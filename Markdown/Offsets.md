# Offsets

(in order)

* Checksum  = [0] ~ (2 bytes)

* Unknown1  = [2|x02] ~ (36 bytes)

* [BoyName](Items/CharacterName.md)  = [38|x26] ~ (34 bytes)

* Unknown2  = [72|x48] ~ (2 bytes)

* [DogName](Items/CharacterName.md)  = [74|x4A] ~ (34 bytes)

* Unknown3  = [108|x67] ~ (2 bytes)

* BoyCurrentHp  = [110|x6E] ~ (2 bytes)

* [Unknown4_BoyBuff](Items/CharacterBuff.md).BuffFlags  = [112|x70
* Unknown4_BoyBuff.Unknown1  = [114|x72] ~ (2 bytes)
* Unknown4_BoyBuff.Unknown2  = [116|x74] ~ (2 bytes)
* Unknown4_BoyBuff.Unknown3  = [138|x8A] ~ (22 bytes)
* Unknown4_BoyBuff.Unknown4  = [140|x8C] ~ (2 bytes)

* BoyMaxHp  = [142|x8E] ~ (2 bytes)

* Unknown5  = [144|x90] ~ (10 bytes)

* BoyExperience  = [154|x9A] ~ (3 bytes)
* BoyLevel  = [157|x9D] ~ (2 bytes)

* Unknown6  = [159|x9F] ~ (16 bytes)

* DogCurrentHp  = [175|xAF] ~ (2 bytes)

* [Unknown7_DogBuff](Items/CharacterBuff.md).BuffFlags  = [177|xB1
* Unknown7_DogBuff.Unknown1  = [179|xB3] ~ (2 bytes)
* Unknown7_DogBuff.Unknown2  = [181|xB5] ~ (2 bytes)
* Unknown7_DogBuff.Unknown3  = [203|xCB] ~ (22 bytes)
* Unknown7_DogBuff.Unknown7  = [205|xCD] ~ (2 bytes)

* DogMaxHp  = [207|xCF] ~ (2 bytes)

* Unknown8  = [209|xD1] ~ (10 bytes)

* DogExperience  = [219|xDB] ~ (3 bytes)
* DogLevel  = [222|xDE] ~ (2 bytes)

* Unknown9  = [224|xE0] ~ (28 bytes)

* [Moneys](Items/Moneys.md)  = [252|xFC] ~ (12 bytes)

* Unknown10  = [264|x107] ~ (13 bytes)

* [WeaponLevels](Items/WeaponLevels.md)  = [277|x115] ~ (26 bytes)

* Unknown11  = [303|x12F] ~ (14 bytes)

* DogAttackLevel  = [317|x13D] ~ (2 bytes)

* Unknown12A  = [319|x13F] ~ (16 bytes)
* Unknown12B  = [335|x14F] ~ (2 bytes)
* Unknown12C  = [337|x151] ~ (4 bytes)

* [AlchemyMinorLevels](Items/AlchemyLevels.md)  = [341|x155] ~ (70 bytes)
* [AlchemyMajorLevels](Items/AlchemyLevels.md)  = [411|x19B] ~ (70 bytes)

* [Unknown13](Items/Unknown13.md)  = [481|x1E1] ~ (23 bytes)

* [Alchemies](Items/Alchemies.md)  = [503|x1F7] ~ (5 bytes)

* [Unknown14](Items/Enums/Unknown14.md)  = [508|x1FC] ~ (4 bytes) 

* [Charms](Items/Charms.md)  = [512|x200] ~ (3 bytes)

* [Unknown15](Items/Unknown15.md)  = [515|x203] ~ (118 bytes)

* [Weapons](Items/Weapons.md)  = [633|x279] ~ (2 bytes)

* Unknown16A  = [635|x27B] ~ (4 bytes)
* [Unknown16B_GothicaFlags](Items/Enums/Unknown16_GothicaFlags.md)  = [639|x27F] ~ (4 bytes)
* [Unknown16C](Items/Unknown16C.md)  = [643|x283] ~ (6 bytes)

* [Ingredients](Items/Ingredients.md)  = [649|x289] ~ (22 bytes)
* [Items](Items/Items.md)  = [671|x29F] ~ (8 bytes)
* [Armors](Items/Armors.md)  = [679|x2A7] ~ (40 bytes)
* [BazookaAmmunitions](Items/BazookaAmmunitions.md)  = [719|x2CF] ~ (3 bytes)

* Unknown17  = [722|x2D2] ~ (67 bytes)

* [TradeGoods](Items/TradeGoods.md)  = [789|x315] ~ (26 bytes)

* Unknown18  = [815|x32F] ~ (2 bytes)