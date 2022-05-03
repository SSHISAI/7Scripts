using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace _7Scripts
{
    internal class Sleep
    {
        [DllImport("Kernel32.dll")] public static extern bool QueryPerformanceCounter(out long lpPerformanceCount);
        [DllImport("Kernel32.dll")] public static extern bool QueryPerformanceFrequency(out long lpFrequency);

        public static void PerciseSleep(int ms)
        {
            QueryPerformanceFrequency(out long timerResolution);
            timerResolution /= 1000;

            QueryPerformanceCounter(out long currentTime);
            long wantedTime = currentTime / timerResolution + ms;
            currentTime = 0;
            while (currentTime < wantedTime)
            {
                QueryPerformanceCounter(out currentTime);
                currentTime /= timerResolution;
            }
        }
    }
}
