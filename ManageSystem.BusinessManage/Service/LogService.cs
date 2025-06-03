using DevComponents.Editors;
using ManageSystem.BasicCommonBase;
using ManageSystem.DataManage;
using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public Task<List<Log>> GetLogsByCondition(string Operator, bool StartTime,DateTime startTime,bool EndTime,DateTime endTime)
        {
            LogManage logManage = new LogManage(_IFreeSql);
            Expression<Func<Log, bool>> where = l => true;
            if (!string.IsNullOrEmpty(Operator))
            {
                where = where.And(l => l.Operator.Contains(Operator));
            }
            if (StartTime)
            {
                where = where.And(l => l.OperaTime >= new DateTime(startTime.Year, startTime.Month, startTime.Day, 0, 0,0));
            }
            if (EndTime)
            {
                where = where.And(l => l.OperaTime <= new DateTime(endTime.Year, endTime.Month, endTime.Day, 23, 59, 59));
            }
            return logManage.GetLogsByCondition(where);
        }

        public Task<bool> AddLog(Log log)
        {
            LogManage logManage = new(_IFreeSql);
            log.OperaTime = DateTime.Now;
            User user = GlobalVariable.LoginUser as User;
            log.Operator = $"[{user.Name}]{user.ChineseName}";
            return logManage.AddLog(log);
        }

        public Task<bool> AddLogs(List<Log> logs)
        {
            User user = GlobalVariable.LoginUser as User;
            logs.ForEach(x => { x.OperaTime = DateTime.Now; x.Operator = $"[{user.Name}]{user.ChineseName}"; });
            LogManage logManage = new(_IFreeSql);
            return logManage.AddLogs(logs);
        }

        public void Dispose()
        {
            
        }
    }
}
