using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using EO.WebBrowser;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// Token: 0x0200002B RID: 43
public static class GClass1
{
	// Token: 0x0600010D RID: 269 RVA: 0x00003694 File Offset: 0x00001894
	public static string smethod_0(this ScriptCall scriptCall_0)
	{
		scriptCall_0.WaitOne(5000);
		return scriptCall_0.Result.ToString();
	}

	// Token: 0x0600010E RID: 270 RVA: 0x000036AD File Offset: 0x000018AD
	public static JToken smethod_1(this JToken[] jtoken_0)
	{
		return jtoken_0[GForm1.random_0.Next(0, jtoken_0.Length - 1)];
	}

	// Token: 0x0600010F RID: 271 RVA: 0x000036C1 File Offset: 0x000018C1
	public static JToken smethod_2(this IEnumerable<JToken> ienumerable_0)
	{
		if (!ienumerable_0.Any<JToken>())
		{
			return null;
		}
		return ienumerable_0.ToArray<JToken>()[GForm1.random_0.Next(0, ienumerable_0.Count<JToken>())];
	}

	// Token: 0x06000110 RID: 272 RVA: 0x000036E5 File Offset: 0x000018E5
	public static string smethod_3(this string string_0)
	{
		return Regex.Replace(string_0, Class185.smethod_0(537714073), string.Empty);
	}

	// Token: 0x06000111 RID: 273 RVA: 0x000036FC File Offset: 0x000018FC
	public static string smethod_4(this string string_0)
	{
		return HttpUtility.JavaScriptStringEncode(string_0);
	}

	// Token: 0x06000112 RID: 274 RVA: 0x0000E9BC File Offset: 0x0000CBBC
	public static byte[] smethod_5(this Stream stream_0)
	{
		byte[] array = new byte[stream_0.Length];
		byte[] result;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			for (;;)
			{
				int num = stream_0.Read(array, 0, array.Length);
				if (num <= 0)
				{
					break;
				}
				memoryStream.Write(array, 0, num);
			}
			result = memoryStream.ToArray();
		}
		return result;
	}

	// Token: 0x06000113 RID: 275 RVA: 0x0000EA1C File Offset: 0x0000CC1C
	public static string smethod_6(this string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return string_0;
		}
		string oldValue = '\u2028'.ToString();
		string oldValue2 = '\u2029'.ToString();
		return string_0.Replace(Class185.smethod_0(537714049), string.Empty).Replace(Class185.smethod_0(537703659), string.Empty).Replace(Class185.smethod_0(537703651), string.Empty).Replace(oldValue, string.Empty).Replace(oldValue2, string.Empty);
	}

	// Token: 0x06000114 RID: 276 RVA: 0x00003704 File Offset: 0x00001904
	public static bool smethod_7(this string string_0)
	{
		return string_0.Any(new Func<char, bool>(char.IsDigit));
	}

	// Token: 0x06000115 RID: 277 RVA: 0x0000EAA4 File Offset: 0x0000CCA4
	public static string smethod_8(this string string_0, bool bool_0)
	{
		string text;
		if (Class173.jobject_3.ContainsKey(string_0))
		{
			text = Class173.jobject_3[string_0][Class185.smethod_0(537713582)].ToString();
		}
		else
		{
			text = null;
		}
		if (text == Class185.smethod_0(537713625) && bool_0)
		{
			text = Class185.smethod_0(537713618);
		}
		return text;
	}

	// Token: 0x06000116 RID: 278 RVA: 0x0000EB04 File Offset: 0x0000CD04
	public static bool smethod_9(this string string_0)
	{
		string_0 = string_0.Trim();
		if ((string_0.StartsWith(Class185.smethod_0(537714106)) && string_0.EndsWith(Class185.smethod_0(537714098))) || (string_0.StartsWith(Class185.smethod_0(537714090)) && string_0.EndsWith(Class185.smethod_0(537714082))))
		{
			bool result;
			try
			{
				JToken.Parse(string_0);
				result = true;
			}
			catch (JsonReaderException)
			{
				result = false;
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}
		return false;
	}
}
