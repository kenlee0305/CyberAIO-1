using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;
using CyberAIO.Websites.Shopify;
using EO.WebBrowser;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json.Linq;

// Token: 0x020000D6 RID: 214
internal sealed class Class116
{
	// Token: 0x06000591 RID: 1425 RVA: 0x00033F94 File Offset: 0x00032194
	public static void smethod_0(object object_0, JSExtInvokeArgs jsextInvokeArgs_0)
	{
		try
		{
			foreach (KeyValuePair<string, JToken> keyValuePair in JObject.Parse(jsextInvokeArgs_0.Arguments.First<object>().ToString()))
			{
				Class116.Class117 @class = new Class116.Class117();
				@class.jtoken_0 = keyValuePair.Value;
				if (GForm1.dictionary_0.ContainsKey((int)@class.jtoken_0[Class185.smethod_0(537703519)]))
				{
					if (Class116.Class119.callSite_0 == null)
					{
						Class116.Class119.callSite_0 = CallSite<Func<CallSite, object, Thread>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Thread), typeof(Class116)));
					}
					if (Class116.Class119.callSite_0.Target(Class116.Class119.callSite_0, GForm1.dictionary_0[(int)@class.jtoken_0[Class185.smethod_0(537703519)]][Class185.smethod_0(537700090)]).IsAlive)
					{
						continue;
					}
				}
				string text = @class.jtoken_0[Class185.smethod_0(537700413)].ToString();
				uint num = Class98.smethod_0(text);
				Thread thread;
				if (num <= 1213666813u)
				{
					if (num <= 834122706u)
					{
						if (num <= 156382626u)
						{
							if (num <= 72053246u)
							{
								if (num != 7379352u)
								{
									if (num != 72053246u)
									{
										goto IL_837;
									}
									if (!(text == Class185.smethod_0(537699710)))
									{
										goto IL_837;
									}
									thread = new Thread(new ThreadStart(@class.method_14));
								}
								else
								{
									if (!(text == Class185.smethod_0(537699521)))
									{
										goto IL_837;
									}
									thread = new Thread(new ThreadStart(@class.method_20));
								}
							}
							else if (num != 94696313u)
							{
								if (num != 156382626u)
								{
									goto IL_837;
								}
								if (!(text == Class185.smethod_0(537699748)))
								{
									goto IL_837;
								}
								thread = new Thread(new ThreadStart(@class.method_4));
							}
							else
							{
								if (!(text == Class185.smethod_0(537713557)))
								{
									goto IL_837;
								}
								thread = new Thread(new ThreadStart(@class.method_30));
							}
						}
						else if (num <= 537959913u)
						{
							if (num != 356287031u)
							{
								if (num != 537959913u)
								{
									goto IL_837;
								}
								if (!(text == Class185.smethod_0(537699461)))
								{
									goto IL_837;
								}
								thread = new Thread(new ThreadStart(@class.method_17));
							}
							else
							{
								if (!(text == Class185.smethod_0(537699831)))
								{
									goto IL_837;
								}
								thread = new Thread(new ThreadStart(@class.method_7));
							}
						}
						else if (num != 607951316u)
						{
							if (num != 834122706u)
							{
								goto IL_837;
							}
							if (!(text == Class185.smethod_0(537699732)))
							{
								goto IL_837;
							}
							thread = new Thread(new ThreadStart(@class.method_1));
						}
						else
						{
							if (!(text == Class185.smethod_0(537699782)))
							{
								goto IL_837;
							}
							thread = new Thread(new ThreadStart(@class.method_6));
						}
					}
					else if (num <= 1073939897u)
					{
						if (num <= 993983648u)
						{
							if (num != 978780147u)
							{
								if (num != 993983648u)
								{
									goto IL_837;
								}
								if (!(text == Class185.smethod_0(537699797)))
								{
									goto IL_837;
								}
								thread = new Thread(new ThreadStart(@class.method_5));
							}
							else
							{
								if (!(text == Class185.smethod_0(537699608)))
								{
									goto IL_837;
								}
								thread = new Thread(new ThreadStart(@class.method_8));
							}
						}
						else if (num != 1033461544u)
						{
							if (num != 1073939897u)
							{
								goto IL_837;
							}
							if (!(text == Class185.smethod_0(537699498)))
							{
								goto IL_837;
							}
							thread = new Thread(new ThreadStart(@class.method_18));
						}
						else
						{
							if (!(text == Class185.smethod_0(537699389)))
							{
								goto IL_837;
							}
							thread = new Thread(new ThreadStart(@class.method_24));
						}
					}
					else if (num <= 1127660147u)
					{
						if (num != 1115811218u)
						{
							if (num != 1127660147u)
							{
								goto IL_837;
							}
							if (!(text == Class185.smethod_0(537699676)))
							{
								goto IL_837;
							}
							thread = new Thread(new ThreadStart(@class.method_12));
						}
						else
						{
							if (!(text == Class185.smethod_0(537699763)))
							{
								goto IL_837;
							}
							thread = new Thread(new ThreadStart(@class.method_3));
						}
					}
					else if (num != 1162892671u)
					{
						if (num != 1213666813u)
						{
							goto IL_837;
						}
						if (!(text == Class185.smethod_0(537699627)))
						{
							goto IL_837;
						}
						thread = new Thread(new ThreadStart(@class.method_11));
					}
					else
					{
						if (!(text == Class185.smethod_0(537699593)))
						{
							goto IL_837;
						}
						thread = new Thread(new ThreadStart(@class.method_9));
					}
				}
				else if (num <= 3276705478u)
				{
					if (num <= 2445159016u)
					{
						if (num <= 1494588195u)
						{
							if (num != 1258127411u)
							{
								if (num != 1494588195u)
								{
									goto IL_837;
								}
								if (!(text == Class185.smethod_0(537699337)))
								{
									goto IL_837;
								}
								thread = new Thread(new ThreadStart(@class.method_23));
							}
							else
							{
								if (!(text == Class185.smethod_0(537699557)))
								{
									goto IL_837;
								}
								thread = new Thread(new ThreadStart(@class.method_22));
							}
						}
						else if (num != 1518474074u)
						{
							if (num != 2445159016u)
							{
								goto IL_837;
							}
							if (!(text == Class185.smethod_0(537699441)))
							{
								goto IL_837;
							}
							thread = new Thread(new ThreadStart(@class.method_28));
						}
						else
						{
							if (!(text == Class185.smethod_0(537699695)))
							{
								goto IL_837;
							}
							thread = new Thread(new ThreadStart(@class.method_15));
						}
					}
					else if (num <= 2692391852u)
					{
						if (num != 2508713984u)
						{
							if (num != 2692391852u)
							{
								goto IL_837;
							}
							if (!(text == Class185.smethod_0(537703522)))
							{
								goto IL_837;
							}
							thread = new Thread(new ThreadStart(@class.method_31));
						}
						else
						{
							if (!(text == Class185.smethod_0(537699568)))
							{
								goto IL_837;
							}
							thread = new Thread(new ThreadStart(@class.method_21));
						}
					}
					else if (num != 3138249339u)
					{
						if (num != 3276705478u)
						{
							goto IL_837;
						}
						if (!(text == Class185.smethod_0(537701307)))
						{
							goto IL_837;
						}
						thread = new Thread(new ThreadStart(@class.method_0));
					}
					else
					{
						if (!(text == Class185.smethod_0(537699423)))
						{
							goto IL_837;
						}
						thread = new Thread(new ThreadStart(@class.method_26));
					}
				}
				else if (num <= 3925924200u)
				{
					if (num <= 3544959638u)
					{
						if (num != 3520812353u)
						{
							if (num != 3544959638u)
							{
								goto IL_837;
							}
							if (!(text == Class185.smethod_0(537699429)))
							{
								goto IL_837;
							}
							thread = new Thread(new ThreadStart(@class.method_29));
						}
						else
						{
							if (!(text == Class185.smethod_0(537699551)))
							{
								goto IL_837;
							}
							thread = new Thread(new ThreadStart(@class.method_19));
						}
					}
					else if (num != 3842920480u)
					{
						if (num != 3925924200u)
						{
							goto IL_837;
						}
						if (!(text == Class185.smethod_0(537699715)))
						{
							goto IL_837;
						}
						thread = new Thread(new ThreadStart(@class.method_2));
					}
					else
					{
						if (!(text == Class185.smethod_0(537699371)))
						{
							goto IL_837;
						}
						thread = new Thread(new ThreadStart(@class.method_25));
					}
				}
				else if (num <= 4053610095u)
				{
					if (num != 4009715463u)
					{
						if (num != 4053610095u)
						{
							goto IL_837;
						}
						if (!(text == Class185.smethod_0(537699472)))
						{
							goto IL_837;
						}
						thread = new Thread(new ThreadStart(@class.method_16));
					}
					else
					{
						if (!(text == Class185.smethod_0(537699392)))
						{
							goto IL_837;
						}
						thread = new Thread(new ThreadStart(@class.method_27));
					}
				}
				else if (num != 4249577209u)
				{
					if (num != 4285839398u)
					{
						goto IL_837;
					}
					if (!(text == Class185.smethod_0(537699661)))
					{
						goto IL_837;
					}
					thread = new Thread(new ThreadStart(@class.method_13));
				}
				else
				{
					if (!(text == Class185.smethod_0(537699642)))
					{
						goto IL_837;
					}
					thread = new Thread(new ThreadStart(@class.method_10));
				}
				IL_85D:
				thread.IsBackground = true;
				Dictionary<int, Dictionary<string, object>> dictionary_ = GForm1.dictionary_0;
				int key = (int)@class.jtoken_0[Class185.smethod_0(537703519)];
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary[Class185.smethod_0(537700090)] = thread;
				dictionary[Class185.smethod_0(537700087)] = false;
				dictionary_[key] = dictionary;
				thread.Start();
				GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537713537), @class.jtoken_0[Class185.smethod_0(537703519)]));
				continue;
				IL_837:
				thread = new Thread(new ThreadStart(@class.method_32));
				goto IL_85D;
			}
		}
		catch
		{
		}
	}

	// Token: 0x06000592 RID: 1426 RVA: 0x000348E0 File Offset: 0x00032AE0
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"ControlThread\"/>\r\n</PermissionSet>\r\n")]
	public static void smethod_1(object object_0, JSExtInvokeArgs jsextInvokeArgs_0)
	{
		Class116.Class118 @class = new Class116.Class118();
		@class.jsextInvokeArgs_0 = jsextInvokeArgs_0;
		try
		{
			new Task(new Action(@class.method_0)).Start();
		}
		catch
		{
		}
	}

	// Token: 0x020000D7 RID: 215
	private sealed class Class117
	{
		// Token: 0x06000594 RID: 1428 RVA: 0x00005ADF File Offset: 0x00003CDF
		internal void method_0()
		{
			new Class111(this.jtoken_0).method_0();
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00005AF1 File Offset: 0x00003CF1
		internal void method_1()
		{
			new Class59(this.jtoken_0).method_0();
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00005B03 File Offset: 0x00003D03
		internal void method_2()
		{
			new Class27(this.jtoken_0).method_0();
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00005B15 File Offset: 0x00003D15
		internal void method_3()
		{
			new Class181(this.jtoken_0, Class185.smethod_0(537698888)).method_0();
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00005B31 File Offset: 0x00003D31
		internal void method_4()
		{
			new Class181(this.jtoken_0, Class185.smethod_0(537698917)).method_0();
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00005B4D File Offset: 0x00003D4D
		internal void method_5()
		{
			new Class181(this.jtoken_0, Class185.smethod_0(537698738)).method_0();
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00005B69 File Offset: 0x00003D69
		internal void method_6()
		{
			new Class181(this.jtoken_0, Class185.smethod_0(537698767)).method_0();
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00005B85 File Offset: 0x00003D85
		internal void method_7()
		{
			new Class181(this.jtoken_0, Class185.smethod_0(537698588)).method_0();
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00005BA1 File Offset: 0x00003DA1
		internal void method_8()
		{
			new Class181(this.jtoken_0, Class185.smethod_0(537698601)).method_0();
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00005BBD File Offset: 0x00003DBD
		internal void method_9()
		{
			new Class181(this.jtoken_0, Class185.smethod_0(537698630)).method_0();
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00005BD9 File Offset: 0x00003DD9
		internal void method_10()
		{
			new Class181(this.jtoken_0, Class185.smethod_0(537698451)).method_0();
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00005BF5 File Offset: 0x00003DF5
		internal void method_11()
		{
			new Class181(this.jtoken_0, Class185.smethod_0(537698464)).method_0();
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00005C11 File Offset: 0x00003E11
		internal void method_12()
		{
			new Class181(this.jtoken_0, Class185.smethod_0(537698557)).method_0();
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00005C2D File Offset: 0x00003E2D
		internal void method_13()
		{
			new Class181(this.jtoken_0, Class185.smethod_0(537698314)).method_0();
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00005C49 File Offset: 0x00003E49
		internal void method_14()
		{
			new Class181(this.jtoken_0, Class185.smethod_0(537698343)).method_0();
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00005C65 File Offset: 0x00003E65
		internal void method_15()
		{
			new Class181(this.jtoken_0, Class185.smethod_0(537698420)).method_0();
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00005C81 File Offset: 0x00003E81
		internal void method_16()
		{
			new Class56(this.jtoken_0).method_0();
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00005C93 File Offset: 0x00003E93
		internal void method_17()
		{
			new Class126(this.jtoken_0, Class185.smethod_0(537700282)).method_0();
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00005CAF File Offset: 0x00003EAF
		internal void method_18()
		{
			new Class126(this.jtoken_0, Class185.smethod_0(537700271)).method_0();
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00005CCB File Offset: 0x00003ECB
		internal void method_19()
		{
			new Class126(this.jtoken_0, Class185.smethod_0(537700307)).method_0();
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00005CE7 File Offset: 0x00003EE7
		internal void method_20()
		{
			new Class126(this.jtoken_0, Class185.smethod_0(537700344)).method_0();
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00005D03 File Offset: 0x00003F03
		internal void method_21()
		{
			new Class126(this.jtoken_0, Class185.smethod_0(537700330)).method_0();
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00005D1F File Offset: 0x00003F1F
		internal void method_22()
		{
			new Class108(this.jtoken_0, Class185.smethod_0(537700282)).method_0();
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00005D3B File Offset: 0x00003F3B
		internal void method_23()
		{
			new Class108(this.jtoken_0, Class185.smethod_0(537700271)).method_0();
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00005D57 File Offset: 0x00003F57
		internal void method_24()
		{
			new Class108(this.jtoken_0, Class185.smethod_0(537700344)).method_0();
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00005D73 File Offset: 0x00003F73
		internal void method_25()
		{
			new Class108(this.jtoken_0, Class185.smethod_0(537700330)).method_0();
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00005CCB File Offset: 0x00003ECB
		internal void method_26()
		{
			new Class126(this.jtoken_0, Class185.smethod_0(537700307)).method_0();
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00005D8F File Offset: 0x00003F8F
		internal void method_27()
		{
			new Class13(this.jtoken_0, Class185.smethod_0(537700113), Class185.smethod_0(537700098)).method_0();
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00005DB5 File Offset: 0x00003FB5
		internal void method_28()
		{
			new Class13(this.jtoken_0, Class185.smethod_0(537700185), Class185.smethod_0(537700171)).method_0();
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00005DDB File Offset: 0x00003FDB
		internal void method_29()
		{
			new Class13(this.jtoken_0, Class185.smethod_0(537700194), Class185.smethod_0(537699985)).method_0();
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00005E01 File Offset: 0x00004001
		internal void method_30()
		{
			new Class13(this.jtoken_0, Class185.smethod_0(537700008), Class185.smethod_0(537700003)).method_0();
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00005E27 File Offset: 0x00004027
		internal void method_31()
		{
			new Class135(this.jtoken_0).method_0();
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00005E39 File Offset: 0x00004039
		internal void method_32()
		{
			new Shopify(this.jtoken_0).Start();
		}

		// Token: 0x040002BE RID: 702
		public JToken jtoken_0;
	}

	// Token: 0x020000D8 RID: 216
	private sealed class Class118
	{
		// Token: 0x060005B6 RID: 1462 RVA: 0x00034928 File Offset: 0x00032B28
		internal void method_0()
		{
			JObject jobject = JObject.Parse(this.jsextInvokeArgs_0.Arguments.First<object>().ToString());
			foreach (KeyValuePair<string, JToken> keyValuePair in jobject)
			{
				JToken value = keyValuePair.Value;
				if (GForm1.dictionary_0.ContainsKey((int)value[Class185.smethod_0(537703519)]))
				{
					object arg = GForm1.dictionary_0[(int)value[Class185.smethod_0(537703519)]][Class185.smethod_0(537700090)];
					if (Class116.Class120.callSite_0 == null)
					{
						Class116.Class120.callSite_0 = CallSite<Func<CallSite, object, Thread>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Thread), typeof(Class116)));
					}
					if (Class116.Class120.callSite_0.Target(Class116.Class120.callSite_0, arg).IsAlive)
					{
						GForm1.dictionary_0[(int)value[Class185.smethod_0(537703519)]][Class185.smethod_0(537700087)] = true;
						GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537700066), value[Class185.smethod_0(537703519)]));
					}
				}
			}
			foreach (KeyValuePair<string, JToken> keyValuePair2 in jobject)
			{
				JToken value2 = keyValuePair2.Value;
				if (GForm1.dictionary_0.ContainsKey((int)value2[Class185.smethod_0(537703519)]))
				{
					object arg2 = GForm1.dictionary_0[(int)value2[Class185.smethod_0(537703519)]][Class185.smethod_0(537700090)];
					if (Class116.Class120.callSite_1 == null)
					{
						Class116.Class120.callSite_1 = CallSite<Func<CallSite, object, Thread>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Thread), typeof(Class116)));
					}
					if (Class116.Class120.callSite_1.Target(Class116.Class120.callSite_1, arg2).IsAlive)
					{
						Class30.smethod_1((int)value2[Class185.smethod_0(537703519)], null);
						if (Class116.Class120.callSite_2 == null)
						{
							Class116.Class120.callSite_2 = CallSite<Action<CallSite, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class185.smethod_0(537699894), null, typeof(Class116), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Class116.Class120.callSite_2.Target(Class116.Class120.callSite_2, arg2);
					}
				}
			}
			foreach (KeyValuePair<string, JToken> keyValuePair3 in jobject)
			{
				JToken value3 = keyValuePair3.Value;
				if (GForm1.dictionary_0.ContainsKey((int)value3[Class185.smethod_0(537703519)]))
				{
					object arg3 = GForm1.dictionary_0[(int)value3[Class185.smethod_0(537703519)]][Class185.smethod_0(537700090)];
					if (Class116.Class120.callSite_3 == null)
					{
						Class116.Class120.callSite_3 = CallSite<Func<CallSite, object, Thread>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Thread), typeof(Class116)));
					}
					if (Class116.Class120.callSite_3.Target(Class116.Class120.callSite_3, arg3).IsAlive)
					{
						if (Class116.Class120.callSite_4 == null)
						{
							Class116.Class120.callSite_4 = CallSite<Action<CallSite, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class185.smethod_0(537699874), null, typeof(Class116), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Class116.Class120.callSite_4.Target(Class116.Class120.callSite_4, arg3);
						GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537699933), value3[Class185.smethod_0(537703519)].ToString()));
						GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537699958), value3[Class185.smethod_0(537703519)].ToString()));
					}
					GForm1.dictionary_0.Remove((int)value3[Class185.smethod_0(537703519)]);
				}
			}
		}

		// Token: 0x040002BF RID: 703
		public JSExtInvokeArgs jsextInvokeArgs_0;
	}

	// Token: 0x020000D9 RID: 217
	private static class Class119
	{
		// Token: 0x040002C0 RID: 704
		public static CallSite<Func<CallSite, object, Thread>> callSite_0;
	}

	// Token: 0x020000DA RID: 218
	private static class Class120
	{
		// Token: 0x040002C1 RID: 705
		public static CallSite<Func<CallSite, object, Thread>> callSite_0;

		// Token: 0x040002C2 RID: 706
		public static CallSite<Func<CallSite, object, Thread>> callSite_1;

		// Token: 0x040002C3 RID: 707
		public static CallSite<Action<CallSite, object>> callSite_2;

		// Token: 0x040002C4 RID: 708
		public static CallSite<Func<CallSite, object, Thread>> callSite_3;

		// Token: 0x040002C5 RID: 709
		public static CallSite<Action<CallSite, object>> callSite_4;
	}
}
