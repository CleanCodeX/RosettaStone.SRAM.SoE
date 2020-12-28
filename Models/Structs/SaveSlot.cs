#define EXPLICIT

using System.Runtime.InteropServices;
using SramFormat.SoE.Models.Enums;
using SramCommons.Models.Structs;
using SramFormat.SoE.Constants;
using SramFormat.SoE.Models.Structs.Unknown;

// ReSharper disable InconsistentNaming

namespace SramFormat.SoE.Models.Structs
{
#if EXPLICIT
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = Sizes.SaveSlot.All)]
#else
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
#endif
	public struct SaveSlot
	{
		// Unknown game file bytes: 462 of 817
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.Checksum)]
#endif
		public ushort Checksum; // 2 bytes

		// Unknown 1
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.Unknown1)]
#endif
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.SaveSlot.Unknown1)]
		public byte[] Unknown1; // 36 bytes

		// Boy & Dog character
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.BoyName)]
#endif
		public CharacterName BoyName; // 38 (34 bytes) Null terminated

		// Unknown 2
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.Unknown2)]
#endif
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.SaveSlot.Unknown2)]
		public byte[] Unknown2; // 72 (2 bytes)

#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.DogName)]
#endif
		public CharacterName DogName; // 74 (34 bytes) Null terminated

		// Unknown 3
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.Unknown3)]
#endif
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.SaveSlot.Unknown3)]
		public byte[] Unknown3; // 108 (2 bytes)

#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.BoyCurrentHp)]
#endif
		public ushort BoyCurrentHp; // 110 (2 bytes)
		// Unknown 4
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.Unknown4_BoyBuff__BuffFlags)]
#endif
		public CharacterBuff Unknown4_BoyBuff;

#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.BoyMaxHp)]
#endif
		public ushort BoyMaxHp; // 142 (2 bytes)

		// Unknown 5
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.Unknown5)]
#endif
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.SaveSlot.Unknown5)]
		public byte[] Unknown5; // 144 (10 bytes)

#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.BoyExperience)]
#endif
		public ThreeByteUInt BoyExperience; // 154 (3 Byte)
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.BoyLevel)]
#endif
		public ushort BoyLevel; // 157 (2 bytes)

		// Unknown 6
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.Unknown6)]
#endif
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.SaveSlot.Unknown6)]
		public byte[] Unknown6; // 159 (16 bytes)

#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.DogCurrentHp)]
#endif
		public ushort DogCurrentHp; // 175 (2 bytes)

		// Unknown 7
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.Unknown7_DogBuff__BuffFlags)]
#endif
		public CharacterBuff Unknown7_DogBuff; 

#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.DogMaxHp)]
#endif
		public ushort DogMaxHp; // 207 (2 bytes)

		// Unknown 8
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.Unknown8)]
#endif
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.SaveSlot.Unknown8)]
		public byte[] Unknown8; // 209 (10 bytes)

#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.DogExperience)] 
#endif
		public ThreeByteUInt DogExperience; // 219 (3 Byte)
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.DogLevel)]
#endif
		public ushort DogLevel; // 222 (2 bytes)

		// Unknown 9
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.Unknown9)]
#endif
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.SaveSlot.Unknown9)]
		public byte[] Unknown9; // 224 (28 bytes)

		// Money
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.Money)]
#endif
		public Moneys Moneys; // 252 (12 bytes)

		// Unknown 10
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.Unknown10)]
#endif
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.SaveSlot.Unknown10)]
		public byte[] Unknown10; // 264 (13 bytes)

		// Weapon Levels
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.WeaponLevels)]
#endif
		public WeaponLevels WeaponLevels; // 277 (26 bytes)

		// Unknown 11
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.Unknown11)]
#endif
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.SaveSlot.Unknown11)]
		public byte[] Unknown11; // 303 (14 bytes)

#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.DogAttackLevel)]
#endif
		public WeaponLevel DogAttackLevel; // 317 (2 bytes)

		// Unknown 12 A
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.Unknown12A)]
#endif
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.SaveSlot.Unknown12A)]
		public byte[] Unknown12A; // 319 (16 bytes)

		// Unknown 12 B
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.Unknown12B)]
#endif
		public ushort Unknown12B;// 335 (2 bytes) Maybe frame-counter, changes at every in-game save

		// Unknown 12 C
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.Unknown12C)]
#endif
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.SaveSlot.Unknown12C)]
		public byte[] Unknown12C; // 337 (4 bytes)

		// Alchemy Levels
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.AlchemyMinorLevels)]
#endif
		public AlchemyLevels AlchemyMinorLevels; // 341 (70 bytes)

#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.AlchemyMajorLevels)] 
#endif
		public AlchemyLevels AlchemyMajorLevels; // 411 (70 bytes)

		// Unknown 13
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.Unknown13)]
#endif
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.SaveSlot.Unknown13)]
		public byte[] Unknown13; // 481 (22 bytes)

		// Weapons
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.Alchemies)]
#endif
		public Alchemies Alchemies; // 503 (5 bytes)

		// Unknown 14
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.Unknown14_AntiquaFlags)]
#endif
		public Unknown14_AntiquaFlags Unknown14_AntiquaFlags; // 508 (4 bytes) 

		// Charms
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.Charms)]
#endif
		public Charms Charms; // 512 (3 bytes)

		// Unknown 15
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.Unknown15)]
#endif
		public Unknown15 Unknown15; // 515 (118 bytes)

		// Weapons
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.Weapons)]
#endif
		public Weapons Weapons; // 633 (2 bytes)

		// Unknown 16

#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.Unknown16A)]
#endif
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.SaveSlot.Unknown16A)]
		public byte[] Unknown16A; // 635 (4 bytes) 

#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.Unknown16B_GothicaFlags)]
#endif
		public Unknown16_GothicaFlags Unknown16B_GothicaFlags; // 639 (4 bytes)

#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.Unknown16A)]
#endif
		public Unknown16C Unknown16C; // 643 (6 bytes) 

		// Ingredients
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.Ingredients)]
#endif
		public Ingredients Ingredients; // 649 (22 bytes)

		// Items
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.Items)]
#endif
		public Items Items; // 671 (8 bytes)

#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.Armors)]
#endif
		public Armors Armors; // 679 (40 bytes)

#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.BazookaAmmunitions)]
#endif
		public BazookaAmmunitions BazookaAmmunitions; // 719 (3 bytes)

		// Unknown 17
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.Unknown17)]
#endif
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.SaveSlot.Unknown17)]
		public byte[] Unknown17; // 722 (67 bytes)

		// Trade Goods
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.TradeGoods)]
#endif
		public TradeGoods TradeGoods; // 789 (26 bytes)

		// Unknown 18
#if EXPLICIT
		[FieldOffset(Offsets.SaveSlot.Unknown18)]
#endif
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = Sizes.SaveSlot.Unknown18)]
		public byte[] Unknown18; // 816 (2 bytes)
	}
}