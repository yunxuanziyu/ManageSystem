using ManageSystem.DataManage;
using ManageSystem.DataManage.Model;
using ManageSystem.Extensions;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ManageSystem.BusinessManage.Service
{
    public class DepartmentService : IDepartmentService
    {
        private IFreeSql _freeSql;
        public DepartmentService(IFreeSql freeSql = null)
        {
            _freeSql = freeSql ?? DBHelper.freeSql;
        }
        public DepartmentService()
        {
            _freeSql = DBHelper.freeSql;
        }
        public void Dispose()
        {
            
        }

        public async Task<List<Department>> GetDepartmentList()
        {
            var manage = new DepartmentManage(_freeSql);
            return (await manage.GetDepartments()).ToExtensionList();
        }

        public async Task<List<Department>> GetDepartmentByCondition(string name,string code)
        {
            Expression<Func<Department, bool>> where = l => true;
            if(!string.IsNullOrEmpty(name))
                where = where.And(l => l.DeptName.Contains(name));
            if(!string.IsNullOrEmpty(code))
                where = where.And(l => l.DeptCode.Contains(code));
            var manage = new DepartmentManage(_freeSql);
            return (await manage.GetDepartmentsByCondition(where)).ToExtensionList();
        }
    }
}
