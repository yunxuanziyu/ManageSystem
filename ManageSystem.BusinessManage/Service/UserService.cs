using ManageSystem.DataManage;
using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ManageSystem.BusinessManage
{
    public class UserService : IUserService
    {
        private IFreeSql _freeSql;
        public UserService()
        {
            _freeSql = DBHelper.freeSql;
        }

        public UserService(IFreeSql freeSql)
        {
            _freeSql = freeSql;
        }

        public async Task<List<User>> GetUserByWhere(string where, object param)
        {
            UserManage userManage = new(_freeSql);
            return await userManage.GetUsersByWhere(where, param);
        }

        public async Task<List<User>> GetUserList()
        {
            UserManage userManage = new(_freeSql);
            return await userManage.GetUsers();
        }

        public async Task<User> GetUser(string name, string pwd)
        {
            UserManage userManage = new(_freeSql);
            return await userManage.GetUser(name, pwd);
        }

        public async Task Update(List<User> lst)
        {
            UserManage manage = new UserManage();
            await manage.Update(lst);
        }

        public void Dispose()
        {
            
        }
    }
}
