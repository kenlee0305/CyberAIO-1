using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Media;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json.Linq;

// Token: 0x0200000D RID: 13
internal sealed class Class4
{
	// Token: 0x06000041 RID: 65 RVA: 0x00008E30 File Offset: 0x00007030
	public Class4(JToken jtoken_2)
	{
		this.jtoken_1 = jtoken_2;
		this.string_2 = jtoken_2[Class185.smethod_0(537700008)].ToString();
		GForm1.dictionary_0[(int)jtoken_2[Class185.smethod_0(537703519)]][Class185.smethod_0(537710986)] = string.Empty;
		this.method_4(Class185.smethod_0(537710911), Class185.smethod_0(537700781), true, false);
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00008EC0 File Offset: 0x000070C0
	public void method_0(string string_3, string string_4, bool bool_2)
	{
		if (bool_2)
		{
			GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537699958), this.jtoken_1[Class185.smethod_0(537703519)]));
		}
		this.method_4(string_3, string_4, true, true);
		this.bool_0 = true;
		Class30.smethod_1((int)this.jtoken_1[Class185.smethod_0(537703519)], null);
		Thread.CurrentThread.Abort();
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00008F3C File Offset: 0x0000713C
	public HttpResponseMessage method_1(string string_3, bool bool_2, JObject jobject_0)
	{
		return Class30.smethod_2(string_3, (int)this.jtoken_1[Class185.smethod_0(537703519)], jobject_0, bool_2);
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00002E8C File Offset: 0x0000108C
	public Task<HttpResponseMessage> method_2(string string_3, bool bool_2, JObject jobject_0)
	{
		Task<HttpResponseMessage> task = new Task<HttpResponseMessage>(new Func<HttpResponseMessage>(new Class4.Class5
		{
			string_0 = string_3,
			class4_0 = this,
			bool_0 = bool_2,
			jobject_0 = jobject_0
		}.method_0));
		task.Start();
		return task;
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00008F70 File Offset: 0x00007170
	public bool method_3(out JToken jtoken_2)
	{
		bool result;
		try
		{
			jtoken_2 = JObject.Parse(GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537710925), this.jtoken_1[Class185.smethod_0(537710947)])).smethod_0());
			this.jtoken_0 = jtoken_2;
			result = true;
		}
		catch
		{
			jtoken_2 = null;
			result = false;
		}
		return result;
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00008FDC File Offset: 0x000071DC
	public void method_4(string string_3, string string_4, bool bool_2, bool bool_3)
	{
		if (Class4.Class7.callSite_6 == null)
		{
			Class4.Class7.callSite_6 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Class4), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
			}));
		}
		Func<CallSite, object, bool> target = Class4.Class7.callSite_6.Target;
		CallSite callSite_ = Class4.Class7.callSite_6;
		bool flag;
		object obj;
		if (flag = GForm1.dictionary_0.ContainsKey((int)this.jtoken_1[Class185.smethod_0(537703519)]))
		{
			if (Class4.Class7.callSite_1 == null)
			{
				Class4.Class7.callSite_1 = CallSite<Func<CallSite, bool, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.BinaryOperationLogical, ExpressionType.And, typeof(Class4), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, bool, object, object> target2 = Class4.Class7.callSite_1.Target;
			CallSite callSite_2 = Class4.Class7.callSite_1;
			bool arg = flag;
			if (Class4.Class7.callSite_0 == null)
			{
				Class4.Class7.callSite_0 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Class4), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			obj = target2(callSite_2, arg, Class4.Class7.callSite_0.Target(Class4.Class7.callSite_0, GForm1.dictionary_0[(int)this.jtoken_1[Class185.smethod_0(537703519)]][Class185.smethod_0(537700087)], false));
		}
		else
		{
			obj = flag;
		}
		object obj2 = obj;
		if (Class4.Class7.callSite_3 == null)
		{
			Class4.Class7.callSite_3 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Class4), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
			}));
		}
		object obj3;
		if (!Class4.Class7.callSite_3.Target(Class4.Class7.callSite_3, obj2))
		{
			if (Class4.Class7.callSite_2 == null)
			{
				Class4.Class7.callSite_2 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.BinaryOperationLogical, ExpressionType.Or, typeof(Class4), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
			}
			obj3 = Class4.Class7.callSite_2.Target(Class4.Class7.callSite_2, obj2, bool_3);
		}
		else
		{
			obj3 = obj2;
		}
		object obj4 = obj3;
		if (Class4.Class7.callSite_5 == null)
		{
			Class4.Class7.callSite_5 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsFalse, typeof(Class4), new CSharpArgumentInfo[]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
			}));
		}
		object arg2;
		if (!Class4.Class7.callSite_5.Target(Class4.Class7.callSite_5, obj4))
		{
			if (Class4.Class7.callSite_4 == null)
			{
				Class4.Class7.callSite_4 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.BinaryOperationLogical, ExpressionType.And, typeof(Class4), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
			}
			arg2 = Class4.Class7.callSite_4.Target(Class4.Class7.callSite_4, obj4, !this.bool_0);
		}
		else
		{
			arg2 = obj4;
		}
		if (target(callSite_, arg2))
		{
			if (bool_2)
			{
				GClass3.smethod_0(string_3, Class185.smethod_0(537710737) + this.jtoken_1[Class185.smethod_0(537703519)]);
			}
			if (string_3.ToLower().Contains(Class185.smethod_0(537710733)))
			{
				string_4 = Class185.smethod_0(537700909);
			}
			if (!this.bool_1)
			{
				GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537710777), string_3, string_4, this.jtoken_1[Class185.smethod_0(537703519)]));
				return;
			}
		}
		else
		{
			Thread.CurrentThread.Abort();
		}
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00002EC5 File Offset: 0x000010C5
	public void method_5(string string_3)
	{
		GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537710814), string_3, this.jtoken_1[Class185.smethod_0(537703519)]));
		this.string_2 = string_3;
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00009320 File Offset: 0x00007520
	public string method_6()
	{
		string result;
		try
		{
			if (this.jtoken_1[Class185.smethod_0(537692535)].ToString() != Class185.smethod_0(537710839))
			{
				result = this.jtoken_1[Class185.smethod_0(537692535)].ToString();
			}
			else
			{
				short num = Convert.ToInt16(GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537710819), this.jtoken_1[Class185.smethod_0(537703519)])).smethod_0());
				JArray jarray_ = GClass0.jarray_0;
				if ((int)num > jarray_.Count<JToken>() - 1)
				{
					GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537710606), this.jtoken_1[Class185.smethod_0(537703519)]));
					result = null;
				}
				else
				{
					string text = jarray_[(int)num][Class185.smethod_0(537692535)].ToString();
					GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537710680), text, this.jtoken_1[Class185.smethod_0(537703519)]));
					result = text;
				}
			}
		}
		catch
		{
			GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537710606), this.jtoken_1[Class185.smethod_0(537703519)]));
			result = null;
		}
		return result;
	}

	// Token: 0x0600004A RID: 74 RVA: 0x0000949C File Offset: 0x0000769C
	public void method_7(string string_3, string string_4 = "#c2c2c2")
	{
		this.jtoken_1[Class185.smethod_0(537710986)] = string_3;
		GForm1.dictionary_0[(int)this.jtoken_1[Class185.smethod_0(537703519)]][Class185.smethod_0(537710986)] = string_3;
		GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537710705), string_3.Replace(Class185.smethod_0(537700459), Class185.smethod_0(537700451)), string_4, this.jtoken_1[Class185.smethod_0(537703519)]));
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00009544 File Offset: 0x00007744
	public void method_8()
	{
		string text = (string)this.jtoken_1[Class185.smethod_0(537712534)];
		if (text == Class185.smethod_0(537710839))
		{
			return;
		}
		int num = (int)new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(Convert.ToDouble(text)).Subtract(DateTime.UtcNow).TotalSeconds;
		if (num > 0)
		{
			this.method_13(num, Class185.smethod_0(537712512), 0);
			return;
		}
	}

	// Token: 0x0600004C RID: 76 RVA: 0x000095CC File Offset: 0x000077CC
	public void method_9(bool bool_2)
	{
		Class4.Class6 @class = new Class4.Class6();
		@class.bool_0 = bool_2;
		@class.class4_0 = this;
		try
		{
			if (GClass0.bool_0)
			{
				MethodInvoker method = new MethodInvoker(@class.method_0);
				GForm1.gform1_0.Invoke(method);
			}
			new Task(new Action(@class.method_1)).Start();
		}
		catch
		{
		}
		try
		{
			Class4.soundPlayer_0.Play();
		}
		catch
		{
		}
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00009654 File Offset: 0x00007854
	public void method_10(bool bool_2)
	{
		try
		{
			if (GClass0.string_1.Contains(Class185.smethod_0(537712574)))
			{
				JObject jobject = new JObject(new JProperty(Class185.smethod_0(537712585), new JObject()));
				jobject[Class185.smethod_0(537712582)] = Class185.smethod_0(537714282);
				jobject[Class185.smethod_0(537712629)] = Class185.smethod_0(537712614);
				JArray jarray = new JArray();
				JObject jobject2 = new JObject();
				jobject2[Class185.smethod_0(537712450)] = (bool_2 ? Class185.smethod_0(537712485) : Class185.smethod_0(537712510));
				jobject2[Class185.smethod_0(537704268)] = DateTime.Now.ToString(Class185.smethod_0(537711032), CultureInfo.InvariantCulture);
				jobject2[Class185.smethod_0(537712259)] = (bool_2 ? 16711680 : 3329330);
				if (this.string_1 != null)
				{
					jobject2[Class185.smethod_0(537712319)] = new JObject();
					jobject2[Class185.smethod_0(537712319)][Class185.smethod_0(537712303)] = (this.string_1.Contains(Class185.smethod_0(537712345)) ? this.string_1.Replace(Class185.smethod_0(537712320), Class185.smethod_0(537711600)) : (Class185.smethod_0(537712340) + this.string_1.Replace(Class185.smethod_0(537712320), Class185.smethod_0(537711600))));
				}
				jobject2[Class185.smethod_0(537712377)] = new JObject();
				jobject2[Class185.smethod_0(537712377)][Class185.smethod_0(537712374)] = Class185.smethod_0(537712353);
				JArray jarray2 = new JArray();
				JObject jobject3 = new JObject();
				jobject3[Class185.smethod_0(537712143)] = Class185.smethod_0(537712186);
				jobject3[Class185.smethod_0(537711408)] = this.jtoken_1[Class185.smethod_0(537710986)].ToString();
				jobject3[Class185.smethod_0(537712168)] = false;
				jarray2.Add(jobject3);
				jobject3 = new JObject();
				jobject3[Class185.smethod_0(537712143)] = Class185.smethod_0(537712165);
				jobject3[Class185.smethod_0(537711408)] = this.jtoken_1[Class185.smethod_0(537700413)].ToString();
				jobject3[Class185.smethod_0(537712168)] = true;
				jarray2.Add(jobject3);
				jobject3 = new JObject();
				jobject3[Class185.smethod_0(537712143)] = Class185.smethod_0(537712209);
				jobject3[Class185.smethod_0(537711408)] = this.string_2;
				jobject3[Class185.smethod_0(537712168)] = true;
				jarray2.Add(jobject3);
				if (this.jtoken_1[Class185.smethod_0(537700413)].ToString() == Class185.smethod_0(537703522))
				{
					jobject3 = new JObject();
					jobject3[Class185.smethod_0(537712143)] = Class185.smethod_0(537712204);
					jobject3[Class185.smethod_0(537711408)] = this.string_0;
					jobject3[Class185.smethod_0(537712168)] = true;
					jarray2.Add(jobject3);
					jobject3 = new JObject();
					jobject3[Class185.smethod_0(537712143)] = Class185.smethod_0(537712248);
					jobject3[Class185.smethod_0(537711408)] = this.jtoken_1[Class185.smethod_0(537692180)][Class185.smethod_0(537712247)].ToString();
					jobject3[Class185.smethod_0(537712168)] = false;
					jarray2.Add(jobject3);
				}
				jobject3 = new JObject();
				jobject3[Class185.smethod_0(537712143)] = Class185.smethod_0(537712230);
				jobject3[Class185.smethod_0(537711408)] = this.jtoken_1[Class185.smethod_0(537710947)].ToString();
				jobject3[Class185.smethod_0(537712168)] = true;
				jarray2.Add(jobject3);
				jobject2[Class185.smethod_0(537712020)] = jarray2;
				jarray.Add(jobject2);
				jobject[Class185.smethod_0(537712585)] = jarray;
				new Class70(null, Class185.smethod_0(537692910), 10, false, true, null, false).method_10(GClass0.string_1, jobject);
			}
		}
		catch
		{
		}
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00009B80 File Offset: 0x00007D80
	public void method_11(bool bool_2)
	{
		try
		{
			if (GClass0.string_1.Contains(Class185.smethod_0(537712574)) || GClass0.string_1.Contains(Class185.smethod_0(537712001)))
			{
				JObject jobject = new JObject(new JProperty(Class185.smethod_0(537712089), new JObject()));
				jobject[Class185.smethod_0(537712582)] = Class185.smethod_0(537714282);
				jobject[Class185.smethod_0(537712075)] = Class185.smethod_0(537712614);
				JArray jarray = new JArray();
				JObject jobject2 = new JObject();
				jobject2[Class185.smethod_0(537712450)] = (bool_2 ? Class185.smethod_0(537712485) : Class185.smethod_0(537712510));
				jobject2[Class185.smethod_0(537712374)] = DateTime.Now.ToString(Class185.smethod_0(537711032), CultureInfo.InvariantCulture);
				jobject2[Class185.smethod_0(537712259)] = (bool_2 ? Class185.smethod_0(537712104) : Class185.smethod_0(537712122));
				if (this.string_1 != null)
				{
					jobject2[Class185.smethod_0(537712102)] = (this.string_1.Contains(Class185.smethod_0(537712345)) ? this.string_1.Replace(Class185.smethod_0(537712320), Class185.smethod_0(537711600)) : (Class185.smethod_0(537712340) + this.string_1.Replace(Class185.smethod_0(537712320), Class185.smethod_0(537711600))));
				}
				jobject2[Class185.smethod_0(537712377)] = Class185.smethod_0(537712353);
				JArray jarray2 = new JArray();
				JObject jobject3 = new JObject();
				jobject3[Class185.smethod_0(537712450)] = Class185.smethod_0(537712186);
				jobject3[Class185.smethod_0(537711408)] = this.jtoken_1[Class185.smethod_0(537710986)].ToString();
				jobject3[Class185.smethod_0(537711894)] = false;
				jarray2.Add(jobject3);
				jobject3 = new JObject();
				jobject3[Class185.smethod_0(537712450)] = Class185.smethod_0(537712165);
				jobject3[Class185.smethod_0(537711408)] = this.jtoken_1[Class185.smethod_0(537700413)].ToString();
				jobject3[Class185.smethod_0(537711894)] = true;
				jarray2.Add(jobject3);
				jobject3 = new JObject();
				jobject3[Class185.smethod_0(537712450)] = Class185.smethod_0(537712209);
				jobject3[Class185.smethod_0(537711408)] = this.string_2;
				jobject3[Class185.smethod_0(537711894)] = true;
				jarray2.Add(jobject3);
				if (this.jtoken_1[Class185.smethod_0(537700413)].ToString() == Class185.smethod_0(537703522))
				{
					jobject3 = new JObject();
					jobject3[Class185.smethod_0(537712450)] = Class185.smethod_0(537712204);
					jobject3[Class185.smethod_0(537711408)] = this.string_0;
					jobject3[Class185.smethod_0(537711894)] = true;
					jarray2.Add(jobject3);
					jobject3 = new JObject();
					jobject3[Class185.smethod_0(537712450)] = Class185.smethod_0(537712248);
					jobject3[Class185.smethod_0(537711408)] = this.jtoken_1[Class185.smethod_0(537692180)][Class185.smethod_0(537712247)].ToString();
					jobject3[Class185.smethod_0(537711894)] = false;
					jarray2.Add(jobject3);
				}
				jobject3 = new JObject();
				jobject3[Class185.smethod_0(537712450)] = Class185.smethod_0(537712230);
				jobject3[Class185.smethod_0(537711408)] = this.jtoken_1[Class185.smethod_0(537710947)].ToString();
				jobject3[Class185.smethod_0(537711894)] = true;
				jarray2.Add(jobject3);
				jobject2[Class185.smethod_0(537712020)] = jarray2;
				jarray.Add(jobject2);
				jobject[Class185.smethod_0(537712089)] = jarray;
				new Class70(null, Class185.smethod_0(537692910), 10, false, true, null, false).method_10(GClass0.string_1.Contains(Class185.smethod_0(537711874)) ? (GClass0.string_1.Replace(Class185.smethod_0(537711920), string.Empty) + Class185.smethod_0(537711920)) : GClass0.string_1, jobject);
			}
		}
		catch
		{
		}
	}

	// Token: 0x0600004F RID: 79 RVA: 0x0000A0C0 File Offset: 0x000082C0
	public void method_12()
	{
		if (object.Equals(true, (bool)this.jtoken_0[Class185.smethod_0(537711917)]))
		{
			foreach (JToken jtoken in JObject.Parse(GForm1.webView_0.QueueScriptCall(Class185.smethod_0(537700382)).smethod_0()).Values())
			{
				if (jtoken[Class185.smethod_0(537710947)].ToString() == this.jtoken_1[Class185.smethod_0(537710947)].ToString() && jtoken[Class185.smethod_0(537700413)].ToString() == this.jtoken_1[Class185.smethod_0(537700413)].ToString() && jtoken[Class185.smethod_0(537703519)].ToString() != this.jtoken_1[Class185.smethod_0(537703519)].ToString())
				{
					if (Class4.Class8.callSite_3 == null)
					{
						Class4.Class8.callSite_3 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Class4), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, bool> target = Class4.Class8.callSite_3.Target;
					CallSite callSite_ = Class4.Class8.callSite_3;
					bool flag;
					object arg2;
					if (flag = GForm1.dictionary_0.ContainsKey((int)jtoken[Class185.smethod_0(537703519)]))
					{
						if (Class4.Class8.callSite_2 == null)
						{
							Class4.Class8.callSite_2 = CallSite<Func<CallSite, bool, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.BinaryOperationLogical, ExpressionType.And, typeof(Class4), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, bool, object, object> target2 = Class4.Class8.callSite_2.Target;
						CallSite callSite_2 = Class4.Class8.callSite_2;
						bool arg = flag;
						if (Class4.Class8.callSite_1 == null)
						{
							Class4.Class8.callSite_1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Class4), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
							}));
						}
						Func<CallSite, object, string, object> target3 = Class4.Class8.callSite_1.Target;
						CallSite callSite_3 = Class4.Class8.callSite_1;
						if (Class4.Class8.callSite_0 == null)
						{
							Class4.Class8.callSite_0 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, Class185.smethod_0(537711952), null, typeof(Class4), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						arg2 = target2(callSite_2, arg, target3(callSite_3, Class4.Class8.callSite_0.Target(Class4.Class8.callSite_0, GForm1.dictionary_0[(int)jtoken[Class185.smethod_0(537703519)]][Class185.smethod_0(537710986)]), this.jtoken_1[Class185.smethod_0(537710986)].ToString()));
					}
					else
					{
						arg2 = flag;
					}
					if (target(callSite_, arg2))
					{
						object arg3 = GForm1.dictionary_0[(int)jtoken[Class185.smethod_0(537703519)]][Class185.smethod_0(537700090)];
						GForm1.dictionary_0[(int)jtoken[Class185.smethod_0(537703519)]][Class185.smethod_0(537700087)] = true;
						GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537700066), jtoken[Class185.smethod_0(537703519)]));
						if (Class4.Class8.callSite_4 == null)
						{
							Class4.Class8.callSite_4 = CallSite<Action<CallSite, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class185.smethod_0(537699894), null, typeof(Class4), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Class4.Class8.callSite_4.Target(Class4.Class8.callSite_4, arg3);
						if (Class4.Class8.callSite_5 == null)
						{
							Class4.Class8.callSite_5 = CallSite<Action<CallSite, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class185.smethod_0(537699874), null, typeof(Class4), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Class4.Class8.callSite_5.Target(Class4.Class8.callSite_5, arg3);
						GForm1.dictionary_0.Remove((int)jtoken[Class185.smethod_0(537703519)]);
						GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537711951), jtoken[Class185.smethod_0(537703519)]));
						GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537699958), jtoken[Class185.smethod_0(537703519)]));
					}
				}
			}
		}
	}

	// Token: 0x06000050 RID: 80 RVA: 0x0000A570 File Offset: 0x00008770
	public void method_13(int int_0, string string_3, int int_1)
	{
		this.stopwatch_0.Restart();
		while ((double)int_0 > this.stopwatch_0.Elapsed.TotalSeconds)
		{
			this.method_4(string_3 + Class185.smethod_0(537711014) + TimeSpan.FromSeconds((double)int_0 - this.stopwatch_0.Elapsed.TotalSeconds).ToString(Class185.smethod_0(537711773)), Class185.smethod_0(537700781), false, false);
			Thread.Sleep(1000);
		}
		this.stopwatch_0.Stop();
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00002EFE File Offset: 0x000010FE
	internal void method_14(string string_3, string string_4 = "#c2c2c2")
	{
		this.method_7(string_3, string_4);
	}

	// Token: 0x04000034 RID: 52
	public static SoundPlayer soundPlayer_0 = new SoundPlayer(Class185.smethod_0(537710885));

	// Token: 0x04000035 RID: 53
	public string string_0;

	// Token: 0x04000036 RID: 54
	public string string_1;

	// Token: 0x04000037 RID: 55
	public bool bool_0;

	// Token: 0x04000038 RID: 56
	private JToken jtoken_0;

	// Token: 0x04000039 RID: 57
	private string string_2;

	// Token: 0x0400003A RID: 58
	private readonly JToken jtoken_1;

	// Token: 0x0400003B RID: 59
	private readonly Stopwatch stopwatch_0 = new Stopwatch();

	// Token: 0x0400003C RID: 60
	public bool bool_1;

	// Token: 0x0200000E RID: 14
	private sealed class Class5
	{
		// Token: 0x06000053 RID: 83 RVA: 0x0000A608 File Offset: 0x00008808
		internal HttpResponseMessage method_0()
		{
			string text = this.string_0;
			int int_ = (int)this.class4_0.jtoken_1[Class185.smethod_0(537703519)];
			bool flag = this.bool_0;
			return Class30.smethod_2(text, int_, this.jobject_0, flag);
		}

		// Token: 0x0400003D RID: 61
		public string string_0;

		// Token: 0x0400003E RID: 62
		public Class4 class4_0;

		// Token: 0x0400003F RID: 63
		public bool bool_0;

		// Token: 0x04000040 RID: 64
		public JObject jobject_0;
	}

	// Token: 0x0200000F RID: 15
	private sealed class Class6
	{
		// Token: 0x06000055 RID: 85 RVA: 0x0000A650 File Offset: 0x00008850
		internal void method_0()
		{
			GForm4.smethod_0(this.bool_0 ? Class185.smethod_0(537711206) : Class185.smethod_0(537711175), (string)this.class4_0.jtoken_1[Class185.smethod_0(537710986)], this.bool_0 ? ((GForm4.GEnum0)1) : ((GForm4.GEnum0)0), true);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000A6AC File Offset: 0x000088AC
		internal void method_1()
		{
			this.class4_0.method_11(this.bool_0);
			string text = DateTime.UtcNow.ToString(Class185.smethod_0(537711032), CultureInfo.InvariantCulture);
			long num = Convert.ToInt64(text.Replace(Class185.smethod_0(537711014), string.Empty).Replace(Class185.smethod_0(537711600), string.Empty).Replace(Class185.smethod_0(537711070), string.Empty).Replace(Class185.smethod_0(537696580), string.Empty)) * 27L;
			Dictionary<string, string> dictionary = Class70.smethod_1();
			dictionary[Class185.smethod_0(537692633)] = num.ToString();
			dictionary[Class185.smethod_0(537711062)] = text;
			dictionary[Class185.smethod_0(537700413)] = this.class4_0.jtoken_1[Class185.smethod_0(537700413)].ToString();
			dictionary[Class185.smethod_0(537710986)] = this.class4_0.jtoken_1[Class185.smethod_0(537710986)].ToString();
			dictionary[Class185.smethod_0(537711046)] = GForm3.string_0;
			dictionary[Class185.smethod_0(537711093)] = this.bool_0.ToString();
			new Class70(null, Class185.smethod_0(537692910), 4, false, false, null, false).method_7(Class185.smethod_0(537711076), dictionary, false);
		}

		// Token: 0x04000041 RID: 65
		public bool bool_0;

		// Token: 0x04000042 RID: 66
		public Class4 class4_0;
	}

	// Token: 0x02000010 RID: 16
	private static class Class7
	{
		// Token: 0x04000043 RID: 67
		public static CallSite<Func<CallSite, object, bool, object>> callSite_0;

		// Token: 0x04000044 RID: 68
		public static CallSite<Func<CallSite, bool, object, object>> callSite_1;

		// Token: 0x04000045 RID: 69
		public static CallSite<Func<CallSite, object, bool, object>> callSite_2;

		// Token: 0x04000046 RID: 70
		public static CallSite<Func<CallSite, object, bool>> callSite_3;

		// Token: 0x04000047 RID: 71
		public static CallSite<Func<CallSite, object, bool, object>> callSite_4;

		// Token: 0x04000048 RID: 72
		public static CallSite<Func<CallSite, object, bool>> callSite_5;

		// Token: 0x04000049 RID: 73
		public static CallSite<Func<CallSite, object, bool>> callSite_6;
	}

	// Token: 0x02000011 RID: 17
	private static class Class8
	{
		// Token: 0x0400004A RID: 74
		public static CallSite<Func<CallSite, object, object>> callSite_0;

		// Token: 0x0400004B RID: 75
		public static CallSite<Func<CallSite, object, string, object>> callSite_1;

		// Token: 0x0400004C RID: 76
		public static CallSite<Func<CallSite, bool, object, object>> callSite_2;

		// Token: 0x0400004D RID: 77
		public static CallSite<Func<CallSite, object, bool>> callSite_3;

		// Token: 0x0400004E RID: 78
		public static CallSite<Action<CallSite, object>> callSite_4;

		// Token: 0x0400004F RID: 79
		public static CallSite<Action<CallSite, object>> callSite_5;
	}
}
