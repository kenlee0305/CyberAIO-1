using System;
using System.IO;
using System.Windows.Forms;
using EO.WebBrowser;
using Newtonsoft.Json.Linq;

// Token: 0x02000050 RID: 80
internal sealed class Class46
{
	// Token: 0x060001BB RID: 443 RVA: 0x00012774 File Offset: 0x00010974
	public static void smethod_0(object object_0, JSExtInvokeArgs jsextInvokeArgs_0)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = Class185.smethod_0(537703556);
		openFileDialog.Title = Class185.smethod_0(537703599);
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			JObject jobject = JObject.Parse(new StreamReader(openFileDialog.FileName).ReadToEnd().ToString());
			string code = string.Format(Class185.smethod_0(537703631), jobject.ToString().Replace(Class185.smethod_0(537703659), string.Empty).Replace(Class185.smethod_0(537703651), string.Empty));
			GForm1.webView_0.EvalScript(code);
		}
	}

	// Token: 0x060001BC RID: 444 RVA: 0x00012818 File Offset: 0x00010A18
	public static void smethod_1(object object_0, JSExtInvokeArgs jsextInvokeArgs_0)
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.Filter = Class185.smethod_0(537703556);
		saveFileDialog.Title = Class185.smethod_0(537703451);
		saveFileDialog.FileName = Class185.smethod_0(537703425);
		if (saveFileDialog.ShowDialog() == DialogResult.OK)
		{
			StreamWriter streamWriter = new StreamWriter(saveFileDialog.OpenFile());
			streamWriter.WriteLine(GForm1.webView_0.EvalScript(Class185.smethod_0(537703472)).ToString());
			streamWriter.Dispose();
		}
	}
}
