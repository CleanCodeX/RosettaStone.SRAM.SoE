using System.Diagnostics;
using System.Runtime.InteropServices;
using RosettaStone.Sram.SoE.Extensions;

namespace RosettaStone.Sram.SoE.Models.Structs
{
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct BazookaAmmunitions
	{
		public byte ThunderBall; // 0 - 99
		public byte ParticleBomb; // 0 - 99
		public byte CryoBlast; // 0 - 99

		public override string ToString() => $@"{nameof(ThunderBall)}: {ThunderBall}
{nameof(ParticleBomb)}: {ParticleBomb}
{nameof(CryoBlast)}: {CryoBlast}
".ReplaceLineBreaks();
	}
}