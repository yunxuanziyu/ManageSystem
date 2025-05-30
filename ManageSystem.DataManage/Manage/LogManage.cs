using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.DataManage
{
    public class LogManage: BaseManage
    {
        readonly IFreeSql _freeSql;
        public LogManage(IFreeSql freeSql = null)
        {
            if (freeSql == null)
                _freeSql = DBHelper.freeSql;
            else
                _freeSql = freeSql;
        }
        public async Task<List<Log>> GetLogs()
        {
            return await _freeSql.Select<Log>().ToListAsync();
        }

        public async Task<bool> AddLog(Log log)
        {
            try
            {
                await _freeSql.Insert(log).ExecuteAffrowsAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
