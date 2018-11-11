using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace CyberAIO.Properties
{
	// Token: 0x02000135 RID: 309
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.7.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600077F RID: 1919 RVA: 0x00006B66 File Offset: 0x00004D66
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x00006B6D File Offset: 0x00004D6D
		// (set) Token: 0x06000781 RID: 1921 RVA: 0x00006B84 File Offset: 0x00004D84
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string LicenseKey
		{
			get
			{
				return (string)this[Class185.smethod_0(537715941)];
			}
			set
			{
				this[Class185.smethod_0(537715941)] = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x00006B97 File Offset: 0x00004D97
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x00006BAE File Offset: 0x00004DAE
		[DefaultSettingValue("2500")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public int retry_delay
		{
			get
			{
				return (int)this[Class185.smethod_0(537714228)];
			}
			set
			{
				this[Class185.smethod_0(537714228)] = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x00006BC6 File Offset: 0x00004DC6
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x00006BDD File Offset: 0x00004DDD
		[DebuggerNonUserCode]
		[DefaultSettingValue("2500")]
		[UserScopedSetting]
		public int monitor_delay
		{
			get
			{
				return (int)this[Class185.smethod_0(537699262)];
			}
			set
			{
				this[Class185.smethod_0(537699262)] = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x00006BF5 File Offset: 0x00004DF5
		// (set) Token: 0x06000787 RID: 1927 RVA: 0x00006C0C File Offset: 0x00004E0C
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string UniqueID
		{
			get
			{
				return (string)this[Class185.smethod_0(537715734)];
			}
			set
			{
				this[Class185.smethod_0(537715734)] = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x00006C1F File Offset: 0x00004E1F
		// (set) Token: 0x06000789 RID: 1929 RVA: 0x00006C36 File Offset: 0x00004E36
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string profiles
		{
			get
			{
				return (string)this[Class185.smethod_0(537701485)];
			}
			set
			{
				this[Class185.smethod_0(537701485)] = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x00006C49 File Offset: 0x00004E49
		// (set) Token: 0x0600078B RID: 1931 RVA: 0x00006C60 File Offset: 0x00004E60
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string proxies
		{
			get
			{
				return (string)this[Class185.smethod_0(537701503)];
			}
			set
			{
				this[Class185.smethod_0(537701503)] = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x00006C73 File Offset: 0x00004E73
		// (set) Token: 0x0600078D RID: 1933 RVA: 0x00006C8A File Offset: 0x00004E8A
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string tasks
		{
			get
			{
				return (string)this[Class185.smethod_0(537701443)];
			}
			set
			{
				this[Class185.smethod_0(537701443)] = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x00006C9D File Offset: 0x00004E9D
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x00006CB4 File Offset: 0x00004EB4
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string user
		{
			get
			{
				return (string)this[Class185.smethod_0(537715717)];
			}
			set
			{
				this[Class185.smethod_0(537715717)] = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x00006CC7 File Offset: 0x00004EC7
		// (set) Token: 0x06000791 RID: 1937 RVA: 0x00006CDE File Offset: 0x00004EDE
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool UpgradeRequired
		{
			get
			{
				return (bool)this[Class185.smethod_0(537715760)];
			}
			set
			{
				this[Class185.smethod_0(537715760)] = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x00006CF6 File Offset: 0x00004EF6
		// (set) Token: 0x06000793 RID: 1939 RVA: 0x00006D0D File Offset: 0x00004F0D
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string webhook
		{
			get
			{
				return (string)this[Class185.smethod_0(537699234)];
			}
			set
			{
				this[Class185.smethod_0(537699234)] = value;
			}
		}

		// Token: 0x04000524 RID: 1316
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
