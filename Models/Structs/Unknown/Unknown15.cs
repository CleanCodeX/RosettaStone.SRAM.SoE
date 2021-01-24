// ReSharper disable InconsistentNaming

using System.Runtime.InteropServices;
using RosettaStone.Sram.SoE.Models.Enums.Unknown;
using SramCommons.Extensions;

namespace RosettaStone.Sram.SoE.Models.Structs
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = SramSizes.SaveSlot.Unknown15)] // 118
	public struct Unknown15
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 17)] 
		public byte[] Offset0To16;

		public Unknown15_IvorTowerFlags_Offset17 Offset17; // 1
		public Unknown15_IvorTowerFlags_Offset18 Offset18; // 1
		public Unknown15_IvorTowerFlags_Offset19 Offset19; // 1
		public Unknown15_IvorTowerFlags_Offset20 Offset20; // 1
		public byte Offset21; 
		public byte Offset22; 
		public byte Offset23; 
		public Unknown15_IvorTowerFlags_Offset24 Offset24; // 1

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 93)]
		public byte[] Offset25To117;

		public override string ToString() => this.FormatAsString();
	}
}