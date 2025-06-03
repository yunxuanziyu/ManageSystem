namespace ManageSystem.UIDesign
{
    partial class UCDeptManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSave = new DevComponents.DotNetBar.ButtonX();
            this.buttonQuery = new DevComponents.DotNetBar.ButtonX();
            this.textBoxCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelX1 = new ManageSystem.ControlX.PanelX(this.components);
            this.dataGridViewXDept = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.panel1.SuspendLayout();
            this.panelX1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXDept)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonQuery);
            this.panel1.Controls.Add(this.textBoxCode);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(453, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 418);
            this.panel1.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonSave.Location = new System.Drawing.Point(27, 382);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(56, 23);
            this.buttonSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "保 存";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonQuery
            // 
            this.buttonQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonQuery.Location = new System.Drawing.Point(100, 382);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(56, 23);
            this.buttonQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonQuery.TabIndex = 7;
            this.buttonQuery.Text = "查  询";
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // textBoxCode
            // 
            // 
            // 
            // 
            this.textBoxCode.Border.Class = "TextBoxBorder";
            this.textBoxCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxCode.Location = new System.Drawing.Point(6, 130);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.PreventEnterBeep = true;
            this.textBoxCode.Size = new System.Drawing.Size(161, 21);
            this.textBoxCode.TabIndex = 3;
            // 
            // textBoxName
            // 
            // 
            // 
            // 
            this.textBoxName.Border.Class = "TextBoxBorder";
            this.textBoxName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxName.Location = new System.Drawing.Point(6, 44);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PreventEnterBeep = true;
            this.textBoxName.Size = new System.Drawing.Size(161, 21);
            this.textBoxName.TabIndex = 2;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(3, 101);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "部门编码";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(6, 15);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "部门名称";
            // 
            // panelX1
            // 
            this.panelX1.Controls.Add(this.dataGridViewXDept);
            this.panelX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelX1.Location = new System.Drawing.Point(0, 0);
            this.panelX1.Name = "panelX1";
            this.panelX1.Padding = new System.Windows.Forms.Padding(10);
            this.panelX1.Size = new System.Drawing.Size(453, 418);
            this.panelX1.TabIndex = 1;
            // 
            // dataGridViewXDept
            // 
            this.dataGridViewXDept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewXDept.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewXDept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewXDept.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewXDept.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewXDept.Name = "dataGridViewXDept";
            this.dataGridViewXDept.RowTemplate.Height = 23;
            this.dataGridViewXDept.Size = new System.Drawing.Size(433, 398);
            this.dataGridViewXDept.TabIndex = 0;
            // 
            // UCDeptManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelX1);
            this.Controls.Add(this.panel1);
            this.Name = "UCDeptManage";
            this.Size = new System.Drawing.Size(637, 418);
            this.panel1.ResumeLayout(false);
            this.panelX1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXDept)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxCode;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxName;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX buttonSave;
        private DevComponents.DotNetBar.ButtonX buttonQuery;
        private ControlX.PanelX panelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewXDept;
    }
}
