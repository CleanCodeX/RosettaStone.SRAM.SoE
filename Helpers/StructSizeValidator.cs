using System.Runtime.InteropServices;
using Common.Shared.Min.Helpers;
using WRAM.Snes9x.SoE.Models.Structs.Chunks;

namespace SRAM.SoE.Helpers
{
	internal static class StructSizeValidator
	{
		internal static void Validate()
		{
			Requires.True(Marshal.SizeOf<Chunk01>() == Chunk01.Size, nameof(Chunk01));
			Requires.True(Marshal.SizeOf<Chunk02>() == Chunk02.Size, nameof(Chunk02));
			Requires.True(Marshal.SizeOf<Chunk03>() == Chunk03.Size, nameof(Chunk03));
			Requires.True(Marshal.SizeOf<Chunk04>() == Chunk04.Size, nameof(Chunk04));
			Requires.True(Marshal.SizeOf<Chunk05>() == Chunk05.Size, nameof(Chunk05));
			Requires.True(Marshal.SizeOf<Chunk06>() == Chunk06.Size, nameof(Chunk06));
			Requires.True(Marshal.SizeOf<Chunk07>() == Chunk07.Size, nameof(Chunk07));
			Requires.True(Marshal.SizeOf<Chunk08>() == Chunk08.Size, nameof(Chunk08));
			Requires.True(Marshal.SizeOf<Chunk09>() == Chunk09.Size, nameof(Chunk09));
			Requires.True(Marshal.SizeOf<Chunk10>() == Chunk10.Size, nameof(Chunk10));
			Requires.True(Marshal.SizeOf<Chunk11>() == Chunk11.Size, nameof(Chunk11));
			Requires.True(Marshal.SizeOf<Chunk12>() == Chunk12.Size, nameof(Chunk12));
			Requires.True(Marshal.SizeOf<Chunk13>() == Chunk13.Size, nameof(Chunk13));
			Requires.True(Marshal.SizeOf<Chunk14>() == Chunk14.Size, nameof(Chunk14));
			Requires.True(Marshal.SizeOf<Chunk15>() == Chunk15.Size, nameof(Chunk15));
			Requires.True(Marshal.SizeOf<Chunk16>() == Chunk16.Size, nameof(Chunk16));
			Requires.True(Marshal.SizeOf<Chunk17>() == Chunk17.Size, nameof(Chunk17));
			Requires.True(Marshal.SizeOf<Chunk18>() == Chunk18.Size, nameof(Chunk18));
			Requires.True(Marshal.SizeOf<Chunk19>() == Chunk19.Size, nameof(Chunk19));
			Requires.True(Marshal.SizeOf<Chunk20>() == Chunk20.Size, nameof(Chunk20));
			Requires.True(Marshal.SizeOf<Chunk21>() == Chunk21.Size, nameof(Chunk21));
		}
	}
}
