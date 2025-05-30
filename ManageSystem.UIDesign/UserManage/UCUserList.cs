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
    public partial class UCUserList: UserControl
    {
        public UCUserList()
        {
            InitializeComponent();
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            using (UserService userService = new UserService())
            {
                var lst = userService.GetUserList();
                dataGridViewX1.DataSource = lst.Result;
            }
        }

        private static UCUserList m_Instance;
        public static UCUserList Instance 
        { 
            get 
            {
                if (m_Instance == null)
                    m_Instance = new UCUserList();
                return  m_Instance; 
            }
        }

        private void UCUserList_Load(object sender, EventArgs e)
        {
            DeptService deptService = new DeptService();
            var lst = deptService.GetDepts();
            comboBoxDeptList.DataSource = lst.Result;
            var dept = lst.Result.FirstOrDefault();
            comboBoxDeptList.DisplayMember = nameof(dept.DeptName);
            comboBoxDeptList.ValueMember = nameof(dept.DeptCode);
        }
    }

}
