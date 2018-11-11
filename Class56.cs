using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberAIO.Properties;
using HtmlAgilityPack;
using Newtonsoft.Json.Linq;

// Token: 0x02000060 RID: 96
internal sealed class Class56
{
	// Token: 0x06000222 RID: 546 RVA: 0x00014A20 File Offset: 0x00012C20
	public Class56(JToken jtoken_2)
	{
		try
		{
			this.jtoken_1 = jtoken_2;
			this.class4_0 = new Class4(jtoken_2);
			this.string_1 = (string)jtoken_2[Class185.smethod_0(537702300)];
			if (!((string)jtoken_2[Class185.smethod_0(537700008)] == Class185.smethod_0(537663132)) && !((string)jtoken_2[Class185.smethod_0(537700008)] == Class185.smethod_0(537663113)))
			{
				this.string_2 = (string)jtoken_2[Class185.smethod_0(537700008)];
				this.string_2.Replace('.', ',');
			}
			else
			{
				this.bool_0 = true;
			}
			if (!this.class4_0.method_3(out this.jtoken_0))
			{
				this.class4_0.method_0(Class185.smethod_0(537663358), Class185.smethod_0(537700909), false);
			}
			else
			{
				this.class70_0 = new Class70(this.class4_0.method_6(), Class185.smethod_0(537692910), 10, false, false, null, false);
				this.class70_0.httpClient_0.DefaultRequestHeaders.ExpectContinue = new bool?(false);
			}
		}
		catch
		{
			this.class4_0.method_0(Class185.smethod_0(537663193), Class185.smethod_0(537700909), false);
		}
	}

	// Token: 0x06000223 RID: 547 RVA: 0x00014BBC File Offset: 0x00012DBC
	public void method_0()
	{
		try
		{
			this.class4_0.method_8();
			Task task = this.method_1();
			this.method_2();
			Class30.smethod_1((int)this.jtoken_1[Class185.smethod_0(537703519)], string.Format(Class185.smethod_0(537658111), this.string_1));
			task.Wait();
			this.method_3();
			this.method_4();
			this.method_5();
			this.method_6();
		}
		catch
		{
		}
		finally
		{
			this.class4_0.method_0(Class185.smethod_0(537663178), Class185.smethod_0(537700909), true);
		}
	}

	// Token: 0x06000224 RID: 548 RVA: 0x00003F98 File Offset: 0x00002198
	public Task method_1()
	{
		Task task = new Task(new Action(this.method_7));
		task.Start();
		return task;
	}

