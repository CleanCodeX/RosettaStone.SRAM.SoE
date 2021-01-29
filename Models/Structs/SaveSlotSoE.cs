using System;
using System.Runtime.InteropServices;
using IO.Extensions;
using IO.Helpers;
using SRAM.SoE.Models.Structs.Chunks;

// ReSharper disable BuiltInTypeReferenceStyle

namespace SRAM.SoE.Models.Structs
{
	/// <summary>
	/// The saveslot actually consists of a large data chunk and a preceding checksum
	/// </summary>
	/// <remarks>817 bytes</remarks>
	[HasComplexMembers]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct SaveSlotSoE
	{
		public UInt16 Checksum; // [0] :: (2 bytes)
		public SaveSlotDataSoE Data; // [2|x02] :: (815 bytes)

		public override string ToString() => Data.ToString();
	}

	/// <summary>
	/// Thge actual save slot data, without checksum
	/// </summary>
	/// <remarks>815 bytes</remarks>
	[HasComplexMembers]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]	
	public struct SaveSlotDataSoE
	{
		// Last save point [2|x02] :: (36 bytes, null terminated)
		public FixedLengthString LastSavePointName; 

		//BoyName, dogName [38|x26] :: (72 bytes)
		public Chunk01 BoyNameDogName;

		// BoyCurrentHp [110|x6E] :: (2 bytes)
		public Chunk02 BoyCurrentHp;

		// BoyStatusBuffs [112|x70] :: (24 bytes)
		public Chunk03 BoyStatusBuffs;

		// Chunk04 [136|x88] :: (6 bytes)
		public Chunk04 Chunk04;

		// BoyMaxHp [142|x8E] :: (2 bytes)
		public Chunk05 BoyMaxHp;

		// BoyStats1 [144|x90] :: (13 bytes)
		public Chunk06 BoyStats1;

		// BoyLevel [157|x9D] :: (2 bytes)
		public Chunk07 BoyLevel;

		// BoyStats2 [161|xA1] :: (14 bytes)
		public Chunk08 BoyStats2;

		// DogCurrentHp [175|xAF] :: (2 bytes)
		public Chunk09 DogCurrentHp;

		// Dog Status Buffs [177|xB1] :: (24 bytes)
		public Chunk10 DogStatusBuffs;

		// Unknown 7 [201|xC9] :: (6 bytes)
		public Chunk11 Chunk11;

		// DogMaxHp [207|xCF] :: (2 bytes)
		public Chunk12 DogMaxHp;

		// Chunk13_DogStats1 [209|xD1] :: (13 bytes)
		public Chunk13 DogStats1;

		// Chunk14_DogLevel [222|xDE] :: (4 bytes)
		public Chunk14 DogLevel;

		// Chunk15_DogStats2 [226|xE4] :: (14 bytes) 
		public Chunk15 DogStats2;

		// Chunk16_EquWeapon_Moneys_EquAlchemies_WeaponLvls_DogAtkLvl [240|xF0] :: (101 bytes)
		public Chunk16 EquippedStuff_Moneys_Levels;

		// Chunk17_AlchemyLevels [341|x155] :: (162 bytes)
		public Chunk17 AlchemyLevels;

		// Alchemies_Charms_Spots_Weapons [503|x1F7] :: (146 bytes)
		public Chunk18 Collectables_Spots;

		// Ingredients_Items_Armors_Ammo_FlyingMachine [649|x289] :: (92 bytes)
		public Chunk19 PossessedStuff;

		// LastLanding_CurrentWeapon [741|x2E5] :: (44 bytes)
		public Chunk20 LastLanding_CurrentWeapon;

		// TradeGoods [785|x311] :: (32 bytes)
		public Chunk21 TradeGoods;

		public override string ToString() => this.FormatAsString();
	}
}