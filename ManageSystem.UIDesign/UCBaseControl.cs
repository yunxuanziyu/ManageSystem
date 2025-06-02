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
using DevComponents.WinForms.Drawing;
using System.Drawing.Drawing2D;
using DevComponents.DotNetBar.Controls;
using ManageSystem.DataManage.Model;
using System.Linq.Expressions;
using ManageSystem.ControlX;
using static ManageSystem.ControlX.ComboBoxX;
using static ManageSystem.ControlX.ComboTreeX;

namespace ManageSystem.UIDesign
{
    public partial class UCBaseControl: UserControl
    {
        public UCBaseControl()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }

        public void WriteData<T>(object data,Control p)where T : class
        {
            T obj = (T)data;
            //TODO:Binding Data
            foreach (var c in p.Controls)
            {
                switch (c)
                {
                    case ComboBoxX cbx:
                        if (!string.IsNullOrEmpty(cbx.BindField))
                        {
                            string bindValue = typeof(T).GetProperty(cbx.BindField)?.GetValue(obj, null)?.ToString();
                            cbx.SelectedItem = cbx.Items.Cast<ItemNode>().FirstOrDefault(item => item.Value.ToString() == bindValue);
                        }
                        break;
                    case PictureBoxX pbx:
                        if(!string.IsNullOrEmpty(pbx.BindField))
                        {
                            Image img = (Image)typeof(T).GetProperty(pbx.BindField)?.GetValue(obj, null);
                            if (img != null) pbx.BackgroundImage = img;
                        }
                        break;
                    case TextBoxEx tbx:
                        if (!string.IsNullOrEmpty(tbx.BindField))
                            tbx.Text = typeof(T).GetProperty(tbx.BindField)?.GetValue(obj, null)?.ToString();
                        break;
                    case ComboTreeX comboTree:
                        if (!string.IsNullOrEmpty(comboTree.BindField))
                        {
                           string bindValue = typeof(T).GetProperty(comboTree.BindField)?.GetValue(obj, null)?.ToString();
                            comboTree.SelectedNode = comboTree.Nodes.Cast<EnumerationNode>().FirstOrDefault(node => node.Value.ToString() == bindValue);
                        }
                        break;
                    case DateTimeInputX dtx:
                        if (!string.IsNullOrEmpty(dtx.BindField))
                            dtx.Value = (DateTime)typeof(T).GetProperty(dtx.BindField)?.GetValue(obj, null);
                        break;
                }
            }
        }

        public void ReadData<T>(object data, UserControl uc) where T : class
        {
            T obj = (T)data;
            //TODO:Binding Data
            foreach (var c in uc.Controls.OfType<Control>())
            {
                switch (c)
                {
                    case ComboBoxX cbx:
                        if (!string.IsNullOrEmpty(cbx.BindField))
                            typeof(T).GetProperty(cbx.BindField).SetValue(obj, (cbx.SelectedItem as ItemNode).Value);
                        break;
                    case PictureBoxX pbx:
                        if (!string.IsNullOrEmpty(pbx.BindField) && pbx.BackgroundImage != null)
                            typeof(T).GetProperty(pbx.BindField).SetValue(obj, pbx.BackgroundImage);
                        break;
                    case TextBoxEx tbx:
                        if (!string.IsNullOrEmpty(tbx.BindField))
                            typeof(T).GetProperty(tbx.BindField).SetValue(obj, tbx.Text);
                        break;
                    case ComboTreeX comboTree:
                        if (!string.IsNullOrEmpty(comboTree.BindField))
                            typeof(T).GetProperty(comboTree.BindField).SetValue(obj, (comboTree.SelectedNode as EnumerationNode).Value);
                        break;
                    case DateTimeInputX dtx:
                        if (!string.IsNullOrEmpty(dtx.BindField))
                            typeof(T).GetProperty(dtx.BindField).SetValue(obj, dtx.Value);
                        break;
                }
            }
        }

