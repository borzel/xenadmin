using System;
using System.Runtime.InteropServices;

namespace XenAdmin.Core
{
	public static class NativeCalls
	{
		private static INativeCalls _instance = null;

		public static INativeCalls Instance 
		{
			get{
				if (_instance == null) {
					if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
						_instance = new NativeCallsWin32 ();
					} else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) {
						_instance = new NativeCallsLinux ();
					}
				}

				return _instance;
			}
		}
	}
}

