using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageSystem.BusinessManage;
using ManageSystem.BusinessManage.Service;

namespace ManageSystem.UIDesign
{
    public partial class UCUserList: UCBaseControl
    {
        public UCUserList()
        {
            InitializeComponent();
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            string DeptCode = comboBoxDeptList.SelectedValue.ToString();
            string ChineseName = textBoxName.Text.Trim();
            using (UserService userService = new UserService())
            {
                string where = "1=1";
                if(DeptCode!= "")
                    where += " AND DeptCode = @DeptCode";
                if(ChineseName != "")
                    where += " AND ChineseName LIKE '%@ChineseName%'";
                var lst = userService.GetUserByWhere(where, new { DeptCode, ChineseName });
                dataGridViewX1.DataSource = lst.Result.ToDataTable();
            }
        }

        private void UCUserList_Load(object sender, EventArgs e)
        {
            DeptService deptService = new DeptService();
            var lst = deptService.GetDepts();
            var departments = lst.Result.ToList();
            departments.Insert(0, new DataManage.Model.Department());
            comboBoxDeptList.DataSource = departments;
            var dept = departments.FirstOrDefault();
            comboBoxDeptList.DisplayMember = nameof(dept.DeptName);
            comboBoxDeptList.ValueMember = nameof(dept.DeptCode);
        }
    }

}
