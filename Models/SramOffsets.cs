using System.Collections.Generic;
using WRAM.Snes9x.SoE.Models;
using WRAM.Snes9x.SoE.Models.Structs.Chunks;

namespace SRAM.SoE2.Models
{
	/// <summary>
	/// Known offsets of SoE's S-RAM format
	/// </summary>
	public class SramOffsets
	{
		public const int FirstSaveSlot = 2;
		public const int Unknown19 = 3_270; // [xCC6]

		public static readonly Dictionary<int, (int WramOffset, int Size)> WramChunkOffsetMappings = new()
		{
			[SaveSlot.Chunk01] = (WramOffsets.Chunk01, Chunk01.Size), // [x26]

			[SaveSlot.Chunk02] = (WramOffsets.Chunk02, Chunk02.Size), // [x6E] (2)
			[SaveSlot.Chunk03] = (WramOffsets.Chunk03, Chunk03.Size), // [x70] (24)
			[SaveSlot.Chunk04] = (WramOffsets.Chunk04, Chunk04.Size), // [x88] (6)
			[SaveSlot.Chunk05] = (WramOffsets.Chunk05, Chunk05.Size), // [x8E] (2)
			[SaveSlot.Chunk06] = (WramOffsets.Chunk06, Chunk06.Size), // [x90] (13) 
			[SaveSlot.Chunk07] = (WramOffsets.Chunk07, Chunk07.Size), // [x9D] (4)
			[SaveSlot.Chunk08] = (WramOffsets.Chunk08, Chunk08.Size), // [xA1] (14)

			[SaveSlot.Chunk09] = (WramOffsets.Chunk09, Chunk09.Size), // [xAF] (2)
			[SaveSlot.Chunk10] = (WramOffsets.Chunk10, Chunk10.Size), // [xB1] (24)
			[SaveSlot.Chunk11] = (WramOffsets.Chunk11, Chunk11.Size), // [xC9] (6)
			[SaveSlot.Chunk12] = (WramOffsets.Chunk12, Chunk12.Size), // [xCF] (2)
			[SaveSlot.Chunk13] = (WramOffsets.Chunk13, Chunk13.Size), // [xD1] (13)
			[SaveSlot.Chunk14] = (WramOffsets.Chunk14, Chunk14.Size), // [xDE] (4)
			[SaveSlot.Chunk15] = (WramOffsets.Chunk15, Chunk15.Size), // [xE2] (14)

			[SaveSlot.Chunk16] = (WramOffsets.Chunk16, Chunk16.Size), // [xF0] (101)

			[SaveSlot.Chunk17] = (WramOffsets.Chunk17, Chunk17.Size), // [x155] (162)

			[SaveSlot.Chunk18] = (WramOffsets.Chunk18, Chunk18.Size), // [x1F7] (146)
			[SaveSlot.Chunk19] = (WramOffsets.Chunk19, Chunk19.Size), // [x289] (92)
			[SaveSlot.Chunk20] = (WramOffsets.Chunk20, Chunk20.Size), // [x2E5] (44)
			[SaveSlot.Chunk21] = (WramOffsets.Chunk21, Chunk21.Size), // [x311] (32)
		};

		public static readonly Dictionary<int, (int WramOffset, int Size)> WramOffsetMappings = new()
		{
			//[0] = (0x7E0B21, 2)
		};

		public class SaveSlot
		{
			/* Not used atm */

			public const int Chunk01 = 38; // (x26) 

			public const int Chunk02 = 110; // (x6E) 
			public const int Chunk03 = 112; // (x70) 
			public const int Chunk04 = 136; // (x88) 

			public const int Chunk05 = 142; // (x8E) 
			public const int Chunk06 = 144; // (x90) 
			public const int Chunk07 = 157; // (x9D) 

			public const int Chunk08 = 161; // (xA1) 
			public const int Chunk09 = 175; // (xAF) 
			public const int Chunk10 = 177; // (xB1) 

			public const int Chunk11 = 201; // (xC9) 
			public const int Chunk12 = 207; // (xCF) 
			public const int Chunk13 = 209; // (xD1)
			public const int Chunk14 = 222; // (xDE) 
			public const int Chunk15 = 226; // (xE4)
			public const int Chunk16 = 240; // (xF0)

			public const int Chunk17 = 341; // (x155) 

			public const int Chunk18 = 503; // (x1F7)
			public const int Chunk19 = 649; // (x289) 
			public const int Chunk20 = 741; // (x2E5) 
			public const int Chunk21 = 785; // (x311)

			public const int Unknown15 = 609; // [x261] (24 bytes)
			public const int Unknown16C = 643; // [x283] (6 bytes)
		}
	}
}