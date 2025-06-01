using ManageSystem.DataManage;
using ManageSystem.DataManage.Manage;
using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.BusinessManage.Service
{
    public class EnumerationService : IEnumerationService
    {
        public void Dispose()
        {
            
        }

        private IFreeSql _freeSql;
        public EnumerationService(IFreeSql freeSql)
        {
            _freeSql = freeSql;
        }
        public EnumerationService()
        {
            _freeSql = DBHelper.freeSql;
        }
        public async Task<List<Enumeration>> GetEnumerationByType(string type)
        {
            EnumerationManage manage = new(_freeSql);
            return await manage.GetEnumerationByType(type);
        }

        public async Task<List<string>> GetTypes()
        {
            EnumerationManage manage = new(_freeSql);
            return await manage.GetTypes();
        }
    }
}
