using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EO.WebBrowser;

// Token: 0x020000E2 RID: 226
public sealed partial class GForm6 : Form
{
	// Token: 0x060005EA RID: 1514 RVA: 0x00035288 File Offset: 0x00033488
	public GForm6(string string_0)
	{
		this.method_2();
		this.webView_0 = new WebView();
		this.webView_0.Create(base.Handle);
		this.webView_0.BeforeContextMenu += this.method_0;
		this.webView_0.LoadUrlAndWait(string_0);
		new Thread(new ThreadStart(this.method_1)).Start();
	}

	// Token: 0x060005EB RID: 1515 RVA: 0x00002C72 File Offset: 0x00000E72
	private void method_0(object sender, BeforeContextMenuEventArgs e)
	{
		e.Menu.Items.Clear();
	}

	// Token: 0x060005EC RID: 1516 RVA: 0x000352F8 File Offset: 0x000334F8
	private void method_1()
	{
		while (!this.webView_0.GetHtml().Contains(Class185.smethod_0(537716551)))
		{
			Thread.Sleep(1000);
		}
		new Task(new Action(GForm6.Class124.class124_0.method_0)).Start();
	}

	// Token: 0x060005ED RID: 1517 RVA: 0x00005FF4 File Offset: 0x000041F4
	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		base.OnFormClosing(e);
		if (e.CloseReason == CloseReason.UserClosing)
		{
			Class173.form_0 = null;
		}
	}

	// Token: 0x060005EF RID: 1519 RVA: 0x00035358 File Offset: 0x00033558
	private void method_2()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm6));
		base.SuspendLayout();
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(620, 615);
		base.Icon = (Icon)componentResourceManager.GetObject(Class185.smethod_0(537704548));
		base.Name = Class185.smethod_0(537716599);
		this.Text = Class185.smethod_0(537716581);
		base.ResumeLayout(false);
	}

	// Token: 0x040002D5 RID: 725
	public WebView webView_0;

	// Token: 0x020000E3 RID: 227
	[Serializable]
	private sealed class Class124
	{
		// Token: 0x060005F2 RID: 1522 RVA: 0x000353F0 File Offset: 0x000335F0
		internal void method_0()
		{
			GForm1.webView_0.QueueScriptCall(Class185.smethod_0(537714943));
			for (int i = 0; i < 5; i++)
			{
				GForm3.smethod_11(GClass0.string_2, false, true);
				if (GForm3.dateTime_0 > Class173.dateTime_0)
				{
					GForm1.webView_0.QueueScriptCall(Class185.smethod_0(537714806));
					Class68.smethod_1();
					return;
				}
				Thread.Sleep(3000);
			}
			GForm1.webView_0.QueueScriptCall(Class185.smethod_0(537716720));
		}

		// Token: 0x040002D7 RID: 727
		public static readonly GForm6.Class124 class124_0 = new GForm6.Class124();

		// Token: 0x040002D8 RID: 728
		public static Action action_0;
	}
}
