// ReSharper disable InconsistentNaming

using System.Linq;
using SramCommons.Extensions;

namespace RosettaStone.Sram.SoE.Models
{
	/// <summary>
	/// Known offsets of SoE's S-RAM format
	/// </summary>
	public class SramOffsets
	{
		public const int AudioMode = 0; 
		public const int LastSaveSlotId = 1;
		public const int FirstSaveSlot = 2;
		public const int Unknown1 = 3_270; // [xCC6]

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

			//public const int Checksum = 0; // (2 bytes)

			//public const int LastSavePointName = 2; // (36 bytes)

			//// W-RAM Chunk01_BoyNameDogName
			//public const int BoyName = 38; // [x26] (36 bytes)
			//public const int DogName = 74; // [x4A] (36 bytes)

			//// W-RAM Chunk2_BoyCurrentHp + Chunk3_BoyStatusBuffs
			//public const int BoyCurrentHp = 110; // [x69] (2 bytes)
			//public const int BoyStatusBuffs = 112; // [x70] (30 bytes)

			//// W-RAM Chunk04 [136] (6 bytes) ???

			//// W-RAM Chunk5 [142] (2 bytes) 
			//public const int BoyMaxHp = 142; // [x8E] (2 bytes)
			//// W-RAM Chunk5 [144] (2 bytes) 
			//public const int Unknown5 = 144; // [x90] (10 bytes)

			//public const int BoyExperience = 154; // [x9A] (3 bytes)

			//public const int BoyLevel = 157; // [x9D] (2 bytes)

			//public const int BoyMaxChargeup = 159; // [x9F] (2 bytes)

			//public const int Unknown6 = 161; // [xA1] (14 bytes)

			//public const int DogCurrentHp = 175; // [xAF] (2 bytes)

			//public const int DogStatusBuffs = 177; // [xB1] (30 bytes)

			//public const int DogMaxHp = 207; // [xCF] (2 bytes)

			//public const int Unknown8 = 209; // [xD1] (10 bytes)

			//public const int DogExperience = 219; // [xDB] (3 bytes)

			//public const int DogLevel = 222; // [xDE] (2 bytes)

			//public const int DogMaxChargeup = 224; // [xE0] (2 bytes)

			//public const int Unknown9 = 226; // [xE3] (26 bytes)

			//public const int Money = 252; // [xFC] (12 bytes)

			//public const int Unknown10 = 264; // [x107] (13 bytes)

			//public const int WeaponLevels = 277; // [x115] (26 bytes)

			//public const int Unknown11 = 303; // [x12F] (14 bytes)

			//public const int DogAttackLevel = 317; // [x13D] (2 bytes)

			//public const int Unknown12A = 319; // [x13F] (16 bytes)
			//public const int Unknown12B = 335; // [x14F] (2 bytes)
			//public const int Unknown12C = 337; // [x151] (4 bytes)

			//public const int AlchemyMinorLevels = 341; // [x155] (70 bytes)

			//public const int AlchemyMajorLevels = 411; // [x19B] (70 bytes)

			//public const int Unknown13 = 481; // [x1E1] (22 bytes)

			//public const int Alchemies = 503; // [x1F7] (5 bytes)

			//public const int Unknown14 = 508; // [x1FC] (4 bytes) 

			//public const int CharmsAndRareItems = 512; // [x200] (4 bytes)

			//public const int IngredientSniffSpots = 516; // [x204] (89 bytes)

			public const int Unknown15 = 609; // [x261] (24 bytes)

			//public const int Weapons = 633; // [x279] (2 bytes)

			//public const int Unknown16A = 635; // [x27B] (4 bytes)
			//public const int Unknown16B_GothicaFlags = 639; // [x27F] (4 bytes)
			public const int Unknown16C = 643; // [x283] (6 bytes)

			//public const int Ingredients = 649; // [x289] (22 bytes)

			//public const int Items = 671; // [x29F] (8 bytes)

			//public const int Armors = 679; // [x2A7] (40 bytes)

			//public const int BazookaAmmunitions = 719; // [x2CF] (4 bytes)

			//public const int Unknown17 = 723; // [x2D3] (66 bytes)

			//public const int TradeGoods = 789; // [x315] (26 bytes)

			//public const int Unknown18 = 815; // [x32F] (2 bytes)
		}
	}
}