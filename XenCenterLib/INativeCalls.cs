using System;

namespace XenAdmin.Core
{
	public interface INativeCalls
	{
		void SetLastError(uint dwErrCode);
		int GetGuiResources(IntPtr hProcess, int uiFlags);
		bool GetScrollInfo(IntPtr hWnd, int n, ref Win32.ScrollInfo lpScrollInfo);
		IntPtr CreateCompatibleDC(IntPtr hdc);

		string GetUniqueIdHash();
	}
}

