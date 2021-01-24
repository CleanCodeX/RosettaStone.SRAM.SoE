using System.IO;
using SoE.Models.Enums;
using SRAM.SoE.Models.Structs;

namespace SRAM.SoE.Models
{
	/// <summary>
	/// Implementation of SramFileSoE with <see cref="CurrentSaveSlot"/> functionality
	/// </summary>
	public class CurrentSaveSlotSramFileSoE : SramFileSoE
	{
		public CurrentSaveSlotSramFileSoE(Stream stream, GameRegion region) : base(stream, region)
		{ }

		private SaveSlotSoE _currentSaveSlot;
		/// <summary>
		/// The current game data
		/// </summary>
		public ref SaveSlotSoE CurrentSaveSlot => ref _currentSaveSlot;

		private int _currentSaveSlotIndex = -1;

		/// <summary>
		/// The current save slot index
		/// Setting the index sets automatically <see cref="CurrentSaveSlot"/>
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
		/// Overwrites save slot for <see cref="CurrentSaveSlotIndex"/> with modified data from <see cref="CurrentSaveSlot"/>
		/// </summary>
		public virtual void AcceptCurrentSaveSlotChanges() => SetSegment(CurrentSaveSlotIndex, CurrentSaveSlot);

		/// <summary>
		/// Overwrites save slot for <see cref="CurrentSaveSlotIndex"/> with original data from <see cref="SramFileSoE.Struct"/> buffer
		/// </summary>
		public virtual void DiscardCurrentSaveSlotChanges() => base.SetSegment(CurrentSaveSlotIndex, Struct.SaveSlots[CurrentSaveSlotIndex]);
	}
}