using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Media;

namespace Timed_Shutdown
{
    public class Actions
    {

        SoundPlayer sndplayer = new SoundPlayer(@"E:\workspace\misc-timer\misc-timer\Resources\Sounds\extreme_alarm.wav");

        public void ShutDownComputer(int flag)
        {
            ManagementBaseObject mboShutdown = null;
            ManagementClass mcWin32 = new ManagementClass("Win32_OperatingSystem");
            mcWin32.Get();
            // You can't shutdown without security privileges
            mcWin32.Scope.Options.EnablePrivileges = true;
            ManagementBaseObject mboShutdownParams = mcWin32.GetMethodParameters("Win32Shutdown");
            // Flag 1 means we want to shut down the system
            mboShutdownParams["Flags"] = flag;
            mboShutdownParams["Reserved"] = "0";
            foreach (ManagementObject manObj in mcWin32.GetInstances())
            {
                mboShutdown = manObj.InvokeMethod("Win32Shutdown", mboShutdownParams, null);
            }
        }

        public void Alarm()
        {
            sndplayer.Play();
        }
    }
}
