using System;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

// Token: 0x020000DC RID: 220
internal static class Class121
{
	// Token: 0x060005BF RID: 1471 RVA: 0x00035040 File Offset: 0x00033240
	public static JObject smethod_0(this HttpResponseMessage httpResponseMessage_0)
	{
		JObject result;
		try
		{
			result = JObject.Parse(httpResponseMessage_0.Content.ReadAsStringAsync().Result);
		}
		catch
		{
			result = null;
		}
		return result;
	}

	// Token: 0x060005C0 RID: 1472 RVA: 0x0003507C File Offset: 0x0003327C
	public static async Task<JObject> smethod_1(this HttpResponseMessage httpResponseMessage_0)
	{
		JObject result;
		try
		{
			result = JObject.Parse(await httpResponseMessage_0.Content.ReadAsStringAsync());
		}
		catch
		{
			result = null;
		}
		return result;
	}

	// Token: 0x060005C1 RID: 1473 RVA: 0x000350C4 File Offset: 0x000332C4
	public static JArray smethod_2(this HttpResponseMessage httpResponseMessage_0)
	{
		JArray result;
		try
		{
			result = JArray.Parse(httpResponseMessage_0.Content.ReadAsStringAsync().Result);
		}
		catch
		{
			result = null;
		}
		return result;
	}

	// Token: 0x060005C2 RID: 1474 RVA: 0x00005E8C File Offset: 0x0000408C
	public static string smethod_3(this HttpResponseMessage httpResponseMessage_0)
	{
		return httpResponseMessage_0.Content.ReadAsStringAsync().Result;
	}

	// Token: 0x060005C3 RID: 1475 RVA: 0x00005E9E File Offset: 0x0000409E
	public static Task<string> smethod_4(this HttpResponseMessage httpResponseMessage_0)
	{
		return httpResponseMessage_0.Content.ReadAsStringAsync();
	}

	// Token: 0x060005C4 RID: 1476 RVA: 0x00005EAB File Offset: 0x000040AB
	public static bool smethod_5(this HttpResponseMessage httpResponseMessage_0)
	{
		return httpResponseMessage_0.smethod_3().Contains(Class185.smethod_0(537711571));
	}

	// Token: 0x020000DD RID: 221
	[StructLayout(LayoutKind.Auto)]
	private struct Struct44 : IAsyncStateMachine
	{
		// Token: 0x060005C5 RID: 1477 RVA: 0x00035100 File Offset: 0x00033300
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			JObject result;
			try
			{
				try
				{
					TaskAwaiter<string> taskAwaiter;
					if (num != 0)
					{
						taskAwaiter = httpResponseMessage_0.Content.ReadAsStringAsync().GetAwaiter();
						if (!taskAwaiter.IsCompleted)
						{
							num2 = 0;
							TaskAwaiter<string> taskAwaiter2 = taskAwaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Class121.Struct44>(ref taskAwaiter, ref this);
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
					result = JObject.Parse(taskAwaiter.GetResult());
				}
				catch
				{
					result = null;
				}
			}
			catch (Exception exception)
			{
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			num2 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00005EC2 File Offset: 0x000040C2
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040002C7 RID: 711
		public int int_0;

		// Token: 0x040002C8 RID: 712
		public AsyncTaskMethodBuilder<JObject> asyncTaskMethodBuilder_0;

		// Token: 0x040002C9 RID: 713
		public HttpResponseMessage httpResponseMessage_0;

		// Token: 0x040002CA RID: 714
		private TaskAwaiter<string> taskAwaiter_0;
	}
}
