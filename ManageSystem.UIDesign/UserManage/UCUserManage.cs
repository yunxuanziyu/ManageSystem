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
    public partial class UCUserManage : UCBaseControl
    {
        public UCUserManage()
        {
            InitializeComponent();
        }

        private void labelUserList_Click(object sender, EventArgs e)
        {
            LoadUCPage(panelBody, UCCreateCreator.Create<UCUserList>());
        }

        private void labelXDept_Click(object sender, EventArgs e)
        {
            LoadUCPage(panelBody, UCCreateCreator.Create<UCDeptManage>());
        }
        public void labelX_MouseEnter(object sender, EventArgs e)
        {
            LabelX lbl = sender as LabelX;
            lbl.BackColor = Color.White;
        }

        public void labelX_MouseLeave(object sender, EventArgs e)
        {
            LabelX lbl = sender as LabelX;
            lbl.BackColor = Color.Transparent;
        }
    }
}
