using System;
using System.Runtime.InteropServices;
using System.Text;

namespace XenAdmin.Core
{
	public class NativeCallsWin32 : INativeCalls
	{
		private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		public void SetLastError(uint dwErrCode){
			_SetLastError (dwErrCode);
		}

		[DllImport("kernel32.dll", EntryPoint="SetLastError")]
		static extern void _SetLastError(uint dwErrCode);


		public int GetGuiResources (IntPtr hProcess, int uiFlags)
		{
			return _GetGuiResources (hProcess, uiFlags);
		}

		/// From George Shepherd's Windows Forms FAQ:
		/// http://www.syncfusion.com/FAQ/WindowsForms/FAQ_c73c.aspx
		/// 
		/// uiFlags: 0 - Count of GDI objects 
		/// uiFlags: 1 - Count of USER objects 
		/// - Win32 GDI objects (pens, brushes, fonts, palettes, regions, device contexts, bitmap headers) 
		/// - Win32 USER objects: 
		///      - WIN32 resources (accelerator tables, bitmap resources, dialog box templates, font resources, menu resources, raw data resources, string table entries, message table entries, cursors/icons) 
		/// - Other USER objects (windows, menus) 
		/// 
		[DllImport ("User32", EntryPoint="GetGuiResources")]
		extern static public int _GetGuiResources (IntPtr hProcess, int uiFlags);

		public bool GetScrollInfo(IntPtr hWnd, int n, ref Win32.ScrollInfo lpScrollInfo)
		{
			return _GetScrollInfo(hWnd, n, ref lpScrollInfo);
		}

		/// <summary>
		/// See http://msdn2.microsoft.com/en-us/library/bb787583.aspx and
		/// http://pinvoke.net/default.aspx/user32/GetScrollInfo.html
		/// </summary>
		[DllImport("user32.dll", EntryPoint="GetScrollInfo")]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool _GetScrollInfo(IntPtr hWnd, int n, ref Win32.ScrollInfo lpScrollInfo);


		public IntPtr CreateCompatibleDC(IntPtr hdc)
		{
			return _CreateCompatibleDC (hdc);
		}

		[DllImport("gdi32.dll", EntryPoint="CreateCompatibleDC")]
		static extern IntPtr _CreateCompatibleDC(IntPtr hdc);



		// #################################################################################################

		public string GetUniqueIdHash()
		{
			string uniqueIdHash = "nil";

			try
			{
				var managementObj = new System.Management.ManagementObject("Win32_OperatingSystem=@");
				string serialNumber = (string)managementObj["SerialNumber"];

				if (!string.IsNullOrWhiteSpace(serialNumber))
				{
					var serialBytes = Encoding.ASCII.GetBytes(serialNumber);

					using (var md = new System.Security.Cryptography.MD5CryptoServiceProvider()) // MD5 to keep it short enough as this hash is not used for security in any way
					{
						var hash = md.ComputeHash(serialBytes);
						uniqueIdHash = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
					}
				}
			}
			catch (Exception ex)
			{
				log.Error(ex);
			}

			return uniqueIdHash;
		}
	}
}

