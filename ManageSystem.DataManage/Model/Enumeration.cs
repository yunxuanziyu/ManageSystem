using FreeSql.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.DataManage.Model
{
    [Table(Name = "Enumeration")]
    public class Enumeration:ModelBase
    {
        [Browsable(false)]
        [Column(IsIdentity = true, IsPrimary = true)]
        public int ID { get; set; }

        [DisplayName("名称")]
        public string Name { get; set; }

        [DisplayName("描述")]
        public string Description { get; set; }

        [DisplayName("状态")]
        public bool State { get; set; }

        [DisplayName("类型")]
        public string Type { get; set; }

        [DisplayName("父级枚举值")]
        public string ParentValue { get; set; }

        [DisplayName("枚举值")]
        public string Value { get; set; }
    }
}
