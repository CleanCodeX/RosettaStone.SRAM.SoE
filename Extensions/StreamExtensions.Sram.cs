using System.IO;
using Common.Shared.Min.Extensions;
using SoE.Models.Enums;
using SRAM.SoE2.Helpers;
using WRAM.Snes9x.Helpers;

namespace SRAM.SoE2.Extensions
{
	public static class StreamExtensions
    {
	    public static Stream GetSramFromSavestate(this Stream source, GameRegion region) => SavestateWramHelper.GetSramFileFromSavestate(SavestateReader.Load(source), region).Buffer.ToStream();
    }
}
