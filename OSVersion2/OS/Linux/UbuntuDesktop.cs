using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSVersion2.OS.Linux
{
    internal class UbuntuDesktop
    {
        public static OSInfo Create2004()
        {
            return new OSInfo()
            {
                Name = "Ubuntu Desktop",
                OSFamily = OSFamily.Linux,
                VersionName = "20.04",
                Serial = 2004,
                Alias = new string[] { "Focal Fossa", "FocalFossa", "Focal", "Fossa" },
                Version = "20.04",
                Distribution = Distribution.Ubuntu,
                ReleaseDate = new DateTime(2020, 4, 23),
                EndSupportDate = new DateTime(2025, 4, 30),     //  2025年4月までとの記載なので、30日にセット
                IsServer = false,
                IsEmbedded = false,
            };
        }
    }
}
