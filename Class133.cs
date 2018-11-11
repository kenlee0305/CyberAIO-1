using System;

// Token: 0x020000F7 RID: 247
internal sealed class Class133 : Class128
{
	// Token: 0x06000643 RID: 1603 RVA: 0x00006271 File Offset: 0x00004471
	public byte method_0()
	{
		return this.byte_0;
	}

	// Token: 0x06000644 RID: 1604 RVA: 0x00006279 File Offset: 0x00004479
	public void method_1(byte byte_1)
	{
		this.byte_0 = byte_1;
	}

	// Token: 0x06000645 RID: 1605 RVA: 0x00006282 File Offset: 0x00004482
	public bool method_2()
	{
		return (this.method_0() & 2) > 0;
	}

	// Token: 0x06000646 RID: 1606 RVA: 0x0000628F File Offset: 0x0000448F
	public bool method_3()
	{
		return (this.method_0() & 1) > 0;
	}

	// Token: 0x06000647 RID: 1607 RVA: 0x0000629C File Offset: 0x0000449C
	public Class45 method_4()
	{
		return this.class45_0;
	}

	// Token: 0x06000648 RID: 1608 RVA: 0x000062A4 File Offset: 0x000044A4
	public void method_5(Class45 class45_4)
	{
		this.class45_0 = class45_4;
	}

	// Token: 0x06000649 RID: 1609 RVA: 0x000062AD File Offset: 0x000044AD
	public string method_6()
	{
		return this.string_0;
	}

	// Token: 0x0600064A RID: 1610 RVA: 0x000062B5 File Offset: 0x000044B5
	public void method_7(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x0600064B RID: 1611 RVA: 0x000062BE File Offset: 0x000044BE
	public Class45[] method_8()
	{
		return this.class45_1;
	}

	// Token: 0x0600064C RID: 1612 RVA: 0x000062C6 File Offset: 0x000044C6
	public void method_9(Class45[] class45_4)
	{
		this.class45_1 = class45_4;
	}

	// Token: 0x0600064D RID: 1613 RVA: 0x000062CF File Offset: 0x000044CF
	public Class45[] method_10()
	{
		return this.class45_2;
	}

	// Token: 0x0600064E RID: 1614 RVA: 0x000062D7 File Offset: 0x000044D7
	public void method_11(Class45[] class45_4)
	{
		this.class45_2 = class45_4;
	}

	// Token: 0x0600064F RID: 1615 RVA: 0x000062E0 File Offset: 0x000044E0
	public Class45 method_12()
	{
		return this.class45_3;
	}

	// Token: 0x06000650 RID: 1616 RVA: 0x000062E8 File Offset: 0x000044E8
	public void method_13(Class45 class45_4)
	{
		this.class45_3 = class45_4;
	}

	// Token: 0x06000651 RID: 1617 RVA: 0x000062F1 File Offset: 0x000044F1
	public override byte vmethod_0()
	{
		return 4;
	}

	// Token: 0x04000349 RID: 841
	private byte byte_0;

	// Token: 0x0400034A RID: 842
	private Class45 class45_0;

	// Token: 0x0400034B RID: 843
	private string string_0;

	// Token: 0x0400034C RID: 844
	private Class45[] class45_1;

	// Token: 0x0400034D RID: 845
	private Class45[] class45_2;

	// Token: 0x0400034E RID: 846
	private Class45 class45_3;
}
