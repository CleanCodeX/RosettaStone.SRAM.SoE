using System;

// ReSharper disable InconsistentNaming

namespace SramFormat.SoE.Models.Enums
{
	[Flags]
	public enum Unknown14_AntiquaFlags : uint
	{
		AnnihilationAmuletMerchantScrewed = 0x40 // Merchant for annihilation amulett blocked "you're too screwed"
	}
}