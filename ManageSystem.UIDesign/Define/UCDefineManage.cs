using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace ManageSystem.UIDesign
{
    public partial class UCDefineManage: UCBaseControl
    {
        public UCDefineManage()
        {
            InitializeComponent();
        }

        private void labelX1_Click(object sender, EventArgs e)
        {
            
        }

        private void UCDefineManage_Load(object sender, EventArgs e)
        {
            LabelXBindingEvent(panel1);
        }

        private void labelXEnum_Click(object sender, EventArgs e)
        {
            LoadUCPage(panelXHolder, UCCreateCreator.Create<UCEnumDefine>());
        }
    }
}
