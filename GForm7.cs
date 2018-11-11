using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Media;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using EO.Base;
using EO.WebBrowser;
using EO.WebEngine;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json.Linq;

// Token: 0x0200011D RID: 285
public sealed partial class GForm7 : Form
{
	// Token: 0x06000731 RID: 1841 RVA: 0x00006934 File Offset: 0x00004B34
	public GForm7(bool bool_1 = true)
	{
		this.method_13();
		this.method_1();
		this.method_8();
		this.bunifuThinButton2_2_Click(null, null);
	}

	// Token: 0x06000733 RID: 1843 RVA: 0x000423E0 File Offset: 0x000405E0
	public void method_0(string string_1, string string_2)
	{
		int num = 1;
		string text = (string_1 != null) ? string_1 : (Class185.smethod_0(537692546) + num);
		while (GForm7.dictionary_0.ContainsKey(text))
		{
			num++;
			text = Class185.smethod_0(537692546) + num;
		}
		Panel panel = new Panel();
		panel.Dock = DockStyle.Fill;
		BrowserOptions options = new BrowserOptions
		{
			EnableXSSAuditor = new bool?(false),
			EnableWebSecurity = new bool?(false)
		};
		WebView webView = new WebView();
		Engine engine = Engine.Create(text);
		if (string_2 != null)
		{
			try
			{
				string[] array = string_2.Split(new char[]
				{
					':'
				});
				if (array.Length == 4)
				{
					engine.Options.Proxy = new ProxyInfo(ProxyType.HTTP, array[0], Convert.ToInt32(array[1]), array[2], array[3]);
				}
				else if (array.Length == 2)
				{
					engine.Options.Proxy = new ProxyInfo(ProxyType.HTTP, array[0], Convert.ToInt32(array[1]));
				}
				else
				{
					string_2 = null;
				}
			}
			catch
			{
				string_2 = null;
			}
		}
		webView.SetOptions(options);
		webView.Engine = engine;
		webView.Engine.AllowRestart = true;
		webView.Create(panel.Handle);
		webView.RegisterJSExtensionFunction(Class185.smethod_0(537692509), new JSExtInvokeHandler(this.method_3));
		webView.RegisterJSExtensionFunction(Class185.smethod_0(537692490), new JSExtInvokeHandler(GForm7.smethod_3));
		webView.CertificateError += this.method_5;
		webView.BeforeContextMenu += this.method_4;
		Dictionary<string, Dictionary<string, object>> dictionary = GForm7.dictionary_0;
		string key = text;
		Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
		dictionary2[Class185.smethod_0(537692592)] = webView;
		dictionary2[Class185.smethod_0(537692562)] = true;
		dictionary2[Class185.smethod_0(537692539)] = panel;
		dictionary2[Class185.smethod_0(537692535)] = string_2;
		dictionary[key] = dictionary2;
		GForm7.smethod_7(text);
		this.method_2();
	}

	// Token: 0x06000734 RID: 1844 RVA: 0x000425DC File Offset: 0x000407DC
	public void method_1()
	{
		foreach (KeyValuePair<string, JToken> keyValuePair in GClass0.jobject_3)
		{
			string key = keyValuePair.Key;
			JToken jtoken = keyValuePair.Value[Class185.smethod_0(537692535)];
			this.method_0(key, (jtoken != null) ? jtoken.ToString() : null);
		}
		if (GClass0.jobject_3.Count == 0)
		{
			this.method_0(null, null);
		}
	}

