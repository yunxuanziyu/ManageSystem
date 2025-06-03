using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.DataManage.Model
{
    public class Cargo : ModelBase
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Inventory { get; set; }
        public string CargoType { get; set; }
        public double UnitPrice { get; set; }
        public string Unit { get; set; }
        public string Remark { get; set; }
        public string AliasName { get; set; }
        public string Specifications { get; set; }
    }
}
