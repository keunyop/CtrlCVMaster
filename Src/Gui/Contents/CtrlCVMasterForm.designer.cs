namespace CtrlCVMaster.Gui.Contents
{
    partial class CtrlCVMasterForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlCVMasterForm));
            this.grdCtrl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip_MoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_MoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.grdView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_ShortKey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repPopUp = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.popUpCtrl = new DevExpress.XtraEditors.PopupContainerControl();
            this.btn_DelShortcut = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ShortCutOk = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEdit_Keys = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbl_Keys = new DevExpress.XtraEditors.LabelControl();
            this.chkBox_Alt = new DevExpress.XtraEditors.CheckEdit();
            this.chkBox_Ctrl = new DevExpress.XtraEditors.CheckEdit();
            this.lbl_ctrl = new DevExpress.XtraEditors.LabelControl();
            this.chkbox_shift = new DevExpress.XtraEditors.CheckEdit();
            this.col_Contents = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repPopUp_Image = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.globalEventProvider = new Gma.UserActivityMonitor.GlobalEventProvider();
            this.pnlTop = new DevExpress.XtraEditors.PanelControl();
            this.btnMoveUp = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoveDown = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAbout = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
            this.lbl_ItemCount = new DevExpress.XtraEditors.LabelControl();
            this.lbl_BottomInfo = new DevExpress.XtraEditors.LabelControl();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip_tray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trayMenu_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenu_OpenDisabled = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.trayMenu_ShowList = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenu_DelList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.trayMenu_Enable = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenu_Disable = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.trayMenu_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenu_Text = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPopUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popUpCtrl)).BeginInit();
            this.popUpCtrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_Keys.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBox_Alt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBox_Ctrl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkbox_shift.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPopUp_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.contextMenuStrip_tray.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdCtrl
            // 
            this.grdCtrl.ContextMenuStrip = this.contextMenuStrip;
            this.grdCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCtrl.Location = new System.Drawing.Point(0, 32);
            this.grdCtrl.LookAndFeel.SkinName = "Office 2010 Blue";
            this.grdCtrl.MainView = this.grdView;
            this.grdCtrl.Name = "grdCtrl";
            this.grdCtrl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repPopUp,
            this.repPopUp_Image});
            this.grdCtrl.Size = new System.Drawing.Size(355, 234);
            this.grdCtrl.TabIndex = 4;
            this.grdCtrl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuStrip_Add,
            this.contextMenuStrip_Delete,
            this.toolStripSeparator1,
            this.contextMenuStrip_MoveUp,
            this.contextMenuStrip_MoveDown});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(207, 98);
            // 
            // contextMenuStrip_Add
            // 
            this.contextMenuStrip_Add.Image = ((System.Drawing.Image)(resources.GetObject("contextMenuStrip_Add.Image")));
            this.contextMenuStrip_Add.Name = "contextMenuStrip_Add";
            this.contextMenuStrip_Add.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.contextMenuStrip_Add.Size = new System.Drawing.Size(206, 22);
            this.contextMenuStrip_Add.Text = "Add";
            this.contextMenuStrip_Add.Click += new System.EventHandler(this.contextMenuStrip_Add_Click);
            // 
            // contextMenuStrip_Delete
            // 
            this.contextMenuStrip_Delete.Image = ((System.Drawing.Image)(resources.GetObject("contextMenuStrip_Delete.Image")));
            this.contextMenuStrip_Delete.Name = "contextMenuStrip_Delete";
            this.contextMenuStrip_Delete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.contextMenuStrip_Delete.Size = new System.Drawing.Size(206, 22);
            this.contextMenuStrip_Delete.Text = "Delete";
            this.contextMenuStrip_Delete.Click += new System.EventHandler(this.contextMenuStrip_Delete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            // 
            // contextMenuStrip_MoveUp
            // 
            this.contextMenuStrip_MoveUp.Image = ((System.Drawing.Image)(resources.GetObject("contextMenuStrip_MoveUp.Image")));
            this.contextMenuStrip_MoveUp.Name = "contextMenuStrip_MoveUp";
            this.contextMenuStrip_MoveUp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.contextMenuStrip_MoveUp.Size = new System.Drawing.Size(206, 22);
            this.contextMenuStrip_MoveUp.Text = "Move Up";
            this.contextMenuStrip_MoveUp.Click += new System.EventHandler(this.contextMenuStrip_MoveUp_Click);
            // 
            // contextMenuStrip_MoveDown
            // 
            this.contextMenuStrip_MoveDown.Image = ((System.Drawing.Image)(resources.GetObject("contextMenuStrip_MoveDown.Image")));
            this.contextMenuStrip_MoveDown.Name = "contextMenuStrip_MoveDown";
            this.contextMenuStrip_MoveDown.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.contextMenuStrip_MoveDown.Size = new System.Drawing.Size(206, 22);
            this.contextMenuStrip_MoveDown.Text = "Move Down";
            this.contextMenuStrip_MoveDown.Click += new System.EventHandler(this.contextMenuStrip_MoveDown_Click);
            // 
            // grdView
            // 
            this.grdView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_ShortKey,
            this.col_Contents});
            this.grdView.GridControl = this.grdCtrl;
            this.grdView.Name = "grdView";
            this.grdView.OptionsView.ShowGroupPanel = false;
            this.grdView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdView_FocusedRowChanged);
            this.grdView.DoubleClick += new System.EventHandler(this.grdView_DoubleClick);
            // 
            // col_ShortKey
            // 
            this.col_ShortKey.AppearanceHeader.Options.UseTextOptions = true;
            this.col_ShortKey.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_ShortKey.Caption = "Shortcuts";
            this.col_ShortKey.ColumnEdit = this.repPopUp;
            this.col_ShortKey.FieldName = "SHORTKEY";
            this.col_ShortKey.Name = "col_ShortKey";
            this.col_ShortKey.Visible = true;
            this.col_ShortKey.VisibleIndex = 0;
            this.col_ShortKey.Width = 79;
            // 
            // repPopUp
            // 
            this.repPopUp.AutoHeight = false;
            this.repPopUp.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repPopUp.Name = "repPopUp";
            this.repPopUp.PopupControl = this.popUpCtrl;
            this.repPopUp.PopupFormSize = new System.Drawing.Size(159, 90);
            this.repPopUp.PopupSizeable = false;
            this.repPopUp.Popup += new System.EventHandler(this.repPopUp_Popup);
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
            this.popUpCtrl.Location = new System.Drawing.Point(12, 120);
            this.popUpCtrl.Name = "popUpCtrl";
            this.popUpCtrl.Size = new System.Drawing.Size(200, 74);
            this.popUpCtrl.TabIndex = 7;
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
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0"});
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
            this.chkBox_Alt.CheckedChanged += new System.EventHandler(this.chkBox_Alt_CheckedChanged);
            // 
            // chkBox_Ctrl
            // 
            this.chkBox_Ctrl.Location = new System.Drawing.Point(3, 23);
            this.chkBox_Ctrl.Name = "chkBox_Ctrl";
            this.chkBox_Ctrl.Properties.Caption = "Ctrl";
            this.chkBox_Ctrl.Size = new System.Drawing.Size(44, 19);
            this.chkBox_Ctrl.TabIndex = 2;
            this.chkBox_Ctrl.CheckedChanged += new System.EventHandler(this.chkBox_Ctrl_CheckedChanged);
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
            // col_Contents
            // 
            this.col_Contents.AppearanceHeader.Options.UseTextOptions = true;
            this.col_Contents.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_Contents.Caption = "Contents";
            this.col_Contents.FieldName = "CONTENTS";
            this.col_Contents.Name = "col_Contents";
            this.col_Contents.OptionsColumn.AllowEdit = false;
            this.col_Contents.Visible = true;
            this.col_Contents.VisibleIndex = 1;
            this.col_Contents.Width = 242;
            // 
            // repPopUp_Image
            // 
            this.repPopUp_Image.AutoHeight = false;
            this.repPopUp_Image.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repPopUp_Image.Name = "repPopUp_Image";
            // 
            // globalEventProvider
            // 
            this.globalEventProvider.KeyDown += new System.Windows.Forms.KeyEventHandler(this.globalEventProvider_KeyDown);
            this.globalEventProvider.KeyUp += new System.Windows.Forms.KeyEventHandler(this.globalEventProvider_KeyUp);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnMoveUp);
            this.pnlTop.Controls.Add(this.btnMoveDown);
            this.pnlTop.Controls.Add(this.btnAdd);
            this.pnlTop.Controls.Add(this.btnDelete);
            this.pnlTop.Controls.Add(this.btnAbout);
            this.pnlTop.Controls.Add(this.btnLoad);
            this.pnlTop.Controls.Add(this.btnSave);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(355, 32);
            this.pnlTop.TabIndex = 5;
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveUp.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnMoveUp.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveUp.Image")));
            this.btnMoveUp.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnMoveUp.Location = new System.Drawing.Point(176, 5);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(30, 23);
            this.btnMoveUp.TabIndex = 6;
            this.btnMoveUp.ToolTip = "Move Up (Ctrl+Up)";
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveDown.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnMoveDown.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveDown.Image")));
            this.btnMoveDown.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnMoveDown.Location = new System.Drawing.Point(212, 5);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(30, 23);
            this.btnMoveDown.TabIndex = 5;
            this.btnMoveDown.ToolTip = "Move Down (Ctrl+Down)";
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAdd.Location = new System.Drawing.Point(248, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.ToolTip = "Add (Ctrl+N)";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnDelete.Location = new System.Drawing.Point(284, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.ToolTip = "Delete (Ctrl+D)";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAbout.Location = new System.Drawing.Point(320, 5);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(30, 23);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.ToolTip = "Setting";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLoad.Location = new System.Drawing.Point(49, 5);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(30, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.ToolTip = "Open (Ctrl+O)";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSave.Location = new System.Drawing.Point(12, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(30, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.ToolTip = "Save (Ctrl+S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.lbl_ItemCount);
            this.pnlBottom.Controls.Add(this.lbl_BottomInfo);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 266);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(355, 32);
            this.pnlBottom.TabIndex = 6;
            // 
            // lbl_ItemCount
            // 
            this.lbl_ItemCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ItemCount.Location = new System.Drawing.Point(295, 9);
            this.lbl_ItemCount.Name = "lbl_ItemCount";
            this.lbl_ItemCount.Size = new System.Drawing.Size(48, 14);
            this.lbl_ItemCount.TabIndex = 1;
            this.lbl_ItemCount.Text = "Count: 0";
            // 
            // lbl_BottomInfo
            // 
            this.lbl_BottomInfo.Location = new System.Drawing.Point(5, 9);
            this.lbl_BottomInfo.Name = "lbl_BottomInfo";
            this.lbl_BottomInfo.Size = new System.Drawing.Size(207, 14);
            this.lbl_BottomInfo.TabIndex = 0;
            this.lbl_BottomInfo.Text = "Collected Time: 2013-01-30 23:14:23";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "CtrlCVMaster";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // contextMenuStrip_tray
            // 
            this.contextMenuStrip_tray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayMenu_Open,
            this.trayMenu_OpenDisabled,
            this.toolStripSeparator3,
            this.trayMenu_ShowList,
            this.trayMenu_DelList,
            this.toolStripSeparator5,
            this.trayMenu_Enable,
            this.trayMenu_Disable,
            this.toolStripSeparator4,
            this.trayMenu_Close,
            this.trayMenu_Text});
            this.contextMenuStrip_tray.Name = "contextMenuStrip";
            this.contextMenuStrip_tray.Size = new System.Drawing.Size(191, 198);
            // 
            // trayMenu_Open
            // 
            this.trayMenu_Open.Image = ((System.Drawing.Image)(resources.GetObject("trayMenu_Open.Image")));
            this.trayMenu_Open.Name = "trayMenu_Open";
            this.trayMenu_Open.ShortcutKeyDisplayString = "";
            this.trayMenu_Open.Size = new System.Drawing.Size(190, 22);
            this.trayMenu_Open.Text = "Open (&O)";
            this.trayMenu_Open.Click += new System.EventHandler(this.trayMenu_Open_Click);
            // 
            // trayMenu_OpenDisabled
            // 
            this.trayMenu_OpenDisabled.Image = ((System.Drawing.Image)(resources.GetObject("trayMenu_OpenDisabled.Image")));
            this.trayMenu_OpenDisabled.Name = "trayMenu_OpenDisabled";
            this.trayMenu_OpenDisabled.Size = new System.Drawing.Size(190, 22);
            this.trayMenu_OpenDisabled.Text = "Open (&O)";
            this.trayMenu_OpenDisabled.Visible = false;
            this.trayMenu_OpenDisabled.Click += new System.EventHandler(this.trayMenu_OpenDisabled_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(187, 6);
            // 
            // trayMenu_ShowList
            // 
            this.trayMenu_ShowList.Image = ((System.Drawing.Image)(resources.GetObject("trayMenu_ShowList.Image")));
            this.trayMenu_ShowList.Name = "trayMenu_ShowList";
            this.trayMenu_ShowList.Size = new System.Drawing.Size(190, 22);
            this.trayMenu_ShowList.Text = "Show List";
            this.trayMenu_ShowList.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.trayMenu_ShowList_DropDownItemClicked);
            this.trayMenu_ShowList.DropDownOpening += new System.EventHandler(this.trayMenu_ShowList_DropDownOpening);
            // 
            // trayMenu_DelList
            // 
            this.trayMenu_DelList.Image = ((System.Drawing.Image)(resources.GetObject("trayMenu_DelList.Image")));
            this.trayMenu_DelList.Name = "trayMenu_DelList";
            this.trayMenu_DelList.Size = new System.Drawing.Size(190, 22);
            this.trayMenu_DelList.Text = "Delete List";
            this.trayMenu_DelList.Click += new System.EventHandler(this.trayMenu_DelList_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(187, 6);
            // 
            // trayMenu_Enable
            // 
            this.trayMenu_Enable.Image = ((System.Drawing.Image)(resources.GetObject("trayMenu_Enable.Image")));
            this.trayMenu_Enable.Name = "trayMenu_Enable";
            this.trayMenu_Enable.Size = new System.Drawing.Size(190, 22);
            this.trayMenu_Enable.Text = "Enable Clipboard (&E)";
            this.trayMenu_Enable.Visible = false;
            this.trayMenu_Enable.Click += new System.EventHandler(this.trayMenu_Enable_Click);
            // 
            // trayMenu_Disable
            // 
            this.trayMenu_Disable.Image = ((System.Drawing.Image)(resources.GetObject("trayMenu_Disable.Image")));
            this.trayMenu_Disable.Name = "trayMenu_Disable";
            this.trayMenu_Disable.Size = new System.Drawing.Size(190, 22);
            this.trayMenu_Disable.Text = "Disable Clipboard (&D)";
            this.trayMenu_Disable.Click += new System.EventHandler(this.trayMenu_Disable_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(187, 6);
            // 
            // trayMenu_Close
            // 
            this.trayMenu_Close.Name = "trayMenu_Close";
            this.trayMenu_Close.Size = new System.Drawing.Size(190, 22);
            this.trayMenu_Close.Text = "Exit (&X)";
            this.trayMenu_Close.Click += new System.EventHandler(this.trayMenu_Close_Click);
            // 
            // trayMenu_Text
            // 
            this.trayMenu_Text.Image = ((System.Drawing.Image)(resources.GetObject("trayMenu_Text.Image")));
            this.trayMenu_Text.Name = "trayMenu_Text";
            this.trayMenu_Text.Size = new System.Drawing.Size(190, 22);
            this.trayMenu_Text.Text = "trayMenu_Text";
            this.trayMenu_Text.Visible = false;
            // 
            // CtrlCVMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 298);
            this.Controls.Add(this.popUpCtrl);
            this.Controls.Add(this.grdCtrl);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CtrlCVMasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ctrl+CV Master";
            this.Load += new System.EventHandler(this.CtrlCVMasterForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CtrlCVMasterForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPopUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popUpCtrl)).EndInit();
            this.popUpCtrl.ResumeLayout(false);
            this.popUpCtrl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_Keys.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBox_Alt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBox_Ctrl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkbox_shift.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPopUp_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).EndInit();
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.contextMenuStrip_tray.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdCtrl;
        private DevExpress.XtraGrid.Views.Grid.GridView grdView;
        private DevExpress.XtraGrid.Columns.GridColumn col_ShortKey;
        private DevExpress.XtraGrid.Columns.GridColumn col_Contents;
        private Gma.UserActivityMonitor.GlobalEventProvider globalEventProvider;
        private DevExpress.XtraEditors.PanelControl pnlTop;
        private DevExpress.XtraEditors.PanelControl pnlBottom;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAbout;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraEditors.SimpleButton btnMoveUp;
        private DevExpress.XtraEditors.SimpleButton btnMoveDown;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.LabelControl lbl_BottomInfo;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_tray;
        private System.Windows.Forms.ToolStripMenuItem trayMenu_Close;
        private System.Windows.Forms.ToolStripMenuItem trayMenu_Open;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem contextMenuStrip_Add;
        private System.Windows.Forms.ToolStripMenuItem contextMenuStrip_Delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem contextMenuStrip_MoveUp;
        private System.Windows.Forms.ToolStripMenuItem contextMenuStrip_MoveDown;
        private System.Windows.Forms.ToolStripMenuItem trayMenu_ShowList;
        private System.Windows.Forms.ToolStripMenuItem trayMenu_DelList;
        private DevExpress.XtraEditors.LabelControl lbl_ItemCount;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit repPopUp;
        private DevExpress.XtraEditors.PopupContainerControl popUpCtrl;
        private DevExpress.XtraEditors.CheckEdit chkbox_shift;
        private DevExpress.XtraEditors.LabelControl lbl_ctrl;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit_Keys;
        private DevExpress.XtraEditors.LabelControl lbl_Keys;
        private DevExpress.XtraEditors.CheckEdit chkBox_Alt;
        private DevExpress.XtraEditors.CheckEdit chkBox_Ctrl;
        private System.ComponentModel.ComponentResourceManager resources;
        private DevExpress.XtraEditors.SimpleButton btn_ShortCutOk;
        private System.Windows.Forms.ToolStripMenuItem trayMenu_Text;
        private DevExpress.XtraEditors.SimpleButton btn_DelShortcut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem trayMenu_Enable;
        private System.Windows.Forms.ToolStripMenuItem trayMenu_Disable;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repPopUp_Image;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem trayMenu_OpenDisabled;
    }
}