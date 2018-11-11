using System;

// Token: 0x020000BA RID: 186
internal sealed class Class100 : Interface1
{
	// Token: 0x060004EB RID: 1259 RVA: 0x000054E5 File Offset: 0x000036E5
	public Class100(Interface1 interface1_1, byte[] byte_1) : this(interface1_1, byte_1, 0, byte_1.Length)
	{
	}

	// Token: 0x060004EC RID: 1260 RVA: 0x0002AE98 File Offset: 0x00029098
	public Class100(Interface1 interface1_1, byte[] byte_1, int int_0, int int_1)
	{
		if (interface1_1 == null)
		{
			throw new ArgumentNullException(Class185.smethod_0(537694769));
		}
		if (byte_1 == null)
		{
			throw new ArgumentNullException(Class185.smethod_0(537694754));
		}
		this.interface1_0 = interface1_1;
		this.byte_0 = new byte[int_1];
		Array.Copy(byte_1, int_0, this.byte_0, 0, int_1);
	}

	// Token: 0x060004ED RID: 1261 RVA: 0x000054F3 File Offset: 0x000036F3
	public byte[] method_0()
	{
		return (byte[])this.byte_0.Clone();
	}

	// Token: 0x060004EE RID: 1262 RVA: 0x00005505 File Offset: 0x00003705
	public Interface1 method_1()
	{
		return this.interface1_0;
	}

	// Token: 0x04000269 RID: 617
	private readonly Interface1 interface1_0;

	// Token: 0x0400026A RID: 618
	private readonly byte[] byte_0;
}
