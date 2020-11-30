using System.Runtime.InteropServices;
using System.Text;
using SramCommons.Extensions;
using SramFormat.SoE.Constants;
using SramFormat.SoE.Models.Enums;

namespace SramFormat.SoE.Models.Structs.Unknown
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = Sizes.Game.Unknown16C)] // 6
	public struct Unknown16C
	{
		public Unknown16C_Offset1 Offset0;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
		public byte[] Offset1To5;

		public string FormatAsString()
		{
			var sb = new StringBuilder();

			sb.AppendLine(nameof(Offset0) + ": " + Offset0.ToString())
				.AppendLine(nameof(Offset1To5) + ": " + Offset1To5.FormatAsString())
				;

			return sb.ToString();
		}
	}
}
