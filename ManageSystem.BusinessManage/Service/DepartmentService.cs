using ManageSystem.DataManage;
using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
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
        public void Dispose()
        {
            
        }

        public async Task<List<Department>> GetDepartmentList()
        {
            var manage = new DepartmentManage(_freeSql);
            return await manage.GetDepartments();
        }

        public async Task<List<Department>> GetDepartmentByCondition(string name,string code)
        {
            Expression<Func<Department, bool>> where = l => true;
            if(!string.IsNullOrEmpty(name))
                where = where.And(l => l.DeptName.Contains(name));
            if(!string.IsNullOrEmpty(code))
                where = where.And(l => l.DeptCode.Contains(code));
            var manage = new DepartmentManage(_freeSql);
            return await manage.GetDepartmentsByCondition(where);
        }
    }
}
