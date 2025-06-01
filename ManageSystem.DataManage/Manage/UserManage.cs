using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.DataManage
{
    public class UserManage: BaseManage
    {
        private IFreeSql _freeSql;
        public UserManage()
        {
            _freeSql = DBHelper.freeSql;
        }

        public UserManage(IFreeSql freeSql)
        {
            _freeSql = freeSql;
        }
        public async Task<List<User>> GetUsers()
        {
            return await DBHelper.freeSql.Select<User>().ToListAsync();
        }
        public async Task<User> GetUser(string name, string password)
        {
            return await DBHelper.freeSql.Select<User>().Where(a => a.Name == name && a.Password == password).FirstAsync();
        }

        public async Task<List<User>> GetUsersByWhere(string where,object param = null)
        {
            return await DBHelper.freeSql.Select<User>().Where(where,param).ToListAsync();
        }

        public async Task Update(List<User> entities)
        {
            List<User> UpdateEntities = entities.Where(x => x.EditState == EnumEditState.eUpdate).ToList();
            UpdateEntities.ForEach(user => user.UpdatedDate = DateTime.Now);
            List<User> AddEntities = entities.Where(x => x.EditState == EnumEditState.eInsert).ToList();
            AddEntities.ForEach(user => user.CreatedDate = DateTime.Now);
            List<User> DeleteEntities = entities.Where(x => x.EditState == EnumEditState.eDelete).ToList();

            var res1 = await _freeSql.Insert(AddEntities).ExecuteAffrowsAsync();
            var res2 = await _freeSql.Update<User>().SetSource(UpdateEntities).ExecuteAffrowsAsync();
            var res3 = await _freeSql.Delete<User>().Where(a => DeleteEntities.Select(b => b.Name).Contains(a.Name)).ExecuteAffrowsAsync();
        }
    }
}
