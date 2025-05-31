using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.BusinessManage
{
    public interface IServiceBase
    {
        public Task Update<T>(List<ModelBase> entities) where T : class, new();
    }
}
