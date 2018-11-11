using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

// Token: 0x0200001B RID: 27
internal sealed class Class13
{
	// Token: 0x060000A6 RID: 166 RVA: 0x0000B7C0 File Offset: 0x000099C0
	public Class13(JToken jtoken_2, string string_11, string string_12)
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
				this.string_0 = string_11;
				this.string_1 = string_12;
				this.string_3 = (string)jtoken_2[Class185.smethod_0(537702300)];
				this.string_4 = ((string)jtoken_2[Class185.smethod_0(537700008)]).Replace(Class185.smethod_0(537663330), string.Empty);
				if (this.string_4 == Class185.smethod_0(537663132) || this.string_4 == Class185.smethod_0(537663113))
				{
					this.bool_0 = true;
				}
				this.jobject_0 = new JObject();
				this.jobject_0[Class185.smethod_0(537713963)] = Class185.smethod_0(537689874);
				this.jobject_0[Class185.smethod_0(537689940)] = string_12;
				this.class70_0 = new Class70(this.class4_0.method_6(), Class185.smethod_0(537692910), 10, false, false, this.jobject_0, false);
			}
		}
		catch
		{
			this.class4_0.method_0(Class185.smethod_0(537663193), Class185.smethod_0(537700909), true);
		}
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x0000B964 File Offset: 0x00009B64
	public void method_0()
	{
		try
		{
			Task task = this.method_5();
			this.class4_0.method_8();
			this.method_1();
			this.class4_0.method_4(Class185.smethod_0(537689924), Class185.smethod_0(537700781), true, false);
			task.Wait();
			this.method_2();
			this.method_7();
			this.method_8();
		}
		catch
		{
		}
		finally
		{
			this.class4_0.method_0(Class185.smethod_0(537663178), Class185.smethod_0(537700909), true);
		}
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x00003257 File Offset: 0x00001457
	public static string smethod_0(string string_11, string string_12)
	{
		return Class13.smethod_2(Class185.smethod_0(537689967), Class185.smethod_0(537689734), new Uri(string_11), string_12);
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x00003279 File Offset: 0x00001479
	public static string smethod_1(string string_11, string string_12)
	{
		return Class13.smethod_2(Class185.smethod_0(537689783), Class185.smethod_0(537689806), new Uri(string_11), string_12);
	}

	// Token: 0x060000AA RID: 170 RVA: 0x0000BA04 File Offset: 0x00009C04
	public static string smethod_2(string string_11, string string_12, Uri uri_0, string string_13)
	{
		int num = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
		string text = Guid.NewGuid().ToString().Substring(0, 6);
		string s = string.Format(Class185.smethod_0(537689855), new object[]
		{
			num,
			text,
			string_13,
			uri_0.PathAndQuery,
			uri_0.Host
		});
		string text2 = Convert.ToBase64String(new HMACSHA256(Encoding.ASCII.GetBytes(string_11)).ComputeHash(Encoding.ASCII.GetBytes(s)));
		return string.Format(Class185.smethod_0(537689613), new object[]
		{
			string_12,
			text2,
			num,
			text
		});
	}

	// Token: 0x060000AB RID: 171 RVA: 0x0000BADC File Offset: 0x00009CDC
	public void method_1()
	{
		this.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), true, false);
		for (;;)
		{
			try
			{
				HttpResponseMessage httpResponseMessage = this.class4_0.method_1(string.Format(Class185.smethod_0(537689681), this.string_0, this.string_3), true, this.jobject_0);
				if (!httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537689502)))
				{
					httpResponseMessage.EnsureSuccessStatusCode();
					JObject jobject = httpResponseMessage.smethod_0();
					this.class4_0.method_7(jobject[Class185.smethod_0(537712143)].ToString(), Class185.smethod_0(537700781));
					if (this.bool_0)
					{
						JToken[] array = jobject[Class185.smethod_0(537689535)].Where(new Func<JToken, bool>(Class13.Class14.class14_0.method_0)).ToArray<JToken>();
						if (array.Length == 0)
						{
							this.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
							Thread.Sleep(GClass0.int_0);
							continue;
						}
						JToken jtoken = array[GForm1.random_0.Next(0, array.Length)];
						this.class4_0.method_5(jtoken[Class185.smethod_0(537712143)].ToString());
						this.string_2 = jtoken[Class185.smethod_0(537710986)][Class185.smethod_0(537657721)].ToString();
					}
					else
					{
						JToken jtoken2 = jobject[Class185.smethod_0(537689535)].FirstOrDefault(new Func<JToken, bool>(this.method_10));
						if (jtoken2 == null)
						{
							throw new Exception();
						}
						if (jtoken2[Class185.smethod_0(537710986)][Class185.smethod_0(537690097)].ToString() != Class185.smethod_0(537690083))
						{
							this.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
							Thread.Sleep(GClass0.int_0);
							continue;
						}
						this.class4_0.method_5(jtoken2[Class185.smethod_0(537712143)].ToString());
						this.string_2 = jtoken2[Class185.smethod_0(537710986)][Class185.smethod_0(537657721)].ToString();
					}
					Class30.smethod_1((int)this.jtoken_0[Class185.smethod_0(537703519)], string.Format(Class185.smethod_0(537689681), this.string_0, this.string_3));
					break;
				}
				Thread.Sleep(GClass0.int_0);
				this.class4_0.method_4(Class185.smethod_0(537663207), Class185.smethod_0(537700781), true, false);
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

	// Token: 0x060000AC RID: 172 RVA: 0x0000BE1C File Offset: 0x0000A01C
	public void method_2()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537663094), Class185.smethod_0(537700781), true, false);
				JObject jobject = new JObject();
				jobject[Class185.smethod_0(537657721)] = this.string_2;
				jobject[Class185.smethod_0(537662905)] = 1;
				jobject[Class185.smethod_0(537676350)] = Class185.smethod_0(537689507);
				JObject jobject2 = new JObject();
				jobject2[Class185.smethod_0(537689557)] = new JArray(jobject);
				jobject2[Class185.smethod_0(537711046)] = new JObject();
				jobject2[Class185.smethod_0(537711046)][Class185.smethod_0(537703519)] = string.Format(Class185.smethod_0(537689540), this.string_0, this.string_6);
				jobject2[Class185.smethod_0(537674598)] = new JObject();
				jobject2[Class185.smethod_0(537674598)][Class185.smethod_0(537703519)] = string.Format(Class185.smethod_0(537689346), this.string_0, this.string_6, this.string_7);
				jobject2[Class185.smethod_0(537689470)] = new JObject();
				jobject2[Class185.smethod_0(537689470)][Class185.smethod_0(537703519)] = string.Format(Class185.smethod_0(537689346), this.string_0, this.string_6, this.string_7);
				jobject2[Class185.smethod_0(537689444)] = new JObject();
				jobject2[Class185.smethod_0(537689444)][Class185.smethod_0(537689236)] = Class185.smethod_0(537689221);
				jobject2[Class185.smethod_0(537689444)][Class185.smethod_0(537689269)] = Class185.smethod_0(537689254);
				jobject2[Class185.smethod_0(537689444)][Class185.smethod_0(537689288)] = Class185.smethod_0(537689337);
				HttpResponseMessage httpResponseMessage = this.class70_0.method_9(string.Format(Class185.smethod_0(537689326), this.string_0, this.string_1), jobject2, true);
				while (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537689140)))
				{
					this.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
					httpResponseMessage = this.class70_0.method_9(string.Format(Class185.smethod_0(537689326), this.string_0, this.string_1), jobject2, true);
					Thread.Sleep(GClass0.int_0);
				}
				httpResponseMessage.EnsureSuccessStatusCode();
				this.string_5 = httpResponseMessage.smethod_0()[Class185.smethod_0(537674058)].ToString();
				this.string_8 = httpResponseMessage.smethod_0()[Class185.smethod_0(537660189)][Class185.smethod_0(537689174)].ToString();
			}
			catch (ThreadAbortException)
			{
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537662720), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_1);
				continue;
			}
			break;
		}
	}

	// Token: 0x060000AD RID: 173 RVA: 0x0000C1BC File Offset: 0x0000A3BC
	public void method_3()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537689213), Class185.smethod_0(537700781), true, false);
				HttpResponseMessage httpResponseMessage = this.class70_0.method_5(string.Format(Class185.smethod_0(537686942), new object[]
				{
					this.string_0,
					this.string_5,
					Class172.smethod_0((string)this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], false),
					(string)this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537660362)]
				}), true);
				httpResponseMessage.EnsureSuccessStatusCode();
				this.string_8 = httpResponseMessage.smethod_0()[Class185.smethod_0(537687011)][0][Class185.smethod_0(537674058)].ToString();
			}
			catch (ThreadAbortException)
			{
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537686793), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_1);
				continue;
			}
			break;
		}
	}

	// Token: 0x060000AE RID: 174 RVA: 0x0000C310 File Offset: 0x0000A510
	public void method_4()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537686829), Class185.smethod_0(537700781), true, false);
				JObject jobject = new JObject();
				jobject[Class185.smethod_0(537660189)] = new JObject();
				jobject[Class185.smethod_0(537660189)][Class185.smethod_0(537689174)] = this.string_8;
				this.class70_0.method_16(string.Format(Class185.smethod_0(537686859), this.string_0, this.string_5), jobject, false).EnsureSuccessStatusCode();
			}
			catch (ThreadAbortException)
			{
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537686677), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_1);
				continue;
			}
			break;
		}
	}

	// Token: 0x060000AF RID: 175 RVA: 0x0000329B File Offset: 0x0000149B
	public Task method_5()
	{
		Task task = new Task(new Action(this.method_11));
		task.Start();
		return task;
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x0000C404 File Offset: 0x0000A604
	public void method_6()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537686697), Class185.smethod_0(537700781), true, false);
				JObject jobject = new JObject();
				string propertyName = Class185.smethod_0(537711046);
				JObject jobject2 = new JObject();
				jobject2[Class185.smethod_0(537703519)] = string.Format(Class185.smethod_0(537689540), this.string_0, this.string_6);
				jobject[propertyName] = jobject2;
				string propertyName2 = Class185.smethod_0(537674598);
				JObject jobject3 = new JObject();
				jobject3[Class185.smethod_0(537703519)] = string.Format(Class185.smethod_0(537689346), this.string_0, this.string_6, this.string_7);
				jobject[propertyName2] = jobject3;
				string propertyName3 = Class185.smethod_0(537689470);
				JObject jobject4 = new JObject();
				jobject4[Class185.smethod_0(537703519)] = string.Format(Class185.smethod_0(537689346), this.string_0, this.string_6, this.string_7);
				jobject[propertyName3] = jobject4;
				JObject jobject5 = jobject;
				HttpResponseMessage httpResponseMessage = this.class70_0.method_16(string.Format(Class185.smethod_0(537686859), this.string_0, this.string_5), jobject5, false);
				httpResponseMessage.EnsureSuccessStatusCode();
				this.string_8 = httpResponseMessage.smethod_0()[Class185.smethod_0(537660189)][Class185.smethod_0(537689174)].ToString();
			}
			catch (ThreadAbortException)
			{
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537686741), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_1);
				continue;
			}
			break;
		}
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x0000C5E0 File Offset: 0x0000A7E0
	public void method_7()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537686775), Class185.smethod_0(537700781), true, false);
				JObject jobject = new JObject();
				string propertyName = Class185.smethod_0(537689444);
				JObject jobject2 = new JObject();
				jobject2[Class185.smethod_0(537689236)] = Class185.smethod_0(537689221);
				jobject2[Class185.smethod_0(537689269)] = Class185.smethod_0(537689254);
				jobject2[Class185.smethod_0(537689288)] = Class185.smethod_0(537689337);
				jobject[propertyName] = jobject2;
				object key = Class185.smethod_0(537689236);
				jobject[Class185.smethod_0(537689444)][key] = Class185.smethod_0(537689221);
				object key2 = Class185.smethod_0(537689269);
				jobject[Class185.smethod_0(537689444)][key2] = Class185.smethod_0(537689254);
				object key3 = Class185.smethod_0(537689288);
				jobject[Class185.smethod_0(537689444)][key3] = Class185.smethod_0(537689337);
				JObject jobject3 = jobject;
				HttpResponseMessage httpResponseMessage = this.class70_0.method_9(string.Format(Class185.smethod_0(537686546), this.string_0, this.string_5), jobject3, true);
				while (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537686602)))
				{
					this.class4_0.method_4(Class185.smethod_0(537663011), Class185.smethod_0(537700781), true, false);
					httpResponseMessage = this.class70_0.method_9(string.Format(Class185.smethod_0(537686546), this.string_0, this.string_5), jobject3, true);
					Thread.Sleep(GClass0.int_0);
				}
				httpResponseMessage.EnsureSuccessStatusCode();
				JObject jobject4 = httpResponseMessage.smethod_0();
				this.string_9 = jobject4[Class185.smethod_0(537674058)].ToString();
				this.string_10 = jobject4[Class185.smethod_0(537686628)][Class185.smethod_0(537686412)].ToString().Split(new char[]
				{
					'='
				})[1].Split(new char[]
				{
					'"'
				})[0];
			}
			catch (ThreadAbortException)
			{
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537686463), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_1);
				continue;
			}
			break;
		}
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x0000C894 File Offset: 0x0000AA94
	public void method_8()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537660830), Class185.smethod_0(537700964), true, false);
				Dictionary<string, string> dictionary = Class70.smethod_1();
				dictionary[Class185.smethod_0(537686480)] = ((string)this.jtoken_1[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660835)]).Replace(Class185.smethod_0(537711014), string.Empty);
				dictionary[Class185.smethod_0(537660870)] = (string)this.jtoken_1[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660870)];
				dictionary[Class185.smethod_0(537660699)] = (string)this.jtoken_1[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660699)];
				dictionary[Class185.smethod_0(537686466)] = (string)this.jtoken_1[Class185.smethod_0(537662788)][Class185.smethod_0(537660840)][Class185.smethod_0(537660682)];
				dictionary[Class185.smethod_0(537686515)] = this.string_10;
				dictionary[Class185.smethod_0(537670350)] = Class185.smethod_0(537686503);
				HttpResponseMessage httpResponseMessage = this.class70_0.method_7(Class185.smethod_0(537686293), dictionary, false);
				if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537686314)))
				{
					this.class4_0.method_0(Class185.smethod_0(537686337), Class185.smethod_0(537700909), false);
				}
				string string_ = httpResponseMessage.Headers.GetValues(Class185.smethod_0(537686380)).First<string>().ToString();
				this.method_9(string_);
			}
			catch (ThreadAbortException)
			{
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537660605), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_1);
				continue;
			}
			break;
		}
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x0000CB0C File Offset: 0x0000AD0C
	public void method_9(string string_11)
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537658294), Class185.smethod_0(537700964), true, false);
				HttpResponseMessage httpResponseMessage_ = this.class70_0.method_9(string.Format(Class185.smethod_0(537686171), this.string_0, this.string_9), JObject.Parse(string.Format(Class185.smethod_0(537686220), string_11)), true);
				while (httpResponseMessage_.smethod_0().ToString().Contains(Class185.smethod_0(537686246)))
				{
					Thread.Sleep(1000);
					httpResponseMessage_ = this.class70_0.method_9(string.Format(Class185.smethod_0(537686171), this.string_0, this.string_9), JObject.Parse(string.Format(Class185.smethod_0(537686220), string_11)), true);
				}
				while (httpResponseMessage_.smethod_0().ToString().Contains(Class185.smethod_0(537686024)))
				{
					Thread.Sleep(1000);
					httpResponseMessage_ = this.class70_0.method_9(string.Format(Class185.smethod_0(537686171), this.string_0, this.string_9), JObject.Parse(string.Format(Class185.smethod_0(537686220), string_11)), true);
				}
				if (httpResponseMessage_.smethod_0()[Class185.smethod_0(537706613)].ToString() == Class185.smethod_0(537686066))
				{
					this.class4_0.method_9(true);
					this.class4_0.method_0(Class185.smethod_0(537660452), Class185.smethod_0(537700909), false);
				}
				else if (httpResponseMessage_.smethod_0()[Class185.smethod_0(537706613)].ToString() == Class185.smethod_0(537716259))
				{
					this.class4_0.method_0(Class185.smethod_0(537660491), Class185.smethod_0(537700909), false);
				}
				else
				{
					this.class4_0.method_12();
					this.class4_0.method_9(false);
					this.class4_0.method_0(Class185.smethod_0(537658349), Class185.smethod_0(537658124), false);
				}
			}
			catch (ThreadAbortException)
			{
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537658168), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_1);
				continue;
			}
			break;
		}
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x000032B4 File Offset: 0x000014B4
	private bool method_10(JToken jtoken_2)
	{
		return Class172.smethod_2(this.string_4, jtoken_2[Class185.smethod_0(537712143)].ToString());
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x0000CD8C File Offset: 0x0000AF8C
	private void method_11()
	{
		for (;;)
		{
			try
			{
				this.class4_0.method_4(Class185.smethod_0(537686049), Class185.smethod_0(537700781), true, false);
				JObject jobject = new JObject();
				jobject[Class185.smethod_0(537677019)] = this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537662508)];
				jobject[Class185.smethod_0(537677003)] = this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537662540)];
				jobject[Class185.smethod_0(537662792)] = this.jtoken_1[Class185.smethod_0(537662788)][Class185.smethod_0(537662792)];
				jobject[Class185.smethod_0(537660356)] = this.jtoken_1[Class185.smethod_0(537662788)][Class185.smethod_0(537660356)];
				jobject[Class185.smethod_0(537686080)] = false;
				jobject[Class185.smethod_0(537686112)] = true;
				JObject jobject2 = jobject;
				JObject jobject3 = new JObject();
				jobject3[Class185.smethod_0(537677019)] = this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537662508)];
				jobject3[Class185.smethod_0(537677003)] = this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537662540)];
				jobject3[Class185.smethod_0(537662588)] = this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537662571)];
				jobject3[Class185.smethod_0(537662567)] = this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537660310)];
				jobject3[Class185.smethod_0(537660334)] = this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)];
				jobject3[Class185.smethod_0(537687966)] = Class172.smethod_0((string)this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], false);
				jobject3[Class185.smethod_0(537660385)] = Class172.smethod_1((string)this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537660334)], (string)this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537660385)]);
				jobject3[Class185.smethod_0(537687947)] = this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537660362)];
				jobject3[Class185.smethod_0(537676819)] = this.jtoken_1[Class185.smethod_0(537660189)][Class185.smethod_0(537660290)];
				jobject3[Class185.smethod_0(537687994)] = false;
				jobject3[Class185.smethod_0(537688024)] = true;
				JObject jobject4 = jobject3;
				JObject jobject5 = new JObject();
				jobject5[Class185.smethod_0(537677019)] = this.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537662508)];
				jobject5[Class185.smethod_0(537677003)] = this.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537662540)];
				jobject5[Class185.smethod_0(537662588)] = this.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537662571)];
				jobject5[Class185.smethod_0(537662567)] = this.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537660310)];
				jobject5[Class185.smethod_0(537660334)] = this.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537688015)];
				jobject5[Class185.smethod_0(537687966)] = Class172.smethod_0((string)this.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)], false);
				jobject5[Class185.smethod_0(537660385)] = Class172.smethod_1((string)this.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537660334)], (string)this.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537660385)]);
				jobject5[Class185.smethod_0(537687947)] = this.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537660362)];
				jobject5[Class185.smethod_0(537676819)] = this.jtoken_1[Class185.smethod_0(537662526)][Class185.smethod_0(537660290)];
				jobject5[Class185.smethod_0(537687994)] = true;
				jobject5[Class185.smethod_0(537688024)] = false;
				JObject jobject6 = jobject5;
				jobject2[Class185.smethod_0(537688055)] = new JArray(new object[]
				{
					jobject4,
					jobject6
				});
				HttpResponseMessage httpResponseMessage = this.class70_0.method_9(string.Format(Class185.smethod_0(537688039), this.string_0), jobject2, true);
				if (httpResponseMessage.StatusCode == HttpStatusCode.Conflict)
				{
					this.class4_0.method_0(Class185.smethod_0(537688219), Class185.smethod_0(537700909), false);
				}
				httpResponseMessage.EnsureSuccessStatusCode();
				this.string_6 = httpResponseMessage.smethod_0()[Class185.smethod_0(537674058)].ToString();
				this.string_7 = httpResponseMessage.smethod_0()[Class185.smethod_0(537688055)][0][Class185.smethod_0(537674058)].ToString();
			}
			catch (ThreadAbortException)
			{
			}
			catch
			{
				this.class4_0.method_4(Class185.smethod_0(537687841), Class185.smethod_0(537700781), true, false);
				Thread.Sleep(GClass0.int_1);
				continue;
			}
			break;
		}
	}

	// Token: 0x0400006E RID: 110
	private Class70 class70_0;

	// Token: 0x0400006F RID: 111
	private JToken jtoken_0;

	// Token: 0x04000070 RID: 112
	private JToken jtoken_1;

	// Token: 0x04000071 RID: 113
	private Class4 class4_0;

	// Token: 0x04000072 RID: 114
	private string string_0;

	// Token: 0x04000073 RID: 115
	private string string_1;

	// Token: 0x04000074 RID: 116
	private string string_2;

	// Token: 0x04000075 RID: 117
	private string string_3;

	// Token: 0x04000076 RID: 118
	private string string_4;

	// Token: 0x04000077 RID: 119
	private string string_5;

	// Token: 0x04000078 RID: 120
	private string string_6;

	// Token: 0x04000079 RID: 121
	private string string_7;

	// Token: 0x0400007A RID: 122
	private string string_8;

	// Token: 0x0400007B RID: 123
	private string string_9;

	// Token: 0x0400007C RID: 124
	private string string_10;

	// Token: 0x0400007D RID: 125
	private bool bool_0;

	// Token: 0x0400007E RID: 126
	private JObject jobject_0;

	// Token: 0x0200001C RID: 28
	[Serializable]
	private sealed class Class14
	{
		// Token: 0x060000B8 RID: 184 RVA: 0x000032E2 File Offset: 0x000014E2
		internal bool method_0(JToken jtoken_0)
		{
			return jtoken_0[Class185.smethod_0(537710986)][Class185.smethod_0(537690097)].ToString() == Class185.smethod_0(537690083);
		}

		// Token: 0x0400007F RID: 127
		public static readonly Class13.Class14 class14_0 = new Class13.Class14();

		// Token: 0x04000080 RID: 128
		public static Func<JToken, bool> func_0;
	}
}
