using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Extensions;

namespace SRAM.SoE.Models.Structs
{
	/// <summary>
	/// The amount of ingredients the boy can hold
	/// </summary>
	/// <remarks>22 bytes</remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct Ingredients
	{
		public byte Wax;
		public byte Water;
		public byte Vinegar;
		public byte Root;
		public byte Oil;
		public byte Mushroom;
		public byte MudPepper;
		public byte Meteorite;
		public byte Limestone;
		public byte Iron;
		public byte GunPowder;
		public byte Grease;
		public byte Feather;
		public byte Ethanol;
		public byte DryIce;
		public byte Crystal;
		public byte Clay;
		public byte Brimstone;
		public byte Bone;
		public byte AtlasMedallion;
		public byte Ash;
		public byte Acorn;

		public override string ToString() => this.FormatAsString();
	}
}