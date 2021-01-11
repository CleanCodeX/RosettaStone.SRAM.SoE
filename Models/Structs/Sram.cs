using System.Runtime.InteropServices;
using RosettaStone.Sram.SoE.Constants;

namespace RosettaStone.Sram.SoE.Models.Structs
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Sram
	{
		public ushort Checksum; // Offset 0 (2 Bytes)

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
		public SaveSlot[] SaveSlots; // Offset 2 (3268 = 4* 817 Bytes)

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.SramUnknown1)]
		public byte[] Unknown1; // Offset 3270 (4922 Bytes)
	}
}