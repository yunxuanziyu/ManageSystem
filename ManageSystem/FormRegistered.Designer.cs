namespace ManageSystem
{
    partial class FormRegistered
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
            this.textBoxRegisterCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxMachineCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.buttonRegister = new DevComponents.DotNetBar.ButtonX();
            this.buttonGetMachineCode = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // textBoxRegisterCode
            // 
            // 
            // 
            // 
            this.textBoxRegisterCode.Border.Class = "TextBoxBorder";
            this.textBoxRegisterCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxRegisterCode.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBoxRegisterCode.Location = new System.Drawing.Point(78, 75);
            this.textBoxRegisterCode.Multiline = true;
            this.textBoxRegisterCode.Name = "textBoxRegisterCode";
            this.textBoxRegisterCode.PreventEnterBeep = true;
            this.textBoxRegisterCode.Size = new System.Drawing.Size(341, 92);
            this.textBoxRegisterCode.TabIndex = 7;
            this.textBoxRegisterCode.WatermarkText = "注册码";
            // 
            // textBoxMachineCode
            // 
            // 
            // 
            // 
            this.textBoxMachineCode.Border.Class = "TextBoxBorder";
            this.textBoxMachineCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxMachineCode.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBoxMachineCode.Location = new System.Drawing.Point(78, 33);
            this.textBoxMachineCode.Multiline = true;
            this.textBoxMachineCode.Name = "textBoxMachineCode";
            this.textBoxMachineCode.PreventEnterBeep = true;
            this.textBoxMachineCode.Size = new System.Drawing.Size(341, 29);
            this.textBoxMachineCode.TabIndex = 6;
            this.textBoxMachineCode.WatermarkText = "机器码";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.labelX1.Location = new System.Drawing.Point(22, 38);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(50, 23);
            this.labelX1.TabIndex = 8;
            this.labelX1.Text = "机器码";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.labelX2.Location = new System.Drawing.Point(22, 80);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(50, 23);
            this.labelX2.TabIndex = 9;
            this.labelX2.Text = "注册码";
            // 
            // buttonRegister
            // 
            this.buttonRegister.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonRegister.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonRegister.Location = new System.Drawing.Point(346, 173);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(75, 30);
            this.buttonRegister.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonRegister.TabIndex = 11;
            this.buttonRegister.Text = "注  册";
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonGetMachineCode
            // 
            this.buttonGetMachineCode.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonGetMachineCode.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonGetMachineCode.Location = new System.Drawing.Point(253, 173);
            this.buttonGetMachineCode.Name = "buttonGetMachineCode";
            this.buttonGetMachineCode.Size = new System.Drawing.Size(75, 30);
            this.buttonGetMachineCode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonGetMachineCode.TabIndex = 10;
            this.buttonGetMachineCode.Text = "获取机器码";
            this.buttonGetMachineCode.Click += new System.EventHandler(this.buttonGetMachineCode_Click);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(19, 177);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(203, 23);
            this.labelX3.TabIndex = 12;
            // 
            // FormRegistered
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 212);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonGetMachineCode);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.textBoxRegisterCode);
            this.Controls.Add(this.textBoxMachineCode);
            this.Name = "FormRegistered";
            this.Text = "注册";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX textBoxRegisterCode;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxMachineCode;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX buttonRegister;
        private DevComponents.DotNetBar.ButtonX buttonGetMachineCode;
        private DevComponents.DotNetBar.LabelX labelX3;
    }
}