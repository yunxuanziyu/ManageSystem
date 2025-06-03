namespace ManageSystem.UIDesign
{
    partial class UCCargoDefine
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxXCargoType = new ManageSystem.ControlX.ComboBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.buttonXSave = new DevComponents.DotNetBar.ButtonX();
            this.textBoxExSpecifications = new ManageSystem.ControlX.TextBoxEx();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.textBoxExUnit = new ManageSystem.ControlX.TextBoxEx();
            this.textBoxExUnitPrice = new ManageSystem.ControlX.TextBoxEx();
            this.textBoxExAliasName = new ManageSystem.ControlX.TextBoxEx();
            this.textBoxExCode = new ManageSystem.ControlX.TextBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.textBoxExName = new ManageSystem.ControlX.TextBoxEx();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.buttonXAdd = new DevComponents.DotNetBar.ButtonX();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ucBaseControl1 = new ManageSystem.UIDesign.UCBaseControl();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.ucBaseControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(11, 38);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(35, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "名称";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(11, 101);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(35, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "单价";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(11, 70);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(35, 23);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "别名";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(11, 137);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(35, 23);
            this.labelX4.TabIndex = 4;
            this.labelX4.Tag = "Unit";
            this.labelX4.Text = "单位";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.line2);
            this.panel1.Controls.Add(this.ucBaseControl1);
            this.panel1.Controls.Add(this.buttonXSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(508, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 526);
            this.panel1.TabIndex = 8;
            // 
            // comboBoxXCargoType
            // 
            this.comboBoxXCargoType.BindField = "CargoType";
            this.comboBoxXCargoType.DisplayMember = "Text";
            this.comboBoxXCargoType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxXCargoType.EnumBindField = "CargoType";
            this.comboBoxXCargoType.FormattingEnabled = true;
            this.comboBoxXCargoType.ItemHeight = 15;
            this.comboBoxXCargoType.Location = new System.Drawing.Point(54, 193);
            this.comboBoxXCargoType.Name = "comboBoxXCargoType";
            this.comboBoxXCargoType.Size = new System.Drawing.Size(118, 21);
            this.comboBoxXCargoType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxXCargoType.TabIndex = 17;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(11, 195);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(41, 23);
            this.labelX7.TabIndex = 16;
            this.labelX7.Text = "类别";
            // 
            // buttonXSave
            // 
            this.buttonXSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonXSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonXSave.Location = new System.Drawing.Point(101, 483);
            this.buttonXSave.Name = "buttonXSave";
            this.buttonXSave.Size = new System.Drawing.Size(75, 33);
            this.buttonXSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonXSave.TabIndex = 15;
            this.buttonXSave.Text = "保  存";
            this.toolTip1.SetToolTip(this.buttonXSave, "保存数据入库");
            this.buttonXSave.Click += new System.EventHandler(this.buttonXSave_Click);
            // 
            // textBoxExSpecifications
            // 
            this.textBoxExSpecifications.BindField = "Specifications";
            // 
            // 
            // 
            this.textBoxExSpecifications.Border.Class = "TextBoxBorder";
            this.textBoxExSpecifications.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxExSpecifications.Location = new System.Drawing.Point(54, 166);
            this.textBoxExSpecifications.Name = "textBoxExSpecifications";
            this.textBoxExSpecifications.PreventEnterBeep = true;
            this.textBoxExSpecifications.Size = new System.Drawing.Size(118, 21);
            this.textBoxExSpecifications.TabIndex = 14;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(11, 166);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(41, 23);
            this.labelX6.TabIndex = 13;
            this.labelX6.Tag = "";
            this.labelX6.Text = "规格";
            // 
            // textBoxExUnit
            // 
            this.textBoxExUnit.BindField = "Unit";
            // 
            // 
            // 
            this.textBoxExUnit.Border.Class = "TextBoxBorder";
            this.textBoxExUnit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxExUnit.Location = new System.Drawing.Point(54, 137);
            this.textBoxExUnit.Name = "textBoxExUnit";
            this.textBoxExUnit.PreventEnterBeep = true;
            this.textBoxExUnit.Size = new System.Drawing.Size(118, 21);
            this.textBoxExUnit.TabIndex = 12;
            // 
            // textBoxExUnitPrice
            // 
            this.textBoxExUnitPrice.BindField = "UnitPrice";
            // 
            // 
            // 
            this.textBoxExUnitPrice.Border.Class = "TextBoxBorder";
            this.textBoxExUnitPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxExUnitPrice.Location = new System.Drawing.Point(54, 101);
            this.textBoxExUnitPrice.Name = "textBoxExUnitPrice";
            this.textBoxExUnitPrice.PreventEnterBeep = true;
            this.textBoxExUnitPrice.Size = new System.Drawing.Size(118, 21);
            this.textBoxExUnitPrice.TabIndex = 11;
            // 
            // textBoxExAliasName
            // 
            this.textBoxExAliasName.BindField = "AliasName";
            // 
            // 
            // 
            this.textBoxExAliasName.Border.Class = "TextBoxBorder";
            this.textBoxExAliasName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxExAliasName.Location = new System.Drawing.Point(54, 70);
            this.textBoxExAliasName.Name = "textBoxExAliasName";
            this.textBoxExAliasName.PreventEnterBeep = true;
            this.textBoxExAliasName.Size = new System.Drawing.Size(118, 21);
            this.textBoxExAliasName.TabIndex = 10;
            // 
            // textBoxExCode
            // 
            this.textBoxExCode.BindField = "Code";
            // 
            // 
            // 
            this.textBoxExCode.Border.Class = "TextBoxBorder";
            this.textBoxExCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxExCode.Location = new System.Drawing.Point(54, 9);
            this.textBoxExCode.Name = "textBoxExCode";
            this.textBoxExCode.PreventEnterBeep = true;
            this.textBoxExCode.Size = new System.Drawing.Size(118, 21);
            this.textBoxExCode.TabIndex = 9;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(11, 9);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(41, 23);
            this.labelX5.TabIndex = 8;
            this.labelX5.Text = "编码";
            // 
            // textBoxExName
            // 
            this.textBoxExName.BindField = "Name";
            // 
            // 
            // 
            this.textBoxExName.Border.Class = "TextBoxBorder";
            this.textBoxExName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxExName.Location = new System.Drawing.Point(54, 38);
            this.textBoxExName.Name = "textBoxExName";
            this.textBoxExName.PreventEnterBeep = true;
            this.textBoxExName.Size = new System.Drawing.Size(118, 21);
            this.textBoxExName.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewX1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(508, 526);
            this.panel2.TabIndex = 9;
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.RowTemplate.Height = 23;
            this.dataGridViewX1.Size = new System.Drawing.Size(488, 506);
            this.dataGridViewX1.TabIndex = 0;
            // 
            // buttonXAdd
            // 
            this.buttonXAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonXAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonXAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonXAdd.Location = new System.Drawing.Point(95, 421);
            this.buttonXAdd.Name = "buttonXAdd";
            this.buttonXAdd.Size = new System.Drawing.Size(75, 33);
            this.buttonXAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonXAdd.TabIndex = 18;
            this.buttonXAdd.Text = "添  加";
            this.toolTip1.SetToolTip(this.buttonXAdd, "加入左侧列表");
            this.buttonXAdd.Click += new System.EventHandler(this.buttonXAdd_Click);
            // 
            // ucBaseControl1
            // 
            this.ucBaseControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucBaseControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ucBaseControl1.Controls.Add(this.textBoxExCode);
            this.ucBaseControl1.Controls.Add(this.buttonXAdd);
            this.ucBaseControl1.Controls.Add(this.labelX1);
            this.ucBaseControl1.Controls.Add(this.comboBoxXCargoType);
            this.ucBaseControl1.Controls.Add(this.labelX2);
            this.ucBaseControl1.Controls.Add(this.labelX7);
            this.ucBaseControl1.Controls.Add(this.labelX4);
            this.ucBaseControl1.Controls.Add(this.labelX3);
            this.ucBaseControl1.Controls.Add(this.textBoxExSpecifications);
            this.ucBaseControl1.Controls.Add(this.textBoxExName);
            this.ucBaseControl1.Controls.Add(this.labelX6);
            this.ucBaseControl1.Controls.Add(this.labelX5);
            this.ucBaseControl1.Controls.Add(this.textBoxExUnit);
            this.ucBaseControl1.Controls.Add(this.textBoxExAliasName);
            this.ucBaseControl1.Controls.Add(this.textBoxExUnitPrice);
            this.ucBaseControl1.CornerRadius = 50;
            this.ucBaseControl1.Location = new System.Drawing.Point(6, 10);
            this.ucBaseControl1.Name = "ucBaseControl1";
            this.ucBaseControl1.Size = new System.Drawing.Size(185, 467);
            this.ucBaseControl1.TabIndex = 19;
            // 
            // line2
            // 
            this.line2.Location = new System.Drawing.Point(3, 472);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(188, 10);
            this.line2.TabIndex = 19;
            this.line2.Text = "line2";
            // 
            // UCCargoDefine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCCargoDefine";
            this.Size = new System.Drawing.Size(702, 526);
            this.Load += new System.EventHandler(this.UCCargoDefine_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ucBaseControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private ControlX.TextBoxEx textBoxExCode;
        private DevComponents.DotNetBar.LabelX labelX5;
        private ControlX.TextBoxEx textBoxExName;
        private ControlX.TextBoxEx textBoxExAliasName;
        private DevComponents.DotNetBar.ButtonX buttonXSave;
        private ControlX.TextBoxEx textBoxExSpecifications;
        private DevComponents.DotNetBar.LabelX labelX6;
        private ControlX.TextBoxEx textBoxExUnit;
        private ControlX.TextBoxEx textBoxExUnitPrice;
        private ControlX.ComboBoxX comboBoxXCargoType;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.ButtonX buttonXAdd;
        private System.Windows.Forms.ToolTip toolTip1;
        private UCBaseControl ucBaseControl1;
        private DevComponents.DotNetBar.Controls.Line line2;
    }
}
