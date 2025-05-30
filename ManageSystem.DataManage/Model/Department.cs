using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ManageSystem.DataManage.Model
{
    public class Department:ModelBase
    {
        [Browsable(false)]
        [ScaffoldColumn(false)]
        [NotMapped]
        public new int ID { get; set; }
        [DisplayName("部门")]
        public string DeptName { get; set { field = value; OnPropertyChanged(nameof(DeptName)); } }
        [Key]
        [DisplayName("部门代码")]
        [Browsable(false)]
        public string DeptCode { get; set { field = value; OnPropertyChanged(nameof(DeptCode)); } }
    }
}
