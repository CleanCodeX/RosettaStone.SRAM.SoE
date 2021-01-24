using System.Diagnostics;
using System.Runtime.InteropServices;
using SramCommons.Extensions;

namespace RosettaStone.Sram.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// BoyStats2
	/// </summary>
	/// <remarks><see cref="SramSizes.SaveSlot.Chunk08"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct Chunk08
	{
		// Overall boost to Attack statistic from alchemy/items/statuses
		public ushort BoyOverallAttackBoost; // [157|x9D] :: (2 bytes)

		// Overall boost to Defense statistic from alchemy/items/statuses
		public ushort BoyOverallDefenseBoost; // [159|x9F] :: (2 bytes)

		// Overall boost to Evade % statistic from alchemy/items/statuses
		public ushort BoyOverallEvadeBoost; // [161|xA1] :: (2 bytes)

		// Overall boost to Hit % statistic from alchemy/items/statuses
		public ushort BoyOverallHitBoost; // [163|xA3] :: (2 bytes)

		// Overall boost to Magic Defense statistic from alchemy/items/statuses(unused)
		public ushort BoyOverallMagicDefenseBoost; // [165|xA5] :: (2 bytes)

		// Last damage taken.  Used by time Warp (Horace).
		public ushort BoyLastDamageTaken; // [167|xA7] :: (2 bytes)

		// Regenerate (Horace) or Pixie Dust protection in effect (0001 = yes, 0000 = no)
		public ushort BoyRegenerateOrPixieDustInEffect; // [169|xA9] :: (2 bytes)

		public override string ToString() => this.FormatAsString();
	}
}