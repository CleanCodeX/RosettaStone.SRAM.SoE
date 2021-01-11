using System;
using RosettaStone.Sram.SoE.Constants;
using RosettaStone.Sram.SoE.Enums;

namespace RosettaStone.Sram.SoE.Helpers
{
	/// <summary>
	/// Calculates the checksum of given save slot index from buffer
	/// </summary>
	public static class ChecksumHelper
	{
		/// <summary>
		/// Calculates the checksum of given save slot index from buffer
		/// </summary>
		/// <param name="sram">The sram buffer containing the given game</param>
		/// <param name="slotIndex">The game's index which checksum to be calculated</param>
		/// <param name="region">the game's region of sram</param>
		/// <returns>The calculated checksum for the given save slot index</returns>
		public static ushort CalcChecksum(byte[] sram, int slotIndex, GameRegion region) =>
			CalcChecksum(sram, slotIndex, region == GameRegion.EnglishNtsc);

		/// <summary>
		/// Calculates the checksum of given save slot index from buffer
		/// </summary>
		/// <param name="sram">The sram buffer containing the given game</param>
		/// <param name="slotIndex">The game's index which checksum to be calculated</param>
		/// <param name="isUsVersion">sets if this sram is the US region</param>
		/// <returns>The calculated checksum for the given save slot index</returns>
		public static ushort CalcChecksum(byte[] sram, int slotIndex, bool isUsVersion)
		{
			const int gameSize = Sizes.SaveSlot.All;
			const int sizeChecksum = 2;
			var checksum = isUsVersion ? ChecksumStartValues.US : ChecksumStartValues.Europe;
			var offset = Offsets.FirstSaveSlot + slotIndex * gameSize;
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