namespace ManageSystem.UIDesign
{
    partial class UCDataManage
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.panelUCHolder = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(112, 446);
            this.panelMenu.TabIndex = 0;
            // 
            // line1
            // 
            this.line1.Dock = System.Windows.Forms.DockStyle.Left;
            this.line1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.line1.Location = new System.Drawing.Point(112, 0);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(10, 446);
            this.line1.TabIndex = 1;
            this.line1.Text = "line1";
            this.line1.VerticalLine = true;
            // 
            // panelUCHolder
            // 
            this.panelUCHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUCHolder.Location = new System.Drawing.Point(122, 0);
            this.panelUCHolder.Name = "panelUCHolder";
            this.panelUCHolder.Padding = new System.Windows.Forms.Padding(10);
            this.panelUCHolder.Size = new System.Drawing.Size(412, 446);
            this.panelUCHolder.TabIndex = 2;
            // 
            // UCDataManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelUCHolder);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.panelMenu);
            this.Name = "UCDataManage";
            this.Size = new System.Drawing.Size(534, 446);
            this.Load += new System.EventHandler(this.UCDataManage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private DevComponents.DotNetBar.Controls.Line line1;
        private System.Windows.Forms.Panel panelUCHolder;
    }
}
