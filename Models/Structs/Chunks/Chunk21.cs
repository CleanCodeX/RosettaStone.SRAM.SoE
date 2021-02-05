using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Extensions;
using IO.Helpers;

namespace SRAM.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// Trade Goods
	/// </summary>
	/// <remarks><see cref="SramSizes.SaveSlot.Chunk21"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[HasComplexMembers]
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct Chunk21
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown17G)]
		public byte[] Unknown17G; // [785|x311] :: (4 bytes) 

		// Trade Goods
		public TradeGoods TradeGoods; // [789|x315] :: (26 bytes)

		// Unknown 18
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown18)]
		public byte[] Unknown18; // [815|x32F] :: (2 bytes)

		public override string ToString() => this.Format();
	}
}