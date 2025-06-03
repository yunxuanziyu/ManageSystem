using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.DataManage
{
    public class DepartmentManage : BaseManage
    {
        private IFreeSql _freeSql;
        public DepartmentManage()
        {
            _freeSql = DBHelper.freeSql;
        }

        public DepartmentManage(IFreeSql freeSql)
        {
            _freeSql = freeSql;
        }

        public async Task<bool> AddDepartments(List<Department> department)
        {
            try
            {
                await _freeSql.Insert(department).ExecuteAffrowsAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Department>> GetDepartments()
        {
            return await _freeSql.Select<Department>()
                .ToListAsync();
        }

        public async Task<List<Department>> GetDepartmentsByCondition(Expression<Func<Department, bool>> where)
        {
            return await _freeSql.Select<Department>()
                .Where(where)
                .ToListAsync();
        }

        public async Task Update(List<Department> entities)
        {
            List<Department> UpdateEntities = entities.Where(x => x.EditState == EnumEditState.eUpdate).ToList();
            List<Department> AddEntities = entities.Where(x => x.EditState == EnumEditState.eInsert).ToList();
            List<Department> DeleteEntities = entities.Where(x => x.EditState == EnumEditState.eDelete).ToList();
            var res1 = await _freeSql.Insert(AddEntities).ExecuteAffrowsAsync();
            var res2 = await _freeSql.Update<Department>().SetSource(UpdateEntities).ExecuteAffrowsAsync();
            var res3 = await _freeSql.Delete<Department>().Where(a => DeleteEntities.Select(b => b.DeptCode).Contains(a.DeptCode)).ExecuteAffrowsAsync();
        }
    }
}
