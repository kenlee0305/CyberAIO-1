using System;

// Token: 0x02000019 RID: 25
internal sealed class Class11
{
	// Token: 0x0600009B RID: 155 RVA: 0x00003203 File Offset: 0x00001403
	public Class11(int int_2, int int_3)
	{
		this.method_1(int_2);
		this.int_1 = int_3;
	}

	// Token: 0x0600009C RID: 156 RVA: 0x00003219 File Offset: 0x00001419
	public int method_0()
	{
		return this.int_0;
	}

	// Token: 0x0600009D RID: 157 RVA: 0x00003221 File Offset: 0x00001421
	public void method_1(int int_2)
	{
		this.int_0 = int_2;
	}

	// Token: 0x0600009E RID: 158 RVA: 0x0000322A File Offset: 0x0000142A
	public int method_2()
	{
		return this.int_1;
	}

	// Token: 0x0600009F RID: 159 RVA: 0x0000B760 File Offset: 0x00009960
	public override bool Equals(object obj)
	{
		Class11 class11_ = obj as Class11;
		return !(class11_ == null) && this.method_3(class11_);
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x00003232 File Offset: 0x00001432
	public bool method_3(Class11 class11_0)
	{
		return class11_0.method_0() == this.method_0();
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x00003242 File Offset: 0x00001442
	public static bool operator ==(Class11 class11_0, Class11 class11_1)
	{
		return class11_0.method_3(class11_1);
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x0000324B File Offset: 0x0000144B
	public static bool operator !=(Class11 class11_0, Class11 class11_1)
	{
		return !(class11_0 == class11_1);
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x0000B788 File Offset: 0x00009988
	public override int GetHashCode()
	{
		return this.method_0().GetHashCode();
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x0000B7A4 File Offset: 0x000099A4
	public override string ToString()
	{
		return this.method_0().ToString();
	}

	// Token: 0x04000069 RID: 105
	private int int_0;

	// Token: 0x0400006A RID: 106
	private readonly int int_1;
}
