using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Common.Shared.Min.Helpers;
using RosettaStone.Sram.SoE.Constants;
using RosettaStone.Sram.SoE.Enums;
using RosettaStone.Sram.SoE.Helpers;
using RosettaStone.Sram.SoE.Models.Structs;
using SramCommons.Exceptions;
using SramCommons.Extensions;
using SramCommons.Models;

namespace RosettaStone.Sram.SoE.Models
{
	/// <summary>
	/// SramFile implementation for <see cref="SramSoE"/> and <see cref="SaveSlotSoE"/>
	/// </summary>
	public class SramFileSoE : SramFile<SramSoE, SaveSlotSoE>
	{
		private const int BlankFileChecksum = 0xC10F;

		/// <summary>
		/// Checksum validation status of every game
		/// </summary>
		private readonly bool[] _validSaveSlots = new bool[4];

		/// <summary>
		/// The SRAM's file gameRegion 
		/// </summary>
		public GameRegion GameRegion { get; }

		/// <summary>
		/// Creates an instance of <see cref="SramFileSoE" />
		/// </summary>
		/// <param name="buffer"></param>
		/// <param name="gameRegion">The SRAM's file gameRegion</param>
		public SramFileSoE(byte[] buffer, GameRegion gameRegion) : base(buffer, SramOffsets.FirstSaveSlot, 3)
		{
			SizeChecks();
			GameRegion = gameRegion;
		}

		/// <summary>
		/// Creates an instance of <see cref="SramFileSoE" />
		/// </summary>
		/// <param name="stream">The (opened) stream from which the S-RAM buffer and S-RAM structure will be loaded</param>
		/// <param name="gameRegion">The SRAM's file gameRegion</param>
		public SramFileSoE(Stream stream, GameRegion gameRegion) : base(stream, SramOffsets.FirstSaveSlot, 3)
		{
			SizeChecks();
			GameRegion = gameRegion;
		}

		private void SizeChecks()
		{
			Requires.Equal(Marshal.SizeOf<SramSoE>(), SramSizes.Sram, nameof(BufferSize));
			Requires.Equal(Marshal.SizeOf<SaveSlotSoE>(), SramSizes.SaveSlot.All, nameof(SaveSlotSize));

			Debug.Assert(SramSizes.SaveSlot.All == SramSizes.SaveSlot.AllKnown + SramSizes.SaveSlot.AllUnknown);
		}

		/// <summary>
		/// Returns if a save slot index itself is valid and the game's checksum is correct
		/// </summary>
		/// <param name="slotIndex">The index which game's checksum should be checked</param>
		/// <returns>Returns true if the save slot index itself is valid and the checksum for that game is</returns>
		public override bool IsValid(int slotIndex) => base.IsValid(slotIndex) && _validSaveSlots[slotIndex];

		/// <summary>
		/// Loads the entire S-RAM buffer and structure from a stream
		/// </summary>
		/// <param name="stream">The (openned) stream which holds the sram buffer</param>
		public override void Load(Stream stream)
		{
			base.Load(stream);

			var anyIsValid = false;
			for (var slotIndex = 0; slotIndex <= 3; ++slotIndex)
			{
				var fileGameChecksum = GetChecksum(slotIndex);

				var calculatedChecksum = ChecksumHelper.CalcChecksum(Buffer, slotIndex, GameRegion);
				if (fileGameChecksum != calculatedChecksum) continue;

				anyIsValid = true;
				_validSaveSlots[slotIndex] = true;
			}

			if (!anyIsValid)
				throw new InvalidSramFileException(SramError.NoValidSaveSlots);
		}

