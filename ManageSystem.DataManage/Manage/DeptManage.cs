using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.DataManage
{
    public class DeptManage: BaseManage
    {
        private IFreeSql _freeSql;
        public DeptManage()
        {
            _freeSql = DBHelper.freeSql;
        }

        public DeptManage(IFreeSql freeSql)
        {
            _freeSql = freeSql;
        }
        public async Task Update(List<Department> entities)
        {
            List<Department> UpdateEntities = entities.Where(x => x.EditState == EnumEditState.eUpdate).ToList();
            List<Department> AddEntities = entities.Where(x => x.EditState == EnumEditState.eInsert).ToList();
            List<Department> DeleteEntities = entities.Where(x => x.EditState == EnumEditState.eDelete).ToList();

            List<Task> tasks =
            [
                _freeSql.Insert(AddEntities).ExecuteAffrowsAsync(),
                _freeSql.Update<Department>(UpdateEntities).ExecuteAffrowsAsync(),
                _freeSql.Delete<Department>(DeleteEntities).ExecuteAffrowsAsync(),
            ];
            await Task.WhenAll(tasks);
        }
    }
}
