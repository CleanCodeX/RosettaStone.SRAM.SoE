using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Common.Shared.Min.Helpers;
using SramCommons.Exceptions;
using SramCommons.Extensions;
using SramCommons.Models;
using SramFormat.SoE.Constants;
using SramFormat.SoE.Helpers;
using SramFormat.SoE.Models.Enums;
using SramFormat.SoE.Models.Structs;

namespace SramFormat.SoE
{
	/// <summary>
	/// SramFile implementation for <see cref="Sram"/> and <see cref="SramGame"/>
	/// </summary>
	public class SramFileSoE : SramFile<Sram, SramGame>
	{
		/// <summary>
		/// Checksum validation status of every game
		/// </summary>
		private readonly bool[] _validGames = new bool[4];

		/// <summary>
		/// The SRAM's file region 
		/// </summary>
		public FileRegion Region { get; }

		/// <summary>
		/// Creates an instance of SramFileSoE
		/// </summary>
		/// <param name="stream">The (opened) stream from which the Sram buffer and Sram structure will be loaded</param>
		/// <param name="region">The SRAM's file region</param>
		public SramFileSoE(Stream stream, FileRegion region) : base(stream, Offsets.FirstGame, 3)
		{
			Requires.Equal(Marshal.SizeOf<Sram>(), Sizes.Sram, nameof(SramSize));
			Requires.Equal(Marshal.SizeOf<SramGame>(), Sizes.Game.All, nameof(GameSize));

			Debug.Assert(Sizes.Game.All == Sizes.Game.AllKnown + Sizes.Game.AllUnknown);

			Region = region;
		}

		/// <summary>
		/// Returns if a game index itself is valid and the game's checksum is correct
		/// </summary>
		/// <param name="gameIndex">The index which game's checksum should be checked</param>
		/// <returns>Returns true if the game index itself is valid and the checksum for that game is</returns>
		public override bool IsValid(int gameIndex) => base.IsValid(gameIndex) && _validGames[gameIndex];

		/// <summary>
		/// Loads the entire Sram buffer and structure from a stream
		/// </summary>
		/// <param name="stream">The (openned) stream which holds the sram buffer</param>
		public override void Load(Stream stream)
		{
			base.Load(stream);

			var anyGameIsValid = false;
			for (var gameIndex = 0; gameIndex <= 3; ++gameIndex)
			{
				var fileGameChecksum = GetChecksum(gameIndex);

				var calculatedChecksum = ChecksumHelper.CalcChecksum(SramBuffer, gameIndex, Region);
				if (fileGameChecksum != calculatedChecksum) continue;

				anyGameIsValid = true;
				_validGames[gameIndex] = true;
			}

			if (!anyGameIsValid)
				throw new InvalidSramFileException(SramError.NoValidGames);
		}

