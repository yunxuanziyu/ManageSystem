namespace ManageSystem.UIDesign
{
    partial class UCSaveSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSaveSetting));
            this.buttonXLogout = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // buttonXLogout
            // 
            this.buttonXLogout.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.buttonXLogout, "buttonXLogout");
            this.buttonXLogout.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonXLogout.Name = "buttonXLogout";
            this.buttonXLogout.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(15);
            this.buttonXLogout.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.buttonXLogout.Click += new System.EventHandler(this.buttonXLogout_Click);
            // 
            // UCSaveSetting
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonXLogout);
            this.Name = "UCSaveSetting";
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX buttonXLogout;
    }
}
