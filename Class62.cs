using System;
using System.IO;
using System.Runtime.CompilerServices;

// Token: 0x02000070 RID: 112
internal static class Class62
{
	// Token: 0x06000266 RID: 614 RVA: 0x00004230 File Offset: 0x00002430
	[MethodImpl(MethodImplOptions.Synchronized)]
	public static Class87 smethod_0()
	{
		if (Class62.class177_0 == null)
		{
			Class62.class177_0 = new Class177();
		}
		return new Class87(Class62.class177_0);
	}

	// Token: 0x06000267 RID: 615 RVA: 0x0000424D File Offset: 0x0000244D
	public static Stream smethod_1()
	{
		if (Class62.stream_0 == null)
		{
			Class62.stream_0 = typeof(Class62).Assembly.GetManifestResourceStream("12e5a041d2154a349fa034203dddf111");
		}
		return Class62.stream_0;
	}

	// Token: 0x04000161 RID: 353
	private static Class177 class177_0;

	// Token: 0x04000162 RID: 354
	[ThreadStatic]
	private static Stream stream_0;
}
