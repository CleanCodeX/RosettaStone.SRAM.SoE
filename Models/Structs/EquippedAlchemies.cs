using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Extensions;

namespace SRAM.SoE.Models.Structs
{
	/// <summary>
	/// The boy's equipped alchemy spells
	/// </summary>
	/// <remarks>9 bytes</remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct EquippedAlchemies
	{
		public byte Spell1;
		public byte Spell2;
		public byte Spell3;
		public byte Spell4;
		public byte Spell5;
		public byte Spell6;
		public byte Spell7;
		public byte Spell8;
		public byte Spell9;

		public override string ToString() => this.FormatAsString();
	}
}