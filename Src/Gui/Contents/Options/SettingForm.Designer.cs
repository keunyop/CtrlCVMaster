namespace CtrlCVMaster.Gui.Contents.Options
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancle = new DevExpress.XtraEditors.SimpleButton();
            this.pnlLeft = new DevExpress.XtraEditors.PanelControl();
            this.gridCtrl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSetting = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnlTop = new DevExpress.XtraEditors.PanelControl();
            this.lbl_SettingDetail = new DevExpress.XtraEditors.LabelControl();
            this.lbl_SettingList = new DevExpress.XtraEditors.LabelControl();
            this.aboutControl = new CtrlCVMaster.Gui.Contents.Options.AboutControl();
            this.generalSettingControl = new CtrlCVMaster.Gui.Contents.Options.GeneralSettingControl();
            this.pnlRight = new DevExpress.XtraEditors.PanelControl();
            this.shortcutsControl = new CtrlCVMaster.Src.Gui.Contents.Options.ShortcutsControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).BeginInit();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnOK);
            this.pnlBottom.Controls.Add(this.btnCancle);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 376);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(635, 35);
            this.pnlBottom.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(467, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK (&O)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Location = new System.Drawing.Point(548, 5);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 0;
            this.btnCancle.Text = "Cancel (&C)";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.gridCtrl);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 20);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(179, 356);
            this.pnlLeft.TabIndex = 1;
            // 
            // gridCtrl
            // 
            this.gridCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrl.Location = new System.Drawing.Point(2, 2);
            this.gridCtrl.MainView = this.gridView;
            this.gridCtrl.Name = "gridCtrl";
            this.gridCtrl.Size = new System.Drawing.Size(175, 352);
            this.gridCtrl.TabIndex = 0;
            this.gridCtrl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView,
            this.gridView2});
            // 
            // gridView
            // 
            this.gridView.Appearance.FocusedCell.BackColor = System.Drawing.Color.DarkGray;
            this.gridView.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gridView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSetting});
            this.gridView.GridControl = this.gridCtrl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsView.ShowColumnHeaders = false;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.OptionsView.ShowIndicator = false;
            this.gridView.RowHeight = 30;
            this.gridView.RowSeparatorHeight = 5;
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // colSetting
            // 
            this.colSetting.Caption = "gridColumn1";
            this.colSetting.FieldName = "SETTINGNAME";
            this.colSetting.Name = "colSetting";
            this.colSetting.Visible = true;
            this.colSetting.VisibleIndex = 0;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridCtrl;
            this.gridView2.Name = "gridView2";
            // 
            // pnlTop
            // 
            this.pnlTop.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTop.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTop.Appearance.ForeColor = System.Drawing.Color.Black;
            this.pnlTop.Appearance.Options.UseBackColor = true;
            this.pnlTop.Appearance.Options.UseFont = true;
            this.pnlTop.Appearance.Options.UseForeColor = true;
            this.pnlTop.Controls.Add(this.lbl_SettingDetail);
            this.pnlTop.Controls.Add(this.lbl_SettingList);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(635, 20);
            this.pnlTop.TabIndex = 2;
            // 
            // lbl_SettingDetail
            // 
            this.lbl_SettingDetail.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_SettingDetail.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_SettingDetail.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_SettingDetail.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_SettingDetail.Location = new System.Drawing.Point(176, 0);
            this.lbl_SettingDetail.Name = "lbl_SettingDetail";
            this.lbl_SettingDetail.Size = new System.Drawing.Size(459, 20);
            this.lbl_SettingDetail.TabIndex = 1;
            this.lbl_SettingDetail.Text = "  General";
            // 
            // lbl_SettingList
            // 
            this.lbl_SettingList.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_SettingList.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_SettingList.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_SettingList.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_SettingList.Location = new System.Drawing.Point(0, 0);
            this.lbl_SettingList.Name = "lbl_SettingList";
            this.lbl_SettingList.Size = new System.Drawing.Size(177, 20);
            this.lbl_SettingList.TabIndex = 0;
            this.lbl_SettingList.Text = " Item";
            // 
            // aboutControl
            // 
            this.aboutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutControl.Location = new System.Drawing.Point(13, 6);
            this.aboutControl.Name = "aboutControl";
            this.aboutControl.Size = new System.Drawing.Size(350, 199);
            this.aboutControl.TabIndex = 4;
            // 
            // generalSettingControl
            // 
            this.generalSettingControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalSettingControl.Location = new System.Drawing.Point(2, 2);
            this.generalSettingControl.Name = "generalSettingControl";
            this.generalSettingControl.Size = new System.Drawing.Size(452, 352);
            this.generalSettingControl.TabIndex = 6;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.shortcutsControl);
            this.pnlRight.Controls.Add(this.generalSettingControl);
            this.pnlRight.Controls.Add(this.aboutControl);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(179, 20);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(456, 356);
            this.pnlRight.TabIndex = 7;
            // 
            // shortcutsControl
            // 
            this.shortcutsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shortcutsControl.Location = new System.Drawing.Point(2, 2);
            this.shortcutsControl.Name = "shortcutsControl";
            this.shortcutsControl.Size = new System.Drawing.Size(452, 352);
            this.shortcutsControl.TabIndex = 7;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancle;
            this.ClientSize = new System.Drawing.Size(635, 411);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ctrl+CV Master - Setting";
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).EndInit();
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlBottom;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancle;
        private DevExpress.XtraEditors.PanelControl pnlLeft;
        private DevExpress.XtraGrid.GridControl gridCtrl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colSetting;
        private DevExpress.XtraEditors.PanelControl pnlTop;
        private DevExpress.XtraEditors.LabelControl lbl_SettingDetail;
        private DevExpress.XtraEditors.LabelControl lbl_SettingList;
        private AboutControl aboutControl;
        private GeneralSettingControl generalSettingControl;
        private DevExpress.XtraEditors.PanelControl pnlRight;
        private CtrlCVMaster.Src.Gui.Contents.Options.ShortcutsControl shortcutsControl;
    }
}