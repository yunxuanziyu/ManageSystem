namespace ManageSystem.UIDesign
{
    partial class MessageYesNoCancle
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
            this.buttonCancle = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // buttonCancle
            // 
            this.buttonCancle.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonCancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancle.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonCancle.Location = new System.Drawing.Point(183, 109);
            this.buttonCancle.Name = "buttonCancle";
            this.buttonCancle.Size = new System.Drawing.Size(53, 23);
            this.buttonCancle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonCancle.TabIndex = 7;
            this.buttonCancle.Text = "取消";
            this.buttonCancle.Click += new System.EventHandler(this.buttonCancle_Click);
            // 
            // MessageYesNoCancle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 161);
            this.Controls.Add(this.buttonCancle);
            this.DoubleBuffered = true;
            this.Name = "MessageYesNoCancle";
            this.Text = "MessageYesNoCancle";
            this.Controls.SetChildIndex(this.buttonCancle, 0);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX buttonCancle;
    }
}