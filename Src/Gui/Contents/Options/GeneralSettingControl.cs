using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace CtrlCVMaster.Gui.Contents.Options
{
    public partial class GeneralSettingControl : AbstractOptionPanel
    {
        private bool bIsChanged = false;

        public GeneralSettingControl()
        {
            InitializeComponent();
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

        public override bool StorePanelContents()
        {
            if (!this.bIsChanged)
                return true;

            if (!this.CheckInputData())
                return false;


            Console.WriteLine("이곳에서 GeneralSetting에 대한 설정을 저장한다.!!!!");


            // Apply right away
            //this.SetStartup();

            return true;
        }

        /// <summary>
        /// Check whether the input data is ok.
        /// </summary>
        private bool CheckInputData()
        {
            try
            {
                if (this.cmb_Max.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Plese select the max. # of shortcut keys.", "WARNING");
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
        /// Start CtrlCVMaster on System Startup
        /// </summary>
        private void SetStartup()
        {
            try
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

                if (this.chk_Startup.Checked)
                    rk.SetValue("CtrlCVMaster", Application.ExecutablePath.ToString());
                else
                    rk.DeleteValue("CtrlCVMaster", false);
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }

        /// <summary>
        /// chk_Startup check changed
        /// </summary>
        private void chk_Startup_CheckStateChanged(object sender, EventArgs e)
        {
            this.bIsChanged = true;                 
        }
    }
}
