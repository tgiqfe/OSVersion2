using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using OSVersion2.Windows;

namespace OSVersion2
{
    internal class OSVersion
    {
        #region GetCurrent method

        /// <summary>
        /// Windows/Mac/Linuxを判定し、それぞれのFind～クラスでのOSInfoチェック
        /// </summary>
        /// <returns></returns>
        public static OSInfo GetCurrent()
        {
            if (OperatingSystem.IsWindows())
            {
                return FindWindows.GetOSInfo();
            }
            else if (OperatingSystem.IsMacOS())
            {
                return FindMacOS.GetOSInfo();   
            }
            else if (OperatingSystem.IsLinux())
            {
                return FindLinux.GetOSInfo();
            }
            return null;
        }

        #endregion
        #region GetWindows

        public static OSInfo GetWindows(int osSerial)
        {
            return null;
        }

        public static OSInfo GetWindows(string osName)
        {
            return null;
        }

        #endregion
    }
}
