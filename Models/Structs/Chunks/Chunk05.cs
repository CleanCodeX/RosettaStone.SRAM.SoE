using System.Diagnostics;
using SramCommons.Extensions;

namespace RosettaStone.Sram.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// BoyMaxHp
	/// </summary>
	/// <remarks><see cref="SramSizes.SaveSlot.Chunk5"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	public struct Chunk05
	{
		public ushort BoyMaxHp;

		public override string ToString() => this.FormatAsString();
	}
}