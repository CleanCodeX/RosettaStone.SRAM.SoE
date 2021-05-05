using System.IO;
using SoE.Models.Enums;
using SRAM.SoE.Helpers;
using WRAM.Snes9x.Helpers;

namespace SRAM.SoE.Extensions
{
	public static class StreamExtensions
    {
	    public static byte[] ReadSramFromSavestate(this Stream source, GameRegion region) => SavestateWramHelper.CreateSramFileFromSavestate(SavestateReader.Load(source), region).Buffer;

	    public static byte[] WriteSramToSavestate(this Stream source, GameRegion region, byte[] sram)
	    {
		    var unchangedSavestate = SavestateReader.Load(source, true);
			var changedSavestate = SavestateWramHelper.CopySramToSavestate(unchangedSavestate, region, sram);
			return SavestateWriter.Save(source, changedSavestate);
	    }
    }
}
