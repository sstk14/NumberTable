using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;
namespace NumberTable.Config
{
    [XmlRoot("settings")]
    public class NumberTableConf : Util.XmlExtend
    {
        /// <summary>
        /// 設定ファイル
        /// </summary>
        [XmlElement("outputPath")]
        public string OutputPath { get; set; }

    }
}
