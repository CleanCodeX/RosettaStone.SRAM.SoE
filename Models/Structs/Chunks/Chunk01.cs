using System.Diagnostics;
using SramCommons.Extensions;

namespace RosettaStone.Sram.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// BoyNameDogName
	/// </summary>
	/// <remarks><see cref="SramSizes.SaveSlot.Chunk01"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	public struct Chunk01
	{
		public FixedLengthString BoyName; // [36|x26] (36 bytes)
		public FixedLengthString DogName; // [74|x4A] (36 bytes)

		public override string ToString() => this.FormatAsString();
	}
}