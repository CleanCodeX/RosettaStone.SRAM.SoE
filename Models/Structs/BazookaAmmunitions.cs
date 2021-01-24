using System.Diagnostics;
using System.Runtime.InteropServices;
using SramCommons.Extensions;

namespace RosettaStone.Sram.SoE.Models.Structs
{
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct BazookaAmmunitions
	{
		public byte ThunderBall; // 0 - 99
		public byte ParticleBomb; // 0 - 99
		public byte CryoBlast; // 0 - 99
		public byte CurrentAmmunitionType; // 0 = Thunder Ball, 2 = Particle Bomb, 4 = Cryo Blast

		public override string ToString() => this.FormatAsString();
	}
}