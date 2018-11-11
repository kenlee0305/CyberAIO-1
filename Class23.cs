using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EO.WebBrowser;
using wyDay.Controls;

// Token: 0x0200002E RID: 46
internal sealed class Class23
{
	// Token: 0x06000127 RID: 295 RVA: 0x0000ED94 File Offset: 0x0000CF94
	public static void smethod_0()
	{
		Class23.automaticUpdaterBackend_0 = new AutomaticUpdaterBackend
		{
			GUID = Class185.smethod_0(537708761),
			wyUpdateCommandline = string.Format(Class185.smethod_0(537708738), Class173.string_3),
			UpdateType = UpdateType.OnlyCheck,
			wyUpdateLocation = Class185.smethod_0(537708779)
		};
		Class23.automaticUpdaterBackend_0.ReadyToBeInstalled += Class23.smethod_5;
		Class23.automaticUpdaterBackend_0.CheckingFailed += Class23.smethod_1;
		Class23.automaticUpdaterBackend_0.UpToDate += Class23.smethod_3;
		Class23.automaticUpdaterBackend_0.UpdateAvailable += Class23.smethod_4;
		Class23.automaticUpdaterBackend_0.ProgressChanged += Class23.smethod_2;
		Class23.automaticUpdaterBackend_0.DownloadingFailed += Class23.smethod_1;
		Class23.automaticUpdaterBackend_0.ExtractingFailed += Class23.smethod_1;
		Class23.automaticUpdaterBackend_0.UpdateFailed += Class23.smethod_1;
		Class23.automaticUpdaterBackend_0.UpdateSuccessful += Class23.smethod_3;
		Class23.automaticUpdaterBackend_0.ReadyToBeInstalled += Class23.smethod_5;
		Class23.automaticUpdaterBackend_0.Initialize();
		Class23.automaticUpdaterBackend_0.AppLoaded();
	}

