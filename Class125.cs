using System;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x020000E5 RID: 229
internal static class Class125
{
	// Token: 0x060005F3 RID: 1523 RVA: 0x00035478 File Offset: 0x00033678
	public static Class12 smethod_0(string string_0)
	{
		byte[] array = Class9.smethod_5(string_0);
		if (array == null)
		{
			return null;
		}
		return new Class12
		{
			class184_0 = new Class184
			{
				byte_0 = array,
				bool_0 = true,
				bool_1 = true
			}
		};
	}

	// Token: 0x060005F4 RID: 1524 RVA: 0x000354B8 File Offset: 0x000336B8
	public static byte[] smethod_1(string string_0)
	{
		if (string_0 == null)
		{
			return null;
		}
		if (string_0.Length == 0)
		{
			return new byte[0];
		}
		byte[] bytes = Encoding.UTF8.GetBytes(string_0);
		byte[] result = Class180.smethod_0(bytes, Class55.smethod_0(), new Func<byte[]>(Class125.smethod_4));
		Array.Clear(bytes, 0, bytes.Length);
		return result;
	}

	// Token: 0x060005F5 RID: 1525 RVA: 0x00035508 File Offset: 0x00033708
	public static string smethod_2(byte[] byte_0, bool bool_0)
	{
		if (byte_0 == null)
		{
			return null;
		}
		if (byte_0.Length == 0)
		{
			return string.Empty;
		}
		byte[] array = Class180.smethod_1<byte>(byte_0, 0, Class55.smethod_0(), new Func<byte[]>(Class125.smethod_4), bool_0);
		string @string = Encoding.UTF8.GetString(array);
		Array.Clear(array, 0, array.Length);
		return @string;
	}

	// Token: 0x060005F6 RID: 1526 RVA: 0x00035554 File Offset: 0x00033754
	public static void smethod_3(string string_0)
	{
		if (string.IsInterned(string_0) != null)
		{
			return;
		}
		GCHandle gchandle = default(GCHandle);
		try
		{
			gchandle = GCHandle.Alloc(string_0, GCHandleType.Pinned);
			IntPtr ptr = gchandle.AddrOfPinnedObject();
			bool flag = IntPtr.Size == 4;
			int num = string_0.Length * 2;
			int i = 0;
			int num2 = num / IntPtr.Size;
			for (int j = 0; j < num2; j++)
			{
				if (flag)
				{
					Marshal.WriteInt32(ptr, i, 0);
				}
				else
				{
					Marshal.WriteInt64(ptr, i, 0L);
				}
				i += IntPtr.Size;
			}
			while (i < num)
			{
				Marshal.WriteInt16(ptr, i, 0);
				i += 2;
			}
			gchandle.Free();
		}
		catch (Exception)
		{
			if (gchandle.IsAllocated)
			{
				gchandle.Free();
			}
		}
	}

	// Token: 0x060005F7 RID: 1527 RVA: 0x00006037 File Offset: 0x00004237
	private static byte[] smethod_4()
	{
		return (byte[])Class62.smethod_0().method_232(Class62.smethod_1(), "rr;n^qYTOQ", null);
	}
}
