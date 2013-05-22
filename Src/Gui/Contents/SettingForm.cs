using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CtrlCVMaster.Gui.Contents.Data;
using Microsoft.Win32;

namespace CtrlCVMaster.Gui.Contents
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
            this.SetResource();
            this.SetData();
        }

        private void SetResource()
        {
            this.pnlRight.Controls.Add(this.generalSettingControl);
            this.pnlRight.Controls.Add(this.aboutControl);
            this.generalSettingControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutControl.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void SetData()
        {
            try
            {
                string[] settingList = new string[] { "General", "Shortcuts", "About Ctrl+CV Master" };

                SettingInfoList settingInfoList = new SettingInfoList();
                foreach (string settingName in settingList)
                {
                    SettingInfo settingInfo = new SettingInfo();
                    settingInfo.SETTINGNAME = settingName;
                    settingInfoList.Add(settingInfo);
                }

                this.gridCtrl.DataSource = settingInfoList;
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString(), t);
            }
        }

        #region Utility
        /// <summary>
        /// Debug Console 창에 밝은 빨간색 font
        /// </summary>
        private ConsoleLib.ConsoleLib.ConsoleAttributes t
        {
            get { return ConsoleLib.ConsoleLib.ConsoleAttributes.ForegroundRed | ConsoleLib.ConsoleLib.ConsoleAttributes.ForegroundIntensity; }
        }

        private SettingInfo GetSelectedSettingInfo
        {
            get
            {
                return this.gridView.GetRow(this.gridView.FocusedRowHandle) as SettingInfo;
            }
        }
        #endregion

        /// <summary>
        /// 설정창 리스트 항목 이동시 발생
        /// </summary>
        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.lbl_SettingDetail.Text = " " + this.GetSelectedSettingInfo.SETTINGNAME;                
                switch (e.FocusedRowHandle)
                {
                    case 0:
                        this.generalSettingControl.Visible = true;
                        this.shortcutsControl.Visible = false;
                        this.aboutControl.Visible = false;
                        break;
                    case 1:
                        this.generalSettingControl.Visible = false;
                        this.shortcutsControl.Visible = true;
                        this.aboutControl.Visible = false;                
                        break;
                    case 2:
                        this.generalSettingControl.Visible = false;
                        this.shortcutsControl.Visible = false;
                        this.aboutControl.Visible = true;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString(), t);
            }
        }

        /// <summary>
        /// 확인 버튼
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                this.SetStartup();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString(), t);
            }
        }

        private void SetStartup()
        {
            try
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

                if (this.generalSettingControl.chk_Startup.Checked)
                    rk.SetValue("CtrlCVMaster", Application.ExecutablePath.ToString());
                else
                    rk.DeleteValue("CtrlCVMaster", false);
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted("SetStartup" + ex.ToString(), t);
            }
        }
    }
}
