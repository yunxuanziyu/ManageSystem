using FreeSql.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.DataManage.Model
{
    public class Cargo : ModelBase
    {
        [Column(IsIgnore = true)]
        [Browsable(false)]
        [DisplayName("实体名称")]
        public override string EntityName => Name ?? Code;

        [Browsable(false)]
        public int ID { get; set; }

        [DisplayName("货物编码")]
        [Required]
        public string Code { get; set; }

        [Required]
        [DisplayName("名称")]
        public string Name { get; set; }

        [DisplayName("库存")]
        public int Inventory { get; set; }

        [Required]
        [DisplayName("类型")]
        public string CargoType { get; set; }

        [Required]
        [DisplayName("单价")]
        public double UnitPrice { get; set; }

        [DisplayName("单位")]
        public string Unit { get; set; }
        [DisplayName("备注")]
        public string Remark { get; set; }
        [DisplayName("别名")]
        public string AliasName { get; set; }
        [DisplayName("规格")]
        public string Specifications { get; set; }
    }
}
