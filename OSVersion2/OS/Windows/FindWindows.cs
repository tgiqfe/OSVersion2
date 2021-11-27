﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Management;
using System.Text.RegularExpressions;

namespace OSVersion2.OS.Windows
{
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    internal class FindWindows
    {
        #region Check ServerOS

        [DllImport("shlwapi.dll", SetLastError = true, EntryPoint = "#437")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsOS(uint os);

        //  OSType
        //  参考
        //  https://www.pinvoke.net/default.aspx/shlwapi.isos

        //private const uint OS_Windows = 0;
        //private const uint OS_NT = 1;
        //private const uint OS_Win95OrGreater = 2;
        //private const uint OS_NT4OrGreater = 3;
        //private const uint OS_Win98OrGreater = 5;
        //private const uint OS_Win98Gold = 6;
        //private const uint OS_Win2000OrGreater = 7;
        //private const uint OS_Win2000Pro = 8;
        //private const uint OS_Win2000Server = 9;
        //private const uint OS_Win2000AdvancedServer = 10;
        //private const uint OS_Win2000DataCenter = 11;
        //private const uint OS_Win2000Terminal = 12;
        //private const uint OS_Embedded = 13;
        //private const uint OS_TerminalClient = 14;
        //private const uint OS_TerminalRemoteAdmin = 15;
        //private const uint OS_Win95Gold = 16;
        //private const uint OS_MEOrGreater = 17;
        //private const uint OS_XPOrGreater = 18;
        //private const uint OS_Home = 19;
        //private const uint OS_Professional = 20;
        //private const uint OS_DataCenter = 21;
        //private const uint OS_AdvancedServer = 22;
        //private const uint OS_Server = 23;
        //private const uint OS_TerminalServer = 24;
        //private const uint OS_PersonalTerminalServer = 25;
        //private const uint OS_FastUserSwitching = 26;
        //private const uint OS_WelcomeLogonUI = 27;
        //private const uint OS_DomainMember = 28;
        private const uint OS_AnyServer = 29;
        //private const uint OS_WOW6432 = 30;
        //private const uint OS_WebServer = 31;
        //private const uint OS_SmallBusinessServer = 32;
        //private const uint OS_TabletPC = 33;
        //private const uint OS_ServerAdminUI = 34;
        //private const uint OS_MediaCenter = 35;
        //private const uint OS_Appliance = 36;

        public static bool IsWindowsServer()
        {
            return IsOS(OS_AnyServer);
        }

        #endregion

        public static OSInfo GetOSInfo()
        {
            var mo = new ManagementClass("Win32_OperatingSystem").
                GetInstances().
                OfType<ManagementObject>().
                First();
            string caption = mo["Caption"]?.ToString();
            string editionText = Regex.Replace(caption, @"Microsoft\sWindows\s\d+\s", "");
            Edition edition = Enum.TryParse(editionText, out Edition tempEdition) ? tempEdition : Edition.None;

            if (IsWindowsServer())
            {
                //  Windows Serverのチェックをここで
            }
            else
            {
                OSInfo info = (mo["Version"]?.ToString() ?? "") switch
                {
                    "10.0.10240" => Windows10.Create1507(edition),
                    "10.0.10586" => Windows10.Create1511(edition),
                    "10.0.14393" => Windows10.Create1607(edition),
                    "10.0.15063" => Windows10.Create1703(edition),
                    "10.0.16299" => Windows10.Create1709(edition),
                    "10.0.17134" => Windows10.Create1803(edition),
                    "10.0.17763" => Windows10.Create1809(edition),
                    "10.0.18362" => Windows10.Create1903(edition),
                    "10.0.18636" => Windows10.Create1909(edition),
                    "10.0.19041" => Windows10.Create2004(edition),
                    "10.0.19042" => Windows10.Create20H2(edition),
                    "10.0.19043" => Windows10.Create21H1(edition),
                    "10.0.19044" => Windows10.Create21H2(edition),
                    "10.0.22000" => Windows11.Create21H2(edition),
                    _ => null,
                };

                //  Embeddedの判定をこのあたりで

                return info;
            };
            return null;
        }
    }
}
