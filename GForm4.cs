using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

// Token: 0x02000089 RID: 137
public sealed partial class GForm4 : Form
{
	// Token: 0x060002E6 RID: 742 RVA: 0x0001A69C File Offset: 0x0001889C
	public GForm4()
	{
		this.method_0();
		GForm4.gform4_0 = this;
		base.TopMost = true;
		Rectangle workingArea = Screen.GetWorkingArea(this);
		base.Location = new Point(workingArea.Right - base.Size.Width - 10, workingArea.Bottom - base.Size.Height - 10);
		base.Show();
	}

	// Token: 0x060002E8 RID: 744 RVA: 0x0001A70C File Offset: 0x0001890C
	public static void smethod_0(string string_1, string string_2, GForm4.GEnum0 genum0_0, bool bool_0)
	{
		GForm4.Class75 @class = new GForm4.Class75();
		@class.genum0_0 = genum0_0;
		@class.string_0 = string_1;
		@class.string_1 = string_2;
		string string_3 = GClass2.smethod_2(10);
		GForm4.string_0 = string_3;
		GForm4.gform4_0.Show();
		GForm4.smethod_3(new Action(@class.method_0));
		if (bool_0)
		{
			GForm4.smethod_1(string_3);
		}
	}

	// Token: 0x060002E9 RID: 745 RVA: 0x0001A768 File Offset: 0x00018968
	public static void smethod_1(string string_1)
	{
		GForm4.Class76 @class = new GForm4.Class76();
		@class.string_0 = string_1;
		@class.timer_0 = new Timer
		{
			Interval = 3000
		};
		@class.timer_0.Tick += @class.method_0;
		@class.timer_0.Start();
	}

	// Token: 0x060002EA RID: 746 RVA: 0x0001A7BC File Offset: 0x000189BC
	public static Timer smethod_2()
	{
		GForm4.Class78 @class = new GForm4.Class78();
		@class.double_0 = 0.0;
		GForm4.gform4_0.Opacity = 0.0;
		GForm4.timer_0.Stop();
		GForm4.timer_0 = new Timer
		{
			Interval = 10
		};
		GForm4.timer_0.Tick += @class.method_0;
		GForm4.timer_0.Start();
		return GForm4.timer_0;
	}

	// Token: 0x060002EB RID: 747 RVA: 0x0001A834 File Offset: 0x00018A34
	public static Timer smethod_3(Action action_0)
	{
		GForm4.Class77 @class = new GForm4.Class77();
		@class.action_0 = action_0;
		GForm4.timer_1.Stop();
		GForm4.timer_1 = new Timer
		{
			Interval = 10
		};
		GForm4.timer_1.Tick += @class.method_0;
		GForm4.timer_1.Start();
		return GForm4.timer_1;
	}

	// Token: 0x060002EC RID: 748 RVA: 0x000047B8 File Offset: 0x000029B8
	private void pictureBox_1_Click(object sender, EventArgs e)
	{
		GForm4.smethod_3(new Action(this.method_1));
	}

