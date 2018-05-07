using System;
using System.Runtime.InteropServices;

namespace XenAdmin.Core
{
	public class NativeCallsLinux : INativeCalls
	{
		private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		public void SetLastError(uint dwErrCode){
			// TODO: Linux: Implement SetLastError
		}

		public int GetGuiResources (IntPtr hProcess, int uiFlags)
		{
			//return 0;
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
		[DllImport ("User32", EntryPoint = "GetGuiResources", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		extern static public int _GetGuiResources (IntPtr hProcess, int uiFlags);



		public bool GetScrollInfo(IntPtr hWnd, int n, ref Win32.ScrollInfo lpScrollInfo)
		{
			// TODO: linux GetScrollInfo implementation
			if (false)
			{
				lpScrollInfo.cbSize = 0;
				lpScrollInfo.fMask = 0;
				lpScrollInfo.nMin = 0;
				lpScrollInfo.nMax = 0;
				lpScrollInfo.nPage = 0;
				lpScrollInfo.nPos = 0;
				lpScrollInfo.nTrackPos = 0;
				return true;
			}
			else
			{
				return _GetScrollInfo(hWnd, n, ref lpScrollInfo);
			}
		}

		/// <summary>
		/// See http://msdn2.microsoft.com/en-us/library/bb787583.aspx and
		/// http://pinvoke.net/default.aspx/user32/GetScrollInfo.html
		/// </summary>
		[DllImport("user32.dll", EntryPoint="GetScrollInfo", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool _GetScrollInfo(IntPtr hWnd, int n, ref Win32.ScrollInfo lpScrollInfo);


		public IntPtr CreateCompatibleDC(IntPtr hdc)
		{
			return _CreateCompatibleDC (hdc);
//			IntPtr p = IntPtr.Zero;
//
//			try{
//				
//			} catch(Exception ex) {
//				log.Error(ex);
//			}

			//return p;
		}

		[DllImport("gdi32.dll", EntryPoint="CreateCompatibleDC", CallingConvention=CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		static extern IntPtr _CreateCompatibleDC (IntPtr hdc);
	



		// ##########################################################################################

		public string GetUniqueIdHash()
		{
			return System.Guid.NewGuid().ToString();
		}
	}
}

