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
        private IFreeSql _freeSql { get; set; }
        public ServiceBase(IFreeSql freeSql = null)
        {
            _freeSql = freeSql??DBHelper.freeSql;
        }

        public async Task Update<T>(List<ModelBase> entities) where T : class, new()
        {
            BaseManage baseManage = new BaseManage(_freeSql);
            await baseManage.Update<T>(entities);
        }
    }
}
