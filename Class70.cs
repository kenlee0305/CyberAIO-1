using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Newtonsoft.Json.Linq;

// Token: 0x0200007B RID: 123
internal sealed class Class70
{
	// Token: 0x060002BF RID: 703 RVA: 0x000194DC File Offset: 0x000176DC
	public Class70(string string_0 = null, string string_1 = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/66.0.3359.181 Safari/537.36", int int_0 = 10, bool bool_1 = false, bool bool_2 = false, JObject jobject_0 = null, bool bool_3 = false)
	{
		this.bool_0 = bool_1;
		this.cookieContainer_0 = new CookieContainer();
		WebRequestHandler webRequestHandler = new WebRequestHandler
		{
			UseCookies = true,
			CookieContainer = this.cookieContainer_0,
			AllowAutoRedirect = bool_3,
			Proxy = Class70.smethod_0(string_0),
			PreAuthenticate = true,
			AutomaticDecompression = (DecompressionMethods.GZip | DecompressionMethods.Deflate),
			ClientCertificateOptions = ClientCertificateOption.Manual
		};
		if (!bool_2)
		{
			webRequestHandler.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(this.method_0);
		}
		this.httpClient_0 = new HttpClient(webRequestHandler)
		{
			Timeout = TimeSpan.FromSeconds((double)int_0)
		};
		this.httpClient_0.DefaultRequestHeaders.TryAddWithoutValidation(Class185.smethod_0(537713963), string_1);
		this.httpClient_0.DefaultRequestHeaders.TryAddWithoutValidation(Class185.smethod_0(537714012), Class185.smethod_0(537713986));
		this.httpClient_0.DefaultRequestHeaders.TryAddWithoutValidation(Class185.smethod_0(537714038), Class185.smethod_0(537713814));
		this.httpClient_0.DefaultRequestHeaders.TryAddWithoutValidation(Class185.smethod_0(537713806), Class185.smethod_0(537713844));
		this.httpClient_0.DefaultRequestHeaders.TryAddWithoutValidation(Class185.smethod_0(537713877), Class185.smethod_0(537713862));
		if (jobject_0 != null)
		{
			foreach (KeyValuePair<string, JToken> keyValuePair in jobject_0)
			{
				this.httpClient_0.DefaultRequestHeaders.TryAddWithoutValidation(keyValuePair.Key, (string)keyValuePair.Value);
			}
		}
	}

	// Token: 0x060002C0 RID: 704 RVA: 0x00019684 File Offset: 0x00017884
	public bool method_0(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
	{
		string host = ((HttpWebRequest)object_0).Host;
		string certHashString = x509Certificate_0.GetCertHashString();
		if (Debugger.IsAttached)
		{
			return true;
		}
		if (Class173.string_2.ToUpper().Contains(certHashString.ToUpper()))
		{
			return true;
		}
		if (this.bool_0)
		{
			return x509Certificate_0.Issuer.Contains(Class185.smethod_0(537713911)) || x509Certificate_0.Issuer.Contains(Class185.smethod_0(537713672));
		}
		if (host.Contains(Class185.smethod_0(537692180)))
		{
			return true;
		}
		GClass3.smethod_0(certHashString, Class185.smethod_0(537713701));
		return host.Replace(Class185.smethod_0(537700393), string.Empty) == Class185.smethod_0(537713759) && x509Certificate_0.Issuer == Class185.smethod_0(537713784);
	}

	// Token: 0x060002C1 RID: 705 RVA: 0x00019768 File Offset: 0x00017968
	private static WebProxy smethod_0(string string_0)
	{
		WebProxy result;
		try
		{
			WebProxy webProxy = Debugger.IsAttached ? null : new WebProxy();
			if (string_0 == null)
			{
				result = webProxy;
			}
			else
			{
				string[] array = string_0.Split(new char[]
				{
					':'
				});
				if (array.Length == 4)
				{
					string address = string.Format(Class185.smethod_0(537711536), array[0], array[1]);
					NetworkCredential credentials = new NetworkCredential(array[2], array[3]);
					webProxy = new WebProxy(address, false)
					{
						UseDefaultCredentials = false,
						Credentials = credentials
					};
					result = webProxy;
				}
				else
				{
					result = ((array.Length == 2) ? new WebProxy(string.Format(Class185.smethod_0(537711525), array[0], array[1]), false) : webProxy);
				}
			}
		}
		catch
		{
			result = new WebProxy();
		}
		return result;
	}

	// Token: 0x060002C2 RID: 706 RVA: 0x00019824 File Offset: 0x00017A24
	private HttpResponseMessage method_1(string string_0, HttpResponseMessage httpResponseMessage_0)
	{
		while (httpResponseMessage_0.StatusCode >= HttpStatusCode.MultipleChoices && httpResponseMessage_0.StatusCode <= (HttpStatusCode)399)
		{
			Uri uri = httpResponseMessage_0.Headers.Location;
			if (!uri.IsAbsoluteUri)
			{
				uri = new Uri(new Uri(string_0).GetLeftPart(UriPartial.Authority) + uri);
			}
			httpResponseMessage_0 = this.httpClient_0.GetAsync(uri).Result;
		}
		return httpResponseMessage_0;
	}

	// Token: 0x060002C3 RID: 707 RVA: 0x00019890 File Offset: 0x00017A90
	private async Task<HttpResponseMessage> method_2(string string_0, HttpResponseMessage httpResponseMessage_0)
	{
		while (httpResponseMessage_0.StatusCode >= HttpStatusCode.MultipleChoices && httpResponseMessage_0.StatusCode <= (HttpStatusCode)399)
		{
			Uri uri = httpResponseMessage_0.Headers.Location;
			if (!uri.IsAbsoluteUri)
			{
				uri = new Uri(new Uri(string_0).GetLeftPart(UriPartial.Authority) + uri);
			}
			TaskAwaiter<HttpResponseMessage> taskAwaiter = this.httpClient_0.GetAsync(uri).GetAwaiter();
			if (!taskAwaiter.IsCompleted)
			{
				await taskAwaiter;
				TaskAwaiter<HttpResponseMessage> taskAwaiter2;
				taskAwaiter = taskAwaiter2;
				taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
			}
			httpResponseMessage_0 = taskAwaiter.GetResult();
		}
		return httpResponseMessage_0;
	}

	// Token: 0x060002C4 RID: 708 RVA: 0x000198E8 File Offset: 0x00017AE8
	private bool method_3(string string_0, string string_1)
	{
		bool result;
		try
		{
			if (string_0.Contains(Class185.smethod_0(537711571)))
			{
				Uri uri = new Uri(string_1);
				string_1 = uri.Scheme + Class185.smethod_0(537711558) + uri.Authority + Class185.smethod_0(537711600);
				HtmlDocument htmlDocument = new HtmlDocument();
				htmlDocument.LoadHtml(string_0);
				string innerHtml = htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537711592)).InnerHtml;
				string value = htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537711376)).Attributes[Class185.smethod_0(537711408)].Value;
				string value2 = htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537711404)).Attributes[Class185.smethod_0(537711408)].Value;
				string_0.Split(new string[]
				{
					Class185.smethod_0(537711432)
				}, StringSplitOptions.None)[1].Split(new string[]
				{
					Class185.smethod_0(537711477)
				}, StringSplitOptions.None)[0] + string_0.Split(new string[]
				{
					Class185.smethod_0(537711256)
				}, StringSplitOptions.None)[1].Split(new string[]
				{
					Class185.smethod_0(537711234)
				}, StringSplitOptions.None)[0].Replace(Class185.smethod_0(537711282), string.Empty) + new Uri(string_1).Host.Length;
				string empty = string.Empty;
				string string_2 = string.Format(string_1 + Class185.smethod_0(537711267), value, value2, empty);
				Thread.Sleep(6000);
				this.method_5(string_2, false);
				result = true;
			}
			else
			{
				result = false;
			}
		}
		catch
		{
			throw new Exception();
		}
		return result;
	}

	// Token: 0x060002C5 RID: 709 RVA: 0x00019ABC File Offset: 0x00017CBC
	private void method_4(string string_0, string string_1)
	{
		this.httpClient_0.DefaultRequestHeaders.Remove(Class185.smethod_0(537711332));
		if (string_0.Contains(Class185.smethod_0(537700113)))
		{
			this.httpClient_0.DefaultRequestHeaders.TryAddWithoutValidation(Class185.smethod_0(537711332), Class13.smethod_0(string_0, string_1));
			return;
		}
		if (string_0.Contains(Class185.smethod_0(537700185)))
		{
			this.httpClient_0.DefaultRequestHeaders.TryAddWithoutValidation(Class185.smethod_0(537711332), Class13.smethod_1(string_0, string_1));
		}
	}

	// Token: 0x060002C6 RID: 710 RVA: 0x00019B50 File Offset: 0x00017D50
	public HttpResponseMessage method_5(string string_0, bool bool_1)
	{
		HttpResponseMessage result;
		for (;;)
		{
			this.method_4(string_0, Class185.smethod_0(537713926));
			result = this.httpClient_0.GetAsync(string_0).Result;
			if (!result.smethod_5())
			{
				break;
			}
			this.method_3(result.smethod_3(), string_0);
		}
		if (!bool_1)
		{
			return result;
		}
		return this.method_1(string_0, result);
	}

	// Token: 0x060002C7 RID: 711 RVA: 0x00019BA8 File Offset: 0x00017DA8
	public async Task<HttpResponseMessage> method_6(string string_0, bool bool_1)
	{
		this.method_4(string_0, Class185.smethod_0(537713926));
		HttpResponseMessage result;
		if (bool_1)
		{
			string string_ = string_0;
			TaskAwaiter<HttpResponseMessage> taskAwaiter = this.httpClient_0.GetAsync(string_0).GetAwaiter();
			if (!taskAwaiter.IsCompleted)
			{
				await taskAwaiter;
				TaskAwaiter<HttpResponseMessage> taskAwaiter2;
				taskAwaiter = taskAwaiter2;
				taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
			}
			result = await this.method_2(string_, taskAwaiter.GetResult());
			string_ = null;
		}
		else
		{
			TaskAwaiter<HttpResponseMessage> taskAwaiter = this.httpClient_0.GetAsync(string_0).GetAwaiter();
			if (!taskAwaiter.IsCompleted)
			{
				await taskAwaiter;
				TaskAwaiter<HttpResponseMessage> taskAwaiter2;
				taskAwaiter = taskAwaiter2;
				taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
			}
			result = taskAwaiter.GetResult();
		}
		return result;
	}

	// Token: 0x060002C8 RID: 712 RVA: 0x00019C00 File Offset: 0x00017E00
	public HttpResponseMessage method_7(string string_0, Dictionary<string, string> dictionary_0, bool bool_1)
	{
		HttpResponseMessage result;
		for (;;)
		{
			this.method_4(string_0, Class185.smethod_0(537713968));
			result = this.httpClient_0.PostAsync(string_0, Class70.smethod_2(dictionary_0)).Result;
			if (!result.smethod_5())
			{
				break;
			}
			this.method_3(result.smethod_3(), string_0);
		}
		if (!bool_1)
		{
			return result;
		}
		return this.method_1(string_0, result);
	}

	// Token: 0x060002C9 RID: 713 RVA: 0x00019C5C File Offset: 0x00017E5C
	public async Task<HttpResponseMessage> method_8(string string_0, Dictionary<string, string> dictionary_0, bool bool_1)
	{
		this.method_4(string_0, Class185.smethod_0(537713968));
		HttpResponseMessage result;
		if (bool_1)
		{
			string string_ = string_0;
			TaskAwaiter<HttpResponseMessage> taskAwaiter = this.httpClient_0.PostAsync(string_0, Class70.smethod_2(dictionary_0)).GetAwaiter();
			if (!taskAwaiter.IsCompleted)
			{
				await taskAwaiter;
				TaskAwaiter<HttpResponseMessage> taskAwaiter2;
				taskAwaiter = taskAwaiter2;
				taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
			}
			result = await this.method_2(string_, taskAwaiter.GetResult());
			string_ = null;
		}
		else
		{
			TaskAwaiter<HttpResponseMessage> taskAwaiter = this.httpClient_0.PostAsync(string_0, Class70.smethod_2(dictionary_0)).GetAwaiter();
			if (!taskAwaiter.IsCompleted)
			{
				await taskAwaiter;
				TaskAwaiter<HttpResponseMessage> taskAwaiter2;
				taskAwaiter = taskAwaiter2;
				taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
			}
			result = taskAwaiter.GetResult();
		}
		return result;
	}

	// Token: 0x060002CA RID: 714 RVA: 0x00019CBC File Offset: 0x00017EBC
	public HttpResponseMessage method_9(string string_0, JObject jobject_0, bool bool_1)
	{
		HttpResponseMessage result;
		for (;;)
		{
			this.method_4(string_0, Class185.smethod_0(537713968));
			result = this.httpClient_0.PostAsync(string_0, new StringContent(jobject_0.ToString(), Encoding.UTF8, Class185.smethod_0(537696162))).Result;
			if (!result.smethod_5())
			{
				break;
			}
			this.method_3(result.smethod_3(), string_0);
		}
		if (!bool_1)
		{
			return result;
		}
		return this.method_1(string_0, result);
	}

	// Token: 0x060002CB RID: 715 RVA: 0x00004681 File Offset: 0x00002881
	public Task<HttpResponseMessage> method_10(string string_0, JObject jobject_0)
	{
		this.method_4(string_0, Class185.smethod_0(537713968));
		return this.httpClient_0.PostAsync(string_0, new StringContent(jobject_0.ToString(), Encoding.UTF8, Class185.smethod_0(537696162)));
	}

	// Token: 0x060002CC RID: 716 RVA: 0x00019D2C File Offset: 0x00017F2C
	public HttpResponseMessage method_11(string string_0, Dictionary<string, string> dictionary_0, bool bool_1)
	{
		HttpResponseMessage result;
		for (;;)
		{
			this.method_4(string_0, Class185.smethod_0(537713968));
			HttpRequestMessage request = new HttpRequestMessage
			{
				Method = new HttpMethod(Class185.smethod_0(537711113)),
				RequestUri = new Uri(string_0),
				Content = Class70.smethod_2(dictionary_0)
			};
			result = this.httpClient_0.SendAsync(request).Result;
			if (!result.smethod_5())
			{
				break;
			}
			this.method_3(result.smethod_3(), string_0);
		}
		if (!bool_1)
		{
			return result;
		}
		return this.method_1(string_0, result);
	}

	// Token: 0x060002CD RID: 717 RVA: 0x00019DB4 File Offset: 0x00017FB4
	public HttpResponseMessage method_12(string string_0, JObject jobject_0, bool bool_1)
	{
		HttpResponseMessage result;
		for (;;)
		{
			this.method_4(string_0, Class185.smethod_0(537711113));
			HttpRequestMessage request = new HttpRequestMessage
			{
				Method = new HttpMethod(Class185.smethod_0(537711113)),
				RequestUri = new Uri(string_0),
				Content = new StringContent(jobject_0.ToString(), Encoding.UTF8, Class185.smethod_0(537696162))
			};
			result = this.httpClient_0.SendAsync(request).Result;
			if (!result.smethod_5())
			{
				break;
			}
			this.method_3(result.smethod_3(), string_0);
		}
		if (!bool_1)
		{
			return result;
		}
		return this.method_1(string_0, result);
	}

	// Token: 0x060002CE RID: 718 RVA: 0x00019E54 File Offset: 0x00018054
	public Task<HttpResponseMessage> method_13(string string_0, JObject jobject_0, bool bool_1)
	{
		this.method_4(string_0, Class185.smethod_0(537711113));
		HttpRequestMessage request = new HttpRequestMessage
		{
			Method = new HttpMethod(Class185.smethod_0(537711113)),
			RequestUri = new Uri(string_0),
			Content = new StringContent(jobject_0.ToString(), Encoding.UTF8, Class185.smethod_0(537696162))
		};
		return this.httpClient_0.SendAsync(request);
	}

	// Token: 0x060002CF RID: 719 RVA: 0x00019EC8 File Offset: 0x000180C8
	public Task<HttpResponseMessage> method_14(string string_0, Dictionary<string, string> dictionary_0, bool bool_1)
	{
		this.method_4(string_0, Class185.smethod_0(537711113));
		HttpRequestMessage request = new HttpRequestMessage
		{
			Method = new HttpMethod(Class185.smethod_0(537711113)),
			RequestUri = new Uri(string_0),
			Content = Class70.smethod_2(dictionary_0)
		};
		return this.httpClient_0.SendAsync(request);
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x00019F28 File Offset: 0x00018128
	public HttpResponseMessage method_15(string string_0, Dictionary<string, string> dictionary_0, bool bool_1)
	{
		HttpResponseMessage result;
		for (;;)
		{
			this.method_4(string_0, Class185.smethod_0(537711109));
			result = this.httpClient_0.PutAsync(string_0, Class70.smethod_2(dictionary_0)).Result;
			if (!result.smethod_5())
			{
				break;
			}
			this.method_3(result.smethod_3(), string_0);
		}
		if (!bool_1)
		{
			return result;
		}
		return this.method_1(string_0, result);
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x00019F84 File Offset: 0x00018184
	public HttpResponseMessage method_16(string string_0, JObject jobject_0, bool bool_1)
	{
		HttpResponseMessage result;
		for (;;)
		{
			this.method_4(string_0, Class185.smethod_0(537711109));
			result = this.httpClient_0.PutAsync(string_0, new StringContent(jobject_0.ToString(), Encoding.UTF8, Class185.smethod_0(537696162))).Result;
			if (!result.smethod_5())
			{
				break;
			}
			this.method_3(result.smethod_3(), string_0);
		}
		if (!bool_1)
		{
			return result;
		}
		return this.method_1(string_0, result);
	}

	// Token: 0x060002D2 RID: 722 RVA: 0x000046BA File Offset: 0x000028BA
	public Task<HttpResponseMessage> method_17(string string_0, Dictionary<string, string> dictionary_0, bool bool_1)
	{
		this.method_4(string_0, Class185.smethod_0(537711109));
		return this.httpClient_0.PutAsync(string_0, Class70.smethod_2(dictionary_0));
	}

	// Token: 0x060002D3 RID: 723 RVA: 0x000046DF File Offset: 0x000028DF
	public Task<HttpResponseMessage> method_18(string string_0, JObject jobject_0, bool bool_1)
	{
		this.method_4(string_0, Class185.smethod_0(537711109));
		return this.httpClient_0.PutAsync(string_0, new StringContent(jobject_0.ToString(), Encoding.UTF8, Class185.smethod_0(537696162)));
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x00004718 File Offset: 0x00002918
	public static Dictionary<string, string> smethod_1()
	{
		return new Dictionary<string, string>();
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x00019FF4 File Offset: 0x000181F4
	public static FormUrlEncodedContent smethod_2(Dictionary<string, string> dictionary_0)
	{
		List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
		foreach (KeyValuePair<string, string> keyValuePair in dictionary_0)
		{
			list.Add(new KeyValuePair<string, string>(keyValuePair.Key, keyValuePair.Value));
		}
		return new FormUrlEncodedContent(list);
	}

	// Token: 0x04000171 RID: 369
	public CookieContainer cookieContainer_0;

	// Token: 0x04000172 RID: 370
	public HttpClient httpClient_0;

	// Token: 0x04000173 RID: 371
	private bool bool_0;

	// Token: 0x0200007C RID: 124
	[StructLayout(LayoutKind.Auto)]
	private struct Struct18 : IAsyncStateMachine
	{
		// Token: 0x060002D6 RID: 726 RVA: 0x0001A064 File Offset: 0x00018264
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			Class70 @class = this;
			HttpResponseMessage result3;
			try
			{
				TaskAwaiter<HttpResponseMessage> taskAwaiter3;
				switch (num)
				{
				case 0:
					taskAwaiter3 = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
					num2 = -1;
					break;
				case 1:
					taskAwaiter3 = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
					num2 = -1;
					goto IL_157;
				case 2:
					taskAwaiter3 = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
					num2 = -1;
					goto IL_184;
				default:
					@class.method_4(string_0, Class185.smethod_0(537713926));
					if (bool_1)
					{
						string_ = string_0;
						taskAwaiter3 = @class.httpClient_0.GetAsync(string_0).GetAwaiter();
						if (!taskAwaiter3.IsCompleted)
						{
							num2 = 0;
							taskAwaiter2 = taskAwaiter3;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class70.Struct18>(ref taskAwaiter3, ref this);
							return;
						}
					}
					else
					{
						taskAwaiter3 = @class.httpClient_0.GetAsync(string_0).GetAwaiter();
						if (!taskAwaiter3.IsCompleted)
						{
							num2 = 2;
							taskAwaiter2 = taskAwaiter3;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class70.Struct18>(ref taskAwaiter3, ref this);
							return;
						}
						goto IL_184;
					}
					break;
				}
				HttpResponseMessage result = taskAwaiter3.GetResult();
				taskAwaiter3 = @class.method_2(string_, result).GetAwaiter();
				if (!taskAwaiter3.IsCompleted)
				{
					num2 = 1;
					taskAwaiter2 = taskAwaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class70.Struct18>(ref taskAwaiter3, ref this);
					return;
				}
				IL_157:
				HttpResponseMessage result2 = taskAwaiter3.GetResult();
				string_ = null;
				goto IL_18C;
				IL_184:
				result2 = taskAwaiter3.GetResult();
				IL_18C:
				result3 = result2;
			}
			catch (Exception exception)
			{
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			num2 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result3);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000471F File Offset: 0x0000291F
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000174 RID: 372
		public int int_0;

		// Token: 0x04000175 RID: 373
		public AsyncTaskMethodBuilder<HttpResponseMessage> asyncTaskMethodBuilder_0;

		// Token: 0x04000176 RID: 374
		public Class70 class70_0;

		// Token: 0x04000177 RID: 375
		public string string_0;

		// Token: 0x04000178 RID: 376
		public bool bool_0;

		// Token: 0x04000179 RID: 377
		private string string_1;

		// Token: 0x0400017A RID: 378
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;
	}

	// Token: 0x0200007D RID: 125
	[StructLayout(LayoutKind.Auto)]
	private struct Struct19 : IAsyncStateMachine
	{
		// Token: 0x060002D8 RID: 728 RVA: 0x0001A24C File Offset: 0x0001844C
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			Class70 @class = this;
			HttpResponseMessage result3;
			try
			{
				TaskAwaiter<HttpResponseMessage> taskAwaiter3;
				switch (num)
				{
				case 0:
					taskAwaiter3 = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
					num2 = -1;
					break;
				case 1:
					taskAwaiter3 = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
					num2 = -1;
					goto IL_16D;
				case 2:
					taskAwaiter3 = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
					num2 = -1;
					goto IL_19A;
				default:
					@class.method_4(string_0, Class185.smethod_0(537713968));
					if (bool_1)
					{
						string_ = string_0;
						taskAwaiter3 = @class.httpClient_0.PostAsync(string_0, Class70.smethod_2(dictionary_0)).GetAwaiter();
						if (!taskAwaiter3.IsCompleted)
						{
							num2 = 0;
							taskAwaiter2 = taskAwaiter3;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class70.Struct19>(ref taskAwaiter3, ref this);
							return;
						}
					}
					else
					{
						taskAwaiter3 = @class.httpClient_0.PostAsync(string_0, Class70.smethod_2(dictionary_0)).GetAwaiter();
						if (!taskAwaiter3.IsCompleted)
						{
							num2 = 2;
							taskAwaiter2 = taskAwaiter3;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class70.Struct19>(ref taskAwaiter3, ref this);
							return;
						}
						goto IL_19A;
					}
					break;
				}
				HttpResponseMessage result = taskAwaiter3.GetResult();
				taskAwaiter3 = @class.method_2(string_, result).GetAwaiter();
				if (!taskAwaiter3.IsCompleted)
				{
					num2 = 1;
					taskAwaiter2 = taskAwaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class70.Struct19>(ref taskAwaiter3, ref this);
					return;
				}
				IL_16D:
				HttpResponseMessage result2 = taskAwaiter3.GetResult();
				string_ = null;
				goto IL_1A2;
				IL_19A:
				result2 = taskAwaiter3.GetResult();
				IL_1A2:
				result3 = result2;
			}
			catch (Exception exception)
			{
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			num2 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result3);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000472D File Offset: 0x0000292D
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400017B RID: 379
		public int int_0;

		// Token: 0x0400017C RID: 380
		public AsyncTaskMethodBuilder<HttpResponseMessage> asyncTaskMethodBuilder_0;

		// Token: 0x0400017D RID: 381
		public Class70 class70_0;

		// Token: 0x0400017E RID: 382
		public string string_0;

		// Token: 0x0400017F RID: 383
		public bool bool_0;

		// Token: 0x04000180 RID: 384
		public Dictionary<string, string> dictionary_0;

		// Token: 0x04000181 RID: 385
		private string string_1;

		// Token: 0x04000182 RID: 386
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;
	}

	// Token: 0x0200007E RID: 126
	[StructLayout(LayoutKind.Auto)]
	private struct Struct20 : IAsyncStateMachine
	{
		// Token: 0x060002DA RID: 730 RVA: 0x0001A44C File Offset: 0x0001864C
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			Class70 @class = this;
			HttpResponseMessage result;
			try
			{
				TaskAwaiter<HttpResponseMessage> taskAwaiter3;
				if (num == 0)
				{
					taskAwaiter3 = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
					num2 = -1;
					goto IL_AA;
				}
				IL_2F:
				if (httpResponseMessage_0.StatusCode < HttpStatusCode.MultipleChoices || httpResponseMessage_0.StatusCode > (HttpStatusCode)399)
				{
					result = httpResponseMessage_0;
					goto IL_103;
				}
				Uri uri = httpResponseMessage_0.Headers.Location;
				if (!uri.IsAbsoluteUri)
				{
					uri = new Uri(new Uri(string_0).GetLeftPart(UriPartial.Authority) + uri);
				}
				taskAwaiter3 = @class.httpClient_0.GetAsync(uri).GetAwaiter();
				if (!taskAwaiter3.IsCompleted)
				{
					num2 = 0;
					taskAwaiter2 = taskAwaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class70.Struct20>(ref taskAwaiter3, ref this);
					return;
				}
				IL_AA:
				HttpResponseMessage result2 = taskAwaiter3.GetResult();
				httpResponseMessage_0 = result2;
				goto IL_2F;
			}
			catch (Exception exception)
			{
				num2 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_103:
			num2 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000473B File Offset: 0x0000293B
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000183 RID: 387
		public int int_0;

		// Token: 0x04000184 RID: 388
		public AsyncTaskMethodBuilder<HttpResponseMessage> asyncTaskMethodBuilder_0;

		// Token: 0x04000185 RID: 389
		public HttpResponseMessage httpResponseMessage_0;

		// Token: 0x04000186 RID: 390
		public string string_0;

		// Token: 0x04000187 RID: 391
		public Class70 class70_0;

		// Token: 0x04000188 RID: 392
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;
	}
}
