using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Newtonsoft.Json.Linq;

// Token: 0x02000027 RID: 39
internal static class Class20
{
	// Token: 0x060000F9 RID: 249 RVA: 0x0000E174 File Offset: 0x0000C374
	public static Bitmap smethod_0(int int_0, int int_1, int int_2, int int_3, Bitmap bitmap_0)
	{
		Rectangle srcRect = new Rectangle(int_0, int_1, int_2, int_3);
		Bitmap bitmap = new Bitmap(srcRect.Width, srcRect.Height);
		using (Graphics graphics = Graphics.FromImage(bitmap))
		{
			graphics.DrawImage(bitmap_0, new Rectangle(0, 0, bitmap.Width, bitmap.Height), srcRect, GraphicsUnit.Pixel);
		}
		return bitmap;
	}

	// Token: 0x060000FA RID: 250 RVA: 0x0000E1E4 File Offset: 0x0000C3E4
	public static void smethod_1(Bitmap bitmap_0, int int_0, int int_1, string string_0)
	{
		GClass3.smethod_0(Class185.smethod_0(537704068), Class185.smethod_0(537704074));
		int width = bitmap_0.Width;
		int height = bitmap_0.Height;
		int num = 1;
		JObject jobject = new JObject();
		for (int i = 0; i < height; i += height / int_0)
		{
			for (int j = 0; j < width; j += width / int_1)
			{
				Class20.smethod_3(Class20.smethod_0(j, i, width / int_1, height / int_0, bitmap_0), num, jobject, string_0);
				num++;
			}
		}
		while (jobject.Count != num - 1)
		{
			Thread.Sleep(200);
		}
		GClass3.smethod_0(Class185.smethod_0(537704103), Class185.smethod_0(537704074));
		Console.WriteLine(jobject.ToString());
	}

