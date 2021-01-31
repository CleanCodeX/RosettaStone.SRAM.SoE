using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Helpers;

namespace SRAM.SoE.Models.Structs
{
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	[HasToStringOverride]
	public struct AlchemyLevel
	{
		public byte Minor; // 0-255
		public byte Major; // 0-8
		
		public override string ToString() => Minor.ToString();
	}
}