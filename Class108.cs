using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using HtmlAgilityPack;
using Newtonsoft.Json.Linq;

// Token: 0x020000C8 RID: 200
internal sealed class Class108
{
	// Token: 0x06000530 RID: 1328 RVA: 0x0002C598 File Offset: 0x0002A798
	public Class108(JToken jtoken_2, string string_12)
	{
		try
		{
			this.jtoken_1 = jtoken_2;
			this.class4_0 = new Class4(jtoken_2);
			this.string_0 = (string)jtoken_2[Class185.smethod_0(537702300)];
			this.string_2 = string_12;
			if (!((string)jtoken_2[Class185.smethod_0(537700008)] == Class185.smethod_0(537663132)) && !((string)jtoken_2[Class185.smethod_0(537700008)] == Class185.smethod_0(537663113)))
			{
				this.string_3 = (string)jtoken_2[Class185.smethod_0(537700008)];
			}
			else
			{
				this.string_3 = GClass2.smethod_1();
				this.class4_0.method_5(this.string_3);
			}
			this.string_3 = Class172.smethod_4(this.string_3);
			if (!this.string_3.Contains(Class185.smethod_0(537669999)) && this.string_3.Replace(Class185.smethod_0(537696580), string.Empty).smethod_0())
			{
				this.string_3 += Class185.smethod_0(537661229);
			}
			if (this.string_3.Length == 3)
			{
				this.string_3 = Class185.smethod_0(537708442) + this.string_3;
			}
			if (!this.class4_0.method_3(out this.jtoken_0))
			{
				this.class4_0.method_0(Class185.smethod_0(537663358), Class185.smethod_0(537700909), true);
			}
			else
			{
				this.string_10 = this.class4_0.method_6();
				this.class70_0 = new Class70(this.string_10, Class185.smethod_0(537692910), 10, false, false, null, false);
				this.class70_0.httpClient_0.DefaultRequestHeaders.TryAddWithoutValidation(Class185.smethod_0(537669784), string.Format(Class185.smethod_0(537669781), string_12));
				this.class70_0.httpClient_0.DefaultRequestHeaders.TryAddWithoutValidation(Class185.smethod_0(537663147), string.Format(Class185.smethod_0(537669781), string_12));
				this.class70_0.httpClient_0.DefaultRequestHeaders.TryAddWithoutValidation(Class185.smethod_0(537701050), Class185.smethod_0(537669819));
				this.class70_0.httpClient_0.DefaultRequestHeaders.TryAddWithoutValidation(Class185.smethod_0(537713877), Class185.smethod_0(537713862));
				this.class70_0.httpClient_0.DefaultRequestHeaders.ExpectContinue = new bool?(false);
				this.string_11 = Class108.smethod_0(32);
			}
		}
		catch
		{
			this.class4_0.method_0(Class185.smethod_0(537663193), Class185.smethod_0(537700909), true);
		}
	}

	// Token: 0x06000531 RID: 1329 RVA: 0x0002C87C File Offset: 0x0002AA7C
	public void method_0()
	{
		try
		{
			this.class4_0.method_8();
			this.method_8();
			this.class4_0.method_13(this.int_0, Class185.smethod_0(537669813), 0);
			this.method_9();
			this.method_10();
			this.method_11();
			this.method_12();
			this.method_13();
			this.method_15();
		}
		catch
		{
		}
		finally
		{
			this.class4_0.method_0(Class185.smethod_0(537663178), Class185.smethod_0(537700909), true);
		}
	}

	// Token: 0x06000532 RID: 1330 RVA: 0x00005817 File Offset: 0x00003A17
	public void method_1()
	{
		this.method_9();
		this.method_10();
		this.method_11();
		this.method_12();
		this.method_13();
		this.method_14();
		this.method_15();
	}

	// Token: 0x06000533 RID: 1331 RVA: 0x00005843 File Offset: 0x00003A43
	public static string smethod_0(int int_1)
	{
		return new string(Enumerable.Repeat<string>(Class185.smethod_0(537714138), int_1).Select(new Func<string, char>(Class108.Class109.class109_0.method_0)).ToArray<char>());
	}

	// Token: 0x06000534 RID: 1332 RVA: 0x0002C91C File Offset: 0x0002AB1C
	public string method_2(string string_12)
	{
		switch (string_12[0])
		{
		case '3':
			return Class185.smethod_0(537669832);
		case '4':
			return Class185.smethod_0(537669796);
		case '5':
			return Class185.smethod_0(537669855);
		default:
			return Class185.smethod_0(537669855);
		}
	}

	// Token: 0x06000535 RID: 1333 RVA: 0x0002C974 File Offset: 0x0002AB74
	public bool method_3(HttpResponseMessage httpResponseMessage_0)
	{
		if (httpResponseMessage_0.smethod_3().Contains(Class185.smethod_0(537669827)))
		{
			this.method_10();
			return true;
		}
		if (httpResponseMessage_0.StatusCode == HttpStatusCode.Found && httpResponseMessage_0.Headers.Location.ToString() == Class185.smethod_0(537669875))
		{
			this.class4_0.method_0(Class185.smethod_0(537669652), Class185.smethod_0(537700909), false);
			return false;
		}
		if (httpResponseMessage_0.smethod_3().Contains(Class185.smethod_0(537669692)))
		{
			Thread.Sleep(1000);
			if (this.cookieCollection_0 != null)
			{
				this.class70_0.cookieContainer_0.Add(this.cookieCollection_0);
			}
			return true;
		}
		if (httpResponseMessage_0.smethod_3().Contains(Class185.smethod_0(537669666)))
		{
			this.method_1();
			return true;
		}
		if (httpResponseMessage_0.StatusCode == HttpStatusCode.Forbidden)
		{
			this.class4_0.method_4(Class185.smethod_0(537669715), Class185.smethod_0(537700909), true, false);
			Thread.Sleep(GClass0.int_1);
			return true;
		}
		return false;
	}

