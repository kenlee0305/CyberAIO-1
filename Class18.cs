using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x02000024 RID: 36
internal sealed class Class18<T, U>
{
	// Token: 0x060000E8 RID: 232 RVA: 0x000034C0 File Offset: 0x000016C0
	[DebuggerHidden]
	public Class18(T gparam_2, U gparam_3)
	{
		this.gparam_0 = gparam_2;
		this.gparam_1 = gparam_3;
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x000034D6 File Offset: 0x000016D6
	public T method_0()
	{
		return this.gparam_0;
	}

	// Token: 0x060000EA RID: 234 RVA: 0x000034DE File Offset: 0x000016DE
	public U method_1()
	{
		return this.gparam_1;
	}

	// Token: 0x060000EB RID: 235 RVA: 0x0000DE30 File Offset: 0x0000C030
	[DebuggerHidden]
	public override bool Equals(object obj)
	{
		Class18<T, U> @class = obj as Class18<T, U>;
		return @class != null && EqualityComparer<T>.Default.Equals(this.gparam_0, @class.gparam_0) && EqualityComparer<U>.Default.Equals(this.gparam_1, @class.gparam_1);
	}

	// Token: 0x060000EC RID: 236 RVA: 0x000034E6 File Offset: 0x000016E6
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (-111245096 + EqualityComparer<T>.Default.GetHashCode(this.gparam_0)) * -1521134295 + EqualityComparer<U>.Default.GetHashCode(this.gparam_1);
	}

	// Token: 0x060000ED RID: 237 RVA: 0x0000DE78 File Offset: 0x0000C078
	[DebuggerHidden]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = Class185.smethod_0(537697180);
		object[] array = new object[2];
		int num = 0;
		T t = this.gparam_0;
		ref T ptr = ref t;
		T t2 = default(T);
		object obj;
		if (t2 == null)
		{
			t2 = t;
			ptr = ref t2;
			if (t2 == null)
			{
				obj = null;
				goto IL_4B;
			}
		}
		obj = ptr.ToString();
		IL_4B:
		array[num] = obj;
		int num2 = 1;
		U u = this.gparam_1;
		ref U ptr2 = ref u;
		U u2 = default(U);
		object obj2;
		if (u2 == null)
		{
			u2 = u;
			ptr2 = ref u2;
			if (u2 == null)
			{
				obj2 = null;
				goto IL_86;
			}
		}
		obj2 = ptr2.ToString();
		IL_86:
		array[num2] = obj2;
		return string.Format(provider, format, array);
	}

	// Token: 0x0400008B RID: 139
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly T gparam_0;

	// Token: 0x0400008C RID: 140
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly U gparam_1;
}
