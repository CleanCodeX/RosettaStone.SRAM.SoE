using System.Diagnostics;
using System.Runtime.InteropServices;
using SramCommons.Extensions;

namespace RosettaStone.Sram.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// TradeGoods
	/// </summary>
	/// <remarks><see cref="SramSizes.SaveSlot.Chunk21"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	public struct Chunk21
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown17G)]
		public byte[] Unknown17G; // [785|x311] :: (4 bytes) 

		// Trade Goods
		public TradeGoods TradeGoods; // [789|x315] :: (26 bytes)

		// Unknown 18
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown18)]
		public byte[] Unknown18; // [815|x32F] :: (2 bytes)

		public override string ToString() => this.FormatAsString();
	}
}