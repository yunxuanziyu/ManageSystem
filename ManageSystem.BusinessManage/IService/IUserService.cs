using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.BusinessManage
{
    public interface IUserService : IDisposable
    {
        public Task<User> GetUser(string name, string pwd);
        public Task<List<User>> GetUserList();
        public Task<List<User>> GetUserByWhere(string where, object param);
    }
}
