using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.BusinessManage.IService
{
    public interface IDeptService
    {
        public Task<List<Department>> GetDepts();
    }
}
