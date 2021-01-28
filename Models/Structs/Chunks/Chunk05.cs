using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SRAM.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// BoyMaxHp
	/// </summary>
	/// <remarks><see cref="SramSizes.SaveSlot.Chunk05"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct Chunk05
	{
		public UInt16 BoyMaxHp;

		public override string ToString() => BoyMaxHp.ToString();
	}
}