using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

// Token: 0x020000E6 RID: 230
internal sealed class Class126
{
	// Token: 0x060005F8 RID: 1528 RVA: 0x00035614 File Offset: 0x00033814
	public Class126(JToken jtoken_2, string string_9)
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

	// Token: 0x060005F9 RID: 1529 RVA: 0x00035854 File Offset: 0x00033A54
	public void method_0()
	{
		try
		{
			this.method_2().Wait();
			this.task_1 = this.method_4();
			this.task_2 = this.method_7();
			this.task_4 = this.method_5();
			this.task_5 = this.method_6();
			this.task_3 = this.method_8();
			this.class4_0.method_8();
			this.method_1().Wait();
			this.method_3().Wait();
			this.task_4.Wait();
			this.task_5.Wait();
			this.task_3.Wait();
			this.method_9().Wait();
		}
		catch
		{
		}
		finally
		{
			this.class4_0.method_0(Class185.smethod_0(537663178), Class185.smethod_0(537700909), true);
		}
	}

	// Token: 0x060005FA RID: 1530 RVA: 0x00035938 File Offset: 0x00033B38
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
				JObject jobject = httpResponseMessage.smethod_0();
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
							this.class4_0.method_5(jtoken2[Class185.smethod_0(537677565)].First(new Func<JToken, bool>(Class126.Class127.class127_0.method_1))[Class185.smethod_0(537711408)].ToString());
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

	// Token: 0x060005FB RID: 1531 RVA: 0x00035980 File Offset: 0x00033B80
	public async Task method_2()
	{
		for (;;)
		{
			int num = 0;
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537677200), Class185.smethod_0(537700781), true, false);
				HttpResponseMessage httpResponseMessage = await this.class70_0.method_6(string.Format(Class185.smethod_0(537677190), this.string_3), false);
				if (httpResponseMessage.StatusCode == HttpStatusCode.Found && httpResponseMessage.Headers.Location.ToString().Contains(Class185.smethod_0(537674351)))
				{
					this.class4_0.method_0(Class185.smethod_0(537669652), Class185.smethod_0(537700909), false);
				}
				httpResponseMessage.EnsureSuccessStatusCode();
				this.class70_0.httpClient_0.DefaultRequestHeaders.TryAddWithoutValidation(Class185.smethod_0(537677596), httpResponseMessage.smethod_0()[Class185.smethod_0(537706797)][Class185.smethod_0(537677272)].ToString());
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

