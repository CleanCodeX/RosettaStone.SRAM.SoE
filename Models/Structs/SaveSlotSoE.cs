using System.Runtime.InteropServices;
using System.Text;
using RosettaStone.Sram.SoE.Constants;
using RosettaStone.Sram.SoE.Models.Enums;
using RosettaStone.Sram.SoE.Models.Structs.Unknown;
using SramCommons.Models.Structs;

// ReSharper disable InconsistentNaming

namespace RosettaStone.Sram.SoE.Models.Structs
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct SaveSlotSoE
	{
		public ushort Checksum; // [0] ~ (2 bytes)

		// Data
		public SaveSlotDataSoE Data; // [2|x02] ~ (815 bytes)

		public override string ToString() => Data.ToString();
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct SaveSlotDataSoE
	{
		// Last save point
		public FixedLengthString LastSavePointName; // [2|x02] ~ (36 bytes, null terminated)

		// Boy & Dog character
		public FixedLengthString BoyName; // [38|x26] ~ (36 bytes, null terminated)
		public FixedLengthString DogName; // [74|x4A] ~ (36 bytes, null terminated)

		public ushort BoyCurrentHp; // [110|x69] ~ (30 bytes)
		
		// Unknown 4
		public CharacterBuff Unknown4_BoyBuff; // [112|x70] ~ (30 bytes)

		public ushort BoyMaxHp; // [142|x8E] ~ (2 bytes)

		// Unknown 5
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown5)]
		public byte[] Unknown5; // [144|x90] ~ (10 bytes)

		public ThreeByteUInt BoyExperience; // [154|x9A] ~ (3 bytes)

		public ushort BoyLevel; // [157|x9D] ~ (2 bytes)

		// Unknown 6
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown6)]
		public byte[] Unknown6; // [159|x9F] ~ (16 bytes)

		public ushort DogCurrentHp; // [175|xAF] ~ (2 bytes)

		// Unknown 7
		public CharacterBuff Unknown7_DogBuff; // [177|xB1] ~ (30 bytes)

		public ushort DogMaxHp; // [207|xCF] ~ (2 bytes)

		// Unknown 8
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown8)]
		public byte[] Unknown8; // [209|xD1] ~ (10 bytes)

		public ThreeByteUInt DogExperience; // [219|xDB] ~ (3 bytes)

		public ushort DogLevel; // [222|xDE] ~ (2 bytes)

		// Unknown 9
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown9)]
		public byte[] Unknown9; // [224|xE0] ~ (28 bytes)

		// Money
		public Moneys Moneys; // [252|xFC] ~ (12 bytes)

		// Unknown 10
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown10)]
		public byte[] Unknown10; // [264|x107] ~ (13 bytes)

		// Weapon Levels
		public WeaponLevels WeaponLevels; // [277|x115] ~ (26 bytes)

		// Unknown 11
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown11)]
		public byte[] Unknown11; // [303|x12F] ~ (14 bytes)

		public WeaponLevel DogAttackLevel; // [317|x13D] ~ (2 bytes)

		// Unknown 12 A
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown12A)]
		public byte[] Unknown12A; // [319|x13F] ~ (16 bytes)

		// Unknown 12 B
		public ushort Unknown12B;// 335|x14F] ~ (2 bytes) Note: contains probably frame-counter, changes at every in-game save

		// Unknown 12 C
		public uint Unknown12C; // [337|x151] ~ (4 bytes)

		// Alchemy Levels
		public AlchemyLevels AlchemyMinorLevels; // [341|x155] ~ (70 bytes)

		public AlchemyLevels AlchemyMajorLevels; // [411|x19B] ~ (70 bytes)

		// Unknown 13
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown13)]
		public byte[] Unknown13; // [481|x1E1] ~ (22 bytes)

		// Weapons
		public Alchemies Alchemies; // [503|x1F7] ~ (5 bytes)


		// Unknown 14
		public Unknown14 Unknown14; // [508|x1FC] ~ (4 bytes) 

		// Charms
		public Charms Charms; // [512|x200] ~ (3 bytes)

		// Unknown 15
		public Unknown15 Unknown15; // [515|x203] ~ (118 bytes)

		// Weapons
		public Weapons Weapons; // [633|x279] ~ (2 bytes)

		// Unknown 16
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown16A)]
		public byte[] Unknown16A; // [635|x27B] ~ (4 bytes) 

		public Unknown16_GothicaFlags Unknown16B_GothicaFlags; // [639|x27F] ~ (4 bytes)

		public Unknown16C Unknown16C; // [643|x283] ~ (6 bytes) 

		// Ingredients
		public Ingredients Ingredients; // [649|x289] ~ (22 bytes)

		// Items
		public Items Items; // [671|x29F] ~ (8 bytes)

		public Armors Armors; // [679|x2A7] ~ (40 bytes)

		public BazookaAmmunitions BazookaAmmunitions; // [719|x2CF] ~ (3 bytes)

		// Unknown 17
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown17)]
		public byte[] Unknown17; // [722|x2D2] ~ (67 bytes) Note: contains market timer

		// Trade Goods
		public TradeGoods TradeGoods; // [789|x315] ~ (26 bytes)

		// Unknown 18
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown18)]
		public byte[] Unknown18; // [815|x32F] ~ (2 bytes)

		public override string ToString()
		{
			var sb = new StringBuilder();

			sb.AppendLine($"{nameof(LastSavePointName)}: {LastSavePointName}");
			sb.AppendLine($"{nameof(BoyName)}: {BoyName}");
			sb.AppendLine($"{nameof(DogName)}: {DogName}");
			sb.AppendLine($"{nameof(BoyCurrentHp)}: {BoyCurrentHp}");
			sb.AppendLine($"{nameof(Unknown4_BoyBuff)}: {Unknown4_BoyBuff}");
			sb.AppendLine($"{nameof(BoyMaxHp)}: {BoyMaxHp}");
			sb.AppendLine($"{nameof(Unknown5)}: {Unknown5}");
			sb.AppendLine($"{nameof(BoyExperience)}: {BoyExperience}");
			sb.AppendLine($"{nameof(BoyLevel)}: {BoyLevel}");
			sb.AppendLine($"{nameof(Unknown6)}: {Unknown6}");
			sb.AppendLine($"{nameof(DogCurrentHp)}: {DogCurrentHp}");
			sb.AppendLine($"{nameof(Unknown7_DogBuff)}: {Unknown7_DogBuff}");
			sb.AppendLine($"{nameof(DogMaxHp)}: {DogMaxHp}");
			sb.AppendLine($"{nameof(Unknown8)}: {Unknown8}");
			sb.AppendLine($"{nameof(DogExperience)}: {DogExperience}");
			sb.AppendLine($"{nameof(DogLevel)}: {DogLevel}");
			sb.AppendLine($"{nameof(Unknown9)}: {Unknown9}");
			sb.AppendLine($"{nameof(Moneys)}: {Moneys}");
			sb.AppendLine($"{nameof(Unknown10)}: {Unknown10}");
			sb.AppendLine($"{nameof(WeaponLevels)}: {WeaponLevels}");
			sb.AppendLine($"{nameof(Unknown11)}: {Unknown11}");
			sb.AppendLine($"{nameof(DogAttackLevel)}: {DogAttackLevel}");
			sb.AppendLine($"{nameof(Unknown12A)}: {Unknown12A}");
			sb.AppendLine($"{nameof(Unknown12B)}: {Unknown12B}");
			sb.AppendLine($"{nameof(Unknown12C)}: {Unknown12C}");
			sb.AppendLine($"{nameof(AlchemyMinorLevels)}: {AlchemyMinorLevels}");
			sb.AppendLine($"{nameof(AlchemyMajorLevels)}: {AlchemyMajorLevels}");
			sb.AppendLine($"{nameof(Unknown13)}: {Unknown13}");
			sb.AppendLine($"{nameof(Alchemies)}: {Alchemies}");
			sb.AppendLine($"{nameof(Unknown14)}: {Unknown14}");
			sb.AppendLine($"{nameof(Charms)}: {Charms}");
			sb.AppendLine($"{nameof(Unknown15)}: {Unknown15}");
			sb.AppendLine($"{nameof(Weapons)}: {Weapons}");
			sb.AppendLine($"{nameof(Unknown16A)}: {Unknown16A}");
			sb.AppendLine($"{nameof(Unknown16B_GothicaFlags)}: {Unknown16B_GothicaFlags}");
			sb.AppendLine($"{nameof(Unknown16C)}: {Unknown16C}");
			sb.AppendLine($"{nameof(Ingredients)}: {Ingredients}");
			sb.AppendLine($"{nameof(Items)}: {Items}");
			sb.AppendLine($"{nameof(Armors)}: {Armors}");
			sb.AppendLine($"{nameof(BazookaAmmunitions)}: {BazookaAmmunitions}");
			sb.AppendLine($"{nameof(Unknown17)}: {Unknown17}");
			sb.AppendLine($"{nameof(TradeGoods)}: {TradeGoods}");
			sb.AppendLine($"{nameof(Unknown18)}: {Unknown18}");

			return sb.ToString();
		}
	}
}