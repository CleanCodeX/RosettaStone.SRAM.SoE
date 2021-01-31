using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Extensions;

namespace SRAM.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// Unknown4
	/// </summary>
	/// <remarks><see cref="SramSizes.SaveSlot.Chunk04"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct Chunk04
	{
		// Unknown 4
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown4)]
		public byte[] Unknown4; // [136|x88] :: (6 bytes)

		public char[] AsChars => Unknown4.GetChars();

		public override string ToString() => Unknown4.FormatAsString();
	}
}