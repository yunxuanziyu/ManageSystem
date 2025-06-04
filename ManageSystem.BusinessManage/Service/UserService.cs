using ManageSystem.DataManage;
using ManageSystem.DataManage.Model;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ManageSystem.Extensions;

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
            return (await userManage.GetUsersByWhere(where, param)).ToExtensionList();
        }

        public async Task<List<User>> GetUserList()
        {
            UserManage userManage = new(_freeSql);
            var lst = await userManage.GetUsers();
            return lst.ToExtensionList();
        }

        public async Task<User> GetUser(string name, string pwd)
        {
            UserManage userManage = new(_freeSql);
            return await userManage.GetUser(name, pwd);
        }

        public async Task Update(List<User> lst)
        {
            UserManage manage = new UserManage();
            await manage.Update(lst.ToList());
        }

        public async Task Update(User user)
        {
            UserManage manage = new UserManage();
            await this.Update(new List<User> { user });
        }

        public void Dispose()
        {
            
        }
    }
}
