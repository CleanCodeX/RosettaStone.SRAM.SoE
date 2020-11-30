using System;

// ReSharper disable InconsistentNaming

namespace SramFormat.SoE.Models.Enums
{
	[Flags]
	public enum Unknown16C_Offset1 : byte
	{
		Bit1 = 0x1,
		Bit2 = 0x2,
		Bit3 = 0x4,
		Bit4 = 0x8,

		Bit5 = 0x10,
		Bit6 = 0x20,
		Bit7 = 0x40,
		Bit8 = 0x80,
		All = 255
	}
}