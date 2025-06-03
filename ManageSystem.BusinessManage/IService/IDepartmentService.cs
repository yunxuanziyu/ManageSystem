using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.BusinessManage
{
    public interface IDepartmentService : IDisposable
    {
        public Task<List<Department>> GetDepartmentList();
    }
}
