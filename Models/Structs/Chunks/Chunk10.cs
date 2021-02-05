using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Extensions;
using IO.Helpers;

namespace SRAM.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// DogStatusBuffs
	/// </summary>
	/// <remarks><see cref="SramSizes.SaveSlot.Chunk10"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[HasComplexMembers]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Chunk10
	{
		// Dog Status Buffs 1-4
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public CharacterBuffStatus[] Status; // [177|xB1] :: (24 bytes)

		public override string ToString() => this.Format();
	}
}