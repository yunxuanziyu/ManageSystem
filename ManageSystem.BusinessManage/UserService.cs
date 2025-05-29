using ManageSystem.DataManage;
using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.BusinessManage
{
    public class UserService : IUserService
    {

        public UserService()
        {
            
        }

        public List<User> GetUserByWhere(string where, object param)
        {
            UserManage userManage = new();
            return userManage.GetUsersByWhere(where, param).Result;
        }

        public async Task<List<User>> GetUserList()
        {
            UserManage userManage = new();
            return await userManage.GetUsers();
        }

        public async Task<User> GetUser(string name, string pwd)
        {
            UserManage userManage = new();
            return await userManage.GetUser(name, pwd);
        }

        public void Dispose()
        {
            
        }
    }
}
