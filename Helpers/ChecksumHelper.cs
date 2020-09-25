using System;
using SramFormat.SoE.Constants;
using SramFormat.SoE.Models.Enums;

namespace SramFormat.SoE.Helpers
{
    public static class ChecksumHelper
    {
        public static ushort CalcChecksum(byte[] sram, int gameIndex, FileRegion region) =>
            CalcChecksum(sram, gameIndex, region == FileRegion.UnitedStates);

        public static ushort CalcChecksum(byte[] sram, int gameIndex, bool isUsVersion)
        {
            const int gameSize = Sizes.Game.All;
            const int sizeChecksum = 2;
            var checksum = isUsVersion ? ChecksumStartValues.US : ChecksumStartValues.Europe;
            var offset = Offsets.FirstGame + gameIndex * gameSize;
            var temp = (byte)(checksum + sram[offset + sizeChecksum]);

            for (var i = 3; i < gameSize; ++i)
            {
                checksum &= 0xFF00;
                checksum |= temp;
                checksum <<= 1;

                if (checksum > 0xFFFF)
                    checksum -= 0xFFFF;

                temp = (byte)(checksum + sram[offset + i]);
            }

            return Convert.ToUInt16(checksum);
        }
    }
}