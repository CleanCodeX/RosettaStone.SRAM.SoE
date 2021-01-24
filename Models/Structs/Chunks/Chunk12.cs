using System.Diagnostics;
using System.Runtime.InteropServices;
using SramCommons.Extensions;

namespace RosettaStone.Sram.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// DogMaxHp
	/// </summary>
	/// <remarks><see cref="SramSizes.SaveSlot.Chunk12"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct Chunk12
	{
		public ushort DogMaxHp; // [207|xCF] :: (2 bytes)

		public override string ToString() => this.FormatAsString();
	}
}