using System.Runtime.InteropServices;
using SramCommons.Extensions;

namespace RosettaStone.Sram.SoE.Models.Structs
{
	/// <summary>
	/// CharacterStats2
	/// </summary>
	/// <remarks>14 Bytes</remarks>
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct CharacterStats2
	{
		// Overall boost to Attack statistic from alchemy/items/statuses
		public ushort OverallAttackBoost; // (2 bytes)

		// Overall boost to Defense statistic from alchemy/items/statuses
		public ushort OverallDefenseBoost; // (2 bytes)

		// Overall boost to Evade % statistic from alchemy/items/statuses
		public ushort OverallEvadeBoost; // (2 bytes)

		// Overall boost to Hit % statistic from alchemy/items/statuses
		public ushort OverallHitBoost; // (2 bytes)

		// Overall boost to Magic Defense statistic from alchemy/items/statuses(unused)
		public ushort OverallMagicDefenseBoost; // (2 bytes)

		// Last damage taken.  Used by time Warp (Horace).
		public ushort LastDamageTaken; // (2 bytes)

		// Regenerate (Horace) or Pixie Dust protection in effect (0001 = yes, 0000 = no)
		public ushort RegenerateOrPixieDustInEffect; // (2 bytes)

		public override string ToString() => this.FormatAsString();
	}
}
