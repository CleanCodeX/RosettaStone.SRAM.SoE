using System.IO;
using RosettaStone.Sram.SoE.Enums;
using RosettaStone.Sram.SoE.Models.Structs;

namespace RosettaStone.Sram.SoE.Models
{
	/// <summary>
	/// Implementation of SramFileSoE with <see cref="CurrentSaveSlot"/> functionality
	/// </summary>
	public class CurrentSaveSlotSramFileSoE : SramFileSoE
	{
		public CurrentSaveSlotSramFileSoE(Stream stream, GameRegion gameRegion) : base(stream, gameRegion)
		{ }

		private SaveSlotSoE _currentSaveSlot;
		/// <summary>
		/// The current game data
		/// </summary>
		public ref SaveSlotSoE CurrentSaveSlot => ref _currentSaveSlot;

		private int _currentSaveSlotIndex = -1;

		/// <summary>
		/// The current save slot index
		/// Setting the index set sets automatically <see cref="CurrentSaveSlot"/>
		/// </summary>
		public virtual int CurrentSaveSlotIndex
		{
			get => _currentSaveSlotIndex;
			set
			{
				_currentSaveSlotIndex = value;
				_currentSaveSlot = GetSegment(value);
			}
		}

		/// <summary>
		/// Overwrites game data for <see cref="CurrentSaveSlotIndex"/> with modified data from <see cref="CurrentSaveSlot"/>
		/// </summary>
		public virtual void AcceptCurrentSaveSlotChanges() => SetSegment(CurrentSaveSlotIndex, CurrentSaveSlot);

		/// <summary>
		/// Overwrites game data for <see cref="CurrentSaveSlotIndex"/> with original data from <see cref="SramFileSoE.Struct"/> buffer
		/// </summary>
		public virtual void DiscardCurrentSaveSlotChanges() => base.SetSegment(CurrentSaveSlotIndex, Struct.SaveSlots[CurrentSaveSlotIndex]);
	}
}