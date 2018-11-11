using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;

// Token: 0x020000A3 RID: 163
internal sealed class Class87
{
	// Token: 0x06000341 RID: 833 RVA: 0x0001F344 File Offset: 0x0001D544
	public Class87(Class177 class177_1, Module module_1)
	{
		this.dictionary_2 = new Dictionary<MethodBase, int>(256);
		this.dictionary_0 = new Dictionary<MethodBase, object>();
		this.class57_0 = new Class57<Class87.Struct39>();
		this.class57_1 = new Class57<Class144>();
		base..ctor();
		this.class177_0 = class177_1;
		this.module_0 = module_1;
		this.method_81();
	}

	// Token: 0x06000342 RID: 834 RVA: 0x00004A0A File Offset: 0x00002C0A
	public Class87(Class177 class177_1) : this(class177_1, typeof(Class87).Module)
	{
	}

	// Token: 0x06000343 RID: 835 RVA: 0x0001F3AC File Offset: 0x0001D5AC
	// Note: this type is marked as 'beforefieldinit'.
	static Class87()
	{
		Class87.object_2 = new object();
		Class87.type_2 = typeof(void);
		Class87.type_8 = typeof(object[]);
		Class87.type_0 = typeof(IntPtr);
		Class87.type_6 = typeof(Assembly);
		Class87.type_1 = typeof(MethodBase);
		Class87.type_4 = typeof(RuntimeHelpers);
	}

	// Token: 0x06000344 RID: 836 RVA: 0x0001F434 File Offset: 0x0001D634
	private void method_0(Class144 class144_2)
	{
		Class169 @class = (Class169)class144_2;
		this.method_287((int)@class.method_2());
	}

	// Token: 0x06000345 RID: 837 RVA: 0x0001F454 File Offset: 0x0001D654
	private void method_1(Class144 class144_2)
	{
		int int_ = ((Class150)class144_2).method_2();
		FieldInfo fieldInfo = this.method_122(int_);
		Class144 @class = this.method_218();
		Class152 class152_;
		if ((class152_ = (@class as Class152)) != null)
		{
			@class = this.method_245(class152_);
		}
		object obj = @class.vmethod_0();
		if (obj == null)
		{
			throw new NullReferenceException();
		}
		this.method_129(Class104.smethod_1(fieldInfo.GetValue(obj), fieldInfo.FieldType));
	}

	// Token: 0x06000346 RID: 838 RVA: 0x00004A22 File Offset: 0x00002C22
	private void method_2(Class144 class144_2)
	{
		this.method_129(class144_2);
	}

	// Token: 0x06000347 RID: 839 RVA: 0x0001F4B8 File Offset: 0x0001D6B8
	private Class45 method_3(int int_0)
	{
		if (this.class183_0 == null)
		{
			throw new InvalidOperationException();
		}
		Class52 obj = this.class183_0.method_0();
		Class45 result;
		lock (obj)
		{
			this.class183_0.method_0().vmethod_9((long)int_0, 0);
			Class45 @class = new Class45();
			@class.method_1(this.class183_0.method_6());
			if (@class.method_0() == 1)
			{
				@class.method_3(this.class183_0.method_19());
			}
			else
			{
				@class.method_5(this.method_21(this.class183_0));
			}
			result = @class;
		}
		return result;
	}

	// Token: 0x06000348 RID: 840 RVA: 0x00004A2B File Offset: 0x00002C2B
	private static void smethod_0(ILGenerator ilgenerator_0, Type type_9)
	{
		if (!type_9.IsValueType && !Class107.smethod_0(type_9).IsGenericParameter)
		{
			Class87.smethod_11(ilgenerator_0, type_9);
			return;
		}
		ilgenerator_0.Emit(OpCodes.Unbox_Any, type_9);
	}

	// Token: 0x06000349 RID: 841 RVA: 0x00004A56 File Offset: 0x00002C56
	private void method_4(Class144 class144_2)
	{
		throw new NotSupportedException(Class185.smethod_0(537697413));
	}

	// Token: 0x0600034A RID: 842 RVA: 0x00004A67 File Offset: 0x00002C67
	private void method_5(Class144 class144_2)
	{
		this.method_75(typeof(float));
	}

	// Token: 0x0600034B RID: 843 RVA: 0x00004A79 File Offset: 0x00002C79
	private void method_6(Class144 class144_2)
	{
		throw new NotSupportedException(Class185.smethod_0(537698275));
	}

	// Token: 0x0600034C RID: 844 RVA: 0x00004A8A File Offset: 0x00002C8A
	private void method_7(Class144 class144_2)
	{
		this.method_252();
	}

	// Token: 0x0600034D RID: 845 RVA: 0x00004A92 File Offset: 0x00002C92
	private void method_8(Class144 class144_2)
	{
		this.method_36(typeof(double));
	}

	// Token: 0x0600034E RID: 846 RVA: 0x00004AA4 File Offset: 0x00002CA4
	private void method_9(Class144 class144_2)
	{
		this.method_117(typeof(double));
	}

	// Token: 0x0600034F RID: 847 RVA: 0x0001F55C File Offset: 0x0001D75C
	private void method_10(Class144 class144_2)
	{
		Class164 @class = (Class164)class144_2;
		Class155 class2 = new Class155();
		class2.method_3(this.class144_0[(int)@class.method_2()]);
		this.method_129(class2);
	}

	// Token: 0x06000350 RID: 848 RVA: 0x0001F594 File Offset: 0x0001D794
	private void method_11(Class144 class144_2)
	{
		Class169 @class = (Class169)class144_2;
		this.class144_0[(int)@class.method_2()].vmethod_3(this.method_218());
	}

	// Token: 0x06000351 RID: 849 RVA: 0x0001F5C8 File Offset: 0x0001D7C8
	private void method_12(Class144 class144_2)
	{
		int int_ = ((Class150)class144_2).method_2();
		Type t = this.method_136(int_, true);
		Class150 @class = new Class150();
		@class.method_3(Marshal.SizeOf(t));
		this.method_129(@class);
	}

	// Token: 0x06000352 RID: 850 RVA: 0x0001F604 File Offset: 0x0001D804
	private void method_13(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		Class144 class144_4 = this.method_218();
		this.method_129(this.method_188(class144_4, class144_3, true));
	}

