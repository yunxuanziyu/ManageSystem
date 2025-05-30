using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ManageSystem.BasicCommonBase
{
    public class XmlLocalSetting
    {

        #region 单节点XMl序列化
        public static void OneNodeWriteXml<T>(object value, string ParentNodeName)
        {
            XmlSerializer xml = new XmlSerializer(typeof(T), new XmlRootAttribute(ParentNodeName));
            using Stream s = new FileStream(GlobalVariable.XmlSetPath + "\\系统设置.xml", FileMode.OpenOrCreate);
            //写入xml文件
            xml.Serialize(s, value);
        }

        public static T OneNodeReadXml<T>(string ParentNodeName)
        {
            XmlSerializer xml = new XmlSerializer(typeof(T), new XmlRootAttribute(ParentNodeName));
            using Stream s = new FileStream(GlobalVariable.XmlSetPath + "\\系统设置.xml", FileMode.OpenOrCreate);
            //读取xml文件
            var res = xml.Deserialize(s);
            return (T)res;
        }
        #endregion

        public static void WriteXml<T>(object value, string ParentNodeName, string ChildNodeName = null)
        {
            if (value == null) return;
            ChildNodeName = ChildNodeName ?? "NodeValue";
            var xmlDoc = new XmlDocument();
            if (!File.Exists(GlobalVariable.XmlSetPath + "\\系统设置.xml"))
            {
                var xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
                xmlDoc.AppendChild(xmlDeclaration);
            }
            else
                xmlDoc.Load(GlobalVariable.XmlSetPath + "\\系统设置.xml");

            var root = xmlDoc.SelectSingleNode("Root");
            if (root == null)
            {
                root = xmlDoc.CreateElement("Root");    //创建根节点
                xmlDoc.AppendChild(root);
            }

            var parentNode = root.SelectSingleNode(ParentNodeName);
            if (parentNode == null)
            {
                parentNode = xmlDoc.CreateElement(ParentNodeName);
                root.AppendChild(parentNode);
            }
            var childNode = parentNode.SelectSingleNode(ChildNodeName);
            if (childNode == null)
            {
                childNode = xmlDoc.CreateElement(ChildNodeName);
                parentNode.AppendChild(childNode);
            }
            childNode.InnerText = JsonConvert.SerializeObject(value);
            xmlDoc.Save(GlobalVariable.XmlSetPath + "\\系统设置.xml");
        }

        public static T ReadXml<T>(string ParentNodeName, string ChildNodeName = null)
        {
            if (!File.Exists(GlobalVariable.XmlSetPath + "\\系统设置.xml"))return default(T);
            ChildNodeName = ChildNodeName ?? "NodeValue";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(GlobalVariable.XmlSetPath + "\\系统设置.xml");
            var root = xmlDoc.SelectSingleNode("Root");
            if(root == null)return default(T);
            var parentNode = root.SelectSingleNode(ParentNodeName);
            if (parentNode == null) return default(T);
            var xmlElement = parentNode.SelectSingleNode(ChildNodeName);
            if (xmlElement == null) return default(T);
            var jsonStr = xmlElement.InnerText;
            return JsonConvert.DeserializeObject<T>(jsonStr);
        }
    }
}
