# SRAM - Format

SoE uses a SRAM of size 8192 bytes. (8 KiB)

## Major sections
* UInt16 Checksum (2 bytes)
* [Game slot](SramGame.md) #1-4 (4 * 817 bytes)
* byte[] Unknown1 (4922 bytes - probably completely unused space)