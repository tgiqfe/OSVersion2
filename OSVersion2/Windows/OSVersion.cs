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
        public static void GetCurrent()
        {
            if (OperatingSystem.IsWindows())
            {
                GetWindows();
            }
            else if (OperatingSystem.IsMacOS())
            {
                GetMacOS();
            }
            else if (OperatingSystem.IsLinux())
            {
                GetLinux();
            }
        }

        /// <summary>
        /// Windows用のバージョン取得
        /// </summary>
        public static void GetWindows()
        {

        }

        //  Mac用のバージョン取得。後回し
        public static void GetMacOS() { }

        //  Linux用のバージョン取得。後回し
        public static void GetLinux() { }
    }
}
