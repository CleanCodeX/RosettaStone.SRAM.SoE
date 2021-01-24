using System.Runtime.InteropServices;
using SRAM.SoE.Models.Enums.Unknown;
using IO.Extensions;

namespace SRAM.SoE.Models.Structs
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = SramSizes.SaveSlot.Unknown16C)] // 6
	public struct Unknown16C
	{
		public Unknown16C_Offset1 Offset0;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
		public byte[] Offset1To5;

		public override string ToString() => this.FormatAsString();
	}
}
