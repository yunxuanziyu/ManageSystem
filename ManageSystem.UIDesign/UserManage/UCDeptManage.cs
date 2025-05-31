using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageSystem.BusinessManage.Service;
using ManageSystem.DataManage.Model;
using ManageSystem.Extensions;

namespace ManageSystem.UIDesign
{
    public partial class UCDeptManage: UCBaseControl
    {
        public UCDeptManage()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Save();
            }
            catch (Exception ex)
            {
                MessageForm.ShowErrorMessage("保存失败:"+ex.Message);
            }
        }
        private async void Save()
        {
            using (DeptService deptService = new DeptService())
            {
                var lst = (dataGridViewXDept.DataSource as DataTable).ToList<Department>();
                await deptService.Update(lst);
                MessageForm.ShowMessage("保存成功！");
            }
        }
        private void buttonQuery_Click(object sender, EventArgs e)
        {
            using (DeptService deptService = new DeptService())
            {
                string deptName = textBoxName.Text.Trim();
                string deptDesc = textBoxCode.Text.Trim();
                var lst = deptService.GetDeptsByCondition(deptName, deptDesc);
                var departments = lst.Result.ToDataTable();
                dataGridViewXDept.DataSource = departments;
            }
        }
    }
}
