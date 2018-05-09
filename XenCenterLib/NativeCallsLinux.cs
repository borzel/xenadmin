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
			return 0;         
		}

        public bool GetScrollInfo(IntPtr hWnd, int n, ref Win32.ScrollInfo lpScrollInfo)
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

        public IntPtr CreateCompatibleDC(IntPtr hdc)
		{
			throw new NotImplementedException();         
		}


		// ##########################################################################################

		public string GetUniqueIdHash()
		{
			// TODO: do it real unique 
			return "im-not-a-areal-unique-hash";
		}
	}
}

