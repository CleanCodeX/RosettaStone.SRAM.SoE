# SRAM Game

// Unknown game file bytes: 462 of 817
* UInt16 Checksum // 2 bytes

// Unknown 1
* byte[] Unknown1 // 36 bytes

// Boy & Dog character
* [CharacterName](CharacterName.md) BoyName // 38 (34 bytes) Null terminated

// Unknown 2
* byte[] Unknown2 // 72 (2 bytes)

* [CharacterName](CharacterName.md) DogName // 74 (34 bytes) Null terminated

// Unknown 3
* byte[] Unknown3 // 108 (2 bytes)

* UInt16 BoyCurrentHp // 110 (2 bytes)
// Unknown 4
* [CharacterBuff](CharacterBuff.md) Unknown4_BoyBuff

* UInt16 BoyMaxHp // 142 (2 bytes)

// Unknown 5
* byte[] Unknown5 // 144 (10 bytes)

* UInt24 BoyExperience // 154 (3 Byte)

* UInt16 BoyLevel // 157 (2 bytes)

// Unknown 6
* byte[] Unknown6 // 159 (16 bytes)

* UInt16 DogCurrentHp // 175 (2 bytes)

// Unknown 7
* [CharacterBuff](CharacterBuff.md) Unknown7_DogBuff 

* UInt16 DogMaxHp // 207 (2 bytes)

// Unknown 8
* byte[] Unknown8 // 209 (10 bytes)

* UInt24 DogExperience // 219 (3 Byte)

* UInt16 DogLevel // 222 (2 bytes)

// Unknown 9
* byte[] Unknown9 // 224 (28 bytes)

// Money
* [Moneys](Moneys.md) Moneys // 252 (12 bytes)

// Unknown 10
* byte[] Unknown10 // 264 (13 bytes)

// Weapon Levels
* [WeaponLevels](WeaponLevels.md) WeaponLevels // 277 (26 bytes)

// Unknown 11
* byte[] Unknown11 // 303 (14 bytes)

* [WeaponLevel](WeaponLevel.md) DogAttackLevel // 317 (2 bytes)

// Unknown 12 A
* byte[] Unknown12A // 319 (16 bytes)

// Unknown 12 B
* UInt16 Unknown12B// 335 (2 bytes) Maybe frame-counter, changes at every in-game save

// Unknown 12 C
* byte[] Unknown12C // 337 (4 bytes)

// Alchemy Levels
* [AlchemyLevels](AlchemyLevels.md) AlchemyMinorLevels // 341 (70 bytes)

* [AlchemyLevels](AlchemyLevels.md) AlchemyMajorLevels // 411 (70 bytes)

// Unknown 13
* byte[] Unknown13 // 481 (22 bytes)

// Weapons
* Alchemies Alchemies // 503 (5 bytes)

// Unknown 14
* [Unknown14_AntiquaFlags](Enums/Unknown14_AntiquaFlags.md) Unknown14_AntiquaFlags // 508 (4 bytes) 

// Charms
* [Charms](Charms.md) Charms // 512 (3 bytes)

// Unknown 15
* [Unknown15](Unknown15.md) Unknown15 // 515 (118 bytes)

// Weapons
* [Weapons](Weapons.md) Weapons // 633 (2 bytes)

// Unknown 16

* byte[] Unknown16A // 635 (4 bytes) 

* [Unknown16_GothicaFlags](Enums/Unknown16_GothicaFlags.md) Unknown16B_GoticaFlags // 639 (4 bytes)

* [Unknown16C](Unknown16C.md) Unknown16C // 643 (6 bytes) 

// Ingredients
* [Ingredients](Ingredients.md) Ingredients // 649 (22 bytes)

// Items
* [Items](Items.md) Items // 671 (8 bytes)

* [Armors](Armors.md) Armors // 679 (40 bytes)

* [BazookaAmmunitions](BazookaAmmunitions.md) BazookaAmmunitions // 719 (3 bytes)

// Unknown 17
* byte[] Unknown17 // 722 (67 bytes)

// Trade Goods
* [TradeGoods](TradeGoods.md) TradeGoods // 789 (26 bytes)

// Unknown 18
* byte[] Unknown18 // 816 (2 bytes)

