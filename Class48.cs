using System;
using System.Security.Cryptography;

// Token: 0x0200002D RID: 45
internal sealed class Class48 : Class47
{
	// Token: 0x0600011F RID: 287 RVA: 0x00003767 File Offset: 0x00001967
	public Class48(ICryptoTransform icryptoTransform_1)
	{
		this.icryptoTransform_0 = icryptoTransform_1;
	}

	// Token: 0x06000120 RID: 288 RVA: 0x00003776 File Offset: 0x00001976
	public override void Dispose()
	{
		this.icryptoTransform_0.Dispose();
	}

	// Token: 0x06000121 RID: 289 RVA: 0x00003783 File Offset: 0x00001983
	public override bool vmethod_0()
	{
		return this.icryptoTransform_0.CanReuseTransform;
	}

	// Token: 0x06000122 RID: 290 RVA: 0x00003790 File Offset: 0x00001990
	public override int vmethod_1()
	{
		return this.icryptoTransform_0.InputBlockSize;
	}

	// Token: 0x06000123 RID: 291 RVA: 0x0000379D File Offset: 0x0000199D
	public override int vmethod_2(byte[] byte_0, int int_0, int int_1, byte[] byte_1, int int_2)
	{
		return this.icryptoTransform_0.TransformBlock(byte_0, int_0, int_1, byte_1, int_2);
	}

	// Token: 0x06000124 RID: 292 RVA: 0x000037B1 File Offset: 0x000019B1
	public override byte[] vmethod_3(byte[] byte_0, int int_0, int int_1)
	{
		return this.icryptoTransform_0.TransformFinalBlock(byte_0, int_0, int_1);
	}

	// Token: 0x04000099 RID: 153
	private ICryptoTransform icryptoTransform_0;
}