	// Token: 0x060005FC RID: 1532 RVA: 0x000359C8 File Offset: 0x00033BC8
	public async Task method_3()
	{
		for (;;)
		{
			int num = 0;
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537663094), Class185.smethod_0(537662875), true, false);
				JObject jobject = new JObject();
				jobject[Class185.smethod_0(537676329)] = this.string_0;
				jobject[Class185.smethod_0(537676377)] = Class185.smethod_0(537713814);
				if (this.bool_1)
				{
					this.class4_0.method_4(Class185.smethod_0(537676367), Class185.smethod_0(537676393), true, false);
					jobject[Class185.smethod_0(537676185)] = Class185.smethod_0(537676164);
					this.class4_0.method_4(Class185.smethod_0(537663094), Class185.smethod_0(537662875), true, false);
				}
				HttpResponseMessage httpResponseMessage = await this.class70_0.method_10(string.Format(Class185.smethod_0(537677727), this.string_3), jobject);
				if (!httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537677733)) && !httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537677762)))
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

	// Token: 0x060005FD RID: 1533 RVA: 0x00035A10 File Offset: 0x00033C10
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

	// Token: 0x060005FE RID: 1534 RVA: 0x00035A58 File Offset: 0x00033C58
	public async Task method_5()
	{
		await this.task_1;
		for (;;)
		{
			int num = 0;
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537662655), Class185.smethod_0(537700781), true, false);
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
				HttpResponseMessage httpResponseMessage = await this.class70_0.method_10(string.Format(Class185.smethod_0(537674271), this.string_3), jobject);
				httpResponseMessage.EnsureSuccessStatusCode();
				this.string_6 = httpResponseMessage.smethod_0()[Class185.smethod_0(537703519)].ToString();
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

	// Token: 0x060005FF RID: 1535 RVA: 0x00035AA0 File Offset: 0x00033CA0
	public async Task method_6()
	{
		await this.task_1;
		for (;;)
		{
			int num = 0;
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537676858), Class185.smethod_0(537700781), true, false);
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

	// Token: 0x06000600 RID: 1536 RVA: 0x00035AE8 File Offset: 0x00033CE8
	public async Task method_7()
	{
		for (;;)
		{
			int num = 0;
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537661418), Class185.smethod_0(537700781), true, false);
				Dictionary<string, string> dictionary = Class70.smethod_1();
				dictionary[Class185.smethod_0(537670350)] = Class185.smethod_0(537677334);
				dictionary[Class185.smethod_0(537677318)] = Class185.smethod_0(537713814);
				dictionary[Class185.smethod_0(537677354)] = Class185.smethod_0(537713814);
				dictionary[Class185.smethod_0(537677407)] = this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660835)].ToString().Replace(Class185.smethod_0(537711014), string.Empty);
				HttpResponseMessage httpResponseMessage = await this.class70_0.method_8(string.Format(Class185.smethod_0(537677376), this.string_3), dictionary, false);
				httpResponseMessage.EnsureSuccessStatusCode();
				this.string_5 = httpResponseMessage.smethod_3().Replace(Class185.smethod_0(537711014), string.Empty).Split(new string[]
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

	// Token: 0x06000601 RID: 1537 RVA: 0x00035B30 File Offset: 0x00033D30
	public async Task method_8()
	{
		await this.task_4;
		await this.task_5;
		for (;;)
		{
			int num = 0;
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537660830), Class185.smethod_0(537700781), true, false);
				JObject jobject = new JObject();
				jobject[Class185.smethod_0(537674618)] = new JObject();
				jobject[Class185.smethod_0(537674618)][Class185.smethod_0(537713582)] = Class185.smethod_0(537674601);
				jobject[Class185.smethod_0(537674598)] = new JObject();
				jobject[Class185.smethod_0(537674598)][Class185.smethod_0(537703519)] = this.string_6;
				jobject[Class185.smethod_0(537674379)] = this.string_5;
				jobject[Class185.smethod_0(537674431)] = this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660870)];
				jobject[Class185.smethod_0(537674401)] = this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660699)];
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

	// Token: 0x06000602 RID: 1538 RVA: 0x00035B78 File Offset: 0x00033D78
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
				HttpResponseMessage httpResponseMessage_ = await this.class70_0.method_10(string.Format(Class185.smethod_0(537674715), this.string_3), jobject);
				JObject jobject2 = httpResponseMessage_.smethod_0();
				if (httpResponseMessage_.smethod_3().Contains(Class185.smethod_0(537674738)))
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
				else if (httpResponseMessage_.smethod_3().Contains(Class185.smethod_0(537674547)))
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

	// Token: 0x06000603 RID: 1539 RVA: 0x00006053 File Offset: 0x00004253
	private bool method_10(JToken jtoken_2)
	{
		return jtoken_2[Class185.smethod_0(537671291)].ToString() == this.string_1;
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x00035BC0 File Offset: 0x00033DC0
	private bool method_11(JToken jtoken_2)
	{
		return jtoken_2[Class185.smethod_0(537677565)].First(new Func<JToken, bool>(Class126.Class127.class127_0.method_0))[Class185.smethod_0(537703519)].ToString() == this.string_2 && jtoken_2[Class185.smethod_0(537677528)].ToString() == Class185.smethod_0(537677519);
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x00035C48 File Offset: 0x00033E48
	private bool method_12(JToken jtoken_2)
	{
		if (jtoken_2[Class185.smethod_0(537677565)].First(new Func<JToken, bool>(Class126.Class127.class127_0.method_2))[Class185.smethod_0(537703519)].ToString() == this.string_2)
		{
			return Class172.smethod_2(this.string_4, jtoken_2[Class185.smethod_0(537677565)].First(new Func<JToken, bool>(Class126.Class127.class127_0.method_3))[Class185.smethod_0(537711408)].ToString());
		}
		return false;
	}

	// Token: 0x040002DB RID: 731
	private Class70 class70_0;

	// Token: 0x040002DC RID: 732
	private Class4 class4_0;

	// Token: 0x040002DD RID: 733
	private JToken jtoken_0;

	// Token: 0x040002DE RID: 734
	private int int_0;

	// Token: 0x040002DF RID: 735
	private JToken jtoken_1;

	// Token: 0x040002E0 RID: 736
	private string string_0;

	// Token: 0x040002E1 RID: 737
	private string string_1;

	// Token: 0x040002E2 RID: 738
	private string string_2;

	// Token: 0x040002E3 RID: 739
	private string string_3;

	// Token: 0x040002E4 RID: 740
	private string string_4;

	// Token: 0x040002E5 RID: 741
	private bool bool_0;

	// Token: 0x040002E6 RID: 742
	private string string_5;

	// Token: 0x040002E7 RID: 743
	private string string_6;

	// Token: 0x040002E8 RID: 744
	private string string_7;

	// Token: 0x040002E9 RID: 745
	private bool bool_1;

	// Token: 0x040002EA RID: 746
	private string string_8 = Class185.smethod_0(537674320);

	// Token: 0x040002EB RID: 747
	private Task task_0;

	// Token: 0x040002EC RID: 748
	private Task task_1;

	// Token: 0x040002ED RID: 749
	private Task task_2;

	// Token: 0x040002EE RID: 750
	private Task task_3;

	// Token: 0x040002EF RID: 751
	private Task task_4;

	// Token: 0x040002F0 RID: 752
	private Task task_5;

	// Token: 0x020000E7 RID: 231
	[Serializable]
	private sealed class Class127
	{
		// Token: 0x06000608 RID: 1544 RVA: 0x000048D1 File Offset: 0x00002AD1
		internal bool method_0(JToken jtoken_0)
		{
			return jtoken_0[Class185.smethod_0(537676350)].ToString() == Class185.smethod_0(537704228);
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x000048F7 File Offset: 0x00002AF7
		internal bool method_1(JToken jtoken_0)
		{
			return jtoken_0[Class185.smethod_0(537676350)].ToString() == Class185.smethod_0(537700008);
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x000048D1 File Offset: 0x00002AD1
		internal bool method_2(JToken jtoken_0)
		{
			return jtoken_0[Class185.smethod_0(537676350)].ToString() == Class185.smethod_0(537704228);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x000048F7 File Offset: 0x00002AF7
		internal bool method_3(JToken jtoken_0)
		{
			return jtoken_0[Class185.smethod_0(537676350)].ToString() == Class185.smethod_0(537700008);
		}

		// Token: 0x040002F1 RID: 753
		public static readonly Class126.Class127 class127_0 = new Class126.Class127();

		// Token: 0x040002F2 RID: 754
		public static Func<JToken, bool> func_0;

		// Token: 0x040002F3 RID: 755
		public static Func<JToken, bool> func_1;

		// Token: 0x040002F4 RID: 756
		public static Func<JToken, bool> func_2;

		// Token: 0x040002F5 RID: 757
		public static Func<JToken, bool> func_3;
	}

	// Token: 0x020000E8 RID: 232
	[StructLayout(LayoutKind.Auto)]
	private struct Struct46 : IAsyncStateMachine
	{
		// Token: 0x0600060C RID: 1548 RVA: 0x00035D00 File Offset: 0x00033F00
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			Class126 @class = this;
			try
			{
				if (num == 0)
				{
					goto IL_2B0;
				}
				if (num != 1)
				{
					goto IL_2AD;
				}
				TaskAwaiter taskAwaiter3 = taskAwaiter2;
				taskAwaiter2 = default(TaskAwaiter);
				int num3 = -1;
				num = -1;
				num2 = num3;
				IL_2A6:
				taskAwaiter3.GetResult();
				IL_2AD:
				int num4 = 0;
				IL_2B0:
				try
				{
					TaskAwaiter<HttpResponseMessage> taskAwaiter4;
					if (num != 0)
					{
						@class.class4_0.method_4(Class185.smethod_0(537658294), Class185.smethod_0(537700964), true, false);
						JObject jobject = new JObject();
						jobject[Class185.smethod_0(537674636)] = @class.string_7;
						jobject[Class185.smethod_0(537674681)] = @class.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660682)];
						jobject[Class185.smethod_0(537674668)] = GClass2.smethod_2(50);
						taskAwaiter4 = @class.class70_0.method_10(string.Format(Class185.smethod_0(537674715), @class.string_3), jobject).GetAwaiter();
						if (!taskAwaiter4.IsCompleted)
						{
							int num5 = 0;
							num = 0;
							num2 = num5;
							TaskAwaiter<HttpResponseMessage> taskAwaiter5 = taskAwaiter4;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class126.Struct46>(ref taskAwaiter4, ref this);
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
					JObject jobject2 = result.smethod_0();
					if (result.smethod_3().Contains(Class185.smethod_0(537674738)))
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
					else if (result.smethod_3().Contains(Class185.smethod_0(537674547)))
					{
						@class.class4_0.method_0(Class185.smethod_0(537674576), Class185.smethod_0(537700909), false);
					}
					else
					{
						@class.class4_0.method_0(Class185.smethod_0(537660491), Class185.smethod_0(537700909), false);
					}
					goto IL_2F0;
				}
				catch (ThreadAbortException)
				{
					goto IL_2F0;
				}
				catch
				{
					num4 = 1;
				}
				if (num4 != 1)
				{
					goto IL_2AD;
				}
				@class.class4_0.method_4(Class185.smethod_0(537658168), Class185.smethod_0(537700781), true, false);
				taskAwaiter3 = Task.Delay(GClass0.int_1).GetAwaiter();
				if (taskAwaiter3.IsCompleted)
				{
					goto IL_2A6;
				}
				int num7 = 1;
				num = 1;
				num2 = num7;
				taskAwaiter2 = taskAwaiter3;
				this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class126.Struct46>(ref taskAwaiter3, ref this);
				return;
			}
			catch (Exception exception)
			{
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_2F0:
			num2 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00006081 File Offset: 0x00004281
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040002F6 RID: 758
		public int int_0;

		// Token: 0x040002F7 RID: 759
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040002F8 RID: 760
		public Class126 class126_0;

		// Token: 0x040002F9 RID: 761
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x040002FA RID: 762
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x020000E9 RID: 233
	[StructLayout(LayoutKind.Auto)]
	private struct Struct47 : IAsyncStateMachine
	{
		// Token: 0x0600060E RID: 1550 RVA: 0x0003605C File Offset: 0x0003425C
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			Class126 @class = this;
			try
			{
				TaskAwaiter taskAwaiter3;
				if (num > 2)
				{
					if (num != 3)
					{
						goto IL_359;
					}
					taskAwaiter3 = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					num2 = num3;
					goto IL_352;
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
						goto IL_2A3;
					}
					case 2:
					{
						taskAwaiter3 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						int num6 = -1;
						num = -1;
						num2 = num6;
						goto IL_2FE;
					}
					default:
					{
						@class.class4_0.method_4(Class185.smethod_0(537663094), Class185.smethod_0(537662875), true, false);
						JObject jobject = new JObject();
						jobject[Class185.smethod_0(537676329)] = @class.string_0;
						jobject[Class185.smethod_0(537676377)] = Class185.smethod_0(537713814);
						JObject jobject2 = jobject;
						if (@class.bool_1)
						{
							@class.class4_0.method_4(Class185.smethod_0(537676367), Class185.smethod_0(537676393), true, false);
							jobject2[Class185.smethod_0(537676185)] = Class185.smethod_0(537676164);
							@class.class4_0.method_4(Class185.smethod_0(537663094), Class185.smethod_0(537662875), true, false);
						}
						taskAwaiter4 = @class.class70_0.method_10(string.Format(Class185.smethod_0(537677727), @class.string_3), jobject2).GetAwaiter();
						if (!taskAwaiter4.IsCompleted)
						{
							int num7 = 0;
							num = 0;
							num2 = num7;
							TaskAwaiter<HttpResponseMessage> taskAwaiter5 = taskAwaiter4;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class126.Struct47>(ref taskAwaiter4, ref this);
							return;
						}
						break;
					}
					}
					HttpResponseMessage result = taskAwaiter4.GetResult();
					if (!result.smethod_3().Contains(Class185.smethod_0(537677733)) && !result.smethod_3().Contains(Class185.smethod_0(537677762)))
					{
						result.EnsureSuccessStatusCode();
						@class.string_7 = result.smethod_0()[Class185.smethod_0(537677793)].ToString();
						@class.class70_0.httpClient_0.DefaultRequestHeaders.TryAddWithoutValidation(Class185.smethod_0(537677596), result.Headers.GetValues(Class185.smethod_0(537677596)).First<string>());
						goto IL_39A;
					}
					@class.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
					taskAwaiter3 = Task.Delay(GClass0.int_0).GetAwaiter();
					if (!taskAwaiter3.IsCompleted)
					{
						int num8 = 1;
						num = 1;
						num2 = num8;
						taskAwaiter2 = taskAwaiter3;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class126.Struct47>(ref taskAwaiter3, ref this);
						return;
					}
					IL_2A3:
					taskAwaiter3.GetResult();
					taskAwaiter3 = @class.method_1().GetAwaiter();
					if (!taskAwaiter3.IsCompleted)
					{
						int num9 = 2;
						num = 2;
						num2 = num9;
						taskAwaiter2 = taskAwaiter3;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class126.Struct47>(ref taskAwaiter3, ref this);
						return;
					}
					IL_2FE:
					taskAwaiter3.GetResult();
					goto IL_359;
				}
				catch (ThreadAbortException)
				{
					goto IL_39A;
				}
				catch
				{
					num10 = 1;
				}
				if (num10 != 1)
				{
					goto IL_359;
				}
				@class.class4_0.method_4(Class185.smethod_0(537662720), Class185.smethod_0(537700781), true, false);
				taskAwaiter3 = Task.Delay(GClass0.int_1).GetAwaiter();
				if (!taskAwaiter3.IsCompleted)
				{
					int num11 = 3;
					num = 3;
					num2 = num11;
					taskAwaiter2 = taskAwaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class126.Struct47>(ref taskAwaiter3, ref this);
					return;
				}
				IL_352:
				taskAwaiter3.GetResult();
				IL_359:
				num10 = 0;
				goto IL_3C;
			}
			catch (Exception exception)
			{
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_39A:
			num2 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0000608F File Offset: 0x0000428F
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040002FB RID: 763
		public int int_0;

		// Token: 0x040002FC RID: 764
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040002FD RID: 765
		public Class126 class126_0;

		// Token: 0x040002FE RID: 766
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x040002FF RID: 767
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x020000EA RID: 234
	[StructLayout(LayoutKind.Auto)]
	private struct Struct48 : IAsyncStateMachine
	{
		// Token: 0x06000610 RID: 1552 RVA: 0x00036464 File Offset: 0x00034664
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			Class126 @class = this;
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
					IL_100:
					try
					{
						TaskAwaiter<HttpResponseMessage> taskAwaiter4;
						if (num != 2)
						{
							@class.class4_0.method_4(Class185.smethod_0(537660830), Class185.smethod_0(537700781), true, false);
							JObject jobject = new JObject();
							jobject[Class185.smethod_0(537674618)] = new JObject();
							jobject[Class185.smethod_0(537674618)][Class185.smethod_0(537713582)] = Class185.smethod_0(537674601);
							jobject[Class185.smethod_0(537674598)] = new JObject();
							jobject[Class185.smethod_0(537674598)][Class185.smethod_0(537703519)] = @class.string_6;
							jobject[Class185.smethod_0(537674379)] = @class.string_5;
							jobject[Class185.smethod_0(537674431)] = @class.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660870)];
							jobject[Class185.smethod_0(537674401)] = @class.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660699)];
							taskAwaiter4 = @class.class70_0.method_10(string.Format(Class185.smethod_0(537674450), @class.string_3), jobject).GetAwaiter();
							if (!taskAwaiter4.IsCompleted)
							{
								int num5 = 2;
								num = 2;
								num2 = num5;
								TaskAwaiter<HttpResponseMessage> taskAwaiter5 = taskAwaiter4;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class126.Struct48>(ref taskAwaiter4, ref this);
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
						goto IL_36D;
					}
					catch (ThreadAbortException)
					{
						goto IL_36D;
					}
					catch
					{
						num7 = 1;
					}
					if (num7 != 1)
					{
						goto IL_2E9;
					}
					@class.class4_0.method_4(Class185.smethod_0(537660605), Class185.smethod_0(537700781), true, false);
					taskAwaiter3 = Task.Delay(GClass0.int_1).GetAwaiter();
					if (taskAwaiter3.IsCompleted)
					{
						goto IL_32B;
					}
					int num8 = 3;
					num = 3;
					num2 = num8;
					taskAwaiter2 = taskAwaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class126.Struct48>(ref taskAwaiter3, ref this);
					return;
				}
				case 3:
				{
					taskAwaiter3 = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter);
					int num9 = -1;
					num = -1;
					num2 = num9;
					goto IL_32B;
				}
				default:
					taskAwaiter3 = @class.task_4.GetAwaiter();
					if (!taskAwaiter3.IsCompleted)
					{
						int num10 = 0;
						num = 0;
						num2 = num10;
						taskAwaiter2 = taskAwaiter3;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class126.Struct48>(ref taskAwaiter3, ref this);
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
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class126.Struct48>(ref taskAwaiter3, ref this);
					return;
				}
				IL_D3:
				taskAwaiter3.GetResult();
				IL_2E9:
				num7 = 0;
				goto IL_100;
				IL_32B:
				taskAwaiter3.GetResult();
				goto IL_2E9;
			}
			catch (Exception exception)
			{
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_36D:
			num2 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0000609D File Offset: 0x0000429D
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000300 RID: 768
		public int int_0;

		// Token: 0x04000301 RID: 769
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000302 RID: 770
		public Class126 class126_0;

		// Token: 0x04000303 RID: 771
		private TaskAwaiter taskAwaiter_0;

		// Token: 0x04000304 RID: 772
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_1;
	}

	// Token: 0x020000EB RID: 235
	[StructLayout(LayoutKind.Auto)]
	private struct Struct49 : IAsyncStateMachine
	{
		// Token: 0x06000612 RID: 1554 RVA: 0x00036840 File Offset: 0x00034A40
		void IAsyncStateMachine.MoveNext()
		{
			int num3;
			int num2 = num3;
			Class126 @class = this;
			try
			{
				TaskAwaiter taskAwaiter3;
				if (num2 > 3)
				{
					if (num2 != 4)
					{
						@class.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), true, false);
						goto IL_5AA;
					}
					taskAwaiter3 = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter);
					int num4 = -1;
					num2 = -1;
					num3 = num4;
					goto IL_582;
				}
				IL_5D:
				try
				{
					TaskAwaiter<HttpResponseMessage> taskAwaiter4;
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
						taskAwaiter3 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						int num6 = -1;
						num2 = -1;
						num3 = num6;
						goto IL_4F3;
					}
					case 2:
					{
						taskAwaiter3 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						int num7 = -1;
						num2 = -1;
						num3 = num7;
						goto IL_51B;
					}
					case 3:
					{
						taskAwaiter3 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						int num8 = -1;
						num2 = -1;
						num3 = num8;
						goto IL_543;
					}
					default:
						taskAwaiter4 = @class.class70_0.method_6(string.Format(Class185.smethod_0(537677583), @class.string_3, @class.string_1), false).GetAwaiter();
						if (!taskAwaiter4.IsCompleted)
						{
							int num9 = 0;
							num2 = 0;
							num3 = num9;
							TaskAwaiter<HttpResponseMessage> taskAwaiter5 = taskAwaiter4;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class126.Struct49>(ref taskAwaiter4, ref this);
							return;
						}
						break;
					}
					HttpResponseMessage result = taskAwaiter4.GetResult();
					result.EnsureSuccessStatusCode();
					JObject jobject = result.smethod_0();
					@class.class4_0.method_7(jobject[Class185.smethod_0(537712143)].ToString(), Class185.smethod_0(537700781));
					JToken jtoken = jobject[Class185.smethod_0(537677658)].FirstOrDefault(new Func<JToken, bool>(@class.method_10));
					if (jtoken == null)
					{
						@class.class4_0.method_0(Class185.smethod_0(537671545), Class185.smethod_0(537700909), false);
						goto IL_55C;
					}
					@class.bool_1 = (bool)jtoken[Class185.smethod_0(537677634)];
					@class.int_0 = (((bool)jtoken[Class185.smethod_0(537677684)]) ? Convert.ToInt32(Convert.ToDateTime(jtoken[Class185.smethod_0(537677456)].ToString().Replace(Class185.smethod_0(537677444), string.Empty)).Subtract(DateTime.UtcNow).TotalSeconds) : 0);
					@class.class4_0.method_13(@class.int_0, Class185.smethod_0(537669813), 0);
					@class.string_2 = (string)jtoken[Class185.smethod_0(537713582)];
					if (@class.bool_0)
					{
						JToken jtoken2 = jobject[Class185.smethod_0(537677492)].Where(new Func<JToken, bool>(@class.method_11)).smethod_2();
						if (jtoken2 != null && !(jtoken2[Class185.smethod_0(537677528)].ToString() != Class185.smethod_0(537677519)))
						{
							@class.class4_0.method_5(jtoken2[Class185.smethod_0(537677565)].First(new Func<JToken, bool>(Class126.Class127.class127_0.method_1))[Class185.smethod_0(537711408)].ToString());
							@class.string_0 = jtoken2[Class185.smethod_0(537713582)].ToString();
							@class.class4_0.method_4(Class185.smethod_0(537677550) + @class.string_0, Class185.smethod_0(537700781), true, false);
							goto IL_5EF;
						}
						@class.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
						taskAwaiter3 = Task.Delay(GClass0.int_0).GetAwaiter();
						if (!taskAwaiter3.IsCompleted)
						{
							int num10 = 1;
							num2 = 1;
							num3 = num10;
							taskAwaiter2 = taskAwaiter3;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class126.Struct49>(ref taskAwaiter3, ref this);
							return;
						}
					}
					else
					{
						JToken jtoken3 = jobject[Class185.smethod_0(537677492)].FirstOrDefault(new Func<JToken, bool>(@class.method_12));
						if (jtoken3 == null)
						{
							taskAwaiter3 = Task.Delay(GClass0.int_0).GetAwaiter();
							if (!taskAwaiter3.IsCompleted)
							{
								int num11 = 2;
								num2 = 2;
								num3 = num11;
								taskAwaiter2 = taskAwaiter3;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class126.Struct49>(ref taskAwaiter3, ref this);
								return;
							}
							goto IL_51B;
						}
						else
						{
							if (!(jtoken3[Class185.smethod_0(537677528)].ToString() != Class185.smethod_0(537677519)))
							{
								@class.string_0 = jtoken3[Class185.smethod_0(537713582)].ToString();
								@class.class4_0.method_4(Class185.smethod_0(537677550) + @class.string_0, Class185.smethod_0(537700781), true, false);
								goto IL_5EF;
							}
							@class.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
							taskAwaiter3 = Task.Delay(GClass0.int_0).GetAwaiter();
							if (!taskAwaiter3.IsCompleted)
							{
								int num12 = 3;
								num2 = 3;
								num3 = num12;
								taskAwaiter2 = taskAwaiter3;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class126.Struct49>(ref taskAwaiter3, ref this);
								return;
							}
							goto IL_543;
						}
					}
					IL_4F3:
					taskAwaiter3.GetResult();
					goto IL_5AA;
					IL_51B:
					taskAwaiter3.GetResult();
					goto IL_5AA;
					IL_543:
					taskAwaiter3.GetResult();
					goto IL_5AA;
				}
				catch (ThreadAbortException)
				{
					goto IL_5EF;
				}
				catch
				{
					num = 1;
				}
				IL_55C:
				int num13 = num;
				if (num13 != 1)
				{
					goto IL_5AA;
				}
				taskAwaiter3 = Task.Delay(GClass0.int_0).GetAwaiter();
				if (!taskAwaiter3.IsCompleted)
				{
					int num14 = 4;
					num2 = 4;
					num3 = num14;
					taskAwaiter2 = taskAwaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class126.Struct49>(ref taskAwaiter3, ref this);
					return;
				}
				IL_582:
				taskAwaiter3.GetResult();
				@class.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), false, false);
				IL_5AA:
				num = 0;
				goto IL_5D;
			}
			catch (Exception exception)
			{
				num3 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_5EF:
			num3 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x000060AB File Offset: 0x000042AB
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000305 RID: 773
		public int int_0;

		// Token: 0x04000306 RID: 774
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000307 RID: 775
		public Class126 class126_0;

		// Token: 0x04000308 RID: 776
		private int int_1;

		// Token: 0x04000309 RID: 777
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x0400030A RID: 778
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x020000EC RID: 236
	[StructLayout(LayoutKind.Auto)]
	private struct Struct50 : IAsyncStateMachine
	{
		// Token: 0x06000614 RID: 1556 RVA: 0x00036E9C File Offset: 0x0003509C
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			Class126 @class = this;
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
					IL_A1:
					try
					{
						TaskAwaiter<HttpResponseMessage> taskAwaiter4;
						if (num != 1)
						{
							@class.class4_0.method_4(Class185.smethod_0(537662655), Class185.smethod_0(537700781), true, false);
							JObject jobject = new JObject(new JProperty(Class185.smethod_0(537677123), new JObject()));
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
							taskAwaiter4 = @class.class70_0.method_10(string.Format(Class185.smethod_0(537674271), @class.string_3), jobject).GetAwaiter();
							if (!taskAwaiter4.IsCompleted)
							{
								int num4 = 1;
								num = 1;
								num2 = num4;
								TaskAwaiter<HttpResponseMessage> taskAwaiter5 = taskAwaiter4;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class126.Struct50>(ref taskAwaiter4, ref this);
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
						HttpResponseMessage result = taskAwaiter4.GetResult();
						result.EnsureSuccessStatusCode();
						@class.string_6 = result.smethod_0()[Class185.smethod_0(537703519)].ToString();
						goto IL_69D;
					}
					catch (ThreadAbortException)
					{
						goto IL_69D;
					}
					catch
					{
						num6 = 1;
					}
					if (num6 != 1)
					{
						goto IL_619;
					}
					@class.class4_0.method_4(Class185.smethod_0(537659996), Class185.smethod_0(537700781), true, false);
					taskAwaiter3 = Task.Delay(GClass0.int_1).GetAwaiter();
					if (taskAwaiter3.IsCompleted)
					{
						goto IL_65B;
					}
					int num7 = 2;
					num = 2;
					num2 = num7;
					taskAwaiter2 = taskAwaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class126.Struct50>(ref taskAwaiter3, ref this);
					return;
				}
				case 2:
				{
					taskAwaiter3 = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter);
					int num8 = -1;
					num = -1;
					num2 = num8;
					goto IL_65B;
				}
				default:
					taskAwaiter3 = @class.task_1.GetAwaiter();
					if (!taskAwaiter3.IsCompleted)
					{
						int num9 = 0;
						num = 0;
						num2 = num9;
						taskAwaiter2 = taskAwaiter3;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class126.Struct50>(ref taskAwaiter3, ref this);
						return;
					}
					break;
				}
				taskAwaiter3.GetResult();
				IL_619:
				num6 = 0;
				goto IL_A1;
				IL_65B:
				taskAwaiter3.GetResult();
				goto IL_619;
			}
			catch (Exception exception)
			{
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_69D:
			num2 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x000060B9 File Offset: 0x000042B9
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400030B RID: 779
		public int int_0;

		// Token: 0x0400030C RID: 780
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400030D RID: 781
		public Class126 class126_0;

		// Token: 0x0400030E RID: 782
		private TaskAwaiter taskAwaiter_0;

		// Token: 0x0400030F RID: 783
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_1;
	}

	// Token: 0x020000ED RID: 237
	[StructLayout(LayoutKind.Auto)]
	private struct Struct51 : IAsyncStateMachine
	{
		// Token: 0x06000616 RID: 1558 RVA: 0x000375A8 File Offset: 0x000357A8
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			Class126 @class = this;
			try
			{
				if (num == 0)
				{
					goto IL_1D3;
				}
				if (num != 1)
				{
					goto IL_1D1;
				}
				TaskAwaiter taskAwaiter3 = taskAwaiter2;
				taskAwaiter2 = default(TaskAwaiter);
				int num3 = -1;
				num = -1;
				num2 = num3;
				IL_1CA:
				taskAwaiter3.GetResult();
				IL_1D1:
				int num4 = 0;
				IL_1D3:
				try
				{
					TaskAwaiter<HttpResponseMessage> taskAwaiter4;
					if (num != 0)
					{
						@class.class4_0.method_4(Class185.smethod_0(537677200), Class185.smethod_0(537700781), true, false);
						taskAwaiter4 = @class.class70_0.method_6(string.Format(Class185.smethod_0(537677190), @class.string_3), false).GetAwaiter();
						if (!taskAwaiter4.IsCompleted)
						{
							int num5 = 0;
							num = 0;
							num2 = num5;
							TaskAwaiter<HttpResponseMessage> taskAwaiter5 = taskAwaiter4;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class126.Struct51>(ref taskAwaiter4, ref this);
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
					if (result.StatusCode == HttpStatusCode.Found && result.Headers.Location.ToString().Contains(Class185.smethod_0(537674351)))
					{
						@class.class4_0.method_0(Class185.smethod_0(537669652), Class185.smethod_0(537700909), false);
					}
					result.EnsureSuccessStatusCode();
					@class.class70_0.httpClient_0.DefaultRequestHeaders.TryAddWithoutValidation(Class185.smethod_0(537677596), result.smethod_0()[Class185.smethod_0(537706797)][Class185.smethod_0(537677272)].ToString());
					goto IL_213;
				}
				catch (ThreadAbortException)
				{
					goto IL_213;
				}
				catch
				{
					num4 = 1;
				}
				if (num4 != 1)
				{
					goto IL_1D1;
				}
				@class.class4_0.method_4(Class185.smethod_0(537677256), Class185.smethod_0(537700781), true, false);
				taskAwaiter3 = Task.Delay(GClass0.int_1).GetAwaiter();
				if (taskAwaiter3.IsCompleted)
				{
					goto IL_1CA;
				}
				int num7 = 1;
				num = 1;
				num2 = num7;
				taskAwaiter2 = taskAwaiter3;
				this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class126.Struct51>(ref taskAwaiter3, ref this);
				return;
			}
			catch (Exception exception)
			{
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_213:
			num2 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x000060C7 File Offset: 0x000042C7
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000310 RID: 784
		public int int_0;

		// Token: 0x04000311 RID: 785
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000312 RID: 786
		public Class126 class126_0;

		// Token: 0x04000313 RID: 787
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x04000314 RID: 788
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x020000EE RID: 238
	[StructLayout(LayoutKind.Auto)]
	private struct Struct52 : IAsyncStateMachine
	{
		// Token: 0x06000618 RID: 1560 RVA: 0x00037828 File Offset: 0x00035A28
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			Class126 @class = this;
			try
			{
				if (num == 0)
				{
					goto IL_240;
				}
				if (num != 1)
				{
					goto IL_23E;
				}
				TaskAwaiter taskAwaiter3 = taskAwaiter2;
				taskAwaiter2 = default(TaskAwaiter);
				int num3 = -1;
				num = -1;
				num2 = num3;
				IL_237:
				taskAwaiter3.GetResult();
				IL_23E:
				int num4 = 0;
				IL_240:
				try
				{
					TaskAwaiter<HttpResponseMessage> taskAwaiter4;
					if (num != 0)
					{
						@class.class4_0.method_4(Class185.smethod_0(537661418), Class185.smethod_0(537700781), true, false);
						Dictionary<string, string> dictionary = Class70.smethod_1();
						dictionary[Class185.smethod_0(537670350)] = Class185.smethod_0(537677334);
						dictionary[Class185.smethod_0(537677318)] = Class185.smethod_0(537713814);
						dictionary[Class185.smethod_0(537677354)] = Class185.smethod_0(537713814);
						dictionary[Class185.smethod_0(537677407)] = @class.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660835)].ToString().Replace(Class185.smethod_0(537711014), string.Empty);
						taskAwaiter4 = @class.class70_0.method_8(string.Format(Class185.smethod_0(537677376), @class.string_3), dictionary, false).GetAwaiter();
						if (!taskAwaiter4.IsCompleted)
						{
							int num5 = 0;
							num = 0;
							num2 = num5;
							TaskAwaiter<HttpResponseMessage> taskAwaiter5 = taskAwaiter4;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class126.Struct52>(ref taskAwaiter4, ref this);
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
					@class.string_5 = result.smethod_3().Replace(Class185.smethod_0(537711014), string.Empty).Split(new string[]
					{
						Class185.smethod_0(537677410)
					}, StringSplitOptions.None)[1].Split(new char[]
					{
						'\''
					})[0];
					goto IL_280;
				}
				catch (ThreadAbortException)
				{
					goto IL_280;
				}
				catch
				{
					num4 = 1;
				}
				if (num4 != 1)
				{
					goto IL_23E;
				}
				@class.class4_0.method_4(Class185.smethod_0(537661084), Class185.smethod_0(537700781), true, false);
				taskAwaiter3 = Task.Delay(GClass0.int_1).GetAwaiter();
				if (taskAwaiter3.IsCompleted)
				{
					goto IL_237;
				}
				int num7 = 1;
				num = 1;
				num2 = num7;
				taskAwaiter2 = taskAwaiter3;
				this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class126.Struct52>(ref taskAwaiter3, ref this);
				return;
			}
			catch (Exception exception)
			{
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_280:
			num2 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x000060D5 File Offset: 0x000042D5
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000315 RID: 789
		public int int_0;

		// Token: 0x04000316 RID: 790
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000317 RID: 791
		public Class126 class126_0;

		// Token: 0x04000318 RID: 792
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x04000319 RID: 793
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x020000EF RID: 239
	[StructLayout(LayoutKind.Auto)]
	private struct Struct53 : IAsyncStateMachine
	{
		// Token: 0x0600061A RID: 1562 RVA: 0x00037B14 File Offset: 0x00035D14
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			Class126 @class = this;
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
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class126.Struct53>(ref taskAwaiter4, ref this);
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
				this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class126.Struct53>(ref taskAwaiter3, ref this);
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

		// Token: 0x0600061B RID: 1563 RVA: 0x000060E3 File Offset: 0x000042E3
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400031A RID: 794
		public int int_0;

		// Token: 0x0400031B RID: 795
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400031C RID: 796
		public Class126 class126_0;

		// Token: 0x0400031D RID: 797
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x0400031E RID: 798
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x020000F0 RID: 240
	[StructLayout(LayoutKind.Auto)]
	private struct Struct54 : IAsyncStateMachine
	{
		// Token: 0x0600061C RID: 1564 RVA: 0x00037D40 File Offset: 0x00035F40
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			Class126 @class = this;
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
					IL_A1:
					try
					{
						TaskAwaiter<HttpResponseMessage> taskAwaiter4;
						if (num != 1)
						{
							@class.class4_0.method_4(Class185.smethod_0(537676858), Class185.smethod_0(537700781), true, false);
							JObject jobject = new JObject(new JProperty(Class185.smethod_0(537677123), new JObject()));
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
							taskAwaiter4 = @class.class70_0.method_10(string.Format(Class185.smethod_0(537676835), @class.string_3), jobject).GetAwaiter();
							if (!taskAwaiter4.IsCompleted)
							{
								int num4 = 1;
								num = 1;
								num2 = num4;
								TaskAwaiter<HttpResponseMessage> taskAwaiter5 = taskAwaiter4;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class126.Struct54>(ref taskAwaiter4, ref this);
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
						goto IL_579;
					}
					catch (ThreadAbortException)
					{
						goto IL_579;
					}
					catch
					{
						num6 = 1;
					}
					if (num6 != 1)
					{
						goto IL_4F5;
					}
					@class.class4_0.method_4(Class185.smethod_0(537676909), Class185.smethod_0(537700781), true, false);
					taskAwaiter3 = Task.Delay(GClass0.int_1).GetAwaiter();
					if (taskAwaiter3.IsCompleted)
					{
						goto IL_537;
					}
					int num7 = 2;
					num = 2;
					num2 = num7;
					taskAwaiter2 = taskAwaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class126.Struct54>(ref taskAwaiter3, ref this);
					return;
				}
				case 2:
				{
					taskAwaiter3 = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter);
					int num8 = -1;
					num = -1;
					num2 = num8;
					goto IL_537;
				}
				default:
					taskAwaiter3 = @class.task_1.GetAwaiter();
					if (!taskAwaiter3.IsCompleted)
					{
						int num9 = 0;
						num = 0;
						num2 = num9;
						taskAwaiter2 = taskAwaiter3;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class126.Struct54>(ref taskAwaiter3, ref this);
						return;
					}
					break;
				}
				taskAwaiter3.GetResult();
				IL_4F5:
				num6 = 0;
				goto IL_A1;
				IL_537:
				taskAwaiter3.GetResult();
				goto IL_4F5;
			}
			catch (Exception exception)
			{
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_579:
			num2 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x000060F1 File Offset: 0x000042F1
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400031F RID: 799
		public int int_0;

		// Token: 0x04000320 RID: 800
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000321 RID: 801
		public Class126 class126_0;

		// Token: 0x04000322 RID: 802
		private TaskAwaiter taskAwaiter_0;

		// Token: 0x04000323 RID: 803
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_1;
	}
}
