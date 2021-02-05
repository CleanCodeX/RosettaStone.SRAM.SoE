using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Extensions;
// ReSharper disable BuiltInTypeReferenceStyle

namespace SRAM.SoE.Models.Structs
{
	/// <summary>
	/// The trade goods the boy can hold
	/// </summary>
	/// <remarks>26 bytes</remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct TradeGoods
	{
		//  (0 - 99)
		public UInt16 AnnihilationAmulet; 
		public UInt16 Beads;
		public UInt16 CeramicPot; 
		public UInt16 Chicken; 
		public UInt16 GoldenJackal; 
		public UInt16 JeweledScarab; 
		public UInt16 LimestoneTablet; 
		public UInt16 Perfume; 
		public UInt16 Rice; 
		public UInt16 Spice; 
		public UInt16 SouvenirSpoon; 
		public UInt16 Tapestry; 
		public UInt16 TicketForExhibition;

		public override string ToString() => this.Format();
	}
}