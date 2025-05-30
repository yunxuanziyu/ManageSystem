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
            panelBody.Controls.Clear();
            panelBody.Controls.Add(UCCreateCreator.Create<UCUserList>());
        }
    }
}
