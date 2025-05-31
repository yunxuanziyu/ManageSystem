using ManageSystem.DataManage;
using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.BusinessManage
{
    public class ServiceBase : IServiceBase
    {
        private IFreeSql _freeSql;
        public ServiceBase(IFreeSql freeSql)
        {
            _freeSql = freeSql;
        }

        public async Task Update<T>(List<ModelBase> entities) where T : class, new()
        {
            BaseManage baseManage = new BaseManage(_freeSql);
            await baseManage.Update<T>(entities);
        }


    }
}
