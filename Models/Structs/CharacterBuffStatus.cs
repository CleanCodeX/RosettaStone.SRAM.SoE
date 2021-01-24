using System.Runtime.InteropServices;
using IO.Extensions;

// ReSharper disable InconsistentNaming

namespace SRAM.SoE.Models.Structs
{
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct CharacterBuffStatus
	{
		public ushort Id; // FFFFh = none, Bit 15: 1 = most recently given, see list of IDs below
		public ushort Timer; // ascending from 0, frame-based
		public ushort Boost; // Boost provided to statistic(s), OR Time since/until last/next damage/healing interval

		public override string ToString() => this.FormatAsString();
	}

	// NOTE: Since Plague doesn't auto-expire, it has time since last interval where the Timer would go, and an unknown value in the third(Time interval) slot.

	/*	Status ID list for above structures:
	00h = Atlas, 
	08h = Aura (Horace),
	10h = Barrier, 
	18h = Defend,
	20h = Energize, 
	28h = Force Field,
	30h = Reflect, 
	38h = Shield (Camellia),
	40h = Regrowth, 
	48h = Speed,
	50h = Regenerate (Horace) and Pixie Dust, 
	58h = Stop (*),
	60h = Confound, 
	68h = Disrupt (*),
	70h = Slow Burn, 
	78h = Corrosion,
	80h = Hypnotize (*), 
	88h = Plague,
	90h = Poison, 
	98h = Wings helper status
	FFFFh = Nothing
	# Boy and Dog don't receive	
	*/
}
