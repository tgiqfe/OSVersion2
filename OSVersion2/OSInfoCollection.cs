﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using OSVersion2.Windows;
using System.IO;

namespace OSVersion2
{
    internal class OSInfoCollection : List<OSInfo>
    {
        const string dbPath = "osinfocollection.json";

        public OSInfoCollection() { }

        #region Load default

        public void LoadDefault()
        {
            //  Windows 10
            Add(Windows10.Create1507(Edition.Home));
            Add(Windows10.Create1507(Edition.Pro));
            Add(Windows10.Create1507(Edition.Enterprise));
            Add(Windows10.Create1507(Edition.Education));
            Add(Windows10.Create1507(Edition.EducationPro));
            Add(Windows10.Create1507(Edition.EnterpriseLTSB));

            Add(Windows10.Create1511(Edition.Home));
            Add(Windows10.Create1511(Edition.Pro));
            Add(Windows10.Create1511(Edition.Enterprise));
            Add(Windows10.Create1511(Edition.Education));
            Add(Windows10.Create1511(Edition.EducationPro));

            Add(Windows10.Create1607(Edition.Home));
            Add(Windows10.Create1607(Edition.Pro));
            Add(Windows10.Create1607(Edition.Enterprise));
            Add(Windows10.Create1607(Edition.Education));
            Add(Windows10.Create1607(Edition.EducationPro));
            Add(Windows10.Create1607(Edition.EnterpriseLTSB));

            Add(Windows10.Create1703(Edition.Home));
            Add(Windows10.Create1703(Edition.Pro));
            Add(Windows10.Create1703(Edition.Enterprise));
            Add(Windows10.Create1703(Edition.Education));
            Add(Windows10.Create1703(Edition.EducationPro));

            Add(Windows10.Create1709(Edition.Home));
            Add(Windows10.Create1709(Edition.Pro));
            Add(Windows10.Create1709(Edition.Enterprise));
            Add(Windows10.Create1709(Edition.Education));
            Add(Windows10.Create1709(Edition.EducationPro));

            Add(Windows10.Create1803(Edition.Home));
            Add(Windows10.Create1803(Edition.Pro));
            Add(Windows10.Create1803(Edition.Enterprise));
            Add(Windows10.Create1803(Edition.Education));
            Add(Windows10.Create1803(Edition.EducationPro));

            Add(Windows10.Create1809(Edition.Home));
            Add(Windows10.Create1809(Edition.Pro));
            Add(Windows10.Create1809(Edition.Enterprise));
            Add(Windows10.Create1809(Edition.Education));
            Add(Windows10.Create1809(Edition.EducationPro));
            Add(Windows10.Create1809(Edition.EnterpriseLTSC));

            Add(Windows10.Create1903(Edition.Home));
            Add(Windows10.Create1903(Edition.Pro));
            Add(Windows10.Create1903(Edition.Enterprise));
            Add(Windows10.Create1903(Edition.Education));
            Add(Windows10.Create1903(Edition.EducationPro));

            Add(Windows10.Create1909(Edition.Home));
            Add(Windows10.Create1909(Edition.Pro));
            Add(Windows10.Create1909(Edition.Enterprise));
            Add(Windows10.Create1909(Edition.Education));
            Add(Windows10.Create1909(Edition.EducationPro));

            Add(Windows10.Create2004(Edition.Home));
            Add(Windows10.Create2004(Edition.Pro));
            Add(Windows10.Create2004(Edition.Enterprise));
            Add(Windows10.Create2004(Edition.Education));
            Add(Windows10.Create2004(Edition.EducationPro));

            Add(Windows10.Create20H2(Edition.Home));
            Add(Windows10.Create20H2(Edition.Pro));
            Add(Windows10.Create20H2(Edition.Enterprise));
            Add(Windows10.Create20H2(Edition.Education));
            Add(Windows10.Create20H2(Edition.EducationPro));

            Add(Windows10.Create21H1(Edition.Home));
            Add(Windows10.Create21H1(Edition.Pro));
            Add(Windows10.Create21H1(Edition.Enterprise));
            Add(Windows10.Create21H1(Edition.Education));
            Add(Windows10.Create21H1(Edition.EducationPro));

            Add(Windows10.Create21H2(Edition.Home));
            Add(Windows10.Create21H2(Edition.Pro));
            Add(Windows10.Create21H2(Edition.Enterprise));
            Add(Windows10.Create21H2(Edition.Education));
            Add(Windows10.Create21H2(Edition.EducationPro));

            //  Windows 11
            Add(Windows11.Create21H2(Edition.Home));
            Add(Windows11.Create21H2(Edition.Pro));
            Add(Windows11.Create21H2(Edition.ProEducation));
            Add(Windows11.Create21H2(Edition.ProForWorkstations));
            Add(Windows11.Create21H2(Edition.Enterprise));
            Add(Windows11.Create21H2(Edition.Education));
        }

        #endregion
        #region Load/Save

        public static OSInfoCollection Load()
        {
            OSInfoCollection result = null;
            try
            {
                using (var sr = new StreamReader(dbPath, Encoding.UTF8))
                {
                    result = JsonSerializer.Deserialize<OSInfoCollection>(sr.ReadToEnd());
                }
            }
            catch { }

            if (result == null)
            {
                result = new OSInfoCollection();
                result.LoadDefault();
            }

            return result;
        }

        public void Save()
        {
            using (var sw = new StreamWriter(dbPath, false, Encoding.UTF8))
            {
                string json = JsonSerializer.Serialize(this, new JsonSerializerOptions()
                {
                    WriteIndented = true,
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                });
                sw.WriteLine(json);
            }
        }

        #endregion
    }
}