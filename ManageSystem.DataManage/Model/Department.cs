using FreeSql.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ManageSystem.DataManage.Model
{
    public class Department: ModelBase
    {
        [Column(Name = "DeptCode", IsIdentity = false, IsPrimary = true)]
        [DisplayName("部门代码")]
        public string DeptCode { get; set { field = value; OnPropertyChanged(nameof(DeptCode)); } }
        
        [DisplayName("部门")]
        public string DeptName { get; set { field = value; OnPropertyChanged(nameof(DeptName)); } }

        [DisplayName("用户")]
        [Navigate(nameof(User.DeptCode))]
        public List<User> Users { get; set; }
    }

    public class DepartmentList: List<ModelBase>
    {

    }
}
