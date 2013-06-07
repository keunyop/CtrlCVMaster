using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CtrlCVMaster.Gui.Contents.Data;

namespace CtrlCVMaster.Gui.Contents.Options
{
    public partial class SettingForm : Form
    {
        private List<IOptionPanel> OptionPanels = new List<IOptionPanel>();

        public SettingForm()
        {
            InitializeComponent();
            this.SetData();
        }

        private void SetData()
        {
            try
            {
                string[] settingList = new string[] { "General", "Shortcuts", "About CtrlCVMaster" };

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
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
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
                IOptionPanel pane = null;

                this.lbl_SettingDetail.Text = " " + this.GetSelectedSettingInfo.SETTINGNAME;
                switch (e.FocusedRowHandle)
                {
                    case 0:
                        this.generalSettingControl.Visible = true;
                        this.shortcutsControl.Visible = false;
                        this.aboutControl.Visible = false;
                        pane = this.generalSettingControl;
                        break;
                    case 1:
                        this.generalSettingControl.Visible = false;
                        this.shortcutsControl.Visible = true;
                        this.aboutControl.Visible = false;
                        pane = this.shortcutsControl;
                        break;
                    case 2:
                        this.generalSettingControl.Visible = false;
                        this.shortcutsControl.Visible = false;
                        this.aboutControl.Visible = true;
                        break;
                    default:
                        break;
                }

                if (pane != null && !this.OptionPanels.Contains(pane))
                    this.OptionPanels.Add(pane);
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }

        /// <summary>
        /// OK Button Click
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                // Save to the configuration
                foreach (IOptionPanel pane in OptionPanels)
                {
                    if (!pane.ReceiveDialogMessage(DialogMessage.OK))
                        return;
                }

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }
    }
}
