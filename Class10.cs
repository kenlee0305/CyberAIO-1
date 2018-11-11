using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;

// Token: 0x02000018 RID: 24
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
internal sealed class Class10
{
	// Token: 0x06000097 RID: 151 RVA: 0x00002CF0 File Offset: 0x00000EF0
	internal Class10()
	{
	}

	// Token: 0x06000098 RID: 152 RVA: 0x000031C3 File Offset: 0x000013C3
	internal static ResourceManager smethod_0()
	{
		if (Class10.resourceManager_0 == null)
		{
			Class10.resourceManager_0 = new ResourceManager(Class185.smethod_0(537715946), typeof(Class10).Assembly);
		}
		return Class10.resourceManager_0;
	}

	// Token: 0x06000099 RID: 153 RVA: 0x000031F4 File Offset: 0x000013F4
	internal static CultureInfo smethod_1()
	{
		return Class10.cultureInfo_0;
	}

	// Token: 0x0600009A RID: 154 RVA: 0x000031FB File Offset: 0x000013FB
	internal static void smethod_2(CultureInfo cultureInfo_1)
	{
		Class10.cultureInfo_0 = cultureInfo_1;
	}

	// Token: 0x04000067 RID: 103
	private static ResourceManager resourceManager_0;

	// Token: 0x04000068 RID: 104
	private static CultureInfo cultureInfo_0;
}
