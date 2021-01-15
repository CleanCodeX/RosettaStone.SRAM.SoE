using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using Common.Shared.Min.Extensions;

namespace RosettaStone.Sram.SoE.Models.Structs
{
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
	public struct FixedString
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
		public byte[] Bytes; // (36 Bytes) Null terminated

		public char[] AsChars => Encoding.ASCII.GetChars(Bytes);
		public string AsString => new(AsChars);
		public string AsTrimmedString => AsString.Remove("\0")!;

		public override string ToString() => AsString;
	}
}