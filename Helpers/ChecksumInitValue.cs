using System;

namespace SRAM.SoE.Helpers
{
	internal enum ChecksumInitValue: UInt32
	{
		/// The starting value for the checksum in the US version
		// ReSharper disable once InconsistentNaming
		US = 1_087,

		/// The starting value for the checksum in the European versions
		Europe = 5_887
	}
}