using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CtrlCVMaster.Gui.Contents.Data;
using System.Collections;
using System.Runtime.InteropServices;
using System.IO;
using DevExpress.XtraEditors;
using System.Xml;
using CtrlCVMaster.Gui.Contents.Options;
using CtrlCVMaster.Properties;

namespace CtrlCVMaster.Gui.Contents
{
    public partial class CtrlCVMasterForm : Form
    {
        private bool IsCtrlPressed = false;
        private ComponentResourceManager imgResource = new ComponentResourceManager(typeof(CtrlCVMasterForm));
        private HotKeyInfoList hotKeyInfoList = new HotKeyInfoList();

        public CtrlCVMasterForm()
        {
            InitializeComponent();
            this.SetData();

            // Setting the default CtrlCVMaster Activate shortcut key
            this.ActivateShortcutKey(Keys.Q, false, false, true, false);
        }

        #region Utilities
        private ClipboardInfoList GetClipboardInfoList
        {
            get { return this.grdCtrl.DataSource as ClipboardInfoList; }
        }

        private ClipboardInfo GetClipboardInfoByRowHandle(int rowHandle)
        {
            return this.grdView.GetRow(rowHandle) as ClipboardInfo;
        }

        #region DEBUG
        /// <summary>
        /// Debug Console 창에 밝은 빨간색 font
        /// </summary>
        private ConsoleLib.ConsoleLib.ConsoleAttributes t
        {
            get { return ConsoleLib.ConsoleLib.ConsoleAttributes.ForegroundRed | ConsoleLib.ConsoleLib.ConsoleAttributes.ForegroundIntensity; }
        }
        #endregion
        #endregion

        #region Data Process
        private void SetData()
        {
            ClipboardInfoList clipboardInfoList = new ClipboardInfoList();
            this.grdCtrl.DataSource = clipboardInfoList;
        }

        public int AddData()
        {
            try
            {
                ClipboardInfoList clipboardInfoList = this.GetClipboardInfoList;

                // 리스트에 이미 포함되어 있을때 다시 추가하지 않음
                foreach (ClipboardInfo info in clipboardInfoList)
                {
                    if (info.CONTENTS == Clipboard.GetText())
                        return clipboardInfoList.Count;
                }

                ClipboardInfo clipboardInfo = new ClipboardInfo();
                if (Clipboard.ContainsText()) // if the copied object is a text
                {
                    clipboardInfo.CONTENTS = Clipboard.GetText();
                    clipboardInfo.CONTENTSTYPE = ContentsType.Text;
                }
                else if (Clipboard.ContainsImage()) // if the copied object is an image
                {
                    clipboardInfo.CONTENTS = " ** Copying an image is not supported. **";
                    clipboardInfo.CONTENTSTYPE = ContentsType.Image;
                }
                
                clipboardInfo.COPIEDTIME = (DateTime.Now).ToString();
                clipboardInfoList.Insert(0, clipboardInfo);

                // Focusing
                this.grdView.FocusedRowHandle = 0;

                return clipboardInfoList.Count;
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
                return 0;
            }
        }
        #endregion

        #region Global Key
        /// <summary>
        /// Global KeyDown Event
        /// </summary>
        private void globalEventProvider_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 162)
                IsCtrlPressed = true;

