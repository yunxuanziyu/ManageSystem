using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.DataManage
{
    public class BaseManage
    {
        private IFreeSql _freeSql { get; set; }
        public BaseManage(IFreeSql freeSql)
        {
            _freeSql = freeSql;
        }
        public BaseManage()
        {
            _freeSql = DBHelper.freeSql;
        }

        public virtual async Task<List<T>> GetEntityList<T>() where T : class, new()
        {
            return (await _freeSql.Select<T>().ToListAsync()).ToList();
        }
        public virtual async Task<List<ModelBase>> GetEntityListByCondition<T>(string condition, object param) where T : class, new()
        {
            return (await _freeSql.Select<T>().Where(condition, param).ToListAsync()).Cast<ModelBase>().ToList();
        }

        public async Task Update<T>(List<ModelBase> entities) where T : class, new()
        {
            
        }
    }
}
