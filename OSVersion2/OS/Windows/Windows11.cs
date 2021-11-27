using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSVersion2.OS.Windows
{
    internal class Windows11 : OSInfo
    {
        public override string Name { get { return "Windows 11"; } }

        public static Windows11 Create21H2(Edition? edition)
        {
            return new Windows11()
            {
                Name = "Windows 11",
                VersionName = "21H2",
                Serial = 2109,
                Alias = new string[] { "Released Version" },
                Version = "10.0.22000",
                Edition = edition,
                ReleaseDate = new DateTime(2021, 10, 5),
                EndSupportDate = edition switch
                {
                    Windows.Edition.Home => new DateTime(2023, 10, 10),
                    Windows.Edition.Pro => new DateTime(2023, 10, 10),
                    Windows.Edition.ProEducation => new DateTime(2023, 10, 10),
                    Windows.Edition.ProForWorkstations => new DateTime(2023, 10, 10),
                    Windows.Edition.Enterprise => new DateTime(2024, 10, 8),
                    Windows.Edition.Education => new DateTime(2024, 10, 8),
                    _ => null,
                },
                IsServer = false,
                IsEmbedded = false
            };
        }
    }
}
