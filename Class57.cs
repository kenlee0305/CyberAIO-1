using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

// Token: 0x02000061 RID: 97
internal sealed class Class57<T> : IEnumerable<T>, ICollection, IEnumerable
{
	// Token: 0x0600022B RID: 555 RVA: 0x00003FB1 File Offset: 0x000021B1
	public Class57()
	{
		this.gparam_0 = Class122<T>.gparam_0;
		this.int_0 = 0;
		this.int_1 = 0;
	}

	// Token: 0x0600022C RID: 556 RVA: 0x00003FD2 File Offset: 0x000021D2
	public Class57(int int_2)
	{
		if (int_2 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		this.gparam_0 = new T[int_2];
		this.int_0 = 0;
		this.int_1 = 0;
	}

	// Token: 0x0600022D RID: 557 RVA: 0x00016290 File Offset: 0x00014490
	public Class57(IEnumerable<T> ienumerable_0)
	{
		if (ienumerable_0 == null)
		{
			throw new ArgumentNullException();
		}
		ICollection<T> collection = ienumerable_0 as ICollection<T>;
		if (collection != null)
		{
			int count = collection.Count;
			this.gparam_0 = new T[count];
			collection.CopyTo(this.gparam_0, 0);
			this.int_0 = count;
			return;
		}
		this.int_0 = 0;
		this.gparam_0 = new T[4];
		foreach (T gparam_ in ienumerable_0)
		{
			this.method_7(gparam_);
		}
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x0600022E RID: 558 RVA: 0x00003FFE File Offset: 0x000021FE
	public int Count
	{
		get
		{
			return this.int_0;
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x0600022F RID: 559 RVA: 0x00003ADA File Offset: 0x00001CDA
	bool ICollection.IsSynchronized
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000230 RID: 560 RVA: 0x00004006 File Offset: 0x00002206
	object ICollection.SyncRoot
	{
		get
		{
			if (this.object_0 == null)
			{
				Interlocked.CompareExchange(ref this.object_0, new object(), null);
			}
			return this.object_0;
		}
	}

	// Token: 0x06000231 RID: 561 RVA: 0x00004028 File Offset: 0x00002228
	public void method_0()
	{
		Array.Clear(this.gparam_0, 0, this.int_0);
		this.int_0 = 0;
		this.int_1++;
	}

	// Token: 0x06000232 RID: 562 RVA: 0x0001632C File Offset: 0x0001452C
	public bool method_1(T gparam_1)
	{
		int num = this.int_0;
		EqualityComparer<T> @default = EqualityComparer<T>.Default;
		while (num-- > 0)
		{
			if (gparam_1 == null)
			{
				if (this.gparam_0[num] == null)
				{
					return true;
				}
			}
			else if (this.gparam_0[num] != null && @default.Equals(this.gparam_0[num], gparam_1))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000233 RID: 563 RVA: 0x0001639C File Offset: 0x0001459C
	public void method_2(T[] gparam_1, int int_2)
	{
		if (gparam_1 == null)
		{
			throw new ArgumentNullException(Class185.smethod_0(537697048));
		}
		if (int_2 < 0 || int_2 > gparam_1.Length)
		{
			throw new ArgumentOutOfRangeException(Class185.smethod_0(537697043), Class185.smethod_0(537697038));
		}
		if (gparam_1.Length - int_2 < this.int_0)
		{
			throw new ArgumentException(Class185.smethod_0(537697104));
		}
		Array.Copy(this.gparam_0, 0, gparam_1, int_2, this.int_0);
		Array.Reverse(gparam_1, int_2, this.int_0);
	}

	// Token: 0x06000234 RID: 564 RVA: 0x00016420 File Offset: 0x00014620
	void ICollection.CopyTo(Array array, int index)
	{
		if (array == null)
		{
			throw new ArgumentNullException();
		}
		if (array.Rank != 1)
		{
			throw new ArgumentException();
		}
		if (array.GetLowerBound(0) != 0)
		{
			throw new ArgumentException();
		}
		if (index >= 0 && index <= array.Length)
		{
			if (array.Length - index < this.int_0)
			{
				throw new ArgumentException();
			}
			try
			{
				Array.Copy(this.gparam_0, 0, array, index, this.int_0);
				Array.Reverse(array, index, this.int_0);
				return;
			}
			catch (ArrayTypeMismatchException)
			{
				throw new ArgumentException();
			}
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x06000235 RID: 565 RVA: 0x00004051 File Offset: 0x00002251
	public Class57<T>.Struct8 method_3()
	{
		return new Class57<T>.Struct8(this);
	}

	// Token: 0x06000236 RID: 566 RVA: 0x00004059 File Offset: 0x00002259
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return new Class57<T>.Struct8(this);
	}

	// Token: 0x06000237 RID: 567 RVA: 0x00004059 File Offset: 0x00002259
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new Class57<T>.Struct8(this);
	}

	// Token: 0x06000238 RID: 568 RVA: 0x000164B8 File Offset: 0x000146B8
	public void method_4()
	{
		int num = (int)((double)this.gparam_0.Length * 0.9);
		if (this.int_0 < num)
		{
			T[] destinationArray = new T[this.int_0];
			Array.Copy(this.gparam_0, 0, destinationArray, 0, this.int_0);
			this.gparam_0 = destinationArray;
			this.int_1++;
		}
	}

	// Token: 0x06000239 RID: 569 RVA: 0x00004066 File Offset: 0x00002266
	public T method_5()
	{
		if (this.int_0 == 0)
		{
			throw new InvalidOperationException();
		}
		return this.gparam_0[this.int_0 - 1];
	}

	// Token: 0x0600023A RID: 570 RVA: 0x00016518 File Offset: 0x00014718
	public T method_6()
	{
		if (this.int_0 == 0)
		{
			throw new InvalidOperationException();
		}
		this.int_1++;
		T[] array = this.gparam_0;
		int num = this.int_0 - 1;
		this.int_0 = num;
		T result = array[num];
		this.gparam_0[this.int_0] = default(T);
		return result;
	}

	// Token: 0x0600023B RID: 571 RVA: 0x00016578 File Offset: 0x00014778
	public void method_7(T gparam_1)
	{
		if (this.int_0 == this.gparam_0.Length)
		{
			T[] destinationArray = new T[(this.gparam_0.Length == 0) ? 4 : (2 * this.gparam_0.Length)];
			Array.Copy(this.gparam_0, 0, destinationArray, 0, this.int_0);
			this.gparam_0 = destinationArray;
		}
		T[] array = this.gparam_0;
		int num = this.int_0;
		this.int_0 = num + 1;
		array[num] = gparam_1;
		this.int_1++;
	}

	// Token: 0x0600023C RID: 572 RVA: 0x000165F8 File Offset: 0x000147F8
	public T[] method_8()
	{
		T[] array = new T[this.int_0];
		for (int i = 0; i < this.int_0; i++)
		{
			array[i] = this.gparam_0[this.int_0 - i - 1];
		}
		return array;
	}

	// Token: 0x04000121 RID: 289
	private T[] gparam_0;

	// Token: 0x04000122 RID: 290
	private int int_0;

	// Token: 0x04000123 RID: 291
	private int int_1;

	// Token: 0x04000124 RID: 292
	private object object_0;

	// Token: 0x02000062 RID: 98
	public struct Struct8 : IEnumerator<T>, IEnumerator, IDisposable
	{
		// Token: 0x0600023D RID: 573 RVA: 0x00004089 File Offset: 0x00002289
		internal Struct8(Class57<T> class57_1)
		{
			this.class57_0 = class57_1;
			this.int_1 = this.class57_0.int_1;
			this.int_0 = -2;
			this.gparam_0 = default(T);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x000040B7 File Offset: 0x000022B7
		public void Dispose()
		{
			this.int_0 = -1;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00016640 File Offset: 0x00014840
		public bool MoveNext()
		{
			if (this.int_1 != this.class57_0.int_1)
			{
				throw new InvalidOperationException(Class185.smethod_0(537697264));
			}
			if (this.int_0 == -2)
			{
				this.int_0 = this.class57_0.int_0 - 1;
				bool flag = this.int_0 >= 0;
				if (flag)
				{
					this.gparam_0 = this.class57_0.gparam_0[this.int_0];
				}
				return flag;
			}
			if (this.int_0 == -1)
			{
				return false;
			}
			int num = this.int_0 - 1;
			this.int_0 = num;
			bool flag2 = num >= 0;
			if (flag2)
			{
				this.gparam_0 = this.class57_0.gparam_0[this.int_0];
				return flag2;
			}
			this.gparam_0 = default(T);
			return flag2;
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000240 RID: 576 RVA: 0x000040C0 File Offset: 0x000022C0
		public T Current
		{
			get
			{
				if (this.int_0 == -2)
				{
					throw new InvalidOperationException();
				}
				if (this.int_0 == -1)
				{
					throw new InvalidOperationException();
				}
				return this.gparam_0;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000241 RID: 577 RVA: 0x000040E7 File Offset: 0x000022E7
		object IEnumerator.Current
		{
			get
			{
				if (this.int_0 == -2)
				{
					throw new InvalidOperationException();
				}
				if (this.int_0 == -1)
				{
					throw new InvalidOperationException();
				}
				return this.gparam_0;
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00004113 File Offset: 0x00002313
		void IEnumerator.Reset()
		{
			if (this.int_1 != this.class57_0.int_1)
			{
				throw new InvalidOperationException();
			}
			this.int_0 = -2;
			this.gparam_0 = default(T);
		}

		// Token: 0x04000125 RID: 293
		private Class57<T> class57_0;

		// Token: 0x04000126 RID: 294
		private int int_0;

		// Token: 0x04000127 RID: 295
		private int int_1;

		// Token: 0x04000128 RID: 296
		private T gparam_0;
	}
}
