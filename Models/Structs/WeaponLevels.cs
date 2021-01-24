using System.Diagnostics;
using System.Runtime.InteropServices;
using SramCommons.Extensions;

namespace RosettaStone.Sram.SoE.Models.Structs
{
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct WeaponLevels
	{
		public WeaponLevel BareHands; // you can't ever fight with them

		public WeaponLevel BoneCrusher; // %256 * 100 gives in-game display)
		public WeaponLevel GladiatorSword;
		public WeaponLevel CrusaderSword;
		public WeaponLevel NeutronBlade;

		public WeaponLevel SpidersClaw;
		public WeaponLevel BronzeAxe;
		public WeaponLevel KnightBasher;
		public WeaponLevel AtomSmasher;

		public WeaponLevel HornSpear;
		public WeaponLevel BronzeSpear;
		public WeaponLevel LanceWeapon;
		public WeaponLevel LaserLance;

		public WeaponLevel Bazooka; // high part never initialized to 1 like the other weapons are, and its default of 0 causes bugs with the computer-controlled character and with Energize.

		public override string ToString() => this.FormatAsString();
	}
}