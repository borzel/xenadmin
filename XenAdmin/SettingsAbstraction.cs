using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace XenAdmin
{
	public class SettingsAbstraction
	{
		public bool ToolbarsEnabled
		{
			get{return _getValue<bool>("ToolbarsEnabled");}
			set{_setValue("ToolbarsEnabled", value);}
		}

		public bool SaveSession
		{
			get{return _getValue<bool>("SaveSession");}
			set{_setValue("SaveSession", value);}
		}

		public global::System.Windows.Forms.AutoCompleteStringCollection ServerHistory
		{
			get{return _getValue<global::System.Windows.Forms.AutoCompleteStringCollection>("ServerHistory");}
			set{_setValue<global::System.Windows.Forms.AutoCompleteStringCollection>("ServerHistory", value);}
		}

		public string[] ServerList
		{
			get{return _getValue<string[]>("ServerList");}
			set{_setValue<string[]>("ServerList", value);}
		}

		public bool LocalSRsVisible
        {
			get { return _getValue<bool>("LocalSRsVisible"); }
			set { _setValue<bool>("LocalSRsVisible", value); }
        }

		public bool DefaultTemplatesVisible
        {
			get { return _getValue<bool>("DefaultTemplatesVisible"); }
			set { _setValue<bool>("DefaultTemplatesVisible", value); }
        }

		public bool UserTemplatesVisible
        {
			get { return _getValue<bool>("UserTemplatesVisible"); }
			set { _setValue<bool>("UserTemplatesVisible", value); }
        }

		public bool DebugHelp
        {
			get { return _getValue<bool>("DebugHelp"); }
			set { _setValue<bool>("DebugHelp", value); }
        }

		public global::System.Drawing.Size WindowSize
        {
			get { return _getValue<global::System.Drawing.Size>("WindowSize"); }
			set { _setValue<global::System.Drawing.Size>("WindowSize", value); }
        }

		public global::System.Drawing.Point WindowLocation
        {
			get { return _getValue<global::System.Drawing.Point>("WindowLocation"); }
			set { _setValue<global::System.Drawing.Point>("WindowLocation", value); }
        }

		public bool RequirePass
		{
			get{return _getValue<bool>("RequirePass");}
			set{_setValue<bool>("RequirePass", value);}
		}

		public int FullScreenShortcutKey
        {
			get { return _getValue<int>("FullScreenShortcutKey"); }
			set { _setValue<int>("FullScreenShortcutKey", value); }
        }

		public bool WindowsShortcuts
        {
			get { return _getValue<bool>("WindowsShortcuts"); }
			set { _setValue<bool>("WindowsShortcuts", value); }
        }

		public bool ReceiveSoundFromRDP
        {
			get { return _getValue<bool>("ReceiveSoundFromRDP"); }
			set { _setValue<bool>("ReceiveSoundFromRDP", value); }
        }

		public bool AutoSwitchToRDP
        {
			get { return _getValue<bool>("AutoSwitchToRDP"); }
			set { _setValue<bool>("AutoSwitchToRDP", value); }
        }

		public bool PreserveScaleWhenUndocked
        {
			get { return _getValue<bool>("PreserveScaleWhenUndocked"); }
			set { _setValue<bool>("PreserveScaleWhenUndocked", value); }
        }

		public int ProxySetting
        {
			get { return _getValue<int>("ProxySetting"); }
			set { _setValue<int>("ProxySetting", value); }
        }

		public string ProxyAddress
        {
			get { return _getValue<string>("ProxyAddress"); }
			set { _setValue<string>("ProxyAddress", value); }
        }

		public int ProxyPort
        {
			get { return _getValue<int>("ProxyPort"); }
			set { _setValue<int>("ProxyPort", value); }
        }

		public bool PreserveScaleWhenSwitchBackToVNC
        {
			get { return _getValue<bool>("PreserveScaleWhenSwitchBackToVNC"); }
			set { _setValue<bool>("PreserveScaleWhenSwitchBackToVNC", value); }
        }

		public int ConnectionTimeout
        {
			get { return _getValue<int>("ConnectionTimeout"); }
			set { _setValue<int>("ConnectionTimeout", value); }
        }

		public int HttpTimeout
        {
			get { return _getValue<int>("HttpTimeout"); }
			set { _setValue<int>("HttpTimeout", value); }
        }

		public bool ShowHiddenVMs
        {
			get { return _getValue<bool>("ShowHiddenVMs"); }
			set { _setValue<bool>("ShowHiddenVMs", value); }
		}

		public bool ClipboardAndPrterRedirection
        {
			get { return _getValue<bool>("ClipboardAndPrinterRedirection"); }
			set { _setValue<bool>("ClipboardAndPrinterRedirection", value); }
        }

		public int DockShortcutKey
        {
			get { return _getValue<int>("DockShortcutKey"); }
			set { _setValue<int>("DockShorutKey", value); }
        }
      
		public string[] ServerAddressList
		{
			get{return _getValue<string[]>("ServerAddressList");}
			set{_setValue<string[]>("ServerAddressList", value);}
		}

		public bool ConnectToServerConsole
        {
			get { return _getValue<bool>("ConnectToServerConsole"); }
			set { _setValue<bool>("ConnectToServerConsole", value); }
        }

		public bool WarnUnrecognizedCertificate
        {
			get { return _getValue<bool>("WarnUnrecognizedCertificate"); }
			set { _setValue<bool>("WarnUnrecognizedCertificate", value); }
        }      

		public string[] KnownServers
		{
			get{ return _getValue<string[]>("KnownServers");}
			set{ _setValue<string[]>("KnownServers", value);}
		}

		public bool WarnChangedCertificate
        {
			get { return _getValue<bool>("WarnChangedCertificate"); }
			set { _setValue<bool>("WarnChangedCertificate", value); }
        }

		public bool AllowXenCenterUpdates
		{
			get { return _getValue<bool>("AllowXenCenterUpdates"); }
			set { _setValue<bool>("AllowXenCenterUpdates", value); }
		}

		public bool AllowPatchesUpdates
        {
			get { return _getValue<bool>("AllowPatchesUpdates"); }
			set { _setValue<bool>("AllowPatchesUpdates", value); }
        }

		public bool AllowXenServerUpdates
        {
			get { return _getValue<bool>("AllowXenServerUpdates"); }
			set { _setValue<bool>("AllowXenServerUpdates", value); }
        }

		public string LatestXenCenterSeen
        {
			get { return _getValue<string>("LatestXenCenterSeen"); }
			set { _setValue<string>("LatestXenCenterSeen", value); }
        }      

		public bool SeenAllowUpdatesDialog
        {
			get { return _getValue<bool>("SeenAllowUpdatesDialog"); }
			set { _setValue<bool>("SeenAllowUpdatesDialog", value); }
        }

		public bool FillAreaUnderGraphs
        {
			get { return _getValue<bool>("FillAreaUnderGraphs"); }
			set { _setValue<bool>("FillAreaUnderGraphs", value); }
        }

		public string DefaultSearch
        {
			get { return _getValue<string>("DefaultSearch"); }
			set { _setValue<string>("DefaultSearch", value); }
        }

		public bool LoadPlugins
        {
			get { return _getValue<bool>("LoadPlugins"); }
			set { _setValue<bool>("LoadPlugins", value); }
        }

		public string[] DisabledPlugins
        {
			get { return _getValue<string[]>("DisabledPlugins"); }
			set { _setValue<string[]>("DisabledPlugins", value); }
        }

		public string[] CslgCredentials
        {
			get { return _getValue<string[]>("CslgCredentials"); }
			set { _setValue<string[]>("CslgCredentials", value); }
        }

		public string[] IgnoreFirstRunWizards
        {
			get { return _getValue<string[]>("IgnoreFirstRunWizards"); }
			set { _setValue<string[]>("IgnoreFirstRunWizards", value); }
        }

		public string ServerStatusPath
        {
			get { return _getValue<string>("ServerStatusPath"); }
			set { _setValue<string>("ServerStatusPath", value); }
        }

		public bool RollingUpgradeWizardShowFirstPage
        {
			get { return _getValue<bool>("RollingUpgradeWizardShowFirstPage"); }
			set { _setValue<bool>("RollingUpgradeWizardShowFirstPage", value); }
        }

		public bool EnableRDPPolling
        {
			get { return _getValue<bool>("EnableRDPPolling"); }
			set { _setValue<bool>("EnableRDPPolling", value); }
        }

		public string ApplicationVersion
        {
			get { return _getValue<string>("ApplicationVersion"); }
			set { _setValue<string>("ApplicationVersion", value); }
        }

		public int UncaptureShortcutKey
        {
			get { return _getValue<int>("UncaptureShortcutKey"); }
			set { _setValue<int>("UncaptureShortcutKey", value); }
        }

		public bool DRFailoverWizardShowFirstPage
        {
			get { return _getValue<bool>("DRFailoverWizardShowFirstPage"); }
			set { _setValue<bool>("DRFailoverWizardShowFirstPage", value); }
        }

		public bool PinConnectionBar
        {
			get { return _getValue<bool>("PinConnectionBar"); }
			set { _setValue<bool>("PinConnectionBar", value); }
        }

		public bool ShowHealthCheckEnrollmentReminder
        {
			get { return _getValue<bool>("ShowHealthCheckEnrollmentReminder"); }
			set { _setValue<bool>("ShowHealthCheckEnrollmentReminder", value); }
        }

		public bool ShowJustHostInSearch
		{
			get { return _getValue<bool>("ShowJustHostInSearch"); }
			set { _setValue<bool>("ShowJustHostInSearch", value); }
		}

		public bool ShowAboutDialog
        {
			get { return _getValue<bool>("ShowAboutDialog"); }
			set { _setValue<bool>("ShowAboutDialog", value); }
        }

		public bool ProvideProxyAuthentication
        {
			get { return _getValue<bool>("ProvideProxyAuthentication"); }
			set { _setValue<bool>("ProvideProxyAuthentication", value); }
        }

		public string ProxyUsername
        {
			get { return _getValue<string>("ProxyUsername"); }
			set { _setValue<string>("ProxyUsername", value); }
        }

		public string ProxyPassword
        {
			get { return _getValue<string>("ProxyPassword"); }
			set { _setValue<string>("ProxyPassword", value); }
        }

		public bool BypassProxyForServers
        {
			get { return _getValue<bool>("BypassProxyForServers"); }
			set { _setValue<bool>("BypassProxyForServers", value); }
        }

		public int ProxyAuthenticationMethod
        {
			get { return _getValue<int>("ProxyAuthenticationMethod"); }
			set { _setValue<int>("ProxyAuthenticationMethod", value); }
        }

		public bool DoNotConfirmDismissAlerts
        {
			get { return _getValue<bool>("DoNotConfirmDismissAlerts"); }
			set { _setValue<bool>("DoNotConfirmDismissAlerts", value); }
        }

		public bool DoNotConfirmDismissEvents
        {
			get { return _getValue<bool>("DoNotConfirmDismissEvents"); }
			set { _setValue<bool>("DoNotConfirmDismissEvents", value); }
        }

		public bool DoNotConfirmDismissUpdates
        {
			get { return _getValue<bool>("DoNotConfirmDismissUpdates"); }
			set { _setValue<bool>("DoNotConfirmDismissUpdates", value); }
        }

		public string HelpLastUsed
        {
			get { return _getValue<string>("HelpLastUsed"); }
			set { _setValue<string>("HelpLastUsed", value); }
        }

		public bool EjectSharedIsoOnUpdate
        {
			get { return _getValue<bool>("EjectSharedIsoOnUpdate"); }
			set { _setValue<bool>("EjectSharedIsoOnUpdate", value); }
        }

		public bool ClipboardAndPrinterRedirection
        {
			get { return _getValue<bool>("ClipboardAndPrinterRedirection"); }
			set { _setValue<bool>("ClipboardAndPrinterRedirection", value); }
        }


		// ######################################################################################

		Dictionary<string, object> _settings = new Dictionary<string, object>();
		Type _PSD = Properties.Settings.Default.GetType();
		static bool _isMono = (Environment.OSVersion.Platform == PlatformID.Unix);
		static string _settingsFile = "/tmp/center.settings";

		private static SettingsAbstraction _instance = null;

		public static SettingsAbstraction Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = Load();
				}

				return _instance;
			}
		}

		public void Save()
		{
			if (_isMono)
			{
				System.Xml.Serialization.XmlSerializer writer =
						  new System.Xml.Serialization.XmlSerializer(typeof(SettingsAbstraction));
				System.IO.FileStream file = System.IO.File.Create(_settingsFile);

				writer.Serialize(file, Instance);
				file.Close();
			}
			else
			{
				Properties.Settings.Default.Save();
			}
		}

		static SettingsAbstraction Load()
		{
			if (_isMono && System.IO.File.Exists(_settingsFile))
			{
				System.Xml.Serialization.XmlSerializer reader =
						  new System.Xml.Serialization.XmlSerializer(typeof(SettingsAbstraction));

				System.IO.FileStream file = System.IO.File.OpenRead(_settingsFile);
				return (SettingsAbstraction)reader.Deserialize(file);
			}
			else
			{
				return new SettingsAbstraction();
			}

		}

		t _getValue<t>(string key)
		{
			if (_isMono)
			{
				object o;
				if (_settings.TryGetValue(key, out o))
					return (t)o;
				else
				{
					//return default(t);
					return (t)_PSD.GetProperty(key).GetValue(Properties.Settings.Default);
				}
			}
			else
			{
				return (t)_PSD.GetProperty(key).GetValue(Properties.Settings.Default);
			}
		}

		void _setValue<t>(string key, t value)
		{
			if (_isMono)
			{
				if (_settings.ContainsKey(key))
				{
					_settings[key] = value;
				}
				else
				{
					_settings.Add(key, value);
				}
			}
			else
			{
				_PSD.GetProperty(key).SetValue(Properties.Settings.Default, value);
			}
		}
	}
}
