using SoE;
using WRAM.Snes9x.SoE.Models;

// ReSharper disable MemberHidesStaticFromOuterClass
// ReSharper disable PossibleLossOfFraction

namespace SRAM.SoE.Models
{
	/// <summary>
	/// Known sizes of SoE's S-RAM buffer
	/// </summary>
	public static class SramSizes
	{
		public const int AudioMode = 1;
		public const int LastSaveSlotId = 1;
		
		public static readonly bool IsValid = All + SaveSlot * 3 + Unknown19 == Size;
		public const int Size = 8192;

		public const int Checksum = 2;
		public const int SaveSlot = WramSizes.AllChunks + Sizes.LastSavePointName + Checksum;

		public static readonly bool SaveSlotIsValid = SaveSlot == 817;

		#region DO NOT RENAME - Accessed by Reflection

		public const int All = AudioMode + LastSaveSlotId + SaveSlot;
		
		public const int AllKnown = All - Sizes.AllUnknown;
		public const int AllUnknown = Sizes.AllUnknown;
		
		public const double UnknownPercentage = AllUnknown * 100D / All;
		public const double KnownPercentage = AllKnown * 100D / All;

		#endregion

		/// Size of the S-RAM Unknown buffer
		public const int Unknown19 = 4922; // Probably no meaning at all
	}
}