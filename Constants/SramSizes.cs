// ReSharper disable MemberHidesStaticFromOuterClass

using System;

namespace RosettaStone.Sram.SoE.Constants
{
	/// <summary>
	/// Known sizes of SoE's S-RAM buffer
	/// </summary>
	public class SramSizes
	{
		public const int AudioMode = 1;
		public const int LastSaveSlotId = 1;

		/// Size of the S-RAM Unknown buffer
		public const int Unknown1 = 4_922;

		/// Size of the S-RAM file
		public const int All = 8_192;

		public const bool IsValid = AudioMode + LastSaveSlotId + SaveSlot.All * 4 + Unknown1 == All;

		/// <summary>Sizes of save slot buffers</summary>
		public class SaveSlot
		{
			public const int Checksum = 2; // Offset 0
			public const int LastSavePointName = 36; // Offset 2
			public const int BoyName = 36; // Offset 38
			public const int DogName = 36; // Offset 74
			public const int BoyCurrentHp = 2; // Offset 110
			public const int Unknown4 = 30; // Offset 112
			public const int BoyMaxHp = 2; // Offset 142
			public const int Unknown5 = 10; // Offset 144 
			public const int BoyExperience = 3; // Offset 154
			public const int BoyLevel = 2; // Offset 157
			public const int Unknown6 = 16; // Offset 159
			public const int DogCurrentHp = 2; // Offset 175
			public const int Unknown7 = 30; // Offset 177
			public const int DogMaxHp = 2; // Offset 207
			public const int Unknown8 = 10; // Offset 209
			public const int DogExperience = 3; // Offset 219
			public const int DogLevel = 2; // Offset 222
			public const int Unknown9 = 28; // Offset 224
			public const int Money = 12; // Offset 252
			public const int Unknown10 = 13; // Offset 264
			public const int WeaponLevels = 26; // Offset 277
			public const int Unknown11 = 14; // Offset 303
			public const int DogAttackLevel = 2; // Offset 317

			public const int Unknown12A = 14; // Offset 319
			public const int Unknown12B = 4; // Offset 333
			public const int Unknown12C = 4; // Offset 337

			public const int AlchemyMinorLevels = 70; // Offset 341
			public const int AlchemyMajorLevels = 70; // Offset 411
			public const int Unknown13 = 22; // Offset 481
			public const int Alchemies = 5; // Offset 503
			public const int Unknown14 = 4; // Offset 508
			public const int Charms = 3; // Offset 512
			public const int Unknown15 = 118; // Offset 515
			public const int Weapons = 2; // Offset 633

			public const int Unknown16A = 4; // Offset 635
			public const int Unknown16B_GothicaFlags = 4; // Offset 639
			public const int Unknown16C = 6; // Offset 643

			public const int Ingredients = 22; // Offset 649
			public const int Items = 8; // Offset 671
			public const int Armors = 40; // Offset 679
			public const int BazookaAmmunitions = 3; // Offset 719 
			public const int Unknown17 = 67; // Offset 722
			public const int TradeGoods = 26; // Offset 789
			public const int Unknown18 = 2; // Offset 815

			public const int AllUnknown = Unknown4 + Unknown5 +
										  Unknown6 + Unknown7 + Unknown8 + Unknown9 + Unknown10 +
										  Unknown11 + Unknown12A + Unknown12B + Unknown12C + Unknown13 + Unknown14 + Unknown15 +
										  Unknown16A + Unknown16B_GothicaFlags + Unknown16C + Unknown17 + Unknown18;

			public const int AllKnown = Checksum + LastSavePointName + BoyName + DogName + BoyCurrentHp + BoyMaxHp + BoyExperience + 
			                            BoyLevel + DogCurrentHp + DogMaxHp + DogExperience + DogLevel + Money +
										WeaponLevels + DogAttackLevel + AlchemyMinorLevels + AlchemyMajorLevels + Alchemies +
										Charms + Weapons + Ingredients + Items + Armors + BazookaAmmunitions + TradeGoods;

			public const int Data = 815;
			public const int All = Data + Checksum;

			public static readonly double UnknownPercentage = AllUnknown * 100D / All;
			public static readonly double KnownPercentage = AllKnown * 100D / All;

			public const bool IsValid = AllKnown + AllUnknown == All;
		}
	}
}