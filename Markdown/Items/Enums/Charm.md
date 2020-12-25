## Charm (3 bytes)

### Byte #1
* DogAvailable = 0x1, **$2261&0x01**
* BoyAvailable = 0x2, **$2261&0x02**
* StoneVestOnceOwned = 0x4, **$2261&0x04 (indicates previously owned the Stone Vest, see [0x968b54] and [0x968b7d]) (Used to be able to trade Centurion Cape)
* ObsidianHelmetOnceOwned = 0x8, **$2261&0x08** (indicates previously owned the Obsidian Helmet, see [0x9695f4], [0x969611] and [0x969647]) (Used to be able to trade Centurion Helmet)
* BronzeGauntletOnceOwned = 0x10, **$2261&0x10** (indicates previously owned the Bronze Gauntlet, see [0x96aa45], [0x96aa5c] and [0x96aa85]) (Used to be able to trade Gloves of Ra)

* // No meaning for 0x1 - 0x10
* ArmorPolish = 0x20, **$2261&0x20**
* ChocoboEgg = 0x40, **$2261&0x40**
* InsectIncense = 0x80, **$2261&0x80**

### Byte #2
* JadeDisk = 0x100, **$2262&0x01**
* JaguarRing = 0x200, **$2262&0x02**
* MagicGourd = 0x400, **$2262&0x04**
* MoxaStick = 0x800, **$2262&0x08**

* OracleBone = 0x1_000, **$2262&0x10**
* RubyHeart = 0x2_000, **$2262&0x20**
* SilverSheath = 0x4_000, **$2262&0x40**
* StaffOfLife = 0x8_000, **$2262&0x80**

### Byte #3
* SunStone = 0x10_000, **$2263&0x01**
* ThugsCloak = 0x20_000, **$2263&0x02**
* WizardsCoin = 0x40_000, **$2263&0x04**
* JadeDiskOnceOwned = 0x80_000, **$2263&0x08** indicates previously owned JadeDisk (can be traded in Ivor Tower alley)
* SunStoneOnceOwned = 0x100_000, **$2263&0x10** indicates previously owned SunStone (can be traded in Ivor Tower alley)
* SilverSheathOnceOwned = 0x200_000, **$2263&0x20** indicates previously owned SilverSheath (can be traded in Ivor Tower alley)
* RunbyHeartOnceOwned = 0x400_000, **$2263&0x40** indicates previously owned RubyHeart see [0x96942d] (used to trade back against MoxaStick in Nobilia)
* MoxaStickOnceOwned = 0x800_000, **$2263&0x80** indicates previously owned MoxaStick (can be traded in Ivor Tower alley)