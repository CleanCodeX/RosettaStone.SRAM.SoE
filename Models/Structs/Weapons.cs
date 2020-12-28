using System.Diagnostics;
using System.Runtime.InteropServices;
using SramFormat.SoE.Models.Enums;

namespace SramFormat.SoE.Models.Structs
{
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct Weapons
	{
		[FieldOffset(0)] public ushort Value;

		[FieldOffset(0)] public byte Byte1;
		[FieldOffset(1)] public byte Byte2;

		public Weapon EnumValue
		{
			get => (Weapon)Value;
			set => Value = (ushort)value;
		}

		public override string ToString() => EnumValue.ToString();
	}
}