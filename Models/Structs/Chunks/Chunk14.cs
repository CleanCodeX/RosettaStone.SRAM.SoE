using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Extensions;

namespace SRAM.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// DogLevel
	/// </summary>
	/// <remarks><see cref="SramSizes.SaveSlot.Chunk14"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Chunk14
	{
		public ushort DogLevel; // [222|xDE] :: (2 bytes)
		public ushort DogMaxChargeup; // [224|xE0] :: (2 bytes)

		public override string ToString() => this.FormatAsString();
	}
}