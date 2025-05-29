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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSelect = new DevComponents.DotNetBar.LabelX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonQuery = new DevComponents.DotNetBar.ButtonX();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelSelect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.panel1.Size = new System.Drawing.Size(114, 479);
            this.panel1.TabIndex = 0;
            // 
            // labelSelect
            // 
            this.labelSelect.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelSelect.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSelect.Location = new System.Drawing.Point(0, 15);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(114, 37);
            this.labelSelect.TabIndex = 20;
            this.labelSelect.Text = "用户列表";
            this.labelSelect.TextAlignment = System.Drawing.StringAlignment.Center;
            this.labelSelect.Click += new System.EventHandler(this.labelSelect_Click);
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.RowTemplate.Height = 23;
            this.dataGridViewX1.Size = new System.Drawing.Size(667, 479);
            this.dataGridViewX1.TabIndex = 1;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dataGridViewX1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(124, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 479);
            this.panel2.TabIndex = 22;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(14, 15);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(53, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "labelX1";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(14, 74);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(53, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "labelX2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonQuery);
            this.panel3.Controls.Add(this.textBoxX1);
            this.panel3.Controls.Add(this.labelX1);
            this.panel3.Controls.Add(this.labelX2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(483, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 479);
            this.panel3.TabIndex = 4;
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Location = new System.Drawing.Point(14, 37);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(156, 21);
            this.textBoxX1.TabIndex = 5;
            // 
            // buttonQuery
            // 
            this.buttonQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonQuery.Location = new System.Drawing.Point(95, 440);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonQuery.TabIndex = 6;
            this.buttonQuery.Text = "查  询";
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // UCUserManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.panel1);
            this.Name = "UCUserManage";
            this.Size = new System.Drawing.Size(791, 479);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.LabelX labelSelect;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.Controls.Line line1;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.ButtonX buttonQuery;
    }
}
