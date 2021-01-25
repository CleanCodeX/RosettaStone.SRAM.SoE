using System.Runtime.InteropServices;
using Common.Shared.Min.Helpers;
using SRAM.SoE.Models.Structs.Chunks;
using Slot = SRAM.SoE.Models.SramSizes.SaveSlot;

namespace SRAM.SoE.Helpers
{
	internal static class StructSizeValidator
	{
		internal static void Validate()
		{
			Requires.True(Marshal.SizeOf<Chunk01>() == Slot.Chunk01, nameof(Slot.Chunk01));
			Requires.True(Marshal.SizeOf<Chunk02>() == Slot.Chunk02, nameof(Slot.Chunk02));
			Requires.True(Marshal.SizeOf<Chunk03>() == Slot.Chunk03, nameof(Slot.Chunk03));
			Requires.True(Marshal.SizeOf<Chunk04>() == Slot.Chunk04, nameof(Slot.Chunk04));
			Requires.True(Marshal.SizeOf<Chunk05>() == Slot.Chunk05, nameof(Slot.Chunk05));
			Requires.True(Marshal.SizeOf<Chunk06>() == Slot.Chunk06, nameof(Slot.Chunk06));
			Requires.True(Marshal.SizeOf<Chunk07>() == Slot.Chunk07, nameof(Slot.Chunk07));
			Requires.True(Marshal.SizeOf<Chunk08>() == Slot.Chunk08, nameof(Slot.Chunk08));
			Requires.True(Marshal.SizeOf<Chunk09>() == Slot.Chunk09, nameof(Slot.Chunk09));
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
