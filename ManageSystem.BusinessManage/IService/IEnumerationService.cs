using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.BusinessManage
{
    public interface IEnumerationService : IDisposable
    {
        public Task<List<Enumeration>> GetEnumerationByType(string type);
        public Task<List<string>> GetTypes();
    }
}
