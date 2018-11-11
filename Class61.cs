using System;
using System.Reflection;
using System.Runtime.CompilerServices;

// Token: 0x0200006F RID: 111
internal static class Class61
{
	// Token: 0x06000265 RID: 613 RVA: 0x00004214 File Offset: 0x00002414
	public static void smethod_0(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		if (Class188.smethod_0())
		{
			int metadataToken = FieldInfo.GetFieldFromHandle(runtimeFieldHandle_0).MetadataToken;
		}
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}
}
