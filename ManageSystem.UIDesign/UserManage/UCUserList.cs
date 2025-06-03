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
using static ManageSystem.ControlX.ComboBoxX;

namespace ManageSystem.UIDesign
{
    public partial class UCUserList: UCBaseControl
    {
        private bool _isEditing = false;
        public UCUserList()
        {
            InitializeComponent();
        }

        private List<User> SourceData;
        private void buttonQuery_Click(object sender, EventArgs e)
        {
            try
            {
                buttonQuery.Enabled = false;
                loadingCircle1.Active = loadingCircle1.Visible = true;
                string DeptCode = (comboBoxXDept.SelectedItem as ItemNode)?.Value.ToString();
                string ChineseName = textBoxName.Text.Trim();
                using (UserService userService = new UserService())
                {
                    string where = "1=1";
                    if (!string.IsNullOrEmpty(DeptCode))
                        where += " AND DeptCode = @DeptCode";
                    if (!string.IsNullOrEmpty(ChineseName))
                        where += " AND ChineseName LIKE '%@ChineseName%'";
                    var lst = userService.GetUserByWhere(where, new { DeptCode, ChineseName });
                    SourceData = lst.Result.ToList();
                    dataGridViewX1.DataSource = new BindingList<User>(SourceData);// lst.Result.ToDataTable();
                    _isEditing = false;
                }
            }
            catch (Exception ex)
            {
                MessageForm.ShowErrorMessage("查询失败！" + ex.Message);
            }finally
            {
                buttonQuery.Enabled = true;
                loadingCircle1.Active = loadingCircle1.Visible = false;
            }
        }

        private void UCUserList_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewX1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 || e.ColumnIndex <= 0)return;
            DataGridViewRow row = dataGridViewX1.Rows[e.RowIndex];
            if (dataGridViewX1.DataSource is BindingList<User> userList)
            {
                User modifiedUser = SourceData[e.RowIndex];
                modifiedUser.EditState = EnumEditState.eUpdate;
                // 获取修改后的值（可选）
                object newValue = row.Cells[e.ColumnIndex].Value;
                string columnName = dataGridViewX1.Columns[e.ColumnIndex].Name;
                logs.Add(new Log() { Content = $"修改用户[{modifiedUser.Name}]的{columnName}为{newValue}", OperaTime = DateTime.Now, Operator = ((User)GlobalVariable.LoginUser).Name });
                _isEditing = true;
            }
        }

        private List<Log> logs = new List<Log>();

        private void buttonSave_Click(object sender, EventArgs e)
        {
            UpdateData();
            _isEditing = false;
        }

        private async Task UpdateData()
        {
            try
            {
                buttonSave.Enabled = false;
                loadingCircle1.Active = loadingCircle1.Visible = true;
                using (UserService userService = new UserService())
                {
                    await userService.Update(SourceData);
                }
                using (LogService logService = new LogService())
                {
                    await logService.AddLogs(logs);
                    logs.Clear();
                }
                MessageForm.ShowMessage("保存成功！");
                buttonQuery_Click(null, null);
            }
            catch(Exception ex)
            {
                MessageForm.ShowErrorMessage("保存失败！" + ex.Message);
            }
            finally
            {
                buttonSave.Enabled = true;
                loadingCircle1.Active = loadingCircle1.Visible = false;
            }
        }

        private void buttonXDetail_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.DataSource is BindingList<User> userList)
            {
                if (dataGridViewX1.CurrentRow == null)
                    return;
                int rowIndex = dataGridViewX1.CurrentRow.Index;
                User modifiedUser = userList[rowIndex];
                FormUserDetailInfo f = FormBase.CreateForm<FormUserDetailInfo>(new object[] { modifiedUser }) as FormUserDetailInfo;
                f.BindingUser(modifiedUser);
                f.Show();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedIndexes = GetSelectedRows(dataGridViewX1);
            if (selectedIndexes.Count == 0)
                return;
            DialogResult dr = MessageYesNo.ShowMessage("确认删除选中的用户吗？");
            if (dr == DialogResult.No)
                return;
            var userDict = SourceData.ToDictionary(u => u.ID, u => u);
            foreach (int index in selectedIndexes)
                if (userDict.TryGetValue(index, out User user))
                    user.EditState = EnumEditState.eDelete; // 修改属性
            _isEditing = true;
            dataGridViewX1.DataSource = new BindingList<User>(SourceData.Where(u => u.EditState != EnumEditState.eDelete).ToList());
        }

        private void UCUserList_VisibleChanged(object sender, EventArgs e)
        {
            if (_isEditing && !Visible)
            {
                DialogResult  d=  MessageYesNo.ShowMessage("有未保存的修改，是否先保存?");
                if (d == DialogResult.Yes)
                {
                    UpdateData().Wait();
                    _isEditing = false;
                }
            }
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridViewX1.Rows)
            {
                row.Cells[0].Value = true;
            }
        }

        private void 取消全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridViewX1.Rows)
            {
                row.Cells[0].Value = false;
            }
        }
    }
}
