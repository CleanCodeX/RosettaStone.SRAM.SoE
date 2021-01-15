using System.Runtime.InteropServices;
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
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct SaveSlotDataSoE
	{
		// Last save point
		public FixedString LastSavePointName; // [2|x02] ~ (36 bytes)

		// Boy & Dog character
		public FixedString BoyName; // [38|x26] ~ (36 bytes) Null terminated
		public FixedString DogName; // [74|x4A] ~ (36 bytes) Null terminated

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
		public ushort Unknown12B;// 335|x14F] ~ (2 bytes) Maybe frame-counter, changes at every in-game save

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
		public byte[] Unknown17; // [722|x2D2] ~ (67 bytes)

		// Trade Goods
		public TradeGoods TradeGoods; // [789|x315] ~ (26 bytes)

		// Unknown 18
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown18)]
		public byte[] Unknown18; // [815|x32F] ~ (2 bytes)
	}
}