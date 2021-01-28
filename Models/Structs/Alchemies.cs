using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Extensions;
using IO.Models.Structs;
using SoE.Models.Enums;
using SRAM.SoE.Extensions;

namespace SRAM.SoE.Models.Structs
{
	/// <summary>
	/// The Alchemies the boy can learn
	/// </summary>
	/// <remarks>48 bits (38 used)</remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Alchemies
	{
		public UInt48 Data;

		public Alchemy Value
		{
			get => (Alchemy)Data.Value;
			set => Data.Value = value.ToUInt64();
		}

		public override string ToString() => Value.ToString();
	}
}