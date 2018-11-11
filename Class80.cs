using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

// Token: 0x02000092 RID: 146
internal sealed class Class80
{
	// Token: 0x0600030C RID: 780 RVA: 0x0001B150 File Offset: 0x00019350
	public Class80(JToken jtoken_2, string string_9)
	{
		try
		{
			this.jtoken_1 = jtoken_2;
			this.class4_0 = new Class4(jtoken_2);
			this.string_1 = (string)jtoken_2[Class185.smethod_0(537702300)];
			this.string_3 = string_9;
			if (!((string)jtoken_2[Class185.smethod_0(537700008)] == Class185.smethod_0(537663132)) && !((string)jtoken_2[Class185.smethod_0(537700008)] == Class185.smethod_0(537663113)))
			{
				this.string_4 = (string)jtoken_2[Class185.smethod_0(537700008)];
				if (!this.string_4.Contains(Class185.smethod_0(537669999)) && this.string_4.Replace(Class185.smethod_0(537696580), string.Empty).smethod_0())
				{
					this.string_4 += Class185.smethod_0(537661229);
				}
				if (this.string_4.Length == 3)
				{
					this.string_4 = Class185.smethod_0(537708442) + this.string_4;
				}
			}
			else
			{
				this.bool_0 = true;
			}
			this.string_4 = Class172.smethod_4(this.string_4);
			if (!this.class4_0.method_3(out this.jtoken_0))
			{
				this.class4_0.method_0(Class185.smethod_0(537663358), Class185.smethod_0(537700909), true);
			}
			else
			{
				this.class70_0 = new Class70(this.class4_0.method_6(), Class185.smethod_0(537692910), 10, false, false, null, false);
				this.class70_0.httpClient_0.DefaultRequestHeaders.TryAddWithoutValidation(Class185.smethod_0(537701050), Class185.smethod_0(537696162));
				this.class70_0.httpClient_0.DefaultRequestHeaders.ExpectContinue = new bool?(false);
			}
		}
		catch
		{
			this.class4_0.method_0(Class185.smethod_0(537663193), Class185.smethod_0(537700909), true);
		}
	}

	// Token: 0x0600030D RID: 781 RVA: 0x0001B390 File Offset: 0x00019590
	public async void method_0()
	{
		try
		{
			await this.method_2();
			this.task_1 = this.method_4();
			this.task_2 = this.method_7();
			this.task_4 = this.method_5();
			this.task_5 = this.method_6();
			this.task_3 = this.method_8();
			this.class4_0.method_8();
			await this.method_1();
			await this.method_3();
			await this.task_4;
			await this.task_5;
			await this.task_3;
			await this.method_9();
		}
		catch
		{
		}
		finally
		{
			this.class4_0.method_0(Class185.smethod_0(537663178), Class185.smethod_0(537700909), true);
		}
	}

