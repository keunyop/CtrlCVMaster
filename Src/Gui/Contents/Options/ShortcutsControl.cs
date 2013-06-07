using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CtrlCVMaster.Gui.Contents.Data;
using CtrlCVMaster.Gui.Contents.Options;
using CtrlCVMaster.Properties;

namespace CtrlCVMaster.Src.Gui.Contents.Options
{
    public partial class ShortcutsControl : AbstractOptionPanel
    {
        private bool bIsChanged = false;

        public ShortcutsControl()
        {
            InitializeComponent();
            this.SetSettings();
        }

        private void SetSettings()
        {
            this.popupContainerEdit.Text = Settings.Default["Shortcut_ActiveKey"].ToString();
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

            // Save in the Settings
            Settings.Default["Shortcut_ActiveKey"] = this.popupContainerEdit.Text;
            Settings.Default.Save();

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
        /// Activate CtrlCVMaster Shortcut key 'OK' button
        /// </summary>
        private void btn_ShortCutOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.chkBox_Ctrl.Checked || this.chkBox_Alt.Checked) // Ctrl or Alt CheckBox must be checked first
                {
                    if (this.comboBoxEdit_Keys.Text.Length > 0) // Key is selected
                    {
                        string shortCutKey = "";

                        if (this.chkBox_Ctrl.Checked) shortCutKey = "Ctrl+";
                        if (this.chkBox_Alt.Checked) shortCutKey += "Alt+";
                        if (this.chkbox_shift.Checked) shortCutKey += "Shift+";

                        shortCutKey += this.comboBoxEdit_Keys.Text;

                        Keys key = Keys.None;
                        switch (this.comboBoxEdit_Keys.Text)
                        {
                            case "Q": key = Keys.Q; break;
                            default: break;
                        }

                        this.popupContainerEdit.Text = shortCutKey;

                        this.popupContainerEdit.ClosePopup();
                    }
                    else
                    {
                        MessageBox.Show("To set a shortcut key, key must be selected.", "WARNING");
                    }
                }
                else
                {
                    MessageBox.Show("To set a shortcut key, at least one of Ctrl or Alt key must be checked.", "WARNING");
                }
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }

        /// <summary>
        /// Activate CtrlCVMaster Shortcutkey Popup 
        /// </summary>        
        private void popupContainerEdit_Popup(object sender, EventArgs e)
        {
            try
            {
                this.bIsChanged = true;
                this.chkBox_Alt.Checked = false;
                this.chkBox_Ctrl.Checked = false;
                this.chkbox_shift.Checked = false;
                this.comboBoxEdit_Keys.Text = "";
                string shortCutKey = this.popupContainerEdit.Text;

                if (shortCutKey.Length > 0)
                {
                    if (shortCutKey.Contains("Ctrl"))
                        this.chkBox_Ctrl.Checked = true;
                    if (shortCutKey.Contains("Alt"))
                        this.chkBox_Alt.Checked = true;
                    if (shortCutKey.Contains("Shift"))
                        this.chkbox_shift.Checked = true;

                    this.comboBoxEdit_Keys.Text = shortCutKey.Substring(shortCutKey.LastIndexOf("+") + 1);
                }
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }

        /// <summary>
        /// Activate CtrlCVMaster Shortcutkey delete btn
        /// </summary>
        private void btn_DelShortcut_Click(object sender, EventArgs e)
        {
            try
            {
                this.popupContainerEdit.Text = "";
                this.popupContainerEdit.ClosePopup();
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }
    }
}
