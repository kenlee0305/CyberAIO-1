using System;
using System.Diagnostics;
using System.Threading;

// Token: 0x020000AE RID: 174
internal static class Class93
{
	// Token: 0x020000AF RID: 175
	private sealed class Class94
	{
		// Token: 0x060004B9 RID: 1209 RVA: 0x000052F3 File Offset: 0x000034F3
		internal void method_0(int int_1)
		{
			this.int_0 += int_1;
		}

		// Token: 0x04000249 RID: 585
		public int int_0;
	}

	// Token: 0x020000B0 RID: 176
	internal sealed class Class95 : Interface5<int>, Interface9<int>, Interface2, Interface4, Interface7
	{
		// Token: 0x060004BA RID: 1210 RVA: 0x00005303 File Offset: 0x00003503
		[DebuggerHidden]
		public Class95(int int_8)
		{
			this.int_0 = int_8;
			this.int_2 = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x0002A520 File Offset: 0x00028720
		[DebuggerHidden]
		void Interface4.imethod_0()
		{
			int num = this.int_0;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					this.method_0();
				}
			}
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0002A558 File Offset: 0x00028758
		bool Interface2.imethod_0()
		{
			bool result;
			try
			{
				int num = this.int_0;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					this.int_0 = -3;
					int num2 = this.class94_0.int_0;
					this.class94_0.int_0 = num2 - 1;
					if (this.class94_0.int_0 == 0)
					{
						result = false;
						this.method_0();
						return result;
					}
					int num3 = this.int_6;
					this.int_6 = (num3 + this.int_5 + this.class94_0.int_0 ^ -1482656774 + this.int_7);
					this.int_5 = num3;
				}
				else
				{
					this.int_0 = -1;
					this.class94_0 = new Class93.Class94();
					this.class94_0.int_0 = this.int_3;
					this.int_5 = 0;
					this.int_6 = 1;
					Class93.Delegate3<int> @delegate = new Class93.Delegate3<int>(this.class94_0.method_0);
					int num4 = this.int_6;
					Class93.Delegate3<int> delegate3_ = @delegate;
					int num5 = num4;
					this.interface5_0 = ((Interface9<int>)new Class93.Class96(-2)
					{
						int_4 = num5,
						delegate3_1 = delegate3_
					}).imethod_1();
					this.int_0 = -3;
				}
				if (!this.interface5_0.imethod_0())
				{
					this.method_0();
					this.interface5_0 = null;
					result = false;
				}
				else
				{
					this.int_7 = this.interface5_0.imethod_3();
					this.int_1 = this.int_6;
					this.int_0 = 1;
					result = true;
				}
			}
			catch
			{
				this.Interface4.imethod_0();
				throw;
			}
			return result;
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00005322 File Offset: 0x00003522
		private void method_0()
		{
			this.int_0 = -1;
			if (this.interface5_0 != null)
			{
				this.interface5_0.imethod_0();
			}
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0000533E File Offset: 0x0000353E
		[DebuggerHidden]
		int Interface5<int>.imethod_3()
		{
			return this.int_1;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00005346 File Offset: 0x00003546
		[DebuggerHidden]
		void Interface2.imethod_2()
		{
			throw new NotSupportedException();
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0000534D File Offset: 0x0000354D
		[DebuggerHidden]
		object Interface2.imethod_1()
		{
			return this.int_1;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0002A6D4 File Offset: 0x000288D4
		[DebuggerHidden]
		Interface5<int> Interface9<int>.imethod_1()
		{
			Class93.Class95 @class;
			if (this.int_0 == -2 && this.int_2 == Thread.CurrentThread.ManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class93.Class95(0);
			}
			@class.int_3 = this.int_4;
			return @class;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0000535A File Offset: 0x0000355A
		[DebuggerHidden]
		Interface2 Interface7.imethod_0()
		{
			return this.Interface9<System.Int32>.imethod_1();
		}

		// Token: 0x0400024A RID: 586
		private int int_0;

		// Token: 0x0400024B RID: 587
		private int int_1;

		// Token: 0x0400024C RID: 588
		private int int_2;

		// Token: 0x0400024D RID: 589
		private int int_3;

		// Token: 0x0400024E RID: 590
		public int int_4;

		// Token: 0x0400024F RID: 591
		private Class93.Class94 class94_0;

		// Token: 0x04000250 RID: 592
		private int int_5;

		// Token: 0x04000251 RID: 593
		private int int_6;

		// Token: 0x04000252 RID: 594
		private Interface5<int> interface5_0;

		// Token: 0x04000253 RID: 595
		private int int_7;
	}

	// Token: 0x020000B1 RID: 177
	internal sealed class Class96 : Interface5<int>, Interface9<int>, Interface2, Interface4, Interface7
	{
		// Token: 0x060004C3 RID: 1219 RVA: 0x00005362 File Offset: 0x00003562
		[DebuggerHidden]
		public Class96(int int_6)
		{
			this.int_0 = int_6;
			this.int_2 = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0000336F File Offset: 0x0000156F
		[DebuggerHidden]
		void Interface4.imethod_0()
		{
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0002A71C File Offset: 0x0002891C
		bool Interface2.imethod_0()
		{
			int num = this.int_0;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				this.int_0 = -1;
				this.int_5 += this.int_5;
				if (this.int_5 == 64)
				{
					this.delegate3_0(this.int_5 - 7);
					this.int_5 = 5;
				}
			}
			else
			{
				this.int_0 = -1;
				this.int_5 = 1;
				this.delegate3_0(this.int_3 - 2033554624);
			}
			this.int_1 = this.int_5;
			this.int_0 = 1;
			return true;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00005381 File Offset: 0x00003581
		[DebuggerHidden]
		int Interface5<int>.imethod_3()
		{
			return this.int_1;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00005346 File Offset: 0x00003546
		[DebuggerHidden]
		void Interface2.imethod_2()
		{
			throw new NotSupportedException();
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00005389 File Offset: 0x00003589
		[DebuggerHidden]
		object Interface2.imethod_1()
		{
			return this.int_1;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0002A7B4 File Offset: 0x000289B4
		[DebuggerHidden]
		Interface5<int> Interface9<int>.imethod_1()
		{
			Class93.Class96 @class;
			if (this.int_0 == -2 && this.int_2 == Thread.CurrentThread.ManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class93.Class96(0);
			}
			@class.int_3 = this.int_4;
			@class.delegate3_0 = this.delegate3_1;
			return @class;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00005396 File Offset: 0x00003596
		[DebuggerHidden]
		Interface2 Interface7.imethod_0()
		{
			return this.Interface9<System.Int32>.imethod_1();
		}

		// Token: 0x04000254 RID: 596
		private int int_0;

		// Token: 0x04000255 RID: 597
		private int int_1;

		// Token: 0x04000256 RID: 598
		private int int_2;

		// Token: 0x04000257 RID: 599
		private Class93.Delegate3<int> delegate3_0;

		// Token: 0x04000258 RID: 600
		public Class93.Delegate3<int> delegate3_1;

		// Token: 0x04000259 RID: 601
		private int int_3;

		// Token: 0x0400025A RID: 602
		public int int_4;

		// Token: 0x0400025B RID: 603
		private int int_5;
	}

	// Token: 0x020000B2 RID: 178
	// (Invoke) Token: 0x060004CC RID: 1228
	private delegate void Delegate3<T>(T gparam_0);

	// Token: 0x020000B3 RID: 179
	internal sealed class Class97 : Interface5<int>, Interface9<int>, Interface2, Interface4, Interface7
	{
		// Token: 0x060004CF RID: 1231 RVA: 0x0000539E File Offset: 0x0000359E
		[DebuggerHidden]
		public Class97(int int_6)
		{
			this.int_0 = int_6;
			this.int_2 = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0002A808 File Offset: 0x00028A08
		[DebuggerHidden]
		void Interface4.imethod_0()
		{
			int num = this.int_0;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					this.method_0();
				}
			}
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0002A840 File Offset: 0x00028A40
		bool Interface2.imethod_0()
		{
			bool result;
			try
			{
				int num = this.int_0;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					this.int_0 = -3;
					if (this.int_5 == 0)
					{
						result = false;
						this.method_0();
						return result;
					}
				}
				else
				{
					this.int_0 = -1;
					this.int_5 = 7;
					int num2 = this.int_3;
					this.interface5_0 = ((Interface9<int>)new Class93.Class95(-2)
					{
						int_4 = num2
					}).imethod_1();
					this.int_0 = -3;
				}
				if (!this.interface5_0.imethod_0())
				{
					this.method_0();
					this.interface5_0 = null;
					result = false;
				}
				else
				{
					int num3 = this.interface5_0.imethod_3() ^ this.int_3;
					if ((num3 & 3) == 0)
					{
						num3 ^= 706155683;
					}
					int num4 = this.int_5 - 1;
					this.int_5 = num4;
					if ((num3 & 15) == 0)
					{
						num3 ^= (51866299 ^ this.int_5);
					}
					this.int_1 = num3;
					this.int_0 = 1;
					result = true;
				}
			}
			catch
			{
				this.Interface4.imethod_0();
				throw;
			}
			return result;
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x000053BD File Offset: 0x000035BD
		private void method_0()
		{
			this.int_0 = -1;
			if (this.interface5_0 != null)
			{
				this.interface5_0.imethod_0();
			}
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x000053D9 File Offset: 0x000035D9
		[DebuggerHidden]
		int Interface5<int>.imethod_3()
		{
			return this.int_1;
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00005346 File Offset: 0x00003546
		[DebuggerHidden]
		void Interface2.imethod_2()
		{
			throw new NotSupportedException();
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x000053E1 File Offset: 0x000035E1
		[DebuggerHidden]
		object Interface2.imethod_1()
		{
			return this.int_1;
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x0002A944 File Offset: 0x00028B44
		[DebuggerHidden]
		Interface5<int> Interface9<int>.imethod_1()
		{
			Class93.Class97 @class;
			if (this.int_0 == -2 && this.int_2 == Thread.CurrentThread.ManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class93.Class97(0);
			}
			@class.int_3 = this.int_4;
			return @class;
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x000053EE File Offset: 0x000035EE
		[DebuggerHidden]
		Interface2 Interface7.imethod_0()
		{
			return this.Interface9<System.Int32>.imethod_1();
		}

		// Token: 0x0400025C RID: 604
		private int int_0;

		// Token: 0x0400025D RID: 605
		private int int_1;

		// Token: 0x0400025E RID: 606
		private int int_2;

		// Token: 0x0400025F RID: 607
		private int int_3;

		// Token: 0x04000260 RID: 608
		public int int_4;

		// Token: 0x04000261 RID: 609
		private int int_5;

		// Token: 0x04000262 RID: 610
		private Interface5<int> interface5_0;
	}
}
