using System;
using System.IO;

// Token: 0x0200001D RID: 29
internal sealed class Class53 : Class52, IDisposable
{
	// Token: 0x060000B9 RID: 185 RVA: 0x00003317 File Offset: 0x00001517
	public Class53() : this(0)
	{
	}

	// Token: 0x060000BA RID: 186 RVA: 0x0000D498 File Offset: 0x0000B698
	public Class53(int int_4)
	{
		if (int_4 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		this.byte_0 = new byte[int_4];
		this.int_3 = int_4;
		this.bool_0 = true;
		this.bool_1 = true;
		this.int_0 = 0;
		this.bool_2 = true;
	}

	// Token: 0x060000BB RID: 187 RVA: 0x00003320 File Offset: 0x00001520
	public Class53(byte[] byte_1) : this(byte_1, true)
	{
	}

	// Token: 0x060000BC RID: 188 RVA: 0x0000D4E4 File Offset: 0x0000B6E4
	public Class53(byte[] byte_1, bool bool_4)
	{
		if (byte_1 == null)
		{
			throw new ArgumentNullException();
		}
		this.byte_0 = byte_1;
		this.int_2 = (this.int_3 = byte_1.Length);
		this.bool_1 = bool_4;
		this.int_0 = 0;
		this.bool_2 = true;
	}

	// Token: 0x060000BD RID: 189 RVA: 0x0000332A File Offset: 0x0000152A
	public Class53(byte[] byte_1, int int_4, int int_5) : this(byte_1, int_4, int_5, true)
	{
	}

	// Token: 0x060000BE RID: 190 RVA: 0x0000D530 File Offset: 0x0000B730
	public Class53(byte[] byte_1, int int_4, int int_5, bool bool_4)
	{
		if (byte_1 == null)
		{
			throw new ArgumentNullException();
		}
		if (int_4 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (int_5 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (byte_1.Length - int_4 < int_5)
		{
			throw new ArgumentException();
		}
		this.byte_0 = byte_1;
		this.int_1 = int_4;
		this.int_0 = int_4;
		this.int_2 = (this.int_3 = int_4 + int_5);
		this.bool_1 = bool_4;
		this.bool_0 = false;
		this.bool_2 = true;
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00003336 File Offset: 0x00001536
	public override bool vmethod_0()
	{
		return this.bool_2;
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x00003336 File Offset: 0x00001536
	public override bool vmethod_2()
	{
		return this.bool_2;
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x0000333E File Offset: 0x0000153E
	public override bool vmethod_1()
	{
		return this.bool_1;
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x00003346 File Offset: 0x00001546
	protected override void vmethod_7(bool bool_4)
	{
		if (!this.bool_3)
		{
			if (bool_4)
			{
				this.bool_2 = false;
				this.bool_1 = false;
				this.bool_0 = false;
			}
			this.bool_3 = true;
		}
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x0000D5B0 File Offset: 0x0000B7B0
	private bool method_0(int int_4)
	{
		if (int_4 < 0)
		{
			throw new IOException();
		}
		if (int_4 > this.int_3)
		{
			int num = int_4;
			if (num < 256)
			{
				num = 256;
			}
			if (num < this.int_3 * 2)
			{
				num = this.int_3 * 2;
			}
			this.method_6(num);
			return true;
		}
		return false;
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x0000336F File Offset: 0x0000156F
	public override void vmethod_8()
	{
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x00003371 File Offset: 0x00001571
	internal byte[] method_1()
	{
		return this.byte_0;
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x00003379 File Offset: 0x00001579
	internal void method_2(out int int_4, out int int_5)
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		int_4 = this.int_0;
		int_5 = this.int_2;
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x00003399 File Offset: 0x00001599
	internal int method_3()
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		return this.int_1;
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x0000D600 File Offset: 0x0000B800
	public int method_4(int int_4)
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		int num = this.int_2 - this.int_1;
		if (num > int_4)
		{
			num = int_4;
		}
		if (num < 0)
		{
			num = 0;
		}
		this.int_1 += num;
		return num;
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x000033AF File Offset: 0x000015AF
	public int method_5()
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		return this.int_3 - this.int_0;
	}

	// Token: 0x060000CA RID: 202 RVA: 0x0000D644 File Offset: 0x0000B844
	public void method_6(int int_4)
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		if (int_4 != this.int_3)
		{
			if (!this.bool_0)
			{
				throw new Exception();
			}
			if (int_4 < this.int_2)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (int_4 > 0)
			{
				byte[] dst = new byte[int_4];
				if (this.int_2 > 0)
				{
					Buffer.BlockCopy(this.byte_0, 0, dst, 0, this.int_2);
				}
				this.byte_0 = dst;
			}
			else
			{
				this.byte_0 = null;
			}
			this.int_3 = int_4;
		}
	}

	// Token: 0x060000CB RID: 203 RVA: 0x000033CC File Offset: 0x000015CC
	public override long vmethod_3()
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		return (long)(this.int_2 - this.int_0);
	}

	// Token: 0x060000CC RID: 204 RVA: 0x000033EA File Offset: 0x000015EA
	public override long vmethod_4()
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		return (long)(this.int_1 - this.int_0);
	}

	// Token: 0x060000CD RID: 205 RVA: 0x0000D6C4 File Offset: 0x0000B8C4
	public override void vmethod_5(long long_0)
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		if (long_0 < 0L)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (long_0 > 2147483647L)
		{
			throw new ArgumentOutOfRangeException();
		}
		this.int_1 = this.int_0 + (int)long_0;
	}

	// Token: 0x060000CE RID: 206 RVA: 0x0000D714 File Offset: 0x0000B914
	public override int vmethod_11(byte[] byte_1, int int_4, int int_5)
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		if (byte_1 == null)
		{
			throw new ArgumentNullException();
		}
		if (int_4 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (int_5 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (byte_1.Length - int_4 < int_5)
		{
			throw new ArgumentException();
		}
		int num = this.int_2 - this.int_1;
		if (num > int_5)
		{
			num = int_5;
		}
		if (num <= 0)
		{
			return 0;
		}
		if (num <= 8)
		{
			int num2 = num;
			while (--num2 >= 0)
			{
				byte_1[int_4 + num2] = this.byte_0[this.int_1 + num2];
			}
		}
		else
		{
			Buffer.BlockCopy(this.byte_0, this.int_1, byte_1, int_4, num);
		}
		this.int_1 += num;
		return num;
	}

	// Token: 0x060000CF RID: 207 RVA: 0x0000D7C0 File Offset: 0x0000B9C0
	public override int vmethod_12()
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		if (this.int_1 >= this.int_2)
		{
			return -1;
		}
		byte[] array = this.byte_0;
		int num = this.int_1;
		this.int_1 = num + 1;
		return array[num];
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x0000D804 File Offset: 0x0000BA04
	public override long vmethod_9(long long_0, int int_4)
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		if (long_0 > 2147483647L)
		{
			throw new ArgumentOutOfRangeException();
		}
		switch (int_4)
		{
		case 0:
			if (long_0 < 0L)
			{
				throw new IOException();
			}
			this.int_1 = this.int_0 + (int)long_0;
			break;
		case 1:
			if (long_0 + (long)this.int_1 < (long)this.int_0)
			{
				throw new IOException();
			}
			this.int_1 += (int)long_0;
			break;
		case 2:
			if ((long)this.int_2 + long_0 < (long)this.int_0)
			{
				throw new IOException();
			}
			this.int_1 = this.int_2 + (int)long_0;
			break;
		default:
			throw new ArgumentException();
		}
		return (long)this.int_1;
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x0000D8C4 File Offset: 0x0000BAC4
	public override void vmethod_10(long long_0)
	{
		if (!this.bool_1)
		{
			throw new Exception();
		}
		if (long_0 > 2147483647L)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (long_0 >= 0L && long_0 <= (long)(2147483647 - this.int_0))
		{
			int num = this.int_0 + (int)long_0;
			if (!this.method_0(num) && num > this.int_2)
			{
				Array.Clear(this.byte_0, this.int_2, num - this.int_2);
			}
			this.int_2 = num;
			if (this.int_1 > num)
			{
				this.int_1 = num;
			}
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x0000D964 File Offset: 0x0000BB64
	public byte[] method_7()
	{
		byte[] array = new byte[this.int_2 - this.int_0];
		Buffer.BlockCopy(this.byte_0, this.int_0, array, 0, this.int_2 - this.int_0);
		return array;
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x0000D9A8 File Offset: 0x0000BBA8
	public override void vmethod_13(byte[] byte_1, int int_4, int int_5)
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		if (!this.bool_1)
		{
			throw new Exception();
		}
		if (byte_1 == null)
		{
			throw new ArgumentNullException();
		}
		if (int_4 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (int_5 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (byte_1.Length - int_4 < int_5)
		{
			throw new ArgumentException();
		}
		int num = this.int_1 + int_5;
		if (num < 0)
		{
			throw new IOException();
		}
		if (num > this.int_2)
		{
			bool flag = this.int_1 > this.int_2;
			if (num > this.int_3 && this.method_0(num))
			{
				flag = false;
			}
			if (flag)
			{
				Array.Clear(this.byte_0, this.int_2, num - this.int_2);
			}
			this.int_2 = num;
		}
		if (int_5 <= 8)
		{
			int num2 = int_5;
			while (--num2 >= 0)
			{
				this.byte_0[this.int_1 + num2] = byte_1[int_4 + num2];
			}
		}
		else
		{
			Buffer.BlockCopy(byte_1, int_4, this.byte_0, this.int_1, int_5);
		}
		this.int_1 = num;
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x0000DAA0 File Offset: 0x0000BCA0
	public override void vmethod_14(byte byte_1)
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		if (!this.bool_1)
		{
			throw new Exception();
		}
		if (this.int_1 >= this.int_2)
		{
			int num = this.int_1 + 1;
			bool flag = this.int_1 > this.int_2;
			if (num >= this.int_3 && this.method_0(num))
			{
				flag = false;
			}
			if (flag)
			{
				Array.Clear(this.byte_0, this.int_2, this.int_1 - this.int_2);
			}
			this.int_2 = num;
		}
		byte[] array = this.byte_0;
		int num2 = this.int_1;
		this.int_1 = num2 + 1;
		array[num2] = byte_1;
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x00003408 File Offset: 0x00001608
	public void method_8(Stream stream_0)
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		if (stream_0 == null)
		{
			throw new ArgumentNullException();
		}
		stream_0.Write(this.byte_0, this.int_0, this.int_2 - this.int_0);
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x0000DB44 File Offset: 0x0000BD44
	internal int method_9()
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		int num = this.int_1 += 4;
		if (num > this.int_2)
		{
			this.int_1 = this.int_2;
			throw new Exception();
		}
		return (int)this.byte_0[num - 4] << 8 | (int)this.byte_0[num - 3] << 24 | (int)this.byte_0[num - 1] | (int)this.byte_0[num - 2] << 16;
	}

	// Token: 0x04000081 RID: 129
	private byte[] byte_0;

	// Token: 0x04000082 RID: 130
	private int int_0;

	// Token: 0x04000083 RID: 131
	private int int_1;

	// Token: 0x04000084 RID: 132
	private int int_2;

	// Token: 0x04000085 RID: 133
	private int int_3;

	// Token: 0x04000086 RID: 134
	private bool bool_0;

	// Token: 0x04000087 RID: 135
	private bool bool_1;

	// Token: 0x04000088 RID: 136
	private bool bool_2;

	// Token: 0x04000089 RID: 137
	private bool bool_3;
}
