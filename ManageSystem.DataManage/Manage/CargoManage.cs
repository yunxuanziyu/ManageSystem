using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.DataManage.Manage
{
    public class CargoManage:BaseManage
    {
        private IFreeSql _freeSql;
        public CargoManage()
        {
            _freeSql = DBHelper.freeSql;
        }

        public CargoManage(IFreeSql freeSql)
        {
            _freeSql = freeSql;
        }

        public async Task<List<Cargo>> GetCargoList(Expression<Func<Cargo, bool>> where)
        {
            return await _freeSql.Select<Cargo>()
               .Where(where)
               .ToListAsync();
        }

        public async Task<bool> AddCargo(List<Cargo> cargos)
        {
            try
            {
                await _freeSql.Insert(cargos).ExecuteAffrowsAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Update(List<Cargo> entities)
        {


            List<Cargo> UpdateEntities = [.. entities.Where(x => x.EditState == EnumEditState.eUpdate)];
            List<Cargo> AddEntities = [.. entities.Where(x => x.EditState == EnumEditState.eInsert)];
            List<Cargo> DeleteEntities = [.. entities.Where(x => x.EditState == EnumEditState.eDelete)];
            var res1 = await _freeSql.Insert(AddEntities).ExecuteAffrowsAsync();
            var res2 = await _freeSql.Update<Cargo>().SetSource(UpdateEntities).ExecuteAffrowsAsync();
            var res3 = await _freeSql.Delete<Cargo>().Where(a => DeleteEntities.Select(b => b.Name).Contains(a.Name)).ExecuteAffrowsAsync();
        }
    }
}
