namespace CtrlCVMaster.Src.Gui.Contents.Options
{
    partial class ShortcutsControl
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
            this.popUpCtrl = new DevExpress.XtraEditors.PopupContainerControl();
            this.btn_DelShortcut = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ShortCutOk = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEdit_Keys = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbl_Keys = new DevExpress.XtraEditors.LabelControl();
            this.chkBox_Alt = new DevExpress.XtraEditors.CheckEdit();
            this.chkBox_Ctrl = new DevExpress.XtraEditors.CheckEdit();
            this.lbl_ctrl = new DevExpress.XtraEditors.LabelControl();
            this.chkbox_shift = new DevExpress.XtraEditors.CheckEdit();
            this.lbl_Activate = new DevExpress.XtraEditors.LabelControl();
            this.popupContainerEdit = new DevExpress.XtraEditors.PopupContainerEdit();
            ((System.ComponentModel.ISupportInitialize)(this.popUpCtrl)).BeginInit();
            this.popUpCtrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_Keys.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBox_Alt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBox_Ctrl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkbox_shift.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // popUpCtrl
            // 
            this.popUpCtrl.Controls.Add(this.btn_DelShortcut);
            this.popUpCtrl.Controls.Add(this.btn_ShortCutOk);
            this.popUpCtrl.Controls.Add(this.comboBoxEdit_Keys);
            this.popUpCtrl.Controls.Add(this.lbl_Keys);
            this.popUpCtrl.Controls.Add(this.chkBox_Alt);
            this.popUpCtrl.Controls.Add(this.chkBox_Ctrl);
            this.popUpCtrl.Controls.Add(this.lbl_ctrl);
            this.popUpCtrl.Controls.Add(this.chkbox_shift);
            this.popUpCtrl.Location = new System.Drawing.Point(156, 55);
            this.popUpCtrl.Name = "popUpCtrl";
            this.popUpCtrl.Size = new System.Drawing.Size(200, 74);
            this.popUpCtrl.TabIndex = 8;
            // 
            // btn_DelShortcut
            // 
            this.btn_DelShortcut.Location = new System.Drawing.Point(154, 43);
            this.btn_DelShortcut.Name = "btn_DelShortcut";
            this.btn_DelShortcut.Size = new System.Drawing.Size(40, 22);
            this.btn_DelShortcut.TabIndex = 8;
            this.btn_DelShortcut.Text = "DEL";
            this.btn_DelShortcut.Click += new System.EventHandler(this.btn_DelShortcut_Click);
            // 
            // btn_ShortCutOk
            // 
            this.btn_ShortCutOk.Location = new System.Drawing.Point(109, 43);
            this.btn_ShortCutOk.Name = "btn_ShortCutOk";
            this.btn_ShortCutOk.Size = new System.Drawing.Size(40, 22);
            this.btn_ShortCutOk.TabIndex = 7;
            this.btn_ShortCutOk.Text = "OK";
            this.btn_ShortCutOk.Click += new System.EventHandler(this.btn_ShortCutOk_Click);
            // 
            // comboBoxEdit_Keys
            // 
            this.comboBoxEdit_Keys.Location = new System.Drawing.Point(35, 45);
            this.comboBoxEdit_Keys.Name = "comboBoxEdit_Keys";
            this.comboBoxEdit_Keys.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit_Keys.Properties.Items.AddRange(new object[] {
            "Q"});
            this.comboBoxEdit_Keys.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit_Keys.Size = new System.Drawing.Size(68, 20);
            this.comboBoxEdit_Keys.TabIndex = 6;
            // 
            // lbl_Keys
            // 
            this.lbl_Keys.Location = new System.Drawing.Point(5, 48);
            this.lbl_Keys.Name = "lbl_Keys";
            this.lbl_Keys.Size = new System.Drawing.Size(24, 14);
            this.lbl_Keys.TabIndex = 5;
            this.lbl_Keys.Text = "Key:";
            // 
            // chkBox_Alt
            // 
            this.chkBox_Alt.Location = new System.Drawing.Point(53, 23);
            this.chkBox_Alt.Name = "chkBox_Alt";
            this.chkBox_Alt.Properties.Caption = "Alt";
            this.chkBox_Alt.Size = new System.Drawing.Size(39, 19);
            this.chkBox_Alt.TabIndex = 3;
            // 
            // chkBox_Ctrl
            // 
            this.chkBox_Ctrl.Location = new System.Drawing.Point(3, 23);
            this.chkBox_Ctrl.Name = "chkBox_Ctrl";
            this.chkBox_Ctrl.Properties.Caption = "Ctrl";
            this.chkBox_Ctrl.Size = new System.Drawing.Size(44, 19);
            this.chkBox_Ctrl.TabIndex = 2;
            // 
            // lbl_ctrl
            // 
            this.lbl_ctrl.Location = new System.Drawing.Point(3, 3);
            this.lbl_ctrl.Name = "lbl_ctrl";
            this.lbl_ctrl.Size = new System.Drawing.Size(125, 14);
            this.lbl_ctrl.TabIndex = 1;
            this.lbl_ctrl.Text = "Setting Shortcut Keys:";
            // 
            // chkbox_shift
            // 
            this.chkbox_shift.Enabled = false;
            this.chkbox_shift.Location = new System.Drawing.Point(98, 23);
            this.chkbox_shift.Name = "chkbox_shift";
            this.chkbox_shift.Properties.Caption = "Shift";
            this.chkbox_shift.Size = new System.Drawing.Size(51, 19);
            this.chkbox_shift.TabIndex = 0;
            // 
            // lbl_Activate
            // 
            this.lbl_Activate.Location = new System.Drawing.Point(28, 32);
            this.lbl_Activate.Name = "lbl_Activate";
            this.lbl_Activate.Size = new System.Drawing.Size(122, 14);
            this.lbl_Activate.TabIndex = 9;
            this.lbl_Activate.Text = "Activate CtrlCVMaster:";
            // 
            // popupContainerEdit
            // 
            this.popupContainerEdit.Location = new System.Drawing.Point(156, 29);
            this.popupContainerEdit.Name = "popupContainerEdit";
            this.popupContainerEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.popupContainerEdit.Properties.PopupControl = this.popUpCtrl;
            this.popupContainerEdit.Size = new System.Drawing.Size(100, 20);
            this.popupContainerEdit.TabIndex = 10;
            this.popupContainerEdit.Popup += new System.EventHandler(this.popupContainerEdit_Popup);
            // 
            // ShortcutsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.popupContainerEdit);
            this.Controls.Add(this.lbl_Activate);
            this.Controls.Add(this.popUpCtrl);
            this.Name = "ShortcutsControl";
            this.Size = new System.Drawing.Size(438, 312);
            ((System.ComponentModel.ISupportInitialize)(this.popUpCtrl)).EndInit();
            this.popUpCtrl.ResumeLayout(false);
            this.popUpCtrl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_Keys.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBox_Alt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBox_Ctrl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkbox_shift.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PopupContainerControl popUpCtrl;
        private DevExpress.XtraEditors.SimpleButton btn_DelShortcut;
        private DevExpress.XtraEditors.SimpleButton btn_ShortCutOk;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit_Keys;
        private DevExpress.XtraEditors.LabelControl lbl_Keys;
        private DevExpress.XtraEditors.CheckEdit chkBox_Alt;
        private DevExpress.XtraEditors.CheckEdit chkBox_Ctrl;
        private DevExpress.XtraEditors.LabelControl lbl_ctrl;
        private DevExpress.XtraEditors.CheckEdit chkbox_shift;
        private DevExpress.XtraEditors.LabelControl lbl_Activate;
        private DevExpress.XtraEditors.PopupContainerEdit popupContainerEdit;
    }
}
