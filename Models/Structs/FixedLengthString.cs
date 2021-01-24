using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using SramCommons.Extensions;

namespace RosettaStone.Sram.SoE.Models.Structs
{
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
	public struct FixedLengthString
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
		public byte[] Bytes; // (36 Bytes) Null terminated

		public char[] AsChars => Encoding.ASCII.GetChars(Bytes);
		public string AsString => AsChars.GetString();

		public override string ToString() => AsString;
	}
}