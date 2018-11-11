using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

// Token: 0x020000BE RID: 190
public sealed class GClass3
{
	// Token: 0x060004FD RID: 1277 RVA: 0x0002B554 File Offset: 0x00029754
	public GClass3()
	{
		Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Class185.smethod_0(537714282)));
		File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Class185.smethod_0(537701893)), GClass3.string_0);
		Timer timer = new Timer();
		timer.Interval = 5000;
		timer.Tick += this.method_0;
		timer.Start();
	}

	// Token: 0x060004FF RID: 1279 RVA: 0x0002B5CC File Offset: 0x000297CC
	public static string smethod_0(string string_1, string string_2)
	{
		string text = string.Format(Class185.smethod_0(537714165), new object[]
		{
			string_2,
			DateTime.Today.Date.ToShortDateString(),
			DateTime.UtcNow.ToString(Class185.smethod_0(537713939), CultureInfo.InvariantCulture),
			string_1
		}) + Environment.NewLine;
		GClass3.string_0 += text;
		if (Debugger.IsAttached)
		{
			Console.Out.WriteAsync(text);
		}
		return text;
	}

	// Token: 0x06000500 RID: 1280 RVA: 0x000055EB File Offset: 0x000037EB
	private void method_0(object sender, EventArgs e)
	{
		new Task(new Action(GClass3.Class103.class103_0.method_0)).Start();
	}

	// Token: 0x0400026D RID: 621
	private static string string_0 = string.Empty;

	// Token: 0x020000BF RID: 191
	[Serializable]
	private sealed class Class103
	{
		// Token: 0x06000503 RID: 1283 RVA: 0x0002B65C File Offset: 0x0002985C
		internal void method_0()
		{
			try
			{
				Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Class185.smethod_0(537714282)));
				File.AppendAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Class185.smethod_0(537701893)), GClass3.string_0);
				GClass3.string_0 = string.Empty;
			}
			catch
			{
			}
		}

		// Token: 0x0400026E RID: 622
		public static readonly GClass3.Class103 class103_0 = new GClass3.Class103();

		// Token: 0x0400026F RID: 623
		public static Action action_0;
	}
}
