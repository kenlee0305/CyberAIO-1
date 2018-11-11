using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using EO.WebBrowser;
using EO.WebEngine;

// Token: 0x020000C4 RID: 196
public sealed partial class GForm5 : Form
{
	// Token: 0x06000510 RID: 1296 RVA: 0x0002BA90 File Offset: 0x00029C90
	public GForm5(bool bool_2 = false, string string_2 = null)
	{
		this.method_10();
		this.bool_1 = bool_2;
		this.string_1 = string_2;
		BrowserOptions options = new BrowserOptions
		{
			EnableWebSecurity = new bool?(false),
			LoadImages = new bool?(true)
		};
		this.webView_0 = new WebView();
		this.webView_0.SetOptions(options);
		this.webView_0.Create(base.Handle);
		base.Size = new Size(600, 400);
		GForm5.string_0 = Class185.smethod_0(537721826);
		this.webView_0.LoadHtml(GForm5.string_0, Class185.smethod_0(537707425) + Directory.GetCurrentDirectory() + Class185.smethod_0(537711600));
		this.webView_0.LoadCompleted += this.webView_0_LoadCompleted;
		if (bool_2)
		{
			this.method_0(new EventHandler(this.method_7));
		}
	}

	// Token: 0x06000512 RID: 1298 RVA: 0x0002BB94 File Offset: 0x00029D94
	public void method_0(EventHandler eventHandler_1)
	{
		EventHandler eventHandler = this.eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000513 RID: 1299 RVA: 0x0002BBCC File Offset: 0x00029DCC
	public void method_1(EventHandler eventHandler_1)
	{
		EventHandler eventHandler = this.eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000514 RID: 1300 RVA: 0x00005662 File Offset: 0x00003862
	protected override void SetVisibleCore(bool value)
	{
		base.SetVisibleCore(this.bool_0 ? value : this.bool_0);
	}

	// Token: 0x06000515 RID: 1301 RVA: 0x0002BC04 File Offset: 0x00029E04
	private void webView_0_LoadCompleted(object sender, LoadCompletedEventArgs e)
	{
		Thread.Sleep(500);
		this.method_2();
		this.webView_0.RegisterJSExtensionFunction(Class185.smethod_0(537715225), new JSExtInvokeHandler(this.method_8));
		this.webView_0.RegisterJSExtensionFunction(Class185.smethod_0(537715221), new JSExtInvokeHandler(this.method_9));
	}

	// Token: 0x06000516 RID: 1302 RVA: 0x0002BC64 File Offset: 0x00029E64
	public void method_2()
	{
		base.CenterToScreen();
		this.bool_0 = true;
		base.Opacity = 0.0;
		base.Show();
		this.timer_0.Interval = 10;
		this.timer_0.Tick += this.timer_0_Tick;
		this.timer_0.Start();
	}

	// Token: 0x06000517 RID: 1303 RVA: 0x0000567B File Offset: 0x0000387B
	public void method_3(object sender, EventArgs e)
	{
		this.timer_1.Interval = 10;
		this.timer_1.Tick += this.timer_1_Tick;
		this.timer_1.Start();
	}

	// Token: 0x06000518 RID: 1304 RVA: 0x0002BCC4 File Offset: 0x00029EC4
	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (base.Opacity >= 1.0)
		{
			this.timer_0.Stop();
			this.eventHandler_0(this, e);
			return;
		}
		base.Opacity += 0.05;
	}

	// Token: 0x06000519 RID: 1305 RVA: 0x000056AC File Offset: 0x000038AC
	private void timer_1_Tick(object sender, EventArgs e)
	{
		if (base.Opacity <= 0.0)
		{
			this.timer_1.Dispose();
			base.Hide();
			return;
		}
		base.Opacity -= 0.05;
	}

	// Token: 0x0600051A RID: 1306 RVA: 0x000056E7 File Offset: 0x000038E7
	public void method_4()
	{
		this.webView_0.EvalScript(Class185.smethod_0(537715201) + GForm5.string_0 + Class185.smethod_0(537715235));
	}

	// Token: 0x0600051B RID: 1307 RVA: 0x00005713 File Offset: 0x00003913
	public void method_5(string string_2, string string_3)
	{
		this.webView_0.EvalScript(string.Format(Class185.smethod_0(537715291), string_2.ToUpper(), string_3));
	}

	// Token: 0x0600051C RID: 1308 RVA: 0x00005737 File Offset: 0x00003937
	public void method_6()
	{
		this.webView_0.EvalScript(Class185.smethod_0(537715187));
	}

	// Token: 0x0600051D RID: 1309 RVA: 0x0002BD14 File Offset: 0x00029F14
	public async void method_7(object sender, EventArgs e)
	{
		for (;;)
		{
			try
			{
				string a;
				if (this.string_1 == null)
				{
					if (GClass0.string_2 != null && GClass0.string_2.Length > 5)
					{
						this.method_5(Class185.smethod_0(537721754), Class185.smethod_0(537721735));
						TaskAwaiter<string> taskAwaiter = GForm3.smethod_11(GClass0.string_2, true, false).GetAwaiter();
						if (!taskAwaiter.IsCompleted)
						{
							await taskAwaiter;
							TaskAwaiter<string> taskAwaiter2;
							taskAwaiter = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter<string>);
						}
						a = taskAwaiter.GetResult();
					}
					else
					{
						this.method_5(Class185.smethod_0(537721779), Class185.smethod_0(537721735));
						a = Class185.smethod_0(537721762);
					}
				}
				else
				{
					a = this.string_1;
				}
				if (a == Class185.smethod_0(537706979))
				{
					this.method_6();
					Thread.Sleep(500);
					this.method_5(string.Format(Class185.smethod_0(537721821), GForm3.string_0.Split(new char[]
					{
						'#'
					})[0]), Class185.smethod_0(537721735));
					GForm1.smethod_0(new EventHandler(this.method_3));
					new GForm1().Show();
				}
				else
				{
					if (a == Class185.smethod_0(537710733))
					{
						for (int i = 10; i > 0; i--)
						{
							this.method_5(string.Format(Class185.smethod_0(537721796), i), Class185.smethod_0(537721735));
							Thread.Sleep(1000);
						}
						continue;
					}
					GForm3.smethod_0(new EventHandler(this.method_3));
					new GForm3();
				}
			}
			catch
			{
				for (int j = 10; j > 0; j--)
				{
					this.method_5(string.Format(Class185.smethod_0(537721796), j), Class185.smethod_0(537721735));
					Thread.Sleep(1000);
				}
				continue;
			}
			break;
		}
	}

