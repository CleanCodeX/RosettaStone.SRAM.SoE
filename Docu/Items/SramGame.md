# SRAM Game

// Unknown game file bytes: 462 of 817
* UInt16 Checksum // 2 bytes

// Unknown 1
* byte[] Unknown1 // 36 bytes

// Boy & Dog character
* [BoyName](CharacterName.md) // 38 (34 bytes) 

// Unknown 2
* byte[] Unknown2 // 72 (2 bytes)

* [DogName](CharacterName.md) // 74 (34 bytes) 

// Unknown 3
* byte[] Unknown3 // 108 (2 bytes)

* UInt16 BoyCurrentHp // 110 (2 bytes)
// Unknown 4
* [Unknown4_BoyBuff](CharacterBuff.md) 

* UInt16 BoyMaxHp // 142 (2 bytes)

// Unknown 5
* byte[] Unknown5 // 144 (10 bytes)

* UInt24 BoyExperience // 154 (3 bytes)

* UInt16 BoyLevel // 157 (2 bytes)

// Unknown 6
* byte[] Unknown6 // 159 (16 bytes)

* UInt16 DogCurrentHp // 175 (2 bytes)

// Unknown 7
* [Unknown7_DogBuff](CharacterBuff.md)  

* UInt16 DogMaxHp // 207 (2 bytes)

// Unknown 8
* byte[] Unknown8 // 209 (10 bytes)

* UInt24 DogExperience // 219 (3 bytes)

* UInt16 DogLevel // 222 (2 bytes)

// Unknown 9
* byte[] Unknown9 // 224 (28 bytes)

// Money
* [Moneys](Moneys.md) // 252 (12 bytes)

// Unknown 10
* byte[] Unknown10 // 264 (13 bytes)

// Weapon Levels
* [WeaponLevels](WeaponLevels.md) // 277 (26 bytes)

// Unknown 11
* byte[] Unknown11 // 303 (14 bytes)

* [DogAttackLevel](WeaponLevel.md) // 317 (2 bytes)

// Unknown 12 A
* byte[] Unknown12A // 319 (16 bytes)

// Unknown 12 B
* UInt16 Unknown12B// 335 (2 bytes) Maybe frame-counter, changes at every in-game save

// Unknown 12 C
* byte[] Unknown12C // 337 (4 bytes)

// Alchemy Levels
* [AlchemyMinorLevels](AlchemyLevels.md) // 341 (70 bytes)

* [AlchemyMajorLevels](AlchemyLevels.md) // 411 (70 bytes)

// Unknown 13
* byte[] Unknown13 // 481 (22 bytes)

// Weapons
* Alchemies Alchemies // 503 (5 bytes)

// Unknown 14
* [Unknown14](Enums/Unknown14_AntiquaFlags.md) // 508 (4 bytes) 

// Charms
* [Charms](Charms.md) Charms // 512 (3 bytes)

// Unknown 15
* [Unknown15](Unknown15.md) Unknown15 // 515 (118 bytes)

// Weapons
* [Weapons](Weapons.md) Weapons // 633 (2 bytes)

// Unknown 16

* byte[] Unknown16A // 635 (4 bytes) 

* [Unknown16](Enums/Unknown16_GothicaFlags.md) // 639 (4 bytes)

* [Unknown16C](Unknown16C.md) // 643 (6 bytes) 

// Ingredients
* [Ingredients](Ingredients.md) // 649 (22 bytes)

// Items
* [Items](Items.md) // 671 (8 bytes)

* [Armors](Armors.md) // 679 (40 bytes)

* [BazookaAmmunitions](BazookaAmmunitions.md) // 719 (3 bytes)

// Unknown 17
* byte[] Unknown17 // 722 (67 bytes)

// Trade Goods
* [TradeGoods](TradeGoods.md) // 789 (26 bytes)

// Unknown 18
* byte[] Unknown18 // 816 (2 bytes)

