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
        public string DataSourceName { get; set; }
        public string IP { get; set; }
        public int Port { get; set; }
        public EnumDataSourceType DataSourceType { get; set; }
        public string ConnectionString { get; set; }

        private string _userName;
        public string UserName
        {
            get { return GlobalMethod.AESDecrypt(_userName); }
            set { _userName = GlobalMethod.AESEncrypt(value); }
        }
        
        private string _password;
        public string Password
        { 
            get {  return GlobalMethod.AESDecrypt(_password); } 
            set { _password = GlobalMethod.AESEncrypt(value); } 
        }
    }
}
