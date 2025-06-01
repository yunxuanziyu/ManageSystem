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
        public void Dispose()
        {
            
        }

        public async Task<List<Department>> GetDepts()
        {
            DeptManage manage = new DeptManage();
            var entities = await manage.GetEntityList<Department>();
            var result = new DepartmentList();
            entities.ForEach(x => result.Add(x as Department));
            return entities;
        }

        public async Task<DepartmentList> GetDeptsByCondition(string DeptName,string DeptCode)
        {
            string where = "1=1 ";
            if (!string.IsNullOrEmpty(DeptName))
            {
                where += $" and DeptName like '%@DeptName%'";
            }
            if (!string.IsNullOrEmpty(DeptCode))
            {
                where += $" and DeptCode like '%@DeptCode%'";
            }
            var param = new { DeptName , DeptCode };
            DeptManage manage = new DeptManage();
            var entities = await manage.GetEntityListByCondition<Department>(where, param);
            var result = new DepartmentList();
            entities.ForEach(x => result.Add(x as Department));
            return result;
        }

        public async Task Update(List<Department> lst)
        {
            DeptManage manage = new DeptManage();
            await manage.Update(lst);
        }
    }
}
