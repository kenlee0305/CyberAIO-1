using System;
using System.Reflection;

// Token: 0x02000038 RID: 56
internal static class Class28
{
	// Token: 0x06000167 RID: 359 RVA: 0x00003A5D File Offset: 0x00001C5D
	public static bool smethod_0(Type type_4)
	{
		return type_4.IsGenericType && type_4.GetGenericTypeDefinition() == Class28.type_1;
	}

	// Token: 0x040000C2 RID: 194
	public static readonly Type type_0 = typeof(object);

	// Token: 0x040000C3 RID: 195
	public static readonly Type type_1 = typeof(Nullable<>);

	// Token: 0x040000C4 RID: 196
	public static readonly Type type_2 = typeof(Enum);

	// Token: 0x040000C5 RID: 197
	public static readonly Type type_3 = typeof(ValueType);

	// Token: 0x040000C6 RID: 198
	public static readonly Assembly assembly_0 = typeof(Class28).Assembly;
}
