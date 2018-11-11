using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using HtmlAgilityPack;
using Jint;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json.Linq;

namespace CyberAIO.Websites.Shopify
{
	// Token: 0x02000136 RID: 310
	public class Shopify
	{
		// Token: 0x06000794 RID: 1940 RVA: 0x00047570 File Offset: 0x00045770
		public Shopify(JToken task)
		{
			try
			{
				this.jtoken_1 = task;
				Class173.string_1 = null;
				this.class4_0 = new Class4(task);
				if (task[Class185.smethod_0(537700413)].ToString() == Class185.smethod_0(537762877))
				{
					this.string_13 = string.Format(Class185.smethod_0(537762858), new Uri((string)task[Class185.smethod_0(537762888)]).Scheme, new Uri((string)task[Class185.smethod_0(537762888)]).Host);
					GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537762937), new Uri((string)task[Class185.smethod_0(537762888)]).Host, task[Class185.smethod_0(537703519)]));
					task[Class185.smethod_0(537700413)] = new Uri((string)task[Class185.smethod_0(537762888)]).Host;
				}
				else
				{
					this.string_13 = Class173.jobject_4[task[Class185.smethod_0(537700413)].ToString()][Class185.smethod_0(537700388)].ToString();
				}
				if (!this.class4_0.method_3(out this.jtoken_0))
				{
					this.class4_0.method_0(Class185.smethod_0(537663358), Class185.smethod_0(537700909), true);
				}
				else
				{
					if (task[Class185.smethod_0(537702300)].ToString().smethod_0() && task[Class185.smethod_0(537702300)].ToString().Length > 6)
					{
						this.string_15 = task[Class185.smethod_0(537702300)].ToString();
						this.class4_0.method_7(this.string_15, Class185.smethod_0(537700781));
						this.string_1 = new Uri(this.string_13).Scheme + Class185.smethod_0(537711558) + new Uri(this.string_13).Authority + Class185.smethod_0(537711600);
					}
					else if (Uri.TryCreate(task[Class185.smethod_0(537702300)].ToString().Split(new char[]
					{
						'?'
					})[0], UriKind.Absolute, out this.uri_0))
					{
						this.bool_4 = false;
						this.string_1 = this.uri_0.Scheme + Class185.smethod_0(537711558) + this.uri_0.Authority + Class185.smethod_0(537711600);
					}
					else
					{
						this.string_8 = ((string)task[Class185.smethod_0(537702300)]).Replace(Class185.smethod_0(537711014), string.Empty).ToLower().Split(new char[]
						{
							','
						}).Where(new Func<string, bool>(Shopify.Class211.class211_0.method_5)).ToArray<string>();
						this.string_5 = ((string)task[Class185.smethod_0(537702300)]).Replace(Class185.smethod_0(537711014), string.Empty).ToLower().Split(new char[]
						{
							','
						}).Where(new Func<string, bool>(Shopify.Class211.class211_0.method_6)).ToArray<string>().Select(new Func<string, string>(Shopify.Class211.class211_0.method_7)).ToArray<string>();
						this.string_1 = new Uri(this.string_13).Scheme + Class185.smethod_0(537711558) + new Uri(this.string_13).Authority + Class185.smethod_0(537711600);
					}
					if (!((string)task[Class185.smethod_0(537700008)] == Class185.smethod_0(537663132)) && !((string)task[Class185.smethod_0(537700008)] == Class185.smethod_0(537663113)))
					{
						this.string_14 = (string)task[Class185.smethod_0(537700008)];
					}
					else
					{
						this.bool_3 = true;
					}
					if (this.string_1.Contains(Class185.smethod_0(537760658)))
					{
						this.bool_2 = true;
					}
					this.string_11 = this.class4_0.method_6();
					this.class70_0 = new Class70(this.string_11, Class185.smethod_0(537692910), 10, true, false, null, false);
					this.class70_0.httpClient_0.DefaultRequestHeaders.ExpectContinue = new bool?(false);
					this.bool_1 = ((string)task[Class185.smethod_0(537700413)] == Class185.smethod_0(537760655));
				}
			}
			catch
			{
				this.class4_0.method_0(Class185.smethod_0(537663193), Class185.smethod_0(537700909), true);
			}
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00047AEC File Offset: 0x00045CEC
		public async Task GetShippingMethodApi()
		{
			for (;;)
			{
				int num = 0;
				TaskAwaiter taskAwaiter6;
				try
				{
					HttpResponseMessage result;
					for (;;)
					{
						IL_103:
						this.class4_0.method_4(Class185.smethod_0(537683324), Class185.smethod_0(537700781), true, false);
						TaskAwaiter<HttpResponseMessage> taskAwaiter = this.class70_0.method_6(this.string_0 + Class185.smethod_0(537683097), false).GetAwaiter();
						TaskAwaiter<HttpResponseMessage> taskAwaiter2;
						if (!taskAwaiter.IsCompleted)
						{
							await taskAwaiter;
							taskAwaiter = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
						}
						result = taskAwaiter.GetResult();
						TaskAwaiter<bool> taskAwaiter3 = this.HandleResponse(result, false).GetAwaiter();
						TaskAwaiter<bool> taskAwaiter4;
						if (!taskAwaiter3.IsCompleted)
						{
							await taskAwaiter3;
							taskAwaiter3 = taskAwaiter4;
							taskAwaiter4 = default(TaskAwaiter<bool>);
						}
						if (!taskAwaiter3.GetResult())
						{
							while (result.StatusCode == HttpStatusCode.Accepted)
							{
								TaskAwaiter taskAwaiter5 = Task.Delay(500).GetAwaiter();
								if (!taskAwaiter5.IsCompleted)
								{
									await taskAwaiter5;
									taskAwaiter5 = taskAwaiter6;
									taskAwaiter6 = default(TaskAwaiter);
								}
								taskAwaiter5.GetResult();
								taskAwaiter = this.class70_0.httpClient_0.GetAsync(this.string_0 + Class185.smethod_0(537683097)).GetAwaiter();
								if (!taskAwaiter.IsCompleted)
								{
									await taskAwaiter;
									taskAwaiter = taskAwaiter2;
									taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
								}
								result = taskAwaiter.GetResult();
								taskAwaiter3 = this.HandleResponse(result, false).GetAwaiter();
								if (!taskAwaiter3.IsCompleted)
								{
									await taskAwaiter3;
									taskAwaiter3 = taskAwaiter4;
									taskAwaiter4 = default(TaskAwaiter<bool>);
								}
								if (taskAwaiter3.GetResult())
								{
									goto IL_103;
								}
							}
							break;
						}
						goto IL_28C;
					}
					if (result.smethod_3().Contains(Class185.smethod_0(537683076)))
					{
						this.string_12 = null;
						break;
					}
					if (result.smethod_3().Contains(Class185.smethod_0(537683108)))
					{
						this.class4_0.method_0(Class185.smethod_0(537683147), Class185.smethod_0(537700909), false);
						break;
					}
					if (result.smethod_3().Contains(Class185.smethod_0(537683191)))
					{
						this.class4_0.method_0(Class185.smethod_0(537683356), Class185.smethod_0(537700909), false);
						break;
					}
					if (!result.smethod_0()[Class185.smethod_0(537683172)].Any<JToken>())
					{
						this.class4_0.method_0(Class185.smethod_0(537683147), Class185.smethod_0(537700909), false);
					}
					this.string_12 = result.smethod_0()[Class185.smethod_0(537683172)][0][Class185.smethod_0(537703519)].ToString();
					this.class4_0.method_4(Class185.smethod_0(537682953), Class185.smethod_0(537700781), true, false);
					break;
					IL_28C:
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
					this.class4_0.method_4(Class185.smethod_0(537682995), Class185.smethod_0(537700781), true, false);
					TaskAwaiter taskAwaiter5 = Task.Delay(GClass0.int_1).GetAwaiter();
					if (!taskAwaiter5.IsCompleted)
					{
						await taskAwaiter5;
						taskAwaiter5 = taskAwaiter6;
						taskAwaiter6 = default(TaskAwaiter);
					}
					taskAwaiter5.GetResult();
				}
			}
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00047B34 File Offset: 0x00045D34
		public async Task SubmitShippingMethodApi()
		{
			for (;;)
			{
				int num = 0;
				try
				{
					this.class4_0.method_4(Class185.smethod_0(537762994), Class185.smethod_0(537700781), true, false);
					JObject jobject = new JObject();
					string propertyName = Class185.smethod_0(537681978);
					JObject jobject2 = new JObject();
					string propertyName2 = Class185.smethod_0(537763789);
					JObject jobject3 = new JObject();
					jobject3[Class185.smethod_0(537703519)] = this.string_12;
					jobject2[propertyName2] = jobject3;
					jobject[propertyName] = jobject2;
					JObject jobject4 = jobject;
					if (this.bool_2)
					{
						jobject4[Class185.smethod_0(537681978)][Class185.smethod_0(537763817)] = this.string_6;
					}
					TaskAwaiter<HttpResponseMessage> taskAwaiter = this.class70_0.method_13(this.string_0, jobject4, false).GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						await taskAwaiter;
						TaskAwaiter<HttpResponseMessage> taskAwaiter2;
						taskAwaiter = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
					}
					HttpResponseMessage result = taskAwaiter.GetResult();
					HttpResponseMessage httpResponseMessage = result;
					TaskAwaiter<bool> taskAwaiter3 = this.HandleResponse(httpResponseMessage, false).GetAwaiter();
					if (!taskAwaiter3.IsCompleted)
					{
						await taskAwaiter3;
						TaskAwaiter<bool> taskAwaiter4;
						taskAwaiter3 = taskAwaiter4;
						taskAwaiter4 = default(TaskAwaiter<bool>);
					}
					if (taskAwaiter3.GetResult())
					{
						continue;
					}
					httpResponseMessage.EnsureSuccessStatusCode();
					this.class4_0.method_4(Class185.smethod_0(537763030), Class185.smethod_0(537700781), true, false);
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
					this.class4_0.method_4(Class185.smethod_0(537763043), Class185.smethod_0(537700781), true, false);
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

		// Token: 0x06000797 RID: 1943 RVA: 0x00047B7C File Offset: 0x00045D7C
		public async Task SubmitOrderApi()
		{
			for (;;)
			{
				int num = 0;
				try
				{
					this.class4_0.method_4(Class185.smethod_0(537763262), Class185.smethod_0(537700964), true, false);
					JObject jobject = new JObject();
					string propertyName = Class185.smethod_0(537662788);
					JObject jobject2 = new JObject();
					jobject2[Class185.smethod_0(537661240)] = this.string_9;
					jobject2[Class185.smethod_0(537763290)] = GClass2.smethod_2(16);
					string propertyName2 = Class185.smethod_0(537763277);
					JObject jobject3 = new JObject();
					jobject3[Class185.smethod_0(537676350)] = Class185.smethod_0(537763313);
					jobject3[Class185.smethod_0(537763098)] = this.string_7;
					jobject2[propertyName2] = jobject3;
					jobject[propertyName] = jobject2;
					TaskAwaiter<HttpResponseMessage> taskAwaiter = this.class70_0.method_10(this.string_2 + Class185.smethod_0(537683439) + this.string_3 + Class185.smethod_0(537662977), jobject).GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						await taskAwaiter;
						TaskAwaiter<HttpResponseMessage> taskAwaiter2;
						taskAwaiter = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
					}
					HttpResponseMessage result = taskAwaiter.GetResult();
					TaskAwaiter<bool> taskAwaiter3 = this.HandleResponse(result, false).GetAwaiter();
					if (!taskAwaiter3.IsCompleted)
					{
						await taskAwaiter3;
						TaskAwaiter<bool> taskAwaiter4;
						taskAwaiter3 = taskAwaiter4;
						taskAwaiter4 = default(TaskAwaiter<bool>);
					}
					if (!taskAwaiter3.GetResult())
					{
						result.smethod_0();
						if (result.smethod_3().Contains(Class185.smethod_0(537682010)))
						{
							this.class4_0.method_0(Class185.smethod_0(537762345), Class185.smethod_0(537700909), false);
						}
						else if (result.smethod_3().ToLower().Contains(Class185.smethod_0(537711093)))
						{
							this.class4_0.method_9(true);
							this.class4_0.method_0(Class185.smethod_0(537660452), Class185.smethod_0(537700909), false);
						}
						else if (result.smethod_3().Contains(Class185.smethod_0(537762471)))
						{
							this.class4_0.method_0(Class185.smethod_0(537660491), Class185.smethod_0(537700909), false);
						}
						else if (result.smethod_3().Contains(Class185.smethod_0(537762510)))
						{
							this.class4_0.method_12();
							this.class4_0.method_9(false);
							this.class4_0.method_0(Class185.smethod_0(537658349), Class185.smethod_0(537658124), false);
						}
						else if (!result.smethod_3().Contains(Class185.smethod_0(537762558)) && !result.smethod_3().Contains(Class185.smethod_0(537762543)))
						{
							if (result.smethod_3().Contains(Class185.smethod_0(537762322)))
							{
								this.class4_0.method_0(Class185.smethod_0(537762345), Class185.smethod_0(537700909), false);
							}
							else
							{
								GClass3.smethod_0(result.smethod_3(), Class185.smethod_0(537762390));
								this.class4_0.method_0(Class185.smethod_0(537660491), Class185.smethod_0(537700909), false);
							}
						}
						else
						{
							this.class4_0.method_0(Class185.smethod_0(537660738), Class185.smethod_0(537700909), false);
						}
						throw new Exception();
					}
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
					this.class4_0.method_4(Class185.smethod_0(537763085), Class185.smethod_0(537700781), true, false);
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

		// Token: 0x06000798 RID: 1944 RVA: 0x00047BC4 File Offset: 0x00045DC4
		public async Task FindProduct()
		{
			if (this.bool_4)
			{
				if (this.string_1.Contains(Class185.smethod_0(537683875)))
				{
					TaskAwaiter taskAwaiter = this.ScrapeJs().GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						await taskAwaiter;
						TaskAwaiter taskAwaiter2;
						taskAwaiter = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
					}
					taskAwaiter.GetResult();
					Class30.smethod_1((int)this.jtoken_1[Class185.smethod_0(537703519)], this.string_1);
				}
				else if (this.string_1.Contains(Class185.smethod_0(537683925)))
				{
					TaskAwaiter taskAwaiter = this.ScrapeDsm().GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						await taskAwaiter;
						TaskAwaiter taskAwaiter2;
						taskAwaiter = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
					}
					taskAwaiter.GetResult();
					Class30.smethod_1((int)this.jtoken_1[Class185.smethod_0(537703519)], this.string_1);
					await this.ScrapeDsmProduct();
					Class30.smethod_1((int)this.jtoken_1[Class185.smethod_0(537703519)], this.string_1);
				}
				else if (this.string_13.Contains(Class185.smethod_0(537662977)))
				{
					TaskAwaiter taskAwaiter = this.ScrapeJson().GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						await taskAwaiter;
						TaskAwaiter taskAwaiter2;
						taskAwaiter = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
					}
					taskAwaiter.GetResult();
					Class30.smethod_1((int)this.jtoken_1[Class185.smethod_0(537703519)], this.string_13);
				}
				else if (this.string_13.Contains(Class185.smethod_0(537683965)))
				{
					TaskAwaiter taskAwaiter = this.ScrapeAtom().GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						await taskAwaiter;
						TaskAwaiter taskAwaiter2;
						taskAwaiter = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
					}
					taskAwaiter.GetResult();
					Class30.smethod_1((int)this.jtoken_1[Class185.smethod_0(537703519)], this.string_13);
					await this.ScrapeProduct();
					Class30.smethod_1((int)this.jtoken_1[Class185.smethod_0(537703519)], this.uri_0 + Class185.smethod_0(537683945));
				}
				else if (this.string_13.Contains(Class185.smethod_0(537683939)))
				{
					TaskAwaiter taskAwaiter = this.ScrapeOembed().GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						await taskAwaiter;
						TaskAwaiter taskAwaiter2;
						taskAwaiter = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
					}
					taskAwaiter.GetResult();
					Class30.smethod_1((int)this.jtoken_1[Class185.smethod_0(537703519)], this.string_13);
				}
				if (this.bool_1)
				{
					await this.GetToken(null);
				}
			}
			else
			{
				if (this.string_1.Contains(Class185.smethod_0(537683875)))
				{
					TaskAwaiter taskAwaiter = this.ScrapeJs().GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						await taskAwaiter;
						TaskAwaiter taskAwaiter2;
						taskAwaiter = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
					}
					taskAwaiter.GetResult();
					Class30.smethod_1((int)this.jtoken_1[Class185.smethod_0(537703519)], this.uri_0.ToString());
				}
				else if (this.string_1.Contains(Class185.smethod_0(537683925)))
				{
					TaskAwaiter taskAwaiter = this.ScrapeDsmProduct().GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						await taskAwaiter;
						TaskAwaiter taskAwaiter2;
						taskAwaiter = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
					}
					taskAwaiter.GetResult();
					Class30.smethod_1((int)this.jtoken_1[Class185.smethod_0(537703519)], this.uri_0.ToString());
				}
				else
				{
					TaskAwaiter taskAwaiter = this.ScrapeProduct().GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						await taskAwaiter;
						TaskAwaiter taskAwaiter2;
						taskAwaiter = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
					}
					taskAwaiter.GetResult();
					Class30.smethod_1((int)this.jtoken_1[Class185.smethod_0(537703519)], this.uri_0 + Class185.smethod_0(537683945));
				}
				if (this.bool_1)
				{
					await this.GetToken(null);
				}
			}
			this.class4_0.method_4(Class185.smethod_0(537683729) + this.string_15, Class185.smethod_0(537700781), true, false);
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00047C0C File Offset: 0x00045E0C
		public async Task ScrapeDsm()
		{
			for (;;)
			{
				int num = 0;
				TaskAwaiter taskAwaiter3;
				TaskAwaiter taskAwaiter4;
				try
				{
					this.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), true, false);
					if (this.CheckMassLinkChange())
					{
						break;
					}
					TaskAwaiter<HttpResponseMessage> taskAwaiter = this.class4_0.method_2(this.string_1, this.bool_5, null).GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						await taskAwaiter;
						TaskAwaiter<HttpResponseMessage> taskAwaiter2;
						taskAwaiter = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
					}
					HttpResponseMessage result = taskAwaiter.GetResult();
					HtmlDocument htmlDocument = new HtmlDocument();
					htmlDocument.LoadHtml(result.smethod_3());
					HtmlNodeCollection htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes(Class185.smethod_0(537762261));
					HtmlNode htmlNode = (htmlNodeCollection != null) ? htmlNodeCollection.FirstOrDefault(new Func<HtmlNode, bool>(this.method_0)) : null;
					if (htmlNode != null)
					{
						this.class4_0.method_7(htmlNode.InnerText, Class185.smethod_0(537700781));
						this.uri_0 = new Uri(this.string_1 + htmlNode.ParentNode.Attributes[Class185.smethod_0(537669937)].Value);
						break;
					}
					taskAwaiter3 = Task.Delay(GClass0.int_0).GetAwaiter();
					if (!taskAwaiter3.IsCompleted)
					{
						await taskAwaiter3;
						taskAwaiter3 = taskAwaiter4;
						taskAwaiter4 = default(TaskAwaiter);
					}
					taskAwaiter3.GetResult();
					goto IL_241;
				}
				catch (ThreadAbortException)
				{
					break;
				}
				catch
				{
					num = 1;
					goto IL_241;
				}
				IL_1F4:
				taskAwaiter3 = Task.Delay(GClass0.int_0).GetAwaiter();
				if (!taskAwaiter3.IsCompleted)
				{
					await taskAwaiter3;
					taskAwaiter3 = taskAwaiter4;
					taskAwaiter4 = default(TaskAwaiter);
				}
				taskAwaiter3.GetResult();
				this.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), false, false);
				continue;
				IL_241:
				if (num == 1)
				{
					goto IL_1F4;
				}
			}
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00047C54 File Offset: 0x00045E54
		public async Task ScrapeDsmProduct()
		{
			this.class4_0.method_4(Class185.smethod_0(537762276), Class185.smethod_0(537700781), true, false);
			for (;;)
			{
				int num = 0;
				TaskAwaiter taskAwaiter3;
				TaskAwaiter taskAwaiter4;
				try
				{
					HttpResponseMessage result;
					for (;;)
					{
						IL_3B5:
						this.CheckMassLinkChange();
						TaskAwaiter<HttpResponseMessage> taskAwaiter = this.class4_0.method_2(this.uri_0.ToString(), this.bool_5, null).GetAwaiter();
						if (!taskAwaiter.IsCompleted)
						{
							await taskAwaiter;
							TaskAwaiter<HttpResponseMessage> taskAwaiter2;
							taskAwaiter = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
						}
						JToken jtoken;
						for (;;)
						{
							result = taskAwaiter.GetResult();
							HtmlDocument htmlDocument = new HtmlDocument();
							htmlDocument.LoadHtml(result.smethod_3());
							JObject jobject = JObject.Parse(htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537762060)).InnerText);
							this.class4_0.method_7(jobject[Class185.smethod_0(537712450)].ToString(), Class185.smethod_0(537700781));
							this.string_10 = jobject[Class185.smethod_0(537703519)].ToString();
							this.jtoken_1[Class185.smethod_0(537762143)] = this.string_10;
							jtoken = jobject[Class185.smethod_0(537762112)];
							if (this.bool_3)
							{
								break;
							}
							using (IEnumerator<JToken> enumerator = ((IEnumerable<JToken>)jtoken).GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									JToken jtoken2 = enumerator.Current;
									if (jtoken2[Class185.smethod_0(537762157)].Any(new Func<JToken, bool>(this.method_1)))
									{
										this.string_15 = jtoken2[Class185.smethod_0(537703519)].ToString();
										if (object.Equals(false, Convert.ToBoolean(jtoken2[Class185.smethod_0(537692562)])))
										{
											this.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
											taskAwaiter3 = Task.Delay(GClass0.int_0).GetAwaiter();
											if (!taskAwaiter3.IsCompleted)
											{
												await taskAwaiter3;
												taskAwaiter3 = taskAwaiter4;
												taskAwaiter4 = default(TaskAwaiter);
											}
											taskAwaiter3.GetResult();
											goto IL_3B5;
										}
										await this.GetToken(result.smethod_3());
										return;
									}
								}
								goto IL_401;
							}
						}
						if (this.GetRandomSize(jtoken, out this.string_15, Class185.smethod_0(537762175), Class185.smethod_0(537703519), Class185.smethod_0(537692562)))
						{
							goto IL_48E;
						}
						this.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
						taskAwaiter3 = Task.Delay(GClass0.int_0).GetAwaiter();
						if (!taskAwaiter3.IsCompleted)
						{
							await taskAwaiter3;
							taskAwaiter3 = taskAwaiter4;
							taskAwaiter4 = default(TaskAwaiter);
						}
						taskAwaiter3.GetResult();
					}
					IL_401:
					IEnumerator<JToken> enumerator = null;
					taskAwaiter3 = Task.Delay(GClass0.int_0).GetAwaiter();
					if (!taskAwaiter3.IsCompleted)
					{
						await taskAwaiter3;
						taskAwaiter3 = taskAwaiter4;
						taskAwaiter4 = default(TaskAwaiter);
					}
					taskAwaiter3.GetResult();
					this.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), false, false);
					goto IL_57B;
					IL_48E:
					taskAwaiter3 = this.GetToken(result.smethod_3()).GetAwaiter();
					if (!taskAwaiter3.IsCompleted)
					{
						await taskAwaiter3;
						taskAwaiter3 = taskAwaiter4;
						taskAwaiter4 = default(TaskAwaiter);
					}
					taskAwaiter3.GetResult();
					break;
				}
				catch (ThreadAbortException)
				{
					break;
				}
				catch
				{
					num = 1;
					goto IL_57B;
				}
				IL_52E:
				taskAwaiter3 = Task.Delay(GClass0.int_0).GetAwaiter();
				if (!taskAwaiter3.IsCompleted)
				{
					await taskAwaiter3;
					taskAwaiter3 = taskAwaiter4;
					taskAwaiter4 = default(TaskAwaiter);
				}
				taskAwaiter3.GetResult();
				this.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), false, false);
				continue;
				IL_57B:
				if (num == 1)
				{
					goto IL_52E;
				}
			}
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00047C9C File Offset: 0x00045E9C
		public async Task ScrapeJs()
		{
			this.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), true, false);
			Engine engine = new Engine();
			for (;;)
			{
				int num = 0;
				TaskAwaiter taskAwaiter6;
				try
				{
					for (;;)
					{
						IL_219:
						this.CheckMassLinkChange();
						TaskAwaiter<HttpResponseMessage> taskAwaiter = this.class4_0.method_2((!this.bool_4) ? this.uri_0.ToString() : this.string_1, this.bool_5, null).GetAwaiter();
						if (!taskAwaiter.IsCompleted)
						{
							await taskAwaiter;
							TaskAwaiter<HttpResponseMessage> taskAwaiter2;
							taskAwaiter = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
						}
						HttpResponseMessage result = taskAwaiter.GetResult();
						if (this.FollowRedirects(result.smethod_3()))
						{
							goto IL_834;
						}
						TaskAwaiter<bool> taskAwaiter3 = this.HandleResponse(result, true).GetAwaiter();
						if (!taskAwaiter3.IsCompleted)
						{
							await taskAwaiter3;
							TaskAwaiter<bool> taskAwaiter4;
							taskAwaiter3 = taskAwaiter4;
							taskAwaiter4 = default(TaskAwaiter<bool>);
						}
						taskAwaiter3.GetResult();
						HtmlDocument htmlDocument = new HtmlDocument();
						htmlDocument.LoadHtml(result.smethod_3());
						object obj;
						if (result.smethod_3().Contains(Class185.smethod_0(537761947)))
						{
							obj = JObject.Parse(htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537761921)).InnerText);
						}
						else
						{
							engine.Execute(Class185.smethod_0(537761959) + string.Join(Class185.smethod_0(537711014), htmlDocument.DocumentNode.SelectNodes(Class185.smethod_0(537762705)).Where(new Func<HtmlNode, bool>(Shopify.Class211.class211_0.method_0)).Select(new Func<HtmlNode, string>(Shopify.Class211.class211_0.method_1))));
							obj = JObject.Parse(engine.Execute(Class185.smethod_0(537761994)).GetCompletionValue().ToString())[Class185.smethod_0(537762038)].FirstOrDefault(new Func<JToken, bool>(this.method_2));
							if (obj == null)
							{
								goto IL_85D;
							}
						}
						if (Shopify.Class214.callSite_2 == null)
						{
							Shopify.Class214.callSite_2 = CallSite<Action<CallSite, Class4, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class185.smethod_0(537762030), null, typeof(Shopify), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Action<CallSite, Class4, object> target = Shopify.Class214.callSite_2.Target;
						CallSite callSite_ = Shopify.Class214.callSite_2;
						Class4 arg = this.class4_0;
						if (Shopify.Class214.callSite_1 == null)
						{
							Shopify.Class214.callSite_1 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, Class185.smethod_0(537711952), null, typeof(Shopify), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, object> target2 = Shopify.Class214.callSite_1.Target;
						CallSite callSite_2 = Shopify.Class214.callSite_1;
						if (Shopify.Class214.callSite_0 == null)
						{
							Shopify.Class214.callSite_0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Shopify), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						target(callSite_, arg, target2(callSite_2, Shopify.Class214.callSite_0.Target(Shopify.Class214.callSite_0, obj, Class185.smethod_0(537712450))));
						if (Shopify.Class214.callSite_5 == null)
						{
							Shopify.Class214.callSite_5 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Shopify)));
						}
						Func<CallSite, object, string> target3 = Shopify.Class214.callSite_5.Target;
						CallSite callSite_3 = Shopify.Class214.callSite_5;
						if (Shopify.Class214.callSite_4 == null)
						{
							Shopify.Class214.callSite_4 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, Class185.smethod_0(537711952), null, typeof(Shopify), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, object> target4 = Shopify.Class214.callSite_4.Target;
						CallSite callSite_4 = Shopify.Class214.callSite_4;
						if (Shopify.Class214.callSite_3 == null)
						{
							Shopify.Class214.callSite_3 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Shopify), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						this.string_10 = target3(callSite_3, target4(callSite_4, Shopify.Class214.callSite_3.Target(Shopify.Class214.callSite_3, obj, Class185.smethod_0(537703519))));
						this.jtoken_1[Class185.smethod_0(537762143)] = this.string_10;
						if (Shopify.Class214.callSite_6 == null)
						{
							Shopify.Class214.callSite_6 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Shopify), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						object obj2 = Shopify.Class214.callSite_6.Target(Shopify.Class214.callSite_6, obj, Class185.smethod_0(537762112));
						if (this.bool_3)
						{
							if (Shopify.Class214.callSite_9 == null)
							{
								Shopify.Class214.callSite_9 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Shopify), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, object, bool> target5 = Shopify.Class214.callSite_9.Target;
							CallSite callSite_5 = Shopify.Class214.callSite_9;
							if (Shopify.Class214.callSite_8 == null)
							{
								Shopify.Class214.callSite_8 = CallSite<Func<CallSite, object, object>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.Not, typeof(Shopify), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, object, object> target6 = Shopify.Class214.callSite_8.Target;
							CallSite callSite_6 = Shopify.Class214.callSite_8;
							if (Shopify.Class214.callSite_7 == null)
							{
								Shopify.Class214.callSite_7 = CallSite<Delegate0<CallSite, Shopify, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName, Class185.smethod_0(537761817), null, typeof(Shopify), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsOut, null)
								}));
							}
							if (!target5(callSite_5, target6(callSite_6, Shopify.Class214.callSite_7.Target(Shopify.Class214.callSite_7, this, obj2, ref this.string_15))))
							{
								goto IL_886;
							}
							this.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
							TaskAwaiter taskAwaiter5 = Task.Delay(GClass0.int_0).GetAwaiter();
							if (!taskAwaiter5.IsCompleted)
							{
								await taskAwaiter5;
								taskAwaiter5 = taskAwaiter6;
								taskAwaiter6 = default(TaskAwaiter);
							}
							taskAwaiter5.GetResult();
						}
						else
						{
							if (Shopify.Class214.callSite_10 == null)
							{
								Shopify.Class214.callSite_10 = CallSite<Func<CallSite, object, JToken>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(JToken), typeof(Shopify)));
							}
							using (IEnumerator<JToken> enumerator = ((IEnumerable<JToken>)Shopify.Class214.callSite_10.Target(Shopify.Class214.callSite_10, obj2)).GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									JToken jtoken = enumerator.Current;
									if (jtoken[Class185.smethod_0(537762157)].Any(new Func<JToken, bool>(this.method_3)))
									{
										this.string_15 = jtoken[Class185.smethod_0(537703519)].ToString();
										if (object.Equals(false, Convert.ToBoolean(jtoken[Class185.smethod_0(537692562)])))
										{
											this.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
											TaskAwaiter taskAwaiter5 = Task.Delay(GClass0.int_0).GetAwaiter();
											if (!taskAwaiter5.IsCompleted)
											{
												await taskAwaiter5;
												taskAwaiter5 = taskAwaiter6;
												taskAwaiter6 = default(TaskAwaiter);
											}
											taskAwaiter5.GetResult();
											goto IL_219;
										}
										return;
									}
								}
								break;
							}
						}
					}
					IEnumerator<JToken> enumerator = null;
					throw new Exception();
					IL_834:
					continue;
					IL_85D:
					throw new Exception();
					IL_886:
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
					TaskAwaiter taskAwaiter5 = Task.Delay(GClass0.int_0).GetAwaiter();
					if (!taskAwaiter5.IsCompleted)
					{
						await taskAwaiter5;
						taskAwaiter5 = taskAwaiter6;
						taskAwaiter6 = default(TaskAwaiter);
					}
					taskAwaiter5.GetResult();
					this.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), false, false);
				}
			}
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00047CE4 File Offset: 0x00045EE4
		public async Task ScrapeJson()
		{
			this.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), true, false);
			for (;;)
			{
				int num = 0;
				TaskAwaiter taskAwaiter5;
				TaskAwaiter taskAwaiter6;
				try
				{
					IL_4C3:
					while (!this.CheckMassLinkChange())
					{
						HttpResponseMessage httpResponseMessage;
						JToken jtoken;
						for (;;)
						{
							TaskAwaiter<HttpResponseMessage> taskAwaiter = this.class4_0.method_2(this.string_13, this.bool_5, null).GetAwaiter();
							if (!taskAwaiter.IsCompleted)
							{
								await taskAwaiter;
								TaskAwaiter<HttpResponseMessage> taskAwaiter2;
								taskAwaiter = taskAwaiter2;
								taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
							}
							httpResponseMessage = taskAwaiter.GetResult();
							if (httpResponseMessage.StatusCode == HttpStatusCode.NotFound)
							{
								this.class4_0.method_0(Class185.smethod_0(537761812), Class185.smethod_0(537700909), false);
							}
							TaskAwaiter<bool> taskAwaiter3 = this.HandleResponse(httpResponseMessage, true).GetAwaiter();
							if (!taskAwaiter3.IsCompleted)
							{
								await taskAwaiter3;
								TaskAwaiter<bool> taskAwaiter4;
								taskAwaiter3 = taskAwaiter4;
								taskAwaiter4 = default(TaskAwaiter<bool>);
							}
							taskAwaiter3.GetResult();
							httpResponseMessage.EnsureSuccessStatusCode();
							jtoken = httpResponseMessage.smethod_0()[Class185.smethod_0(537761855)].FirstOrDefault(new Func<JToken, bool>(this.method_4));
							if (jtoken == null)
							{
								goto IL_590;
							}
							this.class4_0.method_7(jtoken[Class185.smethod_0(537712450)].ToString(), Class185.smethod_0(537700781));
							this.string_10 = jtoken[Class185.smethod_0(537703519)].ToString();
							this.uri_0 = new Uri(string.Format(Class185.smethod_0(537761838), this.string_1, jtoken[Class185.smethod_0(537761876)]));
							this.class4_0.string_1 = (jtoken[Class185.smethod_0(537761857)].Any<JToken>() ? jtoken[Class185.smethod_0(537761857)][0][Class185.smethod_0(537703994)].ToString() : null);
							if (this.bool_3)
							{
								break;
							}
							using (IEnumerator<JToken> enumerator = ((IEnumerable<JToken>)jtoken[Class185.smethod_0(537762112)]).GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									JToken jtoken2 = enumerator.Current;
									if (jtoken2[Class185.smethod_0(537762157)].Any(new Func<JToken, bool>(this.method_5)))
									{
										this.string_15 = jtoken2[Class185.smethod_0(537703519)].ToString();
										this.string_9 = jtoken2[Class185.smethod_0(537761918)].ToString();
										this.jtoken_1[Class185.smethod_0(537762143)] = this.string_10;
										if (object.Equals(false, Convert.ToBoolean(jtoken2[Class185.smethod_0(537692562)])))
										{
											this.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
											taskAwaiter5 = Task.Delay(GClass0.int_0).GetAwaiter();
											if (!taskAwaiter5.IsCompleted)
											{
												await taskAwaiter5;
												taskAwaiter5 = taskAwaiter6;
												taskAwaiter6 = default(TaskAwaiter);
											}
											taskAwaiter5.GetResult();
											goto IL_4C3;
										}
										return;
									}
								}
								goto IL_4D0;
							}
						}
						if (!this.GetRandomSize(jtoken[Class185.smethod_0(537762112)], out this.string_15, Class185.smethod_0(537762175), Class185.smethod_0(537703519), Class185.smethod_0(537692562)))
						{
							this.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
							taskAwaiter5 = Task.Delay(GClass0.int_0).GetAwaiter();
							if (!taskAwaiter5.IsCompleted)
							{
								await taskAwaiter5;
								taskAwaiter5 = taskAwaiter6;
								taskAwaiter6 = default(TaskAwaiter);
							}
							taskAwaiter5.GetResult();
							continue;
						}
						return;
						IL_4D0:
						IEnumerator<JToken> enumerator = null;
						IL_590:
						await Task.Delay(GClass0.int_0);
						this.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), false, false);
						httpResponseMessage = null;
						goto IL_676;
					}
					taskAwaiter5 = this.ScrapeProduct().GetAwaiter();
					if (!taskAwaiter5.IsCompleted)
					{
						await taskAwaiter5;
						taskAwaiter5 = taskAwaiter6;
						taskAwaiter6 = default(TaskAwaiter);
					}
					taskAwaiter5.GetResult();
					break;
				}
				catch (ThreadAbortException)
				{
					break;
				}
				catch
				{
					num = 1;
					goto IL_676;
				}
				IL_629:
				taskAwaiter5 = Task.Delay(GClass0.int_0).GetAwaiter();
				if (!taskAwaiter5.IsCompleted)
				{
					await taskAwaiter5;
					taskAwaiter5 = taskAwaiter6;
					taskAwaiter6 = default(TaskAwaiter);
				}
				taskAwaiter5.GetResult();
				this.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), false, false);
				continue;
				IL_676:
				if (num == 1)
				{
					goto IL_629;
				}
			}
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00047D2C File Offset: 0x00045F2C
		public async Task ScrapeOembed()
		{
			this.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), true, false);
			for (;;)
			{
				int num = 0;
				TaskAwaiter taskAwaiter5;
				TaskAwaiter taskAwaiter6;
				try
				{
					IL_3F7:
					while (!this.CheckMassLinkChange())
					{
						HttpResponseMessage httpResponseMessage;
						JToken jtoken;
						for (;;)
						{
							TaskAwaiter<HttpResponseMessage> taskAwaiter = this.class4_0.method_2(this.string_13, this.bool_5, null).GetAwaiter();
							if (!taskAwaiter.IsCompleted)
							{
								await taskAwaiter;
								TaskAwaiter<HttpResponseMessage> taskAwaiter2;
								taskAwaiter = taskAwaiter2;
								taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
							}
							httpResponseMessage = taskAwaiter.GetResult();
							TaskAwaiter<bool> taskAwaiter3 = this.HandleResponse(httpResponseMessage, true).GetAwaiter();
							if (!taskAwaiter3.IsCompleted)
							{
								await taskAwaiter3;
								TaskAwaiter<bool> taskAwaiter4;
								taskAwaiter3 = taskAwaiter4;
								taskAwaiter4 = default(TaskAwaiter<bool>);
							}
							taskAwaiter3.GetResult();
							httpResponseMessage.EnsureSuccessStatusCode();
							jtoken = httpResponseMessage.smethod_0()[Class185.smethod_0(537761855)].FirstOrDefault(new Func<JToken, bool>(this.method_6));
							if (jtoken == null)
							{
								goto IL_4C4;
							}
							this.string_10 = jtoken[Class185.smethod_0(537762143)].ToString();
							this.class4_0.method_7(jtoken[Class185.smethod_0(537712450)].ToString(), Class185.smethod_0(537700781));
							Class4 @class = this.class4_0;
							JToken jtoken2 = jtoken[Class185.smethod_0(537761898)];
							@class.string_1 = ((jtoken2 != null) ? jtoken2.ToString() : null);
							if (this.bool_3)
							{
								break;
							}
							using (IEnumerator<JToken> enumerator = ((IEnumerable<JToken>)jtoken[Class185.smethod_0(537763742)]).GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									JToken jtoken3 = enumerator.Current;
									if (Class172.smethod_2(this.string_14, jtoken3[Class185.smethod_0(537712450)].ToString()))
									{
										this.string_15 = jtoken3[Class185.smethod_0(537763723)].ToString();
										if (object.Equals(false, Convert.ToBoolean(jtoken3[Class185.smethod_0(537763770)])))
										{
											this.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
											taskAwaiter5 = Task.Delay(GClass0.int_0).GetAwaiter();
											if (!taskAwaiter5.IsCompleted)
											{
												await taskAwaiter5;
												taskAwaiter5 = taskAwaiter6;
												taskAwaiter6 = default(TaskAwaiter);
											}
											taskAwaiter5.GetResult();
											goto IL_3F7;
										}
										return;
									}
								}
								goto IL_404;
							}
						}
						if (!this.GetRandomSize(jtoken[Class185.smethod_0(537763742)], out this.string_15, Class185.smethod_0(537712450), Class185.smethod_0(537763723), Class185.smethod_0(537763770)))
						{
							this.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
							taskAwaiter5 = Task.Delay(GClass0.int_0).GetAwaiter();
							if (!taskAwaiter5.IsCompleted)
							{
								await taskAwaiter5;
								taskAwaiter5 = taskAwaiter6;
								taskAwaiter6 = default(TaskAwaiter);
							}
							taskAwaiter5.GetResult();
							continue;
						}
						return;
						IL_404:
						IEnumerator<JToken> enumerator = null;
						IL_4C4:
						await Task.Delay(GClass0.int_0);
						this.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), false, false);
						httpResponseMessage = null;
						goto IL_5AA;
					}
					taskAwaiter5 = this.ScrapeProduct().GetAwaiter();
					if (!taskAwaiter5.IsCompleted)
					{
						await taskAwaiter5;
						taskAwaiter5 = taskAwaiter6;
						taskAwaiter6 = default(TaskAwaiter);
					}
					taskAwaiter5.GetResult();
					break;
				}
				catch (ThreadAbortException)
				{
					break;
				}
				catch
				{
					num = 1;
					goto IL_5AA;
				}
				IL_55D:
				taskAwaiter5 = Task.Delay(GClass0.int_0).GetAwaiter();
				if (!taskAwaiter5.IsCompleted)
				{
					await taskAwaiter5;
					taskAwaiter5 = taskAwaiter6;
					taskAwaiter6 = default(TaskAwaiter);
				}
				taskAwaiter5.GetResult();
				this.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), false, false);
				continue;
				IL_5AA:
				if (num == 1)
				{
					goto IL_55D;
				}
			}
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00047D74 File Offset: 0x00045F74
		public async Task ScrapeAtom()
		{
			this.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), true, false);
			for (;;)
			{
				int num = 0;
				TaskAwaiter taskAwaiter;
				TaskAwaiter taskAwaiter2;
				try
				{
					if (this.CheckMassLinkChange())
					{
						taskAwaiter = this.ScrapeProduct().GetAwaiter();
						if (!taskAwaiter.IsCompleted)
						{
							await taskAwaiter;
							taskAwaiter = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter);
						}
						taskAwaiter.GetResult();
						break;
					}
					TaskAwaiter<HttpResponseMessage> taskAwaiter3 = this.class4_0.method_2(this.string_13, this.bool_5, null).GetAwaiter();
					if (!taskAwaiter3.IsCompleted)
					{
						await taskAwaiter3;
						TaskAwaiter<HttpResponseMessage> taskAwaiter4;
						taskAwaiter3 = taskAwaiter4;
						taskAwaiter4 = default(TaskAwaiter<HttpResponseMessage>);
					}
					HttpResponseMessage httpResponseMessage = taskAwaiter3.GetResult();
					await this.HandleResponse(httpResponseMessage, true);
					httpResponseMessage.EnsureSuccessStatusCode();
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.LoadXml(httpResponseMessage.smethod_3());
					foreach (object obj in xmlDocument.GetElementsByTagName(Class185.smethod_0(537762222)))
					{
						XmlNode xmlNode = (XmlNode)obj;
						if (this.string_8.All(new Func<string, bool>(xmlNode[Class185.smethod_0(537712450)].InnerText.ToLower().Contains)) && !this.string_5.Any(new Func<string, bool>(xmlNode[Class185.smethod_0(537712450)].InnerText.ToLower().Contains)))
						{
							this.uri_0 = new Uri(xmlNode[Class185.smethod_0(537762266)].Attributes[Class185.smethod_0(537669937)].Value);
							return;
						}
					}
					await Task.Delay(GClass0.int_0);
					this.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), false, false);
					httpResponseMessage = null;
					goto IL_3AE;
				}
				catch (ThreadAbortException)
				{
					break;
				}
				catch
				{
					num = 1;
					goto IL_3AE;
				}
				IL_361:
				taskAwaiter = Task.Delay(GClass0.int_0).GetAwaiter();
				if (!taskAwaiter.IsCompleted)
				{
					await taskAwaiter;
					taskAwaiter = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter);
				}
				taskAwaiter.GetResult();
				this.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), false, false);
				continue;
				IL_3AE:
				if (num == 1)
				{
					goto IL_361;
				}
			}
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00047DBC File Offset: 0x00045FBC
		public async Task ScrapeProduct()
		{
			this.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), true, false);
			for (;;)
			{
				int num = 0;
				TaskAwaiter taskAwaiter5;
				TaskAwaiter taskAwaiter6;
				try
				{
					HttpResponseMessage httpResponseMessage;
					for (;;)
					{
						IL_3DF:
						this.CheckMassLinkChange();
						TaskAwaiter<HttpResponseMessage> taskAwaiter = this.class4_0.method_2(this.uri_0 + Class185.smethod_0(537683945), this.bool_5, null).GetAwaiter();
						if (!taskAwaiter.IsCompleted)
						{
							await taskAwaiter;
							TaskAwaiter<HttpResponseMessage> taskAwaiter2;
							taskAwaiter = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
						}
						JObject jobject;
						for (;;)
						{
							httpResponseMessage = taskAwaiter.GetResult();
							TaskAwaiter<bool> taskAwaiter3 = this.HandleResponse(httpResponseMessage, true).GetAwaiter();
							if (!taskAwaiter3.IsCompleted)
							{
								await taskAwaiter3;
								TaskAwaiter<bool> taskAwaiter4;
								taskAwaiter3 = taskAwaiter4;
								taskAwaiter4 = default(TaskAwaiter<bool>);
							}
							taskAwaiter3.GetResult();
							httpResponseMessage.EnsureSuccessStatusCode();
							jobject = httpResponseMessage.smethod_0();
							this.class4_0.method_7(jobject[Class185.smethod_0(537712450)].ToString(), Class185.smethod_0(537700781));
							this.string_10 = jobject[Class185.smethod_0(537703519)].ToString();
							this.jtoken_1[Class185.smethod_0(537762143)] = this.string_10;
							Class4 @class = this.class4_0;
							JToken jtoken = jobject[Class185.smethod_0(537763753)];
							@class.string_1 = ((jtoken != null) ? jtoken.ToString() : null);
							if (jobject[Class185.smethod_0(537704318)].Any(new Func<JToken, bool>(Shopify.Class211.class211_0.method_2)))
							{
								this.bool_1 = true;
							}
							if (this.bool_3)
							{
								break;
							}
							using (IEnumerator<JToken> enumerator = ((IEnumerable<JToken>)jobject[Class185.smethod_0(537762112)]).GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									JToken jtoken2 = enumerator.Current;
									if (jtoken2[Class185.smethod_0(537762157)].Any(new Func<JToken, bool>(this.method_7)))
									{
										this.string_15 = jtoken2[Class185.smethod_0(537703519)].ToString();
										if (object.Equals(false, Convert.ToBoolean(jtoken2[Class185.smethod_0(537692562)])))
										{
											this.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
											taskAwaiter5 = Task.Delay(GClass0.int_0).GetAwaiter();
											if (!taskAwaiter5.IsCompleted)
											{
												await taskAwaiter5;
												taskAwaiter5 = taskAwaiter6;
												taskAwaiter6 = default(TaskAwaiter);
											}
											taskAwaiter5.GetResult();
											goto IL_3DF;
										}
										return;
									}
								}
								goto IL_422;
							}
						}
						if (this.GetRandomSize(jobject[Class185.smethod_0(537762112)], out this.string_15, Class185.smethod_0(537762175), Class185.smethod_0(537703519), Class185.smethod_0(537692562)))
						{
							goto IL_4D3;
						}
						this.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
						taskAwaiter5 = Task.Delay(GClass0.int_0).GetAwaiter();
						if (!taskAwaiter5.IsCompleted)
						{
							await taskAwaiter5;
							taskAwaiter5 = taskAwaiter6;
							taskAwaiter6 = default(TaskAwaiter);
						}
						taskAwaiter5.GetResult();
					}
					IL_422:
					IEnumerator<JToken> enumerator = null;
					taskAwaiter5 = Task.Delay(GClass0.int_0).GetAwaiter();
					if (!taskAwaiter5.IsCompleted)
					{
						await taskAwaiter5;
						taskAwaiter5 = taskAwaiter6;
						taskAwaiter6 = default(TaskAwaiter);
					}
					taskAwaiter5.GetResult();
					this.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), false, false);
					httpResponseMessage = null;
					goto IL_582;
					IL_4D3:
					break;
				}
				catch (ThreadAbortException)
				{
					break;
				}
				catch
				{
					num = 1;
					goto IL_582;
				}
				IL_535:
				taskAwaiter5 = Task.Delay(GClass0.int_0).GetAwaiter();
				if (!taskAwaiter5.IsCompleted)
				{
					await taskAwaiter5;
					taskAwaiter5 = taskAwaiter6;
					taskAwaiter6 = default(TaskAwaiter);
				}
				taskAwaiter5.GetResult();
				this.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), false, false);
				continue;
				IL_582:
				if (num == 1)
				{
					goto IL_535;
				}
			}
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00047E04 File Offset: 0x00046004
		public bool FollowRedirects(string html)
		{
			HtmlDocument htmlDocument = new HtmlDocument();
			htmlDocument.LoadHtml(html);
			foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)htmlDocument.DocumentNode.SelectNodes(Class185.smethod_0(537762705))))
			{
				if (htmlNode.InnerText.Contains(Class185.smethod_0(537760688)) && !htmlNode.InnerText.Contains(new Uri(this.string_1).Authority) && htmlNode.InnerText.Contains(Class185.smethod_0(537760684)))
				{
					string text = htmlNode.InnerText.Split(new string[]
					{
						Class185.smethod_0(537683440)
					}, StringSplitOptions.None)[1].Split(new string[]
					{
						Class185.smethod_0(537760684)
					}, StringSplitOptions.None)[0];
					if (text.Length > 0)
					{
						Class30.smethod_1((int)this.jtoken_1[Class185.smethod_0(537703519)], this.string_1);
						this.string_1 = Class185.smethod_0(537683440) + text + Class185.smethod_0(537760684);
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00047F48 File Offset: 0x00046148
		public async Task GetPalaceNote()
		{
			if (this.bool_2)
			{
				for (;;)
				{
					int num = 0;
					try
					{
						this.class4_0.method_4(Class185.smethod_0(537670109), Class185.smethod_0(537700781), true, false);
						HttpResponseMessage httpResponseMessage = await new Class70(this.string_11, Class185.smethod_0(537692910), 10, false, true, null, true).method_6(string.Format(Class185.smethod_0(537683241), this.string_1, this.string_15), false);
						httpResponseMessage.EnsureSuccessStatusCode();
						HtmlDocument htmlDocument = new HtmlDocument();
						htmlDocument.LoadHtml(httpResponseMessage.smethod_3());
						this.string_6 = htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537683280)).Attributes[Class185.smethod_0(537711408)].Value;
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
						this.class4_0.method_4(Class185.smethod_0(537669957), Class185.smethod_0(537700781), true, false);
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
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00047F90 File Offset: 0x00046190
		public async Task GetApiKey()
		{
			for (;;)
			{
				try
				{
					if (!Class173.jobject_4.ContainsKey((string)this.jtoken_1[Class185.smethod_0(537700413)]))
					{
						this.class4_0.method_4(Class185.smethod_0(537683719), Class185.smethod_0(537700781), true, false);
						TaskAwaiter<HttpResponseMessage> taskAwaiter = this.class4_0.method_2(this.string_1, true, null).GetAwaiter();
						if (!taskAwaiter.IsCompleted)
						{
							await taskAwaiter;
							TaskAwaiter<HttpResponseMessage> taskAwaiter2;
							taskAwaiter = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
						}
						HttpResponseMessage result = taskAwaiter.GetResult();
						result.EnsureSuccessStatusCode();
						HtmlDocument htmlDocument = new HtmlDocument();
						htmlDocument.LoadHtml(result.smethod_3());
						string value = htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537683757)).Attributes[Class185.smethod_0(537706534)].Value;
						this.class70_0.httpClient_0.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Class185.smethod_0(537683838), Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format(Class185.smethod_0(537683818), value))));
						JObject jobject = new JObject();
						jobject[Class185.smethod_0(537683813)] = value;
						jobject[Class185.smethod_0(537683893)] = false;
						jobject[Class185.smethod_0(537683603)] = true;
						JObject value2 = jobject;
						Class173.jobject_4[(string)this.jtoken_1[Class185.smethod_0(537700413)]] = value2;
						Class30.smethod_1((int)this.jtoken_1[Class185.smethod_0(537703519)], this.string_1);
					}
					else
					{
						string arg = Class173.jobject_4[(string)this.jtoken_1[Class185.smethod_0(537700413)]][Class185.smethod_0(537683813)].ToString();
						this.class70_0.httpClient_0.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Class185.smethod_0(537683838), Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format(Class185.smethod_0(537683818), arg))));
					}
				}
				catch (ThreadAbortException)
				{
				}
				catch
				{
					this.class4_0.method_0(Class185.smethod_0(537683584), Class185.smethod_0(537700909), false);
					continue;
				}
				break;
			}
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00047FD8 File Offset: 0x000461D8
		public async Task GetToken(string html = null)
		{
			for (;;)
			{
				int num = 0;
				try
				{
					if (this.uri_0 == null && html == null)
					{
						break;
					}
					this.class4_0.method_4(Class185.smethod_0(537670109), Class185.smethod_0(537700781), true, false);
					string text = html;
					if (text == null)
					{
						text = (await this.class4_0.method_2(this.uri_0.ToString(), this.bool_5, null)).smethod_3();
					}
					string text2 = text;
					HtmlDocument htmlDocument = new HtmlDocument();
					htmlDocument.LoadHtml(text2);
					if ((string)this.jtoken_1[Class185.smethod_0(537700413)] == Class185.smethod_0(537683030))
					{
						this.jobject_0[text2.Replace(Class185.smethod_0(537711014), string.Empty).Split(new string[]
						{
							Class185.smethod_0(537683009)
						}, StringSplitOptions.None)[1].Split(new char[]
						{
							';'
						})[0].Replace(Class185.smethod_0(537715235), string.Empty).Replace(Class185.smethod_0(537700459), string.Empty)] = text2.Replace(Class185.smethod_0(537711014), string.Empty).Split(new string[]
						{
							Class185.smethod_0(537683060)
						}, StringSplitOptions.None)[1].Split(new char[]
						{
							';'
						})[0].Replace(Class185.smethod_0(537715235), string.Empty).Replace(Class185.smethod_0(537700459), string.Empty);
					}
					else if (this.jtoken_1[Class185.smethod_0(537700413)].ToString().Contains(Class185.smethod_0(537683047)))
					{
						HtmlNode htmlNode = htmlDocument.DocumentNode.SelectNodes(Class185.smethod_0(537762705)).FirstOrDefault(new Func<HtmlNode, bool>(Shopify.Class211.class211_0.method_3));
						if (htmlNode != null)
						{
							string text3 = string.Empty;
							string text4 = string.Empty;
							foreach (string text5 in htmlNode.InnerHtml.Split(new string[]
							{
								Class185.smethod_0(537762688)
							}, StringSplitOptions.None).Skip(1).ToArray<string>())
							{
								try
								{
									string @string = Encoding.UTF8.GetString(Convert.FromBase64String(text5.Split(new string[]
									{
										Class185.smethod_0(537762749)
									}, StringSplitOptions.None)[0]));
									if (@string.Contains(Class185.smethod_0(537706840)))
									{
										text3 = @string.Split(new string[]
										{
											Class185.smethod_0(537762742)
										}, StringSplitOptions.None)[1].Split(new char[]
										{
											']'
										})[0];
									}
									else if (!@string.Contains(Class185.smethod_0(537710986)))
									{
										text4 = @string;
									}
								}
								catch
								{
								}
							}
							if (text3 != null && text4 != null)
							{
								this.jobject_0[text3] = text4;
							}
						}
					}
					HtmlNodeCollection htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes(Class185.smethod_0(537762776));
					HtmlNode htmlNode2;
					if (htmlNodeCollection == null)
					{
						htmlNode2 = null;
					}
					else
					{
						htmlNode2 = htmlNodeCollection.FirstOrDefault(new Func<HtmlNode, bool>(Shopify.Class211.class211_0.method_4));
					}
					HtmlNode htmlNode3 = htmlNode2;
					if (htmlNode3 != null)
					{
						this.jobject_0[htmlNode3.Attributes[Class185.smethod_0(537712143)].Value.Replace(Class185.smethod_0(537762742), string.Empty).Replace(Class185.smethod_0(537714082), string.Empty)] = htmlNode3.Attributes[Class185.smethod_0(537711408)].Value;
					}
					this.class4_0.method_4(Class185.smethod_0(537762765), Class185.smethod_0(537700781), true, false);
					Class30.smethod_1((int)this.jtoken_1[Class185.smethod_0(537703519)], this.uri_0.ToString());
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
					this.class4_0.method_4(Class185.smethod_0(537669957), Class185.smethod_0(537700781), true, false);
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

		// Token: 0x060007A4 RID: 1956 RVA: 0x00048028 File Offset: 0x00046228
		public void Start()
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537760722), Class185.smethod_0(537700781), true, false);
				Task task = this.Login();
				Task task2 = this.SubmitPayment(false);
				this.GetApiKey().Wait();
				Task checkoutUrl = this.GetCheckoutUrl(null);
				this.class4_0.method_8();
				if (this.string_15 == null)
				{
					this.FindProduct().Wait();
				}
				this.class4_0.method_4(Class185.smethod_0(537760707), Class185.smethod_0(537700781), true, false);
				checkoutUrl.Wait();
				this.CheckDomainChange().Wait();
				Task palaceNote = this.GetPalaceNote();
				if (!this.bool_0)
				{
					this.AddToCart().Wait();
				}
				if (this.string_12 == null)
				{
					this.GetShippingMethodApi().Wait();
				}
				task.Wait();
				task2.Wait();
				palaceNote.Wait();
				this.SubmitOrder().Wait();
				this.Process().Wait();
			}
			catch
			{
			}
			finally
			{
				this.class4_0.method_0(Class185.smethod_0(537663178), Class185.smethod_0(537700909), true);
			}
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0004815C File Offset: 0x0004635C
		public async Task CheckDomainChange()
		{
			this.class4_0.method_4(Class185.smethod_0(537683848), Class185.smethod_0(537700781), true, false);
			if (new Uri(this.string_4).Authority != new Uri(this.string_1).Authority)
			{
				await this.GetCheckoutUrl(null);
			}
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x000481A4 File Offset: 0x000463A4
		public async Task<bool> HandleResponse(HttpResponseMessage response, bool rotating = false)
		{
			bool result;
			if (response.StatusCode == (HttpStatusCode)430)
			{
				if (rotating)
				{
					TaskAwaiter taskAwaiter = Task.Delay(GClass0.int_0).GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						await taskAwaiter;
						TaskAwaiter taskAwaiter2;
						taskAwaiter = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
					}
					taskAwaiter.GetResult();
					result = true;
				}
				else
				{
					this.class4_0.method_4(Class185.smethod_0(537762796), Class185.smethod_0(537700781), true, false);
					TaskAwaiter taskAwaiter = Task.Delay(5000).GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						await taskAwaiter;
						TaskAwaiter taskAwaiter2;
						taskAwaiter = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
					}
					taskAwaiter.GetResult();
					result = true;
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x000481FC File Offset: 0x000463FC
		public bool GetRandomSize(JToken variants, out string variantID, string size_name = "option1", string variant_id = "id", string available = "available")
		{
			JToken jtoken = variants.Where(new Func<JToken, bool>(new Shopify.Class212
			{
				string_0 = available
			}.method_0)).smethod_2();
			if (jtoken == null)
			{
				variantID = null;
				return false;
			}
			this.class4_0.method_5(jtoken[size_name].ToString().ToUpper());
			variantID = jtoken[variant_id].ToString();
			return true;
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00048264 File Offset: 0x00046464
		public bool CheckMassLinkChange()
		{
			bool result;
			try
			{
				if (Class173.string_1 != null && (this.uri_0 == null || (this.uri_0 != null && Class173.string_1 != this.uri_0.ToString())) && Class173.string_1.Replace(Class185.smethod_0(537700393), string.Empty).Contains(this.string_1.Replace(Class185.smethod_0(537700393), string.Empty)))
				{
					this.class4_0.method_7(Class173.string_1, Class185.smethod_0(537700781));
					this.bool_4 = false;
					this.uri_0 = new Uri(Class173.string_1.Split(new char[]
					{
						'?'
					})[0]);
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0004834C File Offset: 0x0004654C
		public async Task Login()
		{
			for (;;)
			{
				int num = 0;
				try
				{
					if (this.jtoken_1[Class185.smethod_0(537762580)].ToString() == Class185.smethod_0(537710839))
					{
						break;
					}
					this.class4_0.method_4(Class185.smethod_0(537662763), Class185.smethod_0(537700781), true, false);
					Dictionary<string, string> dictionary = Class70.smethod_1();
					dictionary[Class185.smethod_0(537762560)] = Class185.smethod_0(537762608);
					dictionary[Class185.smethod_0(537658149)] = Class185.smethod_0(537658192);
					dictionary[Class185.smethod_0(537762597)] = this.jtoken_1[Class185.smethod_0(537762580)][Class185.smethod_0(537712582)].ToString();
					dictionary[Class185.smethod_0(537762635)] = this.jtoken_1[Class185.smethod_0(537762580)][Class185.smethod_0(537706673)].ToString();
					TaskAwaiter<HttpResponseMessage> taskAwaiter = this.class70_0.method_8(this.string_1 + Class185.smethod_0(537762676), dictionary, false).GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						await taskAwaiter;
						TaskAwaiter<HttpResponseMessage> taskAwaiter2;
						taskAwaiter = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
					}
					HttpResponseMessage result = taskAwaiter.GetResult();
					HttpResponseMessage httpResponseMessage = result;
					TaskAwaiter<bool> taskAwaiter3 = this.HandleResponse(httpResponseMessage, false).GetAwaiter();
					if (!taskAwaiter3.IsCompleted)
					{
						await taskAwaiter3;
						TaskAwaiter<bool> taskAwaiter4;
						taskAwaiter3 = taskAwaiter4;
						taskAwaiter4 = default(TaskAwaiter<bool>);
					}
					taskAwaiter3.GetResult();
					if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537762676)))
					{
						this.class4_0.method_0(Class185.smethod_0(537762457), Class185.smethod_0(537700909), false);
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

		// Token: 0x060007AA RID: 1962 RVA: 0x00048394 File Offset: 0x00046594
		public JObject AddProperties(JObject json)
		{
			try
			{
				if (Class173.jobject_0.ContainsKey(this.jtoken_1[Class185.smethod_0(537700413)].ToString()))
				{
					json[Class185.smethod_0(537681978)][Class185.smethod_0(537681961)][0][Class185.smethod_0(537706840)] = Class173.jobject_0[this.jtoken_1[Class185.smethod_0(537700413)].ToString()];
				}
				foreach (KeyValuePair<string, JToken> keyValuePair in this.jobject_0)
				{
					json[Class185.smethod_0(537681978)][Class185.smethod_0(537681961)][0][Class185.smethod_0(537706840)][keyValuePair.Key] = keyValuePair.Value;
				}
			}
			catch
			{
			}
			return json;
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x000484BC File Offset: 0x000466BC
		public async Task AddToCart()
		{
			for (;;)
			{
				int num = 0;
				TaskAwaiter taskAwaiter6;
				try
				{
					HttpResponseMessage result;
					for (;;)
					{
						this.class4_0.method_4(Class185.smethod_0(537663094), Class185.smethod_0(537662875), true, false);
						JObject jobject = new JObject(new JProperty(Class185.smethod_0(537681978), new JObject(new JProperty(Class185.smethod_0(537681961), new JArray(new JObject())))));
						jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537681961)][0][Class185.smethod_0(537662856)] = this.string_15;
						jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537681961)][0][Class185.smethod_0(537662905)] = 1;
						jobject = this.AddProperties(jobject);
						TaskAwaiter<HttpResponseMessage> taskAwaiter = this.class70_0.method_13(this.string_0 + Class185.smethod_0(537662977), jobject, false).GetAwaiter();
						if (!taskAwaiter.IsCompleted)
						{
							await taskAwaiter;
							TaskAwaiter<HttpResponseMessage> taskAwaiter2;
							taskAwaiter = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
						}
						result = taskAwaiter.GetResult();
						TaskAwaiter<bool> taskAwaiter3 = this.HandleResponse(result, false).GetAwaiter();
						if (!taskAwaiter3.IsCompleted)
						{
							await taskAwaiter3;
							TaskAwaiter<bool> taskAwaiter4;
							taskAwaiter3 = taskAwaiter4;
							taskAwaiter4 = default(TaskAwaiter<bool>);
						}
						if (taskAwaiter3.GetResult())
						{
							break;
						}
						if (!result.smethod_3().Contains(Class185.smethod_0(537682010)) && result.smethod_0()[Class185.smethod_0(537681978)][Class185.smethod_0(537681961)].Any<JToken>())
						{
							goto IL_33A;
						}
						this.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
						TaskAwaiter taskAwaiter5 = Task.Delay(GClass0.int_0).GetAwaiter();
						if (!taskAwaiter5.IsCompleted)
						{
							await taskAwaiter5;
							taskAwaiter5 = taskAwaiter6;
							taskAwaiter6 = default(TaskAwaiter);
						}
						taskAwaiter5.GetResult();
						this.bool_5 = false;
						taskAwaiter5 = this.FindProduct().GetAwaiter();
						if (!taskAwaiter5.IsCompleted)
						{
							await taskAwaiter5;
							taskAwaiter5 = taskAwaiter6;
							taskAwaiter6 = default(TaskAwaiter);
						}
						taskAwaiter5.GetResult();
					}
					continue;
					IL_33A:
					if (result.smethod_0()[Class185.smethod_0(537681978)][Class185.smethod_0(537681988)].Any<JToken>())
					{
						this.string_12 = result.smethod_0()[Class185.smethod_0(537681978)][Class185.smethod_0(537681988)][0][Class185.smethod_0(537703519)].ToString();
					}
					this.string_9 = result.smethod_0()[Class185.smethod_0(537681978)][Class185.smethod_0(537682019)].ToString();
					this.class4_0.method_4(Class185.smethod_0(537662950), Class185.smethod_0(537700781), true, false);
					this.bool_0 = true;
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
					TaskAwaiter taskAwaiter5 = Task.Delay(GClass0.int_1).GetAwaiter();
					if (!taskAwaiter5.IsCompleted)
					{
						await taskAwaiter5;
						taskAwaiter5 = taskAwaiter6;
						taskAwaiter6 = default(TaskAwaiter);
					}
					taskAwaiter5.GetResult();
				}
			}
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00048504 File Offset: 0x00046704
		public async Task GetCheckoutUrl(dynamic variant = null)
		{
			if (this.string_15 != null)
			{
				variant = this.string_15;
			}
			for (;;)
			{
				int num = 0;
				try
				{
					this.string_4 = null;
					this.class4_0.method_4(Class185.smethod_0(537683485), Class185.smethod_0(537700781), true, false);
					if (this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)].ToString().ToLower().Contains(Class185.smethod_0(537721762)))
					{
						this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)] = this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660290)].ToString();
					}
					if (this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660385)].ToString().ToLower().Contains(Class185.smethod_0(537721762)))
					{
						this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660385)] = this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660290)].ToString();
					}
					JObject jobject = new JObject();
					jobject[Class185.smethod_0(537681978)] = new JObject();
					jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537662792)] = this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537662792)];
					jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682186)] = new JObject();
					jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682186)][Class185.smethod_0(537662508)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662508)];
					jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682186)][Class185.smethod_0(537662540)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662540)];
					jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682186)][Class185.smethod_0(537662588)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662571)];
					jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682186)][Class185.smethod_0(537662567)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660310)];
					jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682186)][Class185.smethod_0(537660290)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660290)];
					jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682186)][Class185.smethod_0(537660334)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)];
					jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682186)][Class185.smethod_0(537683515)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)];
					jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682186)][Class185.smethod_0(537660385)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)];
					jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682186)][Class185.smethod_0(537660362)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660362)];
					jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682186)][Class185.smethod_0(537660356)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)];
					jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682418)] = new JObject();
					jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682418)][Class185.smethod_0(537662508)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662508)];
					jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682418)][Class185.smethod_0(537662540)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662540)];
					jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682418)][Class185.smethod_0(537662588)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662571)];
					jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682418)][Class185.smethod_0(537662567)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660310)];
					jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682418)][Class185.smethod_0(537660290)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660290)];
					jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682418)][Class185.smethod_0(537660334)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)];
					jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682418)][Class185.smethod_0(537683515)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660385)];
					jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682418)][Class185.smethod_0(537660385)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660385)];
					jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682418)][Class185.smethod_0(537660362)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660362)];
					jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682418)][Class185.smethod_0(537660356)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)];
					if (Shopify.Class213.callSite_1 == null)
					{
						Shopify.Class213.callSite_1 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Shopify), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, bool> target = Shopify.Class213.callSite_1.Target;
					CallSite callSite_ = Shopify.Class213.callSite_1;
					if (Shopify.Class213.callSite_0 == null)
					{
						Shopify.Class213.callSite_0 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof(Shopify), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					if (target(callSite_, Shopify.Class213.callSite_0.Target(Shopify.Class213.callSite_0, variant, null)))
					{
						this.class4_0.method_4(Class185.smethod_0(537663094), Class185.smethod_0(537662875), true, false);
						JObject jobject2 = new JObject();
						string propertyName = Class185.smethod_0(537662856);
						if (Shopify.Class213.callSite_2 == null)
						{
							Shopify.Class213.callSite_2 = CallSite<Func<CallSite, object, JToken>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(JToken), typeof(Shopify)));
						}
						jobject2[propertyName] = Shopify.Class213.callSite_2.Target(Shopify.Class213.callSite_2, variant);
						jobject2[Class185.smethod_0(537662905)] = 1;
						jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537681961)] = new JArray(jobject2);
						this.bool_0 = true;
					}
					HttpResponseMessage httpResponseMessage = await this.class70_0.method_10(this.string_1 + Class185.smethod_0(537683498), jobject);
					TaskAwaiter<bool> taskAwaiter = this.HandleResponse(httpResponseMessage, false).GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						await taskAwaiter;
						TaskAwaiter<bool> taskAwaiter2;
						taskAwaiter = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter<bool>);
					}
					if (taskAwaiter.GetResult())
					{
						continue;
					}
					if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537683540)))
					{
						httpResponseMessage = await this.QueueWait(httpResponseMessage.Headers.GetValues(Class185.smethod_0(537686380)).First<string>());
					}
					JObject jobject3 = httpResponseMessage.smethod_0();
					if (jobject3.ContainsKey(Class185.smethod_0(537683577)))
					{
						JToken jtoken = jobject3[Class185.smethod_0(537683577)][Class185.smethod_0(537681978)];
						if (jtoken[Class185.smethod_0(537681961)] != null)
						{
							if (jtoken[Class185.smethod_0(537681961)].ToString().Contains(Class185.smethod_0(537682010)))
							{
								variant = null;
								this.bool_0 = false;
								continue;
							}
							this.class4_0.method_0(Class185.smethod_0(537683574), Class185.smethod_0(537700909), false);
						}
						else if (jtoken[Class185.smethod_0(537682186)] != null)
						{
							this.class4_0.method_0(Class185.smethod_0(537683356), Class185.smethod_0(537700909), false);
						}
						else
						{
							if (jtoken[Class185.smethod_0(537682418)] == null)
							{
								GClass3.smethod_0(httpResponseMessage.smethod_3(), Class185.smethod_0(537683417));
								throw new Exception();
							}
							this.class4_0.method_0(Class185.smethod_0(537683387), Class185.smethod_0(537700909), false);
						}
					}
					JObject jobject4 = httpResponseMessage.smethod_0();
					this.string_4 = jobject4[Class185.smethod_0(537681978)][Class185.smethod_0(537683394)].ToString();
					this.string_3 = jobject4[Class185.smethod_0(537681978)][Class185.smethod_0(537692633)].ToString();
					this.string_2 = Class185.smethod_0(537683440) + new Uri(this.string_4).Authority.Replace(Class185.smethod_0(537711600), string.Empty);
					this.string_0 = this.string_2 + Class185.smethod_0(537683439) + this.string_3;
					if (jobject4[Class185.smethod_0(537681978)][Class185.smethod_0(537681988)].Any<JToken>())
					{
						this.string_12 = jobject4[Class185.smethod_0(537681978)][Class185.smethod_0(537681988)][0][Class185.smethod_0(537703519)].ToString();
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
					this.class4_0.method_4(Class185.smethod_0(537683221), Class185.smethod_0(537700781), true, false);
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

		// Token: 0x060007AD RID: 1965 RVA: 0x00048554 File Offset: 0x00046754
		public async Task<HttpResponseMessage> QueueWait(string queue_poll)
		{
			this.class70_0.httpClient_0.DefaultRequestHeaders.TryAddWithoutValidation(Class185.smethod_0(537663147), queue_poll);
			HttpResponseMessage result;
			for (;;)
			{
				int num = 0;
				TaskAwaiter taskAwaiter2;
				try
				{
					this.class4_0.method_4(Class185.smethod_0(537762194), Class185.smethod_0(537700781), true, false);
					HttpResponseMessage httpResponseMessage = await this.class70_0.method_6(queue_poll, false);
					await this.HandleResponse(httpResponseMessage, false);
					while (httpResponseMessage.StatusCode != HttpStatusCode.Created)
					{
						TaskAwaiter taskAwaiter = Task.Delay(1000).GetAwaiter();
						if (!taskAwaiter.IsCompleted)
						{
							await taskAwaiter;
							taskAwaiter = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter);
						}
						taskAwaiter.GetResult();
						this.class4_0.method_4(Class185.smethod_0(537762194), Class185.smethod_0(537700781), true, false);
						httpResponseMessage = this.class70_0.method_5(queue_poll, false);
					}
					this.class70_0.httpClient_0.DefaultRequestHeaders.Remove(Class185.smethod_0(537663147));
					result = httpResponseMessage;
					break;
				}
				catch (ThreadAbortException)
				{
					result = null;
					break;
				}
				catch
				{
					num = 1;
				}
				if (num == 1)
				{
					this.class4_0.method_4(Class185.smethod_0(537762177), Class185.smethod_0(537700781), true, false);
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
			return result;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x000485A4 File Offset: 0x000467A4
		public async Task SubmitShippingMethod()
		{
			for (;;)
			{
				int num = 0;
				try
				{
					this.class4_0.method_4(Class185.smethod_0(537762994), Class185.smethod_0(537700781), true, false);
					JObject jobject = new JObject();
					string propertyName = Class185.smethod_0(537681978);
					JObject jobject2 = new JObject();
					string propertyName2 = Class185.smethod_0(537763789);
					JObject jobject3 = new JObject();
					jobject3[Class185.smethod_0(537703519)] = this.string_12;
					jobject2[propertyName2] = jobject3;
					jobject[propertyName] = jobject2;
					jobject[Class185.smethod_0(537763825)] = this.string_7;
					JObject jobject4 = jobject;
					if (this.bool_2)
					{
						jobject4[Class185.smethod_0(537681978)][Class185.smethod_0(537763817)] = this.string_6;
					}
					TaskAwaiter<HttpResponseMessage> taskAwaiter = this.class70_0.method_13(this.string_0, jobject4, false).GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						await taskAwaiter;
						TaskAwaiter<HttpResponseMessage> taskAwaiter2;
						taskAwaiter = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
					}
					HttpResponseMessage result = taskAwaiter.GetResult();
					HttpResponseMessage httpResponseMessage = result;
					TaskAwaiter<bool> taskAwaiter3 = this.HandleResponse(httpResponseMessage, false).GetAwaiter();
					if (!taskAwaiter3.IsCompleted)
					{
						await taskAwaiter3;
						TaskAwaiter<bool> taskAwaiter4;
						taskAwaiter3 = taskAwaiter4;
						taskAwaiter4 = default(TaskAwaiter<bool>);
					}
					if (taskAwaiter3.GetResult())
					{
						continue;
					}
					if (!httpResponseMessage.IsSuccessStatusCode && httpResponseMessage.StatusCode != HttpStatusCode.Found)
					{
						throw new Exception();
					}
					this.class4_0.method_4(Class185.smethod_0(537763030), Class185.smethod_0(537700781), true, false);
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
					this.class4_0.method_4(Class185.smethod_0(537763043), Class185.smethod_0(537700781), true, false);
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

		// Token: 0x060007AF RID: 1967 RVA: 0x000485EC File Offset: 0x000467EC
		public async Task SubmitPayment(bool silent = false)
		{
			for (;;)
			{
				int num = 0;
				try
				{
					if (!silent)
					{
						this.class4_0.method_4(Class185.smethod_0(537661418), Class185.smethod_0(537700781), true, false);
					}
					JObject jobject = new JObject();
					jobject[Class185.smethod_0(537763119)] = new JObject();
					jobject[Class185.smethod_0(537763119)][Class185.smethod_0(537660835)] = ((string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660835)]).Replace(Class185.smethod_0(537711014), string.Empty);
					jobject[Class185.smethod_0(537763119)][Class185.smethod_0(537763153)] = this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660870)];
					jobject[Class185.smethod_0(537763119)][Class185.smethod_0(537763149)] = this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660699)];
					jobject[Class185.smethod_0(537763119)][Class185.smethod_0(537763192)] = this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660682)];
					jobject[Class185.smethod_0(537763119)][Class185.smethod_0(537662508)] = this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662508)];
					jobject[Class185.smethod_0(537763119)][Class185.smethod_0(537662540)] = this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662540)];
					HttpResponseMessage httpResponseMessage = await this.class70_0.method_10(Class185.smethod_0(537763169), jobject);
					httpResponseMessage.EnsureSuccessStatusCode();
					this.string_7 = httpResponseMessage.smethod_0()[Class185.smethod_0(537703519)].ToString();
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

		// Token: 0x060007B0 RID: 1968 RVA: 0x0004863C File Offset: 0x0004683C
		public async Task CheckForCaptcha()
		{
			try
			{
				HttpResponseMessage httpResponseMessage_ = await this.class70_0.method_6(this.string_4, false);
				this.bool_6 = httpResponseMessage_.smethod_3().Contains(Class185.smethod_0(537683893));
			}
			catch
			{
			}
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00048684 File Offset: 0x00046884
		public async Task<string> GetCaptcha()
		{
			if (this.bool_6 && (this.string_16 == null || this.stopwatch_0.ElapsedMilliseconds > 110000L))
			{
				this.class4_0.method_4(Class185.smethod_0(537676367), Class185.smethod_0(537676393), true, false);
				this.string_16 = await GForm7.smethod_1(Class185.smethod_0(537683626), Class185.smethod_0(537683705), (string)this.jtoken_1[Class185.smethod_0(537703519)]);
				this.stopwatch_0.Restart();
			}
			return this.string_16;
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x000486CC File Offset: 0x000468CC
		public async Task SubmitOrder()
		{
			JObject jobject = new JObject();
			jobject[Class185.smethod_0(537763806)] = Class185.smethod_0(537713814);
			string propertyName = Class185.smethod_0(537681978);
			JObject jobject2 = new JObject();
			string propertyName2 = Class185.smethod_0(537763789);
			JObject jobject3 = new JObject();
			jobject3[Class185.smethod_0(537703519)] = this.string_12;
			jobject2[propertyName2] = jobject3;
			jobject[propertyName] = jobject2;
			jobject[Class185.smethod_0(537763825)] = this.string_7;
			JObject jobject4 = jobject;
			if (this.bool_2)
			{
				jobject4[Class185.smethod_0(537681978)][Class185.smethod_0(537763817)] = this.string_6;
			}
			this.string_16 = null;
			int i = 0;
			while (i < 5)
			{
				int num = 0;
				TaskAwaiter taskAwaiter6;
				try
				{
					this.class4_0.method_4(Class185.smethod_0(537658294), Class185.smethod_0(537700964), true, false);
					HttpResponseMessage httpResponseMessage = await this.class70_0.method_13(this.string_4, jobject4, false);
					if (!httpResponseMessage.IsSuccessStatusCode && httpResponseMessage.StatusCode != HttpStatusCode.Found)
					{
						httpResponseMessage.EnsureSuccessStatusCode();
					}
					jobject4.Remove(Class185.smethod_0(537763825));
					jobject4.Remove(Class185.smethod_0(537676185));
					jobject4.Remove(Class185.smethod_0(537681978));
					TaskAwaiter<bool> taskAwaiter = this.HandleResponse(httpResponseMessage, false).GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						await taskAwaiter;
						TaskAwaiter<bool> taskAwaiter2;
						taskAwaiter = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter<bool>);
					}
					if (taskAwaiter.GetResult())
					{
						goto IL_67B;
					}
					if (httpResponseMessage.smethod_3().ToLower().Contains(Class185.smethod_0(537763812)))
					{
						this.bool_6 = true;
						JObject jobject5 = jobject4;
						TaskAwaiter<string> taskAwaiter3 = this.GetCaptcha().GetAwaiter();
						if (!taskAwaiter3.IsCompleted)
						{
							await taskAwaiter3;
							TaskAwaiter<string> taskAwaiter4;
							taskAwaiter3 = taskAwaiter4;
							taskAwaiter4 = default(TaskAwaiter<string>);
						}
						string result = taskAwaiter3.GetResult();
						jobject5[Class185.smethod_0(537676185)] = result;
						jobject5 = null;
						goto IL_67B;
					}
					if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537763588)))
					{
						this.class4_0.method_0(Class185.smethod_0(537762345), Class185.smethod_0(537700909), false);
					}
					else if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537762676)) && httpResponseMessage.StatusCode == HttpStatusCode.Found)
					{
						this.class4_0.method_0(Class185.smethod_0(537763625), Class185.smethod_0(537700909), false);
					}
					else
					{
						if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537763678)))
						{
							this.class4_0.method_4(Class185.smethod_0(537763678), Class185.smethod_0(537700964), true, false);
							TaskAwaiter taskAwaiter5 = Task.Delay(500).GetAwaiter();
							if (!taskAwaiter5.IsCompleted)
							{
								await taskAwaiter5;
								taskAwaiter5 = taskAwaiter6;
								taskAwaiter6 = default(TaskAwaiter);
							}
							taskAwaiter5.GetResult();
							goto IL_67B;
						}
						if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537763654)))
						{
							this.class4_0.method_0(Class185.smethod_0(537763476), Class185.smethod_0(537700909), false);
						}
						else if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537763509)))
						{
							this.class4_0.method_0(Class185.smethod_0(537763532), Class185.smethod_0(537700909), false);
						}
						else if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537763574)))
						{
							this.class4_0.method_0(Class185.smethod_0(537763385), Class185.smethod_0(537700909), false);
						}
						else
						{
							if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537763363)))
							{
								TaskAwaiter taskAwaiter5 = Task.Delay(GClass0.int_1).GetAwaiter();
								if (!taskAwaiter5.IsCompleted)
								{
									await taskAwaiter5;
									taskAwaiter5 = taskAwaiter6;
									taskAwaiter6 = default(TaskAwaiter);
								}
								taskAwaiter5.GetResult();
								goto IL_67B;
							}
							if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537763429)))
							{
								return;
							}
						}
					}
					GClass3.smethod_0(httpResponseMessage.smethod_3(), Class185.smethod_0(537763223));
					throw new Exception();
				}
				catch (ThreadAbortException)
				{
					return;
				}
				catch
				{
					num = 1;
				}
				goto IL_624;
				IL_67B:
				num = i++;
				continue;
				IL_624:
				if (num == 1)
				{
					this.class4_0.method_4(Class185.smethod_0(537658168), Class185.smethod_0(537700781), true, false);
					TaskAwaiter taskAwaiter5 = Task.Delay(GClass0.int_1).GetAwaiter();
					if (!taskAwaiter5.IsCompleted)
					{
						await taskAwaiter5;
						taskAwaiter5 = taskAwaiter6;
						taskAwaiter6 = default(TaskAwaiter);
					}
					taskAwaiter5.GetResult();
					goto IL_67B;
				}
				goto IL_67B;
			}
			this.class4_0.method_0(Class185.smethod_0(537660491), Class185.smethod_0(537700909), false);
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00048714 File Offset: 0x00046914
		public async Task Process()
		{
			for (;;)
			{
				int num = 0;
				try
				{
					this.class4_0.method_4(Class185.smethod_0(537762437), Class185.smethod_0(537700964), true, false);
					TaskAwaiter<HttpResponseMessage> taskAwaiter = this.class70_0.method_6(this.string_0, false).GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						await taskAwaiter;
						TaskAwaiter<HttpResponseMessage> taskAwaiter2;
						taskAwaiter = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
					}
					HttpResponseMessage result = taskAwaiter.GetResult();
					TaskAwaiter<bool> taskAwaiter3 = this.HandleResponse(result, false).GetAwaiter();
					if (!taskAwaiter3.IsCompleted)
					{
						await taskAwaiter3;
						TaskAwaiter<bool> taskAwaiter4;
						taskAwaiter3 = taskAwaiter4;
						taskAwaiter4 = default(TaskAwaiter<bool>);
					}
					if (!taskAwaiter3.GetResult())
					{
						if (result.smethod_3().ToLower().Contains(Class185.smethod_0(537762473)))
						{
							this.class4_0.method_9(true);
							this.class4_0.method_0(Class185.smethod_0(537660452), Class185.smethod_0(537700909), false);
						}
						else if (result.smethod_3().Contains(Class185.smethod_0(537762471)))
						{
							this.class4_0.method_0(Class185.smethod_0(537660491), Class185.smethod_0(537700909), false);
						}
						else if (result.smethod_3().Contains(Class185.smethod_0(537762510)))
						{
							this.class4_0.method_12();
							this.class4_0.method_9(false);
							this.class4_0.method_0(Class185.smethod_0(537658349), Class185.smethod_0(537658124), false);
						}
						else if (!result.smethod_3().Contains(Class185.smethod_0(537762558)) && !result.smethod_3().Contains(Class185.smethod_0(537762543)))
						{
							if (result.smethod_3().Contains(Class185.smethod_0(537762322)))
							{
								this.class4_0.method_0(Class185.smethod_0(537762345), Class185.smethod_0(537700909), false);
							}
							else
							{
								GClass3.smethod_0(result.smethod_3(), Class185.smethod_0(537762390));
								this.class4_0.method_0(Class185.smethod_0(537660491), Class185.smethod_0(537700909), false);
							}
						}
						else
						{
							this.class4_0.method_0(Class185.smethod_0(537660738), Class185.smethod_0(537700909), false);
						}
						throw new Exception();
					}
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
					this.class4_0.method_4(Class185.smethod_0(537762416), Class185.smethod_0(537700781), true, false);
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

		// Token: 0x060007B4 RID: 1972 RVA: 0x0004875C File Offset: 0x0004695C
		private bool method_0(HtmlNode htmlNode_0)
		{
			return this.string_8.All(new Func<string, bool>(htmlNode_0.InnerText.ToLower().Contains)) && !this.string_5.Any(new Func<string, bool>(htmlNode_0.InnerText.ToLower().Contains));
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00006D20 File Offset: 0x00004F20
		private bool method_1(JToken jtoken_2)
		{
			return Class172.smethod_2(this.string_14, jtoken_2.ToString());
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x000487B4 File Offset: 0x000469B4
		private bool method_2(JToken jtoken_2)
		{
			return this.string_8.All(new Func<string, bool>(jtoken_2[Class185.smethod_0(537712450)].ToString().ToLower().Contains)) && !this.string_5.Any(new Func<string, bool>(jtoken_2[Class185.smethod_0(537712450)].ToString().ToLower().Contains));
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00006D20 File Offset: 0x00004F20
		private bool method_3(JToken jtoken_2)
		{
			return Class172.smethod_2(this.string_14, jtoken_2.ToString());
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00048828 File Offset: 0x00046A28
		private bool method_4(JToken jtoken_2)
		{
			return (this.string_8.All(new Func<string, bool>(jtoken_2[Class185.smethod_0(537712450)].ToString().ToLower().Contains)) && !this.string_5.Any(new Func<string, bool>(jtoken_2[Class185.smethod_0(537712450)].ToString().ToLower().Contains))) || jtoken_2[Class185.smethod_0(537703519)].ToString() == this.string_10;
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00006D20 File Offset: 0x00004F20
		private bool method_5(JToken jtoken_2)
		{
			return Class172.smethod_2(this.string_14, jtoken_2.ToString());
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x000488BC File Offset: 0x00046ABC
		private bool method_6(JToken jtoken_2)
		{
			return (this.string_8.All(new Func<string, bool>(jtoken_2[Class185.smethod_0(537712450)].ToString().ToLower().Contains)) && !this.string_5.Any(new Func<string, bool>(jtoken_2[Class185.smethod_0(537712450)].ToString().ToLower().Contains))) || jtoken_2[Class185.smethod_0(537762143)].ToString() == this.string_10;
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00006D20 File Offset: 0x00004F20
		private bool method_7(JToken jtoken_2)
		{
			return Class172.smethod_2(this.string_14, jtoken_2.ToString());
		}

		// Token: 0x04000525 RID: 1317
		private readonly Class4 class4_0;

		// Token: 0x04000526 RID: 1318
		private string string_0;

		// Token: 0x04000527 RID: 1319
		private string string_1;

		// Token: 0x04000528 RID: 1320
		private bool bool_0;

		// Token: 0x04000529 RID: 1321
		private string string_2;

		// Token: 0x0400052A RID: 1322
		private string string_3;

		// Token: 0x0400052B RID: 1323
		private string string_4;

		// Token: 0x0400052C RID: 1324
		private readonly Class70 class70_0;

		// Token: 0x0400052D RID: 1325
		private bool bool_1;

		// Token: 0x0400052E RID: 1326
		private readonly string[] string_5;

		// Token: 0x0400052F RID: 1327
		private readonly bool bool_2;

		// Token: 0x04000530 RID: 1328
		private string string_6 = string.Empty;

		// Token: 0x04000531 RID: 1329
		private string string_7;

		// Token: 0x04000532 RID: 1330
		private readonly string[] string_8;

		// Token: 0x04000533 RID: 1331
		private string string_9;

		// Token: 0x04000534 RID: 1332
		private string string_10;

		// Token: 0x04000535 RID: 1333
		private Uri uri_0;

		// Token: 0x04000536 RID: 1334
		private readonly JToken jtoken_0;

		// Token: 0x04000537 RID: 1335
		private readonly string string_11;

		// Token: 0x04000538 RID: 1336
		private readonly bool bool_3;

		// Token: 0x04000539 RID: 1337
		private string string_12;

		// Token: 0x0400053A RID: 1338
		private readonly string string_13;

		// Token: 0x0400053B RID: 1339
		private readonly string string_14;

		// Token: 0x0400053C RID: 1340
		private string string_15;

		// Token: 0x0400053D RID: 1341
		private readonly JToken jtoken_1;

		// Token: 0x0400053E RID: 1342
		private bool bool_4 = true;

		// Token: 0x0400053F RID: 1343
		private JObject jobject_0 = new JObject();

		// Token: 0x04000540 RID: 1344
		private bool bool_5 = true;

		// Token: 0x04000541 RID: 1345
		private string string_16;

		// Token: 0x04000542 RID: 1346
		private Stopwatch stopwatch_0 = new Stopwatch();

		// Token: 0x04000543 RID: 1347
		private bool bool_6;

		// Token: 0x02000137 RID: 311
		[Serializable]
		private sealed class Class211
		{
			// Token: 0x060007BE RID: 1982 RVA: 0x00006D3F File Offset: 0x00004F3F
			internal bool method_0(HtmlNode htmlNode_0)
			{
				return htmlNode_0.InnerHtml.Contains(Class185.smethod_0(537682145));
			}

			// Token: 0x060007BF RID: 1983 RVA: 0x00006D56 File Offset: 0x00004F56
			internal string method_1(HtmlNode htmlNode_0)
			{
				return htmlNode_0.InnerHtml;
			}

			// Token: 0x060007C0 RID: 1984 RVA: 0x00006D5E File Offset: 0x00004F5E
			internal bool method_2(JToken jtoken_0)
			{
				return jtoken_0.ToString() == Class185.smethod_0(537681949);
			}

			// Token: 0x060007C1 RID: 1985 RVA: 0x00006D75 File Offset: 0x00004F75
			internal bool method_3(HtmlNode htmlNode_0)
			{
				return htmlNode_0.InnerHtml.Contains(Class185.smethod_0(537681935));
			}

			// Token: 0x060007C2 RID: 1986 RVA: 0x00006D8C File Offset: 0x00004F8C
			internal bool method_4(HtmlNode htmlNode_0)
			{
				return htmlNode_0.Name.Contains(Class185.smethod_0(537706840));
			}

			// Token: 0x060007C3 RID: 1987 RVA: 0x00006182 File Offset: 0x00004382
			internal bool method_5(string string_0)
			{
				return string_0[0] != '-';
			}

			// Token: 0x060007C4 RID: 1988 RVA: 0x00006192 File Offset: 0x00004392
			internal bool method_6(string string_0)
			{
				return string_0[0] == '-';
			}

			// Token: 0x060007C5 RID: 1989 RVA: 0x0000619F File Offset: 0x0000439F
			internal string method_7(string string_0)
			{
				return string_0.Replace(Class185.smethod_0(537676948), string.Empty);
			}

			// Token: 0x04000544 RID: 1348
			public static readonly Shopify.Class211 class211_0 = new Shopify.Class211();

			// Token: 0x04000545 RID: 1349
			public static Func<HtmlNode, bool> func_0;

			// Token: 0x04000546 RID: 1350
			public static Func<HtmlNode, string> func_1;

			// Token: 0x04000547 RID: 1351
			public static Func<JToken, bool> func_2;

			// Token: 0x04000548 RID: 1352
			public static Func<HtmlNode, bool> func_3;

			// Token: 0x04000549 RID: 1353
			public static Func<HtmlNode, bool> func_4;

			// Token: 0x0400054A RID: 1354
			public static Func<string, bool> func_5;

			// Token: 0x0400054B RID: 1355
			public static Func<string, bool> func_6;

			// Token: 0x0400054C RID: 1356
			public static Func<string, string> func_7;
		}

		// Token: 0x02000138 RID: 312
		[StructLayout(LayoutKind.Auto)]
		private struct Struct61 : IAsyncStateMachine
		{
			// Token: 0x060007C6 RID: 1990 RVA: 0x00048950 File Offset: 0x00046B50
			void IAsyncStateMachine.MoveNext()
			{
				int num2;
				int num = num2;
				Shopify shopify = this;
				try
				{
					TaskAwaiter taskAwaiter3;
					switch (num)
					{
					case 0:
						taskAwaiter3 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						num2 = -1;
						break;
					case 1:
						taskAwaiter3 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						num2 = -1;
						goto IL_338;
					case 2:
						taskAwaiter3 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						num2 = -1;
						goto IL_3B8;
					case 3:
						taskAwaiter3 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						num2 = -1;
						goto IL_405;
					case 4:
						taskAwaiter3 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						num2 = -1;
						goto IL_452;
					case 5:
						taskAwaiter3 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						num2 = -1;
						goto IL_4D2;
					case 6:
						taskAwaiter3 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						num2 = -1;
						goto IL_52B;
					case 7:
						taskAwaiter3 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						num2 = -1;
						goto IL_5B7;
					case 8:
						taskAwaiter3 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						num2 = -1;
						goto IL_5DF;
					case 9:
						taskAwaiter3 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						num2 = -1;
						goto IL_631;
					case 10:
						taskAwaiter3 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						num2 = -1;
						goto IL_680;
					case 11:
						taskAwaiter3 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						num2 = -1;
						goto IL_717;
					default:
						if (shopify.bool_4)
						{
							if (shopify.string_1.Contains(Class185.smethod_0(537683875)))
							{
								taskAwaiter3 = shopify.ScrapeJs().GetAwaiter();
								if (!taskAwaiter3.IsCompleted)
								{
									num2 = 0;
									taskAwaiter2 = taskAwaiter3;
									this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct61>(ref taskAwaiter3, ref this);
									return;
								}
							}
							else if (shopify.string_1.Contains(Class185.smethod_0(537683925)))
							{
								taskAwaiter3 = shopify.ScrapeDsm().GetAwaiter();
								if (!taskAwaiter3.IsCompleted)
								{
									num2 = 1;
									taskAwaiter2 = taskAwaiter3;
									this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct61>(ref taskAwaiter3, ref this);
									return;
								}
								goto IL_338;
							}
							else if (shopify.string_13.Contains(Class185.smethod_0(537662977)))
							{
								taskAwaiter3 = shopify.ScrapeJson().GetAwaiter();
								if (!taskAwaiter3.IsCompleted)
								{
									num2 = 3;
									taskAwaiter2 = taskAwaiter3;
									this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct61>(ref taskAwaiter3, ref this);
									return;
								}
								goto IL_405;
							}
							else if (shopify.string_13.Contains(Class185.smethod_0(537683965)))
							{
								taskAwaiter3 = shopify.ScrapeAtom().GetAwaiter();
								if (!taskAwaiter3.IsCompleted)
								{
									num2 = 4;
									taskAwaiter2 = taskAwaiter3;
									this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct61>(ref taskAwaiter3, ref this);
									return;
								}
								goto IL_452;
							}
							else
							{
								if (!shopify.string_13.Contains(Class185.smethod_0(537683939)))
								{
									goto IL_557;
								}
								taskAwaiter3 = shopify.ScrapeOembed().GetAwaiter();
								if (!taskAwaiter3.IsCompleted)
								{
									num2 = 6;
									taskAwaiter2 = taskAwaiter3;
									this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct61>(ref taskAwaiter3, ref this);
									return;
								}
								goto IL_52B;
							}
						}
						else if (shopify.string_1.Contains(Class185.smethod_0(537683875)))
						{
							taskAwaiter3 = shopify.ScrapeJs().GetAwaiter();
							if (!taskAwaiter3.IsCompleted)
							{
								num2 = 8;
								taskAwaiter2 = taskAwaiter3;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct61>(ref taskAwaiter3, ref this);
								return;
							}
							goto IL_5DF;
						}
						else if (shopify.string_1.Contains(Class185.smethod_0(537683925)))
						{
							taskAwaiter3 = shopify.ScrapeDsmProduct().GetAwaiter();
							if (!taskAwaiter3.IsCompleted)
							{
								num2 = 9;
								taskAwaiter2 = taskAwaiter3;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct61>(ref taskAwaiter3, ref this);
								return;
							}
							goto IL_631;
						}
						else
						{
							taskAwaiter3 = shopify.ScrapeProduct().GetAwaiter();
							if (!taskAwaiter3.IsCompleted)
							{
								num2 = 10;
								taskAwaiter2 = taskAwaiter3;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct61>(ref taskAwaiter3, ref this);
								return;
							}
							goto IL_680;
						}
						break;
					}
					taskAwaiter3.GetResult();
					Class30.smethod_1((int)shopify.jtoken_1[Class185.smethod_0(537703519)], shopify.string_1);
					goto IL_557;
					IL_338:
					taskAwaiter3.GetResult();
					Class30.smethod_1((int)shopify.jtoken_1[Class185.smethod_0(537703519)], shopify.string_1);
					taskAwaiter3 = shopify.ScrapeDsmProduct().GetAwaiter();
					if (!taskAwaiter3.IsCompleted)
					{
						num2 = 2;
						taskAwaiter2 = taskAwaiter3;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct61>(ref taskAwaiter3, ref this);
						return;
					}
					IL_3B8:
					taskAwaiter3.GetResult();
					Class30.smethod_1((int)shopify.jtoken_1[Class185.smethod_0(537703519)], shopify.string_1);
					goto IL_557;
					IL_405:
					taskAwaiter3.GetResult();
					Class30.smethod_1((int)shopify.jtoken_1[Class185.smethod_0(537703519)], shopify.string_13);
					goto IL_557;
					IL_452:
					taskAwaiter3.GetResult();
					Class30.smethod_1((int)shopify.jtoken_1[Class185.smethod_0(537703519)], shopify.string_13);
					taskAwaiter3 = shopify.ScrapeProduct().GetAwaiter();
					if (!taskAwaiter3.IsCompleted)
					{
						num2 = 5;
						taskAwaiter2 = taskAwaiter3;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct61>(ref taskAwaiter3, ref this);
						return;
					}
					IL_4D2:
					taskAwaiter3.GetResult();
					Class30.smethod_1((int)shopify.jtoken_1[Class185.smethod_0(537703519)], shopify.uri_0 + Class185.smethod_0(537683945));
					goto IL_557;
					IL_52B:
					taskAwaiter3.GetResult();
					Class30.smethod_1((int)shopify.jtoken_1[Class185.smethod_0(537703519)], shopify.string_13);
					IL_557:
					if (!shopify.bool_1)
					{
						goto IL_71E;
					}
					taskAwaiter3 = shopify.GetToken(null).GetAwaiter();
					if (!taskAwaiter3.IsCompleted)
					{
						num2 = 7;
						taskAwaiter2 = taskAwaiter3;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct61>(ref taskAwaiter3, ref this);
						return;
					}
					IL_5B7:
					taskAwaiter3.GetResult();
					goto IL_71E;
					IL_5DF:
					taskAwaiter3.GetResult();
					Class30.smethod_1((int)shopify.jtoken_1[Class185.smethod_0(537703519)], shopify.uri_0.ToString());
					goto IL_6BB;
					IL_631:
					taskAwaiter3.GetResult();
					Class30.smethod_1((int)shopify.jtoken_1[Class185.smethod_0(537703519)], shopify.uri_0.ToString());
					goto IL_6BB;
					IL_680:
					taskAwaiter3.GetResult();
					Class30.smethod_1((int)shopify.jtoken_1[Class185.smethod_0(537703519)], shopify.uri_0 + Class185.smethod_0(537683945));
					IL_6BB:
					if (!shopify.bool_1)
					{
						goto IL_71E;
					}
					taskAwaiter3 = shopify.GetToken(null).GetAwaiter();
					if (!taskAwaiter3.IsCompleted)
					{
						num2 = 11;
						taskAwaiter2 = taskAwaiter3;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct61>(ref taskAwaiter3, ref this);
						return;
					}
					IL_717:
					taskAwaiter3.GetResult();
					IL_71E:
					shopify.class4_0.method_4(Class185.smethod_0(537683729) + shopify.string_15, Class185.smethod_0(537700781), true, false);
				}
				catch (Exception exception)
				{
					num2 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060007C7 RID: 1991 RVA: 0x00006DA3 File Offset: 0x00004FA3
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400054D RID: 1357
			public int int_0;

			// Token: 0x0400054E RID: 1358
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x0400054F RID: 1359
			public Shopify shopify_0;

			// Token: 0x04000550 RID: 1360
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000139 RID: 313
		[StructLayout(LayoutKind.Auto)]
		private struct Struct62 : IAsyncStateMachine
		{
			// Token: 0x060007C8 RID: 1992 RVA: 0x000490F0 File Offset: 0x000472F0
			void IAsyncStateMachine.MoveNext()
			{
				int num2;
				int num = num2;
				Shopify shopify = this;
				bool result;
				try
				{
					TaskAwaiter taskAwaiter3;
					if (num != 0)
					{
						if (num != 1)
						{
							if (response.StatusCode != (HttpStatusCode)430)
							{
								result = false;
								goto IL_13C;
							}
							if (rotating)
							{
								taskAwaiter3 = Task.Delay(GClass0.int_0).GetAwaiter();
								if (!taskAwaiter3.IsCompleted)
								{
									num2 = 0;
									taskAwaiter2 = taskAwaiter3;
									this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct62>(ref taskAwaiter3, ref this);
									return;
								}
								goto IL_118;
							}
							else
							{
								shopify.class4_0.method_4(Class185.smethod_0(537762796), Class185.smethod_0(537700781), true, false);
								taskAwaiter3 = Task.Delay(5000).GetAwaiter();
								if (!taskAwaiter3.IsCompleted)
								{
									num2 = 1;
									taskAwaiter2 = taskAwaiter3;
									this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct62>(ref taskAwaiter3, ref this);
									return;
								}
							}
						}
						else
						{
							taskAwaiter3 = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter);
							num2 = -1;
						}
						taskAwaiter3.GetResult();
						result = true;
						goto IL_13C;
					}
					taskAwaiter3 = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter);
					num2 = -1;
					IL_118:
					taskAwaiter3.GetResult();
					result = true;
				}
				catch (Exception exception)
				{
					num2 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_13C:
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetResult(result);
			}

			// Token: 0x060007C9 RID: 1993 RVA: 0x00006DB1 File Offset: 0x00004FB1
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04000551 RID: 1361
			public int int_0;

			// Token: 0x04000552 RID: 1362
			public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

			// Token: 0x04000553 RID: 1363
			public HttpResponseMessage httpResponseMessage_0;

			// Token: 0x04000554 RID: 1364
			public bool bool_0;

			// Token: 0x04000555 RID: 1365
			public Shopify shopify_0;

			// Token: 0x04000556 RID: 1366
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x0200013A RID: 314
		[StructLayout(LayoutKind.Auto)]
		private struct Struct63 : IAsyncStateMachine
		{
			// Token: 0x060007CA RID: 1994 RVA: 0x0004926C File Offset: 0x0004746C
			void IAsyncStateMachine.MoveNext()
			{
				int num2;
				int num = num2;
				Shopify shopify = this;
				try
				{
					TaskAwaiter taskAwaiter7;
					if (num > 3)
					{
						if (num != 4)
						{
							shopify.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), true, false);
							engine = new Engine();
							goto IL_8DD;
						}
						taskAwaiter7 = taskAwaiter6;
						taskAwaiter6 = default(TaskAwaiter);
						int num3 = -1;
						num = -1;
						num2 = num3;
						goto IL_8B5;
					}
					IL_68:
					int num12;
					try
					{
						TaskAwaiter<HttpResponseMessage> taskAwaiter8;
						TaskAwaiter<bool> taskAwaiter9;
						switch (num)
						{
						case 0:
						{
							taskAwaiter8 = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
							int num4 = -1;
							num = -1;
							num2 = num4;
							goto IL_256;
						}
						case 1:
						{
							taskAwaiter9 = taskAwaiter4;
							taskAwaiter4 = default(TaskAwaiter<bool>);
							int num5 = -1;
							num = -1;
							num2 = num5;
							goto IL_29D;
						}
						case 2:
						{
							taskAwaiter7 = taskAwaiter6;
							taskAwaiter6 = default(TaskAwaiter);
							int num6 = -1;
							num = -1;
							num2 = num6;
							goto IL_795;
						}
						case 3:
							IL_E9:
							try
							{
								if (num != 3)
								{
									while (enumerator.MoveNext())
									{
										JToken jtoken = enumerator.Current;
										if (jtoken[Class185.smethod_0(537762157)].Any(new Func<JToken, bool>(shopify.method_3)))
										{
											shopify.string_15 = jtoken[Class185.smethod_0(537703519)].ToString();
											if (!object.Equals(false, Convert.ToBoolean(jtoken[Class185.smethod_0(537692562)])))
											{
												goto IL_91E;
											}
											shopify.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
											taskAwaiter7 = Task.Delay(GClass0.int_0).GetAwaiter();
											if (!taskAwaiter7.IsCompleted)
											{
												int num7 = 3;
												num = 3;
												num2 = num7;
												taskAwaiter6 = taskAwaiter7;
												this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct63>(ref taskAwaiter7, ref this);
												return;
											}
											goto IL_1F8;
										}
									}
									goto IL_803;
								}
								taskAwaiter7 = taskAwaiter6;
								taskAwaiter6 = default(TaskAwaiter);
								int num8 = -1;
								num = -1;
								num2 = num8;
								IL_1F8:
								taskAwaiter7.GetResult();
							}
							finally
							{
								if (num < 0 && enumerator != null)
								{
									enumerator.Dispose();
								}
							}
							break;
							IL_803:
							enumerator = null;
							throw new Exception();
						}
						IL_219:
						shopify.CheckMassLinkChange();
						taskAwaiter8 = shopify.class4_0.method_2((!shopify.bool_4) ? shopify.uri_0.ToString() : shopify.string_1, shopify.bool_5, null).GetAwaiter();
						if (!taskAwaiter8.IsCompleted)
						{
							int num9 = 0;
							num = 0;
							num2 = num9;
							taskAwaiter2 = taskAwaiter8;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Shopify.Struct63>(ref taskAwaiter8, ref this);
							return;
						}
						IL_256:
						HttpResponseMessage result2 = taskAwaiter8.GetResult();
						result = result2;
						if (shopify.FollowRedirects(result.smethod_3()))
						{
							goto IL_8DD;
						}
						taskAwaiter9 = shopify.HandleResponse(result, true).GetAwaiter();
						if (!taskAwaiter9.IsCompleted)
						{
							int num10 = 1;
							num = 1;
							num2 = num10;
							taskAwaiter4 = taskAwaiter9;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Shopify.Struct63>(ref taskAwaiter9, ref this);
							return;
						}
						IL_29D:
						taskAwaiter9.GetResult();
						HtmlDocument htmlDocument = new HtmlDocument();
						htmlDocument.LoadHtml(result.smethod_3());
						object obj;
						if (result.smethod_3().Contains(Class185.smethod_0(537761947)))
						{
							obj = JObject.Parse(htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537761921)).InnerText);
						}
						else
						{
							engine.Execute(Class185.smethod_0(537761959) + string.Join(Class185.smethod_0(537711014), htmlDocument.DocumentNode.SelectNodes(Class185.smethod_0(537762705)).Where(new Func<HtmlNode, bool>(Shopify.Class211.class211_0.method_0)).Select(new Func<HtmlNode, string>(Shopify.Class211.class211_0.method_1))));
							obj = JObject.Parse(engine.Execute(Class185.smethod_0(537761994)).GetCompletionValue().ToString())[Class185.smethod_0(537762038)].FirstOrDefault(new Func<JToken, bool>(shopify.method_2));
							if (obj == null)
							{
								throw new Exception();
							}
						}
						if (Shopify.Class214.callSite_2 == null)
						{
							Shopify.Class214.callSite_2 = CallSite<Action<CallSite, Class4, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class185.smethod_0(537762030), null, typeof(Shopify), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Action<CallSite, Class4, object> target = Shopify.Class214.callSite_2.Target;
						CallSite callSite_ = Shopify.Class214.callSite_2;
						Class4 class4_ = shopify.class4_0;
						if (Shopify.Class214.callSite_1 == null)
						{
							Shopify.Class214.callSite_1 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, Class185.smethod_0(537711952), null, typeof(Shopify), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, object> target2 = Shopify.Class214.callSite_1.Target;
						CallSite callSite_2 = Shopify.Class214.callSite_1;
						if (Shopify.Class214.callSite_0 == null)
						{
							Shopify.Class214.callSite_0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Shopify), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						target(callSite_, class4_, target2(callSite_2, Shopify.Class214.callSite_0.Target(Shopify.Class214.callSite_0, obj, Class185.smethod_0(537712450))));
						Shopify shopify2 = shopify;
						if (Shopify.Class214.callSite_5 == null)
						{
							Shopify.Class214.callSite_5 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Shopify)));
						}
						Func<CallSite, object, string> target3 = Shopify.Class214.callSite_5.Target;
						CallSite callSite_3 = Shopify.Class214.callSite_5;
						if (Shopify.Class214.callSite_4 == null)
						{
							Shopify.Class214.callSite_4 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, Class185.smethod_0(537711952), null, typeof(Shopify), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, object> target4 = Shopify.Class214.callSite_4.Target;
						CallSite callSite_4 = Shopify.Class214.callSite_4;
						if (Shopify.Class214.callSite_3 == null)
						{
							Shopify.Class214.callSite_3 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Shopify), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						shopify2.string_10 = target3(callSite_3, target4(callSite_4, Shopify.Class214.callSite_3.Target(Shopify.Class214.callSite_3, obj, Class185.smethod_0(537703519))));
						shopify.jtoken_1[Class185.smethod_0(537762143)] = shopify.string_10;
						if (Shopify.Class214.callSite_6 == null)
						{
							Shopify.Class214.callSite_6 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Shopify), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						object obj2 = Shopify.Class214.callSite_6.Target(Shopify.Class214.callSite_6, obj, Class185.smethod_0(537762112));
						if (!shopify.bool_3)
						{
							if (Shopify.Class214.callSite_10 == null)
							{
								Shopify.Class214.callSite_10 = CallSite<Func<CallSite, object, JToken>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(JToken), typeof(Shopify)));
							}
							enumerator = ((IEnumerable<JToken>)Shopify.Class214.callSite_10.Target(Shopify.Class214.callSite_10, obj2)).GetEnumerator();
							goto IL_E9;
						}
						if (Shopify.Class214.callSite_9 == null)
						{
							Shopify.Class214.callSite_9 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Shopify), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, bool> target5 = Shopify.Class214.callSite_9.Target;
						CallSite callSite_5 = Shopify.Class214.callSite_9;
						if (Shopify.Class214.callSite_8 == null)
						{
							Shopify.Class214.callSite_8 = CallSite<Func<CallSite, object, object>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.Not, typeof(Shopify), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, object> target6 = Shopify.Class214.callSite_8.Target;
						CallSite callSite_6 = Shopify.Class214.callSite_8;
						if (Shopify.Class214.callSite_7 == null)
						{
							Shopify.Class214.callSite_7 = CallSite<Delegate0<CallSite, Shopify, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName, Class185.smethod_0(537761817), null, typeof(Shopify), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsOut, null)
							}));
						}
						if (!target5(callSite_5, target6(callSite_6, Shopify.Class214.callSite_7.Target(Shopify.Class214.callSite_7, shopify, obj2, ref shopify.string_15))))
						{
							goto IL_91E;
						}
						shopify.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
						taskAwaiter7 = Task.Delay(GClass0.int_0).GetAwaiter();
						if (!taskAwaiter7.IsCompleted)
						{
							int num11 = 2;
							num = 2;
							num2 = num11;
							taskAwaiter6 = taskAwaiter7;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct63>(ref taskAwaiter7, ref this);
							return;
						}
						IL_795:
						taskAwaiter7.GetResult();
						goto IL_219;
					}
					catch (ThreadAbortException)
					{
						goto IL_91E;
					}
					catch
					{
						num12 = 1;
					}
					if (num12 != 1)
					{
						goto IL_8DD;
					}
					taskAwaiter7 = Task.Delay(GClass0.int_0).GetAwaiter();
					if (!taskAwaiter7.IsCompleted)
					{
						int num13 = 4;
						num = 4;
						num2 = num13;
						taskAwaiter6 = taskAwaiter7;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct63>(ref taskAwaiter7, ref this);
						return;
					}
					IL_8B5:
					taskAwaiter7.GetResult();
					shopify.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), false, false);
					IL_8DD:
					num12 = 0;
					goto IL_68;
				}
				catch (Exception exception)
				{
					num2 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_91E:
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060007CB RID: 1995 RVA: 0x00006DBF File Offset: 0x00004FBF
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04000557 RID: 1367
			public int int_0;

			// Token: 0x04000558 RID: 1368
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04000559 RID: 1369
			public Shopify shopify_0;

			// Token: 0x0400055A RID: 1370
			private Engine engine_0;

			// Token: 0x0400055B RID: 1371
			private HttpResponseMessage httpResponseMessage_0;

			// Token: 0x0400055C RID: 1372
			private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

			// Token: 0x0400055D RID: 1373
			private TaskAwaiter<bool> taskAwaiter_1;

			// Token: 0x0400055E RID: 1374
			private TaskAwaiter taskAwaiter_2;

			// Token: 0x0400055F RID: 1375
			private IEnumerator<JToken> ienumerator_0;
		}

		// Token: 0x0200013B RID: 315
		[StructLayout(LayoutKind.Auto)]
		private struct Struct64 : IAsyncStateMachine
		{
			// Token: 0x060007CC RID: 1996 RVA: 0x00049C10 File Offset: 0x00047E10
			void IAsyncStateMachine.MoveNext()
			{
				int num2;
				int num = num2;
				Shopify shopify = this;
				try
				{
					TaskAwaiter taskAwaiter7;
					if (num > 1)
					{
						if (num != 2)
						{
							goto IL_283;
						}
						taskAwaiter7 = taskAwaiter6;
						taskAwaiter6 = default(TaskAwaiter);
						int num3 = -1;
						num = -1;
						num2 = num3;
						goto IL_27C;
					}
					IL_3D:
					int num8;
					try
					{
						TaskAwaiter<bool> taskAwaiter8;
						TaskAwaiter<HttpResponseMessage> taskAwaiter9;
						if (num != 0)
						{
							if (num == 1)
							{
								taskAwaiter8 = taskAwaiter4;
								taskAwaiter4 = default(TaskAwaiter<bool>);
								int num4 = -1;
								num = -1;
								num2 = num4;
								goto IL_1D9;
							}
							shopify.class4_0.method_4(Class185.smethod_0(537762994), Class185.smethod_0(537700781), true, false);
							JObject jobject = new JObject();
							string propertyName = Class185.smethod_0(537681978);
							JObject jobject2 = new JObject();
							string propertyName2 = Class185.smethod_0(537763789);
							JObject jobject3 = new JObject();
							jobject3[Class185.smethod_0(537703519)] = shopify.string_12;
							jobject2[propertyName2] = jobject3;
							jobject[propertyName] = jobject2;
							jobject[Class185.smethod_0(537763825)] = shopify.string_7;
							JObject jobject4 = jobject;
							if (shopify.bool_2)
							{
								jobject4[Class185.smethod_0(537681978)][Class185.smethod_0(537763817)] = shopify.string_6;
							}
							taskAwaiter9 = shopify.class70_0.method_13(shopify.string_0, jobject4, false).GetAwaiter();
							if (!taskAwaiter9.IsCompleted)
							{
								int num5 = 0;
								num = 0;
								num2 = num5;
								taskAwaiter2 = taskAwaiter9;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Shopify.Struct64>(ref taskAwaiter9, ref this);
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
						httpResponseMessage = result;
						taskAwaiter8 = shopify.HandleResponse(httpResponseMessage, false).GetAwaiter();
						if (!taskAwaiter8.IsCompleted)
						{
							int num7 = 1;
							num = 1;
							num2 = num7;
							taskAwaiter4 = taskAwaiter8;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Shopify.Struct64>(ref taskAwaiter8, ref this);
							return;
						}
						IL_1D9:
						if (taskAwaiter8.GetResult())
						{
							goto IL_283;
						}
						if (!httpResponseMessage.IsSuccessStatusCode && httpResponseMessage.StatusCode != HttpStatusCode.Found)
						{
							throw new Exception();
						}
						shopify.class4_0.method_4(Class185.smethod_0(537763030), Class185.smethod_0(537700781), true, false);
						goto IL_2C4;
					}
					catch (ThreadAbortException)
					{
						goto IL_2C4;
					}
					catch
					{
						num8 = 1;
					}
					if (num8 != 1)
					{
						goto IL_283;
					}
					shopify.class4_0.method_4(Class185.smethod_0(537763043), Class185.smethod_0(537700781), true, false);
					taskAwaiter7 = Task.Delay(GClass0.int_1).GetAwaiter();
					if (!taskAwaiter7.IsCompleted)
					{
						int num9 = 2;
						num = 2;
						num2 = num9;
						taskAwaiter6 = taskAwaiter7;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct64>(ref taskAwaiter7, ref this);
						return;
					}
					IL_27C:
					taskAwaiter7.GetResult();
					IL_283:
					num8 = 0;
					goto IL_3D;
				}
				catch (Exception exception)
				{
					num2 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_2C4:
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060007CD RID: 1997 RVA: 0x00006DCD File Offset: 0x00004FCD
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04000560 RID: 1376
			public int int_0;

			// Token: 0x04000561 RID: 1377
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04000562 RID: 1378
			public Shopify shopify_0;

			// Token: 0x04000563 RID: 1379
			private HttpResponseMessage httpResponseMessage_0;

			// Token: 0x04000564 RID: 1380
			private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

			// Token: 0x04000565 RID: 1381
			private TaskAwaiter<bool> taskAwaiter_1;

			// Token: 0x04000566 RID: 1382
			private TaskAwaiter taskAwaiter_2;
		}

		// Token: 0x0200013C RID: 316
		private sealed class Class212
		{
			// Token: 0x060007CF RID: 1999 RVA: 0x00006DDB File Offset: 0x00004FDB
			internal bool method_0(JToken jtoken_0)
			{
				return object.Equals(true, (bool)jtoken_0[this.string_0]);
			}

			// Token: 0x04000567 RID: 1383
			public string string_0;
		}

		// Token: 0x0200013D RID: 317
		[StructLayout(LayoutKind.Auto)]
		private struct Struct65 : IAsyncStateMachine
		{
			// Token: 0x060007D0 RID: 2000 RVA: 0x00049F40 File Offset: 0x00048140
			void IAsyncStateMachine.MoveNext()
			{
				int num2;
				int num = num2;
				Shopify shopify = this;
				try
				{
					for (;;)
					{
						try
						{
							TaskAwaiter<HttpResponseMessage> taskAwaiter3;
							if (num != 0)
							{
								if (Class173.jobject_4.ContainsKey((string)shopify.jtoken_1[Class185.smethod_0(537700413)]))
								{
									string arg = Class173.jobject_4[(string)shopify.jtoken_1[Class185.smethod_0(537700413)]][Class185.smethod_0(537683813)].ToString();
									shopify.class70_0.httpClient_0.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Class185.smethod_0(537683838), Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format(Class185.smethod_0(537683818), arg))));
									break;
								}
								shopify.class4_0.method_4(Class185.smethod_0(537683719), Class185.smethod_0(537700781), true, false);
								taskAwaiter3 = shopify.class4_0.method_2(shopify.string_1, true, null).GetAwaiter();
								if (!taskAwaiter3.IsCompleted)
								{
									int num3 = 0;
									num = 0;
									num2 = num3;
									taskAwaiter2 = taskAwaiter3;
									this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Shopify.Struct65>(ref taskAwaiter3, ref this);
									return;
								}
							}
							else
							{
								taskAwaiter3 = taskAwaiter2;
								taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
								int num4 = -1;
								num = -1;
								num2 = num4;
							}
							HttpResponseMessage result = taskAwaiter3.GetResult();
							result.EnsureSuccessStatusCode();
							HtmlDocument htmlDocument = new HtmlDocument();
							htmlDocument.LoadHtml(result.smethod_3());
							string value = htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537683757)).Attributes[Class185.smethod_0(537706534)].Value;
							shopify.class70_0.httpClient_0.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Class185.smethod_0(537683838), Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format(Class185.smethod_0(537683818), value))));
							JObject jobject = new JObject();
							jobject[Class185.smethod_0(537683813)] = value;
							jobject[Class185.smethod_0(537683893)] = false;
							jobject[Class185.smethod_0(537683603)] = true;
							JObject value2 = jobject;
							Class173.jobject_4[(string)shopify.jtoken_1[Class185.smethod_0(537700413)]] = value2;
							Class30.smethod_1((int)shopify.jtoken_1[Class185.smethod_0(537703519)], shopify.string_1);
							break;
						}
						catch (ThreadAbortException)
						{
							break;
						}
						catch
						{
							shopify.class4_0.method_0(Class185.smethod_0(537683584), Class185.smethod_0(537700909), false);
						}
					}
				}
				catch (Exception exception)
				{
					num2 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060007D1 RID: 2001 RVA: 0x00006DFE File Offset: 0x00004FFE
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04000568 RID: 1384
			public int int_0;

			// Token: 0x04000569 RID: 1385
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x0400056A RID: 1386
			public Shopify shopify_0;

			// Token: 0x0400056B RID: 1387
			private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;
		}

		// Token: 0x0200013E RID: 318
		[StructLayout(LayoutKind.Auto)]
		private struct Struct66 : IAsyncStateMachine
		{
			// Token: 0x060007D2 RID: 2002 RVA: 0x0004A25C File Offset: 0x0004845C
			void IAsyncStateMachine.MoveNext()
			{
				int num2;
				int num = num2;
				Shopify shopify = this;
				try
				{
					if (num <= 1)
					{
						goto IL_2CA;
					}
					if (num != 2)
					{
						goto IL_2C8;
					}
					TaskAwaiter taskAwaiter7 = taskAwaiter6;
					taskAwaiter6 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					num2 = num3;
					IL_2C1:
					taskAwaiter7.GetResult();
					IL_2C8:
					int num4 = 0;
					IL_2CA:
					try
					{
						TaskAwaiter<bool> taskAwaiter8;
						TaskAwaiter<HttpResponseMessage> taskAwaiter9;
						if (num != 0)
						{
							if (num == 1)
							{
								taskAwaiter8 = taskAwaiter4;
								taskAwaiter4 = default(TaskAwaiter<bool>);
								int num5 = -1;
								num = -1;
								num2 = num5;
								goto IL_22E;
							}
							if (shopify.jtoken_1[Class185.smethod_0(537762580)].ToString() == Class185.smethod_0(537710839))
							{
								goto IL_30A;
							}
							shopify.class4_0.method_4(Class185.smethod_0(537662763), Class185.smethod_0(537700781), true, false);
							Dictionary<string, string> dictionary = Class70.smethod_1();
							dictionary[Class185.smethod_0(537762560)] = Class185.smethod_0(537762608);
							dictionary[Class185.smethod_0(537658149)] = Class185.smethod_0(537658192);
							dictionary[Class185.smethod_0(537762597)] = shopify.jtoken_1[Class185.smethod_0(537762580)][Class185.smethod_0(537712582)].ToString();
							dictionary[Class185.smethod_0(537762635)] = shopify.jtoken_1[Class185.smethod_0(537762580)][Class185.smethod_0(537706673)].ToString();
							taskAwaiter9 = shopify.class70_0.method_8(shopify.string_1 + Class185.smethod_0(537762676), dictionary, false).GetAwaiter();
							if (!taskAwaiter9.IsCompleted)
							{
								int num6 = 0;
								num = 0;
								num2 = num6;
								taskAwaiter2 = taskAwaiter9;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Shopify.Struct66>(ref taskAwaiter9, ref this);
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
						httpResponseMessage = result;
						taskAwaiter8 = shopify.HandleResponse(httpResponseMessage, false).GetAwaiter();
						if (!taskAwaiter8.IsCompleted)
						{
							int num8 = 1;
							num = 1;
							num2 = num8;
							taskAwaiter4 = taskAwaiter8;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Shopify.Struct66>(ref taskAwaiter8, ref this);
							return;
						}
						IL_22E:
						taskAwaiter8.GetResult();
						if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537762676)))
						{
							shopify.class4_0.method_0(Class185.smethod_0(537762457), Class185.smethod_0(537700909), false);
						}
						goto IL_30A;
					}
					catch (ThreadAbortException)
					{
						goto IL_30A;
					}
					catch
					{
						num4 = 1;
					}
					if (num4 != 1)
					{
						goto IL_2C8;
					}
					shopify.class4_0.method_4(Class185.smethod_0(537662600), Class185.smethod_0(537700781), true, false);
					taskAwaiter7 = Task.Delay(GClass0.int_1).GetAwaiter();
					if (taskAwaiter7.IsCompleted)
					{
						goto IL_2C1;
					}
					int num9 = 2;
					num = 2;
					num2 = num9;
					taskAwaiter6 = taskAwaiter7;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct66>(ref taskAwaiter7, ref this);
					return;
				}
				catch (Exception exception)
				{
					num2 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_30A:
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060007D3 RID: 2003 RVA: 0x00006E0C File Offset: 0x0000500C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400056C RID: 1388
			public int int_0;

			// Token: 0x0400056D RID: 1389
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x0400056E RID: 1390
			public Shopify shopify_0;

			// Token: 0x0400056F RID: 1391
			private HttpResponseMessage httpResponseMessage_0;

			// Token: 0x04000570 RID: 1392
			private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

			// Token: 0x04000571 RID: 1393
			private TaskAwaiter<bool> taskAwaiter_1;

			// Token: 0x04000572 RID: 1394
			private TaskAwaiter taskAwaiter_2;
		}

		// Token: 0x0200013F RID: 319
		[StructLayout(LayoutKind.Auto)]
		private struct Struct67 : IAsyncStateMachine
		{
			// Token: 0x060007D4 RID: 2004 RVA: 0x0004A5D4 File Offset: 0x000487D4
			void IAsyncStateMachine.MoveNext()
			{
				int num3;
				int num2 = num3;
				Shopify shopify = this;
				try
				{
					TaskAwaiter taskAwaiter7;
					if (num2 > 5)
					{
						if (num2 != 6)
						{
							shopify.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), true, false);
							goto IL_66A;
						}
						taskAwaiter7 = taskAwaiter6;
						taskAwaiter6 = default(TaskAwaiter);
						int num4 = -1;
						num2 = -1;
						num3 = num4;
						goto IL_642;
					}
					IL_5D:
					try
					{
						TaskAwaiter<HttpResponseMessage> taskAwaiter8;
						TaskAwaiter<bool> taskAwaiter9;
						switch (num2)
						{
						case 0:
						{
							taskAwaiter7 = taskAwaiter6;
							taskAwaiter6 = default(TaskAwaiter);
							int num5 = -1;
							num2 = -1;
							num3 = num5;
							goto IL_514;
						}
						case 1:
						{
							taskAwaiter8 = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
							int num6 = -1;
							num2 = -1;
							num3 = num6;
							goto IL_2A1;
						}
						case 2:
						{
							taskAwaiter9 = taskAwaiter4;
							taskAwaiter4 = default(TaskAwaiter<bool>);
							int num7 = -1;
							num2 = -1;
							num3 = num7;
							goto IL_304;
						}
						case 3:
						{
							taskAwaiter7 = taskAwaiter6;
							taskAwaiter6 = default(TaskAwaiter);
							int num8 = -1;
							num2 = -1;
							num3 = num8;
							goto IL_49A;
						}
						case 4:
							IL_107:
							try
							{
								if (num2 != 4)
								{
									while (enumerator.MoveNext())
									{
										JToken jtoken = enumerator.Current;
										if (jtoken[Class185.smethod_0(537762157)].Any(new Func<JToken, bool>(shopify.method_5)))
										{
											shopify.string_15 = jtoken[Class185.smethod_0(537703519)].ToString();
											shopify.string_9 = jtoken[Class185.smethod_0(537761918)].ToString();
											shopify.jtoken_1[Class185.smethod_0(537762143)] = shopify.string_10;
											if (!object.Equals(false, Convert.ToBoolean(jtoken[Class185.smethod_0(537692562)])))
											{
												goto IL_6BE;
											}
											shopify.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
											taskAwaiter7 = Task.Delay(GClass0.int_0).GetAwaiter();
											if (!taskAwaiter7.IsCompleted)
											{
												int num9 = 4;
												num2 = 4;
												num3 = num9;
												taskAwaiter6 = taskAwaiter7;
												this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct67>(ref taskAwaiter7, ref this);
												return;
											}
											goto IL_252;
										}
									}
									goto IL_4D0;
								}
								taskAwaiter7 = taskAwaiter6;
								taskAwaiter6 = default(TaskAwaiter);
								int num10 = -1;
								num2 = -1;
								num3 = num10;
								IL_252:
								taskAwaiter7.GetResult();
								goto IL_4C3;
							}
							finally
							{
								if (num2 < 0 && enumerator != null)
								{
									enumerator.Dispose();
								}
							}
							break;
							IL_4D0:
							enumerator = null;
							goto IL_590;
						case 5:
						{
							taskAwaiter7 = taskAwaiter6;
							taskAwaiter6 = default(TaskAwaiter);
							int num11 = -1;
							num2 = -1;
							num3 = num11;
							goto IL_5E8;
						}
						default:
							goto IL_4C3;
						}
						IL_276:
						taskAwaiter8 = shopify.class4_0.method_2(shopify.string_13, shopify.bool_5, null).GetAwaiter();
						if (!taskAwaiter8.IsCompleted)
						{
							int num12 = 1;
							num2 = 1;
							num3 = num12;
							taskAwaiter2 = taskAwaiter8;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Shopify.Struct67>(ref taskAwaiter8, ref this);
							return;
						}
						IL_2A1:
						HttpResponseMessage result = taskAwaiter8.GetResult();
						httpResponseMessage = result;
						if (httpResponseMessage.StatusCode == HttpStatusCode.NotFound)
						{
							shopify.class4_0.method_0(Class185.smethod_0(537761812), Class185.smethod_0(537700909), false);
						}
						taskAwaiter9 = shopify.HandleResponse(httpResponseMessage, true).GetAwaiter();
						if (!taskAwaiter9.IsCompleted)
						{
							int num13 = 2;
							num2 = 2;
							num3 = num13;
							taskAwaiter4 = taskAwaiter9;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Shopify.Struct67>(ref taskAwaiter9, ref this);
							return;
						}
						IL_304:
						taskAwaiter9.GetResult();
						httpResponseMessage.EnsureSuccessStatusCode();
						JToken jtoken2 = httpResponseMessage.smethod_0()[Class185.smethod_0(537761855)].FirstOrDefault(new Func<JToken, bool>(shopify.method_4));
						if (jtoken2 == null)
						{
							goto IL_590;
						}
						shopify.class4_0.method_7(jtoken2[Class185.smethod_0(537712450)].ToString(), Class185.smethod_0(537700781));
						shopify.string_10 = jtoken2[Class185.smethod_0(537703519)].ToString();
						shopify.uri_0 = new Uri(string.Format(Class185.smethod_0(537761838), shopify.string_1, jtoken2[Class185.smethod_0(537761876)]));
						shopify.class4_0.string_1 = (jtoken2[Class185.smethod_0(537761857)].Any<JToken>() ? jtoken2[Class185.smethod_0(537761857)][0][Class185.smethod_0(537703994)].ToString() : null);
						if (!shopify.bool_3)
						{
							enumerator = ((IEnumerable<JToken>)jtoken2[Class185.smethod_0(537762112)]).GetEnumerator();
							goto IL_107;
						}
						if (shopify.GetRandomSize(jtoken2[Class185.smethod_0(537762112)], out shopify.string_15, Class185.smethod_0(537762175), Class185.smethod_0(537703519), Class185.smethod_0(537692562)))
						{
							goto IL_6BE;
						}
						shopify.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
						taskAwaiter7 = Task.Delay(GClass0.int_0).GetAwaiter();
						if (!taskAwaiter7.IsCompleted)
						{
							int num14 = 3;
							num2 = 3;
							num3 = num14;
							taskAwaiter6 = taskAwaiter7;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct67>(ref taskAwaiter7, ref this);
							return;
						}
						IL_49A:
						taskAwaiter7.GetResult();
						IL_4C3:
						if (!shopify.CheckMassLinkChange())
						{
							goto IL_276;
						}
						taskAwaiter7 = shopify.ScrapeProduct().GetAwaiter();
						if (!taskAwaiter7.IsCompleted)
						{
							int num15 = 0;
							num2 = 0;
							num3 = num15;
							taskAwaiter6 = taskAwaiter7;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct67>(ref taskAwaiter7, ref this);
							return;
						}
						IL_514:
						taskAwaiter7.GetResult();
						goto IL_6BE;
						IL_590:
						taskAwaiter7 = Task.Delay(GClass0.int_0).GetAwaiter();
						if (!taskAwaiter7.IsCompleted)
						{
							int num16 = 5;
							num2 = 5;
							num3 = num16;
							taskAwaiter6 = taskAwaiter7;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct67>(ref taskAwaiter7, ref this);
							return;
						}
						IL_5E8:
						taskAwaiter7.GetResult();
						shopify.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), false, false);
						httpResponseMessage = null;
						goto IL_676;
					}
					catch (ThreadAbortException)
					{
						goto IL_6BE;
					}
					catch
					{
						num = 1;
						goto IL_676;
					}
					IL_629:
					taskAwaiter7 = Task.Delay(GClass0.int_0).GetAwaiter();
					if (taskAwaiter7.IsCompleted)
					{
						goto IL_642;
					}
					int num17 = 6;
					num2 = 6;
					num3 = num17;
					taskAwaiter6 = taskAwaiter7;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct67>(ref taskAwaiter7, ref this);
					return;
					IL_676:
					int num18 = num;
					if (num18 == 1)
					{
						goto IL_629;
					}
					goto IL_66A;
					IL_642:
					taskAwaiter7.GetResult();
					shopify.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), false, false);
					IL_66A:
					num = 0;
					goto IL_5D;
				}
				catch (Exception exception)
				{
					num3 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_6BE:
				num3 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060007D5 RID: 2005 RVA: 0x00006E1A File Offset: 0x0000501A
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04000573 RID: 1395
			public int int_0;

			// Token: 0x04000574 RID: 1396
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04000575 RID: 1397
			public Shopify shopify_0;

			// Token: 0x04000576 RID: 1398
			private int int_1;

			// Token: 0x04000577 RID: 1399
			private HttpResponseMessage httpResponseMessage_0;

			// Token: 0x04000578 RID: 1400
			private TaskAwaiter taskAwaiter_0;

			// Token: 0x04000579 RID: 1401
			private TaskAwaiter<HttpResponseMessage> taskAwaiter_1;

			// Token: 0x0400057A RID: 1402
			private TaskAwaiter<bool> taskAwaiter_2;

			// Token: 0x0400057B RID: 1403
			private IEnumerator<JToken> ienumerator_0;
		}

		// Token: 0x02000140 RID: 320
		[StructLayout(LayoutKind.Auto)]
		private struct Struct68 : IAsyncStateMachine
		{
			// Token: 0x060007D6 RID: 2006 RVA: 0x0004AD18 File Offset: 0x00048F18
			void IAsyncStateMachine.MoveNext()
			{
				int num2;
				int num = num2;
				Shopify shopify = this;
				try
				{
					TaskAwaiter taskAwaiter7;
					if (num > 1)
					{
						if (num != 2)
						{
							goto IL_24F;
						}
						taskAwaiter7 = taskAwaiter6;
						taskAwaiter6 = default(TaskAwaiter);
						int num3 = -1;
						num = -1;
						num2 = num3;
						goto IL_248;
					}
					IL_3D:
					int num8;
					try
					{
						TaskAwaiter<bool> taskAwaiter8;
						TaskAwaiter<HttpResponseMessage> taskAwaiter9;
						if (num != 0)
						{
							if (num == 1)
							{
								taskAwaiter8 = taskAwaiter4;
								taskAwaiter4 = default(TaskAwaiter<bool>);
								int num4 = -1;
								num = -1;
								num2 = num4;
								goto IL_1BE;
							}
							shopify.class4_0.method_4(Class185.smethod_0(537762994), Class185.smethod_0(537700781), true, false);
							JObject jobject = new JObject();
							string propertyName = Class185.smethod_0(537681978);
							JObject jobject2 = new JObject();
							string propertyName2 = Class185.smethod_0(537763789);
							JObject jobject3 = new JObject();
							jobject3[Class185.smethod_0(537703519)] = shopify.string_12;
							jobject2[propertyName2] = jobject3;
							jobject[propertyName] = jobject2;
							JObject jobject4 = jobject;
							if (shopify.bool_2)
							{
								jobject4[Class185.smethod_0(537681978)][Class185.smethod_0(537763817)] = shopify.string_6;
							}
							taskAwaiter9 = shopify.class70_0.method_13(shopify.string_0, jobject4, false).GetAwaiter();
							if (!taskAwaiter9.IsCompleted)
							{
								int num5 = 0;
								num = 0;
								num2 = num5;
								taskAwaiter2 = taskAwaiter9;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Shopify.Struct68>(ref taskAwaiter9, ref this);
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
						httpResponseMessage = result;
						taskAwaiter8 = shopify.HandleResponse(httpResponseMessage, false).GetAwaiter();
						if (!taskAwaiter8.IsCompleted)
						{
							int num7 = 1;
							num = 1;
							num2 = num7;
							taskAwaiter4 = taskAwaiter8;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Shopify.Struct68>(ref taskAwaiter8, ref this);
							return;
						}
						IL_1BE:
						if (taskAwaiter8.GetResult())
						{
							goto IL_24F;
						}
						httpResponseMessage.EnsureSuccessStatusCode();
						shopify.class4_0.method_4(Class185.smethod_0(537763030), Class185.smethod_0(537700781), true, false);
						goto IL_290;
					}
					catch (ThreadAbortException)
					{
						goto IL_290;
					}
					catch
					{
						num8 = 1;
					}
					if (num8 != 1)
					{
						goto IL_24F;
					}
					shopify.class4_0.method_4(Class185.smethod_0(537763043), Class185.smethod_0(537700781), true, false);
					taskAwaiter7 = Task.Delay(GClass0.int_1).GetAwaiter();
					if (!taskAwaiter7.IsCompleted)
					{
						int num9 = 2;
						num = 2;
						num2 = num9;
						taskAwaiter6 = taskAwaiter7;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct68>(ref taskAwaiter7, ref this);
						return;
					}
					IL_248:
					taskAwaiter7.GetResult();
					IL_24F:
					num8 = 0;
					goto IL_3D;
				}
				catch (Exception exception)
				{
					num2 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_290:
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060007D7 RID: 2007 RVA: 0x00006E28 File Offset: 0x00005028
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400057C RID: 1404
			public int int_0;

			// Token: 0x0400057D RID: 1405
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x0400057E RID: 1406
			public Shopify shopify_0;

			// Token: 0x0400057F RID: 1407
			private HttpResponseMessage httpResponseMessage_0;

			// Token: 0x04000580 RID: 1408
			private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

			// Token: 0x04000581 RID: 1409
			private TaskAwaiter<bool> taskAwaiter_1;

			// Token: 0x04000582 RID: 1410
			private TaskAwaiter taskAwaiter_2;
		}

		// Token: 0x02000141 RID: 321
		private static class Class213
		{
			// Token: 0x04000583 RID: 1411
			public static CallSite<Func<CallSite, object, object, object>> callSite_0;

			// Token: 0x04000584 RID: 1412
			public static CallSite<Func<CallSite, object, bool>> callSite_1;

			// Token: 0x04000585 RID: 1413
			public static CallSite<Func<CallSite, object, JToken>> callSite_2;
		}

		// Token: 0x02000142 RID: 322
		[StructLayout(LayoutKind.Auto)]
		private struct Struct69 : IAsyncStateMachine
		{
			// Token: 0x060007D8 RID: 2008 RVA: 0x0004B014 File Offset: 0x00049214
			void IAsyncStateMachine.MoveNext()
			{
				int num2;
				int num = num2;
				Shopify shopify = this;
				string string_;
				try
				{
					TaskAwaiter<string> taskAwaiter;
					if (num != 0)
					{
						if (!shopify.bool_6 || (shopify.string_16 != null && shopify.stopwatch_0.ElapsedMilliseconds <= 110000L))
						{
							goto IL_FB;
						}
						shopify.class4_0.method_4(Class185.smethod_0(537676367), Class185.smethod_0(537676393), true, false);
						taskAwaiter = GForm7.smethod_1(Class185.smethod_0(537683626), Class185.smethod_0(537683705), (string)shopify.jtoken_1[Class185.smethod_0(537703519)]).GetAwaiter();
						if (!taskAwaiter.IsCompleted)
						{
							num2 = 0;
							TaskAwaiter<string> taskAwaiter2 = taskAwaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Shopify.Struct69>(ref taskAwaiter, ref this);
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
					string result = taskAwaiter.GetResult();
					shopify.string_16 = result;
					shopify.stopwatch_0.Restart();
					IL_FB:
					string_ = shopify.string_16;
				}
				catch (Exception exception)
				{
					num2 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetResult(string_);
			}

			// Token: 0x060007D9 RID: 2009 RVA: 0x00006E36 File Offset: 0x00005036
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04000586 RID: 1414
			public int int_0;

			// Token: 0x04000587 RID: 1415
			public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

			// Token: 0x04000588 RID: 1416
			public Shopify shopify_0;

			// Token: 0x04000589 RID: 1417
			private TaskAwaiter<string> taskAwaiter_0;
		}

		// Token: 0x02000143 RID: 323
		[StructLayout(LayoutKind.Auto)]
		private struct Struct70 : IAsyncStateMachine
		{
			// Token: 0x060007DA RID: 2010 RVA: 0x0004B164 File Offset: 0x00049364
			void IAsyncStateMachine.MoveNext()
			{
				int num2;
				int num = num2;
				Shopify shopify = this;
				try
				{
					TaskAwaiter taskAwaiter7;
					if (num > 1)
					{
						if (num != 2)
						{
							goto IL_360;
						}
						taskAwaiter7 = taskAwaiter6;
						taskAwaiter6 = default(TaskAwaiter);
						int num3 = -1;
						num = -1;
						num2 = num3;
						goto IL_359;
					}
					IL_3D:
					int num8;
					try
					{
						TaskAwaiter<bool> taskAwaiter8;
						TaskAwaiter<HttpResponseMessage> taskAwaiter9;
						if (num != 0)
						{
							if (num == 1)
							{
								taskAwaiter8 = taskAwaiter4;
								taskAwaiter4 = default(TaskAwaiter<bool>);
								int num4 = -1;
								num = -1;
								num2 = num4;
								goto IL_13A;
							}
							shopify.class4_0.method_4(Class185.smethod_0(537762437), Class185.smethod_0(537700964), true, false);
							taskAwaiter9 = shopify.class70_0.method_6(shopify.string_0, false).GetAwaiter();
							if (!taskAwaiter9.IsCompleted)
							{
								int num5 = 0;
								num = 0;
								num2 = num5;
								taskAwaiter2 = taskAwaiter9;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Shopify.Struct70>(ref taskAwaiter9, ref this);
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
						HttpResponseMessage result2 = taskAwaiter9.GetResult();
						result = result2;
						taskAwaiter8 = shopify.HandleResponse(result, false).GetAwaiter();
						if (!taskAwaiter8.IsCompleted)
						{
							int num7 = 1;
							num = 1;
							num2 = num7;
							taskAwaiter4 = taskAwaiter8;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Shopify.Struct70>(ref taskAwaiter8, ref this);
							return;
						}
						IL_13A:
						if (!taskAwaiter8.GetResult())
						{
							if (result.smethod_3().ToLower().Contains(Class185.smethod_0(537762473)))
							{
								shopify.class4_0.method_9(true);
								shopify.class4_0.method_0(Class185.smethod_0(537660452), Class185.smethod_0(537700909), false);
							}
							else if (result.smethod_3().Contains(Class185.smethod_0(537762471)))
							{
								shopify.class4_0.method_0(Class185.smethod_0(537660491), Class185.smethod_0(537700909), false);
							}
							else if (result.smethod_3().Contains(Class185.smethod_0(537762510)))
							{
								shopify.class4_0.method_12();
								shopify.class4_0.method_9(false);
								shopify.class4_0.method_0(Class185.smethod_0(537658349), Class185.smethod_0(537658124), false);
							}
							else if (!result.smethod_3().Contains(Class185.smethod_0(537762558)) && !result.smethod_3().Contains(Class185.smethod_0(537762543)))
							{
								if (result.smethod_3().Contains(Class185.smethod_0(537762322)))
								{
									shopify.class4_0.method_0(Class185.smethod_0(537762345), Class185.smethod_0(537700909), false);
								}
								else
								{
									GClass3.smethod_0(result.smethod_3(), Class185.smethod_0(537762390));
									shopify.class4_0.method_0(Class185.smethod_0(537660491), Class185.smethod_0(537700909), false);
								}
							}
							else
							{
								shopify.class4_0.method_0(Class185.smethod_0(537660738), Class185.smethod_0(537700909), false);
							}
							throw new Exception();
						}
						goto IL_360;
					}
					catch (ThreadAbortException)
					{
						goto IL_3A1;
					}
					catch
					{
						num8 = 1;
					}
					if (num8 != 1)
					{
						goto IL_360;
					}
					shopify.class4_0.method_4(Class185.smethod_0(537762416), Class185.smethod_0(537700781), true, false);
					taskAwaiter7 = Task.Delay(GClass0.int_1).GetAwaiter();
					if (!taskAwaiter7.IsCompleted)
					{
						int num9 = 2;
						num = 2;
						num2 = num9;
						taskAwaiter6 = taskAwaiter7;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct70>(ref taskAwaiter7, ref this);
						return;
					}
					IL_359:
					taskAwaiter7.GetResult();
					IL_360:
					num8 = 0;
					goto IL_3D;
				}
				catch (Exception exception)
				{
					num2 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_3A1:
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060007DB RID: 2011 RVA: 0x00006E44 File Offset: 0x00005044
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400058A RID: 1418
			public int int_0;

			// Token: 0x0400058B RID: 1419
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x0400058C RID: 1420
			public Shopify shopify_0;

			// Token: 0x0400058D RID: 1421
			private HttpResponseMessage httpResponseMessage_0;

			// Token: 0x0400058E RID: 1422
			private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

			// Token: 0x0400058F RID: 1423
			private TaskAwaiter<bool> taskAwaiter_1;

			// Token: 0x04000590 RID: 1424
			private TaskAwaiter taskAwaiter_2;
		}

		// Token: 0x02000144 RID: 324
		[StructLayout(LayoutKind.Auto)]
		private struct Struct71 : IAsyncStateMachine
		{
			// Token: 0x060007DC RID: 2012 RVA: 0x0004B574 File Offset: 0x00049774
			void IAsyncStateMachine.MoveNext()
			{
				int num3;
				int num2 = num3;
				Shopify shopify = this;
				try
				{
					TaskAwaiter taskAwaiter7;
					if (num2 > 5)
					{
						if (num2 != 6)
						{
							shopify.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), true, false);
							goto IL_59E;
						}
						taskAwaiter7 = taskAwaiter6;
						taskAwaiter6 = default(TaskAwaiter);
						int num4 = -1;
						num2 = -1;
						num3 = num4;
						goto IL_576;
					}
					IL_5D:
					try
					{
						TaskAwaiter<HttpResponseMessage> taskAwaiter8;
						TaskAwaiter<bool> taskAwaiter9;
						switch (num2)
						{
						case 0:
						{
							taskAwaiter7 = taskAwaiter6;
							taskAwaiter6 = default(TaskAwaiter);
							int num5 = -1;
							num2 = -1;
							num3 = num5;
							goto IL_448;
						}
						case 1:
						{
							taskAwaiter8 = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
							int num6 = -1;
							num2 = -1;
							num3 = num6;
							goto IL_264;
						}
						case 2:
						{
							taskAwaiter9 = taskAwaiter4;
							taskAwaiter4 = default(TaskAwaiter<bool>);
							int num7 = -1;
							num2 = -1;
							num3 = num7;
							goto IL_295;
						}
						case 3:
						{
							taskAwaiter7 = taskAwaiter6;
							taskAwaiter6 = default(TaskAwaiter);
							int num8 = -1;
							num2 = -1;
							num3 = num8;
							goto IL_3CE;
						}
						case 4:
							IL_107:
							try
							{
								if (num2 != 4)
								{
									while (enumerator.MoveNext())
									{
										JToken jtoken = enumerator.Current;
										if (Class172.smethod_2(shopify.string_14, jtoken[Class185.smethod_0(537712450)].ToString()))
										{
											shopify.string_15 = jtoken[Class185.smethod_0(537763723)].ToString();
											if (!object.Equals(false, Convert.ToBoolean(jtoken[Class185.smethod_0(537763770)])))
											{
												goto IL_5F2;
											}
											shopify.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
											taskAwaiter7 = Task.Delay(GClass0.int_0).GetAwaiter();
											if (!taskAwaiter7.IsCompleted)
											{
												int num9 = 4;
												num2 = 4;
												num3 = num9;
												taskAwaiter6 = taskAwaiter7;
												this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct71>(ref taskAwaiter7, ref this);
												return;
											}
											goto IL_215;
										}
									}
									goto IL_404;
								}
								taskAwaiter7 = taskAwaiter6;
								taskAwaiter6 = default(TaskAwaiter);
								int num10 = -1;
								num2 = -1;
								num3 = num10;
								IL_215:
								taskAwaiter7.GetResult();
								goto IL_3F7;
							}
							finally
							{
								if (num2 < 0 && enumerator != null)
								{
									enumerator.Dispose();
								}
							}
							break;
							IL_404:
							enumerator = null;
							goto IL_4C4;
						case 5:
						{
							taskAwaiter7 = taskAwaiter6;
							taskAwaiter6 = default(TaskAwaiter);
							int num11 = -1;
							num2 = -1;
							num3 = num11;
							goto IL_51C;
						}
						default:
							goto IL_3F7;
						}
						IL_239:
						taskAwaiter8 = shopify.class4_0.method_2(shopify.string_13, shopify.bool_5, null).GetAwaiter();
						if (!taskAwaiter8.IsCompleted)
						{
							int num12 = 1;
							num2 = 1;
							num3 = num12;
							taskAwaiter2 = taskAwaiter8;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Shopify.Struct71>(ref taskAwaiter8, ref this);
							return;
						}
						IL_264:
						HttpResponseMessage result = taskAwaiter8.GetResult();
						httpResponseMessage = result;
						taskAwaiter9 = shopify.HandleResponse(httpResponseMessage, true).GetAwaiter();
						if (!taskAwaiter9.IsCompleted)
						{
							int num13 = 2;
							num2 = 2;
							num3 = num13;
							taskAwaiter4 = taskAwaiter9;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Shopify.Struct71>(ref taskAwaiter9, ref this);
							return;
						}
						IL_295:
						taskAwaiter9.GetResult();
						httpResponseMessage.EnsureSuccessStatusCode();
						JToken jtoken2 = httpResponseMessage.smethod_0()[Class185.smethod_0(537761855)].FirstOrDefault(new Func<JToken, bool>(shopify.method_6));
						if (jtoken2 == null)
						{
							goto IL_4C4;
						}
						shopify.string_10 = jtoken2[Class185.smethod_0(537762143)].ToString();
						shopify.class4_0.method_7(jtoken2[Class185.smethod_0(537712450)].ToString(), Class185.smethod_0(537700781));
						Class4 class4_ = shopify.class4_0;
						JToken jtoken3 = jtoken2[Class185.smethod_0(537761898)];
						class4_.string_1 = ((jtoken3 != null) ? jtoken3.ToString() : null);
						if (!shopify.bool_3)
						{
							enumerator = ((IEnumerable<JToken>)jtoken2[Class185.smethod_0(537763742)]).GetEnumerator();
							goto IL_107;
						}
						if (shopify.GetRandomSize(jtoken2[Class185.smethod_0(537763742)], out shopify.string_15, Class185.smethod_0(537712450), Class185.smethod_0(537763723), Class185.smethod_0(537763770)))
						{
							goto IL_5F2;
						}
						shopify.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
						taskAwaiter7 = Task.Delay(GClass0.int_0).GetAwaiter();
						if (!taskAwaiter7.IsCompleted)
						{
							int num14 = 3;
							num2 = 3;
							num3 = num14;
							taskAwaiter6 = taskAwaiter7;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct71>(ref taskAwaiter7, ref this);
							return;
						}
						IL_3CE:
						taskAwaiter7.GetResult();
						IL_3F7:
						if (!shopify.CheckMassLinkChange())
						{
							goto IL_239;
						}
						taskAwaiter7 = shopify.ScrapeProduct().GetAwaiter();
						if (!taskAwaiter7.IsCompleted)
						{
							int num15 = 0;
							num2 = 0;
							num3 = num15;
							taskAwaiter6 = taskAwaiter7;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct71>(ref taskAwaiter7, ref this);
							return;
						}
						IL_448:
						taskAwaiter7.GetResult();
						goto IL_5F2;
						IL_4C4:
						taskAwaiter7 = Task.Delay(GClass0.int_0).GetAwaiter();
						if (!taskAwaiter7.IsCompleted)
						{
							int num16 = 5;
							num2 = 5;
							num3 = num16;
							taskAwaiter6 = taskAwaiter7;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct71>(ref taskAwaiter7, ref this);
							return;
						}
						IL_51C:
						taskAwaiter7.GetResult();
						shopify.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), false, false);
						httpResponseMessage = null;
						goto IL_5AA;
					}
					catch (ThreadAbortException)
					{
						goto IL_5F2;
					}
					catch
					{
						num = 1;
						goto IL_5AA;
					}
					IL_55D:
					taskAwaiter7 = Task.Delay(GClass0.int_0).GetAwaiter();
					if (taskAwaiter7.IsCompleted)
					{
						goto IL_576;
					}
					int num17 = 6;
					num2 = 6;
					num3 = num17;
					taskAwaiter6 = taskAwaiter7;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct71>(ref taskAwaiter7, ref this);
					return;
					IL_5AA:
					int num18 = num;
					if (num18 == 1)
					{
						goto IL_55D;
					}
					goto IL_59E;
					IL_576:
					taskAwaiter7.GetResult();
					shopify.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), false, false);
					IL_59E:
					num = 0;
					goto IL_5D;
				}
				catch (Exception exception)
				{
					num3 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_5F2:
				num3 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060007DD RID: 2013 RVA: 0x00006E52 File Offset: 0x00005052
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04000591 RID: 1425
			public int int_0;

			// Token: 0x04000592 RID: 1426
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04000593 RID: 1427
			public Shopify shopify_0;

			// Token: 0x04000594 RID: 1428
			private int int_1;

			// Token: 0x04000595 RID: 1429
			private HttpResponseMessage httpResponseMessage_0;

			// Token: 0x04000596 RID: 1430
			private TaskAwaiter taskAwaiter_0;

			// Token: 0x04000597 RID: 1431
			private TaskAwaiter<HttpResponseMessage> taskAwaiter_1;

			// Token: 0x04000598 RID: 1432
			private TaskAwaiter<bool> taskAwaiter_2;

			// Token: 0x04000599 RID: 1433
			private IEnumerator<JToken> ienumerator_0;
		}

		// Token: 0x02000145 RID: 325
		[StructLayout(LayoutKind.Auto)]
		private struct Struct72 : IAsyncStateMachine
		{
			// Token: 0x060007DE RID: 2014 RVA: 0x0004BBEC File Offset: 0x00049DEC
			void IAsyncStateMachine.MoveNext()
			{
				int num2;
				int num = num2;
				Shopify shopify = this;
				try
				{
					TaskAwaiter taskAwaiter7;
					if (num > 3)
					{
						if (num != 4)
						{
							goto IL_4B1;
						}
						taskAwaiter7 = taskAwaiter6;
						taskAwaiter6 = default(TaskAwaiter);
						int num3 = -1;
						num = -1;
						num2 = num3;
						goto IL_4AA;
					}
					IL_3C:
					int num12;
					try
					{
						TaskAwaiter<HttpResponseMessage> taskAwaiter8;
						TaskAwaiter<bool> taskAwaiter9;
						switch (num)
						{
						case 0:
						{
							taskAwaiter8 = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
							int num4 = -1;
							num = -1;
							num2 = num4;
							goto IL_1F2;
						}
						case 1:
						{
							taskAwaiter9 = taskAwaiter4;
							taskAwaiter4 = default(TaskAwaiter<bool>);
							int num5 = -1;
							num = -1;
							num2 = num5;
							goto IL_223;
						}
						case 2:
						{
							taskAwaiter7 = taskAwaiter6;
							taskAwaiter6 = default(TaskAwaiter);
							int num6 = -1;
							num = -1;
							num2 = num6;
							goto IL_2BB;
						}
						case 3:
						{
							taskAwaiter7 = taskAwaiter6;
							taskAwaiter6 = default(TaskAwaiter);
							int num7 = -1;
							num = -1;
							num2 = num7;
							goto IL_2E1;
						}
						}
						IL_DE:
						shopify.class4_0.method_4(Class185.smethod_0(537663094), Class185.smethod_0(537662875), true, false);
						JObject jobject = new JObject(new JProperty(Class185.smethod_0(537681978), new JObject(new JProperty(Class185.smethod_0(537681961), new JArray(new JObject())))));
						jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537681961)][0][Class185.smethod_0(537662856)] = shopify.string_15;
						jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537681961)][0][Class185.smethod_0(537662905)] = 1;
						jobject = shopify.AddProperties(jobject);
						taskAwaiter8 = shopify.class70_0.method_13(shopify.string_0 + Class185.smethod_0(537662977), jobject, false).GetAwaiter();
						if (!taskAwaiter8.IsCompleted)
						{
							int num8 = 0;
							num = 0;
							num2 = num8;
							taskAwaiter2 = taskAwaiter8;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Shopify.Struct72>(ref taskAwaiter8, ref this);
							return;
						}
						IL_1F2:
						HttpResponseMessage result2 = taskAwaiter8.GetResult();
						result = result2;
						taskAwaiter9 = shopify.HandleResponse(result, false).GetAwaiter();
						if (!taskAwaiter9.IsCompleted)
						{
							int num9 = 1;
							num = 1;
							num2 = num9;
							taskAwaiter4 = taskAwaiter9;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Shopify.Struct72>(ref taskAwaiter9, ref this);
							return;
						}
						IL_223:
						if (taskAwaiter9.GetResult())
						{
							goto IL_4B1;
						}
						if (!result.smethod_3().Contains(Class185.smethod_0(537682010)) && result.smethod_0()[Class185.smethod_0(537681978)][Class185.smethod_0(537681961)].Any<JToken>())
						{
							if (result.smethod_0()[Class185.smethod_0(537681978)][Class185.smethod_0(537681988)].Any<JToken>())
							{
								shopify.string_12 = result.smethod_0()[Class185.smethod_0(537681978)][Class185.smethod_0(537681988)][0][Class185.smethod_0(537703519)].ToString();
							}
							shopify.string_9 = result.smethod_0()[Class185.smethod_0(537681978)][Class185.smethod_0(537682019)].ToString();
							shopify.class4_0.method_4(Class185.smethod_0(537662950), Class185.smethod_0(537700781), true, false);
							shopify.bool_0 = true;
							goto IL_4F2;
						}
						shopify.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
						taskAwaiter7 = Task.Delay(GClass0.int_0).GetAwaiter();
						if (!taskAwaiter7.IsCompleted)
						{
							int num10 = 2;
							num = 2;
							num2 = num10;
							taskAwaiter6 = taskAwaiter7;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct72>(ref taskAwaiter7, ref this);
							return;
						}
						IL_2BB:
						taskAwaiter7.GetResult();
						shopify.bool_5 = false;
						taskAwaiter7 = shopify.FindProduct().GetAwaiter();
						if (!taskAwaiter7.IsCompleted)
						{
							int num11 = 3;
							num = 3;
							num2 = num11;
							taskAwaiter6 = taskAwaiter7;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct72>(ref taskAwaiter7, ref this);
							return;
						}
						IL_2E1:
						taskAwaiter7.GetResult();
						goto IL_DE;
					}
					catch (ThreadAbortException)
					{
						goto IL_4F2;
					}
					catch
					{
						num12 = 1;
					}
					if (num12 != 1)
					{
						goto IL_4B1;
					}
					shopify.class4_0.method_4(Class185.smethod_0(537662720), Class185.smethod_0(537700781), true, false);
					taskAwaiter7 = Task.Delay(GClass0.int_1).GetAwaiter();
					if (!taskAwaiter7.IsCompleted)
					{
						int num13 = 4;
						num = 4;
						num2 = num13;
						taskAwaiter6 = taskAwaiter7;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct72>(ref taskAwaiter7, ref this);
						return;
					}
					IL_4AA:
					taskAwaiter7.GetResult();
					IL_4B1:
					num12 = 0;
					goto IL_3C;
				}
				catch (Exception exception)
				{
					num2 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_4F2:
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060007DF RID: 2015 RVA: 0x00006E60 File Offset: 0x00005060
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400059A RID: 1434
			public int int_0;

			// Token: 0x0400059B RID: 1435
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x0400059C RID: 1436
			public Shopify shopify_0;

			// Token: 0x0400059D RID: 1437
			private HttpResponseMessage httpResponseMessage_0;

			// Token: 0x0400059E RID: 1438
			private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

			// Token: 0x0400059F RID: 1439
			private TaskAwaiter<bool> taskAwaiter_1;

			// Token: 0x040005A0 RID: 1440
			private TaskAwaiter taskAwaiter_2;
		}

		// Token: 0x02000146 RID: 326
		[StructLayout(LayoutKind.Auto)]
		private struct Struct73 : IAsyncStateMachine
		{
			// Token: 0x060007E0 RID: 2016 RVA: 0x0004C14C File Offset: 0x0004A34C
			void IAsyncStateMachine.MoveNext()
			{
				int num2;
				int num = num2;
				Shopify shopify = this;
				try
				{
					if (num == 0)
					{
						goto IL_1AE;
					}
					TaskAwaiter taskAwaiter3;
					if (num != 1)
					{
						if (!shopify.bool_2)
						{
							goto IL_1EE;
						}
						goto IL_1AC;
					}
					else
					{
						taskAwaiter3 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						int num3 = -1;
						num = -1;
						num2 = num3;
					}
					IL_1A5:
					taskAwaiter3.GetResult();
					IL_1AC:
					int num4 = 0;
					IL_1AE:
					try
					{
						TaskAwaiter<HttpResponseMessage> taskAwaiter4;
						if (num != 0)
						{
							shopify.class4_0.method_4(Class185.smethod_0(537670109), Class185.smethod_0(537700781), true, false);
							taskAwaiter4 = new Class70(shopify.string_11, Class185.smethod_0(537692910), 10, false, true, null, true).method_6(string.Format(Class185.smethod_0(537683241), shopify.string_1, shopify.string_15), false).GetAwaiter();
							if (!taskAwaiter4.IsCompleted)
							{
								int num5 = 0;
								num = 0;
								num2 = num5;
								TaskAwaiter<HttpResponseMessage> taskAwaiter5 = taskAwaiter4;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Shopify.Struct73>(ref taskAwaiter4, ref this);
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
						shopify.string_6 = htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537683280)).Attributes[Class185.smethod_0(537711408)].Value;
						goto IL_1EE;
					}
					catch (ThreadAbortException)
					{
						goto IL_1EE;
					}
					catch
					{
						num4 = 1;
					}
					if (num4 != 1)
					{
						goto IL_1AC;
					}
					shopify.class4_0.method_4(Class185.smethod_0(537669957), Class185.smethod_0(537700781), true, false);
					taskAwaiter3 = Task.Delay(GClass0.int_1).GetAwaiter();
					if (taskAwaiter3.IsCompleted)
					{
						goto IL_1A5;
					}
					int num7 = 1;
					num = 1;
					num2 = num7;
					taskAwaiter2 = taskAwaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct73>(ref taskAwaiter3, ref this);
					return;
				}
				catch (Exception exception)
				{
					num2 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_1EE:
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060007E1 RID: 2017 RVA: 0x00006E6E File Offset: 0x0000506E
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040005A1 RID: 1441
			public int int_0;

			// Token: 0x040005A2 RID: 1442
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040005A3 RID: 1443
			public Shopify shopify_0;

			// Token: 0x040005A4 RID: 1444
			private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

			// Token: 0x040005A5 RID: 1445
			private TaskAwaiter taskAwaiter_1;
		}

		// Token: 0x02000147 RID: 327
		[StructLayout(LayoutKind.Auto)]
		private struct Struct74 : IAsyncStateMachine
		{
			// Token: 0x060007E2 RID: 2018 RVA: 0x0004C3A8 File Offset: 0x0004A5A8
			void IAsyncStateMachine.MoveNext()
			{
				int num3;
				int num2 = num3;
				Shopify shopify = this;
				try
				{
					TaskAwaiter taskAwaiter5;
					if (num2 > 3)
					{
						if (num2 != 4)
						{
							shopify.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), true, false);
							goto IL_3A2;
						}
						taskAwaiter5 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						int num4 = -1;
						num2 = -1;
						num3 = num4;
						goto IL_37A;
					}
					IL_5D:
					try
					{
						TaskAwaiter<HttpResponseMessage> taskAwaiter6;
						TaskAwaiter<bool> taskAwaiter7;
						switch (num2)
						{
						case 0:
						{
							taskAwaiter5 = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter);
							int num5 = -1;
							num2 = -1;
							num3 = num5;
							break;
						}
						case 1:
						{
							taskAwaiter6 = taskAwaiter4;
							taskAwaiter4 = default(TaskAwaiter<HttpResponseMessage>);
							int num6 = -1;
							num2 = -1;
							num3 = num6;
							goto IL_148;
						}
						case 2:
						{
							TaskAwaiter<bool> taskAwaiter8;
							taskAwaiter7 = taskAwaiter8;
							taskAwaiter8 = default(TaskAwaiter<bool>);
							int num7 = -1;
							num2 = -1;
							num3 = num7;
							goto IL_1B7;
						}
						case 3:
						{
							taskAwaiter5 = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter);
							int num8 = -1;
							num2 = -1;
							num3 = num8;
							goto IL_320;
						}
						default:
							if (shopify.CheckMassLinkChange())
							{
								taskAwaiter5 = shopify.ScrapeProduct().GetAwaiter();
								if (!taskAwaiter5.IsCompleted)
								{
									int num9 = 0;
									num2 = 0;
									num3 = num9;
									taskAwaiter2 = taskAwaiter5;
									this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct74>(ref taskAwaiter5, ref this);
									return;
								}
							}
							else
							{
								taskAwaiter6 = shopify.class4_0.method_2(shopify.string_13, shopify.bool_5, null).GetAwaiter();
								if (!taskAwaiter6.IsCompleted)
								{
									int num10 = 1;
									num2 = 1;
									num3 = num10;
									taskAwaiter4 = taskAwaiter6;
									this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Shopify.Struct74>(ref taskAwaiter6, ref this);
									return;
								}
								goto IL_148;
							}
							break;
						}
						taskAwaiter5.GetResult();
						goto IL_3F6;
						IL_148:
						HttpResponseMessage result = taskAwaiter6.GetResult();
						httpResponseMessage = result;
						taskAwaiter7 = shopify.HandleResponse(httpResponseMessage, true).GetAwaiter();
						if (!taskAwaiter7.IsCompleted)
						{
							int num11 = 2;
							num2 = 2;
							num3 = num11;
							TaskAwaiter<bool> taskAwaiter8 = taskAwaiter7;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Shopify.Struct74>(ref taskAwaiter7, ref this);
							return;
						}
						IL_1B7:
						taskAwaiter7.GetResult();
						httpResponseMessage.EnsureSuccessStatusCode();
						XmlDocument xmlDocument = new XmlDocument();
						xmlDocument.LoadXml(httpResponseMessage.smethod_3());
						IEnumerator enumerator = xmlDocument.GetElementsByTagName(Class185.smethod_0(537762222)).GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								object obj = enumerator.Current;
								XmlNode xmlNode = (XmlNode)obj;
								if (shopify.string_8.All(new Func<string, bool>(xmlNode[Class185.smethod_0(537712450)].InnerText.ToLower().Contains)) && !shopify.string_5.Any(new Func<string, bool>(xmlNode[Class185.smethod_0(537712450)].InnerText.ToLower().Contains)))
								{
									shopify.uri_0 = new Uri(xmlNode[Class185.smethod_0(537762266)].Attributes[Class185.smethod_0(537669937)].Value);
									goto IL_3F6;
								}
							}
						}
						finally
						{
							if (num2 < 0)
							{
								IDisposable disposable = enumerator as IDisposable;
								if (disposable != null)
								{
									disposable.Dispose();
								}
							}
						}
						taskAwaiter5 = Task.Delay(GClass0.int_0).GetAwaiter();
						if (!taskAwaiter5.IsCompleted)
						{
							int num12 = 3;
							num2 = 3;
							num3 = num12;
							taskAwaiter2 = taskAwaiter5;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct74>(ref taskAwaiter5, ref this);
							return;
						}
						IL_320:
						taskAwaiter5.GetResult();
						shopify.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), false, false);
						httpResponseMessage = null;
						goto IL_3AE;
					}
					catch (ThreadAbortException)
					{
						goto IL_3F6;
					}
					catch
					{
						num = 1;
						goto IL_3AE;
					}
					IL_361:
					taskAwaiter5 = Task.Delay(GClass0.int_0).GetAwaiter();
					if (taskAwaiter5.IsCompleted)
					{
						goto IL_37A;
					}
					int num13 = 4;
					num2 = 4;
					num3 = num13;
					taskAwaiter2 = taskAwaiter5;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct74>(ref taskAwaiter5, ref this);
					return;
					IL_3AE:
					int num14 = num;
					if (num14 == 1)
					{
						goto IL_361;
					}
					goto IL_3A2;
					IL_37A:
					taskAwaiter5.GetResult();
					shopify.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), false, false);
					IL_3A2:
					num = 0;
					goto IL_5D;
				}
				catch (Exception exception)
				{
					num3 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_3F6:
				num3 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060007E3 RID: 2019 RVA: 0x00006E7C File Offset: 0x0000507C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040005A6 RID: 1446
			public int int_0;

			// Token: 0x040005A7 RID: 1447
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040005A8 RID: 1448
			public Shopify shopify_0;

			// Token: 0x040005A9 RID: 1449
			private int int_1;

			// Token: 0x040005AA RID: 1450
			private HttpResponseMessage httpResponseMessage_0;

			// Token: 0x040005AB RID: 1451
			private TaskAwaiter taskAwaiter_0;

			// Token: 0x040005AC RID: 1452
			private TaskAwaiter<HttpResponseMessage> taskAwaiter_1;

			// Token: 0x040005AD RID: 1453
			private TaskAwaiter<bool> taskAwaiter_2;
		}

		// Token: 0x02000148 RID: 328
		[StructLayout(LayoutKind.Auto)]
		private struct Struct75 : IAsyncStateMachine
		{
			// Token: 0x060007E4 RID: 2020 RVA: 0x0004C824 File Offset: 0x0004AA24
			void IAsyncStateMachine.MoveNext()
			{
				int num2;
				int num = num2;
				Shopify shopify = this;
				try
				{
					TaskAwaiter taskAwaiter7;
					if (num > 4)
					{
						if (num != 5)
						{
							JObject jobject6 = new JObject();
							jobject6[Class185.smethod_0(537763806)] = Class185.smethod_0(537713814);
							string propertyName = Class185.smethod_0(537681978);
							JObject jobject7 = new JObject();
							string propertyName2 = Class185.smethod_0(537763789);
							JObject jobject8 = new JObject();
							jobject8[Class185.smethod_0(537703519)] = shopify.string_12;
							jobject7[propertyName2] = jobject8;
							jobject6[propertyName] = jobject7;
							jobject6[Class185.smethod_0(537763825)] = shopify.string_7;
							jobject4 = jobject6;
							if (shopify.bool_2)
							{
								jobject4[Class185.smethod_0(537681978)][Class185.smethod_0(537763817)] = shopify.string_6;
							}
							shopify.string_16 = null;
							i = 0;
							goto IL_66B;
						}
						taskAwaiter7 = taskAwaiter6;
						taskAwaiter6 = default(TaskAwaiter);
						int num3 = -1;
						num = -1;
						num2 = num3;
						goto IL_662;
					}
					IL_111:
					int num14;
					try
					{
						TaskAwaiter<HttpResponseMessage> taskAwaiter8;
						TaskAwaiter<bool> taskAwaiter10;
						TaskAwaiter<string> taskAwaiter11;
						switch (num)
						{
						case 0:
						{
							TaskAwaiter<HttpResponseMessage> taskAwaiter9;
							taskAwaiter8 = taskAwaiter9;
							taskAwaiter9 = default(TaskAwaiter<HttpResponseMessage>);
							int num4 = -1;
							num = -1;
							num2 = num4;
							break;
						}
						case 1:
						{
							taskAwaiter10 = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter<bool>);
							int num5 = -1;
							num = -1;
							num2 = num5;
							goto IL_292;
						}
						case 2:
						{
							taskAwaiter11 = taskAwaiter4;
							taskAwaiter4 = default(TaskAwaiter<string>);
							int num6 = -1;
							num = -1;
							num2 = num6;
							goto IL_59B;
						}
						case 3:
						{
							taskAwaiter7 = taskAwaiter6;
							taskAwaiter6 = default(TaskAwaiter);
							int num7 = -1;
							num = -1;
							num2 = num7;
							goto IL_5E8;
						}
						case 4:
						{
							taskAwaiter7 = taskAwaiter6;
							taskAwaiter6 = default(TaskAwaiter);
							int num8 = -1;
							num = -1;
							num2 = num8;
							goto IL_610;
						}
						default:
							shopify.class4_0.method_4(Class185.smethod_0(537658294), Class185.smethod_0(537700964), true, false);
							taskAwaiter8 = shopify.class70_0.method_13(shopify.string_4, jobject4, false).GetAwaiter();
							if (!taskAwaiter8.IsCompleted)
							{
								int num9 = 0;
								num = 0;
								num2 = num9;
								TaskAwaiter<HttpResponseMessage> taskAwaiter9 = taskAwaiter8;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Shopify.Struct75>(ref taskAwaiter8, ref this);
								return;
							}
							break;
						}
						HttpResponseMessage result = taskAwaiter8.GetResult();
						httpResponseMessage = result;
						if (!httpResponseMessage.IsSuccessStatusCode && httpResponseMessage.StatusCode != HttpStatusCode.Found)
						{
							httpResponseMessage.EnsureSuccessStatusCode();
						}
						jobject4.Remove(Class185.smethod_0(537763825));
						jobject4.Remove(Class185.smethod_0(537676185));
						jobject4.Remove(Class185.smethod_0(537681978));
						taskAwaiter10 = shopify.HandleResponse(httpResponseMessage, false).GetAwaiter();
						if (!taskAwaiter10.IsCompleted)
						{
							int num10 = 1;
							num = 1;
							num2 = num10;
							taskAwaiter2 = taskAwaiter10;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Shopify.Struct75>(ref taskAwaiter10, ref this);
							return;
						}
						IL_292:
						if (taskAwaiter10.GetResult())
						{
							goto IL_67B;
						}
						if (!httpResponseMessage.smethod_3().ToLower().Contains(Class185.smethod_0(537763812)))
						{
							if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537763588)))
							{
								shopify.class4_0.method_0(Class185.smethod_0(537762345), Class185.smethod_0(537700909), false);
							}
							else if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537762676)) && httpResponseMessage.StatusCode == HttpStatusCode.Found)
							{
								shopify.class4_0.method_0(Class185.smethod_0(537763625), Class185.smethod_0(537700909), false);
							}
							else if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537763678)))
							{
								shopify.class4_0.method_4(Class185.smethod_0(537763678), Class185.smethod_0(537700964), true, false);
								taskAwaiter7 = Task.Delay(500).GetAwaiter();
								if (!taskAwaiter7.IsCompleted)
								{
									int num11 = 3;
									num = 3;
									num2 = num11;
									taskAwaiter6 = taskAwaiter7;
									this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct75>(ref taskAwaiter7, ref this);
									return;
								}
								goto IL_5E8;
							}
							else if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537763654)))
							{
								shopify.class4_0.method_0(Class185.smethod_0(537763476), Class185.smethod_0(537700909), false);
							}
							else if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537763509)))
							{
								shopify.class4_0.method_0(Class185.smethod_0(537763532), Class185.smethod_0(537700909), false);
							}
							else if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537763574)))
							{
								shopify.class4_0.method_0(Class185.smethod_0(537763385), Class185.smethod_0(537700909), false);
							}
							else if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537763363)))
							{
								taskAwaiter7 = Task.Delay(GClass0.int_1).GetAwaiter();
								if (!taskAwaiter7.IsCompleted)
								{
									int num12 = 4;
									num = 4;
									num2 = num12;
									taskAwaiter6 = taskAwaiter7;
									this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct75>(ref taskAwaiter7, ref this);
									return;
								}
								goto IL_610;
							}
							else if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537763429)))
							{
								goto IL_6E8;
							}
							GClass3.smethod_0(httpResponseMessage.smethod_3(), Class185.smethod_0(537763223));
							throw new Exception();
						}
						shopify.bool_6 = true;
						jobject5 = jobject4;
						taskAwaiter11 = shopify.GetCaptcha().GetAwaiter();
						if (!taskAwaiter11.IsCompleted)
						{
							int num13 = 2;
							num = 2;
							num2 = num13;
							taskAwaiter4 = taskAwaiter11;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Shopify.Struct75>(ref taskAwaiter11, ref this);
							return;
						}
						IL_59B:
						string result2 = taskAwaiter11.GetResult();
						jobject5[Class185.smethod_0(537676185)] = result2;
						jobject5 = null;
						goto IL_67B;
						IL_5E8:
						taskAwaiter7.GetResult();
						goto IL_67B;
						IL_610:
						taskAwaiter7.GetResult();
						goto IL_67B;
					}
					catch (ThreadAbortException)
					{
						goto IL_6E8;
					}
					catch
					{
						num14 = 1;
					}
					if (num14 != 1)
					{
						goto IL_67B;
					}
					shopify.class4_0.method_4(Class185.smethod_0(537658168), Class185.smethod_0(537700781), true, false);
					taskAwaiter7 = Task.Delay(GClass0.int_1).GetAwaiter();
					if (!taskAwaiter7.IsCompleted)
					{
						int num15 = 5;
						num = 5;
						num2 = num15;
						taskAwaiter6 = taskAwaiter7;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct75>(ref taskAwaiter7, ref this);
						return;
					}
					IL_662:
					taskAwaiter7.GetResult();
					goto IL_67B;
					IL_66B:
					if (i < 5)
					{
						num14 = 0;
						goto IL_111;
					}
					shopify.class4_0.method_0(Class185.smethod_0(537660491), Class185.smethod_0(537700909), false);
					goto IL_6E8;
					IL_67B:
					num14 = i;
					i = num14 + 1;
					goto IL_66B;
				}
				catch (Exception exception)
				{
					num2 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_6E8:
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060007E5 RID: 2021 RVA: 0x00006E8A File Offset: 0x0000508A
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040005AE RID: 1454
			public int int_0;

			// Token: 0x040005AF RID: 1455
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040005B0 RID: 1456
			public Shopify shopify_0;

			// Token: 0x040005B1 RID: 1457
			private JObject jobject_0;

			// Token: 0x040005B2 RID: 1458
			private int int_1;

			// Token: 0x040005B3 RID: 1459
			private HttpResponseMessage httpResponseMessage_0;

			// Token: 0x040005B4 RID: 1460
			private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

			// Token: 0x040005B5 RID: 1461
			private TaskAwaiter<bool> taskAwaiter_1;

			// Token: 0x040005B6 RID: 1462
			private JObject jobject_1;

			// Token: 0x040005B7 RID: 1463
			private TaskAwaiter<string> taskAwaiter_2;

			// Token: 0x040005B8 RID: 1464
			private TaskAwaiter taskAwaiter_3;
		}

		// Token: 0x02000149 RID: 329
		private static class Class214
		{
			// Token: 0x040005B9 RID: 1465
			public static CallSite<Func<CallSite, object, string, object>> callSite_0;

			// Token: 0x040005BA RID: 1466
			public static CallSite<Func<CallSite, object, object>> callSite_1;

			// Token: 0x040005BB RID: 1467
			public static CallSite<Action<CallSite, Class4, object>> callSite_2;

			// Token: 0x040005BC RID: 1468
			public static CallSite<Func<CallSite, object, string, object>> callSite_3;

			// Token: 0x040005BD RID: 1469
			public static CallSite<Func<CallSite, object, object>> callSite_4;

			// Token: 0x040005BE RID: 1470
			public static CallSite<Func<CallSite, object, string>> callSite_5;

			// Token: 0x040005BF RID: 1471
			public static CallSite<Func<CallSite, object, string, object>> callSite_6;

			// Token: 0x040005C0 RID: 1472
			public static CallSite<Delegate0<CallSite, Shopify, object, string, object>> callSite_7;

			// Token: 0x040005C1 RID: 1473
			public static CallSite<Func<CallSite, object, object>> callSite_8;

			// Token: 0x040005C2 RID: 1474
			public static CallSite<Func<CallSite, object, bool>> callSite_9;

			// Token: 0x040005C3 RID: 1475
			public static CallSite<Func<CallSite, object, JToken>> callSite_10;
		}

		// Token: 0x0200014A RID: 330
		[StructLayout(LayoutKind.Auto)]
		private struct Struct76 : IAsyncStateMachine
		{
			// Token: 0x060007E6 RID: 2022 RVA: 0x0004CF78 File Offset: 0x0004B178
			void IAsyncStateMachine.MoveNext()
			{
				int num2;
				int num = num2;
				Shopify shopify = this;
				try
				{
					TaskAwaiter taskAwaiter5;
					if (num > 2)
					{
						if (num == 3)
						{
							taskAwaiter5 = taskAwaiter4;
							taskAwaiter4 = default(TaskAwaiter);
							int num3 = -1;
							num = -1;
							num2 = num3;
							goto IL_F38;
						}
						if (shopify.string_15 != null)
						{
							variant = shopify.string_15;
							goto IL_F3F;
						}
						goto IL_F3F;
					}
					IL_54:
					int num10;
					try
					{
						TaskAwaiter<HttpResponseMessage> taskAwaiter6;
						TaskAwaiter<bool> taskAwaiter8;
						switch (num)
						{
						case 0:
						{
							TaskAwaiter<HttpResponseMessage> taskAwaiter7;
							taskAwaiter6 = taskAwaiter7;
							taskAwaiter7 = default(TaskAwaiter<HttpResponseMessage>);
							int num4 = -1;
							num = -1;
							num2 = num4;
							break;
						}
						case 1:
						{
							taskAwaiter8 = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter<bool>);
							int num5 = -1;
							num = -1;
							num2 = num5;
							goto IL_BCB;
						}
						case 2:
						{
							TaskAwaiter<HttpResponseMessage> taskAwaiter7;
							taskAwaiter6 = taskAwaiter7;
							taskAwaiter7 = default(TaskAwaiter<HttpResponseMessage>);
							int num6 = -1;
							num = -1;
							num2 = num6;
							goto IL_C6B;
						}
						default:
						{
							shopify.string_4 = null;
							shopify.class4_0.method_4(Class185.smethod_0(537683485), Class185.smethod_0(537700781), true, false);
							if (shopify.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)].ToString().ToLower().Contains(Class185.smethod_0(537721762)))
							{
								shopify.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)] = shopify.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660290)].ToString();
							}
							if (shopify.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660385)].ToString().ToLower().Contains(Class185.smethod_0(537721762)))
							{
								shopify.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660385)] = shopify.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660290)].ToString();
							}
							JObject jobject = new JObject();
							jobject[Class185.smethod_0(537681978)] = new JObject();
							jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537662792)] = shopify.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537662792)];
							jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682186)] = new JObject();
							jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682186)][Class185.smethod_0(537662508)] = (string)shopify.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662508)];
							jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682186)][Class185.smethod_0(537662540)] = (string)shopify.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662540)];
							jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682186)][Class185.smethod_0(537662588)] = (string)shopify.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662571)];
							jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682186)][Class185.smethod_0(537662567)] = (string)shopify.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660310)];
							jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682186)][Class185.smethod_0(537660290)] = (string)shopify.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660290)];
							jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682186)][Class185.smethod_0(537660334)] = (string)shopify.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)];
							jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682186)][Class185.smethod_0(537683515)] = (string)shopify.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)];
							jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682186)][Class185.smethod_0(537660385)] = (string)shopify.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)];
							jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682186)][Class185.smethod_0(537660362)] = (string)shopify.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660362)];
							jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682186)][Class185.smethod_0(537660356)] = (string)shopify.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)];
							jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682418)] = new JObject();
							jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682418)][Class185.smethod_0(537662508)] = (string)shopify.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662508)];
							jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682418)][Class185.smethod_0(537662540)] = (string)shopify.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662540)];
							jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682418)][Class185.smethod_0(537662588)] = (string)shopify.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662571)];
							jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682418)][Class185.smethod_0(537662567)] = (string)shopify.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660310)];
							jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682418)][Class185.smethod_0(537660290)] = (string)shopify.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660290)];
							jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682418)][Class185.smethod_0(537660334)] = (string)shopify.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)];
							jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682418)][Class185.smethod_0(537683515)] = (string)shopify.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660385)];
							jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682418)][Class185.smethod_0(537660385)] = (string)shopify.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660385)];
							jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682418)][Class185.smethod_0(537660362)] = (string)shopify.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660362)];
							jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537682418)][Class185.smethod_0(537660356)] = (string)shopify.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)];
							if (Shopify.Class213.callSite_1 == null)
							{
								Shopify.Class213.callSite_1 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Shopify), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, object, bool> target = Shopify.Class213.callSite_1.Target;
							CallSite callSite_ = Shopify.Class213.callSite_1;
							if (Shopify.Class213.callSite_0 == null)
							{
								Shopify.Class213.callSite_0 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof(Shopify), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
								}));
							}
							if (target(callSite_, Shopify.Class213.callSite_0.Target(Shopify.Class213.callSite_0, variant, null)))
							{
								shopify.class4_0.method_4(Class185.smethod_0(537663094), Class185.smethod_0(537662875), true, false);
								JObject jobject2 = new JObject();
								JObject jobject3 = jobject2;
								string propertyName = Class185.smethod_0(537662856);
								if (Shopify.Class213.callSite_2 == null)
								{
									Shopify.Class213.callSite_2 = CallSite<Func<CallSite, object, JToken>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(JToken), typeof(Shopify)));
								}
								jobject3[propertyName] = Shopify.Class213.callSite_2.Target(Shopify.Class213.callSite_2, variant);
								jobject2[Class185.smethod_0(537662905)] = 1;
								jobject[Class185.smethod_0(537681978)][Class185.smethod_0(537681961)] = new JArray(jobject2);
								shopify.bool_0 = true;
							}
							taskAwaiter6 = shopify.class70_0.method_10(shopify.string_1 + Class185.smethod_0(537683498), jobject).GetAwaiter();
							if (!taskAwaiter6.IsCompleted)
							{
								int num7 = 0;
								num = 0;
								num2 = num7;
								TaskAwaiter<HttpResponseMessage> taskAwaiter7 = taskAwaiter6;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Shopify.Struct76>(ref taskAwaiter6, ref this);
								return;
							}
							break;
						}
						}
						HttpResponseMessage result = taskAwaiter6.GetResult();
						httpResponseMessage = result;
						taskAwaiter8 = shopify.HandleResponse(httpResponseMessage, false).GetAwaiter();
						if (!taskAwaiter8.IsCompleted)
						{
							int num8 = 1;
							num = 1;
							num2 = num8;
							taskAwaiter2 = taskAwaiter8;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Shopify.Struct76>(ref taskAwaiter8, ref this);
							return;
						}
						IL_BCB:
						if (taskAwaiter8.GetResult())
						{
							goto IL_F3F;
						}
						if (!httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537683540)))
						{
							goto IL_C7C;
						}
						taskAwaiter6 = shopify.QueueWait(httpResponseMessage.Headers.GetValues(Class185.smethod_0(537686380)).First<string>()).GetAwaiter();
						if (!taskAwaiter6.IsCompleted)
						{
							int num9 = 2;
							num = 2;
							num2 = num9;
							TaskAwaiter<HttpResponseMessage> taskAwaiter7 = taskAwaiter6;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Shopify.Struct76>(ref taskAwaiter6, ref this);
							return;
						}
						IL_C6B:
						result = taskAwaiter6.GetResult();
						httpResponseMessage = result;
						IL_C7C:
						JObject jobject4 = httpResponseMessage.smethod_0();
						if (jobject4.ContainsKey(Class185.smethod_0(537683577)))
						{
							JToken jtoken = jobject4[Class185.smethod_0(537683577)][Class185.smethod_0(537681978)];
							if (jtoken[Class185.smethod_0(537681961)] != null)
							{
								if (jtoken[Class185.smethod_0(537681961)].ToString().Contains(Class185.smethod_0(537682010)))
								{
									variant = null;
									shopify.bool_0 = false;
									goto IL_F3F;
								}
								shopify.class4_0.method_0(Class185.smethod_0(537683574), Class185.smethod_0(537700909), false);
							}
							else if (jtoken[Class185.smethod_0(537682186)] != null)
							{
								shopify.class4_0.method_0(Class185.smethod_0(537683356), Class185.smethod_0(537700909), false);
							}
							else
							{
								if (jtoken[Class185.smethod_0(537682418)] == null)
								{
									GClass3.smethod_0(httpResponseMessage.smethod_3(), Class185.smethod_0(537683417));
									throw new Exception();
								}
								shopify.class4_0.method_0(Class185.smethod_0(537683387), Class185.smethod_0(537700909), false);
							}
						}
						JObject jobject5 = httpResponseMessage.smethod_0();
						shopify.string_4 = jobject5[Class185.smethod_0(537681978)][Class185.smethod_0(537683394)].ToString();
						shopify.string_3 = jobject5[Class185.smethod_0(537681978)][Class185.smethod_0(537692633)].ToString();
						shopify.string_2 = Class185.smethod_0(537683440) + new Uri(shopify.string_4).Authority.Replace(Class185.smethod_0(537711600), string.Empty);
						shopify.string_0 = shopify.string_2 + Class185.smethod_0(537683439) + shopify.string_3;
						if (jobject5[Class185.smethod_0(537681978)][Class185.smethod_0(537681988)].Any<JToken>())
						{
							shopify.string_12 = jobject5[Class185.smethod_0(537681978)][Class185.smethod_0(537681988)][0][Class185.smethod_0(537703519)].ToString();
						}
						goto IL_F81;
					}
					catch (ThreadAbortException)
					{
						goto IL_F81;
					}
					catch
					{
						num10 = 1;
					}
					if (num10 != 1)
					{
						goto IL_F3F;
					}
					shopify.class4_0.method_4(Class185.smethod_0(537683221), Class185.smethod_0(537700781), true, false);
					taskAwaiter5 = Task.Delay(GClass0.int_1).GetAwaiter();
					if (!taskAwaiter5.IsCompleted)
					{
						int num11 = 3;
						num = 3;
						num2 = num11;
						taskAwaiter4 = taskAwaiter5;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct76>(ref taskAwaiter5, ref this);
						return;
					}
					IL_F38:
					taskAwaiter5.GetResult();
					IL_F3F:
					num10 = 0;
					goto IL_54;
				}
				catch (Exception exception)
				{
					num2 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_F81:
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060007E7 RID: 2023 RVA: 0x00006E98 File Offset: 0x00005098
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040005C4 RID: 1476
			public int int_0;

			// Token: 0x040005C5 RID: 1477
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040005C6 RID: 1478
			public Shopify shopify_0;

			// Token: 0x040005C7 RID: 1479
			public object object_0;

			// Token: 0x040005C8 RID: 1480
			private HttpResponseMessage httpResponseMessage_0;

			// Token: 0x040005C9 RID: 1481
			private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

			// Token: 0x040005CA RID: 1482
			private TaskAwaiter<bool> taskAwaiter_1;

			// Token: 0x040005CB RID: 1483
			private TaskAwaiter taskAwaiter_2;
		}

		// Token: 0x0200014B RID: 331
		[StructLayout(LayoutKind.Auto)]
		private struct Struct77 : IAsyncStateMachine
		{
			// Token: 0x060007E8 RID: 2024 RVA: 0x0004DF68 File Offset: 0x0004C168
			void IAsyncStateMachine.MoveNext()
			{
				int num2;
				int num = num2;
				Shopify shopify = this;
				HttpResponseMessage result2;
				try
				{
					if (num <= 2)
					{
						goto IL_2A7;
					}
					if (num != 3)
					{
						shopify.class70_0.httpClient_0.DefaultRequestHeaders.TryAddWithoutValidation(Class185.smethod_0(537663147), queue_poll);
						goto IL_2A4;
					}
					TaskAwaiter taskAwaiter3 = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					num2 = num3;
					IL_29D:
					taskAwaiter3.GetResult();
					IL_2A4:
					int num4 = 0;
					IL_2A7:
					try
					{
						TaskAwaiter<HttpResponseMessage> taskAwaiter4;
						TaskAwaiter<bool> taskAwaiter6;
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
							TaskAwaiter<bool> taskAwaiter7;
							taskAwaiter6 = taskAwaiter7;
							taskAwaiter7 = default(TaskAwaiter<bool>);
							int num6 = -1;
							num = -1;
							num2 = num6;
							goto IL_16A;
						}
						case 2:
						{
							taskAwaiter3 = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter);
							int num7 = -1;
							num = -1;
							num2 = num7;
							goto IL_1BF;
						}
						default:
							shopify.class4_0.method_4(Class185.smethod_0(537762194), Class185.smethod_0(537700781), true, false);
							taskAwaiter4 = shopify.class70_0.method_6(queue_poll, false).GetAwaiter();
							if (!taskAwaiter4.IsCompleted)
							{
								int num8 = 0;
								num = 0;
								num2 = num8;
								TaskAwaiter<HttpResponseMessage> taskAwaiter5 = taskAwaiter4;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Shopify.Struct77>(ref taskAwaiter4, ref this);
								return;
							}
							break;
						}
						HttpResponseMessage result = taskAwaiter4.GetResult();
						httpResponseMessage = result;
						taskAwaiter6 = shopify.HandleResponse(httpResponseMessage, false).GetAwaiter();
						if (!taskAwaiter6.IsCompleted)
						{
							int num9 = 1;
							num = 1;
							num2 = num9;
							TaskAwaiter<bool> taskAwaiter7 = taskAwaiter6;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Shopify.Struct77>(ref taskAwaiter6, ref this);
							return;
						}
						IL_16A:
						taskAwaiter6.GetResult();
						IL_192:
						if (httpResponseMessage.StatusCode == HttpStatusCode.Created)
						{
							shopify.class70_0.httpClient_0.DefaultRequestHeaders.Remove(Class185.smethod_0(537663147));
							result2 = httpResponseMessage;
							goto IL_2E6;
						}
						taskAwaiter3 = Task.Delay(1000).GetAwaiter();
						if (!taskAwaiter3.IsCompleted)
						{
							int num10 = 2;
							num = 2;
							num2 = num10;
							taskAwaiter2 = taskAwaiter3;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct77>(ref taskAwaiter3, ref this);
							return;
						}
						IL_1BF:
						taskAwaiter3.GetResult();
						shopify.class4_0.method_4(Class185.smethod_0(537762194), Class185.smethod_0(537700781), true, false);
						httpResponseMessage = shopify.class70_0.method_5(queue_poll, false);
						goto IL_192;
					}
					catch (ThreadAbortException)
					{
						result2 = null;
						goto IL_2E6;
					}
					catch
					{
						num4 = 1;
					}
					if (num4 != 1)
					{
						goto IL_2A4;
					}
					shopify.class4_0.method_4(Class185.smethod_0(537762177), Class185.smethod_0(537700781), true, false);
					taskAwaiter3 = Task.Delay(GClass0.int_1).GetAwaiter();
					if (taskAwaiter3.IsCompleted)
					{
						goto IL_29D;
					}
					int num11 = 3;
					num = 3;
					num2 = num11;
					taskAwaiter2 = taskAwaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct77>(ref taskAwaiter3, ref this);
					return;
				}
				catch (Exception exception)
				{
					num2 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_2E6:
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetResult(result2);
			}

			// Token: 0x060007E9 RID: 2025 RVA: 0x00006EA6 File Offset: 0x000050A6
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040005CC RID: 1484
			public int int_0;

			// Token: 0x040005CD RID: 1485
			public AsyncTaskMethodBuilder<HttpResponseMessage> asyncTaskMethodBuilder_0;

			// Token: 0x040005CE RID: 1486
			public Shopify shopify_0;

			// Token: 0x040005CF RID: 1487
			public string string_0;

			// Token: 0x040005D0 RID: 1488
			private HttpResponseMessage httpResponseMessage_0;

			// Token: 0x040005D1 RID: 1489
			private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

			// Token: 0x040005D2 RID: 1490
			private TaskAwaiter<bool> taskAwaiter_1;

			// Token: 0x040005D3 RID: 1491
			private TaskAwaiter taskAwaiter_2;
		}

		// Token: 0x0200014C RID: 332
		[StructLayout(LayoutKind.Auto)]
		private struct Struct78 : IAsyncStateMachine
		{
			// Token: 0x060007EA RID: 2026 RVA: 0x0004E2BC File Offset: 0x0004C4BC
			void IAsyncStateMachine.MoveNext()
			{
				int num3;
				int num2 = num3;
				Shopify shopify = this;
				try
				{
					TaskAwaiter taskAwaiter7;
					if (num2 > 4)
					{
						if (num2 != 5)
						{
							shopify.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), true, false);
							goto IL_576;
						}
						taskAwaiter7 = taskAwaiter6;
						taskAwaiter6 = default(TaskAwaiter);
						int num4 = -1;
						num2 = -1;
						num3 = num4;
						goto IL_54E;
					}
					IL_5D:
					try
					{
						TaskAwaiter<HttpResponseMessage> taskAwaiter8;
						TaskAwaiter<bool> taskAwaiter9;
						switch (num2)
						{
						case 0:
						{
							taskAwaiter8 = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
							int num5 = -1;
							num2 = -1;
							num3 = num5;
							break;
						}
						case 1:
						{
							taskAwaiter9 = taskAwaiter4;
							taskAwaiter4 = default(TaskAwaiter<bool>);
							int num6 = -1;
							num2 = -1;
							num3 = num6;
							goto IL_246;
						}
						case 2:
						{
							taskAwaiter7 = taskAwaiter6;
							taskAwaiter6 = default(TaskAwaiter);
							int num7 = -1;
							num2 = -1;
							num3 = num7;
							goto IL_3B6;
						}
						case 3:
							IL_E2:
							try
							{
								if (num2 != 3)
								{
									while (enumerator.MoveNext())
									{
										JToken jtoken = enumerator.Current;
										if (jtoken[Class185.smethod_0(537762157)].Any(new Func<JToken, bool>(shopify.method_7)))
										{
											shopify.string_15 = jtoken[Class185.smethod_0(537703519)].ToString();
											if (!object.Equals(false, Convert.ToBoolean(jtoken[Class185.smethod_0(537692562)])))
											{
												goto IL_5CA;
											}
											shopify.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
											taskAwaiter7 = Task.Delay(GClass0.int_0).GetAwaiter();
											if (!taskAwaiter7.IsCompleted)
											{
												int num8 = 3;
												num2 = 3;
												num3 = num8;
												taskAwaiter6 = taskAwaiter7;
												this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct78>(ref taskAwaiter7, ref this);
												return;
											}
											goto IL_1F1;
										}
									}
									goto IL_422;
								}
								taskAwaiter7 = taskAwaiter6;
								taskAwaiter6 = default(TaskAwaiter);
								int num9 = -1;
								num2 = -1;
								num3 = num9;
								IL_1F1:
								taskAwaiter7.GetResult();
								goto IL_3DF;
							}
							finally
							{
								if (num2 < 0 && enumerator != null)
								{
									enumerator.Dispose();
								}
							}
							break;
							IL_422:
							enumerator = null;
							taskAwaiter7 = Task.Delay(GClass0.int_0).GetAwaiter();
							if (!taskAwaiter7.IsCompleted)
							{
								int num10 = 4;
								num2 = 4;
								num3 = num10;
								taskAwaiter6 = taskAwaiter7;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct78>(ref taskAwaiter7, ref this);
								return;
							}
							goto IL_4F4;
						case 4:
						{
							taskAwaiter7 = taskAwaiter6;
							taskAwaiter6 = default(TaskAwaiter);
							int num11 = -1;
							num2 = -1;
							num3 = num11;
							goto IL_4F4;
						}
						default:
							goto IL_3DF;
						}
						IL_215:
						HttpResponseMessage result = taskAwaiter8.GetResult();
						httpResponseMessage = result;
						taskAwaiter9 = shopify.HandleResponse(httpResponseMessage, true).GetAwaiter();
						if (!taskAwaiter9.IsCompleted)
						{
							int num12 = 1;
							num2 = 1;
							num3 = num12;
							taskAwaiter4 = taskAwaiter9;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Shopify.Struct78>(ref taskAwaiter9, ref this);
							return;
						}
						IL_246:
						taskAwaiter9.GetResult();
						httpResponseMessage.EnsureSuccessStatusCode();
						JObject jobject = httpResponseMessage.smethod_0();
						shopify.class4_0.method_7(jobject[Class185.smethod_0(537712450)].ToString(), Class185.smethod_0(537700781));
						shopify.string_10 = jobject[Class185.smethod_0(537703519)].ToString();
						shopify.jtoken_1[Class185.smethod_0(537762143)] = shopify.string_10;
						Class4 class4_ = shopify.class4_0;
						JToken jtoken2 = jobject[Class185.smethod_0(537763753)];
						class4_.string_1 = ((jtoken2 != null) ? jtoken2.ToString() : null);
						if (jobject[Class185.smethod_0(537704318)].Any(new Func<JToken, bool>(Shopify.Class211.class211_0.method_2)))
						{
							shopify.bool_1 = true;
						}
						if (!shopify.bool_3)
						{
							enumerator = ((IEnumerable<JToken>)jobject[Class185.smethod_0(537762112)]).GetEnumerator();
							goto IL_E2;
						}
						if (shopify.GetRandomSize(jobject[Class185.smethod_0(537762112)], out shopify.string_15, Class185.smethod_0(537762175), Class185.smethod_0(537703519), Class185.smethod_0(537692562)))
						{
							goto IL_5CA;
						}
						shopify.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
						taskAwaiter7 = Task.Delay(GClass0.int_0).GetAwaiter();
						if (!taskAwaiter7.IsCompleted)
						{
							int num13 = 2;
							num2 = 2;
							num3 = num13;
							taskAwaiter6 = taskAwaiter7;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct78>(ref taskAwaiter7, ref this);
							return;
						}
						IL_3B6:
						taskAwaiter7.GetResult();
						IL_3DF:
						shopify.CheckMassLinkChange();
						taskAwaiter8 = shopify.class4_0.method_2(shopify.uri_0 + Class185.smethod_0(537683945), shopify.bool_5, null).GetAwaiter();
						if (!taskAwaiter8.IsCompleted)
						{
							int num14 = 0;
							num2 = 0;
							num3 = num14;
							taskAwaiter2 = taskAwaiter8;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Shopify.Struct78>(ref taskAwaiter8, ref this);
							return;
						}
						goto IL_215;
						IL_4F4:
						taskAwaiter7.GetResult();
						shopify.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), false, false);
						httpResponseMessage = null;
						goto IL_582;
					}
					catch (ThreadAbortException)
					{
						goto IL_5CA;
					}
					catch
					{
						num = 1;
						goto IL_582;
					}
					IL_535:
					taskAwaiter7 = Task.Delay(GClass0.int_0).GetAwaiter();
					if (taskAwaiter7.IsCompleted)
					{
						goto IL_54E;
					}
					int num15 = 5;
					num2 = 5;
					num3 = num15;
					taskAwaiter6 = taskAwaiter7;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct78>(ref taskAwaiter7, ref this);
					return;
					IL_582:
					int num16 = num;
					if (num16 == 1)
					{
						goto IL_535;
					}
					goto IL_576;
					IL_54E:
					taskAwaiter7.GetResult();
					shopify.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), false, false);
					IL_576:
					num = 0;
					goto IL_5D;
				}
				catch (Exception exception)
				{
					num3 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_5CA:
				num3 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060007EB RID: 2027 RVA: 0x00006EB4 File Offset: 0x000050B4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040005D4 RID: 1492
			public int int_0;

			// Token: 0x040005D5 RID: 1493
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040005D6 RID: 1494
			public Shopify shopify_0;

			// Token: 0x040005D7 RID: 1495
			private int int_1;

			// Token: 0x040005D8 RID: 1496
			private HttpResponseMessage httpResponseMessage_0;

			// Token: 0x040005D9 RID: 1497
			private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

			// Token: 0x040005DA RID: 1498
			private TaskAwaiter<bool> taskAwaiter_1;

			// Token: 0x040005DB RID: 1499
			private TaskAwaiter taskAwaiter_2;

			// Token: 0x040005DC RID: 1500
			private IEnumerator<JToken> ienumerator_0;
		}

		// Token: 0x0200014D RID: 333
		[StructLayout(LayoutKind.Auto)]
		private struct Struct79 : IAsyncStateMachine
		{
			// Token: 0x060007EC RID: 2028 RVA: 0x0004E90C File Offset: 0x0004CB0C
			void IAsyncStateMachine.MoveNext()
			{
				int num2;
				int num = num2;
				Shopify shopify = this;
				try
				{
					TaskAwaiter taskAwaiter;
					if (num != 0)
					{
						shopify.class4_0.method_4(Class185.smethod_0(537683848), Class185.smethod_0(537700781), true, false);
						if (!(new Uri(shopify.string_4).Authority != new Uri(shopify.string_1).Authority))
						{
							goto IL_B2;
						}
						taskAwaiter = shopify.GetCheckoutUrl(null).GetAwaiter();
						if (!taskAwaiter.IsCompleted)
						{
							num2 = 0;
							TaskAwaiter taskAwaiter2 = taskAwaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct79>(ref taskAwaiter, ref this);
							return;
						}
					}
					else
					{
						TaskAwaiter taskAwaiter2;
						taskAwaiter = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						num2 = -1;
					}
					taskAwaiter.GetResult();
					IL_B2:;
				}
				catch (Exception exception)
				{
					num2 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060007ED RID: 2029 RVA: 0x00006EC2 File Offset: 0x000050C2
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040005DD RID: 1501
			public int int_0;

			// Token: 0x040005DE RID: 1502
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040005DF RID: 1503
			public Shopify shopify_0;

			// Token: 0x040005E0 RID: 1504
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x0200014E RID: 334
		[StructLayout(LayoutKind.Auto)]
		private struct Struct80 : IAsyncStateMachine
		{
			// Token: 0x060007EE RID: 2030 RVA: 0x0004EA08 File Offset: 0x0004CC08
			void IAsyncStateMachine.MoveNext()
			{
				int num2;
				int num = num2;
				Shopify shopify = this;
				try
				{
					TaskAwaiter taskAwaiter7;
					if (num > 4)
					{
						if (num != 5)
						{
							goto IL_49E;
						}
						taskAwaiter7 = taskAwaiter6;
						taskAwaiter6 = default(TaskAwaiter);
						int num3 = -1;
						num = -1;
						num2 = num3;
						goto IL_497;
					}
					IL_3D:
					int num14;
					try
					{
						TaskAwaiter<HttpResponseMessage> taskAwaiter8;
						TaskAwaiter<bool> taskAwaiter9;
						switch (num)
						{
						case 0:
						{
							taskAwaiter8 = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
							int num4 = -1;
							num = -1;
							num2 = num4;
							goto IL_157;
						}
						case 1:
						{
							taskAwaiter9 = taskAwaiter4;
							taskAwaiter4 = default(TaskAwaiter<bool>);
							int num5 = -1;
							num = -1;
							num2 = num5;
							goto IL_187;
						}
						case 2:
						{
							taskAwaiter7 = taskAwaiter6;
							taskAwaiter6 = default(TaskAwaiter);
							int num6 = -1;
							num = -1;
							num2 = num6;
							goto IL_1C7;
						}
						case 3:
						{
							taskAwaiter8 = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
							int num7 = -1;
							num = -1;
							num2 = num7;
							goto IL_205;
						}
						case 4:
						{
							taskAwaiter9 = taskAwaiter4;
							taskAwaiter4 = default(TaskAwaiter<bool>);
							int num8 = -1;
							num = -1;
							num2 = num8;
							goto IL_235;
						}
						}
						IL_103:
						shopify.class4_0.method_4(Class185.smethod_0(537683324), Class185.smethod_0(537700781), true, false);
						taskAwaiter8 = shopify.class70_0.method_6(shopify.string_0 + Class185.smethod_0(537683097), false).GetAwaiter();
						if (!taskAwaiter8.IsCompleted)
						{
							int num9 = 0;
							num = 0;
							num2 = num9;
							taskAwaiter2 = taskAwaiter8;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Shopify.Struct80>(ref taskAwaiter8, ref this);
							return;
						}
						IL_157:
						HttpResponseMessage result2 = taskAwaiter8.GetResult();
						result = result2;
						taskAwaiter9 = shopify.HandleResponse(result, false).GetAwaiter();
						if (!taskAwaiter9.IsCompleted)
						{
							int num10 = 1;
							num = 1;
							num2 = num10;
							taskAwaiter4 = taskAwaiter9;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Shopify.Struct80>(ref taskAwaiter9, ref this);
							return;
						}
						IL_187:
						if (taskAwaiter9.GetResult())
						{
							goto IL_49E;
						}
						IL_193:
						if (result.StatusCode != HttpStatusCode.Accepted)
						{
							if (result.smethod_3().Contains(Class185.smethod_0(537683076)))
							{
								shopify.string_12 = null;
								goto IL_4E0;
							}
							if (result.smethod_3().Contains(Class185.smethod_0(537683108)))
							{
								shopify.class4_0.method_0(Class185.smethod_0(537683147), Class185.smethod_0(537700909), false);
								goto IL_4E0;
							}
							if (result.smethod_3().Contains(Class185.smethod_0(537683191)))
							{
								shopify.class4_0.method_0(Class185.smethod_0(537683356), Class185.smethod_0(537700909), false);
								goto IL_4E0;
							}
							if (!result.smethod_0()[Class185.smethod_0(537683172)].Any<JToken>())
							{
								shopify.class4_0.method_0(Class185.smethod_0(537683147), Class185.smethod_0(537700909), false);
							}
							shopify.string_12 = result.smethod_0()[Class185.smethod_0(537683172)][0][Class185.smethod_0(537703519)].ToString();
							shopify.class4_0.method_4(Class185.smethod_0(537682953), Class185.smethod_0(537700781), true, false);
							goto IL_4E0;
						}
						else
						{
							taskAwaiter7 = Task.Delay(500).GetAwaiter();
							if (!taskAwaiter7.IsCompleted)
							{
								int num11 = 2;
								num = 2;
								num2 = num11;
								taskAwaiter6 = taskAwaiter7;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct80>(ref taskAwaiter7, ref this);
								return;
							}
						}
						IL_1C7:
						taskAwaiter7.GetResult();
						taskAwaiter8 = shopify.class70_0.httpClient_0.GetAsync(shopify.string_0 + Class185.smethod_0(537683097)).GetAwaiter();
						if (!taskAwaiter8.IsCompleted)
						{
							int num12 = 3;
							num = 3;
							num2 = num12;
							taskAwaiter2 = taskAwaiter8;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Shopify.Struct80>(ref taskAwaiter8, ref this);
							return;
						}
						IL_205:
						result2 = taskAwaiter8.GetResult();
						result = result2;
						taskAwaiter9 = shopify.HandleResponse(result, false).GetAwaiter();
						if (!taskAwaiter9.IsCompleted)
						{
							int num13 = 4;
							num = 4;
							num2 = num13;
							taskAwaiter4 = taskAwaiter9;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Shopify.Struct80>(ref taskAwaiter9, ref this);
							return;
						}
						IL_235:
						if (!taskAwaiter9.GetResult())
						{
							goto IL_193;
						}
						goto IL_103;
					}
					catch (ThreadAbortException)
					{
						goto IL_4E0;
					}
					catch
					{
						num14 = 1;
					}
					if (num14 != 1)
					{
						goto IL_49E;
					}
					shopify.class4_0.method_4(Class185.smethod_0(537682995), Class185.smethod_0(537700781), true, false);
					taskAwaiter7 = Task.Delay(GClass0.int_1).GetAwaiter();
					if (!taskAwaiter7.IsCompleted)
					{
						int num15 = 5;
						num = 5;
						num2 = num15;
						taskAwaiter6 = taskAwaiter7;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct80>(ref taskAwaiter7, ref this);
						return;
					}
					IL_497:
					taskAwaiter7.GetResult();
					IL_49E:
					num14 = 0;
					goto IL_3D;
				}
				catch (Exception exception)
				{
					num2 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_4E0:
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060007EF RID: 2031 RVA: 0x00006ED0 File Offset: 0x000050D0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040005E1 RID: 1505
			public int int_0;

			// Token: 0x040005E2 RID: 1506
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040005E3 RID: 1507
			public Shopify shopify_0;

			// Token: 0x040005E4 RID: 1508
			private HttpResponseMessage httpResponseMessage_0;

			// Token: 0x040005E5 RID: 1509
			private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

			// Token: 0x040005E6 RID: 1510
			private TaskAwaiter<bool> taskAwaiter_1;

			// Token: 0x040005E7 RID: 1511
			private TaskAwaiter taskAwaiter_2;
		}

		// Token: 0x0200014F RID: 335
		[StructLayout(LayoutKind.Auto)]
		private struct Struct81 : IAsyncStateMachine
		{
			// Token: 0x060007F0 RID: 2032 RVA: 0x0004EF54 File Offset: 0x0004D154
			void IAsyncStateMachine.MoveNext()
			{
				int num3;
				int num2 = num3;
				Shopify shopify = this;
				try
				{
					TaskAwaiter taskAwaiter5;
					if (num2 > 1)
					{
						if (num2 != 2)
						{
							goto IL_235;
						}
						taskAwaiter5 = taskAwaiter4;
						taskAwaiter4 = default(TaskAwaiter);
						int num4 = -1;
						num2 = -1;
						num3 = num4;
						goto IL_20D;
					}
					IL_3C:
					try
					{
						TaskAwaiter<HttpResponseMessage> taskAwaiter6;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								taskAwaiter5 = taskAwaiter4;
								taskAwaiter4 = default(TaskAwaiter);
								int num5 = -1;
								num2 = -1;
								num3 = num5;
								goto IL_1DB;
							}
							shopify.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), true, false);
							if (shopify.CheckMassLinkChange())
							{
								goto IL_289;
							}
							taskAwaiter6 = shopify.class4_0.method_2(shopify.string_1, shopify.bool_5, null).GetAwaiter();
							if (!taskAwaiter6.IsCompleted)
							{
								int num6 = 0;
								num2 = 0;
								num3 = num6;
								taskAwaiter2 = taskAwaiter6;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Shopify.Struct81>(ref taskAwaiter6, ref this);
								return;
							}
						}
						else
						{
							taskAwaiter6 = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
							int num7 = -1;
							num2 = -1;
							num3 = num7;
						}
						HttpResponseMessage result = taskAwaiter6.GetResult();
						HtmlDocument htmlDocument = new HtmlDocument();
						htmlDocument.LoadHtml(result.smethod_3());
						HtmlNodeCollection htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes(Class185.smethod_0(537762261));
						HtmlNode htmlNode = (htmlNodeCollection != null) ? htmlNodeCollection.FirstOrDefault(new Func<HtmlNode, bool>(shopify.method_0)) : null;
						if (htmlNode != null)
						{
							shopify.class4_0.method_7(htmlNode.InnerText, Class185.smethod_0(537700781));
							shopify.uri_0 = new Uri(shopify.string_1 + htmlNode.ParentNode.Attributes[Class185.smethod_0(537669937)].Value);
							goto IL_289;
						}
						taskAwaiter5 = Task.Delay(GClass0.int_0).GetAwaiter();
						if (!taskAwaiter5.IsCompleted)
						{
							int num8 = 1;
							num2 = 1;
							num3 = num8;
							taskAwaiter4 = taskAwaiter5;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct81>(ref taskAwaiter5, ref this);
							return;
						}
						IL_1DB:
						taskAwaiter5.GetResult();
						goto IL_241;
					}
					catch (ThreadAbortException)
					{
						goto IL_289;
					}
					catch
					{
						num = 1;
						goto IL_241;
					}
					IL_1F4:
					taskAwaiter5 = Task.Delay(GClass0.int_0).GetAwaiter();
					if (taskAwaiter5.IsCompleted)
					{
						goto IL_20D;
					}
					int num9 = 2;
					num2 = 2;
					num3 = num9;
					taskAwaiter4 = taskAwaiter5;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct81>(ref taskAwaiter5, ref this);
					return;
					IL_241:
					int num10 = num;
					if (num10 == 1)
					{
						goto IL_1F4;
					}
					goto IL_235;
					IL_20D:
					taskAwaiter5.GetResult();
					shopify.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), false, false);
					IL_235:
					num = 0;
					goto IL_3C;
				}
				catch (Exception exception)
				{
					num3 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_289:
				num3 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060007F1 RID: 2033 RVA: 0x00006EDE File Offset: 0x000050DE
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040005E8 RID: 1512
			public int int_0;

			// Token: 0x040005E9 RID: 1513
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040005EA RID: 1514
			public Shopify shopify_0;

			// Token: 0x040005EB RID: 1515
			private int int_1;

			// Token: 0x040005EC RID: 1516
			private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

			// Token: 0x040005ED RID: 1517
			private TaskAwaiter taskAwaiter_1;
		}

		// Token: 0x02000150 RID: 336
		[StructLayout(LayoutKind.Auto)]
		private struct Struct82 : IAsyncStateMachine
		{
			// Token: 0x060007F2 RID: 2034 RVA: 0x0004F24C File Offset: 0x0004D44C
			void IAsyncStateMachine.MoveNext()
			{
				int num2;
				int num = num2;
				Shopify shopify = this;
				try
				{
					TaskAwaiter taskAwaiter7;
					if (num > 1)
					{
						if (num != 2)
						{
							goto IL_472;
						}
						taskAwaiter7 = taskAwaiter6;
						taskAwaiter6 = default(TaskAwaiter);
						int num3 = -1;
						num = -1;
						num2 = num3;
						goto IL_46B;
					}
					IL_3D:
					int num8;
					try
					{
						TaskAwaiter<bool> taskAwaiter8;
						TaskAwaiter<HttpResponseMessage> taskAwaiter9;
						if (num != 0)
						{
							if (num == 1)
							{
								taskAwaiter8 = taskAwaiter4;
								taskAwaiter4 = default(TaskAwaiter<bool>);
								int num4 = -1;
								num = -1;
								num2 = num4;
								goto IL_1FF;
							}
							shopify.class4_0.method_4(Class185.smethod_0(537763262), Class185.smethod_0(537700964), true, false);
							JObject jobject = new JObject();
							string propertyName = Class185.smethod_0(537662788);
							JObject jobject2 = new JObject();
							jobject2[Class185.smethod_0(537661240)] = shopify.string_9;
							jobject2[Class185.smethod_0(537763290)] = GClass2.smethod_2(16);
							string propertyName2 = Class185.smethod_0(537763277);
							JObject jobject3 = new JObject();
							jobject3[Class185.smethod_0(537676350)] = Class185.smethod_0(537763313);
							jobject3[Class185.smethod_0(537763098)] = shopify.string_7;
							jobject2[propertyName2] = jobject3;
							jobject[propertyName] = jobject2;
							JObject jobject_ = jobject;
							taskAwaiter9 = shopify.class70_0.method_10(shopify.string_2 + Class185.smethod_0(537683439) + shopify.string_3 + Class185.smethod_0(537662977), jobject_).GetAwaiter();
							if (!taskAwaiter9.IsCompleted)
							{
								int num5 = 0;
								num = 0;
								num2 = num5;
								taskAwaiter2 = taskAwaiter9;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Shopify.Struct82>(ref taskAwaiter9, ref this);
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
						HttpResponseMessage result2 = taskAwaiter9.GetResult();
						result = result2;
						taskAwaiter8 = shopify.HandleResponse(result, false).GetAwaiter();
						if (!taskAwaiter8.IsCompleted)
						{
							int num7 = 1;
							num = 1;
							num2 = num7;
							taskAwaiter4 = taskAwaiter8;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Shopify.Struct82>(ref taskAwaiter8, ref this);
							return;
						}
						IL_1FF:
						if (!taskAwaiter8.GetResult())
						{
							result.smethod_0();
							if (result.smethod_3().Contains(Class185.smethod_0(537682010)))
							{
								shopify.class4_0.method_0(Class185.smethod_0(537762345), Class185.smethod_0(537700909), false);
							}
							else if (result.smethod_3().ToLower().Contains(Class185.smethod_0(537711093)))
							{
								shopify.class4_0.method_9(true);
								shopify.class4_0.method_0(Class185.smethod_0(537660452), Class185.smethod_0(537700909), false);
							}
							else if (result.smethod_3().Contains(Class185.smethod_0(537762471)))
							{
								shopify.class4_0.method_0(Class185.smethod_0(537660491), Class185.smethod_0(537700909), false);
							}
							else if (result.smethod_3().Contains(Class185.smethod_0(537762510)))
							{
								shopify.class4_0.method_12();
								shopify.class4_0.method_9(false);
								shopify.class4_0.method_0(Class185.smethod_0(537658349), Class185.smethod_0(537658124), false);
							}
							else if (!result.smethod_3().Contains(Class185.smethod_0(537762558)) && !result.smethod_3().Contains(Class185.smethod_0(537762543)))
							{
								if (result.smethod_3().Contains(Class185.smethod_0(537762322)))
								{
									shopify.class4_0.method_0(Class185.smethod_0(537762345), Class185.smethod_0(537700909), false);
								}
								else
								{
									GClass3.smethod_0(result.smethod_3(), Class185.smethod_0(537762390));
									shopify.class4_0.method_0(Class185.smethod_0(537660491), Class185.smethod_0(537700909), false);
								}
							}
							else
							{
								shopify.class4_0.method_0(Class185.smethod_0(537660738), Class185.smethod_0(537700909), false);
							}
							throw new Exception();
						}
						goto IL_472;
					}
					catch (ThreadAbortException)
					{
						goto IL_4B3;
					}
					catch
					{
						num8 = 1;
					}
					if (num8 != 1)
					{
						goto IL_472;
					}
					shopify.class4_0.method_4(Class185.smethod_0(537763085), Class185.smethod_0(537700781), true, false);
					taskAwaiter7 = Task.Delay(GClass0.int_1).GetAwaiter();
					if (!taskAwaiter7.IsCompleted)
					{
						int num9 = 2;
						num = 2;
						num2 = num9;
						taskAwaiter6 = taskAwaiter7;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct82>(ref taskAwaiter7, ref this);
						return;
					}
					IL_46B:
					taskAwaiter7.GetResult();
					IL_472:
					num8 = 0;
					goto IL_3D;
				}
				catch (Exception exception)
				{
					num2 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_4B3:
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060007F3 RID: 2035 RVA: 0x00006EEC File Offset: 0x000050EC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040005EE RID: 1518
			public int int_0;

			// Token: 0x040005EF RID: 1519
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040005F0 RID: 1520
			public Shopify shopify_0;

			// Token: 0x040005F1 RID: 1521
			private HttpResponseMessage httpResponseMessage_0;

			// Token: 0x040005F2 RID: 1522
			private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

			// Token: 0x040005F3 RID: 1523
			private TaskAwaiter<bool> taskAwaiter_1;

			// Token: 0x040005F4 RID: 1524
			private TaskAwaiter taskAwaiter_2;
		}

		// Token: 0x02000151 RID: 337
		[StructLayout(LayoutKind.Auto)]
		private struct Struct83 : IAsyncStateMachine
		{
			// Token: 0x060007F4 RID: 2036 RVA: 0x0004F76C File Offset: 0x0004D96C
			void IAsyncStateMachine.MoveNext()
			{
				int num2;
				int num = num2;
				Shopify shopify = this;
				try
				{
					try
					{
						TaskAwaiter<HttpResponseMessage> taskAwaiter;
						if (num != 0)
						{
							taskAwaiter = shopify.class70_0.method_6(shopify.string_4, false).GetAwaiter();
							if (!taskAwaiter.IsCompleted)
							{
								num2 = 0;
								TaskAwaiter<HttpResponseMessage> taskAwaiter2 = taskAwaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Shopify.Struct83>(ref taskAwaiter, ref this);
								return;
							}
						}
						else
						{
							TaskAwaiter<HttpResponseMessage> taskAwaiter2;
							taskAwaiter = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
							num2 = -1;
						}
						HttpResponseMessage result = taskAwaiter.GetResult();
						shopify.bool_6 = result.smethod_3().Contains(Class185.smethod_0(537683893));
					}
					catch
					{
					}
				}
				catch (Exception exception)
				{
					num2 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060007F5 RID: 2037 RVA: 0x00006EFA File Offset: 0x000050FA
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040005F5 RID: 1525
			public int int_0;

			// Token: 0x040005F6 RID: 1526
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040005F7 RID: 1527
			public Shopify shopify_0;

			// Token: 0x040005F8 RID: 1528
			private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;
		}

		// Token: 0x02000152 RID: 338
		[StructLayout(LayoutKind.Auto)]
		private struct Struct84 : IAsyncStateMachine
		{
			// Token: 0x060007F6 RID: 2038 RVA: 0x0004F85C File Offset: 0x0004DA5C
			void IAsyncStateMachine.MoveNext()
			{
				int num2;
				int num = num2;
				Shopify shopify = this;
				try
				{
					if (num == 0)
					{
						goto IL_4F9;
					}
					if (num != 1)
					{
						goto IL_4F6;
					}
					TaskAwaiter taskAwaiter3 = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					num2 = num3;
					IL_4EF:
					taskAwaiter3.GetResult();
					IL_4F6:
					int num4 = 0;
					IL_4F9:
					try
					{
						string text;
						TaskAwaiter<HttpResponseMessage> taskAwaiter4;
						if (num != 0)
						{
							if (shopify.uri_0 == null && html == null)
							{
								goto IL_539;
							}
							shopify.class4_0.method_4(Class185.smethod_0(537670109), Class185.smethod_0(537700781), true, false);
							text = html;
							if (text != null)
							{
								goto IL_103;
							}
							taskAwaiter4 = shopify.class4_0.method_2(shopify.uri_0.ToString(), shopify.bool_5, null).GetAwaiter();
							if (!taskAwaiter4.IsCompleted)
							{
								int num5 = 0;
								num = 0;
								num2 = num5;
								TaskAwaiter<HttpResponseMessage> taskAwaiter5 = taskAwaiter4;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Shopify.Struct84>(ref taskAwaiter4, ref this);
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
						text = taskAwaiter4.GetResult().smethod_3();
						IL_103:
						string text2 = text;
						HtmlDocument htmlDocument = new HtmlDocument();
						htmlDocument.LoadHtml(text2);
						if ((string)shopify.jtoken_1[Class185.smethod_0(537700413)] == Class185.smethod_0(537683030))
						{
							shopify.jobject_0[text2.Replace(Class185.smethod_0(537711014), string.Empty).Split(new string[]
							{
								Class185.smethod_0(537683009)
							}, StringSplitOptions.None)[1].Split(new char[]
							{
								';'
							})[0].Replace(Class185.smethod_0(537715235), string.Empty).Replace(Class185.smethod_0(537700459), string.Empty)] = text2.Replace(Class185.smethod_0(537711014), string.Empty).Split(new string[]
							{
								Class185.smethod_0(537683060)
							}, StringSplitOptions.None)[1].Split(new char[]
							{
								';'
							})[0].Replace(Class185.smethod_0(537715235), string.Empty).Replace(Class185.smethod_0(537700459), string.Empty);
						}
						else if (shopify.jtoken_1[Class185.smethod_0(537700413)].ToString().Contains(Class185.smethod_0(537683047)))
						{
							HtmlNode htmlNode = htmlDocument.DocumentNode.SelectNodes(Class185.smethod_0(537762705)).FirstOrDefault(new Func<HtmlNode, bool>(Shopify.Class211.class211_0.method_3));
							if (htmlNode != null)
							{
								string text3 = string.Empty;
								string text4 = string.Empty;
								foreach (string text5 in htmlNode.InnerHtml.Split(new string[]
								{
									Class185.smethod_0(537762688)
								}, StringSplitOptions.None).Skip(1).ToArray<string>())
								{
									try
									{
										string @string = Encoding.UTF8.GetString(Convert.FromBase64String(text5.Split(new string[]
										{
											Class185.smethod_0(537762749)
										}, StringSplitOptions.None)[0]));
										if (@string.Contains(Class185.smethod_0(537706840)))
										{
											text3 = @string.Split(new string[]
											{
												Class185.smethod_0(537762742)
											}, StringSplitOptions.None)[1].Split(new char[]
											{
												']'
											})[0];
										}
										else if (!@string.Contains(Class185.smethod_0(537710986)))
										{
											text4 = @string;
										}
									}
									catch
									{
									}
								}
								if (text3 != null && text4 != null)
								{
									shopify.jobject_0[text3] = text4;
								}
							}
						}
						HtmlNodeCollection htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes(Class185.smethod_0(537762776));
						HtmlNode htmlNode2;
						if (htmlNodeCollection == null)
						{
							htmlNode2 = null;
						}
						else
						{
							htmlNode2 = htmlNodeCollection.FirstOrDefault(new Func<HtmlNode, bool>(Shopify.Class211.class211_0.method_4));
						}
						HtmlNode htmlNode3 = htmlNode2;
						if (htmlNode3 != null)
						{
							shopify.jobject_0[htmlNode3.Attributes[Class185.smethod_0(537712143)].Value.Replace(Class185.smethod_0(537762742), string.Empty).Replace(Class185.smethod_0(537714082), string.Empty)] = htmlNode3.Attributes[Class185.smethod_0(537711408)].Value;
						}
						shopify.class4_0.method_4(Class185.smethod_0(537762765), Class185.smethod_0(537700781), true, false);
						Class30.smethod_1((int)shopify.jtoken_1[Class185.smethod_0(537703519)], shopify.uri_0.ToString());
						goto IL_539;
					}
					catch (ThreadAbortException)
					{
						goto IL_539;
					}
					catch
					{
						num4 = 1;
					}
					if (num4 != 1)
					{
						goto IL_4F6;
					}
					shopify.class4_0.method_4(Class185.smethod_0(537669957), Class185.smethod_0(537700781), true, false);
					taskAwaiter3 = Task.Delay(GClass0.int_1).GetAwaiter();
					if (taskAwaiter3.IsCompleted)
					{
						goto IL_4EF;
					}
					int num7 = 1;
					num = 1;
					num2 = num7;
					taskAwaiter2 = taskAwaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct84>(ref taskAwaiter3, ref this);
					return;
				}
				catch (Exception exception)
				{
					num2 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_539:
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060007F7 RID: 2039 RVA: 0x00006F08 File Offset: 0x00005108
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040005F9 RID: 1529
			public int int_0;

			// Token: 0x040005FA RID: 1530
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040005FB RID: 1531
			public Shopify shopify_0;

			// Token: 0x040005FC RID: 1532
			public string string_0;

			// Token: 0x040005FD RID: 1533
			private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

			// Token: 0x040005FE RID: 1534
			private TaskAwaiter taskAwaiter_1;
		}

		// Token: 0x02000153 RID: 339
		[StructLayout(LayoutKind.Auto)]
		private struct Struct85 : IAsyncStateMachine
		{
			// Token: 0x060007F8 RID: 2040 RVA: 0x0004FE1C File Offset: 0x0004E01C
			void IAsyncStateMachine.MoveNext()
			{
				int num3;
				int num2 = num3;
				Shopify shopify = this;
				try
				{
					TaskAwaiter taskAwaiter5;
					if (num2 > 5)
					{
						if (num2 != 6)
						{
							shopify.class4_0.method_4(Class185.smethod_0(537762276), Class185.smethod_0(537700781), true, false);
							goto IL_56F;
						}
						taskAwaiter5 = taskAwaiter4;
						taskAwaiter4 = default(TaskAwaiter);
						int num4 = -1;
						num2 = -1;
						num3 = num4;
						goto IL_547;
					}
					IL_5D:
					try
					{
						TaskAwaiter<HttpResponseMessage> taskAwaiter6;
						HttpResponseMessage result;
						switch (num2)
						{
						case 0:
						{
							taskAwaiter6 = taskAwaiter2;
							taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
							int num5 = -1;
							num2 = -1;
							num3 = num5;
							break;
						}
						case 1:
						{
							taskAwaiter5 = taskAwaiter4;
							taskAwaiter4 = default(TaskAwaiter);
							int num6 = -1;
							num2 = -1;
							num3 = num6;
							goto IL_3AE;
						}
						case 2:
						{
							taskAwaiter5 = taskAwaiter4;
							taskAwaiter4 = default(TaskAwaiter);
							int num7 = -1;
							num2 = -1;
							num3 = num7;
							goto IL_4CC;
						}
						case 3:
						case 4:
							IL_3FB:
							try
							{
								if (num2 != 3)
								{
									if (num2 != 4)
									{
										while (enumerator.MoveNext())
										{
											JToken jtoken = enumerator.Current;
											if (jtoken[Class185.smethod_0(537762157)].Any(new Func<JToken, bool>(shopify.method_1)))
											{
												shopify.string_15 = jtoken[Class185.smethod_0(537703519)].ToString();
												if (object.Equals(false, Convert.ToBoolean(jtoken[Class185.smethod_0(537692562)])))
												{
													shopify.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
													taskAwaiter5 = Task.Delay(GClass0.int_0).GetAwaiter();
													if (!taskAwaiter5.IsCompleted)
													{
														int num8 = 3;
														num2 = 3;
														num3 = num8;
														taskAwaiter4 = taskAwaiter5;
														this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct85>(ref taskAwaiter5, ref this);
														return;
													}
													goto IL_25E;
												}
												else
												{
													taskAwaiter5 = shopify.GetToken(result.smethod_3()).GetAwaiter();
													if (!taskAwaiter5.IsCompleted)
													{
														int num9 = 4;
														num2 = 4;
														num3 = num9;
														taskAwaiter4 = taskAwaiter5;
														this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct85>(ref taskAwaiter5, ref this);
														return;
													}
													goto IL_236;
												}
											}
										}
										goto IL_401;
									}
									taskAwaiter5 = taskAwaiter4;
									taskAwaiter4 = default(TaskAwaiter);
									int num10 = -1;
									num2 = -1;
									num3 = num10;
									IL_236:
									taskAwaiter5.GetResult();
									goto IL_5C3;
								}
								taskAwaiter5 = taskAwaiter4;
								taskAwaiter4 = default(TaskAwaiter);
								int num11 = -1;
								num2 = -1;
								num3 = num11;
								IL_25E:
								taskAwaiter5.GetResult();
								goto IL_3B5;
							}
							finally
							{
								if (num2 < 0 && enumerator != null)
								{
									enumerator.Dispose();
								}
							}
							break;
							IL_401:
							enumerator = null;
							taskAwaiter5 = Task.Delay(GClass0.int_0).GetAwaiter();
							if (!taskAwaiter5.IsCompleted)
							{
								int num12 = 5;
								num2 = 5;
								num3 = num12;
								taskAwaiter4 = taskAwaiter5;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct85>(ref taskAwaiter5, ref this);
								return;
							}
							goto IL_4F4;
						case 5:
						{
							taskAwaiter5 = taskAwaiter4;
							taskAwaiter4 = default(TaskAwaiter);
							int num13 = -1;
							num2 = -1;
							num3 = num13;
							goto IL_4F4;
						}
						default:
							goto IL_3B5;
						}
						IL_282:
						result = taskAwaiter6.GetResult();
						HtmlDocument htmlDocument = new HtmlDocument();
						htmlDocument.LoadHtml(result.smethod_3());
						JObject jobject = JObject.Parse(htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537762060)).InnerText);
						shopify.class4_0.method_7(jobject[Class185.smethod_0(537712450)].ToString(), Class185.smethod_0(537700781));
						shopify.string_10 = jobject[Class185.smethod_0(537703519)].ToString();
						shopify.jtoken_1[Class185.smethod_0(537762143)] = shopify.string_10;
						JToken jtoken2 = jobject[Class185.smethod_0(537762112)];
						if (!shopify.bool_3)
						{
							enumerator = ((IEnumerable<JToken>)jtoken2).GetEnumerator();
							goto IL_3FB;
						}
						if (!shopify.GetRandomSize(jtoken2, out shopify.string_15, Class185.smethod_0(537762175), Class185.smethod_0(537703519), Class185.smethod_0(537692562)))
						{
							shopify.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
							taskAwaiter5 = Task.Delay(GClass0.int_0).GetAwaiter();
							if (!taskAwaiter5.IsCompleted)
							{
								int num14 = 1;
								num2 = 1;
								num3 = num14;
								taskAwaiter4 = taskAwaiter5;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct85>(ref taskAwaiter5, ref this);
								return;
							}
						}
						else
						{
							taskAwaiter5 = shopify.GetToken(result.smethod_3()).GetAwaiter();
							if (!taskAwaiter5.IsCompleted)
							{
								int num15 = 2;
								num2 = 2;
								num3 = num15;
								taskAwaiter4 = taskAwaiter5;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct85>(ref taskAwaiter5, ref this);
								return;
							}
							goto IL_4CC;
						}
						IL_3AE:
						taskAwaiter5.GetResult();
						IL_3B5:
						shopify.CheckMassLinkChange();
						taskAwaiter6 = shopify.class4_0.method_2(shopify.uri_0.ToString(), shopify.bool_5, null).GetAwaiter();
						if (!taskAwaiter6.IsCompleted)
						{
							int num16 = 0;
							num2 = 0;
							num3 = num16;
							taskAwaiter2 = taskAwaiter6;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Shopify.Struct85>(ref taskAwaiter6, ref this);
							return;
						}
						goto IL_282;
						IL_4CC:
						taskAwaiter5.GetResult();
						goto IL_5C3;
						IL_4F4:
						taskAwaiter5.GetResult();
						shopify.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), false, false);
						goto IL_57B;
					}
					catch (ThreadAbortException)
					{
						goto IL_5C3;
					}
					catch
					{
						num = 1;
						goto IL_57B;
					}
					IL_52E:
					taskAwaiter5 = Task.Delay(GClass0.int_0).GetAwaiter();
					if (taskAwaiter5.IsCompleted)
					{
						goto IL_547;
					}
					int num17 = 6;
					num2 = 6;
					num3 = num17;
					taskAwaiter4 = taskAwaiter5;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct85>(ref taskAwaiter5, ref this);
					return;
					IL_57B:
					int num18 = num;
					if (num18 == 1)
					{
						goto IL_52E;
					}
					goto IL_56F;
					IL_547:
					taskAwaiter5.GetResult();
					shopify.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), false, false);
					IL_56F:
					num = 0;
					goto IL_5D;
				}
				catch (Exception exception)
				{
					num3 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_5C3:
				num3 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060007F9 RID: 2041 RVA: 0x00006F16 File Offset: 0x00005116
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040005FF RID: 1535
			public int int_0;

			// Token: 0x04000600 RID: 1536
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04000601 RID: 1537
			public Shopify shopify_0;

			// Token: 0x04000602 RID: 1538
			private int int_1;

			// Token: 0x04000603 RID: 1539
			private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

			// Token: 0x04000604 RID: 1540
			private TaskAwaiter taskAwaiter_1;

			// Token: 0x04000605 RID: 1541
			private IEnumerator<JToken> ienumerator_0;
		}

		// Token: 0x02000154 RID: 340
		[StructLayout(LayoutKind.Auto)]
		private struct Struct86 : IAsyncStateMachine
		{
			// Token: 0x060007FA RID: 2042 RVA: 0x00050464 File Offset: 0x0004E664
			void IAsyncStateMachine.MoveNext()
			{
				int num2;
				int num = num2;
				Shopify shopify = this;
				try
				{
					if (num == 0)
					{
						goto IL_366;
					}
					if (num != 1)
					{
						goto IL_364;
					}
					TaskAwaiter taskAwaiter3 = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					num2 = num3;
					IL_35D:
					taskAwaiter3.GetResult();
					IL_364:
					int num4 = 0;
					IL_366:
					try
					{
						TaskAwaiter<HttpResponseMessage> taskAwaiter4;
						if (num != 0)
						{
							if (!silent)
							{
								shopify.class4_0.method_4(Class185.smethod_0(537661418), Class185.smethod_0(537700781), true, false);
							}
							JObject jobject = new JObject();
							jobject[Class185.smethod_0(537763119)] = new JObject();
							jobject[Class185.smethod_0(537763119)][Class185.smethod_0(537660835)] = ((string)shopify.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660835)]).Replace(Class185.smethod_0(537711014), string.Empty);
							jobject[Class185.smethod_0(537763119)][Class185.smethod_0(537763153)] = shopify.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660870)];
							jobject[Class185.smethod_0(537763119)][Class185.smethod_0(537763149)] = shopify.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660699)];
							jobject[Class185.smethod_0(537763119)][Class185.smethod_0(537763192)] = shopify.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660682)];
							jobject[Class185.smethod_0(537763119)][Class185.smethod_0(537662508)] = shopify.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662508)];
							jobject[Class185.smethod_0(537763119)][Class185.smethod_0(537662540)] = shopify.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662540)];
							taskAwaiter4 = shopify.class70_0.method_10(Class185.smethod_0(537763169), jobject).GetAwaiter();
							if (!taskAwaiter4.IsCompleted)
							{
								int num5 = 0;
								num = 0;
								num2 = num5;
								TaskAwaiter<HttpResponseMessage> taskAwaiter5 = taskAwaiter4;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Shopify.Struct86>(ref taskAwaiter4, ref this);
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
						shopify.string_7 = result.smethod_0()[Class185.smethod_0(537703519)].ToString();
						goto IL_3A6;
					}
					catch (ThreadAbortException)
					{
						goto IL_3A6;
					}
					catch
					{
						num4 = 1;
					}
					if (num4 != 1)
					{
						goto IL_364;
					}
					shopify.class4_0.method_4(Class185.smethod_0(537661084), Class185.smethod_0(537700781), true, false);
					taskAwaiter3 = Task.Delay(GClass0.int_1).GetAwaiter();
					if (taskAwaiter3.IsCompleted)
					{
						goto IL_35D;
					}
					int num7 = 1;
					num = 1;
					num2 = num7;
					taskAwaiter2 = taskAwaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Shopify.Struct86>(ref taskAwaiter3, ref this);
					return;
				}
				catch (Exception exception)
				{
					num2 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_3A6:
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060007FB RID: 2043 RVA: 0x00006F24 File Offset: 0x00005124
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04000606 RID: 1542
			public int int_0;

			// Token: 0x04000607 RID: 1543
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04000608 RID: 1544
			public bool bool_0;

			// Token: 0x04000609 RID: 1545
			public Shopify shopify_0;

			// Token: 0x0400060A RID: 1546
			private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

			// Token: 0x0400060B RID: 1547
			private TaskAwaiter taskAwaiter_1;
		}
	}
}
