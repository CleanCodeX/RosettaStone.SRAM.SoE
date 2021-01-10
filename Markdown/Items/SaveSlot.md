# SRAM Save Slot

###### Unknown game file bytes: 462 of 817
* UInt16 Checksum # [0] ~ (2 bytes)

###### Unknown 1
* byte[] Unknown1 # [2|x02] ~ (36 bytes)

###### Boy & Dog character
* [BoyName](CharacterName.md) # [38|x26] ~ (34 bytes) 

###### Unknown 2
* byte[] Unknown2 # [74|x4A] ~ (2 bytes)

###### The dog's name
* [DogName](CharacterName.md) # [74|x4A] ~ (34 bytes) 

###### Unknown 3
* byte[] Unknown3 # [108|x67] ~ (2 bytes)

###### The boy's current HP'
* UInt16 BoyCurrentHp # [110|x6E] ~ (2 bytes)

###### Unknown 4
* [Unknown4_BoyBuff](CharacterBuff.md) # [112|x70] ~ (30 bytes)

###### The boy's max HP
* UInt16 BoyMaxHp # [142|x8E] ~ (2 bytes)

###### Unknown 5
* byte[] Unknown5 # [144|x90] ~ (10 bytes)

###### The boy's experience
* UInt24 BoyExperience # [154|x9A] ~ (3 bytes)

###### The boy's level
* UInt16 BoyLevel # [157|x9D] ~ (2 bytes)

###### Unknown 6
* byte[] Unknown6 # [159|x9F] ~ (16 bytes)

###### The dog's current HP
* UInt16 DogCurrentHp # [175|xAF] ~ (2 bytes)

###### Unknown 7
* [Unknown7_DogBuff](CharacterBuff.md) # [177|xB1] ~ (30 bytes)

###### The dog's max HP
* UInt16 DogMaxHp # [207|xCF] ~ (2 bytes)

###### Unknown 8
* byte[] Unknown8 # [209|xD1] ~ (10 bytes)

###### The dog's experience
* UInt24 DogExperience # [219|xDB] ~ (3 bytes)

###### The dog's level
* UInt16 DogLevel # [222|xDE] ~ (2 bytes)

###### Unknown 9
* byte[] Unknown9 # [224|xE0] ~ (28 bytes)

###### Moneys
* [Moneys](Moneys.md) # [252|xFC] ~ (12 bytes)

###### Unknown 10
* byte[] Unknown10 # [264|x107] ~ (13 bytes)

###### Weapon Levels
* [WeaponLevels](WeaponLevels.md) # [277|x115] ~ (26 bytes)

###### Unknown 11
* byte[] Unknown11 # [303|x12F] ~ (14 bytes)

###### The dogs's attack level
* [DogAttackLevel](WeaponLevel.md) # [317|x13D] ~ (2 bytes)

###### Unknown 12 A
* byte[] Unknown12A # [319|x13F] ~ (16 bytes)

###### Unknown 12 B
* UInt16 Unknown12B # 335|x14F] ~ (2 bytes) Maybe frame-counter, changes at every in-game save

###### Unknown 12 C
* UInt32 Unknown12C # [337|x151] ~ (4 bytes)

###### Alchemy Levels
* [AlchemyMinorLevels](AlchemyLevels.md) # [341|x155] ~ (70 bytes)
* [AlchemyMajorLevels](AlchemyLevels.md) # [411|x19B] ~ (70 bytes)

###### Unknown 13
* byte[] Unknown13 # [481|x1E1] ~ (22 bytes)

###### Weapons
* Alchemies Alchemies # [503|x1F7] ~ (5 bytes)

###### Unknown 14
* [Unknown14](Enums/Unknown14.md) # [508|x1FC] ~ (4 bytes) 

###### Charms
* [Charms](Enums/Charm.md) # [512|x200] ~ (3 bytes)

###### Unknown 15
* [Unknown15](Unknown15.md) # [515|x203] ~ (118 bytes)

###### Weapons
* [Weapons](Weapons.md) # [633|x279] ~ (2 bytes)

###### Unknown 16
* byte[] Unknown16A # [635|x27B] ~ (4 bytes) 
* [Unknown16B_GothicaFlags](Enums/Unknown16B_GothicaFlags.md) # [639|x27F] ~ (4 bytes)
* [Unknown16C](Unknown16C.md) # [643|x283] ~ (6 bytes) 

###### Ingredients
* [Ingredients](Ingredients.md) # [649|x289] ~ (22 bytes)

###### Items
* [Items](Items.md) # [671|x29F] ~ (8 bytes)

###### Armors
* [Armors](Armors.md) # [679|x2A7] ~ (40 bytes)

###### Bazooka Ammunitions
* [BazookaAmmunitions](BazookaAmmunitions.md) # [719|x2CF] ~ (3 bytes)

###### Unknown 17
* byte[] Unknown17 # [722|x2D2] ~ (67 bytes)

###### Trade Goods
* [TradeGoods](TradeGoods.md) # [789|x315] ~ (26 bytes)

###### Unknown 18
* byte[] Unknown18 # [815|x32F] ~ (2 bytes)

