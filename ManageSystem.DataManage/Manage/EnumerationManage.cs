using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.DataManage.Manage
{
    public class EnumerationManage: BaseManage
    {
        private IFreeSql _freeSql;
        public EnumerationManage()
        {
            _freeSql = DBHelper.freeSql;
        }

        public EnumerationManage(IFreeSql freeSql)
        {
            _freeSql = freeSql;
        }

        public async Task<List<Enumeration>> GetEnumerationByType(string type)
        {
            return await _freeSql.Select<Enumeration>().Where(a => a.Type == type && a.State == 1).ToListAsync();
        }

        public async Task<List<string>> GetTypes()
        {
            return await _freeSql.Select<Enumeration>().Distinct().ToListAsync(s=>s.Type);
        }

        public async Task<List<Enumeration>> GetEnumerations()
        {
            return await _freeSql.Select<Enumeration>().ToListAsync();
        }

        public async Task Update(List<Enumeration> entities)
        {
            List<Enumeration> UpdateEntities = entities.Where(x => x.EditState == EnumEditState.eUpdate).ToList();
            List<Enumeration> AddEntities = entities.Where(x => x.EditState == EnumEditState.eInsert).ToList();
            List<Enumeration> DeleteEntities = entities.Where(x => x.EditState == EnumEditState.eDelete).ToList();

            List<Task> tasks =
            [
                _freeSql.Insert(AddEntities).ExecuteAffrowsAsync(),
                _freeSql.Update<Enumeration>(UpdateEntities).ExecuteAffrowsAsync(),
                _freeSql.Delete<Enumeration>(DeleteEntities).ExecuteAffrowsAsync(),
            ];
            await Task.WhenAll(tasks);
        }
    }
}
