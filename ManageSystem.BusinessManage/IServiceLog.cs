using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.BusinessManage
{
    public interface IServiceLog:IDisposable
    {
        public Task<List<Log>> GetLogs();
        public Task<bool> AddLog(Log log);
    }
}
