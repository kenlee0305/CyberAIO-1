using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using EO.WebBrowser;
using EO.WebEngine;

// Token: 0x02000004 RID: 4
public sealed partial class GForm0 : Form
{
	// Token: 0x0600000B RID: 11 RVA: 0x00006F8C File Offset: 0x0000518C
	public GForm0()
	{
		this.method_4();
		this.method_0();
		System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
		timer.Interval = 500;
		timer.Tick += GForm0.smethod_3;
		timer.Start();
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00006FE0 File Offset: 0x000051E0
	public void method_0()
	{
		BrowserOptions options = new BrowserOptions
		{
			EnableXSSAuditor = new bool?(false),
			EnableWebSecurity = new bool?(false)
		};
		GForm0.webView_0 = new WebView();
		GForm0.webView_0.SetOptions(options);
		GForm0.webView_0.Create(this.panel_0.Handle);
		GForm0.webView_0.RegisterJSExtensionFunction(Class185.smethod_0(537692509), new JSExtInvokeHandler(this.method_1));
		GForm0.webView_0.CertificateError += this.method_3;
		GForm0.webView_0.BeforeContextMenu += this.method_2;
		GForm0.concurrentDictionary_1[Class185.smethod_0(537706437)] = true;
		GForm0.webView_1 = this.threadRunner_0.CreateWebView();
		GForm0.webView_1.SetOptions(options);
		GForm0.webView_1.RegisterJSExtensionFunction(Class185.smethod_0(537692509), new JSExtInvokeHandler(this.method_1));
		GForm0.webView_1.CertificateError += this.method_3;
		GForm0.webView_1.BeforeContextMenu += this.method_2;
		GForm0.concurrentDictionary_1[Class185.smethod_0(537706077)] = true;
		GForm0.webView_2 = this.threadRunner_0.CreateWebView();
		GForm0.webView_2.SetOptions(options);
		GForm0.webView_2.RegisterJSExtensionFunction(Class185.smethod_0(537692509), new JSExtInvokeHandler(this.method_1));
		GForm0.webView_2.CertificateError += this.method_3;
		GForm0.webView_2.BeforeContextMenu += this.method_2;
		GForm0.concurrentDictionary_1[Class185.smethod_0(537706060)] = true;
		GForm0.webView_3 = this.threadRunner_0.CreateWebView();
		GForm0.webView_3.SetOptions(options);
		GForm0.webView_3.RegisterJSExtensionFunction(Class185.smethod_0(537692509), new JSExtInvokeHandler(this.method_1));
		GForm0.webView_3.CertificateError += this.method_3;
		GForm0.webView_3.BeforeContextMenu += this.method_2;
		GForm0.concurrentDictionary_1[Class185.smethod_0(537706107)] = true;
		GForm0.smethod_7();
		this.gform2_0 = new GForm2();
	}

	// Token: 0x0600000E RID: 14 RVA: 0x0000721C File Offset: 0x0000541C
	private void method_1(object object_0, JSExtInvokeArgs jsextInvokeArgs_0)
	{
		GForm0.Class1 @class = new GForm0.Class1();
		@class.jsextInvokeArgs_0 = jsextInvokeArgs_0;
		GForm0.concurrentDictionary_0[@class.jsextInvokeArgs_0.Arguments[1].ToString()] = @class.jsextInvokeArgs_0.Arguments.First<object>().ToString();
		ConcurrentDictionary<string, string> concurrentDictionary = GForm0.list_0.Where(new Func<ConcurrentDictionary<string, string>, bool>(@class.method_0)).First<ConcurrentDictionary<string, string>>();
		GForm0.list_0.Remove(concurrentDictionary);
		GForm0.concurrentDictionary_1[concurrentDictionary[Class185.smethod_0(537706450)]] = true;
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002C1D File Offset: 0x00000E1D
	public static string smethod_0(string string_0, string string_1, string string_2)
	{
		return string.Empty;
	}

	// Token: 0x06000010 RID: 16 RVA: 0x000072AC File Offset: 0x000054AC
	public static string smethod_1(string string_0, string string_1, string string_2)
	{
		if (string_1.Contains(Class185.smethod_0(537692180)) && GForm3.string_0.Contains(Class185.smethod_0(537706090)))
		{
			return GForm0.smethod_0(string_0, string_1, string_2);
		}
		if (!GForm1.gform7_0.Visible)
		{
			GForm1.gform1_0.Invoke(new MethodInvoker(GForm0.Class0.class0_0.method_0));
		}
		string text = Class108.smethod_0(16);
		ConcurrentDictionary<string, string> concurrentDictionary = new ConcurrentDictionary<string, string>();
		concurrentDictionary[Class185.smethod_0(537692629)] = string_0;
		concurrentDictionary[Class185.smethod_0(537692611)] = string_1;
		concurrentDictionary[Class185.smethod_0(537692656)] = string_2;
		concurrentDictionary[Class185.smethod_0(537692633)] = text;
		concurrentDictionary[Class185.smethod_0(537706414)] = Class185.smethod_0(537692590);
		concurrentDictionary[Class185.smethod_0(537692776)] = Class185.smethod_0(537692774);
		GForm0.list_0.Add(concurrentDictionary);
		string result;
		try
		{
			while (!GForm0.concurrentDictionary_0.ContainsKey(text))
			{
				Thread.Sleep(100);
			}
			result = GForm0.concurrentDictionary_0[text];
		}
		catch (ThreadAbortException)
		{
			GForm0.list_0.Remove(concurrentDictionary);
			if (concurrentDictionary.ContainsKey(Class185.smethod_0(537706450)))
			{
				GForm0.concurrentDictionary_1[concurrentDictionary[Class185.smethod_0(537706450)]] = true;
			}
			Thread.CurrentThread.Abort();
			result = string.Empty;
		}
		catch
		{
			result = string.Empty;
		}
		return result;
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00007448 File Offset: 0x00005648
	public static WebView smethod_2(bool bool_1, out bool bool_2, out bool bool_3, out string string_0)
	{
		if (GForm0.concurrentDictionary_1[Class185.smethod_0(537706437)])
		{
			GForm0.concurrentDictionary_1[Class185.smethod_0(537706437)] = false;
			bool_2 = false;
			bool_3 = true;
			string_0 = Class185.smethod_0(537706437);
			GClass3.smethod_0(Class185.smethod_0(537705886), Class185.smethod_0(537705917));
			return GForm0.webView_0;
		}
		if (bool_1)
		{
			GForm0.concurrentDictionary_1.Where(new Func<KeyValuePair<string, bool>, bool>(GForm0.Class0.class0_0.method_1));
			if (GForm0.concurrentDictionary_1[Class185.smethod_0(537706077)])
			{
				GForm0.concurrentDictionary_1[Class185.smethod_0(537706077)] = false;
				bool_2 = true;
				bool_3 = true;
				string_0 = Class185.smethod_0(537706077);
				GClass3.smethod_0(Class185.smethod_0(537705890), Class185.smethod_0(537705917));
				return GForm0.webView_1;
			}
			if (GForm0.concurrentDictionary_1[Class185.smethod_0(537706060)])
			{
				GForm0.concurrentDictionary_1[Class185.smethod_0(537706060)] = false;
				bool_2 = true;
				bool_3 = true;
				string_0 = Class185.smethod_0(537706060);
				GClass3.smethod_0(Class185.smethod_0(537705934), Class185.smethod_0(537705917));
				return GForm0.webView_2;
			}
			if (GForm0.concurrentDictionary_1[Class185.smethod_0(537706107)])
			{
				GForm0.concurrentDictionary_1[Class185.smethod_0(537706107)] = false;
				bool_2 = true;
				bool_3 = true;
				string_0 = Class185.smethod_0(537706107);
				GClass3.smethod_0(Class185.smethod_0(537705962), Class185.smethod_0(537705917));
				return GForm0.webView_2;
			}
		}
		bool_3 = false;
		bool_2 = false;
		string_0 = string.Empty;
		return null;
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002C24 File Offset: 0x00000E24
	public static void smethod_3(object sender, EventArgs e)
	{
		new Task(new Action(GForm0.Class0.class0_0.method_2)).Start();
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00007608 File Offset: 0x00005808
	public static string smethod_4(string string_0, string string_1, string string_2, string string_3)
	{
		GForm0.bool_0 = true;
		return string.Concat(new string[]
		{
			Class185.smethod_0(537705750),
			string_2,
			Class185.smethod_0(537693956),
			string_0,
			Class185.smethod_0(537693854),
			string_1,
			Class185.smethod_0(537693735),
			new Uri(string_3).Host,
			Class185.smethod_0(537705634)
		});
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00007684 File Offset: 0x00005884
	public static string smethod_5(string string_0, string string_1)
	{
		GForm0.bool_0 = true;
		return string.Concat(new string[]
		{
			Class185.smethod_0(537693202),
			string_1,
			Class185.smethod_0(537691015),
			string_0,
			Class185.smethod_0(537690966)
		});
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002C4F File Offset: 0x00000E4F
	public static string smethod_6()
	{
		GForm0.bool_0 = false;
		return Class185.smethod_0(537703388);
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002C61 File Offset: 0x00000E61
	public static void smethod_7()
	{
		GForm0.webView_0.LoadHtmlAndWait(GForm0.smethod_6());
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002C72 File Offset: 0x00000E72
	private void method_2(object sender, BeforeContextMenuEventArgs e)
	{
		e.Menu.Items.Clear();
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002C84 File Offset: 0x00000E84
	public void method_3(object sender, CertificateErrorEventArgs e)
	{
		e.Continue();
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002C8C File Offset: 0x00000E8C
	private void pictureBox_0_Click(object sender, EventArgs e)
	{
		base.Hide();
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002C94 File Offset: 0x00000E94
	private void pictureBox_1_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002C9D File Offset: 0x00000E9D
	private void bunifuThinButton2_1_Click(object sender, EventArgs e)
	{
		this.gform2_0.Show();
		this.gform2_0.webView_0.LoadUrl(Class185.smethod_0(537691677));
	}

	// Token: 0x0600001C RID: 28 RVA: 0x000076D4 File Offset: 0x000058D4
	private void bunifuThinButton2_0_Click(object sender, EventArgs e)
	{
		GForm0.webView_0.Engine.Stop(true);
		GForm0.webView_0.Dispose();
		this.method_0();
		this.gform2_0.webView_0.Dispose();
		this.gform2_0.method_0(null);
		GForm0.list_0.ForEach(new Action<ConcurrentDictionary<string, string>>(GForm0.Class0.class0_0.method_4));
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00007748 File Offset: 0x00005948
	private void method_4()
	{
		this.icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm7));
		this.bunifuElipse_0 = new BunifuElipse(this.icontainer_0);
		this.panel_0 = new Panel();
		this.panel_1 = new Panel();
		this.pictureBox_0 = new PictureBox();
		this.pictureBox_1 = new PictureBox();
		this.label_0 = new Label();
		this.bunifuDragControl_0 = new BunifuDragControl(this.icontainer_0);
		this.panel_2 = new Panel();
		this.pictureBox_2 = new PictureBox();
		this.bunifuThinButton2_0 = new BunifuThinButton2();
		this.pictureBox_3 = new PictureBox();
		this.bunifuThinButton2_1 = new BunifuThinButton2();
		this.panel_1.SuspendLayout();
		((ISupportInitialize)this.pictureBox_0).BeginInit();
		((ISupportInitialize)this.pictureBox_1).BeginInit();
		this.panel_2.SuspendLayout();
		((ISupportInitialize)this.pictureBox_2).BeginInit();
		((ISupportInitialize)this.pictureBox_3).BeginInit();
		base.SuspendLayout();
		this.bunifuElipse_0.ElipseRadius = 10;
		this.bunifuElipse_0.TargetControl = this;
		this.panel_0.BackColor = Color.FromArgb(25, 23, 26);
		this.panel_0.Dock = DockStyle.Fill;
		this.panel_0.Location = new Point(0, 52);
		this.panel_0.Name = Class185.smethod_0(537704240);
		this.panel_0.Size = new Size(439, 497);
		this.panel_0.TabIndex = 0;
		this.panel_1.BackColor = Color.FromArgb(25, 23, 26);
		this.panel_1.Controls.Add(this.pictureBox_0);
		this.panel_1.Controls.Add(this.pictureBox_1);
		this.panel_1.Controls.Add(this.label_0);
		this.panel_1.Dock = DockStyle.Top;
		this.panel_1.Location = new Point(0, 0);
		this.panel_1.Name = Class185.smethod_0(537691434);
		this.panel_1.Size = new Size(439, 52);
		this.panel_1.TabIndex = 1;
		this.pictureBox_0.Cursor = Cursors.Hand;
		this.pictureBox_0.Image = (Image)componentResourceManager.GetObject(Class185.smethod_0(537691267));
		this.pictureBox_0.Location = new Point(400, 9);
		this.pictureBox_0.Name = Class185.smethod_0(537691305);
		this.pictureBox_0.Size = new Size(27, 28);
		this.pictureBox_0.SizeMode = PictureBoxSizeMode.StretchImage;
		this.pictureBox_0.TabIndex = 7;
		this.pictureBox_0.TabStop = false;
		this.pictureBox_0.Click += this.pictureBox_0_Click;
		this.pictureBox_1.Cursor = Cursors.Hand;
		this.pictureBox_1.Image = (Image)componentResourceManager.GetObject(Class185.smethod_0(537691353));
		this.pictureBox_1.Location = new Point(367, 18);
		this.pictureBox_1.Name = Class185.smethod_0(537691330);
		this.pictureBox_1.Size = new Size(27, 22);
		this.pictureBox_1.SizeMode = PictureBoxSizeMode.StretchImage;
		this.pictureBox_1.TabIndex = 8;
		this.pictureBox_1.TabStop = false;
		this.pictureBox_1.Click += this.pictureBox_1_Click;
		this.label_0.AutoSize = true;
		this.label_0.BackColor = Color.Transparent;
		this.label_0.Font = new Font(Class185.smethod_0(537691381), 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.label_0.ForeColor = Color.FromArgb(44, 186, 118);
		this.label_0.Location = new Point(123, 14);
		this.label_0.Name = Class185.smethod_0(537691363);
		this.label_0.Size = new Size(190, 23);
		this.label_0.TabIndex = 6;
		this.label_0.Text = Class185.smethod_0(537691152);
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.panel_1;
		this.bunifuDragControl_0.Vertical = true;
		this.panel_2.BackColor = Color.FromArgb(25, 23, 26);
		this.panel_2.Controls.Add(this.pictureBox_2);
		this.panel_2.Controls.Add(this.bunifuThinButton2_0);
		this.panel_2.Controls.Add(this.pictureBox_3);
		this.panel_2.Controls.Add(this.bunifuThinButton2_1);
		this.panel_2.Dock = DockStyle.Bottom;
		this.panel_2.Location = new Point(0, 549);
		this.panel_2.Name = Class185.smethod_0(537691140);
		this.panel_2.Size = new Size(439, 67);
		this.panel_2.TabIndex = 1;
		this.pictureBox_2.Cursor = Cursors.Hand;
		this.pictureBox_2.Image = (Image)componentResourceManager.GetObject(Class185.smethod_0(537705386));
		this.pictureBox_2.Location = new Point(29, 18);
		this.pictureBox_2.Name = Class185.smethod_0(537705426);
		this.pictureBox_2.Size = new Size(27, 28);
		this.pictureBox_2.SizeMode = PictureBoxSizeMode.StretchImage;
		this.pictureBox_2.TabIndex = 11;
		this.pictureBox_2.TabStop = false;
		this.bunifuThinButton2_0.ActiveBorderThickness = 1;
		this.bunifuThinButton2_0.ActiveCornerRadius = 30;
		this.bunifuThinButton2_0.ActiveFillColor = Color.FromArgb(25, 23, 26);
		this.bunifuThinButton2_0.ActiveForecolor = Color.FromArgb(225, 29, 65);
		this.bunifuThinButton2_0.ActiveLineColor = Color.FromArgb(225, 29, 65);
		this.bunifuThinButton2_0.BackColor = Color.FromArgb(25, 23, 26);
		this.bunifuThinButton2_0.BackgroundImage = (Image)componentResourceManager.GetObject(Class185.smethod_0(537705412));
		this.bunifuThinButton2_0.ButtonText = Class185.smethod_0(537705246);
		this.bunifuThinButton2_0.Cursor = Cursors.Hand;
		this.bunifuThinButton2_0.Font = new Font(Class185.smethod_0(537691381), 12f);
		this.bunifuThinButton2_0.ForeColor = Color.FromArgb(44, 186, 118);
		this.bunifuThinButton2_0.IdleBorderThickness = 1;
		this.bunifuThinButton2_0.IdleCornerRadius = 30;
		this.bunifuThinButton2_0.IdleFillColor = Color.FromArgb(25, 23, 26);
		this.bunifuThinButton2_0.IdleForecolor = Color.FromArgb(225, 29, 65);
		this.bunifuThinButton2_0.IdleLineColor = Color.FromArgb(225, 29, 65);
		this.bunifuThinButton2_0.Location = new Point(14, 10);
		this.bunifuThinButton2_0.Margin = new Padding(5, 4, 5, 4);
		this.bunifuThinButton2_0.Name = Class185.smethod_0(537705222);
		this.bunifuThinButton2_0.Size = new Size(192, 44);
		this.bunifuThinButton2_0.TabIndex = 10;
		this.bunifuThinButton2_0.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuThinButton2_0.Click += this.bunifuThinButton2_0_Click;
		this.pictureBox_3.Cursor = Cursors.Hand;
		this.pictureBox_3.Image = (Image)componentResourceManager.GetObject(Class185.smethod_0(537705248));
		this.pictureBox_3.Location = new Point(251, 17);
		this.pictureBox_3.Name = Class185.smethod_0(537705288);
		this.pictureBox_3.Size = new Size(27, 28);
		this.pictureBox_3.SizeMode = PictureBoxSizeMode.StretchImage;
		this.pictureBox_3.TabIndex = 9;
		this.pictureBox_3.TabStop = false;
		this.bunifuThinButton2_1.ActiveBorderThickness = 1;
		this.bunifuThinButton2_1.ActiveCornerRadius = 30;
		this.bunifuThinButton2_1.ActiveFillColor = Color.FromArgb(25, 23, 26);
		this.bunifuThinButton2_1.ActiveForecolor = Color.FromArgb(44, 186, 118);
		this.bunifuThinButton2_1.ActiveLineColor = Color.FromArgb(44, 186, 118);
		this.bunifuThinButton2_1.BackColor = Color.FromArgb(25, 23, 26);
		this.bunifuThinButton2_1.BackgroundImage = (Image)componentResourceManager.GetObject(Class185.smethod_0(537705338));
		this.bunifuThinButton2_1.ButtonText = Class185.smethod_0(537705107);
		this.bunifuThinButton2_1.Cursor = Cursors.Hand;
		this.bunifuThinButton2_1.Font = new Font(Class185.smethod_0(537691381), 12f);
		this.bunifuThinButton2_1.ForeColor = Color.FromArgb(44, 186, 118);
		this.bunifuThinButton2_1.IdleBorderThickness = 1;
		this.bunifuThinButton2_1.IdleCornerRadius = 30;
		this.bunifuThinButton2_1.IdleFillColor = Color.FromArgb(25, 23, 26);
		this.bunifuThinButton2_1.IdleForecolor = Color.FromArgb(44, 186, 118);
		this.bunifuThinButton2_1.IdleLineColor = Color.FromArgb(44, 186, 118);
		this.bunifuThinButton2_1.Location = new Point(232, 9);
		this.bunifuThinButton2_1.Margin = new Padding(5, 4, 5, 4);
		this.bunifuThinButton2_1.Name = Class185.smethod_0(537705146);
		this.bunifuThinButton2_1.Size = new Size(192, 44);
		this.bunifuThinButton2_1.TabIndex = 0;
		this.bunifuThinButton2_1.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuThinButton2_1.Click += this.bunifuThinButton2_1_Click;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		this.BackColor = Color.FromArgb(32, 30, 38);
		base.ClientSize = new Size(439, 616);
		base.Controls.Add(this.panel_0);
		base.Controls.Add(this.panel_2);
		base.Controls.Add(this.panel_1);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Icon = (Icon)componentResourceManager.GetObject(Class185.smethod_0(537704548));
		base.Name = Class185.smethod_0(537706427);
		this.Text = Class185.smethod_0(537706427);
		this.panel_1.ResumeLayout(false);
		this.panel_1.PerformLayout();
		((ISupportInitialize)this.pictureBox_0).EndInit();
		((ISupportInitialize)this.pictureBox_1).EndInit();
		this.panel_2.ResumeLayout(false);
		((ISupportInitialize)this.pictureBox_2).EndInit();
		((ISupportInitialize)this.pictureBox_3).EndInit();
		base.ResumeLayout(false);
	}

	// Token: 0x04000002 RID: 2
	public static WebView webView_0;

	// Token: 0x04000003 RID: 3
	public static WebView webView_1;

	// Token: 0x04000004 RID: 4
	public static WebView webView_2;

	// Token: 0x04000005 RID: 5
	public static WebView webView_3;

	// Token: 0x04000006 RID: 6
	public static bool bool_0;

	// Token: 0x04000007 RID: 7
	public static List<ConcurrentDictionary<string, string>> list_0 = new List<ConcurrentDictionary<string, string>>();

	// Token: 0x04000008 RID: 8
	public static ConcurrentDictionary<string, string> concurrentDictionary_0 = new ConcurrentDictionary<string, string>();

	// Token: 0x04000009 RID: 9
	public static ConcurrentDictionary<string, bool> concurrentDictionary_1 = new ConcurrentDictionary<string, bool>();

	// Token: 0x0400000A RID: 10
	public static SoundPlayer soundPlayer_0 = new SoundPlayer(Class185.smethod_0(537692456));

	// Token: 0x0400000B RID: 11
	public GForm2 gform2_0;

	// Token: 0x0400000C RID: 12
	private readonly ThreadRunner threadRunner_0 = new ThreadRunner();

	// Token: 0x0400000E RID: 14
	private BunifuElipse bunifuElipse_0;

	// Token: 0x0400000F RID: 15
	private Panel panel_0;

	// Token: 0x04000010 RID: 16
	private Panel panel_1;

	// Token: 0x04000011 RID: 17
	private PictureBox pictureBox_0;

	// Token: 0x04000012 RID: 18
	private PictureBox pictureBox_1;

	// Token: 0x04000013 RID: 19
	private Label label_0;

	// Token: 0x04000014 RID: 20
	private BunifuDragControl bunifuDragControl_0;

	// Token: 0x04000015 RID: 21
	private Panel panel_2;

	// Token: 0x04000016 RID: 22
	private PictureBox pictureBox_2;

	// Token: 0x04000017 RID: 23
	private BunifuThinButton2 bunifuThinButton2_0;

	// Token: 0x04000018 RID: 24
	private PictureBox pictureBox_3;

	// Token: 0x04000019 RID: 25
	private BunifuThinButton2 bunifuThinButton2_1;

	// Token: 0x02000005 RID: 5
	[Serializable]
	private sealed class Class0
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00002CF8 File Offset: 0x00000EF8
		internal void method_0()
		{
			GForm1.gform7_0.Show();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002D04 File Offset: 0x00000F04
		internal bool method_1(KeyValuePair<string, bool> keyValuePair_0)
		{
			return object.Equals(true, keyValuePair_0.Value);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00008274 File Offset: 0x00006474
		internal void method_2()
		{
			if (GForm0.list_0.Count > 0)
			{
				ConcurrentDictionary<string, string>[] array = GForm0.list_0.Where(new Func<ConcurrentDictionary<string, string>, bool>(GForm0.Class0.class0_0.method_3)).ToArray<ConcurrentDictionary<string, string>>();
				for (int i = 0; i < array.Length; i++)
				{
					GForm0.Class2 @class = new GForm0.Class2();
					@class.concurrentDictionary_0 = array[i];
					GForm0.Class3 class2 = new GForm0.Class3();
					class2.class2_0 = @class;
					if (class2.class2_0.concurrentDictionary_0 == null)
					{
						return;
					}
					bool flag = false;
					bool flag2 = false;
					class2.webView_0 = GForm0.smethod_2(class2.class2_0.concurrentDictionary_0[Class185.smethod_0(537706414)] == Class185.smethod_0(537692590), out flag2, out flag, out class2.string_0);
					if (!flag2)
					{
						class2.class2_0.concurrentDictionary_0[Class185.smethod_0(537706414)] = Class185.smethod_0(537692774);
					}
					class2.class2_0.concurrentDictionary_0[Class185.smethod_0(537706450)] = class2.string_0;
					if (flag)
					{
						class2.class2_0.concurrentDictionary_0[Class185.smethod_0(537692776)] = Class185.smethod_0(537692590);
						if (!flag2)
						{
							GForm0.soundPlayer_0.Play();
						}
						if (class2.class2_0.concurrentDictionary_0[Class185.smethod_0(537692611)].Contains(Class185.smethod_0(537692180)))
						{
							class2.webView_0.LoadHtml(GForm0.smethod_5(class2.class2_0.concurrentDictionary_0[Class185.smethod_0(537692629)], class2.class2_0.concurrentDictionary_0[Class185.smethod_0(537692633)]), class2.class2_0.concurrentDictionary_0[Class185.smethod_0(537692611)]);
						}
						else
						{
							class2.webView_0.LoadHtml(GForm0.smethod_4(class2.class2_0.concurrentDictionary_0[Class185.smethod_0(537692629)], class2.class2_0.concurrentDictionary_0[Class185.smethod_0(537692656)], class2.class2_0.concurrentDictionary_0[Class185.smethod_0(537692633)], class2.class2_0.concurrentDictionary_0[Class185.smethod_0(537692611)]), class2.class2_0.concurrentDictionary_0[Class185.smethod_0(537692611)]);
						}
						if (flag2)
						{
							new Task(new Action(class2.method_0)).Start();
						}
					}
				}
				return;
			}
			if (GForm0.concurrentDictionary_1[Class185.smethod_0(537706437)] && !GForm0.webView_0.GetText().Contains(Class185.smethod_0(537706480)))
			{
				GForm0.smethod_7();
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002D1D File Offset: 0x00000F1D
		internal bool method_3(ConcurrentDictionary<string, string> concurrentDictionary_0)
		{
			return concurrentDictionary_0[Class185.smethod_0(537692776)] == Class185.smethod_0(537692774);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002D3E File Offset: 0x00000F3E
		internal void method_4(ConcurrentDictionary<string, string> concurrentDictionary_0)
		{
			concurrentDictionary_0[Class185.smethod_0(537692776)] = Class185.smethod_0(537692774);
		}

		// Token: 0x0400001A RID: 26
		public static readonly GForm0.Class0 class0_0 = new GForm0.Class0();

		// Token: 0x0400001B RID: 27
		public static MethodInvoker methodInvoker_0;

		// Token: 0x0400001C RID: 28
		public static Func<KeyValuePair<string, bool>, bool> func_0;

		// Token: 0x0400001D RID: 29
		public static Func<ConcurrentDictionary<string, string>, bool> func_1;

		// Token: 0x0400001E RID: 30
		public static Action action_0;

		// Token: 0x0400001F RID: 31
		public static Action<ConcurrentDictionary<string, string>> action_1;
	}

	// Token: 0x02000006 RID: 6
	private sealed class Class1
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00002D5A File Offset: 0x00000F5A
		internal bool method_0(ConcurrentDictionary<string, string> concurrentDictionary_0)
		{
			return concurrentDictionary_0[Class185.smethod_0(537692633)] == this.jsextInvokeArgs_0.Arguments[1].ToString();
		}

		// Token: 0x04000020 RID: 32
		public JSExtInvokeArgs jsextInvokeArgs_0;
	}

	// Token: 0x02000007 RID: 7
	private sealed class Class2
	{
		// Token: 0x04000021 RID: 33
		public ConcurrentDictionary<string, string> concurrentDictionary_0;
	}

	// Token: 0x02000008 RID: 8
	private sealed class Class3
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00008538 File Offset: 0x00006738
		internal void method_0()
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			while (!GForm0.concurrentDictionary_0.ContainsKey(this.class2_0.concurrentDictionary_0[Class185.smethod_0(537692633)]) && this.class2_0.concurrentDictionary_0[Class185.smethod_0(537706414)] == Class185.smethod_0(537692590) && GForm0.list_0.Contains(this.class2_0.concurrentDictionary_0))
			{
				try
				{
					string text = this.webView_0.QueueScriptCall(Class185.smethod_0(537706478)).smethod_0();
					if (text.Contains(Class185.smethod_0(537706122)))
					{
						this.webView_0.LoadHtml(Class185.smethod_0(537706480));
						GClass3.smethod_0(Class185.smethod_0(537706164), Class185.smethod_0(537706183));
						this.class2_0.concurrentDictionary_0[Class185.smethod_0(537706414)] = Class185.smethod_0(537692774);
						this.class2_0.concurrentDictionary_0[Class185.smethod_0(537692776)] = Class185.smethod_0(537692774);
						GForm0.concurrentDictionary_1[this.string_0] = true;
						return;
					}
					if (text.Contains(Class185.smethod_0(537706219)))
					{
						this.webView_0.LoadHtml(Class185.smethod_0(537706480));
						GForm0.concurrentDictionary_1[this.string_0] = true;
						return;
					}
					if (stopwatch.Elapsed.TotalSeconds > 5.0)
					{
						this.webView_0.LoadHtml(Class185.smethod_0(537706480));
						GClass3.smethod_0(Class185.smethod_0(537705998), Class185.smethod_0(537706183));
						this.class2_0.concurrentDictionary_0[Class185.smethod_0(537692776)] = Class185.smethod_0(537692774);
						this.class2_0.concurrentDictionary_0[Class185.smethod_0(537706414)] = Class185.smethod_0(537692774);
						GForm0.concurrentDictionary_1[this.string_0] = true;
						return;
					}
				}
				catch
				{
				}
				Thread.Sleep(200);
			}
			GForm0.concurrentDictionary_1[this.string_0] = true;
		}

		// Token: 0x04000022 RID: 34
		public WebView webView_0;

		// Token: 0x04000023 RID: 35
		public string string_0;

		// Token: 0x04000024 RID: 36
		public GForm0.Class2 class2_0;
	}
}
