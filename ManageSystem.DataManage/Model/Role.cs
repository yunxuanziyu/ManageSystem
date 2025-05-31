using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeSql.DataAnnotations;

namespace ManageSystem.DataManage.Model
{
    public  class Role:ModelBase
    {
        [Column(Name = "ID", IsIdentity = true, IsPrimary = true)]
        public int ID { get; set; }

        [DisplayName("角色名称")]
        public string Name { get; set; }
    }
}