        /// <summary>
        /// LabelX的事件绑定,
        /// UC的Menu可通用
        /// </summary>
        /// <param name="panel"></param>
        public void LabelXBindingEvent(Panel panel,bool BindScroll = false)
        {
            foreach (Control l in panel.Controls.Cast<Control>().Where(c=>c is LabelX || c is Label))
            {
                l.MouseEnter += labelX_MouseEnter;
                l.MouseLeave += labelX_MouseLeave;
                l.MouseClick += labelSet_MouseClick;
                if (BindScroll)
                    l.Click += labelScroll_Click;
            }
        }
        private void labelScroll_Click(object sender, EventArgs e)
        {
            Control label = sender as Control;
            Control FindControl = label;
            Control parentControl = null;
            //寻找Menu的LabelX所在的最外层UC
            do
            {
                parentControl = FindControl.Parent;
                FindControl = parentControl;
            } while (!(parentControl is UserControl));
            //父UC里所有的子UC(存放实际内容的UC)
            var targetControl = parentControl.Controls.Cast<Control>()
                .SelectMany(c => new[] { c }.Concat(GetAllChildren(c)))
                .FirstOrDefault(c => c.Name == "UC_"+label.Name);
            //实际需要的UC的父Panel
            Panel UCparentPanel = targetControl?.Parent as Panel;
            // 计算相对位置
            Point targetPosition = targetControl.Parent.PointToScreen(targetControl.Location);
            Point panelPosition = UCparentPanel.PointToScreen(Point.Empty);
            int relativeY = targetPosition.Y - panelPosition.Y;
            // 执行滚动
            UCparentPanel.AutoScrollPosition = new Point(0, relativeY);
        }

        public void labelX_MouseEnter(object sender, EventArgs e)
        {
            LabelX lbl = sender as LabelX;
            if (lbl.BackColor == Color.Transparent)
                lbl.BackColor = Color.White;
        }

        public void labelX_MouseLeave(object sender, EventArgs e)
        {
            LabelX lbl = sender as LabelX;
            if (lbl.BackColor == Color.White)
                lbl.BackColor = Color.Transparent;
        }
        private void labelSet_MouseClick(object sender, MouseEventArgs e)
        {
            Panel _panel = (sender as Control).Parent as Panel;
            _panel.Controls.Cast<Control>().Where(c => c is LabelX || c is Label).ToList().ForEach(c => c.BackColor = ((c.Name == (sender as Control).Name) ? Color.FromArgb(226, 230, 235) : Color.Transparent));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataGridViewX1"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public List<int> GetSelectedRows(DataGridView dataGridViewX1,string columnName = "ID")
        {
            var selectedIndexes = new List<int>();
            for (int i = 0; i < dataGridViewX1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridViewX1.Rows[i].Cells[0].Value))
                {
                    int rowID = Convert.ToInt32(dataGridViewX1.Rows[i].Cells[columnName].Value);
                    selectedIndexes.Add(rowID);
                }
            }
            return selectedIndexes;
        }
        public void LoadUCPage(Panel panelUCHolder, UserControl uc)
        {
            if (uc == panelUCHolder.Controls.OfType<UserControl>().FirstOrDefault())
                return;
            uc.Dock = DockStyle.Fill;
            if (!panelUCHolder.Controls.Contains(uc))
                panelUCHolder.Controls.Add(uc);
            uc.BringToFront();
            foreach(var c in panelUCHolder.Controls.OfType<UserControl>())
                c.Visible = c == uc;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetRoundRegion();
        }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);

        //    int shadowSize = 8; // 阴影宽度
        //    int radius = CornerRadius;
        //    Rectangle shadowRect = new Rectangle(
        //        shadowSize / 2,
        //        shadowSize / 2,
        //        this.Width - shadowSize,
        //        this.Height - shadowSize);

        //    using (GraphicsPath path = new GraphicsPath())
        //    {
        //        path.StartFigure();
        //        path.AddArc(shadowRect.Left, shadowRect.Top, radius, radius, 180, 90);
        //        path.AddArc(shadowRect.Right - radius, shadowRect.Top, radius, radius, 270, 90);
        //        path.AddArc(shadowRect.Right - radius, shadowRect.Bottom - radius, radius, radius, 0, 90);
        //        path.AddArc(shadowRect.Left, shadowRect.Bottom - radius, radius, radius, 90, 90);
        //        path.CloseFigure();

        //        // 绘制阴影
        //        using (PathGradientBrush brush = new PathGradientBrush(path))
        //        {
        //            brush.CenterColor = Color.FromArgb(80, Color.Black); // 阴影中心色
        //            brush.SurroundColors = new Color[] { Color.Transparent };
        //            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        //            e.Graphics.FillPath(brush, path);
        //        }
        //    }
        //}

        public int CornerRadius { get; set; } = 50;
        private void SetRoundRegion()
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = CornerRadius;
                path.StartFigure();
                path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
                path.AddArc(new Rectangle(this.Width - radius, 0, radius, radius), 270, 90);
                path.AddArc(new Rectangle(this.Width - radius, this.Height - radius, radius, radius), 0, 90);
                path.AddArc(new Rectangle(0, this.Height - radius, radius, radius), 90, 90);
                path.CloseFigure();
                this.Region = new Region(path);
            }
        }

        IEnumerable<Control> GetAllChildren(Control parent) =>
            parent.Controls.Cast<Control>().SelectMany(c => new[] { c }.Concat(GetAllChildren(c)));
    }
}
