namespace ManageSystem.UIDesign
{
    partial class UCSystemSet
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSet2 = new DevComponents.DotNetBar.LabelX();
            this.labelSet1 = new DevComponents.DotNetBar.LabelX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.panelXHolder = new ManageSystem.ControlX.PanelX(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelSet2);
            this.panel1.Controls.Add(this.labelSet1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel1.Size = new System.Drawing.Size(114, 359);
            this.panel1.TabIndex = 1;
            // 
            // labelSet2
            // 
            this.labelSet2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelSet2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelSet2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSet2.Location = new System.Drawing.Point(0, 47);
            this.labelSet2.Name = "labelSet2";
            this.labelSet2.Size = new System.Drawing.Size(114, 37);
            this.labelSet2.TabIndex = 22;
            this.labelSet2.Text = "设置2";
            this.labelSet2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.labelSet2.Click += new System.EventHandler(this.labelSetCheck_Click);
            // 
            // labelSet1
            // 
            this.labelSet1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelSet1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelSet1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSet1.Location = new System.Drawing.Point(0, 10);
            this.labelSet1.Name = "labelSet1";
            this.labelSet1.Size = new System.Drawing.Size(114, 37);
            this.labelSet1.TabIndex = 21;
            this.labelSet1.Text = "设置1";
            this.labelSet1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.labelSet1.Click += new System.EventHandler(this.labelSetCheck_Click);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.Transparent;
            this.line1.Dock = System.Windows.Forms.DockStyle.Left;
            this.line1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.line1.Location = new System.Drawing.Point(114, 0);
            this.line1.Margin = new System.Windows.Forms.Padding(0, 13, 0, 13);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(10, 359);
            this.line1.TabIndex = 23;
            this.line1.Text = "line1";
            this.line1.VerticalLine = true;
            // 
            // panelXHolder
            // 
            this.panelXHolder.AutoScroll = true;
            this.panelXHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelXHolder.Location = new System.Drawing.Point(124, 0);
            this.panelXHolder.Name = "panelXHolder";
            this.panelXHolder.Padding = new System.Windows.Forms.Padding(10);
            this.panelXHolder.Size = new System.Drawing.Size(528, 359);
            this.panelXHolder.TabIndex = 24;
            this.panelXHolder.MouseEnter += new System.EventHandler(this.labelX_MouseEnter);
            this.panelXHolder.MouseLeave += new System.EventHandler(this.labelX_MouseLeave);
            // 
            // UCSystemSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelXHolder);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.panel1);
            this.Name = "UCSystemSet";
            this.Size = new System.Drawing.Size(652, 359);
            this.Load += new System.EventHandler(this.UCSystemSet_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.LabelX labelSet2;
        private DevComponents.DotNetBar.LabelX labelSet1;
        private DevComponents.DotNetBar.Controls.Line line1;
        private ControlX.PanelX panelXHolder;
    }
}
