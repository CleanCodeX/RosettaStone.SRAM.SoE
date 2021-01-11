using System;

// ReSharper disable InconsistentNaming

namespace RosettaStone.Sram.SoE.Models.Enums
{
	[Flags]
	public enum Unknown13_IvorTowerFlags_Offset3
	{
		AuraReceived = 0b0000_0001, // bit 1,
		AnnihilationAmuletReceived = 0b0000_0010, // bit 2
	}
}