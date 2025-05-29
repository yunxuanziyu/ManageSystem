using DevComponents.DotNetBar;
using ManageSystem.BusinessManage;
using ManageSystem.DataManage.Model;
using ManageSystem.UIDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSystem
{
    public partial class FormMain: FormBase
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public FormMain(User user)
        {
            InitializeComponent();
            this.Text = "欢迎你" + user.ChineseName + "  管理系统";
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

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void labelFirstPage_Click(object sender, EventArgs e)
        {
            LoadUCPage(UCHome.Instance());
        }

        private void LoadUCPage(UserControl uc)
        {
            if (uc == panelUCHolder.Controls.OfType<UserControl>().FirstOrDefault())
                return;
            panelUCHolder.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelUCHolder.Controls.Add(uc);
        }

        private void labelXUserManage_Click(object sender, EventArgs e)
        {
            LoadUCPage(UCUserManage.Instance());
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (MessageYesNo.ShowMessage("确定要退出系统吗？") == DialogResult.No)
                return;
            Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            labelFirstPage_Click(null, null);
        }

        private void labelXDataManage_Click(object sender, EventArgs e)
        {
            LoadUCPage(UCDataManage.Instance());
        }
    }
}
