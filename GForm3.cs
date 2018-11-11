using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Management;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

// Token: 0x02000058 RID: 88
public sealed partial class GForm3 : Form
{
	// Token: 0x060001EE RID: 494 RVA: 0x00003E16 File Offset: 0x00002016
	public GForm3()
	{
		this.method_2();
		this.method_0();
	}

	// Token: 0x060001F0 RID: 496 RVA: 0x00012DC8 File Offset: 0x00010FC8
	public static void smethod_0(EventHandler eventHandler_1)
	{
		EventHandler eventHandler = GForm3.eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref GForm3.eventHandler_0, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060001F1 RID: 497 RVA: 0x00012DFC File Offset: 0x00010FFC
	public static void smethod_1(EventHandler eventHandler_1)
	{
		EventHandler eventHandler = GForm3.eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref GForm3.eventHandler_0, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060001F2 RID: 498 RVA: 0x00012E30 File Offset: 0x00011030
	public void method_0()
	{
		base.CenterToScreen();
		base.Opacity = 0.0;
		base.Show();
		this.timer_0.Interval = 10;
		this.timer_0.Tick += this.timer_0_Tick;
		this.timer_0.Start();
	}

	// Token: 0x060001F3 RID: 499 RVA: 0x00003E63 File Offset: 0x00002063
	public void method_1()
	{
		this.timer_1.Interval = 10;
		this.timer_1.Tick += this.timer_1_Tick;
		this.timer_1.Start();
	}

	// Token: 0x060001F4 RID: 500 RVA: 0x00012E88 File Offset: 0x00011088
	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (base.Opacity >= 1.0)
		{
			this.timer_0.Stop();
			GForm3.eventHandler_0(this, e);
			return;
		}
		base.Opacity += 0.05;
	}

	// Token: 0x060001F5 RID: 501 RVA: 0x00003E94 File Offset: 0x00002094
	private void timer_1_Tick(object sender, EventArgs e)
	{
		if (base.Opacity <= 0.0)
		{
			this.timer_1.Dispose();
			base.Hide();
			return;
		}
		base.Opacity -= 0.05;
	}

	// Token: 0x060001F6 RID: 502 RVA: 0x00002FF9 File Offset: 0x000011F9
	protected override void SetVisibleCore(bool value)
	{
		if (!base.IsHandleCreated)
		{
			this.CreateHandle();
			value = false;
		}
		base.SetVisibleCore(value);
	}

	// Token: 0x060001F7 RID: 503 RVA: 0x00003ECF File Offset: 0x000020CF
	private void pictureBox_1_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	// Token: 0x060001F8 RID: 504 RVA: 0x00012ED4 File Offset: 0x000110D4
	public static string smethod_2()
	{
		return Guid.NewGuid().ToString(Class185.smethod_0(537707981));
	}

	// Token: 0x060001F9 RID: 505 RVA: 0x00012EF8 File Offset: 0x000110F8
	public static string smethod_3()
	{
		string result;
		try
		{
			string text = null;
			foreach (ManagementBaseObject managementBaseObject in new ManagementClass(Class185.smethod_0(537707973)).GetInstances())
			{
				text = ((ManagementObject)managementBaseObject).Properties[Class185.smethod_0(537708011)].Value.ToString();
			}
			if (text == null)
			{
				result = Class185.smethod_0(537707805);
			}
			else
			{
				result = text;
			}
		}
		catch
		{
			result = Class185.smethod_0(537707805);
		}
		return result;
	}

	// Token: 0x060001FA RID: 506 RVA: 0x00012FA4 File Offset: 0x000111A4
	public static string smethod_4()
	{
		string result;
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher(Class185.smethod_0(537707787)).Get())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				object value = managementObject[Class185.smethod_0(537707818)];
				stringBuilder.Append(Convert.ToString(value));
				stringBuilder.Append(':');
				value = managementObject[Class185.smethod_0(537707869)];
				stringBuilder.Append(Convert.ToString(value));
			}
			if (stringBuilder == null)
			{
				result = Class185.smethod_0(537707805);
			}
			else
			{
				result = stringBuilder.ToString();
			}
		}
		catch
		{
			result = Class185.smethod_0(537707805);
		}
		return result;
	}

	// Token: 0x060001FB RID: 507 RVA: 0x00013080 File Offset: 0x00011280
	public static string smethod_5()
	{
		ManagementObjectCollection instances = new ManagementClass(Class185.smethod_0(537707840)).GetInstances();
		string text = string.Empty;
		foreach (ManagementBaseObject managementBaseObject in instances)
		{
			ManagementObject managementObject = (ManagementObject)managementBaseObject;
			if (text == string.Empty && (bool)managementObject[Class185.smethod_0(537707672)])
			{
				text = managementObject[Class185.smethod_0(537707656)].ToString();
			}
			managementObject.Dispose();
		}
		if (text == string.Empty)
		{
			return Class185.smethod_0(537707805);
		}
		return text;
	}

	// Token: 0x060001FC RID: 508 RVA: 0x0001313C File Offset: 0x0001133C
	public static string smethod_6()
	{
		if (GForm3.string_1 == null)
		{
			GForm3.string_1 = string.Concat(new string[]
			{
				GForm3.smethod_5(),
				Class185.smethod_0(537711014),
				GForm3.smethod_3(),
				Class185.smethod_0(537711014),
				GForm3.smethod_4().Trim()
			});
			return GForm3.string_1;
		}
		return GForm3.string_1;
	}

	// Token: 0x060001FD RID: 509 RVA: 0x000131A4 File Offset: 0x000113A4
	public static void smethod_7(string string_2, string string_3)
	{
		object[] object_ = new object[]
		{
			string_2,
			string_3
		};
		Class62.smethod_0().method_203(Class62.smethod_1(), "rr;nfqYTaW", object_);
	}

	// Token: 0x060001FE RID: 510 RVA: 0x00003ED6 File Offset: 0x000020D6
	public static void smethod_8()
	{
		Class62.smethod_0().method_203(Class62.smethod_1(), "rr;onqYT^V", null);
	}

	// Token: 0x060001FF RID: 511 RVA: 0x000131D8 File Offset: 0x000113D8
	public static void smethod_9()
	{
		GForm3.Struct5 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		AsyncVoidMethodBuilder asyncVoidMethodBuilder_ = @struct.asyncVoidMethodBuilder_0;
		asyncVoidMethodBuilder_.Start<GForm3.Struct5>(ref @struct);
	}

	// Token: 0x06000200 RID: 512 RVA: 0x0001320C File Offset: 0x0001140C
	public static string smethod_10(string string_2, string string_3, string string_4)
	{
		object[] object_ = new object[]
		{
			string_2,
			string_3,
			string_4
		};
		return (string)Class62.smethod_0().method_232(Class62.smethod_1(), "rr;ncqYSq@", object_);
	}

	// Token: 0x06000201 RID: 513 RVA: 0x00013248 File Offset: 0x00011448
	public static Task<string> smethod_11(string string_2, bool bool_0, bool bool_1)
	{
		object[] object_ = new object[]
		{
			string_2,
			bool_0,
			bool_1
		};
		return (Task<string>)Class62.smethod_0().method_232(Class62.smethod_1(), "rr;nLqYT(D", object_);
	}

	// Token: 0x06000202 RID: 514 RVA: 0x0001328C File Offset: 0x0001148C
	private async void bunifuFlatButton_0_Click(object sender, EventArgs e)
	{
		this.bunifuFlatButton_0.ButtonText = Class185.smethod_0(537708238);
		string text = await GForm3.smethod_11(this.bunifuMetroTextbox_0.Text, true, false);
		if (text == Class185.smethod_0(537706979))
		{
			GClass0.string_2 = this.bunifuMetroTextbox_0.Text;
			GClass0.smethod_2();
			this.bunifuMetroTextbox_0.BorderColorFocused = Color.Green;
			this.bunifuMetroTextbox_0.BorderColorIdle = Color.Green;
			this.bunifuMetroTextbox_0.BorderColorMouseHover = Color.Green;
			this.bunifuCustomLabel_0.Text = Class185.smethod_0(537708276);
			this.bunifuCustomLabel_0.ForeColor = Color.Green;
			this.method_1();
			new GForm5(true, text);
		}
		else if (text == Class185.smethod_0(537708475))
		{
			this.bunifuMetroTextbox_0.BorderColorFocused = Color.Red;
			this.bunifuMetroTextbox_0.BorderColorIdle = Color.Red;
			this.bunifuMetroTextbox_0.BorderColorMouseHover = Color.Red;
			this.bunifuCustomLabel_0.Text = Class185.smethod_0(537708037);
			this.bunifuCustomLabel_0.ForeColor = Color.Red;
		}
		else if (text == Class185.smethod_0(537708458))
		{
			this.bunifuMetroTextbox_0.BorderColorFocused = Color.Red;
			this.bunifuMetroTextbox_0.BorderColorIdle = Color.Red;
			this.bunifuMetroTextbox_0.BorderColorMouseHover = Color.Red;
			this.bunifuCustomLabel_0.Text = Class185.smethod_0(537708148);
			this.bunifuCustomLabel_0.ForeColor = Color.Red;
		}
		else if (text == Class185.smethod_0(537710733))
		{
			this.bunifuMetroTextbox_0.BorderColorFocused = Color.Red;
			this.bunifuMetroTextbox_0.BorderColorIdle = Color.Red;
			this.bunifuMetroTextbox_0.BorderColorMouseHover = Color.Red;
			this.bunifuCustomLabel_0.Text = Class185.smethod_0(537707929);
			this.bunifuCustomLabel_0.ForeColor = Color.Red;
		}
		this.bunifuFlatButton_0.ButtonText = Class185.smethod_0(537707996);
	}

	// Token: 0x06000203 RID: 515 RVA: 0x00003EED File Offset: 0x000020ED
	private void bunifuMetroTextbox_0_Enter(object sender, EventArgs e)
	{
		this.bunifuMetroTextbox_0.Text = null;
	}

	// Token: 0x06000205 RID: 517 RVA: 0x000132C8 File Offset: 0x000114C8
	private void method_2()
	{
		this.icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm3));
		this.bunifuDragControl_0 = new BunifuDragControl(this.icontainer_0);
		this.panel_0 = new Panel();
		this.pictureBox_1 = new PictureBox();
		this.label_0 = new Label();
		this.pictureBox_0 = new PictureBox();
		this.bunifuElipse_0 = new BunifuElipse(this.icontainer_0);
		this.bunifuCustomLabel_0 = new BunifuCustomLabel();
		this.bunifuMetroTextbox_0 = new BunifuMetroTextbox();
		this.bunifuFlatButton_0 = new BunifuFlatButton();
		this.panel_0.SuspendLayout();
		((ISupportInitialize)this.pictureBox_1).BeginInit();
		((ISupportInitialize)this.pictureBox_0).BeginInit();
		base.SuspendLayout();
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.panel_0;
		this.bunifuDragControl_0.Vertical = true;
		this.panel_0.Controls.Add(this.pictureBox_1);
		this.panel_0.Controls.Add(this.label_0);
		this.panel_0.Controls.Add(this.pictureBox_0);
		this.panel_0.Dock = DockStyle.Top;
		this.panel_0.Location = new Point(0, 0);
		this.panel_0.Name = Class185.smethod_0(537707705);
		this.panel_0.Size = new Size(493, 85);
		this.panel_0.TabIndex = 7;
		this.pictureBox_1.Cursor = Cursors.Hand;
		this.pictureBox_1.Image = (Image)componentResourceManager.GetObject(Class185.smethod_0(537691267));
		this.pictureBox_1.Location = new Point(456, 8);
		this.pictureBox_1.Name = Class185.smethod_0(537691305);
		this.pictureBox_1.Size = new Size(27, 28);
		this.pictureBox_1.SizeMode = PictureBoxSizeMode.StretchImage;
		this.pictureBox_1.TabIndex = 10;
		this.pictureBox_1.TabStop = false;
		this.pictureBox_1.Click += this.pictureBox_1_Click;
		this.label_0.AutoSize = true;
		this.label_0.BackColor = Color.Transparent;
		this.label_0.Font = new Font(Class185.smethod_0(537705197), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.label_0.ForeColor = Color.White;
		this.label_0.Location = new Point(168, 53);
		this.label_0.Name = Class185.smethod_0(537691363);
		this.label_0.Size = new Size(162, 13);
		this.label_0.TabIndex = 9;
		this.label_0.Text = Class185.smethod_0(537707688);
		this.pictureBox_0.Cursor = Cursors.Default;
		this.pictureBox_0.Image = (Image)componentResourceManager.GetObject(Class185.smethod_0(537707732));
		this.pictureBox_0.Location = new Point(149, 12);
		this.pictureBox_0.Name = Class185.smethod_0(537707774);
		this.pictureBox_0.Size = new Size(200, 29);
		this.pictureBox_0.SizeMode = PictureBoxSizeMode.StretchImage;
		this.pictureBox_0.TabIndex = 6;
		this.pictureBox_0.TabStop = false;
		this.bunifuElipse_0.ElipseRadius = 5;
		this.bunifuElipse_0.TargetControl = this;
		this.bunifuCustomLabel_0.Font = new Font(Class185.smethod_0(537705197), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.bunifuCustomLabel_0.ForeColor = SystemColors.ButtonFace;
		this.bunifuCustomLabel_0.ImageAlign = ContentAlignment.MiddleLeft;
		this.bunifuCustomLabel_0.Location = new Point(2, 190);
		this.bunifuCustomLabel_0.Name = Class185.smethod_0(537707746);
		this.bunifuCustomLabel_0.Size = new Size(491, 22);
		this.bunifuCustomLabel_0.TabIndex = 15;
		this.bunifuCustomLabel_0.TextAlign = ContentAlignment.TopCenter;
		this.bunifuMetroTextbox_0.BorderColorFocused = Color.White;
		this.bunifuMetroTextbox_0.BorderColorIdle = Color.White;
		this.bunifuMetroTextbox_0.BorderColorMouseHover = Color.White;
		this.bunifuMetroTextbox_0.BorderThickness = 3;
		this.bunifuMetroTextbox_0.characterCasing = CharacterCasing.Normal;
		this.bunifuMetroTextbox_0.Cursor = Cursors.IBeam;
		this.bunifuMetroTextbox_0.Font = new Font(Class185.smethod_0(537691496), 9.75f);
		this.bunifuMetroTextbox_0.ForeColor = Color.Gray;
		this.bunifuMetroTextbox_0.isPassword = false;
		this.bunifuMetroTextbox_0.Location = new Point(63, 142);
		this.bunifuMetroTextbox_0.Margin = new Padding(4);
		this.bunifuMetroTextbox_0.MaxLength = 32767;
		this.bunifuMetroTextbox_0.Name = Class185.smethod_0(537707541);
		this.bunifuMetroTextbox_0.Size = new Size(370, 44);
		this.bunifuMetroTextbox_0.TabIndex = 16;
		this.bunifuMetroTextbox_0.Text = Class185.smethod_0(537707523);
		this.bunifuMetroTextbox_0.TextAlign = HorizontalAlignment.Center;
		this.bunifuMetroTextbox_0.Click += this.bunifuMetroTextbox_0_Enter;
		this.bunifuMetroTextbox_0.Enter += this.bunifuMetroTextbox_0_Enter;
		this.bunifuFlatButton_0.Active = false;
		this.bunifuFlatButton_0.Activecolor = Color.Transparent;
		this.bunifuFlatButton_0.BackColor = Color.Transparent;
		this.bunifuFlatButton_0.BackgroundImageLayout = ImageLayout.Stretch;
		this.bunifuFlatButton_0.BorderRadius = 0;
		this.bunifuFlatButton_0.ButtonText = Class185.smethod_0(537707996);
		this.bunifuFlatButton_0.Cursor = Cursors.Hand;
		this.bunifuFlatButton_0.DisabledColor = Color.Gray;
		this.bunifuFlatButton_0.Font = new Font(Class185.smethod_0(537691381), 12f);
		this.bunifuFlatButton_0.Iconcolor = Color.Transparent;
		this.bunifuFlatButton_0.Iconimage = (Image)componentResourceManager.GetObject(Class185.smethod_0(537707565));
		this.bunifuFlatButton_0.Iconimage_right = null;
		this.bunifuFlatButton_0.Iconimage_right_Selected = null;
		this.bunifuFlatButton_0.Iconimage_Selected = null;
		this.bunifuFlatButton_0.IconMarginLeft = 0;
		this.bunifuFlatButton_0.IconMarginRight = 0;
		this.bunifuFlatButton_0.IconRightVisible = true;
		this.bunifuFlatButton_0.IconRightZoom = 0.0;
		this.bunifuFlatButton_0.IconVisible = true;
		this.bunifuFlatButton_0.IconZoom = 35.0;
		this.bunifuFlatButton_0.IsTab = false;
		this.bunifuFlatButton_0.Location = new Point(149, 216);
		this.bunifuFlatButton_0.Margin = new Padding(5, 4, 5, 4);
		this.bunifuFlatButton_0.Name = Class185.smethod_0(537707594);
		this.bunifuFlatButton_0.Normalcolor = Color.Transparent;
		this.bunifuFlatButton_0.OnHovercolor = Color.Transparent;
		this.bunifuFlatButton_0.OnHoverTextColor = Color.FromArgb(43, 184, 115);
		this.bunifuFlatButton_0.selected = false;
		this.bunifuFlatButton_0.Size = new Size(255, 75);
		this.bunifuFlatButton_0.TabIndex = 17;
		this.bunifuFlatButton_0.Text = Class185.smethod_0(537707996);
		this.bunifuFlatButton_0.TextAlign = ContentAlignment.MiddleLeft;
		this.bunifuFlatButton_0.Textcolor = Color.FromArgb(43, 184, 115);
		this.bunifuFlatButton_0.TextFont = new Font(Class185.smethod_0(537691381), 12f);
		this.bunifuFlatButton_0.Click += this.bunifuFlatButton_0_Click;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		this.BackColor = Color.FromArgb(35, 34, 40);
		base.ClientSize = new Size(493, 304);
		base.Controls.Add(this.bunifuFlatButton_0);
		base.Controls.Add(this.bunifuMetroTextbox_0);
		base.Controls.Add(this.bunifuCustomLabel_0);
		base.Controls.Add(this.panel_0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Icon = (Icon)componentResourceManager.GetObject(Class185.smethod_0(537704548));
		base.Name = Class185.smethod_0(537707645);
		base.StartPosition = FormStartPosition.CenterScreen;
		this.Text = Class185.smethod_0(537707628);
		this.panel_0.ResumeLayout(false);
		this.panel_0.PerformLayout();
		((ISupportInitialize)this.pictureBox_1).EndInit();
		((ISupportInitialize)this.pictureBox_0).EndInit();
		base.ResumeLayout(false);
	}

	// Token: 0x040000EA RID: 234
	public static DateTime dateTime_0;

	// Token: 0x040000EB RID: 235
	public static string string_0 = string.Empty;

	// Token: 0x040000EC RID: 236
	public static int int_0 = 60;

	// Token: 0x040000ED RID: 237
	public static List<string> list_0 = new List<string>();

	// Token: 0x040000EE RID: 238
	private System.Windows.Forms.Timer timer_0 = new System.Windows.Forms.Timer();

	// Token: 0x040000EF RID: 239
	private System.Windows.Forms.Timer timer_1 = new System.Windows.Forms.Timer();

	// Token: 0x040000F0 RID: 240
	private static EventHandler eventHandler_0;

	// Token: 0x040000F1 RID: 241
	public static string string_1 = null;

	// Token: 0x040000F3 RID: 243
	private BunifuDragControl bunifuDragControl_0;

	// Token: 0x040000F4 RID: 244
	private BunifuElipse bunifuElipse_0;

	// Token: 0x040000F5 RID: 245
	private Panel panel_0;

	// Token: 0x040000F6 RID: 246
	private Label label_0;

	// Token: 0x040000F7 RID: 247
	private PictureBox pictureBox_0;

	// Token: 0x040000F8 RID: 248
	private PictureBox pictureBox_1;

	// Token: 0x040000F9 RID: 249
	private BunifuCustomLabel bunifuCustomLabel_0;

	// Token: 0x040000FA RID: 250
	private BunifuMetroTextbox bunifuMetroTextbox_0;

	// Token: 0x040000FB RID: 251
	private BunifuFlatButton bunifuFlatButton_0;

	// Token: 0x02000059 RID: 89
	[StructLayout(LayoutKind.Auto)]
	private struct Struct3 : IAsyncStateMachine
	{
		// Token: 0x06000206 RID: 518 RVA: 0x00013BC0 File Offset: 0x00011DC0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter<HttpResponseMessage> awaiter;
				if (num != 0)
				{
					awaiter = new Class70(null, Class185.smethod_0(537692910), 10, false, false, null, false).method_6(string.Format(Class185.smethod_0(537707120), new object[]
					{
						Class173.struct42_1.method_1(),
						Class173.struct42_0.method_1(),
						this.string_0,
						this.string_1
					}), false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GForm3.Struct3>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
					this.int_0 = -1;
				}
				awaiter.GetResult().EnsureSuccessStatusCode();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00003F1A File Offset: 0x0000211A
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040000FC RID: 252
		public int int_0;

		// Token: 0x040000FD RID: 253
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040000FE RID: 254
		public string string_0;

		// Token: 0x040000FF RID: 255
		public string string_1;

		// Token: 0x04000100 RID: 256
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;
	}

	// Token: 0x0200005A RID: 90
	[StructLayout(LayoutKind.Auto)]
	private struct Struct4 : IAsyncStateMachine
	{
		// Token: 0x06000208 RID: 520 RVA: 0x00013CCC File Offset: 0x00011ECC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			string result;
			try
			{
				try
				{
					TaskAwaiter<HttpResponseMessage> awaiter;
					if (num != 0)
					{
						awaiter = new Class70(null, Class185.smethod_0(537692910), 10, false, true, null, false).method_6(string.Format(Class185.smethod_0(537706925), new object[]
						{
							Class173.struct42_1.method_1(),
							Class173.struct42_0.method_1(),
							this.string_0,
							Assembly.GetEntryAssembly().GetName().Version
						}), false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GForm3.Struct4>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
						this.int_0 = -1;
					}
					JObject jobject = awaiter.GetResult().smethod_0();
					if ((bool)jobject[Class185.smethod_0(537706979)])
					{
						string text = GForm3.smethod_6();
						GForm3.dateTime_0 = Convert.ToDateTime(jobject[Class185.smethod_0(537706783)]);
						GForm3.int_0 = (int)jobject[Class185.smethod_0(537706765)];
						Class173.jobject_4 = JObject.Parse(jobject[Class185.smethod_0(537706815)][Class185.smethod_0(537706797)].ToString());
						Class173.jobject_0 = JObject.Parse(jobject[Class185.smethod_0(537706815)][Class185.smethod_0(537706840)].ToString());
						Class173.jobject_2 = JObject.Parse(jobject[Class185.smethod_0(537692180)][Class185.smethod_0(537706825)][Class185.smethod_0(537700388)].ToString());
						Class173.jarray_0 = JArray.Parse(jobject[Class185.smethod_0(537692180)][Class185.smethod_0(537706825)][Class185.smethod_0(537706818)].ToString());
						Class173.jarray_1 = JArray.Parse(jobject[Class185.smethod_0(537692180)][Class185.smethod_0(537706864)][Class185.smethod_0(537706818)].ToString());
						Class173.jobject_1 = JObject.Parse(jobject[Class185.smethod_0(537692180)][Class185.smethod_0(537706857)].ToString());
						Class173.string_2 = jobject[Class185.smethod_0(537706655)][Class185.smethod_0(537706638)].ToString();
						Class173.string_3 = jobject[Class185.smethod_0(537706655)][Class185.smethod_0(537706673)].ToString();
						Class173.string_4 = jobject[Class185.smethod_0(537706655)][Class185.smethod_0(537706656)].ToString();
						Class173.jobject_5 = JObject.Parse(jobject[Class185.smethod_0(537706707)].ToString());
						Class173.bool_0 = (bool)jobject[Class185.smethod_0(537692180)][Class185.smethod_0(537706864)][Class185.smethod_0(537706689)];
						Class173.bool_1 = (bool)jobject[Class185.smethod_0(537692180)][Class185.smethod_0(537706825)][Class185.smethod_0(537706689)];
						JToken jtoken = jobject[Class185.smethod_0(537706742)];
						GForm3.string_0 = ((jtoken != null) ? jtoken.ToString() : null);
						if (Class173.jobject_5[Class185.smethod_0(537706724)][Assembly.GetEntryAssembly().GetName().Version.ToString()] != null && Convert.ToDateTime(jobject[Class185.smethod_0(537706783)]) < Convert.ToDateTime(Class173.jobject_5[Class185.smethod_0(537706724)][Assembly.GetEntryAssembly().GetName().Version.ToString()][Class185.smethod_0(537706515)].ToString()))
						{
							Process.GetCurrentProcess().Kill();
						}
						if (Class173.string_0 == null)
						{
							Class173.string_0 = GForm3.smethod_10(jobject[Class185.smethod_0(537706510)].ToString(), this.string_0 + (string)jobject[Class185.smethod_0(537706553)] + (string)jobject[Class185.smethod_0(537706655)][Class185.smethod_0(537692633)] + Class173.struct42_0.method_1(), null);
						}
						if (this.bool_0 && jobject[Class185.smethod_0(537706536)][Class185.smethod_0(537706534)].Type != JTokenType.Null && !GForm3.list_0.Contains(jobject[Class185.smethod_0(537706536)].ToString()))
						{
							GForm3.list_0.Add(jobject[Class185.smethod_0(537706536)].ToString());
							GForm1.webView_0.QueueScriptCall(string.Format(Class185.smethod_0(537706580), jobject[Class185.smethod_0(537706536)][Class185.smethod_0(537712450)].ToString(), jobject[Class185.smethod_0(537706536)][Class185.smethod_0(537706534)].ToString()));
						}
						if (jobject[Class185.smethod_0(537706613)].ToString() == Class185.smethod_0(537706594))
						{
							result = Class185.smethod_0(537706979);
						}
						else if (jobject[Class185.smethod_0(537706613)].ToString() == Class185.smethod_0(537708442))
						{
							if (this.bool_1)
							{
								GForm3.smethod_7(this.string_0, text);
								result = Class185.smethod_0(537706979);
							}
							else
							{
								result = Class185.smethod_0(537708434);
							}
						}
						else if (jobject[Class185.smethod_0(537708417)].ToString() == text)
						{
							result = Class185.smethod_0(537706979);
						}
						else if (jobject[Class185.smethod_0(537708417)].ToString() != text)
						{
							result = Class185.smethod_0(537708475);
						}
						else
						{
							result = Class185.smethod_0(537710733);
						}
					}
					else
					{
						result = Class185.smethod_0(537708458);
					}
				}
				catch
				{
					result = Class185.smethod_0(537710733);
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00003F28 File Offset: 0x00002128
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000101 RID: 257
		public int int_0;

		// Token: 0x04000102 RID: 258
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x04000103 RID: 259
		public string string_0;

		// Token: 0x04000104 RID: 260
		public bool bool_0;

		// Token: 0x04000105 RID: 261
		public bool bool_1;

		// Token: 0x04000106 RID: 262
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;
	}

	// Token: 0x0200005B RID: 91
	[StructLayout(LayoutKind.Auto)]
	private struct Struct5 : IAsyncStateMachine
	{
		// Token: 0x0600020A RID: 522 RVA: 0x000143C4 File Offset: 0x000125C4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				for (;;)
				{
					try
					{
						TaskAwaiter awaiter;
						TaskAwaiter<string> awaiter2;
						switch (num)
						{
						case 0:
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							int num2 = -1;
							num = -1;
							this.int_0 = num2;
							break;
						}
						case 1:
						{
							awaiter2 = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter<string>);
							int num3 = -1;
							num = -1;
							this.int_0 = num3;
							goto IL_D9;
						}
						case 2:
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							int num4 = -1;
							num = -1;
							this.int_0 = num4;
							goto IL_19A;
						}
						default:
							awaiter = Task.Delay(GForm3.int_0 * 1000).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num5 = 0;
								num = 0;
								this.int_0 = num5;
								this.taskAwaiter_0 = awaiter;
								this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GForm3.Struct5>(ref awaiter, ref this);
								return;
							}
							break;
						}
						awaiter.GetResult();
						awaiter2 = GForm3.smethod_11(GClass0.string_2, false, true).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num6 = 1;
							num = 1;
							this.int_0 = num6;
							this.taskAwaiter_1 = awaiter2;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GForm3.Struct5>(ref awaiter2, ref this);
							break;
						}
						IL_D9:
						string result = awaiter2.GetResult();
						if (!(result != Class185.smethod_0(537706979)) || !(result != Class185.smethod_0(537710733)))
						{
							continue;
						}
						this.int_1 = 5;
						this.int_2 = 0;
						IL_139:
						if (this.int_1 <= this.int_2)
						{
							GClass0.string_2 = null;
							GClass0.smethod_2();
							GForm1.gform1_0.method_9(null, null);
							continue;
						}
						GForm1.webView_0.QueueScriptCall(Class185.smethod_0(537708504) + (this.int_1 - this.int_2).ToString() + Class185.smethod_0(537708322));
						awaiter = Task.Delay(1000).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num7 = 2;
							num = 2;
							this.int_0 = num7;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GForm3.Struct5>(ref awaiter, ref this);
							break;
						}
						IL_19A:
						awaiter.GetResult();
						int num8 = this.int_2;
						this.int_2 = num8 + 1;
						goto IL_139;
					}
					catch
					{
					}
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
			}
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00003F36 File Offset: 0x00002136
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000107 RID: 263
		public int int_0;

		// Token: 0x04000108 RID: 264
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000109 RID: 265
		private TaskAwaiter taskAwaiter_0;

		// Token: 0x0400010A RID: 266
		private TaskAwaiter<string> taskAwaiter_1;

		// Token: 0x0400010B RID: 267
		private int int_1;

		// Token: 0x0400010C RID: 268
		private int int_2;
	}

	// Token: 0x0200005C RID: 92
	[StructLayout(LayoutKind.Auto)]
	private struct Struct6 : IAsyncStateMachine
	{
		// Token: 0x0600020C RID: 524 RVA: 0x00014618 File Offset: 0x00012818
		void IAsyncStateMachine.MoveNext()
		{
			int num2;
			int num = num2;
			GForm3 gform = this;
			try
			{
				TaskAwaiter<string> taskAwaiter;
				if (num != 0)
				{
					gform.bunifuFlatButton_0.ButtonText = Class185.smethod_0(537708238);
					taskAwaiter = GForm3.smethod_11(gform.bunifuMetroTextbox_0.Text, true, false).GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						num2 = 0;
						TaskAwaiter<string> taskAwaiter2 = taskAwaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GForm3.Struct6>(ref taskAwaiter, ref this);
						return;
					}
				}
				else
				{
					TaskAwaiter<string> taskAwaiter2;
					taskAwaiter = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter<string>);
					num2 = -1;
				}
				string result = taskAwaiter.GetResult();
				if (result == Class185.smethod_0(537706979))
				{
					GClass0.string_2 = gform.bunifuMetroTextbox_0.Text;
					GClass0.smethod_2();
					gform.bunifuMetroTextbox_0.BorderColorFocused = Color.Green;
					gform.bunifuMetroTextbox_0.BorderColorIdle = Color.Green;
					gform.bunifuMetroTextbox_0.BorderColorMouseHover = Color.Green;
					gform.bunifuCustomLabel_0.Text = Class185.smethod_0(537708276);
					gform.bunifuCustomLabel_0.ForeColor = Color.Green;
					gform.method_1();
					new GForm5(true, result);
				}
				else if (result == Class185.smethod_0(537708475))
				{
					gform.bunifuMetroTextbox_0.BorderColorFocused = Color.Red;
					gform.bunifuMetroTextbox_0.BorderColorIdle = Color.Red;
					gform.bunifuMetroTextbox_0.BorderColorMouseHover = Color.Red;
					gform.bunifuCustomLabel_0.Text = Class185.smethod_0(537708037);
					gform.bunifuCustomLabel_0.ForeColor = Color.Red;
				}
				else if (result == Class185.smethod_0(537708458))
				{
					gform.bunifuMetroTextbox_0.BorderColorFocused = Color.Red;
					gform.bunifuMetroTextbox_0.BorderColorIdle = Color.Red;
					gform.bunifuMetroTextbox_0.BorderColorMouseHover = Color.Red;
					gform.bunifuCustomLabel_0.Text = Class185.smethod_0(537708148);
					gform.bunifuCustomLabel_0.ForeColor = Color.Red;
				}
				else if (result == Class185.smethod_0(537710733))
				{
					gform.bunifuMetroTextbox_0.BorderColorFocused = Color.Red;
					gform.bunifuMetroTextbox_0.BorderColorIdle = Color.Red;
					gform.bunifuMetroTextbox_0.BorderColorMouseHover = Color.Red;
					gform.bunifuCustomLabel_0.Text = Class185.smethod_0(537707929);
					gform.bunifuCustomLabel_0.ForeColor = Color.Red;
				}
				gform.bunifuFlatButton_0.ButtonText = Class185.smethod_0(537707996);
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

		// Token: 0x0600020D RID: 525 RVA: 0x00003F44 File Offset: 0x00002144
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400010D RID: 269
		public int int_0;

		// Token: 0x0400010E RID: 270
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400010F RID: 271
		public GForm3 gform3_0;

		// Token: 0x04000110 RID: 272
		private TaskAwaiter<string> taskAwaiter_0;
	}

	// Token: 0x0200005D RID: 93
	[StructLayout(LayoutKind.Auto)]
	private struct Struct7 : IAsyncStateMachine
	{
		// Token: 0x0600020E RID: 526 RVA: 0x000148E0 File Offset: 0x00012AE0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter<HttpResponseMessage> awaiter;
				if (num != 0)
				{
					awaiter = new Class70(null, Class185.smethod_0(537692910), 10, false, false, null, false).method_6(string.Format(Class185.smethod_0(537708169), Class173.struct42_1.method_1(), Class173.struct42_0.method_1(), GClass0.string_2), false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GForm3.Struct7>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
					this.int_0 = -1;
				}
				awaiter.GetResult();
				GClass0.string_2 = null;
				GClass0.smethod_2();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00003F52 File Offset: 0x00002152
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000111 RID: 273
		public int int_0;

		// Token: 0x04000112 RID: 274
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000113 RID: 275
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;
	}
}
