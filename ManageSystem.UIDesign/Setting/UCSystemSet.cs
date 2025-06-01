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
    public partial class UCSystemSet: UCBaseControl
    {
        public UCSystemSet()
        {
            InitializeComponent();
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

        private void LoadUC(UserControl uc,object param = null)
        {
            Panel p = new Panel() { Height = 10, BackColor = Color.Transparent };
            this.panelXHolder.Controls.Add(p);
            uc.Dock = DockStyle.Top;
            this.panelXHolder.Controls.Add(uc);
        }

        private void UCSystemSet_Load(object sender, EventArgs e)
        {
            LoadUC(new UCSaveSetting());
            LoadUC(new UCSetting2());
            LoadUC(new UCSetting1());
        }

        private void labelSetCheck_Click(object sender, EventArgs e)
        {

        }
    }
}
