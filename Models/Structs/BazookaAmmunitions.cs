using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Extensions;

namespace SRAM.SoE.Models.Structs
{
	/// <summary>
	/// The bazooka ammunitions the boy can hold
	/// </summary>
	/// <remarks>4 bytes</remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct BazookaAmmunitions
	{
		public byte ThunderBall; // 0 - 99
		public byte ParticleBomb; // 0 - 99
		public byte CryoBlast; // 0 - 99
		public byte CurrentAmmunitionType; // 0 = Thunder Ball, 2 = Particle Bomb, 4 = Cryo Blast

		public override string ToString() => this.FormatAsString();
	}
}