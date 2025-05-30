using ManageSystem.BusinessManage.IService;
using ManageSystem.DataManage;
using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.BusinessManage.Service
{
    public class DeptService : IDeptService
    {
        public async Task<List<Department>> GetDepts()
        {
            DeptManage manage = new DeptManage();
            var entities = await manage.GetEntityList<Department>();
            var result = new List<Department>();
            entities.ForEach(x => result.Add(x as Department));
            return result;
        }
    }
}
