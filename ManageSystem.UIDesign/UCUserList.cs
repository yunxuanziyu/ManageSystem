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
    }

}
