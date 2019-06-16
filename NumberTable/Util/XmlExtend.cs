using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace NumberTable.Util
{
    public class XmlExtend
    {

        public dynamic LoadFile(string filePath)
        {
            try
            {
                using(System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
                {
                    string strXml = reader.ReadToEnd();
                    var xmlObj = this.LoadXml(strXml);
                    return xmlObj;
                }
            }
            catch
            {
                throw;
            }       
        }
        public dynamic LoadXml(string strXml)
        {
            try
            {

                System.Xml.Serialization.XmlSerializer serializer
                     = new System.Xml.Serialization.XmlSerializer(this.GetType());
                dynamic deserializeObj = serializer.Deserialize(new StringReader(strXml));
                return deserializeObj;
                
            }
            catch
            {
                throw;
            }
        }
    }
}
