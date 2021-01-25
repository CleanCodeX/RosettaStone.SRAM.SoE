## Charm (4 bytes)

Explanation for [$XXXX&0xYY] : [$XXXX] = SoE (script) variable name [0xYY] = bit flag to check

### Byte #1
* DogAvailable = 0x1 : [$2261&0x01]  (Script variable)
* BoyAvailable = 0x2 : [$2261&0x02]
* StoneVestOnceOwned = 0x4 : [$2261&0x04 : indicates previously owned the [Stone Vest] : see offset [0x968b54] and [0x968b7d]) (Used to be able to trade [Centurion Cape]
* ObsidianHelmetOnceOwned = 0x8 : [$2261&0x08] : indicates previously owned the [Obsidian Helmet] : see offset [0x9695f4] : [0x969611] and [0x969647]. (Used to be able to trade [Centurion Helmet])
* BronzeGauntletOnceOwned = 0x10 : [$2261&0x10] : indicates previously owned the [Bronze Gauntlet] : see offset [0x96aa45] : [0x96aa5c] and [0x96aa85]. (Used to be able to trade [Gloves of Ra])

* ArmorPolish = 0x20 : [$2261&0x20]
* ChocoboEgg = 0x40 : [$2261&0x40]
* InsectIncense = 0x80 : [$2261&0x80]

### Byte #2
* JadeDisk = 0x1 + 256 : [$2262&0x01]
* JaguarRing = 0x2 + 256 : [$2262&0x02]
* MagicGourd = 0x4 + 256 : [$2262&0x04]
* MoxaStick = 0x8 + 256 : [$2262&0x08]

* OracleBone = 0x10 + 256 : [$2262&0x10]
* RubyHeart = 0x20 + 256 : [$2262&0x20]
* SilverSheath = 0x40 + 256 : [$2262&0x40]
* StaffOfLife = 0x80 + 256 : [$2262&0x80]

### Byte #3
* SunStone = 0x1 + 256 ^ 2 : [$2263&0x01]
* ThugsCloak = 0x2 + 256 ^ 2 : [$2263&0x02]
* WizardsCoin = 0x4 + 256 ^ 2 : [$2263&0x04]
* JadeDiskOnceOwned = 0x8 + 256 ^ 2 : [$2263&0x08] indicates previously owned [Jade Disk] (can be traded in Ivor Tower alley)
* SunStoneOnceOwned = 0x10 + 256 ^ 2 : [$2263&0x10] indicates previously owned [Sun Stone] (can be traded in Ivor Tower alley)

* SilverSheathOnceOwned = 0x20 + 256 ^ 2 : [$2263&0x20] indicates previously owned [Silver Sheath] (can be traded in Ivor Tower alley)
* RunbyHeartOnceOwned = 0x40 + 256 ^ 2 : [$2263&0x40] indicates previously owned [Ruby Heart] see [0x96942d] (used to trade back against [Moxa Stick] in Nobilia)
* MoxaStickOnceOwned = 0x80 + 256 ^ 2 : [$2263&0x80] indicates previously owned [Moxa Stick] (can be traded in Ivor Tower alley)

### Byte #4
* DiamondEye = 0x1 + 256 ^ 3 : [$2264&0x01]
* DiamondEyes = 0x2 + 256 ^ 3 : [$2264&0x02]
* Gauge = 0x4 + 256 ^ 3 : [$2264&0x04]
* Wheel = 0x8 + 256 ^ 3 : [$2264&0x08]

* QuennsKey = 0x10 + 256 ^ 3 : [$2264&0x10]
* EnegeryCore = 0x20 + 256 ^ 3 : [$2264&0x20]
* Unknown1 = 0x40 + 256 ^ 3 : [$2264&0x40]
* Unknown2 = 0x80 + 256 ^ 3 : [$2264&0x80]