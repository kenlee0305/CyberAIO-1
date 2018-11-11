using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using EO.WebBrowser;
using Newtonsoft.Json.Linq;

// Token: 0x020000BB RID: 187
internal sealed class Class101
{
	// Token: 0x060004F0 RID: 1264 RVA: 0x0000550D File Offset: 0x0000370D
	public static void smethod_0(object object_0, JSExtInvokeArgs jsextInvokeArgs_0)
	{
		new Thread(new ParameterizedThreadStart(new Class101.Class102
		{
			jobject_0 = JObject.Parse(jsextInvokeArgs_0.Arguments.First<object>().ToString())
		}.method_0)).Start();
	}

	// Token: 0x060004F1 RID: 1265 RVA: 0x0002AEF8 File Offset: 0x000290F8
	public static void smethod_1(string string_0, string string_1)
	{
		string string_2;
		string string_3;
		try
		{
			string text = GForm1.webView_0.QueueScriptCall(Class185.smethod_0(537703496)).smethod_0();
			Class70 @class = new Class70(string_0, Class185.smethod_0(537692910), 10, false, true, null, false);
			string text2;
			if (!(text == Class185.smethod_0(537703540)))
			{
				if (!(text == Class185.smethod_0(537703522)))
				{
					if (!(text == Class185.smethod_0(537701264)))
					{
						if (!(text == Class185.smethod_0(537701259)))
						{
							if (!(text == Class185.smethod_0(537701307)))
							{
								if (!(text == Class185.smethod_0(537701291)))
								{
									text2 = text;
									try
									{
										text = new Uri(text2).Host;
										goto IL_17D;
									}
									catch
									{
										GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537701089), string_1, Class185.smethod_0(537700923), Class185.smethod_0(537700909)));
										return;
									}
								}
								text2 = Class185.smethod_0(537701071);
							}
							else
							{
								text2 = Class185.smethod_0(537701047);
							}
						}
						else
						{
							text2 = Class185.smethod_0(537701016);
							@class.httpClient_0.DefaultRequestHeaders.ExpectContinue = new bool?(false);
							@class.httpClient_0.DefaultRequestHeaders.TryAddWithoutValidation(Class185.smethod_0(537701050), Class185.smethod_0(537696162));
						}
					}
					else
					{
						text2 = Class185.smethod_0(537701134);
					}
				}
				else
				{
					text2 = Class185.smethod_0(537701361);
				}
			}
			else
			{
				text2 = Class185.smethod_0(537701337);
			}
			IL_17D:
			GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537700903), string_1, Class185.smethod_0(537700979), Class185.smethod_0(537700964)));
			GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537700753), string_1, text, Class185.smethod_0(537700781)));
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			HttpResponseMessage httpResponseMessage = @class.method_5(text2, true);
			stopwatch.Stop();
			long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
			if (httpResponseMessage.IsSuccessStatusCode)
			{
				string_2 = elapsedMilliseconds.ToString() + Class185.smethod_0(537700827);
				string_3 = Class185.smethod_0(537700820);
				if (text == Class185.smethod_0(537703522))
				{
					if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537700802)))
					{
						GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537700753), string_1, Class185.smethod_0(537700860), Class185.smethod_0(537700781)));
					}
					else if (httpResponseMessage.smethod_3().Contains(Class185.smethod_0(537700845)))
					{
						GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537700753), string_1, Class185.smethod_0(537700839), Class185.smethod_0(537700781)));
					}
				}
			}
			else if (httpResponseMessage.StatusCode == (HttpStatusCode)430)
			{
				string_2 = Class185.smethod_0(537700616);
				string_3 = Class185.smethod_0(537700613);
			}
			else if (httpResponseMessage.StatusCode == HttpStatusCode.ProxyAuthenticationRequired)
			{
				string_2 = Class185.smethod_0(537700671);
				string_3 = Class185.smethod_0(537700613);
			}
			else
			{
				string_2 = string.Format(Class185.smethod_0(537700698), (int)httpResponseMessage.StatusCode);
				string_3 = Class185.smethod_0(537700613);
			}
		}
		catch
		{
			string_2 = Class185.smethod_0(537700684);
			string_3 = Class185.smethod_0(537700613);
		}
		Class101.smethod_2(string_1, string_3, string_2);
	}

	// Token: 0x060004F2 RID: 1266 RVA: 0x00005544 File Offset: 0x00003744
	public static void smethod_2(string string_0, string string_1, string string_2)
	{
		GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537701089), string_0, string_2, string_1));
	}

	// Token: 0x020000BC RID: 188
	private sealed class Class102
	{
		// Token: 0x060004F4 RID: 1268 RVA: 0x00005563 File Offset: 0x00003763
		internal void method_0(object object_0)
		{
			Class101.smethod_1(this.jobject_0[Class185.smethod_0(537692535)].ToString(), this.jobject_0[Class185.smethod_0(537703519)].ToString());
		}

		// Token: 0x0400026B RID: 619
		public JObject jobject_0;
	}
}
