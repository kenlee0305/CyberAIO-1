using System;
using System.IO;
using CyberAIO.Properties;
using Newtonsoft.Json.Linq;

// Token: 0x0200000B RID: 11
public static class GClass0
{
	// Token: 0x06000034 RID: 52 RVA: 0x00008A2C File Offset: 0x00006C2C
	public static void smethod_0()
	{
		try
		{
			GClass0.int_0 = Settings.Default.monitor_delay;
			GClass0.int_1 = Settings.Default.retry_delay;
			GClass0.string_1 = Settings.Default.webhook;
			GClass0.string_2 = Settings.Default.LicenseKey;
			GClass0.jarray_0 = (Settings.Default.proxies.smethod_9() ? JArray.Parse(Settings.Default.proxies) : new JArray());
			GClass0.jobject_0 = (Settings.Default.profiles.smethod_9() ? JObject.Parse(Settings.Default.profiles) : new JObject());
			GClass0.jobject_1 = (Settings.Default.tasks.smethod_9() ? JObject.Parse(Settings.Default.tasks) : new JObject());
			GClass0.jobject_3 = new JObject();
		}
		catch
		{
		}
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00008B18 File Offset: 0x00006D18
	public static void smethod_1()
	{
		if (!File.Exists(GClass0.string_0))
		{
			GClass0.smethod_2();
		}
		JObject jobject;
		try
		{
			jobject = JObject.Parse(File.ReadAllText(GClass0.string_0));
		}
		catch
		{
			jobject = new JObject();
		}
		GClass0.int_0 = (int)jobject[Class185.smethod_0(537699228)][Class185.smethod_0(537699262)];
		GClass0.int_1 = (int)jobject[Class185.smethod_0(537699228)][Class185.smethod_0(537714228)];
		GClass0.string_1 = (string)jobject[Class185.smethod_0(537699228)][Class185.smethod_0(537699234)];
		GClass0.bool_0 = (jobject[Class185.smethod_0(537699228)][Class185.smethod_0(537714214)] != null && (bool)jobject[Class185.smethod_0(537699228)][Class185.smethod_0(537714214)]);
		GClass0.string_2 = (string)jobject[Class185.smethod_0(537714250)];
		GClass0.jarray_0 = (JArray)jobject[Class185.smethod_0(537701503)];
		GClass0.jobject_0 = (JObject)jobject[Class185.smethod_0(537701485)];
		GClass0.jobject_1 = (JObject)jobject[Class185.smethod_0(537701443)];
		GClass0.jobject_3 = (((JObject)jobject[Class185.smethod_0(537714300)] != null) ? ((JObject)jobject[Class185.smethod_0(537714300)]) : new JObject());
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00002DF5 File Offset: 0x00000FF5
	public static void smethod_2()
	{
		GClass0.smethod_3();
		Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Class185.smethod_0(537714282)));
		File.WriteAllText(GClass0.string_0, GClass0.jobject_2.ToString());
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00008CCC File Offset: 0x00006ECC
	public static void smethod_3()
	{
		JObject jobject = new JObject();
		string propertyName = Class185.smethod_0(537699228);
		JObject jobject2 = new JObject();
		jobject2[Class185.smethod_0(537699262)] = GClass0.int_0;
		jobject2[Class185.smethod_0(537714228)] = GClass0.int_1;
		jobject2[Class185.smethod_0(537699234)] = GClass0.string_1;
		jobject2[Class185.smethod_0(537714214)] = GClass0.bool_0;
		jobject[propertyName] = jobject2;
		jobject[Class185.smethod_0(537701443)] = GClass0.jobject_1;
		jobject[Class185.smethod_0(537701503)] = GClass0.jarray_0;
		jobject[Class185.smethod_0(537701485)] = GClass0.jobject_0;
		jobject[Class185.smethod_0(537714250)] = GClass0.string_2;
		jobject[Class185.smethod_0(537714300)] = GClass0.jobject_3;
		GClass0.jobject_2 = jobject;
	}

	// Token: 0x04000027 RID: 39
	private static string string_0 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Class185.smethod_0(537714199));

	// Token: 0x04000028 RID: 40
	public static int int_0 = 2500;

	// Token: 0x04000029 RID: 41
	public static int int_1 = 2500;

	// Token: 0x0400002A RID: 42
	public static string string_1;

	// Token: 0x0400002B RID: 43
	public static string string_2;

	// Token: 0x0400002C RID: 44
	public static JArray jarray_0;

	// Token: 0x0400002D RID: 45
	public static JObject jobject_0;

	// Token: 0x0400002E RID: 46
	public static JObject jobject_1;

	// Token: 0x0400002F RID: 47
	public static JObject jobject_2;

	// Token: 0x04000030 RID: 48
	public static string string_3;

	// Token: 0x04000031 RID: 49
	public static bool bool_0;

	// Token: 0x04000032 RID: 50
	public static JObject jobject_3;
}
