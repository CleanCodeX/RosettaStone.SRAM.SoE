using System.Runtime.InteropServices;
using IO.Extensions;
using IO.Helpers;

namespace SRAM.SoE.Models.Structs
{
	/// <summary>
	/// The S-RAM structure containing all saveslot data 
	/// </summary>
	/// <remarks>8192 bytes (8 KiB)</remarks>
	[ContainsComplexStructures]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct SramSoE
	{
		public byte AudioMode; // Offset [0] (1 byte)
		public byte LastSaveslotId; // Offset [1] (1 byte)

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
		public SaveSlotSoE[] SaveSlots; // Offset [2] (3268 = 4* 817 Bytes)

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.Unknown19)]
		public byte[] Unknown19; // Offset [3270|xCC6] (4922 Bytes)

		public override string ToString() => this.FormatAsString();
	}
}