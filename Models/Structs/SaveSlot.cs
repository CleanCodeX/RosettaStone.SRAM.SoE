using System.Runtime.InteropServices;
using SramFormat.SoE.Models.Enums;
using SramCommons.Models.Structs;
using SramFormat.SoE.Constants;
using SramFormat.SoE.Models.Structs.Unknown;

// ReSharper disable InconsistentNaming

namespace SramFormat.SoE.Models.Structs
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct SaveSlot
	{
		// Unknown game file bytes: 462 of 817
		public ushort Checksum; // 2 bytes

		// Unknown 1
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.SaveSlot.Unknown1)]
		public byte[] Unknown1; // 36 bytes

		// Boy & Dog character
		public CharacterName BoyName; // 38 (34 bytes) Null terminated

		// Unknown 2
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.SaveSlot.Unknown2)]
		public byte[] Unknown2; // 72 (2 bytes)

		public CharacterName DogName; // 74 (34 bytes) Null terminated

		// Unknown 3
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.SaveSlot.Unknown3)]
		public byte[] Unknown3; // 108 (2 bytes)

		public ushort BoyCurrentHp; // 110 (2 bytes)
		// Unknown 4
		public CharacterBuff Unknown4_BoyBuff;

		public ushort BoyMaxHp; // 142 (2 bytes)

		// Unknown 5
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.SaveSlot.Unknown5)]
		public byte[] Unknown5; // 144 (10 bytes)

		public ThreeByteUInt BoyExperience; // 154 (3 Byte)
		
		public ushort BoyLevel; // 157 (2 bytes)

		// Unknown 6
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.SaveSlot.Unknown6)]
		public byte[] Unknown6; // 159 (16 bytes)

		public ushort DogCurrentHp; // 175 (2 bytes)

		// Unknown 7
		public CharacterBuff Unknown7_DogBuff; 

		public ushort DogMaxHp; // 207 (2 bytes)

		// Unknown 8
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.SaveSlot.Unknown8)]
		public byte[] Unknown8; // 209 (10 bytes)

		public ThreeByteUInt DogExperience; // 219 (3 Byte)

		public ushort DogLevel; // 222 (2 bytes)

		// Unknown 9
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.SaveSlot.Unknown9)]
		public byte[] Unknown9; // 224 (28 bytes)

		// Money
		public Moneys Moneys; // 252 (12 bytes)

		// Unknown 10
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.SaveSlot.Unknown10)]
		public byte[] Unknown10; // 264 (13 bytes)

		// Weapon Levels
		public WeaponLevels WeaponLevels; // 277 (26 bytes)

		// Unknown 11
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.SaveSlot.Unknown11)]
		public byte[] Unknown11; // 303 (14 bytes)

		public WeaponLevel DogAttackLevel; // 317 (2 bytes)

		// Unknown 12 A
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.SaveSlot.Unknown12A)]
		public byte[] Unknown12A; // 319 (16 bytes)

		// Unknown 12 B
		public ushort Unknown12B;// 335 (2 bytes) Maybe frame-counter, changes at every in-game save

		// Unknown 12 C
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.SaveSlot.Unknown12C)]
		public byte[] Unknown12C; // 337 (4 bytes)

		// Alchemy Levels
		public AlchemyLevels AlchemyMinorLevels; // 341 (70 bytes)

		public AlchemyLevels AlchemyMajorLevels; // 411 (70 bytes)

		// Unknown 13
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.SaveSlot.Unknown13)]
		public byte[] Unknown13; // 481 (22 bytes)

		// Weapons
		public Alchemies Alchemies; // 503 (5 bytes)

		// Unknown 14
		public Unknown14 Unknown14; // 508 (4 bytes) 

		// Charms
		public Charms Charms; // 512 (3 bytes)

		// Unknown 15
		public Unknown15 Unknown15; // 515 (118 bytes)

		// Weapons
		public Weapons Weapons; // 633 (2 bytes)

		// Unknown 16
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.SaveSlot.Unknown16A)]
		public byte[] Unknown16A; // 635 (4 bytes) 

		public Unknown16_GothicaFlags Unknown16B_GothicaFlags; // 639 (4 bytes)

		public Unknown16C Unknown16C; // 643 (6 bytes) 

		// Ingredients
		public Ingredients Ingredients; // 649 (22 bytes)

		// Items
		public Items Items; // 671 (8 bytes)

		public Armors Armors; // 679 (40 bytes)

		public BazookaAmmunitions BazookaAmmunitions; // 719 (3 bytes)

		// Unknown 17
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.SaveSlot.Unknown17)]
		public byte[] Unknown17; // 722 (67 bytes)

		// Trade Goods
		public TradeGoods TradeGoods; // 789 (26 bytes)

		// Unknown 18
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.SaveSlot.Unknown18)]
		public byte[] Unknown18; // 816 (2 bytes)
	}
}