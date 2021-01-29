using System.Diagnostics;
using System.Runtime.InteropServices;
using Common.Shared.Min.Extensions;
using IO.Models.Structs;
using SoE.Models.Enums;

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
			set => Data.Value = value.ToULong();
		}

		public override string ToString() => Value.ToString();
	}
}