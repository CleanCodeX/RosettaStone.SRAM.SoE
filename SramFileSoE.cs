using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Common.Shared.Min.Helpers;
using SramCommons.Exceptions;
using SramCommons.Extensions;
using SramCommons.Models;
using SramFormat.SoE.Constants;
using SramFormat.SoE.Enums;
using SramFormat.SoE.Helpers;
using SramFormat.SoE.Models.Structs;

namespace SramFormat.SoE
{
	/// <summary>
	/// SramFile implementation for <see cref="Sram"/> and <see cref="SaveSlot"/>
	/// </summary>
	public class SramFileSoE : SramFile<Sram, SaveSlot>
	{
		/// <summary>
		/// Checksum validation status of every game
		/// </summary>
		private readonly bool[] _validSaveSlots = new bool[4];

		/// <summary>
		/// The SRAM's file gameRegion 
		/// </summary>
		public GameRegion GameRegion { get; }

		/// <summary>
		/// Creates an instance of SramFileSoE
		/// </summary>
		/// <param name="stream">The (opened) stream from which the Sram buffer and Sram structure will be loaded</param>
		/// <param name="gameRegion">The SRAM's file gameRegion</param>
		public SramFileSoE(Stream stream, GameRegion gameRegion) : base(stream, Offsets.FirstSaveSlot, 3)
		{
			Requires.Equal(Marshal.SizeOf<Sram>(), Sizes.Sram, nameof(SramSize));
			Requires.Equal(Marshal.SizeOf<SaveSlot>(), Sizes.SaveSlot.All, nameof(SaveSlotSize));

			Debug.Assert(Sizes.SaveSlot.All == Sizes.SaveSlot.AllKnown + Sizes.SaveSlot.AllUnknown);

			GameRegion = gameRegion;
		}

		/// <summary>
		/// Returns if a save slot index itself is valid and the game's checksum is correct
		/// </summary>
		/// <param name="slotIndex">The index which game's checksum should be checked</param>
		/// <returns>Returns true if the save slot index itself is valid and the checksum for that game is</returns>
		public override bool IsValid(int slotIndex) => base.IsValid(slotIndex) && _validSaveSlots[slotIndex];

		/// <summary>
		/// Loads the entire Sram buffer and structure from a stream
		/// </summary>
		/// <param name="stream">The (openned) stream which holds the sram buffer</param>
		public override void Load(Stream stream)
		{
			base.Load(stream);

			var anyIsValid = false;
			for (var slotIndex = 0; slotIndex <= 3; ++slotIndex)
			{
				var fileGameChecksum = GetChecksum(slotIndex);

				var calculatedChecksum = ChecksumHelper.CalcChecksum(SramBuffer, slotIndex, GameRegion);
				if (fileGameChecksum != calculatedChecksum) continue;

				anyIsValid = true;
				_validSaveSlots[slotIndex] = true;
			}

			if (!anyIsValid)
				throw new InvalidSramFileException(SramError.NoValidSaveSlots);
		}

		/// <summary>
		/// Gets the game from Sram structure for the given save slot index
		/// </summary>
		/// <param name="slotIndex"></param>
		/// <returns></returns>
		public override SaveSlot GetSaveSlot(int slotIndex)
		{
			ref var game = ref Sram.SaveSlots[slotIndex];
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
				var unknown12C = game.Unknown12C.ToString();
				var unknown13 = game.Unknown13.FormatAsString();
				var unknown14 = game.Unknown14.ToString();
				var unknown15 = game.Unknown15.FormatAsString();
				var unknown16A = game.Unknown16A.FormatAsString();
				var unknown16B = game.Unknown16B_GothicaFlags.ToString();
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
		/// Saves game to SaveSlot structure, not not to Sram buffer. To save to sram buffer call Save method.
		/// </summary>
		/// <param name="slotIndex">The target save slot index the game is saved to</param>
		/// <param name="slot">The game to be saved</param>
		public override void SetSaveSlot(int slotIndex, SaveSlot slot) => Sram.SaveSlots[slotIndex] = slot;

		/// <summary>
		/// Saves the data of Sram structure to Sram buffer.
		/// </summary>
		/// <param name="stream"></param>
		public override void Save(Stream stream)
		{
			for (var slotIndex = 0; slotIndex <= 3; ++slotIndex)
				if (IsValid(slotIndex))
					base.SetSaveSlot(slotIndex, Sram.SaveSlots[slotIndex]);

			base.Save(stream);
		}

		protected override void OnRawSave()
		{
			for (var slotIndex = 0; slotIndex <= 3; ++slotIndex)
				SetChecksum(slotIndex, ChecksumHelper.CalcChecksum(SramBuffer, slotIndex, GameRegion));
		}

		/// <summary>
		/// Gets the checksum for a save slot index
		/// </summary>
		/// <param name="slotIndex">the save slot index which game's checksum should be returned</param>
		/// <returns>The checksum for the given save slot index</returns>
		public virtual ushort GetChecksum(int slotIndex)
		{
			var offset = FirstSaveSlotOffset + slotIndex * SaveSlotSize + Offsets.SaveSlot.Checksum;
			return BitConverter.ToUInt16(SramBuffer, offset);
		}

		/// <summary>
		/// Sets the checksum for the given save slot index
		/// </summary>
		/// <param name="slotIndex">The save slot index which game's checksum should be set</param>
		/// <param name="checksum">The checksum to be set</param>
		public virtual void SetChecksum(int slotIndex, ushort checksum)
		{
			var offset = FirstSaveSlotOffset + slotIndex * SaveSlotSize + Offsets.SaveSlot.Checksum;
			var bytes = BitConverter.GetBytes(checksum);

			Sram.SaveSlots[slotIndex].Checksum = checksum;

			bytes.CopyTo(SramBuffer, offset);
		}
	}
}