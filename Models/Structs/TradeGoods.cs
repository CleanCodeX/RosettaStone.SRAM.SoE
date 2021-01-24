using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Extensions;

namespace SRAM.SoE.Models.Structs
{
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct TradeGoods
	{
		//  (0 - 99)
		public ushort AnnihilationAmulet; 
		public ushort Beads;
		public ushort CeramicPot; 
		public ushort Chicken; 
		public ushort GoldenJackal; 
		public ushort JeweledScarab; 
		public ushort LimestoneTablet; 
		public ushort Perfume; 
		public ushort Rice; 
		public ushort Spice; 
		public ushort SouvenirSpoon; 
		public ushort Tapestry; 
		public ushort TicketForExhibition;

		public override string ToString() => this.FormatAsString();
	}
}