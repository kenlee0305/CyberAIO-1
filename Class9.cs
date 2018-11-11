using System;
using System.IO;

// Token: 0x02000017 RID: 23
internal sealed class Class9
{
	// Token: 0x0600008B RID: 139 RVA: 0x00003111 File Offset: 0x00001311
	private static Stream smethod_0()
	{
		return (Stream)Class62.smethod_0().method_232(Class62.smethod_1(), "rr;nMqYT1G", null);
	}

	// Token: 0x0600008C RID: 140 RVA: 0x0000312D File Offset: 0x0000132D
	private static int smethod_1()
	{
		return (int)Class62.smethod_0().method_232(Class62.smethod_1(), "rr;m<qYT1G", null);
	}

	// Token: 0x0600008D RID: 141 RVA: 0x0000314E File Offset: 0x0000134E
	private static byte[] smethod_2()
	{
		return (byte[])Class62.smethod_0().method_232(Class62.smethod_1(), "rr;mUqYT1G", null);
	}

	// Token: 0x0600008E RID: 142 RVA: 0x0000316A File Offset: 0x0000136A
	private static byte[] smethod_3()
	{
		return (byte[])Class62.smethod_0().method_232(Class62.smethod_1(), "rr;opqYSY8", null);
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00003186 File Offset: 0x00001386
	public static void smethod_4(string string_0, byte[] byte_0, int int_0, int int_1)
	{
		if (Class9.stream_0 == null)
		{
			Class9.stream_0 = Class9.smethod_0();
		}
		Class9.smethod_9(Class9.smethod_11(string_0), byte_0, int_0, int_1);
	}

	// Token: 0x06000090 RID: 144 RVA: 0x0000B598 File Offset: 0x00009798
	public static byte[] smethod_5(string string_0)
	{
		if (Class9.stream_0 == null)
		{
			Class9.stream_0 = Class9.smethod_0();
		}
		long num = Class9.smethod_11(string_0);
		byte[] array = new byte[4];
		Class9.smethod_9(num, array, 0, 4);
		int num2 = Class15.smethod_4(array, 0);
		Array.Clear(array, 0, array.Length);
		byte[] array2 = new byte[num2];
		Class9.smethod_9(num + 4L, array2, 0, num2);
		return array2;
	}

	// Token: 0x06000091 RID: 145 RVA: 0x0000B5F8 File Offset: 0x000097F8
	private static Class47 smethod_6(out bool bool_0)
	{
		bool_0 = true;
		if (Class9.class47_0 != null)
		{
			return Class9.class47_0;
		}
		if (Class9.class141_0 != null)
		{
			bool_0 = false;
			return Class9.class141_0.method_8();
		}
		Class141 @class = Class9.smethod_8();
		Class47 class2 = @class.method_8();
		if (class2.vmethod_0())
		{
			Class9.class47_0 = class2;
			@class.Dispose();
		}
		else
		{
			Class9.class141_0 = @class;
			bool_0 = false;
		}
		return class2;
	}

	// Token: 0x06000092 RID: 146 RVA: 0x0000B658 File Offset: 0x00009858
	private static int smethod_7()
	{
		if (Class9.nullable_0 != null)
		{
			return Class9.nullable_0.Value;
		}
		bool flag;
		Class47 @class = Class9.smethod_6(out flag);
		Class9.nullable_0 = new int?(@class.vmethod_1());
		if (!flag)
		{
			@class.Dispose();
		}
		return Class9.nullable_0.Value;
	}

	// Token: 0x06000093 RID: 147 RVA: 0x000031A7 File Offset: 0x000013A7
	private static Class141 smethod_8()
	{
		return (Class141)Class62.smethod_0().method_232(Class62.smethod_1(), "rr;n0qYU-b", null);
	}

	// Token: 0x06000094 RID: 148 RVA: 0x0000B6A8 File Offset: 0x000098A8
	private static void smethod_9(long long_0, byte[] byte_0, int int_0, int int_1)
	{
		object[] object_ = new object[]
		{
			long_0,
			byte_0,
			int_0,
			int_1
		};
		Class62.smethod_0().method_203(Class62.smethod_1(), "rr;m:qYU6e", object_);
	}

	// Token: 0x06000095 RID: 149 RVA: 0x0000B6F0 File Offset: 0x000098F0
	private static void smethod_10(long long_0, byte[] byte_0)
	{
		object[] object_ = new object[]
		{
			long_0,
			byte_0
		};
		Class62.smethod_0().method_203(Class62.smethod_1(), "rr;ohqYTjZ", object_);
	}

	// Token: 0x06000096 RID: 150 RVA: 0x0000B728 File Offset: 0x00009928
	private static long smethod_11(string string_0)
	{
		object[] object_ = new object[]
		{
			string_0
		};
		return (long)Class62.smethod_0().method_232(Class62.smethod_1(), "rr;mLqYU!^", object_);
	}

	// Token: 0x04000063 RID: 99
	[ThreadStatic]
	private static Stream stream_0;

	// Token: 0x04000064 RID: 100
	[ThreadStatic]
	private static Class141 class141_0;

	// Token: 0x04000065 RID: 101
	[ThreadStatic]
	private static Class47 class47_0;

	// Token: 0x04000066 RID: 102
	private static int? nullable_0;
}
