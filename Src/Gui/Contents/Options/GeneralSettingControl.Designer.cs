namespace CtrlCVMaster.Gui.Contents.Options
{
    partial class GeneralSettingControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.chk_Startup = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_Startup.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chk_Startup
            // 
            this.chk_Startup.Location = new System.Drawing.Point(26, 32);
            this.chk_Startup.Name = "chk_Startup";
            this.chk_Startup.Properties.Caption = "Start CtrlCVMaster on System Startup";
            this.chk_Startup.Size = new System.Drawing.Size(236, 19);
            this.chk_Startup.TabIndex = 3;
            this.chk_Startup.CheckStateChanged += new System.EventHandler(this.chk_Startup_CheckStateChanged);
            // 
            // GeneralSettingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chk_Startup);
            this.Name = "GeneralSettingControl";
            this.Size = new System.Drawing.Size(397, 333);
            ((System.ComponentModel.ISupportInitialize)(this.chk_Startup.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit chk_Startup;
    }
}
