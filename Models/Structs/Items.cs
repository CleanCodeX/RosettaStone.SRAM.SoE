using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Extensions;

namespace SRAM.SoE.Models.Structs
{
	/// <summary>
	/// The items the boy can hold
	/// </summary>
	/// <remarks>8 bytes</remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct Items
	{
		// Items
		public byte Petal; // 0 - 6
		public byte Nectar; // 0 - 6
		public byte Honey; // 0 - 6
		public byte DogBiscuit; // 0 - 6
		public byte Wings; // 0 - 6
		public byte Essence; // 0 - 6
		public byte PixieDust; // 0 - 6
		public byte CallBead; // 0 - 99

		public override string ToString() => this.FormatAsString();
	}
}