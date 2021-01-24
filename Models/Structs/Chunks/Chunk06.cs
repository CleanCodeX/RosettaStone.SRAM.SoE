using System.Diagnostics;
using SramCommons.Extensions;
using SramCommons.Models.Structs;

namespace RosettaStone.Sram.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// BoyStats1
	/// </summary>
	/// <remarks><see cref="SramSizes.SaveSlot.Chunk6"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	public struct Chunk06
	{
		public ushort BoyAttack; // [144|x90] :: (2 bytes)
		public ushort BoyDefense;// [146|x92] :: (2 bytes)
		public ushort BoyMagicDefense;// [148|x94] :: (2 bytes)
		public ushort BoyEvadePercent;// [150|x96] :: (2 bytes)
		public ushort BoyHitPercent;// [152|x98] :: (2 bytes)
		public ThreeByteUInt BoyExperience; // [154|x9A] :: (3 bytes)

		public override string ToString() => this.FormatAsString();
	}
}