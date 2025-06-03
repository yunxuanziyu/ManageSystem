using ManageSystem.DataManage;
using ManageSystem.DataManage.Manage;
using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.BusinessManage.Service
{
    public class EnumerationService : IEnumerationService
    {
        public void Dispose()
        {
            
        }

        private IFreeSql _freeSql;
        public EnumerationService(IFreeSql freeSql)
        {
            _freeSql = freeSql;
        }
        public EnumerationService()
        {
            _freeSql = DBHelper.freeSql;
        }
        public async Task<List<Enumeration>> GetEnumerationByType(string type)
        {
            EnumerationManage manage = new(_freeSql);
            return await manage.GetEnumerationByType(type);
        }

        public async Task<List<string>> GetTypes()
        {
            EnumerationManage manage = new(_freeSql);
            return await manage.GetTypes();
        }

        public async Task<List<(string,string)>> GetTypesWithName(string typeName="")
        {
            EnumerationManage manage = new(_freeSql);
            var lst = await manage.GetEnumerations();
            var result = lst.GroupBy(e => e.Type)
                      .Select(g => (Type: g.Key, TypeName: g.Select(e => e.TypeName).FirstOrDefault()))
                      .ToList();
            if (!string.IsNullOrEmpty(typeName))
            {
                result = result.Where(item=>item.Type.Contains(typeName)|| item.TypeName.Contains(typeName)).ToList();
            }
            return result;
        }

        public async Task Update(List<Enumeration> entities)
        {
            EnumerationManage manage=new(_freeSql);
            await manage.Update(entities);
        }
        public async Task Update(Enumeration entity)
        {
            await Update(new List<Enumeration>() { entity });
        }
    }
}
