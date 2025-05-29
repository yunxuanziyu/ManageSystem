using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ManageSystem.BasicCommonBase
{
    public class XmlLocalSetting
    {
        public static void WriteXml<T>(object value, string ParentNodeName)
        {
            XmlSerializer xml = new XmlSerializer(typeof(T), new XmlRootAttribute(ParentNodeName));
            using Stream s = new FileStream(GlobalVariable.XmlSetPath + "\\系统设置.xml", FileMode.OpenOrCreate);
            //写入xml文件
            xml.Serialize(s, value);
        }

        public static T ReadXml<T>(string ParentNodeName)
        {
            XmlSerializer xml = new XmlSerializer(typeof(T), new XmlRootAttribute(ParentNodeName));
            using Stream s = new FileStream(GlobalVariable.XmlSetPath+"\\系统设置.xml", FileMode.OpenOrCreate);
            //读取xml文件
            var res = xml.Deserialize(s);
            return (T)res;
        }
    }
}
