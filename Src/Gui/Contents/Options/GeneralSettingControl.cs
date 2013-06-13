using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using CtrlCVMaster.Properties;

namespace CtrlCVMaster.Gui.Contents.Options
{
    public partial class GeneralSettingControl : AbstractOptionPanel
    {
        private bool bIsChanged = false;

        public GeneralSettingControl()
        {
            InitializeComponent();
            this.SetSettings();
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

        private void SetSettings()
        {
            try
            {
                string check = Settings.Default["General_SystemStartup"].ToString();
                if ("True".Equals(check))
                    this.chk_Startup.CheckState = CheckState.Checked;
                else
                    this.chk_Startup.CheckState = CheckState.Unchecked;                
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }

        public override bool StorePanelContents()
        {
            if (!this.bIsChanged)
                return true;

            if (!this.CheckInputData())
                return false;

            // Save in the Settings
            Settings.Default["General_SystemStartup"] = this.chk_Startup.Checked;
            Settings.Default.Save();


            // Apply right away
            this.SetStartup();

            return true;
        }

        /// <summary>
        /// Check whether the input data is ok.
        /// </summary>
        private bool CheckInputData()
        {
            try
            {
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
                RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

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
