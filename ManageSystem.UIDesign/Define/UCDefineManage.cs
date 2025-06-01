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

        private void labelDept_Click(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 加载控件
        /// 靠前的后加载(写下面)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UCDefineManage_Load(object sender, EventArgs e)
        {
            LabelXBindingEvent(panelXHolder);
        }
    }
}
