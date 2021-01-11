using System.Diagnostics;
using System.Runtime.InteropServices;
using SramCommons.Models.Structs;

namespace RosettaStone.Sram.SoE.Models.Structs
{
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 12)]
	public struct Moneys
	{
		public ThreeByteUInt Talons;
		public ThreeByteUInt Jewels;
		public ThreeByteUInt GoldCoins;
		public ThreeByteUInt Credits;

		public override string ToString() => $"T: {Talons} | J: {Jewels} | GC: {GoldCoins} | C: {Credits}";
	}
}