	// Token: 0x06000735 RID: 1845 RVA: 0x00042668 File Offset: 0x00040868
	public void method_2()
	{
		JObject jobject = new JObject();
		foreach (KeyValuePair<string, Dictionary<string, object>> keyValuePair in GForm7.dictionary_0)
		{
			jobject[keyValuePair.Key] = new JObject();
			JToken jtoken = jobject[keyValuePair.Key];
			object key = Class185.smethod_0(537692535);
			if (GForm7.Class208.callSite_0 == null)
			{
				GForm7.Class208.callSite_0 = CallSite<Func<CallSite, object, JToken>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(JToken), typeof(GForm7)));
			}
			jtoken[key] = GForm7.Class208.callSite_0.Target(GForm7.Class208.callSite_0, keyValuePair.Value[Class185.smethod_0(537692535)]);
		}
		GClass0.jobject_3 = jobject;
		GClass0.smethod_2();
	}

	// Token: 0x06000736 RID: 1846 RVA: 0x00042750 File Offset: 0x00040950
	private void bunifuThinButton2_12_Click(object sender, EventArgs e)
	{
		try
		{
			if (!(this.bunifuMaterialTextbox_0.Text == Class185.smethod_0(537692515)))
			{
				string[] array = this.bunifuMaterialTextbox_0.Text.Split(new char[]
				{
					':'
				});
				if (array.Length == 4 || array.Length == 2)
				{
					if (GForm7.Class191.callSite_0 == null)
					{
						GForm7.Class191.callSite_0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, Class185.smethod_0(537692347), typeof(GForm7), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					object arg = GForm7.Class191.callSite_0.Target(GForm7.Class191.callSite_0, GForm7.dictionary_0[GForm7.string_0][Class185.smethod_0(537692592)]);
					if (array.Length == 4)
					{
						if (GForm7.Class191.callSite_2 == null)
						{
							GForm7.Class191.callSite_2 = CallSite<Func<CallSite, object, ProxyInfo, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, Class185.smethod_0(537692328), typeof(GForm7), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
							}));
						}
						Func<CallSite, object, ProxyInfo, object> target = GForm7.Class191.callSite_2.Target;
						CallSite callSite_ = GForm7.Class191.callSite_2;
						if (GForm7.Class191.callSite_1 == null)
						{
							GForm7.Class191.callSite_1 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, Class185.smethod_0(537692324), typeof(GForm7), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						target(callSite_, GForm7.Class191.callSite_1.Target(GForm7.Class191.callSite_1, arg), new ProxyInfo(ProxyType.HTTP, array[0], Convert.ToInt32(array[1]), array[2], array[3]));
					}
					else
					{
						if (array.Length != 2)
						{
							return;
						}
						if (GForm7.Class191.callSite_4 == null)
						{
							GForm7.Class191.callSite_4 = CallSite<Func<CallSite, object, ProxyInfo, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, Class185.smethod_0(537692328), typeof(GForm7), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
							}));
						}
						Func<CallSite, object, ProxyInfo, object> target2 = GForm7.Class191.callSite_4.Target;
						CallSite callSite_2 = GForm7.Class191.callSite_4;
						if (GForm7.Class191.callSite_3 == null)
						{
							GForm7.Class191.callSite_3 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, Class185.smethod_0(537692324), typeof(GForm7), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						target2(callSite_2, GForm7.Class191.callSite_3.Target(GForm7.Class191.callSite_3, arg), new ProxyInfo(ProxyType.HTTP, array[0], Convert.ToInt32(array[1])));
					}
					if (GForm7.Class191.callSite_6 == null)
					{
						GForm7.Class191.callSite_6 = CallSite<Action<CallSite, object, bool>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class185.smethod_0(537692370), null, typeof(GForm7), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Action<CallSite, object, bool> target3 = GForm7.Class191.callSite_6.Target;
					CallSite callSite_3 = GForm7.Class191.callSite_6;
					if (GForm7.Class191.callSite_5 == null)
					{
						GForm7.Class191.callSite_5 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, Class185.smethod_0(537692347), typeof(GForm7), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					target3(callSite_3, GForm7.Class191.callSite_5.Target(GForm7.Class191.callSite_5, GForm7.dictionary_0[GForm7.string_0][Class185.smethod_0(537692592)]), false);
					if (GForm7.Class191.callSite_7 == null)
					{
						GForm7.Class191.callSite_7 = CallSite<Action<CallSite, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class185.smethod_0(537692365), null, typeof(GForm7), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					GForm7.Class191.callSite_7.Target(GForm7.Class191.callSite_7, GForm7.dictionary_0[GForm7.string_0][Class185.smethod_0(537692592)]);
					BrowserOptions options = new BrowserOptions
					{
						EnableXSSAuditor = new bool?(false),
						EnableWebSecurity = new bool?(false)
					};
					WebView webView = new WebView();
					webView.SetOptions(options);
					WebView webView2 = webView;
					if (GForm7.Class191.callSite_8 == null)
					{
						GForm7.Class191.callSite_8 = CallSite<Func<CallSite, object, Engine>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Engine), typeof(GForm7)));
					}
					webView2.Engine = GForm7.Class191.callSite_8.Target(GForm7.Class191.callSite_8, arg);
					webView.Engine.AllowRestart = true;
					if (GForm7.Class191.callSite_10 == null)
					{
						GForm7.Class191.callSite_10 = CallSite<Action<CallSite, WebView, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class185.smethod_0(537692411), null, typeof(GForm7), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Action<CallSite, WebView, object> target4 = GForm7.Class191.callSite_10.Target;
					CallSite callSite_4 = GForm7.Class191.callSite_10;
					WebView arg2 = webView;
					if (GForm7.Class191.callSite_9 == null)
					{
						GForm7.Class191.callSite_9 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, Class185.smethod_0(537692392), typeof(GForm7), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					target4(callSite_4, arg2, GForm7.Class191.callSite_9.Target(GForm7.Class191.callSite_9, GForm7.dictionary_0[GForm7.string_0][Class185.smethod_0(537692539)]));
					webView.RegisterJSExtensionFunction(Class185.smethod_0(537692509), new JSExtInvokeHandler(this.method_3));
					webView.RegisterJSExtensionFunction(Class185.smethod_0(537692490), new JSExtInvokeHandler(GForm7.smethod_3));
					webView.CertificateError += this.method_5;
					webView.BeforeContextMenu += this.method_4;
					GForm7.dictionary_0[GForm7.string_0][Class185.smethod_0(537692592)] = webView;
					GForm7.dictionary_0[GForm7.string_0][Class185.smethod_0(537692535)] = this.bunifuMaterialTextbox_0.Text;
					this.pictureBox_4_Click(null, null);
					this.method_2();
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x06000737 RID: 1847 RVA: 0x00042D08 File Offset: 0x00040F08
	private void method_3(object object_0, JSExtInvokeArgs jsextInvokeArgs_0)
	{
		GForm7.Class193 @class = new GForm7.Class193();
		@class.jsextInvokeArgs_0 = jsextInvokeArgs_0;
		GForm7.concurrentDictionary_0[@class.jsextInvokeArgs_0.Arguments[1].ToString()] = @class.jsextInvokeArgs_0.Arguments.First<object>().ToString();
		ConcurrentDictionary<string, string> concurrentDictionary = GForm7.list_0.First(new Func<ConcurrentDictionary<string, string>, bool>(@class.method_0));
		GForm7.list_0.Remove(concurrentDictionary);
		GForm7.smethod_7(concurrentDictionary[Class185.smethod_0(537692592)]);
		this.method_7();
	}

	// Token: 0x06000738 RID: 1848 RVA: 0x00002C1D File Offset: 0x00000E1D
	public static string smethod_0(string string_1, string string_2, string string_3)
	{
		return string.Empty;
	}

	// Token: 0x06000739 RID: 1849 RVA: 0x00042D94 File Offset: 0x00040F94
	public static async Task<string> smethod_1(string string_1, string string_2, string string_3)
	{
		GForm1.gform1_0.Invoke(new MethodInvoker(GForm7.Class190.class190_0.method_0));
		string text = Class108.smethod_0(16);
		ConcurrentDictionary<string, string> concurrentDictionary = new ConcurrentDictionary<string, string>();
		concurrentDictionary[Class185.smethod_0(537692629)] = string_1;
		concurrentDictionary[Class185.smethod_0(537692611)] = string_2;
		concurrentDictionary[Class185.smethod_0(537692656)] = string_3;
		concurrentDictionary[Class185.smethod_0(537692633)] = text;
		concurrentDictionary[Class185.smethod_0(537692776)] = Class185.smethod_0(537692774);
		ConcurrentDictionary<string, string> concurrentDictionary2 = concurrentDictionary;
		GForm7.list_0.Add(concurrentDictionary2);
		string result;
		try
		{
			GForm7.smethod_2(null, null);
			while (!GForm7.concurrentDictionary_0.ContainsKey(text))
			{
				if (!GForm1.dictionary_0.ContainsKey((int)Convert.ToInt16(string_3)))
				{
					GForm7.list_0.Remove(concurrentDictionary2);
					if (concurrentDictionary2.ContainsKey(Class185.smethod_0(537692592)))
					{
						GForm7.smethod_7(concurrentDictionary2[Class185.smethod_0(537692592)]);
						GForm1.gform1_0.Invoke(new MethodInvoker(GForm7.Class190.class190_0.method_1));
					}
					return null;
				}
				TaskAwaiter taskAwaiter = Task.Delay(100).GetAwaiter();
				if (!taskAwaiter.IsCompleted)
				{
					await taskAwaiter;
					TaskAwaiter taskAwaiter2;
					taskAwaiter = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter);
				}
				taskAwaiter.GetResult();
			}
			result = GForm7.concurrentDictionary_0[text];
		}
		catch
		{
			GForm7.list_0.Remove(concurrentDictionary2);
			if (concurrentDictionary2.ContainsKey(Class185.smethod_0(537692592)))
			{
				GForm7.smethod_7(concurrentDictionary2[Class185.smethod_0(537692592)]);
				GForm1.gform1_0.Invoke(new MethodInvoker(GForm7.Class190.class190_0.method_2));
			}
			result = null;
		}
		return result;
	}

	// Token: 0x0600073A RID: 1850 RVA: 0x00042DEC File Offset: 0x00040FEC
	public static void smethod_2(object sender, EventArgs e)
	{
		if (GForm7.list_0.Any(new Func<ConcurrentDictionary<string, string>, bool>(GForm7.Class190.class190_0.method_3)))
		{
			if (GForm7.dictionary_0.Any(new Func<KeyValuePair<string, Dictionary<string, object>>, bool>(GForm7.Class190.class190_0.method_4)))
			{
				ConcurrentDictionary<string, string> concurrentDictionary = GForm7.list_0.First(new Func<ConcurrentDictionary<string, string>, bool>(GForm7.Class190.class190_0.method_5));
				concurrentDictionary[Class185.smethod_0(537692776)] = Class185.smethod_0(537692590);
				string key = GForm7.dictionary_0.ToList<KeyValuePair<string, Dictionary<string, object>>>().OrderBy(new Func<KeyValuePair<string, Dictionary<string, object>>, short>(GForm7.Class190.class190_0.method_6)).First(new Func<KeyValuePair<string, Dictionary<string, object>>, bool>(GForm7.Class190.class190_0.method_7)).Key;
				GForm7.dictionary_0[key][Class185.smethod_0(537692562)] = false;
				concurrentDictionary[Class185.smethod_0(537692592)] = key;
				if (GForm7.Class194.callSite_2 == null)
				{
					GForm7.Class194.callSite_2 = CallSite<Action<CallSite, object, string, string>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class185.smethod_0(537692389), null, typeof(GForm7), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				GForm7.Class194.callSite_2.Target(GForm7.Class194.callSite_2, GForm7.dictionary_0[key][Class185.smethod_0(537692592)], concurrentDictionary[Class185.smethod_0(537692611)].Contains(Class185.smethod_0(537692180)) ? GForm7.smethod_5(concurrentDictionary[Class185.smethod_0(537692629)], concurrentDictionary[Class185.smethod_0(537692633)]) : GForm7.smethod_4(concurrentDictionary[Class185.smethod_0(537692629)], concurrentDictionary[Class185.smethod_0(537692656)], concurrentDictionary[Class185.smethod_0(537692633)], concurrentDictionary[Class185.smethod_0(537692611)]), concurrentDictionary[Class185.smethod_0(537692611)]);
				if (key != GForm7.string_0)
				{
					if (GForm7.Class194.callSite_3 == null)
					{
						GForm7.Class194.callSite_3 = CallSite<Func<CallSite, object, bool>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(bool), typeof(GForm7)));
					}
					if (GForm7.Class194.callSite_3.Target(GForm7.Class194.callSite_3, GForm7.dictionary_0[GForm7.string_0][Class185.smethod_0(537692562)]))
					{
						GForm1.gform1_0.Invoke(new MethodInvoker(GForm7.Class190.class190_0.method_8));
					}
				}
			}
		}
	}

	// Token: 0x0600073B RID: 1851 RVA: 0x000430E0 File Offset: 0x000412E0
	public static async void smethod_3(object object_0, JSExtInvokeArgs jsextInvokeArgs_0)
	{
		try
		{
			GClass3.smethod_0(Class185.smethod_0(537692653), Class185.smethod_0(537692445));
			TaskAwaiter<Stream> taskAwaiter = Class143.smethod_0(jsextInvokeArgs_0.Arguments.First<object>().ToString()).GetAwaiter();
			if (!taskAwaiter.IsCompleted)
			{
				await taskAwaiter;
				TaskAwaiter<Stream> taskAwaiter2;
				taskAwaiter = taskAwaiter2;
				taskAwaiter2 = default(TaskAwaiter<Stream>);
			}
			TaskAwaiter<string> taskAwaiter3 = Class143.smethod_1(taskAwaiter.GetResult()).GetAwaiter();
			if (!taskAwaiter3.IsCompleted)
			{
				await taskAwaiter3;
				TaskAwaiter<string> taskAwaiter4;
				taskAwaiter3 = taskAwaiter4;
				taskAwaiter4 = default(TaskAwaiter<string>);
			}
			string result = taskAwaiter3.GetResult();
			GClass3.smethod_0(Class185.smethod_0(537692416) + result, Class185.smethod_0(537692445));
		}
		catch
		{
		}
	}

	// Token: 0x0600073C RID: 1852 RVA: 0x0004311C File Offset: 0x0004131C
	public static string smethod_4(string string_1, string string_2, string string_3, string string_4)
	{
		return string.Concat(new string[]
		{
			Class185.smethod_0(537692162),
			string_3,
			Class185.smethod_0(537693956),
			string_1,
			Class185.smethod_0(537693854),
			string_2,
			Class185.smethod_0(537693735),
			new Uri(string_4).Host,
			Class185.smethod_0(537693570)
		});
	}

	// Token: 0x0600073D RID: 1853 RVA: 0x0000698A File Offset: 0x00004B8A
	public static string smethod_5(string string_1, string string_2)
	{
		return string.Concat(new string[]
		{
			Class185.smethod_0(537693202),
			string_2,
			Class185.smethod_0(537691015),
			string_1,
			Class185.smethod_0(537690966)
		});
	}

	// Token: 0x0600073E RID: 1854 RVA: 0x000069C6 File Offset: 0x00004BC6
	public static string smethod_6()
	{
		return Class185.smethod_0(537690686);
	}

	// Token: 0x0600073F RID: 1855 RVA: 0x00043190 File Offset: 0x00041390
	public static void smethod_7(string string_1)
	{
		GForm7.dictionary_0[string_1][Class185.smethod_0(537692562)] = true;
		if (GForm7.Class197.callSite_0 == null)
		{
			GForm7.Class197.callSite_0 = CallSite<Action<CallSite, object, string>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class185.smethod_0(537692389), null, typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
			}));
		}
		GForm7.Class197.callSite_0.Target(GForm7.Class197.callSite_0, GForm7.dictionary_0[string_1][Class185.smethod_0(537692592)], GForm7.smethod_6());
		GForm7.smethod_2(null, null);
	}

	// Token: 0x06000740 RID: 1856 RVA: 0x00002C72 File Offset: 0x00000E72
	private void method_4(object sender, BeforeContextMenuEventArgs e)
	{
		e.Menu.Items.Clear();
	}

	// Token: 0x06000741 RID: 1857 RVA: 0x00002C84 File Offset: 0x00000E84
	public void method_5(object sender, CertificateErrorEventArgs e)
	{
		e.Continue();
	}

	// Token: 0x06000742 RID: 1858 RVA: 0x00002C8C File Offset: 0x00000E8C
	private void pictureBox_0_Click(object sender, EventArgs e)
	{
		base.Hide();
	}

	// Token: 0x06000743 RID: 1859 RVA: 0x00002C94 File Offset: 0x00000E94
	private void pictureBox_1_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	// Token: 0x06000744 RID: 1860 RVA: 0x00043244 File Offset: 0x00041444
	private void bunifuThinButton2_1_Click(object sender, EventArgs e)
	{
		if (GForm7.Class203.callSite_0 == null)
		{
			GForm7.Class203.callSite_0 = CallSite<Action<CallSite, object, string>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class185.smethod_0(537691887), null, typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
			}));
		}
		GForm7.Class203.callSite_0.Target(GForm7.Class203.callSite_0, GForm7.dictionary_0[GForm7.string_0][Class185.smethod_0(537692592)], Class185.smethod_0(537691677));
	}

	// Token: 0x06000745 RID: 1861 RVA: 0x000432D8 File Offset: 0x000414D8
	private void bunifuThinButton2_0_Click(object sender, EventArgs e)
	{
		if (GForm7.Class200.callSite_1 == null)
		{
			GForm7.Class200.callSite_1 = CallSite<Action<CallSite, object, bool>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class185.smethod_0(537692370), null, typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
			}));
		}
		Action<CallSite, object, bool> target = GForm7.Class200.callSite_1.Target;
		CallSite callSite_ = GForm7.Class200.callSite_1;
		if (GForm7.Class200.callSite_0 == null)
		{
			GForm7.Class200.callSite_0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, Class185.smethod_0(537692347), typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
			}));
		}
		target(callSite_, GForm7.Class200.callSite_0.Target(GForm7.Class200.callSite_0, GForm7.dictionary_0[GForm7.string_0][Class185.smethod_0(537692592)]), true);
		if (GForm7.Class200.callSite_2 == null)
		{
			GForm7.Class200.callSite_2 = CallSite<Action<CallSite, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class185.smethod_0(537692365), null, typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
			}));
		}
		GForm7.Class200.callSite_2.Target(GForm7.Class200.callSite_2, GForm7.dictionary_0[GForm7.string_0][Class185.smethod_0(537692592)]);
		if (GForm7.Class200.callSite_3 == null)
		{
			GForm7.Class200.callSite_3 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, Class185.smethod_0(537692347), typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
			}));
		}
		object arg = GForm7.Class200.callSite_3.Target(GForm7.Class200.callSite_3, GForm7.dictionary_0[GForm7.string_0][Class185.smethod_0(537692592)]);
		BrowserOptions options = new BrowserOptions
		{
			EnableXSSAuditor = new bool?(false),
			EnableWebSecurity = new bool?(false)
		};
		WebView webView = new WebView();
		webView.SetOptions(options);
		WebView webView2 = webView;
		if (GForm7.Class200.callSite_4 == null)
		{
			GForm7.Class200.callSite_4 = CallSite<Func<CallSite, object, Engine>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Engine), typeof(GForm7)));
		}
		webView2.Engine = GForm7.Class200.callSite_4.Target(GForm7.Class200.callSite_4, arg);
		webView.Engine.AllowRestart = true;
		if (GForm7.Class200.callSite_6 == null)
		{
			GForm7.Class200.callSite_6 = CallSite<Action<CallSite, WebView, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class185.smethod_0(537692411), null, typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
			}));
		}
		Action<CallSite, WebView, object> target2 = GForm7.Class200.callSite_6.Target;
		CallSite callSite_2 = GForm7.Class200.callSite_6;
		WebView arg2 = webView;
		if (GForm7.Class200.callSite_5 == null)
		{
			GForm7.Class200.callSite_5 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, Class185.smethod_0(537692392), typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
			}));
		}
		target2(callSite_2, arg2, GForm7.Class200.callSite_5.Target(GForm7.Class200.callSite_5, GForm7.dictionary_0[GForm7.string_0][Class185.smethod_0(537692539)]));
		webView.RegisterJSExtensionFunction(Class185.smethod_0(537692509), new JSExtInvokeHandler(this.method_3));
		webView.RegisterJSExtensionFunction(Class185.smethod_0(537692490), new JSExtInvokeHandler(GForm7.smethod_3));
		webView.CertificateError += this.method_5;
		webView.BeforeContextMenu += this.method_4;
		GForm7.dictionary_0[GForm7.string_0][Class185.smethod_0(537692592)] = webView;
		this.pictureBox_4_Click(null, null);
	}

	// Token: 0x06000746 RID: 1862 RVA: 0x000069D2 File Offset: 0x00004BD2
	private void method_6()
	{
		this.bunifuCustomLabel_0.Visible = false;
		this.bunifuCustomLabel_3.Visible = false;
		this.bunifuCustomLabel_2.Visible = false;
		this.bunifuCustomLabel_1.Visible = false;
	}

	// Token: 0x06000747 RID: 1863 RVA: 0x00043660 File Offset: 0x00041860
	private void bunifuThinButton2_2_Click(object sender, EventArgs e)
	{
		this.method_6();
		this.bunifuCustomLabel_0.Visible = true;
		this.panel_1.Controls.Clear();
		if (GForm7.Class206.callSite_0 == null)
		{
			GForm7.Class206.callSite_0 = CallSite<Action<CallSite, Control.ControlCollection, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class185.smethod_0(537696810), null, typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
			}));
		}
		GForm7.Class206.callSite_0.Target(GForm7.Class206.callSite_0, this.panel_1.Controls, GForm7.dictionary_0[this.bunifuThinButton2_2.ButtonText][Class185.smethod_0(537692539)]);
		GForm7.string_0 = this.bunifuThinButton2_2.ButtonText;
		if (GForm7.Class206.callSite_2 == null)
		{
			GForm7.Class206.callSite_2 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
			}));
		}
		Func<CallSite, object, bool> target = GForm7.Class206.callSite_2.Target;
		CallSite callSite_ = GForm7.Class206.callSite_2;
		if (GForm7.Class206.callSite_1 == null)
		{
			GForm7.Class206.callSite_1 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
			}));
		}
		if (target(callSite_, GForm7.Class206.callSite_1.Target(GForm7.Class206.callSite_1, GForm7.dictionary_0[GForm7.string_0][Class185.smethod_0(537692535)], null)))
		{
			Control control = this.bunifuMaterialTextbox_0;
			if (GForm7.Class206.callSite_3 == null)
			{
				GForm7.Class206.callSite_3 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(GForm7)));
			}
			control.Text = GForm7.Class206.callSite_3.Target(GForm7.Class206.callSite_3, GForm7.dictionary_0[GForm7.string_0][Class185.smethod_0(537692535)]);
			return;
		}
		this.bunifuMaterialTextbox_0.Text = Class185.smethod_0(537692515);
	}

	// Token: 0x06000748 RID: 1864 RVA: 0x00043864 File Offset: 0x00041A64
	private void bunifuThinButton2_11_Click(object sender, EventArgs e)
	{
		this.method_6();
		this.bunifuCustomLabel_3.Visible = true;
		this.panel_1.Controls.Clear();
		if (GForm7.Class209.callSite_0 == null)
		{
			GForm7.Class209.callSite_0 = CallSite<Action<CallSite, Control.ControlCollection, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class185.smethod_0(537696810), null, typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
			}));
		}
		GForm7.Class209.callSite_0.Target(GForm7.Class209.callSite_0, this.panel_1.Controls, GForm7.dictionary_0[this.bunifuThinButton2_11.ButtonText][Class185.smethod_0(537692539)]);
		GForm7.string_0 = this.bunifuThinButton2_11.ButtonText;
		if (GForm7.Class209.callSite_2 == null)
		{
			GForm7.Class209.callSite_2 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
			}));
		}
		Func<CallSite, object, bool> target = GForm7.Class209.callSite_2.Target;
		CallSite callSite_ = GForm7.Class209.callSite_2;
		if (GForm7.Class209.callSite_1 == null)
		{
			GForm7.Class209.callSite_1 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
			}));
		}
		if (target(callSite_, GForm7.Class209.callSite_1.Target(GForm7.Class209.callSite_1, GForm7.dictionary_0[GForm7.string_0][Class185.smethod_0(537692535)], null)))
		{
			Control control = this.bunifuMaterialTextbox_0;
			if (GForm7.Class209.callSite_3 == null)
			{
				GForm7.Class209.callSite_3 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(GForm7)));
			}
			control.Text = GForm7.Class209.callSite_3.Target(GForm7.Class209.callSite_3, GForm7.dictionary_0[GForm7.string_0][Class185.smethod_0(537692535)]);
			return;
		}
		this.bunifuMaterialTextbox_0.Text = Class185.smethod_0(537692515);
	}

	// Token: 0x06000749 RID: 1865 RVA: 0x00043A68 File Offset: 0x00041C68
	private void bunifuThinButton2_9_Click(object sender, EventArgs e)
	{
		this.method_6();
		this.bunifuCustomLabel_2.Visible = true;
		this.panel_1.Controls.Clear();
		if (GForm7.Class192.callSite_0 == null)
		{
			GForm7.Class192.callSite_0 = CallSite<Action<CallSite, Control.ControlCollection, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class185.smethod_0(537696810), null, typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
			}));
		}
		GForm7.Class192.callSite_0.Target(GForm7.Class192.callSite_0, this.panel_1.Controls, GForm7.dictionary_0[this.bunifuThinButton2_9.ButtonText][Class185.smethod_0(537692539)]);
		GForm7.string_0 = this.bunifuThinButton2_9.ButtonText;
		if (GForm7.Class192.callSite_2 == null)
		{
			GForm7.Class192.callSite_2 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
			}));
		}
		Func<CallSite, object, bool> target = GForm7.Class192.callSite_2.Target;
		CallSite callSite_ = GForm7.Class192.callSite_2;
		if (GForm7.Class192.callSite_1 == null)
		{
			GForm7.Class192.callSite_1 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
			}));
		}
		if (target(callSite_, GForm7.Class192.callSite_1.Target(GForm7.Class192.callSite_1, GForm7.dictionary_0[GForm7.string_0][Class185.smethod_0(537692535)], null)))
		{
			Control control = this.bunifuMaterialTextbox_0;
			if (GForm7.Class192.callSite_3 == null)
			{
				GForm7.Class192.callSite_3 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(GForm7)));
			}
			control.Text = GForm7.Class192.callSite_3.Target(GForm7.Class192.callSite_3, GForm7.dictionary_0[GForm7.string_0][Class185.smethod_0(537692535)]);
			return;
		}
		this.bunifuMaterialTextbox_0.Text = Class185.smethod_0(537692515);
	}

	// Token: 0x0600074A RID: 1866 RVA: 0x00043C6C File Offset: 0x00041E6C
	private void bunifuThinButton2_7_Click(object sender, EventArgs e)
	{
		this.method_6();
		this.bunifuCustomLabel_1.Visible = true;
		this.panel_1.Controls.Clear();
		if (GForm7.Class195.callSite_0 == null)
		{
			GForm7.Class195.callSite_0 = CallSite<Action<CallSite, Control.ControlCollection, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class185.smethod_0(537696810), null, typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
			}));
		}
		GForm7.Class195.callSite_0.Target(GForm7.Class195.callSite_0, this.panel_1.Controls, GForm7.dictionary_0[this.bunifuThinButton2_7.ButtonText][Class185.smethod_0(537692539)]);
		GForm7.string_0 = this.bunifuThinButton2_7.ButtonText;
		if (GForm7.Class195.callSite_2 == null)
		{
			GForm7.Class195.callSite_2 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
			}));
		}
		Func<CallSite, object, bool> target = GForm7.Class195.callSite_2.Target;
		CallSite callSite_ = GForm7.Class195.callSite_2;
		if (GForm7.Class195.callSite_1 == null)
		{
			GForm7.Class195.callSite_1 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
			}));
		}
		if (target(callSite_, GForm7.Class195.callSite_1.Target(GForm7.Class195.callSite_1, GForm7.dictionary_0[GForm7.string_0][Class185.smethod_0(537692535)], null)))
		{
			Control control = this.bunifuMaterialTextbox_0;
			if (GForm7.Class195.callSite_3 == null)
			{
				GForm7.Class195.callSite_3 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(GForm7)));
			}
			control.Text = GForm7.Class195.callSite_3.Target(GForm7.Class195.callSite_3, GForm7.dictionary_0[GForm7.string_0][Class185.smethod_0(537692535)]);
			return;
		}
		this.bunifuMaterialTextbox_0.Text = Class185.smethod_0(537692515);
	}

	// Token: 0x0600074B RID: 1867 RVA: 0x00043E70 File Offset: 0x00042070
	private void bunifuThinButton2_3_Click(object sender, EventArgs e)
	{
		this.method_6();
		int num = (GForm7.dictionary_0.Count<KeyValuePair<string, Dictionary<string, object>>>() + 3) / 4;
		this.int_0++;
		if (this.int_0 >= num)
		{
			this.int_0 = 0;
		}
		this.method_9(this.int_0);
	}

	// Token: 0x0600074C RID: 1868 RVA: 0x00043EBC File Offset: 0x000420BC
	private void method_7()
	{
		List<string> list = GForm7.dictionary_0.Select(new Func<KeyValuePair<string, Dictionary<string, object>>, string>(GForm7.Class190.class190_0.method_9)).OrderBy(new Func<string, short>(GForm7.Class190.class190_0.method_10)).ToList<string>();
		KeyValuePair<string, Dictionary<string, object>> keyValuePair = GForm7.dictionary_0.FirstOrDefault(new Func<KeyValuePair<string, Dictionary<string, object>>, bool>(GForm7.Class190.class190_0.method_11));
		if (keyValuePair.Value == null)
		{
			return;
		}
		int num = list.IndexOf(keyValuePair.Key);
		int num2 = (GForm7.dictionary_0.Count<KeyValuePair<string, Dictionary<string, object>>>() + 3) / 4;
		int int_ = num / 4;
		this.method_9(int_);
		switch (num % 4)
		{
		case 0:
			this.bunifuThinButton2_2_Click(null, null);
			return;
		case 1:
			this.bunifuThinButton2_11_Click(null, null);
			return;
		case 2:
			this.bunifuThinButton2_9_Click(null, null);
			return;
		case 3:
			this.bunifuThinButton2_7_Click(null, null);
			return;
		default:
			return;
		}
	}

	// Token: 0x0600074D RID: 1869 RVA: 0x00043FB4 File Offset: 0x000421B4
	private void method_8()
	{
		string buttonText = this.bunifuThinButton2_2.ButtonText;
		this.method_9(this.int_0);
		if (GForm7.string_0 == buttonText)
		{
			GForm7.string_0 = this.bunifuThinButton2_2.ButtonText;
			this.method_9(this.int_0);
			this.bunifuThinButton2_2_Click(null, null);
		}
	}

	// Token: 0x0600074E RID: 1870 RVA: 0x0004400C File Offset: 0x0004220C
	private void method_9(int int_1)
	{
		this.int_0 = int_1;
		List<string> list = GForm7.dictionary_0.Select(new Func<KeyValuePair<string, Dictionary<string, object>>, string>(GForm7.Class190.class190_0.method_12)).ToList<string>().OrderBy(new Func<string, short>(GForm7.Class190.class190_0.method_13)).ToList<string>();
		list = list.Skip(int_1 * 4).ToList<string>();
		int num = list.Count<string>();
		if (num <= 0)
		{
			this.int_0--;
			this.method_9(this.int_0);
			return;
		}
		this.bunifuThinButton2_2.ButtonText = list[0];
		this.bunifuThinButton2_2.Visible = true;
		this.bunifuCustomLabel_0.Visible = (list[0] == GForm7.string_0);
		if (num > 1)
		{
			this.bunifuThinButton2_11.ButtonText = list[1];
			this.bunifuThinButton2_11.Visible = true;
			this.bunifuCustomLabel_3.Visible = (list[1] == GForm7.string_0);
			this.bunifuThinButton2_10.Visible = true;
			this.bunifuThinButton2_10.BringToFront();
		}
		else
		{
			this.bunifuThinButton2_11.ButtonText = string.Empty;
			this.bunifuThinButton2_11.Visible = false;
			this.bunifuThinButton2_10.Visible = false;
			this.bunifuCustomLabel_3.Visible = false;
		}
		if (num > 2)
		{
			this.bunifuThinButton2_9.ButtonText = list[2];
			this.bunifuThinButton2_9.Visible = true;
			this.bunifuCustomLabel_2.Visible = (list[2] == GForm7.string_0);
			this.bunifuThinButton2_8.Visible = true;
			this.bunifuThinButton2_8.BringToFront();
		}
		else
		{
			this.bunifuThinButton2_9.ButtonText = string.Empty;
			this.bunifuThinButton2_9.Visible = false;
			this.bunifuThinButton2_8.Visible = false;
			this.bunifuCustomLabel_2.Visible = false;
		}
		if (num > 3)
		{
			this.bunifuThinButton2_7.ButtonText = list[3];
			this.bunifuThinButton2_7.Visible = true;
			this.bunifuCustomLabel_1.Visible = (list[3] == GForm7.string_0);
			this.bunifuThinButton2_6.Visible = true;
			this.bunifuThinButton2_6.BringToFront();
			return;
		}
		this.bunifuThinButton2_7.ButtonText = string.Empty;
		this.bunifuThinButton2_7.Visible = false;
		this.bunifuThinButton2_6.Visible = false;
		this.bunifuCustomLabel_1.Visible = false;
	}

	// Token: 0x0600074F RID: 1871 RVA: 0x0004428C File Offset: 0x0004248C
	private void bunifuThinButton2_4_Click(object sender, EventArgs e)
	{
		this.method_0(null, null);
		int int_ = (GForm7.dictionary_0.Count<KeyValuePair<string, Dictionary<string, object>>>() + 3) / 4 - 1;
		this.method_9(int_);
	}

	// Token: 0x06000750 RID: 1872 RVA: 0x000442BC File Offset: 0x000424BC
	private void pictureBox_4_Click(object sender, EventArgs e)
	{
		ConcurrentDictionary<string, string> concurrentDictionary = GForm7.list_0.Where(new Func<ConcurrentDictionary<string, string>, bool>(GForm7.Class190.class190_0.method_14)).FirstOrDefault<ConcurrentDictionary<string, string>>();
		if (concurrentDictionary != null)
		{
			concurrentDictionary[Class185.smethod_0(537692776)] = Class185.smethod_0(537692774);
		}
		GForm7.smethod_7(GForm7.string_0);
		GForm7.smethod_2(null, null);
	}

	// Token: 0x06000751 RID: 1873 RVA: 0x00044328 File Offset: 0x00042528
	private void method_10(object sender, EventArgs e)
	{
		if (this.bunifuMaterialTextbox_0.Text.Contains(Class185.smethod_0(537692328)))
		{
			this.bunifuMaterialTextbox_0.Text = this.bunifuMaterialTextbox_0.Text.Replace(Class185.smethod_0(537692515), string.Empty);
		}
	}

	// Token: 0x06000752 RID: 1874 RVA: 0x0004437C File Offset: 0x0004257C
	private void method_11(ConcurrentDictionary<string, string> concurrentDictionary_1)
	{
		concurrentDictionary_1[Class185.smethod_0(537692776)] = Class185.smethod_0(537692774);
		GForm7.smethod_2(null, null);
		GForm1.gform1_0.Invoke(new MethodInvoker(GForm7.Class190.class190_0.method_15));
	}

	// Token: 0x06000753 RID: 1875 RVA: 0x000443D4 File Offset: 0x000425D4
	private void bunifuThinButton2_5_Click(object sender, EventArgs e)
	{
		GForm7.Class196 @class = new GForm7.Class196();
		if (GForm7.dictionary_0.Count<KeyValuePair<string, Dictionary<string, object>>>() == 1)
		{
			return;
		}
		if (GForm7.Class204.callSite_1 == null)
		{
			GForm7.Class204.callSite_1 = CallSite<Action<CallSite, object, bool>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class185.smethod_0(537692370), null, typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
			}));
		}
		Action<CallSite, object, bool> target = GForm7.Class204.callSite_1.Target;
		CallSite callSite_ = GForm7.Class204.callSite_1;
		if (GForm7.Class204.callSite_0 == null)
		{
			GForm7.Class204.callSite_0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, Class185.smethod_0(537692347), typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
			}));
		}
		target(callSite_, GForm7.Class204.callSite_0.Target(GForm7.Class204.callSite_0, GForm7.dictionary_0[this.bunifuThinButton2_2.ButtonText][Class185.smethod_0(537692592)]), false);
		if (GForm7.Class204.callSite_2 == null)
		{
			GForm7.Class204.callSite_2 = CallSite<Action<CallSite, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class185.smethod_0(537692365), null, typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
			}));
		}
		GForm7.Class204.callSite_2.Target(GForm7.Class204.callSite_2, GForm7.dictionary_0[this.bunifuThinButton2_2.ButtonText][Class185.smethod_0(537692592)]);
		GForm7.dictionary_0.Remove(this.bunifuThinButton2_2.ButtonText);
		this.method_2();
		@class.string_0 = this.bunifuThinButton2_2.ButtonText;
		this.method_8();
		ConcurrentDictionary<string, string> concurrentDictionary = GForm7.list_0.FirstOrDefault(new Func<ConcurrentDictionary<string, string>, bool>(@class.method_0));
		if (concurrentDictionary != null)
		{
			this.method_11(concurrentDictionary);
		}
	}

	// Token: 0x06000754 RID: 1876 RVA: 0x00044594 File Offset: 0x00042794
	private void bunifuThinButton2_10_Click(object sender, EventArgs e)
	{
		GForm7.Class202 @class = new GForm7.Class202();
		if (GForm7.dictionary_0.Count<KeyValuePair<string, Dictionary<string, object>>>() == 1)
		{
			return;
		}
		if (GForm7.Class201.callSite_1 == null)
		{
			GForm7.Class201.callSite_1 = CallSite<Action<CallSite, object, bool>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class185.smethod_0(537692370), null, typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
			}));
		}
		Action<CallSite, object, bool> target = GForm7.Class201.callSite_1.Target;
		CallSite callSite_ = GForm7.Class201.callSite_1;
		if (GForm7.Class201.callSite_0 == null)
		{
			GForm7.Class201.callSite_0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, Class185.smethod_0(537692347), typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
			}));
		}
		target(callSite_, GForm7.Class201.callSite_0.Target(GForm7.Class201.callSite_0, GForm7.dictionary_0[this.bunifuThinButton2_11.ButtonText][Class185.smethod_0(537692592)]), false);
		if (GForm7.Class201.callSite_2 == null)
		{
			GForm7.Class201.callSite_2 = CallSite<Action<CallSite, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class185.smethod_0(537692365), null, typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
			}));
		}
		GForm7.Class201.callSite_2.Target(GForm7.Class201.callSite_2, GForm7.dictionary_0[this.bunifuThinButton2_11.ButtonText][Class185.smethod_0(537692592)]);
		GForm7.dictionary_0.Remove(this.bunifuThinButton2_11.ButtonText);
		this.method_2();
		@class.string_0 = this.bunifuThinButton2_11.ButtonText;
		this.method_8();
		ConcurrentDictionary<string, string> concurrentDictionary = GForm7.list_0.FirstOrDefault(new Func<ConcurrentDictionary<string, string>, bool>(@class.method_0));
		if (concurrentDictionary != null)
		{
			this.method_11(concurrentDictionary);
		}
	}

	// Token: 0x06000755 RID: 1877 RVA: 0x00044754 File Offset: 0x00042954
	private void bunifuThinButton2_8_Click(object sender, EventArgs e)
	{
		GForm7.Class199 @class = new GForm7.Class199();
		if (GForm7.dictionary_0.Count<KeyValuePair<string, Dictionary<string, object>>>() == 1)
		{
			return;
		}
		if (GForm7.Class207.callSite_1 == null)
		{
			GForm7.Class207.callSite_1 = CallSite<Action<CallSite, object, bool>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class185.smethod_0(537692370), null, typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
			}));
		}
		Action<CallSite, object, bool> target = GForm7.Class207.callSite_1.Target;
		CallSite callSite_ = GForm7.Class207.callSite_1;
		if (GForm7.Class207.callSite_0 == null)
		{
			GForm7.Class207.callSite_0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, Class185.smethod_0(537692347), typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
			}));
		}
		target(callSite_, GForm7.Class207.callSite_0.Target(GForm7.Class207.callSite_0, GForm7.dictionary_0[this.bunifuThinButton2_9.ButtonText][Class185.smethod_0(537692592)]), false);
		if (GForm7.Class207.callSite_2 == null)
		{
			GForm7.Class207.callSite_2 = CallSite<Action<CallSite, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class185.smethod_0(537692365), null, typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
			}));
		}
		GForm7.Class207.callSite_2.Target(GForm7.Class207.callSite_2, GForm7.dictionary_0[this.bunifuThinButton2_9.ButtonText][Class185.smethod_0(537692592)]);
		GForm7.dictionary_0.Remove(this.bunifuThinButton2_9.ButtonText);
		this.method_2();
		@class.string_0 = this.bunifuThinButton2_9.ButtonText;
		this.method_8();
		ConcurrentDictionary<string, string> concurrentDictionary = GForm7.list_0.FirstOrDefault(new Func<ConcurrentDictionary<string, string>, bool>(@class.method_0));
		if (concurrentDictionary != null)
		{
			this.method_11(concurrentDictionary);
		}
	}

	// Token: 0x06000756 RID: 1878 RVA: 0x00044914 File Offset: 0x00042B14
	private void bunifuThinButton2_6_Click(object sender, EventArgs e)
	{
		GForm7.Class205 @class = new GForm7.Class205();
		if (GForm7.dictionary_0.Count<KeyValuePair<string, Dictionary<string, object>>>() == 1)
		{
			return;
		}
		if (GForm7.Class210.callSite_1 == null)
		{
			GForm7.Class210.callSite_1 = CallSite<Action<CallSite, object, bool>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class185.smethod_0(537692370), null, typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
			}));
		}
		Action<CallSite, object, bool> target = GForm7.Class210.callSite_1.Target;
		CallSite callSite_ = GForm7.Class210.callSite_1;
		if (GForm7.Class210.callSite_0 == null)
		{
			GForm7.Class210.callSite_0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, Class185.smethod_0(537692347), typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
			}));
		}
		target(callSite_, GForm7.Class210.callSite_0.Target(GForm7.Class210.callSite_0, GForm7.dictionary_0[this.bunifuThinButton2_7.ButtonText][Class185.smethod_0(537692592)]), false);
		if (GForm7.Class210.callSite_2 == null)
		{
			GForm7.Class210.callSite_2 = CallSite<Action<CallSite, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class185.smethod_0(537692365), null, typeof(GForm7), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
			}));
		}
		GForm7.Class210.callSite_2.Target(GForm7.Class210.callSite_2, GForm7.dictionary_0[this.bunifuThinButton2_7.ButtonText][Class185.smethod_0(537692592)]);
		GForm7.dictionary_0.Remove(this.bunifuThinButton2_7.ButtonText);
		this.method_2();
		@class.string_0 = this.bunifuThinButton2_7.ButtonText;
		this.method_8();
		ConcurrentDictionary<string, string> concurrentDictionary = GForm7.list_0.FirstOrDefault(new Func<ConcurrentDictionary<string, string>, bool>(@class.method_0));
		if (concurrentDictionary != null)
		{
			this.method_11(concurrentDictionary);
		}
	}

	// Token: 0x06000757 RID: 1879
	[DllImport("user32.dll")]
	public static extern int SendMessage(IntPtr intptr_0, int int_1, int int_2, int int_3);

	// Token: 0x06000758 RID: 1880
	[DllImport("user32.dll")]
	public static extern bool ReleaseCapture();

	// Token: 0x06000759 RID: 1881 RVA: 0x00006A04 File Offset: 0x00004C04
	private void panel_3_MouseMove(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			GForm7.ReleaseCapture();
			GForm7.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	// Token: 0x0600075A RID: 1882 RVA: 0x00006A2C File Offset: 0x00004C2C
	private void method_12(object sender, MouseEventArgs e)
	{
		Console.WriteLine(Class185.smethod_0(537691449));
	}

	// Token: 0x0600075C RID: 1884 RVA: 0x00044AD4 File Offset: 0x00042CD4
	private void method_13()
	{
		this.icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm7));
		this.bunifuElipse_0 = new BunifuElipse(this.icontainer_0);
		this.panel_3 = new Panel();
		this.bunifuThinButton2_4 = new BunifuThinButton2();
		this.pictureBox_0 = new PictureBox();
		this.pictureBox_1 = new PictureBox();
		this.label_0 = new Label();
		this.panel_0 = new Panel();
		this.bunifuThinButton2_12 = new BunifuThinButton2();
		this.pictureBox_4 = new PictureBox();
		this.bunifuMaterialTextbox_0 = new BunifuMaterialTextbox();
		this.pictureBox_2 = new PictureBox();
		this.bunifuThinButton2_0 = new BunifuThinButton2();
		this.pictureBox_3 = new PictureBox();
		this.bunifuThinButton2_1 = new BunifuThinButton2();
		this.panel_2 = new Panel();
		this.bunifuThinButton2_6 = new BunifuThinButton2();
		this.bunifuThinButton2_7 = new BunifuThinButton2();
		this.bunifuCustomLabel_1 = new BunifuCustomLabel();
		this.bunifuThinButton2_8 = new BunifuThinButton2();
		this.bunifuCustomLabel_2 = new BunifuCustomLabel();
		this.bunifuThinButton2_9 = new BunifuThinButton2();
		this.bunifuThinButton2_10 = new BunifuThinButton2();
		this.bunifuCustomLabel_3 = new BunifuCustomLabel();
		this.bunifuThinButton2_11 = new BunifuThinButton2();
		this.bunifuThinButton2_5 = new BunifuThinButton2();
		this.bunifuThinButton2_3 = new BunifuThinButton2();
		this.bunifuCustomLabel_0 = new BunifuCustomLabel();
		this.bunifuThinButton2_2 = new BunifuThinButton2();
		this.panel_1 = new Panel();
		this.panel_3.SuspendLayout();
		((ISupportInitialize)this.pictureBox_0).BeginInit();
		((ISupportInitialize)this.pictureBox_1).BeginInit();
		this.panel_0.SuspendLayout();
		((ISupportInitialize)this.pictureBox_4).BeginInit();
		((ISupportInitialize)this.pictureBox_2).BeginInit();
		((ISupportInitialize)this.pictureBox_3).BeginInit();
		this.panel_2.SuspendLayout();
		base.SuspendLayout();
		this.bunifuElipse_0.ElipseRadius = 10;
		this.bunifuElipse_0.TargetControl = this;
		this.panel_3.BackColor = Color.FromArgb(25, 23, 26);
		this.panel_3.Controls.Add(this.bunifuThinButton2_4);
		this.panel_3.Controls.Add(this.pictureBox_0);
		this.panel_3.Controls.Add(this.pictureBox_1);
		this.panel_3.Controls.Add(this.label_0);
		this.panel_3.Dock = DockStyle.Top;
		this.panel_3.ForeColor = Color.FromArgb(25, 23, 26);
		this.panel_3.Location = new Point(0, 0);
		this.panel_3.Name = Class185.smethod_0(537691434);
		this.panel_3.Size = new Size(439, 53);
		this.panel_3.TabIndex = 1;
		this.panel_3.MouseMove += this.panel_3_MouseMove;
		this.bunifuThinButton2_4.ActiveBorderThickness = 1;
		this.bunifuThinButton2_4.ActiveCornerRadius = 20;
		this.bunifuThinButton2_4.ActiveFillColor = Color.Empty;
		this.bunifuThinButton2_4.ActiveForecolor = Color.Empty;
		this.bunifuThinButton2_4.ActiveLineColor = Color.Empty;
		this.bunifuThinButton2_4.BackColor = Color.FromArgb(25, 23, 26);
		this.bunifuThinButton2_4.BackgroundImage = (Image)componentResourceManager.GetObject(Class185.smethod_0(537691482));
		this.bunifuThinButton2_4.ButtonText = Class185.smethod_0(537691504);
		this.bunifuThinButton2_4.Cursor = Cursors.Hand;
		this.bunifuThinButton2_4.Font = new Font(Class185.smethod_0(537691496), 18f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.bunifuThinButton2_4.ForeColor = Color.FromArgb(44, 186, 118);
		this.bunifuThinButton2_4.IdleBorderThickness = 1;
		this.bunifuThinButton2_4.IdleCornerRadius = 20;
		this.bunifuThinButton2_4.IdleFillColor = Color.Empty;
		this.bunifuThinButton2_4.IdleForecolor = Color.Empty;
		this.bunifuThinButton2_4.IdleLineColor = Color.Empty;
		this.bunifuThinButton2_4.Location = new Point(21, 9);
		this.bunifuThinButton2_4.Margin = new Padding(6, 5, 6, 5);
		this.bunifuThinButton2_4.Name = Class185.smethod_0(537691293);
		this.bunifuThinButton2_4.Size = new Size(36, 31);
		this.bunifuThinButton2_4.TabIndex = 9;
		this.bunifuThinButton2_4.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuThinButton2_4.Click += this.bunifuThinButton2_4_Click;
		this.pictureBox_0.Cursor = Cursors.Hand;
		this.pictureBox_0.Image = (Image)componentResourceManager.GetObject(Class185.smethod_0(537691267));
		this.pictureBox_0.Location = new Point(400, 9);
		this.pictureBox_0.Name = Class185.smethod_0(537691305);
		this.pictureBox_0.Size = new Size(27, 28);
		this.pictureBox_0.SizeMode = PictureBoxSizeMode.StretchImage;
		this.pictureBox_0.TabIndex = 7;
		this.pictureBox_0.TabStop = false;
		this.pictureBox_0.Click += this.pictureBox_0_Click;
		this.pictureBox_1.Cursor = Cursors.Hand;
		this.pictureBox_1.Image = (Image)componentResourceManager.GetObject(Class185.smethod_0(537691353));
		this.pictureBox_1.Location = new Point(367, 18);
		this.pictureBox_1.Name = Class185.smethod_0(537691330);
		this.pictureBox_1.Size = new Size(27, 22);
		this.pictureBox_1.SizeMode = PictureBoxSizeMode.StretchImage;
		this.pictureBox_1.TabIndex = 8;
		this.pictureBox_1.TabStop = false;
		this.pictureBox_1.Click += this.pictureBox_1_Click;
		this.label_0.AutoSize = true;
		this.label_0.BackColor = Color.Transparent;
		this.label_0.Font = new Font(Class185.smethod_0(537691381), 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.label_0.ForeColor = Color.FromArgb(44, 186, 118);
		this.label_0.Location = new Point(118, 14);
		this.label_0.Name = Class185.smethod_0(537691363);
		this.label_0.Size = new Size(190, 23);
		this.label_0.TabIndex = 6;
		this.label_0.Text = Class185.smethod_0(537691152);
		this.panel_0.BackColor = Color.FromArgb(25, 23, 26);
		this.panel_0.Controls.Add(this.bunifuThinButton2_12);
		this.panel_0.Controls.Add(this.pictureBox_4);
		this.panel_0.Controls.Add(this.bunifuMaterialTextbox_0);
		this.panel_0.Controls.Add(this.pictureBox_2);
		this.panel_0.Controls.Add(this.bunifuThinButton2_0);
		this.panel_0.Controls.Add(this.pictureBox_3);
		this.panel_0.Controls.Add(this.bunifuThinButton2_1);
		this.panel_0.Dock = DockStyle.Bottom;
		this.panel_0.Location = new Point(0, 626);
		this.panel_0.Name = Class185.smethod_0(537691140);
		this.panel_0.Size = new Size(439, 115);
		this.panel_0.TabIndex = 1;
		this.bunifuThinButton2_12.ActiveBorderThickness = 1;
		this.bunifuThinButton2_12.ActiveCornerRadius = 20;
		this.bunifuThinButton2_12.ActiveFillColor = Color.Empty;
		this.bunifuThinButton2_12.ActiveForecolor = Color.Empty;
		this.bunifuThinButton2_12.ActiveLineColor = Color.Empty;
		this.bunifuThinButton2_12.BackColor = Color.FromArgb(25, 23, 26);
		this.bunifuThinButton2_12.BackgroundImage = (Image)componentResourceManager.GetObject(Class185.smethod_0(537691176));
		this.bunifuThinButton2_12.ButtonText = Class185.smethod_0(537691213);
		this.bunifuThinButton2_12.Cursor = Cursors.Hand;
		this.bunifuThinButton2_12.Font = new Font(Class185.smethod_0(537691496), 18f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.bunifuThinButton2_12.ForeColor = Color.FromArgb(44, 186, 118);
		this.bunifuThinButton2_12.IdleBorderThickness = 1;
		this.bunifuThinButton2_12.IdleCornerRadius = 20;
		this.bunifuThinButton2_12.IdleFillColor = Color.Empty;
		this.bunifuThinButton2_12.IdleForecolor = Color.Empty;
		this.bunifuThinButton2_12.IdleLineColor = Color.Empty;
		this.bunifuThinButton2_12.Location = new Point(398, 14);
		this.bunifuThinButton2_12.Margin = new Padding(6, 5, 6, 5);
		this.bunifuThinButton2_12.Name = Class185.smethod_0(537691206);
		this.bunifuThinButton2_12.Size = new Size(30, 31);
		this.bunifuThinButton2_12.TabIndex = 10;
		this.bunifuThinButton2_12.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuThinButton2_12.Click += this.bunifuThinButton2_12_Click;
		this.pictureBox_4.Cursor = Cursors.Hand;
		this.pictureBox_4.Image = (Image)componentResourceManager.GetObject(Class185.smethod_0(537691243));
		this.pictureBox_4.Location = new Point(398, 67);
		this.pictureBox_4.Name = Class185.smethod_0(537705365);
		this.pictureBox_4.Size = new Size(27, 28);
		this.pictureBox_4.SizeMode = PictureBoxSizeMode.StretchImage;
		this.pictureBox_4.TabIndex = 15;
		this.pictureBox_4.TabStop = false;
		this.pictureBox_4.Click += this.pictureBox_4_Click;
		this.bunifuMaterialTextbox_0.AutoCompleteMode = AutoCompleteMode.None;
		this.bunifuMaterialTextbox_0.AutoCompleteSource = AutoCompleteSource.None;
		this.bunifuMaterialTextbox_0.characterCasing = CharacterCasing.Normal;
		this.bunifuMaterialTextbox_0.Cursor = Cursors.IBeam;
		this.bunifuMaterialTextbox_0.Font = new Font(Class185.smethod_0(537691496), 9.75f);
		this.bunifuMaterialTextbox_0.ForeColor = Color.DimGray;
		this.bunifuMaterialTextbox_0.HintForeColor = Color.Empty;
		this.bunifuMaterialTextbox_0.HintText = string.Empty;
		this.bunifuMaterialTextbox_0.isPassword = false;
		this.bunifuMaterialTextbox_0.LineFocusedColor = Color.DimGray;
		this.bunifuMaterialTextbox_0.LineIdleColor = Color.DimGray;
		this.bunifuMaterialTextbox_0.LineMouseHoverColor = Color.DimGray;
		this.bunifuMaterialTextbox_0.LineThickness = 2;
		this.bunifuMaterialTextbox_0.Location = new Point(17, 8);
		this.bunifuMaterialTextbox_0.Margin = new Padding(4);
		this.bunifuMaterialTextbox_0.MaxLength = 32767;
		this.bunifuMaterialTextbox_0.Name = Class185.smethod_0(537705401);
		this.bunifuMaterialTextbox_0.Size = new Size(372, 37);
		this.bunifuMaterialTextbox_0.TabIndex = 12;
		this.bunifuMaterialTextbox_0.Text = Class185.smethod_0(537692515);
		this.bunifuMaterialTextbox_0.TextAlign = HorizontalAlignment.Left;
		this.pictureBox_2.Cursor = Cursors.Hand;
		this.pictureBox_2.Image = (Image)componentResourceManager.GetObject(Class185.smethod_0(537705386));
		this.pictureBox_2.Location = new Point(29, 66);
		this.pictureBox_2.Name = Class185.smethod_0(537705426);
		this.pictureBox_2.Size = new Size(27, 28);
		this.pictureBox_2.SizeMode = PictureBoxSizeMode.StretchImage;
		this.pictureBox_2.TabIndex = 11;
		this.pictureBox_2.TabStop = false;
		this.bunifuThinButton2_0.ActiveBorderThickness = 1;
		this.bunifuThinButton2_0.ActiveCornerRadius = 30;
		this.bunifuThinButton2_0.ActiveFillColor = Color.FromArgb(25, 23, 26);
		this.bunifuThinButton2_0.ActiveForecolor = Color.FromArgb(225, 29, 65);
		this.bunifuThinButton2_0.ActiveLineColor = Color.FromArgb(225, 29, 65);
		this.bunifuThinButton2_0.BackColor = Color.FromArgb(25, 23, 26);
		this.bunifuThinButton2_0.BackgroundImage = (Image)componentResourceManager.GetObject(Class185.smethod_0(537705412));
		this.bunifuThinButton2_0.ButtonText = Class185.smethod_0(537705246);
		this.bunifuThinButton2_0.Cursor = Cursors.Hand;
		this.bunifuThinButton2_0.Font = new Font(Class185.smethod_0(537691381), 12f);
		this.bunifuThinButton2_0.ForeColor = Color.FromArgb(44, 186, 118);
		this.bunifuThinButton2_0.IdleBorderThickness = 1;
		this.bunifuThinButton2_0.IdleCornerRadius = 30;
		this.bunifuThinButton2_0.IdleFillColor = Color.FromArgb(25, 23, 26);
		this.bunifuThinButton2_0.IdleForecolor = Color.FromArgb(225, 29, 65);
		this.bunifuThinButton2_0.IdleLineColor = Color.FromArgb(225, 29, 65);
		this.bunifuThinButton2_0.Location = new Point(14, 58);
		this.bunifuThinButton2_0.Margin = new Padding(5, 4, 5, 4);
		this.bunifuThinButton2_0.Name = Class185.smethod_0(537705222);
		this.bunifuThinButton2_0.Size = new Size(183, 44);
		this.bunifuThinButton2_0.TabIndex = 10;
		this.bunifuThinButton2_0.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuThinButton2_0.Click += this.bunifuThinButton2_0_Click;
		this.pictureBox_3.Cursor = Cursors.Hand;
		this.pictureBox_3.Image = (Image)componentResourceManager.GetObject(Class185.smethod_0(537705248));
		this.pictureBox_3.Location = new Point(220, 66);
		this.pictureBox_3.Name = Class185.smethod_0(537705288);
		this.pictureBox_3.Size = new Size(27, 28);
		this.pictureBox_3.SizeMode = PictureBoxSizeMode.StretchImage;
		this.pictureBox_3.TabIndex = 9;
		this.pictureBox_3.TabStop = false;
		this.bunifuThinButton2_1.ActiveBorderThickness = 1;
		this.bunifuThinButton2_1.ActiveCornerRadius = 30;
		this.bunifuThinButton2_1.ActiveFillColor = Color.FromArgb(25, 23, 26);
		this.bunifuThinButton2_1.ActiveForecolor = Color.FromArgb(44, 186, 118);
		this.bunifuThinButton2_1.ActiveLineColor = Color.FromArgb(44, 186, 118);
		this.bunifuThinButton2_1.BackColor = Color.FromArgb(25, 23, 26);
		this.bunifuThinButton2_1.BackgroundImage = (Image)componentResourceManager.GetObject(Class185.smethod_0(537705338));
		this.bunifuThinButton2_1.ButtonText = Class185.smethod_0(537705107);
		this.bunifuThinButton2_1.Cursor = Cursors.Hand;
		this.bunifuThinButton2_1.Font = new Font(Class185.smethod_0(537691381), 12f);
		this.bunifuThinButton2_1.ForeColor = Color.FromArgb(44, 186, 118);
		this.bunifuThinButton2_1.IdleBorderThickness = 1;
		this.bunifuThinButton2_1.IdleCornerRadius = 30;
		this.bunifuThinButton2_1.IdleFillColor = Color.FromArgb(25, 23, 26);
		this.bunifuThinButton2_1.IdleForecolor = Color.FromArgb(44, 186, 118);
		this.bunifuThinButton2_1.IdleLineColor = Color.FromArgb(44, 186, 118);
		this.bunifuThinButton2_1.Location = new Point(207, 58);
		this.bunifuThinButton2_1.Margin = new Padding(5, 4, 5, 4);
		this.bunifuThinButton2_1.Name = Class185.smethod_0(537705146);
		this.bunifuThinButton2_1.Size = new Size(182, 44);
		this.bunifuThinButton2_1.TabIndex = 0;
		this.bunifuThinButton2_1.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuThinButton2_1.Click += this.bunifuThinButton2_1_Click;
		this.panel_2.Controls.Add(this.bunifuThinButton2_6);
		this.panel_2.Controls.Add(this.bunifuThinButton2_7);
		this.panel_2.Controls.Add(this.bunifuCustomLabel_1);
		this.panel_2.Controls.Add(this.bunifuThinButton2_8);
		this.panel_2.Controls.Add(this.bunifuCustomLabel_2);
		this.panel_2.Controls.Add(this.bunifuThinButton2_9);
		this.panel_2.Controls.Add(this.bunifuThinButton2_10);
		this.panel_2.Controls.Add(this.bunifuCustomLabel_3);
		this.panel_2.Controls.Add(this.bunifuThinButton2_11);
		this.panel_2.Controls.Add(this.bunifuThinButton2_5);
		this.panel_2.Controls.Add(this.bunifuThinButton2_3);
		this.panel_2.Controls.Add(this.bunifuCustomLabel_0);
		this.panel_2.Controls.Add(this.bunifuThinButton2_2);
		this.panel_2.Dock = DockStyle.Top;
		this.panel_2.Location = new Point(0, 53);
		this.panel_2.Name = Class185.smethod_0(537705123);
		this.panel_2.Size = new Size(439, 42);
		this.panel_2.TabIndex = 2;
		this.bunifuThinButton2_6.ActiveBorderThickness = 1;
		this.bunifuThinButton2_6.ActiveCornerRadius = 20;
		this.bunifuThinButton2_6.ActiveFillColor = Color.Empty;
		this.bunifuThinButton2_6.ActiveForecolor = Color.Empty;
		this.bunifuThinButton2_6.ActiveLineColor = Color.Empty;
		this.bunifuThinButton2_6.BackColor = Color.FromArgb(25, 23, 26);
		this.bunifuThinButton2_6.BackgroundImage = (Image)componentResourceManager.GetObject(Class185.smethod_0(537705170));
		this.bunifuThinButton2_6.ButtonText = Class185.smethod_0(537705205);
		this.bunifuThinButton2_6.Cursor = Cursors.Hand;
		this.bunifuThinButton2_6.Font = new Font(Class185.smethod_0(537705197), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.bunifuThinButton2_6.ForeColor = Color.White;
		this.bunifuThinButton2_6.IdleBorderThickness = 1;
		this.bunifuThinButton2_6.IdleCornerRadius = 20;
		this.bunifuThinButton2_6.IdleFillColor = Color.Empty;
		this.bunifuThinButton2_6.IdleForecolor = Color.Empty;
		this.bunifuThinButton2_6.IdleLineColor = Color.Empty;
		this.bunifuThinButton2_6.Location = new Point(388, 7);
		this.bunifuThinButton2_6.Margin = new Padding(4, 4, 4, 4);
		this.bunifuThinButton2_6.Name = Class185.smethod_0(537704968);
		this.bunifuThinButton2_6.Size = new Size(17, 21);
		this.bunifuThinButton2_6.TabIndex = 19;
		this.bunifuThinButton2_6.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuThinButton2_6.Click += this.bunifuThinButton2_6_Click;
		this.bunifuThinButton2_7.ActiveBorderThickness = 1;
		this.bunifuThinButton2_7.ActiveCornerRadius = 20;
		this.bunifuThinButton2_7.ActiveFillColor = Color.Transparent;
		this.bunifuThinButton2_7.ActiveForecolor = Color.White;
		this.bunifuThinButton2_7.ActiveLineColor = Color.Transparent;
		this.bunifuThinButton2_7.BackColor = Color.FromArgb(25, 23, 26);
		this.bunifuThinButton2_7.BackgroundImage = (Image)componentResourceManager.GetObject(Class185.smethod_0(537705019));
		this.bunifuThinButton2_7.ButtonText = Class185.smethod_0(537705055);
		this.bunifuThinButton2_7.Cursor = Cursors.Hand;
		this.bunifuThinButton2_7.Font = new Font(Class185.smethod_0(537691496), 10f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.bunifuThinButton2_7.ForeColor = Color.SeaGreen;
		this.bunifuThinButton2_7.IdleBorderThickness = 1;
		this.bunifuThinButton2_7.IdleCornerRadius = 20;
		this.bunifuThinButton2_7.IdleFillColor = Color.Transparent;
		this.bunifuThinButton2_7.IdleForecolor = Color.White;
		this.bunifuThinButton2_7.IdleLineColor = Color.Transparent;
		this.bunifuThinButton2_7.Location = new Point(321, 16);
		this.bunifuThinButton2_7.Margin = new Padding(4, 4, 4, 4);
		this.bunifuThinButton2_7.Name = Class185.smethod_0(537705038);
		this.bunifuThinButton2_7.Size = new Size(75, 17);
		this.bunifuThinButton2_7.TabIndex = 18;
		this.bunifuThinButton2_7.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuThinButton2_7.Click += this.bunifuThinButton2_7_Click;
		this.bunifuCustomLabel_1.BackColor = Color.SeaGreen;
		this.bunifuCustomLabel_1.ForeColor = Color.Coral;
		this.bunifuCustomLabel_1.Location = new Point(321, 37);
		this.bunifuCustomLabel_1.Name = Class185.smethod_0(537705074);
		this.bunifuCustomLabel_1.Size = new Size(75, 3);
		this.bunifuCustomLabel_1.TabIndex = 17;
		this.bunifuThinButton2_8.ActiveBorderThickness = 1;
		this.bunifuThinButton2_8.ActiveCornerRadius = 20;
		this.bunifuThinButton2_8.ActiveFillColor = Color.Empty;
		this.bunifuThinButton2_8.ActiveForecolor = Color.Empty;
		this.bunifuThinButton2_8.ActiveLineColor = Color.Empty;
		this.bunifuThinButton2_8.BackColor = Color.FromArgb(25, 23, 26);
		this.bunifuThinButton2_8.BackgroundImage = (Image)componentResourceManager.GetObject(Class185.smethod_0(537705060));
		this.bunifuThinButton2_8.ButtonText = Class185.smethod_0(537705205);
		this.bunifuThinButton2_8.Cursor = Cursors.Hand;
		this.bunifuThinButton2_8.Font = new Font(Class185.smethod_0(537705197), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.bunifuThinButton2_8.ForeColor = Color.White;
		this.bunifuThinButton2_8.IdleBorderThickness = 1;
		this.bunifuThinButton2_8.IdleCornerRadius = 20;
		this.bunifuThinButton2_8.IdleFillColor = Color.Empty;
		this.bunifuThinButton2_8.IdleForecolor = Color.Empty;
		this.bunifuThinButton2_8.IdleLineColor = Color.Empty;
		this.bunifuThinButton2_8.Location = new Point(283, 7);
		this.bunifuThinButton2_8.Margin = new Padding(4, 4, 4, 4);
		this.bunifuThinButton2_8.Name = Class185.smethod_0(537704839);
		this.bunifuThinButton2_8.Size = new Size(17, 21);
		this.bunifuThinButton2_8.TabIndex = 16;
		this.bunifuThinButton2_8.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuThinButton2_8.Click += this.bunifuThinButton2_8_Click;
		this.bunifuCustomLabel_2.BackColor = Color.SeaGreen;
		this.bunifuCustomLabel_2.ForeColor = Color.Coral;
		this.bunifuCustomLabel_2.Location = new Point(217, 37);
		this.bunifuCustomLabel_2.Name = Class185.smethod_0(537704874);
		this.bunifuCustomLabel_2.Size = new Size(75, 3);
		this.bunifuCustomLabel_2.TabIndex = 14;
		this.bunifuThinButton2_9.ActiveBorderThickness = 1;
		this.bunifuThinButton2_9.ActiveCornerRadius = 20;
		this.bunifuThinButton2_9.ActiveFillColor = Color.Transparent;
		this.bunifuThinButton2_9.ActiveForecolor = Color.White;
		this.bunifuThinButton2_9.ActiveLineColor = Color.Transparent;
		this.bunifuThinButton2_9.BackColor = Color.FromArgb(25, 23, 26);
		this.bunifuThinButton2_9.BackgroundImage = (Image)componentResourceManager.GetObject(Class185.smethod_0(537704924));
		this.bunifuThinButton2_9.ButtonText = Class185.smethod_0(537704944);
		this.bunifuThinButton2_9.Cursor = Cursors.Hand;
		this.bunifuThinButton2_9.Font = new Font(Class185.smethod_0(537691496), 10f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.bunifuThinButton2_9.ForeColor = Color.SeaGreen;
		this.bunifuThinButton2_9.IdleBorderThickness = 1;
		this.bunifuThinButton2_9.IdleCornerRadius = 20;
		this.bunifuThinButton2_9.IdleFillColor = Color.Transparent;
		this.bunifuThinButton2_9.IdleForecolor = Color.White;
		this.bunifuThinButton2_9.IdleLineColor = Color.Transparent;
		this.bunifuThinButton2_9.Location = new Point(217, 16);
		this.bunifuThinButton2_9.Margin = new Padding(4, 4, 4, 4);
		this.bunifuThinButton2_9.Name = Class185.smethod_0(537704943);
		this.bunifuThinButton2_9.Size = new Size(75, 17);
		this.bunifuThinButton2_9.TabIndex = 15;
		this.bunifuThinButton2_9.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuThinButton2_9.Click += this.bunifuThinButton2_9_Click;
		this.bunifuThinButton2_10.ActiveBorderThickness = 1;
		this.bunifuThinButton2_10.ActiveCornerRadius = 20;
		this.bunifuThinButton2_10.ActiveFillColor = Color.Empty;
		this.bunifuThinButton2_10.ActiveForecolor = Color.Empty;
		this.bunifuThinButton2_10.ActiveLineColor = Color.Empty;
		this.bunifuThinButton2_10.BackColor = Color.FromArgb(25, 23, 26);
		this.bunifuThinButton2_10.BackgroundImage = (Image)componentResourceManager.GetObject(Class185.smethod_0(537704723));
		this.bunifuThinButton2_10.ButtonText = Class185.smethod_0(537705205);
		this.bunifuThinButton2_10.Cursor = Cursors.Hand;
		this.bunifuThinButton2_10.Font = new Font(Class185.smethod_0(537705197), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.bunifuThinButton2_10.ForeColor = Color.White;
		this.bunifuThinButton2_10.IdleBorderThickness = 1;
		this.bunifuThinButton2_10.IdleCornerRadius = 20;
		this.bunifuThinButton2_10.IdleFillColor = Color.Empty;
		this.bunifuThinButton2_10.IdleForecolor = Color.Empty;
		this.bunifuThinButton2_10.IdleLineColor = Color.Empty;
		this.bunifuThinButton2_10.Location = new Point(182, 7);
		this.bunifuThinButton2_10.Margin = new Padding(4, 4, 4, 4);
		this.bunifuThinButton2_10.Name = Class185.smethod_0(537704758);
		this.bunifuThinButton2_10.Size = new Size(17, 21);
		this.bunifuThinButton2_10.TabIndex = 13;
		this.bunifuThinButton2_10.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuThinButton2_10.Click += this.bunifuThinButton2_10_Click;
		this.bunifuCustomLabel_3.BackColor = Color.SeaGreen;
		this.bunifuCustomLabel_3.ForeColor = Color.Coral;
		this.bunifuCustomLabel_3.Location = new Point(116, 37);
		this.bunifuCustomLabel_3.Name = Class185.smethod_0(537704793);
		this.bunifuCustomLabel_3.Size = new Size(75, 3);
		this.bunifuCustomLabel_3.TabIndex = 11;
		this.bunifuThinButton2_11.ActiveBorderThickness = 1;
		this.bunifuThinButton2_11.ActiveCornerRadius = 20;
		this.bunifuThinButton2_11.ActiveFillColor = Color.Transparent;
		this.bunifuThinButton2_11.ActiveForecolor = Color.White;
		this.bunifuThinButton2_11.ActiveLineColor = Color.Transparent;
		this.bunifuThinButton2_11.BackColor = Color.FromArgb(25, 23, 26);
		this.bunifuThinButton2_11.BackgroundImage = (Image)componentResourceManager.GetObject(Class185.smethod_0(537704779));
		this.bunifuThinButton2_11.ButtonText = Class185.smethod_0(537704815);
		this.bunifuThinButton2_11.Cursor = Cursors.Hand;
		this.bunifuThinButton2_11.Font = new Font(Class185.smethod_0(537691496), 10f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.bunifuThinButton2_11.ForeColor = Color.SeaGreen;
		this.bunifuThinButton2_11.IdleBorderThickness = 1;
		this.bunifuThinButton2_11.IdleCornerRadius = 20;
		this.bunifuThinButton2_11.IdleFillColor = Color.Transparent;
		this.bunifuThinButton2_11.IdleForecolor = Color.White;
		this.bunifuThinButton2_11.IdleLineColor = Color.Transparent;
		this.bunifuThinButton2_11.Location = new Point(116, 16);
		this.bunifuThinButton2_11.Margin = new Padding(4, 4, 4, 4);
		this.bunifuThinButton2_11.Name = Class185.smethod_0(537704606);
		this.bunifuThinButton2_11.Size = new Size(75, 17);
		this.bunifuThinButton2_11.TabIndex = 12;
		this.bunifuThinButton2_11.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuThinButton2_11.Click += this.bunifuThinButton2_11_Click;
		this.bunifuThinButton2_5.ActiveBorderThickness = 1;
		this.bunifuThinButton2_5.ActiveCornerRadius = 20;
		this.bunifuThinButton2_5.ActiveFillColor = Color.Empty;
		this.bunifuThinButton2_5.ActiveForecolor = Color.Empty;
		this.bunifuThinButton2_5.ActiveLineColor = Color.Empty;
		this.bunifuThinButton2_5.BackColor = Color.FromArgb(25, 23, 26);
		this.bunifuThinButton2_5.BackgroundImage = (Image)componentResourceManager.GetObject(Class185.smethod_0(537704578));
		this.bunifuThinButton2_5.ButtonText = Class185.smethod_0(537705205);
		this.bunifuThinButton2_5.Cursor = Cursors.Hand;
		this.bunifuThinButton2_5.Font = new Font(Class185.smethod_0(537705197), 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.bunifuThinButton2_5.ForeColor = Color.White;
		this.bunifuThinButton2_5.IdleBorderThickness = 1;
		this.bunifuThinButton2_5.IdleCornerRadius = 20;
		this.bunifuThinButton2_5.IdleFillColor = Color.Empty;
		this.bunifuThinButton2_5.IdleForecolor = Color.Empty;
		this.bunifuThinButton2_5.IdleLineColor = Color.Empty;
		this.bunifuThinButton2_5.Location = new Point(78, 7);
		this.bunifuThinButton2_5.Margin = new Padding(4, 4, 4, 4);
		this.bunifuThinButton2_5.Name = Class185.smethod_0(537704613);
		this.bunifuThinButton2_5.Size = new Size(17, 21);
		this.bunifuThinButton2_5.TabIndex = 10;
		this.bunifuThinButton2_5.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuThinButton2_5.Click += this.bunifuThinButton2_5_Click;
		this.bunifuThinButton2_3.ActiveBorderThickness = 1;
		this.bunifuThinButton2_3.ActiveCornerRadius = 20;
		this.bunifuThinButton2_3.ActiveFillColor = Color.Empty;
		this.bunifuThinButton2_3.ActiveForecolor = Color.Empty;
		this.bunifuThinButton2_3.ActiveLineColor = Color.Empty;
		this.bunifuThinButton2_3.BackColor = Color.FromArgb(25, 23, 26);
		this.bunifuThinButton2_3.BackgroundImage = (Image)componentResourceManager.GetObject(Class185.smethod_0(537704648));
		this.bunifuThinButton2_3.ButtonText = Class185.smethod_0(537704684);
		this.bunifuThinButton2_3.Cursor = Cursors.Hand;
		this.bunifuThinButton2_3.Font = new Font(Class185.smethod_0(537691496), 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.bunifuThinButton2_3.ForeColor = Color.FromArgb(44, 186, 118);
		this.bunifuThinButton2_3.IdleBorderThickness = 1;
		this.bunifuThinButton2_3.IdleCornerRadius = 20;
		this.bunifuThinButton2_3.IdleFillColor = Color.Empty;
		this.bunifuThinButton2_3.IdleForecolor = Color.Empty;
		this.bunifuThinButton2_3.IdleLineColor = Color.Empty;
		this.bunifuThinButton2_3.Location = new Point(408, 11);
		this.bunifuThinButton2_3.Margin = new Padding(5);
		this.bunifuThinButton2_3.Name = Class185.smethod_0(537704676);
		this.bunifuThinButton2_3.Size = new Size(33, 29);
		this.bunifuThinButton2_3.TabIndex = 0;
		this.bunifuThinButton2_3.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuThinButton2_3.Click += this.bunifuThinButton2_3_Click;
		this.bunifuCustomLabel_0.BackColor = Color.SeaGreen;
		this.bunifuCustomLabel_0.ForeColor = Color.Coral;
		this.bunifuCustomLabel_0.Location = new Point(12, 37);
		this.bunifuCustomLabel_0.Name = Class185.smethod_0(537704456);
		this.bunifuCustomLabel_0.Size = new Size(75, 3);
		this.bunifuCustomLabel_0.TabIndex = 1;
		this.bunifuThinButton2_2.ActiveBorderThickness = 1;
		this.bunifuThinButton2_2.ActiveCornerRadius = 20;
		this.bunifuThinButton2_2.ActiveFillColor = Color.Transparent;
		this.bunifuThinButton2_2.ActiveForecolor = Color.White;
		this.bunifuThinButton2_2.ActiveLineColor = Color.Transparent;
		this.bunifuThinButton2_2.BackColor = Color.FromArgb(25, 23, 26);
		this.bunifuThinButton2_2.BackgroundImage = (Image)componentResourceManager.GetObject(Class185.smethod_0(537704506));
		this.bunifuThinButton2_2.ButtonText = Class185.smethod_0(537704542);
		this.bunifuThinButton2_2.Cursor = Cursors.Hand;
		this.bunifuThinButton2_2.Font = new Font(Class185.smethod_0(537691496), 10f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.bunifuThinButton2_2.ForeColor = Color.SeaGreen;
		this.bunifuThinButton2_2.IdleBorderThickness = 1;
		this.bunifuThinButton2_2.IdleCornerRadius = 20;
		this.bunifuThinButton2_2.IdleFillColor = Color.Transparent;
		this.bunifuThinButton2_2.IdleForecolor = Color.White;
		this.bunifuThinButton2_2.IdleLineColor = Color.Transparent;
		this.bunifuThinButton2_2.Location = new Point(12, 16);
		this.bunifuThinButton2_2.Margin = new Padding(4, 4, 4, 4);
		this.bunifuThinButton2_2.Name = Class185.smethod_0(537704525);
		this.bunifuThinButton2_2.Size = new Size(75, 17);
		this.bunifuThinButton2_2.TabIndex = 2;
		this.bunifuThinButton2_2.TextAlign = ContentAlignment.MiddleCenter;
		this.bunifuThinButton2_2.Click += this.bunifuThinButton2_2_Click;
		this.panel_1.Dock = DockStyle.Fill;
		this.panel_1.Location = new Point(0, 95);
		this.panel_1.Name = Class185.smethod_0(537704561);
		this.panel_1.Size = new Size(439, 531);
		this.panel_1.TabIndex = 3;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		this.BackColor = Color.FromArgb(25, 23, 26);
		base.ClientSize = new Size(439, 741);
		base.Controls.Add(this.panel_1);
		base.Controls.Add(this.panel_2);
		base.Controls.Add(this.panel_0);
		base.Controls.Add(this.panel_3);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Icon = (Icon)componentResourceManager.GetObject(Class185.smethod_0(537704548));
		base.Name = Class185.smethod_0(537706389);
		this.Text = Class185.smethod_0(537706427);
		this.panel_3.ResumeLayout(false);
		this.panel_3.PerformLayout();
		((ISupportInitialize)this.pictureBox_0).EndInit();
		((ISupportInitialize)this.pictureBox_1).EndInit();
		this.panel_0.ResumeLayout(false);
		((ISupportInitialize)this.pictureBox_4).EndInit();
		((ISupportInitialize)this.pictureBox_2).EndInit();
		((ISupportInitialize)this.pictureBox_3).EndInit();
		this.panel_2.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	// Token: 0x040004A5 RID: 1189
	public static bool bool_0;

	// Token: 0x040004A6 RID: 1190
	public static List<ConcurrentDictionary<string, string>> list_0 = new List<ConcurrentDictionary<string, string>>();

	// Token: 0x040004A7 RID: 1191
	public static ConcurrentDictionary<string, string> concurrentDictionary_0 = new ConcurrentDictionary<string, string>();

	// Token: 0x040004A8 RID: 1192
	public static SoundPlayer soundPlayer_0 = new SoundPlayer(Class185.smethod_0(537692456));

	// Token: 0x040004A9 RID: 1193
	public GForm2 gform2_0;

	// Token: 0x040004AA RID: 1194
	[Dynamic(new bool[]
	{
		false,
		false,
		false,
		false,
		true
	})]
	private static Dictionary<string, Dictionary<string, dynamic>> dictionary_0 = new Dictionary<string, Dictionary<string, object>>();

	// Token: 0x040004AB RID: 1195
	private static string string_0;

	// Token: 0x040004AC RID: 1196
	private int int_0;

	// Token: 0x040004AE RID: 1198
	private BunifuElipse bunifuElipse_0;

	// Token: 0x040004AF RID: 1199
	private PictureBox pictureBox_0;

	// Token: 0x040004B0 RID: 1200
	private PictureBox pictureBox_1;

	// Token: 0x040004B1 RID: 1201
	private Label label_0;

	// Token: 0x040004B2 RID: 1202
	private Panel panel_0;

	// Token: 0x040004B3 RID: 1203
	private PictureBox pictureBox_2;

	// Token: 0x040004B4 RID: 1204
	private BunifuThinButton2 bunifuThinButton2_0;

	// Token: 0x040004B5 RID: 1205
	private PictureBox pictureBox_3;

	// Token: 0x040004B6 RID: 1206
	private BunifuThinButton2 bunifuThinButton2_1;

	// Token: 0x040004B7 RID: 1207
	private BunifuMaterialTextbox bunifuMaterialTextbox_0;

	// Token: 0x040004B8 RID: 1208
	private Panel panel_1;

	// Token: 0x040004B9 RID: 1209
	private Panel panel_2;

	// Token: 0x040004BA RID: 1210
	private BunifuThinButton2 bunifuThinButton2_2;

	// Token: 0x040004BB RID: 1211
	private BunifuCustomLabel bunifuCustomLabel_0;

	// Token: 0x040004BC RID: 1212
	private BunifuThinButton2 bunifuThinButton2_3;

	// Token: 0x040004BD RID: 1213
	private BunifuThinButton2 bunifuThinButton2_4;

	// Token: 0x040004BE RID: 1214
	private PictureBox pictureBox_4;

	// Token: 0x040004BF RID: 1215
	private BunifuThinButton2 bunifuThinButton2_5;

	// Token: 0x040004C0 RID: 1216
	public Panel panel_3;

	// Token: 0x040004C1 RID: 1217
	private BunifuThinButton2 bunifuThinButton2_6;

	// Token: 0x040004C2 RID: 1218
	private BunifuThinButton2 bunifuThinButton2_7;

	// Token: 0x040004C3 RID: 1219
	private BunifuCustomLabel bunifuCustomLabel_1;

	// Token: 0x040004C4 RID: 1220
	private BunifuThinButton2 bunifuThinButton2_8;

	// Token: 0x040004C5 RID: 1221
	private BunifuCustomLabel bunifuCustomLabel_2;

	// Token: 0x040004C6 RID: 1222
	private BunifuThinButton2 bunifuThinButton2_9;

	// Token: 0x040004C7 RID: 1223
	private BunifuThinButton2 bunifuThinButton2_10;

	// Token: 0x040004C8 RID: 1224
	private BunifuCustomLabel bunifuCustomLabel_3;

	// Token: 0x040004C9 RID: 1225
	private BunifuThinButton2 bunifuThinButton2_11;

	// Token: 0x040004CA RID: 1226
	private BunifuThinButton2 bunifuThinButton2_12;

	// Token: 0x0200011E RID: 286
	[Serializable]
	private sealed class Class190
	{
		// Token: 0x0600075F RID: 1887 RVA: 0x00006A68 File Offset: 0x00004C68
		internal void method_0()
		{
			GForm1.smethod_2(null, null);
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00006A71 File Offset: 0x00004C71
		internal void method_1()
		{
			GForm1.gform7_0.method_7();
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00006A71 File Offset: 0x00004C71
		internal void method_2()
		{
			GForm1.gform7_0.method_7();
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00002D1D File Offset: 0x00000F1D
		internal bool method_3(ConcurrentDictionary<string, string> concurrentDictionary_0)
		{
			return concurrentDictionary_0[Class185.smethod_0(537692776)] == Class185.smethod_0(537692774);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00046E68 File Offset: 0x00045068
		internal bool method_4(KeyValuePair<string, Dictionary<string, dynamic>> keyValuePair_0)
		{
			if (GForm7.Class194.callSite_0 == null)
			{
				GForm7.Class194.callSite_0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(bool), typeof(GForm7)));
			}
			return GForm7.Class194.callSite_0.Target(GForm7.Class194.callSite_0, keyValuePair_0.Value[Class185.smethod_0(537692562)]);
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00002D1D File Offset: 0x00000F1D
		internal bool method_5(ConcurrentDictionary<string, string> concurrentDictionary_0)
		{
			return concurrentDictionary_0[Class185.smethod_0(537692776)] == Class185.smethod_0(537692774);
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00006A7D File Offset: 0x00004C7D
		internal short method_6(KeyValuePair<string, Dictionary<string, dynamic>> keyValuePair_0)
		{
			return Convert.ToInt16(keyValuePair_0.Key.Replace(Class185.smethod_0(537692546), string.Empty));
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00046ECC File Offset: 0x000450CC
		internal bool method_7(KeyValuePair<string, Dictionary<string, dynamic>> keyValuePair_0)
		{
			if (GForm7.Class194.callSite_1 == null)
			{
				GForm7.Class194.callSite_1 = CallSite<Func<CallSite, object, bool>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(bool), typeof(GForm7)));
			}
			return GForm7.Class194.callSite_1.Target(GForm7.Class194.callSite_1, keyValuePair_0.Value[Class185.smethod_0(537692562)]);
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00006A71 File Offset: 0x00004C71
		internal void method_8()
		{
			GForm1.gform7_0.method_7();
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00006A9F File Offset: 0x00004C9F
		internal string method_9(KeyValuePair<string, Dictionary<string, dynamic>> keyValuePair_0)
		{
			return keyValuePair_0.Key;
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00006AA8 File Offset: 0x00004CA8
		internal short method_10(string string_0)
		{
			return Convert.ToInt16(string_0.Replace(Class185.smethod_0(537692546), string.Empty));
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00046F30 File Offset: 0x00045130
		internal bool method_11(KeyValuePair<string, Dictionary<string, dynamic>> keyValuePair_0)
		{
			if (GForm7.Class198.callSite_0 == null)
			{
				GForm7.Class198.callSite_0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(bool), typeof(GForm7)));
			}
			return !GForm7.Class198.callSite_0.Target(GForm7.Class198.callSite_0, keyValuePair_0.Value[Class185.smethod_0(537692562)]);
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00006A9F File Offset: 0x00004C9F
		internal string method_12(KeyValuePair<string, Dictionary<string, dynamic>> keyValuePair_0)
		{
			return keyValuePair_0.Key;
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00006AA8 File Offset: 0x00004CA8
		internal short method_13(string string_0)
		{
			return Convert.ToInt16(string_0.Replace(Class185.smethod_0(537692546), string.Empty));
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00006AC4 File Offset: 0x00004CC4
		internal bool method_14(ConcurrentDictionary<string, string> concurrentDictionary_0)
		{
			return concurrentDictionary_0[Class185.smethod_0(537692592)] == GForm7.string_0 && concurrentDictionary_0[Class185.smethod_0(537692776)] == Class185.smethod_0(537692590);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00006A71 File Offset: 0x00004C71
		internal void method_15()
		{
			GForm1.gform7_0.method_7();
		}

		// Token: 0x040004CB RID: 1227
		public static readonly GForm7.Class190 class190_0 = new GForm7.Class190();

		// Token: 0x040004CC RID: 1228
		public static MethodInvoker methodInvoker_0;

		// Token: 0x040004CD RID: 1229
		public static MethodInvoker methodInvoker_1;

		// Token: 0x040004CE RID: 1230
		public static MethodInvoker methodInvoker_2;

		// Token: 0x040004CF RID: 1231
		public static Func<ConcurrentDictionary<string, string>, bool> func_0;

		// Token: 0x040004D0 RID: 1232
		public static Func<KeyValuePair<string, Dictionary<string, object>>, bool> func_1;

		// Token: 0x040004D1 RID: 1233
		public static Func<ConcurrentDictionary<string, string>, bool> func_2;

		// Token: 0x040004D2 RID: 1234
		public static Func<KeyValuePair<string, Dictionary<string, object>>, short> func_3;

		// Token: 0x040004D3 RID: 1235
		public static Func<KeyValuePair<string, Dictionary<string, object>>, bool> func_4;

		// Token: 0x040004D4 RID: 1236
		public static MethodInvoker methodInvoker_3;

		// Token: 0x040004D5 RID: 1237
		public static Func<KeyValuePair<string, Dictionary<string, object>>, string> func_5;

		// Token: 0x040004D6 RID: 1238
		public static Func<string, short> func_6;

		// Token: 0x040004D7 RID: 1239
		public static Func<KeyValuePair<string, Dictionary<string, object>>, bool> func_7;

		// Token: 0x040004D8 RID: 1240
		public static Func<KeyValuePair<string, Dictionary<string, object>>, string> func_8;

		// Token: 0x040004D9 RID: 1241
		public static Func<string, short> func_9;

		// Token: 0x040004DA RID: 1242
		public static Func<ConcurrentDictionary<string, string>, bool> func_10;

		// Token: 0x040004DB RID: 1243
		public static MethodInvoker methodInvoker_4;
	}

	// Token: 0x0200011F RID: 287
	private static class Class191
	{
		// Token: 0x040004DC RID: 1244
		public static CallSite<Func<CallSite, object, object>> callSite_0;

		// Token: 0x040004DD RID: 1245
		public static CallSite<Func<CallSite, object, object>> callSite_1;

		// Token: 0x040004DE RID: 1246
		public static CallSite<Func<CallSite, object, ProxyInfo, object>> callSite_2;

		// Token: 0x040004DF RID: 1247
		public static CallSite<Func<CallSite, object, object>> callSite_3;

		// Token: 0x040004E0 RID: 1248
		public static CallSite<Func<CallSite, object, ProxyInfo, object>> callSite_4;

		// Token: 0x040004E1 RID: 1249
		public static CallSite<Func<CallSite, object, object>> callSite_5;

		// Token: 0x040004E2 RID: 1250
		public static CallSite<Action<CallSite, object, bool>> callSite_6;

		// Token: 0x040004E3 RID: 1251
		public static CallSite<Action<CallSite, object>> callSite_7;

		// Token: 0x040004E4 RID: 1252
		public static CallSite<Func<CallSite, object, Engine>> callSite_8;

		// Token: 0x040004E5 RID: 1253
		public static CallSite<Func<CallSite, object, object>> callSite_9;

		// Token: 0x040004E6 RID: 1254
		public static CallSite<Action<CallSite, WebView, object>> callSite_10;
	}

	// Token: 0x02000120 RID: 288
	private static class Class192
	{
		// Token: 0x040004E7 RID: 1255
		public static CallSite<Action<CallSite, Control.ControlCollection, object>> callSite_0;

		// Token: 0x040004E8 RID: 1256
		public static CallSite<Func<CallSite, object, object, object>> callSite_1;

		// Token: 0x040004E9 RID: 1257
		public static CallSite<Func<CallSite, object, bool>> callSite_2;

		// Token: 0x040004EA RID: 1258
		public static CallSite<Func<CallSite, object, string>> callSite_3;
	}

	// Token: 0x02000121 RID: 289
	[StructLayout(LayoutKind.Auto)]
	private struct Struct59 : IAsyncStateMachine
	{
		// Token: 0x0600076F RID: 1903 RVA: 0x00046F98 File Offset: 0x00045198
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			string result;
			try
			{
				if (num != 0)
				{
					GForm1.gform1_0.Invoke(new MethodInvoker(GForm7.Class190.class190_0.method_0));
					text = Class108.smethod_0(16);
					ConcurrentDictionary<string, string> concurrentDictionary3 = new ConcurrentDictionary<string, string>();
					concurrentDictionary3[Class185.smethod_0(537692629)] = string_1;
					concurrentDictionary3[Class185.smethod_0(537692611)] = string_2;
					concurrentDictionary3[Class185.smethod_0(537692656)] = string_3;
					concurrentDictionary3[Class185.smethod_0(537692633)] = text;
					concurrentDictionary3[Class185.smethod_0(537692776)] = Class185.smethod_0(537692774);
					concurrentDictionary2 = concurrentDictionary3;
					GForm7.list_0.Add(concurrentDictionary2);
				}
				try
				{
					TaskAwaiter taskAwaiter3;
					if (num == 0)
					{
						taskAwaiter3 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
						num2 = -1;
						goto IL_13E;
					}
					GForm7.smethod_2(null, null);
					IL_FC:
					if (GForm7.concurrentDictionary_0.ContainsKey(text))
					{
						result = GForm7.concurrentDictionary_0[text];
						goto IL_27B;
					}
					if (!GForm1.dictionary_0.ContainsKey((int)Convert.ToInt16(string_3)))
					{
						GForm7.list_0.Remove(concurrentDictionary2);
						if (concurrentDictionary2.ContainsKey(Class185.smethod_0(537692592)))
						{
							GForm7.smethod_7(concurrentDictionary2[Class185.smethod_0(537692592)]);
							GForm1.gform1_0.Invoke(new MethodInvoker(GForm7.Class190.class190_0.method_1));
						}
						result = null;
						goto IL_27B;
					}
					taskAwaiter3 = Task.Delay(100).GetAwaiter();
					if (!taskAwaiter3.IsCompleted)
					{
						num2 = 0;
						taskAwaiter2 = taskAwaiter3;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GForm7.Struct59>(ref taskAwaiter3, ref this);
						return;
					}
					IL_13E:
					taskAwaiter3.GetResult();
					goto IL_FC;
				}
				catch
				{
					GForm7.list_0.Remove(concurrentDictionary2);
					if (concurrentDictionary2.ContainsKey(Class185.smethod_0(537692592)))
					{
						GForm7.smethod_7(concurrentDictionary2[Class185.smethod_0(537692592)]);
						GForm1.gform1_0.Invoke(new MethodInvoker(GForm7.Class190.class190_0.method_2));
					}
					result = null;
				}
			}
			catch (Exception exception)
			{
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_27B:
			num2 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00006B03 File Offset: 0x00004D03
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040004EB RID: 1259
		public int int_0;

		// Token: 0x040004EC RID: 1260
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x040004ED RID: 1261
		public string string_0;

		// Token: 0x040004EE RID: 1262
		public string string_1;

		// Token: 0x040004EF RID: 1263
		public string string_2;

		// Token: 0x040004F0 RID: 1264
		private string string_3;

		// Token: 0x040004F1 RID: 1265
		private ConcurrentDictionary<string, string> concurrentDictionary_0;

		// Token: 0x040004F2 RID: 1266
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000122 RID: 290
	private sealed class Class193
	{
		// Token: 0x06000772 RID: 1906 RVA: 0x00006B11 File Offset: 0x00004D11
		internal bool method_0(ConcurrentDictionary<string, string> concurrentDictionary_0)
		{
			return concurrentDictionary_0[Class185.smethod_0(537692633)] == this.jsextInvokeArgs_0.Arguments[1].ToString();
		}

		// Token: 0x040004F3 RID: 1267
		public JSExtInvokeArgs jsextInvokeArgs_0;
	}

	// Token: 0x02000123 RID: 291
	private static class Class194
	{
		// Token: 0x040004F4 RID: 1268
		public static CallSite<Func<CallSite, object, bool>> callSite_0;

		// Token: 0x040004F5 RID: 1269
		public static CallSite<Func<CallSite, object, bool>> callSite_1;

		// Token: 0x040004F6 RID: 1270
		public static CallSite<Action<CallSite, object, string, string>> callSite_2;

		// Token: 0x040004F7 RID: 1271
		public static CallSite<Func<CallSite, object, bool>> callSite_3;
	}

	// Token: 0x02000124 RID: 292
	private static class Class195
	{
		// Token: 0x040004F8 RID: 1272
		public static CallSite<Action<CallSite, Control.ControlCollection, object>> callSite_0;

		// Token: 0x040004F9 RID: 1273
		public static CallSite<Func<CallSite, object, object, object>> callSite_1;

		// Token: 0x040004FA RID: 1274
		public static CallSite<Func<CallSite, object, bool>> callSite_2;

		// Token: 0x040004FB RID: 1275
		public static CallSite<Func<CallSite, object, string>> callSite_3;
	}

	// Token: 0x02000125 RID: 293
	[StructLayout(LayoutKind.Auto)]
	private struct Struct60 : IAsyncStateMachine
	{
		// Token: 0x06000773 RID: 1907 RVA: 0x00047268 File Offset: 0x00045468
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			try
			{
				try
				{
					TaskAwaiter<string> taskAwaiter5;
					TaskAwaiter<Stream> taskAwaiter6;
					if (num != 0)
					{
						if (num == 1)
						{
							taskAwaiter5 = taskAwaiter4;
							taskAwaiter4 = default(TaskAwaiter<string>);
							num2 = -1;
							goto IL_EC;
						}
						GClass3.smethod_0(Class185.smethod_0(537692653), Class185.smethod_0(537692445));
						taskAwaiter6 = Class143.smethod_0(jsextInvokeArgs_0.Arguments.First<object>().ToString()).GetAwaiter();
						if (!taskAwaiter6.IsCompleted)
						{
							num2 = 0;
							taskAwaiter2 = taskAwaiter6;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Stream>, GForm7.Struct60>(ref taskAwaiter6, ref this);
							return;
						}
					}
					else
					{
						taskAwaiter6 = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter<Stream>);
						num2 = -1;
					}
					taskAwaiter5 = Class143.smethod_1(taskAwaiter6.GetResult()).GetAwaiter();
					if (!taskAwaiter5.IsCompleted)
					{
						num2 = 1;
						taskAwaiter4 = taskAwaiter5;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GForm7.Struct60>(ref taskAwaiter5, ref this);
						return;
					}
					IL_EC:
					string result = taskAwaiter5.GetResult();
					GClass3.smethod_0(Class185.smethod_0(537692416) + result, Class185.smethod_0(537692445));
				}
				catch
				{
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

		// Token: 0x06000774 RID: 1908 RVA: 0x00006B3A File Offset: 0x00004D3A
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040004FC RID: 1276
		public int int_0;

		// Token: 0x040004FD RID: 1277
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040004FE RID: 1278
		public JSExtInvokeArgs jsextInvokeArgs_0;

		// Token: 0x040004FF RID: 1279
		private TaskAwaiter<Stream> taskAwaiter_0;

		// Token: 0x04000500 RID: 1280
		private TaskAwaiter<string> taskAwaiter_1;
	}

	// Token: 0x02000126 RID: 294
	private sealed class Class196
	{
		// Token: 0x06000776 RID: 1910 RVA: 0x000473F0 File Offset: 0x000455F0
		internal bool method_0(ConcurrentDictionary<string, string> concurrentDictionary_0)
		{
			return concurrentDictionary_0.ContainsKey(Class185.smethod_0(537692592)) && concurrentDictionary_0[Class185.smethod_0(537692592)] == this.string_0 && concurrentDictionary_0[Class185.smethod_0(537692776)] == Class185.smethod_0(537692590);
		}

		// Token: 0x04000501 RID: 1281
		public string string_0;
	}

	// Token: 0x02000127 RID: 295
	private static class Class197
	{
		// Token: 0x04000502 RID: 1282
		public static CallSite<Action<CallSite, object, string>> callSite_0;
	}

	// Token: 0x02000128 RID: 296
	private static class Class198
	{
		// Token: 0x04000503 RID: 1283
		public static CallSite<Func<CallSite, object, bool>> callSite_0;
	}

	// Token: 0x02000129 RID: 297
	private sealed class Class199
	{
		// Token: 0x06000778 RID: 1912 RVA: 0x00047450 File Offset: 0x00045650
		internal bool method_0(ConcurrentDictionary<string, string> concurrentDictionary_0)
		{
			return concurrentDictionary_0.ContainsKey(Class185.smethod_0(537692592)) && concurrentDictionary_0[Class185.smethod_0(537692592)] == this.string_0 && concurrentDictionary_0[Class185.smethod_0(537692776)] == Class185.smethod_0(537692590);
		}

		// Token: 0x04000504 RID: 1284
		public string string_0;
	}

	// Token: 0x0200012A RID: 298
	private static class Class200
	{
		// Token: 0x04000505 RID: 1285
		public static CallSite<Func<CallSite, object, object>> callSite_0;

		// Token: 0x04000506 RID: 1286
		public static CallSite<Action<CallSite, object, bool>> callSite_1;

		// Token: 0x04000507 RID: 1287
		public static CallSite<Action<CallSite, object>> callSite_2;

		// Token: 0x04000508 RID: 1288
		public static CallSite<Func<CallSite, object, object>> callSite_3;

		// Token: 0x04000509 RID: 1289
		public static CallSite<Func<CallSite, object, Engine>> callSite_4;

		// Token: 0x0400050A RID: 1290
		public static CallSite<Func<CallSite, object, object>> callSite_5;

		// Token: 0x0400050B RID: 1291
		public static CallSite<Action<CallSite, WebView, object>> callSite_6;
	}

	// Token: 0x0200012B RID: 299
	private static class Class201
	{
		// Token: 0x0400050C RID: 1292
		public static CallSite<Func<CallSite, object, object>> callSite_0;

		// Token: 0x0400050D RID: 1293
		public static CallSite<Action<CallSite, object, bool>> callSite_1;

		// Token: 0x0400050E RID: 1294
		public static CallSite<Action<CallSite, object>> callSite_2;
	}

	// Token: 0x0200012C RID: 300
	private sealed class Class202
	{
		// Token: 0x0600077A RID: 1914 RVA: 0x000474B0 File Offset: 0x000456B0
		internal bool method_0(ConcurrentDictionary<string, string> concurrentDictionary_0)
		{
			return concurrentDictionary_0.ContainsKey(Class185.smethod_0(537692592)) && concurrentDictionary_0[Class185.smethod_0(537692592)] == this.string_0 && concurrentDictionary_0[Class185.smethod_0(537692776)] == Class185.smethod_0(537692590);
		}

		// Token: 0x0400050F RID: 1295
		public string string_0;
	}

	// Token: 0x0200012D RID: 301
	private static class Class203
	{
		// Token: 0x04000510 RID: 1296
		public static CallSite<Action<CallSite, object, string>> callSite_0;
	}

	// Token: 0x0200012E RID: 302
	private static class Class204
	{
		// Token: 0x04000511 RID: 1297
		public static CallSite<Func<CallSite, object, object>> callSite_0;

		// Token: 0x04000512 RID: 1298
		public static CallSite<Action<CallSite, object, bool>> callSite_1;

		// Token: 0x04000513 RID: 1299
		public static CallSite<Action<CallSite, object>> callSite_2;
	}

	// Token: 0x0200012F RID: 303
	private sealed class Class205
	{
		// Token: 0x0600077C RID: 1916 RVA: 0x00047510 File Offset: 0x00045710
		internal bool method_0(ConcurrentDictionary<string, string> concurrentDictionary_0)
		{
			return concurrentDictionary_0.ContainsKey(Class185.smethod_0(537692592)) && concurrentDictionary_0[Class185.smethod_0(537692592)] == this.string_0 && concurrentDictionary_0[Class185.smethod_0(537692776)] == Class185.smethod_0(537692590);
		}

		// Token: 0x04000514 RID: 1300
		public string string_0;
	}

	// Token: 0x02000130 RID: 304
	private static class Class206
	{
		// Token: 0x04000515 RID: 1301
		public static CallSite<Action<CallSite, Control.ControlCollection, object>> callSite_0;

		// Token: 0x04000516 RID: 1302
		public static CallSite<Func<CallSite, object, object, object>> callSite_1;

		// Token: 0x04000517 RID: 1303
		public static CallSite<Func<CallSite, object, bool>> callSite_2;

		// Token: 0x04000518 RID: 1304
		public static CallSite<Func<CallSite, object, string>> callSite_3;
	}

	// Token: 0x02000131 RID: 305
	private static class Class207
	{
		// Token: 0x04000519 RID: 1305
		public static CallSite<Func<CallSite, object, object>> callSite_0;

		// Token: 0x0400051A RID: 1306
		public static CallSite<Action<CallSite, object, bool>> callSite_1;

		// Token: 0x0400051B RID: 1307
		public static CallSite<Action<CallSite, object>> callSite_2;
	}

	// Token: 0x02000132 RID: 306
	private static class Class208
	{
		// Token: 0x0400051C RID: 1308
		public static CallSite<Func<CallSite, object, JToken>> callSite_0;
	}

	// Token: 0x02000133 RID: 307
	private static class Class209
	{
		// Token: 0x0400051D RID: 1309
		public static CallSite<Action<CallSite, Control.ControlCollection, object>> callSite_0;

		// Token: 0x0400051E RID: 1310
		public static CallSite<Func<CallSite, object, object, object>> callSite_1;

		// Token: 0x0400051F RID: 1311
		public static CallSite<Func<CallSite, object, bool>> callSite_2;

		// Token: 0x04000520 RID: 1312
		public static CallSite<Func<CallSite, object, string>> callSite_3;
	}

	// Token: 0x02000134 RID: 308
	private static class Class210
	{
		// Token: 0x04000521 RID: 1313
		public static CallSite<Func<CallSite, object, object>> callSite_0;

		// Token: 0x04000522 RID: 1314
		public static CallSite<Action<CallSite, object, bool>> callSite_1;

		// Token: 0x04000523 RID: 1315
		public static CallSite<Action<CallSite, object>> callSite_2;
	}
}
