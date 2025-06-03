using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<bool> AddCargo(Cargo cargo)
        {
            try
            {
                await _freeSql.Insert(cargo).ExecuteAffrowsAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Update(List<Cargo> entities)
        {
            List<Cargo> UpdateEntities = entities.Where(x => x.EditState == EnumEditState.eUpdate).ToList();
            List<Cargo> AddEntities = entities.Where(x => x.EditState == EnumEditState.eInsert).ToList();
            List<Cargo> DeleteEntities = entities.Where(x => x.EditState == EnumEditState.eDelete).ToList();
            var res1 = await _freeSql.Insert(AddEntities).ExecuteAffrowsAsync();
            var res2 = await _freeSql.Update<Cargo>().SetSource(UpdateEntities).ExecuteAffrowsAsync();
            var res3 = await _freeSql.Delete<Cargo>().Where(a => DeleteEntities.Select(b => b.Name).Contains(a.Name)).ExecuteAffrowsAsync();
        }
    }
}
