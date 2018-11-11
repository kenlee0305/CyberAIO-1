using System;
using System.Runtime.CompilerServices;

// Token: 0x020000C7 RID: 199
internal struct Struct42
{
	// Token: 0x06000529 RID: 1321 RVA: 0x000057DF File Offset: 0x000039DF
	public Struct42(string string_0)
	{
		this.class58_0 = new Class58
		{
			class12_0 = Class125.smethod_0(string_0)
		};
	}

	// Token: 0x0600052B RID: 1323 RVA: 0x0002C364 File Offset: 0x0002A564
	private bool method_0(out string string_0)
	{
		string_0 = null;
		Class58 @class = this.class58_0;
		Class12 class2 = (@class != null) ? @class.class12_0 : null;
		if (class2 == null)
		{
			return true;
		}
		WeakReference weakReference_ = class2.weakReference_0;
		string_0 = (((weakReference_ != null) ? weakReference_.Target : null) as string);
		return string_0 != null;
	}

	// Token: 0x0600052C RID: 1324 RVA: 0x0002C3AC File Offset: 0x0002A5AC
	public string method_1()
	{
		string text;
		if (this.method_0(out text))
		{
			return text;
		}
		object obj = Struct42.object_0;
		lock (obj)
		{
			if (this.method_0(out text))
			{
				return text;
			}
			Class184 class184_ = this.class58_0.class12_0.class184_0;
			object obj2 = class184_.object_0;
			byte[] byte_;
			bool bool_;
			lock (obj2)
			{
				byte_ = class184_.byte_0;
				bool_ = class184_.bool_0;
				if (class184_.bool_1)
				{
					if (byte_ == null)
					{
						throw new Exception(Class185.smethod_0(537694803));
					}
				}
				else
				{
					WeakReference weakReference_ = this.class58_0.class12_0.weakReference_1;
					string text2 = ((weakReference_ != null) ? weakReference_.Target : null) as string;
					if (text2 == null)
					{
						throw new Exception(Class185.smethod_0(537694608));
					}
					text = string.Copy(text2);
					Class125.smethod_3(text2);
				}
				class184_.bool_1 = true;
			}
			if (text == null)
			{
				text = Class125.smethod_2(byte_, bool_);
			}
			this.method_2(text);
		}
		return text;
	}

	// Token: 0x0600052D RID: 1325 RVA: 0x0002C4CC File Offset: 0x0002A6CC
	private void method_2(string string_0)
	{
		Class83 @class;
		if (!Struct42.conditionalWeakTable_0.TryGetValue(string_0, out @class))
		{
			Class12 class2 = new Class12
			{
				class184_0 = new Class184(),
				weakReference_0 = new WeakReference(string_0),
				weakReference_1 = new WeakReference(string_0, true)
			};
			@class = new Class83(string_0, class2, class2.class184_0);
			Struct42.conditionalWeakTable_0.Add(string_0, @class);
		}
		this.class58_0.class12_0 = @class.class12_0;
	}

	// Token: 0x0600052E RID: 1326 RVA: 0x0002C540 File Offset: 0x0002A740
	public void method_3(string string_0)
	{
		object obj = Struct42.object_0;
		lock (obj)
		{
			if (string_0 == null)
			{
				this.class58_0 = null;
			}
			else
			{
				this.class58_0 = new Class58();
				this.method_2(string_0);
			}
		}
	}

	// Token: 0x0600052F RID: 1327 RVA: 0x0000580E File Offset: 0x00003A0E
	public void method_4()
	{
		this.method_3(null);
	}

	// Token: 0x04000280 RID: 640
	private static readonly ConditionalWeakTable<string, Class83> conditionalWeakTable_0 = new ConditionalWeakTable<string, Class83>();

	// Token: 0x04000281 RID: 641
	private static readonly object object_0 = new object();

	// Token: 0x04000282 RID: 642
	private Class58 class58_0;
}
