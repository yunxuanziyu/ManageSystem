using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.DataManage
{
    public class UserManage
    {

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

    }
}
