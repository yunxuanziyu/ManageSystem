using ManageSystem.DataManage.Model;
using ManageSystem.Extensions;
using System;
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
