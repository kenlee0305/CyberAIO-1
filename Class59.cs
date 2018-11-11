using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Newtonsoft.Json.Linq;

// Token: 0x02000064 RID: 100
internal sealed class Class59
{
	// Token: 0x06000244 RID: 580 RVA: 0x00016708 File Offset: 0x00014908
	public Class59(JToken jtoken_2)
	{
		try
		{
			this.jtoken_0 = jtoken_2;
			this.class4_0 = new Class4(jtoken_2);
			if (!this.class4_0.method_3(out this.jtoken_1))
			{
				this.class4_0.method_0(Class185.smethod_0(537663358), Class185.smethod_0(537700909), true);
			}
			else
			{
				this.string_0 = (string)jtoken_2[Class185.smethod_0(537702300)];
				this.string_2 = (string)jtoken_2[Class185.smethod_0(537700008)];
				if (this.string_2 == Class185.smethod_0(537663132) || this.string_2 == Class185.smethod_0(537663113))
				{
					this.bool_0 = true;
				}
				this.class70_0 = new Class70(this.class4_0.method_6(), Class185.smethod_0(537692910), 10, false, false, null, false);
			}
		}
		catch
		{
			this.class4_0.method_0(Class185.smethod_0(537663193), Class185.smethod_0(537700909), true);
		}
	}

	// Token: 0x06000245 RID: 581 RVA: 0x00016838 File Offset: 0x00014A38
	public void method_0()
	{
		try
		{
			Task task = this.method_3();
			this.method_1().Wait();
			this.method_2().Wait();
			this.method_4().Wait();
			task.Wait();
			this.method_6().Wait();
			this.method_5().Wait();
			this.method_7().Wait();
			this.method_8().Wait();
		}
		catch
		{
		}
		finally
		{
			this.class4_0.method_0(Class185.smethod_0(537663178), Class185.smethod_0(537700909), true);
		}
	}