	// Token: 0x06000353 RID: 851 RVA: 0x0001F630 File Offset: 0x0001D830
	private bool method_14(MethodBase methodBase_0, object object_3, ref object object_4, object[] object_5)
	{
		if (!methodBase_0.IsStatic && methodBase_0.Name == Class185.smethod_0(537696765))
		{
			MethodInfo methodInfo = methodBase_0 as MethodInfo;
			if (methodInfo != null)
			{
				Type type = methodInfo.ReturnType;
				if (type.IsByRef)
				{
					type = type.GetElementType();
					int num = object_5.Length;
					if (num >= 1 && object_5[0] is int)
					{
						int[] array = new int[num];
						for (int i = 0; i < num; i++)
						{
							array[i] = (int)object_5[i];
						}
						Class158 @class = new Class158();
						@class.method_5((Array)object_3);
						@class.method_7(array);
						@class.method_3(type);
						object_4 = @class;
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06000354 RID: 852 RVA: 0x00004AB6 File Offset: 0x00002CB6
	private void method_15(Class144 class144_2)
	{
		this.method_129(this.class144_0[3].vmethod_4());
	}

	// Token: 0x06000355 RID: 853 RVA: 0x00004ACF File Offset: 0x00002CCF
	private void method_16(Class144 class144_2)
	{
		this.method_129(this.class144_0[0].vmethod_4());
	}

	// Token: 0x06000356 RID: 854 RVA: 0x00004AE8 File Offset: 0x00002CE8
	private void method_17(Class144 class144_2)
	{
		this.method_294(true);
	}

	// Token: 0x06000357 RID: 855 RVA: 0x0001F6DC File Offset: 0x0001D8DC
	private void method_18(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		Class144 class144_4 = this.method_218();
		this.method_129(this.method_69(class144_4, class144_3));
	}

	// Token: 0x06000358 RID: 856 RVA: 0x0001F708 File Offset: 0x0001D908
	private void method_19(Class144 class144_2)
	{
		MethodBase methodBase_ = ((Class147)this.method_218()).method_2();
		this.method_271(methodBase_, false);
	}

	// Token: 0x06000359 RID: 857 RVA: 0x0001F730 File Offset: 0x0001D930
	private static Class144 smethod_1(Class144 class144_2, Class144 class144_3, bool bool_2, bool bool_3)
	{
		if (!bool_3)
		{
			long num = ((Class161)class144_2).method_2();
			long num2 = ((Class161)class144_3).method_2();
			long long_;
			if (bool_2)
			{
				long_ = checked(num - num2);
			}
			else
			{
				long_ = num - num2;
			}
			Class161 @class = new Class161();
			@class.method_3(long_);
			return @class;
		}
		ulong num3 = (ulong)((Class161)class144_2).method_2();
		ulong num4 = (ulong)((Class161)class144_3).method_2();
		ulong long_2;
		if (bool_2)
		{
			long_2 = checked(num3 - num4);
		}
		else
		{
			long_2 = num3 - num4;
		}
		Class161 class2 = new Class161();
		class2.method_3((long)long_2);
		return class2;
	}

	// Token: 0x0600035A RID: 858 RVA: 0x0001F7AC File Offset: 0x0001D9AC
	private void method_20(Class144 class144_2)
	{
		int int_ = ((Class150)class144_2).method_2();
		Type type = this.method_136(int_, true);
		long long_ = this.method_202();
		Array array_ = (Array)this.method_218().vmethod_0();
		Class157 @class = new Class157();
		@class.method_5(array_);
		@class.method_3(type);
		@class.method_7(long_);
		this.method_129(@class);
	}

	// Token: 0x0600035B RID: 859 RVA: 0x0001F808 File Offset: 0x0001DA08
	private Class128 method_21(Class183 class183_2)
	{
		switch (class183_2.method_6())
		{
		case 0:
		{
			Class129 @class = new Class129();
			Class45 class2 = new Class45();
			class2.method_1(0);
			class2.method_3(class183_2.method_19());
			@class.method_1(class2);
			@class.method_3(class183_2.method_9());
			@class.method_5(class183_2.method_5());
			return @class;
		}
		case 1:
		{
			Class132 class3 = new Class132();
			class3.method_11(class183_2.method_19());
			class3.method_9(class183_2.method_19());
			class3.method_3(class183_2.method_5());
			class3.method_1(class183_2.method_9());
			class3.method_5(class183_2.method_5());
			int num = (int)class183_2.method_23();
			Class45[] array = new Class45[num];
			for (int i = 0; i < num; i++)
			{
				Class45[] array2 = array;
				int num2 = i;
				Class45 class4 = new Class45();
				class4.method_1(0);
				class4.method_3(class183_2.method_19());
				array2[num2] = class4;
			}
			class3.method_7(array);
			return class3;
		}
		case 2:
		{
			Class130 class5 = new Class130();
			class5.method_1(class183_2.method_9());
			return class5;
		}
		case 3:
		{
			Class131 class6 = new Class131();
			class6.method_1(class183_2.method_19());
			class6.method_3(class183_2.method_19());
			return class6;
		}
		case 4:
		{
			Class133 class7 = new Class133();
			Class133 class8 = class7;
			Class45 class9 = new Class45();
			class9.method_1(0);
			class9.method_3(class183_2.method_19());
			class8.method_5(class9);
			class7.method_1(class183_2.method_6());
			class7.method_7(class183_2.method_9());
			Class133 class10 = class7;
			Class45 class11 = new Class45();
			class11.method_1(0);
			class11.method_3(class183_2.method_19());
			class10.method_13(class11);
			int num3 = (int)class183_2.method_23();
			Class45[] array3 = new Class45[num3];
			for (int j = 0; j < num3; j++)
			{
				Class45[] array4 = array3;
				int num4 = j;
				Class45 class12 = new Class45();
				class12.method_1(0);
				class12.method_3(class183_2.method_19());
				array4[num4] = class12;
			}
			class7.method_9(array3);
			int num5 = (int)class183_2.method_23();
			Class45[] array5 = new Class45[num5];
			for (int k = 0; k < num5; k++)
			{
				Class45[] array6 = array5;
				int num6 = k;
				Class45 class13 = new Class45();
				class13.method_1(0);
				class13.method_3(class183_2.method_19());
				array6[num6] = class13;
			}
			class7.method_11(array5);
			return class7;
		}
		default:
			throw new ArgumentOutOfRangeException();
		}
	}

	// Token: 0x0600035C RID: 860 RVA: 0x00004AF1 File Offset: 0x00002CF1
	private void method_22(Class144 class144_2)
	{
		Class150 @class = new Class150();
		@class.method_3(-1);
		this.method_129(@class);
	}

	// Token: 0x0600035D RID: 861 RVA: 0x00004B05 File Offset: 0x00002D05
	private void method_23(Class144 class144_2)
	{
		Class150 @class = new Class150();
		@class.method_3(1);
		this.method_129(@class);
	}

	// Token: 0x0600035E RID: 862 RVA: 0x00004B19 File Offset: 0x00002D19
	private void method_24(Class144 class144_2)
	{
		this.method_92(false);
	}

	// Token: 0x0600035F RID: 863 RVA: 0x0001FA14 File Offset: 0x0001DC14
	private void method_25(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		Class144 class144_4 = this.method_218();
		Class150 @class = new Class150();
		@class.method_3(Class87.smethod_10(class144_4, class144_3) ? 1 : 0);
		this.method_129(@class);
	}

	// Token: 0x06000360 RID: 864 RVA: 0x00004B22 File Offset: 0x00002D22
	private void method_26(Class144 class144_2)
	{
		this.method_75(typeof(int));
	}

	// Token: 0x06000361 RID: 865 RVA: 0x0001FA50 File Offset: 0x0001DC50
	private Class144 method_27(Class144 class144_2, Class144 class144_3)
	{
		if (class144_2.vmethod_2() == 7)
		{
			if (class144_3.vmethod_2() == 7)
			{
				int num = ((Class150)class144_2).method_2();
				int num2 = ((Class150)class144_3).method_2();
				Class150 @class = new Class150();
				@class.method_3(num & num2);
				return @class;
			}
			if (class144_3.vmethod_2() == 24)
			{
				int num3 = ((Class150)class144_2).method_2();
				Type underlyingType = Enum.GetUnderlyingType(class144_3.vmethod_0().GetType());
				if (underlyingType != typeof(long))
				{
					if (underlyingType != typeof(ulong))
					{
						int num4 = Convert.ToInt32(class144_3.vmethod_0());
						Class150 class2 = new Class150();
						class2.method_3(num3 & num4);
						return class2;
					}
				}
				long num5 = Convert.ToInt64(class144_3.vmethod_0());
				Class161 class3 = new Class161();
				class3.method_3((long)num3 & num5);
				return class3;
			}
		}
		if (class144_2.vmethod_2() == 11)
		{
			if (class144_3.vmethod_2() == 11)
			{
				long num6 = ((Class161)class144_2).method_2();
				long num7 = ((Class161)class144_3).method_2();
				Class161 class4 = new Class161();
				class4.method_3(num6 & num7);
				return class4;
			}
			if (class144_3.vmethod_2() == 24)
			{
				int num8 = ((Class150)class144_2).method_2();
				long num9 = Convert.ToInt64(class144_3.vmethod_0());
				Class161 class5 = new Class161();
				class5.method_3((long)num8 & num9);
				return class5;
			}
		}
		if (class144_2.vmethod_2() == 24)
		{
			if (class144_3.vmethod_2() == 7)
			{
				int num10 = ((Class150)class144_3).method_2();
				Type underlyingType2 = Enum.GetUnderlyingType(class144_2.vmethod_0().GetType());
				if (underlyingType2 != typeof(long))
				{
					if (underlyingType2 != typeof(ulong))
					{
						int num11 = Convert.ToInt32(class144_2.vmethod_0());
						Class150 class6 = new Class150();
						class6.method_3(num11 & num10);
						return class6;
					}
				}
				long num12 = Convert.ToInt64(class144_3.vmethod_0());
				Class161 class7 = new Class161();
				class7.method_3(num12 & (long)num10);
				return class7;
			}
			if (class144_3.vmethod_2() == 11)
			{
				long num13 = Convert.ToInt64(class144_2.vmethod_0());
				long num14 = ((Class161)class144_3).method_2();
				Class161 class8 = new Class161();
				class8.method_3(num13 & num14);
				return class8;
			}
			if (class144_3.vmethod_2() == 24)
			{
				Type underlyingType3 = Enum.GetUnderlyingType(class144_2.vmethod_0().GetType());
				Type underlyingType4 = Enum.GetUnderlyingType(class144_3.vmethod_0().GetType());
				if (underlyingType3 != typeof(long) && underlyingType3 != typeof(ulong) && underlyingType4 != typeof(long))
				{
					if (underlyingType4 != typeof(ulong))
					{
						int num15 = Convert.ToInt32(class144_2.vmethod_0());
						int num16 = Convert.ToInt32(class144_3.vmethod_0());
						Class150 class9 = new Class150();
						class9.method_3(num15 & num16);
						return class9;
					}
				}
				long num17 = Convert.ToInt64(class144_2.vmethod_0());
				long num18 = Convert.ToInt64(class144_3.vmethod_0());
				Class161 class10 = new Class161();
				class10.method_3(num17 & num18);
				return class10;
			}
		}
		throw new InvalidOperationException();
	}

	// Token: 0x06000362 RID: 866 RVA: 0x00004B34 File Offset: 0x00002D34
	private void method_28(Class144 class144_2)
	{
		this.method_218();
	}

	// Token: 0x06000363 RID: 867 RVA: 0x0001FD18 File Offset: 0x0001DF18
	private Class114[] method_29(Class183 class183_2)
	{
		Class114[] array = new Class114[(int)class183_2.method_23()];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = this.method_107(class183_2);
		}
		return array;
	}

	// Token: 0x06000364 RID: 868 RVA: 0x0001FD50 File Offset: 0x0001DF50
	private void method_30(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		Class144 class144_4 = this.method_218();
		this.method_129(this.method_215(class144_4, class144_3, false));
	}

	// Token: 0x06000365 RID: 869 RVA: 0x0001FD7C File Offset: 0x0001DF7C
	private Type method_31(int int_0, Class45 class45_0, ref bool bool_2, bool bool_3)
	{
		if (class45_0.method_0() == 1)
		{
			return this.module_0.ResolveType(class45_0.method_2());
		}
		Class132 @class = (Class132)class45_0.method_4();
		Type type;
		if (@class.method_2())
		{
			if (@class.method_10() != -1)
			{
				type = this.type_7[@class.method_10()];
			}
			else
			{
				if (@class.method_8() == -1)
				{
					throw new Exception();
				}
				type = this.type_3[@class.method_8()];
			}
			Class57<Struct45> class2 = Class107.smethod_3(@class.method_0());
			type = Class107.smethod_4(type, class2);
			bool_2 = false;
			return type;
		}
		string text = @class.method_0();
		type = Type.GetType(text);
		if (type == null)
		{
			int num = text.IndexOf(',');
			string text2 = text.Substring(0, num);
			string text3 = text.Substring(num + 1).Trim();
			Assembly assembly_ = Class28.assembly_0;
			if (text3.Equals(assembly_.FullName, StringComparison.Ordinal))
			{
				type = assembly_.GetType(text2);
			}
			else
			{
				Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
				int i = 0;
				while (i < assemblies.Length)
				{
					Assembly assembly = assemblies[i];
					string value = null;
					try
					{
						value = assembly.Location;
						goto IL_13C;
					}
					catch (NotSupportedException)
					{
						goto IL_13C;
					}
					goto IL_119;
					IL_136:
					i++;
					continue;
					IL_119:
					if (!assembly.FullName.Equals(text3, StringComparison.Ordinal))
					{
						goto IL_136;
					}
					type = assembly.GetType(text2);
					if (type == null)
					{
						goto IL_136;
					}
					break;
					IL_13C:
					if (string.IsNullOrEmpty(value))
					{
						goto IL_119;
					}
					goto IL_136;
				}
			}
			if (type == null && text2.StartsWith(Class185.smethod_0(537696558), StringComparison.Ordinal) && text2.Contains(Class185.smethod_0(537696580)))
			{
				try
				{
					foreach (Type type2 in Assembly.Load(text3).GetTypes())
					{
						if (type2.FullName == text2)
						{
							type = type2;
							break;
						}
					}
				}
				catch
				{
				}
			}
		}
		if (@class.method_4())
		{
			Type[] array = new Type[@class.method_6().Length];
			for (int j = 0; j < @class.method_6().Length; j++)
			{
				array[j] = this.method_136(@class.method_6()[j].method_2(), bool_3);
			}
			Type genericTypeDefinition = Class107.smethod_0(type).GetGenericTypeDefinition();
			Class57<Struct45> class3 = Class107.smethod_2(type);
			type = genericTypeDefinition.MakeGenericType(array);
			type = Class107.smethod_4(type, class3);
			bool_2 = false;
		}
		return type;
	}

	// Token: 0x06000366 RID: 870 RVA: 0x0001FFD4 File Offset: 0x0001E1D4
	private void method_32(Class144 class144_2)
	{
		Class144 @class = this.method_218();
		int num = @class.vmethod_2();
		UIntPtr uintptr_;
		if (num <= 11)
		{
			if (num == 7)
			{
				uintptr_ = new UIntPtr((uint)((Class150)@class).method_2());
				goto IL_82;
			}
			if (num == 11)
			{
				uintptr_ = new UIntPtr((ulong)((Class161)@class).method_2());
				goto IL_82;
			}
		}
		else
		{
			if (num == 17)
			{
				uintptr_ = new UIntPtr((ulong)((Class163)@class).method_2());
				goto IL_82;
			}
			if (num == 24)
			{
				uintptr_ = new UIntPtr(Convert.ToUInt64(((Class165)@class).method_2()));
				goto IL_82;
			}
		}
		throw new InvalidOperationException();
		IL_82:
		Class162 class2 = new Class162();
		class2.method_3(uintptr_);
		this.method_129(class2);
	}

	// Token: 0x06000367 RID: 871 RVA: 0x00004B3D File Offset: 0x00002D3D
	private void method_33(Class144 class144_2)
	{
		this.method_75(Class87.type_0);
	}

	// Token: 0x06000368 RID: 872 RVA: 0x00004B4A File Offset: 0x00002D4A
	private void method_34(Class144 class144_2)
	{
		Class150 @class = new Class150();
		@class.method_3(5);
		this.method_129(@class);
	}

	// Token: 0x06000369 RID: 873 RVA: 0x00004B5E File Offset: 0x00002D5E
	private void method_35(Class144 class144_2)
	{
		throw new NotSupportedException(Class185.smethod_0(537696450));
	}

	// Token: 0x0600036A RID: 874 RVA: 0x00020078 File Offset: 0x0001E278
	private void method_36(Type type_9)
	{
		object object_ = this.method_218().vmethod_0();
		long long_ = this.method_202();
		Array array_ = (Array)this.method_218().vmethod_0();
		this.method_206(type_9, object_, long_, array_);
	}

	// Token: 0x0600036B RID: 875 RVA: 0x00004B6F File Offset: 0x00002D6F
	private void method_37(ref Class87.Struct38 struct38_0)
	{
		if (struct38_0.bool_0)
		{
			Monitor.Exit(Class87.object_2);
		}
	}

	// Token: 0x0600036C RID: 876 RVA: 0x000200B4 File Offset: 0x0001E2B4
	private void method_38(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		Class144 class144_4 = this.method_218();
		this.method_129(this.method_188(class144_4, class144_3, false));
	}

	// Token: 0x0600036D RID: 877 RVA: 0x000200E0 File Offset: 0x0001E2E0
	private void method_39(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		Class144 class144_4 = this.method_218();
		Class150 @class = new Class150();
		@class.method_3(Class87.smethod_16(class144_4, class144_3) ? 1 : 0);
		this.method_129(@class);
	}

	// Token: 0x0600036E RID: 878 RVA: 0x00004B83 File Offset: 0x00002D83
	private void method_40(Class144 class144_2)
	{
		this.method_263();
	}

	// Token: 0x0600036F RID: 879 RVA: 0x0002011C File Offset: 0x0001E31C
	private void method_41(bool bool_2)
	{
		Class144 @class = this.method_218();
		int num = @class.vmethod_2();
		sbyte int_;
		if (num <= 11)
		{
			if (num != 7)
			{
				if (num == 11)
				{
					if (bool_2)
					{
						int_ = checked((sbyte)((Class161)@class).method_2());
						goto IL_BD;
					}
					int_ = (sbyte)((Class161)@class).method_2();
					goto IL_BD;
				}
			}
			else
			{
				if (bool_2)
				{
					int_ = checked((sbyte)((Class150)@class).method_2());
					goto IL_BD;
				}
				int_ = (sbyte)((Class150)@class).method_2();
				goto IL_BD;
			}
		}
		else if (num != 17)
		{
			if (num == 24)
			{
				if (bool_2)
				{
					int_ = checked((sbyte)Convert.ToUInt64(((Class165)@class).method_2()));
					goto IL_BD;
				}
				int_ = (sbyte)Convert.ToUInt64(((Class165)@class).method_2());
				goto IL_BD;
			}
		}
		else
		{
			if (bool_2)
			{
				int_ = checked((sbyte)((Class163)@class).method_2());
				goto IL_BD;
			}
			int_ = (sbyte)((Class163)@class).method_2();
			goto IL_BD;
		}
		throw new InvalidOperationException();
		IL_BD:
		Class150 class2 = new Class150();
		class2.method_3((int)int_);
		this.method_129(class2);
	}

	// Token: 0x06000370 RID: 880 RVA: 0x000201F8 File Offset: 0x0001E3F8
	private void method_42(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		if (Class87.smethod_27(this.method_218(), class144_3))
		{
			uint uint_ = ((Class168)class144_2).method_2();
			this.method_275(uint_);
		}
	}

	// Token: 0x06000371 RID: 881 RVA: 0x00020230 File Offset: 0x0001E430
	private void method_43(object object_3)
	{
		Exception ex = object_3 as Exception;
		if (ex != null)
		{
			Class87.smethod_26(ex);
		}
		Class87.smethod_28(object_3);
	}

	// Token: 0x06000372 RID: 882 RVA: 0x00020254 File Offset: 0x0001E454
	private void method_44(Class144 class144_2)
	{
		Class144 @class = this.method_218();
		int num = @class.vmethod_2();
		checked
		{
			sbyte int_;
			if (num <= 11)
			{
				if (num == 7)
				{
					int_ = (sbyte)((uint)((Class150)@class).method_2());
					goto IL_6F;
				}
				if (num == 11)
				{
					int_ = (sbyte)((ulong)((Class161)@class).method_2());
					goto IL_6F;
				}
			}
			else
			{
				if (num == 17)
				{
					int_ = (sbyte)((Class163)@class).method_2();
					goto IL_6F;
				}
				if (num == 24)
				{
					int_ = (sbyte)Convert.ToUInt64(((Class165)@class).method_2());
					goto IL_6F;
				}
			}
			throw new InvalidOperationException();
			IL_6F:
			Class150 class2 = new Class150();
			class2.method_3((int)int_);
			this.method_129(class2);
		}
	}

	// Token: 0x06000373 RID: 883 RVA: 0x000202E4 File Offset: 0x0001E4E4
	private static Class144 smethod_2(Class144 class144_2, Class144 class144_3, bool bool_2)
	{
		if (!bool_2)
		{
			long num = ((Class161)class144_2).method_2();
			long num2 = ((Class161)class144_3).method_2();
			Class161 @class = new Class161();
			@class.method_3(num % num2);
			return @class;
		}
		ulong num3 = (ulong)((Class161)class144_2).method_2();
		ulong num4 = (ulong)((Class161)class144_3).method_2();
		Class161 class2 = new Class161();
		class2.method_3((long)(num3 % num4));
		return class2;
	}

	// Token: 0x06000374 RID: 884 RVA: 0x00020344 File Offset: 0x0001E544
	private void method_45(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		Class144 class144_4 = this.method_218();
		this.method_129(this.method_285(class144_4, class144_3, true, false));
	}

	// Token: 0x06000375 RID: 885 RVA: 0x00020370 File Offset: 0x0001E570
	private void method_46(bool bool_2)
	{
		Class144 @class = this.method_218();
		int num = @class.vmethod_2();
		IntPtr intptr_;
		if (num <= 11)
		{
			if (num != 7)
			{
				if (num == 11)
				{
					if (bool_2)
					{
						intptr_ = new IntPtr(((Class161)@class).method_2());
						goto IL_EE;
					}
					intptr_ = new IntPtr(((Class161)@class).method_2());
					goto IL_EE;
				}
			}
			else
			{
				if (bool_2)
				{
					intptr_ = new IntPtr(((Class150)@class).method_2());
					goto IL_EE;
				}
				intptr_ = new IntPtr(((Class150)@class).method_2());
				goto IL_EE;
			}
		}
		else if (num != 17)
		{
			if (num == 24)
			{
				if (bool_2)
				{
					intptr_ = new IntPtr(checked((long)Convert.ToUInt64(((Class165)@class).method_2())));
					goto IL_EE;
				}
				intptr_ = new IntPtr((long)Convert.ToUInt64(((Class165)@class).method_2()));
				goto IL_EE;
			}
		}
		else
		{
			if (bool_2)
			{
				intptr_ = new IntPtr(checked((long)((Class163)@class).method_2()));
				goto IL_EE;
			}
			intptr_ = new IntPtr((long)((Class163)@class).method_2());
			goto IL_EE;
		}
		throw new InvalidOperationException();
		IL_EE:
		Class151 class2 = new Class151();
		class2.method_3(intptr_);
		this.method_129(class2);
	}

	// Token: 0x06000376 RID: 886 RVA: 0x00020480 File Offset: 0x0001E680
	private void method_47(Class144 class144_2)
	{
		Class144 @class = this.method_218();
		int num = @class.vmethod_2();
		checked
		{
			IntPtr intptr_;
			if (num <= 11)
			{
				if (num == 7)
				{
					intptr_ = new IntPtr((long)(unchecked((ulong)(checked((uint)((Class150)@class).method_2())))));
					goto IL_87;
				}
				if (num == 11)
				{
					intptr_ = new IntPtr((long)((ulong)((Class161)@class).method_2()));
					goto IL_87;
				}
			}
			else
			{
				if (num == 17)
				{
					intptr_ = new IntPtr((long)((Class163)@class).method_2());
					goto IL_87;
				}
				if (num == 24)
				{
					intptr_ = new IntPtr((long)Convert.ToUInt64(((Class165)@class).method_2()));
					goto IL_87;
				}
			}
			throw new InvalidOperationException();
			IL_87:
			Class151 class2 = new Class151();
			class2.method_3(intptr_);
			this.method_129(class2);
		}
	}

	// Token: 0x06000377 RID: 887 RVA: 0x00020528 File Offset: 0x0001E728
	private string method_48(Class67 class67_1)
	{
		Type type = this.method_136(class67_1.method_6(), false);
		Class114[] array = class67_1.method_2();
		string[] array2 = new string[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			string[] array3 = array2;
			int num = i;
			Type type2 = this.method_136(array[i].method_0(), false);
			array3[num] = ((type2 != null) ? type2.FullName : null);
		}
		string arg = string.Join(Class185.smethod_0(537696782), array2);
		return string.Format(Class185.smethod_0(537696775), type.FullName, class67_1.method_4(), arg);
	}

	// Token: 0x06000378 RID: 888 RVA: 0x00004B8B File Offset: 0x00002D8B
	private void method_49(Class144 class144_2)
	{
		this.method_261(true);
	}

	// Token: 0x06000379 RID: 889 RVA: 0x00004B94 File Offset: 0x00002D94
	private void method_50(Class144 class144_2)
	{
		this.method_168(false);
	}

	// Token: 0x0600037A RID: 890 RVA: 0x00004B9D File Offset: 0x00002D9D
	private void method_51(Class144 class144_2)
	{
		this.method_75(Class28.type_0);
	}

	// Token: 0x0600037B RID: 891 RVA: 0x00004BAA File Offset: 0x00002DAA
	private void method_52(Class144 class144_2)
	{
		Class150 @class = new Class150();
		@class.method_3(8);
		this.method_129(@class);
	}

	// Token: 0x0600037C RID: 892 RVA: 0x00004BBE File Offset: 0x00002DBE
	private void method_53(Class144 class144_2)
	{
		this.method_261(false);
	}

	// Token: 0x0600037D RID: 893 RVA: 0x00004BC7 File Offset: 0x00002DC7
	private int method_54()
	{
		return -1965788237;
	}

	// Token: 0x0600037E RID: 894 RVA: 0x000205B4 File Offset: 0x0001E7B4
	private void method_55(bool bool_2)
	{
		Class144 @class = this.method_218();
		int num = @class.vmethod_2();
		ulong long_;
		if (num <= 11)
		{
			if (num != 7)
			{
				if (num == 11)
				{
					if (bool_2)
					{
						long_ = checked((ulong)((Class161)@class).method_2());
						goto IL_BB;
					}
					long_ = (ulong)((Class161)@class).method_2();
					goto IL_BB;
				}
			}
			else
			{
				if (bool_2)
				{
					long_ = (ulong)(checked((uint)((Class150)@class).method_2()));
					goto IL_BB;
				}
				long_ = (ulong)((Class150)@class).method_2();
				goto IL_BB;
			}
		}
		else if (num != 17)
		{
			if (num == 24)
			{
				if (bool_2)
				{
					long_ = Convert.ToUInt64(((Class165)@class).method_2());
					goto IL_BB;
				}
				long_ = Convert.ToUInt64(((Class165)@class).method_2());
				goto IL_BB;
			}
		}
		else
		{
			if (bool_2)
			{
				long_ = checked((ulong)((Class163)@class).method_2());
				goto IL_BB;
			}
			long_ = (ulong)((Class163)@class).method_2();
			goto IL_BB;
		}
		throw new InvalidOperationException();
		IL_BB:
		Class161 class2 = new Class161();
		class2.method_3((long)long_);
		this.method_129(class2);
	}

	// Token: 0x0600037F RID: 895 RVA: 0x00020690 File Offset: 0x0001E890
	private void method_56(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		Class144 class144_4 = this.method_218();
		Class150 @class = new Class150();
		@class.method_3(Class87.smethod_27(class144_4, class144_3) ? 1 : 0);
		this.method_129(@class);
	}

	// Token: 0x06000380 RID: 896 RVA: 0x000206CC File Offset: 0x0001E8CC
	private void method_57(int int_0, Type[] type_9, Type[] type_10, bool bool_2)
	{
		this.class183_0.method_0().vmethod_9((long)int_0, 0);
		this.method_233(this.class183_0);
		Class67 @class = this.method_278(this.class183_0);
		this.method_237(@class);
		int num = @class.method_2().Length;
		object[] array = new object[num];
		Class144[] array2 = new Class144[num];
		if (this.type_5 != null && bool_2)
		{
			int num2 = @class.method_12() ? 0 : 1;
			Type[] array3 = new Type[num - num2];
			for (int i = num - 1; i >= num2; i--)
			{
				array3[i] = this.method_136(@class.method_2()[i].method_0(), true);
			}
			MethodInfo method = this.type_5.GetMethod(@class.method_4(), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty, null, array3, null);
			this.type_5 = null;
			if (method != null)
			{
				this.method_271(method, true);
				return;
			}
		}
		for (int j = num - 1; j >= 0; j--)
		{
			Class144 class2 = this.method_218();
			array2[j] = class2;
			Class152 class152_;
			if ((class152_ = (class2 as Class152)) != null)
			{
				class2 = this.method_245(class152_);
			}
			if (class2.method_0() != null)
			{
				class2 = Class104.smethod_1(null, class2.method_0()).vmethod_3(class2);
			}
			Class144 class3 = Class104.smethod_1(null, this.method_136(@class.method_2()[j].method_0(), true)).vmethod_3(class2);
			array[j] = class3.vmethod_0();
			if (j == 0 && bool_2 && !@class.method_12() && array[j] == null)
			{
				throw new NullReferenceException();
			}
		}
		Class87 class4 = new Class87(this.class177_0);
		object[] object_ = new object[]
		{
			this.module_0.Assembly
		};
		object obj;
		try
		{
			obj = class4.method_219(this.stream_0, int_0, array, type_9, type_10, object_);
		}
		finally
		{
			for (int k = 0; k < array2.Length; k++)
			{
				Class152 class152_2;
				if ((class152_2 = (array2[k] as Class152)) != null)
				{
					object obj2 = array[k];
					this.method_105(class152_2, Class104.smethod_1(obj2, null));
				}
			}
		}
		Type type = class4.method_136(class4.class67_0.method_8(), true);
		if (type != Class87.type_2)
		{
			this.method_129(Class104.smethod_1(obj, type));
		}
	}

	// Token: 0x06000381 RID: 897 RVA: 0x00020910 File Offset: 0x0001EB10
	private void method_58(Class144 class144_2)
	{
		Class169 @class = (Class169)class144_2;
		Class154 class2 = new Class154();
		class2.method_3((int)@class.method_2());
		this.method_129(class2);
	}

	// Token: 0x06000382 RID: 898 RVA: 0x0000336F File Offset: 0x0000156F
	[Conditional("DEBUG")]
	private void method_59(object object_3)
	{
	}

	// Token: 0x06000383 RID: 899 RVA: 0x0002093C File Offset: 0x0001EB3C
	private void method_60(Class144 class144_2)
	{
		int int_ = ((Class150)class144_2).method_2();
		Type type_ = this.method_136(int_, true);
		Class144 class144_3 = this.method_218();
		if (this.method_61(class144_3, type_))
		{
			this.method_129(class144_3);
			return;
		}
		this.method_129(new Class171());
	}

	// Token: 0x06000384 RID: 900 RVA: 0x00020984 File Offset: 0x0001EB84
	private bool method_61(Class144 class144_2, Type type_9)
	{
		if (class144_2.vmethod_0() == null)
		{
			return true;
		}
		Type type = class144_2.method_0() ?? class144_2.vmethod_0().GetType();
		if (type != type_9 && !type_9.IsAssignableFrom(type))
		{
			if (!type.IsValueType && !type_9.IsValueType && Marshal.IsComObject(class144_2.vmethod_0()))
			{
				IntPtr intPtr;
				try
				{
					intPtr = Marshal.GetComInterfaceForObject(class144_2.vmethod_0(), type_9);
				}
				catch (InvalidCastException)
				{
					intPtr = IntPtr.Zero;
				}
				if (intPtr != IntPtr.Zero)
				{
					try
					{
						Marshal.Release(intPtr);
					}
					catch
					{
					}
					return true;
				}
			}
			return false;
		}
		return true;
	}

	// Token: 0x06000385 RID: 901 RVA: 0x00020A30 File Offset: 0x0001EC30
	private void method_62(Class144 class144_2)
	{
		int int_ = ((Class150)class144_2).method_2();
		Class45 @class = this.method_3(int_);
		object obj;
		if (@class.method_0() != 1)
		{
			switch (@class.method_4().vmethod_0())
			{
			case 0:
				obj = this.method_122(int_).FieldHandle;
				goto IL_95;
			case 1:
				obj = this.method_136(int_, true).TypeHandle;
				goto IL_95;
			case 4:
				obj = this.method_157(int_).MethodHandle;
				goto IL_95;
			}
			throw new InvalidOperationException();
		}
		obj = this.method_153(@class.method_2());
		IL_95:
		Class171 class2 = new Class171();
		class2.method_3(obj);
		this.method_129(class2);
	}

	// Token: 0x06000386 RID: 902 RVA: 0x00004BCE File Offset: 0x00002DCE
	private void method_63(Class144 class144_2)
	{
		throw new NotSupportedException(Class185.smethod_0(537697616));
	}

	// Token: 0x06000387 RID: 903 RVA: 0x00004BDF File Offset: 0x00002DDF
	private void method_64(Class144 class144_2)
	{
		this.method_36(Class87.type_0);
	}

	// Token: 0x06000388 RID: 904 RVA: 0x00020AE4 File Offset: 0x0001ECE4
	private void method_65(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		if (Class87.smethod_16(this.method_218(), class144_3))
		{
			uint uint_ = ((Class168)class144_2).method_2();
			this.method_275(uint_);
		}
	}

	// Token: 0x06000389 RID: 905 RVA: 0x00004BEC File Offset: 0x00002DEC
	private void method_66(Class144 class144_2)
	{
		Class150 @class = new Class150();
		@class.method_3(7);
		this.method_129(@class);
	}

	// Token: 0x0600038A RID: 906 RVA: 0x00020B1C File Offset: 0x0001ED1C
	private void method_67(Class144 class144_2)
	{
		Class163 @class = (Class163)this.method_218();
		if (double.IsNaN(@class.method_2()) || double.IsInfinity(@class.method_2()))
		{
			throw new OverflowException(Class185.smethod_0(537698116));
		}
		this.method_129(@class);
	}

	// Token: 0x0600038B RID: 907 RVA: 0x00020B68 File Offset: 0x0001ED68
	private void method_68(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		Class144 class144_4 = this.method_218();
		this.method_129(this.method_166(class144_4, class144_3, false, false));
	}

	// Token: 0x0600038C RID: 908 RVA: 0x00020B94 File Offset: 0x0001ED94
	private Class144 method_69(Class144 class144_2, Class144 class144_3)
	{
		if (class144_2.vmethod_2() == 7)
		{
			if (class144_3.vmethod_2() == 7)
			{
				int num = ((Class150)class144_2).method_2();
				int num2 = ((Class150)class144_3).method_2();
				Class150 @class = new Class150();
				@class.method_3(num ^ num2);
				return @class;
			}
			if (class144_3.vmethod_2() == 24)
			{
				int num3 = ((Class150)class144_2).method_2();
				Type underlyingType = Enum.GetUnderlyingType(class144_3.vmethod_0().GetType());
				if (underlyingType != typeof(long))
				{
					if (underlyingType != typeof(ulong))
					{
						int num4 = Convert.ToInt32(class144_3.vmethod_0());
						Class150 class2 = new Class150();
						class2.method_3(num3 ^ num4);
						return class2;
					}
				}
				long num5 = Convert.ToInt64(class144_3.vmethod_0());
				Class161 class3 = new Class161();
				class3.method_3((long)num3 ^ num5);
				return class3;
			}
		}
		if (class144_2.vmethod_2() == 11)
		{
			if (class144_3.vmethod_2() == 11)
			{
				long num6 = ((Class161)class144_2).method_2();
				long num7 = ((Class161)class144_3).method_2();
				Class161 class4 = new Class161();
				class4.method_3(num6 ^ num7);
				return class4;
			}
			if (class144_3.vmethod_2() == 24)
			{
				int num8 = ((Class150)class144_2).method_2();
				long num9 = Convert.ToInt64(class144_3.vmethod_0());
				Class161 class5 = new Class161();
				class5.method_3((long)num8 ^ num9);
				return class5;
			}
		}
		if (class144_2.vmethod_2() == 24)
		{
			if (class144_3.vmethod_2() == 7)
			{
				int num10 = ((Class150)class144_3).method_2();
				Type underlyingType2 = Enum.GetUnderlyingType(class144_2.vmethod_0().GetType());
				if (underlyingType2 != typeof(long))
				{
					if (underlyingType2 != typeof(ulong))
					{
						int num11 = Convert.ToInt32(class144_2.vmethod_0());
						Class150 class6 = new Class150();
						class6.method_3(num11 ^ num10);
						return class6;
					}
				}
				long num12 = Convert.ToInt64(class144_3.vmethod_0());
				Class161 class7 = new Class161();
				class7.method_3(num12 ^ (long)num10);
				return class7;
			}
			if (class144_3.vmethod_2() == 11)
			{
				long num13 = Convert.ToInt64(class144_2.vmethod_0());
				long num14 = ((Class161)class144_3).method_2();
				Class161 class8 = new Class161();
				class8.method_3(num13 ^ num14);
				return class8;
			}
			if (class144_3.vmethod_2() == 24)
			{
				Type underlyingType3 = Enum.GetUnderlyingType(class144_2.vmethod_0().GetType());
				Type underlyingType4 = Enum.GetUnderlyingType(class144_3.vmethod_0().GetType());
				if (underlyingType3 != typeof(long) && underlyingType3 != typeof(ulong) && underlyingType4 != typeof(long))
				{
					if (underlyingType4 != typeof(ulong))
					{
						int num15 = Convert.ToInt32(class144_2.vmethod_0());
						int num16 = Convert.ToInt32(class144_3.vmethod_0());
						Class150 class9 = new Class150();
						class9.method_3(num15 ^ num16);
						return class9;
					}
				}
				long num17 = Convert.ToInt64(class144_2.vmethod_0());
				long num18 = Convert.ToInt64(class144_3.vmethod_0());
				Class161 class10 = new Class161();
				class10.method_3(num17 ^ num18);
				return class10;
			}
		}
		throw new InvalidOperationException();
	}

	// Token: 0x0600038D RID: 909 RVA: 0x00004C00 File Offset: 0x00002E00
	private void method_70(Class144 class144_2)
	{
		this.method_159(false);
	}

	// Token: 0x0600038E RID: 910 RVA: 0x00020E5C File Offset: 0x0001F05C
	private static string smethod_3(string string_0, string string_1)
	{
		string fullName = typeof(Class87).Assembly.FullName;
		return string.Concat(new string[]
		{
			string.Format(Class185.smethod_0(537697992), string_0, string_1),
			Environment.NewLine,
			Environment.NewLine,
			string.Format(Class185.smethod_0(537698019), fullName),
			Class185.smethod_0(537697893)
		});
	}

	// Token: 0x0600038F RID: 911 RVA: 0x00004C09 File Offset: 0x00002E09
	private void method_71(Class144 class144_2)
	{
		this.method_141(true);
	}

	// Token: 0x06000390 RID: 912 RVA: 0x00020ED0 File Offset: 0x0001F0D0
	private void method_72(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		Class144 class144_4 = this.method_218();
		this.method_129(this.method_27(class144_4, class144_3));
	}

	// Token: 0x06000391 RID: 913 RVA: 0x00004C12 File Offset: 0x00002E12
	private void method_73(Class144 class144_2)
	{
		this.method_159(true);
	}

	// Token: 0x06000392 RID: 914 RVA: 0x00004C1B File Offset: 0x00002E1B
	private bool method_74(MethodBase methodBase_0)
	{
		return methodBase_0.IsVirtual && this.method_136(this.class67_0.method_6(), true).IsSubclassOf(methodBase_0.DeclaringType);
	}

	// Token: 0x06000393 RID: 915 RVA: 0x00020EFC File Offset: 0x0001F0FC
	private static void smethod_4(ILGenerator ilgenerator_0, int int_0)
	{
		switch (int_0)
		{
		case -1:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_M1);
			return;
		case 0:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_0);
			return;
		case 1:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_1);
			return;
		case 2:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_2);
			return;
		case 3:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_3);
			return;
		case 4:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_4);
			return;
		case 5:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_5);
			return;
		case 6:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_6);
			return;
		case 7:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_7);
			return;
		case 8:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_8);
			return;
		default:
			if (int_0 > -129 && int_0 < 128)
			{
				ilgenerator_0.Emit(OpCodes.Ldc_I4_S, (sbyte)int_0);
				return;
			}
			ilgenerator_0.Emit(OpCodes.Ldc_I4, int_0);
			return;
		}
	}

	// Token: 0x06000394 RID: 916 RVA: 0x00020FDC File Offset: 0x0001F1DC
	private void method_75(Type type_9)
	{
		Class152 class152_ = (Class152)this.method_218();
		this.method_129(Class104.smethod_1(this.method_245(class152_).vmethod_0(), type_9));
	}

	// Token: 0x06000395 RID: 917 RVA: 0x00004C49 File Offset: 0x00002E49
	private void method_76(Class144 class144_2)
	{
		this.method_117(typeof(float));
	}

	// Token: 0x06000396 RID: 918 RVA: 0x00021010 File Offset: 0x0001F210
	private void method_77(Class144 class144_2)
	{
		Class169 @class = (Class169)class144_2;
		Class155 class2 = new Class155();
		class2.method_3(this.class144_0[(int)@class.method_2()]);
		this.method_129(class2);
	}

	// Token: 0x06000397 RID: 919 RVA: 0x00021048 File Offset: 0x0001F248
	private void method_78(Class144 class144_2)
	{
		Class164 @class = (Class164)class144_2;
		this.method_287((int)@class.method_2());
	}

	// Token: 0x06000398 RID: 920 RVA: 0x00021068 File Offset: 0x0001F268
	private void method_79(Class144 class144_2)
	{
		int int_ = ((Class150)class144_2).method_2();
		MethodBase methodBase = this.method_157(int_);
		Type declaringType = methodBase.DeclaringType;
		ParameterInfo[] parameters = methodBase.GetParameters();
		int num = parameters.Length;
		object[] array = new object[num];
		Dictionary<int, Class152> dictionary = new Dictionary<int, Class152>();
		for (int i = num - 1; i >= 0; i--)
		{
			Class144 @class = this.method_218();
			Class152 class2;
			if ((class2 = (@class as Class152)) != null)
			{
				dictionary.Add(i, class2);
				@class = this.method_245(class2);
			}
			if (@class.method_0() != null)
			{
				@class = Class104.smethod_1(null, @class.method_0()).vmethod_3(@class);
			}
			Class144 class3 = Class104.smethod_1(null, parameters[i].ParameterType).vmethod_3(@class);
			array[i] = class3.vmethod_0();
		}
		object obj;
		try
		{
			obj = this.method_266(methodBase, null, array, false);
		}
		catch (TargetInvocationException ex)
		{
			Exception object_ = ex.InnerException ?? ex;
			this.method_43(object_);
			return;
		}
		foreach (KeyValuePair<int, Class152> keyValuePair in dictionary)
		{
			this.method_105(keyValuePair.Value, Class104.smethod_1(array[keyValuePair.Key], null));
		}
		this.method_129(Class104.smethod_1(obj, declaringType));
	}

	// Token: 0x06000399 RID: 921 RVA: 0x000211C0 File Offset: 0x0001F3C0
	private void method_80(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		if (!Class87.smethod_14(this.method_218(), class144_3))
		{
			uint uint_ = ((Class168)class144_2).method_2();
			this.method_275(uint_);
		}
	}

	// Token: 0x0600039A RID: 922 RVA: 0x000211F8 File Offset: 0x0001F3F8
	private void method_81()
	{
		if (!this.class177_0.method_1())
		{
			Class177 obj = this.class177_0;
			lock (obj)
			{
				if (!this.class177_0.method_1())
				{
					this.dictionary_4 = this.method_293();
					this.method_144();
					this.class177_0.method_2(true);
				}
			}
		}
		if (this.dictionary_4 == null)
		{
			this.dictionary_4 = this.method_293();
		}
	}

	// Token: 0x0600039B RID: 923 RVA: 0x00021278 File Offset: 0x0001F478
	private void method_82(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		Class144 class144_4 = this.method_218();
		this.method_129(this.method_87(class144_4, class144_3, false));
	}

	// Token: 0x0600039C RID: 924 RVA: 0x000212A4 File Offset: 0x0001F4A4
	private Class144[] method_83(object[] object_3)
	{
		Class114[] array = this.class67_0.method_2();
		int num = array.Length;
		Class144[] array2 = new Class144[num];
		for (int i = 0; i < num; i++)
		{
			object obj = object_3[i];
			Type type = this.method_136(array[i].method_0(), false);
			Type type2 = Class107.smethod_1(type);
			Type type3;
			if (type2 != Class28.type_0 && !Class28.smethod_0(type2))
			{
				type3 = ((obj != null) ? obj.GetType() : type);
			}
			else
			{
				type3 = type;
			}
			if (obj != null && !type.IsAssignableFrom(type3) && type.IsByRef && !type.GetElementType().IsAssignableFrom(type3))
			{
				throw new ArgumentException(string.Format(Class185.smethod_0(537697659), type3, type));
			}
			array2[i] = Class104.smethod_1(obj, type3);
		}
		if (!this.class67_0.method_12() && this.method_136(this.class67_0.method_6(), false).IsValueType)
		{
			Class144[] array3 = array2;
			int num2 = 0;
			Class155 @class = new Class155();
			@class.method_3(array2[0]);
			array3[num2] = @class;
		}
		for (int j = 0; j < num; j++)
		{
			if (array[j].method_2())
			{
				Class144[] array4 = array2;
				int num3 = j;
				Class155 class2 = new Class155();
				class2.method_3(array2[j]);
				array4[num3] = class2;
			}
		}
		return array2;
	}

	// Token: 0x0600039D RID: 925 RVA: 0x000213EC File Offset: 0x0001F5EC
	private void method_84(Class144 class144_2)
	{
		Class169 @class = (Class169)class144_2;
		this.method_129(this.class144_0[(int)@class.method_2()].vmethod_4());
	}

	// Token: 0x0600039E RID: 926 RVA: 0x0002141C File Offset: 0x0001F61C
	private void method_85(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		if (Class87.smethod_20(this.method_218(), class144_3))
		{
			uint uint_ = ((Class168)class144_2).method_2();
			this.method_275(uint_);
		}
	}

	// Token: 0x0600039F RID: 927 RVA: 0x0000336F File Offset: 0x0000156F
	private void method_86(Class144 class144_2)
	{
	}

	// Token: 0x060003A0 RID: 928 RVA: 0x00021454 File Offset: 0x0001F654
	private Class144 method_87(Class144 class144_2, Class144 class144_3, bool bool_2)
	{
		if (class144_2.vmethod_2() == 7)
		{
			if (class144_3.vmethod_2() == 7)
			{
				if (!bool_2)
				{
					int num = ((Class150)class144_2).method_2();
					int num2 = ((Class150)class144_3).method_2();
					Class150 @class = new Class150();
					@class.method_3(num % num2);
					return @class;
				}
				uint num3 = (uint)((Class150)class144_2).method_2();
				uint num4 = (uint)((Class150)class144_3).method_2();
				Class150 class2 = new Class150();
				class2.method_3((int)(num3 % num4));
				return class2;
			}
			else
			{
				if (class144_3.vmethod_2() == 11)
				{
					Class161 class3 = new Class161();
					class3.method_3((long)((Class150)class144_2).method_2());
					return Class87.smethod_2(class3, class144_3, bool_2);
				}
				if (class144_3.vmethod_2() == 24)
				{
					Type underlyingType = Enum.GetUnderlyingType(class144_3.vmethod_0().GetType());
					if (underlyingType != typeof(long))
					{
						if (underlyingType != typeof(ulong))
						{
							Class150 class4 = new Class150();
							class4.method_3(Convert.ToInt32(class144_3.vmethod_0()));
							return this.method_87(class144_2, class4, bool_2);
						}
					}
					Class161 class5 = new Class161();
					class5.method_3((long)((Class150)class144_2).method_2());
					Class161 class6 = new Class161();
					class6.method_3(Convert.ToInt64(class144_3.vmethod_0()));
					return Class87.smethod_2(class5, class6, bool_2);
				}
			}
		}
		if (class144_2.vmethod_2() == 11)
		{
			if (class144_3.vmethod_2() == 11)
			{
				return Class87.smethod_2(class144_2, class144_3, bool_2);
			}
			if (class144_3.vmethod_2() == 7)
			{
				Class161 class7 = new Class161();
				class7.method_3((long)((Class150)class144_3).method_2());
				return Class87.smethod_2(class144_2, class7, bool_2);
			}
			if (class144_3.vmethod_2() == 24)
			{
				Type underlyingType2 = Enum.GetUnderlyingType(class144_3.vmethod_0().GetType());
				if (underlyingType2 != typeof(long))
				{
					if (underlyingType2 != typeof(ulong))
					{
						Class150 class8 = new Class150();
						class8.method_3(Convert.ToInt32(class144_3.vmethod_0()));
						return Class87.smethod_2(class144_2, class8, bool_2);
					}
				}
				Class161 class9 = new Class161();
				class9.method_3(Convert.ToInt64(class144_3.vmethod_0()));
				return Class87.smethod_2(class144_2, class9, bool_2);
			}
		}
		if (class144_2.vmethod_2() == 17 && class144_3.vmethod_2() == 17)
		{
			Class163 class10 = new Class163();
			class10.method_3(((Class163)class144_2).method_2() % ((Class163)class144_3).method_2());
			return class10;
		}
		if (class144_2.vmethod_2() == 24)
		{
			Type underlyingType3 = Enum.GetUnderlyingType(class144_2.vmethod_0().GetType());
			if (underlyingType3 != typeof(long))
			{
				if (underlyingType3 != typeof(ulong))
				{
					Class150 class11 = new Class150();
					class11.method_3(Convert.ToInt32(class144_2.vmethod_0()));
					return this.method_87(class11, class144_3, bool_2);
				}
			}
			Class161 class12 = new Class161();
			class12.method_3(Convert.ToInt64(class144_2.vmethod_0()));
			return this.method_87(class12, class144_3, bool_2);
		}
		throw new InvalidOperationException();
	}

	// Token: 0x060003A1 RID: 929 RVA: 0x000216F0 File Offset: 0x0001F8F0
	private Class87.Delegate1 method_88(Class87.Struct37 struct37_0)
	{
		Dictionary<Class87.Struct37, Class87.Delegate1> obj = this.dictionary_5;
		Class87.Delegate1 result;
		lock (obj)
		{
			this.dictionary_5.TryGetValue(struct37_0, out result);
		}
		return result;
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x00004C5B File Offset: 0x00002E5B
	private void method_89(Class144 class144_2)
	{
		this.method_117(typeof(sbyte));
	}

	// Token: 0x060003A3 RID: 931 RVA: 0x00004C6D File Offset: 0x00002E6D
	private void method_90(Class144 class144_2)
	{
		Class150 @class = new Class150();
		@class.method_3(2);
		this.method_129(@class);
	}

	// Token: 0x060003A4 RID: 932 RVA: 0x00021734 File Offset: 0x0001F934
	private void method_91(Class144 class144_2)
	{
		int int_ = ((Class150)class144_2).method_2();
		FieldInfo fieldInfo_ = this.method_122(int_);
		this.method_129(new Class153(fieldInfo_, null));
	}

	// Token: 0x060003A5 RID: 933 RVA: 0x00021764 File Offset: 0x0001F964
	private void method_92(bool bool_2)
	{
		Class144 @class = this.method_218();
		int num = @class.vmethod_2();
		short int_;
		if (num <= 11)
		{
			if (num != 7)
			{
				if (num == 11)
				{
					if (bool_2)
					{
						int_ = checked((short)((Class161)@class).method_2());
						goto IL_BD;
					}
					int_ = (short)((Class161)@class).method_2();
					goto IL_BD;
				}
			}
			else
			{
				if (bool_2)
				{
					int_ = checked((short)((Class150)@class).method_2());
					goto IL_BD;
				}
				int_ = (short)((Class150)@class).method_2();
				goto IL_BD;
			}
		}
		else if (num != 17)
		{
			if (num == 24)
			{
				if (bool_2)
				{
					int_ = checked((short)Convert.ToUInt64(((Class165)@class).method_2()));
					goto IL_BD;
				}
				int_ = (short)Convert.ToUInt64(((Class165)@class).method_2());
				goto IL_BD;
			}
		}
		else
		{
			if (bool_2)
			{
				int_ = checked((short)((Class163)@class).method_2());
				goto IL_BD;
			}
			int_ = (short)((Class163)@class).method_2();
			goto IL_BD;
		}
		throw new InvalidOperationException();
		IL_BD:
		Class150 class2 = new Class150();
		class2.method_3((int)int_);
		this.method_129(class2);
	}

	// Token: 0x060003A6 RID: 934 RVA: 0x00004C81 File Offset: 0x00002E81
	private void method_93(Class144 class144_2)
	{
		this.method_36(typeof(float));
	}

	// Token: 0x060003A7 RID: 935 RVA: 0x00004C93 File Offset: 0x00002E93
	public object method_94(Stream stream_1, string string_0, object[] object_3, Type[] type_9, Type[] type_10, object[] object_4)
	{
		this.stream_0 = stream_1;
		this.method_169(stream_1, string_0);
		return this.method_115(object_3, type_9, type_10, object_4);
	}

	// Token: 0x060003A8 RID: 936 RVA: 0x00004CB1 File Offset: 0x00002EB1
	private void method_95(Class144 class144_2)
	{
		this.method_55(false);
	}

	// Token: 0x060003A9 RID: 937 RVA: 0x0000336F File Offset: 0x0000156F
	private void method_96(Class144 class144_2)
	{
	}

	// Token: 0x060003AA RID: 938 RVA: 0x0000336F File Offset: 0x0000156F
	private void method_97(Class144 class144_2)
	{
	}

	// Token: 0x060003AB RID: 939 RVA: 0x00021840 File Offset: 0x0001FA40
	private void method_98(Class144 class144_2)
	{
		uint uint_ = ((Class168)class144_2).method_2();
		this.method_187(null, uint_);
	}

	// Token: 0x060003AC RID: 940 RVA: 0x00004CBA File Offset: 0x00002EBA
	private static void smethod_5(ILGenerator ilgenerator_0, Type type_9)
	{
		if (type_9.IsValueType || Class107.smethod_0(type_9).IsGenericParameter)
		{
			ilgenerator_0.Emit(OpCodes.Box, type_9);
		}
	}

	// Token: 0x060003AD RID: 941 RVA: 0x00004CDD File Offset: 0x00002EDD
	private static Exception smethod_6(string string_0, string string_1)
	{
		return new FieldAccessException(Class87.smethod_3(string.Format(Class185.smethod_0(537696485), string_0), string.Format(Class185.smethod_0(537697972), string_1)));
	}

	// Token: 0x060003AE RID: 942 RVA: 0x00021864 File Offset: 0x0001FA64
	private void method_99(Class144 class144_2)
	{
		Class150 @class = (Class150)class144_2;
		MethodBase methodBase_ = this.method_157(@class.method_2());
		foreach (Class144 class144_3 in this.class144_0)
		{
			this.method_129(class144_3);
		}
		this.method_271(methodBase_, false);
	}

	// Token: 0x060003AF RID: 943 RVA: 0x000218B4 File Offset: 0x0001FAB4
	private static byte[] smethod_7(Class183 class183_2)
	{
		int num = class183_2.method_19();
		byte[] array = new byte[num];
		class183_2.method_14(array, 0, num);
		return array;
	}

	// Token: 0x060003B0 RID: 944 RVA: 0x000218DC File Offset: 0x0001FADC
	private void method_100(Class144 class144_2)
	{
		Array array = (Array)this.method_218().vmethod_0();
		Class150 @class = new Class150();
		@class.method_3(array.Length);
		this.method_129(@class);
	}

	// Token: 0x060003B1 RID: 945 RVA: 0x00021914 File Offset: 0x0001FB14
	private Class87.Delegate1 method_101(Class87.Struct37 struct37_0)
	{
		Dictionary<Class87.Struct37, Class87.Delegate1> obj = this.dictionary_5;
		Class87.Delegate1 @delegate;
		lock (obj)
		{
			this.dictionary_5.TryGetValue(struct37_0, out @delegate);
		}
		if (@delegate != null)
		{
			return @delegate;
		}
		MethodBase methodBase = struct37_0.method_0();
		Dictionary<MethodBase, object> obj2 = this.dictionary_0;
		lock (obj2)
		{
			while (this.dictionary_0.ContainsKey(methodBase))
			{
				Monitor.Wait(this.dictionary_0);
			}
			this.dictionary_0[methodBase] = null;
		}
		Class87.Delegate1 result;
		try
		{
			obj = this.dictionary_5;
			lock (obj)
			{
				this.dictionary_5.TryGetValue(struct37_0, out @delegate);
			}
			if (@delegate == null)
			{
				@delegate = this.method_292(methodBase, struct37_0.method_1());
				obj = this.dictionary_5;
				lock (obj)
				{
					this.dictionary_5[struct37_0] = @delegate;
				}
			}
			result = @delegate;
		}
		finally
		{
			obj2 = this.dictionary_0;
			lock (obj2)
			{
				this.dictionary_0.Remove(methodBase);
				Monitor.PulseAll(this.dictionary_0);
			}
		}
		return result;
	}

	// Token: 0x060003B2 RID: 946 RVA: 0x00021A70 File Offset: 0x0001FC70
	private void method_102(ref Class87.Struct38 struct38_0, MethodBase methodBase_0, bool bool_2)
	{
		bool flag = false;
		if (methodBase_0.DeclaringType == typeof(Interlocked) && methodBase_0.IsStatic)
		{
			string name = methodBase_0.Name;
			if (name == Class185.smethod_0(537696810) || name == Class185.smethod_0(537696804) || name == Class185.smethod_0(537696842) || name == Class185.smethod_0(537696890) || name == Class185.smethod_0(537696873) || name == Class185.smethod_0(537696665))
			{
				flag = true;
			}
		}
		if (flag)
		{
			try
			{
			}
			finally
			{
				Monitor.Enter(Class87.object_2);
				struct38_0.bool_0 = true;
			}
		}
	}

	// Token: 0x060003B3 RID: 947 RVA: 0x00021B38 File Offset: 0x0001FD38
	private void method_103(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		Class144 class144_4 = this.method_218();
		this.method_129(this.method_166(class144_4, class144_3, true, false));
	}

	// Token: 0x060003B4 RID: 948 RVA: 0x00021B64 File Offset: 0x0001FD64
	private void method_104(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		this.method_129(this.method_143(class144_3));
	}

	// Token: 0x060003B5 RID: 949 RVA: 0x00021B88 File Offset: 0x0001FD88
	private void method_105(Class152 class152_0, Class144 class144_2)
	{
		int num = class152_0.vmethod_2();
		if (num != 3)
		{
			switch (num)
			{
			case 12:
				((Class155)class152_0).method_2().vmethod_3(class144_2);
				return;
			case 13:
				this.class144_1[((Class154)class152_0).method_2()].vmethod_3(class144_2);
				return;
			case 16:
				goto IL_CC;
			case 18:
			{
				Class153 @class = (Class153)class152_0;
				FieldInfo fieldInfo = @class.method_4();
				Class144 class2 = Class104.smethod_1(class144_2.vmethod_0(), fieldInfo.FieldType);
				fieldInfo.SetValue(@class.method_2(), class2.vmethod_0());
				Class152 class3 = @class.method_6();
				if (class3 != null && fieldInfo.DeclaringType.IsValueType)
				{
					this.method_105(class3, Class104.smethod_1(@class.method_2(), null));
					return;
				}
				return;
			}
			}
			throw new ArgumentOutOfRangeException();
		}
		IL_CC:
		Class156 class4 = (Class156)class152_0;
		Class144 class5 = Class104.smethod_1(class144_2.vmethod_0(), class4.method_2());
		class4.vmethod_6(class5.vmethod_0());
	}

	// Token: 0x060003B6 RID: 950 RVA: 0x00021C8C File Offset: 0x0001FE8C
	private void method_106(Class144 class144_2)
	{
		Class144 @class = this.method_218();
		int num = @class.vmethod_2();
		checked
		{
			ushort int_;
			if (num <= 11)
			{
				if (num == 7)
				{
					int_ = (ushort)((uint)((Class150)@class).method_2());
					goto IL_6F;
				}
				if (num == 11)
				{
					int_ = (ushort)((ulong)((Class161)@class).method_2());
					goto IL_6F;
				}
			}
			else
			{
				if (num == 17)
				{
					int_ = (ushort)((Class163)@class).method_2();
					goto IL_6F;
				}
				if (num == 24)
				{
					int_ = (ushort)Convert.ToUInt64(((Class165)@class).method_2());
					goto IL_6F;
				}
			}
			throw new InvalidOperationException();
			IL_6F:
			Class150 class2 = new Class150();
			class2.method_3((int)int_);
			this.method_129(class2);
		}
	}

	// Token: 0x060003B7 RID: 951 RVA: 0x00004D09 File Offset: 0x00002F09
	private Class114 method_107(Class183 class183_2)
	{
		Class114 @class = new Class114();
		@class.method_1(class183_2.method_19());
		@class.method_3(class183_2.method_5());
		return @class;
	}

	// Token: 0x060003B8 RID: 952 RVA: 0x00021D1C File Offset: 0x0001FF1C
	private void method_108(Class144 class144_2)
	{
		int int_ = ((Class150)class144_2).method_2();
		string string_ = this.method_216(int_);
		Class148 @class = new Class148();
		@class.method_3(string_);
		this.method_129(@class);
	}

	// Token: 0x060003B9 RID: 953 RVA: 0x00021D50 File Offset: 0x0001FF50
	private void method_109(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		Class144 class144_4 = this.method_218();
		this.method_129(this.method_277(class144_4, class144_3, false, false));
	}

	// Token: 0x060003BA RID: 954 RVA: 0x00021D7C File Offset: 0x0001FF7C
	private void method_110(Class144 class144_2)
	{
		Class164 @class = (Class164)class144_2;
		this.method_129(this.class144_1[(int)@class.method_2()].vmethod_4());
	}

	// Token: 0x060003BB RID: 955 RVA: 0x00021DAC File Offset: 0x0001FFAC
	private void method_111(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		if (!Class87.smethod_20(this.method_218(), class144_3))
		{
			uint uint_ = ((Class168)class144_2).method_2();
			this.method_275(uint_);
		}
	}

	// Token: 0x060003BC RID: 956 RVA: 0x00004A8A File Offset: 0x00002C8A
	private void method_112(Class144 class144_2)
	{
		this.method_252();
	}

	// Token: 0x060003BD RID: 957 RVA: 0x00021DE4 File Offset: 0x0001FFE4
	private Class144[] method_113()
	{
		Class99[] array = this.class67_0.method_0();
		int num = array.Length;
		Class144[] array2 = new Class144[num];
		for (int i = 0; i < num; i++)
		{
			array2[i] = Class104.smethod_1(null, this.method_136(array[i].method_0(), false));
		}
		return array2;
	}

	// Token: 0x060003BE RID: 958 RVA: 0x00021E38 File Offset: 0x00020038
	private void method_114(Class144 class144_2)
	{
		if (((Class150)this.method_218()).method_2() != 0)
		{
			this.class57_0.method_7(new Class87.Struct39((uint)this.class183_1.method_0().vmethod_4(), this.object_0));
			this.bool_1 = false;
		}
		this.method_196();
	}

	// Token: 0x060003BF RID: 959 RVA: 0x00021E8C File Offset: 0x0002008C
	private object method_115(object[] object_3, Type[] type_9, Type[] type_10, object[] object_4)
	{
		if (object_3 == null)
		{
			object_3 = Class122<object>.gparam_0;
		}
		if (type_9 == null)
		{
			type_9 = Type.EmptyTypes;
		}
		if (type_10 == null)
		{
			type_10 = Type.EmptyTypes;
		}
		this.object_1 = object_4;
		this.type_7 = type_9;
		this.type_3 = type_10;
		this.class144_0 = this.method_83(object_3);
		this.class144_1 = this.method_113();
		object result;
		try
		{
			Class53 @class = new Class53(this.byte_0);
			try
			{
				using (this.class183_1 = new Class183(@class))
				{
					this.bool_0 = false;
					this.nullable_0 = null;
					this.class57_1.method_0();
					this.method_244();
				}
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
			Type type = this.method_136(this.class67_0.method_8(), false);
			if (type != Class87.type_2 && this.class57_1.Count > 0)
			{
				result = Class104.smethod_1(null, type).vmethod_3(this.method_218()).vmethod_0();
			}
			else
			{
				result = null;
			}
		}
		finally
		{
			for (int i = 0; i < this.class67_0.method_2().Length; i++)
			{
				Class114 class3 = this.class67_0.method_2()[i];
				if (class3.method_2())
				{
					Class155 class4 = (Class155)this.class144_0[i];
					Type type2 = this.method_136(class3.method_0(), false);
					object_3[i] = Class104.smethod_1(null, type2.GetElementType()).vmethod_3(class4.method_2()).vmethod_0();
				}
			}
			this.object_1 = null;
			this.class144_0 = null;
			this.class144_1 = null;
		}
		return result;
	}

	// Token: 0x060003C0 RID: 960 RVA: 0x00022048 File Offset: 0x00020248
	private void method_116(Class144 class144_2)
	{
		Class150 @class = (Class150)class144_2;
		MethodBase methodBase = this.method_157(@class.method_2());
		Type declaringType = methodBase.DeclaringType;
		Type type = this.method_218().vmethod_0().GetType();
		ParameterInfo[] parameters = methodBase.GetParameters();
		Type[] array = new Type[parameters.Length];
		for (int i = 0; i < parameters.Length; i++)
		{
			array[i] = parameters[i].ParameterType;
		}
		MethodBase methodBase2 = null;
		for (Type type2 = type; type2 != null; type2 = type2.BaseType)
		{
			if (type2 == declaringType)
			{
				break;
			}
			MethodInfo method = type2.GetMethod(methodBase.Name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array, null);
			if (method != null && method.GetBaseDefinition() == methodBase)
			{
				methodBase2 = method;
				break;
			}
		}
		if (methodBase2 == null)
		{
			methodBase2 = methodBase;
		}
		Class147 class2 = new Class147();
		class2.method_3(methodBase2);
		this.method_129(class2);
	}

	// Token: 0x060003C1 RID: 961 RVA: 0x00022118 File Offset: 0x00020318
	private void method_117(Type type_9)
	{
		long index = this.method_202();
		Array array = (Array)this.method_218().vmethod_0();
		this.method_129(Class104.smethod_1(array.GetValue(index), type_9));
	}

	// Token: 0x060003C2 RID: 962 RVA: 0x00022150 File Offset: 0x00020350
	private void method_118(Class144 class144_2)
	{
		int int_ = ((Class150)class144_2).method_2();
		Type type_ = this.method_136(int_, true);
		this.method_36(type_);
	}

	// Token: 0x060003C3 RID: 963 RVA: 0x00004D28 File Offset: 0x00002F28
	private void method_119(Class144 class144_2)
	{
		this.method_117(Class28.type_0);
	}

	// Token: 0x060003C4 RID: 964 RVA: 0x0002217C File Offset: 0x0002037C
	private Class144 method_120(Class144 class144_2)
	{
		if (class144_2.vmethod_2() == 7)
		{
			int num = ((Class150)class144_2).method_2();
			Class150 @class = new Class150();
			@class.method_3(~num);
			return @class;
		}
		if (class144_2.vmethod_2() == 11)
		{
			long num2 = ((Class161)class144_2).method_2();
			Class161 class2 = new Class161();
			class2.method_3(~num2);
			return class2;
		}
		if (class144_2.vmethod_2() == 24)
		{
			Type underlyingType = Enum.GetUnderlyingType(class144_2.vmethod_0().GetType());
			if (underlyingType != typeof(long))
			{
				if (underlyingType != typeof(ulong))
				{
					int num3 = Convert.ToInt32(class144_2.vmethod_0());
					Class150 class3 = new Class150();
					class3.method_3(~num3);
					return class3;
				}
			}
			long num4 = Convert.ToInt64(class144_2.vmethod_0());
			Class161 class4 = new Class161();
			class4.method_3(~num4);
			return class4;
		}
		throw new InvalidOperationException();
	}

	// Token: 0x060003C5 RID: 965 RVA: 0x00004D35 File Offset: 0x00002F35
	private void method_121(Class144 class144_2)
	{
		this.method_75(typeof(uint));
	}

	// Token: 0x060003C6 RID: 966 RVA: 0x00022244 File Offset: 0x00020444
	private FieldInfo method_122(int int_0)
	{
		Dictionary<int, object> obj = Class87.dictionary_1;
		FieldInfo result;
		lock (obj)
		{
			bool flag = true;
			object obj2;
			FieldInfo fieldInfo;
			if (Class87.dictionary_1.TryGetValue(int_0, out obj2))
			{
				fieldInfo = (FieldInfo)obj2;
			}
			else
			{
				Class45 class45_ = this.method_3(int_0);
				fieldInfo = this.method_191(int_0, class45_, ref flag);
				if (flag)
				{
					Class87.dictionary_1.Add(int_0, fieldInfo);
				}
			}
			this.method_124(fieldInfo);
			result = fieldInfo;
		}
		return result;
	}

	// Token: 0x060003C7 RID: 967 RVA: 0x000222C0 File Offset: 0x000204C0
	private void method_123(Class144 class144_2)
	{
		Class144 @class = this.method_218();
		int num = @class.vmethod_2();
		double double_;
		if (num <= 11)
		{
			if (num == 7)
			{
				double_ = (double)((Class150)@class).method_2();
				goto IL_6D;
			}
			if (num == 11)
			{
				double_ = (double)((Class161)@class).method_2();
				goto IL_6D;
			}
		}
		else
		{
			if (num == 17)
			{
				double_ = ((Class163)@class).method_2();
				goto IL_6D;
			}
			if (num == 24)
			{
				double_ = Convert.ToUInt64(((Class165)@class).method_2());
				goto IL_6D;
			}
		}
		throw new InvalidOperationException();
		IL_6D:
		Class163 class2 = new Class163();
		class2.method_3(double_);
		this.method_129(class2);
	}

	// Token: 0x060003C8 RID: 968 RVA: 0x0002234C File Offset: 0x0002054C
	private void method_124(MemberInfo memberInfo_0)
	{
		if (Class87.smethod_8() && !this.class67_0.method_13())
		{
			bool flag = false;
			Assembly assembly = typeof(SecurityCriticalAttribute).Assembly;
			MemberInfo memberInfo = memberInfo_0;
			while (memberInfo != null)
			{
				object[] customAttributes = memberInfo.GetCustomAttributes(false);
				for (int i = 0; i < customAttributes.Length; i++)
				{
					Type type = customAttributes[i].GetType();
					if (type.Assembly == assembly)
					{
						string fullName = type.FullName;
						if (Class185.smethod_0(537697445).Equals(fullName, StringComparison.Ordinal))
						{
							flag = true;
							goto IL_9B;
						}
						if (Class185.smethod_0(537697525).Equals(fullName, StringComparison.Ordinal))
						{
							goto IL_9B;
						}
					}
				}
				memberInfo = memberInfo.DeclaringType;
				continue;
				IL_9B:
				if (!flag)
				{
					return;
				}
				if (memberInfo_0 is MethodBase)
				{
					string string_ = Class87.smethod_9((MethodBase)memberInfo_0);
					throw Class87.smethod_30(this.method_48(this.class67_0), string_);
				}
				if (memberInfo_0 is FieldInfo)
				{
					Type declaringType = memberInfo_0.DeclaringType;
					string string_2 = string.Format(Class185.smethod_0(537697337), declaringType.FullName, memberInfo_0.Name);
					throw Class87.smethod_6(this.method_48(this.class67_0), string_2);
				}
				if (memberInfo_0 is Type)
				{
					string fullName2 = ((Type)memberInfo_0).FullName;
					throw Class87.smethod_25(this.method_48(this.class67_0), fullName2);
				}
				throw new SecurityException(Class185.smethod_0(537697335));
			}
			goto IL_9B;
		}
	}

	// Token: 0x060003C9 RID: 969 RVA: 0x00003ADA File Offset: 0x00001CDA
	private static bool smethod_8()
	{
		return false;
	}

	// Token: 0x060003CA RID: 970 RVA: 0x000224A0 File Offset: 0x000206A0
	private void method_125(Class144 class144_2)
	{
		Class144 @class = this.method_218();
		int num = @class.vmethod_2();
		float num2;
		if (num <= 11)
		{
			if (num == 7)
			{
				num2 = (float)((Class150)@class).method_2();
				goto IL_6E;
			}
			if (num == 11)
			{
				num2 = (float)((Class161)@class).method_2();
				goto IL_6E;
			}
		}
		else
		{
			if (num == 17)
			{
				num2 = (float)((Class163)@class).method_2();
				goto IL_6E;
			}
			if (num == 24)
			{
				num2 = Convert.ToUInt64(((Class165)@class).method_2());
				goto IL_6E;
			}
		}
		throw new InvalidOperationException();
		IL_6E:
		Class163 class2 = new Class163();
		class2.method_3((double)num2);
		this.method_129(class2);
	}

	// Token: 0x060003CB RID: 971 RVA: 0x00004A8A File Offset: 0x00002C8A
	private void method_126(Class144 class144_2)
	{
		this.method_252();
	}

	// Token: 0x060003CC RID: 972 RVA: 0x00022530 File Offset: 0x00020730
	private void method_127(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		if (!Class87.smethod_27(this.method_218(), class144_3))
		{
			uint uint_ = ((Class168)class144_2).method_2();
			this.method_275(uint_);
		}
	}

	// Token: 0x060003CD RID: 973 RVA: 0x00004D47 File Offset: 0x00002F47
	private void method_128(Class144 class144_2)
	{
		this.method_117(typeof(int));
	}

	// Token: 0x060003CE RID: 974 RVA: 0x00022568 File Offset: 0x00020768
	private void method_129(Class144 class144_2)
	{
		if (class144_2 == null)
		{
			throw new ArgumentNullException(Class185.smethod_0(537696707));
		}
		Class144 gparam_;
		if (class144_2.method_0() != null)
		{
			gparam_ = class144_2;
		}
		else
		{
			int num = class144_2.vmethod_2();
			switch (num)
			{
			case 0:
			{
				Class150 @class = new Class150();
				@class.method_3((int)((Class164)class144_2).method_2());
				@class.method_1(class144_2.method_0());
				gparam_ = @class;
				goto IL_239;
			}
			case 1:
			case 3:
			case 5:
			case 7:
			case 8:
				break;
			case 2:
			{
				Class150 class2 = new Class150();
				class2.method_3(((Class149)class144_2).method_2() ? 1 : 0);
				class2.method_1(class144_2.method_0());
				gparam_ = class2;
				goto IL_239;
			}
			case 4:
			{
				object obj = class144_2.vmethod_0();
				if (obj == null)
				{
					gparam_ = class144_2;
					goto IL_239;
				}
				Type type = obj.GetType();
				if (type.HasElementType && !type.IsArray)
				{
					type = type.GetElementType();
				}
				if (type != null && !type.IsValueType && !type.IsEnum)
				{
					gparam_ = class144_2;
					goto IL_239;
				}
				gparam_ = Class104.smethod_1(obj, type);
				goto IL_239;
			}
			case 6:
			{
				Class150 class3 = new Class150();
				class3.method_3((int)((Class160)class144_2).method_2());
				class3.method_1(class144_2.method_0());
				gparam_ = class3;
				goto IL_239;
			}
			case 9:
			{
				Class150 class4 = new Class150();
				class4.method_3((int)((Class166)class144_2).method_2());
				class4.method_1(class144_2.method_0());
				gparam_ = class4;
				goto IL_239;
			}
			case 10:
			{
				Class163 class5 = new Class163();
				class5.method_3((double)((Class167)class144_2).method_2());
				class5.method_1(class144_2.method_0());
				gparam_ = class5;
				goto IL_239;
			}
			default:
				if (num == 15)
				{
					Class150 class6 = new Class150();
					class6.method_3((int)((Class146)class144_2).method_2());
					class6.method_1(class144_2.method_0());
					gparam_ = class6;
					goto IL_239;
				}
				switch (num)
				{
				case 19:
				{
					Class161 class7 = new Class161();
					class7.method_3((long)((Class170)class144_2).method_2());
					class7.method_1(class144_2.method_0());
					gparam_ = class7;
					goto IL_239;
				}
				case 21:
				{
					Class150 class8 = new Class150();
					class8.method_3((int)((Class168)class144_2).method_2());
					class8.method_1(class144_2.method_0());
					gparam_ = class8;
					goto IL_239;
				}
				case 22:
				{
					Class150 class9 = new Class150();
					class9.method_3((int)((Class169)class144_2).method_2());
					class9.method_1(class144_2.method_0());
					gparam_ = class9;
					goto IL_239;
				}
				}
				break;
			}
			gparam_ = class144_2;
		}
		IL_239:
		this.class57_1.method_7(gparam_);
	}

	// Token: 0x060003CF RID: 975 RVA: 0x000227BC File Offset: 0x000209BC
	private void method_130(Class144 class144_2)
	{
		Class144 @class = this.method_218();
		int num = @class.vmethod_2();
		bool flag;
		if (num <= 11)
		{
			switch (num)
			{
			case 4:
				flag = (((Class171)@class).method_2() == null);
				goto IL_CD;
			case 5:
			case 6:
				break;
			case 7:
				flag = (((Class150)@class).method_2() == 0);
				goto IL_CD;
			case 8:
				flag = (((Class162)@class).method_2() == UIntPtr.Zero);
				goto IL_CD;
			default:
				if (num == 11)
				{
					flag = (((Class161)@class).method_2() == 0L);
					goto IL_CD;
				}
				break;
			}
		}
		else
		{
			if (num == 14)
			{
				flag = (((Class151)@class).method_2() == IntPtr.Zero);
				goto IL_CD;
			}
			if (num == 24)
			{
				flag = !Convert.ToBoolean(((Class165)@class).method_2());
				goto IL_CD;
			}
		}
		flag = (@class.vmethod_0() == null);
		IL_CD:
		if (flag)
		{
			uint uint_ = ((Class168)class144_2).method_2();
			this.method_275(uint_);
		}
	}

	// Token: 0x060003D0 RID: 976 RVA: 0x000228AC File Offset: 0x00020AAC
	private void method_131(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		Class144 class144_4 = this.method_218();
		this.method_129(this.method_277(class144_4, class144_3, true, true));
	}

	// Token: 0x060003D1 RID: 977 RVA: 0x00004D59 File Offset: 0x00002F59
	private void method_132(Class144 class144_2)
	{
		throw new NotSupportedException(Class185.smethod_0(537698049));
	}

	// Token: 0x060003D2 RID: 978 RVA: 0x00004D6A File Offset: 0x00002F6A
	private void method_133(Class144 class144_2)
	{
		this.method_75(typeof(long));
	}

	// Token: 0x060003D3 RID: 979 RVA: 0x00004D7C File Offset: 0x00002F7C
	private void method_134(Class144 class144_2)
	{
		this.method_75(typeof(double));
	}

	// Token: 0x060003D4 RID: 980 RVA: 0x00004D8E File Offset: 0x00002F8E
	private void method_135(Class144 class144_2)
	{
		this.method_196();
	}

	// Token: 0x060003D5 RID: 981 RVA: 0x000228D8 File Offset: 0x00020AD8
	private Type method_136(int int_0, bool bool_2)
	{
		Dictionary<int, object> obj = Class87.dictionary_1;
		Type type;
		lock (obj)
		{
			bool flag = true;
			object obj2;
			if (Class87.dictionary_1.TryGetValue(int_0, out obj2))
			{
				type = (Type)obj2;
			}
			else
			{
				Class45 class45_ = this.method_3(int_0);
				type = this.method_31(int_0, class45_, ref flag, bool_2);
				if (flag)
				{
					Class87.dictionary_1.Add(int_0, type);
				}
			}
		}
		if (bool_2)
		{
			this.method_124(type);
		}
		return type;
	}

	// Token: 0x060003D6 RID: 982 RVA: 0x00022954 File Offset: 0x00020B54
	private void method_137(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		Class144 class144_4 = this.method_218();
		this.method_129(this.method_285(class144_4, class144_3, false, false));
	}

	// Token: 0x060003D7 RID: 983 RVA: 0x00022980 File Offset: 0x00020B80
	private void method_138(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		Class144 class144_4 = this.method_218();
		Class150 @class = new Class150();
		@class.method_3(Class87.smethod_14(class144_4, class144_3) ? 1 : 0);
		this.method_129(@class);
	}

	// Token: 0x060003D8 RID: 984 RVA: 0x000229BC File Offset: 0x00020BBC
	private void method_139(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		Class144 class144_4 = this.method_218();
		this.method_129(this.method_166(class144_4, class144_3, true, true));
	}

	// Token: 0x060003D9 RID: 985 RVA: 0x000229E8 File Offset: 0x00020BE8
	private static string smethod_9(MethodBase methodBase_0)
	{
		Type declaringType = methodBase_0.DeclaringType;
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		string[] array = new string[parameters.Length];
		for (int i = 0; i < parameters.Length; i++)
		{
			ParameterInfo parameterInfo = parameters[i];
			array[i] = string.Format(Class185.smethod_0(537696336), parameterInfo.ParameterType, parameterInfo.Name);
		}
		string arg = string.Join(Class185.smethod_0(537696782), array);
		return string.Format(Class185.smethod_0(537696775), declaringType.FullName, methodBase_0.Name, arg);
	}

	// Token: 0x060003DA RID: 986 RVA: 0x00004A22 File Offset: 0x00002C22
	private void method_140(Class144 class144_2)
	{
		this.method_129(class144_2);
	}

	// Token: 0x060003DB RID: 987 RVA: 0x00022A78 File Offset: 0x00020C78
	private void method_141(bool bool_2)
	{
		Class144 @class = this.method_218();
		int num = @class.vmethod_2();
		ushort int_;
		if (num <= 11)
		{
			if (num != 7)
			{
				if (num == 11)
				{
					if (bool_2)
					{
						int_ = checked((ushort)((ulong)((Class161)@class).method_2()));
						goto IL_BF;
					}
					int_ = (ushort)((Class161)@class).method_2();
					goto IL_BF;
				}
			}
			else
			{
				if (bool_2)
				{
					int_ = checked((ushort)((uint)((Class150)@class).method_2()));
					goto IL_BF;
				}
				int_ = (ushort)((Class150)@class).method_2();
				goto IL_BF;
			}
		}
		else if (num != 17)
		{
			if (num == 24)
			{
				if (bool_2)
				{
					int_ = checked((ushort)Convert.ToUInt64(((Class165)@class).method_2()));
					goto IL_BF;
				}
				int_ = (ushort)Convert.ToUInt64(((Class165)@class).method_2());
				goto IL_BF;
			}
		}
		else
		{
			if (bool_2)
			{
				int_ = checked((ushort)((Class163)@class).method_2());
				goto IL_BF;
			}
			int_ = (ushort)((Class163)@class).method_2();
			goto IL_BF;
		}
		throw new InvalidOperationException();
		IL_BF:
		Class150 class2 = new Class150();
		class2.method_3((int)int_);
		this.method_129(class2);
	}

	// Token: 0x060003DC RID: 988 RVA: 0x00004D96 File Offset: 0x00002F96
	private void method_142(Class144 class144_2)
	{
		Debugger.Break();
	}

	// Token: 0x060003DD RID: 989 RVA: 0x00022B58 File Offset: 0x00020D58
	private static bool smethod_10(Class144 class144_2, Class144 class144_3)
	{
		int num = class144_2.vmethod_2();
		if (num <= 14)
		{
			switch (num)
			{
			case 4:
				return ((Class171)class144_2).method_2() != ((Class171)class144_3).method_2();
			case 5:
			case 6:
				break;
			case 7:
				return ((Class150)class144_2).method_2() > ((Class150)class144_3).method_2();
			case 8:
				if (class144_3.vmethod_2() == 4 && class144_3.vmethod_0() == null)
				{
					return ((Class162)class144_2).method_2() != UIntPtr.Zero;
				}
				return ((Class162)class144_2).method_2() != ((Class162)class144_3).method_2();
			default:
				if (num == 11)
				{
					return ((Class161)class144_2).method_2() > ((Class161)class144_3).method_2();
				}
				if (num == 14)
				{
					if (class144_3.vmethod_2() == 4 && class144_3.vmethod_0() == null)
					{
						return ((Class151)class144_2).method_2() != IntPtr.Zero;
					}
					return ((Class151)class144_2).method_2() != ((Class151)class144_3).method_2();
				}
				break;
			}
		}
		else
		{
			if (num == 17)
			{
				double num2 = ((Class163)class144_2).method_2();
				double num3 = ((Class163)class144_3).method_2();
				return num2 > num3 || double.IsNaN(num2) || double.IsNaN(num3);
			}
			if (num == 20)
			{
				return (class144_3.vmethod_2() == 4 && class144_3.vmethod_0() == null) || ((Class159)class144_2).method_2() != ((Class159)class144_3).method_2();
			}
			if (num == 24)
			{
				long num4 = Convert.ToInt64(((Class165)class144_2).method_2());
				long num5;
				if (class144_3.vmethod_2() == 7)
				{
					num5 = (long)((Class150)class144_3).method_2();
				}
				else
				{
					num5 = Convert.ToInt64(((Class165)class144_3).method_2());
				}
				return num4 > num5;
			}
		}
		return class144_2.vmethod_0() != class144_3.vmethod_0();
	}

	// Token: 0x060003DE RID: 990 RVA: 0x00022D68 File Offset: 0x00020F68
	private Class144 method_143(Class144 class144_2)
	{
		if (class144_2.vmethod_2() == 7)
		{
			int num = ((Class150)class144_2).method_2();
			Class150 @class = new Class150();
			@class.method_3(-num);
			return @class;
		}
		if (class144_2.vmethod_2() == 11)
		{
			long num2 = ((Class161)class144_2).method_2();
			Class161 class2 = new Class161();
			class2.method_3(-num2);
			return class2;
		}
		if (class144_2.vmethod_2() == 17)
		{
			Class163 class3 = new Class163();
			class3.method_3(-((Class163)class144_2).method_2());
			return class3;
		}
		if (class144_2.vmethod_2() == 24)
		{
			Type underlyingType = Enum.GetUnderlyingType(class144_2.vmethod_0().GetType());
			if (underlyingType != typeof(long))
			{
				if (underlyingType != typeof(ulong))
				{
					Class150 class4 = new Class150();
					class4.method_3(Convert.ToInt32(class144_2.vmethod_0()));
					return this.method_143(class4);
				}
			}
			Class161 class5 = new Class161();
			class5.method_3(Convert.ToInt64(class144_2.vmethod_0()));
			return this.method_143(class5);
		}
		throw new InvalidOperationException();
	}

	// Token: 0x060003DF RID: 991 RVA: 0x0000336F File Offset: 0x0000156F
	private void method_144()
	{
	}

	// Token: 0x060003E0 RID: 992 RVA: 0x00004D9D File Offset: 0x00002F9D
	private void method_145(Class144 class144_2)
	{
		this.method_75(typeof(ushort));
	}

	// Token: 0x060003E1 RID: 993 RVA: 0x00004DAF File Offset: 0x00002FAF
	private void method_146(Class144 class144_2)
	{
		this.method_36(Class28.type_0);
	}

	// Token: 0x060003E2 RID: 994 RVA: 0x00022E54 File Offset: 0x00021054
	private void method_147(Class144 class144_2)
	{
		int int_ = ((Class150)class144_2).method_2();
		FieldInfo fieldInfo = this.method_122(int_);
		Class144 @class = this.method_218();
		Class144 class2 = this.method_218();
		Class152 class3 = class2 as Class152;
		object obj;
		if (class3 != null)
		{
			obj = this.method_245(class3).vmethod_0();
		}
		else
		{
			obj = class2.vmethod_0();
		}
		if (obj == null)
		{
			throw new NullReferenceException();
		}
		Class144 class4 = Class104.smethod_1(@class.vmethod_0(), fieldInfo.FieldType);
		fieldInfo.SetValue(obj, class4.vmethod_0());
		if (class3 != null && obj != null && obj.GetType().IsValueType)
		{
			this.method_105(class3, Class104.smethod_1(obj, null));
		}
	}

	// Token: 0x060003E3 RID: 995 RVA: 0x00004DBC File Offset: 0x00002FBC
	private static void smethod_11(ILGenerator ilgenerator_0, Type type_9)
	{
		if (type_9 == Class28.type_0)
		{
			return;
		}
		ilgenerator_0.Emit(OpCodes.Castclass, type_9);
	}

	// Token: 0x060003E4 RID: 996 RVA: 0x00004DD3 File Offset: 0x00002FD3
	private void method_148(Class144 class144_2)
	{
		this.method_287(1);
	}

	// Token: 0x060003E5 RID: 997 RVA: 0x00022EF0 File Offset: 0x000210F0
	private long method_149(string string_0)
	{
		MemoryStream memoryStream = new MemoryStream(Class82.smethod_0(string_0));
		long result = new Class183(new Class54(memoryStream, this.method_54())).method_21();
		memoryStream.Dispose();
		return result;
	}

	// Token: 0x060003E6 RID: 998 RVA: 0x00022F28 File Offset: 0x00021128
	private static Class144 smethod_12(Class144 class144_2, Class144 class144_3, bool bool_2)
	{
		if (!bool_2)
		{
			long num = ((Class161)class144_2).method_2();
			long num2 = ((Class161)class144_3).method_2();
			Class161 @class = new Class161();
			@class.method_3(num / num2);
			return @class;
		}
		ulong num3 = (ulong)((Class161)class144_2).method_2();
		ulong num4 = (ulong)((Class161)class144_3).method_2();
		Class161 class2 = new Class161();
		class2.method_3((long)(num3 / num4));
		return class2;
	}

	// Token: 0x060003E7 RID: 999 RVA: 0x00004A8A File Offset: 0x00002C8A
	private void method_150(Class144 class144_2)
	{
		this.method_252();
	}

	// Token: 0x060003E8 RID: 1000 RVA: 0x00004DDC File Offset: 0x00002FDC
	private void method_151(Class144 class144_2)
	{
		this.method_141(false);
	}

	// Token: 0x060003E9 RID: 1001 RVA: 0x00022F88 File Offset: 0x00021188
	private void method_152(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		Class144 class144_4 = this.method_218();
		this.method_129(this.method_87(class144_4, class144_3, true));
	}

	// Token: 0x060003EA RID: 1002 RVA: 0x00022FB4 File Offset: 0x000211B4
	private object method_153(int int_0)
	{
		int num = Class139.smethod_0(int_0);
		object result;
		if (num > 67108864)
		{
			if (num <= 167772160)
			{
				if (num == 100663296)
				{
					goto IL_C4;
				}
				if (num != 167772160)
				{
					goto IL_BE;
				}
				try
				{
					return this.module_0.ModuleHandle.ResolveFieldHandle(int_0);
				}
				catch
				{
					try
					{
						result = this.module_0.ModuleHandle.ResolveMethodHandle(int_0);
					}
					catch
					{
						throw new InvalidOperationException();
					}
					return result;
				}
			}
			if (num == 452984832)
			{
				goto IL_E0;
			}
			if (num != 721420288)
			{
				goto IL_BE;
			}
			IL_C4:
			return this.module_0.ModuleHandle.ResolveMethodHandle(int_0);
		}
		if (num == 16777216 || num == 33554432)
		{
			goto IL_E0;
		}
		if (num == 67108864)
		{
			return this.module_0.ModuleHandle.ResolveFieldHandle(int_0);
		}
		IL_BE:
		throw new InvalidOperationException();
		IL_E0:
		result = this.module_0.ModuleHandle.ResolveTypeHandle(int_0);
		return result;
	}

	// Token: 0x060003EB RID: 1003 RVA: 0x000230D8 File Offset: 0x000212D8
	private MethodBase method_154(MethodBase methodBase_0, bool bool_2)
	{
		Dictionary<MethodBase, DynamicMethod> obj = Class87.dictionary_3;
		MethodBase result;
		lock (obj)
		{
			DynamicMethod dynamicMethod;
			if (Class87.dictionary_3.TryGetValue(methodBase_0, out dynamicMethod))
			{
				result = dynamicMethod;
			}
			else
			{
				string empty = string.Empty;
				MethodInfo methodInfo = methodBase_0 as MethodInfo;
				Type returnType;
				if (methodInfo != null)
				{
					returnType = methodInfo.ReturnType;
				}
				else
				{
					returnType = Class87.type_2;
				}
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				Type[] array;
				if (methodBase_0.IsStatic)
				{
					array = new Type[parameters.Length];
					for (int i = 0; i < parameters.Length; i++)
					{
						array[i] = parameters[i].ParameterType;
					}
				}
				else
				{
					array = new Type[parameters.Length + 1];
					Type type = methodBase_0.DeclaringType;
					if (type.IsValueType)
					{
						type = type.MakeByRefType();
						bool_2 = false;
					}
					array[0] = type;
					for (int j = 0; j < parameters.Length; j++)
					{
						array[j + 1] = parameters[j].ParameterType;
					}
				}
				if (dynamicMethod == null)
				{
					dynamicMethod = new DynamicMethod(empty, returnType, array, this.method_136(this.class67_0.method_6(), true), true);
				}
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				for (int k = 0; k < array.Length; k++)
				{
					ilgenerator.Emit(OpCodes.Ldarg, k);
				}
				ConstructorInfo constructorInfo = methodBase_0 as ConstructorInfo;
				if (constructorInfo != null)
				{
					ilgenerator.Emit(bool_2 ? OpCodes.Callvirt : OpCodes.Call, constructorInfo);
				}
				else
				{
					ilgenerator.Emit(bool_2 ? OpCodes.Callvirt : OpCodes.Call, (MethodInfo)methodBase_0);
				}
				ilgenerator.Emit(OpCodes.Ret);
				Class87.dictionary_3.Add(methodBase_0, dynamicMethod);
				result = dynamicMethod;
			}
		}
		return result;
	}

	// Token: 0x060003EC RID: 1004 RVA: 0x00003ADA File Offset: 0x00001CDA
	private static bool smethod_13()
	{
		return false;
	}

	// Token: 0x060003ED RID: 1005 RVA: 0x00023294 File Offset: 0x00021494
	private void method_155(Class144 class144_2)
	{
		int int_ = ((Class150)class144_2).method_2();
		Type type_ = this.method_136(int_, true);
		Class144 class144_3 = this.method_218();
		if (!this.method_61(class144_3, type_))
		{
			throw new InvalidCastException();
		}
		this.method_129(class144_3);
	}

	// Token: 0x060003EE RID: 1006 RVA: 0x000232D4 File Offset: 0x000214D4
	private Class11 method_156(int int_0)
	{
		foreach (Class11 @class in this.class177_0.method_0())
		{
			if (@class.method_0() == int_0)
			{
				return @class;
			}
		}
		return null;
	}

	// Token: 0x060003EF RID: 1007 RVA: 0x00023334 File Offset: 0x00021534
	[DebuggerNonUserCode]
	private MethodBase method_157(int int_0)
	{
		Class45 class45_ = this.method_3(int_0);
		MethodBase methodBase = this.method_221(int_0, class45_);
		this.method_124(methodBase);
		return methodBase;
	}

	// Token: 0x060003F0 RID: 1008 RVA: 0x00004DE5 File Offset: 0x00002FE5
	private void method_158()
	{
		Class87.smethod_22<Class123>(this.class123_0, new Comparison<Class123>(Class87.Class88.class88_0.method_0));
	}

	// Token: 0x060003F1 RID: 1009 RVA: 0x0002335C File Offset: 0x0002155C
	private void method_159(bool bool_2)
	{
		Class144 @class = this.method_218();
		int num = @class.vmethod_2();
		uint int_;
		if (num <= 11)
		{
			if (num != 7)
			{
				if (num == 11)
				{
					if (bool_2)
					{
						int_ = checked((uint)((Class161)@class).method_2());
						goto IL_BD;
					}
					int_ = (uint)((Class161)@class).method_2();
					goto IL_BD;
				}
			}
			else
			{
				if (bool_2)
				{
					int_ = checked((uint)((Class150)@class).method_2());
					goto IL_BD;
				}
				int_ = (uint)((ushort)((Class150)@class).method_2());
				goto IL_BD;
			}
		}
		else if (num != 17)
		{
			if (num == 24)
			{
				if (bool_2)
				{
					int_ = checked((uint)Convert.ToUInt64(((Class165)@class).method_2()));
					goto IL_BD;
				}
				int_ = (uint)Convert.ToUInt64(((Class165)@class).method_2());
				goto IL_BD;
			}
		}
		else
		{
			if (bool_2)
			{
				int_ = checked((uint)((Class163)@class).method_2());
				goto IL_BD;
			}
			int_ = (uint)((Class163)@class).method_2();
			goto IL_BD;
		}
		throw new InvalidOperationException();
		IL_BD:
		Class150 class2 = new Class150();
		class2.method_3((int)int_);
		this.method_129(class2);
	}

	// Token: 0x060003F2 RID: 1010 RVA: 0x00023438 File Offset: 0x00021638
	private void method_160(Class144 class144_2)
	{
		int int_ = ((Class150)class144_2).method_2();
		Type type = this.method_136(int_, true);
		Class144 class144_3 = Class104.smethod_1(this.method_218().vmethod_0(), type);
		this.method_129(class144_3);
	}

	// Token: 0x060003F3 RID: 1011 RVA: 0x00023474 File Offset: 0x00021674
	private void method_161(bool bool_2)
	{
		Class144 @class = this.method_218();
		int num = @class.vmethod_2();
		checked
		{
			UIntPtr uintptr_;
			if (num <= 11)
			{
				if (num != 7)
				{
					if (num == 11)
					{
						if (bool_2)
						{
							uintptr_ = new UIntPtr((ulong)((Class161)@class).method_2());
							goto IL_EF;
						}
						uintptr_ = new UIntPtr((ulong)((Class161)@class).method_2());
						goto IL_EF;
					}
				}
				else
				{
					if (bool_2)
					{
						uintptr_ = new UIntPtr((uint)((Class150)@class).method_2());
						goto IL_EF;
					}
					uintptr_ = new UIntPtr((uint)((Class150)@class).method_2());
					goto IL_EF;
				}
			}
			else if (num != 17)
			{
				if (num == 24)
				{
					if (bool_2)
					{
						uintptr_ = new UIntPtr(Convert.ToUInt64(((Class165)@class).method_2()));
						goto IL_EF;
					}
					uintptr_ = new UIntPtr(Convert.ToUInt64(((Class165)@class).method_2()));
					goto IL_EF;
				}
			}
			else
			{
				if (bool_2)
				{
					uintptr_ = new UIntPtr((ulong)((Class163)@class).method_2());
					goto IL_EF;
				}
				uintptr_ = new UIntPtr(unchecked((ulong)((Class163)@class).method_2()));
				goto IL_EF;
			}
			throw new InvalidOperationException();
			IL_EF:
			Class162 class2 = new Class162();
			class2.method_3(uintptr_);
			this.method_129(class2);
		}
	}

	// Token: 0x060003F4 RID: 1012 RVA: 0x00023584 File Offset: 0x00021784
	private void method_162(Class144 class144_2)
	{
		int num = ((Class150)class144_2).method_2();
		bool flag = (num & int.MinValue) != 0;
		bool bool_ = (num & 1073741824) != 0;
		num &= 1073741823;
		if (flag)
		{
			this.method_57(num, null, null, bool_);
			return;
		}
		Class131 class131_ = (Class131)this.method_3(num).method_4();
		this.method_165(class131_);
	}

	// Token: 0x060003F5 RID: 1013 RVA: 0x000235E0 File Offset: 0x000217E0
	private void method_163(Class144 class144_2)
	{
		Class144 @class = this.method_218();
		int num = @class.vmethod_2();
		checked
		{
			uint int_;
			if (num <= 11)
			{
				if (num == 7)
				{
					int_ = (uint)((Class150)@class).method_2();
					goto IL_6E;
				}
				if (num == 11)
				{
					int_ = (uint)((ulong)((Class161)@class).method_2());
					goto IL_6E;
				}
			}
			else
			{
				if (num == 17)
				{
					int_ = (uint)((Class163)@class).method_2();
					goto IL_6E;
				}
				if (num == 24)
				{
					int_ = (uint)Convert.ToUInt64(((Class165)@class).method_2());
					goto IL_6E;
				}
			}
			throw new InvalidOperationException();
			IL_6E:
			Class150 class2 = new Class150();
			class2.method_3((int)int_);
			this.method_129(class2);
		}
	}

	// Token: 0x060003F6 RID: 1014 RVA: 0x00023670 File Offset: 0x00021870
	private static bool smethod_14(Class144 class144_2, Class144 class144_3)
	{
		bool result = false;
		int num = class144_2.vmethod_2();
		if (num <= 11)
		{
			if (num != 7)
			{
				if (num == 11)
				{
					if (class144_3.vmethod_2() == 24)
					{
						Class161 @class = new Class161();
						@class.method_3(Convert.ToInt64(((Class165)class144_3).method_2()));
						return Class87.smethod_14(class144_2, @class);
					}
					if (class144_3.vmethod_2() == 7)
					{
						Class161 class2 = new Class161();
						class2.method_3((long)((Class150)class144_3).method_2());
						return Class87.smethod_14(class144_2, class2);
					}
					result = (((Class161)class144_2).method_2() < ((Class161)class144_3).method_2());
				}
			}
			else
			{
				if (class144_3.vmethod_2() == 24)
				{
					Class150 class3 = new Class150();
					class3.method_3(Convert.ToInt32(((Class165)class144_3).method_2()));
					return Class87.smethod_14(class144_2, class3);
				}
				result = (((Class150)class144_2).method_2() < ((Class150)class144_3).method_2());
			}
		}
		else if (num != 17)
		{
			if (num == 24)
			{
				Class161 class4 = new Class161();
				class4.method_3(Convert.ToInt64(((Class165)class144_2).method_2()));
				return Class87.smethod_14(class4, class144_3);
			}
		}
		else
		{
			double num2 = ((Class163)class144_2).method_2();
			double num3 = ((Class163)class144_3).method_2();
			result = (num2 < num3 || double.IsNaN(num2) || double.IsNaN(num3));
		}
		return result;
	}

	// Token: 0x060003F7 RID: 1015 RVA: 0x00004E11 File Offset: 0x00003011
	private void method_164(Class144 class144_2)
	{
		this.method_294(false);
	}

	// Token: 0x060003F8 RID: 1016 RVA: 0x000237B4 File Offset: 0x000219B4
	private void method_165(Class131 class131_0)
	{
		Class45 @class = this.method_3(class131_0.method_2());
		Class133 class2 = (Class133)@class.method_4();
		MethodBase methodBase = this.method_221(class131_0.method_2(), @class);
		methodBase.GetParameters();
		int num = class131_0.method_0();
		bool bool_ = (num & 1073741824) != 0;
		num &= -1073741825;
		Type[] array = this.type_7;
		Type[] array2 = this.type_3;
		try
		{
			this.type_7 = ((methodBase is ConstructorInfo) ? Type.EmptyTypes : methodBase.GetGenericArguments());
			this.type_3 = methodBase.DeclaringType.GetGenericArguments();
			this.method_57(num, this.type_7, this.type_3, bool_);
		}
		finally
		{
			this.type_7 = array;
			this.type_3 = array2;
		}
	}

	// Token: 0x060003F9 RID: 1017 RVA: 0x0002387C File Offset: 0x00021A7C
	private Class144 method_166(Class144 class144_2, Class144 class144_3, bool bool_2, bool bool_3)
	{
		if (class144_2.vmethod_2() == 7)
		{
			if (class144_3.vmethod_2() == 7)
			{
				if (!bool_3)
				{
					int num = ((Class150)class144_2).method_2();
					int num2 = ((Class150)class144_3).method_2();
					int int_;
					if (bool_2)
					{
						int_ = checked(num * num2);
					}
					else
					{
						int_ = num * num2;
					}
					Class150 @class = new Class150();
					@class.method_3(int_);
					return @class;
				}
				uint num3 = (uint)((Class150)class144_2).method_2();
				uint num4 = (uint)((Class150)class144_3).method_2();
				uint int_2;
				if (bool_2)
				{
					int_2 = checked(num3 * num4);
				}
				else
				{
					int_2 = num3 * num4;
				}
				Class150 class2 = new Class150();
				class2.method_3((int)int_2);
				return class2;
			}
			else
			{
				if (class144_3.vmethod_2() == 11)
				{
					Class161 class3 = new Class161();
					class3.method_3((long)((Class150)class144_2).method_2());
					return Class87.smethod_15(class3, class144_3, bool_2, bool_3);
				}
				if (class144_3.vmethod_2() == 24)
				{
					Type underlyingType = Enum.GetUnderlyingType(class144_3.vmethod_0().GetType());
					if (underlyingType != typeof(long))
					{
						if (underlyingType != typeof(ulong))
						{
							Class150 class4 = new Class150();
							class4.method_3(Convert.ToInt32(class144_3.vmethod_0()));
							return this.method_166(class144_2, class4, bool_2, bool_3);
						}
					}
					Class161 class5 = new Class161();
					class5.method_3((long)((Class150)class144_2).method_2());
					Class161 class6 = new Class161();
					class6.method_3(Convert.ToInt64(class144_3.vmethod_0()));
					return Class87.smethod_15(class5, class6, bool_2, bool_3);
				}
			}
		}
		if (class144_2.vmethod_2() == 11)
		{
			if (class144_3.vmethod_2() == 11)
			{
				return Class87.smethod_15(class144_2, class144_3, bool_2, bool_3);
			}
			if (class144_3.vmethod_2() == 7)
			{
				Class161 class7 = new Class161();
				class7.method_3((long)((Class150)class144_3).method_2());
				return Class87.smethod_15(class144_2, class7, bool_2, bool_3);
			}
			if (class144_3.vmethod_2() == 24)
			{
				Type underlyingType2 = Enum.GetUnderlyingType(class144_3.vmethod_0().GetType());
				if (underlyingType2 != typeof(long))
				{
					if (underlyingType2 != typeof(ulong))
					{
						Class150 class8 = new Class150();
						class8.method_3(Convert.ToInt32(class144_3.vmethod_0()));
						return Class87.smethod_15(class144_2, class8, bool_2, bool_3);
					}
				}
				Class161 class9 = new Class161();
				class9.method_3(Convert.ToInt64(class144_3.vmethod_0()));
				return Class87.smethod_15(class144_2, class9, bool_2, bool_3);
			}
		}
		if (class144_2.vmethod_2() == 17 && class144_3.vmethod_2() == 17)
		{
			Class163 class10 = new Class163();
			class10.method_3(((Class163)class144_2).method_2() * ((Class163)class144_3).method_2());
			return class10;
		}
		if (class144_2.vmethod_2() == 24)
		{
			Type underlyingType3 = Enum.GetUnderlyingType(class144_2.vmethod_0().GetType());
			if (underlyingType3 != typeof(long))
			{
				if (underlyingType3 != typeof(ulong))
				{
					Class150 class11 = new Class150();
					class11.method_3(Convert.ToInt32(class144_2.vmethod_0()));
					return this.method_166(class11, class144_3, bool_2, bool_3);
				}
			}
			Class161 class12 = new Class161();
			class12.method_3(Convert.ToInt64(class144_2.vmethod_0()));
			return this.method_166(class12, class144_3, bool_2, bool_3);
		}
		throw new InvalidOperationException();
	}

	// Token: 0x060003FA RID: 1018 RVA: 0x00023B4C File Offset: 0x00021D4C
	private void method_167(Class144 class144_2)
	{
		object object_ = this.method_218().vmethod_0();
		long num = this.method_202();
		Array array = (Array)this.method_218().vmethod_0();
		Type elementType = array.GetType().GetElementType();
		checked
		{
			if (elementType == typeof(short))
			{
				Class144 @class = Class104.smethod_1(object_, typeof(short));
				((short[])array)[(int)((IntPtr)num)] = (short)@class.vmethod_0();
				return;
			}
			if (elementType == typeof(ushort))
			{
				Class144 class2 = Class104.smethod_1(object_, typeof(ushort));
				((ushort[])array)[(int)((IntPtr)num)] = (ushort)class2.vmethod_0();
				return;
			}
			if (elementType == typeof(char))
			{
				Class144 class3 = Class104.smethod_1(object_, typeof(char));
				((char[])array)[(int)((IntPtr)num)] = (char)class3.vmethod_0();
				return;
			}
			if (elementType.IsEnum)
			{
				this.method_206(elementType, object_, num, array);
				return;
			}
			this.method_206(typeof(short), object_, num, array);
		}
	}

	// Token: 0x060003FB RID: 1019 RVA: 0x00023C50 File Offset: 0x00021E50
	private static Class144 smethod_15(Class144 class144_2, Class144 class144_3, bool bool_2, bool bool_3)
	{
		if (!bool_3)
		{
			long num = ((Class161)class144_2).method_2();
			long num2 = ((Class161)class144_3).method_2();
			long long_;
			if (bool_2)
			{
				long_ = checked(num * num2);
			}
			else
			{
				long_ = num * num2;
			}
			Class161 @class = new Class161();
			@class.method_3(long_);
			return @class;
		}
		ulong num3 = (ulong)((Class161)class144_2).method_2();
		ulong num4 = (ulong)((Class161)class144_3).method_2();
		ulong long_2;
		if (bool_2)
		{
			long_2 = checked(num3 * num4);
		}
		else
		{
			long_2 = num3 * num4;
		}
		Class161 class2 = new Class161();
		class2.method_3((long)long_2);
		return class2;
	}

	// Token: 0x060003FC RID: 1020 RVA: 0x00023CCC File Offset: 0x00021ECC
	private static bool smethod_16(Class144 class144_2, Class144 class144_3)
	{
		bool result = false;
		int num = class144_2.vmethod_2();
		if (num <= 11)
		{
			if (num != 7)
			{
				if (num == 11)
				{
					if (class144_3.vmethod_2() == 24)
					{
						Class161 @class = new Class161();
						@class.method_3(Convert.ToInt64(((Class165)class144_3).method_2()));
						return Class87.smethod_16(class144_2, @class);
					}
					if (class144_3.vmethod_2() == 7)
					{
						Class161 class2 = new Class161();
						class2.method_3((long)((Class150)class144_3).method_2());
						return Class87.smethod_16(class144_2, class2);
					}
					result = (((Class161)class144_2).method_2() > ((Class161)class144_3).method_2());
				}
			}
			else
			{
				if (class144_3.vmethod_2() == 24)
				{
					Class150 class3 = new Class150();
					class3.method_3(Convert.ToInt32(((Class165)class144_3).method_2()));
					return Class87.smethod_16(class144_2, class3);
				}
				result = (((Class150)class144_2).method_2() > ((Class150)class144_3).method_2());
			}
		}
		else if (num != 17)
		{
			if (num == 24)
			{
				Class161 class4 = new Class161();
				class4.method_3(Convert.ToInt64(((Class165)class144_2).method_2()));
				return Class87.smethod_16(class4, class144_3);
			}
		}
		else
		{
			double num2 = ((Class163)class144_2).method_2();
			double num3 = ((Class163)class144_3).method_2();
			result = (!double.IsNaN(num2) && !double.IsNaN(num3) && num2 > num3);
		}
		return result;
	}

	// Token: 0x060003FD RID: 1021 RVA: 0x00023E10 File Offset: 0x00022010
	private void method_168(bool bool_2)
	{
		Class144 @class = this.method_218();
		int num = @class.vmethod_2();
		int int_;
		if (num <= 11)
		{
			if (num != 7)
			{
				if (num == 11)
				{
					if (bool_2)
					{
						int_ = checked((int)((Class161)@class).method_2());
						goto IL_BB;
					}
					int_ = (int)((Class161)@class).method_2();
					goto IL_BB;
				}
			}
			else
			{
				if (bool_2)
				{
					int_ = ((Class150)@class).method_2();
					goto IL_BB;
				}
				int_ = ((Class150)@class).method_2();
				goto IL_BB;
			}
		}
		else if (num != 17)
		{
			if (num == 24)
			{
				if (bool_2)
				{
					int_ = checked((int)Convert.ToUInt64(((Class165)@class).method_2()));
					goto IL_BB;
				}
				int_ = (int)Convert.ToUInt64(((Class165)@class).method_2());
				goto IL_BB;
			}
		}
		else
		{
			if (bool_2)
			{
				int_ = checked((int)((Class163)@class).method_2());
				goto IL_BB;
			}
			int_ = (int)((Class163)@class).method_2();
			goto IL_BB;
		}
		throw new InvalidOperationException();
		IL_BB:
		Class150 class2 = new Class150();
		class2.method_3(int_);
		this.method_129(class2);
	}

	// Token: 0x060003FE RID: 1022 RVA: 0x00004E1A File Offset: 0x0000301A
	private void method_169(Stream stream_1, string string_0)
	{
		this.method_295(stream_1, 0L, string_0);
	}

	// Token: 0x060003FF RID: 1023 RVA: 0x00023EEC File Offset: 0x000220EC
	private void method_170(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		Class144 class144_4 = this.method_218();
		Class150 @class = new Class150();
		@class.method_3(Class87.smethod_20(class144_4, class144_3) ? 1 : 0);
		this.method_129(@class);
	}

	// Token: 0x06000400 RID: 1024 RVA: 0x00004E2D File Offset: 0x0000302D
	private void method_171(Class144 class144_2)
	{
		this.method_129(this.class144_0[1].vmethod_4());
	}

	// Token: 0x06000401 RID: 1025 RVA: 0x00004A8A File Offset: 0x00002C8A
	private void method_172(Class144 class144_2)
	{
		this.method_252();
	}

	// Token: 0x06000402 RID: 1026 RVA: 0x00023F28 File Offset: 0x00022128
	private void method_173(Class144 class144_2)
	{
		object object_ = this.method_218().vmethod_0();
		long num = this.method_202();
		Array array = (Array)this.method_218().vmethod_0();
		Type elementType = array.GetType().GetElementType();
		checked
		{
			if (elementType == typeof(long))
			{
				Class144 @class = Class104.smethod_1(object_, typeof(long));
				((long[])array)[(int)((IntPtr)num)] = (long)@class.vmethod_0();
				return;
			}
			if (elementType == typeof(ulong))
			{
				Class144 class2 = Class104.smethod_1(object_, typeof(ulong));
				((ulong[])array)[(int)((IntPtr)num)] = (ulong)class2.vmethod_0();
				return;
			}
			if (elementType.IsEnum)
			{
				this.method_206(elementType, object_, num, array);
				return;
			}
			this.method_206(typeof(long), object_, num, array);
		}
	}

	// Token: 0x06000403 RID: 1027 RVA: 0x00004E46 File Offset: 0x00003046
	private void method_174(Class144 class144_2)
	{
		this.method_46(false);
	}

	// Token: 0x06000404 RID: 1028 RVA: 0x00023FF8 File Offset: 0x000221F8
	private void method_175(Class144 class144_2)
	{
		int int_ = ((Class150)class144_2).method_2();
		Type type = this.method_136(int_, true);
		Class144 @class = Class104.smethod_1(this.method_218().vmethod_0(), type);
		@class.method_1(type);
		this.method_129(@class);
	}

	// Token: 0x06000405 RID: 1029 RVA: 0x00004E4F File Offset: 0x0000304F
	private void method_176(Class144 class144_2)
	{
		this.method_129(this.class144_1[1].vmethod_4());
	}

	// Token: 0x06000406 RID: 1030 RVA: 0x0002403C File Offset: 0x0002223C
	private void method_177(Class144 class144_2)
	{
		Class150 @class = (Class150)class144_2;
		MethodBase methodBase = this.method_157(@class.method_2());
		if (this.type_5 != null)
		{
			ParameterInfo[] parameters = methodBase.GetParameters();
			Type[] array = new Type[parameters.Length];
			int num = 0;
			foreach (ParameterInfo parameterInfo in parameters)
			{
				array[num++] = parameterInfo.ParameterType;
			}
			MethodInfo method = this.type_5.GetMethod(methodBase.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty, null, array, null);
			if (method != null)
			{
				methodBase = method;
			}
			this.type_5 = null;
		}
		this.method_271(methodBase, true);
	}

	// Token: 0x06000407 RID: 1031 RVA: 0x000240D4 File Offset: 0x000222D4
	private void method_178(Class144 class144_2)
	{
		Class164 @class = (Class164)class144_2;
		this.method_129(this.class144_0[(int)@class.method_2()].vmethod_4());
	}

	// Token: 0x06000408 RID: 1032 RVA: 0x00024104 File Offset: 0x00022304
	private static Class123 smethod_17(Class183 class183_2)
	{
		Class123 @class = new Class123();
		@class.method_3((int)class183_2.method_6());
		@class.method_1(class183_2.method_19());
		@class.method_7(class183_2.method_20());
		@class.method_5(class183_2.method_20());
		@class.method_11(class183_2.method_20());
		@class.method_9(class183_2.method_20());
		return @class;
	}

	// Token: 0x06000409 RID: 1033 RVA: 0x0000336F File Offset: 0x0000156F
	[Conditional("DEBUG")]
	public static void smethod_18(string string_0)
	{
	}

	// Token: 0x0600040A RID: 1034 RVA: 0x00024160 File Offset: 0x00022360
	private void method_179(Class144 class144_2)
	{
		int int_ = ((Class150)class144_2).method_2();
		Type elementType = this.method_136(int_, true);
		Class144 @class = this.method_218();
		Class150 class2 = @class as Class150;
		int length;
		if (class2 != null)
		{
			length = class2.method_2();
		}
		else
		{
			Class151 class3 = @class as Class151;
			if (class3 != null)
			{
				length = class3.method_2().ToInt32();
			}
			else
			{
				Class162 class4 = @class as Class162;
				if (class4 == null)
				{
					throw new Exception();
				}
				length = (int)class4.method_2().ToUInt32();
			}
		}
		Array array_ = Array.CreateInstance(elementType, length);
		Class145 class5 = new Class145();
		class5.method_3(array_);
		this.method_129(class5);
	}

	// Token: 0x0600040B RID: 1035 RVA: 0x00004A8A File Offset: 0x00002C8A
	private void method_180(Class144 class144_2)
	{
		this.method_252();
	}

	// Token: 0x0600040C RID: 1036 RVA: 0x000241FC File Offset: 0x000223FC
	private void method_181(Class144 class144_2)
	{
		Class144 @class = this.method_218();
		Class144 class144_3 = @class.vmethod_4();
		this.method_129(@class);
		this.method_129(class144_3);
	}

	// Token: 0x0600040D RID: 1037 RVA: 0x00004E68 File Offset: 0x00003068
	private void method_182(Class144 class144_2)
	{
		throw new NotSupportedException(Class185.smethod_0(537696747));
	}

	// Token: 0x0600040E RID: 1038 RVA: 0x00004E79 File Offset: 0x00003079
	private void method_183(Class144 class144_2)
	{
		this.method_75(typeof(byte));
	}

	// Token: 0x0600040F RID: 1039 RVA: 0x00024228 File Offset: 0x00022428
	private void method_184(Class144 class144_2)
	{
		Class144 @class = this.method_218();
		this.method_43(@class.vmethod_0());
	}

	// Token: 0x06000410 RID: 1040 RVA: 0x00024248 File Offset: 0x00022448
	private void method_185(Class144 class144_2)
	{
		Class164 @class = (Class164)class144_2;
		Class154 class2 = new Class154();
		class2.method_3((int)@class.method_2());
		this.method_129(class2);
	}

	// Token: 0x06000411 RID: 1041 RVA: 0x00024274 File Offset: 0x00022474
	private void method_186(Class144 class144_2)
	{
		Class169 @class = (Class169)class144_2;
		this.method_129(this.class144_1[(int)@class.method_2()].vmethod_4());
	}

	// Token: 0x06000412 RID: 1042 RVA: 0x000242A4 File Offset: 0x000224A4
	private static bool smethod_19(MethodBase methodBase_0)
	{
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		for (int i = 0; i < parameters.Length; i++)
		{
			if (parameters[i].ParameterType.IsByRef)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000413 RID: 1043 RVA: 0x000242DC File Offset: 0x000224DC
	private void method_187(object object_3, uint uint_0)
	{
		bool flag = object_3 != null;
		this.object_0 = object_3;
		if (flag)
		{
			this.class57_0.method_0();
		}
		this.bool_1 = flag;
		if (!flag)
		{
			this.class57_0.method_7(new Class87.Struct39(uint_0));
		}
		foreach (Class123 @class in this.class123_0)
		{
			if (this.method_235(this.long_0, @class.method_6(), @class.method_10()))
			{
				switch (@class.method_2())
				{
				case 0:
					if (flag)
					{
						Type type = object_3.GetType();
						Type type2 = this.method_136(@class.method_0(), true);
						if (type == type2 || type.IsSubclassOf(type2))
						{
							this.class57_0.method_7(new Class87.Struct39(@class.method_8(), object_3));
							this.bool_1 = false;
						}
					}
					break;
				case 1:
					if (flag)
					{
						this.class57_0.method_7(new Class87.Struct39(@class.method_8()));
					}
					break;
				case 2:
					if (flag || !this.method_235((long)((ulong)uint_0), @class.method_6(), @class.method_10()))
					{
						this.class57_0.method_7(new Class87.Struct39(@class.method_8()));
					}
					break;
				case 4:
					if (flag)
					{
						this.class57_0.method_7(new Class87.Struct39(@class.method_4(), object_3));
					}
					break;
				}
			}
		}
		this.method_196();
	}

	// Token: 0x06000414 RID: 1044 RVA: 0x00024444 File Offset: 0x00022644
	private static bool smethod_20(Class144 class144_2, Class144 class144_3)
	{
		bool result = false;
		int num = class144_2.vmethod_2();
		if (num <= 11)
		{
			if (num != 7)
			{
				if (num == 11)
				{
					if (class144_3.vmethod_2() == 24)
					{
						Class161 @class = new Class161();
						@class.method_3(Convert.ToInt64(((Class165)class144_3).method_2()));
						return Class87.smethod_20(class144_2, @class);
					}
					if (class144_3.vmethod_2() == 7)
					{
						Class161 class2 = new Class161();
						class2.method_3((long)((Class150)class144_3).method_2());
						return Class87.smethod_20(class144_2, class2);
					}
					result = (((Class161)class144_2).method_2() < ((Class161)class144_3).method_2());
				}
			}
			else
			{
				if (class144_3.vmethod_2() == 24)
				{
					Class150 class3 = new Class150();
					class3.method_3(Convert.ToInt32(((Class165)class144_3).method_2()));
					return Class87.smethod_20(class144_2, class3);
				}
				result = (((Class150)class144_2).method_2() < ((Class150)class144_3).method_2());
			}
		}
		else if (num != 17)
		{
			if (num == 24)
			{
				Class161 class4 = new Class161();
				class4.method_3(Convert.ToInt64(((Class165)class144_2).method_2()));
				return Class87.smethod_20(class4, class144_3);
			}
		}
		else
		{
			result = (((Class163)class144_2).method_2() < ((Class163)class144_3).method_2());
		}
		return result;
	}

	// Token: 0x06000415 RID: 1045 RVA: 0x00024570 File Offset: 0x00022770
	private Class144 method_188(Class144 class144_2, Class144 class144_3, bool bool_2)
	{
		if (class144_2.vmethod_2() == 7)
		{
			if (class144_3.vmethod_2() == 7)
			{
				if (!bool_2)
				{
					int num = ((Class150)class144_2).method_2();
					int num2 = ((Class150)class144_3).method_2();
					Class150 @class = new Class150();
					@class.method_3(num / num2);
					return @class;
				}
				uint num3 = (uint)((Class150)class144_2).method_2();
				uint num4 = (uint)((Class150)class144_3).method_2();
				Class150 class2 = new Class150();
				class2.method_3((int)(num3 / num4));
				return class2;
			}
			else
			{
				if (class144_3.vmethod_2() == 11)
				{
					Class161 class3 = new Class161();
					class3.method_3((long)((Class150)class144_2).method_2());
					return Class87.smethod_12(class3, class144_3, bool_2);
				}
				if (class144_3.vmethod_2() == 24)
				{
					Type underlyingType = Enum.GetUnderlyingType(class144_3.vmethod_0().GetType());
					if (underlyingType != typeof(long))
					{
						if (underlyingType != typeof(ulong))
						{
							Class150 class4 = new Class150();
							class4.method_3(Convert.ToInt32(class144_3.vmethod_0()));
							return this.method_188(class144_2, class4, bool_2);
						}
					}
					Class161 class5 = new Class161();
					class5.method_3((long)((Class150)class144_2).method_2());
					Class161 class6 = new Class161();
					class6.method_3(Convert.ToInt64(class144_3.vmethod_0()));
					return Class87.smethod_12(class5, class6, bool_2);
				}
			}
		}
		if (class144_2.vmethod_2() == 11)
		{
			if (class144_3.vmethod_2() == 11)
			{
				return Class87.smethod_12(class144_2, class144_3, bool_2);
			}
			if (class144_3.vmethod_2() == 7)
			{
				Class161 class7 = new Class161();
				class7.method_3((long)((Class150)class144_3).method_2());
				return Class87.smethod_12(class144_2, class7, bool_2);
			}
			if (class144_3.vmethod_2() == 24)
			{
				Type underlyingType2 = Enum.GetUnderlyingType(class144_3.vmethod_0().GetType());
				if (underlyingType2 != typeof(long))
				{
					if (underlyingType2 != typeof(ulong))
					{
						Class150 class8 = new Class150();
						class8.method_3(Convert.ToInt32(class144_3.vmethod_0()));
						return Class87.smethod_12(class144_2, class8, bool_2);
					}
				}
				Class161 class9 = new Class161();
				class9.method_3(Convert.ToInt64(class144_3.vmethod_0()));
				return Class87.smethod_12(class144_2, class9, bool_2);
			}
		}
		if (class144_2.vmethod_2() == 17 && class144_3.vmethod_2() == 17)
		{
			Class163 class10 = new Class163();
			class10.method_3(((Class163)class144_2).method_2() / ((Class163)class144_3).method_2());
			return class10;
		}
		if (class144_2.vmethod_2() == 24)
		{
			Type underlyingType3 = Enum.GetUnderlyingType(class144_2.vmethod_0().GetType());
			if (underlyingType3 != typeof(long))
			{
				if (underlyingType3 != typeof(ulong))
				{
					Class150 class11 = new Class150();
					class11.method_3(Convert.ToInt32(class144_2.vmethod_0()));
					return this.method_188(class11, class144_3, bool_2);
				}
			}
			Class161 class12 = new Class161();
			class12.method_3(Convert.ToInt64(class144_2.vmethod_0()));
			return this.method_188(class12, class144_3, bool_2);
		}
		throw new InvalidOperationException();
	}

	// Token: 0x06000416 RID: 1046 RVA: 0x0002480C File Offset: 0x00022A0C
	private void method_189(Class144 class144_2)
	{
		Class164 @class = (Class164)class144_2;
		Class144 class2 = this.method_218();
		this.class144_0[(int)@class.method_2()].vmethod_3(class2);
	}

	// Token: 0x06000417 RID: 1047 RVA: 0x00024840 File Offset: 0x00022A40
	private void method_190(Class144 class144_2)
	{
		Class144 @class = this.method_218();
		int num = @class.vmethod_2();
		double double_;
		if (num != 7)
		{
			if (num != 11)
			{
				if (num != 24)
				{
					throw new InvalidOperationException();
				}
				double_ = Convert.ToUInt64(((Class165)@class).method_2());
			}
			else
			{
				double_ = ((Class161)@class).method_2();
			}
		}
		else
		{
			double_ = ((Class150)@class).method_2();
		}
		Class163 class2 = new Class163();
		class2.method_3(double_);
		this.method_129(class2);
	}

	// Token: 0x06000418 RID: 1048 RVA: 0x000248B4 File Offset: 0x00022AB4
	private FieldInfo method_191(int int_0, Class45 class45_0, ref bool bool_2)
	{
		if (class45_0.method_0() == 1)
		{
			bool_2 = false;
			return this.module_0.ResolveField(class45_0.method_2());
		}
		Class129 @class = (Class129)class45_0.method_4();
		Type type = this.method_136(@class.method_0().method_2(), false);
		if (type.IsGenericType)
		{
			bool_2 = false;
		}
		BindingFlags bindingAttr = Class87.smethod_23(@class.method_4());
		return type.GetField(@class.method_2(), bindingAttr);
	}

	// Token: 0x06000419 RID: 1049 RVA: 0x00004E8B File Offset: 0x0000308B
	private void method_192(Class144 class144_2)
	{
		this.method_287(3);
	}

	// Token: 0x0600041A RID: 1050 RVA: 0x00024920 File Offset: 0x00022B20
	private void method_193(Class144 class144_2)
	{
		int int_ = ((Class150)class144_2).method_2();
		FieldInfo fieldInfo = this.method_122(int_);
		this.method_129(Class104.smethod_1(fieldInfo.GetValue(null), fieldInfo.FieldType));
	}

	// Token: 0x0600041B RID: 1051 RVA: 0x00004E94 File Offset: 0x00003094
	private void method_194(Class144 class144_2)
	{
		this.method_161(true);
	}

	// Token: 0x0600041C RID: 1052 RVA: 0x00004A22 File Offset: 0x00002C22
	private void method_195(Class144 class144_2)
	{
		this.method_129(class144_2);
	}

	// Token: 0x0600041D RID: 1053 RVA: 0x0002495C File Offset: 0x00022B5C
	private void method_196()
	{
		if (this.class57_0.Count == 0)
		{
			if (this.bool_1)
			{
				this.method_43(this.object_0);
			}
			return;
		}
		Class87.Struct39 @struct = this.class57_0.method_6();
		if (@struct.method_1() != null)
		{
			Class171 @class = new Class171();
			@class.vmethod_1(@struct.method_1());
			this.method_129(@class);
		}
		else
		{
			this.class57_1.method_0();
		}
		this.method_275(@struct.method_0());
	}

	// Token: 0x0600041E RID: 1054 RVA: 0x000249D4 File Offset: 0x00022BD4
	private void method_197(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		Class144 class144_4 = this.method_218();
		this.method_129(this.method_277(class144_4, class144_3, true, false));
	}

	// Token: 0x0600041F RID: 1055 RVA: 0x00024A00 File Offset: 0x00022C00
	private static Class144 smethod_21(Class144 class144_2, Class144 class144_3, bool bool_2, bool bool_3)
	{
		if (!bool_3)
		{
			long num = ((Class161)class144_2).method_2();
			long num2 = ((Class161)class144_3).method_2();
			long long_;
			if (bool_2)
			{
				long_ = checked(num + num2);
			}
			else
			{
				long_ = num + num2;
			}
			Class161 @class = new Class161();
			@class.method_3(long_);
			return @class;
		}
		ulong num3 = (ulong)((Class161)class144_2).method_2();
		ulong num4 = (ulong)((Class161)class144_3).method_2();
		ulong long_2;
		if (bool_2)
		{
			long_2 = checked(num3 + num4);
		}
		else
		{
			long_2 = num3 + num4;
		}
		Class161 class2 = new Class161();
		class2.method_3((long)long_2);
		return class2;
	}

	// Token: 0x06000420 RID: 1056 RVA: 0x00004E9D File Offset: 0x0000309D
	private void method_198(Class144 class144_2)
	{
		this.method_168(true);
	}

	// Token: 0x06000421 RID: 1057 RVA: 0x00004EA6 File Offset: 0x000030A6
	private object method_199(MethodBase methodBase_0, object object_3, object[] object_4)
	{
		if (methodBase_0.IsConstructor)
		{
			return Activator.CreateInstance(methodBase_0.DeclaringType, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, object_4, null);
		}
		return methodBase_0.Invoke(object_3, object_4);
	}

	// Token: 0x06000422 RID: 1058 RVA: 0x00024A7C File Offset: 0x00022C7C
	private void method_200(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		Class144 @class = this.method_218();
		bool flag;
		if (@class.vmethod_2() == 17)
		{
			flag = !Class87.smethod_10(@class, class144_3);
		}
		else
		{
			flag = !Class87.smethod_16(@class, class144_3);
		}
		if (flag)
		{
			uint uint_ = ((Class168)class144_2).method_2();
			this.method_275(uint_);
		}
	}

	// Token: 0x06000423 RID: 1059 RVA: 0x00024AD0 File Offset: 0x00022CD0
	private void method_201(Class144 class144_2)
	{
		int int_ = ((Class150)class144_2).method_2();
		this.type_5 = this.method_136(int_, true);
	}

	// Token: 0x06000424 RID: 1060 RVA: 0x00024AF8 File Offset: 0x00022CF8
	private long method_202()
	{
		Class144 @class = this.method_218();
		int num = @class.vmethod_2();
		if (num <= 8)
		{
			if (num == 7)
			{
				return (long)((Class150)@class).method_2();
			}
			if (num == 8)
			{
				return (long)((Class162)@class).method_2().ToUInt64();
			}
		}
		else
		{
			if (num == 14)
			{
				return ((Class151)@class).method_2().ToInt64();
			}
			if (num == 24)
			{
				return Convert.ToInt64(((Class165)@class).method_2());
			}
		}
		throw new Exception(Class185.smethod_0(537698095));
	}

	// Token: 0x06000425 RID: 1061 RVA: 0x00004EC9 File Offset: 0x000030C9
	public void method_203(Stream stream_1, string string_0, object[] object_3)
	{
		this.method_232(stream_1, string_0, object_3);
	}

	// Token: 0x06000426 RID: 1062 RVA: 0x00024B8C File Offset: 0x00022D8C
	private void method_204(Class144 class144_2)
	{
		Class150 @class = (Class150)class144_2;
		MethodBase methodBase_ = this.method_157(@class.method_2());
		Class147 class2 = new Class147();
		class2.method_3(methodBase_);
		this.method_129(class2);
	}

	// Token: 0x06000427 RID: 1063 RVA: 0x00024BC0 File Offset: 0x00022DC0
	private void method_205(Class144 class144_2)
	{
		int int_ = ((Class150)class144_2).method_2();
		FieldInfo fieldInfo_ = this.method_122(int_);
		Class144 @class = this.method_218();
		Class152 class2 = @class as Class152;
		object obj;
		if (class2 != null)
		{
			obj = this.method_245(class2).vmethod_0();
		}
		else
		{
			obj = @class.vmethod_0();
		}
		this.method_129(new Class153(fieldInfo_, obj, class2));
	}

	// Token: 0x06000428 RID: 1064 RVA: 0x00024C18 File Offset: 0x00022E18
	private void method_206(Type type_9, object object_3, long long_1, Array array_0)
	{
		Class144 @class = Class104.smethod_1(object_3, type_9);
		array_0.SetValue(@class.vmethod_0(), long_1);
	}

	// Token: 0x06000429 RID: 1065 RVA: 0x00004ED5 File Offset: 0x000030D5
	private void method_207(Class144 class144_2)
	{
		Class150 @class = new Class150();
		@class.method_3(3);
		this.method_129(@class);
	}

	// Token: 0x0600042A RID: 1066 RVA: 0x00004EE9 File Offset: 0x000030E9
	private void method_208(Class144 class144_2)
	{
		Class150 @class = new Class150();
		@class.method_3(6);
		this.method_129(@class);
	}

	// Token: 0x0600042B RID: 1067 RVA: 0x00024C3C File Offset: 0x00022E3C
	private Class144 method_209(Class144 class144_2, Class144 class144_3)
	{
		if (class144_2.vmethod_2() == 7)
		{
			if (class144_3.vmethod_2() == 7)
			{
				int num = ((Class150)class144_2).method_2();
				int num2 = ((Class150)class144_3).method_2();
				Class150 @class = new Class150();
				@class.method_3(num | num2);
				return @class;
			}
			if (class144_3.vmethod_2() == 24)
			{
				int num3 = ((Class150)class144_2).method_2();
				Type underlyingType = Enum.GetUnderlyingType(class144_3.vmethod_0().GetType());
				if (underlyingType != typeof(long))
				{
					if (underlyingType != typeof(ulong))
					{
						int num4 = Convert.ToInt32(class144_3.vmethod_0());
						Class150 class2 = new Class150();
						class2.method_3(num3 | num4);
						return class2;
					}
				}
				long num5 = Convert.ToInt64(class144_3.vmethod_0());
				Class161 class3 = new Class161();
				class3.method_3((long)num3 | num5);
				return class3;
			}
		}
		if (class144_2.vmethod_2() == 11)
		{
			if (class144_3.vmethod_2() == 11)
			{
				long num6 = ((Class161)class144_2).method_2();
				long num7 = ((Class161)class144_3).method_2();
				Class161 class4 = new Class161();
				class4.method_3(num6 | num7);
				return class4;
			}
			if (class144_3.vmethod_2() == 24)
			{
				int num8 = ((Class150)class144_2).method_2();
				long num9 = Convert.ToInt64(class144_3.vmethod_0());
				Class161 class5 = new Class161();
				class5.method_3((long)num8 | num9);
				return class5;
			}
		}
		if (class144_2.vmethod_2() == 24)
		{
			if (class144_3.vmethod_2() == 7)
			{
				int num10 = ((Class150)class144_3).method_2();
				Type underlyingType2 = Enum.GetUnderlyingType(class144_2.vmethod_0().GetType());
				if (underlyingType2 != typeof(long))
				{
					if (underlyingType2 != typeof(ulong))
					{
						int num11 = Convert.ToInt32(class144_2.vmethod_0());
						Class150 class6 = new Class150();
						class6.method_3(num11 | num10);
						return class6;
					}
				}
				long num12 = Convert.ToInt64(class144_3.vmethod_0());
				Class161 class7 = new Class161();
				class7.method_3(num12 | (long)num10);
				return class7;
			}
			if (class144_3.vmethod_2() == 11)
			{
				long num13 = Convert.ToInt64(class144_2.vmethod_0());
				long num14 = ((Class161)class144_3).method_2();
				Class161 class8 = new Class161();
				class8.method_3(num13 | num14);
				return class8;
			}
			if (class144_3.vmethod_2() == 24)
			{
				Type underlyingType3 = Enum.GetUnderlyingType(class144_2.vmethod_0().GetType());
				Type underlyingType4 = Enum.GetUnderlyingType(class144_3.vmethod_0().GetType());
				if (underlyingType3 != typeof(long) && underlyingType3 != typeof(ulong) && underlyingType4 != typeof(long))
				{
					if (underlyingType4 != typeof(ulong))
					{
						int num15 = Convert.ToInt32(class144_2.vmethod_0());
						int num16 = Convert.ToInt32(class144_3.vmethod_0());
						Class150 class9 = new Class150();
						class9.method_3(num15 | num16);
						return class9;
					}
				}
				long num17 = Convert.ToInt64(class144_2.vmethod_0());
				long num18 = Convert.ToInt64(class144_3.vmethod_0());
				Class161 class10 = new Class161();
				class10.method_3(num17 | num18);
				return class10;
			}
		}
		throw new InvalidOperationException();
	}

	// Token: 0x0600042C RID: 1068 RVA: 0x00004EFD File Offset: 0x000030FD
	private void method_210(Class144 class144_2)
	{
		this.method_129(this.class144_1[2].vmethod_4());
	}

	// Token: 0x0600042D RID: 1069 RVA: 0x00024F04 File Offset: 0x00023104
	private void method_211(Class144 class144_2)
	{
		Class150 @class = (Class150)class144_2;
		MethodBase methodBase_ = this.method_157(@class.method_2());
		this.method_271(methodBase_, false);
	}

	// Token: 0x0600042E RID: 1070 RVA: 0x00024F30 File Offset: 0x00023130
	private void method_212(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		if (Class87.smethod_10(this.method_218(), class144_3))
		{
			uint uint_ = ((Class168)class144_2).method_2();
			this.method_275(uint_);
		}
	}

	// Token: 0x0600042F RID: 1071 RVA: 0x0000336F File Offset: 0x0000156F
	private void method_213(Class144 class144_2)
	{
	}

	// Token: 0x06000430 RID: 1072 RVA: 0x00024F68 File Offset: 0x00023168
	private void method_214(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		Class144 class144_4 = this.method_218();
		this.method_129(this.method_209(class144_4, class144_3));
	}

	// Token: 0x06000431 RID: 1073 RVA: 0x00024F94 File Offset: 0x00023194
	private Class144 method_215(Class144 class144_2, Class144 class144_3, bool bool_2)
	{
		if (class144_2.vmethod_2() == 7)
		{
			if (class144_3.vmethod_2() == 7)
			{
				if (!bool_2)
				{
					int num = ((Class150)class144_2).method_2();
					int num2 = ((Class150)class144_3).method_2();
					Class150 @class = new Class150();
					@class.method_3(num >> num2);
					return @class;
				}
				uint num3 = (uint)((Class150)class144_2).method_2();
				int num4 = ((Class150)class144_3).method_2();
				Class150 class2 = new Class150();
				class2.method_3((int)(num3 >> num4));
				return class2;
			}
			else if (class144_3.vmethod_2() == 24)
			{
				Class150 class3 = new Class150();
				class3.method_3(Convert.ToInt32(class144_3.vmethod_0()));
				return this.method_215(class144_2, class3, bool_2);
			}
		}
		if (class144_2.vmethod_2() == 11)
		{
			if (class144_3.vmethod_2() == 7)
			{
				if (!bool_2)
				{
					long num5 = ((Class161)class144_2).method_2();
					int num6 = ((Class150)class144_3).method_2();
					Class161 class4 = new Class161();
					class4.method_3(num5 >> num6);
					return class4;
				}
				ulong num7 = (ulong)((Class161)class144_2).method_2();
				int num8 = ((Class150)class144_3).method_2();
				Class161 class5 = new Class161();
				class5.method_3((long)(num7 >> num8));
				return class5;
			}
			else if (class144_3.vmethod_2() == 24)
			{
				Class150 class6 = new Class150();
				class6.method_3(Convert.ToInt32(class144_3.vmethod_0()));
				return this.method_215(class144_2, class6, bool_2);
			}
		}
		if (class144_2.vmethod_2() == 24)
		{
			Type underlyingType = Enum.GetUnderlyingType(class144_2.vmethod_0().GetType());
			if (underlyingType != typeof(long))
			{
				if (underlyingType != typeof(ulong))
				{
					Class150 class7 = new Class150();
					class7.method_3(Convert.ToInt32(class144_2.vmethod_0()));
					return this.method_215(class7, class144_3, bool_2);
				}
			}
			Class161 class8 = new Class161();
			class8.method_3(Convert.ToInt64(class144_2.vmethod_0()));
			return this.method_215(class8, class144_3, bool_2);
		}
		throw new InvalidOperationException();
	}

	// Token: 0x06000432 RID: 1074 RVA: 0x00025150 File Offset: 0x00023350
	private string method_216(int int_0)
	{
		Dictionary<int, object> obj = Class87.dictionary_1;
		string result;
		lock (obj)
		{
			bool flag = true;
			object obj2;
			if (Class87.dictionary_1.TryGetValue(int_0, out obj2))
			{
				result = (string)obj2;
			}
			else
			{
				Class45 @class = this.method_3(int_0);
				if (@class.method_0() == 1)
				{
					result = this.module_0.ResolveString(@class.method_2());
				}
				else
				{
					string text = ((Class130)@class.method_4()).method_0();
					if (flag)
					{
						Class87.dictionary_1.Add(int_0, text);
					}
					result = text;
				}
			}
		}
		return result;
	}

	// Token: 0x06000433 RID: 1075 RVA: 0x000251E8 File Offset: 0x000233E8
	private void method_217()
	{
		long num = this.class183_1.method_0().vmethod_3();
		while (!this.bool_0)
		{
			if (this.nullable_0 != null)
			{
				this.class183_1.method_0().vmethod_5((long)((ulong)this.nullable_0.Value));
				this.nullable_0 = null;
			}
			this.method_224();
			if (this.class183_1.method_0().vmethod_4() >= num && this.nullable_0 == null)
			{
				break;
			}
		}
	}

	// Token: 0x06000434 RID: 1076 RVA: 0x00004F16 File Offset: 0x00003116
	private Class144 method_218()
	{
		return this.class57_1.method_6();
	}

	// Token: 0x06000435 RID: 1077 RVA: 0x00004F23 File Offset: 0x00003123
	private object method_219(Stream stream_1, int int_0, object[] object_3, Type[] type_9, Type[] type_10, object[] object_4)
	{
		this.stream_0 = stream_1;
		this.method_295(stream_1, (long)int_0, null);
		return this.method_115(object_3, type_9, type_10, object_4);
	}

	// Token: 0x06000436 RID: 1078 RVA: 0x00004F43 File Offset: 0x00003143
	private void method_220(Class144 class144_2)
	{
		this.method_117(Class87.type_0);
	}

	// Token: 0x06000437 RID: 1079 RVA: 0x0002526C File Offset: 0x0002346C
	[DebuggerNonUserCode]
	private MethodBase method_221(int int_0, Class45 class45_0)
	{
		Dictionary<int, object> obj = Class87.dictionary_1;
		MethodBase result;
		lock (obj)
		{
			bool flag = true;
			object obj2;
			if (Class87.dictionary_1.TryGetValue(int_0, out obj2))
			{
				result = (MethodBase)obj2;
			}
			else if (class45_0.method_0() == 1)
			{
				MethodBase methodBase = this.module_0.ResolveMethod(class45_0.method_2());
				if (flag)
				{
					Class87.dictionary_1.Add(int_0, methodBase);
				}
				result = methodBase;
			}
			else
			{
				Class133 @class = (Class133)class45_0.method_4();
				if (@class.method_3())
				{
					result = this.method_239(@class);
				}
				else
				{
					Type type = this.method_136(@class.method_4().method_2(), false);
					Type type2 = this.method_136(@class.method_12().method_2(), true);
					Type[] array = new Type[@class.method_8().Length];
					for (int i = 0; i < array.Length; i++)
					{
						array[i] = this.method_136(@class.method_8()[i].method_2(), true);
					}
					if (type.IsGenericType)
					{
						flag = false;
					}
					if (@class.method_6() == Class185.smethod_0(537696660))
					{
						ConstructorInfo constructor = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, CallingConventions.Any, array, null);
						if (constructor == null)
						{
							throw new Exception();
						}
						if (flag)
						{
							Class87.dictionary_1.Add(int_0, constructor);
						}
						result = constructor;
					}
					else
					{
						BindingFlags bindingAttr = Class87.smethod_23(@class.method_2());
						MethodBase methodBase2 = null;
						try
						{
							methodBase2 = type.GetMethod(@class.method_6(), bindingAttr, null, CallingConventions.Any, array, null);
						}
						catch (AmbiguousMatchException)
						{
							foreach (MethodInfo methodInfo in type.GetMethods(bindingAttr))
							{
								if (!(methodInfo.Name != @class.method_6()) && methodInfo.ReturnType == type2)
								{
									ParameterInfo[] parameters = methodInfo.GetParameters();
									if (parameters.Length == array.Length)
									{
										bool flag2 = false;
										for (int k = 0; k < array.Length; k++)
										{
											if (parameters[k].ParameterType != array[k])
											{
												flag2 = true;
												break;
											}
										}
										if (!flag2)
										{
											methodBase2 = methodInfo;
											break;
										}
									}
								}
							}
						}
						if (methodBase2 == null)
						{
							throw new Exception(string.Format(Class185.smethod_0(537696640), type.Name, @class.method_6()));
						}
						if (flag)
						{
							Class87.dictionary_1.Add(int_0, methodBase2);
						}
						result = methodBase2;
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06000438 RID: 1080 RVA: 0x00004F50 File Offset: 0x00003150
	private void method_222(Class144 class144_2)
	{
		this.method_129(new Class171());
	}

	// Token: 0x06000439 RID: 1081 RVA: 0x00004A8A File Offset: 0x00002C8A
	private void method_223(Class144 class144_2)
	{
		this.method_252();
	}

	// Token: 0x0600043A RID: 1082 RVA: 0x000254F8 File Offset: 0x000236F8
	private void method_224()
	{
		try
		{
			this.method_291();
		}
		catch (object object_)
		{
			this.method_187(object_, 0u);
		}
	}

	// Token: 0x0600043B RID: 1083 RVA: 0x00025528 File Offset: 0x00023728
	private void method_225(Class144 class144_2)
	{
		Class144 @class = this.method_218();
		int num = @class.vmethod_2();
		checked
		{
			short int_;
			if (num <= 11)
			{
				if (num == 7)
				{
					int_ = (short)((uint)((Class150)@class).method_2());
					goto IL_6F;
				}
				if (num == 11)
				{
					int_ = (short)((ulong)((Class161)@class).method_2());
					goto IL_6F;
				}
			}
			else
			{
				if (num == 17)
				{
					int_ = (short)((Class163)@class).method_2();
					goto IL_6F;
				}
				if (num == 24)
				{
					int_ = (short)Convert.ToUInt64(((Class165)@class).method_2());
					goto IL_6F;
				}
			}
			throw new InvalidOperationException();
			IL_6F:
			Class150 class2 = new Class150();
			class2.method_3((int)int_);
			this.method_129(class2);
		}
	}

	// Token: 0x0600043C RID: 1084 RVA: 0x000255B8 File Offset: 0x000237B8
	private void method_226(Class144 class144_2)
	{
		int int_ = ((Class150)class144_2).method_2();
		Type type_ = this.method_136(int_, true);
		this.method_117(type_);
	}

	// Token: 0x0600043D RID: 1085 RVA: 0x00004F5D File Offset: 0x0000315D
	private void method_227(Class144 class144_2)
	{
		this.method_129(this.class144_1[0].vmethod_4());
	}

	// Token: 0x0600043E RID: 1086 RVA: 0x00004F76 File Offset: 0x00003176
	private void method_228(Class144 class144_2)
	{
		this.method_117(typeof(uint));
	}

	// Token: 0x0600043F RID: 1087 RVA: 0x00004F88 File Offset: 0x00003188
	private void method_229(Class144 class144_2)
	{
		this.method_92(true);
	}

	// Token: 0x06000440 RID: 1088 RVA: 0x000255E4 File Offset: 0x000237E4
	private Class99[] method_230(Class183 class183_2)
	{
		Class99[] array = new Class99[(int)class183_2.method_23()];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = this.method_290(class183_2);
		}
		return array;
	}

	// Token: 0x06000441 RID: 1089 RVA: 0x0002561C File Offset: 0x0002381C
	private Class144 method_231(Class183 class183_2, int int_0)
	{
		switch (int_0)
		{
		case 0:
		case 8:
		{
			Class164 @class = new Class164();
			@class.method_3(class183_2.method_24());
			return @class;
		}
		case 1:
		{
			int num = class183_2.method_19();
			Class150[] array = new Class150[num];
			for (int i = 0; i < num; i++)
			{
				Class150[] array2 = array;
				int num2 = i;
				Class150 class2 = new Class150();
				class2.method_3(class183_2.method_19());
				array2[num2] = class2;
			}
			Class145 class3 = new Class145();
			class3.method_3(array);
			return class3;
		}
		case 2:
		case 11:
		{
			Class150 class4 = new Class150();
			class4.method_3(class183_2.method_19());
			return class4;
		}
		case 3:
		case 4:
		{
			Class169 class5 = new Class169();
			class5.method_3(class183_2.method_6());
			return class5;
		}
		case 5:
		{
			Class167 class6 = new Class167();
			class6.method_3(class183_2.method_26());
			return class6;
		}
		case 6:
		{
			Class163 class7 = new Class163();
			class7.method_3(class183_2.method_27());
			return class7;
		}
		case 7:
		{
			Class161 class8 = new Class161();
			class8.method_3(class183_2.method_21());
			return class8;
		}
		case 9:
		{
			Class168 class9 = new Class168();
			class9.method_3(class183_2.method_20());
			return class9;
		}
		case 10:
			return null;
		case 12:
		{
			Class166 class10 = new Class166();
			class10.method_3(class183_2.method_7());
			return class10;
		}
		default:
			throw new Exception(Class185.smethod_0(537696636));
		}
	}

	// Token: 0x06000442 RID: 1090 RVA: 0x00004F91 File Offset: 0x00003191
	public object method_232(Stream stream_1, string string_0, object[] object_3)
	{
		return this.method_94(stream_1, string_0, object_3, null, null, null);
	}

	// Token: 0x06000443 RID: 1091 RVA: 0x0000336F File Offset: 0x0000156F
	private void method_233(Class183 class183_2)
	{
	}

	// Token: 0x06000444 RID: 1092 RVA: 0x00025740 File Offset: 0x00023940
	private void method_234(Class144 class144_2)
	{
		object object_ = this.method_218().vmethod_0();
		long num = this.method_202();
		Array array = (Array)this.method_218().vmethod_0();
		Type elementType = array.GetType().GetElementType();
		checked
		{
			if (elementType == typeof(sbyte))
			{
				Class144 @class = Class104.smethod_1(object_, typeof(sbyte));
				((sbyte[])array)[(int)((IntPtr)num)] = (sbyte)@class.vmethod_0();
				return;
			}
			if (elementType == typeof(byte))
			{
				Class144 class2 = Class104.smethod_1(object_, typeof(byte));
				((byte[])array)[(int)((IntPtr)num)] = (byte)class2.vmethod_0();
				return;
			}
			if (elementType == typeof(bool))
			{
				Class144 class3 = Class104.smethod_1(object_, typeof(bool));
				((bool[])array)[(int)((IntPtr)num)] = (bool)class3.vmethod_0();
				return;
			}
			if (elementType.IsEnum)
			{
				this.method_206(elementType, object_, num, array);
				return;
			}
			this.method_206(typeof(sbyte), object_, num, array);
		}
	}

	// Token: 0x06000445 RID: 1093 RVA: 0x00025844 File Offset: 0x00023A44
	public static void smethod_22<T>(T[] gparam_0, Comparison<T> comparison_0)
	{
		KeyValuePair<int, T>[] array = new KeyValuePair<int, T>[gparam_0.Length];
		for (int i = 0; i < gparam_0.Length; i++)
		{
			array[i] = new KeyValuePair<int, T>(i, gparam_0[i]);
		}
		Array.Sort<KeyValuePair<int, T>, T>(array, gparam_0, new Class87.Class89<T>(comparison_0));
	}

	// Token: 0x06000446 RID: 1094 RVA: 0x00004F9F File Offset: 0x0000319F
	private bool method_235(long long_1, uint uint_0, uint uint_1)
	{
		return long_1 >= (long)((ulong)uint_0) && long_1 <= (long)((ulong)(uint_0 + uint_1));
	}

	// Token: 0x06000447 RID: 1095 RVA: 0x0002588C File Offset: 0x00023A8C
	private void method_236(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		if (Class87.smethod_14(this.method_218(), class144_3))
		{
			uint uint_ = ((Class168)class144_2).method_2();
			this.method_275(uint_);
		}
	}

	// Token: 0x06000448 RID: 1096 RVA: 0x000258C4 File Offset: 0x00023AC4
	private void method_237(Class67 class67_1)
	{
		if (Class87.smethod_8() && !this.class67_0.method_13() && class67_1.method_13() && !class67_1.method_14())
		{
			string string_ = this.method_48(class67_1);
			throw Class87.smethod_30(this.method_48(this.class67_0), string_);
		}
	}

	// Token: 0x06000449 RID: 1097 RVA: 0x00004FB2 File Offset: 0x000031B2
	private int method_238()
	{
		return 1271864378;
	}

	// Token: 0x0600044A RID: 1098 RVA: 0x00025910 File Offset: 0x00023B10
	private MethodBase method_239(Class133 class133_0)
	{
		Type type = this.method_136(class133_0.method_4().method_2(), false);
		BindingFlags bindingAttr = Class87.smethod_23(class133_0.method_2());
		MemberInfo[] member = type.GetMember(class133_0.method_6(), bindingAttr);
		MethodInfo methodInfo = null;
		foreach (MethodInfo methodInfo2 in member)
		{
			if (methodInfo2.IsGenericMethodDefinition)
			{
				ParameterInfo[] parameters = methodInfo2.GetParameters();
				if (parameters.Length == class133_0.method_8().Length && methodInfo2.GetGenericArguments().Length == class133_0.method_10().Length && this.method_250(methodInfo2.ReturnType, class133_0.method_12()))
				{
					bool flag = true;
					int j = 0;
					while (j < parameters.Length)
					{
						if (this.method_250(parameters[j].ParameterType, class133_0.method_8()[j]))
						{
							j++;
						}
						else
						{
							flag = false;
							IL_C6:
							if (!flag)
							{
								goto IL_CA;
							}
							methodInfo = methodInfo2;
							goto IL_DD;
						}
					}
					goto IL_C6;
					IL_DD:
					if (methodInfo == null)
					{
						throw new Exception(string.Format(Class185.smethod_0(537696640), type.Name, class133_0.method_6()));
					}
					Type[] array2 = new Type[class133_0.method_10().Length];
					for (int k = 0; k < array2.Length; k++)
					{
						array2[k] = this.method_136(class133_0.method_10()[k].method_2(), true);
					}
					return methodInfo.MakeGenericMethod(array2);
				}
			}
			IL_CA:;
		}
		goto IL_DD;
	}

	// Token: 0x0600044B RID: 1099 RVA: 0x00025A68 File Offset: 0x00023C68
	private void method_240(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		Class144 class144_4 = this.method_218();
		this.method_129(this.method_215(class144_4, class144_3, true));
	}

	// Token: 0x0600044C RID: 1100 RVA: 0x00004FB9 File Offset: 0x000031B9
	private void method_241(Class144 class144_2)
	{
		if (this.object_0 == null)
		{
			throw new InvalidOperationException();
		}
		this.method_43(this.object_0);
	}

	// Token: 0x0600044D RID: 1101 RVA: 0x00025A94 File Offset: 0x00023C94
	private void method_242(Class144 class144_2)
	{
		int int_ = ((Class150)class144_2).method_2();
		Type type_ = this.method_136(int_, true);
		this.method_75(type_);
	}

	// Token: 0x0600044E RID: 1102 RVA: 0x00004FD5 File Offset: 0x000031D5
	private void method_243(Class144 class144_2)
	{
		this.method_41(true);
	}

	// Token: 0x0600044F RID: 1103 RVA: 0x00025AC0 File Offset: 0x00023CC0
	private void method_244()
	{
		try
		{
			this.method_217();
		}
		catch (Exception object_)
		{
			this.method_187(object_, 0u);
			this.method_217();
		}
	}

	// Token: 0x06000450 RID: 1104 RVA: 0x00025AF8 File Offset: 0x00023CF8
	private static BindingFlags smethod_23(bool bool_2)
	{
		BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.NonPublic;
		if (bool_2)
		{
			bindingFlags |= BindingFlags.Static;
		}
		else
		{
			bindingFlags |= BindingFlags.Instance;
		}
		return bindingFlags;
	}

	// Token: 0x06000451 RID: 1105 RVA: 0x00025B18 File Offset: 0x00023D18
	private Class144 method_245(Class152 class152_0)
	{
		int num = class152_0.vmethod_2();
		if (num != 3)
		{
			switch (num)
			{
			case 12:
				return ((Class155)class152_0).method_2();
			case 13:
				return this.class144_1[((Class154)class152_0).method_2()];
			case 16:
				goto IL_7A;
			case 18:
			{
				Class153 @class = (Class153)class152_0;
				return Class104.smethod_1(@class.method_4().GetValue(@class.method_2()), null);
			}
			}
			throw new ArgumentOutOfRangeException();
		}
		IL_7A:
		Class156 class2 = (Class156)class152_0;
		return Class104.smethod_1(class2.vmethod_5(), class2.method_2());
	}

	// Token: 0x06000452 RID: 1106 RVA: 0x00025BB8 File Offset: 0x00023DB8
	private void method_246(Class144 class144_2)
	{
		int int_ = ((Class150)class144_2).method_2();
		Type type = this.method_136(int_, true);
		Class152 @class = (Class152)this.method_218();
		if (!type.IsValueType)
		{
			this.method_105(@class, new Class171());
			return;
		}
		object obj = this.method_245(@class).vmethod_0();
		if (Class28.smethod_0(type))
		{
			Class152 class152_ = @class;
			Class171 class2 = new Class171();
			class2.method_1(type);
			this.method_105(class152_, class2);
			return;
		}
		foreach (FieldInfo fieldInfo in type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy))
		{
			fieldInfo.SetValue(obj, Class87.smethod_24(fieldInfo.FieldType));
		}
	}

	// Token: 0x06000453 RID: 1107 RVA: 0x00004FDE File Offset: 0x000031DE
	private void method_247(Class144 class144_2)
	{
		this.method_287(2);
	}

	// Token: 0x06000454 RID: 1108 RVA: 0x00025C5C File Offset: 0x00023E5C
	private void method_248(Class144 class144_2)
	{
		Class144 @class = this.method_218();
		int num = @class.vmethod_2();
		bool flag;
		if (num <= 11)
		{
			switch (num)
			{
			case 4:
				flag = (((Class171)@class).method_2() != null);
				goto IL_CA;
			case 5:
			case 6:
				break;
			case 7:
				flag = (((Class150)@class).method_2() != 0);
				goto IL_CA;
			case 8:
				flag = (((Class162)@class).method_2() != UIntPtr.Zero);
				goto IL_CA;
			default:
				if (num == 11)
				{
					flag = (((Class161)@class).method_2() != 0L);
					goto IL_CA;
				}
				break;
			}
		}
		else
		{
			if (num == 14)
			{
				flag = (((Class151)@class).method_2() != IntPtr.Zero);
				goto IL_CA;
			}
			if (num == 24)
			{
				flag = Convert.ToBoolean(((Class165)@class).method_2());
				goto IL_CA;
			}
		}
		flag = (@class.vmethod_0() != null);
		IL_CA:
		if (flag)
		{
			uint uint_ = ((Class168)class144_2).method_2();
			this.method_275(uint_);
		}
	}

	// Token: 0x06000455 RID: 1109 RVA: 0x00004FE7 File Offset: 0x000031E7
	private void method_249(Class144 class144_2)
	{
		this.method_117(typeof(byte));
	}

	// Token: 0x06000456 RID: 1110 RVA: 0x00025D4C File Offset: 0x00023F4C
	private bool method_250(Type type_9, Class45 class45_0)
	{
		Class132 @class = (Class132)class45_0.method_4();
		if (Class107.smethod_0(type_9).IsGenericParameter)
		{
			return @class == null || @class.method_2();
		}
		Type type = this.method_136(class45_0.method_2(), false);
		return Class86.smethod_0(type_9, type);
	}

	// Token: 0x06000457 RID: 1111 RVA: 0x00004FF9 File Offset: 0x000031F9
	private void method_251(Class144 class144_2)
	{
		this.method_117(typeof(short));
	}

	// Token: 0x06000458 RID: 1112 RVA: 0x00025D9C File Offset: 0x00023F9C
	private void method_252()
	{
		Class144 class144_ = this.method_218();
		Class152 class152_ = (Class152)this.method_218();
		this.method_105(class152_, class144_);
	}

	// Token: 0x06000459 RID: 1113 RVA: 0x0000500B File Offset: 0x0000320B
	public static object smethod_24(Type type_9)
	{
		if (type_9.IsValueType)
		{
			return Activator.CreateInstance(type_9);
		}
		return null;
	}

	// Token: 0x0600045A RID: 1114 RVA: 0x0000501D File Offset: 0x0000321D
	private void method_253(Class144 class144_2)
	{
		this.method_117(typeof(long));
	}

	// Token: 0x0600045B RID: 1115 RVA: 0x0000502F File Offset: 0x0000322F
	private void method_254(Class144 class144_2)
	{
		throw new NotSupportedException(Class185.smethod_0(537696524));
	}

	// Token: 0x0600045C RID: 1116 RVA: 0x00025DC4 File Offset: 0x00023FC4
	private void method_255(Class144 class144_2)
	{
		Class144 @class = this.method_218();
		int num = @class.vmethod_2();
		uint num2;
		if (num != 7)
		{
			if (num != 11)
			{
				if (num != 24)
				{
					throw new InvalidOperationException();
				}
				num2 = (uint)Convert.ToInt64(@class.vmethod_0());
			}
			else
			{
				num2 = (uint)((Class161)@class).method_2();
			}
		}
		else
		{
			num2 = (uint)((Class150)@class).method_2();
		}
		Class150[] array = (Class150[])((Class145)class144_2).method_2();
		if ((ulong)num2 >= (ulong)((long)array.Length))
		{
			return;
		}
		uint uint_ = (uint)array[(int)num2].method_2();
		this.method_275(uint_);
	}

	// Token: 0x0600045D RID: 1117 RVA: 0x00005040 File Offset: 0x00003240
	private void method_256(Class144 class144_2)
	{
		this.method_41(false);
	}

	// Token: 0x0600045E RID: 1118 RVA: 0x00005049 File Offset: 0x00003249
	private static Exception smethod_25(string string_0, string string_1)
	{
		return new TypeLoadException(Class87.smethod_3(string.Format(Class185.smethod_0(537696485), string_0), string.Format(Class185.smethod_0(537696317), string_1)));
	}

	// Token: 0x0600045F RID: 1119 RVA: 0x00005075 File Offset: 0x00003275
	private void method_257(Class144 class144_2)
	{
		Class150 @class = new Class150();
		@class.method_3(4);
		this.method_129(@class);
	}

	// Token: 0x06000460 RID: 1120 RVA: 0x00004A8A File Offset: 0x00002C8A
	private void method_258(Class144 class144_2)
	{
		this.method_252();
	}

	// Token: 0x06000461 RID: 1121 RVA: 0x00025E50 File Offset: 0x00024050
	private bool method_259(MethodBase methodBase_0, object object_3, Class144[] class144_2, object[] object_4, bool bool_2, ref object object_5)
	{
		Type declaringType = methodBase_0.DeclaringType;
		if (declaringType == null)
		{
			return false;
		}
		if (declaringType == Class87.type_4 && methodBase_0.Name == Class185.smethod_0(537696408) && object_4.Length == 2)
		{
			string a = methodBase_0.ToString();
			if (a == Class185.smethod_0(537696398))
			{
				Class61.smethod_0((Array)object_4[0], (RuntimeFieldHandle)object_4[1]);
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000462 RID: 1122 RVA: 0x00025EC4 File Offset: 0x000240C4
	private void method_260(Class144 class144_2)
	{
		Class144 @class = this.method_218();
		int num = @class.vmethod_2();
		ulong long_;
		if (num <= 11)
		{
			if (num == 7)
			{
				long_ = (ulong)(checked((uint)((Class150)@class).method_2()));
				goto IL_6D;
			}
			if (num == 11)
			{
				long_ = checked((ulong)((Class161)@class).method_2());
				goto IL_6D;
			}
		}
		else
		{
			if (num == 17)
			{
				long_ = checked((ulong)((Class163)@class).method_2());
				goto IL_6D;
			}
			if (num == 24)
			{
				long_ = Convert.ToUInt64(((Class165)@class).method_2());
				goto IL_6D;
			}
		}
		throw new InvalidOperationException();
		IL_6D:
		Class161 class2 = new Class161();
		class2.method_3((long)long_);
		this.method_129(class2);
	}

	// Token: 0x06000463 RID: 1123 RVA: 0x00025F50 File Offset: 0x00024150
	private void method_261(bool bool_2)
	{
		Class144 @class = this.method_218();
		int num = @class.vmethod_2();
		long long_;
		if (num <= 11)
		{
			if (num != 7)
			{
				if (num == 11)
				{
					if (bool_2)
					{
						long_ = ((Class161)@class).method_2();
						goto IL_BA;
					}
					long_ = ((Class161)@class).method_2();
					goto IL_BA;
				}
			}
			else
			{
				if (bool_2)
				{
					long_ = (long)((Class150)@class).method_2();
					goto IL_BA;
				}
				long_ = (long)((Class150)@class).method_2();
				goto IL_BA;
			}
		}
		else if (num != 17)
		{
			if (num == 24)
			{
				if (bool_2)
				{
					long_ = checked((long)Convert.ToUInt64(((Class165)@class).method_2()));
					goto IL_BA;
				}
				long_ = (long)Convert.ToUInt64(((Class165)@class).method_2());
				goto IL_BA;
			}
		}
		else
		{
			if (bool_2)
			{
				long_ = checked((long)((Class163)@class).method_2());
				goto IL_BA;
			}
			long_ = (long)((Class163)@class).method_2();
			goto IL_BA;
		}
		throw new InvalidOperationException();
		IL_BA:
		Class161 class2 = new Class161();
		class2.method_3(long_);
		this.method_129(class2);
	}

	// Token: 0x06000464 RID: 1124 RVA: 0x00005089 File Offset: 0x00003289
	private void method_262(Class144 class144_2)
	{
		Class150 @class = new Class150();
		@class.method_3(0);
		this.method_129(@class);
	}

	// Token: 0x06000465 RID: 1125 RVA: 0x0000509D File Offset: 0x0000329D
	private void method_263()
	{
		this.bool_0 = true;
	}

	// Token: 0x06000466 RID: 1126 RVA: 0x0002602C File Offset: 0x0002422C
	private void method_264(Class144 class144_2)
	{
		object object_ = this.method_218().vmethod_0();
		long num = this.method_202();
		Array array = (Array)this.method_218().vmethod_0();
		Type elementType = array.GetType().GetElementType();
		checked
		{
			if (elementType == typeof(int))
			{
				Class144 @class = Class104.smethod_1(object_, typeof(int));
				((int[])array)[(int)((IntPtr)num)] = (int)@class.vmethod_0();
				return;
			}
			if (elementType == typeof(uint))
			{
				Class144 class2 = Class104.smethod_1(object_, typeof(uint));
				((uint[])array)[(int)((IntPtr)num)] = (uint)class2.vmethod_0();
				return;
			}
			if (elementType.IsEnum)
			{
				this.method_206(elementType, object_, num, array);
				return;
			}
			this.method_206(typeof(int), object_, num, array);
		}
	}

	// Token: 0x06000467 RID: 1127 RVA: 0x000050A6 File Offset: 0x000032A6
	private void method_265(Class144 class144_2)
	{
		this.method_129(this.class144_1[3].vmethod_4());
	}

	// Token: 0x06000468 RID: 1128 RVA: 0x000050BF File Offset: 0x000032BF
	private static void smethod_26(Exception exception_0)
	{
		ExceptionDispatchInfo.Capture(exception_0).Throw();
	}

	// Token: 0x06000469 RID: 1129 RVA: 0x000260FC File Offset: 0x000242FC
	private object method_266(MethodBase methodBase_0, object object_3, object[] object_4, bool bool_2)
	{
		Class87.Struct37 struct37_ = new Class87.Struct37(methodBase_0, bool_2);
		Class87.Delegate1 @delegate = this.method_88(struct37_);
		if (@delegate == null)
		{
			Dictionary<MethodBase, int> obj = this.dictionary_2;
			bool flag;
			lock (obj)
			{
				int num;
				this.dictionary_2.TryGetValue(methodBase_0, out num);
				if (!(flag = (num >= 50)))
				{
					this.dictionary_2[methodBase_0] = num + 1;
				}
			}
			if (!(flag = (flag || (!bool_2 && object_3 == null && !methodBase_0.IsStatic && !methodBase_0.IsConstructor) || Class87.smethod_19(methodBase_0) || (methodBase_0.CallingConvention & CallingConventions.Any) == CallingConventions.VarArgs)))
			{
				return this.method_199(methodBase_0, object_3, object_4);
			}
			@delegate = this.method_101(struct37_);
			obj = this.dictionary_2;
			lock (obj)
			{
				this.dictionary_2.Remove(methodBase_0);
			}
		}
		return @delegate(object_3, object_4);
	}

	// Token: 0x0600046A RID: 1130 RVA: 0x000261F0 File Offset: 0x000243F0
	private static bool smethod_27(Class144 class144_2, Class144 class144_3)
	{
		bool result = false;
		switch (class144_2.vmethod_2())
		{
		case 3:
		case 16:
		{
			Class156 @class = (Class156)class144_2;
			Class156 class156_ = (Class156)class144_3;
			return @class.vmethod_7(class156_);
		}
		case 4:
			return class144_2.vmethod_0() == class144_3.vmethod_0();
		case 7:
			if (class144_3.vmethod_2() == 24)
			{
				return (long)((Class150)class144_2).method_2() == Convert.ToInt64(((Class165)class144_3).method_2());
			}
			if (class144_3.vmethod_2() == 4 && class144_3.vmethod_0() == null)
			{
				return ((Class150)class144_2).method_2() == 0;
			}
			return ((Class150)class144_2).method_2() == ((Class150)class144_3).method_2();
		case 8:
			if (class144_3.vmethod_2() == 4 && class144_3.vmethod_0() == null)
			{
				return ((Class162)class144_2).method_2() == UIntPtr.Zero;
			}
			if (class144_3.vmethod_2() == 7)
			{
				return ((Class162)class144_2).method_2() == new UIntPtr((uint)((Class150)class144_3).method_2());
			}
			if (class144_3.vmethod_2() == 11)
			{
				return ((Class162)class144_2).method_2() == new UIntPtr((ulong)((Class161)class144_3).method_2());
			}
			return ((Class162)class144_2).method_2() == ((Class162)class144_3).method_2();
		case 11:
			if (class144_3.vmethod_2() == 24)
			{
				return ((Class161)class144_2).method_2() == Convert.ToInt64(((Class165)class144_3).method_2());
			}
			if (class144_3.vmethod_2() == 4 && class144_3.vmethod_0() == null)
			{
				return ((Class161)class144_2).method_2() == 0L;
			}
			return ((Class161)class144_2).method_2() == ((Class161)class144_3).method_2();
		case 12:
		{
			Class155 class2 = (Class155)class144_2;
			Class155 class3 = (Class155)class144_3;
			return Class87.smethod_27(class2.method_2(), class3.method_2());
		}
		case 13:
		{
			Class154 class4 = (Class154)class144_2;
			Class154 class5 = (Class154)class144_3;
			return class4.method_2() == class5.method_2();
		}
		case 14:
			if (class144_3.vmethod_2() == 4 && class144_3.vmethod_0() == null)
			{
				return ((Class151)class144_2).method_2() == IntPtr.Zero;
			}
			if (class144_3.vmethod_2() == 7)
			{
				return ((Class151)class144_2).method_2() == new IntPtr(((Class150)class144_3).method_2());
			}
			if (class144_3.vmethod_2() == 11)
			{
				return ((Class151)class144_2).method_2() == new IntPtr(((Class161)class144_3).method_2());
			}
			return ((Class151)class144_2).method_2() == ((Class151)class144_3).method_2();
		case 17:
		{
			double d = ((Class163)class144_2).method_2();
			double num = ((Class163)class144_3).method_2();
			return !double.IsNaN(d) && !double.IsNaN(num) && d.Equals(num);
		}
		case 18:
		{
			Class153 class6 = (Class153)class144_2;
			Class153 class7 = (Class153)class144_3;
			return class6.method_2() == class7.method_2() && class6.method_4() == class7.method_4();
		}
		case 20:
			return (class144_3.vmethod_2() != 4 || class144_3.vmethod_0() != null) && ((Class159)class144_2).method_2() == ((Class159)class144_3).method_2();
		case 24:
		{
			Class165 class8 = (Class165)class144_2;
			if (class144_3.vmethod_2() == 24)
			{
				return Convert.ToInt64(class8.method_2()) == Convert.ToInt64(((Class165)class144_3).method_2());
			}
			if (class8.method_2() == null)
			{
				return class144_3.vmethod_0() == null;
			}
			if (class144_3.vmethod_0() != null)
			{
				return Convert.ToInt64(class8.method_2()) == Convert.ToInt64(class144_3.vmethod_0());
			}
			return result;
		}
		}
		result = (class144_2.vmethod_0() == class144_3.vmethod_0());
		return result;
	}

	// Token: 0x0600046B RID: 1131 RVA: 0x00026644 File Offset: 0x00024844
	private void method_267(Class144 class144_2)
	{
		Class144 @class = this.method_218();
		int num = @class.vmethod_2();
		checked
		{
			byte int_;
			if (num <= 11)
			{
				if (num == 7)
				{
					int_ = (byte)((uint)((Class150)@class).method_2());
					goto IL_6F;
				}
				if (num == 11)
				{
					int_ = (byte)((ulong)((Class161)@class).method_2());
					goto IL_6F;
				}
			}
			else
			{
				if (num == 17)
				{
					int_ = (byte)((Class163)@class).method_2();
					goto IL_6F;
				}
				if (num == 24)
				{
					int_ = (byte)Convert.ToUInt64(((Class165)@class).method_2());
					goto IL_6F;
				}
			}
			throw new InvalidOperationException();
			IL_6F:
			Class150 class2 = new Class150();
			class2.method_3((int)int_);
			this.method_129(class2);
		}
	}

	// Token: 0x0600046C RID: 1132 RVA: 0x000266D4 File Offset: 0x000248D4
	private void method_268(Class144 class144_2)
	{
		uint uint_ = ((Class168)class144_2).method_2();
		this.method_275(uint_);
	}

	// Token: 0x0600046D RID: 1133 RVA: 0x000266F4 File Offset: 0x000248F4
	private void method_269(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		Class144 class144_4 = this.method_218();
		this.method_129(this.method_272(class144_4, class144_3));
	}

	// Token: 0x0600046E RID: 1134 RVA: 0x000050CC File Offset: 0x000032CC
	private void method_270(Class144 class144_2)
	{
		this.method_287(0);
	}

	// Token: 0x0600046F RID: 1135 RVA: 0x00026720 File Offset: 0x00024920
	private void method_271(MethodBase methodBase_0, bool bool_2)
	{
		if (!bool_2 && this.method_74(methodBase_0))
		{
			methodBase_0 = this.method_154(methodBase_0, bool_2);
		}
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		int num = parameters.Length;
		Class144[] array = new Class144[num];
		object[] array2 = new object[num];
		Class87.Struct38 @struct = default(Class87.Struct38);
		try
		{
			this.method_102(ref @struct, methodBase_0, bool_2);
			for (int i = num - 1; i >= 0; i--)
			{
				Class144 @class = this.method_218();
				array[i] = @class;
				Class152 class152_;
				if ((class152_ = (@class as Class152)) != null)
				{
					@class = this.method_245(class152_);
				}
				if (@class.method_0() != null)
				{
					@class = Class104.smethod_1(null, @class.method_0()).vmethod_3(@class);
				}
				Class144 class2 = Class104.smethod_1(null, parameters[i].ParameterType).vmethod_3(@class);
				array2[i] = class2.vmethod_0();
			}
			Class144 class3 = null;
			if (!methodBase_0.IsStatic)
			{
				class3 = this.method_218();
				if (class3 != null && class3.method_0() != null)
				{
					class3 = Class104.smethod_1(null, class3.method_0()).vmethod_3(class3);
				}
			}
			object obj = null;
			try
			{
				Class152 class4;
				if (methodBase_0.IsConstructor)
				{
					obj = Activator.CreateInstance(methodBase_0.DeclaringType, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, array2, null);
					class4 = (class3 as Class152);
					if (class4 == null)
					{
						throw new InvalidOperationException();
					}
				}
				else
				{
					object obj2 = null;
					if (class3 != null)
					{
						Class144 class5 = class3;
						Class152 class152_2;
						if ((class152_2 = (class3 as Class152)) != null)
						{
							class5 = this.method_245(class152_2);
						}
						obj2 = class5.vmethod_0();
					}
					try
					{
						if (!this.method_284(methodBase_0, obj2, ref obj, array2))
						{
							if (bool_2 && !methodBase_0.IsStatic && obj2 == null)
							{
								throw new NullReferenceException();
							}
							if (!this.method_259(methodBase_0, obj2, array, array2, bool_2, ref obj))
							{
								obj = this.method_266(methodBase_0, obj2, array2, bool_2);
							}
						}
						Class152 class152_3;
						if ((class152_3 = (class3 as Class152)) != null)
						{
							this.method_105(class152_3, Class104.smethod_1(obj2, methodBase_0.DeclaringType));
						}
						goto IL_217;
					}
					catch (TargetInvocationException ex)
					{
						Exception object_ = ex.InnerException ?? ex;
						this.method_43(object_);
						goto IL_217;
					}
				}
				this.method_105(class4, Class104.smethod_1(obj, methodBase_0.DeclaringType));
			}
			finally
			{
				for (int j = 0; j < array.Length; j++)
				{
					Class152 class152_4;
					if ((class152_4 = (array[j] as Class152)) != null)
					{
						object obj3 = array2[j];
						this.method_105(class152_4, Class104.smethod_1(obj3, null));
					}
				}
			}
			IL_217:
			MethodInfo methodInfo = methodBase_0 as MethodInfo;
			if (methodInfo != null)
			{
				Type returnType = methodInfo.ReturnType;
				if (returnType != Class87.type_2)
				{
					this.method_129(Class104.smethod_1(obj, returnType));
				}
			}
		}
		finally
		{
			this.method_37(ref @struct);
		}
	}

	// Token: 0x06000470 RID: 1136 RVA: 0x000269C8 File Offset: 0x00024BC8
	private Class144 method_272(Class144 class144_2, Class144 class144_3)
	{
		if (class144_2.vmethod_2() == 7)
		{
			if (class144_3.vmethod_2() == 7)
			{
				int num = ((Class150)class144_2).method_2();
				int num2 = ((Class150)class144_3).method_2();
				int int_ = num << num2;
				Class150 @class = new Class150();
				@class.method_3(int_);
				return @class;
			}
			if (class144_3.vmethod_2() == 24)
			{
				Class150 class2 = new Class150();
				class2.method_3(Convert.ToInt32(class144_3.vmethod_0()));
				return this.method_272(class144_2, class2);
			}
		}
		if (class144_2.vmethod_2() == 11)
		{
			if (class144_3.vmethod_2() == 7)
			{
				long num3 = ((Class161)class144_2).method_2();
				int num4 = ((Class150)class144_3).method_2();
				long long_ = num3 << num4;
				Class161 class3 = new Class161();
				class3.method_3(long_);
				return class3;
			}
			if (class144_3.vmethod_2() == 24)
			{
				Class150 class4 = new Class150();
				class4.method_3(Convert.ToInt32(class144_3.vmethod_0()));
				return this.method_272(class144_2, class4);
			}
		}
		if (class144_2.vmethod_2() == 24)
		{
			Type underlyingType = Enum.GetUnderlyingType(class144_2.vmethod_0().GetType());
			if (underlyingType != typeof(long))
			{
				if (underlyingType != typeof(ulong))
				{
					Class150 class5 = new Class150();
					class5.method_3(Convert.ToInt32(class144_2.vmethod_0()));
					return this.method_272(class5, class144_3);
				}
			}
			Class161 class6 = new Class161();
			class6.method_3(Convert.ToInt64(class144_2.vmethod_0()));
			return this.method_272(class6, class144_3);
		}
		throw new InvalidOperationException();
	}

	// Token: 0x06000471 RID: 1137 RVA: 0x00026B18 File Offset: 0x00024D18
	private void method_273(Class144 class144_2)
	{
		Class144 @class = this.method_218();
		int num = @class.vmethod_2();
		checked
		{
			long long_;
			if (num <= 11)
			{
				if (num == 7)
				{
					long_ = (long)(unchecked((ulong)(checked((uint)((Class150)@class).method_2()))));
					goto IL_6F;
				}
				if (num == 11)
				{
					long_ = (long)((ulong)((Class161)@class).method_2());
					goto IL_6F;
				}
			}
			else
			{
				if (num == 17)
				{
					long_ = (long)((Class163)@class).method_2();
					goto IL_6F;
				}
				if (num == 24)
				{
					long_ = (long)Convert.ToUInt64(((Class165)@class).method_2());
					goto IL_6F;
				}
			}
			throw new InvalidOperationException();
			IL_6F:
			Class161 class2 = new Class161();
			class2.method_3(long_);
			this.method_129(class2);
		}
	}

	// Token: 0x06000472 RID: 1138 RVA: 0x00004A22 File Offset: 0x00002C22
	private void method_274(Class144 class144_2)
	{
		this.method_129(class144_2);
	}

	// Token: 0x06000473 RID: 1139 RVA: 0x000050D5 File Offset: 0x000032D5
	private static void smethod_28(object object_3)
	{
		throw object_3;
	}

	// Token: 0x06000474 RID: 1140 RVA: 0x000050D8 File Offset: 0x000032D8
	private void method_275(uint uint_0)
	{
		this.nullable_0 = new uint?(uint_0);
	}

	// Token: 0x06000475 RID: 1141 RVA: 0x000050E6 File Offset: 0x000032E6
	private void method_276(Class144 class144_2)
	{
		this.method_161(false);
	}

	// Token: 0x06000476 RID: 1142 RVA: 0x00026BA8 File Offset: 0x00024DA8
	private Class144 method_277(Class144 class144_2, Class144 class144_3, bool bool_2, bool bool_3)
	{
		if (class144_2.vmethod_2() == 7)
		{
			if (class144_3.vmethod_2() == 7)
			{
				if (!bool_3)
				{
					int num = ((Class150)class144_2).method_2();
					int num2 = ((Class150)class144_3).method_2();
					int int_;
					if (bool_2)
					{
						int_ = checked(num + num2);
					}
					else
					{
						int_ = num + num2;
					}
					Class150 @class = new Class150();
					@class.method_3(int_);
					return @class;
				}
				uint num3 = (uint)((Class150)class144_2).method_2();
				uint num4 = (uint)((Class150)class144_3).method_2();
				uint int_2;
				if (bool_2)
				{
					int_2 = checked(num3 + num4);
				}
				else
				{
					int_2 = num3 + num4;
				}
				Class150 class2 = new Class150();
				class2.method_3((int)int_2);
				return class2;
			}
			else
			{
				if (class144_3.vmethod_2() == 11)
				{
					Class161 class3 = new Class161();
					class3.method_3((long)((Class150)class144_2).method_2());
					return Class87.smethod_21(class3, class144_3, bool_2, bool_3);
				}
				if (class144_3.vmethod_2() == 24)
				{
					Type underlyingType = Enum.GetUnderlyingType(class144_3.vmethod_0().GetType());
					if (underlyingType != typeof(long))
					{
						if (underlyingType != typeof(ulong))
						{
							Class150 class4 = new Class150();
							class4.method_3(Convert.ToInt32(class144_3.vmethod_0()));
							return this.method_277(class144_2, class4, bool_2, bool_3);
						}
					}
					Class161 class5 = new Class161();
					class5.method_3((long)((Class150)class144_2).method_2());
					Class161 class6 = new Class161();
					class6.method_3(Convert.ToInt64(class144_3.vmethod_0()));
					return Class87.smethod_21(class5, class6, bool_2, bool_3);
				}
			}
		}
		if (class144_2.vmethod_2() == 11)
		{
			if (class144_3.vmethod_2() == 11)
			{
				return Class87.smethod_21(class144_2, class144_3, bool_2, bool_3);
			}
			if (class144_3.vmethod_2() == 7)
			{
				Class161 class7 = new Class161();
				class7.method_3((long)((Class150)class144_3).method_2());
				return Class87.smethod_21(class144_2, class7, bool_2, bool_3);
			}
			if (class144_3.vmethod_2() == 24)
			{
				Type underlyingType2 = Enum.GetUnderlyingType(class144_3.vmethod_0().GetType());
				if (underlyingType2 != typeof(long))
				{
					if (underlyingType2 != typeof(ulong))
					{
						Class150 class8 = new Class150();
						class8.method_3(Convert.ToInt32(class144_3.vmethod_0()));
						return Class87.smethod_21(class144_2, class8, bool_2, bool_3);
					}
				}
				Class161 class9 = new Class161();
				class9.method_3(Convert.ToInt64(class144_3.vmethod_0()));
				return Class87.smethod_21(class144_2, class9, bool_2, bool_3);
			}
		}
		if (class144_2.vmethod_2() == 17 && class144_3.vmethod_2() == 17)
		{
			Class163 class10 = new Class163();
			class10.method_3(((Class163)class144_2).method_2() + ((Class163)class144_3).method_2());
			return class10;
		}
		if (class144_2.vmethod_2() == 24)
		{
			Type underlyingType3 = Enum.GetUnderlyingType(class144_2.vmethod_0().GetType());
			if (underlyingType3 != typeof(long))
			{
				if (underlyingType3 != typeof(ulong))
				{
					Class150 class11 = new Class150();
					class11.method_3(Convert.ToInt32(class144_2.vmethod_0()));
					return this.method_277(class11, class144_3, bool_2, bool_3);
				}
			}
			Class161 class12 = new Class161();
			class12.method_3(Convert.ToInt64(class144_2.vmethod_0()));
			return this.method_277(class12, class144_3, bool_2, bool_3);
		}
		throw new InvalidOperationException();
	}

	// Token: 0x06000477 RID: 1143 RVA: 0x00026E78 File Offset: 0x00025078
	private Class67 method_278(Class183 class183_2)
	{
		Class67 @class = new Class67();
		@class.method_9(class183_2.method_19());
		@class.method_1(this.method_230(class183_2));
		@class.method_7(class183_2.method_19());
		@class.method_3(this.method_29(class183_2));
		@class.method_5(class183_2.method_9());
		@class.method_11(class183_2.method_6());
		return @class;
	}

	// Token: 0x06000478 RID: 1144 RVA: 0x000050EF File Offset: 0x000032EF
	private void method_279(Class144 class144_2)
	{
		this.method_117(typeof(ushort));
	}

	// Token: 0x06000479 RID: 1145 RVA: 0x00005101 File Offset: 0x00003301
	private void method_280(Class144 class144_2)
	{
		this.method_129(this.class144_0[2].vmethod_4());
	}

	// Token: 0x0600047A RID: 1146 RVA: 0x00026ED4 File Offset: 0x000250D4
	private void method_281(Class144 class144_2)
	{
		Class144 @class = this.method_218();
		int num = @class.vmethod_2();
		checked
		{
			int int_;
			if (num <= 11)
			{
				if (num == 7)
				{
					int_ = (int)((uint)((Class150)@class).method_2());
					goto IL_6F;
				}
				if (num == 11)
				{
					int_ = (int)((ulong)((Class161)@class).method_2());
					goto IL_6F;
				}
			}
			else
			{
				if (num == 17)
				{
					int_ = (int)((Class163)@class).method_2();
					goto IL_6F;
				}
				if (num == 24)
				{
					int_ = (int)Convert.ToUInt64(((Class165)@class).method_2());
					goto IL_6F;
				}
			}
			throw new InvalidOperationException();
			IL_6F:
			Class150 class2 = new Class150();
			class2.method_3(int_);
			this.method_129(class2);
		}
	}

	// Token: 0x0600047B RID: 1147 RVA: 0x00026F64 File Offset: 0x00025164
	private void method_282(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		Class144 class144_4 = this.method_218();
		this.method_129(this.method_285(class144_4, class144_3, true, true));
	}

	// Token: 0x0600047C RID: 1148 RVA: 0x00026F90 File Offset: 0x00025190
	private void method_283(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		this.method_129(this.method_120(class144_3));
	}

	// Token: 0x0600047D RID: 1149 RVA: 0x00026FB4 File Offset: 0x000251B4
	private bool method_284(MethodBase methodBase_0, object object_3, ref object object_4, object[] object_5)
	{
		Type declaringType = methodBase_0.DeclaringType;
		if (declaringType == null)
		{
			return false;
		}
		if (Class28.smethod_0(declaringType))
		{
			if (string.Equals(methodBase_0.Name, Class185.smethod_0(537696365), StringComparison.Ordinal))
			{
				object_4 = (object_3 != null);
			}
			else if (string.Equals(methodBase_0.Name, Class185.smethod_0(537698192), StringComparison.Ordinal))
			{
				if (object_3 == null)
				{
					return ((bool?)null).Value;
				}
				object_4 = object_3;
			}
			else if (methodBase_0.Name.Equals(Class185.smethod_0(537698176), StringComparison.Ordinal))
			{
				if (object_3 == null)
				{
					object_4 = Activator.CreateInstance(Nullable.GetUnderlyingType(methodBase_0.DeclaringType));
				}
				object_4 = object_3;
			}
			else
			{
				if (object_3 != null || methodBase_0.IsStatic)
				{
					return false;
				}
				object_4 = null;
			}
			return true;
		}
		if (declaringType == Class87.type_6)
		{
			if (methodBase_0.Name.Equals(Class185.smethod_0(537698216), StringComparison.Ordinal))
			{
				object_4 = Class28.assembly_0;
				return true;
			}
			if (this.object_1 != null && methodBase_0.Name == Class185.smethod_0(537698259))
			{
				object[] array = this.object_1;
				for (int i = 0; i < array.Length; i++)
				{
					Assembly assembly = array[i] as Assembly;
					if (assembly != null)
					{
						object_4 = assembly;
						return true;
					}
				}
			}
		}
		else if (declaringType == Class87.type_1)
		{
			if (methodBase_0.Name == Class185.smethod_0(537698300))
			{
				if (this.object_1 != null)
				{
					object[] array = this.object_1;
					for (int i = 0; i < array.Length; i++)
					{
						MethodBase methodBase = array[i] as MethodBase;
						if (methodBase != null)
						{
							object_4 = methodBase;
							return true;
						}
					}
				}
				object_4 = MethodBase.GetCurrentMethod();
				return true;
			}
		}
		else if (declaringType.IsArray && declaringType.GetArrayRank() >= 2)
		{
			return this.method_14(methodBase_0, object_3, ref object_4, object_5);
		}
		return false;
	}

	// Token: 0x0600047E RID: 1150 RVA: 0x00027168 File Offset: 0x00025368
	private Class144 method_285(Class144 class144_2, Class144 class144_3, bool bool_2, bool bool_3)
	{
		if (class144_2.vmethod_2() == 7)
		{
			if (class144_3.vmethod_2() == 7)
			{
				if (!bool_3)
				{
					int num = ((Class150)class144_2).method_2();
					int num2 = ((Class150)class144_3).method_2();
					int int_;
					if (bool_2)
					{
						int_ = checked(num - num2);
					}
					else
					{
						int_ = num - num2;
					}
					Class150 @class = new Class150();
					@class.method_3(int_);
					return @class;
				}
				uint num3 = (uint)((Class150)class144_2).method_2();
				uint num4 = (uint)((Class150)class144_3).method_2();
				uint int_2;
				if (bool_2)
				{
					int_2 = checked(num3 - num4);
				}
				else
				{
					int_2 = num3 - num4;
				}
				Class150 class2 = new Class150();
				class2.method_3((int)int_2);
				return class2;
			}
			else
			{
				if (class144_3.vmethod_2() == 11)
				{
					Class161 class3 = new Class161();
					class3.method_3((long)((Class150)class144_2).method_2());
					return Class87.smethod_1(class3, class144_3, bool_2, bool_3);
				}
				if (class144_3.vmethod_2() == 24)
				{
					Type underlyingType = Enum.GetUnderlyingType(class144_3.vmethod_0().GetType());
					if (underlyingType != typeof(long))
					{
						if (underlyingType != typeof(ulong))
						{
							Class150 class4 = new Class150();
							class4.method_3(Convert.ToInt32(class144_3.vmethod_0()));
							return this.method_285(class144_2, class4, bool_2, bool_3);
						}
					}
					Class161 class5 = new Class161();
					class5.method_3((long)((Class150)class144_2).method_2());
					Class161 class6 = new Class161();
					class6.method_3(Convert.ToInt64(class144_3.vmethod_0()));
					return Class87.smethod_1(class5, class6, bool_2, bool_3);
				}
			}
		}
		if (class144_2.vmethod_2() == 11)
		{
			if (class144_3.vmethod_2() == 11)
			{
				return Class87.smethod_1(class144_2, class144_3, bool_2, bool_3);
			}
			if (class144_3.vmethod_2() == 7)
			{
				Class161 class7 = new Class161();
				class7.method_3((long)((Class150)class144_3).method_2());
				return Class87.smethod_1(class144_2, class7, bool_2, bool_3);
			}
			if (class144_3.vmethod_2() == 24)
			{
				Type underlyingType2 = Enum.GetUnderlyingType(class144_3.vmethod_0().GetType());
				if (underlyingType2 != typeof(long))
				{
					if (underlyingType2 != typeof(ulong))
					{
						Class150 class8 = new Class150();
						class8.method_3(Convert.ToInt32(class144_3.vmethod_0()));
						return Class87.smethod_1(class144_2, class8, bool_2, bool_3);
					}
				}
				Class161 class9 = new Class161();
				class9.method_3(Convert.ToInt64(class144_3.vmethod_0()));
				return Class87.smethod_1(class144_2, class9, bool_2, bool_3);
			}
		}
		if (class144_2.vmethod_2() == 17 && class144_3.vmethod_2() == 17)
		{
			Class163 class10 = new Class163();
			class10.method_3(((Class163)class144_2).method_2() - ((Class163)class144_3).method_2());
			return class10;
		}
		if (class144_2.vmethod_2() == 24)
		{
			Type underlyingType3 = Enum.GetUnderlyingType(class144_2.vmethod_0().GetType());
			if (underlyingType3 != typeof(long))
			{
				if (underlyingType3 != typeof(ulong))
				{
					Class150 class11 = new Class150();
					class11.method_3(Convert.ToInt32(class144_2.vmethod_0()));
					return this.method_285(class11, class144_3, bool_2, bool_3);
				}
			}
			Class161 class12 = new Class161();
			class12.method_3(Convert.ToInt64(class144_2.vmethod_0()));
			return this.method_285(class12, class144_3, bool_2, bool_3);
		}
		throw new InvalidOperationException();
	}

	// Token: 0x0600047F RID: 1151 RVA: 0x0000511A File Offset: 0x0000331A
	private void method_286(Class144 class144_2)
	{
		this.method_75(typeof(sbyte));
	}

	// Token: 0x06000480 RID: 1152 RVA: 0x00027438 File Offset: 0x00025638
	private void method_287(int int_0)
	{
		Class144 @class = this.method_218();
		if (@class is Class152)
		{
			this.class144_1[int_0] = @class;
			return;
		}
		this.class144_1[int_0].vmethod_3(@class);
	}

	// Token: 0x06000481 RID: 1153 RVA: 0x0000512C File Offset: 0x0000332C
	private void method_288(Class144 class144_2)
	{
		this.method_75(typeof(short));
	}

	// Token: 0x06000482 RID: 1154 RVA: 0x0000513E File Offset: 0x0000333E
	private void method_289(Class144 class144_2)
	{
		this.method_46(true);
	}

	// Token: 0x06000483 RID: 1155 RVA: 0x00005147 File Offset: 0x00003347
	private Class99 method_290(Class183 class183_2)
	{
		Class99 @class = new Class99();
		@class.method_1(class183_2.method_19());
		return @class;
	}

	// Token: 0x06000484 RID: 1156 RVA: 0x00027478 File Offset: 0x00025678
	private void method_291()
	{
		long num = this.class183_1.method_0().vmethod_4();
		int key = this.class183_1.method_19();
		Class87.Class91 @class;
		if (!this.dictionary_4.TryGetValue(key, out @class))
		{
			throw new InvalidOperationException(Class185.smethod_0(537696334));
		}
		this.long_0 = num;
		@class.delegate2_0(this.method_231(this.class183_1, @class.class11_0.method_2()));
	}

	// Token: 0x06000485 RID: 1157 RVA: 0x000274EC File Offset: 0x000256EC
	private Class87.Delegate1 method_292(MethodBase methodBase_0, bool bool_2)
	{
		DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, Class28.type_0, new Type[]
		{
			Class28.type_0,
			Class87.type_8
		}, typeof(Class87).Module, true);
		ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		Type[] array = new Type[parameters.Length];
		bool flag = false;
		for (int i = 0; i < parameters.Length; i++)
		{
			Type type = parameters[i].ParameterType;
			if (type.IsByRef)
			{
				flag = true;
				type = type.GetElementType();
			}
			array[i] = type;
		}
		LocalBuilder[] array2 = new LocalBuilder[array.Length];
		if (array2.Length != 0)
		{
			dynamicMethod.InitLocals = true;
		}
		for (int j = 0; j < array.Length; j++)
		{
			array2[j] = ilgenerator.DeclareLocal(array[j]);
		}
		for (int k = 0; k < array.Length; k++)
		{
			ilgenerator.Emit(OpCodes.Ldarg_1);
			Class87.smethod_4(ilgenerator, k);
			ilgenerator.Emit(OpCodes.Ldelem_Ref);
			Class87.smethod_0(ilgenerator, array[k]);
			ilgenerator.Emit(OpCodes.Stloc, array2[k]);
		}
		if (flag)
		{
			ilgenerator.BeginExceptionBlock();
		}
		if (!methodBase_0.IsStatic && !methodBase_0.IsConstructor)
		{
			ilgenerator.Emit(OpCodes.Ldarg_0);
			Type declaringType = methodBase_0.DeclaringType;
			if (declaringType.IsValueType)
			{
				ilgenerator.Emit(OpCodes.Unbox, declaringType);
				bool_2 = false;
			}
			else
			{
				Class87.smethod_11(ilgenerator, declaringType);
			}
		}
		for (int l = 0; l < array.Length; l++)
		{
			if (parameters[l].ParameterType.IsByRef)
			{
				ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
			}
			else
			{
				ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
			}
		}
		if (methodBase_0.IsConstructor)
		{
			ilgenerator.Emit(OpCodes.Newobj, (ConstructorInfo)methodBase_0);
			Class87.smethod_5(ilgenerator, methodBase_0.DeclaringType);
		}
		else
		{
			MethodInfo methodInfo = (MethodInfo)methodBase_0;
			if (bool_2 && !methodBase_0.IsStatic)
			{
				ilgenerator.EmitCall(OpCodes.Callvirt, methodInfo, null);
			}
			else
			{
				ilgenerator.EmitCall(OpCodes.Call, methodInfo, null);
			}
			if (methodInfo.ReturnType == Class87.type_2)
			{
				ilgenerator.Emit(OpCodes.Ldnull);
			}
			else
			{
				Class87.smethod_5(ilgenerator, methodInfo.ReturnType);
			}
		}
		if (flag)
		{
			LocalBuilder local = ilgenerator.DeclareLocal(Class28.type_0);
			ilgenerator.Emit(OpCodes.Stloc, local);
			ilgenerator.BeginFinallyBlock();
			for (int m = 0; m < array.Length; m++)
			{
				if (parameters[m].ParameterType.IsByRef)
				{
					ilgenerator.Emit(OpCodes.Ldarg_1);
					Class87.smethod_4(ilgenerator, m);
					ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
					if (array2[m].LocalType.IsValueType || Class107.smethod_0(array2[m].LocalType).IsGenericParameter)
					{
						ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
					}
					ilgenerator.Emit(OpCodes.Stelem_Ref);
				}
			}
			ilgenerator.EndExceptionBlock();
			ilgenerator.Emit(OpCodes.Ldloc, local);
		}
		ilgenerator.Emit(OpCodes.Ret);
		return (Class87.Delegate1)dynamicMethod.CreateDelegate(typeof(Class87.Delegate1));
	}

	// Token: 0x06000486 RID: 1158 RVA: 0x00027838 File Offset: 0x00025A38
	private Dictionary<int, Class87.Class91> method_293()
	{
		return new Dictionary<int, Class87.Class91>(256)
		{
			{
				this.class177_0.class11_129.method_0(),
				new Class87.Class91(this.class177_0.class11_129, new Class87.Delegate2(this.method_76))
			},
			{
				this.class177_0.class11_174.method_0(),
				new Class87.Class91(this.class177_0.class11_174, new Class87.Delegate2(this.method_23))
			},
			{
				this.class177_0.class11_91.method_0(),
				new Class87.Class91(this.class177_0.class11_91, new Class87.Delegate2(this.method_139))
			},
			{
				this.class177_0.class11_162.method_0(),
				new Class87.Class91(this.class177_0.class11_162, new Class87.Delegate2(this.method_146))
			},
			{
				this.class177_0.class11_189.method_0(),
				new Class87.Class91(this.class177_0.class11_189, new Class87.Delegate2(this.method_268))
			},
			{
				this.class177_0.class11_173.method_0(),
				new Class87.Class91(this.class177_0.class11_173, new Class87.Delegate2(this.method_207))
			},
			{
				this.class177_0.class11_149.method_0(),
				new Class87.Class91(this.class177_0.class11_149, new Class87.Delegate2(this.method_281))
			},
			{
				this.class177_0.class11_119.method_0(),
				new Class87.Class91(this.class177_0.class11_119, new Class87.Delegate2(this.method_229))
			},
			{
				this.class177_0.class11_212.method_0(),
				new Class87.Class91(this.class177_0.class11_212, new Class87.Delegate2(this.method_189))
			},
			{
				this.class177_0.class11_51.method_0(),
				new Class87.Class91(this.class177_0.class11_51, new Class87.Delegate2(this.method_77))
			},
			{
				this.class177_0.class11_117.method_0(),
				new Class87.Class91(this.class177_0.class11_117, new Class87.Delegate2(this.method_222))
			},
			{
				this.class177_0.class11_165.method_0(),
				new Class87.Class91(this.class177_0.class11_165, new Class87.Delegate2(this.method_190))
			},
			{
				this.class177_0.class11_28.method_0(),
				new Class87.Class91(this.class177_0.class11_28, new Class87.Delegate2(this.method_9))
			},
			{
				this.class177_0.class11_206.method_0(),
				new Class87.Class91(this.class177_0.class11_206, new Class87.Delegate2(this.method_148))
			},
			{
				this.class177_0.class11_108.method_0(),
				new Class87.Class91(this.class177_0.class11_108, new Class87.Delegate2(this.method_110))
			},
			{
				this.class177_0.class11_153.method_0(),
				new Class87.Class91(this.class177_0.class11_153, new Class87.Delegate2(this.method_138))
			},
			{
				this.class177_0.class11_127.method_0(),
				new Class87.Class91(this.class177_0.class11_127, new Class87.Delegate2(this.method_142))
			},
			{
				this.class177_0.class11_126.method_0(),
				new Class87.Class91(this.class177_0.class11_126, new Class87.Delegate2(this.method_227))
			},
			{
				this.class177_0.class11_136.method_0(),
				new Class87.Class91(this.class177_0.class11_136, new Class87.Delegate2(this.method_38))
			},
			{
				this.class177_0.class11_68.method_0(),
				new Class87.Class91(this.class177_0.class11_68, new Class87.Delegate2(this.method_134))
			},
			{
				this.class177_0.class11_101.method_0(),
				new Class87.Class91(this.class177_0.class11_101, new Class87.Delegate2(this.method_109))
			},
			{
				this.class177_0.class11_19.method_0(),
				new Class87.Class91(this.class177_0.class11_19, new Class87.Delegate2(this.method_128))
			},
			{
				this.class177_0.class11_103.method_0(),
				new Class87.Class91(this.class177_0.class11_103, new Class87.Delegate2(this.method_175))
			},
			{
				this.class177_0.class11_73.method_0(),
				new Class87.Class91(this.class177_0.class11_73, new Class87.Delegate2(this.method_178))
			},
			{
				this.class177_0.class11_204.method_0(),
				new Class87.Class91(this.class177_0.class11_204, new Class87.Delegate2(this.method_96))
			},
			{
				this.class177_0.class11_143.method_0(),
				new Class87.Class91(this.class177_0.class11_143, new Class87.Delegate2(this.method_279))
			},
			{
				this.class177_0.class11_113.method_0(),
				new Class87.Class91(this.class177_0.class11_113, new Class87.Delegate2(this.method_267))
			},
			{
				this.class177_0.class11_84.method_0(),
				new Class87.Class91(this.class177_0.class11_84, new Class87.Delegate2(this.method_32))
			},
			{
				this.class177_0.class11_80.method_0(),
				new Class87.Class91(this.class177_0.class11_80, new Class87.Delegate2(this.method_15))
			},
			{
				this.class177_0.class11_86.method_0(),
				new Class87.Class91(this.class177_0.class11_86, new Class87.Delegate2(this.method_33))
			},
			{
				this.class177_0.class11_195.method_0(),
				new Class87.Class91(this.class177_0.class11_195, new Class87.Delegate2(this.method_30))
			},
			{
				this.class177_0.class11_132.method_0(),
				new Class87.Class91(this.class177_0.class11_164, new Class87.Delegate2(this.method_86))
			},
			{
				this.class177_0.class11_130.method_0(),
				new Class87.Class91(this.class177_0.class11_130, new Class87.Delegate2(this.method_12))
			},
			{
				this.class177_0.class11_41.method_0(),
				new Class87.Class91(this.class177_0.class11_41, new Class87.Delegate2(this.method_213))
			},
			{
				this.class177_0.class11_26.method_0(),
				new Class87.Class91(this.class177_0.class11_26, new Class87.Delegate2(this.method_140))
			},
			{
				this.class177_0.class11_32.method_0(),
				new Class87.Class91(this.class177_0.class11_32, new Class87.Delegate2(this.method_299))
			},
			{
				this.class177_0.class11_78.method_0(),
				new Class87.Class91(this.class177_0.class11_78, new Class87.Delegate2(this.method_147))
			},
			{
				this.class177_0.class11_87.method_0(),
				new Class87.Class91(this.class177_0.class11_87, new Class87.Delegate2(this.method_114))
			},
			{
				this.class177_0.class11_79.method_0(),
				new Class87.Class91(this.class177_0.class11_79, new Class87.Delegate2(this.method_51))
			},
			{
				this.class177_0.class11_198.method_0(),
				new Class87.Class91(this.class177_0.class11_198, new Class87.Delegate2(this.method_20))
			},
			{
				this.class177_0.class11_44.method_0(),
				new Class87.Class91(this.class177_0.class11_44, new Class87.Delegate2(this.method_72))
			},
			{
				this.class177_0.class11_171.method_0(),
				new Class87.Class91(this.class177_0.class11_171, new Class87.Delegate2(this.method_214))
			},
			{
				this.class177_0.class11_52.method_0(),
				new Class87.Class91(this.class177_0.class11_52, new Class87.Delegate2(this.method_276))
			},
			{
				this.class177_0.class11_88.method_0(),
				new Class87.Class91(this.class177_0.class11_88, new Class87.Delegate2(this.method_298))
			},
			{
				this.class177_0.class11_21.method_0(),
				new Class87.Class91(this.class177_0.class11_21, new Class87.Delegate2(this.method_127))
			},
			{
				this.class177_0.class11_95.method_0(),
				new Class87.Class91(this.class177_0.class11_95, new Class87.Delegate2(this.method_283))
			},
			{
				this.class177_0.class11_139.method_0(),
				new Class87.Class91(this.class177_0.class11_139, new Class87.Delegate2(this.method_45))
			},
			{
				this.class177_0.class11_161.method_0(),
				new Class87.Class91(this.class177_0.class11_161, new Class87.Delegate2(this.method_47))
			},
			{
				this.class177_0.class11_2.method_0(),
				new Class87.Class91(this.class177_0.class11_2, new Class87.Delegate2(this.method_64))
			},
			{
				this.class177_0.class11_145.method_0(),
				new Class87.Class91(this.class177_0.class11_145, new Class87.Delegate2(this.method_90))
			},
			{
				this.class177_0.class11_167.method_0(),
				new Class87.Class91(this.class177_0.class11_167, new Class87.Delegate2(this.method_162))
			},
			{
				this.class177_0.class11_29.method_0(),
				new Class87.Class91(this.class177_0.class11_29, new Class87.Delegate2(this.method_280))
			},
			{
				this.class177_0.class11_102.method_0(),
				new Class87.Class91(this.class177_0.class11_102, new Class87.Delegate2(this.method_5))
			},
			{
				this.class177_0.class11_66.method_0(),
				new Class87.Class91(this.class177_0.class11_66, new Class87.Delegate2(this.method_176))
			},
			{
				this.class177_0.class11_114.method_0(),
				new Class87.Class91(this.class177_0.class11_114, new Class87.Delegate2(this.method_211))
			},
			{
				this.class177_0.class11_76.method_0(),
				new Class87.Class91(this.class177_0.class11_76, new Class87.Delegate2(this.method_248))
			},
			{
				this.class177_0.class11_115.method_0(),
				new Class87.Class91(this.class177_0.class11_115, new Class87.Delegate2(this.method_180))
			},
			{
				this.class177_0.class11_34.method_0(),
				new Class87.Class91(this.class177_0.class11_34, new Class87.Delegate2(this.method_10))
			},
			{
				this.class177_0.class11_148.method_0(),
				new Class87.Class91(this.class177_0.class11_148, new Class87.Delegate2(this.method_44))
			},
			{
				this.class177_0.class11_135.method_0(),
				new Class87.Class91(this.class177_0.class11_135, new Class87.Delegate2(this.method_193))
			},
			{
				this.class177_0.class11_94.method_0(),
				new Class87.Class91(this.class177_0.class11_94, new Class87.Delegate2(this.method_116))
			},
			{
				this.class177_0.class11_185.method_0(),
				new Class87.Class91(this.class177_0.class11_185, new Class87.Delegate2(this.method_78))
			},
			{
				this.class177_0.class11_89.method_0(),
				new Class87.Class91(this.class177_0.class11_89, new Class87.Delegate2(this.method_56))
			},
			{
				this.class177_0.class11_142.method_0(),
				new Class87.Class91(this.class177_0.class11_142, new Class87.Delegate2(this.method_170))
			},
			{
				this.class177_0.class11_96.method_0(),
				new Class87.Class91(this.class177_0.class11_96, new Class87.Delegate2(this.method_208))
			},
			{
				this.class177_0.class11_201.method_0(),
				new Class87.Class91(this.class177_0.class11_201, new Class87.Delegate2(this.method_179))
			},
			{
				this.class177_0.class11_191.method_0(),
				new Class87.Class91(this.class177_0.class11_191, new Class87.Delegate2(this.method_186))
			},
			{
				this.class177_0.class11_16.method_0(),
				new Class87.Class91(this.class177_0.class11_16, new Class87.Delegate2(this.method_270))
			},
			{
				this.class177_0.class11_164.method_0(),
				new Class87.Class91(this.class177_0.class11_164, new Class87.Delegate2(this.method_97))
			},
			{
				this.class177_0.class11_18.method_0(),
				new Class87.Class91(this.class177_0.class11_18, new Class87.Delegate2(this.method_53))
			},
			{
				this.class177_0.class11_179.method_0(),
				new Class87.Class91(this.class177_0.class11_179, new Class87.Delegate2(this.method_184))
			},
			{
				this.class177_0.class11_99.method_0(),
				new Class87.Class91(this.class177_0.class11_99, new Class87.Delegate2(this.method_150))
			},
			{
				this.class177_0.class11_166.method_0(),
				new Class87.Class91(this.class177_0.class11_166, new Class87.Delegate2(this.method_130))
			},
			{
				this.class177_0.class11_186.method_0(),
				new Class87.Class91(this.class177_0.class11_186, new Class87.Delegate2(this.method_135))
			},
			{
				this.class177_0.class11_128.method_0(),
				new Class87.Class91(this.class177_0.class11_128, new Class87.Delegate2(this.method_98))
			},
			{
				this.class177_0.class11_183.method_0(),
				new Class87.Class91(this.class177_0.class11_183, new Class87.Delegate2(this.method_247))
			},
			{
				this.class177_0.class11_23.method_0(),
				new Class87.Class91(this.class177_0.class11_23, new Class87.Delegate2(this.method_163))
			},
			{
				this.class177_0.class11_154.method_0(),
				new Class87.Class91(this.class177_0.class11_154, new Class87.Delegate2(this.method_126))
			},
			{
				this.class177_0.class11_72.method_0(),
				new Class87.Class91(this.class177_0.class11_72, new Class87.Delegate2(this.method_260))
			},
			{
				this.class177_0.class11_182.method_0(),
				new Class87.Class91(this.class177_0.class11_182, new Class87.Delegate2(this.method_13))
			},
			{
				this.class177_0.class11_163.method_0(),
				new Class87.Class91(this.class177_0.class11_163, new Class87.Delegate2(this.method_68))
			},
			{
				this.class177_0.class11_155.method_0(),
				new Class87.Class91(this.class177_0.class11_155, new Class87.Delegate2(this.method_103))
			},
			{
				this.class177_0.class11_169.method_0(),
				new Class87.Class91(this.class177_0.class11_169, new Class87.Delegate2(this.method_133))
			},
			{
				this.class177_0.class11_134.method_0(),
				new Class87.Class91(this.class177_0.class11_134, new Class87.Delegate2(this.method_205))
			},
			{
				this.class177_0.class11_175.method_0(),
				new Class87.Class91(this.class177_0.class11_175, new Class87.Delegate2(this.method_171))
			},
			{
				this.class177_0.class11_138.method_0(),
				new Class87.Class91(this.class177_0.class11_138, new Class87.Delegate2(this.method_34))
			},
			{
				this.class177_0.class11_25.method_0(),
				new Class87.Class91(this.class177_0.class11_25, new Class87.Delegate2(this.method_73))
			},
			{
				this.class177_0.class11_22.method_0(),
				new Class87.Class91(this.class177_0.class11_22, new Class87.Delegate2(this.method_82))
			},
			{
				this.class177_0.class11_74.method_0(),
				new Class87.Class91(this.class177_0.class11_74, new Class87.Delegate2(this.method_79))
			},
			{
				this.class177_0.class11_30.method_0(),
				new Class87.Class91(this.class177_0.class11_30, new Class87.Delegate2(this.method_17))
			},
			{
				this.class177_0.class11_209.method_0(),
				new Class87.Class91(this.class177_0.class11_209, new Class87.Delegate2(this.method_225))
			},
			{
				this.class177_0.class11_6.method_0(),
				new Class87.Class91(this.class177_0.class11_6, new Class87.Delegate2(this.method_155))
			},
			{
				this.class177_0.class11_20.method_0(),
				new Class87.Class91(this.class177_0.class11_20, new Class87.Delegate2(this.method_60))
			},
			{
				this.class177_0.class11_137.method_0(),
				new Class87.Class91(this.class177_0.class11_137, new Class87.Delegate2(this.method_262))
			},
			{
				this.class177_0.class11_141.method_0(),
				new Class87.Class91(this.class177_0.class11_141, new Class87.Delegate2(this.method_91))
			},
			{
				this.class177_0.class11_210.method_0(),
				new Class87.Class91(this.class177_0.class11_210, new Class87.Delegate2(this.method_26))
			},
			{
				this.class177_0.class11_97.method_0(),
				new Class87.Class91(this.class177_0.class11_97, new Class87.Delegate2(this.method_301))
			},
			{
				this.class177_0.class11_15.method_0(),
				new Class87.Class91(this.class177_0.class11_15, new Class87.Delegate2(this.method_242))
			},
			{
				this.class177_0.class11_12.method_0(),
				new Class87.Class91(this.class177_0.class11_12, new Class87.Delegate2(this.method_201))
			},
			{
				this.class177_0.class11_192.method_0(),
				new Class87.Class91(this.class177_0.class11_192, new Class87.Delegate2(this.method_246))
			},
			{
				this.class177_0.class11_82.method_0(),
				new Class87.Class91(this.class177_0.class11_82, new Class87.Delegate2(this.method_52))
			},
			{
				this.class177_0.class11_3.method_0(),
				new Class87.Class91(this.class177_0.class11_3, new Class87.Delegate2(this.method_269))
			},
			{
				this.class177_0.class11_36.method_0(),
				new Class87.Class91(this.class177_0.class11_36, new Class87.Delegate2(this.method_1))
			},
			{
				this.class177_0.class11_69.method_0(),
				new Class87.Class91(this.class177_0.class11_69, new Class87.Delegate2(this.method_288))
			},
			{
				this.class177_0.class11_59.method_0(),
				new Class87.Class91(this.class177_0.class11_59, new Class87.Delegate2(this.method_25))
			},
			{
				this.class177_0.class11_123.method_0(),
				new Class87.Class91(this.class177_0.class11_123, new Class87.Delegate2(this.method_177))
			},
			{
				this.class177_0.class11_133.method_0(),
				new Class87.Class91(this.class177_0.class11_133, new Class87.Delegate2(this.method_22))
			},
			{
				this.class177_0.class11_211.method_0(),
				new Class87.Class91(this.class177_0.class11_211, new Class87.Delegate2(this.method_257))
			},
			{
				this.class177_0.class11_8.method_0(),
				new Class87.Class91(this.class177_0.class11_8, new Class87.Delegate2(this.method_11))
			},
			{
				this.class177_0.class11_81.method_0(),
				new Class87.Class91(this.class177_0.class11_81, new Class87.Delegate2(this.method_195))
			},
			{
				this.class177_0.class11_85.method_0(),
				new Class87.Class91(this.class177_0.class11_85, new Class87.Delegate2(this.method_42))
			},
			{
				this.class177_0.class11_7.method_0(),
				new Class87.Class91(this.class177_0.class11_7, new Class87.Delegate2(this.method_39))
			},
			{
				this.class177_0.class11_55.method_0(),
				new Class87.Class91(this.class177_0.class11_55, new Class87.Delegate2(this.method_273))
			},
			{
				this.class177_0.class11_172.method_0(),
				new Class87.Class91(this.class177_0.class11_172, new Class87.Delegate2(this.method_104))
			},
			{
				this.class177_0.class11_17.method_0(),
				new Class87.Class91(this.class177_0.class11_17, new Class87.Delegate2(this.method_66))
			},
			{
				this.class177_0.class11_111.method_0(),
				new Class87.Class91(this.class177_0.class11_111, new Class87.Delegate2(this.method_58))
			},
			{
				this.class177_0.class11_160.method_0(),
				new Class87.Class91(this.class177_0.class11_160, new Class87.Delegate2(this.method_198))
			},
			{
				this.class177_0.class11_58.method_0(),
				new Class87.Class91(this.class177_0.class11_58, new Class87.Delegate2(this.method_121))
			},
			{
				this.class177_0.class11_100.method_0(),
				new Class87.Class91(this.class177_0.class11_100, new Class87.Delegate2(this.method_4))
			},
			{
				this.class177_0.class11_50.method_0(),
				new Class87.Class91(this.class177_0.class11_50, new Class87.Delegate2(this.method_111))
			},
			{
				this.class177_0.class11_39.method_0(),
				new Class87.Class91(this.class177_0.class11_39, new Class87.Delegate2(this.method_228))
			},
			{
				this.class177_0.class11_120.method_0(),
				new Class87.Class91(this.class177_0.class11_120, new Class87.Delegate2(this.method_255))
			},
			{
				this.class177_0.class11_202.method_0(),
				new Class87.Class91(this.class177_0.class11_202, new Class87.Delegate2(this.method_67))
			},
			{
				this.class177_0.class11_213.method_0(),
				new Class87.Class91(this.class177_0.class11_213, new Class87.Delegate2(this.method_62))
			},
			{
				this.class177_0.class11_131.method_0(),
				new Class87.Class91(this.class177_0.class11_131, new Class87.Delegate2(this.method_84))
			},
			{
				this.class177_0.class11_33.method_0(),
				new Class87.Class91(this.class177_0.class11_33, new Class87.Delegate2(this.method_132))
			},
			{
				this.class177_0.class11_71.method_0(),
				new Class87.Class91(this.class177_0.class11_71, new Class87.Delegate2(this.method_289))
			},
			{
				this.class177_0.class11_158.method_0(),
				new Class87.Class91(this.class177_0.class11_158, new Class87.Delegate2(this.method_182))
			},
			{
				this.class177_0.class11_147.method_0(),
				new Class87.Class91(this.class177_0.class11_147, new Class87.Delegate2(this.method_264))
			},
			{
				this.class177_0.class11_109.method_0(),
				new Class87.Class91(this.class177_0.class11_109, new Class87.Delegate2(this.method_99))
			},
			{
				this.class177_0.class11_11.method_0(),
				new Class87.Class91(this.class177_0.class11_11, new Class87.Delegate2(this.method_173))
			},
			{
				this.class177_0.class11_31.method_0(),
				new Class87.Class91(this.class177_0.class11_31, new Class87.Delegate2(this.method_28))
			},
			{
				this.class177_0.class11_35.method_0(),
				new Class87.Class91(this.class177_0.class11_35, new Class87.Delegate2(this.method_100))
			},
			{
				this.class177_0.class11_178.method_0(),
				new Class87.Class91(this.class177_0.class11_178, new Class87.Delegate2(this.method_194))
			},
			{
				this.class177_0.class11_168.method_0(),
				new Class87.Class91(this.class177_0.class11_168, new Class87.Delegate2(this.method_181))
			},
			{
				this.class177_0.class11_42.method_0(),
				new Class87.Class91(this.class177_0.class11_42, new Class87.Delegate2(this.method_2))
			},
			{
				this.class177_0.class11_10.method_0(),
				new Class87.Class91(this.class177_0.class11_10, new Class87.Delegate2(this.method_258))
			},
			{
				this.class177_0.class11_118.method_0(),
				new Class87.Class91(this.class177_0.class11_118, new Class87.Delegate2(this.method_85))
			},
			{
				this.class177_0.class11_98.method_0(),
				new Class87.Class91(this.class177_0.class11_98, new Class87.Delegate2(this.method_256))
			},
			{
				this.class177_0.class11_45.method_0(),
				new Class87.Class91(this.class177_0.class11_45, new Class87.Delegate2(this.method_249))
			},
			{
				this.class177_0.class11_176.method_0(),
				new Class87.Class91(this.class177_0.class11_176, new Class87.Delegate2(this.method_220))
			},
			{
				this.class177_0.class11_112.method_0(),
				new Class87.Class91(this.class177_0.class11_112, new Class87.Delegate2(this.method_152))
			},
			{
				this.class177_0.class11_5.method_0(),
				new Class87.Class91(this.class177_0.class11_5, new Class87.Delegate2(this.method_300))
			},
			{
				this.class177_0.class11_159.method_0(),
				new Class87.Class91(this.class177_0.class11_159, new Class87.Delegate2(this.method_7))
			},
			{
				this.class177_0.class11_46.method_0(),
				new Class87.Class91(this.class177_0.class11_46, new Class87.Delegate2(this.method_112))
			},
			{
				this.class177_0.class11_193.method_0(),
				new Class87.Class91(this.class177_0.class11_193, new Class87.Delegate2(this.method_131))
			},
			{
				this.class177_0.class11_188.method_0(),
				new Class87.Class91(this.class177_0.class11_188, new Class87.Delegate2(this.method_234))
			},
			{
				this.class177_0.class11_0.method_0(),
				new Class87.Class91(this.class177_0.class11_0, new Class87.Delegate2(this.method_70))
			},
			{
				this.class177_0.class11_150.method_0(),
				new Class87.Class91(this.class177_0.class11_150, new Class87.Delegate2(this.method_89))
			},
			{
				this.class177_0.class11_105.method_0(),
				new Class87.Class91(this.class177_0.class11_105, new Class87.Delegate2(this.method_40))
			},
			{
				this.class177_0.class11_196.method_0(),
				new Class87.Class91(this.class177_0.class11_196, new Class87.Delegate2(this.method_204))
			},
			{
				this.class177_0.class11_37.method_0(),
				new Class87.Class91(this.class177_0.class11_37, new Class87.Delegate2(this.method_164))
			},
			{
				this.class177_0.class11_156.method_0(),
				new Class87.Class91(this.class177_0.class11_156, new Class87.Delegate2(this.method_137))
			},
			{
				this.class177_0.class11_14.method_0(),
				new Class87.Class91(this.class177_0.class11_14, new Class87.Delegate2(this.method_71))
			},
			{
				this.class177_0.class11_92.method_0(),
				new Class87.Class91(this.class177_0.class11_92, new Class87.Delegate2(this.method_16))
			},
			{
				this.class177_0.class11_61.method_0(),
				new Class87.Class91(this.class177_0.class11_61, new Class87.Delegate2(this.method_226))
			},
			{
				this.class177_0.class11_197.method_0(),
				new Class87.Class91(this.class177_0.class11_197, new Class87.Delegate2(this.method_251))
			},
			{
				this.class177_0.class11_4.method_0(),
				new Class87.Class91(this.class177_0.class11_4, new Class87.Delegate2(this.method_0))
			},
			{
				this.class177_0.class11_187.method_0(),
				new Class87.Class91(this.class177_0.class11_187, new Class87.Delegate2(this.method_296))
			},
			{
				this.class177_0.class11_170.method_0(),
				new Class87.Class91(this.class177_0.class11_170, new Class87.Delegate2(this.method_93))
			},
			{
				this.class177_0.class11_24.method_0(),
				new Class87.Class91(this.class177_0.class11_24, new Class87.Delegate2(this.method_63))
			},
			{
				this.class177_0.class11_184.method_0(),
				new Class87.Class91(this.class177_0.class11_184, new Class87.Delegate2(this.method_183))
			},
			{
				this.class177_0.class11_75.method_0(),
				new Class87.Class91(this.class177_0.class11_75, new Class87.Delegate2(this.method_49))
			},
			{
				this.class177_0.class11_116.method_0(),
				new Class87.Class91(this.class177_0.class11_116, new Class87.Delegate2(this.method_19))
			},
			{
				this.class177_0.class11_205.method_0(),
				new Class87.Class91(this.class177_0.class11_205, new Class87.Delegate2(this.method_160))
			},
			{
				this.class177_0.class11_9.method_0(),
				new Class87.Class91(this.class177_0.class11_9, new Class87.Delegate2(this.method_297))
			},
			{
				this.class177_0.class11_70.method_0(),
				new Class87.Class91(this.class177_0.class11_70, new Class87.Delegate2(this.method_282))
			},
			{
				this.class177_0.class11_104.method_0(),
				new Class87.Class91(this.class177_0.class11_104, new Class87.Delegate2(this.method_212))
			},
			{
				this.class177_0.class11_122.method_0(),
				new Class87.Class91(this.class177_0.class11_122, new Class87.Delegate2(this.method_254))
			},
			{
				this.class177_0.class11_56.method_0(),
				new Class87.Class91(this.class177_0.class11_56, new Class87.Delegate2(this.method_253))
			},
			{
				this.class177_0.class11_146.method_0(),
				new Class87.Class91(this.class177_0.class11_146, new Class87.Delegate2(this.method_243))
			},
			{
				this.class177_0.class11_125.method_0(),
				new Class87.Class91(this.class177_0.class11_125, new Class87.Delegate2(this.method_65))
			},
			{
				this.class177_0.class11_60.method_0(),
				new Class87.Class91(this.class177_0.class11_60, new Class87.Delegate2(this.method_197))
			},
			{
				this.class177_0.class11_57.method_0(),
				new Class87.Class91(this.class177_0.class11_57, new Class87.Delegate2(this.method_106))
			},
			{
				this.class177_0.class11_124.method_0(),
				new Class87.Class91(this.class177_0.class11_124, new Class87.Delegate2(this.method_80))
			},
			{
				this.class177_0.class11_64.method_0(),
				new Class87.Class91(this.class177_0.class11_64, new Class87.Delegate2(this.method_200))
			},
			{
				this.class177_0.class11_1.method_0(),
				new Class87.Class91(this.class177_0.class11_1, new Class87.Delegate2(this.method_50))
			},
			{
				this.class177_0.class11_151.method_0(),
				new Class87.Class91(this.class177_0.class11_151, new Class87.Delegate2(this.method_174))
			},
			{
				this.class177_0.class11_177.method_0(),
				new Class87.Class91(this.class177_0.class11_177, new Class87.Delegate2(this.method_167))
			},
			{
				this.class177_0.class11_49.method_0(),
				new Class87.Class91(this.class177_0.class11_49, new Class87.Delegate2(this.method_35))
			},
			{
				this.class177_0.class11_140.method_0(),
				new Class87.Class91(this.class177_0.class11_140, new Class87.Delegate2(this.method_265))
			},
			{
				this.class177_0.class11_199.method_0(),
				new Class87.Class91(this.class177_0.class11_199, new Class87.Delegate2(this.method_240))
			},
			{
				this.class177_0.class11_110.method_0(),
				new Class87.Class91(this.class177_0.class11_110, new Class87.Delegate2(this.method_18))
			},
			{
				this.class177_0.class11_65.method_0(),
				new Class87.Class91(this.class177_0.class11_65, new Class87.Delegate2(this.method_24))
			},
			{
				this.class177_0.class11_93.method_0(),
				new Class87.Class91(this.class177_0.class11_93, new Class87.Delegate2(this.method_125))
			},
			{
				this.class177_0.class11_77.method_0(),
				new Class87.Class91(this.class177_0.class11_77, new Class87.Delegate2(this.method_286))
			},
			{
				this.class177_0.class11_83.method_0(),
				new Class87.Class91(this.class177_0.class11_83, new Class87.Delegate2(this.method_123))
			},
			{
				this.class177_0.class11_180.method_0(),
				new Class87.Class91(this.class177_0.class11_180, new Class87.Delegate2(this.method_210))
			},
			{
				this.class177_0.class11_190.method_0(),
				new Class87.Class91(this.class177_0.class11_190, new Class87.Delegate2(this.method_8))
			},
			{
				this.class177_0.class11_152.method_0(),
				new Class87.Class91(this.class177_0.class11_152, new Class87.Delegate2(this.method_108))
			},
			{
				this.class177_0.class11_48.method_0(),
				new Class87.Class91(this.class177_0.class11_48, new Class87.Delegate2(this.method_274))
			},
			{
				this.class177_0.class11_157.method_0(),
				new Class87.Class91(this.class177_0.class11_157, new Class87.Delegate2(this.method_95))
			},
			{
				this.class177_0.class11_40.method_0(),
				new Class87.Class91(this.class177_0.class11_40, new Class87.Delegate2(this.method_223))
			},
			{
				this.class177_0.class11_203.method_0(),
				new Class87.Class91(this.class177_0.class11_203, new Class87.Delegate2(this.method_192))
			},
			{
				this.class177_0.class11_38.method_0(),
				new Class87.Class91(this.class177_0.class11_38, new Class87.Delegate2(this.method_236))
			},
			{
				this.class177_0.class11_54.method_0(),
				new Class87.Class91(this.class177_0.class11_54, new Class87.Delegate2(this.method_145))
			},
			{
				this.class177_0.class11_106.method_0(),
				new Class87.Class91(this.class177_0.class11_106, new Class87.Delegate2(this.method_172))
			},
			{
				this.class177_0.class11_53.method_0(),
				new Class87.Class91(this.class177_0.class11_53, new Class87.Delegate2(this.method_6))
			},
			{
				this.class177_0.class11_200.method_0(),
				new Class87.Class91(this.class177_0.class11_200, new Class87.Delegate2(this.method_151))
			},
			{
				this.class177_0.class11_67.method_0(),
				new Class87.Class91(this.class177_0.class11_67, new Class87.Delegate2(this.method_119))
			},
			{
				this.class177_0.class11_47.method_0(),
				new Class87.Class91(this.class177_0.class11_47, new Class87.Delegate2(this.method_241))
			},
			{
				this.class177_0.class11_121.method_0(),
				new Class87.Class91(this.class177_0.class11_121, new Class87.Delegate2(this.method_185))
			},
			{
				this.class177_0.class11_43.method_0(),
				new Class87.Class91(this.class177_0.class11_43, new Class87.Delegate2(this.method_118))
			}
		};
	}

	// Token: 0x06000487 RID: 1159 RVA: 0x00029FF8 File Offset: 0x000281F8
	private void method_294(bool bool_2)
	{
		Class144 @class = this.method_218();
		int num = @class.vmethod_2();
		byte int_;
		if (num <= 11)
		{
			if (num != 7)
			{
				if (num == 11)
				{
					if (bool_2)
					{
						int_ = checked((byte)((ulong)((Class161)@class).method_2()));
						goto IL_BF;
					}
					int_ = (byte)((Class161)@class).method_2();
					goto IL_BF;
				}
			}
			else
			{
				if (bool_2)
				{
					int_ = checked((byte)((uint)((Class150)@class).method_2()));
					goto IL_BF;
				}
				int_ = (byte)((Class150)@class).method_2();
				goto IL_BF;
			}
		}
		else if (num != 17)
		{
			if (num == 24)
			{
				if (bool_2)
				{
					int_ = checked((byte)Convert.ToUInt64(((Class165)@class).method_2()));
					goto IL_BF;
				}
				int_ = (byte)Convert.ToUInt64(((Class165)@class).method_2());
				goto IL_BF;
			}
		}
		else
		{
			if (bool_2)
			{
				int_ = checked((byte)((Class163)@class).method_2());
				goto IL_BF;
			}
			int_ = (byte)((Class163)@class).method_2();
			goto IL_BF;
		}
		throw new InvalidOperationException();
		IL_BF:
		Class150 class2 = new Class150();
		class2.method_3((int)int_);
		this.method_129(class2);
	}

	// Token: 0x06000488 RID: 1160 RVA: 0x0002A0D8 File Offset: 0x000282D8
	private void method_295(Stream stream_1, long long_1, string string_0)
	{
		int int_ = this.method_238();
		Class54 class52_ = new Class54(stream_1, int_);
		this.class183_0 = new Class183(class52_);
		if (string_0 != null)
		{
			long_1 = this.method_149(string_0);
		}
		Class52 @class = this.class183_0.method_0();
		Class52 obj = @class;
		lock (obj)
		{
			@class.vmethod_9(long_1, 0);
			this.method_233(this.class183_0);
			this.class67_0 = this.method_278(this.class183_0);
			this.class123_0 = Class87.smethod_29(this.class183_0);
			this.byte_0 = Class87.smethod_7(this.class183_0);
		}
		this.method_158();
	}

	// Token: 0x06000489 RID: 1161 RVA: 0x00004A8A File Offset: 0x00002C8A
	private void method_296(Class144 class144_2)
	{
		this.method_252();
	}

	// Token: 0x0600048A RID: 1162 RVA: 0x0002A18C File Offset: 0x0002838C
	private void method_297(Class144 class144_2)
	{
		Class144 class144_3 = this.method_218();
		Class144 @class = this.method_218();
		bool flag;
		if (@class.vmethod_2() == 17)
		{
			flag = !Class87.smethod_16(@class, class144_3);
		}
		else
		{
			flag = !Class87.smethod_10(@class, class144_3);
		}
		if (flag)
		{
			uint uint_ = ((Class168)class144_2).method_2();
			this.method_275(uint_);
		}
	}

	// Token: 0x0600048B RID: 1163 RVA: 0x0002A1E0 File Offset: 0x000283E0
	private static Class123[] smethod_29(Class183 class183_2)
	{
		int num = (int)class183_2.method_23();
		Class123[] array = new Class123[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = Class87.smethod_17(class183_2);
		}
		return array;
	}

	// Token: 0x0600048C RID: 1164 RVA: 0x00004A22 File Offset: 0x00002C22
	private void method_298(Class144 class144_2)
	{
		this.method_129(class144_2);
	}

	// Token: 0x0600048D RID: 1165 RVA: 0x0000515A File Offset: 0x0000335A
	private static Exception smethod_30(string string_0, string string_1)
	{
		return new MethodAccessException(Class87.smethod_3(string.Format(Class185.smethod_0(537696485), string_0), string.Format(Class185.smethod_0(537697951), string_1)));
	}

	// Token: 0x0600048E RID: 1166 RVA: 0x00005186 File Offset: 0x00003386
	private void method_299(Class144 class144_2)
	{
		this.method_55(true);
	}

	// Token: 0x0600048F RID: 1167 RVA: 0x0000518F File Offset: 0x0000338F
	private void method_300(Class144 class144_2)
	{
		throw new NotSupportedException(Class185.smethod_0(537697587));
	}

	// Token: 0x06000490 RID: 1168 RVA: 0x0002A218 File Offset: 0x00028418
	private void method_301(Class144 class144_2)
	{
		int int_ = ((Class150)class144_2).method_2();
		FieldInfo fieldInfo = this.method_122(int_);
		Class144 @class = Class104.smethod_1(this.method_218().vmethod_0(), fieldInfo.FieldType);
		fieldInfo.SetValue(null, @class.vmethod_0());
	}

	// Token: 0x04000215 RID: 533
	private readonly Class57<Class87.Struct39> class57_0;

	// Token: 0x04000216 RID: 534
	private Class67 class67_0;

	// Token: 0x04000217 RID: 535
	private Class183 class183_0;

	// Token: 0x04000218 RID: 536
	private static Type type_0;

	// Token: 0x04000219 RID: 537
	private object object_0;

	// Token: 0x0400021A RID: 538
	private Stream stream_0;

	// Token: 0x0400021B RID: 539
	private object[] object_1;

	// Token: 0x0400021C RID: 540
	private Class144[] class144_0;

	// Token: 0x0400021D RID: 541
	private Dictionary<MethodBase, object> dictionary_0;

	// Token: 0x0400021E RID: 542
	private static Type type_1;

	// Token: 0x0400021F RID: 543
	private static Type type_2;

	// Token: 0x04000220 RID: 544
	private Type[] type_3;

	// Token: 0x04000221 RID: 545
	private static Type type_4;

	// Token: 0x04000222 RID: 546
	private readonly Module module_0;

	// Token: 0x04000223 RID: 547
	private static readonly Dictionary<int, object> dictionary_1 = new Dictionary<int, object>();

	// Token: 0x04000224 RID: 548
	private uint? nullable_0;

	// Token: 0x04000225 RID: 549
	private Type type_5;

	// Token: 0x04000226 RID: 550
	private Class183 class183_1;

	// Token: 0x04000227 RID: 551
	private static object object_2;

	// Token: 0x04000228 RID: 552
	private Class144[] class144_1;

	// Token: 0x04000229 RID: 553
	private readonly Class177 class177_0;

	// Token: 0x0400022A RID: 554
	private readonly Class57<Class144> class57_1;

	// Token: 0x0400022B RID: 555
	private readonly Dictionary<MethodBase, int> dictionary_2;

	// Token: 0x0400022C RID: 556
	private static Type type_6;

	// Token: 0x0400022D RID: 557
	private bool bool_0;

	// Token: 0x0400022E RID: 558
	private static readonly Dictionary<MethodBase, DynamicMethod> dictionary_3 = new Dictionary<MethodBase, DynamicMethod>();

	// Token: 0x0400022F RID: 559
	private Dictionary<int, Class87.Class91> dictionary_4;

	// Token: 0x04000230 RID: 560
	private readonly Dictionary<Class87.Struct37, Class87.Delegate1> dictionary_5 = new Dictionary<Class87.Struct37, Class87.Delegate1>(256);

	// Token: 0x04000231 RID: 561
	private byte[] byte_0;

	// Token: 0x04000232 RID: 562
	private Type[] type_7;

	// Token: 0x04000233 RID: 563
	private static Type type_8;

	// Token: 0x04000234 RID: 564
	private bool bool_1;

	// Token: 0x04000235 RID: 565
	private long long_0;

	// Token: 0x04000236 RID: 566
	private Class123[] class123_0;

	// Token: 0x020000A4 RID: 164
	[Serializable]
	private sealed class Class88
	{
		// Token: 0x06000493 RID: 1171 RVA: 0x0002A260 File Offset: 0x00028460
		internal int method_0(Class123 class123_0, Class123 class123_1)
		{
			if (class123_0.method_6() == class123_1.method_6())
			{
				return class123_1.method_10().CompareTo(class123_0.method_10());
			}
			return class123_0.method_6().CompareTo(class123_1.method_6());
		}

		// Token: 0x04000237 RID: 567
		public static readonly Class87.Class88 class88_0 = new Class87.Class88();

		// Token: 0x04000238 RID: 568
		public static Comparison<Class123> comparison_0;
	}

	// Token: 0x020000A5 RID: 165
	private struct Struct37 : IEquatable<Class87.Struct37>
	{
		// Token: 0x06000494 RID: 1172 RVA: 0x000051AC File Offset: 0x000033AC
		public Struct37(MethodBase methodBase_1, bool bool_1)
		{
			this.methodBase_0 = methodBase_1;
			this.bool_0 = bool_1;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x000051BC File Offset: 0x000033BC
		public MethodBase method_0()
		{
			return this.methodBase_0;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x000051C4 File Offset: 0x000033C4
		public bool method_1()
		{
			return this.bool_0;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0002A2A4 File Offset: 0x000284A4
		public override int GetHashCode()
		{
			return this.method_0().GetHashCode() ^ this.method_1().GetHashCode();
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0002A2CC File Offset: 0x000284CC
		public override bool Equals(object obj)
		{
			if (obj is Class87.Struct37)
			{
				Class87.Struct37 other = (Class87.Struct37)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x000051CC File Offset: 0x000033CC
		public bool Equals(Class87.Struct37 other)
		{
			return this.method_0() == other.method_0() && this.method_1() == other.method_1();
		}

		// Token: 0x04000239 RID: 569
		private readonly MethodBase methodBase_0;

		// Token: 0x0400023A RID: 570
		private readonly bool bool_0;
	}

	// Token: 0x020000A6 RID: 166
	private struct Struct38
	{
		// Token: 0x0400023B RID: 571
		public bool bool_0;
	}

	// Token: 0x020000A7 RID: 167
	private sealed class Class89<T> : IComparer<KeyValuePair<int, T>>
	{
		// Token: 0x0600049A RID: 1178 RVA: 0x000051EE File Offset: 0x000033EE
		public Class89(Comparison<T> comparison_1)
		{
			this.comparison_0 = comparison_1;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0002A2F4 File Offset: 0x000284F4
		public int Compare(KeyValuePair<int, T> x, KeyValuePair<int, T> y)
		{
			int num = this.comparison_0(x.Value, y.Value);
			if (num == 0)
			{
				return y.Key.CompareTo(x.Key);
			}
			return num;
		}

		// Token: 0x0400023C RID: 572
		private readonly Comparison<T> comparison_0;
	}

	// Token: 0x020000A8 RID: 168
	private struct Struct39
	{
		// Token: 0x0600049C RID: 1180 RVA: 0x000051FD File Offset: 0x000033FD
		public Struct39(uint uint_1)
		{
			this.uint_0 = uint_1;
			this.object_0 = null;
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0000520D File Offset: 0x0000340D
		public Struct39(uint uint_1, object object_1)
		{
			this.uint_0 = uint_1;
			this.object_0 = object_1;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0000521D File Offset: 0x0000341D
		public uint method_0()
		{
			return this.uint_0;
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00005225 File Offset: 0x00003425
		public object method_1()
		{
			return this.object_0;
		}

		// Token: 0x0400023D RID: 573
		private readonly uint uint_0;

		// Token: 0x0400023E RID: 574
		private readonly object object_0;
	}

	// Token: 0x020000A9 RID: 169
	private sealed class Class90
	{
		// Token: 0x060004A1 RID: 1185 RVA: 0x0000522D File Offset: 0x0000342D
		public string method_0()
		{
			return this.string_0;
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00005235 File Offset: 0x00003435
		public void method_1(string string_1)
		{
			this.string_0 = string_1;
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0000523E File Offset: 0x0000343E
		public Type method_2()
		{
			return this.type_0;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00005246 File Offset: 0x00003446
		public void method_3(Type type_1)
		{
			this.type_0 = type_1;
		}

		// Token: 0x0400023F RID: 575
		private string string_0;

		// Token: 0x04000240 RID: 576
		private Type type_0;
	}

	// Token: 0x020000AA RID: 170
	// (Invoke) Token: 0x060004A6 RID: 1190
	private delegate object Delegate1(object object_0, object[] object_1);

	// Token: 0x020000AB RID: 171
	// (Invoke) Token: 0x060004AA RID: 1194
	private delegate void Delegate2(Class144 class144_0);

	// Token: 0x020000AC RID: 172
	private sealed class Class91
	{
		// Token: 0x060004AD RID: 1197 RVA: 0x0000524F File Offset: 0x0000344F
		public Class91(Class11 class11_1, Class87.Delegate2 delegate2_1)
		{
			this.class11_0 = class11_1;
			this.delegate2_0 = delegate2_1;
		}

		// Token: 0x04000241 RID: 577
		public Class11 class11_0;

		// Token: 0x04000242 RID: 578
		public Class87.Delegate2 delegate2_0;
	}
}
