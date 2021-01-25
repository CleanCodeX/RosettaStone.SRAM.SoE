using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Models.Structs;

namespace SRAM.SoE.Models.Structs
{
	/// <summary>
	/// The money the characters can hold
	/// </summary>
	/// <remarks>12 bytes, 3 bytes each (16.7M)</remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 12)]
	public struct Moneys
	{
		public UInt24 Talons;
		public UInt24 Jewels;
		public UInt24 GoldCoins;
		public UInt24 Credits;

		public override string ToString() => $"T: {Talons} | J: {Jewels} | GC: {GoldCoins} | C: {Credits}";
	}
}