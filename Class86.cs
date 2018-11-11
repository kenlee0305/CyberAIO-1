using System;

// Token: 0x020000A2 RID: 162
internal static class Class86
{
	// Token: 0x06000340 RID: 832 RVA: 0x0001F24C File Offset: 0x0001D44C
	public static bool smethod_0(Type type_0, Type type_1)
	{
		if (type_0 == type_1)
		{
			return true;
		}
		if (type_0 == null || type_1 == null)
		{
			return false;
		}
		if (type_0.IsByRef)
		{
			return type_1.IsByRef && Class86.smethod_0(type_0.GetElementType(), type_1.GetElementType());
		}
		if (type_1.IsByRef)
		{
			return false;
		}
		if (type_0.IsPointer)
		{
			return type_1.IsPointer && Class86.smethod_0(type_0.GetElementType(), type_1.GetElementType());
		}
		if (type_1.IsPointer)
		{
			return false;
		}
		if (type_0.IsArray)
		{
			return type_1.IsArray && type_0.GetArrayRank() == type_1.GetArrayRank() && Class86.smethod_0(type_0.GetElementType(), type_1.GetElementType());
		}
		if (type_1.IsArray)
		{
			return false;
		}
		if (type_0.IsGenericType && !type_0.IsGenericTypeDefinition)
		{
			type_0 = type_0.GetGenericTypeDefinition();
		}
		if (type_1.IsGenericType && !type_1.IsGenericTypeDefinition)
		{
			type_1 = type_1.GetGenericTypeDefinition();
		}
		return type_0 == type_1;
	}
}
