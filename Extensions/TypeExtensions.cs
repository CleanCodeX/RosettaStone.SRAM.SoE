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
		public static string? GetFieldNameByOffset([NotNull] this Type type, int offset)
		{
			var fieldInfo = InternalGetFieldNameByOffset(type, offset);
			if (fieldInfo is null) return null;

			offset -= (int)Marshal.OffsetOf(type, fieldInfo.Name);
			type = fieldInfo.FieldType!;

			if (type.IsDefined<HasComplexMembersAttribute>())
			{
				if (type.IsArray)
				{
					var structSize = Marshal.SizeOf(type);
					var value = fieldInfo.GetValue(null)!;

					for (var i = 0; i < ((Array)value).Length; ++i)
					{
						offset -= structSize;
						var fieldName = GetFieldNameByOffset(type, offset);
						if (fieldName is not null)
							return fieldName;
					}
				}
				else
				{
					var fieldName = GetFieldNameByOffset(type, offset);
					if (fieldName is not null)
						return fieldName;
				}
			}

			return fieldInfo.Name;
		}

		private static FieldInfo? InternalGetFieldNameByOffset(Type type, int offset) => type.GetFields().Reverse().FirstOrDefault(e =>(int) Marshal.OffsetOf(type, e.Name) <= offset);
	}
}
