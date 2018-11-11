using System;

// Token: 0x02000026 RID: 38
internal sealed class Class19 : Interface1
{
	// Token: 0x060000F6 RID: 246 RVA: 0x00003563 File Offset: 0x00001763
	public Class19(byte[] byte_1)
	{
		if (byte_1 == null)
		{
			throw new ArgumentNullException(Class185.smethod_0(537694949));
		}
		this.byte_0 = (byte[])byte_1.Clone();
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x0000E0FC File Offset: 0x0000C2FC
	public Class19(byte[] byte_1, int int_0, int int_1)
	{
		if (byte_1 == null)
		{
			throw new ArgumentNullException(Class185.smethod_0(537694736));
		}
		if (int_0 < 0 || int_0 > byte_1.Length)
		{
			throw new ArgumentOutOfRangeException(Class185.smethod_0(537694731));
		}
		if (int_1 < 0 || int_0 + int_1 > byte_1.Length)
		{
			throw new ArgumentOutOfRangeException(Class185.smethod_0(537694726));
		}
		this.byte_0 = new byte[int_1];
		Array.Copy(byte_1, int_0, this.byte_0, 0, int_1);
	}

	// Token: 0x060000F8 RID: 248 RVA: 0x0000358F File Offset: 0x0000178F
	public byte[] method_0()
	{
		return (byte[])this.byte_0.Clone();
	}

	// Token: 0x0400008E RID: 142
	private readonly byte[] byte_0;
}
