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
    public partial class UCUserManage: UserControl
    {
        public UCUserManage()
        {
            InitializeComponent();
        }
        private static UCUserManage home;
        public static UCUserManage Instance()
        {
            if (home == null)
                home = new UCUserManage();
            return home;
        }

        private void labelSelect_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
using (UserService userService = new UserService())
            {
                var lst = userService.GetUserList();
                dataGridViewX1.DataSource = lst;
            }
        }
    }
}
