using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CtrlCVMaster.Gui.Contents.Data;

namespace CtrlCVMaster.Src.Gui.Contents
{
    public partial class ShortcutsControl : UserControl
    {
        public ShortcutsControl()
        {
            InitializeComponent();
            this.SetData();
        }

        private void SetData()
        {
            this.popupContainerEdit.Text = "Alt+Q";
        }

        /// <summary>
        /// Debug Console 창에 밝은 빨간색 font
        /// </summary>
        private ConsoleLib.ConsoleLib.ConsoleAttributes t
        {
            get { return ConsoleLib.ConsoleLib.ConsoleAttributes.ForegroundRed | ConsoleLib.ConsoleLib.ConsoleAttributes.ForegroundIntensity; }
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
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString(), t);
            }
        }
    }
}
