using System;

namespace RosettaStone.Sram.SoE.Models.Enums
{
	/// The alchemies
	[Flags]
	public enum Alchemy: ulong
	{
		None = 0,

		// byte 1
		AcidRain = 0x1,
		Atlas = 0x2,
		Barrier = 0x4,
		CallUp = 0x8,
		Corrosion = 0x10,
		Crush = 0x20,
		Cure = 0x40,
		Defend = 0x80,

		// byte 2
		DoubleDrain = 0x1 + (1 << 8),
		Drain = 0x2 + (1 << 8),
		Energize = 0x4 + (1 << 8),
		Escape = 0x8 + (1 << 8),
		Explosion = 0x10 + (1 << 8),
		FireBall = 0x20 + (1 << 8),
		FirePower = 0x40 + (1 << 8),
		Flash = 0x80 + (1 << 8),

		// byte 3
		ForceField = 0x1 + (1 << 16),
		HardBall = 0x2 + (1 << 16),
		Heal = 0x4 + (1 << 16),
		Lance = 0x8 + (1 << 16),
		Laser = 0x10 + (1 << 16),
		Levitate = 0x20 + (1 << 16),
		LightningStorm = 0x40 + (1 << 16),
		MiracleCure = 0x80 + (1 << 16),

		// byte 4
		Nitro = 0x1 + (1 << 24),
		OneUp = 0x2 + (1 << 24),
		Reflect = 0x4 + (1 << 24),
		Regrowth = 0x8 + (1 << 24),
		Revealer = 0x10 + (1 << 24),
		Revive = 0x20 + (1 << 24),
		SlowBurn = 0x40 + (1 << 24),
		Speed = 0x80 + (1 << 24),

		// byte 5
		Sting = 0x1 + (1UL << 32),
		Stop = 0x2 + (1UL << 32),
		SuperHeal = 0x4 + (1UL << 32),

		Unknown1 = 0x8 + (1UL << 32),
		Unknown2 = 0x10 + (1UL << 32),
		Unknown3 = 0x20 + (1UL << 32),
		Unknown4 = 0x40 + (1UL << 32),
		Horace = 0x80 + (1UL << 32),

		// byte 6
		Camellia = 0x1 + (1UL << 40),
		Sidney = 0x2 + (1UL << 40),
		Unknown5 = 0x4 + (1UL << 40),
		Unknown6 = 0x8 + (1UL << 40),
		Unknown7 = 0x10 + (1UL << 40),
		Unknown8 = 0x20 + (1UL << 40),
		Unknown9 = 0x40 + (1UL << 40),
		Unknown10 = 0x80 + (1UL << 40)
	}
}