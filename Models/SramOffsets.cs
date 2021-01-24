// ReSharper disable InconsistentNaming

using System.Linq;
using IO.Extensions;

namespace SRAM.SoE.Models
{
	/// <summary>
	/// Known offsets of SoE's S-RAM format
	/// </summary>
	public class SramOffsets
	{
		public const int FirstSaveSlot = 2;
		public const int Unknown19 = 3_270; // [xCC6]

		public class SaveSlot
		{
			public static string? GetNameFromOffset(int offset)
			{
				var constants = typeof(SaveSlot).GetPublicConstants<int>().OrderBy(e => e.Value);

				return (from kvp in constants 
					where offset >= kvp.Value
						select kvp.Key).LastOrDefault();
			}

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