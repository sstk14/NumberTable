using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTable.Config
{
    public class AppConfig
    {
        
        /// <summary>
        /// アプリケーション設定ファイルのパス
        /// </summary>
        public string ConfigFilePath { get; set; }


        /// <summary>
        /// App.config内のデータ読み込み
        /// </summary>
        public void Load()
        {
            try
            {
                this.ConfigFilePath = System.Configuration
                        .ConfigurationManager.AppSettings["configFilePath"];
            }
            catch
            {
                throw;
            }
        }
    }
}
