using ManageSystem.DataManage;
using ManageSystem.DataManage.Manage;
using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.BusinessManage
{
    public class CargoService : ICargoService
    {
        IFreeSql _freeSql = null;
        public CargoService(IFreeSql freeSql)
        {
            _freeSql = freeSql ?? DBHelper.freeSql;
        }
        public CargoService()
        {
            _freeSql = DBHelper.freeSql;
        }
        public async Task<List<Cargo>> GetCargoList(string Code)
        {
            CargoManage cargoManage = new CargoManage(_freeSql);
            Expression<Func<Cargo, bool>> where = c => true;
            if (!string.IsNullOrEmpty(Code))
                where = c => c.Code == Code;
            return await cargoManage.GetCargoList(where);
        }
        
        public async Task SaveCargos(List<Cargo> cargos)
        {
            CargoManage cargoManage = new CargoManage(_freeSql);
            await cargoManage.Update(cargos);
            cargos.ForEach(c => c.EditState = EnumEditState.eNoEdit);
        }

        public void Dispose()
        {
            
        }
    }
}
