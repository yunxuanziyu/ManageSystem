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

        private void LoadUC(UserControl uc,object param = null)
        {
            Panel p = new Panel() { Height = 10, BackColor = Color.Transparent,Dock = DockStyle.Top };
            this.panelXHolder.Controls.Add(p);
            uc.Dock = DockStyle.Top;
            this.panelXHolder.Controls.Add(uc);
        }

        private void UCSystemSet_Load(object sender, EventArgs e)
        {
            LabelXBindingEvent(panelmenu,true);
            //加载UC的Name必须为 "UC_"  加上对应的菜单Label的Name
            //使用LabelX(推荐使用)或Label控件

            Stack<(UserControl, object)> stack = new Stack<(UserControl, object)>();
            stack.Push((new UCSetting1() { Name = "UC_" + labelSet1.Name }, null));
            stack.Push((new UCSetting2() { Name = "UC_" + labelSet2.Name }, null));
            stack.Push((new UCSaveSetting() { Name = "UC_" + labelXSave.Name }, null));

            while(stack.Count>0)
            { 
                var item = stack.Pop();
                LoadUC(item.Item1, item.Item2);
            }
            //LoadUC(new UCSaveSetting() { Name = "UC_"+labelXSave.Name });
            //LoadUC(new UCSetting2() { Name = "UC_"+labelSet2.Name });
            //LoadUC(new UCSetting1() { Name = "UC_"+labelSet1.Name });
        }


    }
}
