using System;
using System.Collections.Generic;

// Token: 0x02000056 RID: 86
internal sealed class Class51 : Interface0, IDisposable
{
	// Token: 0x060001DA RID: 474 RVA: 0x00003D2B File Offset: 0x00001F2B
	public int imethod_0()
	{
		return this.list_0.Count;
	}

	// Token: 0x060001DB RID: 475 RVA: 0x00003D38 File Offset: 0x00001F38
	public void imethod_3()
	{
		this.list_0.Clear();
	}

	// Token: 0x060001DC RID: 476 RVA: 0x00003D45 File Offset: 0x00001F45
	public Interface0 imethod_4()
	{
		return new Class51();
	}

	// Token: 0x060001DD RID: 477 RVA: 0x00003D4C File Offset: 0x00001F4C
	public void Dispose()
	{
		this.imethod_3();
		this.list_0 = null;
	}

	// Token: 0x060001DE RID: 478 RVA: 0x00003D5B File Offset: 0x00001F5B
	public void imethod_1(int int_0, out byte byte_0)
	{
		byte_0 = this.method_0(this.list_0[int_0], int_0);
	}

	// Token: 0x060001DF RID: 479 RVA: 0x00012D10 File Offset: 0x00010F10
	public void imethod_2(int int_0, ref byte byte_0)
	{
		for (int i = this.list_0.Count; i <= int_0; i++)
		{
			if (i == int_0)
			{
				this.list_0.Add(this.method_1(byte_0, i));
				return;
			}
			this.list_0.Add(this.method_1(0, i));
		}
		this.list_0[int_0] = this.method_1(byte_0, int_0);
	}

	// Token: 0x060001E0 RID: 480 RVA: 0x00003D72 File Offset: 0x00001F72
	private byte method_0(byte byte_0, int int_0)
	{
		throw new NotImplementedException();
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x00003D72 File Offset: 0x00001F72
	private byte method_1(byte byte_0, int int_0)
	{
		throw new NotImplementedException();
	}

	// Token: 0x040000E6 RID: 230
	private List<byte> list_0 = new List<byte>();
}
