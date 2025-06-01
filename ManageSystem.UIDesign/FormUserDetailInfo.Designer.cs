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
            this.pictureBoxX1 = new ManageSystem.ControlX.PictureBoxX();
            this.textBoxEx1 = new ManageSystem.ControlX.TextBoxEx();
            this.columnHeader1 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader2 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader3 = new DevComponents.AdvTree.ColumnHeader();
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
            this.labelX1.Size = new System.Drawing.Size(37, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "姓名";
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
            this.textBoxEx1.BindField = null;
            // 
            // 
            // 
            this.textBoxEx1.Border.Class = "TextBoxBorder";
            this.textBoxEx1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxEx1.Location = new System.Drawing.Point(74, 34);
            this.textBoxEx1.Name = "textBoxEx1";
            this.textBoxEx1.PreventEnterBeep = true;
            this.textBoxEx1.Size = new System.Drawing.Size(100, 21);
            this.textBoxEx1.TabIndex = 4;
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
            // FormUserDetailInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 460);
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
    }
}