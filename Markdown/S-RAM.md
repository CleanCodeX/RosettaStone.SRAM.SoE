# Secret Of Evermore ~ S-RAM - Map

Size: 8192 bytes (8 KiB)

### Pre-save slot
* byte AudioMode : (0) => mono, (1) => stereo
* byte LastSaveSlotId : (0) => slot 1, (2) => slot 2, (4) => slot 3, (6) => slot 4)

### Save slots 1-4
* [SaveSlot](Items/SaveSlot.md)[]  (817 bytes each)

### Post-save slot
* byte[] Unknown1 (4922 bytes - probably completely unused space)
