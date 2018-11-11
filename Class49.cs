using System;

// Token: 0x02000104 RID: 260
internal sealed class Class49 : Class47
{
	// Token: 0x0600069C RID: 1692 RVA: 0x00006569 File Offset: 0x00004769
	public Class49(Interface3 interface3_1)
	{
		this.interface3_0 = interface3_1;
	}

	// Token: 0x0600069D RID: 1693 RVA: 0x00006578 File Offset: 0x00004778
	public override void Dispose()
	{
		this.interface3_0.imethod_15();
	}

	// Token: 0x0600069E RID: 1694 RVA: 0x00002BE6 File Offset: 0x00000DE6
	public override bool vmethod_0()
	{
		return true;
	}

	// Token: 0x0600069F RID: 1695 RVA: 0x00006585 File Offset: 0x00004785
	public override int vmethod_1()
	{
		return this.interface3_0.imethod_2();
	}

	// Token: 0x060006A0 RID: 1696 RVA: 0x00006592 File Offset: 0x00004792
	public override int vmethod_2(byte[] byte_0, int int_0, int int_1, byte[] byte_1, int int_2)
	{
		return this.interface3_0.imethod_8(byte_0, int_0, int_1, byte_1, int_2);
	}

	// Token: 0x060006A1 RID: 1697 RVA: 0x000065A6 File Offset: 0x000047A6
	public override byte[] vmethod_3(byte[] byte_0, int int_0, int int_1)
	{
		return this.interface3_0.imethod_11(byte_0, int_0, int_1);
	}

	// Token: 0x04000370 RID: 880
	private readonly Interface3 interface3_0;
}
