# Chunk16 (101 bytes)

###### CurrentMapId
* UInt16 CurrentEquippedWeapon # [240|xF0] : (2 bytes)

###### Unknown 9
* byte[2] Unknown9 # [242|xF2] : (2 bytes)

###### ArmorStatsPointers (only WRAM?)
* UInt16 DogCollarStatsPointer # [244|xF4] : (2 bytes)
* UInt16 BoyVestsStatsPointer # [246|xF6] : (2 bytes)
* UInt16 BoyHatsStatsPointer # [248|xF8] : (2 bytes)
* UInt16 BoyBraceletStatsPointer # [250|xFA] : (2 bytes)

###### Moneys
* [Moneys](../Moneys.md) # [252|xFC] : (12 bytes)

###### EquippedAlchemies
* byte[9] EquippedAlchemies # [264|x108]:(9 bytes)

###### CurrentMapId
* byte CurrentMapId # [273|x111] : (1 byte)

###### Unknown 10
* byte Unknown10 # [274|x112] : (1 bytes)

###### Weapon Levels
* [WeaponLevels](../WeaponLevels.md) # [275|x113] : (28 bytes)

###### Unknown 11
* byte[14] Unknown11 # [303|x12F] : (14 bytes)

###### The dogs's attack level
* [DogAttackLevel](../WeaponLevel.md) # [317|x13D] : (2 bytes)

###### Unknown 12 A
* byte[16] Unknown12A # [319|x13F] : (16 bytes)

###### Unknown 12 B
* UInt16 Unknown12B # 335|x14F] : (2 bytes) Note: contains probably frame-counter, changes at every in-game save

###### Unknown 12 C
* UInt32 Unknown12C # [337|x151] : (4 bytes)