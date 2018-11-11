using System;

// Token: 0x02000071 RID: 113
internal sealed class Class63
{
	// Token: 0x06000268 RID: 616 RVA: 0x00004279 File Offset: 0x00002479
	public Class63(byte[] byte_2)
	{
		if (byte_2 == null)
		{
			throw new ArgumentNullException(Class185.smethod_0(537696969));
		}
		if (byte_2.Length != 10)
		{
			throw new ArgumentException(Class185.smethod_0(537696964));
		}
		this.byte_0 = byte_2;
	}

	// Token: 0x0600026A RID: 618 RVA: 0x000042CE File Offset: 0x000024CE
	public byte[] method_0(byte[] byte_2)
	{
		return this.method_6(byte_2, true);
	}

	// Token: 0x0600026B RID: 619 RVA: 0x000042D8 File Offset: 0x000024D8
	public byte[] method_1(byte[] byte_2)
	{
		return this.method_6(byte_2, false);
	}

	// Token: 0x0600026C RID: 620 RVA: 0x000042E2 File Offset: 0x000024E2
	private static byte[] smethod_0(uint uint_0)
	{
		return new byte[]
		{
			(byte)(uint_0 >> 24),
			(byte)(uint_0 >> 16),
			(byte)(uint_0 >> 8),
			(byte)uint_0
		};
	}

	// Token: 0x0600026D RID: 621 RVA: 0x00004306 File Offset: 0x00002506
	private static uint smethod_1(byte[] byte_2)
	{
		return (uint)((int)byte_2[0] << 24 | (int)byte_2[1] << 16 | (int)byte_2[2] << 8 | (int)byte_2[3]);
	}

	// Token: 0x0600026E RID: 622 RVA: 0x0000431F File Offset: 0x0000251F
	private static byte[] smethod_2(int int_0)
	{
		return new byte[]
		{
			(byte)(int_0 >> 24),
			(byte)(int_0 >> 16),
			(byte)(int_0 >> 8),
			(byte)int_0
		};
	}

	// Token: 0x0600026F RID: 623 RVA: 0x00004306 File Offset: 0x00002506
	private static int smethod_3(byte[] byte_2)
	{
		return (int)byte_2[0] << 24 | (int)byte_2[1] << 16 | (int)byte_2[2] << 8 | (int)byte_2[3];
	}

	// Token: 0x06000270 RID: 624 RVA: 0x00004343 File Offset: 0x00002543
	public uint method_2(uint uint_0)
	{
		return Class63.smethod_1(this.method_0(Class63.smethod_0(uint_0)));
	}

	// Token: 0x06000271 RID: 625 RVA: 0x00004356 File Offset: 0x00002556
	public uint method_3(uint uint_0)
	{
		return Class63.smethod_1(this.method_1(Class63.smethod_0(uint_0)));
	}

	// Token: 0x06000272 RID: 626 RVA: 0x00004369 File Offset: 0x00002569
	public int method_4(int int_0)
	{
		return Class63.smethod_3(this.method_0(Class63.smethod_2(int_0)));
	}

	// Token: 0x06000273 RID: 627 RVA: 0x0000437C File Offset: 0x0000257C
	public int method_5(int int_0)
	{
		return Class63.smethod_3(this.method_1(Class63.smethod_2(int_0)));
	}

	// Token: 0x06000274 RID: 628 RVA: 0x000186C8 File Offset: 0x000168C8
	private static ushort smethod_4(byte[] byte_2, int int_0, ushort ushort_0)
	{
		byte b = (byte)(ushort_0 >> 8 & 255);
		byte b2 = (byte)(ushort_0 & 255);
		byte b3 = Class63.byte_1[(int)(b2 ^ byte_2[4 * int_0 % 10])] ^ b;
		byte b4 = Class63.byte_1[(int)(b3 ^ byte_2[(4 * int_0 + 1) % 10])] ^ b2;
		byte b5 = Class63.byte_1[(int)(b4 ^ byte_2[(4 * int_0 + 2) % 10])] ^ b3;
		byte b6 = Class63.byte_1[(int)(b5 ^ byte_2[(4 * int_0 + 3) % 10])] ^ b4;
		return (ushort)(((int)b5 << 8) + (int)b6);
	}

