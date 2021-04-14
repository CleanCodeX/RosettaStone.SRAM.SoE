using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Common.Shared.Min.Helpers;
using SoE;
using SoE.Models.Enums;
using SRAM.Models;
using SRAM.SoE.Helpers;
using SRAM.SoE.Models.Structs;

namespace SRAM.SoE.Models
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
		private readonly bool[] _isDirty = new bool[4];

		/// <summary>
		/// The S-RAM's file region 
		/// </summary>
		public GameRegion GameRegion { get; }

		/// <summary>
		/// Creates an instance of <see cref="SramFileSoE" />
		/// </summary>
		/// <param name="buffer"></param>
		/// <param name="region">The S-RAM's file region</param>
		public SramFileSoE(byte[] buffer, GameRegion region) : base(buffer, SramOffsets.FirstSaveSlot, 3) => GameRegion = region;

		/// <summary>
		/// Creates an instance of <see cref="SramFileSoE" />
		/// </summary>
		/// <param name="stream">The (opened) stream from which the S-RAM buffer and S-RAM structure will be loaded</param>
		/// <param name="region">The S-RAM's file region</param>
		public SramFileSoE(Stream stream, GameRegion region) : base(stream, SramOffsets.FirstSaveSlot, 3) => GameRegion = region;

		/// <summary>
		/// Creates an instance of <see cref="SramFileSoE" />
		/// </summary>
		/// <param name="region">The S-RAM's file region</param>
		public SramFileSoE(GameRegion region) : base(SramOffsets.FirstSaveSlot, 3) => GameRegion = region;

		protected override void OnLoading() => SizeChecks();

		private void SizeChecks()
		{
			Requires.True(SramSizes.SaveSlotIsValid, nameof(Sizes));
			Requires.True(SramSizes.IsValid, nameof(SramSizes));
			
			StructSizeValidator.Validate();

			Requires.Equal(Marshal.SizeOf<SramSoE>(), SramSizes.Size, nameof(Size));
			Requires.Equal(Marshal.SizeOf<SaveSlotSoE>(), SramSizes.SaveSlot, nameof(SegmentSize));
		}

		/// <summary>
		/// Returns if a save slot index itself is valid and the game's checksum is correct
		/// </summary>
		/// <param name="index">The index which game's checksum should be checked</param>
		/// <returns>Returns true if the save slot index itself is valid and the checksum for that game is</returns>
		public override bool IsValid(int index) => base.IsValid(index) && _validSaveSlots[index];

		/// <summary>
		/// Loads the entire S-RAM buffer and structure from a stream
		/// </summary>
		/// <param name="stream">The (openned) stream which holds the sram buffer</param>
		public override void Load(Stream stream)
		{
			base.Load(stream);

			for (var index = 0; index <= 3; ++index)
			{
				var fileChecksum = GetChecksum(index);

				var calculatedChecksum = ChecksumHelper.CalcChecksum(Buffer, index, GameRegion);
				_validSaveSlots[index] = fileChecksum == calculatedChecksum;
			}
		}

		/// <summary>
		/// Gets the savegame from S-RAM structure for the given save slot index
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		public override SaveSlotSoE GetSegment(int index)
		{
			ref var saveSlot = ref Struct.SaveSlots[index];
#if DEBUG
			if (Debugger.IsAttached)
			{
#pragma warning disable IDE0059 // Unnötige Zuweisung eines Werts.
				// ReSharper disable UnusedVariable

				ref var data = ref saveSlot.Data;

				// ReSharper restore UnusedVariable
#pragma warning restore IDE0059 // Unnötige Zuweisung eines Werts.
			}
#endif
			return saveSlot;
		}

		/// <summary>
		/// Saves savegame to SaveSlot structure, not to S-RAM buffer. To save to S-RAM buffer call <see cref="Save" /> method.
		/// </summary>
		/// <param name="index">The target save slot index the game is saved to</param>
		/// <param name="slot">The game to be saved</param>
		public override void SetSegment(int index, SaveSlotSoE slot)
		{
			Struct.SaveSlots[index] = slot;
			_isDirty[index] = true;
		}

		/// <summary>
		/// Saves the data of S-RAM structure to S-RAM buffer.
		/// </summary>
		/// <param name="stream"></param>
		public override void Save(Stream stream)
		{
			for (var index = 0; index <= 3; ++index)
				if(_isDirty[index])
					base.SetSegment(index, Struct.SaveSlots[index]);

			base.Save(stream);
		}

		protected override void OnSaving()
		{
			for (var index = 0; index <= 3; ++index)
				if(Struct.SaveSlots[index].Checksum != BlankFileChecksum)
					SetChecksum(index, ChecksumHelper.CalcChecksum(Buffer, index, GameRegion));
		}

		/// <summary>
		/// Gets the checksum for a save slot index
		/// </summary>
		/// <param name="index">the save slot index which game's checksum should be returned</param>
		/// <returns>The checksum for the given save slot index</returns>
		public virtual ushort GetChecksum(int index)
		{
			var offset = FirstSegmentOffset + index * SegmentSize;
			return BitConverter.ToUInt16(Buffer, offset);
		}

		/// <summary>
		/// Sets the checksum for the given save slot index
		/// </summary>
		/// <param name="index">The save slot index which game's checksum should be set</param>
		/// <param name="checksum">The checksum to be set</param>
		public virtual void SetChecksum(int index, ushort checksum)
		{
			var offset = FirstSegmentOffset + index * SegmentSize;
			var bytes = BitConverter.GetBytes(checksum);

			Struct.SaveSlots[index].Checksum = checksum;

			bytes.CopyTo(Buffer, offset);
		}
	}
}