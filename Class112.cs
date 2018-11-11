using System;
using System.Runtime.InteropServices;

// Token: 0x020000D0 RID: 208
[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
internal static class Class112
{
	// Token: 0x06000572 RID: 1394 RVA: 0x0000594F File Offset: 0x00003B4F
	internal static bool smethod_0<T>(T[] gparam_0)
	{
		if (gparam_0 == null)
		{
			throw new ArgumentNullException();
		}
		return gparam_0.Length != 0;
	}
}
