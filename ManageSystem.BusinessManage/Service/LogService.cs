using ManageSystem.BasicCommonBase;
using ManageSystem.DataManage;
using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ManageSystem.Extensions;
using System.Linq;

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

        public async Task<Extensions.List<Log>> GetLogs()
        {
            LogManage logManage = new LogManage(_IFreeSql);
            var logs = await logManage.GetLogs();
            return logs.ToExtensionList();
        }

        public async Task<Extensions.List<Log>> GetLogsByCondition(string Operator, bool StartTime, DateTime startTime, bool EndTime, DateTime endTime)
        {
            LogManage logManage = new LogManage(_IFreeSql);
            Expression<Func<Log, bool>> where = l => true;
            if (!string.IsNullOrEmpty(Operator))
            {
                where = where.And(l => l.Operator.Contains(Operator));
            }
            if (StartTime)
            {
                where = where.And(l => l.OperaTime >= new DateTime(startTime.Year, startTime.Month, startTime.Day, 0, 0, 0));
            }
            if (EndTime)
            {
                where = where.And(l => l.OperaTime <= new DateTime(endTime.Year, endTime.Month, endTime.Day, 23, 59, 59));
            }
            var logs = await logManage.GetLogsByCondition(where);
            return logs.ToExtensionList();
        }

        public Task<bool> AddLog(Log log)
        {
            LogManage logManage = new(_IFreeSql);
            log.OperaTime = DateTime.Now;
            User user = GlobalVariable.LoginUser as User;
            log.Operator = $"[{user.Name}]{user.ChineseName}";
            return logManage.AddLog(log);
        }

        public Task<bool> AddLogs(Extensions.List<Log> logs)
        {
            User user = GlobalVariable.LoginUser as User;
            logs.ForEach(x => { x.OperaTime = DateTime.Now; x.Operator = $"[{user.Name}]{user.ChineseName}"; });
            LogManage logManage = new(_IFreeSql);
            return logManage.AddLogs(logs.ToList());
        }

        public void Dispose()
        {
            
        }
    }
}
