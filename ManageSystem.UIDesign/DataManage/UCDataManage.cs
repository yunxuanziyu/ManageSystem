using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSystem.UIDesign
{
    public partial class UCDataManage: UCBaseControl
    {
        public UCDataManage()
        {
            InitializeComponent();
        }

        private void UCDataManage_Load(object sender, EventArgs e)
        {
            LabelXBindingEvent(this.panelMenu);
        }

        private void labelXCargoIn_Click(object sender, EventArgs e)
        {

        }

        private void labelXCargoOut_Click(object sender, EventArgs e)
        {

        }
    }
}
