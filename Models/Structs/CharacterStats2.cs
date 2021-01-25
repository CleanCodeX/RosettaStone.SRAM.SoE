using System;
using System.Runtime.InteropServices;
using IO.Extensions;
// ReSharper disable BuiltInTypeReferenceStyle

namespace SRAM.SoE.Models.Structs
{
	/// <summary>
	/// Second chunk of bundled CharacterStats
	/// </summary>
	/// <remarks>14 Bytes</remarks>
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct CharacterStats2
	{
		// Overall boost to Attack statistic from alchemy/items/statuses
		public UInt16 OverallAttackBoost; // (2 bytes)

		// Overall boost to Defense statistic from alchemy/items/statuses
		public UInt16 OverallDefenseBoost; // (2 bytes)

		// Overall boost to Evade % statistic from alchemy/items/statuses
		public UInt16 OverallEvadeBoost; // (2 bytes)

		// Overall boost to Hit % statistic from alchemy/items/statuses
		public UInt16 OverallHitBoost; // (2 bytes)

		// Overall boost to Magic Defense statistic from alchemy/items/statuses(unused)
		public UInt16 OverallMagicDefenseBoost; // (2 bytes)

		// Last damage taken.  Used by time Warp (Horace).
		public UInt16 LastDamageTaken; // (2 bytes)

		// Regenerate (Horace) or Pixie Dust protection in effect (0001 = yes, 0000 = no)
		public UInt16 RegenerateOrPixieDustInEffect; // (2 bytes)

		public override string ToString() => this.FormatAsString();
	}
}
