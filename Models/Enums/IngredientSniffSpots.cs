using System.Runtime.InteropServices;

namespace SRAM.SoE.Models.Enums
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct IngredientSniffSpots
	{
		// Unknown 16
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 89)]
		public byte[] SniffSpots; // [520|x208] :: (89 bytes)
	}
}