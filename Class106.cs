using System;

// Token: 0x020000C3 RID: 195
internal static class Class106
{
	// Token: 0x0600050D RID: 1293 RVA: 0x0002B9E4 File Offset: 0x00029BE4
	public static void smethod_0(byte[] byte_0, int int_0, int int_1)
	{
		for (int i = 0; i < 4; i++)
		{
			int num = int_0++;
			byte_0[num] ^= (byte)(int_1 >> i * 8);
		}
	}

	// Token: 0x0600050E RID: 1294 RVA: 0x0002BA1C File Offset: 0x00029C1C
	public static void smethod_1(byte[] byte_0, int int_0, int int_1)
	{
		for (int i = 0; i < 4; i++)
		{
			if (int_0 >= byte_0.Length)
			{
				return;
			}
			int num = int_0++;
			byte_0[num] ^= (byte)(int_1 >> i * 8);
		}
	}

	// Token: 0x0600050F RID: 1295 RVA: 0x0002BA58 File Offset: 0x00029C58
	public static void smethod_2(byte[] byte_0, int int_0, long long_0)
	{
		for (int i = 0; i < 8; i++)
		{
			int num = int_0++;
			byte_0[num] ^= (byte)(long_0 >> i * 8);
		}
	}
}
