using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EO.WebBrowser;
using Newtonsoft.Json.Linq;

// Token: 0x02000077 RID: 119
internal sealed class Class68
{
	// Token: 0x060002A6 RID: 678 RVA: 0x00018A7C File Offset: 0x00016C7C
	public static void smethod_0(object object_0, JSExtInvokeArgs jsextInvokeArgs_0)
	{
		Class173.string_1 = jsextInvokeArgs_0.Arguments.First<object>().ToString();
		JObject jobject = JObject.Parse(GForm1.webView_0.QueueScriptCall(Class185.smethod_0(537700382)).smethod_0());
		foreach (KeyValuePair<string, JToken> keyValuePair in jobject)
		{
			if (Class173.jobject_4.ContainsKey(keyValuePair.Value[Class185.smethod_0(537700413)].ToString()) && Class173.string_1.Replace(Class185.smethod_0(537700393), string.Empty).Contains(new Uri(Class173.jobject_4[keyValuePair.Value[Class185.smethod_0(537700413)].ToString()][Class185.smethod_0(537700388)].ToString().Replace(Class185.smethod_0(537700393), string.Empty)).Host))
			{
				GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537700434), Class173.string_1.Replace(Class185.smethod_0(537700459), Class185.smethod_0(537700451)), keyValuePair.Value[Class185.smethod_0(537703519)].ToString()));
				keyValuePair.Value[Class185.smethod_0(537702300)] = Class173.string_1;
			}
		}
		GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537702283), jobject.ToString().smethod_6().Replace(Class185.smethod_0(537700459), Class185.smethod_0(537700451))));
	}

	// Token: 0x060002A7 RID: 679 RVA: 0x00018C58 File Offset: 0x00016E58
	public static void smethod_1()
	{
		Version version = Assembly.GetEntryAssembly().GetName().Version;
		GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537702318), GClass0.string_2));
		GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537702350), version));
		GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537702174), GClass0.int_1));
		GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537702199), GClass0.int_0));
		GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537702199), GClass0.int_0));
		GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537702209), GClass0.string_1));
		GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537702246), GForm3.dateTime_0.ToShortDateString()));
		GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537702143), GClass0.bool_0.ToString().ToLower()));
	}

	// Token: 0x060002A8 RID: 680 RVA: 0x000044B0 File Offset: 0x000026B0
	public static void smethod_2(object object_0, JSExtInvokeArgs jsextInvokeArgs_0)
	{
		Process.Start(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Class185.smethod_0(537701893)));
	}

	// Token: 0x060002A9 RID: 681 RVA: 0x000044CE File Offset: 0x000026CE
	public static void smethod_3(object object_0, JSExtInvokeArgs jsextInvokeArgs_0)
	{
		GClass0.jobject_0 = JObject.Parse(GForm1.webView_0.QueueScriptCall(Class185.smethod_0(537703472)).smethod_0());
		GClass0.smethod_2();
	}

	// Token: 0x060002AA RID: 682 RVA: 0x000044F8 File Offset: 0x000026F8
	public static void smethod_4(object object_0, JSExtInvokeArgs jsextInvokeArgs_0)
	{
		GClass0.jobject_1 = JObject.Parse(GForm1.webView_0.QueueScriptCall(Class185.smethod_0(537700382)).smethod_0());
		GClass0.smethod_2();
	}

	// Token: 0x060002AB RID: 683 RVA: 0x00004522 File Offset: 0x00002722
	public static void smethod_5(object object_0, JSExtInvokeArgs jsextInvokeArgs_0)
	{
		GClass0.jarray_0 = JArray.Parse(GForm1.webView_0.QueueScriptCall(Class185.smethod_0(537701932)).smethod_0());
		GClass0.smethod_2();
	}

	// Token: 0x060002AC RID: 684 RVA: 0x0000454C File Offset: 0x0000274C
	public static void smethod_6()
	{
		GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537701965), GClass0.jobject_0.ToString().smethod_6().smethod_4()));
	}

	// Token: 0x060002AD RID: 685 RVA: 0x0000457C File Offset: 0x0000277C
	public static void smethod_7()
	{
		GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537702007), GClass0.jobject_1.ToString().smethod_6().smethod_4()));
	}

	// Token: 0x060002AE RID: 686 RVA: 0x000045AC File Offset: 0x000027AC
	public static void smethod_8()
	{
		GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537701790), GClass0.jarray_0.ToString().smethod_6().smethod_4()));
	}

	// Token: 0x060002AF RID: 687 RVA: 0x00018D88 File Offset: 0x00016F88
	public static void smethod_9(object object_0, JSExtInvokeArgs jsextInvokeArgs_0)
	{
		GClass0.int_1 = (int)Convert.ToInt16(GForm1.webView_0.QueueScriptCall(Class185.smethod_0(537701767)).smethod_0());
		GClass0.int_0 = (int)Convert.ToInt16(GForm1.webView_0.QueueScriptCall(Class185.smethod_0(537701797)).smethod_0());
		GClass0.string_1 = GForm1.webView_0.QueueScriptCall(Class185.smethod_0(537701828)).smethod_0();
		GClass0.bool_0 = (GForm1.webView_0.QueueScriptCall(Class185.smethod_0(537701870)).smethod_0() == Class185.smethod_0(537692590));
		GForm1.webView_0.QueueScriptCall(Class185.smethod_0(537701674));
		GClass0.smethod_2();
	}

	// Token: 0x060002B0 RID: 688 RVA: 0x000045DC File Offset: 0x000027DC
	public static void smethod_10(object object_0, JSExtInvokeArgs jsextInvokeArgs_0)
	{
		Process.Start(Class185.smethod_0(537701734) + GClass0.string_2);
	}

	// Token: 0x060002B1 RID: 689 RVA: 0x000045F8 File Offset: 0x000027F8
	public static void smethod_11(object object_0, JSExtInvokeArgs jsextInvokeArgs_0)
	{
		GForm1.webView_0.QueueScriptCall(Class185.smethod_0(537701587));
		new Task(new Action(Class68.Class69.class69_0.method_0)).Start();
	}

	// Token: 0x060002B2 RID: 690 RVA: 0x00018E40 File Offset: 0x00017040
	public static void smethod_12(object object_0, JSExtInvokeArgs jsextInvokeArgs_0)
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.Filter = Class185.smethod_0(537701386);
		saveFileDialog.Title = Class185.smethod_0(537701431);
		saveFileDialog.FileName = Class185.smethod_0(537701469);
		if (saveFileDialog.ShowDialog() == DialogResult.OK)
		{
			JObject jobject = new JObject();
			jobject[Class185.smethod_0(537701443)] = GClass0.jobject_1;
			jobject[Class185.smethod_0(537701503)] = GClass0.jarray_0;
			jobject[Class185.smethod_0(537701485)] = GClass0.jobject_0;
			jobject[Class185.smethod_0(537699228)] = new JObject();
			jobject[Class185.smethod_0(537699228)][Class185.smethod_0(537699211)] = GClass0.int_1;
			jobject[Class185.smethod_0(537699228)][Class185.smethod_0(537699262)] = GClass0.int_0;
			jobject[Class185.smethod_0(537699228)][Class185.smethod_0(537699234)] = GClass0.string_1;
			StreamWriter streamWriter = new StreamWriter(saveFileDialog.OpenFile());
			streamWriter.WriteLine(jobject.ToString());
			streamWriter.Dispose();
			streamWriter.Close();
		}
	}

	// Token: 0x060002B3 RID: 691 RVA: 0x00018F88 File Offset: 0x00017188
	public static void smethod_13(object object_0, JSExtInvokeArgs jsextInvokeArgs_0)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = Class185.smethod_0(537699280);
		openFileDialog.Title = Class185.smethod_0(537699326);
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			JObject jobject = JObject.Parse(new StreamReader(openFileDialog.FileName).ReadToEnd().ToString());
			GForm1.webView_0.QueueScriptCall(Class185.smethod_0(537699100)).smethod_0();
			GForm1.webView_0.QueueScriptCall(Class185.smethod_0(537699181)).smethod_0();
			GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537702007), jobject[Class185.smethod_0(537701443)].ToString().smethod_6()));
			GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537701790), jobject[Class185.smethod_0(537701503)].ToString().smethod_6()));
			GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537699025), jobject[Class185.smethod_0(537701485)].ToString().smethod_6()));
			GClass0.jarray_0 = JArray.Parse(jobject[Class185.smethod_0(537701503)].ToString());
			GClass0.jobject_0 = JObject.Parse(jobject[Class185.smethod_0(537701485)].ToString());
			GClass0.jobject_1 = JObject.Parse(jobject[Class185.smethod_0(537701443)].ToString());
			GClass0.int_1 = (int)jobject[Class185.smethod_0(537699228)][Class185.smethod_0(537699211)];
			GClass0.int_0 = (int)jobject[Class185.smethod_0(537699228)][Class185.smethod_0(537699262)];
			GClass0.string_1 = ((jobject[Class185.smethod_0(537699228)][Class185.smethod_0(537699234)] == null) ? string.Empty : jobject[Class185.smethod_0(537699228)][Class185.smethod_0(537699234)].ToString());
			Class68.smethod_1();
			GForm1.webView_0.QueueScriptCall(Class185.smethod_0(537699067));
			GClass0.smethod_2();
		}
	}

	// Token: 0x02000078 RID: 120
	[Serializable]
	private sealed class Class69
	{
		// Token: 0x060002B6 RID: 694 RVA: 0x000191D4 File Offset: 0x000173D4
		internal void method_0()
		{
			try
			{
				GForm3.smethod_8();
				GForm1.webView_0.QueueScriptCall(Class185.smethod_0(537700728));
				Thread.Sleep(1500);
				GForm1.gform1_0.method_9(null, null);
			}
			catch
			{
				GForm1.webView_0.QueueScriptCall(Class185.smethod_0(537700543));
			}
		}

		// Token: 0x0400016D RID: 365
		public static readonly Class68.Class69 class69_0 = new Class68.Class69();

		// Token: 0x0400016E RID: 366
		public static Action action_0;
	}
}
