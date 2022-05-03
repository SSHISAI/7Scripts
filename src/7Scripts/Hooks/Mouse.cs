using System.Runtime.InteropServices;

namespace _7Scripts
{
	class Mouse
	{
		[DllImport("user32.dll")]
		static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

		public static void RelativeMove(int relx, int rely)
		{
			mouse_event(0x0001, relx, rely, 0, 0);
		}
	}
}