	// Token: 0x060000FB RID: 251 RVA: 0x0000E29C File Offset: 0x0000C49C
	public static void smethod_2(string string_0)
	{
		try
		{
			HtmlDocument htmlDocument = new HtmlDocument();
			htmlDocument.LoadHtml(string_0);
			string innerText = htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537704168)).InnerText;
			GClass3.smethod_0(Class185.smethod_0(537704167) + innerText, Class185.smethod_0(537704074));
			string text = htmlDocument.DocumentNode.SelectSingleNode(Class185.smethod_0(537703950)).Attributes[Class185.smethod_0(537703994)].Value.Replace(Class185.smethod_0(537703988), string.Empty);
			GClass3.smethod_0(Class185.smethod_0(537703983) + text, Class185.smethod_0(537704074));
			int count = htmlDocument.DocumentNode.SelectNodes(Class185.smethod_0(537704023)).Count;
			GClass3.smethod_0(string.Format(Class185.smethod_0(537704032), count), Class185.smethod_0(537704074));
			int num = htmlDocument.DocumentNode.SelectNodes(Class185.smethod_0(537703950)).Select(new Func<HtmlNode, string>(Class20.Class21.class21_0.method_0)).Distinct<string>().Count<string>();
			GClass3.smethod_0(string.Format(Class185.smethod_0(537703818), num), Class185.smethod_0(537704074));
			int num2 = htmlDocument.DocumentNode.SelectNodes(Class185.smethod_0(537703950)).Select(new Func<HtmlNode, string>(Class20.Class21.class21_0.method_1)).Distinct<string>().Count<string>();
			GClass3.smethod_0(string.Format(Class185.smethod_0(537703858), num2), Class185.smethod_0(537704074));
			WebClient webClient = new WebClient();
			byte[] buffer;
			try
			{
				buffer = webClient.DownloadData(text);
			}
			finally
			{
				((IDisposable)webClient).Dispose();
			}
			MemoryStream memoryStream = new MemoryStream(buffer);
			try
			{
				Class20.smethod_1(new Bitmap(memoryStream), num, num2, innerText);
			}
			finally
			{
				((IDisposable)memoryStream).Dispose();
			}
		}
		catch
		{
			GClass3.smethod_0(Class185.smethod_0(537703901), Class185.smethod_0(537704074));
		}
	}

	// Token: 0x060000FC RID: 252 RVA: 0x000035A1 File Offset: 0x000017A1
	public static void smethod_3(Bitmap bitmap_0, int int_0, JObject jobject_0, string string_0)
	{
		new Task(new Action(new Class20.Class22
		{
			bitmap_0 = bitmap_0,
			jobject_0 = jobject_0,
			int_0 = int_0,
			string_0 = string_0
		}.method_0)).Start();
	}

	// Token: 0x060000FD RID: 253 RVA: 0x0000E510 File Offset: 0x0000C710
	public static JObject smethod_4(Bitmap bitmap_0)
	{
		JObject result2;
		try
		{
			HttpClient httpClient = new HttpClient();
			httpClient.DefaultRequestHeaders.Add(Class185.smethod_0(537703933), string.Empty);
			string requestUri = Class185.smethod_0(537703709);
			ByteArrayContent byteArrayContent = new ByteArrayContent((byte[])new ImageConverter().ConvertTo(bitmap_0, typeof(byte[])));
			HttpResponseMessage result;
			try
			{
				byteArrayContent.Headers.ContentType = new MediaTypeHeaderValue(Class185.smethod_0(537703781));
				result = httpClient.PostAsync(requestUri, byteArrayContent).Result;
			}
			finally
			{
				((IDisposable)byteArrayContent).Dispose();
			}
			result2 = result.smethod_0();
		}
		catch (Exception)
		{
			result2 = new JObject();
		}
		return result2;
	}

	// Token: 0x02000028 RID: 40
	[Serializable]
	private sealed class Class21
	{
		// Token: 0x06000100 RID: 256 RVA: 0x000035E5 File Offset: 0x000017E5
		internal string method_0(HtmlNode htmlNode_0)
		{
			return htmlNode_0.Attributes[Class185.smethod_0(537704228)].Value.Split(new char[]
			{
				';'
			})[0];
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00003613 File Offset: 0x00001813
		internal string method_1(HtmlNode htmlNode_0)
		{
			return htmlNode_0.Attributes[Class185.smethod_0(537704228)].Value.Split(new char[]
			{
				';'
			})[1];
		}

		// Token: 0x0400008F RID: 143
		public static readonly Class20.Class21 class21_0 = new Class20.Class21();

		// Token: 0x04000090 RID: 144
		public static Func<HtmlNode, string> func_0;

		// Token: 0x04000091 RID: 145
		public static Func<HtmlNode, string> func_1;
	}

	// Token: 0x02000029 RID: 41
	private sealed class Class22
	{
		// Token: 0x06000103 RID: 259 RVA: 0x0000E5CC File Offset: 0x0000C7CC
		internal void method_0()
		{
			JObject jobject = Class20.smethod_4(this.bitmap_0);
			try
			{
				this.jobject_0[this.int_0.ToString()] = new JObject();
				JToken jtoken = this.jobject_0[this.int_0.ToString()];
				object key = Class185.smethod_0(537704272);
				bool value;
				if (jobject[Class185.smethod_0(537704268)][Class185.smethod_0(537704318)].Count<JToken>() <= 0)
				{
					value = false;
				}
				else
				{
					IEnumerable<JToken> source = jobject[Class185.smethod_0(537704268)][Class185.smethod_0(537704318)];
					Func<JToken, bool> predicate;
					if ((predicate = this.func_0) == null)
					{
						predicate = (this.func_0 = new Func<JToken, bool>(this.method_1));
					}
					value = (source.Where(predicate).Count<JToken>() > 0);
				}
				jtoken[key] = value;
				this.jobject_0[this.int_0.ToString()][Class185.smethod_0(537704318)] = jobject[Class185.smethod_0(537704268)][Class185.smethod_0(537704318)];
				GClass3.smethod_0(Class185.smethod_0(537704297) + this.int_0, Class185.smethod_0(537704074));
			}
			catch
			{
				Console.WriteLine(jobject);
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00003641 File Offset: 0x00001841
		internal bool method_1(JToken jtoken_0)
		{
			return this.string_0.Contains(jtoken_0.ToString());
		}

		// Token: 0x04000092 RID: 146
		public Bitmap bitmap_0;

		// Token: 0x04000093 RID: 147
		public JObject jobject_0;

		// Token: 0x04000094 RID: 148
		public int int_0;

		// Token: 0x04000095 RID: 149
		public string string_0;

		// Token: 0x04000096 RID: 150
		public Func<JToken, bool> func_0;
	}
}