	// Token: 0x06000128 RID: 296 RVA: 0x000037D9 File Offset: 0x000019D9
	private static void smethod_1(object object_0, FailArgs failArgs_0)
	{
		GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537708574), failArgs_0.ErrorTitle.smethod_4(), failArgs_0.ErrorMessage.smethod_4()));
	}

	// Token: 0x06000129 RID: 297 RVA: 0x0000EEDC File Offset: 0x0000D0DC
	private static void smethod_2(object object_0, int int_1)
	{
		if ((Class23.int_0 != int_1 || Class23.string_0 != Class23.automaticUpdaterBackend_0.UpdateStepOn.ToString()) && Class23.automaticUpdaterBackend_0.UpdateStepOn != UpdateStepOn.Checking)
		{
			GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537708592), Class23.automaticUpdaterBackend_0.UpdateStepOn.ToString().Replace(Class185.smethod_0(537710506), Class185.smethod_0(537710503)), int_1.ToString()));
			Class23.int_0 = int_1;
			Class23.string_0 = Class23.automaticUpdaterBackend_0.UpdateStepOn.ToString();
		}
	}

	// Token: 0x0600012A RID: 298 RVA: 0x0000380B File Offset: 0x00001A0B
	private static void smethod_3(object object_0, SuccessArgs successArgs_0)
	{
		if (Class23.bool_0)
		{
			GForm1.webView_0.QueueScriptCall(Class185.smethod_0(537710549));
		}
	}

	// Token: 0x0600012B RID: 299 RVA: 0x0000EF9C File Offset: 0x0000D19C
	private static void smethod_4(object sender, EventArgs e)
	{
		if (Class23.automaticUpdaterBackend_0.Version != null)
		{
			if (DateTime.UtcNow > GForm3.dateTime_0)
			{
				GForm1.webView_0.QueueScriptCall(Class185.smethod_0(537711813));
				return;
			}
			GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537710378), Class23.automaticUpdaterBackend_0.Changes.Split(new char[]
			{
				'\n'
			}).Length, Class23.automaticUpdaterBackend_0.Changes.smethod_4(), Class23.automaticUpdaterBackend_0.Version));
		}
	}

	// Token: 0x0600012C RID: 300 RVA: 0x00003829 File Offset: 0x00001A29
	private static void smethod_5(object sender, EventArgs e)
	{
		if (Class23.automaticUpdaterBackend_0.UpdateStepOn == UpdateStepOn.UpdateReadyToInstall || Class23.automaticUpdaterBackend_0.UpdateStepOn == UpdateStepOn.UpdateDownloaded)
		{
			Class23.automaticUpdaterBackend_0.InstallNow();
		}
	}

	// Token: 0x0600012D RID: 301 RVA: 0x0000384F File Offset: 0x00001A4F
	public static void smethod_6(object object_0, JSExtInvokeArgs jsextInvokeArgs_0)
	{
		new Task(new Action(new Class23.Class25
		{
			object_0 = object_0
		}.method_0)).Start();
	}

	// Token: 0x0600012E RID: 302 RVA: 0x00003872 File Offset: 0x00001A72
	public static void smethod_7(object object_0, JSExtInvokeArgs jsextInvokeArgs_0)
	{
		Class23.bool_0 = (object_0 != null);
		Class23.automaticUpdaterBackend_0.ForceCheckForUpdate(true);
	}

	// Token: 0x0600012F RID: 303 RVA: 0x00003889 File Offset: 0x00001A89
	public static void smethod_8(object object_0, JSExtInvokeArgs jsextInvokeArgs_0)
	{
		Class23.automaticUpdaterBackend_0.InstallNow();
	}

	// Token: 0x06000130 RID: 304 RVA: 0x0000F030 File Offset: 0x0000D230
	public static void smethod_9(object object_0, JSExtInvokeArgs jsextInvokeArgs_0)
	{
		GClass0.smethod_2();
		MethodInvoker method = new MethodInvoker(Class23.Class24.class24_0.method_0);
		GForm1.gform1_0.BeginInvoke(method, null);
		Class23.automaticUpdaterBackend_0.InstallNow();
	}

	// Token: 0x06000131 RID: 305 RVA: 0x0000F07C File Offset: 0x0000D27C
	public static void smethod_10(object object_0, JSExtInvokeArgs jsextInvokeArgs_0)
	{
		new Process
		{
			StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = Class185.smethod_0(537711747),
				Arguments = string.Format(Class185.smethod_0(537710057), Class173.string_3)
			}
		}.Start();
		GForm1.gform1_0.method_9(null, null);
	}

	// Token: 0x06000132 RID: 306 RVA: 0x0000F0E0 File Offset: 0x0000D2E0
	public static async void smethod_11(object object_0, JSExtInvokeArgs jsextInvokeArgs_0)
	{
		if (Class173.form_0 == null)
		{
			Class173.dateTime_0 = GForm3.dateTime_0;
			Dictionary<string, string> dictionary = Class70.smethod_1();
			dictionary[Class185.smethod_0(537709009)] = Class173.string_4;
			dictionary[Class185.smethod_0(537709048)] = Class185.smethod_0(537709042);
			dictionary[Class185.smethod_0(537709026)] = Class185.smethod_0(537708828);
			dictionary[Class185.smethod_0(537708814)] = GClass0.string_2;
			TaskAwaiter<HttpResponseMessage> taskAwaiter = new Class70(null, Class185.smethod_0(537692910), 10, false, true, null, false).method_8(Class185.smethod_0(537708856), dictionary, false).GetAwaiter();
			if (!taskAwaiter.IsCompleted)
			{
				await taskAwaiter;
				TaskAwaiter<HttpResponseMessage> taskAwaiter2;
				taskAwaiter = taskAwaiter2;
				taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
			}
			Class173.form_0 = new GForm6(taskAwaiter.GetResult().Headers.Location.ToString());
			Class173.form_0.Show();
			GForm1.webView_0.QueueScriptCall(Class185.smethod_0(537708884));
		}
		else
		{
			Class173.form_0.WindowState = FormWindowState.Normal;
			Class173.form_0.BringToFront();
		}
	}

	// Token: 0x0400009A RID: 154
	public static AutomaticUpdaterBackend automaticUpdaterBackend_0;

	// Token: 0x0400009B RID: 155
	public static int int_0 = 0;

	// Token: 0x0400009C RID: 156
	public static string string_0 = string.Empty;

	// Token: 0x0400009D RID: 157
	public static bool bool_0 = false;

	// Token: 0x0200002F RID: 47
	[Serializable]
	private sealed class Class24
	{
		// Token: 0x06000135 RID: 309 RVA: 0x000038A1 File Offset: 0x00001AA1
		internal void method_0()
		{
			GForm1.gform1_0.Hide();
			GForm1.webView_0.Close(true);
		}

		// Token: 0x0400009E RID: 158
		public static readonly Class23.Class24 class24_0 = new Class23.Class24();

		// Token: 0x0400009F RID: 159
		public static MethodInvoker methodInvoker_0;
	}

	// Token: 0x02000030 RID: 48
	private sealed class Class25
	{
		// Token: 0x06000137 RID: 311 RVA: 0x0000F114 File Offset: 0x0000D314
		internal void method_0()
		{
			try
			{
				if (this.object_0 == null)
				{
					Thread.Sleep(2000);
				}
				Process process = new Process();
				process.StartInfo = new ProcessStartInfo
				{
					WindowStyle = ProcessWindowStyle.Hidden,
					FileName = Class185.smethod_0(537711747),
					Arguments = Class185.smethod_0(537711793)
				};
				process.Start();
				process.WaitForExit(20000);
				int exitCode = process.ExitCode;
				if (exitCode == 2)
				{
					if (DateTime.UtcNow > GForm3.dateTime_0)
					{
						GForm1.webView_0.QueueScriptCall(Class185.smethod_0(537711813));
					}
					else
					{
						GForm1.webView_0.QueueScriptCall(Class185.smethod_0(537709370));
					}
				}
				else if (exitCode == 1)
				{
					GForm1.webView_0.QueueScriptCall(Class185.smethod_0(537709296));
				}
				else if (this.object_0 != null)
				{
					GForm1.webView_0.QueueScriptCall(Class185.smethod_0(537709124));
				}
			}
			catch
			{
				GForm1.webView_0.QueueScriptCall(Class185.smethod_0(537709296));
			}
		}

		// Token: 0x040000A0 RID: 160
		public object object_0;
	}

	// Token: 0x02000031 RID: 49
	[StructLayout(LayoutKind.Auto)]
	private struct Struct1 : IAsyncStateMachine
	{
		// Token: 0x06000138 RID: 312 RVA: 0x0000F22C File Offset: 0x0000D42C
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			try
			{
				TaskAwaiter<HttpResponseMessage> taskAwaiter3;
				if (num != 0)
				{
					if (Class173.form_0 != null)
					{
						Class173.form_0.WindowState = FormWindowState.Normal;
						Class173.form_0.BringToFront();
						goto IL_150;
					}
					Class173.dateTime_0 = GForm3.dateTime_0;
					Dictionary<string, string> dictionary = Class70.smethod_1();
					dictionary[Class185.smethod_0(537709009)] = Class173.string_4;
					dictionary[Class185.smethod_0(537709048)] = Class185.smethod_0(537709042);
					dictionary[Class185.smethod_0(537709026)] = Class185.smethod_0(537708828);
					dictionary[Class185.smethod_0(537708814)] = GClass0.string_2;
					taskAwaiter3 = new Class70(null, Class185.smethod_0(537692910), 10, false, true, null, false).method_8(Class185.smethod_0(537708856), dictionary, false).GetAwaiter();
					if (!taskAwaiter3.IsCompleted)
					{
						num2 = 0;
						taskAwaiter2 = taskAwaiter3;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class23.Struct1>(ref taskAwaiter3, ref this);
						return;
					}
				}
				else
				{
					taskAwaiter3 = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
					num2 = -1;
				}
				Class173.form_0 = new GForm6(taskAwaiter3.GetResult().Headers.Location.ToString());
				Class173.form_0.Show();
				GForm1.webView_0.QueueScriptCall(Class185.smethod_0(537708884));
				IL_150:;
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

		// Token: 0x06000139 RID: 313 RVA: 0x000038B8 File Offset: 0x00001AB8
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040000A1 RID: 161
		public int int_0;

		// Token: 0x040000A2 RID: 162
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040000A3 RID: 163
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;
	}
}
