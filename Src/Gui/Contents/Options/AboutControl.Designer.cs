namespace CtrlCVMaster.Gui.Contents.Options
{
    partial class AboutControl
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
            this.pnlTop = new DevExpress.XtraEditors.PanelControl();
            this.lbl_SystemInfo = new DevExpress.XtraEditors.LabelControl();
            this.lbl_About = new DevExpress.XtraEditors.LabelControl();
            this.panelBottom = new DevExpress.XtraEditors.PanelControl();
            this.hyperLinkEdit = new DevExpress.XtraEditors.HyperLinkEdit();
            this.memoEdit = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelBottom)).BeginInit();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lbl_SystemInfo);
            this.pnlTop.Controls.Add(this.lbl_About);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(460, 62);
            this.pnlTop.TabIndex = 0;
            // 
            // lbl_SystemInfo
            // 
            this.lbl_SystemInfo.Location = new System.Drawing.Point(5, 37);
            this.lbl_SystemInfo.Name = "lbl_SystemInfo";
            this.lbl_SystemInfo.Size = new System.Drawing.Size(111, 14);
            this.lbl_SystemInfo.TabIndex = 3;
            this.lbl_SystemInfo.Text = "System Information:";
            // 
            // lbl_About
            // 
            this.lbl_About.Location = new System.Drawing.Point(5, 5);
            this.lbl_About.Name = "lbl_About";
            this.lbl_About.Size = new System.Drawing.Size(270, 14);
            this.lbl_About.TabIndex = 2;
            this.lbl_About.Text = "CtrlCVMaster Product Information (Version: 1.05)";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.hyperLinkEdit);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 311);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(460, 59);
            this.panelBottom.TabIndex = 1;
            // 
            // hyperLinkEdit
            // 
            this.hyperLinkEdit.EditValue = "For more information on this program...";
            this.hyperLinkEdit.Location = new System.Drawing.Point(5, 6);
            this.hyperLinkEdit.Name = "hyperLinkEdit";
            this.hyperLinkEdit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.hyperLinkEdit.Properties.Appearance.Options.UseBackColor = true;
            this.hyperLinkEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.hyperLinkEdit.Size = new System.Drawing.Size(228, 18);
            this.hyperLinkEdit.TabIndex = 4;
            this.hyperLinkEdit.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.hyperLinkEdit_OpenLink);
            // 
            // memoEdit
            // 
            this.memoEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEdit.Location = new System.Drawing.Point(0, 62);
            this.memoEdit.Name = "memoEdit";
            this.memoEdit.Size = new System.Drawing.Size(460, 249);
            this.memoEdit.TabIndex = 2;
            // 
            // AboutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.memoEdit);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.pnlTop);
            this.Name = "AboutControl";
            this.Size = new System.Drawing.Size(460, 370);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelBottom)).EndInit();
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlTop;
        private DevExpress.XtraEditors.PanelControl panelBottom;
        private DevExpress.XtraEditors.MemoEdit memoEdit;
        private DevExpress.XtraEditors.LabelControl lbl_About;
        private DevExpress.XtraEditors.LabelControl lbl_SystemInfo;
        private DevExpress.XtraEditors.HyperLinkEdit hyperLinkEdit;

    }
}
