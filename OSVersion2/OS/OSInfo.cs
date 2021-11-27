using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OSVersion2.OS.Windows;

namespace OSVersion2.OS
{
    internal class OSInfo : Arithmetic
    {
        /// <summary>
        /// OSの名前
        /// </summary>
        public virtual string Name { get; }

        /// <summary>
        /// OSのバージョンの名前。一番通りの良い名前。
        /// </summary>
        public string VersionName { get; set; }

        /// <summary>
        /// OSバージョン名のその他の名前。開発時のコードネームも含む
        /// </summary>
        public string[] Alias { get; set; }

        /// <summary>
        /// バージョン
        /// </summary>
        public string Version { get; set; }
        
        /// <summary>
        /// エディション
        /// </summary>
        public Edition Edition { get; set; }

        /// <summary>
        /// リリース日
        /// </summary>
        public DateTime ReleaseDate { get; set; }

        /// <summary>
        /// サポート終了日
        /// </summary>
        public DateTime? EndSupportDate { get; set; }

        /// <summary>
        /// サーバOSであるかどうか
        /// </summary>
        public bool IsServer { get; set; }

        /// <summary>
        /// 組み込み用OSであるかどうか
        /// </summary>
        public bool IsEmbedded { get; set; }

        public string MajorVersion
        {
            get { return Version.Contains(".") ? Version.Split('.')[0] : Version; }
        }
        public string MinorVersion
        {
            get { return Version.Contains(".") && Version.Split('.').Length > 1 ? Version.Split('.')[1] : Version; }
        }
        public string BuildVersion
        {
            get { return Version.Contains(".") && Version.Split('.').Length > 2 ? Version.Split('.')[2] : Version; }
        }

        /// <summary>
        /// 引数無しコンストラクタ
        /// </summary>
        public OSInfo() { }

        /// <summary>
        /// コンストラクタ。全て文字列で
        /// </summary>
        /// <param name="versionName"></param>
        /// <param name="serial"></param>
        /// <param name="alias"></param>
        /// <param name="buildNumber"></param>
        /// <param name="fullVersion"></param>
        /// <param name="edition"></param>
        /// <param name="releaseDate"></param>
        /// <param name="endSupportDate"></param>
        /// <param name="isServer"></param>
        /// <param name="isEmbedded"></param>
        public OSInfo(string name, string versionName, int serial, string alias, string buildNumber, string edition, string releaseDate, string endSupportDate, bool isServer, bool isEmbedded)
        {
            this.Name = name;
            this.VersionName = versionName;
            this.Serial = serial;
            this.Alias = alias.Split(',').Select(x => x.Trim()).ToArray();
            this.Version = buildNumber;
            this.Edition = Enum.TryParse(edition, out Edition ed) ? ed : Edition.None;
            this.ReleaseDate = DateTime.TryParse(releaseDate, out DateTime rd) ? rd : DateTime.MinValue;
            this.EndSupportDate = DateTime.TryParse(endSupportDate, out DateTime es) ? es : DateTime.MinValue;
            this.IsServer = isServer;
            this.IsEmbedded = isEmbedded;
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="versionName"></param>
        /// <param name="serial"></param>
        /// <param name="alias"></param>
        /// <param name="buildNUmber"></param>
        /// <param name="fullVersion"></param>
        /// <param name="edition"></param>
        /// <param name="releaseDate"></param>
        /// <param name="endSupportDate"></param>
        /// <param name="isServer"></param>
        /// <param name="isEmbedded"></param>
        public OSInfo(string name, string versionName, int serial, string[] alias, string buildNUmber, Edition edition, DateTime releaseDate, DateTime? endSupportDate, bool isServer, bool isEmbedded)
        {
            this.Name = name;
            this.VersionName = versionName;
            this.Serial = serial;
            this.Alias = alias;
            this.Version = buildNUmber;
            this.Edition = edition;
            this.ReleaseDate = releaseDate;
            this.EndSupportDate = endSupportDate;
            this.IsServer = isServer;
            this.IsEmbedded = isEmbedded;
        }

        /// <summary>
        /// 文字列化
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Name} {Edition} ver.{VersionName}";
        }
    }
}
