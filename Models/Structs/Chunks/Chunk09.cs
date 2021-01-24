using System.Diagnostics;
using SramCommons.Extensions;

namespace RosettaStone.Sram.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// DogCurrentHp
	/// </summary>
	/// <remarks><see cref="SramSizes.SaveSlot.Chunk9"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	public struct Chunk09
	{
		public ushort DogCurrentHp; // [175|xAF] :: (2 bytes)

		public override string ToString() => this.FormatAsString();
	}
}