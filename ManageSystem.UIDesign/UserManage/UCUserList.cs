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
using ManageSystem.Extensions;
using ManageSystem.DataManage.Model;
using DevComponents.DotNetBar.Controls;
using ManageSystem.BasicCommonBase;

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
            string DeptCode = comboBoxDeptList.SelectedValue?.ToString();
            string ChineseName = textBoxName.Text.Trim();
            using (UserService userService = new UserService())
            {
                string where = "1=1";
                if(!string.IsNullOrEmpty(DeptCode))
                    where += " AND DeptCode = @DeptCode";
                if(!string.IsNullOrEmpty(ChineseName))
                    where += " AND ChineseName LIKE '%@ChineseName%'";
                var lst = userService.GetUserByWhere(where, new { DeptCode, ChineseName });
                dataGridViewX1.DataSource = new BindingList<User>(lst.Result);// lst.Result.ToDataTable();
            }
        }

        private void UCUserList_Load(object sender, EventArgs e)
        {
            using (DeptService deptService = new DeptService())
            {
                var lst = deptService.GetDepts();
                var departments = lst.Result.ToList();
                departments.Insert(0, new DataManage.Model.Department() { DeptName = "", DeptCode = "" });
                comboBoxDeptList.DataSource = departments;
                var dept = departments.FirstOrDefault();
                comboBoxDeptList.DisplayMember = nameof(dept.DeptName);
                comboBoxDeptList.ValueMember = nameof(dept.DeptCode);
            }
        }



        private void dataGridViewX1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewX1.Rows[e.RowIndex];
            if (dataGridViewX1.DataSource is BindingList<User> userList)
            {
                User modifiedUser = userList[e.RowIndex];
                modifiedUser.EditState = EnumEditState.eUpdate;
                // 获取修改后的值（可选）
                object newValue = row.Cells[e.ColumnIndex].Value;
                string columnName = dataGridViewX1.Columns[e.ColumnIndex].Name;
                logs.Add(new Log() { Content = $"修改用户[{modifiedUser.Name}]的{columnName}为{newValue}", OperaTime = DateTime.Now, Operator = ((User)GlobalVariable.LoginUser).Name });
            }
        }

        private List<Log> logs = new List<Log>();

        private void buttonSave_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private async Task UpdateData()
        {
            try
            {
                using (UserService userService = new UserService())
                {
                    var data = dataGridViewX1.DataSource as BindingList<User>;
                    await userService.Update(data.ToList());
                }
                using (LogService logService = new LogService())
                {
                    await logService.AddLogs(logs);
                    logs.Clear();
                }
                MessageForm.ShowMessage("保存成功！");
            }catch(Exception ex)
            {
                MessageForm.ShowErrorMessage("保存失败！" + ex.Message);
            }
            
        }
    }
}
