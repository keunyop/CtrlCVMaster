namespace CtrlCVMaster.Gui.Contents
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
            this.lbl_Max = new DevExpress.XtraEditors.LabelControl();
            this.cmb_Max = new DevExpress.XtraEditors.ComboBoxEdit();
            this.chk_Startup = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Max.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_Startup.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Max
            // 
            this.lbl_Max.Location = new System.Drawing.Point(28, 32);
            this.lbl_Max.Name = "lbl_Max";
            this.lbl_Max.Size = new System.Drawing.Size(200, 14);
            this.lbl_Max.TabIndex = 0;
            this.lbl_Max.Text = "Max. # of Shortcut Keys can be set:";
            // 
            // cmb_Max
            // 
            this.cmb_Max.EditValue = "10";
            this.cmb_Max.Location = new System.Drawing.Point(236, 29);
            this.cmb_Max.Name = "cmb_Max";
            this.cmb_Max.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Max.Properties.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.cmb_Max.Properties.ReadOnly = true;
            this.cmb_Max.Size = new System.Drawing.Size(71, 20);
            this.cmb_Max.TabIndex = 1;
            // 
            // chk_Startup
            // 
            this.chk_Startup.Location = new System.Drawing.Point(26, 79);
            this.chk_Startup.Name = "chk_Startup";
            this.chk_Startup.Properties.Caption = "Start CtrlCVMaster on System Startup";
            this.chk_Startup.Size = new System.Drawing.Size(236, 19);
            this.chk_Startup.TabIndex = 3;
            // 
            // GeneralSettingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chk_Startup);
            this.Controls.Add(this.cmb_Max);
            this.Controls.Add(this.lbl_Max);
            this.Name = "GeneralSettingControl";
            this.Size = new System.Drawing.Size(397, 333);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Max.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_Startup.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbl_Max;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_Max;
        public DevExpress.XtraEditors.CheckEdit chk_Startup;
    }
}
