using ManageSystem.BusinessManage;
using ManageSystem.BusinessManage.Service;
using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ManageSystem.ControlX.ComboBoxX;

namespace ManageSystem.UIDesign
{
    public partial class FormUserDetailInfo: FormBase
    {
        private User _user;
        public FormUserDetailInfo(User user)
        {
            InitializeComponent();
            BindingUser(user);
        }

        public void BindingUser(User user)
        {
            _user = user;
            this.ucBaseControl1.WriteData<User>(user, this);
        }

        private void buttonXSave_Click(object sender, EventArgs e)
        {
            UpdateUser();
        }

        private async void UpdateUser()
        {
            this.ucBaseControl1.WriteData<User>(_user, this);
            using (var service = new UserService())
            {
                await service.Update(_user);
                MessageForm.ShowMessage("修改成功！");
            }
        }

        private void FormUserDetailInfo_Load(object sender, EventArgs e)
        {
            using (var Service = new DepartmentService())
            {
                var lst = Service.GetDepartmentList().Result;
                lst.ForEach(d => comboBoxXDept.Items.Add(new ItemNode() { Name = d.DeptName, Value = d.DeptCode }));
                comboBoxXDept.DisplayMember = "DisplayName";
                comboBoxXDept.ValueMember = "Value";
            }
        }
    }
}
