using ManageSystem.DataManage.Model;
using ManageSystem.Extensions;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.BusinessManage
{
    public interface ILogService:IDisposable
    {
        public Task<List<Log>> GetLogs();
        public Task<bool> AddLog(Log log);
    }
}
