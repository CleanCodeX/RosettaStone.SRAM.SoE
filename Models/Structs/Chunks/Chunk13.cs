using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Extensions;
using IO.Models.Structs;

namespace SRAM.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// DogStats1
	/// </summary>
	/// <remarks><see cref="SramSizes.SaveSlot.Chunk13"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Chunk13
	{
		public ushort DogAttack; // [209|xD1] :: (2 bytes)
		public ushort DogDefense;// [211|xD3] :: (2 bytes)
		public ushort DogMagicDefense;// [213|xD5] :: (2 bytes)
		public ushort DogEvadePercent;// [215|xD7] :: (2 bytes)
		public ushort DogHitPercent;// [217|x9D9] :: (2 bytes)
		public ThreeByteUInt Experience; // [219|xDB] :: (3 bytes)

		public override string ToString() => this.FormatAsString();
	}
}