	// Token: 0x0600051E RID: 1310 RVA: 0x0000574F File Offset: 0x0000394F
	private void method_8(object object_0, JSExtInvokeArgs jsextInvokeArgs_0)
	{
		base.Close();
	}

	// Token: 0x0600051F RID: 1311 RVA: 0x00005757 File Offset: 0x00003957
	private void method_9(object object_0, JSExtInvokeArgs jsextInvokeArgs_0)
	{
		Process.Start(Application.ExecutablePath);
		Process.GetCurrentProcess().Kill();
	}

	// Token: 0x06000521 RID: 1313 RVA: 0x0002BD50 File Offset: 0x00029F50
	private void method_10()
	{
		this.icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm5));
		this.bunifuElipse_0 = new BunifuElipse(this.icontainer_0);
		this.bunifuFormFadeTransition_0 = new BunifuFormFadeTransition(this.icontainer_0);
		base.SuspendLayout();
		this.bunifuElipse_0.ElipseRadius = 5;
		this.bunifuElipse_0.TargetControl = this;
		this.bunifuFormFadeTransition_0.Delay = 1;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(910, 583);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Icon = (Icon)componentResourceManager.GetObject(Class185.smethod_0(537704548));
		this.MinimumSize = new Size(652, 322);
		base.Name = Class185.smethod_0(537715006);
		base.StartPosition = FormStartPosition.CenterScreen;
		this.Text = Class185.smethod_0(537715006);
		base.ResumeLayout(false);
	}

	// Token: 0x04000271 RID: 625
	public WebView webView_0;

	// Token: 0x04000272 RID: 626
	public static string string_0 = string.Empty;

	// Token: 0x04000273 RID: 627
	private bool bool_0;

	// Token: 0x04000274 RID: 628
	public bool bool_1;

	// Token: 0x04000275 RID: 629
	private System.Windows.Forms.Timer timer_0 = new System.Windows.Forms.Timer();

	// Token: 0x04000276 RID: 630
	private System.Windows.Forms.Timer timer_1 = new System.Windows.Forms.Timer();

	// Token: 0x04000277 RID: 631
	private EventHandler eventHandler_0;

	// Token: 0x04000278 RID: 632
	public string string_1;

	// Token: 0x0400027A RID: 634
	private BunifuElipse bunifuElipse_0;

	// Token: 0x0400027B RID: 635
	private BunifuFormFadeTransition bunifuFormFadeTransition_0;

	// Token: 0x020000C5 RID: 197
	[StructLayout(LayoutKind.Auto)]
	private struct Struct41 : IAsyncStateMachine
	{
		// Token: 0x06000522 RID: 1314 RVA: 0x0002BE5C File Offset: 0x0002A05C
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			GForm5 gform = this;
			try
			{
				for (;;)
				{
					try
					{
						string a;
						TaskAwaiter<string> taskAwaiter3;
						if (num != 0)
						{
							if (gform.string_1 != null)
							{
								a = gform.string_1;
								goto IL_E7;
							}
							if (GClass0.string_2 == null || GClass0.string_2.Length <= 5)
							{
								gform.method_5(Class185.smethod_0(537721779), Class185.smethod_0(537721735));
								a = Class185.smethod_0(537721762);
								goto IL_E7;
							}
							gform.method_5(Class185.smethod_0(537721754), Class185.smethod_0(537721735));
							taskAwaiter3 = GForm3.smethod_11(GClass0.string_2, true, false).GetAwaiter();
							if (!taskAwaiter3.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								num2 = num3;
								taskAwaiter2 = taskAwaiter3;
								this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GForm5.Struct41>(ref taskAwaiter3, ref this);
								return;
							}
						}
						else
						{
							taskAwaiter3 = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter<string>);
							int num4 = -1;
							num = -1;
							num2 = num4;
						}
						a = taskAwaiter3.GetResult();
						IL_E7:
						if (a == Class185.smethod_0(537706979))
						{
							gform.method_6();
							Thread.Sleep(500);
							gform.method_5(string.Format(Class185.smethod_0(537721821), GForm3.string_0.Split(new char[]
							{
								'#'
							})[0]), Class185.smethod_0(537721735));
							GForm1.smethod_0(new EventHandler(gform.method_3));
							new GForm1().Show();
						}
						else
						{
							if (a == Class185.smethod_0(537710733))
							{
								for (int i = 10; i > 0; i--)
								{
									gform.method_5(string.Format(Class185.smethod_0(537721796), i), Class185.smethod_0(537721735));
									Thread.Sleep(1000);
								}
								continue;
							}
							GForm3.smethod_0(new EventHandler(gform.method_3));
							new GForm3();
						}
					}
					catch
					{
						for (int j = 10; j > 0; j--)
						{
							gform.method_5(string.Format(Class185.smethod_0(537721796), j), Class185.smethod_0(537721735));
							Thread.Sleep(1000);
						}
						continue;
					}
					break;
				}
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

		// Token: 0x06000523 RID: 1315 RVA: 0x0000578D File Offset: 0x0000398D
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400027C RID: 636
		public int int_0;

		// Token: 0x0400027D RID: 637
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400027E RID: 638
		public GForm5 gform5_0;

		// Token: 0x0400027F RID: 639
		private TaskAwaiter<string> taskAwaiter_0;
	}
}
