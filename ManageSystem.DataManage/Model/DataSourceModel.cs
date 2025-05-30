using ManageSystem.BasicCommonBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.DataManage.Model
{
    public enum EnumDataSourceType
    {
        SqlServer,
        MySql,
        Oracle,
        Sqlite,
        Access,
        Excel,
        Json,
        Xml
    }

    public class DataSourceModel
    {
        /// <summary>
        /// 数据源名称(无实际意义)
        /// </summary>
        public string DataSourceName { get; set; }
        /// <summary>
        /// 数据库名称
        /// </summary>
        public string DataBaseName { get; set; }
        /// <summary>
        /// 数据源路径(本地文件类型数据库)
        /// </summary>
        public string DataSourcePath { get; set; }
        /// <summary>
        /// IP $"Data Source={XmlLocalSetting.ReadXml<DataSourceModel>("SqliteDataSource").IP};Version=3;Encoding=UTF8
        /// </summary>
        public string IP { get; set; }
        /// <summary>
        /// 端口
        /// </summary>
        public int Port { get; set; }
        public EnumDataSourceType DataSourceType { get; set; }

        private string _userName;
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            get { return GlobalMethod.AESDecrypt(_userName); }
            set { _userName = GlobalMethod.AESEncrypt(value); }
        }
        
        private string _password;
        /// <summary>
        /// 密码
        /// </summary>
        public string Password
        { 
            get {  return GlobalMethod.AESDecrypt(_password); } 
            set { _password = GlobalMethod.AESEncrypt(value); } 
        }

        public string GetConnectionString()
        {
            switch (DataSourceType)
            {
                case EnumDataSourceType.SqlServer:
                    return $"Data Source={IP},{Port};Initial Catalog={DataBaseName};User ID={UserName};Password={Password};";
                case EnumDataSourceType.MySql:
                    return $"Server={IP};Database={DataBaseName};User ID={UserName};Password={Password};";
                case EnumDataSourceType.Oracle:
                    return $"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={IP})(PORT={Port})))(CONNECT_DATA=(SID={DataBaseName})));User ID={UserName};Password={Password};";
                case EnumDataSourceType.Sqlite:
                    return $"Data Source={DataSourcePath};Version=3;Encoding=UTF8";
                case EnumDataSourceType.Access:
                    return $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={DataSourcePath};User ID={UserName};Password={Password};";
                case EnumDataSourceType.Excel:
                    return $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={DataSourcePath};Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1';";
                default:
                    return "";
            }
        }
    }
}
