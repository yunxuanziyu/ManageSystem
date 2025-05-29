using ManageSystem.DataManage;
using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.BusinessManage
{
    public class ServiceLog :  IServiceLog
    {
        public Task<List<Log>> GetLogs()
        {
            LogManage logManage = new LogManage();
            return logManage.GetLogs();
        }

        public  Task<bool> AddLog(Log log)
        {
            LogManage logManage = new();
            return logManage.AddLog(log);
        }

        public void Dispose()
        {
            
        }
    }
}
