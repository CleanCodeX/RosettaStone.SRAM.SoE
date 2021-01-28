using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using Common.Shared.Min.Extensions;
using IO.Helpers;

namespace SRAM.SoE.Extensions
{
	public static class TypeExtensions
	{
		public static string? GetFieldNameFromOffset([NotNull] this Type type, int offset)
		{
			var fieldInfo = GetFieldNameByOffset(type, offset);
			if (fieldInfo is null) return null;

			var parentTye = fieldInfo.DeclaringType!;
			var baseOffset = (int)Marshal.OffsetOf(parentTye, fieldInfo.Name);

			while (parentTye.IsDefined<ContainsComplexStructures>())
			{
				if (fieldInfo.FieldType.IsArray)
				{
					var structSize = Marshal.SizeOf(fieldInfo.FieldType);
					var value = fieldInfo.GetValue(null)!;

					for (var i = 0; i < ((Array)value).Length; ++i)
					{
						var tempFieldInfo = GetFieldNameByOffset(fieldInfo.FieldType, offset);
						if (tempFieldInfo is not null)
						{
							fieldInfo = tempFieldInfo;
							goto EndLoop;
						}

						baseOffset += (int)Marshal.OffsetOf(parentTye, fieldInfo.Name);
						offset -= structSize;
					}
				}
				else
				{
					offset -= baseOffset;
					var tempFieldInfo = GetFieldNameByOffset(fieldInfo.FieldType, offset);
					if (tempFieldInfo is null) break;

					fieldInfo = tempFieldInfo;
					parentTye = fieldInfo.DeclaringType!;
					baseOffset = (int) Marshal.OffsetOf(parentTye, fieldInfo.Name);
				}
			}
			EndLoop:

			return fieldInfo.Name;
		}

		private static FieldInfo? GetFieldNameByOffset(Type type, int offset) => type.GetFields().LastOrDefault(e => offset > (int)Marshal.OffsetOf(type, e.Name));
	}
}
