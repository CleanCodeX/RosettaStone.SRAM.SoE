using System.Diagnostics;
using System.Runtime.InteropServices;
using SramCommons.Extensions;

namespace RosettaStone.Sram.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// BoyMaxHp
	/// </summary>
	/// <remarks><see cref="SramSizes.SaveSlot.Chunk05"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct Chunk05
	{
		public ushort BoyMaxHp;

		public override string ToString() => this.FormatAsString();
	}
}