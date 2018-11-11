using System;

// Token: 0x020000C0 RID: 192
internal static class Class104
{
	// Token: 0x06000504 RID: 1284 RVA: 0x0002B6C4 File Offset: 0x000298C4
	private static bool smethod_0<T>(Type type_0)
	{
		Type typeFromHandle = typeof(T);
		return type_0 == typeFromHandle || type_0.IsSubclassOf(typeFromHandle);
	}

	// Token: 0x06000505 RID: 1285 RVA: 0x0002B6EC File Offset: 0x000298EC
	public static Class144 smethod_1(object object_0, Type type_0)
	{
		Class144 @class = object_0 as Class144;
		if (@class != null)
		{
			return @class;
		}
		if (type_0 == null)
		{
			if (object_0 == null)
			{
				return new Class171();
			}
			type_0 = object_0.GetType();
		}
		type_0 = Class107.smethod_1(type_0);
		if (type_0 == Class28.type_0)
		{
			@class = new Class171();
			if (object_0 != null && object_0.GetType() != Class28.type_0)
			{
				@class.method_1(object_0.GetType());
			}
		}
		else if (Class104.smethod_0<Array>(type_0))
		{
			@class = new Class145();
		}
		else if (Class104.smethod_0<string>(type_0))
		{
			@class = new Class148();
		}
		else if (Class104.smethod_0<IntPtr>(type_0))
		{
			@class = new Class151();
		}
		else if (Class104.smethod_0<UIntPtr>(type_0))
		{
			@class = new Class162();
		}
		else if (Class104.smethod_0<ulong>(type_0))
		{
			@class = new Class170();
		}
		else if (Class104.smethod_0<uint>(type_0))
		{
			@class = new Class168();
		}
		else if (Class104.smethod_0<ushort>(type_0))
		{
			@class = new Class164();
		}
		else if (Class104.smethod_0<long>(type_0))
		{
			@class = new Class161();
		}
		else if (Class104.smethod_0<int>(type_0))
		{
			@class = new Class150();
		}
		else if (Class104.smethod_0<short>(type_0))
		{
			@class = new Class146();
		}
		else if (Class104.smethod_0<byte>(type_0))
		{
			@class = new Class169();
		}
		else if (Class104.smethod_0<sbyte>(type_0))
		{
			@class = new Class166();
		}
		else if (Class104.smethod_0<double>(type_0))
		{
			@class = new Class163();
		}
		else if (Class104.smethod_0<float>(type_0))
		{
			@class = new Class167();
		}
		else if (Class104.smethod_0<bool>(type_0))
		{
			@class = new Class149();
		}
		else if (Class104.smethod_0<char>(type_0))
		{
			@class = new Class160();
		}
		else if (Class28.smethod_0(type_0))
		{
			Class171 class2 = new Class171();
			class2.method_1(type_0);
			@class = class2;
		}
		else
		{
			if (Class104.smethod_0<Enum>(type_0))
			{
				Enum enum_;
				if (object_0 == null)
				{
					if (type_0 == Class28.type_2)
					{
						enum_ = null;
					}
					else
					{
						enum_ = (Enum)Activator.CreateInstance(type_0);
					}
				}
				else if (type_0 == Class28.type_2 && object_0 is Enum)
				{
					enum_ = (Enum)object_0;
				}
				else
				{
					enum_ = (Enum)Enum.ToObject(type_0, object_0);
				}
				return new Class165(enum_);
			}
			if (Class104.smethod_0<ValueType>(type_0))
			{
				if (object_0 == null)
				{
					object object_;
					if (type_0 == Class28.type_3)
					{
						object_ = null;
					}
					else
					{
						object_ = Activator.CreateInstance(type_0);
					}
					@class = new Class159(object_);
				}
				else
				{
					if (object_0.GetType() != type_0)
					{
						try
						{
							object_0 = Convert.ChangeType(object_0, type_0);
						}
						catch
						{
						}
					}
					@class = new Class159(object_0);
				}
				return @class;
			}
			@class = new Class171();
		}
		if (object_0 != null)
		{
			@class.vmethod_1(object_0);
		}
		return @class;
	}
}
