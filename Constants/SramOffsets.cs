// ReSharper disable InconsistentNaming

using System.Linq;
using SramCommons.Extensions;

namespace RosettaStone.Sram.SoE.Constants
{
	/// <summary>
	/// Known offsets of SoE's S-RAM format
	/// </summary>
	public class SramOffsets
	{
		/// base offset of the game data in the S-RAM
		public const int FirstSaveSlot = 2;
		public const int SramChecksum = 0;

		public class SaveSlot
		{
			public static string? GetNameFromOffset(int offset)
			{
				var constants = typeof(SaveSlot).GetPublicConstants<int>().OrderBy(e => e.Value);

				return (from kvp in constants 
					where offset >= kvp.Value
						select kvp.Key).LastOrDefault();
			}

			public const int Checksum = 0; // (2 bytes)

			public const int LastSavePointName = 2; // (36 bytes)

			///  of the boy's name
			public const int BoyName = 38; // [x26] (36 bytes)

			///  of the dog's name
			public const int DogName = 74; // [x4A] (36 bytes)

			///  of the boy's current HP
			public const int BoyCurrentHp = 110; // [x69] (2 bytes)

			public const int Unknown4_BoyBuff__BuffFlags = 112; // [x70]
			public const int Unknown4_BoyBuff__Unknown1 = Unknown4_BoyBuff__BuffFlags + 2; // Offset 114
			public const int Unknown4_BoyBuff__Unknown2 = Unknown4_BoyBuff__Unknown1 + 2; // Offset 116
			public const int Unknown4_BoyBuff__Unknown3 = Unknown4_BoyBuff__Unknown2 + 22; // Offset 138
			public const int Unknown4_BoyBuff__Unknown4 = Unknown4_BoyBuff__Unknown3 + 2; // Offset 140

			///  of the boy's max HP
			public const int BoyMaxHp = 142; // [x8E] (2 bytes)

			public const int Unknown5 = 144; // [x90] (10 bytes)

			///  of the boy's experience
			public const int BoyExperience = 154; // [x9A] (3 bytes)

			///  of the boy's level
			public const int BoyLevel = 157; // [x9D] (2 bytes)

			public const int Unknown6 = 159; // [x9F] (16 bytes)

			///  of the dog's current HP
			public const int DogCurrentHp = 175; // [xAF] (2 bytes)

			public const int Unknown7_DogBuff__BuffFlags = 177; // [xB1] Offset 177
			public const int Unknown7_DogBuff__Unknown1 = Unknown7_DogBuff__BuffFlags + 2; // Offset 179
			public const int Unknown7_DogBuff__Unknown2 = Unknown7_DogBuff__Unknown1 + 2; // Offset 181
			public const int Unknown7_DogBuff__Unknown3 = Unknown7_DogBuff__Unknown2 + 22; // Offset 203
			public const int Unknown7_DogBuff__Unknown7 = Unknown7_DogBuff__Unknown3 + 2; // Offset 205

			///  of the dog's max HP
			public const int DogMaxHp = 207; // [xCF] (2 bytes)

			public const int Unknown8 = 209; // [xD1] (10 bytes)

			///  of the dog's experience
			public const int DogExperience = 219; // [xDB] (3 bytes)

			///  of the dog's level
			public const int DogLevel = 222; // [xDE] (2 bytes)

			public const int Unknown9 = 224; // [xE0] (28 bytes)

			/// base money offset
			public const int Money = 252; // [xFC] (12 bytes)

			public const int Unknown10 = 264; // [x107] (13 bytes)

			/// base weapon Levels offset
			public const int WeaponLevels = 277; // [x115] (26 bytes)

			public const int Unknown11 = 303; // [x12F] (14 bytes)

			///  of the dog's attack level
			public const int DogAttackLevel = 317; // [x13D] (2 bytes)

			public const int Unknown12A = 319; // [x13F] (16 bytes)
			public const int Unknown12B = 335; // [x14F] (2 bytes)
			public const int Unknown12C = 337; // [x151] (4 bytes)

			/// base minor alchemy Levels offset
			public const int AlchemyMinorLevels = 341; // [x155] (70 bytes)

			public const int AlchemyMajorLevels = 411; // [x19B] (70 bytes)

			public const int Unknown13 = 481; // [x1E1] (22 bytes)

			///  of boy's alchemy offset
			public const int Alchemies = 503; // [x1F7] (5 bytes)

			public const int Unknown14 = 508; // [x1FC] (4 bytes) 

			///  of charms offset
			public const int Charms = 512; // [x200] (3 bytes)

			public const int Unknown15 = 515; // [x203] (118 bytes)

			///  of boy's weapon offset
			public const int Weapons = 633; // [x279] (2 bytes)

			public const int Unknown16A = 635; // [x27B] (4 bytes)
			public const int Unknown16B_GothicaFlags = 639; // [x27F] (4 bytes)
			public const int Unknown16C = 643; // [x283] (6 bytes)

			/// base alchemy ingredient offset
			public const int Ingredients = 649; // [x289] (22 bytes)

			/// base item offset
			public const int Items = 671; // [x29F] (8 bytes)

			/// base item offset
			public const int Armors = 679; // [x2A7] (40 bytes)

			/// base item offset
			public const int BazookaAmmunitions = 719; // [x2CF] (3 bytes)

			public const int Unknown17 = 722; // [x2D2] (67 bytes)

			/// base tradegood offset
			public const int TradeGoods = 789; // [x315] (26 bytes)

			public const int Unknown18 = 815; // [x32F] (2 bytes)
		}

		public const int SramUnknown1 = 3_270; // [xCC6]
	}
}