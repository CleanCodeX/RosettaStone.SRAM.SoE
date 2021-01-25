using System;

namespace SRAM.SoE.Extensions
{
	public static class EnumExtensions
	{
		public static ulong ToUInt64(this Enum source) => (ulong)(object)source;
	}
}
