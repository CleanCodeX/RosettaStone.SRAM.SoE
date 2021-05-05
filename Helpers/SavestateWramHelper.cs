using System;
using Common.Shared.Min.Extensions;
using SoE.Models.Enums;
using SRAM.SoE.Models;
using WRAM.Snes9x.Models.Structs;

namespace SRAM.SoE.Helpers
{
	public static class SavestateWramHelper
	{
		internal static SramFileSoE CreateSramFileFromSavestate(SavestateSnex9x savestate, GameRegion region)
		{
			savestate.SRA.Data.ThrowIfNull("SRA.Data");

			var sram = savestate.SRA.Data; //.AsSpan(..SramSizes.Size).ToArray();
			SramFileSoE sramFile = new(sram, region);
			var saveSlotId = sramFile.Struct.LastSaveslotId / 2;

			ref var dataW = ref savestate.RAM.Data!;
			var dataS = sramFile.GetSegmentBytes(saveSlotId);

			foreach (var (sramOffset, (wramOffset, size)) in SramOffsets.WramChunkOffsetMappings)
				Array.Copy(dataW, wramOffset, dataS, sramOffset, size);

			sramFile.SetSegmentBytes(saveSlotId, dataS);

			return sramFile;
		}

		internal static SavestateSnex9x CopySramToSavestate(SavestateSnex9x savestate, GameRegion region, byte[] sram)
		{
			SramFileSoE sramFile = new(sram, region);
			var saveSlotId = sramFile.Struct.LastSaveslotId / 2;

			ref var dataW = ref savestate.RAM.Data!;
			var dataS = sramFile.GetSegmentBytes(saveSlotId);

			foreach (var (sramOffset, (wramOffset, size)) in SramOffsets.WramChunkOffsetMappings)
				Array.Copy(dataS, sramOffset, dataW, wramOffset, size);

			return savestate;
		}
	}
}