	// Token: 0x06000246 RID: 582 RVA: 0x000168E0 File Offset: 0x00014AE0
	public async Task method_1()
	{
		for (;;)
		{
			int num = 0;
			TaskAwaiter taskAwaiter2;
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), true, false);
				HttpResponseMessage httpResponseMessage = await this.class70_0.method_6(string.Format(Class185.smethod_0(537687616), this.string_0), false);
				httpResponseMessage.EnsureSuccessStatusCode();
				JObject jobject = httpResponseMessage.smethod_0();
				if (jobject.ContainsKey(Class185.smethod_0(537706536)))
				{
					throw new Exception();
				}
				this.class4_0.method_7((string)jobject[Class185.smethod_0(537712143)], Class185.smethod_0(537700781));
				if (this.bool_0)
				{
					JToken jtoken = jobject[Class185.smethod_0(537687432)].Where(new Func<JToken, bool>(Class59.Class60.class60_0.method_0)).smethod_2();
					if (jtoken == null)
					{
						this.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
						TaskAwaiter taskAwaiter = Task.Delay(GClass0.int_1).GetAwaiter();
						if (!taskAwaiter.IsCompleted)
						{
							await taskAwaiter;
							taskAwaiter = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter);
						}
						taskAwaiter.GetResult();
						continue;
					}
					this.class4_0.method_5((string)jtoken[Class185.smethod_0(537687427)]);
					this.string_1 = (string)jtoken[Class185.smethod_0(537703519)];
				}
				else
				{
					JToken jtoken2 = jobject[Class185.smethod_0(537687432)].FirstOrDefault(new Func<JToken, bool>(this.method_10));
					if (jtoken2 == null)
					{
						this.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), true, false);
						TaskAwaiter taskAwaiter = Task.Delay(GClass0.int_1).GetAwaiter();
						if (!taskAwaiter.IsCompleted)
						{
							await taskAwaiter;
							taskAwaiter = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter);
						}
						taskAwaiter.GetResult();
						continue;
					}
					this.string_1 = (string)jtoken2[Class185.smethod_0(537703519)];
				}
				this.class4_0.method_4(Class185.smethod_0(537675736) + this.string_1, Class185.smethod_0(537700781), true, false);
				break;
			}
			catch (ThreadAbortException)
			{
				break;
			}
			catch
			{
				num = 1;
			}
			if (num == 1)
			{
				this.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), true, false);
				TaskAwaiter taskAwaiter = Task.Delay(GClass0.int_1).GetAwaiter();
				if (!taskAwaiter.IsCompleted)
				{
					await taskAwaiter;
					taskAwaiter = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter);
				}
				taskAwaiter.GetResult();
			}
		}
	}

	// Token: 0x06000247 RID: 583 RVA: 0x00016928 File Offset: 0x00014B28
	public async Task method_2()
	{
		for (;;)
		{
			int num = 0;
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537663094), Class185.smethod_0(537662875), true, false);
				HttpResponseMessage httpResponseMessage = await this.class70_0.method_6(string.Format(Class185.smethod_0(537687764), this.string_1), false);
				if (httpResponseMessage.StatusCode == HttpStatusCode.Gone)
				{
					this.class4_0.method_0(Class185.smethod_0(537671545), Class185.smethod_0(537700909), false);
				}
				JObject jobject = httpResponseMessage.smethod_0();
				string a = (string)jobject[Class185.smethod_0(537687571)];
				if (a == Class185.smethod_0(537687552))
				{
					this.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
					await Task.Delay(GClass0.int_1);
					await this.method_1();
					continue;
				}
				if (!(a == Class185.smethod_0(537687604)))
				{
					throw new Exception();
				}
				this.class70_0.cookieContainer_0.Add(new Cookie((string)jobject[Class185.smethod_0(537687640)][Class185.smethod_0(537712143)], (string)jobject[Class185.smethod_0(537687640)][Class185.smethod_0(537711408)], (string)jobject[Class185.smethod_0(537687640)][Class185.smethod_0(537687637)], (string)jobject[Class185.smethod_0(537687640)][Class185.smethod_0(537692611)]));
				this.class4_0.method_4(Class185.smethod_0(537662950), Class185.smethod_0(537700781), true, false);
				break;
			}
			catch (ThreadAbortException)
			{
				break;
			}
			catch
			{
				num = 1;
			}
			if (num == 1)
			{
				this.class4_0.method_4(Class185.smethod_0(537662720), Class185.smethod_0(537700781), true, false);
				TaskAwaiter taskAwaiter = Task.Delay(GClass0.int_1).GetAwaiter();
				if (!taskAwaiter.IsCompleted)
				{
					await taskAwaiter;
					TaskAwaiter taskAwaiter2;
					taskAwaiter = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter);
				}
				taskAwaiter.GetResult();
			}
		}
	}

	// Token: 0x06000248 RID: 584 RVA: 0x00016970 File Offset: 0x00014B70
	public async Task method_3()
	{
		for (;;)
		{
			int num = 0;
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537687409), Class185.smethod_0(537700781), true, false);
				(await this.class70_0.method_6(Class185.smethod_0(537687399), true)).EnsureSuccessStatusCode();
				break;
			}
			catch (ThreadAbortException)
			{
				break;
			}
			catch
			{
				num = 1;
			}
			if (num == 1)
			{
				this.class4_0.method_4(Class185.smethod_0(537671436), Class185.smethod_0(537700781), true, false);
				TaskAwaiter taskAwaiter = Task.Delay(GClass0.int_1).GetAwaiter();
				if (!taskAwaiter.IsCompleted)
				{
					await taskAwaiter;
					TaskAwaiter taskAwaiter2;
					taskAwaiter = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter);
				}
				taskAwaiter.GetResult();
			}
		}
	}

	// Token: 0x06000249 RID: 585 RVA: 0x000169B8 File Offset: 0x00014BB8
	public async Task method_4()
	{
		for (;;)
		{
			int num = 0;
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537687477), Class185.smethod_0(537700781), true, false);
				(await this.class70_0.method_6(Class185.smethod_0(537687514), false)).EnsureSuccessStatusCode();
				break;
			}
			catch (ThreadAbortException)
			{
				break;
			}
			catch
			{
				num = 1;
			}
			if (num == 1)
			{
				this.class4_0.method_4(Class185.smethod_0(537687520), Class185.smethod_0(537700781), true, false);
				TaskAwaiter taskAwaiter = Task.Delay(GClass0.int_1).GetAwaiter();
				if (!taskAwaiter.IsCompleted)
				{
					await taskAwaiter;
					TaskAwaiter taskAwaiter2;
					taskAwaiter = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter);
				}
				taskAwaiter.GetResult();
			}
		}
	}

	// Token: 0x0600024A RID: 586 RVA: 0x00016A00 File Offset: 0x00014C00
	public async Task method_5()
	{
		for (;;)
		{
			int num = 0;
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537687307), Class185.smethod_0(537700781), true, false);
				TaskAwaiter<HttpResponseMessage> taskAwaiter = this.class70_0.method_6(Class185.smethod_0(537687346), false).GetAwaiter();
				if (!taskAwaiter.IsCompleted)
				{
					await taskAwaiter;
					TaskAwaiter<HttpResponseMessage> taskAwaiter2;
					taskAwaiter = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
				}
				if (!taskAwaiter.GetResult().Headers.Location.ToString().Contains(Class185.smethod_0(537687362)))
				{
					throw new Exception();
				}
				break;
			}
			catch (ThreadAbortException)
			{
				break;
			}
			catch
			{
				num = 1;
			}
			if (num == 1)
			{
				this.class4_0.method_4(Class185.smethod_0(537687520), Class185.smethod_0(537700781), true, false);
				TaskAwaiter taskAwaiter3 = Task.Delay(GClass0.int_1).GetAwaiter();
				if (!taskAwaiter3.IsCompleted)
				{
					await taskAwaiter3;
					TaskAwaiter taskAwaiter4;
					taskAwaiter3 = taskAwaiter4;
					taskAwaiter4 = default(TaskAwaiter);
				}
				taskAwaiter3.GetResult();
			}
		}
	}

	// Token: 0x0600024B RID: 587 RVA: 0x00016A48 File Offset: 0x00014C48
	public async Task method_6()
	{
		for (;;)
		{
			int num = 0;
			try
			{
				this.class70_0.httpClient_0.DefaultRequestHeaders.Clear();
				this.class4_0.method_4(Class185.smethod_0(537662763), Class185.smethod_0(537700781), true, false);
				Dictionary<string, string> dictionary = Class70.smethod_1();
				dictionary[Class185.smethod_0(537687245)] = (string)this.jtoken_1[Class185.smethod_0(537662788)][Class185.smethod_0(537662792)];
				dictionary[Class185.smethod_0(537687294)] = Class185.smethod_0(537687064);
				TaskAwaiter<HttpResponseMessage> taskAwaiter = this.class70_0.method_8(Class185.smethod_0(537687057), dictionary, false).GetAwaiter();
				if (!taskAwaiter.IsCompleted)
				{
					await taskAwaiter;
					TaskAwaiter<HttpResponseMessage> taskAwaiter2;
					taskAwaiter = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
				}
				if (taskAwaiter.GetResult().StatusCode != HttpStatusCode.Found)
				{
					throw new Exception();
				}
				break;
			}
			catch (ThreadAbortException)
			{
				break;
			}
			catch
			{
				num = 1;
			}
			if (num == 1)
			{
				this.class4_0.method_4(Class185.smethod_0(537662600), Class185.smethod_0(537700781), true, false);
				TaskAwaiter taskAwaiter3 = Task.Delay(GClass0.int_1).GetAwaiter();
				if (!taskAwaiter3.IsCompleted)
				{
					await taskAwaiter3;
					TaskAwaiter taskAwaiter4;
					taskAwaiter3 = taskAwaiter4;
					taskAwaiter4 = default(TaskAwaiter);
				}
				taskAwaiter3.GetResult();
			}
		}
	}

	// Token: 0x0600024C RID: 588 RVA: 0x00016A90 File Offset: 0x00014C90
	public async Task method_7()
	{
		for (;;)
		{
			int num = 0;
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537662655), Class185.smethod_0(537700781), true, false);
				Dictionary<string, string> dictionary = Class70.smethod_1();
				dictionary[Class185.smethod_0(537687151)] = Class185.smethod_0(537684881);
				dictionary[Class185.smethod_0(537684865)] = Class185.smethod_0(537684917);
				dictionary[Class185.smethod_0(537684910)] = (string)this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537662508)];
				dictionary[Class185.smethod_0(537684950)] = (string)this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537662540)];
				dictionary[Class185.smethod_0(537684989)] = Class172.smethod_0((string)this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], false);
				dictionary[Class185.smethod_0(537684761)] = (string)this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537662571)];
				dictionary[Class185.smethod_0(537684736)] = (string)this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537660290)];
				dictionary[Class185.smethod_0(537684791)] = Class172.smethod_1((string)this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], (string)this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)]);
				dictionary[Class185.smethod_0(537684827)] = (string)this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537660362)];
				dictionary[Class185.smethod_0(537684802)] = (string)this.jtoken_1[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)];
				dictionary[Class185.smethod_0(537684853)] = Class185.smethod_0(537692590);
				dictionary[Class185.smethod_0(537684626)] = Class185.smethod_0(537684659);
				dictionary[Class185.smethod_0(537684701)] = Class185.smethod_0(537684677);
				dictionary[Class185.smethod_0(537684720)] = Class185.smethod_0(537684718);
				HttpResponseMessage httpResponseMessage = await this.class70_0.method_8(Class185.smethod_0(537684498), dictionary, true);
				httpResponseMessage.EnsureSuccessStatusCode();
				HtmlDocument htmlDocument = new HtmlDocument();
				htmlDocument.LoadHtml(httpResponseMessage.smethod_3());
				string value = htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537684566)).Attributes[Class185.smethod_0(537711408)].Value;
				string value2 = htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537684590)).Attributes[Class185.smethod_0(537711408)].Value;
				string value3 = htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537684352)).Attributes[Class185.smethod_0(537711408)].Value;
				string value4 = htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537684396)).Attributes[Class185.smethod_0(537711408)].Value;
				Console.WriteLine(Class185.smethod_0(537684418));
				this.dictionary_0[Class185.smethod_0(537684477)] = string.Format(Class185.smethod_0(537684463), value4);
				this.dictionary_0[Class185.smethod_0(537684345)] = Class185.smethod_0(537708442);
				this.dictionary_0[Class185.smethod_0(537674618)] = Class185.smethod_0(537684343);
				this.dictionary_0[Class185.smethod_0(537684322)] = Class185.smethod_0(537692774);
				this.dictionary_0[Class185.smethod_0(537677407)] = (string)this.jtoken_1[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660835)];
				this.dictionary_0[Class185.smethod_0(537684114)] = this.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537662508)] + Class185.smethod_0(537711014) + this.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537662540)];
				this.dictionary_0[Class185.smethod_0(537684152)] = (string)this.jtoken_1[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660682)];
				this.dictionary_0[Class185.smethod_0(537674431)] = (string)this.jtoken_1[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660870)];
				this.dictionary_0[Class185.smethod_0(537674401)] = (string)this.jtoken_1[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660699)];
				this.dictionary_0[Class185.smethod_0(537684136)] = string.Empty;
				this.dictionary_0[Class185.smethod_0(537684186)] = Class185.smethod_0(537692774);
				this.dictionary_0[Class185.smethod_0(537684169)] = value;
				this.dictionary_0[Class185.smethod_0(537684208)] = value2;
				this.dictionary_0[Class185.smethod_0(537684193)] = value3;
				break;
			}
			catch (ThreadAbortException)
			{
				break;
			}
			catch
			{
				num = 1;
			}
			if (num == 1)
			{
				this.class4_0.method_4(Class185.smethod_0(537659996), Class185.smethod_0(537700781), true, false);
				TaskAwaiter taskAwaiter = Task.Delay(GClass0.int_1).GetAwaiter();
				if (!taskAwaiter.IsCompleted)
				{
					await taskAwaiter;
					TaskAwaiter taskAwaiter2;
					taskAwaiter = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter);
				}
				taskAwaiter.GetResult();
			}
		}
	}

	// Token: 0x0600024D RID: 589 RVA: 0x00016AD8 File Offset: 0x00014CD8
	public async Task method_8()
	{
		for (;;)
		{
			int num = 0;
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537660830), Class185.smethod_0(537700964), true, false);
				await this.class70_0.method_8(Class185.smethod_0(537687133), this.dictionary_0, false);
				break;
			}
			catch (ThreadAbortException)
			{
				break;
			}
			catch
			{
				num = 1;
			}
			if (num == 1)
			{
				this.class4_0.method_4(Class185.smethod_0(537700684), Class185.smethod_0(537700781), true, false);
				TaskAwaiter taskAwaiter = Task.Delay(GClass0.int_1).GetAwaiter();
				if (!taskAwaiter.IsCompleted)
				{
					await taskAwaiter;
					TaskAwaiter taskAwaiter2;
					taskAwaiter = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter);
				}
				taskAwaiter.GetResult();
			}
		}
	}

	// Token: 0x0600024E RID: 590 RVA: 0x00016B20 File Offset: 0x00014D20
	public async Task method_9()
	{
		for (;;)
		{
			int num = 0;
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537683996), Class185.smethod_0(537700781), true, false);
				goto IL_A4;
			}
			catch (ThreadAbortException)
			{
				break;
			}
			catch
			{
				num = 1;
				goto IL_A4;
			}
			continue;
			IL_A4:
			if (num == 1)
			{
				this.class4_0.method_4(Class185.smethod_0(537700684), Class185.smethod_0(537700781), true, false);
				TaskAwaiter taskAwaiter = Task.Delay(GClass0.int_1).GetAwaiter();
				if (!taskAwaiter.IsCompleted)
				{
					await taskAwaiter;
					TaskAwaiter taskAwaiter2;
					taskAwaiter = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter);
				}
				taskAwaiter.GetResult();
			}
		}
	}

	// Token: 0x0600024F RID: 591 RVA: 0x00004142 File Offset: 0x00002342
	private bool method_10(JToken jtoken_2)
	{
		return Class172.smethod_2(this.string_2, (string)jtoken_2[Class185.smethod_0(537687427)]);
	}

	// Token: 0x0400012A RID: 298
	private Class70 class70_0;

	// Token: 0x0400012B RID: 299
	private JToken jtoken_0;

	// Token: 0x0400012C RID: 300
	private JToken jtoken_1;

	// Token: 0x0400012D RID: 301
	private Class4 class4_0;

	// Token: 0x0400012E RID: 302
	private string string_0;

	// Token: 0x0400012F RID: 303
	private string string_1;

	// Token: 0x04000130 RID: 304
	private string string_2;

	// Token: 0x04000131 RID: 305
	private bool bool_0;

	// Token: 0x04000132 RID: 306
	private Dictionary<string, string> dictionary_0 = new Dictionary<string, string>();

	// Token: 0x02000065 RID: 101
	[Serializable]
	private sealed class Class60
	{
		// Token: 0x06000252 RID: 594 RVA: 0x00004170 File Offset: 0x00002370
		internal bool method_0(JToken jtoken_0)
		{
			return (string)jtoken_0[Class185.smethod_0(537687728)] != Class185.smethod_0(537687713);
		}

		// Token: 0x04000133 RID: 307
		public static readonly Class59.Class60 class60_0 = new Class59.Class60();

		// Token: 0x04000134 RID: 308
		public static Func<JToken, bool> func_0;
	}

	// Token: 0x02000066 RID: 102
	[StructLayout(LayoutKind.Auto)]
	private struct Struct9 : IAsyncStateMachine
	{
		// Token: 0x06000253 RID: 595 RVA: 0x00016B68 File Offset: 0x00014D68
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			Class59 @class = this;
			try
			{
				if (num == 0)
				{
					goto IL_12D;
				}
				if (num != 1)
				{
					goto IL_12B;
				}
				TaskAwaiter taskAwaiter3 = taskAwaiter2;
				taskAwaiter2 = default(TaskAwaiter);
				int num3 = -1;
				num = -1;
				num2 = num3;
				IL_124:
				taskAwaiter3.GetResult();
				IL_12B:
				int num4 = 0;
				IL_12D:
				try
				{
					TaskAwaiter<HttpResponseMessage> taskAwaiter4;
					if (num != 0)
					{
						@class.class4_0.method_4(Class185.smethod_0(537660830), Class185.smethod_0(537700964), true, false);
						taskAwaiter4 = @class.class70_0.method_8(Class185.smethod_0(537687133), @class.dictionary_0, false).GetAwaiter();
						if (!taskAwaiter4.IsCompleted)
						{
							int num5 = 0;
							num = 0;
							num2 = num5;
							TaskAwaiter<HttpResponseMessage> taskAwaiter5 = taskAwaiter4;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class59.Struct9>(ref taskAwaiter4, ref this);
							return;
						}
					}
					else
					{
						TaskAwaiter<HttpResponseMessage> taskAwaiter5;
						taskAwaiter4 = taskAwaiter5;
						taskAwaiter5 = default(TaskAwaiter<HttpResponseMessage>);
						int num6 = -1;
						num = -1;
						num2 = num6;
					}
					taskAwaiter4.GetResult();
					goto IL_16D;
				}
				catch (ThreadAbortException)
				{
					goto IL_16D;
				}
				catch
				{
					num4 = 1;
				}
				if (num4 != 1)
				{
					goto IL_12B;
				}
				@class.class4_0.method_4(Class185.smethod_0(537700684), Class185.smethod_0(537700781), true, false);
				taskAwaiter3 = Task.Delay(GClass0.int_1).GetAwaiter();
				if (taskAwaiter3.IsCompleted)
				{
					goto IL_124;
				}
				int num7 = 1;
				num = 1;
				num2 = num7;
				taskAwaiter2 = taskAwaiter3;
				this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class59.Struct9>(ref taskAwaiter3, ref this);
				return;
			}
			catch (Exception exception)
			{
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_16D:
			num2 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00004196 File Offset: 0x00002396
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000135 RID: 309
		public int int_0;

		// Token: 0x04000136 RID: 310
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000137 RID: 311
		public Class59 class59_0;

		// Token: 0x04000138 RID: 312
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x04000139 RID: 313
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x02000067 RID: 103
	[StructLayout(LayoutKind.Auto)]
	private struct Struct10 : IAsyncStateMachine
	{
		// Token: 0x06000255 RID: 597 RVA: 0x00016D44 File Offset: 0x00014F44
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			Class59 @class = this;
			try
			{
				TaskAwaiter taskAwaiter3;
				if (num > 2)
				{
					if (num != 3)
					{
						goto IL_35C;
					}
					taskAwaiter3 = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					num2 = num3;
					goto IL_355;
				}
				IL_3C:
				int num10;
				try
				{
					TaskAwaiter<HttpResponseMessage> taskAwaiter4;
					switch (num)
					{
					case 0:
					{
						TaskAwaiter<HttpResponseMessage> taskAwaiter5;
						taskAwaiter4 = taskAwaiter5;
						taskAwaiter5 = default(TaskAwaiter<HttpResponseMessage>);
						int num4 = -1;
						num = -1;
						num2 = num4;
						break;
					}
					case 1:
					{
						taskAwaiter3 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						int num5 = -1;
						num = -1;
						num2 = num5;
						goto IL_2A6;
					}
					case 2:
					{
						taskAwaiter3 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						int num6 = -1;
						num = -1;
						num2 = num6;
						goto IL_301;
					}
					default:
						@class.class4_0.method_4(Class185.smethod_0(537663094), Class185.smethod_0(537662875), true, false);
						taskAwaiter4 = @class.class70_0.method_6(string.Format(Class185.smethod_0(537687764), @class.string_1), false).GetAwaiter();
						if (!taskAwaiter4.IsCompleted)
						{
							int num7 = 0;
							num = 0;
							num2 = num7;
							TaskAwaiter<HttpResponseMessage> taskAwaiter5 = taskAwaiter4;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class59.Struct10>(ref taskAwaiter4, ref this);
							return;
						}
						break;
					}
					HttpResponseMessage result = taskAwaiter4.GetResult();
					if (result.StatusCode == HttpStatusCode.Gone)
					{
						@class.class4_0.method_0(Class185.smethod_0(537671545), Class185.smethod_0(537700909), false);
					}
					JObject jobject = result.smethod_0();
					string a = (string)jobject[Class185.smethod_0(537687571)];
					if (!(a == Class185.smethod_0(537687552)))
					{
						if (!(a == Class185.smethod_0(537687604)))
						{
							throw new Exception();
						}
						@class.class70_0.cookieContainer_0.Add(new Cookie((string)jobject[Class185.smethod_0(537687640)][Class185.smethod_0(537712143)], (string)jobject[Class185.smethod_0(537687640)][Class185.smethod_0(537711408)], (string)jobject[Class185.smethod_0(537687640)][Class185.smethod_0(537687637)], (string)jobject[Class185.smethod_0(537687640)][Class185.smethod_0(537692611)]));
						@class.class4_0.method_4(Class185.smethod_0(537662950), Class185.smethod_0(537700781), true, false);
						goto IL_39D;
					}
					else
					{
						@class.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
						taskAwaiter3 = Task.Delay(GClass0.int_1).GetAwaiter();
						if (!taskAwaiter3.IsCompleted)
						{
							int num8 = 1;
							num = 1;
							num2 = num8;
							taskAwaiter2 = taskAwaiter3;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class59.Struct10>(ref taskAwaiter3, ref this);
							return;
						}
					}
					IL_2A6:
					taskAwaiter3.GetResult();
					taskAwaiter3 = @class.method_1().GetAwaiter();
					if (!taskAwaiter3.IsCompleted)
					{
						int num9 = 2;
						num = 2;
						num2 = num9;
						taskAwaiter2 = taskAwaiter3;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class59.Struct10>(ref taskAwaiter3, ref this);
						return;
					}
					IL_301:
					taskAwaiter3.GetResult();
					goto IL_35C;
				}
				catch (ThreadAbortException)
				{
					goto IL_39D;
				}
				catch
				{
					num10 = 1;
				}
				if (num10 != 1)
				{
					goto IL_35C;
				}
				@class.class4_0.method_4(Class185.smethod_0(537662720), Class185.smethod_0(537700781), true, false);
				taskAwaiter3 = Task.Delay(GClass0.int_1).GetAwaiter();
				if (!taskAwaiter3.IsCompleted)
				{
					int num11 = 3;
					num = 3;
					num2 = num11;
					taskAwaiter2 = taskAwaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class59.Struct10>(ref taskAwaiter3, ref this);
					return;
				}
				IL_355:
				taskAwaiter3.GetResult();
				IL_35C:
				num10 = 0;
				goto IL_3C;
			}
			catch (Exception exception)
			{
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_39D:
			num2 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000256 RID: 598 RVA: 0x000041A4 File Offset: 0x000023A4
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400013A RID: 314
		public int int_0;

		// Token: 0x0400013B RID: 315
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400013C RID: 316
		public Class59 class59_0;

		// Token: 0x0400013D RID: 317
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x0400013E RID: 318
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x02000068 RID: 104
	[StructLayout(LayoutKind.Auto)]
	private struct Struct11 : IAsyncStateMachine
	{
		// Token: 0x06000257 RID: 599 RVA: 0x00017150 File Offset: 0x00015350
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			Class59 @class = this;
			try
			{
				if (num == 0)
				{
					goto IL_756;
				}
				if (num != 1)
				{
					goto IL_754;
				}
				TaskAwaiter taskAwaiter3 = taskAwaiter2;
				taskAwaiter2 = default(TaskAwaiter);
				int num3 = -1;
				num = -1;
				num2 = num3;
				IL_74D:
				taskAwaiter3.GetResult();
				IL_754:
				int num4 = 0;
				IL_756:
				try
				{
					TaskAwaiter<HttpResponseMessage> taskAwaiter4;
					if (num != 0)
					{
						@class.class4_0.method_4(Class185.smethod_0(537662655), Class185.smethod_0(537700781), true, false);
						Dictionary<string, string> dictionary = Class70.smethod_1();
						dictionary[Class185.smethod_0(537687151)] = Class185.smethod_0(537684881);
						dictionary[Class185.smethod_0(537684865)] = Class185.smethod_0(537684917);
						dictionary[Class185.smethod_0(537684910)] = (string)@class.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537662508)];
						dictionary[Class185.smethod_0(537684950)] = (string)@class.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537662540)];
						dictionary[Class185.smethod_0(537684989)] = Class172.smethod_0((string)@class.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], false);
						dictionary[Class185.smethod_0(537684761)] = (string)@class.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537662571)];
						dictionary[Class185.smethod_0(537684736)] = (string)@class.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537660290)];
						dictionary[Class185.smethod_0(537684791)] = Class172.smethod_1((string)@class.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], (string)@class.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)]);
						dictionary[Class185.smethod_0(537684827)] = (string)@class.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537660362)];
						dictionary[Class185.smethod_0(537684802)] = (string)@class.jtoken_1[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)];
						dictionary[Class185.smethod_0(537684853)] = Class185.smethod_0(537692590);
						dictionary[Class185.smethod_0(537684626)] = Class185.smethod_0(537684659);
						dictionary[Class185.smethod_0(537684701)] = Class185.smethod_0(537684677);
						dictionary[Class185.smethod_0(537684720)] = Class185.smethod_0(537684718);
						taskAwaiter4 = @class.class70_0.method_8(Class185.smethod_0(537684498), dictionary, true).GetAwaiter();
						if (!taskAwaiter4.IsCompleted)
						{
							int num5 = 0;
							num = 0;
							num2 = num5;
							TaskAwaiter<HttpResponseMessage> taskAwaiter5 = taskAwaiter4;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class59.Struct11>(ref taskAwaiter4, ref this);
							return;
						}
					}
					else
					{
						TaskAwaiter<HttpResponseMessage> taskAwaiter5;
						taskAwaiter4 = taskAwaiter5;
						taskAwaiter5 = default(TaskAwaiter<HttpResponseMessage>);
						int num6 = -1;
						num = -1;
						num2 = num6;
					}
					HttpResponseMessage result = taskAwaiter4.GetResult();
					result.EnsureSuccessStatusCode();
					HtmlDocument htmlDocument = new HtmlDocument();
					htmlDocument.LoadHtml(result.smethod_3());
					string value = htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537684566)).Attributes[Class185.smethod_0(537711408)].Value;
					string value2 = htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537684590)).Attributes[Class185.smethod_0(537711408)].Value;
					string value3 = htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537684352)).Attributes[Class185.smethod_0(537711408)].Value;
					string value4 = htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537684396)).Attributes[Class185.smethod_0(537711408)].Value;
					Console.WriteLine(Class185.smethod_0(537684418));
					@class.dictionary_0[Class185.smethod_0(537684477)] = string.Format(Class185.smethod_0(537684463), value4);
					@class.dictionary_0[Class185.smethod_0(537684345)] = Class185.smethod_0(537708442);
					@class.dictionary_0[Class185.smethod_0(537674618)] = Class185.smethod_0(537684343);
					@class.dictionary_0[Class185.smethod_0(537684322)] = Class185.smethod_0(537692774);
					@class.dictionary_0[Class185.smethod_0(537677407)] = (string)@class.jtoken_1[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660835)];
					@class.dictionary_0[Class185.smethod_0(537684114)] = @class.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537662508)] + Class185.smethod_0(537711014) + @class.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537662540)];
					@class.dictionary_0[Class185.smethod_0(537684152)] = (string)@class.jtoken_1[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660682)];
					@class.dictionary_0[Class185.smethod_0(537674431)] = (string)@class.jtoken_1[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660870)];
					@class.dictionary_0[Class185.smethod_0(537674401)] = (string)@class.jtoken_1[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660699)];
					@class.dictionary_0[Class185.smethod_0(537684136)] = string.Empty;
					@class.dictionary_0[Class185.smethod_0(537684186)] = Class185.smethod_0(537692774);
					@class.dictionary_0[Class185.smethod_0(537684169)] = value;
					@class.dictionary_0[Class185.smethod_0(537684208)] = value2;
					@class.dictionary_0[Class185.smethod_0(537684193)] = value3;
					goto IL_796;
				}
				catch (ThreadAbortException)
				{
					goto IL_796;
				}
				catch
				{
					num4 = 1;
				}
				if (num4 != 1)
				{
					goto IL_754;
				}
				@class.class4_0.method_4(Class185.smethod_0(537659996), Class185.smethod_0(537700781), true, false);
				taskAwaiter3 = Task.Delay(GClass0.int_1).GetAwaiter();
				if (taskAwaiter3.IsCompleted)
				{
					goto IL_74D;
				}
				int num7 = 1;
				num = 1;
				num2 = num7;
				taskAwaiter2 = taskAwaiter3;
				this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class59.Struct11>(ref taskAwaiter3, ref this);
				return;
			}
			catch (Exception exception)
			{
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_796:
			num2 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000258 RID: 600 RVA: 0x000041B2 File Offset: 0x000023B2
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400013F RID: 319
		public int int_0;

		// Token: 0x04000140 RID: 320
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000141 RID: 321
		public Class59 class59_0;

		// Token: 0x04000142 RID: 322
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x04000143 RID: 323
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x02000069 RID: 105
	[StructLayout(LayoutKind.Auto)]
	private struct Struct12 : IAsyncStateMachine
	{
		// Token: 0x06000259 RID: 601 RVA: 0x00017954 File Offset: 0x00015B54
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			Class59 @class = this;
			try
			{
				TaskAwaiter taskAwaiter3;
				if (num > 2)
				{
					if (num != 3)
					{
						goto IL_394;
					}
					taskAwaiter3 = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					num2 = num3;
					goto IL_38D;
				}
				IL_3C:
				int num10;
				try
				{
					TaskAwaiter<HttpResponseMessage> taskAwaiter4;
					switch (num)
					{
					case 0:
					{
						TaskAwaiter<HttpResponseMessage> taskAwaiter5;
						taskAwaiter4 = taskAwaiter5;
						taskAwaiter5 = default(TaskAwaiter<HttpResponseMessage>);
						int num4 = -1;
						num = -1;
						num2 = num4;
						break;
					}
					case 1:
					{
						taskAwaiter3 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						int num5 = -1;
						num = -1;
						num2 = num5;
						goto IL_314;
					}
					case 2:
					{
						taskAwaiter3 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						int num6 = -1;
						num = -1;
						num2 = num6;
						goto IL_339;
					}
					default:
						@class.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), true, false);
						taskAwaiter4 = @class.class70_0.method_6(string.Format(Class185.smethod_0(537687616), @class.string_0), false).GetAwaiter();
						if (!taskAwaiter4.IsCompleted)
						{
							int num7 = 0;
							num = 0;
							num2 = num7;
							TaskAwaiter<HttpResponseMessage> taskAwaiter5 = taskAwaiter4;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class59.Struct12>(ref taskAwaiter4, ref this);
							return;
						}
						break;
					}
					HttpResponseMessage result = taskAwaiter4.GetResult();
					result.EnsureSuccessStatusCode();
					JObject jobject = result.smethod_0();
					if (jobject.ContainsKey(Class185.smethod_0(537706536)))
					{
						throw new Exception();
					}
					@class.class4_0.method_7((string)jobject[Class185.smethod_0(537712143)], Class185.smethod_0(537700781));
					if (@class.bool_0)
					{
						JToken jtoken = jobject[Class185.smethod_0(537687432)].Where(new Func<JToken, bool>(Class59.Class60.class60_0.method_0)).smethod_2();
						if (jtoken == null)
						{
							@class.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
							taskAwaiter3 = Task.Delay(GClass0.int_1).GetAwaiter();
							if (!taskAwaiter3.IsCompleted)
							{
								int num8 = 1;
								num = 1;
								num2 = num8;
								taskAwaiter2 = taskAwaiter3;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class59.Struct12>(ref taskAwaiter3, ref this);
								return;
							}
							goto IL_314;
						}
						else
						{
							@class.class4_0.method_5((string)jtoken[Class185.smethod_0(537687427)]);
							@class.string_1 = (string)jtoken[Class185.smethod_0(537703519)];
						}
					}
					else
					{
						JToken jtoken2 = jobject[Class185.smethod_0(537687432)].FirstOrDefault(new Func<JToken, bool>(@class.method_10));
						if (jtoken2 == null)
						{
							@class.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), true, false);
							taskAwaiter3 = Task.Delay(GClass0.int_1).GetAwaiter();
							if (!taskAwaiter3.IsCompleted)
							{
								int num9 = 2;
								num = 2;
								num2 = num9;
								taskAwaiter2 = taskAwaiter3;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class59.Struct12>(ref taskAwaiter3, ref this);
								return;
							}
							goto IL_339;
						}
						else
						{
							@class.string_1 = (string)jtoken2[Class185.smethod_0(537703519)];
						}
					}
					@class.class4_0.method_4(Class185.smethod_0(537675736) + @class.string_1, Class185.smethod_0(537700781), true, false);
					goto IL_3D5;
					IL_314:
					taskAwaiter3.GetResult();
					goto IL_394;
					IL_339:
					taskAwaiter3.GetResult();
					goto IL_394;
				}
				catch (ThreadAbortException)
				{
					goto IL_3D5;
				}
				catch
				{
					num10 = 1;
				}
				if (num10 != 1)
				{
					goto IL_394;
				}
				@class.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), true, false);
				taskAwaiter3 = Task.Delay(GClass0.int_1).GetAwaiter();
				if (!taskAwaiter3.IsCompleted)
				{
					int num11 = 3;
					num = 3;
					num2 = num11;
					taskAwaiter2 = taskAwaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class59.Struct12>(ref taskAwaiter3, ref this);
					return;
				}
				IL_38D:
				taskAwaiter3.GetResult();
				IL_394:
				num10 = 0;
				goto IL_3C;
			}
			catch (Exception exception)
			{
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_3D5:
			num2 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x0600025A RID: 602 RVA: 0x000041C0 File Offset: 0x000023C0
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000144 RID: 324
		public int int_0;

		// Token: 0x04000145 RID: 325
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000146 RID: 326
		public Class59 class59_0;

		// Token: 0x04000147 RID: 327
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x04000148 RID: 328
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x0200006A RID: 106
	[StructLayout(LayoutKind.Auto)]
	private struct Struct13 : IAsyncStateMachine
	{
		// Token: 0x0600025B RID: 603 RVA: 0x00017D98 File Offset: 0x00015F98
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			Class59 @class = this;
			try
			{
				TaskAwaiter taskAwaiter3;
				if (num == 0)
				{
					taskAwaiter3 = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter);
					num2 = -1;
					goto IL_2D;
				}
				int num3;
				do
				{
					IL_64:
					num3 = 0;
					try
					{
						@class.class4_0.method_4(Class185.smethod_0(537683996), Class185.smethod_0(537700781), true, false);
						goto IL_A4;
					}
					catch (ThreadAbortException)
					{
						goto IL_E3;
					}
					catch
					{
						num3 = 1;
						goto IL_A4;
					}
					continue;
					IL_A4:;
				}
				while (num3 != 1);
				@class.class4_0.method_4(Class185.smethod_0(537700684), Class185.smethod_0(537700781), true, false);
				taskAwaiter3 = Task.Delay(GClass0.int_1).GetAwaiter();
				if (!taskAwaiter3.IsCompleted)
				{
					num2 = 0;
					taskAwaiter2 = taskAwaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class59.Struct13>(ref taskAwaiter3, ref this);
					return;
				}
				IL_2D:
				taskAwaiter3.GetResult();
				goto IL_64;
			}
			catch (Exception exception)
			{
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_E3:
			num2 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x0600025C RID: 604 RVA: 0x000041CE File Offset: 0x000023CE
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000149 RID: 329
		public int int_0;

		// Token: 0x0400014A RID: 330
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400014B RID: 331
		public Class59 class59_0;

		// Token: 0x0400014C RID: 332
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200006B RID: 107
	[StructLayout(LayoutKind.Auto)]
	private struct Struct14 : IAsyncStateMachine
	{
		// Token: 0x0600025D RID: 605 RVA: 0x00017EC4 File Offset: 0x000160C4
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			Class59 @class = this;
			try
			{
				if (num == 0)
				{
					goto IL_14C;
				}
				if (num != 1)
				{
					goto IL_14A;
				}
				TaskAwaiter taskAwaiter5 = taskAwaiter4;
				taskAwaiter4 = default(TaskAwaiter);
				int num3 = -1;
				num = -1;
				num2 = num3;
				IL_143:
				taskAwaiter5.GetResult();
				IL_14A:
				int num4 = 0;
				IL_14C:
				try
				{
					TaskAwaiter<HttpResponseMessage> taskAwaiter6;
					if (num != 0)
					{
						@class.class4_0.method_4(Class185.smethod_0(537687307), Class185.smethod_0(537700781), true, false);
						taskAwaiter6 = @class.class70_0.method_6(Class185.smethod_0(537687346), false).GetAwaiter();
						if (!taskAwaiter6.IsCompleted)
						{
							int num5 = 0;
							num = 0;
							num2 = num5;
							taskAwaiter2 = taskAwaiter6;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class59.Struct14>(ref taskAwaiter6, ref this);
							return;
						}
					}
					else
					{
						taskAwaiter6 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
						int num6 = -1;
						num = -1;
						num2 = num6;
					}
					if (!taskAwaiter6.GetResult().Headers.Location.ToString().Contains(Class185.smethod_0(537687362)))
					{
						throw new Exception();
					}
					goto IL_18C;
				}
				catch (ThreadAbortException)
				{
					goto IL_18C;
				}
				catch
				{
					num4 = 1;
				}
				if (num4 != 1)
				{
					goto IL_14A;
				}
				@class.class4_0.method_4(Class185.smethod_0(537687520), Class185.smethod_0(537700781), true, false);
				taskAwaiter5 = Task.Delay(GClass0.int_1).GetAwaiter();
				if (taskAwaiter5.IsCompleted)
				{
					goto IL_143;
				}
				int num7 = 1;
				num = 1;
				num2 = num7;
				taskAwaiter4 = taskAwaiter5;
				this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class59.Struct14>(ref taskAwaiter5, ref this);
				return;
			}
			catch (Exception exception)
			{
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_18C:
			num2 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000041DC File Offset: 0x000023DC
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400014D RID: 333
		public int int_0;

		// Token: 0x0400014E RID: 334
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400014F RID: 335
		public Class59 class59_0;

		// Token: 0x04000150 RID: 336
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x04000151 RID: 337
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x0200006C RID: 108
	[StructLayout(LayoutKind.Auto)]
	private struct Struct15 : IAsyncStateMachine
	{
		// Token: 0x0600025F RID: 607 RVA: 0x000180BC File Offset: 0x000162BC
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			Class59 @class = this;
			try
			{
				if (num == 0)
				{
					goto IL_12C;
				}
				if (num != 1)
				{
					goto IL_12A;
				}
				TaskAwaiter taskAwaiter3 = taskAwaiter2;
				taskAwaiter2 = default(TaskAwaiter);
				int num3 = -1;
				num = -1;
				num2 = num3;
				IL_123:
				taskAwaiter3.GetResult();
				IL_12A:
				int num4 = 0;
				IL_12C:
				try
				{
					TaskAwaiter<HttpResponseMessage> taskAwaiter4;
					if (num != 0)
					{
						@class.class4_0.method_4(Class185.smethod_0(537687477), Class185.smethod_0(537700781), true, false);
						taskAwaiter4 = @class.class70_0.method_6(Class185.smethod_0(537687514), false).GetAwaiter();
						if (!taskAwaiter4.IsCompleted)
						{
							int num5 = 0;
							num = 0;
							num2 = num5;
							TaskAwaiter<HttpResponseMessage> taskAwaiter5 = taskAwaiter4;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class59.Struct15>(ref taskAwaiter4, ref this);
							return;
						}
					}
					else
					{
						TaskAwaiter<HttpResponseMessage> taskAwaiter5;
						taskAwaiter4 = taskAwaiter5;
						taskAwaiter5 = default(TaskAwaiter<HttpResponseMessage>);
						int num6 = -1;
						num = -1;
						num2 = num6;
					}
					taskAwaiter4.GetResult().EnsureSuccessStatusCode();
					goto IL_16C;
				}
				catch (ThreadAbortException)
				{
					goto IL_16C;
				}
				catch
				{
					num4 = 1;
				}
				if (num4 != 1)
				{
					goto IL_12A;
				}
				@class.class4_0.method_4(Class185.smethod_0(537687520), Class185.smethod_0(537700781), true, false);
				taskAwaiter3 = Task.Delay(GClass0.int_1).GetAwaiter();
				if (taskAwaiter3.IsCompleted)
				{
					goto IL_123;
				}
				int num7 = 1;
				num = 1;
				num2 = num7;
				taskAwaiter2 = taskAwaiter3;
				this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class59.Struct15>(ref taskAwaiter3, ref this);
				return;
			}
			catch (Exception exception)
			{
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_16C:
			num2 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000041EA File Offset: 0x000023EA
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000152 RID: 338
		public int int_0;

		// Token: 0x04000153 RID: 339
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000154 RID: 340
		public Class59 class59_0;

		// Token: 0x04000155 RID: 341
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x04000156 RID: 342
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x0200006D RID: 109
	[StructLayout(LayoutKind.Auto)]
	private struct Struct16 : IAsyncStateMachine
	{
		// Token: 0x06000261 RID: 609 RVA: 0x00018294 File Offset: 0x00016494
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			Class59 @class = this;
			try
			{
				if (num == 0)
				{
					goto IL_12C;
				}
				if (num != 1)
				{
					goto IL_12A;
				}
				TaskAwaiter taskAwaiter3 = taskAwaiter2;
				taskAwaiter2 = default(TaskAwaiter);
				int num3 = -1;
				num = -1;
				num2 = num3;
				IL_123:
				taskAwaiter3.GetResult();
				IL_12A:
				int num4 = 0;
				IL_12C:
				try
				{
					TaskAwaiter<HttpResponseMessage> taskAwaiter4;
					if (num != 0)
					{
						@class.class4_0.method_4(Class185.smethod_0(537687409), Class185.smethod_0(537700781), true, false);
						taskAwaiter4 = @class.class70_0.method_6(Class185.smethod_0(537687399), true).GetAwaiter();
						if (!taskAwaiter4.IsCompleted)
						{
							int num5 = 0;
							num = 0;
							num2 = num5;
							TaskAwaiter<HttpResponseMessage> taskAwaiter5 = taskAwaiter4;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class59.Struct16>(ref taskAwaiter4, ref this);
							return;
						}
					}
					else
					{
						TaskAwaiter<HttpResponseMessage> taskAwaiter5;
						taskAwaiter4 = taskAwaiter5;
						taskAwaiter5 = default(TaskAwaiter<HttpResponseMessage>);
						int num6 = -1;
						num = -1;
						num2 = num6;
					}
					taskAwaiter4.GetResult().EnsureSuccessStatusCode();
					goto IL_16C;
				}
				catch (ThreadAbortException)
				{
					goto IL_16C;
				}
				catch
				{
					num4 = 1;
				}
				if (num4 != 1)
				{
					goto IL_12A;
				}
				@class.class4_0.method_4(Class185.smethod_0(537671436), Class185.smethod_0(537700781), true, false);
				taskAwaiter3 = Task.Delay(GClass0.int_1).GetAwaiter();
				if (taskAwaiter3.IsCompleted)
				{
					goto IL_123;
				}
				int num7 = 1;
				num = 1;
				num2 = num7;
				taskAwaiter2 = taskAwaiter3;
				this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class59.Struct16>(ref taskAwaiter3, ref this);
				return;
			}
			catch (Exception exception)
			{
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_16C:
			num2 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000041F8 File Offset: 0x000023F8
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000157 RID: 343
		public int int_0;

		// Token: 0x04000158 RID: 344
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000159 RID: 345
		public Class59 class59_0;

		// Token: 0x0400015A RID: 346
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x0400015B RID: 347
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x0200006E RID: 110
	[StructLayout(LayoutKind.Auto)]
	private struct Struct17 : IAsyncStateMachine
	{
		// Token: 0x06000263 RID: 611 RVA: 0x0001846C File Offset: 0x0001666C
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			Class59 @class = this;
			try
			{
				if (num == 0)
				{
					goto IL_1AD;
				}
				if (num != 1)
				{
					goto IL_1AB;
				}
				TaskAwaiter taskAwaiter5 = taskAwaiter4;
				taskAwaiter4 = default(TaskAwaiter);
				int num3 = -1;
				num = -1;
				num2 = num3;
				IL_1A4:
				taskAwaiter5.GetResult();
				IL_1AB:
				int num4 = 0;
				IL_1AD:
				try
				{
					TaskAwaiter<HttpResponseMessage> taskAwaiter6;
					if (num != 0)
					{
						@class.class70_0.httpClient_0.DefaultRequestHeaders.Clear();
						@class.class4_0.method_4(Class185.smethod_0(537662763), Class185.smethod_0(537700781), true, false);
						Dictionary<string, string> dictionary = Class70.smethod_1();
						dictionary[Class185.smethod_0(537687245)] = (string)@class.jtoken_1[Class185.smethod_0(537662788)][Class185.smethod_0(537662792)];
						dictionary[Class185.smethod_0(537687294)] = Class185.smethod_0(537687064);
						taskAwaiter6 = @class.class70_0.method_8(Class185.smethod_0(537687057), dictionary, false).GetAwaiter();
						if (!taskAwaiter6.IsCompleted)
						{
							int num5 = 0;
							num = 0;
							num2 = num5;
							taskAwaiter2 = taskAwaiter6;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class59.Struct17>(ref taskAwaiter6, ref this);
							return;
						}
					}
					else
					{
						taskAwaiter6 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
						int num6 = -1;
						num = -1;
						num2 = num6;
					}
					if (taskAwaiter6.GetResult().StatusCode != HttpStatusCode.Found)
					{
						throw new Exception();
					}
					goto IL_1ED;
				}
				catch (ThreadAbortException)
				{
					goto IL_1ED;
				}
				catch
				{
					num4 = 1;
				}
				if (num4 != 1)
				{
					goto IL_1AB;
				}
				@class.class4_0.method_4(Class185.smethod_0(537662600), Class185.smethod_0(537700781), true, false);
				taskAwaiter5 = Task.Delay(GClass0.int_1).GetAwaiter();
				if (taskAwaiter5.IsCompleted)
				{
					goto IL_1A4;
				}
				int num7 = 1;
				num = 1;
				num2 = num7;
				taskAwaiter4 = taskAwaiter5;
				this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class59.Struct17>(ref taskAwaiter5, ref this);
				return;
			}
			catch (Exception exception)
			{
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_1ED:
			num2 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00004206 File Offset: 0x00002406
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400015C RID: 348
		public int int_0;

		// Token: 0x0400015D RID: 349
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400015E RID: 350
		public Class59 class59_0;

		// Token: 0x0400015F RID: 351
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x04000160 RID: 352
		private TaskAwaiter taskAwaiter_1;
	}
}
