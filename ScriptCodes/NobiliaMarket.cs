using System;
using System.Diagnostics;

namespace SramFormat.SoE.ScriptCodes
{
	/// <summary>
	/// Code routines of Nobilia market merchants
	/// </summary>
	internal abstract class NobiliaMarket
	{
		private protected abstract ushort SelectionDialog(params string[] texts);
		private protected abstract void Dialog(params string[] texts);
		private protected abstract void PlaySound(int code);

		private ushort _v2262_charms = 0;
		private ushort _v228b_TalkedToPersons = 0;
		private ushort _v2527_OwnedRice = 0; // Amount of owned Rice
		private ushort _v243d_UnknownStatusMaybe = 0;
		private ushort _v251b_OwnedPots = 0; // Previously owned pots
		private ushort _v285d_Unknown = 0; // What does it do? 
		private ushort _jewels = 0; // What does it do? 

		/// <summary>
		/// Most relevant code for talking to Ceramic Pot merchant
		/// </summary>
		private void TalkToCeramicPotsMerchant()
		{
			var rand = new Random();
			const byte flagCeramicPotMerchant = 0x10;

			if ((_v228b_TalkedToPersons & flagCeramicPotMerchant) > 0)
				Dialog("Would you like some ceramic pots? They're only 2 bags of rice each.");
			else
			{
				Dialog("What you need, my friend, is ceramic pots. They're a classic design, very durable and priced to move only 2 bags of rice per pot.");
				_v228b_TalkedToPersons |= flagCeramicPotMerchant;
			}

			var v289f_WannaBuyPots = SelectionDialog("What do you say?", "I'm sold!", "I'll pass.");
			var v285b_PotsToBuy = 0x0000; // initial set to zero
			ushort v289d_HowManyPots;

			if (v289f_WannaBuyPots != 0)
			{
				v289d_HowManyPots = SelectionDialog("How many?", "One.", "Five.", "Ten.");

				if (v289d_HowManyPots == 0)
					v285b_PotsToBuy = 0x0001;  // (1 pot)
				else if (v289d_HowManyPots == 1)
					v285b_PotsToBuy = 0x0005; // (5 pots)
				else if (v289d_HowManyPots == 2)
					v285b_PotsToBuy = 0x000a; // (10 pots)
				else
					CancelDialog();
			}

			if (v285b_PotsToBuy != 0)
			{
				if (_v2527_OwnedRice < (v285b_PotsToBuy * 2))
				{
					_v243d_UnknownStatusMaybe = 0x0000;
					Dialog(" Can't buy (not enough rice)");
				}
				else if ((_v251b_OwnedPots + v285b_PotsToBuy) > 0x63) // Max 99 items check
				{
					_v243d_UnknownStatusMaybe = 0x0002;
					Dialog("Can't buy (inventory full)");
				}
				else
				{
					PlaySound(0x40);
					Dialog("It's a deal. Thank you very much.");

					_v2527_OwnedRice = (ushort)(_v2527_OwnedRice - (v285b_PotsToBuy * 2));
					_v251b_OwnedPots = (ushort)(_v251b_OwnedPots + v285b_PotsToBuy);

					goto BuySuccess;
				}
			}

			CancelDialog();

			return;

		BuySuccess:

			Debug.Print("UNTRACED INSTR for script caller (0x08)");

			// Subroutine
			void CancelDialog()
			{
				var arg0 = rand.Next(0, 15);
				if (arg0 == 4)
					Dialog("Kids... Always looking, never buying.");
				else if (arg0 == 8)
					Dialog("How can you pass up my deals?");
				else if (arg0 == 7)
					Dialog("Yeesh... Tourists!");
				else if (arg0 > 12)
					Dialog("Fine... Have a nice day!");
				else
					Dialog("OK. Maybe some other time.");

				arg0 = rand.Next(0, 8);

				if (arg0 == 5)
					Dialog("Now please make room for paying customers.");
			}

			if (_v251b_OwnedPots > (_v285d_Unknown + 6)) // more than 6 (not 5 [!]) pots buyed (option 10)
				// Reusage of dialog response variable!
				v289d_HowManyPots = (ushort)rand.Next(0, 15); // 1/16 chance (0-15)
			else if (_v251b_OwnedPots > (_v285d_Unknown + 1)) // more than 1 pot buyed (option 5)
				// Reusage of dialog response variable!
				v289d_HowManyPots = (ushort)rand.Next(0, 7); // 1/8 chance (0-7)
			else
				// Reusage of dialog response variable!
				v289d_HowManyPots = 15; // Means there is never a chance to find something

			if (v289d_HowManyPots < 3) // (0,1,2) means 3/16 or 3/8 chance of finding something
			{
				Debug.Print("Stop/disable boy (and SELECT button)");
				Debug.Print("MAKE boy FACE SOUTH");
				Debug.Print("YIELD (break out of script loop, continue later)"); // Probably necessary for calling global script 0x09
				Debug.Print("CALL Unnamed Global script 0x09"); // What's that?

				Dialog("Hey! One of these ceramic pots has something in it!");

				const uint flagMagicGourd = 0x4;
				const uint flagChocoboEgg = 0x40;

				if ((_v2262_charms & flagMagicGourd) == 0)
				{
					if ((_v2262_charms & flagChocoboEgg) == 0)
					{
						var tmp = rand.Next(0, 15);
						if (tmp == 7)
						{
							_v243d_UnknownStatusMaybe = 2;
							Dialog("Found the Chocobo Egg.");
						}
						else
						{
							_jewels += 10;
							Dialog("Found 10 Jewels.");
						}
					}
					else // 2 branches with same content
					{
						_jewels += 50;
						Dialog("Found 50 Jewels.");
					}
				}
				else // 2 branches with same content
				{
					_jewels += 50;
					Dialog("Found 50 Jewels.");
				}
			}

			Debug.Print("BOY = Player controlled");
		}
	}
}
