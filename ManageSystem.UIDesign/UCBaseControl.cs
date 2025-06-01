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
    }
}