            if (IsCtrlPressed && e.KeyCode == Keys.C)
                this.lbl_ItemCount.Text = "Count: " + this.AddData();         
        }

        private void globalEventProvider_KeyDown(object sender, KeyEventArgs e)
        {
            this.IsCtrlPressed = false;
        }
        #endregion

        #region Buttons
        /// <summary>
        /// Ctrl+CV의 달인 정보 버튼
        /// </summary>
        private void btnAbout_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.ShowDialog();
        }

        /// <summary>
        /// 추가 버튼
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.lbl_ItemCount.Text = "Count: " + this.AddItem();
            this.grdView.FocusedColumn = this.col_Contents;
            this.grdView.ShowEditor();     
        }

        private int AddItem()
        {
            try
            {
                // ToDo
                // Add 버튼 클릭시 추가하는게 텍스트인지 이미지인지

                ClipboardInfoList clipboardInfoList = this.GetClipboardInfoList;
                ClipboardInfo clipboardInfo = new ClipboardInfo();
                clipboardInfo.CONTENTSTYPE = ContentsType.Text;
                clipboardInfo.COPIEDTIME = (DateTime.Now).ToString();
                clipboardInfoList.Insert(0, clipboardInfo);

                // Focusing                
                this.grdView.FocusedRowHandle = 0;

                return clipboardInfoList.Count;
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                               ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
                return 0;
            }
        }

        /// <summary>
        /// 삭제 버튼
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.lbl_ItemCount.Text = "Count: " + this.DeleteItem();
        }

        private int DeleteItem()
        {
            try
            {
                ClipboardInfo clipboardInfo = this.GetClipboardInfoByRowHandle(this.grdView.FocusedRowHandle);
                if (clipboardInfo != null)
                    this.DelHotKey(clipboardInfo.SHORTKEY);
                ClipboardInfoList clipboardInfoList = this.GetClipboardInfoList;
                clipboardInfoList.Remove(clipboardInfo);

                return clipboardInfoList.Count;
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
                return 0;
            }
        }

        #region Tray Context Menu Button
        /// <summary>
        /// 트레이 컨텍스트 메뉴 - 열기 버튼
        /// </summary>
        private void trayMenu_Open_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void trayMenu_OpenDisabled_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        /// <summary>
        /// 트레이 컨텍스트 메뉴 - 리스트 삭제 버튼
        /// </summary>
        private void trayMenu_DelList_Click(object sender, EventArgs e)
        {
            try
            {
                this.trayMenu_ShowList.DropDownItems.Clear();

                ClipboardInfoList list = this.GetClipboardInfoList;
                list.Clear();
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }

        /// <summary>
        /// Tray Context Menu - Enable Clipboard Button
        /// </summary>
        private void trayMenu_Enable_Click(object sender, EventArgs e)
        {
            try
            {
                this.trayMenu_Enable.Visible = false;
                this.trayMenu_Disable.Visible = true;
                this.trayMenu_Open.Visible = true;
                this.trayMenu_OpenDisabled.Visible = false;

                this.notifyIcon.Icon = new System.Drawing.Icon(Application.StartupPath + @"\Main.ico");
                this.notifyIcon.Text = "CtrlCVMaster";
                this.Icon = new System.Drawing.Icon(Application.StartupPath + @"\Main.ico");

                this.globalEventProvider.KeyDown += new System.Windows.Forms.KeyEventHandler(this.globalEventProvider_KeyDown);
                this.globalEventProvider.KeyUp += new System.Windows.Forms.KeyEventHandler(this.globalEventProvider_KeyUp);
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }

        /// <summary>
        /// Tray Contact Menu - Disable Clipboard Button
        /// </summary>
        private void trayMenu_Disable_Click(object sender, EventArgs e)
        {
            try
            {
                this.trayMenu_Enable.Visible = true;
                this.trayMenu_Disable.Visible = false;
                this.trayMenu_Open.Visible = false;
                this.trayMenu_OpenDisabled.Visible = true;

                this.notifyIcon.Icon = new System.Drawing.Icon(Application.StartupPath + @"\Main_Disabled.ico");
                this.notifyIcon.Text = "CtrlCVMaster(Disabled)";
                this.Icon = new System.Drawing.Icon(Application.StartupPath + @"\Main_Disabled.ico");

                this.globalEventProvider.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.globalEventProvider_KeyDown);
                this.globalEventProvider.KeyUp -= new System.Windows.Forms.KeyEventHandler(this.globalEventProvider_KeyUp);
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }

        /// <summary>
        /// 트레이 컨텍스트 메뉴 - 종료 버튼
        /// </summary>
        private void trayMenu_Close_Click(object sender, EventArgs e)
        {
            try
            {
                this.notifyIcon.Visible = false;
                Application.Exit();
                this.Dispose(true);
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }
        #endregion

        /// <summary>
        /// 콘텍스트 메뉴 추가
        /// </summary>
        private void contextMenuStrip_Add_Click(object sender, EventArgs e)
        {
            this.btnAdd.PerformClick();
        }

        /// <summary>
        /// 콘텍스트 메뉴 삭제
        /// </summary>
        private void contextMenuStrip_Delete_Click(object sender, EventArgs e)
        {
            this.btnDelete.PerformClick();
        }

        /// <summary>
        /// 콘텍스트 메뉴 위로이동
        /// </summary>
        private void contextMenuStrip_MoveUp_Click(object sender, EventArgs e)
        {
            this.btnMoveUp.PerformClick();
        }

        /// <summary>
        /// 콘텍스트 메뉴 아래로 이동
        /// </summary>
        private void contextMenuStrip_MoveDown_Click(object sender, EventArgs e)
        {
            this.btnMoveDown.PerformClick();
        }

        /// <summary>
        /// 위로 이동 버튼
        /// </summary>
        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            this.MoveUp();
        }

        /// <summary>
        /// 아래로 이동 버튼
        /// </summary>
        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            this.MoveDown();
        }

        private void MoveUp()
        {
            try
            {
                int[] rowhandle = this.grdView.GetSelectedRows();

                if (rowhandle != null && rowhandle.Length == 1)
                {
                    this.grdView.BeginUpdate();
                    if (rowhandle[0] > 0)
                    {
                        this.SwapBefore(this.grdView.DataSource as ClipboardInfoList, rowhandle[0]);
                        this.grdView.SelectRow(rowhandle[0] - 1);
                        this.grdView.FocusedRowHandle = rowhandle[0] - 1;
                    }
                    this.grdView.EndUpdate();
                }
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }

        private void MoveDown()
        {
            try
            {
                int[] rowhandle = this.grdView.GetSelectedRows();

                if (rowhandle != null && rowhandle.Length == 1)
                {
                    this.grdView.BeginUpdate();
                    ClipboardInfoList list = this.grdView.DataSource as ClipboardInfoList;

                    if (rowhandle[0] < list.Count - 1)
                    {
                        this.SwapAfter(list, rowhandle[0]);
                        this.grdView.SelectRow(rowhandle[0] + 1);
                        this.grdView.FocusedRowHandle = rowhandle[0] + 1;
                    }
                    this.grdView.EndUpdate();
                }
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }

        private void SwapBefore(ClipboardInfoList list, int index)
        {
            try
            {
                if (index == 0)
                    return;

                ClipboardInfo temp = list[index - 1];
                list[index - 1] = list[index];
                list[index] = temp;
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }

        private void SwapAfter(ClipboardInfoList list, int index)
        {
            try
            {
                if (index == list.Count - 1)
                    return;

                ClipboardInfo temp = list[index + 1];
                list[index + 1] = list[index];
                list[index] = temp;
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }

        /// <summary>
        /// Load Button Click
        /// </summary>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                //OpenFileDialog openFileDialog = new OpenFileDialog();
                //openFileDialog.Title = "Open File";
                //openFileDialog.Filter = "XML File(*.xml)|*.xml";
                //if (openFileDialog.ShowDialog() == DialogResult.OK)
                //{
                //    // 1. xml 파일을 datatable로 변환
                //    // 2. datatable을 clipboardInfoList로 변환
                //    // 3. this.grdCtrl.DataSource = clipboardInfoList
                //}

                // 테스트 용
                ClipboardInfoList clipboardInfoList = this.GetClipboardInfoList;
                DataTable dt = clipboardInfoList.GetDataTable();

                clipboardInfoList.Clear();

                ClipboardInfoList cl = clipboardInfoList.SetDataTable(dt);
                this.grdCtrl.DataSource = cl;
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }

        /// <summary>
        /// Save Button
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.OverwritePrompt = true;
                saveFileDialog.ValidateNames = true;
                saveFileDialog.FileName = "CtrlCVMaster_SavedClipboard.xml";
                saveFileDialog.Filter = "XML File(*.xml)|*.xml";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ClipboardInfoList clipboardInfoList = this.GetClipboardInfoList;
                    DataTable dt = clipboardInfoList.GetDataTable();
                    dt.WriteXml(saveFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// 리스트의 Focused Row 변화시 발생
        /// </summary>
        private void grdView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (this.grdView.RowCount == 0)
                    return;

                ClipboardInfo selectedInfo = this.GetClipboardInfoByRowHandle(this.grdView.FocusedRowHandle);     
           
                // 하단 수집일시 표시
                this.lbl_BottomInfo.Text = "Collected Time: " + selectedInfo.COPIEDTIME;

                // 선택한 리스트 setClipboard()
                if (selectedInfo.CONTENTS.Equals(""))
                    return;
                else
                    Clipboard.SetText(selectedInfo.CONTENTS);
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }

        /// <summary>
        /// 폼이 초기에 로드될때 발생
        /// </summary>
        private void CtrlCVMasterForm_Load(object sender, EventArgs e)
        {
            // 트레이 아이콘과 컨텍스트메뉴 연결
            notifyIcon.ContextMenuStrip = this.contextMenuStrip_tray;
            this.lbl_BottomInfo.Text = "";         
        }

        /// <summary>
        /// 폼의 종료 버튼을 눌렀을때 발생
        /// </summary>
        private void CtrlCVMasterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // 이벤트 취소
            this.Visible = false;         
        }

        /// <summary>
        /// 트레이 아이콘 더블클릭시 발생
        /// </summary>
        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {            
            this.Show();            
        }

        /// <summary>
        /// 트레이 컨텍스트 메뉴 - 리스트 보기 펼쳐질때 발생
        /// </summary>
        private void trayMenu_ShowList_DropDownOpening(object sender, EventArgs e)
        {
            try
            {
                int listNum = 0;
                this.trayMenu_ShowList.DropDownItems.Clear();
                ClipboardInfoList clipboardInfoList = this.GetClipboardInfoList;
                if (clipboardInfoList.Count == 0)
                {
                    this.trayMenu_ShowList.DropDownItems.Add("Empty");
                }
                else
                {
                    foreach (ClipboardInfo info in clipboardInfoList)
                    {
                        this.trayMenu_ShowList.DropDownItems.Add(info.CONTENTS);

                        if (info.CONTENTSTYPE == ContentsType.Text)
                            this.trayMenu_ShowList.DropDownItems[listNum].Image = ((System.Drawing.Image)(this.imgResource.GetObject("trayMenu_Text.Image")));
                        else if (info.CONTENTSTYPE == ContentsType.Image)
                        {
                            // 이미지 아이콘 표시
                        }

                        listNum++;
                    }
                }
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }
        #endregion

        #region Shortcut Key
        private Hotkey SetHotKey(Keys keys, bool shift, bool control, bool alt, bool windows)
        {
            try
            {
                ClipboardInfo clipboardInfo = this.GetClipboardInfoByRowHandle(this.grdView.FocusedRowHandle);
                int index = clipboardInfo.INDEX;

                Hotkey hk = new Hotkey();
                hk.KeyCode = keys;
                hk.Shift = shift;
                hk.Control = control;
                hk.Alt = alt;
                hk.Windows = windows;

                switch (index)
                {
                    case 1:
                        hk.Pressed += new HandledEventHandler(hk_Pressed1);
                        break;
                    case 2:
                        hk.Pressed += new HandledEventHandler(hk_Pressed2);
                        break;
                    case 3:
                        hk.Pressed += new HandledEventHandler(hk_Pressed3);
                        break;
                    case 4:
                        hk.Pressed += new HandledEventHandler(hk_Pressed4);
                        break;
                    case 5:
                        hk.Pressed += new HandledEventHandler(hk_Pressed5);
                        break;
                    case 6:
                        hk.Pressed += new HandledEventHandler(hk_Pressed6);
                        break;
                    case 7:
                        hk.Pressed += new HandledEventHandler(hk_Pressed7);
                        break;
                    case 8:
                        hk.Pressed += new HandledEventHandler(hk_Pressed8);
                        break;
                    case 9:
                        hk.Pressed += new HandledEventHandler(hk_Pressed9);
                        break;
                    case 10:
                        hk.Pressed += new HandledEventHandler(hk_Pressed0);
                        break;
                    default:
                        break;                    
                }

                if (hk.GetCanRegister(this))
                {
                    hk.Register(this);
                    return hk;
                }

                return null;
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
                return null;
            }
        }

        private void DelHotKey(string shortCutKey)
        {
            try
            {
                HotKeyInfo hkInfo = this.hotKeyInfoList.FindHotKey(shortCutKey);
                if (hkInfo == null)
                    return;

                if (hkInfo.HOTKEY.Registered)
                    hkInfo.HOTKEY.Unregister();
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }


        #region hk_Pressed1~10
        private void hk_Pressed1(object sender, HandledEventArgs e)
        {
            try
            {
                ClipboardInfoList clipboardInfoList = this.GetClipboardInfoList;
                ClipboardInfo clipboardInfo = clipboardInfoList.FindClipboardInfoByIndex(1);
                if (clipboardInfo == null)
                    return;

                Clipboard.SetText(clipboardInfo.CONTENTS);
                SendKeys.SendWait("^v");
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }
        private void hk_Pressed2(object sender, HandledEventArgs e)
        {
            try
            {
                ClipboardInfoList clipboardInfoList = this.GetClipboardInfoList;
                ClipboardInfo clipboardInfo = clipboardInfoList.FindClipboardInfoByIndex(2);
                if (clipboardInfo == null)
                    return;

                Clipboard.SetText(clipboardInfo.CONTENTS);
                SendKeys.SendWait("^v");
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }
        private void hk_Pressed3(object sender, HandledEventArgs e)
        {
            try
            {
                ClipboardInfoList clipboardInfoList = this.GetClipboardInfoList;
                ClipboardInfo clipboardInfo = clipboardInfoList.FindClipboardInfoByIndex(3);
                if (clipboardInfo == null)
                    return;

                Clipboard.SetText(clipboardInfo.CONTENTS);
                SendKeys.SendWait("^v");
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }
        private void hk_Pressed4(object sender, HandledEventArgs e)
        {
            try
            {
                ClipboardInfoList clipboardInfoList = this.GetClipboardInfoList;
                ClipboardInfo clipboardInfo = clipboardInfoList.FindClipboardInfoByIndex(4);
                if (clipboardInfo == null)
                    return;

                Clipboard.SetText(clipboardInfo.CONTENTS);
                SendKeys.SendWait("^v");
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }
        private void hk_Pressed5(object sender, HandledEventArgs e)
        {
            try
            {
                ClipboardInfoList clipboardInfoList = this.GetClipboardInfoList;
                ClipboardInfo clipboardInfo = clipboardInfoList.FindClipboardInfoByIndex(5);
                if (clipboardInfo == null)
                    return;

                Clipboard.SetText(clipboardInfo.CONTENTS);
                SendKeys.SendWait("^v");
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }
        private void hk_Pressed6(object sender, HandledEventArgs e)
        {
            try
            {
                ClipboardInfoList clipboardInfoList = this.GetClipboardInfoList;
                ClipboardInfo clipboardInfo = clipboardInfoList.FindClipboardInfoByIndex(6);
                if (clipboardInfo == null)
                    return;

                Clipboard.SetText(clipboardInfo.CONTENTS);
                SendKeys.SendWait("^v");
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }
        private void hk_Pressed7(object sender, HandledEventArgs e)
        {
            try
            {
                ClipboardInfoList clipboardInfoList = this.GetClipboardInfoList;
                ClipboardInfo clipboardInfo = clipboardInfoList.FindClipboardInfoByIndex(7);
                if (clipboardInfo == null)
                    return;

                Clipboard.SetText(clipboardInfo.CONTENTS);
                SendKeys.SendWait("^v");
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }
        private void hk_Pressed8(object sender, HandledEventArgs e)
        {
            try
            {
                ClipboardInfoList clipboardInfoList = this.GetClipboardInfoList;
                ClipboardInfo clipboardInfo = clipboardInfoList.FindClipboardInfoByIndex(8);
                if (clipboardInfo == null)
                    return;

                Clipboard.SetText(clipboardInfo.CONTENTS);
                SendKeys.SendWait("^v");
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }
        private void hk_Pressed9(object sender, HandledEventArgs e)
        {
            try
            {
                ClipboardInfoList clipboardInfoList = this.GetClipboardInfoList;
                ClipboardInfo clipboardInfo = clipboardInfoList.FindClipboardInfoByIndex(9);
                if (clipboardInfo == null)
                    return;

                Clipboard.SetText(clipboardInfo.CONTENTS);
                SendKeys.SendWait("^v");
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }
        private void hk_Pressed0(object sender, HandledEventArgs e)
        {
            try
            {
                ClipboardInfoList clipboardInfoList = this.GetClipboardInfoList;
                ClipboardInfo clipboardInfo = clipboardInfoList.FindClipboardInfoByIndex(10);
                if (clipboardInfo == null)
                    return;

                Clipboard.SetText(clipboardInfo.CONTENTS);
                SendKeys.SendWait("^v");
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }

        private void activateHk_Pressed(object sender, HandledEventArgs e)
        {
            try
            {
                if (this.WindowState == FormWindowState.Minimized)
                    this.WindowState = FormWindowState.Normal;
                else
                {
                    this.TopMost = true;
                    this.Show();
                    this.BringToFront();
                    this.TopMost = false;
                }

                this.Location = new Point(Control.MousePosition.X, Control.MousePosition.Y);
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }
        #endregion

        /// <summary>
        /// 컨텍스트 메뉴 > 리스트 보기 > 리스트 클릭시
        /// </summary>
        private void trayMenu_ShowList_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Clipboard.SetText(e.ClickedItem.ToString());
        }

        /// <summary>
        /// 단축키 설정 확인 버튼
        /// </summary>
        private void btn_ShortCutOk_Click(object sender, EventArgs e)
        {
            try
            {
                ClipboardInfoList clipboardInfoList = this.GetClipboardInfoList;
                ClipboardInfo selectedInfo = this.GetClipboardInfoByRowHandle(this.grdView.FocusedRowHandle);
                HotKeyInfo hkInfo = new HotKeyInfo();

                if (selectedInfo != null)
                {
                    if (this.chkBox_Ctrl.Checked || this.chkBox_Alt.Checked) // Ctrl or Alt CheckBox is checked.
                    {
                        if (this.comboBoxEdit_Keys.Text.Length > 0) // Key number is selected.
                        {
                            string shortCutKey = "";

                            if (this.chkBox_Ctrl.Checked)
                                shortCutKey = "Ctrl+";
                            if (this.chkBox_Alt.Checked)
                                shortCutKey += "Alt+";
                            if (this.chkbox_shift.Checked)
                                shortCutKey += "Shift+";

                            shortCutKey += this.comboBoxEdit_Keys.Text;

                            if (this.CheckShortKeyDuplicate(shortCutKey))
                            {
                                selectedInfo.SHORTKEY = shortCutKey;
                                selectedInfo.INDEX = clipboardInfoList.GetNextIndex();

                                // setting global hotKey
                                Keys key = Keys.None;
                                switch (this.comboBoxEdit_Keys.Text)
                                {
                                    case "1": key = Keys.D1; break;
                                    case "2": key = Keys.D2; break;
                                    case "3": key = Keys.D3; break;
                                    case "4": key = Keys.D4; break;
                                    case "5": key = Keys.D5; break;
                                    case "6": key = Keys.D6; break;
                                    case "7": key = Keys.D7; break;
                                    case "8": key = Keys.D8; break;
                                    case "9": key = Keys.D9; break;
                                    case "0": key = Keys.D0; break;
                                    default: break;
                                }

                                Hotkey hk =  this.SetHotKey(key, this.chkbox_shift.Checked, this.chkBox_Ctrl.Checked, this.chkBox_Alt.Checked, false);
                                if (hk == null)
                                {
                                    selectedInfo.SHORTKEY = "";
                                    selectedInfo.INDEX = 0;
                                    return;
                                }                                    
                                hkInfo.HOTKEY = hk;
                                hkInfo.HOTKEYNAME = shortCutKey;
                                //hkInfo.INDEX = clipboardInfoList.GetNextIndex();
                                hotKeyInfoList.Add(hkInfo);
                            }
                            else
                            {
                                MessageBox.Show("Shortcut Key [" + shortCutKey + "] is already being used.", "WARNING");
                            }

                            this.grdView.RefreshRow(this.grdView.FocusedRowHandle);
                        }
                        else
                        {
                            MessageBox.Show("To set a shortcut key, key number must be selected.", "WARNING");
                        }
                    }
                    else
                    {                        
                        MessageBox.Show("To set a shortcut key, at least one of Ctrl or Alt key must be checked.", "WARNING");
                    }
                }
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }

        /// <summary>
        /// Check whether the shortcut key is already being used
        /// </summary>
        private bool CheckShortKeyDuplicate(string key)
        {
            try
            {
                ClipboardInfoList clipboardInfoList = this.GetClipboardInfoList;

                foreach (ClipboardInfo info in clipboardInfoList)
                {
                    if (info.SHORTKEY.Equals(key))
                        return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
                return false;
            }
        }

        /// <summary>
        /// 단축키 설정창 open시 발생
        /// </summary>
        private void repPopUp_Popup(object sender, EventArgs e)
        {
            try
            {
                this.chkBox_Alt.Checked = false;
                this.chkBox_Ctrl.Checked = false;
                this.chkbox_shift.Checked = false;
                this.comboBoxEdit_Keys.Text = "";

                ClipboardInfo clipboardInfo = this.GetClipboardInfoByRowHandle(this.grdView.FocusedRowHandle);
                if (clipboardInfo.SHORTKEY.Length > 0)
                {
                    if (clipboardInfo.SHORTKEY.Contains("Ctrl"))
                        this.chkBox_Ctrl.Checked = true;
                    if (clipboardInfo.SHORTKEY.Contains("Alt"))
                        this.chkBox_Alt.Checked = true;
                    if (clipboardInfo.SHORTKEY.Contains("Shift"))
                        this.chkbox_shift.Checked = true;

                    this.comboBoxEdit_Keys.Text = clipboardInfo.SHORTKEY.Substring(clipboardInfo.SHORTKEY.LastIndexOf("+")+1);
                }
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }
        #endregion

        public enum ContentsType
        {
            None,
            Text,
            Image
        }

        /// <summary>
        /// 단축키 Ctrl 체크박스 변경시
        /// </summary>
        private void chkBox_Ctrl_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chkBox_Ctrl.Checked || this.chkBox_Alt.Checked)
                    this.chkbox_shift.Enabled = true;
                else
                    this.chkbox_shift.Enabled = false;
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }

        /// <summary>
        /// 단축키 Atl 체크박스 변경시
        /// </summary>
        private void chkBox_Alt_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chkBox_Alt.Checked || this.chkBox_Ctrl.Checked)
                    this.chkbox_shift.Enabled = true;
                else
                    this.chkbox_shift.Enabled = false;
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }

        /// <summary>
        /// shortcut key delete btn
        /// </summary>
        private void btn_DelShortcut_Click(object sender, EventArgs e)
        {
            try
            {
                ClipboardInfo selectedInfo = this.GetClipboardInfoByRowHandle(this.grdView.FocusedRowHandle);

                if (selectedInfo != null)
                {
                    this.DelHotKey(selectedInfo.SHORTKEY);
                    selectedInfo.SHORTKEY = "";
                    this.grdView.RefreshRow(this.grdView.FocusedRowHandle);

                }
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }

        /// <summary>
        /// Activate CtrlCVMaster Shortcut Key
        /// </summary>
        public void ActivateShortcutKey(Keys keys, bool shift, bool control, bool alt, bool windows)
        {
            try
            {
                Hotkey hk = new Hotkey();

                hk.KeyCode = keys;
                hk.Shift = shift;
                hk.Control = control;
                hk.Alt = alt;
                hk.Windows = windows;

                hk.Pressed += new HandledEventHandler(activateHk_Pressed);

                if (hk.GetCanRegister(this)) hk.Register(this);
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }
    }
}
