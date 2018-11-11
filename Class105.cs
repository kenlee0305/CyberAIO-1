using System;

// Token: 0x020000C2 RID: 194
internal static class Class105
{
	// Token: 0x0600050C RID: 1292 RVA: 0x0002B9A4 File Offset: 0x00029BA4
	public static bool smethod_0(int[] int_0, int[] int_1)
	{
		if (int_0 == int_1)
		{
			return true;
		}
		if (int_0 == null || int_1 == null)
		{
			return false;
		}
		if (int_0.Length != int_1.Length)
		{
			return false;
		}
		for (int i = 0; i < int_0.Length; i++)
		{
			if (int_0[i] != int_1[i])
			{
				return false;
			}
		}
		return true;
	}
}
