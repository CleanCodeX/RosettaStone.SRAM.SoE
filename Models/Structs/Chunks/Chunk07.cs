using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Extensions;

namespace SRAM.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// BoyLevel
	/// </summary>
	/// <remarks><see cref="SramSizes.SaveSlot.Chunk07"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Chunk07
	{
		public UInt16 BoyLevel; // [157|x9D] :: (2 bytes)
		public UInt16 BoyMaxChargeup; // [159|x9F] :: (2 bytes)

		public override string ToString() => this.FormatAsString();
	}
}