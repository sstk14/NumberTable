using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberTable.Util
{
    [TestClass]
    public class TextFileIOTest
    {
        [TestMethod]
        public void WriteTest()
        {
            NumberTable.Config.AppConfig appConf = new NumberTable.Config.AppConfig();
            appConf.Load();
            try
            {
                NumberTable.Config.NumberTableConf conf = new NumberTable.Config.NumberTableConf();
                conf = conf.LoadFile(appConf.ConfigFilePath);

                NumberTable.Util.TextFileIO textFIleIO = new NumberTable.Util.TextFileIO();

                var text = "Hello World！";
                textFIleIO.Write(conf.OutputPath, text);

                Assert.IsTrue(System.IO.File.Exists(conf.OutputPath));

                using (System.IO.StreamReader reader = new System.IO.StreamReader(conf.OutputPath))
                {
                    string writedText = reader.ReadToEnd();

                    Assert.AreEqual(writedText, text);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
