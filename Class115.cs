using System;

// Token: 0x020000D5 RID: 213
internal sealed class Class115
{
	// Token: 0x0600058D RID: 1421 RVA: 0x00002CF0 File Offset: 0x00000EF0
	private Class115()
	{
	}

	// Token: 0x0600058E RID: 1422 RVA: 0x00005A7E File Offset: 0x00003C7E
	internal static void smethod_0(uint uint_0, byte[] byte_0, int int_0)
	{
		byte_0[int_0] = (byte)uint_0;
		byte_0[++int_0] = (byte)(uint_0 >> 8);
		byte_0[++int_0] = (byte)(uint_0 >> 16);
		byte_0[++int_0] = (byte)(uint_0 >> 24);
	}

	// Token: 0x0600058F RID: 1423 RVA: 0x00005AB1 File Offset: 0x00003CB1
	internal static uint smethod_1(byte[] byte_0, int int_0)
	{
		return (uint)((int)byte_0[int_0] | (int)byte_0[++int_0] << 8 | (int)byte_0[++int_0] << 16 | (int)byte_0[++int_0] << 24);
	}
}
