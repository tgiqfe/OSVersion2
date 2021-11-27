using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace OSVersion2.Windows
{
    internal class OSVersion
    {
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
    }
}
