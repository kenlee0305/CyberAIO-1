using System;

// Token: 0x020000C6 RID: 198
internal static class Class107
{
	// Token: 0x06000524 RID: 1316 RVA: 0x0000579B File Offset: 0x0000399B
	public static Type smethod_0(Type type_0)
	{
		if (!type_0.IsByRef && !type_0.IsArray && !type_0.IsPointer)
		{
			return type_0;
		}
		return Class107.smethod_0(type_0.GetElementType());
	}

	// Token: 0x06000525 RID: 1317 RVA: 0x000057C2 File Offset: 0x000039C2
	public static Type smethod_1(Type type_0)
	{
		if (type_0.HasElementType && !type_0.IsArray)
		{
			type_0 = type_0.GetElementType();
		}
		return type_0;
	}

	// Token: 0x06000526 RID: 1318 RVA: 0x0002C0D8 File Offset: 0x0002A2D8
	public static Class57<Struct45> smethod_2(Type type_0)
	{
		Class57<Struct45> @class = new Class57<Struct45>();
		Type type = type_0;
		for (;;)
		{
			if (type.IsArray)
			{
				@class.method_7(new Struct45
				{
					int_0 = 0,
					int_1 = type.GetArrayRank()
				});
			}
			else if (type.IsByRef)
			{
				@class.method_7(new Struct45
				{
					int_0 = 2
				});
			}
			else
			{
				if (!type.IsPointer)
				{
					break;
				}
				@class.method_7(new Struct45
				{
					int_0 = 1
				});
			}
			type = type.GetElementType();
		}
		return @class;
	}

	// Token: 0x06000527 RID: 1319 RVA: 0x0002C16C File Offset: 0x0002A36C
	public static Class57<Struct45> smethod_3(string string_0)
	{
		string text = string_0;
		Class57<Struct45> @class = new Class57<Struct45>();
		for (;;)
		{
			if (text.EndsWith(Class185.smethod_0(537697202), StringComparison.Ordinal))
			{
				@class.method_7(new Struct45
				{
					int_0 = 2
				});
				text = text.Substring(0, text.Length - 1);
			}
			else if (text.EndsWith(Class185.smethod_0(537697194), StringComparison.Ordinal))
			{
				@class.method_7(new Struct45
				{
					int_0 = 1
				});
				text = text.Substring(0, text.Length - 1);
			}
			else if (text.EndsWith(Class185.smethod_0(537697186), StringComparison.Ordinal))
			{
				@class.method_7(new Struct45
				{
					int_0 = 0,
					int_1 = 1
				});
				text = text.Substring(0, text.Length - 2);
			}
			else
			{
				if (!text.EndsWith(Class185.smethod_0(537697243), StringComparison.Ordinal))
				{
					return @class;
				}
				int num = 1;
				int num2 = -1;
				for (int i = text.Length - 2; i >= 0; i--)
				{
					char c = text[i];
					if (c != ',')
					{
						if (c != '[')
						{
							goto Block_5;
						}
						num2 = i;
						i = -1;
					}
					else
					{
						num++;
					}
				}
				if (num2 < 0)
				{
					goto IL_159;
				}
				text = text.Substring(0, num2);
				@class.method_7(new Struct45
				{
					int_0 = 0,
					int_1 = num
				});
			}
		}
		Block_5:
		throw new InvalidOperationException(Class185.smethod_0(537697236));
		IL_159:
		throw new InvalidOperationException(Class185.smethod_0(537697218));
	}

	// Token: 0x06000528 RID: 1320 RVA: 0x0002C2F4 File Offset: 0x0002A4F4
	public static Type smethod_4(Type type_0, Class57<Struct45> class57_0)
	{
		Type type = type_0;
		while (class57_0.Count > 0)
		{
			Struct45 @struct = class57_0.method_6();
			switch (@struct.int_0)
			{
			case 0:
				if (@struct.int_1 == 1)
				{
					type = type.MakeArrayType();
				}
				else
				{
					type = type.MakeArrayType(@struct.int_1);
				}
				break;
			case 1:
				type = type.MakePointerType();
				break;
			case 2:
				type = type.MakeByRefType();
				break;
			}
		}
		return type;
	}
}
