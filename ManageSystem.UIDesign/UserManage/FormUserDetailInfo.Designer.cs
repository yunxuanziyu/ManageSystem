namespace ManageSystem.UIDesign
{
    partial class FormUserDetailInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserDetailInfo));
            this.UCBaseControl1 = new ManageSystem.UIDesign.UCBaseControl();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.columnHeader1 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader2 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader3 = new DevComponents.AdvTree.ColumnHeader();
            this.pictureBoxX1 = new ManageSystem.ControlX.PictureBoxX();
            this.textBoxEx1 = new ManageSystem.ControlX.TextBoxEx();
            this.buttonXSave = new DevComponents.DotNetBar.ButtonX();
            this.textBoxEx2 = new ManageSystem.ControlX.TextBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.comboBoxX1 = new ManageSystem.ControlX.ComboBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX1)).BeginInit();
            this.SuspendLayout();
            // 
            // UCBaseControl1
            // 
            this.UCBaseControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.UCBaseControl1.CornerRadius = 50;
            this.UCBaseControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UCBaseControl1.Location = new System.Drawing.Point(10, 10);
            this.UCBaseControl1.Name = "UCBaseControl1";
            this.UCBaseControl1.Size = new System.Drawing.Size(654, 440);
            this.UCBaseControl1.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(31, 34);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(52, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "用户名";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "Column";
            this.columnHeader1.Width.Absolute = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            this.columnHeader2.Text = "Column";
            this.columnHeader2.Width.Absolute = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Name = "columnHeader3";
            this.columnHeader3.Text = "Column";
            this.columnHeader3.Width.Absolute = 150;
            // 
            // pictureBoxX1
            // 
            this.pictureBoxX1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxX1.BackgroundImage")));
            this.pictureBoxX1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxX1.BindField = null;
            this.pictureBoxX1.Location = new System.Drawing.Point(443, 34);
            this.pictureBoxX1.Name = "pictureBoxX1";
            this.pictureBoxX1.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxX1.TabIndex = 5;
            this.pictureBoxX1.TabStop = false;
            // 
            // textBoxEx1
            // 
            this.textBoxEx1.BindField = "Name";
            // 
            // 
            // 
            this.textBoxEx1.Border.Class = "TextBoxBorder";
            this.textBoxEx1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxEx1.Location = new System.Drawing.Point(76, 34);
            this.textBoxEx1.Name = "textBoxEx1";
            this.textBoxEx1.PreventEnterBeep = true;
            this.textBoxEx1.ReadOnly = true;
            this.textBoxEx1.Size = new System.Drawing.Size(100, 21);
            this.textBoxEx1.TabIndex = 4;
            // 
            // buttonXSave
            // 
            this.buttonXSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonXSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonXSave.Location = new System.Drawing.Point(550, 399);
            this.buttonXSave.Name = "buttonXSave";
            this.buttonXSave.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(15);
            this.buttonXSave.Size = new System.Drawing.Size(93, 34);
            this.buttonXSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonXSave.TabIndex = 6;
            this.buttonXSave.Text = "保存";
            // 
            // textBoxEx2
            // 
            this.textBoxEx2.BindField = "ChineseName";
            // 
            // 
            // 
            this.textBoxEx2.Border.Class = "TextBoxBorder";
            this.textBoxEx2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxEx2.Location = new System.Drawing.Point(76, 63);
            this.textBoxEx2.Name = "textBoxEx2";
            this.textBoxEx2.PreventEnterBeep = true;
            this.textBoxEx2.ReadOnly = true;
            this.textBoxEx2.Size = new System.Drawing.Size(100, 21);
            this.textBoxEx2.TabIndex = 8;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(31, 63);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(52, 23);
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "姓名";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(31, 92);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(52, 23);
            this.labelX3.TabIndex = 9;
            this.labelX3.Text = "姓名";
            // 
            // comboBoxX1
            // 
            this.comboBoxX1.BindField = "Sex";
            this.comboBoxX1.DisplayMember = "Text";
            this.comboBoxX1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxX1.EnumBindField = "Sex";
            this.comboBoxX1.FormattingEnabled = true;
            this.comboBoxX1.ItemHeight = 15;
            this.comboBoxX1.Location = new System.Drawing.Point(76, 92);
            this.comboBoxX1.Name = "comboBoxX1";
            this.comboBoxX1.Size = new System.Drawing.Size(100, 21);
            this.comboBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxX1.TabIndex = 10;
            // 
            // FormUserDetailInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 460);
            this.Controls.Add(this.comboBoxX1);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.textBoxEx2);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.buttonXSave);
            this.Controls.Add(this.pictureBoxX1);
            this.Controls.Add(this.textBoxEx1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.UCBaseControl1);
            this.Name = "FormUserDetailInfo";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "用户信息";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UCBaseControl UCBaseControl1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private ControlX.TextBoxEx textBoxEx1;
        private ControlX.PictureBoxX pictureBoxX1;
        private DevComponents.AdvTree.ColumnHeader columnHeader1;
        private DevComponents.AdvTree.ColumnHeader columnHeader2;
        private DevComponents.AdvTree.ColumnHeader columnHeader3;
        private DevComponents.DotNetBar.ButtonX buttonXSave;
        private ControlX.TextBoxEx textBoxEx2;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private ControlX.ComboBoxX comboBoxX1;
    }
}