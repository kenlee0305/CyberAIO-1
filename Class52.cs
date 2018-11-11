using System;

// Token: 0x0200005E RID: 94
internal abstract class Class52 : IDisposable
{
	// Token: 0x06000211 RID: 529
	public abstract bool vmethod_0();

	// Token: 0x06000212 RID: 530
	public abstract bool vmethod_1();

	// Token: 0x06000213 RID: 531
	public abstract bool vmethod_2();

	// Token: 0x06000214 RID: 532
	public abstract long vmethod_3();

	// Token: 0x06000215 RID: 533
	public abstract long vmethod_4();

	// Token: 0x06000216 RID: 534
	public abstract void vmethod_5(long long_0);

	// Token: 0x06000217 RID: 535 RVA: 0x00003F60 File Offset: 0x00002160
	public virtual void vmethod_6()
	{
		this.vmethod_7(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x06000218 RID: 536 RVA: 0x00003F6F File Offset: 0x0000216F
	public void Dispose()
	{
		this.vmethod_6();
	}

	// Token: 0x06000219 RID: 537 RVA: 0x0000336F File Offset: 0x0000156F
	protected virtual void vmethod_7(bool bool_0)
	{
	}

	// Token: 0x0600021A RID: 538
	public abstract void vmethod_8();

	// Token: 0x0600021B RID: 539
	public abstract long vmethod_9(long long_0, int int_0);

	// Token: 0x0600021C RID: 540
	public abstract void vmethod_10(long long_0);

	// Token: 0x0600021D RID: 541
	public abstract int vmethod_11(byte[] byte_0, int int_0, int int_1);

	// Token: 0x0600021E RID: 542 RVA: 0x000149D8 File Offset: 0x00012BD8
	public virtual int vmethod_12()
	{
		byte[] array = new byte[1];
		if (this.vmethod_11(array, 0, 1) == 0)
		{
			return -1;
		}
		return (int)array[0];
	}

	// Token: 0x0600021F RID: 543
	public abstract void vmethod_13(byte[] byte_0, int int_0, int int_1);

	// Token: 0x06000220 RID: 544 RVA: 0x000149FC File Offset: 0x00012BFC
	public virtual void vmethod_14(byte byte_0)
	{
		this.vmethod_13(new byte[]
		{
			byte_0
		}, 0, 1);
	}
}
