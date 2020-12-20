# SRAM - Format

SoE uses a SRAM of size 8192 bytes. (8 KiB)

## Sections
* UInt16 Checksum (2 bytes)
* [Game slot #1](SramGame.md) (817 bytes)
* Game slot #2 (817 bytes)
* Game slot #3 (817 bytes)
* Game slot #4 (817 bytes)
* byte[] Unknown1 (4922 bytes - probably completely unused space)