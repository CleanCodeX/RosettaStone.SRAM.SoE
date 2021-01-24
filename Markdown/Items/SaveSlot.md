# S-RAM Save Slot (817 bytes)

###### Checksum
* UInt16 Checksum # [0] (2 bytes)

###### Last save point 
* [LastSavePointName](FixedLengthString.md) # [2|x02] : (36 bytes, null terminated)

###### BoyName, dogName 
* [BoyNameDogName](Chunks/Chunk01.md) # [38|x26] : (72 bytes)

###### BoyCurrentHp 
* [BoyCurrentHp](Chunks/Chunk02.md) # [110|x6E] : (2 bytes)

###### BoyStatusBuffs 
* [BoyStatusBuffs](Chunks/Chunk03.md) # [112|x70] : (24 bytes)

###### Chunk04 
* [Chunk04](Chunks/Chunk04.md) # [136|x88] : (6 bytes)

###### BoyHpNextLevel 
* [BoyHpNextLevel](Chunks/Chunk05.md) # [142|x8E] : (2 bytes)

###### BoyStats1 
* [BoyStats1](Chunks/Chunk06.md) # [144|x90] : (13 bytes)

###### BoyLevel 
* [BoyLevel](Chunks/Chunk07.md) # [157|x9D] : (2 bytes)

###### BoyStats2 
* [BoyStats2](Chunks/Chunk08.md) # [161|xA1] : (14 bytes)

###### DogCurrentHp 
* [DogCurrentHp](Chunks/Chunk09.md) # [175|xAF] : (2 bytes)

###### Dog Status Buffs 
* [DogStatusBuffs](Chunks/Chunk10.md) # [177|xB1] : (24 bytes)

###### Unknown 7 
* [Unknown 7](Chunks/Chunk11.md) # [201|xC9] : (6 bytes)

###### DogHpNextLevel 
* [DogHpNextLevel](Chunks/Chunk12.md) # [207|xCF] : (2 bytes)

###### Chunk13_DogStats1 
* [DogStats1](Chunks/Chunk13.md) # [209|xD1] : (13 bytes)

###### Chunk14_DogLevel 
* [DogLevel](Chunks/Chunk14.md) # [222|xDE] : (2 bytes)

###### DogStats2 
* [DogStats2](Chunks/Chunk15.md) # [226|xE4] : (14 bytes) 

###### EquWeapon_Moneys_EquAlchemies_WeaponLvls_DogAtkLvl 
* [EquippedStuff_Moneys_Levels](Chunks/Chunk16.md) # [240|xF0] : (101 bytes)

###### Chunk17_AlchemyLevels 
* [AlchemyLevels](Chunks/Chunk17.md) # [341|x155] : (162 bytes)

###### Alchemies_Charms_Spots_Weapons 
* [Collectables_Spots](Chunks/Chunk18.md) # [503|x1F7] : (146 bytes)

###### Ingredients_Items_Armors_Ammo_FlyingMachine 
* [PossessedStuff](Chunks/Chunk19.md) # [649|x289] : (92 bytes)

###### LastLanding_CurrentWeapon 
* [LastLanding_CurrentWeapon](Chunks/Chunk20.md) # [741|x2E5] : (44 bytes)

###### TradeGoods 
* [TradeGoods](Chunks/Chunk21.md) # [785|x311] : (32 bytes)
