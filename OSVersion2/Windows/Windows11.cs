using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSVersion2.Windows
{
    internal class Windows11 : OSInfo
    {
        public override string Name { get { return "Windows 11"; } }

        public static Windows11 Create1507(Edition edition)
        {
            return new Windows11()
            {
                VersionName = "21H2",
                Serial = 2109,
                Alias = new string[] { "Released Version" },
                Version = "10.0.22000",
                Edition = edition,
                ReleaseDate = new DateTime(2021, 10, 5),
                EndSupportDate = edition switch
                {
                    Edition.Home => new DateTime(2023, 10, 10),
                    Edition.Pro => new DateTime(2023, 10, 10),
                    Edition.Enterprise => new DateTime(2024, 10, 8),
                    Edition.Eductaino => new DateTime(2024, 10, 8),
                    Edition.EducationPro => new DateTime(2024, 10, 8),
                    Edition.EnterpriseLTSB => new DateTime(2024, 10, 8),
                    Edition.EnterpriseLTSC => null,
                    _ => DateTime.MinValue,
                },
                IsServer = false,
                IsEmbedded = false
            };
        }
    }
}
