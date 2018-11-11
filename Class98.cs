using System;
using System.Runtime.InteropServices;

// Token: 0x020000B5 RID: 181
internal sealed class Class98
{
	// Token: 0x060004DF RID: 1247 RVA: 0x0002AC24 File Offset: 0x00028E24
	internal static uint smethod_0(string string_0)
	{
		uint num;
		if (string_0 != null)
		{
			num = 2166136261u;
			for (int i = 0; i < string_0.Length; i++)
			{
				num = ((uint)string_0[i] ^ num) * 16777619u;
			}
		}
		return num;
	}

	// Token: 0x04000264 RID: 612 RVA: 0x00002B88 File Offset: 0x00000D88
	internal static readonly Class98.Struct40 struct40_0;

	// Token: 0x020000B6 RID: 182
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
	private struct Struct40
	{
	}
}
