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
            this.ucBaseControl1 = new ManageSystem.UIDesign.UCBaseControl();
            this.SuspendLayout();
            // 
            // ucBaseControl1
            // 
            this.ucBaseControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ucBaseControl1.CornerRadius = 50;
            this.ucBaseControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBaseControl1.Location = new System.Drawing.Point(10, 10);
            this.ucBaseControl1.Name = "ucBaseControl1";
            this.ucBaseControl1.Size = new System.Drawing.Size(654, 440);
            this.ucBaseControl1.TabIndex = 0;
            // 
            // FormUserDetailInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 460);
            this.Controls.Add(this.ucBaseControl1);
            this.Name = "FormUserDetailInfo";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "用户信息";
            this.ResumeLayout(false);

        }

        #endregion

        private UCBaseControl ucBaseControl1;
    }
}