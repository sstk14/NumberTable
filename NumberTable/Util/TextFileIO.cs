using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
namespace NumberTable.Util
{
    public class TextFileIO
    {
        public System.Text.Encoding Encoding { get; set; } = System.Text.Encoding.UTF8;
        /// <summary>
        /// 指定したパスにファイルを書込みます
        /// </summary>
        /// <param name="path"></param>
        /// <param name="text"></param>
        public void Write(string path, string text)
        {
            if (System.IO.File.Exists(path) == false)
            {
                File.CreateText(path);
            }
            try
            {

                using (StreamWriter writer = new StreamWriter(path, false, Encoding))
                {
                    writer.Write(text);
                }
            }
            catch
            {
                throw;
            }
        }

    }
}
