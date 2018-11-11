using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using HtmlAgilityPack;
using Newtonsoft.Json.Linq;

// Token: 0x020000CC RID: 204
internal sealed class Class111
{
	// Token: 0x06000547 RID: 1351 RVA: 0x00031AC0 File Offset: 0x0002FCC0
	public Class111(JToken jtoken_2)
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
				this.string_1 = jtoken_2[Class185.smethod_0(537702300)].ToString().Split(new char[]
				{
					'#'
				}).First<string>();
				this.string_2 = ((string)jtoken_2[Class185.smethod_0(537700008)]).Replace(Class185.smethod_0(537663330), string.Empty);
				if (this.string_2 == Class185.smethod_0(537663132) || this.string_2 == Class185.smethod_0(537663113))
				{
					this.bool_0 = true;
				}
				this.bool_1 = (jtoken_2[Class185.smethod_0(537663111)] != null && (bool)jtoken_2[Class185.smethod_0(537663111)]);
				this.class70_0 = new Class70(this.class4_0.method_6(), Class185.smethod_0(537692910), 60, false, false, null, false);
				this.class70_0.httpClient_0.DefaultRequestHeaders.TryAddWithoutValidation(Class185.smethod_0(537663147), this.string_1);
			}
		}
		catch
		{
			this.class4_0.method_0(Class185.smethod_0(537663193), Class185.smethod_0(537700909), true);
		}
	}

	// Token: 0x06000548 RID: 1352 RVA: 0x00031C8C File Offset: 0x0002FE8C
	public void method_0()
	{
		try
		{
			this.class4_0.method_8();
			this.method_2();
			this.method_3();
			this.method_4();
			this.method_5();
			if (this.bool_1)
			{
				this.method_7();
				this.method_14();
			}
			else
			{
				this.method_9();
				this.method_10();
				this.method_11();
				this.method_12();
				this.method_13();
			}
		}
		catch
		{
		}
		finally
		{
			this.class4_0.method_0(Class185.smethod_0(537663178), Class185.smethod_0(537700909), true);
		}
	}

	// Token: 0x06000549 RID: 1353 RVA: 0x00031D34 File Offset: 0x0002FF34
	public string method_1(string string_13)
	{
		HtmlDocument htmlDocument = new HtmlDocument();
		htmlDocument.LoadHtml(this.string_11);
		return htmlDocument.DocumentNode.SelectSingleNode(string.Format(Class185.smethod_0(537663224), string_13)).Attributes[Class185.smethod_0(537711408)].Value;
	}

	// Token: 0x0600054A RID: 1354 RVA: 0x00031D88 File Offset: 0x0002FF88
	public void method_2()
	{
		this.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), true, false);
		for (;;)
		{
			try
			{
				HttpResponseMessage httpResponseMessage = this.class70_0.method_5(this.string_1 + Class185.smethod_0(537662977), true);
				if (httpResponseMessage.StatusCode == HttpStatusCode.Forbidden)
				{
					this.class4_0.method_0(Class185.smethod_0(537683976), Class185.smethod_0(537700909), false);
				}
				httpResponseMessage.EnsureSuccessStatusCode();
				JObject jobject = httpResponseMessage.smethod_0();
				if (this.bool_0)
				{
					JToken jtoken = jobject[Class185.smethod_0(537663037)];
					if (!jtoken.Any<JToken>())
					{
						this.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
						Thread.Sleep(GClass0.int_0);
						continue;
					}
					JToken jtoken2 = jtoken[GForm1.random_0.Next(0, jtoken.Count<JToken>() - 1)];
					this.string_0 = jtoken2[Class185.smethod_0(537703519)].ToString();
					this.class4_0.method_5(jtoken2[Class185.smethod_0(537712143)].ToString());
				}
				else
				{
					JToken jtoken3 = jobject[Class185.smethod_0(537663037)].FirstOrDefault(new Func<JToken, bool>(this.method_15));
					if (jtoken3 == null)
					{
						this.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
						Thread.Sleep(GClass0.int_0);
						continue;
					}
					this.string_0 = jtoken3[Class185.smethod_0(537703519)].ToString();
				}
				this.class4_0.method_4(Class185.smethod_0(537663053) + this.string_0, Class185.smethod_0(537700781), true, false);
				break;
			}
			catch (ThreadAbortException)
			{
				break;
			}
			catch
			{
				Thread.Sleep(GClass0.int_0);
				this.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), true, false);
			}
		}
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x00031FCC File Offset: 0x000301CC
	public void method_3()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537663094), Class185.smethod_0(537662875), true, false);
				JObject jobject = new JObject();
				jobject[Class185.smethod_0(537662856)] = this.string_0;
				jobject[Class185.smethod_0(537662905)] = Class185.smethod_0(537713814);
				HttpResponseMessage httpResponseMessage = this.class70_0.method_9(Class185.smethod_0(537684027), jobject, false);
				if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537662962)))
				{
					this.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
					Thread.Sleep(GClass0.int_0);
					this.method_2();
					continue;
				}
				httpResponseMessage.EnsureSuccessStatusCode();
				this.class4_0.method_4(Class185.smethod_0(537662950), Class185.smethod_0(537700781), true, false);
			}
			catch (ThreadAbortException)
			{
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537662720), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_0);
				continue;
			}
			break;
		}
	}

	// Token: 0x0600054C RID: 1356 RVA: 0x0003211C File Offset: 0x0003031C
	public void method_4()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537662763), Class185.smethod_0(537700781), true, false);
				JObject jobject = new JObject();
				string propertyName = Class185.smethod_0(537662812);
				JObject jobject2 = new JObject();
				jobject2[Class185.smethod_0(537662792)] = this.jtoken_1[Class185.smethod_0(537662788)][Class185.smethod_0(537662792)];
				jobject[propertyName] = jobject2;
				JObject jobject_ = jobject;
				if (!(bool)this.class70_0.method_12(Class185.smethod_0(537684027), jobject_, false).smethod_0()[Class185.smethod_0(537662834)])
				{
					throw new Exception();
				}
				this.class4_0.method_4(Class185.smethod_0(537662827), Class185.smethod_0(537700781), true, false);
			}
			catch (ThreadAbortException)
			{
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537662600), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_0);
				continue;
			}
			break;
		}
	}

	// Token: 0x0600054D RID: 1357 RVA: 0x00032248 File Offset: 0x00030448
	public void method_5()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537662655), Class185.smethod_0(537700781), true, false);
				JObject jobject = new JObject();
				jobject[Class185.smethod_0(537662812)] = new JObject();
				jobject[Class185.smethod_0(537662812)][Class185.smethod_0(537662681)] = new JObject();
				jobject[Class185.smethod_0(537662812)][Class185.smethod_0(537662663)] = new JObject();
				jobject[Class185.smethod_0(537662812)][Class185.smethod_0(537662792)] = this.jtoken_1[Class185.smethod_0(537662788)][Class185.smethod_0(537662792)];
				jobject[Class185.smethod_0(537662812)][Class185.smethod_0(537662693)] = Class185.smethod_0(537708442);
				jobject[Class185.smethod_0(537662812)][Class185.smethod_0(537662681)][Class185.smethod_0(537662478)] = this.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537662508)];
				jobject[Class185.smethod_0(537662812)][Class185.smethod_0(537662681)][Class185.smethod_0(537662557)] = this.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537662540)];
				jobject[Class185.smethod_0(537662812)][Class185.smethod_0(537662681)][Class185.smethod_0(537662588)] = this.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537662571)];
				jobject[Class185.smethod_0(537662812)][Class185.smethod_0(537662681)][Class185.smethod_0(537662567)] = this.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537660310)];
				jobject[Class185.smethod_0(537662812)][Class185.smethod_0(537662681)][Class185.smethod_0(537660290)] = this.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537660290)];
				jobject[Class185.smethod_0(537662812)][Class185.smethod_0(537662681)][Class185.smethod_0(537660349)] = this.method_1((string)this.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)]);
				jobject[Class185.smethod_0(537662812)][Class185.smethod_0(537662681)][Class185.smethod_0(537660380)] = this.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537660362)];
				jobject[Class185.smethod_0(537662812)][Class185.smethod_0(537662681)][Class185.smethod_0(537660356)] = this.jtoken_1[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)];
				jobject[Class185.smethod_0(537662812)][Class185.smethod_0(537662681)][Class185.smethod_0(537660400)] = Class172.smethod_1((string)this.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)], (string)this.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537660385)]);
				jobject[Class185.smethod_0(537662812)][Class185.smethod_0(537662663)][Class185.smethod_0(537662478)] = this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537662508)];
				jobject[Class185.smethod_0(537662812)][Class185.smethod_0(537662663)][Class185.smethod_0(537662557)] = this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537662540)];
				jobject[Class185.smethod_0(537662812)][Class185.smethod_0(537662663)][Class185.smethod_0(537662588)] = this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537662571)];
				jobject[Class185.smethod_0(537662812)][Class185.smethod_0(537662663)][Class185.smethod_0(537662567)] = this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537660310)];
				jobject[Class185.smethod_0(537662812)][Class185.smethod_0(537662663)][Class185.smethod_0(537660290)] = this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537660290)];
				jobject[Class185.smethod_0(537662812)][Class185.smethod_0(537662663)][Class185.smethod_0(537660349)] = this.method_1((string)this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)]);
				jobject[Class185.smethod_0(537662812)][Class185.smethod_0(537662663)][Class185.smethod_0(537660400)] = Class172.smethod_1((string)this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], (string)this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)]);
				jobject[Class185.smethod_0(537662812)][Class185.smethod_0(537662663)][Class185.smethod_0(537660380)] = this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537660362)];
				jobject[Class185.smethod_0(537662812)][Class185.smethod_0(537662663)][Class185.smethod_0(537660356)] = this.jtoken_1[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)];
				jobject[Class185.smethod_0(537662812)][Class185.smethod_0(537662663)][Class185.smethod_0(537660172)] = Class185.smethod_0(537692590);
				jobject[Class185.smethod_0(537662812)][Class185.smethod_0(537660219)] = Class185.smethod_0(537660198);
				HttpResponseMessage httpResponseMessage = this.class70_0.method_12(Class185.smethod_0(537684088), jobject, true);
				httpResponseMessage.EnsureSuccessStatusCode();
				if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537660061)))
				{
					this.class4_0.method_0(Class185.smethod_0(537660087), Class185.smethod_0(537700909), false);
				}
				HtmlDocument htmlDocument = new HtmlDocument();
				htmlDocument.LoadHtml(httpResponseMessage.smethod_3());
				this.string_4 = htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537659823)).Attributes[Class185.smethod_0(537711408)].Value;
				this.string_5 = htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537659664)).Attributes[Class185.smethod_0(537711408)].Value;
				this.string_10 = htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537660126)).Attributes[Class185.smethod_0(537706534)].Value.Split(new char[]
				{
					'/'
				})[4];
				this.string_7 = httpResponseMessage.smethod_3().Replace(Class185.smethod_0(537711014), string.Empty).Split(new string[]
				{
					Class185.smethod_0(537660158)
				}, StringSplitOptions.None)[1].Split(new char[]
				{
					'"'
				})[0];
				this.string_6 = htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537659933)).InnerText.Replace(Class185.smethod_0(537711014), string.Empty).Replace(Class185.smethod_0(537659963), string.Empty);
				this.class4_0.method_4(Class185.smethod_0(537659956) + this.string_10, Class185.smethod_0(537700781), true, false);
				this.class4_0.method_7(htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537659738)).InnerText, Class185.smethod_0(537700781));
			}
			catch (ThreadAbortException)
			{
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537659996), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_0);
				continue;
			}
			break;
		}
	}

	// Token: 0x0600054E RID: 1358 RVA: 0x00032C7C File Offset: 0x00030E7C
	public void method_6()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537660028), Class185.smethod_0(537700781), true, false);
				HttpResponseMessage httpResponseMessage_ = this.class70_0.method_5(Class185.smethod_0(537685944), false);
				HtmlDocument htmlDocument = new HtmlDocument();
				htmlDocument.LoadHtml(httpResponseMessage_.smethod_3());
				this.string_4 = htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537659823)).Attributes[Class185.smethod_0(537711408)].Value;
				this.string_5 = htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537659664)).Attributes[Class185.smethod_0(537711408)].Value;
				this.string_7 = httpResponseMessage_.smethod_3().Replace(Class185.smethod_0(537711014), string.Empty).Split(new string[]
				{
					Class185.smethod_0(537660158)
				}, StringSplitOptions.None)[1].Split(new char[]
				{
					'"'
				})[0];
				this.class4_0.method_4(Class185.smethod_0(537659956) + this.string_10, Class185.smethod_0(537700781), true, false);
				this.class4_0.method_7(htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537659738)).InnerText, Class185.smethod_0(537700781));
			}
			catch (ThreadAbortException)
			{
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537659763), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_0);
				continue;
			}
			break;
		}
	}

	// Token: 0x0600054F RID: 1359 RVA: 0x00032E50 File Offset: 0x00031050
	public void method_7()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537659541), Class185.smethod_0(537700781), true, false);
				Dictionary<string, string> dictionary = Class70.smethod_1();
				dictionary[Class185.smethod_0(537659574)] = Class185.smethod_0(537659556);
				dictionary[Class185.smethod_0(537659600)] = Class185.smethod_0(537713814);
				dictionary[Class185.smethod_0(537659632)] = this.string_4;
				dictionary[Class185.smethod_0(537659440)] = this.string_5;
				this.class70_0.method_7(string.Format(Class185.smethod_0(537685954), this.string_10), dictionary, false);
			}
			catch (ThreadAbortException)
			{
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537661320), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_0);
				continue;
			}
			break;
		}
	}

	// Token: 0x06000550 RID: 1360 RVA: 0x00032F5C File Offset: 0x0003115C
	public void method_8()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537659541), Class185.smethod_0(537700781), true, false);
				JObject jobject = new JObject();
				string propertyName = Class185.smethod_0(537662812);
				JObject jobject2 = new JObject();
				jobject2[Class185.smethod_0(537662693)] = Class185.smethod_0(537713814);
				jobject[propertyName] = jobject2;
				JObject jobject3 = jobject;
				JObject jobject4 = new JObject();
				jobject4[Class185.smethod_0(537661359)] = this.string_4;
				jobject4[Class185.smethod_0(537703519)] = this.string_5;
				JObject content = jobject4;
				jobject3[Class185.smethod_0(537662812)][Class185.smethod_0(537661391)] = new JArray(content);
				this.class70_0.method_12(Class185.smethod_0(537684027), jobject3, false).EnsureSuccessStatusCode();
			}
			catch (ThreadAbortException)
			{
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537661320), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_0);
				continue;
			}
			break;
		}
	}

	// Token: 0x06000551 RID: 1361 RVA: 0x00033098 File Offset: 0x00031298
	public void method_9()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537661418), Class185.smethod_0(537700781), true, false);
				Dictionary<string, string> dictionary = Class70.smethod_1();
				dictionary[Class185.smethod_0(537661206)] = this.string_7;
				dictionary[Class185.smethod_0(537661240)] = (this.string_6.Contains(Class185.smethod_0(537696580)) ? this.string_6.Replace(Class185.smethod_0(537661237), string.Empty) : (this.string_6.Replace(Class185.smethod_0(537661237), string.Empty) + Class185.smethod_0(537661229)));
				HttpResponseMessage httpResponseMessage = this.class70_0.method_7(string.Format(Class185.smethod_0(537685764), this.string_10), dictionary, false);
				httpResponseMessage.EnsureSuccessStatusCode();
				this.string_8 = httpResponseMessage.smethod_0()[Class185.smethod_0(537692633)].ToString();
			}
			catch (ThreadAbortException)
			{
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537661084), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_0);
				continue;
			}
			break;
		}
	}

	// Token: 0x06000552 RID: 1362 RVA: 0x000331EC File Offset: 0x000313EC
	public void method_10()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537661118), Class185.smethod_0(537700781), true, false);
				HttpResponseMessage httpResponseMessage = this.class70_0.method_5(string.Format(Class185.smethod_0(537685885), this.string_8), true);
				httpResponseMessage.EnsureSuccessStatusCode();
				HtmlDocument htmlDocument = new HtmlDocument();
				htmlDocument.LoadHtml(httpResponseMessage.smethod_3());
				foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)htmlDocument.DocumentNode.SelectNodes(Class185.smethod_0(537661018))))
				{
					this.dictionary_0[htmlNode.Attributes[Class185.smethod_0(537712143)].Value] = htmlNode.Attributes[Class185.smethod_0(537711408)].Value;
				}
			}
			catch (ThreadAbortException)
			{
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537661053), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_0);
				continue;
			}
			break;
		}
	}

	// Token: 0x06000553 RID: 1363 RVA: 0x0003332C File Offset: 0x0003152C
	public void method_11()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537660830), Class185.smethod_0(537700964), true, false);
				this.dictionary_0[Class185.smethod_0(537660807)] = this.jtoken_1[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660835)].ToString().Replace(Class185.smethod_0(537711014), string.Empty);
				this.dictionary_0[Class185.smethod_0(537660880)] = (string)this.jtoken_1[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660870)];
				this.dictionary_0[Class185.smethod_0(537660918)] = this.jtoken_1[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660699)].ToString().Substring(2);
				this.dictionary_0[Class185.smethod_0(537660682)] = (string)this.jtoken_1[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660682)];
				this.dictionary_0[Class185.smethod_0(537660676)] = this.string_8;
				HttpResponseMessage httpResponseMessage = this.class70_0.method_7(string.Format(Class185.smethod_0(537685885), this.string_8), this.dictionary_0, false);
				httpResponseMessage.EnsureSuccessStatusCode();
				string text = httpResponseMessage.smethod_3().Split(new string[]
				{
					Class185.smethod_0(537660726)
				}, StringSplitOptions.None)[1].ToLower();
				if (text.Contains(Class185.smethod_0(537708458)) || text.Contains(Class185.smethod_0(537660760)) || text.Contains(Class185.smethod_0(537660756)))
				{
					this.class4_0.method_0(Class185.smethod_0(537660738), Class185.smethod_0(537700909), false);
				}
				this.string_9 = httpResponseMessage.smethod_3().Split(new string[]
				{
					Class185.smethod_0(537660778)
				}, StringSplitOptions.None)[1].Split(new string[]
				{
					Class185.smethod_0(537660545)
				}, StringSplitOptions.None)[0];
			}
			catch (ThreadAbortException)
			{
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537660605), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_0);
				continue;
			}
			break;
		}
	}

	// Token: 0x06000554 RID: 1364 RVA: 0x0003361C File Offset: 0x0003181C
	public void method_12()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537660636), Class185.smethod_0(537700964), true, false);
				Dictionary<string, string> dictionary = Class70.smethod_1();
				dictionary[Class185.smethod_0(537692633)] = this.string_9;
				HttpResponseMessage httpResponseMessage_ = this.class70_0.method_7(Class185.smethod_0(537685745), dictionary, false);
				JObject jobject = httpResponseMessage_.smethod_0();
				if (jobject.ContainsKey(Class185.smethod_0(537710733)))
				{
					if (jobject[Class185.smethod_0(537710733)].ToString().Contains(Class185.smethod_0(537660472)))
					{
						this.class4_0.method_9(true);
						this.class4_0.method_0(Class185.smethod_0(537660452), Class185.smethod_0(537700909), false);
					}
					else
					{
						this.class4_0.method_0(Class185.smethod_0(537660491), Class185.smethod_0(537700909), false);
						GClass3.smethod_0(httpResponseMessage_.smethod_3(), Class185.smethod_0(537710733));
					}
				}
				else if (httpResponseMessage_.smethod_3().Contains(Class185.smethod_0(537660543)))
				{
					this.string_12 = (string)jobject[Class185.smethod_0(537658264)];
				}
				else
				{
					this.class4_0.method_0(Class185.smethod_0(537660491), Class185.smethod_0(537700909), false);
					GClass3.smethod_0(httpResponseMessage_.smethod_3(), Class185.smethod_0(537710733));
				}
			}
			catch (ThreadAbortException)
			{
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537658263), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_0);
				continue;
			}
			break;
		}
	}

	// Token: 0x06000555 RID: 1365 RVA: 0x00033800 File Offset: 0x00031A00
	public void method_13()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537658294), Class185.smethod_0(537700964), true, false);
				HttpResponseMessage httpResponseMessage = this.class70_0.method_5(string.Format(Class185.smethod_0(537685559), this.string_12), false);
				if (httpResponseMessage.StatusCode != HttpStatusCode.Found)
				{
					throw new Exception();
				}
				if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537658352)))
				{
					this.class4_0.method_9(false);
					this.class4_0.method_0(Class185.smethod_0(537658349), Class185.smethod_0(537658124), false);
				}
				else
				{
					this.class4_0.method_9(true);
					this.class4_0.method_0(Class185.smethod_0(537660491), Class185.smethod_0(537700909), false);
				}
			}
			catch (ThreadAbortException)
			{
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537658168), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_0);
				continue;
			}
			break;
		}
	}

	// Token: 0x06000556 RID: 1366 RVA: 0x00033928 File Offset: 0x00031B28
	public void method_14()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537658294), Class185.smethod_0(537700964), true, false);
				Dictionary<string, string> dictionary = Class70.smethod_1();
				dictionary[Class185.smethod_0(537658149)] = Class185.smethod_0(537658192);
				dictionary[Class185.smethod_0(537659574)] = Class185.smethod_0(537659556);
				dictionary[Class185.smethod_0(537658185)] = string.Empty;
				dictionary[Class185.smethod_0(537658226)] = Class185.smethod_0(537658040);
				HttpResponseMessage httpResponseMessage = this.class70_0.method_7(string.Format(Class185.smethod_0(537685581), this.string_10), dictionary, false);
				if (httpResponseMessage.StatusCode != HttpStatusCode.Found)
				{
					throw new Exception();
				}
				if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537658352)))
				{
					this.class4_0.method_9(false);
					this.class4_0.method_0(Class185.smethod_0(537658349), Class185.smethod_0(537658124), false);
				}
				else
				{
					this.class4_0.method_9(true);
					this.class4_0.method_0(Class185.smethod_0(537660491), Class185.smethod_0(537700909), false);
				}
			}
			catch (ThreadAbortException)
			{
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537658168), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_0);
				continue;
			}
			break;
		}
	}

	// Token: 0x06000557 RID: 1367 RVA: 0x0000588F File Offset: 0x00003A8F
	private bool method_15(JToken jtoken_2)
	{
		return Class172.smethod_2(this.string_2, jtoken_2[Class185.smethod_0(537712143)].ToString());
	}

	// Token: 0x0400029B RID: 667
	private Class70 class70_0;

	// Token: 0x0400029C RID: 668
	private JToken jtoken_0;

	// Token: 0x0400029D RID: 669
	private JToken jtoken_1;

	// Token: 0x0400029E RID: 670
	private Class4 class4_0;

	// Token: 0x0400029F RID: 671
	private bool bool_0;

	// Token: 0x040002A0 RID: 672
	private string string_0;

	// Token: 0x040002A1 RID: 673
	private string string_1;

	// Token: 0x040002A2 RID: 674
	private string string_2;

	// Token: 0x040002A3 RID: 675
	private string string_3;

	// Token: 0x040002A4 RID: 676
	private string string_4;

	// Token: 0x040002A5 RID: 677
	private string string_5;

	// Token: 0x040002A6 RID: 678
	private string string_6;

	// Token: 0x040002A7 RID: 679
	private string string_7;

	// Token: 0x040002A8 RID: 680
	private string string_8;

	// Token: 0x040002A9 RID: 681
	private string string_9;

	// Token: 0x040002AA RID: 682
	private Dictionary<string, string> dictionary_0 = new Dictionary<string, string>();

	// Token: 0x040002AB RID: 683
	private string string_10;

	// Token: 0x040002AC RID: 684
	private bool bool_1;

	// Token: 0x040002AD RID: 685
	private string string_11 = Class185.smethod_0(537715750);

	// Token: 0x040002AE RID: 686
	private string string_12;
}
