using System;

// Token: 0x0200009F RID: 159
internal sealed class Class83
{
	// Token: 0x06000337 RID: 823 RVA: 0x000049C1 File Offset: 0x00002BC1
	public Class83(string string_1, Class12 class12_1, Class184 class184_1)
	{
		this.string_0 = string_1;
		this.class12_0 = class12_1;
		this.class184_0 = class184_1;
	}

	// Token: 0x06000338 RID: 824 RVA: 0x0001E648 File Offset: 0x0001C848
	protected override void Finalize()
	{
		try
		{
			object object_ = this.class184_0.object_0;
			lock (object_)
			{
				if (!this.class184_0.bool_1)
				{
					this.class184_0.byte_0 = Class125.smethod_1(this.string_0);
					this.class184_0.bool_1 = true;
					Class125.smethod_3(this.string_0);
				}
			}
		}
		finally
		{
			base.Finalize();
		}
	}

	// Token: 0x04000208 RID: 520
	public readonly string string_0;

	// Token: 0x04000209 RID: 521
	public readonly Class12 class12_0;

	// Token: 0x0400020A RID: 522
	public readonly Class184 class184_0;
}
