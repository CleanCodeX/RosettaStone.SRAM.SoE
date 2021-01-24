using System.Diagnostics;
using System.Runtime.InteropServices;
using SramCommons.Extensions;

namespace RosettaStone.Sram.SoE.Models.Structs
{
	/// <summary>
	/// AlchemyLevels
	/// </summary>
	/// <remarks>70 bytes</remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct AlchemyLevels
	{
		public ushort AcidRain;
		public ushort Atlas;
		public ushort Barrier;
		public ushort CallUp;
		public ushort Corrosion;
		public ushort Crush;
		public ushort Cure;
		public ushort Defend;

		public ushort DoubleDrain;
		public ushort Drain;
		public ushort Energize;
		public ushort Escape;
		public ushort Explosion;
		public ushort FireBall;
		public ushort FirePower;
		public ushort Flash;

		public ushort ForceField;
		public ushort HardBall;
		public ushort Heal;
		public ushort Lance;
		public ushort Laser;
		public ushort Levitate;
		public ushort LightningStorm;
		public ushort MiracleCure;

		public ushort Nitro;
		public ushort OneUp;
		public ushort Reflect;
		public ushort Regrowth;
		public ushort Revealer;
		public ushort Revive;
		public ushort SlowBurn;
		public ushort Speed;

		public ushort Sting;
		public ushort Stop;
		public ushort SuperHeal;

		public override string ToString() => this.FormatAsString();
	}
}