using System;

// Token: 0x02000073 RID: 115
internal abstract class Class64 : Interface3
{
	// Token: 0x0600027C RID: 636
	public abstract string imethod_0();

	// Token: 0x0600027D RID: 637
	public abstract void imethod_1(bool bool_0, Interface1 interface1_0);

	// Token: 0x0600027E RID: 638
	public abstract int imethod_2();

	// Token: 0x0600027F RID: 639
	public abstract int imethod_3(int int_0);

	// Token: 0x06000280 RID: 640
	public abstract int imethod_4(int int_0);

	// Token: 0x06000281 RID: 641 RVA: 0x0000439C File Offset: 0x0000259C
	public virtual byte[] imethod_5(byte[] byte_1)
	{
		return this.imethod_6(byte_1, 0, byte_1.Length);
	}

	// Token: 0x06000282 RID: 642
	public abstract byte[] imethod_6(byte[] byte_1, int int_0, int int_1);

	// Token: 0x06000283 RID: 643 RVA: 0x000043A9 File Offset: 0x000025A9
	public virtual int imethod_7(byte[] byte_1, byte[] byte_2, int int_0)
	{
		return this.imethod_8(byte_1, 0, byte_1.Length, byte_2, int_0);
	}

	// Token: 0x06000284 RID: 644 RVA: 0x00018858 File Offset: 0x00016A58
	public virtual int imethod_8(byte[] byte_1, int int_0, int int_1, byte[] byte_2, int int_2)
	{
		byte[] array = this.imethod_6(byte_1, int_0, int_1);
		if (array == null)
		{
			return 0;
		}
		if (int_2 + array.Length > byte_2.Length)
		{
			throw new Exception1(Class185.smethod_0(537694976));
		}
		array.CopyTo(byte_2, int_2);
		return array.Length;
	}

	// Token: 0x06000285 RID: 645
	public abstract byte[] imethod_9();

	// Token: 0x06000286 RID: 646 RVA: 0x000043B8 File Offset: 0x000025B8
	public virtual byte[] imethod_10(byte[] byte_1)
	{
		return this.imethod_11(byte_1, 0, byte_1.Length);
	}

	// Token: 0x06000287 RID: 647
	public abstract byte[] imethod_11(byte[] byte_1, int int_0, int int_1);

	// Token: 0x06000288 RID: 648 RVA: 0x000188A0 File Offset: 0x00016AA0
	public virtual int imethod_12(byte[] byte_1, int int_0)
	{
		byte[] array = this.imethod_9();
		if (int_0 + array.Length > byte_1.Length)
		{
			throw new Exception1(Class185.smethod_0(537694976));
		}
		array.CopyTo(byte_1, int_0);
		return array.Length;
	}

	// Token: 0x06000289 RID: 649 RVA: 0x000043C5 File Offset: 0x000025C5
	public virtual int imethod_13(byte[] byte_1, byte[] byte_2, int int_0)
	{
		return this.imethod_14(byte_1, 0, byte_1.Length, byte_2, int_0);
	}

	// Token: 0x0600028A RID: 650 RVA: 0x000188DC File Offset: 0x00016ADC
	public virtual int imethod_14(byte[] byte_1, int int_0, int int_1, byte[] byte_2, int int_2)
	{
		int num = this.imethod_8(byte_1, int_0, int_1, byte_2, int_2);
		return num + this.imethod_12(byte_2, int_2 + num);
	}

	// Token: 0x0600028B RID: 651
	public abstract void imethod_15();

	// Token: 0x04000165 RID: 357
	protected static readonly byte[] byte_0 = new byte[0];
}
