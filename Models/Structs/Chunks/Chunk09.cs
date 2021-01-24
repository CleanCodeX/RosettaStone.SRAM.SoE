using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Extensions;

namespace SRAM.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// DogCurrentHp
	/// </summary>
	/// <remarks><see cref="SramSizes.SaveSlot.Chunk09"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct Chunk09
	{
		public ushort DogCurrentHp; // [175|xAF] :: (2 bytes)

		public override string ToString() => this.FormatAsString();
	}
}