	// Token: 0x06000536 RID: 1334 RVA: 0x0002CA8C File Offset: 0x0002AC8C
	public void method_4()
	{
		this.class4_0.method_4(Class185.smethod_0(537669754), Class185.smethod_0(537700781), true, false);
		Cookie cookie = new Cookie(Class185.smethod_0(537669732), string.Empty);
		cookie.Expired = true;
		this.class70_0.cookieContainer_0.Add(new Uri(string.Format(Class185.smethod_0(537671573), this.string_2)), cookie);
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537669754), Class185.smethod_0(537700781), true, false);
				this.string_4 = this.class70_0.method_5(string.Format(Class185.smethod_0(537671612), this.string_2), true).smethod_0()[Class185.smethod_0(537706797)][Class185.smethod_0(537671643)].ToString();
				break;
			}
			catch (ThreadAbortException)
			{
				break;
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537671628), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_1);
			}
		}
	}

	// Token: 0x06000537 RID: 1335 RVA: 0x0002CBCC File Offset: 0x0002ADCC
	public void method_5()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537669754), Class185.smethod_0(537700781), true, false);
				HttpResponseMessage httpResponseMessage_ = new Class70(null, Class185.smethod_0(537692910), 10, false, false, null, false).method_5(this.string_0, true);
				HtmlDocument htmlDocument = new HtmlDocument();
				htmlDocument.LoadHtml(httpResponseMessage_.smethod_3());
				if (htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537671660)) != null)
				{
					this.string_4 = htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537671660)).Attributes[Class185.smethod_0(537711408)].Value;
				}
				Console.WriteLine(this.string_4);
			}
			catch (ThreadAbortException)
			{
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537671628), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_1);
				continue;
			}
			break;
		}
	}

	// Token: 0x06000538 RID: 1336 RVA: 0x0002CCD8 File Offset: 0x0002AED8
	public void method_6()
	{
		for (;;)
		{
			try
			{
			}
			catch (ThreadAbortException)
			{
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537671436), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_1);
				continue;
			}
			break;
		}
	}

	// Token: 0x06000539 RID: 1337 RVA: 0x0002CD38 File Offset: 0x0002AF38
	public void method_7()
	{
		if ((string)this.jtoken_1[Class185.smethod_0(537700008)] == Class185.smethod_0(537663132))
		{
			this.string_3 = GClass2.smethod_1();
			this.class4_0.method_5(this.string_3);
			if (!this.string_3.Contains(Class185.smethod_0(537669999)))
			{
				this.string_3 += Class185.smethod_0(537661229);
			}
			if (this.string_3.Length == 3)
			{
				this.string_3 = Class185.smethod_0(537708442) + this.string_3;
			}
		}
	}

	// Token: 0x0600053A RID: 1338 RVA: 0x0002CDE8 File Offset: 0x0002AFE8
	public void method_8()
	{
		HtmlDocument htmlDocument = new HtmlDocument();
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537671464), Class185.smethod_0(537700781), true, false);
				HttpResponseMessage httpResponseMessage = this.class70_0.method_5(this.string_0, false);
				if (!this.method_3(httpResponseMessage))
				{
					httpResponseMessage.EnsureSuccessStatusCode();
					htmlDocument.LoadHtml(httpResponseMessage.smethod_3());
					this.string_4 = htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537671660)).Attributes[Class185.smethod_0(537711408)].Value;
					this.string_1 = htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537671518)).Attributes[Class185.smethod_0(537711408)].Value;
					if (!this.string_0.Contains(this.string_1))
					{
						this.class4_0.method_0(Class185.smethod_0(537671545), Class185.smethod_0(537700909), false);
					}
					if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537671534)) && this.string_2 != Class185.smethod_0(537700307))
					{
						this.int_0 = Convert.ToInt32(httpResponseMessage.smethod_3().Split(new string[]
						{
							Class185.smethod_0(537671310)
						}, StringSplitOptions.None)[1].Split(new char[]
						{
							';'
						})[0]) - 1;
					}
					else if (this.string_2 == Class185.smethod_0(537700307) && !httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537671330)))
					{
						this.int_0 = Convert.ToInt32(httpResponseMessage.smethod_3().Split(new string[]
						{
							Class185.smethod_0(537671371)
						}, StringSplitOptions.None)[1].Split(new char[]
						{
							';'
						})[0]) - 1;
					}
					break;
				}
			}
			catch (ThreadAbortException)
			{
				return;
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537671409), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_1);
			}
		}
		try
		{
			if (!(this.string_2 == Class185.smethod_0(537700330)) && !(this.string_2 == Class185.smethod_0(537700271)))
			{
				this.class4_0.method_7(htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537671225)).Attributes[Class185.smethod_0(537711408)].Value, Class185.smethod_0(537700781));
			}
			else
			{
				this.class4_0.method_7(htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537671197)).InnerText, Class185.smethod_0(537700781));
			}
			return;
		}
		catch (ThreadAbortException)
		{
		}
		catch
		{
			return;
		}
	}

	// Token: 0x0600053B RID: 1339 RVA: 0x0002D11C File Offset: 0x0002B31C
	public void method_9()
	{
		int num = 1;
		this.class4_0.method_4(Class185.smethod_0(537663094), Class185.smethod_0(537700781), true, false);
		Dictionary<string, string> dictionary = Class70.smethod_1();
		dictionary[Class185.smethod_0(537671257)] = Class185.smethod_0(537671232);
		dictionary[Class185.smethod_0(537669732)] = this.string_4;
		dictionary[Class185.smethod_0(537671291)] = this.string_1;
		dictionary[Class185.smethod_0(537671285)] = Class185.smethod_0(537713814);
		dictionary[Class185.smethod_0(537700008)] = this.string_3;
		dictionary[Class185.smethod_0(537662905)] = Class185.smethod_0(537713814);
		dictionary[Class185.smethod_0(537671279)] = Class185.smethod_0(537713814);
		for (;;)
		{
			try
			{
				if (num == 1)
				{
					HttpResponseMessage httpResponseMessage = this.class70_0.method_7(string.Format(Class185.smethod_0(537671061), this.string_2), dictionary, false);
					if (this.method_3(httpResponseMessage))
					{
						continue;
					}
					httpResponseMessage.EnsureSuccessStatusCode();
					if (httpResponseMessage.smethod_3().ToLower().Contains(Class185.smethod_0(537671120)) || httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537671107)))
					{
						this.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
						Thread.Sleep(GClass0.int_0);
						this.method_7();
						num++;
						continue;
					}
					if ((bool)httpResponseMessage.smethod_0()[Class185.smethod_0(537671148)])
					{
						this.string_4 = httpResponseMessage.smethod_0()[Class185.smethod_0(537670938)].ToString();
						this.class4_0.method_4(Class185.smethod_0(537662950), Class185.smethod_0(537700781), true, false);
						break;
					}
				}
				else if (num == 2)
				{
					HttpResponseMessage httpResponseMessage = this.class70_0.method_5(string.Format(Class185.smethod_0(537670927), new object[]
					{
						this.string_2,
						this.string_4,
						this.string_1,
						this.string_3
					}), true);
					if (this.method_3(httpResponseMessage))
					{
						continue;
					}
					httpResponseMessage.EnsureSuccessStatusCode();
					if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537670824)) || httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537671107)))
					{
						this.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
						Thread.Sleep(GClass0.int_0);
						this.method_7();
						num++;
						continue;
					}
					if ((bool)httpResponseMessage.smethod_0()[Class185.smethod_0(537671148)])
					{
						this.string_4 = httpResponseMessage.smethod_0()[Class185.smethod_0(537706797)][Class185.smethod_0(537671643)].ToString();
						this.class4_0.method_4(Class185.smethod_0(537662950), Class185.smethod_0(537700781), true, false);
						break;
					}
				}
				else
				{
					if (num != 3)
					{
						num = 1;
						continue;
					}
					HttpResponseMessage httpResponseMessage = this.class70_0.method_7(string.Format(Class185.smethod_0(537670864), this.string_2), dictionary, false);
					if (this.method_3(httpResponseMessage))
					{
						continue;
					}
					httpResponseMessage.EnsureSuccessStatusCode();
					if (httpResponseMessage.smethod_3().ToLower().Contains(Class185.smethod_0(537671120)) || httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537671107)))
					{
						this.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
						Thread.Sleep(GClass0.int_0);
						this.method_7();
						num++;
						continue;
					}
					if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537670880)))
					{
						this.string_4 = httpResponseMessage.smethod_3().Split(new string[]
						{
							Class185.smethod_0(537670677)
						}, StringSplitOptions.None)[1].Split(new char[]
						{
							'"'
						})[0];
						this.class4_0.method_4(Class185.smethod_0(537662950), Class185.smethod_0(537700781), true, false);
						break;
					}
				}
				throw new Exception();
			}
			catch (ThreadAbortException)
			{
				break;
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537662720), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_1);
				this.method_7();
				num++;
				this.class4_0.method_4(Class185.smethod_0(537663094), Class185.smethod_0(537700781), true, false);
			}
		}
	}

	// Token: 0x0600053C RID: 1340 RVA: 0x0002D618 File Offset: 0x0002B818
	public void method_10()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537670717), Class185.smethod_0(537700781), true, false);
				HttpResponseMessage httpResponseMessage_ = this.class70_0.method_5(string.Format(Class185.smethod_0(537670694), this.string_2, this.string_4), true);
				while (Convert.ToInt16(httpResponseMessage_.smethod_0()[Class185.smethod_0(537706797)][Class185.smethod_0(537668574)][Class185.smethod_0(537668543)].ToString()) > 0)
				{
					this.class4_0.method_4(Class185.smethod_0(537668503), Class185.smethod_0(537700781), true, false);
					Thread.Sleep((int)(Convert.ToInt16(httpResponseMessage_.smethod_0()[Class185.smethod_0(537706797)][Class185.smethod_0(537668543)].ToString()) * 1000));
				}
				if (httpResponseMessage_.smethod_0()[Class185.smethod_0(537706797)][Class185.smethod_0(537668554)][Class185.smethod_0(537668602)].Any<JToken>())
				{
					this.class4_0.method_4(Class185.smethod_0(537668576), Class185.smethod_0(537700781), true, false);
					Thread.Sleep(GClass0.int_1);
					this.method_1();
				}
				else if (!object.Equals(false, (bool)httpResponseMessage_.smethod_0()[Class185.smethod_0(537706797)][Class185.smethod_0(537660385)][Class185.smethod_0(537668367)]))
				{
					throw new Exception();
				}
			}
			catch (ThreadAbortException)
			{
			}
			catch (ArgumentException)
			{
			}
			catch (FormatException)
			{
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537668392), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_1);
				continue;
			}
			break;
		}
	}

	// Token: 0x0600053D RID: 1341 RVA: 0x0002D870 File Offset: 0x0002BA70
	public void method_11()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537668439), Class185.smethod_0(537700781), true, false);
				HttpResponseMessage httpResponseMessage = this.class70_0.method_5(string.Format(Class185.smethod_0(537668470), this.string_2), true);
				if (this.method_3(httpResponseMessage))
				{
					continue;
				}
				httpResponseMessage.EnsureSuccessStatusCode();
				HtmlDocument htmlDocument = new HtmlDocument();
				htmlDocument.LoadHtml(httpResponseMessage.smethod_3());
				this.string_5 = htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537668228)).Attributes[Class185.smethod_0(537711408)].Value;
				this.string_4 = htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537671660)).Attributes[Class185.smethod_0(537711408)].Value;
			}
			catch (ThreadAbortException)
			{
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537668269), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_1);
				continue;
			}
			break;
		}
	}

	// Token: 0x0600053E RID: 1342 RVA: 0x0002D9A0 File Offset: 0x0002BBA0
	public void method_12()
	{
		this.cookieCollection_0 = this.class70_0.cookieContainer_0.GetCookies(new Uri(string.Format(Class185.smethod_0(537669781), this.string_2)));
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537668290), Class185.smethod_0(537700781), true, false);
				Dictionary<string, string> dictionary = Class70.smethod_1();
				string value = Class185.smethod_0(537668321);
				dictionary[Class185.smethod_0(537669732)] = this.string_4;
				dictionary[Class185.smethod_0(537667733)] = this.string_5;
				dictionary[Class185.smethod_0(537667727)] = Class185.smethod_0(537692590);
				dictionary[Class185.smethod_0(537667752)] = Class185.smethod_0(537667806);
				dictionary[Class185.smethod_0(537667784)] = Class185.smethod_0(537667827);
				dictionary[Class185.smethod_0(537667808)] = Class172.smethod_0((string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)], false);
				dictionary[Class185.smethod_0(537667602)] = Class185.smethod_0(537667647);
				dictionary[Class185.smethod_0(537667624)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662508)];
				dictionary[Class185.smethod_0(537667676)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662540)];
				dictionary[Class185.smethod_0(537667663)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662571)];
				dictionary[Class185.smethod_0(537667698)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660310)];
				dictionary[Class185.smethod_0(537667685)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660362)];
				dictionary[Class185.smethod_0(537669514)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660290)];
				dictionary[Class185.smethod_0(537669561)] = Class172.smethod_1((string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)], (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660385)]);
				dictionary[Class185.smethod_0(537669545)] = Class172.smethod_1((string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)], (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660385)]);
				dictionary[Class185.smethod_0(537669596)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)];
				dictionary[Class185.smethod_0(537669568)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537662792)];
				dictionary[Class185.smethod_0(537669623)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537662792)];
				dictionary[Class185.smethod_0(537669406)] = Class185.smethod_0(537669380);
				dictionary[Class185.smethod_0(537669428)] = Class185.smethod_0(537667827);
				dictionary[Class185.smethod_0(537669471)] = Class172.smethod_0((string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], false);
				dictionary[Class185.smethod_0(537669441)] = Class185.smethod_0(537669486);
				dictionary[Class185.smethod_0(537669479)] = Class185.smethod_0(537692774);
				dictionary[Class185.smethod_0(537669257)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662508)];
				dictionary[Class185.smethod_0(537669309)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662540)];
				dictionary[Class185.smethod_0(537669280)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662571)];
				dictionary[Class185.smethod_0(537669331)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660310)];
				dictionary[Class185.smethod_0(537669318)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660362)];
				dictionary[Class185.smethod_0(537669355)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660290)];
				dictionary[Class185.smethod_0(537669146)] = Class172.smethod_1((string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)]);
				dictionary[Class185.smethod_0(537669130)] = Class172.smethod_1((string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)]);
				dictionary[Class185.smethod_0(537669181)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)];
				dictionary[Class185.smethod_0(537669153)] = value;
				HttpResponseMessage httpResponseMessage = this.class70_0.method_7(string.Format(Class185.smethod_0(537669196), this.string_2), dictionary, false);
				if (!this.method_3(httpResponseMessage))
				{
					httpResponseMessage.EnsureSuccessStatusCode();
					JObject jobject = JObject.Parse(httpResponseMessage.smethod_3().Substring(2, httpResponseMessage.smethod_3().Length - 2));
					if (jobject[Class185.smethod_0(537668992)].ToString() != Class185.smethod_0(537710839))
					{
						throw new Exception();
					}
					if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537669044)))
					{
						this.class4_0.method_0(Class185.smethod_0(537669105), Class185.smethod_0(537700909), false);
					}
					this.string_4 = jobject[Class185.smethod_0(537668892)].ToString();
					this.string_5 = jobject[Class185.smethod_0(537667733)].ToString();
					if (this.string_2 == Class185.smethod_0(537700271))
					{
						this.string_8 = jobject[Class185.smethod_0(537668877)][Class185.smethod_0(537668914)].ToString();
						this.string_9 = jobject[Class185.smethod_0(537668877)][Class185.smethod_0(537668958)].ToString();
					}
					else if (jobject[Class185.smethod_0(537668877)][Class185.smethod_0(537668986)].Any<JToken>())
					{
						this.string_8 = jobject[Class185.smethod_0(537668877)][Class185.smethod_0(537668986)][0][Class185.smethod_0(537668973)].ToString();
						this.string_9 = jobject[Class185.smethod_0(537668877)][Class185.smethod_0(537668986)][0][Class185.smethod_0(537668758)].ToString();
					}
					else
					{
						this.string_8 = jobject[Class185.smethod_0(537668877)][Class185.smethod_0(537668958)].ToString();
						this.string_9 = jobject[Class185.smethod_0(537668877)][Class185.smethod_0(537668914)].ToString();
					}
					this.string_7 = jobject[Class185.smethod_0(537668795)][Class185.smethod_0(537668778)].ToString();
					break;
				}
			}
			catch (ThreadAbortException)
			{
				break;
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537668825), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_1);
			}
		}
	}

	// Token: 0x0600053F RID: 1343 RVA: 0x0002E3CC File Offset: 0x0002C5CC
	public void method_13()
	{
		this.cookieCollection_0 = this.class70_0.cookieContainer_0.GetCookies(new Uri(string.Format(Class185.smethod_0(537669781), this.string_2)));
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537659541), Class185.smethod_0(537700781), true, false);
				Dictionary<string, string> dictionary = Class70.smethod_1();
				dictionary[Class185.smethod_0(537669153)] = string.Format(Class185.smethod_0(537668862), new object[]
				{
					(string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662508)],
					(string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662540)],
					(string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662571)],
					(string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660310)],
					(string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660290)],
					Class172.smethod_1((string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)], (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660385)]),
					Class172.smethod_1((string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)], (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660385)]),
					(string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660362)],
					(string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)],
					Class172.smethod_0((string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)], false),
					(string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537662792)],
					(string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537662792)],
					(string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662508)],
					(string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662540)],
					(string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662571)],
					(string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660310)],
					(string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660290)],
					Class172.smethod_1((string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)]),
					Class172.smethod_1((string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)]),
					(string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660362)],
					(string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)],
					Class172.smethod_0((string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], false),
					this.string_7,
					this.string_9,
					this.string_8
				});
				dictionary[Class185.smethod_0(537669732)] = this.string_4;
				dictionary[Class185.smethod_0(537667733)] = this.string_5;
				dictionary[Class185.smethod_0(537667727)] = Class185.smethod_0(537692590);
				dictionary[Class185.smethod_0(537667752)] = Class185.smethod_0(537667806);
				dictionary[Class185.smethod_0(537667784)] = Class185.smethod_0(537667827);
				dictionary[Class185.smethod_0(537667808)] = Class172.smethod_0((string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)], false);
				dictionary[Class185.smethod_0(537667602)] = Class185.smethod_0(537667647);
				dictionary[Class185.smethod_0(537667624)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662508)];
				dictionary[Class185.smethod_0(537667676)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662540)];
				dictionary[Class185.smethod_0(537667663)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662571)];
				dictionary[Class185.smethod_0(537667698)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660310)];
				dictionary[Class185.smethod_0(537667685)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660362)];
				dictionary[Class185.smethod_0(537669514)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660290)];
				dictionary[Class185.smethod_0(537669561)] = Class172.smethod_1((string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)], (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660385)]);
				dictionary[Class185.smethod_0(537669545)] = Class172.smethod_1((string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)], (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660385)]);
				dictionary[Class185.smethod_0(537669596)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)];
				dictionary[Class185.smethod_0(537669568)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537662792)];
				dictionary[Class185.smethod_0(537669623)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537662792)];
				dictionary[Class185.smethod_0(537669406)] = Class185.smethod_0(537669380);
				dictionary[Class185.smethod_0(537669428)] = Class185.smethod_0(537667827);
				dictionary[Class185.smethod_0(537669471)] = Class172.smethod_0((string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], false);
				dictionary[Class185.smethod_0(537669441)] = Class185.smethod_0(537669486);
				dictionary[Class185.smethod_0(537669479)] = Class185.smethod_0(537692774);
				dictionary[Class185.smethod_0(537669257)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662508)];
				dictionary[Class185.smethod_0(537669309)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662540)];
				dictionary[Class185.smethod_0(537669280)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662571)];
				dictionary[Class185.smethod_0(537669331)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660310)];
				dictionary[Class185.smethod_0(537669318)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660362)];
				dictionary[Class185.smethod_0(537669355)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660290)];
				dictionary[Class185.smethod_0(537669146)] = Class172.smethod_1((string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)]);
				dictionary[Class185.smethod_0(537669130)] = Class172.smethod_1((string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)]);
				dictionary[Class185.smethod_0(537669181)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)];
				dictionary[Class185.smethod_0(537665700)] = this.string_9;
				HttpResponseMessage httpResponseMessage = this.class70_0.method_7(string.Format(Class185.smethod_0(537665737), this.string_2), dictionary, false);
				if (!this.method_3(httpResponseMessage))
				{
					httpResponseMessage.EnsureSuccessStatusCode();
					JObject jobject = JObject.Parse(httpResponseMessage.smethod_3().Substring(2, httpResponseMessage.smethod_3().Length - 2));
					if (jobject[Class185.smethod_0(537668992)].ToString() != Class185.smethod_0(537710839))
					{
						throw new Exception();
					}
					this.string_4 = jobject[Class185.smethod_0(537668892)].ToString();
					this.string_5 = jobject[Class185.smethod_0(537667733)].ToString();
					this.string_6 = jobject[Class185.smethod_0(537665539)][Class185.smethod_0(537665579)].ToString();
					break;
				}
			}
			catch (ThreadAbortException)
			{
				break;
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537665573), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_1);
			}
		}
	}

	// Token: 0x06000540 RID: 1344 RVA: 0x0002F120 File Offset: 0x0002D320
	public void method_14()
	{
		this.cookieCollection_0 = this.class70_0.cookieContainer_0.GetCookies(new Uri(string.Format(Class185.smethod_0(537669781), this.string_2)));
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537660830), Class185.smethod_0(537700781), true, false);
				Dictionary<string, string> dictionary = Class70.smethod_1();
				dictionary[Class185.smethod_0(537669153)] = string.Concat(new string[]
				{
					string.Format(Class185.smethod_0(537665605), (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662508)], (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662540)]),
					string.Format(Class185.smethod_0(537667349), new object[]
					{
						(string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662571)],
						(string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660310)],
						(string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660290)],
						Class172.smethod_1((string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)], (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660385)]),
						Class172.smethod_1((string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)], (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660385)]),
						(string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660362)],
						(string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)],
						Class172.smethod_0((string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)], false)
					}),
					string.Format(Class185.smethod_0(537667250), (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537662792)], (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537662792)]),
					string.Format(Class185.smethod_0(537667199), (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662508)], (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662540)], (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662571)]),
					string.Format(Class185.smethod_0(537666823), new object[]
					{
						(string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660310)],
						(string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660290)],
						Class172.smethod_1((string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)]),
						Class172.smethod_1((string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)]),
						(string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660362)],
						(string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)],
						Class172.smethod_0((string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], false)
					}),
					string.Format(Class185.smethod_0(537666757), this.string_7),
					string.Format(Class185.smethod_0(537680797), this.string_9, this.string_8),
					Class185.smethod_0(537680675),
					string.Format(Class185.smethod_0(537679961), this.string_6),
					Class185.smethod_0(537681907)
				});
				dictionary[Class185.smethod_0(537669732)] = this.string_4;
				dictionary[Class185.smethod_0(537667733)] = this.string_5;
				dictionary[Class185.smethod_0(537681427)] = this.string_11;
				dictionary[Class185.smethod_0(537667727)] = Class185.smethod_0(537692590);
				dictionary[Class185.smethod_0(537681414)] = string.Empty;
				dictionary[Class185.smethod_0(537681444)] = string.Empty;
				dictionary[Class185.smethod_0(537681486)] = string.Empty;
				dictionary[Class185.smethod_0(537681517)] = string.Empty;
				dictionary[Class185.smethod_0(537681283)] = string.Empty;
				dictionary[Class185.smethod_0(537681327)] = string.Empty;
				dictionary[Class185.smethod_0(537667752)] = Class185.smethod_0(537667806);
				dictionary[Class185.smethod_0(537667784)] = Class185.smethod_0(537667827);
				dictionary[Class185.smethod_0(537681367)] = Class172.smethod_0((string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)], false);
				dictionary[Class185.smethod_0(537667808)] = Class172.smethod_0((string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)], false);
				dictionary[Class185.smethod_0(537667602)] = Class185.smethod_0(537667647);
				dictionary[Class185.smethod_0(537667624)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662508)];
				dictionary[Class185.smethod_0(537667676)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662540)];
				dictionary[Class185.smethod_0(537667663)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662571)];
				dictionary[Class185.smethod_0(537667698)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660310)];
				dictionary[Class185.smethod_0(537667685)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660362)];
				dictionary[Class185.smethod_0(537669514)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660290)];
				dictionary[Class185.smethod_0(537681407)] = string.Empty;
				dictionary[Class185.smethod_0(537669561)] = Class172.smethod_1((string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)], (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660385)]);
				dictionary[Class185.smethod_0(537669545)] = string.Empty;
				dictionary[Class185.smethod_0(537681382)] = string.Empty;
				dictionary[Class185.smethod_0(537681164)] = string.Empty;
				dictionary[Class185.smethod_0(537669596)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)];
				dictionary[Class185.smethod_0(537669568)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537662792)];
				dictionary[Class185.smethod_0(537669623)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537662792)];
				dictionary[Class185.smethod_0(537669406)] = Class185.smethod_0(537667806);
				dictionary[Class185.smethod_0(537669428)] = Class185.smethod_0(537667827);
				dictionary[Class185.smethod_0(537681207)] = Class172.smethod_0((string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], false);
				dictionary[Class185.smethod_0(537669471)] = Class172.smethod_0((string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], false);
				dictionary[Class185.smethod_0(537669441)] = Class185.smethod_0(537667647);
				dictionary[Class185.smethod_0(537669479)] = Class185.smethod_0(537692774);
				dictionary[Class185.smethod_0(537669257)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662508)];
				dictionary[Class185.smethod_0(537669309)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662540)];
				dictionary[Class185.smethod_0(537669280)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662571)];
				dictionary[Class185.smethod_0(537669331)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660310)];
				dictionary[Class185.smethod_0(537669318)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660362)];
				dictionary[Class185.smethod_0(537669355)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660290)];
				dictionary[Class185.smethod_0(537681247)] = string.Empty;
				dictionary[Class185.smethod_0(537669146)] = Class172.smethod_1((string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)]);
				dictionary[Class185.smethod_0(537669130)] = string.Empty;
				dictionary[Class185.smethod_0(537681222)] = string.Empty;
				dictionary[Class185.smethod_0(537681260)] = string.Empty;
				dictionary[Class185.smethod_0(537669181)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)];
				dictionary[Class185.smethod_0(537681047)] = string.Empty;
				dictionary[Class185.smethod_0(537665700)] = this.string_9;
				dictionary[Class185.smethod_0(537681087)] = string.Empty;
				dictionary[Class185.smethod_0(537681104)] = string.Empty;
				dictionary[Class185.smethod_0(537681088)] = string.Empty;
				dictionary[Class185.smethod_0(537681142)] = Class185.smethod_0(537680913);
				dictionary[Class185.smethod_0(537680906)] = Class185.smethod_0(537680913);
				dictionary[Class185.smethod_0(537680928)] = ((string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660835)]).Replace(Class185.smethod_0(537711014), string.Empty);
				dictionary[Class185.smethod_0(537680977)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660870)];
				dictionary[Class185.smethod_0(537681016)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660699)];
				dictionary[Class185.smethod_0(537681007)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660682)];
				dictionary[Class185.smethod_0(537678749)] = string.Empty;
				dictionary[Class185.smethod_0(537678779)] = string.Empty;
				dictionary[Class185.smethod_0(537678800)] = string.Empty;
				dictionary[Class185.smethod_0(537678839)] = string.Empty;
				dictionary[Class185.smethod_0(537678605)] = this.method_2(((string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660835)]).Replace(Class185.smethod_0(537711014), string.Empty));
				dictionary[Class185.smethod_0(537678633)] = ((string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660835)]).Replace(Class185.smethod_0(537711014), string.Empty);
				dictionary[Class185.smethod_0(537678679)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660870)];
				dictionary[Class185.smethod_0(537678710)] = this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660699)].ToString()[2].ToString() + this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660699)].ToString()[3].ToString();
				dictionary[Class185.smethod_0(537678484)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660682)];
				dictionary[Class185.smethod_0(537678523)] = string.Empty;
				dictionary[Class185.smethod_0(537669130)] = Class172.smethod_1((string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)]);
				dictionary[Class185.smethod_0(537669545)] = Class172.smethod_1((string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)], (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660385)]);
				HttpResponseMessage httpResponseMessage = this.class70_0.method_7(string.Format(Class185.smethod_0(537678554), this.string_2), dictionary, false);
				if (!this.method_3(httpResponseMessage))
				{
					httpResponseMessage.EnsureSuccessStatusCode();
					JObject jobject = JObject.Parse(httpResponseMessage.smethod_3().Substring(2, httpResponseMessage.smethod_3().Length - 2));
					if (jobject[Class185.smethod_0(537668992)].ToString() != Class185.smethod_0(537710839))
					{
						throw new Exception();
					}
					this.string_4 = jobject[Class185.smethod_0(537668892)].ToString();
					this.string_5 = jobject[Class185.smethod_0(537667733)].ToString();
					break;
				}
			}
			catch (ThreadAbortException)
			{
				break;
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537678359), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_1);
			}
		}
	}

	// Token: 0x06000541 RID: 1345 RVA: 0x0003049C File Offset: 0x0002E69C
	public void method_15()
	{
		this.cookieCollection_0 = this.class70_0.cookieContainer_0.GetCookies(new Uri(string.Format(Class185.smethod_0(537669781), this.string_2)));
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537658294), Class185.smethod_0(537700964), true, false);
				Dictionary<string, string> dictionary = Class70.smethod_1();
				dictionary[Class185.smethod_0(537669153)] = string.Concat(new string[]
				{
					string.Format(Class185.smethod_0(537678368), (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662508)], (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662540)]),
					string.Format(Class185.smethod_0(537667349), new object[]
					{
						(string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662571)],
						(string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660310)],
						(string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660290)],
						Class172.smethod_1((string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)], (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660385)]),
						Class172.smethod_1((string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)], (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660385)]),
						(string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660362)],
						(string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)],
						Class172.smethod_0((string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)], false)
					}),
					string.Format(Class185.smethod_0(537667250), (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537662792)], (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537662792)]),
					string.Format(Class185.smethod_0(537667199), (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662508)], (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662540)], (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662571)]),
					string.Format(Class185.smethod_0(537666823), new object[]
					{
						(string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660310)],
						(string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660290)],
						Class172.smethod_1((string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)]),
						Class172.smethod_1((string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)]),
						(string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660362)],
						(string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)],
						Class172.smethod_0((string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], false)
					}),
					string.Format(Class185.smethod_0(537666757), this.string_7),
					string.Format(Class185.smethod_0(537678322), this.string_9, this.string_8),
					Class185.smethod_0(537677959),
					string.Format(Class185.smethod_0(537679685), new object[]
					{
						(string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660870)],
						this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660699)].ToString()[2].ToString() + this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660699)].ToString()[3].ToString(),
						((string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660835)]).Replace(Class185.smethod_0(537711014), string.Empty),
						this.method_2(((string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660835)]).Replace(Class185.smethod_0(537711014), string.Empty))
					}),
					string.Format(Class185.smethod_0(537679411), (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660682)]),
					Class185.smethod_0(537679321),
					string.Format(Class185.smethod_0(537678878), this.string_6),
					Class185.smethod_0(537676759)
				});
				dictionary[Class185.smethod_0(537669732)] = this.string_4;
				dictionary[Class185.smethod_0(537667733)] = this.string_5;
				dictionary[Class185.smethod_0(537681427)] = Class108.smethod_0(16);
				dictionary[Class185.smethod_0(537669732)] = this.string_4;
				dictionary[Class185.smethod_0(537667733)] = this.string_5;
				dictionary[Class185.smethod_0(537681427)] = this.string_11;
				dictionary[Class185.smethod_0(537667727)] = Class185.smethod_0(537692590);
				dictionary[Class185.smethod_0(537681414)] = string.Empty;
				dictionary[Class185.smethod_0(537681444)] = string.Empty;
				dictionary[Class185.smethod_0(537681486)] = string.Empty;
				dictionary[Class185.smethod_0(537681517)] = string.Empty;
				dictionary[Class185.smethod_0(537681283)] = string.Empty;
				dictionary[Class185.smethod_0(537681327)] = string.Empty;
				dictionary[Class185.smethod_0(537667752)] = Class185.smethod_0(537667806);
				dictionary[Class185.smethod_0(537667784)] = Class185.smethod_0(537667827);
				dictionary[Class185.smethod_0(537681367)] = Class172.smethod_0((string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)], false);
				dictionary[Class185.smethod_0(537667808)] = Class172.smethod_0((string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)], false);
				dictionary[Class185.smethod_0(537667602)] = Class185.smethod_0(537667647);
				dictionary[Class185.smethod_0(537667624)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662508)];
				dictionary[Class185.smethod_0(537667676)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662540)];
				dictionary[Class185.smethod_0(537667663)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662571)];
				dictionary[Class185.smethod_0(537667698)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660310)];
				dictionary[Class185.smethod_0(537667685)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660362)];
				dictionary[Class185.smethod_0(537669514)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660290)];
				dictionary[Class185.smethod_0(537681407)] = string.Empty;
				dictionary[Class185.smethod_0(537669561)] = Class172.smethod_1((string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)], (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660385)]);
				dictionary[Class185.smethod_0(537669545)] = string.Empty;
				dictionary[Class185.smethod_0(537681382)] = string.Empty;
				dictionary[Class185.smethod_0(537681164)] = string.Empty;
				dictionary[Class185.smethod_0(537669596)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)];
				dictionary[Class185.smethod_0(537669568)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537662792)];
				dictionary[Class185.smethod_0(537669623)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537662792)];
				dictionary[Class185.smethod_0(537669406)] = Class185.smethod_0(537667806);
				dictionary[Class185.smethod_0(537669428)] = Class185.smethod_0(537667827);
				dictionary[Class185.smethod_0(537681207)] = Class172.smethod_0((string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], false);
				dictionary[Class185.smethod_0(537669471)] = Class172.smethod_0((string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], false);
				dictionary[Class185.smethod_0(537669441)] = Class185.smethod_0(537667647);
				dictionary[Class185.smethod_0(537669479)] = Class185.smethod_0(537692774);
				dictionary[Class185.smethod_0(537669257)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662508)];
				dictionary[Class185.smethod_0(537669309)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662540)];
				dictionary[Class185.smethod_0(537669280)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662571)];
				dictionary[Class185.smethod_0(537669331)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660310)];
				dictionary[Class185.smethod_0(537669318)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660362)];
				dictionary[Class185.smethod_0(537669355)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660290)];
				dictionary[Class185.smethod_0(537681247)] = string.Empty;
				dictionary[Class185.smethod_0(537669146)] = Class172.smethod_1((string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)]);
				dictionary[Class185.smethod_0(537669130)] = string.Empty;
				dictionary[Class185.smethod_0(537681222)] = string.Empty;
				dictionary[Class185.smethod_0(537681260)] = string.Empty;
				dictionary[Class185.smethod_0(537669181)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)];
				dictionary[Class185.smethod_0(537681047)] = string.Empty;
				dictionary[Class185.smethod_0(537665700)] = this.string_9;
				dictionary[Class185.smethod_0(537681087)] = string.Empty;
				dictionary[Class185.smethod_0(537681104)] = string.Empty;
				dictionary[Class185.smethod_0(537681088)] = string.Empty;
				dictionary[Class185.smethod_0(537681142)] = Class185.smethod_0(537680913);
				dictionary[Class185.smethod_0(537680906)] = Class185.smethod_0(537680913);
				dictionary[Class185.smethod_0(537680928)] = ((string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660835)]).Replace(Class185.smethod_0(537711014), string.Empty);
				dictionary[Class185.smethod_0(537680977)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660870)];
				dictionary[Class185.smethod_0(537681016)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660699)];
				dictionary[Class185.smethod_0(537681007)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660682)];
				dictionary[Class185.smethod_0(537678749)] = string.Empty;
				dictionary[Class185.smethod_0(537678779)] = string.Empty;
				dictionary[Class185.smethod_0(537678800)] = string.Empty;
				dictionary[Class185.smethod_0(537678839)] = string.Empty;
				dictionary[Class185.smethod_0(537678605)] = this.method_2(((string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660835)]).Replace(Class185.smethod_0(537711014), string.Empty));
				dictionary[Class185.smethod_0(537678633)] = ((string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660835)]).Replace(Class185.smethod_0(537711014), string.Empty);
				dictionary[Class185.smethod_0(537678679)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660870)];
				dictionary[Class185.smethod_0(537678710)] = this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660699)].ToString()[2].ToString() + this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660699)].ToString()[3].ToString();
				dictionary[Class185.smethod_0(537678484)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660682)];
				dictionary[Class185.smethod_0(537678523)] = string.Empty;
				dictionary[Class185.smethod_0(537669130)] = Class172.smethod_1((string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)]);
				dictionary[Class185.smethod_0(537669545)] = Class172.smethod_1((string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)], (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660385)]);
				HttpResponseMessage httpResponseMessage = this.class70_0.method_7(string.Format(Class185.smethod_0(537676662), this.string_2), dictionary, false);
				if (!this.method_3(httpResponseMessage))
				{
					httpResponseMessage.EnsureSuccessStatusCode();
					JObject jobject = JObject.Parse(httpResponseMessage.smethod_3().Substring(2, httpResponseMessage.smethod_3().Length - 2));
					if (!httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537676460)))
					{
						if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537676490)))
						{
							this.class4_0.method_0(Class185.smethod_0(537660491), Class185.smethod_0(537700909), false);
						}
						else if ((bool)jobject[Class185.smethod_0(537676515)][Class185.smethod_0(537676297)])
						{
							this.class4_0.method_12();
							this.class4_0.method_9(false);
							this.class4_0.method_0(Class185.smethod_0(537658349), Class185.smethod_0(537658124), false);
						}
						throw new Exception();
					}
					this.class4_0.method_9(true);
					this.class4_0.method_0(Class185.smethod_0(537711206), Class185.smethod_0(537700909), false);
					break;
				}
			}
			catch (ThreadAbortException)
			{
				break;
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537658168), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_1);
			}
		}
	}

	// Token: 0x04000283 RID: 643
	private Class70 class70_0;

	// Token: 0x04000284 RID: 644
	private Class4 class4_0;

	// Token: 0x04000285 RID: 645
	private JToken jtoken_0;

	// Token: 0x04000286 RID: 646
	private int int_0;

	// Token: 0x04000287 RID: 647
	private JToken jtoken_1;

	// Token: 0x04000288 RID: 648
	private string string_0;

	// Token: 0x04000289 RID: 649
	private string string_1;

	// Token: 0x0400028A RID: 650
	private string string_2;

	// Token: 0x0400028B RID: 651
	private string string_3;

	// Token: 0x0400028C RID: 652
	private string string_4;

	// Token: 0x0400028D RID: 653
	private string string_5;

	// Token: 0x0400028E RID: 654
	private string string_6;

	// Token: 0x0400028F RID: 655
	private string string_7;

	// Token: 0x04000290 RID: 656
	private string string_8;

	// Token: 0x04000291 RID: 657
	private string string_9;

	// Token: 0x04000292 RID: 658
	private string string_10;

	// Token: 0x04000293 RID: 659
	private string string_11;

	// Token: 0x04000294 RID: 660
	private CookieCollection cookieCollection_0;

	// Token: 0x020000C9 RID: 201
	[Serializable]
	private sealed class Class109
	{
		// Token: 0x06000544 RID: 1348 RVA: 0x00003CB2 File Offset: 0x00001EB2
		internal char method_0(string string_0)
		{
			return string_0[GForm1.random_0.Next(string_0.Length)];
		}

		// Token: 0x04000295 RID: 661
		public static readonly Class108.Class109 class109_0 = new Class108.Class109();

		// Token: 0x04000296 RID: 662
		public static Func<string, char> func_0;
	}
}