		/// <summary>
		/// Gets the game from Sram structure for the given game index
		/// </summary>
		/// <param name="gameIndex"></param>
		/// <returns></returns>
		public override SramGame GetGame(int gameIndex)
		{
			ref var game = ref Sram.Game[gameIndex];
#if DEBUG
			if (Debugger.IsAttached)
			{
#pragma warning disable IDE0059 // Unnötige Zuweisung eines Werts.
				// ReSharper disable UnusedVariable

				var boyLevel = game.BoyLevel;
				var boyExperience = game.BoyExperience;
				var boyCurrentHp = game.BoyCurrentHp;
				var boyMaxHp = game.BoyMaxHp;
				var boyName = game.BoyName.StringValue;

				var dogLevel = game.DogLevel;
				var dogExperience = game.DogExperience;
				var dogCurrentHp = game.DogCurrentHp;
				var dogMaxHp = game.DogMaxHp;
				var dogName = game.DogName.StringValue;

				var alchemies = game.Alchemies.ToString();
				var alchemyMajorLevels = game.AlchemyMajorLevels.ToString();
				var alchemyMinorLevels = game.AlchemyMinorLevels.ToString();
				var charms = game.Charms.ToString();
				var weapons = game.Weapons.ToString();
				var weaponLevels = game.WeaponLevels.ToString();
				var dogAttackLevel = game.DogAttackLevel.ToString();
				var money = game.Moneys.ToString();
				var items = game.Items.ToString();
				var armors = game.Armors.ToString();
				var ammunitions = game.BazookaAmmunitions.ToString();
				var tradeGoods = game.TradeGoods.ToString();

				var unknown1 = game.Unknown1.FormatAsString();
				var unknown2 = game.Unknown2.FormatAsString();
				var unknown3 = game.Unknown3.FormatAsString();
				var unknown4 = game.Unknown4_BoyBuff.FormatAsString();
				var unknown5 = game.Unknown5.FormatAsString();
				var unknown6 = game.Unknown6.FormatAsString();
				var unknown7 = game.Unknown7_DogBuff.FormatAsString();
				var unknown8 = game.Unknown8.FormatAsString();
				var unknown9 = game.Unknown9.FormatAsString();
				var unknown10 = game.Unknown10.FormatAsString();
				var unknown11 = game.Unknown11.FormatAsString();
				var unknown12A = game.Unknown12A.FormatAsString();
				var unknown12B = game.Unknown12B.ToString();
				var unknown12C = game.Unknown12C.FormatAsString();
				var unknown13 = game.Unknown13.FormatAsString();
				var unknown14 = game.Unknown14_AntiquaFlags.ToString();
				var unknown15 = game.Unknown15.FormatAsString();
				var unknown16A = game.Unknown16A.FormatAsString();
				var unknown16B = game.Unknown16B_GoticaFlags.ToString();
				var unknown16C = game.Unknown16C.FormatAsString();
				var unknown17 = game.Unknown17.FormatAsString();
				var unknown18 = game.Unknown18.FormatAsString();

				// ReSharper restore UnusedVariable
#pragma warning restore IDE0059 // Unnötige Zuweisung eines Werts.
			}
#endif
			return game;
		}

		/// <summary>
		/// Saves game to SramGame structure, not not to Sram buffer. To save to sram buffer call Save method.
		/// </summary>
		/// <param name="gameIndex">The target game index the game is saved to</param>
		/// <param name="game">The game to be saved</param>
		public override void SetGame(int gameIndex, SramGame game) => Sram.Game[gameIndex] = game;

		/// <summary>
		/// Saves the data of Sram structure to Sram buffer.
		/// </summary>
		/// <param name="stream"></param>
		public override void Save(Stream stream)
		{
			for (var gameIndex = 0; gameIndex <= 3; ++gameIndex)
				if (IsValid(gameIndex))
				{
					base.SetGame(gameIndex, Sram.Game[gameIndex]);
					SetChecksum(gameIndex, ChecksumHelper.CalcChecksum(SramBuffer, gameIndex, Region));
				}

			base.Save(stream);
		}

		/// <summary>
		/// Gets the checksum for a game index
		/// </summary>
		/// <param name="gameIndex">the game index which game's checksum should be returned</param>
		/// <returns>The checksum for the given game index</returns>
		public virtual ushort GetChecksum(int gameIndex)
		{
			var offset = FirstGameOffset + gameIndex * GameSize + Offsets.Game.Checksum;
			return BitConverter.ToUInt16(SramBuffer, offset);
		}

		/// <summary>
		/// Sets the checksum for the given game index
		/// </summary>
		/// <param name="gameIndex">The game index which game's checksum should be set</param>
		/// <param name="checksum">The checksum to be set</param>
		public virtual void SetChecksum(int gameIndex, ushort checksum)
		{
			var offset = FirstGameOffset + gameIndex * GameSize + Offsets.Game.Checksum;
			var bytes = BitConverter.GetBytes(checksum);
			Array.Reverse(bytes);
			checksum = BitConverter.ToUInt16(bytes);

			Sram.Game[gameIndex].Checksum = checksum;

			bytes.CopyTo(SramBuffer, offset);
		}
	}
}