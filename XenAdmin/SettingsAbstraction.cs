using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace XenAdmin
{
	public class SettingsAbstraction
    {
		public bool ToolbarsEnabled
        {
            get
            {
				return _getValue<bool>("ToolbarsEnabled");            
            }
            set
            {
				_setValue("ToolbarsEnabled", value);            
            }
        }

		public bool SaveSession
        {
            get
            {
				return _getValue<bool>("SaveSession");
            }
            set
            {
				_setValue("SaveSession", value);
            }
        }

		public global::System.Windows.Forms.AutoCompleteStringCollection ServerHistory
		{
			get
			{
				return _getValue<global::System.Windows.Forms.AutoCompleteStringCollection>("ServerHistory");
			}
			set
			{
				_setValue<global::System.Windows.Forms.AutoCompleteStringCollection>("ServerHistory", value);
			}
		}

		public string[] ServerList
        {
            get
            {
				return _getValue<string[]>("ServerList");
            }
            set
            {
				_setValue<string[]>("ServerList", value);
            }
        }

		public bool RequirePass
        {
            get
            {
				return _getValue <bool>("RequirePass");
            }
            set
            {
				_setValue<bool>("RequirePass", value);
            }
        }

		public string[] ServerAddressList
        {
            get
            {
				return _getValue <string[]>("ServerAddressList");
            }
            set
            {
				_setValue<string[]>("ServerAddressList", value);
            }
        }

		public string[] KnownServers
        {
            get
            {
				return _getValue <string[]>("KnownServers");
            }
            set
            {
				_setValue<string[]>("KnownServers", value);
            }
        }

		public bool AllowXenCenterUpdates
        {
            get
            {
				return _getValue <bool>("AllowXenCenterUpdates");
            }
            set
            {
				_setValue<bool>("AllowXenCenterUpdates", value);
            }
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

		public static void Save()
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
				SettingsAbstraction sa = new SettingsAbstraction();
				sa.RequirePass = false;
				sa.SaveSession = true;
				sa.ToolbarsEnabled = true;
				return sa;
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
                    return default(t);
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
