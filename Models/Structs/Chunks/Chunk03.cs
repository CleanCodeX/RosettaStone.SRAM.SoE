using System.Diagnostics;
using System.Runtime.InteropServices;
using SramCommons.Extensions;

namespace RosettaStone.Sram.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// BoyStatusBuffs
	/// </summary>
	/// <remarks><see cref="SramSizes.SaveSlot.Chunk03"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	public struct Chunk03
	{
		// Boy Status Buffs 1-4
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public CharacterBuffStatus[] Status; // [112|x70] :: (24 bytes)

		public override string ToString() => this.FormatAsString();
	}
}