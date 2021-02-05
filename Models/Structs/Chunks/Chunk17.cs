using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Extensions;
using IO.Helpers;

namespace SRAM.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// AlchemyLevels
	/// </summary>
	/// <remarks><see cref="SramSizes.SaveSlot.Chunk17"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[HasComplexMembers]
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct Chunk17
	{
		// Alchemy Levels
		public AlchemyLevels AlchemyMinorLevels; // [341|x155] :: (70 bytes)

		public AlchemyLevels AlchemyMajorLevels; // [411|x19B] :: (70 bytes)

		// Unknown 13
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown13)]
		public byte[] Unknown13; // [481|x1E1] :: (22 bytes)

		public override string ToString() => this.Format();
	}
}