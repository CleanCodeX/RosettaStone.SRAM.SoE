using System.Diagnostics;
using System.Runtime.InteropServices;
using SramCommons.Extensions;

namespace RosettaStone.Sram.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// Chunk11
	/// </summary>
	/// <remarks><see cref="SramSizes.SaveSlot.Chunk11"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	public struct Chunk11
	{
		// Unknown 7
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown7)]
		public byte[] Unknown7; // [201|xC9] :: (6 bytes)

		public char[] AsChars => Unknown7.GetChars();
		public string AsString => Unknown7.GetString();

		public override string ToString() => this.FormatAsString();
	}
}