	// Token: 0x06000225 RID: 549 RVA: 0x00014C74 File Offset: 0x00012E74
	public void method_2()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), true, false);
				HttpResponseMessage httpResponseMessage = this.class4_0.method_1(string.Format(Class185.smethod_0(537658111), this.string_1), true, null);
				if (httpResponseMessage.StatusCode == HttpStatusCode.NotFound)
				{
					this.class4_0.method_0(Class185.smethod_0(537657739), Class185.smethod_0(537700909), false);
				}
				httpResponseMessage.EnsureSuccessStatusCode();
				HtmlDocument htmlDocument = new HtmlDocument();
				htmlDocument.LoadHtml(httpResponseMessage.smethod_0()[Class185.smethod_0(537706534)].ToString());
				if (htmlDocument.DocumentNode.SelectNodes(Class185.smethod_0(537657779)) != null)
				{
					if (this.bool_0)
					{
						HtmlNodeCollection htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes(Class185.smethod_0(537657801));
						if (htmlNodeCollection == null)
						{
							this.class4_0.method_0(Class185.smethod_0(537657827), Class185.smethod_0(537700909), false);
						}
						this.string_0 = htmlNodeCollection[GForm1.random_0.Next(0, htmlNodeCollection.Count)].Attributes[Class185.smethod_0(537657610)].Value;
					}
					else
					{
						HtmlNode htmlNode = htmlDocument.DocumentNode.SelectSingleNode(string.Format(Class185.smethod_0(537657654), this.string_2));
						if (htmlNode != null)
						{
							this.string_0 = htmlNode.ParentNode.Attributes[Class185.smethod_0(537657610)].Value;
						}
						else
						{
							this.class4_0.method_0(Class185.smethod_0(537657827), Class185.smethod_0(537700909), false);
						}
					}
					using (IEnumerator<HtmlNode> enumerator = ((IEnumerable<HtmlNode>)htmlDocument.DocumentNode.SelectNodes(Class185.smethod_0(537657675))).GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							HtmlNode htmlNode2 = enumerator.Current;
							if (htmlNode2.Attributes.Contains(Class185.smethod_0(537711408)) && htmlNode2.Attributes.Contains(Class185.smethod_0(537712143)))
							{
								if (htmlNode2.Attributes[Class185.smethod_0(537712143)].Value.ToLower().Contains(Class185.smethod_0(537662905)))
								{
									this.dictionary_0[htmlNode2.Attributes[Class185.smethod_0(537712143)].Value] = Class185.smethod_0(537713814);
								}
								else
								{
									this.dictionary_0[htmlNode2.Attributes[Class185.smethod_0(537712143)].Value] = htmlNode2.Attributes[Class185.smethod_0(537711408)].Value;
								}
							}
						}
						goto IL_2BD;
					}
					goto IL_2B7;
					IL_2BD:
					this.dictionary_0[Class185.smethod_0(537657721)] = this.string_0;
					break;
				}
				IL_2B7:
				throw new Exception();
			}
			catch (ThreadAbortException)
			{
			}
			catch
			{
				Thread.Sleep(Settings.Default.monitor_delay);
				continue;
			}
			break;
		}
	}

	// Token: 0x06000226 RID: 550 RVA: 0x00014FC0 File Offset: 0x000131C0
	public void method_3()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537663094), Class185.smethod_0(537700781), true, false);
				this.dictionary_0[Class185.smethod_0(537657715)] = this.string_3;
				HttpResponseMessage httpResponseMessage = this.class70_0.method_7(string.Format(Class185.smethod_0(537657499), this.string_4), this.dictionary_0, false);
				while (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537657508)))
				{
					this.class4_0.method_4(Class185.smethod_0(537657530), Class185.smethod_0(537700781), true, false);
					Thread.Sleep(Settings.Default.retry_delay);
					httpResponseMessage = this.class70_0.method_7(string.Format(Class185.smethod_0(537657499), this.string_4), this.dictionary_0, false);
				}
				HtmlDocument htmlDocument = new HtmlDocument();
				htmlDocument.LoadHtml(httpResponseMessage.smethod_3());
				this.class4_0.method_7(htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537657590)).InnerText, Class185.smethod_0(537700781));
				httpResponseMessage.EnsureSuccessStatusCode();
			}
			catch (ThreadAbortException)
			{
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537662720), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(Settings.Default.retry_delay);
				continue;
			}
			break;
		}
	}

	// Token: 0x06000227 RID: 551 RVA: 0x0001515C File Offset: 0x0001335C
	public void method_4()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537662655), Class185.smethod_0(537700781), true, false);
				Dictionary<string, string> dictionary = Class70.smethod_1();
				dictionary[Class185.smethod_0(537657715)] = this.string_3;
				dictionary[Class185.smethod_0(537657365)] = string.Empty;
				dictionary[Class185.smethod_0(537657404)] = string.Empty;
				dictionary[Class185.smethod_0(537657380)] = Class185.smethod_0(537657416);
				dictionary[Class185.smethod_0(537657440)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662508)];
				dictionary[Class185.smethod_0(537659272)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662540)];
				dictionary[Class185.smethod_0(537659327)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662571)];
				dictionary[Class185.smethod_0(537659302)] = (this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662571)].ToString().Split(new char[]
				{
					' '
				})[0].smethod_0() ? this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662571)].ToString().Split(new char[]
				{
					' '
				})[0] : Class185.smethod_0(537708442));
				dictionary[Class185.smethod_0(537657365)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660310)];
				dictionary[Class185.smethod_0(537659341)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660290)];
				dictionary[Class185.smethod_0(537659376)] = (string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660362)];
				dictionary[Class185.smethod_0(537659161)] = Class172.smethod_0((string)this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)], false);
				dictionary[Class185.smethod_0(537659139)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)];
				dictionary[Class185.smethod_0(537659179)] = Class185.smethod_0(537692590);
				dictionary[Class185.smethod_0(537659210)] = Class185.smethod_0(537659253);
				dictionary[Class185.smethod_0(537659246)] = Class185.smethod_0(537659253);
				dictionary[Class185.smethod_0(537659019)] = Class185.smethod_0(537659063);
				dictionary[Class185.smethod_0(537659042)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537662792)];
				dictionary[Class185.smethod_0(537659092)] = string.Empty;
				dictionary[Class185.smethod_0(537657404)] = string.Empty;
				dictionary[Class185.smethod_0(537659119)] = Class185.smethod_0(537657416);
				dictionary[Class185.smethod_0(537658900)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662508)];
				dictionary[Class185.smethod_0(537658941)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662540)];
				dictionary[Class185.smethod_0(537658917)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662571)];
				dictionary[Class185.smethod_0(537658957)] = (this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662571)].ToString().Split(new char[]
				{
					' '
				})[0].smethod_0() ? this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537662571)].ToString().Split(new char[]
				{
					' '
				})[0] : Class185.smethod_0(537708442));
				dictionary[Class185.smethod_0(537658997)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660310)];
				dictionary[Class185.smethod_0(537658781)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660290)];
				dictionary[Class185.smethod_0(537658753)] = (string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660362)];
				dictionary[Class185.smethod_0(537658795)] = Class172.smethod_0((string)this.jtoken_0[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], false);
				dictionary[Class185.smethod_0(537658838)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)];
				dictionary[Class185.smethod_0(537658879)] = string.Empty;
				dictionary[Class185.smethod_0(537658851)] = Class185.smethod_0(537658625);
				dictionary[Class185.smethod_0(537658656)] = Class185.smethod_0(537658695);
				dictionary[Class185.smethod_0(537658741)] = Class185.smethod_0(537658499);
				dictionary[Class185.smethod_0(537673118)] = Class185.smethod_0(537673095);
				dictionary[Class185.smethod_0(537673126)] = Class185.smethod_0(537673167);
				dictionary[Class185.smethod_0(537673208)] = Class185.smethod_0(537692590);
				dictionary[Class185.smethod_0(537673199)] = Class185.smethod_0(537692590);
				dictionary[Class185.smethod_0(537672960)] = string.Empty;
				HttpResponseMessage httpResponseMessage_ = this.class70_0.method_7(string.Format(Class185.smethod_0(537673008), this.string_4), dictionary, true);
				if (httpResponseMessage_.smethod_3().Contains(Class185.smethod_0(537672844)))
				{
					throw new Exception();
				}
				HtmlDocument htmlDocument = new HtmlDocument();
				htmlDocument.LoadHtml(httpResponseMessage_.smethod_3());
				foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)htmlDocument.DocumentNode.SelectNodes(Class185.smethod_0(537672869))))
				{
					if (htmlNode.Attributes.Contains(Class185.smethod_0(537711408)) && htmlNode.Attributes.Contains(Class185.smethod_0(537712143)))
					{
						this.dictionary_1[htmlNode.Attributes[Class185.smethod_0(537712143)].Value] = htmlNode.Attributes[Class185.smethod_0(537711408)].Value;
					}
				}
			}
			catch (ThreadAbortException)
			{
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537659996), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(Settings.Default.retry_delay);
				continue;
			}
			break;
		}
	}

	// Token: 0x06000228 RID: 552 RVA: 0x000159FC File Offset: 0x00013BFC
	public void method_5()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537672905), Class185.smethod_0(537700781), true, false);
				HttpResponseMessage httpResponseMessage = this.class70_0.method_7(Class185.smethod_0(537672944), this.dictionary_1, false);
				httpResponseMessage.EnsureSuccessStatusCode();
				if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537672761)))
				{
					this.class4_0.method_0(Class185.smethod_0(537660491), Class185.smethod_0(537700909), false);
				}
				HtmlDocument htmlDocument = new HtmlDocument();
				htmlDocument.LoadHtml(httpResponseMessage.smethod_3());
				foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)htmlDocument.DocumentNode.SelectNodes(Class185.smethod_0(537672869))))
				{
					if (htmlNode.Attributes.Contains(Class185.smethod_0(537711408)) && htmlNode.Attributes.Contains(Class185.smethod_0(537712143)))
					{
						this.dictionary_2[htmlNode.Attributes[Class185.smethod_0(537712143)].Value] = htmlNode.Attributes[Class185.smethod_0(537711408)].Value;
					}
				}
				this.dictionary_2[Class185.smethod_0(537672772)] = Class185.smethod_0(537660840);
				this.dictionary_2[Class185.smethod_0(537672823)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660835)];
				this.dictionary_2[Class185.smethod_0(537670557)] = this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662508)] + Class185.smethod_0(537711014) + this.jtoken_0[Class185.smethod_0(537662526)][Class185.smethod_0(537662540)];
				this.dictionary_2[Class185.smethod_0(537670535)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660870)];
				this.dictionary_2[Class185.smethod_0(537670574)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660699)];
				this.dictionary_2[Class185.smethod_0(537670612)] = (string)this.jtoken_0[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660682)];
				this.dictionary_2.Remove(Class185.smethod_0(537670599));
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537670642), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(Settings.Default.retry_delay);
				continue;
			}
			break;
		}
	}

	// Token: 0x06000229 RID: 553 RVA: 0x00015D80 File Offset: 0x00013F80
	public void method_6()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537660830), Class185.smethod_0(537700964), true, false);
				HttpResponseMessage httpResponseMessage = this.class70_0.method_7(Class185.smethod_0(537670431), this.dictionary_2, false);
				string text = httpResponseMessage.Headers.Location.ToString();
				if (text.Contains(Class185.smethod_0(537670481)))
				{
					this.class4_0.method_4(Class185.smethod_0(537660636), Class185.smethod_0(537700964), true, false);
					httpResponseMessage = this.class70_0.method_5(Class185.smethod_0(537670467) + text, true);
					HtmlDocument htmlDocument = new HtmlDocument();
					htmlDocument.LoadHtml(httpResponseMessage.smethod_3());
					Dictionary<string, string> dictionary = Class70.smethod_1();
					foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)htmlDocument.DocumentNode.SelectNodes(Class185.smethod_0(537670302))))
					{
						dictionary[htmlNode.Attributes[Class185.smethod_0(537712143)].Value] = htmlNode.Attributes[Class185.smethod_0(537711408)].Value;
					}
					httpResponseMessage = this.class70_0.method_7(htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537670305)).Attributes[Class185.smethod_0(537670350)].Value, dictionary, false);
					if (!httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537670395)))
					{
						this.class4_0.method_0(Class185.smethod_0(537670382), Class185.smethod_0(537700909), false);
					}
					htmlDocument.LoadHtml(httpResponseMessage.smethod_3());
					dictionary = Class70.smethod_1();
					foreach (HtmlNode htmlNode2 in ((IEnumerable<HtmlNode>)htmlDocument.DocumentNode.SelectNodes(Class185.smethod_0(537670145))))
					{
						dictionary[htmlNode2.Attributes[Class185.smethod_0(537712143)].Value] = htmlNode2.Attributes[Class185.smethod_0(537711408)].Value;
					}
					httpResponseMessage = this.class70_0.method_7(htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537670218)).Attributes[Class185.smethod_0(537670350)].Value, dictionary, false);
					text = httpResponseMessage.Headers.Location.ToString();
				}
				if (!text.Contains(Class185.smethod_0(537670253)) && !text.Contains(Class185.smethod_0(537670038)))
				{
					if (text.Contains(Class185.smethod_0(537670065)))
					{
						this.class4_0.method_4(Class185.smethod_0(537658294), Class185.smethod_0(537700964), true, false);
						this.class70_0.method_5(text, true);
						this.class4_0.method_9(false);
						this.class4_0.method_0(Class185.smethod_0(537658349), Class185.smethod_0(537658124), false);
					}
					else
					{
						this.class4_0.method_0(Class185.smethod_0(537660491), Class185.smethod_0(537700909), false);
					}
				}
				else
				{
					this.class4_0.method_9(true);
					this.class4_0.method_0(Class185.smethod_0(537660452), Class185.smethod_0(537700909), false);
				}
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537660605), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(Settings.Default.retry_delay);
				continue;
			}
			break;
		}
	}

	// Token: 0x0600022A RID: 554 RVA: 0x0001617C File Offset: 0x0001437C
	private void method_7()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537670109), Class185.smethod_0(537700781), true, false);
				HttpResponseMessage httpResponseMessage_ = this.class70_0.method_5(Class185.smethod_0(537670081), true);
				HtmlDocument htmlDocument = new HtmlDocument();
				htmlDocument.LoadHtml(httpResponseMessage_.smethod_3());
				this.string_4 = new Uri(htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537669917)).Attributes[Class185.smethod_0(537669937)].Value).Host;
				this.string_3 = htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537669932)).Attributes[Class185.smethod_0(537711408)].Value;
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537669957), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(Settings.Default.retry_delay);
				continue;
			}
			break;
		}
	}

	// Token: 0x04000114 RID: 276
	private Class70 class70_0;

	// Token: 0x04000115 RID: 277
	private Class4 class4_0;

	// Token: 0x04000116 RID: 278
	private JToken jtoken_0;

	// Token: 0x04000117 RID: 279
	private JToken jtoken_1;

	// Token: 0x04000118 RID: 280
	private string string_0;

	// Token: 0x04000119 RID: 281
	private string string_1;

	// Token: 0x0400011A RID: 282
	private string string_2;

	// Token: 0x0400011B RID: 283
	private string string_3;

	// Token: 0x0400011C RID: 284
	private bool bool_0;

	// Token: 0x0400011D RID: 285
	private Dictionary<string, string> dictionary_0 = new Dictionary<string, string>();

	// Token: 0x0400011E RID: 286
	private Dictionary<string, string> dictionary_1 = new Dictionary<string, string>();

	// Token: 0x0400011F RID: 287
	private Dictionary<string, string> dictionary_2 = new Dictionary<string, string>();

	// Token: 0x04000120 RID: 288
	private string string_4;
}
