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
using DevComponents.DotNetBar;

namespace ManageSystem.UIDesign
{
    public partial class UCUserManage : UserControl
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


        private void labelX_MouseEnter(object sender, EventArgs e)
        {
            LabelX lbl = sender as LabelX;
            lbl.BackColor = Color.White;
        }

        private void labelXSet_MouseLeave(object sender, EventArgs e)
        {
            LabelX lbl = sender as LabelX;
            lbl.BackColor = Color.Transparent;
        }

        private void labelUserList_Click(object sender, EventArgs e)
        {
            panelBody.Controls.Clear();
            panelBody.Controls.Add(UCUserList.Instance);
        }
    }
}