	// Token: 0x0600030E RID: 782 RVA: 0x0001B3CC File Offset: 0x000195CC
	public async Task method_1()
	{
		this.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), true, false);
		for (;;)
		{
			int num = 0;
			TaskAwaiter taskAwaiter2;
			try
			{
				HttpResponseMessage httpResponseMessage = await this.class70_0.method_6(string.Format(Class185.smethod_0(537677583), this.string_3, this.string_1), false);
				httpResponseMessage.EnsureSuccessStatusCode();
				JObject jobject = await httpResponseMessage.smethod_1();
				this.class4_0.method_7(jobject[Class185.smethod_0(537712143)].ToString(), Class185.smethod_0(537700781));
				JToken jtoken = jobject[Class185.smethod_0(537677658)].FirstOrDefault(new Func<JToken, bool>(this.method_10));
				if (jtoken != null)
				{
					this.bool_1 = (bool)jtoken[Class185.smethod_0(537677634)];
					this.int_0 = (((bool)jtoken[Class185.smethod_0(537677684)]) ? Convert.ToInt32(Convert.ToDateTime(jtoken[Class185.smethod_0(537677456)].ToString().Replace(Class185.smethod_0(537677444), string.Empty)).Subtract(DateTime.UtcNow).TotalSeconds) : 0);
					this.class4_0.method_13(this.int_0, Class185.smethod_0(537669813), 0);
					this.string_2 = (string)jtoken[Class185.smethod_0(537713582)];
					if (this.bool_0)
					{
						JToken jtoken2 = jobject[Class185.smethod_0(537677492)].Where(new Func<JToken, bool>(this.method_11)).smethod_2();
						if (jtoken2 != null && !(jtoken2[Class185.smethod_0(537677528)].ToString() != Class185.smethod_0(537677519)))
						{
							this.class4_0.method_5(jtoken2[Class185.smethod_0(537677565)].First(new Func<JToken, bool>(Class80.Class81.class81_0.method_1))[Class185.smethod_0(537711408)].ToString());
							this.string_0 = jtoken2[Class185.smethod_0(537713582)].ToString();
							this.class4_0.method_4(Class185.smethod_0(537677550) + this.string_0, Class185.smethod_0(537700781), true, false);
							break;
						}
						this.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
						TaskAwaiter taskAwaiter = Task.Delay(GClass0.int_0).GetAwaiter();
						if (!taskAwaiter.IsCompleted)
						{
							await taskAwaiter;
							taskAwaiter = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter);
						}
						taskAwaiter.GetResult();
						continue;
					}
					else
					{
						JToken jtoken3 = jobject[Class185.smethod_0(537677492)].FirstOrDefault(new Func<JToken, bool>(this.method_12));
						if (jtoken3 == null)
						{
							TaskAwaiter taskAwaiter = Task.Delay(GClass0.int_0).GetAwaiter();
							if (!taskAwaiter.IsCompleted)
							{
								await taskAwaiter;
								taskAwaiter = taskAwaiter2;
								taskAwaiter2 = default(TaskAwaiter);
							}
							taskAwaiter.GetResult();
							continue;
						}
						if (jtoken3[Class185.smethod_0(537677528)].ToString() != Class185.smethod_0(537677519))
						{
							this.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
							TaskAwaiter taskAwaiter = Task.Delay(GClass0.int_0).GetAwaiter();
							if (!taskAwaiter.IsCompleted)
							{
								await taskAwaiter;
								taskAwaiter = taskAwaiter2;
								taskAwaiter2 = default(TaskAwaiter);
							}
							taskAwaiter.GetResult();
							continue;
						}
						this.string_0 = jtoken3[Class185.smethod_0(537713582)].ToString();
						this.class4_0.method_4(Class185.smethod_0(537677550) + this.string_0, Class185.smethod_0(537700781), true, false);
						break;
					}
				}
				else
				{
					this.class4_0.method_0(Class185.smethod_0(537671545), Class185.smethod_0(537700909), false);
				}
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
				TaskAwaiter taskAwaiter = Task.Delay(GClass0.int_0).GetAwaiter();
				if (!taskAwaiter.IsCompleted)
				{
					await taskAwaiter;
					taskAwaiter = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter);
				}
				taskAwaiter.GetResult();
				this.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), false, false);
			}
		}
	}

	// Token: 0x0600030F RID: 783 RVA: 0x0001B414 File Offset: 0x00019614
	public async Task method_2()
	{
		for (;;)
		{
			int num = 0;
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537677200), Class185.smethod_0(537700781), true, false);
				TaskAwaiter<HttpResponseMessage> taskAwaiter = this.class70_0.method_6(string.Format(Class185.smethod_0(537677190), this.string_3), false).GetAwaiter();
				if (!taskAwaiter.IsCompleted)
				{
					await taskAwaiter;
					TaskAwaiter<HttpResponseMessage> taskAwaiter2;
					taskAwaiter = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
				}
				HttpResponseMessage result = taskAwaiter.GetResult();
				if (result.StatusCode == HttpStatusCode.Found && result.Headers.Location.ToString() == Class185.smethod_0(537669875))
				{
					this.class4_0.method_0(Class185.smethod_0(537669652), Class185.smethod_0(537700909), false);
				}
				result.EnsureSuccessStatusCode();
				HttpRequestHeaders httpRequestHeaders = this.class70_0.httpClient_0.DefaultRequestHeaders;
				TaskAwaiter<JObject> taskAwaiter3 = result.smethod_1().GetAwaiter();
				if (!taskAwaiter3.IsCompleted)
				{
					await taskAwaiter3;
					TaskAwaiter<JObject> taskAwaiter4;
					taskAwaiter3 = taskAwaiter4;
					taskAwaiter4 = default(TaskAwaiter<JObject>);
				}
				JObject result2 = taskAwaiter3.GetResult();
				httpRequestHeaders.TryAddWithoutValidation(Class185.smethod_0(537677596), result2[Class185.smethod_0(537706797)][Class185.smethod_0(537677272)].ToString());
				httpRequestHeaders = null;
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
				this.class4_0.method_4(Class185.smethod_0(537677256), Class185.smethod_0(537700781), true, false);
				TaskAwaiter taskAwaiter5 = Task.Delay(GClass0.int_1).GetAwaiter();
				if (!taskAwaiter5.IsCompleted)
				{
					await taskAwaiter5;
					TaskAwaiter taskAwaiter6;
					taskAwaiter5 = taskAwaiter6;
					taskAwaiter6 = default(TaskAwaiter);
				}
				taskAwaiter5.GetResult();
			}
		}
	}

	// Token: 0x06000310 RID: 784 RVA: 0x0001B45C File Offset: 0x0001965C
	public async Task method_3()
	{
		JObject jobject = new JObject();
		jobject[Class185.smethod_0(537676329)] = this.string_0;
		jobject[Class185.smethod_0(537676377)] = Class185.smethod_0(537713814);
		JObject jobject2 = jobject;
		if (this.bool_1)
		{
			this.class4_0.method_4(Class185.smethod_0(537676367), Class185.smethod_0(537676393), true, false);
			jobject2[Class185.smethod_0(537676185)] = Class185.smethod_0(537676164);
			this.class4_0.method_4(Class185.smethod_0(537663094), Class185.smethod_0(537662875), true, false);
		}
		for (;;)
		{
			int num = 0;
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537663094), Class185.smethod_0(537662875), true, false);
				HttpResponseMessage httpResponseMessage = await this.class70_0.method_10(string.Format(Class185.smethod_0(537677727), this.string_3), jobject2);
				string text = await httpResponseMessage.smethod_4();
				if (!text.Contains(Class185.smethod_0(537677733)) && !text.Contains(Class185.smethod_0(537677762)))
				{
					httpResponseMessage.EnsureSuccessStatusCode();
					this.string_7 = httpResponseMessage.smethod_0()[Class185.smethod_0(537677793)].ToString();
					this.class70_0.httpClient_0.DefaultRequestHeaders.TryAddWithoutValidation(Class185.smethod_0(537677596), httpResponseMessage.Headers.GetValues(Class185.smethod_0(537677596)).First<string>());
					break;
				}
				this.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
				await Task.Delay(GClass0.int_0);
				await this.method_1();
				continue;
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

	// Token: 0x06000311 RID: 785 RVA: 0x0001B4A4 File Offset: 0x000196A4
	public async Task method_4()
	{
		for (;;)
		{
			int num = 0;
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537677300), Class185.smethod_0(537700781), true, false);
				(await this.class70_0.httpClient_0.PutAsync(string.Format(Class185.smethod_0(537677080), this.string_3, this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537662792)]), new StringContent(Class185.smethod_0(537677088), Encoding.UTF8, Class185.smethod_0(537696162)))).EnsureSuccessStatusCode();
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
				this.class4_0.method_4(Class185.smethod_0(537677145), Class185.smethod_0(537700781), true, false);
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

	// Token: 0x06000312 RID: 786 RVA: 0x0001B4EC File Offset: 0x000196EC
	public async Task method_5()
	{
		await this.task_1;
		JObject jobject = new JObject(new JProperty(Class185.smethod_0(537677123), new JObject()));
		jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537660334)] = new JObject();
		jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537660334)][Class185.smethod_0(537677161)] = Class172.smethod_0(this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)].ToString(), false);
		jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537660334)][Class185.smethod_0(537712143)] = this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)];
		jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537677159)] = new JObject();
		jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537677159)][Class185.smethod_0(537677161)] = Class172.smethod_0(this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)].ToString(), false) + Class185.smethod_0(537676948) + Class172.smethod_1(this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)].ToString(), this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)].ToString());
		jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537676350)] = Class185.smethod_0(537676940);
		jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537676968)] = true;
		jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537677019)] = this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662508)];
		jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537677003)] = this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662540)];
		jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537677050)] = this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662571)];
		jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537677046)] = this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660310)];
		jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537677026)] = this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660362)];
		jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537660356)] = this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)];
		jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537662792)] = this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537662792)];
		jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537676819)] = this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660290)];
		jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537676814)] = false;
		jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537677123)] = true;
		for (;;)
		{
			int num = 0;
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537662655), Class185.smethod_0(537700781), true, false);
				TaskAwaiter<HttpResponseMessage> taskAwaiter = this.class70_0.method_10(string.Format(Class185.smethod_0(537674271), this.string_3), jobject).GetAwaiter();
				if (!taskAwaiter.IsCompleted)
				{
					await taskAwaiter;
					TaskAwaiter<HttpResponseMessage> taskAwaiter2;
					taskAwaiter = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
				}
				HttpResponseMessage result = taskAwaiter.GetResult();
				result.EnsureSuccessStatusCode();
				TaskAwaiter<JObject> taskAwaiter3 = result.smethod_1().GetAwaiter();
				if (!taskAwaiter3.IsCompleted)
				{
					await taskAwaiter3;
					TaskAwaiter<JObject> taskAwaiter4;
					taskAwaiter3 = taskAwaiter4;
					taskAwaiter4 = default(TaskAwaiter<JObject>);
				}
				this.string_6 = taskAwaiter3.GetResult()[Class185.smethod_0(537703519)].ToString();
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
				TaskAwaiter taskAwaiter5 = Task.Delay(GClass0.int_1).GetAwaiter();
				if (!taskAwaiter5.IsCompleted)
				{
					await taskAwaiter5;
					TaskAwaiter taskAwaiter6;
					taskAwaiter5 = taskAwaiter6;
					taskAwaiter6 = default(TaskAwaiter);
				}
				taskAwaiter5.GetResult();
			}
		}
	}

	// Token: 0x06000313 RID: 787 RVA: 0x0001B534 File Offset: 0x00019734
	public async Task method_6()
	{
		await this.task_1;
		JObject jobject = new JObject(new JProperty(Class185.smethod_0(537677123), new JObject()));
		jobject[Class185.smethod_0(537660334)] = new JObject();
		jobject[Class185.smethod_0(537660334)][Class185.smethod_0(537677161)] = Class172.smethod_0(this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)].ToString(), false);
		jobject[Class185.smethod_0(537660334)][Class185.smethod_0(537712143)] = this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)];
		jobject[Class185.smethod_0(537677159)] = new JObject();
		jobject[Class185.smethod_0(537677159)][Class185.smethod_0(537677161)] = Class172.smethod_0(this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)].ToString(), false) + Class185.smethod_0(537676948) + Class172.smethod_1(this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)].ToString(), this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)].ToString());
		jobject[Class185.smethod_0(537676350)] = Class185.smethod_0(537676940);
		jobject[Class185.smethod_0(537676968)] = true;
		jobject[Class185.smethod_0(537677019)] = this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662508)];
		jobject[Class185.smethod_0(537677003)] = this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662540)];
		jobject[Class185.smethod_0(537677050)] = this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662571)];
		jobject[Class185.smethod_0(537677046)] = this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660310)];
		jobject[Class185.smethod_0(537677026)] = this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660362)];
		jobject[Class185.smethod_0(537660356)] = this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)];
		jobject[Class185.smethod_0(537662792)] = this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537662792)];
		jobject[Class185.smethod_0(537676819)] = this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660290)];
		jobject[Class185.smethod_0(537676814)] = false;
		jobject[Class185.smethod_0(537677123)] = false;
		for (;;)
		{
			int num = 0;
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537676858), Class185.smethod_0(537700781), true, false);
				(await this.class70_0.method_10(string.Format(Class185.smethod_0(537676835), this.string_3), jobject)).EnsureSuccessStatusCode();
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
				this.class4_0.method_4(Class185.smethod_0(537676909), Class185.smethod_0(537700781), true, false);
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

	// Token: 0x06000314 RID: 788 RVA: 0x0001B57C File Offset: 0x0001977C
	public async Task method_7()
	{
		Dictionary<string, string> dictionary = Class70.smethod_1();
		dictionary[Class185.smethod_0(537670350)] = Class185.smethod_0(537677334);
		dictionary[Class185.smethod_0(537677318)] = Class185.smethod_0(537713814);
		dictionary[Class185.smethod_0(537677354)] = Class185.smethod_0(537713814);
		dictionary[Class185.smethod_0(537677407)] = this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660835)].ToString().Replace(Class185.smethod_0(537711014), string.Empty);
		for (;;)
		{
			int num = 0;
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537661418), Class185.smethod_0(537700781), true, false);
				TaskAwaiter<HttpResponseMessage> taskAwaiter = this.class70_0.method_8(string.Format(Class185.smethod_0(537677376), this.string_3), dictionary, false).GetAwaiter();
				if (!taskAwaiter.IsCompleted)
				{
					await taskAwaiter;
					TaskAwaiter<HttpResponseMessage> taskAwaiter2;
					taskAwaiter = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
				}
				HttpResponseMessage result = taskAwaiter.GetResult();
				result.EnsureSuccessStatusCode();
				TaskAwaiter<string> taskAwaiter3 = result.smethod_4().GetAwaiter();
				if (!taskAwaiter3.IsCompleted)
				{
					await taskAwaiter3;
					TaskAwaiter<string> taskAwaiter4;
					taskAwaiter3 = taskAwaiter4;
					taskAwaiter4 = default(TaskAwaiter<string>);
				}
				this.string_5 = taskAwaiter3.GetResult().Replace(Class185.smethod_0(537711014), string.Empty).Split(new string[]
				{
					Class185.smethod_0(537677410)
				}, StringSplitOptions.None)[1].Split(new char[]
				{
					'\''
				})[0];
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
				this.class4_0.method_4(Class185.smethod_0(537661084), Class185.smethod_0(537700781), true, false);
				TaskAwaiter taskAwaiter5 = Task.Delay(GClass0.int_1).GetAwaiter();
				if (!taskAwaiter5.IsCompleted)
				{
					await taskAwaiter5;
					TaskAwaiter taskAwaiter6;
					taskAwaiter5 = taskAwaiter6;
					taskAwaiter6 = default(TaskAwaiter);
				}
				taskAwaiter5.GetResult();
			}
		}
	}

	// Token: 0x06000315 RID: 789 RVA: 0x0001B5C4 File Offset: 0x000197C4
	public async Task method_8()
	{
		await this.task_4;
		await this.task_5;
		JObject jobject = new JObject();
		jobject[Class185.smethod_0(537674618)] = new JObject();
		jobject[Class185.smethod_0(537674618)][Class185.smethod_0(537713582)] = Class185.smethod_0(537674601);
		jobject[Class185.smethod_0(537674598)] = new JObject();
		jobject[Class185.smethod_0(537674598)][Class185.smethod_0(537703519)] = this.string_6;
		jobject[Class185.smethod_0(537674379)] = this.string_5;
		jobject[Class185.smethod_0(537674431)] = this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660870)];
		jobject[Class185.smethod_0(537674401)] = this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660699)];
		for (;;)
		{
			int num = 0;
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537660830), Class185.smethod_0(537700781), true, false);
				(await this.class70_0.method_10(string.Format(Class185.smethod_0(537674450), this.string_3), jobject)).EnsureSuccessStatusCode();
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
				this.class4_0.method_4(Class185.smethod_0(537660605), Class185.smethod_0(537700781), true, false);
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

	// Token: 0x06000316 RID: 790 RVA: 0x0001B60C File Offset: 0x0001980C
	public async Task method_9()
	{
		for (;;)
		{
			int num = 0;
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537658294), Class185.smethod_0(537700964), true, false);
				JObject jobject = new JObject();
				jobject[Class185.smethod_0(537674636)] = this.string_7;
				jobject[Class185.smethod_0(537674681)] = this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660682)];
				jobject[Class185.smethod_0(537674668)] = GClass2.smethod_2(50);
				HttpResponseMessage httpResponseMessage = await this.class70_0.method_10(string.Format(Class185.smethod_0(537674715), this.string_3), jobject);
				HttpResponseMessage httpResponseMessage_ = httpResponseMessage;
				JObject jobject2 = await httpResponseMessage_.smethod_1();
				string text = await httpResponseMessage_.smethod_4();
				if (text.Contains(Class185.smethod_0(537674738)))
				{
					this.class4_0.method_9(true);
					this.class4_0.method_0(Class185.smethod_0(537660452), Class185.smethod_0(537700909), false);
				}
				else if (jobject2[Class185.smethod_0(537674498)] != null)
				{
					this.class4_0.method_12();
					this.class4_0.method_9(false);
					this.class4_0.method_0(Class185.smethod_0(537658349), Class185.smethod_0(537658124), false);
				}
				else if (text.Contains(Class185.smethod_0(537674547)))
				{
					this.class4_0.method_0(Class185.smethod_0(537674576), Class185.smethod_0(537700909), false);
				}
				else
				{
					this.class4_0.method_0(Class185.smethod_0(537660491), Class185.smethod_0(537700909), false);
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
				this.class4_0.method_4(Class185.smethod_0(537658168), Class185.smethod_0(537700781), true, false);
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

	// Token: 0x06000317 RID: 791 RVA: 0x000048A3 File Offset: 0x00002AA3
	private bool method_10(JToken jtoken_2)
	{
		return jtoken_2[Class185.smethod_0(537671291)].ToString() == this.string_1;
	}

	// Token: 0x06000318 RID: 792 RVA: 0x0001B654 File Offset: 0x00019854
	private bool method_11(JToken jtoken_2)
	{
		return jtoken_2[Class185.smethod_0(537677565)].First(new Func<JToken, bool>(Class80.Class81.class81_0.method_0))[Class185.smethod_0(537703519)].ToString() == this.string_2 && jtoken_2[Class185.smethod_0(537677528)].ToString() == Class185.smethod_0(537677519);
	}

	// Token: 0x06000319 RID: 793 RVA: 0x0001B6DC File Offset: 0x000198DC
	private bool method_12(JToken jtoken_2)
	{
		if (jtoken_2[Class185.smethod_0(537677565)].First(new Func<JToken, bool>(Class80.Class81.class81_0.method_2))[Class185.smethod_0(537703519)].ToString() == this.string_2)
		{
			return Class172.smethod_2(this.string_4, jtoken_2[Class185.smethod_0(537677565)].First(new Func<JToken, bool>(Class80.Class81.class81_0.method_3))[Class185.smethod_0(537711408)].ToString());
		}
		return false;
	}

	// Token: 0x040001AA RID: 426
	private Class70 class70_0;

	// Token: 0x040001AB RID: 427
	private Class4 class4_0;

	// Token: 0x040001AC RID: 428
	private JToken jtoken_0;

	// Token: 0x040001AD RID: 429
	private int int_0;

	// Token: 0x040001AE RID: 430
	private JToken jtoken_1;

	// Token: 0x040001AF RID: 431
	private string string_0;

	// Token: 0x040001B0 RID: 432
	private string string_1;

	// Token: 0x040001B1 RID: 433
	private string string_2;

	// Token: 0x040001B2 RID: 434
	private string string_3;

	// Token: 0x040001B3 RID: 435
	private string string_4;

	// Token: 0x040001B4 RID: 436
	private bool bool_0;

	// Token: 0x040001B5 RID: 437
	private string string_5;

	// Token: 0x040001B6 RID: 438
	private string string_6;

	// Token: 0x040001B7 RID: 439
	private string string_7;

	// Token: 0x040001B8 RID: 440
	private bool bool_1;

	// Token: 0x040001B9 RID: 441
	private string string_8 = Class185.smethod_0(537674320);

	// Token: 0x040001BA RID: 442
	private Task task_0;

	// Token: 0x040001BB RID: 443
	private Task task_1;

	// Token: 0x040001BC RID: 444
	private Task task_2;

	// Token: 0x040001BD RID: 445
	private Task task_3;

	// Token: 0x040001BE RID: 446
	private Task task_4;

	// Token: 0x040001BF RID: 447
	private Task task_5;

	// Token: 0x02000093 RID: 147
	[Serializable]
	private sealed class Class81
	{
		// Token: 0x0600031C RID: 796 RVA: 0x000048D1 File Offset: 0x00002AD1
		internal bool method_0(JToken jtoken_0)
		{
			return jtoken_0[Class185.smethod_0(537676350)].ToString() == Class185.smethod_0(537704228);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x000048F7 File Offset: 0x00002AF7
		internal bool method_1(JToken jtoken_0)
		{
			return jtoken_0[Class185.smethod_0(537676350)].ToString() == Class185.smethod_0(537700008);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x000048D1 File Offset: 0x00002AD1
		internal bool method_2(JToken jtoken_0)
		{
			return jtoken_0[Class185.smethod_0(537676350)].ToString() == Class185.smethod_0(537704228);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x000048F7 File Offset: 0x00002AF7
		internal bool method_3(JToken jtoken_0)
		{
			return jtoken_0[Class185.smethod_0(537676350)].ToString() == Class185.smethod_0(537700008);
		}

		// Token: 0x040001C0 RID: 448
		public static readonly Class80.Class81 class81_0 = new Class80.Class81();

		// Token: 0x040001C1 RID: 449
		public static Func<JToken, bool> func_0;

		// Token: 0x040001C2 RID: 450
		public static Func<JToken, bool> func_1;

		// Token: 0x040001C3 RID: 451
		public static Func<JToken, bool> func_2;

		// Token: 0x040001C4 RID: 452
		public static Func<JToken, bool> func_3;
	}

	// Token: 0x02000094 RID: 148
	[StructLayout(LayoutKind.Auto)]
	private struct Struct27 : IAsyncStateMachine
	{
		// Token: 0x06000320 RID: 800 RVA: 0x0001B794 File Offset: 0x00019994
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			Class80 @class = this;
			try
			{
				TaskAwaiter taskAwaiter3;
				int num6;
				switch (num)
				{
				case 0:
				{
					taskAwaiter3 = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					num2 = num3;
					break;
				}
				case 1:
				{
					IL_48F:
					try
					{
						TaskAwaiter<HttpResponseMessage> taskAwaiter4;
						if (num != 1)
						{
							@class.class4_0.method_4(Class185.smethod_0(537676858), Class185.smethod_0(537700781), true, false);
							taskAwaiter4 = @class.class70_0.method_10(string.Format(Class185.smethod_0(537676835), @class.string_3), jobject).GetAwaiter();
							if (!taskAwaiter4.IsCompleted)
							{
								int num4 = 1;
								num = 1;
								num2 = num4;
								TaskAwaiter<HttpResponseMessage> taskAwaiter5 = taskAwaiter4;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class80.Struct27>(ref taskAwaiter4, ref this);
								return;
							}
						}
						else
						{
							TaskAwaiter<HttpResponseMessage> taskAwaiter5;
							taskAwaiter4 = taskAwaiter5;
							taskAwaiter5 = default(TaskAwaiter<HttpResponseMessage>);
							int num5 = -1;
							num = -1;
							num2 = num5;
						}
						taskAwaiter4.GetResult().EnsureSuccessStatusCode();
						goto IL_5D2;
					}
					catch (ThreadAbortException)
					{
						goto IL_5D2;
					}
					catch
					{
						num6 = 1;
					}
					if (num6 != 1)
					{
						goto IL_54F;
					}
					@class.class4_0.method_4(Class185.smethod_0(537676909), Class185.smethod_0(537700781), true, false);
					taskAwaiter3 = Task.Delay(GClass0.int_1).GetAwaiter();
					if (taskAwaiter3.IsCompleted)
					{
						goto IL_590;
					}
					int num7 = 2;
					num = 2;
					num2 = num7;
					taskAwaiter2 = taskAwaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class80.Struct27>(ref taskAwaiter3, ref this);
					return;
				}
				case 2:
				{
					taskAwaiter3 = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter);
					int num8 = -1;
					num = -1;
					num2 = num8;
					goto IL_590;
				}
				default:
					taskAwaiter3 = @class.task_1.GetAwaiter();
					if (!taskAwaiter3.IsCompleted)
					{
						int num9 = 0;
						num = 0;
						num2 = num9;
						taskAwaiter2 = taskAwaiter3;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class80.Struct27>(ref taskAwaiter3, ref this);
						return;
					}
					break;
				}
				taskAwaiter3.GetResult();
				jobject = new JObject(new JProperty(Class185.smethod_0(537677123), new JObject()));
				jobject[Class185.smethod_0(537660334)] = new JObject();
				jobject[Class185.smethod_0(537660334)][Class185.smethod_0(537677161)] = Class172.smethod_0(@class.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)].ToString(), false);
				jobject[Class185.smethod_0(537660334)][Class185.smethod_0(537712143)] = @class.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)];
				jobject[Class185.smethod_0(537677159)] = new JObject();
				jobject[Class185.smethod_0(537677159)][Class185.smethod_0(537677161)] = Class172.smethod_0(@class.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)].ToString(), false) + Class185.smethod_0(537676948) + Class172.smethod_1(@class.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)].ToString(), @class.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)].ToString());
				jobject[Class185.smethod_0(537676350)] = Class185.smethod_0(537676940);
				jobject[Class185.smethod_0(537676968)] = true;
				jobject[Class185.smethod_0(537677019)] = @class.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662508)];
				jobject[Class185.smethod_0(537677003)] = @class.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662540)];
				jobject[Class185.smethod_0(537677050)] = @class.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662571)];
				jobject[Class185.smethod_0(537677046)] = @class.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660310)];
				jobject[Class185.smethod_0(537677026)] = @class.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660362)];
				jobject[Class185.smethod_0(537660356)] = @class.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)];
				jobject[Class185.smethod_0(537662792)] = @class.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537662792)];
				jobject[Class185.smethod_0(537676819)] = @class.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660290)];
				jobject[Class185.smethod_0(537676814)] = false;
				jobject[Class185.smethod_0(537677123)] = false;
				IL_54F:
				num6 = 0;
				goto IL_48F;
				IL_590:
				taskAwaiter3.GetResult();
				goto IL_54F;
			}
			catch (Exception exception)
			{
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_5D2:
			num2 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000491D File Offset: 0x00002B1D
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040001C5 RID: 453
		public int int_0;

		// Token: 0x040001C6 RID: 454
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040001C7 RID: 455
		public Class80 class80_0;

		// Token: 0x040001C8 RID: 456
		private JObject jobject_0;

		// Token: 0x040001C9 RID: 457
		private TaskAwaiter taskAwaiter_0;

		// Token: 0x040001CA RID: 458
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_1;
	}

	// Token: 0x02000095 RID: 149
	[StructLayout(LayoutKind.Auto)]
	private struct Struct28 : IAsyncStateMachine
	{
		// Token: 0x06000322 RID: 802 RVA: 0x0001BDD4 File Offset: 0x00019FD4
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			Class80 @class = this;
			try
			{
				TaskAwaiter taskAwaiter3;
				if (num > 3)
				{
					if (num == 4)
					{
						taskAwaiter3 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						int num3 = -1;
						num = -1;
						num2 = num3;
						goto IL_3E1;
					}
					JObject jobject3 = new JObject();
					jobject3[Class185.smethod_0(537676329)] = @class.string_0;
					jobject3[Class185.smethod_0(537676377)] = Class185.smethod_0(537713814);
					jobject2 = jobject3;
					if (@class.bool_1)
					{
						@class.class4_0.method_4(Class185.smethod_0(537676367), Class185.smethod_0(537676393), true, false);
						jobject2[Class185.smethod_0(537676185)] = Class185.smethod_0(537676164);
						@class.class4_0.method_4(Class185.smethod_0(537663094), Class185.smethod_0(537662875), true, false);
						goto IL_3E8;
					}
					goto IL_3E8;
				}
				IL_F8:
				int num12;
				try
				{
					TaskAwaiter<HttpResponseMessage> taskAwaiter4;
					TaskAwaiter<string> taskAwaiter6;
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
						TaskAwaiter<string> taskAwaiter7;
						taskAwaiter6 = taskAwaiter7;
						taskAwaiter7 = default(TaskAwaiter<string>);
						int num5 = -1;
						num = -1;
						num2 = num5;
						goto IL_214;
					}
					case 2:
					{
						taskAwaiter3 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						int num6 = -1;
						num = -1;
						num2 = num6;
						goto IL_334;
					}
					case 3:
					{
						taskAwaiter3 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						int num7 = -1;
						num = -1;
						num2 = num7;
						goto IL_38F;
					}
					default:
						@class.class4_0.method_4(Class185.smethod_0(537663094), Class185.smethod_0(537662875), true, false);
						taskAwaiter4 = @class.class70_0.method_10(string.Format(Class185.smethod_0(537677727), @class.string_3), jobject2).GetAwaiter();
						if (!taskAwaiter4.IsCompleted)
						{
							int num8 = 0;
							num = 0;
							num2 = num8;
							TaskAwaiter<HttpResponseMessage> taskAwaiter5 = taskAwaiter4;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class80.Struct28>(ref taskAwaiter4, ref this);
							return;
						}
						break;
					}
					HttpResponseMessage result = taskAwaiter4.GetResult();
					httpResponseMessage = result;
					taskAwaiter6 = httpResponseMessage.smethod_4().GetAwaiter();
					if (!taskAwaiter6.IsCompleted)
					{
						int num9 = 1;
						num = 1;
						num2 = num9;
						TaskAwaiter<string> taskAwaiter7 = taskAwaiter6;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Class80.Struct28>(ref taskAwaiter6, ref this);
						return;
					}
					IL_214:
					string result2 = taskAwaiter6.GetResult();
					if (!result2.Contains(Class185.smethod_0(537677733)) && !result2.Contains(Class185.smethod_0(537677762)))
					{
						httpResponseMessage.EnsureSuccessStatusCode();
						@class.string_7 = httpResponseMessage.smethod_0()[Class185.smethod_0(537677793)].ToString();
						@class.class70_0.httpClient_0.DefaultRequestHeaders.TryAddWithoutValidation(Class185.smethod_0(537677596), httpResponseMessage.Headers.GetValues(Class185.smethod_0(537677596)).First<string>());
						goto IL_428;
					}
					@class.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
					taskAwaiter3 = Task.Delay(GClass0.int_0).GetAwaiter();
					if (!taskAwaiter3.IsCompleted)
					{
						int num10 = 2;
						num = 2;
						num2 = num10;
						taskAwaiter2 = taskAwaiter3;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class80.Struct28>(ref taskAwaiter3, ref this);
						return;
					}
					IL_334:
					taskAwaiter3.GetResult();
					taskAwaiter3 = @class.method_1().GetAwaiter();
					if (!taskAwaiter3.IsCompleted)
					{
						int num11 = 3;
						num = 3;
						num2 = num11;
						taskAwaiter2 = taskAwaiter3;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class80.Struct28>(ref taskAwaiter3, ref this);
						return;
					}
					IL_38F:
					taskAwaiter3.GetResult();
					goto IL_3E8;
				}
				catch (ThreadAbortException)
				{
					goto IL_428;
				}
				catch
				{
					num12 = 1;
				}
				if (num12 != 1)
				{
					goto IL_3E8;
				}
				@class.class4_0.method_4(Class185.smethod_0(537662720), Class185.smethod_0(537700781), true, false);
				taskAwaiter3 = Task.Delay(GClass0.int_1).GetAwaiter();
				if (!taskAwaiter3.IsCompleted)
				{
					int num13 = 4;
					num = 4;
					num2 = num13;
					taskAwaiter2 = taskAwaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class80.Struct28>(ref taskAwaiter3, ref this);
					return;
				}
				IL_3E1:
				taskAwaiter3.GetResult();
				IL_3E8:
				num12 = 0;
				goto IL_F8;
			}
			catch (Exception exception)
			{
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_428:
			num2 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0000492B File Offset: 0x00002B2B
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040001CB RID: 459
		public int int_0;

		// Token: 0x040001CC RID: 460
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040001CD RID: 461
		public Class80 class80_0;

		// Token: 0x040001CE RID: 462
		private JObject jobject_0;

		// Token: 0x040001CF RID: 463
		private HttpResponseMessage httpResponseMessage_0;

		// Token: 0x040001D0 RID: 464
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x040001D1 RID: 465
		private TaskAwaiter<string> taskAwaiter_1;

		// Token: 0x040001D2 RID: 466
		private TaskAwaiter taskAwaiter_2;
	}

	// Token: 0x02000096 RID: 150
	[StructLayout(LayoutKind.Auto)]
	private struct Struct29 : IAsyncStateMachine
	{
		// Token: 0x06000324 RID: 804 RVA: 0x0001C268 File Offset: 0x0001A468
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			Class80 @class = this;
			try
			{
				if (num <= 2)
				{
					goto IL_389;
				}
				if (num != 3)
				{
					goto IL_387;
				}
				TaskAwaiter taskAwaiter3 = taskAwaiter2;
				taskAwaiter2 = default(TaskAwaiter);
				int num3 = -1;
				num = -1;
				num2 = num3;
				IL_380:
				taskAwaiter3.GetResult();
				IL_387:
				int num4 = 0;
				IL_389:
				try
				{
					TaskAwaiter<HttpResponseMessage> taskAwaiter4;
					TaskAwaiter<JObject> taskAwaiter6;
					TaskAwaiter<string> taskAwaiter8;
					switch (num)
					{
					case 0:
					{
						TaskAwaiter<HttpResponseMessage> taskAwaiter5;
						taskAwaiter4 = taskAwaiter5;
						taskAwaiter5 = default(TaskAwaiter<HttpResponseMessage>);
						int num5 = -1;
						num = -1;
						num2 = num5;
						break;
					}
					case 1:
					{
						TaskAwaiter<JObject> taskAwaiter7;
						taskAwaiter6 = taskAwaiter7;
						taskAwaiter7 = default(TaskAwaiter<JObject>);
						int num6 = -1;
						num = -1;
						num2 = num6;
						goto IL_1D2;
					}
					case 2:
					{
						TaskAwaiter<string> taskAwaiter9;
						taskAwaiter8 = taskAwaiter9;
						taskAwaiter9 = default(TaskAwaiter<string>);
						int num7 = -1;
						num = -1;
						num2 = num7;
						goto IL_23F;
					}
					default:
					{
						@class.class4_0.method_4(Class185.smethod_0(537658294), Class185.smethod_0(537700964), true, false);
						JObject jobject3 = new JObject();
						jobject3[Class185.smethod_0(537674636)] = @class.string_7;
						jobject3[Class185.smethod_0(537674681)] = @class.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660682)];
						jobject3[Class185.smethod_0(537674668)] = GClass2.smethod_2(50);
						taskAwaiter4 = @class.class70_0.method_10(string.Format(Class185.smethod_0(537674715), @class.string_3), jobject3).GetAwaiter();
						if (!taskAwaiter4.IsCompleted)
						{
							int num8 = 0;
							num = 0;
							num2 = num8;
							TaskAwaiter<HttpResponseMessage> taskAwaiter5 = taskAwaiter4;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class80.Struct29>(ref taskAwaiter4, ref this);
							return;
						}
						break;
					}
					}
					HttpResponseMessage result = taskAwaiter4.GetResult();
					httpResponseMessage_ = result;
					taskAwaiter6 = httpResponseMessage_.smethod_1().GetAwaiter();
					if (!taskAwaiter6.IsCompleted)
					{
						int num9 = 1;
						num = 1;
						num2 = num9;
						TaskAwaiter<JObject> taskAwaiter7 = taskAwaiter6;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<JObject>, Class80.Struct29>(ref taskAwaiter6, ref this);
						return;
					}
					IL_1D2:
					JObject result2 = taskAwaiter6.GetResult();
					jobject2 = result2;
					taskAwaiter8 = httpResponseMessage_.smethod_4().GetAwaiter();
					if (!taskAwaiter8.IsCompleted)
					{
						int num10 = 2;
						num = 2;
						num2 = num10;
						TaskAwaiter<string> taskAwaiter9 = taskAwaiter8;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Class80.Struct29>(ref taskAwaiter8, ref this);
						return;
					}
					IL_23F:
					string result3 = taskAwaiter8.GetResult();
					if (result3.Contains(Class185.smethod_0(537674738)))
					{
						@class.class4_0.method_9(true);
						@class.class4_0.method_0(Class185.smethod_0(537660452), Class185.smethod_0(537700909), false);
					}
					else if (jobject2[Class185.smethod_0(537674498)] != null)
					{
						@class.class4_0.method_12();
						@class.class4_0.method_9(false);
						@class.class4_0.method_0(Class185.smethod_0(537658349), Class185.smethod_0(537658124), false);
					}
					else if (result3.Contains(Class185.smethod_0(537674547)))
					{
						@class.class4_0.method_0(Class185.smethod_0(537674576), Class185.smethod_0(537700909), false);
					}
					else
					{
						@class.class4_0.method_0(Class185.smethod_0(537660491), Class185.smethod_0(537700909), false);
					}
					goto IL_3C9;
				}
				catch (ThreadAbortException)
				{
					goto IL_3C9;
				}
				catch
				{
					num4 = 1;
				}
				if (num4 != 1)
				{
					goto IL_387;
				}
				@class.class4_0.method_4(Class185.smethod_0(537658168), Class185.smethod_0(537700781), true, false);
				taskAwaiter3 = Task.Delay(GClass0.int_1).GetAwaiter();
				if (taskAwaiter3.IsCompleted)
				{
					goto IL_380;
				}
				int num11 = 3;
				num = 3;
				num2 = num11;
				taskAwaiter2 = taskAwaiter3;
				this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class80.Struct29>(ref taskAwaiter3, ref this);
				return;
			}
			catch (Exception exception)
			{
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_3C9:
			num2 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00004939 File Offset: 0x00002B39
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040001D3 RID: 467
		public int int_0;

		// Token: 0x040001D4 RID: 468
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040001D5 RID: 469
		public Class80 class80_0;

		// Token: 0x040001D6 RID: 470
		private HttpResponseMessage httpResponseMessage_0;

		// Token: 0x040001D7 RID: 471
		private JObject jobject_0;

		// Token: 0x040001D8 RID: 472
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x040001D9 RID: 473
		private TaskAwaiter<JObject> taskAwaiter_1;

		// Token: 0x040001DA RID: 474
		private TaskAwaiter<string> taskAwaiter_2;

		// Token: 0x040001DB RID: 475
		private TaskAwaiter taskAwaiter_3;
	}

	// Token: 0x02000097 RID: 151
	[StructLayout(LayoutKind.Auto)]
	private struct Struct30 : IAsyncStateMachine
	{
		// Token: 0x06000326 RID: 806 RVA: 0x0001C6A0 File Offset: 0x0001A8A0
		void IAsyncStateMachine.MoveNext()
		{
			int num3;
			int num2 = num3;
			Class80 @class = this;
			try
			{
				TaskAwaiter taskAwaiter3;
				if (num2 > 4)
				{
					if (num2 != 5)
					{
						@class.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), true, false);
						goto IL_606;
					}
					taskAwaiter3 = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter);
					int num4 = -1;
					num2 = -1;
					num3 = num4;
					goto IL_5DE;
				}
				IL_5D:
				try
				{
					TaskAwaiter<HttpResponseMessage> taskAwaiter4;
					TaskAwaiter<JObject> taskAwaiter6;
					switch (num2)
					{
					case 0:
					{
						TaskAwaiter<HttpResponseMessage> taskAwaiter5;
						taskAwaiter4 = taskAwaiter5;
						taskAwaiter5 = default(TaskAwaiter<HttpResponseMessage>);
						int num5 = -1;
						num2 = -1;
						num3 = num5;
						break;
					}
					case 1:
					{
						TaskAwaiter<JObject> taskAwaiter7;
						taskAwaiter6 = taskAwaiter7;
						taskAwaiter7 = default(TaskAwaiter<JObject>);
						int num6 = -1;
						num2 = -1;
						num3 = num6;
						goto IL_154;
					}
					case 2:
					{
						taskAwaiter3 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						int num7 = -1;
						num2 = -1;
						num3 = num7;
						goto IL_54F;
					}
					case 3:
					{
						taskAwaiter3 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						int num8 = -1;
						num2 = -1;
						num3 = num8;
						goto IL_577;
					}
					case 4:
					{
						taskAwaiter3 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						int num9 = -1;
						num2 = -1;
						num3 = num9;
						goto IL_59F;
					}
					default:
						taskAwaiter4 = @class.class70_0.method_6(string.Format(Class185.smethod_0(537677583), @class.string_3, @class.string_1), false).GetAwaiter();
						if (!taskAwaiter4.IsCompleted)
						{
							int num10 = 0;
							num2 = 0;
							num3 = num10;
							TaskAwaiter<HttpResponseMessage> taskAwaiter5 = taskAwaiter4;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class80.Struct30>(ref taskAwaiter4, ref this);
							return;
						}
						break;
					}
					HttpResponseMessage result = taskAwaiter4.GetResult();
					result.EnsureSuccessStatusCode();
					taskAwaiter6 = result.smethod_1().GetAwaiter();
					if (!taskAwaiter6.IsCompleted)
					{
						int num11 = 1;
						num2 = 1;
						num3 = num11;
						TaskAwaiter<JObject> taskAwaiter7 = taskAwaiter6;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<JObject>, Class80.Struct30>(ref taskAwaiter6, ref this);
						return;
					}
					IL_154:
					JObject result2 = taskAwaiter6.GetResult();
					@class.class4_0.method_7(result2[Class185.smethod_0(537712143)].ToString(), Class185.smethod_0(537700781));
					JToken jtoken = result2[Class185.smethod_0(537677658)].FirstOrDefault(new Func<JToken, bool>(@class.method_10));
					if (jtoken == null)
					{
						@class.class4_0.method_0(Class185.smethod_0(537671545), Class185.smethod_0(537700909), false);
						goto IL_5B8;
					}
					@class.bool_1 = (bool)jtoken[Class185.smethod_0(537677634)];
					@class.int_0 = (((bool)jtoken[Class185.smethod_0(537677684)]) ? Convert.ToInt32(Convert.ToDateTime(jtoken[Class185.smethod_0(537677456)].ToString().Replace(Class185.smethod_0(537677444), string.Empty)).Subtract(DateTime.UtcNow).TotalSeconds) : 0);
					@class.class4_0.method_13(@class.int_0, Class185.smethod_0(537669813), 0);
					@class.string_2 = (string)jtoken[Class185.smethod_0(537713582)];
					if (@class.bool_0)
					{
						JToken jtoken2 = result2[Class185.smethod_0(537677492)].Where(new Func<JToken, bool>(@class.method_11)).smethod_2();
						if (jtoken2 != null && !(jtoken2[Class185.smethod_0(537677528)].ToString() != Class185.smethod_0(537677519)))
						{
							@class.class4_0.method_5(jtoken2[Class185.smethod_0(537677565)].First(new Func<JToken, bool>(Class80.Class81.class81_0.method_1))[Class185.smethod_0(537711408)].ToString());
							@class.string_0 = jtoken2[Class185.smethod_0(537713582)].ToString();
							@class.class4_0.method_4(Class185.smethod_0(537677550) + @class.string_0, Class185.smethod_0(537700781), true, false);
							goto IL_64B;
						}
						@class.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
						taskAwaiter3 = Task.Delay(GClass0.int_0).GetAwaiter();
						if (!taskAwaiter3.IsCompleted)
						{
							int num12 = 2;
							num2 = 2;
							num3 = num12;
							taskAwaiter2 = taskAwaiter3;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class80.Struct30>(ref taskAwaiter3, ref this);
							return;
						}
					}
					else
					{
						JToken jtoken3 = result2[Class185.smethod_0(537677492)].FirstOrDefault(new Func<JToken, bool>(@class.method_12));
						if (jtoken3 == null)
						{
							taskAwaiter3 = Task.Delay(GClass0.int_0).GetAwaiter();
							if (!taskAwaiter3.IsCompleted)
							{
								int num13 = 3;
								num2 = 3;
								num3 = num13;
								taskAwaiter2 = taskAwaiter3;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class80.Struct30>(ref taskAwaiter3, ref this);
								return;
							}
							goto IL_577;
						}
						else
						{
							if (!(jtoken3[Class185.smethod_0(537677528)].ToString() != Class185.smethod_0(537677519)))
							{
								@class.string_0 = jtoken3[Class185.smethod_0(537713582)].ToString();
								@class.class4_0.method_4(Class185.smethod_0(537677550) + @class.string_0, Class185.smethod_0(537700781), true, false);
								goto IL_64B;
							}
							@class.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
							taskAwaiter3 = Task.Delay(GClass0.int_0).GetAwaiter();
							if (!taskAwaiter3.IsCompleted)
							{
								int num14 = 4;
								num2 = 4;
								num3 = num14;
								taskAwaiter2 = taskAwaiter3;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class80.Struct30>(ref taskAwaiter3, ref this);
								return;
							}
							goto IL_59F;
						}
					}
					IL_54F:
					taskAwaiter3.GetResult();
					goto IL_606;
					IL_577:
					taskAwaiter3.GetResult();
					goto IL_606;
					IL_59F:
					taskAwaiter3.GetResult();
					goto IL_606;
				}
				catch (ThreadAbortException)
				{
					goto IL_64B;
				}
				catch
				{
					num = 1;
				}
				IL_5B8:
				int num15 = num;
				if (num15 != 1)
				{
					goto IL_606;
				}
				taskAwaiter3 = Task.Delay(GClass0.int_0).GetAwaiter();
				if (!taskAwaiter3.IsCompleted)
				{
					int num16 = 5;
					num2 = 5;
					num3 = num16;
					taskAwaiter2 = taskAwaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class80.Struct30>(ref taskAwaiter3, ref this);
					return;
				}
				IL_5DE:
				taskAwaiter3.GetResult();
				@class.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), false, false);
				IL_606:
				num = 0;
				goto IL_5D;
			}
			catch (Exception exception)
			{
				num3 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_64B:
			num3 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00004947 File Offset: 0x00002B47
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040001DC RID: 476
		public int int_0;

		// Token: 0x040001DD RID: 477
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040001DE RID: 478
		public Class80 class80_0;

		// Token: 0x040001DF RID: 479
		private int int_1;

		// Token: 0x040001E0 RID: 480
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x040001E1 RID: 481
		private TaskAwaiter<JObject> taskAwaiter_1;

		// Token: 0x040001E2 RID: 482
		private TaskAwaiter taskAwaiter_2;
	}

	// Token: 0x02000098 RID: 152
	[StructLayout(LayoutKind.Auto)]
	private struct Struct31 : IAsyncStateMachine
	{
		// Token: 0x06000328 RID: 808 RVA: 0x0001CD58 File Offset: 0x0001AF58
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			Class80 @class = this;
			try
			{
				TaskAwaiter taskAwaiter3;
				int num7;
				switch (num)
				{
				case 0:
				{
					taskAwaiter3 = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					num2 = num3;
					break;
				}
				case 1:
				{
					taskAwaiter3 = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter);
					int num4 = -1;
					num = -1;
					num2 = num4;
					goto IL_D3;
				}
				case 2:
				{
					IL_251:
					try
					{
						TaskAwaiter<HttpResponseMessage> taskAwaiter4;
						if (num != 2)
						{
							@class.class4_0.method_4(Class185.smethod_0(537660830), Class185.smethod_0(537700781), true, false);
							taskAwaiter4 = @class.class70_0.method_10(string.Format(Class185.smethod_0(537674450), @class.string_3), jobject).GetAwaiter();
							if (!taskAwaiter4.IsCompleted)
							{
								int num5 = 2;
								num = 2;
								num2 = num5;
								TaskAwaiter<HttpResponseMessage> taskAwaiter5 = taskAwaiter4;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class80.Struct31>(ref taskAwaiter4, ref this);
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
						goto IL_394;
					}
					catch (ThreadAbortException)
					{
						goto IL_394;
					}
					catch
					{
						num7 = 1;
					}
					if (num7 != 1)
					{
						goto IL_311;
					}
					@class.class4_0.method_4(Class185.smethod_0(537660605), Class185.smethod_0(537700781), true, false);
					taskAwaiter3 = Task.Delay(GClass0.int_1).GetAwaiter();
					if (taskAwaiter3.IsCompleted)
					{
						goto IL_352;
					}
					int num8 = 3;
					num = 3;
					num2 = num8;
					taskAwaiter2 = taskAwaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class80.Struct31>(ref taskAwaiter3, ref this);
					return;
				}
				case 3:
				{
					taskAwaiter3 = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter);
					int num9 = -1;
					num = -1;
					num2 = num9;
					goto IL_352;
				}
				default:
					taskAwaiter3 = @class.task_4.GetAwaiter();
					if (!taskAwaiter3.IsCompleted)
					{
						int num10 = 0;
						num = 0;
						num2 = num10;
						taskAwaiter2 = taskAwaiter3;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class80.Struct31>(ref taskAwaiter3, ref this);
						return;
					}
					break;
				}
				taskAwaiter3.GetResult();
				taskAwaiter3 = @class.task_5.GetAwaiter();
				if (!taskAwaiter3.IsCompleted)
				{
					int num11 = 1;
					num = 1;
					num2 = num11;
					taskAwaiter2 = taskAwaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class80.Struct31>(ref taskAwaiter3, ref this);
					return;
				}
				IL_D3:
				taskAwaiter3.GetResult();
				jobject = new JObject();
				jobject[Class185.smethod_0(537674618)] = new JObject();
				jobject[Class185.smethod_0(537674618)][Class185.smethod_0(537713582)] = Class185.smethod_0(537674601);
				jobject[Class185.smethod_0(537674598)] = new JObject();
				jobject[Class185.smethod_0(537674598)][Class185.smethod_0(537703519)] = @class.string_6;
				jobject[Class185.smethod_0(537674379)] = @class.string_5;
				jobject[Class185.smethod_0(537674431)] = @class.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660870)];
				jobject[Class185.smethod_0(537674401)] = @class.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660699)];
				IL_311:
				num7 = 0;
				goto IL_251;
				IL_352:
				taskAwaiter3.GetResult();
				goto IL_311;
			}
			catch (Exception exception)
			{
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_394:
			num2 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00004955 File Offset: 0x00002B55
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040001E3 RID: 483
		public int int_0;

		// Token: 0x040001E4 RID: 484
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040001E5 RID: 485
		public Class80 class80_0;

		// Token: 0x040001E6 RID: 486
		private JObject jobject_0;

		// Token: 0x040001E7 RID: 487
		private TaskAwaiter taskAwaiter_0;

		// Token: 0x040001E8 RID: 488
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_1;
	}

	// Token: 0x02000099 RID: 153
	[StructLayout(LayoutKind.Auto)]
	private struct Struct32 : IAsyncStateMachine
	{
		// Token: 0x0600032A RID: 810 RVA: 0x0001D158 File Offset: 0x0001B358
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			Class80 @class = this;
			try
			{
				if (num <= 1)
				{
					goto IL_24F;
				}
				if (num != 2)
				{
					goto IL_24D;
				}
				TaskAwaiter taskAwaiter7 = taskAwaiter6;
				taskAwaiter6 = default(TaskAwaiter);
				int num3 = -1;
				num = -1;
				num2 = num3;
				IL_246:
				taskAwaiter7.GetResult();
				IL_24D:
				int num4 = 0;
				IL_24F:
				try
				{
					TaskAwaiter<JObject> taskAwaiter8;
					TaskAwaiter<HttpResponseMessage> taskAwaiter9;
					if (num != 0)
					{
						if (num == 1)
						{
							taskAwaiter8 = taskAwaiter4;
							taskAwaiter4 = default(TaskAwaiter<JObject>);
							int num5 = -1;
							num = -1;
							num2 = num5;
							goto IL_1AC;
						}
						@class.class4_0.method_4(Class185.smethod_0(537677200), Class185.smethod_0(537700781), true, false);
						taskAwaiter9 = @class.class70_0.method_6(string.Format(Class185.smethod_0(537677190), @class.string_3), false).GetAwaiter();
						if (!taskAwaiter9.IsCompleted)
						{
							int num6 = 0;
							num = 0;
							num2 = num6;
							taskAwaiter2 = taskAwaiter9;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class80.Struct32>(ref taskAwaiter9, ref this);
							return;
						}
					}
					else
					{
						taskAwaiter9 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
						int num7 = -1;
						num = -1;
						num2 = num7;
					}
					HttpResponseMessage result = taskAwaiter9.GetResult();
					if (result.StatusCode == HttpStatusCode.Found && result.Headers.Location.ToString() == Class185.smethod_0(537669875))
					{
						@class.class4_0.method_0(Class185.smethod_0(537669652), Class185.smethod_0(537700909), false);
					}
					result.EnsureSuccessStatusCode();
					httpRequestHeaders = @class.class70_0.httpClient_0.DefaultRequestHeaders;
					taskAwaiter8 = result.smethod_1().GetAwaiter();
					if (!taskAwaiter8.IsCompleted)
					{
						int num8 = 1;
						num = 1;
						num2 = num8;
						taskAwaiter4 = taskAwaiter8;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<JObject>, Class80.Struct32>(ref taskAwaiter8, ref this);
						return;
					}
					IL_1AC:
					JObject result2 = taskAwaiter8.GetResult();
					httpRequestHeaders.TryAddWithoutValidation(Class185.smethod_0(537677596), result2[Class185.smethod_0(537706797)][Class185.smethod_0(537677272)].ToString());
					httpRequestHeaders = null;
					goto IL_28F;
				}
				catch (ThreadAbortException)
				{
					goto IL_28F;
				}
				catch
				{
					num4 = 1;
				}
				if (num4 != 1)
				{
					goto IL_24D;
				}
				@class.class4_0.method_4(Class185.smethod_0(537677256), Class185.smethod_0(537700781), true, false);
				taskAwaiter7 = Task.Delay(GClass0.int_1).GetAwaiter();
				if (taskAwaiter7.IsCompleted)
				{
					goto IL_246;
				}
				int num9 = 2;
				num = 2;
				num2 = num9;
				taskAwaiter6 = taskAwaiter7;
				this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class80.Struct32>(ref taskAwaiter7, ref this);
				return;
			}
			catch (Exception exception)
			{
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_28F:
			num2 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00004963 File Offset: 0x00002B63
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040001E9 RID: 489
		public int int_0;

		// Token: 0x040001EA RID: 490
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040001EB RID: 491
		public Class80 class80_0;

		// Token: 0x040001EC RID: 492
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x040001ED RID: 493
		private HttpRequestHeaders httpRequestHeaders_0;

		// Token: 0x040001EE RID: 494
		private TaskAwaiter<JObject> taskAwaiter_1;

		// Token: 0x040001EF RID: 495
		private TaskAwaiter taskAwaiter_2;
	}

	// Token: 0x0200009A RID: 154
	[StructLayout(LayoutKind.Auto)]
	private struct Struct33 : IAsyncStateMachine
	{
		// Token: 0x0600032C RID: 812 RVA: 0x0001D454 File Offset: 0x0001B654
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			Class80 @class = this;
			try
			{
				if (num <= 1)
				{
					goto IL_2BC;
				}
				if (num != 2)
				{
					dictionary = Class70.smethod_1();
					dictionary[Class185.smethod_0(537670350)] = Class185.smethod_0(537677334);
					dictionary[Class185.smethod_0(537677318)] = Class185.smethod_0(537713814);
					dictionary[Class185.smethod_0(537677354)] = Class185.smethod_0(537713814);
					dictionary[Class185.smethod_0(537677407)] = @class.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660835)].ToString().Replace(Class185.smethod_0(537711014), string.Empty);
					goto IL_2BA;
				}
				TaskAwaiter taskAwaiter7 = taskAwaiter6;
				taskAwaiter6 = default(TaskAwaiter);
				int num3 = -1;
				num = -1;
				num2 = num3;
				IL_2B3:
				taskAwaiter7.GetResult();
				IL_2BA:
				int num4 = 0;
				IL_2BC:
				try
				{
					TaskAwaiter<string> taskAwaiter8;
					TaskAwaiter<HttpResponseMessage> taskAwaiter9;
					if (num != 0)
					{
						if (num == 1)
						{
							taskAwaiter8 = taskAwaiter4;
							taskAwaiter4 = default(TaskAwaiter<string>);
							int num5 = -1;
							num = -1;
							num2 = num5;
							goto IL_212;
						}
						@class.class4_0.method_4(Class185.smethod_0(537661418), Class185.smethod_0(537700781), true, false);
						taskAwaiter9 = @class.class70_0.method_8(string.Format(Class185.smethod_0(537677376), @class.string_3), dictionary, false).GetAwaiter();
						if (!taskAwaiter9.IsCompleted)
						{
							int num6 = 0;
							num = 0;
							num2 = num6;
							taskAwaiter2 = taskAwaiter9;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class80.Struct33>(ref taskAwaiter9, ref this);
							return;
						}
					}
					else
					{
						taskAwaiter9 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
						int num7 = -1;
						num = -1;
						num2 = num7;
					}
					HttpResponseMessage result = taskAwaiter9.GetResult();
					result.EnsureSuccessStatusCode();
					taskAwaiter8 = result.smethod_4().GetAwaiter();
					if (!taskAwaiter8.IsCompleted)
					{
						int num8 = 1;
						num = 1;
						num2 = num8;
						taskAwaiter4 = taskAwaiter8;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Class80.Struct33>(ref taskAwaiter8, ref this);
						return;
					}
					IL_212:
					string result2 = taskAwaiter8.GetResult();
					@class.string_5 = result2.Replace(Class185.smethod_0(537711014), string.Empty).Split(new string[]
					{
						Class185.smethod_0(537677410)
					}, StringSplitOptions.None)[1].Split(new char[]
					{
						'\''
					})[0];
					goto IL_2FC;
				}
				catch (ThreadAbortException)
				{
					goto IL_2FC;
				}
				catch
				{
					num4 = 1;
				}
				if (num4 != 1)
				{
					goto IL_2BA;
				}
				@class.class4_0.method_4(Class185.smethod_0(537661084), Class185.smethod_0(537700781), true, false);
				taskAwaiter7 = Task.Delay(GClass0.int_1).GetAwaiter();
				if (taskAwaiter7.IsCompleted)
				{
					goto IL_2B3;
				}
				int num9 = 2;
				num = 2;
				num2 = num9;
				taskAwaiter6 = taskAwaiter7;
				this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class80.Struct33>(ref taskAwaiter7, ref this);
				return;
			}
			catch (Exception exception)
			{
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_2FC:
			num2 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00004971 File Offset: 0x00002B71
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040001F0 RID: 496
		public int int_0;

		// Token: 0x040001F1 RID: 497
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040001F2 RID: 498
		public Class80 class80_0;

		// Token: 0x040001F3 RID: 499
		private Dictionary<string, string> dictionary_0;

		// Token: 0x040001F4 RID: 500
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x040001F5 RID: 501
		private TaskAwaiter<string> taskAwaiter_1;

		// Token: 0x040001F6 RID: 502
		private TaskAwaiter taskAwaiter_2;
	}

	// Token: 0x0200009B RID: 155
	[StructLayout(LayoutKind.Auto)]
	private struct Struct34 : IAsyncStateMachine
	{
		// Token: 0x0600032E RID: 814 RVA: 0x0001D7BC File Offset: 0x0001B9BC
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			Class80 @class = this;
			try
			{
				TaskAwaiter taskAwaiter7;
				int num8;
				switch (num)
				{
				case 0:
				{
					taskAwaiter7 = taskAwaiter6;
					taskAwaiter6 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					num2 = num3;
					break;
				}
				case 1:
				case 2:
					IL_720:
					try
					{
						TaskAwaiter<JObject> taskAwaiter8;
						TaskAwaiter<HttpResponseMessage> taskAwaiter9;
						if (num != 1)
						{
							if (num == 2)
							{
								taskAwaiter8 = taskAwaiter4;
								taskAwaiter4 = default(TaskAwaiter<JObject>);
								int num4 = -1;
								num = -1;
								num2 = num4;
								goto IL_6A2;
							}
							@class.class4_0.method_4(Class185.smethod_0(537662655), Class185.smethod_0(537700781), true, false);
							taskAwaiter9 = @class.class70_0.method_10(string.Format(Class185.smethod_0(537674271), @class.string_3), jobject).GetAwaiter();
							if (!taskAwaiter9.IsCompleted)
							{
								int num5 = 1;
								num = 1;
								num2 = num5;
								taskAwaiter2 = taskAwaiter9;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class80.Struct34>(ref taskAwaiter9, ref this);
								return;
							}
						}
						else
						{
							taskAwaiter9 = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
							int num6 = -1;
							num = -1;
							num2 = num6;
						}
						HttpResponseMessage result = taskAwaiter9.GetResult();
						result.EnsureSuccessStatusCode();
						taskAwaiter8 = result.smethod_1().GetAwaiter();
						if (!taskAwaiter8.IsCompleted)
						{
							int num7 = 2;
							num = 2;
							num2 = num7;
							taskAwaiter4 = taskAwaiter8;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<JObject>, Class80.Struct34>(ref taskAwaiter8, ref this);
							return;
						}
						IL_6A2:
						JObject result2 = taskAwaiter8.GetResult();
						@class.string_6 = result2[Class185.smethod_0(537703519)].ToString();
						goto IL_75F;
					}
					catch (ThreadAbortException)
					{
						goto IL_75F;
					}
					catch
					{
						num8 = 1;
					}
					if (num8 != 1)
					{
						goto IL_6DD;
					}
					@class.class4_0.method_4(Class185.smethod_0(537659996), Class185.smethod_0(537700781), true, false);
					taskAwaiter7 = Task.Delay(GClass0.int_1).GetAwaiter();
					if (!taskAwaiter7.IsCompleted)
					{
						int num9 = 3;
						num = 3;
						num2 = num9;
						taskAwaiter6 = taskAwaiter7;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class80.Struct34>(ref taskAwaiter7, ref this);
						return;
					}
					goto IL_58D;
				case 3:
				{
					taskAwaiter7 = taskAwaiter6;
					taskAwaiter6 = default(TaskAwaiter);
					int num10 = -1;
					num = -1;
					num2 = num10;
					goto IL_58D;
				}
				default:
					taskAwaiter7 = @class.task_1.GetAwaiter();
					if (!taskAwaiter7.IsCompleted)
					{
						int num11 = 0;
						num = 0;
						num2 = num11;
						taskAwaiter6 = taskAwaiter7;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class80.Struct34>(ref taskAwaiter7, ref this);
						return;
					}
					break;
				}
				taskAwaiter7.GetResult();
				jobject = new JObject(new JProperty(Class185.smethod_0(537677123), new JObject()));
				jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537660334)] = new JObject();
				jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537660334)][Class185.smethod_0(537677161)] = Class172.smethod_0(@class.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)].ToString(), false);
				jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537660334)][Class185.smethod_0(537712143)] = @class.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)];
				jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537677159)] = new JObject();
				jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537677159)][Class185.smethod_0(537677161)] = Class172.smethod_0(@class.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)].ToString(), false) + Class185.smethod_0(537676948) + Class172.smethod_1(@class.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)].ToString(), @class.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)].ToString());
				jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537676350)] = Class185.smethod_0(537676940);
				jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537676968)] = true;
				jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537677019)] = @class.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662508)];
				jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537677003)] = @class.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662540)];
				jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537677050)] = @class.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662571)];
				jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537677046)] = @class.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660310)];
				jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537677026)] = @class.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660362)];
				jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537660356)] = @class.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)];
				jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537662792)] = @class.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537662792)];
				jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537676819)] = @class.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660290)];
				jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537676814)] = false;
				jobject[Class185.smethod_0(537677123)][Class185.smethod_0(537677123)] = true;
				goto IL_6DD;
				IL_58D:
				taskAwaiter7.GetResult();
				IL_6DD:
				num8 = 0;
				goto IL_720;
			}
			catch (Exception exception)
			{
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_75F:
			num2 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0000497F File Offset: 0x00002B7F
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040001F7 RID: 503
		public int int_0;

		// Token: 0x040001F8 RID: 504
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040001F9 RID: 505
		public Class80 class80_0;

		// Token: 0x040001FA RID: 506
		private JObject jobject_0;

		// Token: 0x040001FB RID: 507
		private TaskAwaiter taskAwaiter_0;

		// Token: 0x040001FC RID: 508
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_1;

		// Token: 0x040001FD RID: 509
		private TaskAwaiter<JObject> taskAwaiter_2;
	}

	// Token: 0x0200009C RID: 156
	[StructLayout(LayoutKind.Auto)]
	private struct Struct35 : IAsyncStateMachine
	{
		// Token: 0x06000330 RID: 816 RVA: 0x0001DF88 File Offset: 0x0001C188
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			Class80 @class = this;
			try
			{
				if (num == 0)
				{
					goto IL_180;
				}
				if (num != 1)
				{
					goto IL_17E;
				}
				TaskAwaiter taskAwaiter3 = taskAwaiter2;
				taskAwaiter2 = default(TaskAwaiter);
				int num3 = -1;
				num = -1;
				num2 = num3;
				IL_177:
				taskAwaiter3.GetResult();
				IL_17E:
				int num4 = 0;
				IL_180:
				try
				{
					TaskAwaiter<HttpResponseMessage> taskAwaiter4;
					if (num != 0)
					{
						@class.class4_0.method_4(Class185.smethod_0(537677300), Class185.smethod_0(537700781), true, false);
						taskAwaiter4 = @class.class70_0.httpClient_0.PutAsync(string.Format(Class185.smethod_0(537677080), @class.string_3, @class.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537662792)]), new StringContent(Class185.smethod_0(537677088), Encoding.UTF8, Class185.smethod_0(537696162))).GetAwaiter();
						if (!taskAwaiter4.IsCompleted)
						{
							int num5 = 0;
							num = 0;
							num2 = num5;
							TaskAwaiter<HttpResponseMessage> taskAwaiter5 = taskAwaiter4;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class80.Struct35>(ref taskAwaiter4, ref this);
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
					goto IL_1C0;
				}
				catch (ThreadAbortException)
				{
					goto IL_1C0;
				}
				catch
				{
					num4 = 1;
				}
				if (num4 != 1)
				{
					goto IL_17E;
				}
				@class.class4_0.method_4(Class185.smethod_0(537677145), Class185.smethod_0(537700781), true, false);
				taskAwaiter3 = Task.Delay(GClass0.int_1).GetAwaiter();
				if (taskAwaiter3.IsCompleted)
				{
					goto IL_177;
				}
				int num7 = 1;
				num = 1;
				num2 = num7;
				taskAwaiter2 = taskAwaiter3;
				this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class80.Struct35>(ref taskAwaiter3, ref this);
				return;
			}
			catch (Exception exception)
			{
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_1C0:
			num2 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000498D File Offset: 0x00002B8D
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040001FE RID: 510
		public int int_0;

		// Token: 0x040001FF RID: 511
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000200 RID: 512
		public Class80 class80_0;

		// Token: 0x04000201 RID: 513
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x04000202 RID: 514
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x0200009D RID: 157
	[StructLayout(LayoutKind.Auto)]
	private struct Struct36 : IAsyncStateMachine
	{
		// Token: 0x06000332 RID: 818 RVA: 0x0001E1B4 File Offset: 0x0001C3B4
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			Class80 @class = this;
			try
			{
				try
				{
					TaskAwaiter taskAwaiter;
					switch (num)
					{
					case 0:
					{
						TaskAwaiter taskAwaiter2;
						taskAwaiter = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						int num3 = -1;
						num = -1;
						num2 = num3;
						break;
					}
					case 1:
					{
						TaskAwaiter taskAwaiter2;
						taskAwaiter = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						int num4 = -1;
						num = -1;
						num2 = num4;
						goto IL_126;
					}
					case 2:
					{
						TaskAwaiter taskAwaiter2;
						taskAwaiter = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						int num5 = -1;
						num = -1;
						num2 = num5;
						goto IL_181;
					}
					case 3:
					{
						TaskAwaiter taskAwaiter2;
						taskAwaiter = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						int num6 = -1;
						num = -1;
						num2 = num6;
						goto IL_1DC;
					}
					case 4:
					{
						TaskAwaiter taskAwaiter2;
						taskAwaiter = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						int num7 = -1;
						num = -1;
						num2 = num7;
						goto IL_237;
					}
					case 5:
					{
						TaskAwaiter taskAwaiter2;
						taskAwaiter = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						int num8 = -1;
						num = -1;
						num2 = num8;
						goto IL_292;
					}
					case 6:
					{
						TaskAwaiter taskAwaiter2;
						taskAwaiter = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						int num9 = -1;
						num = -1;
						num2 = num9;
						goto IL_2EA;
					}
					default:
						taskAwaiter = @class.method_2().GetAwaiter();
						if (!taskAwaiter.IsCompleted)
						{
							int num10 = 0;
							num = 0;
							num2 = num10;
							TaskAwaiter taskAwaiter2 = taskAwaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class80.Struct36>(ref taskAwaiter, ref this);
							return;
						}
						break;
					}
					taskAwaiter.GetResult();
					@class.task_1 = @class.method_4();
					@class.task_2 = @class.method_7();
					@class.task_4 = @class.method_5();
					@class.task_5 = @class.method_6();
					@class.task_3 = @class.method_8();
					@class.class4_0.method_8();
					taskAwaiter = @class.method_1().GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						int num11 = 1;
						num = 1;
						num2 = num11;
						TaskAwaiter taskAwaiter2 = taskAwaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class80.Struct36>(ref taskAwaiter, ref this);
						return;
					}
					IL_126:
					taskAwaiter.GetResult();
					taskAwaiter = @class.method_3().GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						int num12 = 2;
						num = 2;
						num2 = num12;
						TaskAwaiter taskAwaiter2 = taskAwaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class80.Struct36>(ref taskAwaiter, ref this);
						return;
					}
					IL_181:
					taskAwaiter.GetResult();
					taskAwaiter = @class.task_4.GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						int num13 = 3;
						num = 3;
						num2 = num13;
						TaskAwaiter taskAwaiter2 = taskAwaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class80.Struct36>(ref taskAwaiter, ref this);
						return;
					}
					IL_1DC:
					taskAwaiter.GetResult();
					taskAwaiter = @class.task_5.GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						int num14 = 4;
						num = 4;
						num2 = num14;
						TaskAwaiter taskAwaiter2 = taskAwaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class80.Struct36>(ref taskAwaiter, ref this);
						return;
					}
					IL_237:
					taskAwaiter.GetResult();
					taskAwaiter = @class.task_3.GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						int num15 = 5;
						num = 5;
						num2 = num15;
						TaskAwaiter taskAwaiter2 = taskAwaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class80.Struct36>(ref taskAwaiter, ref this);
						return;
					}
					IL_292:
					taskAwaiter.GetResult();
					taskAwaiter = @class.method_9().GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						int num16 = 6;
						num = 6;
						num2 = num16;
						TaskAwaiter taskAwaiter2 = taskAwaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class80.Struct36>(ref taskAwaiter, ref this);
						return;
					}
					IL_2EA:
					taskAwaiter.GetResult();
				}
				catch
				{
				}
				finally
				{
					if (num < 0)
					{
						@class.class4_0.method_0(Class185.smethod_0(537663178), Class185.smethod_0(537700909), true);
					}
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

		// Token: 0x06000333 RID: 819 RVA: 0x0000499B File Offset: 0x00002B9B
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000203 RID: 515
		public int int_0;

		// Token: 0x04000204 RID: 516
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000205 RID: 517
		public Class80 class80_0;

		// Token: 0x04000206 RID: 518
		private TaskAwaiter taskAwaiter_0;
	}
}
