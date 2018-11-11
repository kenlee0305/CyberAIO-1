using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using EO.Base;
using EO.WebBrowser;
using EO.WebEngine;
using HtmlAgilityPack;
using Newtonsoft.Json.Linq;

// Token: 0x02000014 RID: 20
public sealed partial class GForm1 : Form
{
	// Token: 0x06000067 RID: 103 RVA: 0x0000A8B8 File Offset: 0x00008AB8
	public GForm1()
	{
		this.method_10();
		GForm1.gform1_0 = this;
		BrowserOptions options = new BrowserOptions
		{
			EnableWebSecurity = new bool?(false),
			LoadImages = new bool?(true)
		};
		EO.Base.Runtime.EnableEOWP = true;
		GForm1.webView_0.SetOptions(options);
		GForm1.webView_0.Engine = Engine.Create(Class185.smethod_0(537714282));
		GForm1.webView_0.Create(this.panel_0.Handle);
		GForm1.webView_0.BeforeContextMenu += this.method_5;
		GForm1.webView_0.RegisterJSExtensionFunction(Class185.smethod_0(537709887), new JSExtInvokeHandler(this.method_7));
		GForm1.webView_0.RegisterJSExtensionFunction(Class185.smethod_0(537709870), new JSExtInvokeHandler(this.method_9));
		GForm1.webView_0.RegisterJSExtensionFunction(Class185.smethod_0(537709909), new JSExtInvokeHandler(this.method_8));
		GForm1.webView_0.RegisterJSExtensionFunction(Class185.smethod_0(537709951), new JSExtInvokeHandler(GForm1.smethod_2));
		GForm1.webView_0.RegisterJSExtensionFunction(Class185.smethod_0(537709926), new JSExtInvokeHandler(Class23.smethod_7));
		GForm1.webView_0.RegisterJSExtensionFunction(Class185.smethod_0(537709708), new JSExtInvokeHandler(Class23.smethod_8));
		GForm1.webView_0.RegisterJSExtensionFunction(Class185.smethod_0(537709758), new JSExtInvokeHandler(Class23.smethod_11));
		GForm1.webView_0.RegisterJSExtensionFunction(Class185.smethod_0(537709738), new JSExtInvokeHandler(Class68.smethod_10));
		GForm1.webView_0.RegisterJSExtensionFunction(Class185.smethod_0(537709791), new JSExtInvokeHandler(Class68.smethod_11));
		GForm1.webView_0.RegisterJSExtensionFunction(Class185.smethod_0(537709774), new JSExtInvokeHandler(Class68.smethod_9));
		GForm1.webView_0.RegisterJSExtensionFunction(Class185.smethod_0(537709809), new JSExtInvokeHandler(Class68.smethod_3));
		GForm1.webView_0.RegisterJSExtensionFunction(Class185.smethod_0(537709795), new JSExtInvokeHandler(Class68.smethod_4));
		GForm1.webView_0.RegisterJSExtensionFunction(Class185.smethod_0(537709586), new JSExtInvokeHandler(Class68.smethod_5));
		GForm1.webView_0.RegisterJSExtensionFunction(Class185.smethod_0(537709571), new JSExtInvokeHandler(Class68.smethod_12));
		GForm1.webView_0.RegisterJSExtensionFunction(Class185.smethod_0(537709619), new JSExtInvokeHandler(Class68.smethod_13));
		GForm1.webView_0.RegisterJSExtensionFunction(Class185.smethod_0(537709603), new JSExtInvokeHandler(Class68.smethod_2));
		GForm1.webView_0.RegisterJSExtensionFunction(Class185.smethod_0(537709650), new JSExtInvokeHandler(Class68.smethod_0));
		GForm1.webView_0.RegisterJSExtensionFunction(Class185.smethod_0(537709636), new JSExtInvokeHandler(Class46.smethod_0));
		GForm1.webView_0.RegisterJSExtensionFunction(Class185.smethod_0(537709675), new JSExtInvokeHandler(Class46.smethod_1));
		GForm1.webView_0.RegisterJSExtensionFunction(Class185.smethod_0(537707410), new JSExtInvokeHandler(Class116.smethod_0));
		GForm1.webView_0.RegisterJSExtensionFunction(Class185.smethod_0(537707394), new JSExtInvokeHandler(Class116.smethod_1));
		GForm1.webView_0.RegisterJSExtensionFunction(Class185.smethod_0(537707441), new JSExtInvokeHandler(Class101.smethod_0));
		GForm1.webView_0.LoadHtml(this.method_4(Class173.string_0), Class185.smethod_0(537707425) + Directory.GetCurrentDirectory() + Class185.smethod_0(537711600));
		GForm1.webView_0.LoadCompleted += this.method_2;
		EO.Base.Runtime.Exception += this.method_0;
	}

