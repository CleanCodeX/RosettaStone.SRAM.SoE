## Offsets

* Checksum = 0 (2 bytes)

* Unknown1 = 2 (36 bytes)

// the boy's name
* [BoyName](Items/CharacterName.md) = 38 (34 bytes)

* Unknown2 = 72 (2 bytes)

// the dog's name
* [DogName](Items/CharacterName.md) = 74 (34 bytes)

* Unknown3 = 108 (2 bytes)

// the boy's current HP
* BoyCurrentHp = 110 (2 bytes)

* [Unknown4_BoyBuff](Items/CharacterBuff.md).BuffFlags = 112 (Offset 112)
* Unknown4_BoyBuff.Unknown1 = Unknown4_BoyBuff.BuffFlags + 2 (Offset 114)
* Unknown4_BoyBuff.Unknown2 = Unknown4_BoyBuff.Unknown1 + 2 (Offset 116)
* Unknown4_BoyBuff.Unknown3 = Unknown4_BoyBuff.Unknown2 + 22 (Offset 138)
* Unknown4_BoyBuff.Unknown4 = Unknown4_BoyBuff.Unknown3 + 2 (Offset 140)

// the boy's max HP
* BoyMaxHp = 142 (2 bytes)

* Unknown5 = 144 (10 bytes)

// the boy's experience
* BoyExperience = 154 (3 bytes)

// the boy's level
* BoyLevel = 157 (2 bytes)

* Unknown6 = 159 (16 bytes)

// the dog's current HP
* DogCurrentHp = 175 (2 bytes)

* [Unknown7_DogBuff](Items/CharacterBuff.md).BuffFlags = 177 (Offset 177)
* Unknown7_DogBuff.Unknown1 = Unknown7_DogBuff.BuffFlags + 2 (Offset 179)
* Unknown7_DogBuff.Unknown2 = Unknown7_DogBuff.nknown1 + 2 (Offset 181)
* Unknown7_DogBuff.Unknown3 = Unknown7_DogBuff.Unknown2 + 22 (Offset 203)
* Unknown7_DogBuff.Unknown7 = Unknown7_DogBuff.Unknown3 + 2 (Offset 205)

// the dog's max HP
* DogMaxHp = 207 (2 bytes)

* Unknown8 = 209 (10 bytes)

// the dog's experience
* DogExperience = 219 (3 bytes)

// the dog's level
* DogLevel = 222 (2 bytes)

* Unknown9 = 224 (28 bytes)

// money offset
* [Moneys](Items/Moneys.md) = 252 (12 bytes)

* Unknown10 = 264 (13 bytes)

// weapon Levels offset
* [WeaponLevels](Items/WeaponLevels.md) = 277 (26 bytes)

* Unknown11 = 303 (14 bytes)

// the dog's attack level
* DogAttackLevel = 317 (2 bytes)

* Unknown12A = 319 (16 bytes)
* Unknown12B = 335 (2 bytes)
* Unknown12C = 337 (4 bytes)

// minor alchemy Levels offset
* [AlchemyMinorLevels](Items/AlchemyLevels.md) = 341 (70 bytes)

* [AlchemyMajorLevels](Items/AlchemyLevels.md) = 411 (70 bytes)

* [Unknown13](Items/Unknown13.md) = 481 (23 bytes)

// boy's alchemy offset
* [Alchemies](Items/Alchemies.md) = 503 (5 bytes)

* [Unknown14_AntiquaFlags](Items/Enums/Unknown14_AntiquaFlags.md) = 508 (4 bytes) 

// charms offset
* [Charms](Items/Charms.md) = 512 (3 bytes)

* [Unknown15](Items/Unknown15.md) = 515 (118 bytes)

// boy's weapon offset
* [Weapons](Items/Weapons.md) = 633 (2 bytes)

* Unknown16A = 635 (4 bytes)
* [Unknown16B_GoticaFlags](Items/Enums/Unknown16_GoticaFlags.md) = 639 (4 bytes)
* [Unknown16C](Items/Unknown16C.md) = 643 (6 bytes)

// alchemy ingredient offset
* [Ingredients](Items/Ingredients.md) = 649 (22 bytes)

// item offset
* [Items](Items/Items.md) = 671 (8 bytes)

// item offset
* [Armors](Items/Armors.md) = 679 (40 bytes)

// item offset
* [BazookaAmmunitions](Items/BazookaAmmunitions.md) = 719 (3 bytes)

* Unknown17 = 722 (67 bytes)

// tradegood offset
* [TradeGoods](Items/TradeGoods.md) = 789 (26 bytes)

* Unknown18 = 815 (2 bytes)