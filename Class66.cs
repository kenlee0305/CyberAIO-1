using System;

// Token: 0x020000B4 RID: 180
internal sealed class Class66 : Class65
{
	// Token: 0x060004D8 RID: 1240 RVA: 0x000053F6 File Offset: 0x000035F6
	public Class66(Interface6 interface6_1, Interface8 interface8_1)
	{
		this.interface6_0 = interface6_1;
		this.interface8_0 = interface8_1;
		this.byte_1 = new byte[interface6_1.imethod_2()];
		this.int_0 = 0;
	}

	// Token: 0x060004D9 RID: 1241 RVA: 0x00005424 File Offset: 0x00003624
	public Class66(Interface6 interface6_1) : this(interface6_1, new Class189())
	{
	}

	// Token: 0x060004DA RID: 1242 RVA: 0x00005432 File Offset: 0x00003632
	public override void imethod_1(bool bool_1, Interface1 interface1_0)
	{
		this.bool_0 = bool_1;
		this.imethod_15();
		this.interface8_0.imethod_0();
		this.interface6_0.imethod_1(bool_1, interface1_0);
	}

	// Token: 0x060004DB RID: 1243 RVA: 0x0002A98C File Offset: 0x00028B8C
	public override int imethod_3(int int_1)
	{
		int num = int_1 + this.int_0;
		int num2 = num % this.byte_1.Length;
		if (num2 != 0)
		{
			return num - num2 + this.byte_1.Length;
		}
		if (this.bool_0)
		{
			return num + this.byte_1.Length;
		}
		return num;
	}

	// Token: 0x060004DC RID: 1244 RVA: 0x0002A9D4 File Offset: 0x00028BD4
	public override int imethod_4(int int_1)
	{
		int num = int_1 + this.int_0;
		int num2 = num % this.byte_1.Length;
		if (num2 == 0)
		{
			return num - this.byte_1.Length;
		}
		return num - num2;
	}

	// Token: 0x060004DD RID: 1245 RVA: 0x0002AA08 File Offset: 0x00028C08
	public override int imethod_8(byte[] byte_2, int int_1, int int_2, byte[] byte_3, int int_3)
	{
		if (int_2 < 0)
		{
			throw new ArgumentException(Class185.smethod_0(537694875));
		}
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
		return num3;
	}

	// Token: 0x060004DE RID: 1246 RVA: 0x0002AB04 File Offset: 0x00028D04
	public override int imethod_12(byte[] byte_2, int int_1)
	{
		int num = this.interface6_0.imethod_2();
		int num2 = 0;
		if (!this.bool_0)
		{
			if (this.int_0 == num)
			{
				num2 = this.interface6_0.imethod_4(this.byte_1, 0, this.byte_1, 0);
				this.int_0 = 0;
				try
				{
					num2 -= this.interface8_0.imethod_3(this.byte_1);
					Array.Copy(this.byte_1, 0, byte_2, int_1, num2);
					return num2;
				}
				finally
				{
					this.imethod_15();
				}
			}
			this.imethod_15();
			throw new Exception1(Class185.smethod_0(537694901));
		}
		if (this.int_0 == num)
		{
			if (int_1 + 2 * num > byte_2.Length)
			{
				this.imethod_15();
				throw new Exception1(Class185.smethod_0(537694976));
			}
			num2 = this.interface6_0.imethod_4(this.byte_1, 0, byte_2, int_1);
			this.int_0 = 0;
		}
		this.interface8_0.imethod_2(this.byte_1, this.int_0);
		num2 += this.interface6_0.imethod_4(this.byte_1, 0, byte_2, int_1 + num2);
		this.imethod_15();
		return num2;
	}

	// Token: 0x04000263 RID: 611
	private readonly Interface8 interface8_0;
}
