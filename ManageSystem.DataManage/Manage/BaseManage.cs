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
        public virtual async Task<List<ModelBase>> GetEntityList<T>() where T : ModelBase
        {
            // Explicitly cast the result to List<ModelBase> to resolve the type mismatch
            return (await DBHelper.freeSql.Select<T>().ToListAsync()).Cast<ModelBase>().ToList();
        }

        public virtual async Task<bool> AddEntity(ModelBase modelBase)
        {
            try
            {
                await DBHelper.freeSql.Insert(modelBase).ExecuteAffrowsAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public virtual async Task<bool> AddEntityList(List<ModelBase> modelBaseList)
        {
            try
            {
                await DBHelper.freeSql.Insert<ModelBase>().AppendData(modelBaseList).ExecuteAffrowsAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public virtual async Task<bool> UpdateEntity(ModelBase modelBase)
        {
            try
            {
                await DBHelper.freeSql.Update<ModelBase>().SetSource(modelBase).ExecuteAffrowsAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public virtual async Task<bool> UpdateEntityList(List<ModelBase> modelBaseList)
        {
            try
            {
                await DBHelper.freeSql.Update<ModelBase>().SetSource(modelBaseList).ExecuteAffrowsAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public virtual async Task<bool> DeleteEntity(ModelBase modelBase)
        {
            try
            {
                await DBHelper.freeSql.Delete<ModelBase>().Where(a => a.ID == modelBase.ID).ExecuteAffrowsAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public virtual async Task<bool> DeleteEntityList(List<ModelBase> modelBaseList)
        {
            try
            {
                await DBHelper.freeSql.Delete<ModelBase>().Where(a => modelBaseList.Select(b => b.ID).Contains(a.ID)).ExecuteAffrowsAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
