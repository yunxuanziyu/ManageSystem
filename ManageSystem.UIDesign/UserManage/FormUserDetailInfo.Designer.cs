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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.buttonXSave = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.ucBaseControl1 = new ManageSystem.UIDesign.UCBaseControl();
            this.comboBoxX1 = new ManageSystem.ControlX.ComboBoxX();
            this.dateTimeInputX1 = new ManageSystem.ControlX.DateTimeInputX();
            this.textBoxEx2 = new ManageSystem.ControlX.TextBoxEx();
            this.pictureBoxX1 = new ManageSystem.ControlX.PictureBoxX();
            this.textBoxEx1 = new ManageSystem.ControlX.TextBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.textBoxEx3 = new ManageSystem.ControlX.TextBoxEx();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.textBoxEx4 = new ManageSystem.ControlX.TextBoxEx();
            this.textBoxEx5 = new ManageSystem.ControlX.TextBoxEx();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.comboBoxX2 = new ManageSystem.ControlX.ComboBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.textBoxEx6 = new ManageSystem.ControlX.TextBoxEx();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.textBoxEx7 = new ManageSystem.ControlX.TextBoxEx();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(31, 34);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(46, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "用户名";
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
            this.buttonXSave.Click += new System.EventHandler(this.buttonXSave_Click);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(31, 63);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(39, 23);
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "姓名";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(31, 94);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(37, 23);
            this.labelX3.TabIndex = 9;
            this.labelX3.Text = "性别";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(31, 126);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(37, 23);
            this.labelX4.TabIndex = 12;
            this.labelX4.Text = "生日";
            // 
            // ucBaseControl1
            // 
            this.ucBaseControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ucBaseControl1.CornerRadius = 50;
            this.ucBaseControl1.Location = new System.Drawing.Point(31, 4);
            this.ucBaseControl1.Name = "ucBaseControl1";
            this.ucBaseControl1.Size = new System.Drawing.Size(13, 12);
            this.ucBaseControl1.TabIndex = 13;
            this.ucBaseControl1.Visible = false;
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
            this.comboBoxX1.Size = new System.Drawing.Size(124, 21);
            this.comboBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxX1.TabIndex = 14;
            // 
            // dateTimeInputX1
            // 
            // 
            // 
            // 
            this.dateTimeInputX1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInputX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputX1.BindField = "Birtdate";
            this.dateTimeInputX1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInputX1.ButtonDropDown.Visible = true;
            this.dateTimeInputX1.IsPopupCalendarOpen = false;
            this.dateTimeInputX1.Location = new System.Drawing.Point(76, 125);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dateTimeInputX1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputX1.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeInputX1.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInputX1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInputX1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputX1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInputX1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInputX1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInputX1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInputX1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputX1.MonthCalendar.DisplayMonth = new System.DateTime(2025, 6, 1, 0, 0, 0, 0);
            this.dateTimeInputX1.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dateTimeInputX1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInputX1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputX1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInputX1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputX1.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInputX1.Name = "dateTimeInputX1";
            this.dateTimeInputX1.Size = new System.Drawing.Size(124, 21);
            this.dateTimeInputX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInputX1.TabIndex = 10;
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
            this.textBoxEx2.Size = new System.Drawing.Size(124, 21);
            this.textBoxEx2.TabIndex = 8;
            // 
            // pictureBoxX1
            // 
            this.pictureBoxX1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxX1.BackgroundImage")));
            this.pictureBoxX1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxX1.BindField = "Image";
            this.pictureBoxX1.ErrorImage = global::ManageSystem.UIDesign.Properties.Resources.QQ截图20211231150004;
            this.pictureBoxX1.Location = new System.Drawing.Point(461, 13);
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
            this.textBoxEx1.Size = new System.Drawing.Size(124, 21);
            this.textBoxEx1.TabIndex = 4;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(230, 126);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(46, 23);
            this.labelX5.TabIndex = 15;
            this.labelX5.Text = "年龄";
            // 
            // textBoxEx3
            // 
            this.textBoxEx3.BindField = "Age";
            // 
            // 
            // 
            this.textBoxEx3.Border.Class = "TextBoxBorder";
            this.textBoxEx3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxEx3.Location = new System.Drawing.Point(280, 126);
            this.textBoxEx3.Name = "textBoxEx3";
            this.textBoxEx3.PreventEnterBeep = true;
            this.textBoxEx3.ReadOnly = true;
            this.textBoxEx3.Size = new System.Drawing.Size(125, 21);
            this.textBoxEx3.TabIndex = 16;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(31, 332);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(37, 23);
            this.labelX6.TabIndex = 17;
            this.labelX6.Text = "备注";
            // 
            // textBoxEx4
            // 
            this.textBoxEx4.BindField = "Remark";
            // 
            // 
            // 
            this.textBoxEx4.Border.Class = "TextBoxBorder";
            this.textBoxEx4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxEx4.Location = new System.Drawing.Point(31, 361);
            this.textBoxEx4.Multiline = true;
            this.textBoxEx4.Name = "textBoxEx4";
            this.textBoxEx4.PreventEnterBeep = true;
            this.textBoxEx4.Size = new System.Drawing.Size(374, 86);
            this.textBoxEx4.TabIndex = 18;
            // 
            // textBoxEx5
            // 
            this.textBoxEx5.BindField = "Phone";
            // 
            // 
            // 
            this.textBoxEx5.Border.Class = "TextBoxBorder";
            this.textBoxEx5.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxEx5.Location = new System.Drawing.Point(76, 154);
            this.textBoxEx5.MaxLength = 11;
            this.textBoxEx5.Name = "textBoxEx5";
            this.textBoxEx5.PreventEnterBeep = true;
            this.textBoxEx5.Size = new System.Drawing.Size(124, 21);
            this.textBoxEx5.TabIndex = 20;
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(31, 154);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(39, 23);
            this.labelX7.TabIndex = 19;
            this.labelX7.Text = "电话";
            // 
            // comboBoxX2
            // 
            this.comboBoxX2.BindField = "Sex";
            this.comboBoxX2.DisplayMember = "Text";
            this.comboBoxX2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxX2.EnumBindField = "Sex";
            this.comboBoxX2.FormattingEnabled = true;
            this.comboBoxX2.ItemHeight = 15;
            this.comboBoxX2.Location = new System.Drawing.Point(280, 154);
            this.comboBoxX2.Name = "comboBoxX2";
            this.comboBoxX2.Size = new System.Drawing.Size(125, 21);
            this.comboBoxX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxX2.TabIndex = 22;
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(228, 156);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(46, 23);
            this.labelX8.TabIndex = 21;
            this.labelX8.Text = "性别";
            // 
            // textBoxEx6
            // 
            this.textBoxEx6.BindField = "IDCard";
            // 
            // 
            // 
            this.textBoxEx6.Border.Class = "TextBoxBorder";
            this.textBoxEx6.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxEx6.Location = new System.Drawing.Point(280, 94);
            this.textBoxEx6.MaxLength = 18;
            this.textBoxEx6.Name = "textBoxEx6";
            this.textBoxEx6.PreventEnterBeep = true;
            this.textBoxEx6.Size = new System.Drawing.Size(125, 21);
            this.textBoxEx6.TabIndex = 24;
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(228, 94);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(48, 23);
            this.labelX9.TabIndex = 23;
            this.labelX9.Text = "身份证";
            // 
            // textBoxEx7
            // 
            this.textBoxEx7.BindField = "Hometown";
            // 
            // 
            // 
            this.textBoxEx7.Border.Class = "TextBoxBorder";
            this.textBoxEx7.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxEx7.Location = new System.Drawing.Point(76, 306);
            this.textBoxEx7.Name = "textBoxEx7";
            this.textBoxEx7.PreventEnterBeep = true;
            this.textBoxEx7.Size = new System.Drawing.Size(585, 21);
            this.textBoxEx7.TabIndex = 26;
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(31, 306);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(37, 23);
            this.labelX10.TabIndex = 25;
            this.labelX10.Text = "籍贯";
            // 
            // FormUserDetailInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 460);
            this.Controls.Add(this.textBoxEx7);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.textBoxEx6);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.comboBoxX2);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.textBoxEx5);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.textBoxEx4);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.textBoxEx3);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.comboBoxX1);
            this.Controls.Add(this.ucBaseControl1);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.dateTimeInputX1);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.textBoxEx2);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.buttonXSave);
            this.Controls.Add(this.pictureBoxX1);
            this.Controls.Add(this.textBoxEx1);
            this.Controls.Add(this.labelX1);
            this.Name = "FormUserDetailInfo";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "用户信息";
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.LabelX labelX1;
        private ControlX.TextBoxEx textBoxEx1;
        private ControlX.PictureBoxX pictureBoxX1;
        private DevComponents.DotNetBar.ButtonX buttonXSave;
        private ControlX.TextBoxEx textBoxEx2;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private ControlX.DateTimeInputX dateTimeInputX1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private UCBaseControl ucBaseControl1;
        private ControlX.ComboBoxX comboBoxX1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private ControlX.TextBoxEx textBoxEx3;
        private DevComponents.DotNetBar.LabelX labelX6;
        private ControlX.TextBoxEx textBoxEx4;
        private ControlX.TextBoxEx textBoxEx5;
        private DevComponents.DotNetBar.LabelX labelX7;
        private ControlX.ComboBoxX comboBoxX2;
        private DevComponents.DotNetBar.LabelX labelX8;
        private ControlX.TextBoxEx textBoxEx6;
        private DevComponents.DotNetBar.LabelX labelX9;
        private ControlX.TextBoxEx textBoxEx7;
        private DevComponents.DotNetBar.LabelX labelX10;
    }
}