namespace ManageSystem
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.buttonLogin = new DevComponents.DotNetBar.ButtonX();
            this.buttonCancle = new DevComponents.DotNetBar.ButtonX();
            this.textBoxUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.checkBoxRememberPwd = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonLogin.Location = new System.Drawing.Point(393, 334);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(63, 30);
            this.buttonLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "登 录";
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonCancle
            // 
            this.buttonCancle.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonCancle.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonCancle.Location = new System.Drawing.Point(493, 334);
            this.buttonCancle.Name = "buttonCancle";
            this.buttonCancle.Size = new System.Drawing.Size(63, 30);
            this.buttonCancle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonCancle.TabIndex = 1;
            this.buttonCancle.Text = "退 出";
            this.buttonCancle.Click += new System.EventHandler(this.buttonCancle_Click);
            // 
            // textBoxUserName
            // 
            // 
            // 
            // 
            this.textBoxUserName.Border.Class = "TextBoxBorder";
            this.textBoxUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxUserName.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBoxUserName.Location = new System.Drawing.Point(382, 204);
            this.textBoxUserName.Multiline = true;
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.PreventEnterBeep = true;
            this.textBoxUserName.Size = new System.Drawing.Size(181, 29);
            this.textBoxUserName.TabIndex = 4;
            this.textBoxUserName.WatermarkText = "请输入用户名";
            // 
            // textBoxPassword
            // 
            // 
            // 
            // 
            this.textBoxPassword.Border.Class = "TextBoxBorder";
            this.textBoxPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPassword.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBoxPassword.Location = new System.Drawing.Point(382, 246);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.PreventEnterBeep = true;
            this.textBoxPassword.Size = new System.Drawing.Size(181, 29);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.WatermarkText = "请输入密码";
            // 
            // checkBoxRememberPwd
            // 
            this.checkBoxRememberPwd.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.checkBoxRememberPwd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxRememberPwd.Location = new System.Drawing.Point(382, 290);
            this.checkBoxRememberPwd.Name = "checkBoxRememberPwd";
            this.checkBoxRememberPwd.Size = new System.Drawing.Size(74, 23);
            this.checkBoxRememberPwd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxRememberPwd.TabIndex = 6;
            this.checkBoxRememberPwd.Text = "记住密码";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.panelEx1.Controls.Add(this.pictureBox1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(437, 118);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(80, 80);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.CornerDiameter = 80;
            this.panelEx1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 8;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("华文楷体", 20F);
            this.labelX1.Location = new System.Drawing.Point(382, 74);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(181, 30);
            this.labelX1.TabIndex = 12;
            this.labelX1.Text = "管理系统";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(534, 298);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(29, 12);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "注册";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(672, 451);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.checkBoxRememberPwd);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.buttonCancle);
            this.Controls.Add(this.buttonLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonLogin;
        private DevComponents.DotNetBar.ButtonX buttonCancle;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxUserName;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxPassword;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxRememberPwd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}