namespace ManageSystem.UIDesign
{
    partial class UCLogList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loadingCircle1 = new ManageSystem.ControlX.DesignPatternTest.LoadingCircle();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dateTimeInputEnd = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxXMan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dateTimeInputStart = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.buttonXSearch = new DevComponents.DotNetBar.ButtonX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewXLog = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputStart)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXLog)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loadingCircle1);
            this.panel1.Controls.Add(this.labelX3);
            this.panel1.Controls.Add(this.dateTimeInputEnd);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Controls.Add(this.textBoxXMan);
            this.panel1.Controls.Add(this.dateTimeInputStart);
            this.panel1.Controls.Add(this.buttonXSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(454, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 415);
            this.panel1.TabIndex = 0;
            // 
            // loadingCircle1
            // 
            this.loadingCircle1.Active = false;
            this.loadingCircle1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loadingCircle1.Color = System.Drawing.Color.DarkGray;
            this.loadingCircle1.InnerCircleRadius = 5;
            this.loadingCircle1.Location = new System.Drawing.Point(16, 373);
            this.loadingCircle1.Name = "loadingCircle1";
            this.loadingCircle1.NumberSpoke = 12;
            this.loadingCircle1.OuterCircleRadius = 11;
            this.loadingCircle1.RotationSpeed = 100;
            this.loadingCircle1.Size = new System.Drawing.Size(34, 23);
            this.loadingCircle1.SpokeThickness = 2;
            this.loadingCircle1.StylePreset = ManageSystem.ControlX.DesignPatternTest.LoadingCircle.StylePresets.MacOSX;
            this.loadingCircle1.TabIndex = 7;
            this.loadingCircle1.Text = "loadingCircle1";
            this.loadingCircle1.Visible = false;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(12, 136);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 19);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "<--->";
            // 
            // dateTimeInputEnd
            // 
            // 
            // 
            // 
            this.dateTimeInputEnd.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInputEnd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputEnd.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInputEnd.ButtonDropDown.Visible = true;
            this.dateTimeInputEnd.CustomFormat = "yyyy/MM/dd HH:mm";
            this.dateTimeInputEnd.IsPopupCalendarOpen = false;
            this.dateTimeInputEnd.Location = new System.Drawing.Point(12, 156);
            this.dateTimeInputEnd.LockUpdateChecked = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.dateTimeInputEnd.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputEnd.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeInputEnd.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInputEnd.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInputEnd.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputEnd.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInputEnd.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInputEnd.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInputEnd.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInputEnd.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputEnd.MonthCalendar.DisplayMonth = new System.DateTime(2025, 6, 1, 0, 0, 0, 0);
            this.dateTimeInputEnd.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dateTimeInputEnd.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInputEnd.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputEnd.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInputEnd.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputEnd.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInputEnd.Name = "dateTimeInputEnd";
            this.dateTimeInputEnd.ShowCheckBox = true;
            this.dateTimeInputEnd.Size = new System.Drawing.Size(118, 21);
            this.dateTimeInputEnd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInputEnd.TabIndex = 5;
            this.dateTimeInputEnd.Value = new System.DateTime(2025, 6, 4, 11, 56, 0, 0);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 17);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "人员";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 83);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "日期";
            // 
            // textBoxXMan
            // 
            // 
            // 
            // 
            this.textBoxXMan.Border.Class = "TextBoxBorder";
            this.textBoxXMan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxXMan.Location = new System.Drawing.Point(12, 46);
            this.textBoxXMan.Name = "textBoxXMan";
            this.textBoxXMan.PreventEnterBeep = true;
            this.textBoxXMan.Size = new System.Drawing.Size(118, 21);
            this.textBoxXMan.TabIndex = 2;
            // 
            // dateTimeInputStart
            // 
            // 
            // 
            // 
            this.dateTimeInputStart.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInputStart.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputStart.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInputStart.ButtonDropDown.Visible = true;
            this.dateTimeInputStart.CustomFormat = "yyyy/MM/dd HH:mm";
            this.dateTimeInputStart.IsPopupCalendarOpen = false;
            this.dateTimeInputStart.Location = new System.Drawing.Point(12, 114);
            this.dateTimeInputStart.LockUpdateChecked = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.dateTimeInputStart.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputStart.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeInputStart.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInputStart.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInputStart.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputStart.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInputStart.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInputStart.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInputStart.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInputStart.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputStart.MonthCalendar.DisplayMonth = new System.DateTime(2025, 6, 1, 0, 0, 0, 0);
            this.dateTimeInputStart.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dateTimeInputStart.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInputStart.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputStart.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInputStart.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputStart.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInputStart.Name = "dateTimeInputStart";
            this.dateTimeInputStart.ShowCheckBox = true;
            this.dateTimeInputStart.Size = new System.Drawing.Size(118, 21);
            this.dateTimeInputStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInputStart.TabIndex = 1;
            this.dateTimeInputStart.Value = new System.DateTime(2025, 6, 4, 11, 55, 18, 0);
            // 
            // buttonXSearch
            // 
            this.buttonXSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonXSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonXSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonXSearch.Location = new System.Drawing.Point(58, 370);
            this.buttonXSearch.Name = "buttonXSearch";
            this.buttonXSearch.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5);
            this.buttonXSearch.Size = new System.Drawing.Size(75, 28);
            this.buttonXSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonXSearch.TabIndex = 0;
            this.buttonXSearch.Text = "查  询";
            this.buttonXSearch.Click += new System.EventHandler(this.buttonXSearch_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewXLog);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(454, 415);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewXLog
            // 
            this.dataGridViewXLog.AllowUserToAddRows = false;
            this.dataGridViewXLog.AllowUserToDeleteRows = false;
            this.dataGridViewXLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewXLog.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewXLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewXLog.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewXLog.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewXLog.Name = "dataGridViewXLog";
            this.dataGridViewXLog.ReadOnly = true;
            this.dataGridViewXLog.RowTemplate.Height = 23;
            this.dataGridViewXLog.Size = new System.Drawing.Size(434, 395);
            this.dataGridViewXLog.TabIndex = 0;
            // 
            // UCLogList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCLogList";
            this.Size = new System.Drawing.Size(601, 415);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputStart)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewXLog;
        private DevComponents.DotNetBar.ButtonX buttonXSearch;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxXMan;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInputStart;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInputEnd;
        private DevComponents.DotNetBar.LabelX labelX3;
        private ControlX.DesignPatternTest.LoadingCircle loadingCircle1;
    }
}
