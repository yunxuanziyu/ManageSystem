namespace ManageSystem.UIDesign
{
    partial class UCDefineManage
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelDept = new DevComponents.DotNetBar.LabelX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.panelXHolder = new ManageSystem.ControlX.PanelX(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Controls.Add(this.labelDept);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 10, 8, 0);
            this.panel1.Size = new System.Drawing.Size(114, 401);
            this.panel1.TabIndex = 0;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX1.Location = new System.Drawing.Point(8, 47);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(98, 37);
            this.labelX1.Symbol = "";
            this.labelX1.SymbolColor = System.Drawing.Color.Blue;
            this.labelX1.TabIndex = 22;
            this.labelX1.Text = "物品定义";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.labelX1.Click += new System.EventHandler(this.labelX1_Click);
            // 
            // labelDept
            // 
            this.labelDept.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelDept.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelDept.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDept.Location = new System.Drawing.Point(8, 10);
            this.labelDept.Name = "labelDept";
            this.labelDept.Size = new System.Drawing.Size(98, 37);
            this.labelDept.Symbol = "";
            this.labelDept.SymbolColor = System.Drawing.Color.Blue;
            this.labelDept.TabIndex = 21;
            this.labelDept.Text = "部门定义";
            this.labelDept.TextAlignment = System.Drawing.StringAlignment.Center;
            this.labelDept.Click += new System.EventHandler(this.labelDept_Click);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.Transparent;
            this.line1.Dock = System.Windows.Forms.DockStyle.Left;
            this.line1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.line1.Location = new System.Drawing.Point(114, 0);
            this.line1.Margin = new System.Windows.Forms.Padding(0, 13, 0, 13);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(10, 401);
            this.line1.TabIndex = 22;
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
            this.panelXHolder.Size = new System.Drawing.Size(635, 401);
            this.panelXHolder.TabIndex = 23;
            // 
            // UCDefineManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelXHolder);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.panel1);
            this.Name = "UCDefineManage";
            this.Size = new System.Drawing.Size(759, 401);
            this.Load += new System.EventHandler(this.UCDefineManage_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.LabelX labelDept;
        private DevComponents.DotNetBar.LabelX labelX1;
        private ControlX.PanelX panelXHolder;
    }
}
