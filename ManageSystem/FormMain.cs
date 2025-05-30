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

        private void labelFirstPage_Click(object sender, EventArgs e)
        {
            LoadUCPage(UCCreateCreator.Create<UCHome>());
        }

        private void LoadUCPage(UserControl uc)
        {
            if (uc == panelUCHolder.Controls.OfType<UserControl>().FirstOrDefault())
                return;
            //panelUCHolder.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            if (!panelUCHolder.Controls.Contains(uc))
                panelUCHolder.Controls.Add(uc);
            uc.BringToFront();
        }

        private void labelXUserManage_Click(object sender, EventArgs e)
        {
            LoadUCPage(UCCreateCreator.Create<UCUserManage>());
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (MessageYesNo.ShowMessage("确定要退出系统吗？") == DialogResult.No)
            {
                return;
            }
            Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            labelFirstPage_Click(null, null);
            // 在窗体构造函数或Load事件中添加
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                null, panelUCHolder, new object[] { true });
        }

        private void labelXDataManage_Click(object sender, EventArgs e)
        {
            LoadUCPage(UCCreateCreator.Create<UCDataManage>());
        }

        private void labelDefine_Click(object sender, EventArgs e)
        {
            
        }

        private void labelXSet_Click(object sender, EventArgs e)
        {
            LoadUCPage(UCCreateCreator.Create<UCSystemSet>());
        }
    }
}
