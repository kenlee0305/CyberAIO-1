using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using HtmlAgilityPack;
using Newtonsoft.Json.Linq;

// Token: 0x02000037 RID: 55
internal sealed class Class27
{
	// Token: 0x06000155 RID: 341 RVA: 0x0000F944 File Offset: 0x0000DB44
	public Class27(JToken jtoken_2)
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

	// Token: 0x06000156 RID: 342 RVA: 0x0000FB18 File Offset: 0x0000DD18
	public void method_0()
	{
		try
		{
			this.class4_0.method_8();
			this.method_2();
			this.method_3();
			this.method_4();
			this.method_5(false);
			if (this.bool_1)
			{
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

	// Token: 0x06000157 RID: 343 RVA: 0x0000FBBC File Offset: 0x0000DDBC
	public string method_1(string string_13)
	{
		HtmlDocument htmlDocument = new HtmlDocument();
		htmlDocument.LoadHtml(this.string_11);
		return htmlDocument.DocumentNode.SelectSingleNode(string.Format(Class185.smethod_0(537663224), string_13)).Attributes[Class185.smethod_0(537711408)].Value;
	}

	// Token: 0x06000158 RID: 344 RVA: 0x0000FC10 File Offset: 0x0000DE10
	public void method_2()
	{
		this.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), true, false);
		for (;;)
		{
			try
			{
				HttpResponseMessage httpResponseMessage = this.class70_0.method_5(this.string_1 + Class185.smethod_0(537662977), true);
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

	// Token: 0x06000159 RID: 345 RVA: 0x0000FE28 File Offset: 0x0000E028
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
				HttpResponseMessage httpResponseMessage = this.class70_0.method_9(Class185.smethod_0(537662888), jobject, false);
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

	// Token: 0x0600015A RID: 346 RVA: 0x0000FF78 File Offset: 0x0000E178
	public void method_4()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537662763), Class185.smethod_0(537700781), true, false);
				JObject jobject = new JObject();
				jobject[Class185.smethod_0(537662812)] = new JObject();
				jobject[Class185.smethod_0(537662812)][Class185.smethod_0(537662792)] = this.jtoken_1[Class185.smethod_0(537662788)][Class185.smethod_0(537662792)];
				if (!(bool)this.class70_0.method_12(Class185.smethod_0(537662888), jobject, false).smethod_0()[Class185.smethod_0(537662834)])
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

	// Token: 0x0600015B RID: 347 RVA: 0x000100B0 File Offset: 0x0000E2B0
	public void method_5(bool bool_2)
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537662655), Class185.smethod_0(537700781), true, false);
				JObject jobject = new JObject();
				string propertyName = Class185.smethod_0(537662812);
				JObject jobject2 = new JObject();
				jobject2[Class185.smethod_0(537662681)] = new JObject();
				jobject2[Class185.smethod_0(537662663)] = new JObject();
				jobject2[Class185.smethod_0(537662792)] = this.jtoken_1[Class185.smethod_0(537662788)][Class185.smethod_0(537662792)];
				jobject2[Class185.smethod_0(537662693)] = Class185.smethod_0(537708442);
				object key = Class185.smethod_0(537662478);
				jobject2[Class185.smethod_0(537662681)][key] = this.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537662508)];
				object key2 = Class185.smethod_0(537662557);
				jobject2[Class185.smethod_0(537662681)][key2] = this.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537662540)];
				object key3 = Class185.smethod_0(537662588);
				jobject2[Class185.smethod_0(537662681)][key3] = this.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537662571)];
				object key4 = Class185.smethod_0(537662567);
				jobject2[Class185.smethod_0(537662681)][key4] = this.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537660310)];
				object key5 = Class185.smethod_0(537660290);
				jobject2[Class185.smethod_0(537662681)][key5] = this.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537660290)];
				object key6 = Class185.smethod_0(537660349);
				jobject2[Class185.smethod_0(537662681)][key6] = this.method_1((string)this.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)]);
				object key7 = Class185.smethod_0(537660380);
				jobject2[Class185.smethod_0(537662681)][key7] = this.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537660362)];
				object key8 = Class185.smethod_0(537660356);
				jobject2[Class185.smethod_0(537662681)][key8] = this.jtoken_1[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)];
				object key9 = Class185.smethod_0(537660400);
				jobject2[Class185.smethod_0(537662681)][key9] = Class172.smethod_1((string)this.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)], (string)this.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537660385)]);
				object key10 = Class185.smethod_0(537662478);
				jobject2[Class185.smethod_0(537662663)][key10] = this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537662508)];
				object key11 = Class185.smethod_0(537662557);
				jobject2[Class185.smethod_0(537662663)][key11] = this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537662540)];
				object key12 = Class185.smethod_0(537662588);
				jobject2[Class185.smethod_0(537662663)][key12] = this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537662571)];
				object key13 = Class185.smethod_0(537662567);
				jobject2[Class185.smethod_0(537662663)][key13] = this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537660310)];
				object key14 = Class185.smethod_0(537660290);
				jobject2[Class185.smethod_0(537662663)][key14] = this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537660290)];
				object key15 = Class185.smethod_0(537660349);
				jobject2[Class185.smethod_0(537662663)][key15] = this.method_1((string)this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)]);
				object key16 = Class185.smethod_0(537660400);
				jobject2[Class185.smethod_0(537662663)][key16] = Class172.smethod_1((string)this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], (string)this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)]);
				object key17 = Class185.smethod_0(537660380);
				jobject2[Class185.smethod_0(537662663)][key17] = this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537660362)];
				object key18 = Class185.smethod_0(537660356);
				jobject2[Class185.smethod_0(537662663)][key18] = this.jtoken_1[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)];
				object key19 = Class185.smethod_0(537660172);
				jobject2[Class185.smethod_0(537662663)][key19] = Class185.smethod_0(537692590);
				jobject2[Class185.smethod_0(537660219)] = Class185.smethod_0(537660198);
				jobject[propertyName] = jobject2;
				JObject jobject_ = jobject;
				HttpResponseMessage httpResponseMessage = this.class70_0.method_12(Class185.smethod_0(537660240), jobject_, bool_2);
				if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537660061)))
				{
					this.class4_0.method_0(Class185.smethod_0(537660087), Class185.smethod_0(537700909), false);
				}
				if (bool_2)
				{
					HtmlDocument htmlDocument = new HtmlDocument();
					htmlDocument.LoadHtml(httpResponseMessage.smethod_3());
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
				}
				else
				{
					this.string_10 = httpResponseMessage.Headers.Location.ToString().Split(new char[]
					{
						'/'
					})[4];
				}
				this.class4_0.method_4(Class185.smethod_0(537659956) + this.string_10, Class185.smethod_0(537700781), true, false);
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

	// Token: 0x0600015C RID: 348 RVA: 0x00010958 File Offset: 0x0000EB58
	public void method_6()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537660028), Class185.smethod_0(537700781), true, false);
				HttpResponseMessage httpResponseMessage_ = this.class70_0.method_5(Class185.smethod_0(537659800), false);
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

	// Token: 0x0600015D RID: 349 RVA: 0x00010B2C File Offset: 0x0000ED2C
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
				this.class70_0.method_7(string.Format(Class185.smethod_0(537659465), this.string_10), dictionary, false);
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

	// Token: 0x0600015E RID: 350 RVA: 0x00010C38 File Offset: 0x0000EE38
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
				this.class70_0.method_12(Class185.smethod_0(537662888), jobject3, false).EnsureSuccessStatusCode();
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

	// Token: 0x0600015F RID: 351 RVA: 0x00010D74 File Offset: 0x0000EF74
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
				HttpResponseMessage httpResponseMessage = this.class70_0.method_7(string.Format(Class185.smethod_0(537661222), this.string_10), dictionary, false);
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

	// Token: 0x06000160 RID: 352 RVA: 0x00010EC8 File Offset: 0x0000F0C8
	public void method_10()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537661118), Class185.smethod_0(537700781), true, false);
				HttpResponseMessage httpResponseMessage = this.class70_0.method_5(string.Format(Class185.smethod_0(537661145), this.string_8), true);
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

	// Token: 0x06000161 RID: 353 RVA: 0x00011008 File Offset: 0x0000F208
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
				HttpResponseMessage httpResponseMessage = this.class70_0.method_7(string.Format(Class185.smethod_0(537661145), this.string_8), this.dictionary_0, false);
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

	// Token: 0x06000162 RID: 354 RVA: 0x000112F8 File Offset: 0x0000F4F8
	public void method_12()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537660636), Class185.smethod_0(537700964), true, false);
				Dictionary<string, string> dictionary = Class70.smethod_1();
				dictionary[Class185.smethod_0(537692633)] = this.string_9;
				HttpResponseMessage httpResponseMessage_ = this.class70_0.method_7(Class185.smethod_0(537660613), dictionary, false);
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

	// Token: 0x06000163 RID: 355 RVA: 0x000114DC File Offset: 0x0000F6DC
	public void method_13()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537658294), Class185.smethod_0(537700964), true, false);
				HttpResponseMessage httpResponseMessage = this.class70_0.method_5(string.Format(Class185.smethod_0(537658333), this.string_12), false);
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

	// Token: 0x06000164 RID: 356 RVA: 0x00011604 File Offset: 0x0000F804
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
				HttpResponseMessage httpResponseMessage = this.class70_0.method_7(string.Format(Class185.smethod_0(537658033), this.string_10), dictionary, false);
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

	// Token: 0x06000165 RID: 357 RVA: 0x00003A3B File Offset: 0x00001C3B
	private bool method_15(JToken jtoken_2)
	{
		return Class172.smethod_2(this.string_2, jtoken_2[Class185.smethod_0(537712143)].ToString());
	}

	// Token: 0x040000AE RID: 174
	private Class70 class70_0;

	// Token: 0x040000AF RID: 175
	private JToken jtoken_0;

	// Token: 0x040000B0 RID: 176
	private JToken jtoken_1;

	// Token: 0x040000B1 RID: 177
	private Class4 class4_0;

	// Token: 0x040000B2 RID: 178
	private bool bool_0;

	// Token: 0x040000B3 RID: 179
	private string string_0;

	// Token: 0x040000B4 RID: 180
	private string string_1;

	// Token: 0x040000B5 RID: 181
	private string string_2;

	// Token: 0x040000B6 RID: 182
	private string string_3;

	// Token: 0x040000B7 RID: 183
	private string string_4;

	// Token: 0x040000B8 RID: 184
	private string string_5;

	// Token: 0x040000B9 RID: 185
	private string string_6;

	// Token: 0x040000BA RID: 186
	private string string_7;

	// Token: 0x040000BB RID: 187
	private string string_8;

	// Token: 0x040000BC RID: 188
	private string string_9;

	// Token: 0x040000BD RID: 189
	private Dictionary<string, string> dictionary_0 = new Dictionary<string, string>();

	// Token: 0x040000BE RID: 190
	private string string_10;

	// Token: 0x040000BF RID: 191
	private bool bool_1 = true;

	// Token: 0x040000C0 RID: 192
	private string string_11 = Class185.smethod_0(537715750);

	// Token: 0x040000C1 RID: 193
	private string string_12;
}
