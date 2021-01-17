using System.Runtime.InteropServices;
using RosettaStone.Sram.SoE.Constants;

namespace RosettaStone.Sram.SoE.Models.Structs
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct SramSoE
	{
		public byte AudioMode; // Offset 0 (1 byte)
		public byte LastSaveslotId; // Offset 1 (1 byte)

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
		public SaveSlotSoE[] SaveSlots; // Offset 2 (3268 = 4* 817 Bytes)

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.Unknown1)]
		public byte[] Unknown1; // Offset 3270 (4922 Bytes)
	}
}