using ManageSystem.DataManage;
using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.BusinessManage
{
    public class LogService :ServiceBase, ILogService
    {
        private readonly IFreeSql _IFreeSql = null;
        public LogService(IFreeSql freeSql):base(freeSql)
        {
            _IFreeSql = freeSql;
        }
        public LogService():base(DBHelper.freeSql)
        {
            
        }

        public Task<List<Log>> GetLogs()
        {
            LogManage logManage = new LogManage(_IFreeSql);
            return logManage.GetLogs();
        }

        public Task<bool> AddLog(Log log)
        {
            LogManage logManage = new(_IFreeSql);
            return logManage.AddLog(log);
        }

        public Task<bool> AddLogs(List<Log> log)
        {
            LogManage logManage = new(_IFreeSql);
            return logManage.AddLogs(log);
        }

        public void Dispose()
        {
            
        }
    }
}
