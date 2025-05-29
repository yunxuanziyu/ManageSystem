using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.DataManage
{
    public class LogManage
    {
        public async Task<List<Log>> GetLogs()
        {
            return await DBHelper.freeSql.Select<Log>().ToListAsync();
        }

        public async Task<bool> AddLog(Log log)
        {
            try
            {
                await DBHelper.freeSql.Insert(log).ExecuteAffrowsAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
