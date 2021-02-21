using System;
using SoE.Models.Enums;
using SRAM.SoE2.Models;
using WRAM.Snes9x.Models.Structs;

namespace SRAM.SoE2.Helpers
{
	public static class SavestateWramHelper
	{
		internal static SramFileSoE GetSramFileFromSavestate(SavestateSnex9x savestate, GameRegion region)
		{
			var sramFile = new SramFileSoE(savestate.SRA.Data, region);
			var saveSlotId = sramFile.Struct.LastSaveslotId / 2;

			var dataW = savestate.RAM.Data;
			var dataS = sramFile.GetSegmentBytes(saveSlotId);

			foreach (var (sramOffset, (wramOffset, size)) in SramOffsets.WramChunkOffsetMappings)
				Array.Copy(dataW, wramOffset, dataS, sramOffset, size);

			sramFile.SetSegmentBytes(saveSlotId, dataS);

			return sramFile;
		}
	}
}