using System.Diagnostics;
using SramCommons.Extensions;

namespace RosettaStone.Sram.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// DogMaxHp
	/// </summary>
	/// <remarks><see cref="SramSizes.SaveSlot.Chunk12"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	public struct Chunk12
	{
		public ushort DogMaxHp; // [207|xCF] :: (2 bytes)

		public override string ToString() => this.FormatAsString();
	}
}