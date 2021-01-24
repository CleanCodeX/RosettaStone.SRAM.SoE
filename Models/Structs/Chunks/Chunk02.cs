using System.Diagnostics;
using SramCommons.Extensions;

namespace RosettaStone.Sram.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// BoyCurrentHp
	/// </summary>
	/// <remarks><see cref="SramSizes.SaveSlot.Chunk2"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	public struct Chunk02
	{
		public ushort BoyCurrentHp; // [110|x69] :: (2 bytes)

		public override string ToString() => this.FormatAsString();
	}
}