using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.DataManage.Model
{
    public class Department:ModelBase
    {
        public int ID { get; set; }
        [DisplayName("部门名称")]
        public string DeptName { get; set; }
        [DisplayName("部门代码")]
        public string DeptCode { get; set; }
        [DisplayName("备注")]
        public string Remark { get; set; }
        [DisplayName("部门负责人")]
        public string DeptHead { get; set; }
        public List<User> users { get; set; }
    }
}
