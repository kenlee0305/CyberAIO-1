using System;

// Token: 0x020000D1 RID: 209
internal class Class65 : Class64
{
	// Token: 0x06000573 RID: 1395 RVA: 0x00005963 File Offset: 0x00003B63
	protected Class65()
	{
	}

	// Token: 0x06000574 RID: 1396 RVA: 0x0000596B File Offset: 0x00003B6B
	public Class65(Interface6 interface6_1)
	{
		if (interface6_1 == null)
		{
			throw new ArgumentNullException(Class185.smethod_0(537694265));
		}
		this.interface6_0 = interface6_1;
		this.byte_1 = new byte[interface6_1.imethod_2()];
		this.int_0 = 0;
	}

	// Token: 0x06000575 RID: 1397 RVA: 0x000059A5 File Offset: 0x00003BA5
	public override string imethod_0()
	{
		return this.interface6_0.imethod_0();
	}

	// Token: 0x06000576 RID: 1398 RVA: 0x000059B2 File Offset: 0x00003BB2
	public override void imethod_1(bool bool_1, Interface1 interface1_0)
	{
		this.bool_0 = bool_1;
		this.imethod_15();
		this.interface6_0.imethod_1(bool_1, interface1_0);
	}

	// Token: 0x06000577 RID: 1399 RVA: 0x000059CE File Offset: 0x00003BCE
	public override int imethod_2()
	{
		return this.interface6_0.imethod_2();
	}

	// Token: 0x06000578 RID: 1400 RVA: 0x00033AD0 File Offset: 0x00031CD0
	public override int imethod_4(int int_1)
	{
		int num = int_1 + this.int_0;
		int num2 = num % this.byte_1.Length;
		return num - num2;
	}

	// Token: 0x06000579 RID: 1401 RVA: 0x000059DB File Offset: 0x00003BDB
	public override int imethod_3(int int_1)
	{
		return int_1 + this.int_0;
	}

	// Token: 0x0600057A RID: 1402 RVA: 0x00033AF4 File Offset: 0x00031CF4
	public override byte[] imethod_6(byte[] byte_2, int int_1, int int_2)
	{
		if (byte_2 == null)
		{
			throw new ArgumentNullException(Class185.smethod_0(537694262));
		}
		if (int_2 < 1)
		{
			return null;
		}
		int num = this.imethod_4(int_2);
		byte[] array = (num > 0) ? new byte[num] : null;
		int num2 = this.imethod_8(byte_2, int_1, int_2, array, 0);
		if (num > 0 && num2 < num)
		{
			byte[] array2 = new byte[num2];
			Array.Copy(array, 0, array2, 0, num2);
			array = array2;
		}
		return array;
	}

	// Token: 0x0600057B RID: 1403 RVA: 0x00033B58 File Offset: 0x00031D58
	public override int imethod_8(byte[] byte_2, int int_1, int int_2, byte[] byte_3, int int_3)
	{
		if (int_2 < 1)
		{
			if (int_2 < 0)
			{
				throw new ArgumentException(Class185.smethod_0(537694875));
			}
			return 0;
		}
		else
		{
			int num = this.imethod_2();
			int num2 = this.imethod_4(int_2);
			if (num2 > 0 && int_3 + num2 > byte_3.Length)
			{
				throw new Exception1(Class185.smethod_0(537694976));
			}
			int num3 = 0;
			int num4 = this.byte_1.Length - this.int_0;
			if (int_2 > num4)
			{
				Array.Copy(byte_2, int_1, this.byte_1, this.int_0, num4);
				num3 += this.interface6_0.imethod_4(this.byte_1, 0, byte_3, int_3);
				this.int_0 = 0;
				int_2 -= num4;
				int_1 += num4;
				while (int_2 > this.byte_1.Length)
				{
					num3 += this.interface6_0.imethod_4(byte_2, int_1, byte_3, int_3 + num3);
					int_2 -= num;
					int_1 += num;
				}
			}
			Array.Copy(byte_2, int_1, this.byte_1, this.int_0, int_2);
			this.int_0 += int_2;
			if (this.int_0 == this.byte_1.Length)
			{
				num3 += this.interface6_0.imethod_4(this.byte_1, 0, byte_3, int_3 + num3);
				this.int_0 = 0;
			}
			return num3;
		}
	}

	// Token: 0x0600057C RID: 1404 RVA: 0x00033C8C File Offset: 0x00031E8C
	public override byte[] imethod_9()
	{
		byte[] array = Class64.byte_0;
		int num = this.imethod_3(0);
		if (num > 0)
		{
			array = new byte[num];
			int num2 = this.imethod_12(array, 0);
			if (num2 < array.Length)
			{
				byte[] array2 = new byte[num2];
				Array.Copy(array, 0, array2, 0, num2);
				array = array2;
			}
		}
		else
		{
			this.imethod_15();
		}
		return array;
	}

	// Token: 0x0600057D RID: 1405 RVA: 0x00033CE0 File Offset: 0x00031EE0
	public override byte[] imethod_11(byte[] byte_2, int int_1, int int_2)
	{
		if (byte_2 == null)
		{
			throw new ArgumentNullException(Class185.smethod_0(537694241));
		}
		int num = this.imethod_3(int_2);
		byte[] array = Class64.byte_0;
		if (num > 0)
		{
			array = new byte[num];
			int num2 = (int_2 > 0) ? this.imethod_8(byte_2, int_1, int_2, array, 0) : 0;
			num2 += this.imethod_12(array, num2);
			if (num2 < array.Length)
			{
				byte[] array2 = new byte[num2];
				Array.Copy(array, 0, array2, 0, num2);
				array = array2;
			}
		}
		else
		{
			this.imethod_15();
		}
		return array;
	}

	// Token: 0x0600057E RID: 1406 RVA: 0x00033D5C File Offset: 0x00031F5C
	public override int imethod_12(byte[] byte_2, int int_1)
	{
		int result;
		try
		{
			if (this.int_0 != 0)
			{
				if (!this.interface6_0.imethod_3())
				{
					throw new Exception1(Class185.smethod_0(537694300));
				}
				if (int_1 + this.int_0 > byte_2.Length)
				{
					throw new Exception1(Class185.smethod_0(537694334));
				}
				this.interface6_0.imethod_4(this.byte_1, 0, this.byte_1, 0);
				Array.Copy(this.byte_1, 0, byte_2, int_1, this.int_0);
			}
			result = this.int_0;
		}
		finally
		{
			this.imethod_15();
		}
		return result;
	}

	// Token: 0x0600057F RID: 1407 RVA: 0x000059E5 File Offset: 0x00003BE5
	public override void imethod_15()
	{
		Array.Clear(this.byte_1, 0, this.byte_1.Length);
		this.int_0 = 0;
		this.interface6_0.imethod_5();
	}

	// Token: 0x040002B7 RID: 695
	internal byte[] byte_1;

	// Token: 0x040002B8 RID: 696
	internal int int_0;

	// Token: 0x040002B9 RID: 697
	internal bool bool_0;

	// Token: 0x040002BA RID: 698
	internal Interface6 interface6_0;
}