	// Token: 0x06000275 RID: 629 RVA: 0x0001874C File Offset: 0x0001694C
	private byte[] method_6(byte[] byte_2, bool bool_0)
	{
		if (byte_2 == null)
		{
			throw new ArgumentNullException(Class185.smethod_0(537697022));
		}
		int num = byte_2.Length;
		if (num % 4 != 0)
		{
			throw new ArgumentOutOfRangeException(Class185.smethod_0(537697001), Class185.smethod_0(537696996));
		}
		byte[] byte_3 = this.byte_0;
		byte[] array = new byte[num];
		for (int i = 0; i < num; i += 4)
		{
			Class63.smethod_5(byte_3, byte_2, i, array, i, bool_0);
		}
		return array;
	}

	// Token: 0x06000276 RID: 630 RVA: 0x000187B8 File Offset: 0x000169B8
	private static void smethod_5(byte[] byte_2, byte[] byte_3, int int_0, byte[] byte_4, int int_1, bool bool_0)
	{
		int num;
		int num2;
		if (bool_0)
		{
			num = 1;
			num2 = 0;
		}
		else
		{
			num = -1;
			num2 = 23;
		}
		ushort num3 = (ushort)(((int)byte_3[int_0] << 8) + (int)byte_3[int_0 + 1]);
		ushort num4 = (ushort)(((int)byte_3[int_0 + 2] << 8) + (int)byte_3[int_0 + 3]);
		for (int i = 0; i < 12; i++)
		{
			num4 ^= (ushort)((int)Class63.smethod_4(byte_2, num2, num3) ^ num2);
			num2 += num;
			num3 ^= (ushort)((int)Class63.smethod_4(byte_2, num2, num4) ^ num2);
			num2 += num;
		}
		byte_4[int_1] = (byte)(num4 >> 8);
		byte_4[int_1 + 1] = (byte)(num4 & 255);
		byte_4[int_1 + 2] = (byte)(num3 >> 8);
		byte_4[int_1 + 3] = (byte)(num3 & 255);
	}

	// Token: 0x04000163 RID: 355
	private readonly byte[] byte_0;

	// Token: 0x04000164 RID: 356
	private static byte[] byte_1 = new byte[]
	{
		163,
		215,
		9,
		131,
		248,
		72,
		246,
		244,
		179,
		33,
		21,
		120,
		153,
		177,
		175,
		249,
		231,
		45,
		77,
		138,
		206,
		76,
		202,
		46,
		82,
		149,
		217,
		30,
		78,
		56,
		68,
		40,
		10,
		223,
		2,
		160,
		23,
		241,
		96,
		104,
		18,
		183,
		122,
		195,
		233,
		250,
		61,
		83,
		150,
		132,
		107,
		186,
		242,
		99,
		154,
		25,
		124,
		174,
		229,
		245,
		247,
		22,
		106,
		162,
		57,
		182,
		123,
		15,
		193,
		147,
		129,
		27,
		238,
		180,
		26,
		234,
		208,
		145,
		47,
		184,
		85,
		185,
		218,
		133,
		63,
		65,
		191,
		224,
		90,
		88,
		128,
		95,
		102,
		11,
		216,
		144,
		53,
		213,
		192,
		167,
		51,
		6,
		101,
		105,
		69,
		0,
		148,
		86,
		109,
		152,
		155,
		118,
		151,
		252,
		178,
		194,
		176,
		254,
		219,
		32,
		225,
		235,
		214,
		228,
		221,
		71,
		74,
		29,
		66,
		237,
		158,
		110,
		73,
		60,
		205,
		67,
		39,
		210,
		7,
		212,
		222,
		199,
		103,
		24,
		137,
		203,
		48,
		31,
		141,
		198,
		143,
		170,
		200,
		116,
		220,
		201,
		93,
		92,
		49,
		164,
		112,
		136,
		97,
		44,
		159,
		13,
		43,
		135,
		80,
		130,
		84,
		100,
		38,
		125,
		3,
		64,
		52,
		75,
		28,
		115,
		209,
		196,
		253,
		59,
		204,
		251,
		127,
		171,
		230,
		62,
		91,
		165,
		173,
		4,
		35,
		156,
		20,
		81,
		34,
		240,
		41,
		121,
		113,
		126,
		byte.MaxValue,
		140,
		14,
		226,
		12,
		239,
		188,
		114,
		117,
		111,
		55,
		161,
		236,
		211,
		142,
		98,
		139,
		134,
		16,
		232,
		8,
		119,
		17,
		190,
		146,
		79,
		36,
		197,
		50,
		54,
		157,
		207,
		243,
		166,
		187,
		172,
		94,
		108,
		169,
		19,
		87,
		37,
		181,
		227,
		189,
		168,
		58,
		1,
		5,
		89,
		42,
		70
	};
}
