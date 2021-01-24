using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Extensions;

namespace SRAM.SoE.Models.Structs
{
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct Armors
	{
		// Vests (0 - 6)
		public byte GrassVest;
		public byte ShellPlate;
		public byte DinoSkin;
		public byte BronzeArmor;
		public byte StoneVest;
		public byte CenturionCape;
		public byte SilverMail;
		public byte GoldPlatedVest;
		public byte ShiningArmor;
		public byte MagnaMail;
		public byte TitaniumVest;
		public byte VirtualVest;

		// Hats (0 - 6)
		public byte GrassHat;
		public byte ShellHat;
		public byte DinoHelmet;
		public byte BronzeHelmet;
		public byte ObsidianHelmet;
		public byte CenturionHelmet;
		public byte TitansCrown;
		public byte DragonHelmet;
		public byte KnightsHelmet;
		public byte LightningHelmet;
		public byte OldReliable;
		public byte BrainStorm;

		// Bracelets (0 - 6)
		public byte VineBracelet;
		public byte MammothGuard;
		public byte ClawGuard;
		public byte SerpentBracer;
		public byte BronzeGauntlet;
		public byte GlovesOfRa;
		public byte IronBracer;
		public byte MagiciansRing;
		public byte DragonsClaw;
		public byte CyberGlove;
		public byte ProtectorRing;
		public byte VirtualGlove;

		// Collars (0 - 6)
		public byte LeatherCollar;
		public byte SpikyCollar;
		public byte DefenderCollar;
		public byte SpotsCollar;

		public override string ToString() => this.FormatAsString();
	}
}