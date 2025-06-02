using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageSystem.BusinessManage.Service;
using ManageSystem.DataManage.Model;
using ManageSystem.Extensions;

namespace ManageSystem.UIDesign
{
    public partial class UCDeptManage: UCBaseControl
    {
        public UCDeptManage()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageForm.ShowErrorMessage("保存失败:"+ex.Message);
            }
        }
    }
}
