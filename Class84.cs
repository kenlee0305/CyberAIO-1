using System;
using System.Linq;
using System.Threading;
using Newtonsoft.Json.Linq;

// Token: 0x020000A0 RID: 160
internal sealed class Class84
{
	// Token: 0x06000339 RID: 825 RVA: 0x0001E6D4 File Offset: 0x0001C8D4
	public Class84(string string_5, Class4 class4_1, JToken jtoken_1)
	{
		this.class4_0 = class4_1;
		this.jtoken_0 = jtoken_1;
		this.string_3 = GClass2.smethod_2(32);
		this.string_1 = new Uri(string_5).Query.Split(new char[]
		{
			'&'
		}).Where(new Func<string, bool>(Class84.Class85.class85_0.method_0)).First<string>().Split(new char[]
		{
			'='
		})[1];
		this.string_0 = string.Format(Class185.smethod_0(537685390), this.string_1);
	}

	// Token: 0x0600033A RID: 826 RVA: 0x000049DE File Offset: 0x00002BDE
	public void method_0()
	{
		this.method_1();
		this.method_2();
	}

	// Token: 0x0600033B RID: 827 RVA: 0x0001E798 File Offset: 0x0001C998
	public void method_1()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537685253), Class185.smethod_0(537700781), true, false);
				JObject jobject = JObject.Parse(this.class70_0.method_5(this.string_0, true).smethod_3().Split(new string[]
				{
					Class185.smethod_0(537685295)
				}, StringSplitOptions.None)[1].Split(new string[]
				{
					Class185.smethod_0(537685343)
				}, StringSplitOptions.None)[0]);
				this.string_4 = (string)jobject[Class185.smethod_0(537706797)][Class185.smethod_0(537685326)][Class185.smethod_0(537703519)];
				this.string_2 = (string)jobject[Class185.smethod_0(537685373)][Class185.smethod_0(537685352)];
				GClass3.smethod_0(Class185.smethod_0(537685347) + this.string_4, Class185.smethod_0(537685131));
				GClass3.smethod_0(Class185.smethod_0(537685176) + this.string_2, Class185.smethod_0(537685131));
			}
			catch (ThreadAbortException)
			{
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537685161), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_1);
				continue;
			}
			break;
		}
	}

	// Token: 0x0600033C RID: 828 RVA: 0x0001E934 File Offset: 0x0001CB34
	public void method_2()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537660830), Class185.smethod_0(537700964), true, false);
				JObject jobject = JObject.Parse(Class185.smethod_0(537685193));
				jobject[Class185.smethod_0(537706797)][Class185.smethod_0(537715717)][Class185.smethod_0(537662508)] = this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662508)];
				jobject[Class185.smethod_0(537706797)][Class185.smethod_0(537715717)][Class185.smethod_0(537662540)] = this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662540)];
				jobject[Class185.smethod_0(537706797)][Class185.smethod_0(537715717)][Class185.smethod_0(537662792)] = this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537662792)];
				jobject[Class185.smethod_0(537706797)][Class185.smethod_0(537682418)][Class185.smethod_0(537677050)] = this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662571)];
				jobject[Class185.smethod_0(537706797)][Class185.smethod_0(537682418)][Class185.smethod_0(537660290)] = this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660290)];
				jobject[Class185.smethod_0(537706797)][Class185.smethod_0(537682418)][Class185.smethod_0(537660385)] = Class172.smethod_1((string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)], (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660385)]);
				jobject[Class185.smethod_0(537706797)][Class185.smethod_0(537682418)][Class185.smethod_0(537682200)] = this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660362)];
				jobject[Class185.smethod_0(537706797)][Class185.smethod_0(537682418)][Class185.smethod_0(537660334)] = Class172.smethod_0((string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)], false);
				jobject[Class185.smethod_0(537706797)][Class185.smethod_0(537682186)][Class185.smethod_0(537662508)] = this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662508)];
				jobject[Class185.smethod_0(537706797)][Class185.smethod_0(537682186)][Class185.smethod_0(537662540)] = this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662540)];
				jobject[Class185.smethod_0(537706797)][Class185.smethod_0(537682186)][Class185.smethod_0(537677050)] = this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662571)];
				jobject[Class185.smethod_0(537706797)][Class185.smethod_0(537682186)][Class185.smethod_0(537660290)] = this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660290)];
				jobject[Class185.smethod_0(537706797)][Class185.smethod_0(537682186)][Class185.smethod_0(537660385)] = Class172.smethod_1((string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)]);
				jobject[Class185.smethod_0(537706797)][Class185.smethod_0(537682186)][Class185.smethod_0(537682200)] = this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660362)];
				jobject[Class185.smethod_0(537706797)][Class185.smethod_0(537682186)][Class185.smethod_0(537660334)] = Class172.smethod_0((string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], false);
				jobject[Class185.smethod_0(537706797)][Class185.smethod_0(537660356)][Class185.smethod_0(537660835)] = this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)];
				jobject[Class185.smethod_0(537706797)][Class185.smethod_0(537660840)][Class185.smethod_0(537676350)] = Class185.smethod_0(537682225);
				jobject[Class185.smethod_0(537706797)][Class185.smethod_0(537660840)][Class185.smethod_0(537660835)] = this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660835)].ToString().Replace(Class185.smethod_0(537711014), string.Empty);
				jobject[Class185.smethod_0(537706797)][Class185.smethod_0(537660840)][Class185.smethod_0(537682210)] = this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660870)];
				jobject[Class185.smethod_0(537706797)][Class185.smethod_0(537660840)][Class185.smethod_0(537682261)] = this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660699)];
				jobject[Class185.smethod_0(537706797)][Class185.smethod_0(537660840)][Class185.smethod_0(537682247)] = this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660682)];
				jobject[Class185.smethod_0(537706797)][Class185.smethod_0(537682283)][Class185.smethod_0(537682071)][Class185.smethod_0(537703519)] = this.string_4;
				jobject[Class185.smethod_0(537685373)][Class185.smethod_0(537692633)] = this.string_1;
				jobject[Class185.smethod_0(537685373)][Class185.smethod_0(537685352)] = this.string_2;
				jobject[Class185.smethod_0(537685373)][Class185.smethod_0(537682098)] = this.string_3;
				this.class70_0.method_9(Class185.smethod_0(537682093), jobject, false);
			}
			catch (ThreadAbortException)
			{
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537660605), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_1);
				continue;
			}
			break;
		}
	}

	// Token: 0x0400020B RID: 523
	private Class70 class70_0 = new Class70(null, Class185.smethod_0(537692910), 10, false, false, null, false);

	// Token: 0x0400020C RID: 524
	private JToken jtoken_0;

	// Token: 0x0400020D RID: 525
	private Class4 class4_0;

	// Token: 0x0400020E RID: 526
	private string string_0;

	// Token: 0x0400020F RID: 527
	private string string_1;

	// Token: 0x04000210 RID: 528
	private string string_2;

	// Token: 0x04000211 RID: 529
	private string string_3;

	// Token: 0x04000212 RID: 530
	private string string_4;

	// Token: 0x020000A1 RID: 161
	[Serializable]
	private sealed class Class85
	{
		// Token: 0x0600033F RID: 831 RVA: 0x000049F8 File Offset: 0x00002BF8
		internal bool method_0(string string_0)
		{
			return string_0.Contains(Class185.smethod_0(537692633));
		}

		// Token: 0x04000213 RID: 531
		public static readonly Class84.Class85 class85_0 = new Class84.Class85();

		// Token: 0x04000214 RID: 532
		public static Func<string, bool> func_0;
	}
}
