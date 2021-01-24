// ReSharper disable InconsistentNaming

using System.Runtime.InteropServices;
using SramCommons.Extensions;

namespace RosettaStone.Sram.SoE.Models.Structs
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = SramSizes.SaveSlot.Unknown15)] // 24
	public struct Unknown15
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown15)]
		public byte[] Offset0To23;

		public override string ToString() => this.FormatAsString();
	}
}