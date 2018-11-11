using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000053 RID: 83
public static class GClass2
{
	// Token: 0x060001CB RID: 459 RVA: 0x00012ADC File Offset: 0x00010CDC
	public static bool smethod_0(this string string_0)
	{
		foreach (char c in string_0)
		{
			if (c < '0' || c > '9')
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060001CC RID: 460 RVA: 0x00012B14 File Offset: 0x00010D14
	public static string smethod_1()
	{
		List<double> list = new List<double>();
		for (double num = 4.5; num < 14.0; num += 0.5)
		{
			list.Add(num);
		}
		return list[GForm1.random_0.Next(0, list.Count)].ToString();
	}

	// Token: 0x060001CD RID: 461 RVA: 0x00003C66 File Offset: 0x00001E66
	public static string smethod_2(int int_0)
	{
		return new string(Enumerable.Repeat<string>(Class185.smethod_0(537714138), int_0).Select(new Func<string, char>(GClass2.Class50.class50_0.method_0)).ToArray<char>());
	}

	// Token: 0x02000054 RID: 84
	[Serializable]
	private sealed class Class50
	{
		// Token: 0x060001D0 RID: 464 RVA: 0x00003CB2 File Offset: 0x00001EB2
		internal char method_0(string string_0)
		{
			return string_0[GForm1.random_0.Next(string_0.Length)];
		}

		// Token: 0x040000E3 RID: 227
		public static readonly GClass2.Class50 class50_0 = new GClass2.Class50();

		// Token: 0x040000E4 RID: 228
		public static Func<string, char> func_0;
	}
}
