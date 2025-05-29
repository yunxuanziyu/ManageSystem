using FreeSql;
using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.DataManage
{
    public class ContextBase : FreeSql.DbContext
    {
        public ContextBase() : base(DBHelper.freeSql, null)
        {

        }
    }
}
