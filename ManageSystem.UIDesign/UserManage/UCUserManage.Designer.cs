namespace ManageSystem.UIDesign
{
    partial class UCUserManage
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
            this.labelXDept = new DevComponents.DotNetBar.LabelX();
            this.labelUserList = new DevComponents.DotNetBar.LabelX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.labelXDept);
            this.panelMenu.Controls.Add(this.labelUserList);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.panelMenu.Size = new System.Drawing.Size(114, 479);
            this.panelMenu.TabIndex = 0;
            // 
            // labelXDept
            // 
            this.labelXDept.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelXDept.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelXDept.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelXDept.Location = new System.Drawing.Point(0, 52);
            this.labelXDept.Name = "labelXDept";
            this.labelXDept.Size = new System.Drawing.Size(114, 37);
            this.labelXDept.TabIndex = 21;
            this.labelXDept.Text = "部门列表";
            this.labelXDept.TextAlignment = System.Drawing.StringAlignment.Center;
            this.labelXDept.Click += new System.EventHandler(this.labelXDept_Click);
            // 
            // labelUserList
            // 
            this.labelUserList.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelUserList.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelUserList.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelUserList.Location = new System.Drawing.Point(0, 15);
            this.labelUserList.Name = "labelUserList";
            this.labelUserList.Size = new System.Drawing.Size(114, 37);
            this.labelUserList.TabIndex = 20;
            this.labelUserList.Text = "用户列表";
            this.labelUserList.TextAlignment = System.Drawing.StringAlignment.Center;
            this.labelUserList.Click += new System.EventHandler(this.labelUserList_Click);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.Transparent;
            this.line1.Dock = System.Windows.Forms.DockStyle.Left;
            this.line1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.line1.Location = new System.Drawing.Point(114, 0);
            this.line1.Margin = new System.Windows.Forms.Padding(0, 13, 0, 13);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(10, 479);
            this.line1.TabIndex = 21;
            this.line1.Text = "line1";
            this.line1.VerticalLine = true;
            // 
            // panelBody
            // 
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(124, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Padding = new System.Windows.Forms.Padding(5);
            this.panelBody.Size = new System.Drawing.Size(667, 479);
            this.panelBody.TabIndex = 22;
            // 
            // UCUserManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.panelMenu);
            this.Name = "UCUserManage";
            this.Size = new System.Drawing.Size(791, 479);
            this.Load += new System.EventHandler(this.UCUserManage_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private DevComponents.DotNetBar.LabelX labelUserList;
        private DevComponents.DotNetBar.Controls.Line line1;
        private System.Windows.Forms.Panel panelBody;
        private DevComponents.DotNetBar.LabelX labelXDept;
    }
}
