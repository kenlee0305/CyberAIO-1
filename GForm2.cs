using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using EO.WebBrowser;

// Token: 0x02000035 RID: 53
public sealed partial class GForm2 : Form
{
	// Token: 0x06000147 RID: 327 RVA: 0x00003921 File Offset: 0x00001B21
	public GForm2()
	{
		this.method_1();
		this.method_0(null);
	}

	// Token: 0x06000148 RID: 328 RVA: 0x00003936 File Offset: 0x00001B36
	public void method_0(string string_0)
	{
		this.webView_0 = new WebView();
		this.webView_0.Create(this.panel_0.Handle);
		this.webView_0.LoadUrl(Class185.smethod_0(537691677));
	}

	// Token: 0x06000149 RID: 329 RVA: 0x0000396F File Offset: 0x00001B6F
	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		base.OnFormClosing(e);
		if (e.CloseReason == CloseReason.UserClosing)
		{
			e.Cancel = true;
			base.Hide();
		}
	}

	// Token: 0x0600014A RID: 330 RVA: 0x0000398E File Offset: 0x00001B8E
	private void bunifuDropdown_0_onItemSelected(object sender, EventArgs e)
	{
		this.webView_0.Dispose();
		this.method_0(this.bunifuDropdown_0.selectedValue);
	}

	// Token: 0x0600014C RID: 332 RVA: 0x0000F4E4 File Offset: 0x0000D6E4
	private void method_1()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm2));
		this.panel_0 = new Panel();
		this.panel_1 = new Panel();
		this.bunifuDropdown_0 = new BunifuDropdown();
		this.panel_0.SuspendLayout();
		this.panel_1.SuspendLayout();
		base.SuspendLayout();
		this.panel_0.BackColor = Color.White;
		this.panel_0.Controls.Add(this.panel_1);
		this.panel_0.Dock = DockStyle.Fill;
		this.panel_0.Location = new Point(0, 0);
		this.panel_0.Name = Class185.smethod_0(537704240);
		this.panel_0.Size = new Size(738, 720);
		this.panel_0.TabIndex = 0;
		this.panel_1.Controls.Add(this.bunifuDropdown_0);
		this.panel_1.Dock = DockStyle.Bottom;
		this.panel_1.Location = new Point(0, 659);
		this.panel_1.Name = Class185.smethod_0(537707205);
		this.panel_1.Size = new Size(738, 61);
		this.panel_1.TabIndex = 14;
		this.panel_1.Visible = false;
		this.bunifuDropdown_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.bunifuDropdown_0.BackColor = Color.Transparent;
		this.bunifuDropdown_0.BackgroundImageLayout = ImageLayout.None;
		this.bunifuDropdown_0.BorderRadius = 0;
		this.bunifuDropdown_0.DisabledColor = Color.FromArgb(44, 186, 118);
		this.bunifuDropdown_0.Font = new Font(Class185.smethod_0(537705197), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.bunifuDropdown_0.ForeColor = Color.FromArgb(44, 186, 118);
		this.bunifuDropdown_0.items = new string[]
		{
			Class185.smethod_0(537707250),
			Class185.smethod_0(537707234),
			Class185.smethod_0(537707027),
			Class185.smethod_0(537707011)
		};
		this.bunifuDropdown_0.Location = new Point(292, 13);
		this.bunifuDropdown_0.Margin = new Padding(4, 4, 4, 4);
		this.bunifuDropdown_0.Name = Class185.smethod_0(537707059);
		this.bunifuDropdown_0.NomalColor = Color.Transparent;
		this.bunifuDropdown_0.onHoverColor = Color.Transparent;
		this.bunifuDropdown_0.selectedIndex = -1;
		this.bunifuDropdown_0.Size = new Size(170, 35);
		this.bunifuDropdown_0.TabIndex = 12;
		this.bunifuDropdown_0.Visible = false;
		this.bunifuDropdown_0.onItemSelected += this.bunifuDropdown_0_onItemSelected;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(738, 720);
		base.Controls.Add(this.panel_0);
		base.Icon = (Icon)componentResourceManager.GetObject(Class185.smethod_0(537704548));
		base.Name = Class185.smethod_0(537707098);
		this.Text = Class185.smethod_0(537707085);
		this.panel_0.ResumeLayout(false);
		this.panel_1.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	// Token: 0x040000A8 RID: 168
	public WebView webView_0;

	// Token: 0x040000AA RID: 170
	private Panel panel_0;

	// Token: 0x040000AB RID: 171
	private BunifuDropdown bunifuDropdown_0;

	// Token: 0x040000AC RID: 172
	private Panel panel_1;
}
