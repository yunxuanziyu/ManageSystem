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
        [Column(IsIgnore = true)]
        [Browsable(false)]
        [DisplayName("实体名称")]
        public override string EntityName => Name ?? Code;
        [Column(Name = "ID", IsIdentity = true, IsPrimary = true)]
        public int ID { get; set; }

        public string Code { get; set; }

        [DisplayName("角色名称")]
        public string Name { get; set; }
    }
}
