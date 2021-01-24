// ReSharper disable InconsistentNaming

using System.Runtime.InteropServices;
using IO.Extensions;

namespace SRAM.SoE.Models.Structs
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = SramSizes.SaveSlot.Unknown15)] // 24
	public struct Unknown15
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown15)]
		public byte[] Offset0To23;

		public override string ToString() => this.FormatAsString();
	}
}