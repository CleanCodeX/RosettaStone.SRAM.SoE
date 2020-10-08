using System.Diagnostics;
using System.Runtime.InteropServices;
using SramCommons.Models.Structs;

namespace SramFormat.SoE.Models.Structs
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 12)]
	[DebuggerDisplay("{ToString(),nq}")]
	public struct Moneys
	{
		public ThreeByteUInt Talons;
		public ThreeByteUInt Jewels;
		public ThreeByteUInt GoldCoins;
		public ThreeByteUInt Credits;

		public override string ToString() => $"T: {Talons} | J: {Jewels} | GC: {GoldCoins} | C: {Credits}";
	}
}