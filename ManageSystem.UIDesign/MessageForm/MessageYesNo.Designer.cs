namespace ManageSystem.UIDesign
{
    partial class MessageYesNo
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
            this.labelMsg = new DevComponents.DotNetBar.LabelX();
            this.buttonYes = new DevComponents.DotNetBar.ButtonX();
            this.buttonNo = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelMsg
            // 
            this.labelMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelMsg.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelMsg.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMsg.Location = new System.Drawing.Point(12, 12);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(378, 91);
            this.labelMsg.TabIndex = 1;
            this.labelMsg.Text = "labelX1";
            this.labelMsg.TextLineAlignment = System.Drawing.StringAlignment.Near;
            // 
            // buttonYes
            // 
            this.buttonYes.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonYes.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonYes.Location = new System.Drawing.Point(255, 109);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(53, 23);
            this.buttonYes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonYes.TabIndex = 2;
            this.buttonYes.Text = "是";
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // buttonNo
            // 
            this.buttonNo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonNo.Location = new System.Drawing.Point(325, 109);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(53, 23);
            this.buttonNo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonNo.TabIndex = 3;
            this.buttonNo.Text = "否";
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // MessageYesNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 136);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.labelMsg);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageYesNo";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX buttonYes;
        private DevComponents.DotNetBar.ButtonX buttonNo;
        public DevComponents.DotNetBar.LabelX labelMsg;
    }
}