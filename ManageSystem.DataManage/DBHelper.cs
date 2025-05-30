using ManageSystem.BasicCommonBase;
using ManageSystem.DataManage.Model;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSystem.DataManage
{
    public class DBHelper
    {
        private static Lazy<IFreeSql> sqliteLazy = new Lazy<IFreeSql>(() => new FreeSql.FreeSqlBuilder()
                                                          //.UseMonitorCommand(cmd => Trace.WriteLine(""))
                                                          .UseConnectionString(FreeSql.DataType.Sqlite, XmlLocalSetting.ReadXml<DataSourceModel>("SqliteDataSource").GetConnectionString())
                                                          .UseAutoSyncStructure(false)
                                                          .Build());
        public static IFreeSql freeSql { get; set; } = sqliteLazy.Value;

        private static Lazy<IFreeSql> OtherDataSourceLazy = new Lazy<IFreeSql>(() => new FreeSql.FreeSqlBuilder()
                                                          //.UseMonitorCommand(cmd => Trace.WriteLine(""))
                                                          .UseConnectionString(FreeSql.DataType.Sqlite, "Data Source=C:\\Users\\84025\\Desktop\\C#\\DB.db;Version=3;Encoding=UTF8")
                                                          .UseAutoSyncStructure(false)
                                                          .Build());
        public static IFreeSql OtherDataSource { get; set; } = OtherDataSourceLazy.Value;


    }
}