		/// <summary>
		/// Gets the savegame from S-RAM structure for the given save slot index
		/// </summary>
		/// <param name="slotIndex"></param>
		/// <returns></returns>
		public override SaveSlotSoE GetSaveSlot(int slotIndex)
		{
			ref var saveSlot = ref Sram.SaveSlots[slotIndex];
#if DEBUG
			if (Debugger.IsAttached)
			{
#pragma warning disable IDE0059 // Unnötige Zuweisung eines Werts.
				// ReSharper disable UnusedVariable

				ref var data = ref saveSlot.Data;

				var boyLevel = data.BoyLevel;
				var boyExperience = data.BoyExperience;
				var boyCurrentHp = data.BoyCurrentHp;
				var boyMaxHp = data.BoyMaxHp;
				var boyName = data.BoyName.AsTrimmedString;

				var dogLevel = data.DogLevel;
				var dogExperience = data.DogExperience;
				var dogCurrentHp = data.DogCurrentHp;
				var dogMaxHp = data.DogMaxHp;
				var dogName = data.DogName.AsTrimmedString;

				var alchemies = data.Alchemies.ToString();
				var alchemyMajorLevels = data.AlchemyMajorLevels.ToString();
				var alchemyMinorLevels = data.AlchemyMinorLevels.ToString();
				var charms = data.Charms.ToString();
				var weapons = data.Weapons.ToString();
				var weaponLevels = data.WeaponLevels.ToString();
				var dogAttackLevel = data.DogAttackLevel.ToString();
				var money = data.Moneys.ToString();
				var items = data.Items.ToString();
				var armors = data.Armors.ToString();
				var ammunitions = data.BazookaAmmunitions.ToString();
				var tradeGoods = data.TradeGoods.ToString();

				var unknown1 = data.LastSavePointName.AsTrimmedString;
				var unknown4 = data.Unknown4_BoyBuff.FormatAsString();
				var unknown5 = data.Unknown5.FormatAsString();
				var unknown6 = data.Unknown6.FormatAsString();
				var unknown7 = data.Unknown7_DogBuff.FormatAsString();
				var unknown8 = data.Unknown8.FormatAsString();
				var unknown9 = data.Unknown9.FormatAsString();
				var unknown10 = data.Unknown10.FormatAsString();
				var unknown11 = data.Unknown11.FormatAsString();
				var unknown12A = data.Unknown12A.FormatAsString();
				var unknown12B = data.Unknown12B.ToString();
				var unknown12C = data.Unknown12C.ToString();
				var unknown13 = data.Unknown13.FormatAsString();
				var unknown14 = data.Unknown14.ToString();
				var unknown15 = data.Unknown15.FormatAsString();
				var unknown16A = data.Unknown16A.FormatAsString();
				var unknown16B = data.Unknown16B_GothicaFlags.ToString();
				var unknown16C = data.Unknown16C.FormatAsString();
				var unknown17 = data.Unknown17.FormatAsString();
				var unknown18 = data.Unknown18.FormatAsString();

				// ReSharper restore UnusedVariable
#pragma warning restore IDE0059 // Unnötige Zuweisung eines Werts.
			}
#endif
			return saveSlot;
		}

		/// <summary>
		/// Saves savegame to SaveSlot structure, not to S-RAM buffer. To save to S-RAM buffer call <see cref="Save"> method.
		/// </summary>
		/// <param name="slotIndex">The target save slot index the game is saved to</param>
		/// <param name="slot">The game to be saved</param>
		public override void SetSaveSlot(int slotIndex, SaveSlotSoE slot) => Sram.SaveSlots[slotIndex] = slot;

		/// <summary>
		/// Saves the data of S-RAM structure to S-RAM buffer.
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
				if(Sram.SaveSlots[slotIndex].Checksum != BlankFileChecksum)
					SetChecksum(slotIndex, ChecksumHelper.CalcChecksum(Buffer, slotIndex, GameRegion));
		}

		/// <summary>
		/// Gets the checksum for a save slot index
		/// </summary>
		/// <param name="slotIndex">the save slot index which game's checksum should be returned</param>
		/// <returns>The checksum for the given save slot index</returns>
		public virtual ushort GetChecksum(int slotIndex)
		{
			var offset = FirstSaveSlotOffset + slotIndex * SaveSlotSize + SramOffsets.SaveSlot.Checksum;
			return BitConverter.ToUInt16(Buffer, offset);
		}

		/// <summary>
		/// Sets the checksum for the given save slot index
		/// </summary>
		/// <param name="slotIndex">The save slot index which game's checksum should be set</param>
		/// <param name="checksum">The checksum to be set</param>
		public virtual void SetChecksum(int slotIndex, ushort checksum)
		{
			var offset = FirstSaveSlotOffset + slotIndex * SaveSlotSize + SramOffsets.SaveSlot.Checksum;
			var bytes = BitConverter.GetBytes(checksum);

			Sram.SaveSlots[slotIndex].Checksum = checksum;

			bytes.CopyTo(Buffer, offset);
		}
	}
}