	// Token: 0x06000069 RID: 105 RVA: 0x0000AC70 File Offset: 0x00008E70
	public static void smethod_0(EventHandler eventHandler_1)
	{
		EventHandler eventHandler = GForm1.eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref GForm1.eventHandler_0, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600006A RID: 106 RVA: 0x0000ACA4 File Offset: 0x00008EA4
	public static void smethod_1(EventHandler eventHandler_1)
	{
		EventHandler eventHandler = GForm1.eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref GForm1.eventHandler_0, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600006B RID: 107
	[DllImport("user32.dll")]
	public static extern int SendMessage(IntPtr intptr_0, int int_0, int int_1, int int_2);

	// Token: 0x0600006C RID: 108
	[DllImport("user32.dll")]
	public static extern bool ReleaseCapture();

	// Token: 0x0600006D RID: 109 RVA: 0x00002FCB File Offset: 0x000011CB
	private void method_0(object sender, ExceptionEventArgs e)
	{
		GClass3.smethod_0(e.ErrorException.Message, Class185.smethod_0(537707472));
	}

	// Token: 0x0600006E RID: 110 RVA: 0x0000ACD8 File Offset: 0x00008ED8
	public void method_1()
	{
		if (Screen.PrimaryScreen.WorkingArea.Height < 800)
		{
			Size size = new Size(Screen.PrimaryScreen.WorkingArea.Width - 15, Screen.PrimaryScreen.WorkingArea.Height - 10);
			base.Size = size;
			this.panel_0.Size = new Size(size.Width - 5, size.Height - 5);
			this.MinimumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width - 25, Screen.PrimaryScreen.WorkingArea.Height - 20);
			GForm1.webView_0.ZoomFactor = 0.83;
			return;
		}
		Size size2 = new Size(1400, 820);
		base.Size = size2;
		this.panel_0.Size = new Size(size2.Width - 5, size2.Height - 5);
		this.MinimumSize = new Size(1300, 820);
	}

	// Token: 0x0600006F RID: 111 RVA: 0x0000ADF4 File Offset: 0x00008FF4
	private void method_2(object sender, LoadCompletedEventArgs e)
	{
		this.method_1();
		Class68.smethod_1();
		GForm1.gform7_0 = new GForm7(true);
		Class68.smethod_6();
		Class68.smethod_7();
		Class68.smethod_8();
		Class68.smethod_5(null, null);
		bool isAttached = Debugger.IsAttached;
		GForm3.smethod_9();
		Class173.jobject_3 = JObject.Parse(GForm1.webView_0.QueueScriptCall(Class185.smethod_0(537707460)).smethod_0());
		Class23.smethod_0();
		base.Opacity = 0.0;
		base.Show();
		this.timer_0.Interval = 10;
		this.timer_0.Tick += this.timer_0_Tick;
		this.timer_0.Start();
	}

	// Token: 0x06000070 RID: 112 RVA: 0x0000AEA4 File Offset: 0x000090A4
	public async void method_3()
	{
		Console.WriteLine(await Class143.smethod_1(File.OpenRead(Class185.smethod_0(537709839))));
	}

	// Token: 0x06000071 RID: 113 RVA: 0x0000AED8 File Offset: 0x000090D8
	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (base.Opacity >= 1.0)
		{
			this.timer_0.Stop();
			GForm1.eventHandler_0(this, e);
			return;
		}
		base.Opacity += 0.05;
	}

