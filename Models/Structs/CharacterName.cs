using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace RosettaStone.Sram.SoE.Models.Structs
{
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
	public unsafe struct CharacterName
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 34)]
		public byte[] BytesValue; // (34 Bytes) Null terminated

		public string StringValue
		{
			get
			{
				const int length = 32;
				var sb = new StringBuilder(length);
				fixed (byte* pointer = BytesValue)
				{
					for (var i = 0; i < length; ++i)
					{
						var value = (char)*(pointer + i);
						if (value == 0 || value == 96) continue;

						sb.Append(value);
					}
				}

				var result = sb.ToString();
				return result;
			}
			set
			{
				// TODO Check for correctness
				//BytesValue = Encoding.ASCII.GetBytes(value + (char) 0);
			}
		}

		public override string ToString() => StringValue;
	}
}