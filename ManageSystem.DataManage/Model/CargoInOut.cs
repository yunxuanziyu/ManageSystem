using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.DataManage.Model
{
    public class CargoInOut : ModelBase
    {
        [DisplayName("编号")]
        [Browsable(false)]
        public int ID { get; set; }

        [DisplayName("入库/出库数量")]
        public int InOutCount { get; set; }

        [DisplayName("操作员")]
        public string Staff { get; set; }

        [DisplayName("入库/出库日期")]
        public DateTime InOutDate { get; set; }
        /// <summary>
        /// 入库：0，出库：1
        /// </summary>
        [DisplayName("入库/出库")]
        [Browsable(false)]
        public int InOutType { get; set; }

        [DisplayName("备注")]
        public string Remark { get; set; }

        [DisplayName("货物编码")]
        public string CargoID { get; set; }

        [DisplayName("货物名称")]
        public string CargoName { get; set; }
    }
}
