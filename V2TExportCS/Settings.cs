using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace OdbcExporter.Properties
{
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
	internal sealed class Settings : ApplicationSettingsBase
	{
		private static Settings defaultInstance;

		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		public static Settings DefaultOriginal
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
        public string ConnectionString
        {
            get
            {
                return (string)this["ConnectionString"];
            }
        }

        [UserScopedSetting]
		public string ExportList
		{
			get
			{
				return (string)this["ExportList"];
			}
			set
			{
				this["ExportList"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string FoldertoExport
		{
			get
			{
				return (string)this["FoldertoExport"];
			}
			set
			{
				this["FoldertoExport"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool IncludeErrors
		{
			get
			{
				return (bool)this["IncludeErrors"];
			}
			set
			{
				this["IncludeErrors"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string Logfile
		{
			get
			{
				return (string)this["Logfile"];
			}
			set
			{
				this["Logfile"] = value;
			}
		}

		public int CommandTimeout
		{
			get
			{
				return (int)this["CommandTimeout"];
			}
			set
			{
				this["CommandTimeout"] = value;
			}
		}

		static Settings()
		{
			Settings.defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
		}

		public Settings()
		{
		}

		private void SettingChangingEventHandler(object sender, SettingChangingEventArgs e)
		{
		}

		private void SettingsSavingEventHandler(object sender, CancelEventArgs e)
		{
		}
	}
}