using System.Runtime.InteropServices;
using Common.Shared.Min.Extensions;
using Common.Shared.Min.Helpers;
using RosettaStone.Sram.SoE.Models.Structs.Chunks;
using Slot = RosettaStone.Sram.SoE.Models.SramSizes.SaveSlot;

namespace RosettaStone.Sram.SoE.Helpers
{
	public static class StructSizeValidator
	{
		internal static void Validate()
		{
			Requires.True(Marshal.SizeOf<Chunk01>() == Slot.Chunk1, nameof(Slot.Chunk1));
			Requires.True(Marshal.SizeOf<Chunk02>() == Slot.Chunk2, nameof(Slot.Chunk2));
			Requires.True(Marshal.SizeOf<Chunk03>() == Slot.Chunk3, nameof(Slot.Chunk3));
			Requires.True(Marshal.SizeOf<Chunk04>() == Slot.Chunk4, nameof(Slot.Chunk4));
			Requires.True(Marshal.SizeOf<Chunk05>() == Slot.Chunk5, nameof(Slot.Chunk5));
			Requires.True(Marshal.SizeOf<Chunk06>() == Slot.Chunk6, nameof(Slot.Chunk6));
			Requires.True(Marshal.SizeOf<Chunk07>() == Slot.Chunk7, nameof(Slot.Chunk7));
			Requires.True(Marshal.SizeOf<Chunk08>() == Slot.Chunk8, nameof(Slot.Chunk8));
			Requires.True(Marshal.SizeOf<Chunk09>() == Slot.Chunk9, nameof(Slot.Chunk9));
			Requires.True(Marshal.SizeOf<Chunk10>() == Slot.Chunk10, nameof(Slot.Chunk10));
			Requires.True(Marshal.SizeOf<Chunk11>() == Slot.Chunk11, nameof(Slot.Chunk11));
			Requires.True(Marshal.SizeOf<Chunk12>() == Slot.Chunk12, nameof(Slot.Chunk12));
			Requires.True(Marshal.SizeOf<Chunk13>() == Slot.Chunk13, nameof(Slot.Chunk13));
			Requires.True(Marshal.SizeOf<Chunk14>() == Slot.Chunk14, nameof(Slot.Chunk14));
			Requires.True(Marshal.SizeOf<Chunk15>() == Slot.Chunk15, nameof(Slot.Chunk15));
			Requires.True(Marshal.SizeOf<Chunk16>() == Slot.Chunk16, nameof(Slot.Chunk16));
			Requires.True(Marshal.SizeOf<Chunk17>() == Slot.Chunk17, nameof(Slot.Chunk17));
			Requires.True(Marshal.SizeOf<Chunk18>() == Slot.Chunk18, nameof(Slot.Chunk18));
			Requires.True(Marshal.SizeOf<Chunk19>() == Slot.Chunk19, nameof(Slot.Chunk19));
			Requires.True(Marshal.SizeOf<Chunk20>() == Slot.Chunk20, nameof(Slot.Chunk20));
			Requires.True(Marshal.SizeOf<Chunk21>() == Slot.Chunk21, nameof(Slot.Chunk21));
		}
	}
}