	// Token: 0x06000072 RID: 114 RVA: 0x0000AF24 File Offset: 0x00009124
	public string method_4(string string_1)
	{
		HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
		htmlDocument.LoadHtml(string_1);
		string text = Class185.smethod_0(537707291);
		foreach (KeyValuePair<string, JToken> keyValuePair in Class173.jobject_4)
		{
			text += string.Format(Class185.smethod_0(537707304), keyValuePair.Key, keyValuePair.Key);
		}
		string str = Class185.smethod_0(537707343);
		foreach (string text2 in GForm1.string_0)
		{
			str += string.Format(Class185.smethod_0(537707304), text2, text2);
		}
		htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537707383)).InnerHtml = text;
		string innerHtml = str + htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537707146)).InnerHtml;
		htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537707146)).InnerHtml = innerHtml;
		return htmlDocument.DocumentNode.InnerHtml;
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00002FE8 File Offset: 0x000011E8
	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		this.method_9(null, null);
		base.OnFormClosing(e);
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00002FF9 File Offset: 0x000011F9
	protected override void SetVisibleCore(bool value)
	{
		if (!base.IsHandleCreated)
		{
			this.CreateHandle();
			value = false;
		}
		base.SetVisibleCore(value);
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00003013 File Offset: 0x00001213
	public static void smethod_2(object object_0, JSExtInvokeArgs jsextInvokeArgs_0)
	{
		GForm1.gform7_0.Show();
		GForm1.gform7_0.WindowState = FormWindowState.Normal;
		GForm1.gform7_0.BringToFront();
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00002C72 File Offset: 0x00000E72
	private void method_5(object sender, BeforeContextMenuEventArgs e)
	{
		e.Menu.Items.Clear();
	}

	// Token: 0x06000077 RID: 119
	[DllImport("user32.dll")]
	private static extern IntPtr GetForegroundWindow();

	// Token: 0x06000078 RID: 120 RVA: 0x00003034 File Offset: 0x00001234
	public bool method_6(IntPtr intptr_0)
	{
		return GForm1.GetForegroundWindow() == intptr_0;
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00003041 File Offset: 0x00001241
	private void method_7(object object_0, JSExtInvokeArgs jsextInvokeArgs_0)
	{
		if (this.method_6(base.Handle))
		{
			GForm1.ReleaseCapture();
			GForm1.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	// Token: 0x0600007A RID: 122 RVA: 0x0000B050 File Offset: 0x00009250
	protected override void WndProc(ref Message m)
	{
		if (m.Msg == 132)
		{
			int x = (int)(m.LParam.ToInt64() & 65535L);
			int y = (int)((m.LParam.ToInt64() & 4294901760L) >> 16);
			Point point = base.PointToClient(new Point(x, y));
			Size clientSize = base.ClientSize;
			if (point.X >= clientSize.Width - 16 && point.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
			{
				m.Result = (IntPtr)(base.IsMirrored ? 16 : 17);
				return;
			}
			if (point.X <= 16 && point.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
			{
				m.Result = (IntPtr)(base.IsMirrored ? 17 : 16);
				return;
			}
			if (point.X <= 16 && point.Y <= 16 && clientSize.Height >= 16)
			{
				m.Result = (IntPtr)(base.IsMirrored ? 14 : 13);
				return;
			}
			if (point.X >= clientSize.Width - 16 && point.Y <= 16 && clientSize.Height >= 16)
			{
				m.Result = (IntPtr)(base.IsMirrored ? 13 : 14);
				return;
			}
			if (point.Y <= 16 && clientSize.Height >= 16)
			{
				m.Result = (IntPtr)12;
				return;
			}
			if (point.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
			{
				m.Result = (IntPtr)15;
				return;
			}
			if (point.X <= 16 && clientSize.Height >= 16)
			{
				m.Result = (IntPtr)10;
				return;
			}
			if (point.X >= clientSize.Width - 16 && clientSize.Height >= 16)
			{
				m.Result = (IntPtr)11;
				return;
			}
		}
		base.WndProc(ref m);
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00002C94 File Offset: 0x00000E94
	public void method_8(object object_0, JSExtInvokeArgs jsextInvokeArgs_0)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	// Token: 0x0600007C RID: 124 RVA: 0x0000306A File Offset: 0x0000126A
	public void method_9(object object_0, JSExtInvokeArgs jsextInvokeArgs_0)
	{
		GClass0.smethod_2();
		GForm1.gform1_0.BeginInvoke(null, null);
		Process.GetCurrentProcess().Kill();
	}

	// Token: 0x0600007E RID: 126 RVA: 0x0000B270 File Offset: 0x00009470
	private void method_10()
	{
		this.icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm1));
		this.label_0 = new Label();
		this.panel_0 = new Panel();
		this.bunifuElipse_0 = new BunifuElipse(this.icontainer_0);
		this.bunifuFormFadeTransition_0 = new BunifuFormFadeTransition(this.icontainer_0);
		base.SuspendLayout();
		this.label_0.Location = new Point(0, 0);
		this.label_0.Name = Class185.smethod_0(537707183);
		this.label_0.Size = new Size(100, 23);
		this.label_0.TabIndex = 2;
		this.panel_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this.panel_0.Location = new Point(1, -1);
		this.panel_0.Name = Class185.smethod_0(537704240);
		this.panel_0.Size = new Size(1296, 734);
		this.panel_0.TabIndex = 1;
		this.bunifuElipse_0.ElipseRadius = 20;
		this.bunifuElipse_0.TargetControl = this;
		this.bunifuFormFadeTransition_0.Delay = 3;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		this.BackColor = Color.FromArgb(22, 21, 26);
		base.ClientSize = new Size(1214, 612);
		base.Controls.Add(this.panel_0);
		base.Controls.Add(this.label_0);
		this.DoubleBuffered = true;
		this.ForeColor = Color.FromArgb(22, 21, 26);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Icon = (Icon)componentResourceManager.GetObject(Class185.smethod_0(537704548));
		this.MinimumSize = new Size(412, 252);
		base.Name = Class185.smethod_0(537707220);
		base.StartPosition = FormStartPosition.CenterScreen;
		this.Text = Class185.smethod_0(537714282);
		base.ResumeLayout(false);
	}

	// Token: 0x0600007F RID: 127 RVA: 0x000030A7 File Offset: 0x000012A7
	private void method_11()
	{
		base.Hide();
		GForm1.webView_0.Close(true);
	}

	// Token: 0x04000052 RID: 82
	public static string[] string_0 = new string[]
	{
		Class185.smethod_0(537701307)
	};

	// Token: 0x04000053 RID: 83
	[Dynamic(new bool[]
	{
		false,
		false,
		false,
		false,
		true
	})]
	public static Dictionary<int, Dictionary<string, dynamic>> dictionary_0 = new Dictionary<int, Dictionary<string, object>>();

	// Token: 0x04000054 RID: 84
	public static WebView webView_0 = new WebView();

	// Token: 0x04000055 RID: 85
	public static GForm7 gform7_0;

	// Token: 0x04000056 RID: 86
	public static Random random_0 = new Random();

	// Token: 0x04000057 RID: 87
	public static GForm1 gform1_0;

	// Token: 0x04000058 RID: 88
	private readonly System.Windows.Forms.Timer timer_0 = new System.Windows.Forms.Timer();

	// Token: 0x04000059 RID: 89
	private static EventHandler eventHandler_0;

	// Token: 0x0400005B RID: 91
	private Label label_0;

	// Token: 0x0400005C RID: 92
	private Panel panel_0;

	// Token: 0x0400005D RID: 93
	private BunifuElipse bunifuElipse_0;

	// Token: 0x0400005E RID: 94
	private BunifuFormFadeTransition bunifuFormFadeTransition_0;

	// Token: 0x02000015 RID: 21
	[StructLayout(LayoutKind.Auto)]
	private struct Struct0 : IAsyncStateMachine
	{
		// Token: 0x06000080 RID: 128 RVA: 0x0000B480 File Offset: 0x00009680
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			try
			{
				TaskAwaiter<string> taskAwaiter;
				if (num != 0)
				{
					taskAwaiter = Class143.smethod_1(File.OpenRead(Class185.smethod_0(537709839))).GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						num2 = 0;
						TaskAwaiter<string> taskAwaiter2 = taskAwaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GForm1.Struct0>(ref taskAwaiter, ref this);
						return;
					}
				}
				else
				{
					TaskAwaiter<string> taskAwaiter2;
					taskAwaiter = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter<string>);
					num2 = -1;
				}
				Console.WriteLine(taskAwaiter.GetResult());
			}
			catch (Exception exception)
			{
				num2 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			num2 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000030BA File Offset: 0x000012BA
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400005F RID: 95
		public int int_0;

		// Token: 0x04000060 RID: 96
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000061 RID: 97
		private TaskAwaiter<string> taskAwaiter_0;
	}
}
