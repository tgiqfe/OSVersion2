using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSVersion2.OS.Mac
{
    internal class MacOS
    {
        public static OSInfo Create11()
        {
            return new OSInfo()
            {
                Name = "macOS 11",
                OSFamily = OSFamily.Mac,
                VersionName = "11",
                Serial = 110000,
                Alias = new string[] { "macOS Big Sur", "Big Sur", "BigSur" },
                Version = "11",
                ReleaseDate = new DateTime(2020, 11,13),
                IsServer = false,
                IsEmbedded = false,
            };
        }
    }
}
