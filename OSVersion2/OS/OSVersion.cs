﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using OSVersion2.OS.Windows;

namespace OSVersion2.OS
{
    internal class OSVersion
    {
        private static OSInfoCollection _collection = null;

        #region GetCurrent method

        /// <summary>
        /// Windows/Mac/Linuxを判定し、それぞれのFind～クラスでのOSInfoチェック
        /// </summary>
        /// <returns></returns>
        public static OSInfo GetCurrent()
        {
            if (OperatingSystem.IsWindows())
            {
                return FindWindows.GetCurrent();
            }
            else if (OperatingSystem.IsMacOS())
            {
                return FindMac.GetOSInfo();
            }
            else if (OperatingSystem.IsLinux())
            {
                return FindLinux.GetOSInfo();
            }
            return null;
        }

        #endregion
        #region GetWindows

        public static OSInfo GetWindows(int versionSerial)
        {
            _collection ??= OSInfoCollection.Load();

            var windowsCollection = _collection.Where(x => x.OSFamily == OSFamily.Windows).Where(x => !x.IsServer);
            OSInfo result = windowsCollection.FirstOrDefault(x => x.Serial == versionSerial);
            if (result != null) { result.Edition = Edition.None; }

            return result;
        }

        public static OSInfo GetWindows(string versionName)
        {
            if (int.TryParse(versionName, out int tempInt))
            {
                return GetWindows(tempInt);
            }

            _collection ??= OSInfoCollection.Load();

            var windowsCollection = _collection.Where(x => x.OSFamily == OSFamily.Windows).Where(x => !x.IsServer);
            OSInfo result =
                windowsCollection.FirstOrDefault(x => x.VersionName.Equals(versionName, StringComparison.OrdinalIgnoreCase)) ??
                windowsCollection.FirstOrDefault(x => x.Alias.Any(y => y.Equals(versionName, StringComparison.OrdinalIgnoreCase))) ??
                windowsCollection.FirstOrDefault(x => x.Version.Equals(versionName)) ??
                windowsCollection.FirstOrDefault(x => x.BuildVersion.Equals(versionName));
            if (result != null) { result.Edition = Edition.None; }

            return result;
        }

        #endregion
    }
}
