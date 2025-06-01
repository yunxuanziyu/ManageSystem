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
            this.panelmenu = new System.Windows.Forms.Panel();
            this.labelSet2 = new DevComponents.DotNetBar.LabelX();
            this.labelSet1 = new DevComponents.DotNetBar.LabelX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.panelXHolder = new ManageSystem.ControlX.PanelX(this.components);
            this.panelmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.Controls.Add(this.labelSet2);
            this.panelmenu.Controls.Add(this.labelSet1);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Padding = new System.Windows.Forms.Padding(8, 10, 8, 0);
            this.panelmenu.Size = new System.Drawing.Size(114, 359);
            this.panelmenu.TabIndex = 1;
            // 
            // labelSet2
            // 
            this.labelSet2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelSet2.BackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveText;
            this.labelSet2.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.DockSiteBackColor2;
            this.labelSet2.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.labelSet2.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.labelSet2.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.labelSet2.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.labelSet2.BackgroundStyle.CornerDiameter = 20;
            this.labelSet2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.labelSet2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSet2.Location = new System.Drawing.Point(8, 47);
            this.labelSet2.Name = "labelSet2";
            this.labelSet2.Size = new System.Drawing.Size(98, 37);
            this.labelSet2.Symbol = "";
            this.labelSet2.SymbolColor = System.Drawing.Color.Blue;
            this.labelSet2.TabIndex = 22;
            this.labelSet2.Text = "设置2";
            this.labelSet2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelSet1
            // 
            this.labelSet1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelSet1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelSet1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSet1.Location = new System.Drawing.Point(8, 10);
            this.labelSet1.Name = "labelSet1";
            this.labelSet1.Size = new System.Drawing.Size(98, 37);
            this.labelSet1.Symbol = "";
            this.labelSet1.SymbolColor = System.Drawing.Color.Blue;
            this.labelSet1.TabIndex = 21;
            this.labelSet1.Text = "设置1";
            this.labelSet1.TextAlignment = System.Drawing.StringAlignment.Center;
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
            // 
            // UCSystemSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelXHolder);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.panelmenu);
            this.Name = "UCSystemSet";
            this.Size = new System.Drawing.Size(652, 359);
            this.Load += new System.EventHandler(this.UCSystemSet_Load);
            this.panelmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmenu;
        private DevComponents.DotNetBar.LabelX labelSet2;
        private DevComponents.DotNetBar.LabelX labelSet1;
        private DevComponents.DotNetBar.Controls.Line line1;
        private ControlX.PanelX panelXHolder;
    }
}
