using System.Diagnostics;
using System.Runtime.InteropServices;
using SramCommons.Extensions;

namespace RosettaStone.Sram.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// DogStats2
	/// </summary>
	/// <remarks><see cref="SramSizes.SaveSlot.Chunk15"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct Chunk15
	{
		// Overall boost to Attack statistic from alchemy/items/statuses
		public ushort DogOverallAttackBoost; // [226|xE4] :: (2 bytes)

		// Overall boost to Defense statistic from alchemy/items/statuses
		public ushort DogOverallDefenseBoost; // [228|xE6] :: (2 bytes)

		// Overall boost to Evade % statistic from alchemy/items/statuses
		public ushort DogOverallEvadeBoost; // [230|xE8] :: (2 bytes)

		// Overall boost to Hit % statistic from alchemy/items/statuses
		public ushort DogOverallHitBoost; // [232|xE8] :: (2 bytes)

		// Overall boost to Magic Defense statistic from alchemy/items/statuses(unused)
		public ushort DogOverallMagicDefenseBoost; // [234|xFA] :: (2 bytes)

		// Last damage taken.  Used by time Warp (Horace).
		public ushort DogLastDamageTaken; // [236|xEC] :: (2 bytes)

		// Regenerate (Horace) or Pixie Dust protection in effect (0001 = yes, 0000 = no)
		public ushort DogRegenerateOrPixieDustInEffect; // [238|xEE] :: (2 bytes)

		public override string ToString() => this.FormatAsString();
	}
}