	// Token: 0x060002EE RID: 750 RVA: 0x0001A890 File Offset: 0x00018A90
	private void method_0()
	{
		this.icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm4));
		this.bunifuElipse_0 = new BunifuElipse(this.icontainer_0);
		this.pictureBox_0 = new PictureBox();
		this.bunifuCustomLabel_0 = new BunifuCustomLabel();
		this.bunifuCustomLabel_1 = new BunifuCustomLabel();
		this.pictureBox_1 = new PictureBox();
		this.panel_0 = new Panel();
		((ISupportInitialize)this.pictureBox_0).BeginInit();
		((ISupportInitialize)this.pictureBox_1).BeginInit();
		this.panel_0.SuspendLayout();
		base.SuspendLayout();
		this.bunifuElipse_0.ElipseRadius = 20;
		this.bunifuElipse_0.TargetControl = this;
		this.pictureBox_0.Image = (Image)componentResourceManager.GetObject(Class185.smethod_0(537715067));
		this.pictureBox_0.Location = new Point(2, 2);
		this.pictureBox_0.Name = Class185.smethod_0(537715052);
		this.pictureBox_0.Size = new Size(87, 66);
		this.pictureBox_0.SizeMode = PictureBoxSizeMode.Zoom;
		this.pictureBox_0.TabIndex = 0;
		this.pictureBox_0.TabStop = false;
		this.bunifuCustomLabel_0.AutoSize = true;
		this.bunifuCustomLabel_0.Font = new Font(Class185.smethod_0(537715047), 15f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.bunifuCustomLabel_0.ForeColor = Color.White;
		this.bunifuCustomLabel_0.Location = new Point(94, 10);
		this.bunifuCustomLabel_0.Name = Class185.smethod_0(537712450);
		this.bunifuCustomLabel_0.Size = new Size(266, 24);
		this.bunifuCustomLabel_0.TabIndex = 1;
		this.bunifuCustomLabel_0.Text = Class185.smethod_0(537714835);
		this.bunifuCustomLabel_1.AutoEllipsis = true;
		this.bunifuCustomLabel_1.AutoSize = true;
		this.bunifuCustomLabel_1.Font = new Font(Class185.smethod_0(537715047), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.bunifuCustomLabel_1.ForeColor = Color.FromArgb(194, 194, 194);
		this.bunifuCustomLabel_1.Location = new Point(96, 42);
		this.bunifuCustomLabel_1.Name = Class185.smethod_0(537704268);
		this.bunifuCustomLabel_1.Size = new Size(134, 16);
		this.bunifuCustomLabel_1.TabIndex = 2;
		this.bunifuCustomLabel_1.Text = Class185.smethod_0(537714867);
		this.pictureBox_1.Cursor = Cursors.Hand;
		this.pictureBox_1.Image = (Image)componentResourceManager.GetObject(Class185.smethod_0(537691267));
		this.pictureBox_1.Location = new Point(380, 4);
		this.pictureBox_1.Name = Class185.smethod_0(537691305);
		this.pictureBox_1.Size = new Size(19, 22);
		this.pictureBox_1.SizeMode = PictureBoxSizeMode.Zoom;
		this.pictureBox_1.TabIndex = 3;
		this.pictureBox_1.TabStop = false;
		this.pictureBox_1.Click += this.pictureBox_1_Click;
		this.panel_0.Controls.Add(this.pictureBox_0);
		this.panel_0.Controls.Add(this.bunifuCustomLabel_0);
		this.panel_0.Controls.Add(this.bunifuCustomLabel_1);
		this.panel_0.Location = new Point(12, 14);
		this.panel_0.Name = Class185.smethod_0(537714908);
		this.panel_0.Size = new Size(363, 69);
		this.panel_0.TabIndex = 4;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		this.BackColor = Color.FromArgb(22, 21, 26);
		base.ClientSize = new Size(406, 98);
		base.Controls.Add(this.panel_0);
		base.Controls.Add(this.pictureBox_1);
		this.ForeColor = Color.FromArgb(22, 21, 26);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Icon = (Icon)componentResourceManager.GetObject(Class185.smethod_0(537704548));
		base.Name = Class185.smethod_0(537714892);
		base.Opacity = 0.0;
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		this.Text = Class185.smethod_0(537714892);
		((ISupportInitialize)this.pictureBox_0).EndInit();
		((ISupportInitialize)this.pictureBox_1).EndInit();
		this.panel_0.ResumeLayout(false);
		this.panel_0.PerformLayout();
		base.ResumeLayout(false);
	}

	// Token: 0x060002EF RID: 751 RVA: 0x00002C8C File Offset: 0x00000E8C
	private void method_1()
	{
		base.Hide();
	}

	// Token: 0x04000192 RID: 402
	private static GForm4 gform4_0;

	// Token: 0x04000193 RID: 403
	public static string string_0;

	// Token: 0x04000194 RID: 404
	public static Timer timer_0 = new Timer();

	// Token: 0x04000195 RID: 405
	public static Timer timer_1 = new Timer();

	// Token: 0x04000197 RID: 407
	private BunifuElipse bunifuElipse_0;

	// Token: 0x04000198 RID: 408
	private BunifuCustomLabel bunifuCustomLabel_0;

	// Token: 0x04000199 RID: 409
	private PictureBox pictureBox_0;

	// Token: 0x0400019A RID: 410
	private BunifuCustomLabel bunifuCustomLabel_1;

	// Token: 0x0400019B RID: 411
	private PictureBox pictureBox_1;

	// Token: 0x0400019C RID: 412
	private Panel panel_0;

	// Token: 0x0200008A RID: 138
	[Serializable]
	private sealed class Class74
	{
		// Token: 0x060002F2 RID: 754 RVA: 0x000047F7 File Offset: 0x000029F7
		internal void method_0()
		{
			GForm4.gform4_0.Hide();
		}

		// Token: 0x0400019D RID: 413
		public static readonly GForm4.Class74 class74_0 = new GForm4.Class74();

		// Token: 0x0400019E RID: 414
		public static Action action_0;
	}

	// Token: 0x0200008B RID: 139
	private sealed class Class75
	{
		// Token: 0x060002F4 RID: 756 RVA: 0x0001AD58 File Offset: 0x00018F58
		internal void method_0()
		{
			GForm4.GEnum0 genum = this.genum0_0;
			if (genum != (GForm4.GEnum0)0)
			{
				if (genum != (GForm4.GEnum0)1)
				{
					return;
				}
				GForm4.gform4_0.pictureBox_0.ImageLocation = Class185.smethod_0(537715029);
			}
			else
			{
				GForm4.gform4_0.pictureBox_0.ImageLocation = Class185.smethod_0(537714988);
			}
			GForm4.gform4_0.bunifuCustomLabel_0.Text = this.string_0;
			GForm4.gform4_0.bunifuCustomLabel_1.Text = this.string_1;
			GForm4.smethod_2();
		}

		// Token: 0x0400019F RID: 415
		public GForm4.GEnum0 genum0_0;

		// Token: 0x040001A0 RID: 416
		public string string_0;

		// Token: 0x040001A1 RID: 417
		public string string_1;
	}

	// Token: 0x0200008C RID: 140
	private sealed class Class76
	{
		// Token: 0x060002F6 RID: 758 RVA: 0x0001ADD8 File Offset: 0x00018FD8
		internal void method_0(object sender, EventArgs e)
		{
			if (GForm4.string_0 == this.string_0 && !GForm4.gform4_0.ClientRectangle.Contains(GForm4.gform4_0.PointToClient(Control.MousePosition)))
			{
				GForm4.smethod_3(new Action(GForm4.Class74.class74_0.method_0));
				return;
			}
			if (GForm4.string_0 != this.string_0)
			{
				this.timer_0.Dispose();
			}
		}

		// Token: 0x040001A2 RID: 418
		public string string_0;

		// Token: 0x040001A3 RID: 419
		public Timer timer_0;
	}

	// Token: 0x0200008D RID: 141
	private sealed class Class77
	{
		// Token: 0x060002F8 RID: 760 RVA: 0x0001AE60 File Offset: 0x00019060
		internal void method_0(object sender, EventArgs e)
		{
			if (GForm4.gform4_0.Opacity <= 0.0)
			{
				Action action = this.action_0;
				if (action != null)
				{
					action();
				}
				GForm4.timer_1.Dispose();
				return;
			}
			GForm4.gform4_0.Opacity -= 0.05;
		}

		// Token: 0x040001A4 RID: 420
		public Action action_0;
	}

	// Token: 0x0200008E RID: 142
	private sealed class Class78
	{
		// Token: 0x060002FA RID: 762 RVA: 0x0001AEB8 File Offset: 0x000190B8
		internal void method_0(object sender, EventArgs e)
		{
			if (this.double_0 < 1.0)
			{
				GForm4.gform4_0.Opacity += 0.05;
				this.double_0 += 0.05;
				return;
			}
			GForm4.timer_0.Dispose();
		}

		// Token: 0x040001A5 RID: 421
		public double double_0;
	}

	// Token: 0x0200008F RID: 143
	public enum GEnum0
	{

	}
}
