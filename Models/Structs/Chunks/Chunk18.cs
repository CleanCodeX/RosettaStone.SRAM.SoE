using System.Diagnostics;
using System.Runtime.InteropServices;
using SoE.Models.Enums;
using SRAM.SoE.Models.Enums.Unknown;
using IO.Extensions;
using SRAM.SoE.Models.Enums;
using SRAM.SoE.Models.Structs.Unknown;

namespace SRAM.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// Alchemies_Charms_Spots_Weapons
	/// </summary>
	/// <remarks><see cref="SramSizes.SaveSlot.Chunk18"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Chunk18
	{
		// Alchemies
		public Alchemies Alchemies; // [503|x1F7] :: (5 bytes)

		// Unknown 14
		public Unknown14 Unknown14; // [508|x1FC] :: (4 bytes) 

		// Charms
		public CharmsAndRareItems CharmsAndRareItems; // [512|x200] :: (4 bytes)

		public GourdSpots GourdSpots; // [516|x204] :: (4 bytes)

		public IngredientSniffSpots IngredientSniffSpots; // [520|x208] :: (89 bytes)

		// Unknown 15 (Ingredients sniff spots?)
		public Unknown15 Unknown15; // [609|x261] :: (24 bytes)

		// Weapons
		public Weapons Weapons; // [633|x279] :: (2 bytes)

		// Unknown 16
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown16A)]
		public byte[] Unknown16A; // [635|x27B] :: (4 bytes) 

		public Unknown16_GothicaFlags Unknown16B_GothicaFlags; // [639|x27F] :: (4 bytes)

		public Unknown16C Unknown16C; // [643|x283] :: (6 bytes) 

		public override string ToString() => this.FormatAsString();
	}
}