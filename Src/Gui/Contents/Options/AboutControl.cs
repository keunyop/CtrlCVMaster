using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CtrlCVMaster.Gui.Contents.Options
{
    public partial class AboutControl : UserControl
    {
        public AboutControl()
        {
            InitializeComponent();
            this.SetResource();
        }

        #region Debug
        /// <summary>
        /// Debug Console 창에 밝은 빨간색 font
        /// </summary>
        private ConsoleLib.ConsoleLib.ConsoleAttributes t
        {
            get { return ConsoleLib.ConsoleLib.ConsoleAttributes.ForegroundRed | ConsoleLib.ConsoleLib.ConsoleAttributes.ForegroundIntensity; }
        }
        #endregion

        private void SetResource()
        {
            try
            {
                this.memoEdit.Text = "Product Version: 1.03" + Environment.NewLine + "Release Date: 2013-06-04";
                this.memoEdit.Text += Environment.NewLine + Environment.NewLine;
                this.memoEdit.Text += "Added Feature: ";
                this.memoEdit.Text += Environment.NewLine + "\t- Activate CtrlCVMaster Shortcut key.";
                this.memoEdit.Text += Environment.NewLine + "\t- Enable/Disable clipboard connection.";
                this.memoEdit.Text += Environment.NewLine + "\t\t- Change CtrlCVMaster Icon while disabled.";
                this.memoEdit.Text += Environment.NewLine + "\t- In the Setting window, only the changed properties are saved.";
                this.memoEdit.Text += Environment.NewLine + "\t\t- Input validation check added";
                this.memoEdit.Text += Environment.NewLine + "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
                this.memoEdit.Text += Environment.NewLine + Environment.NewLine;
                this.memoEdit.Text += "Product Version: 1.03" + Environment.NewLine + "Release Date: 2013-03-12";
                this.memoEdit.Text += Environment.NewLine + Environment.NewLine;
                this.memoEdit.Text += "Added Feature: ";
                this.memoEdit.Text += Environment.NewLine + "\t- Can set Start CtrlCVMaster on System Startup.";
                this.memoEdit.Text += Environment.NewLine + "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
                this.memoEdit.Text += Environment.NewLine + Environment.NewLine;
                this.memoEdit.Text += "Product Version: 1.02" + Environment.NewLine + "Release Date: 2013-03-11";
                this.memoEdit.Text += Environment.NewLine + Environment.NewLine;
                this.memoEdit.Text += "Added Feature: ";
                this.memoEdit.Text += Environment.NewLine + "\t- Setting hotkey upto 10.";
                this.memoEdit.Text += Environment.NewLine + "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
                this.memoEdit.Text += Environment.NewLine + Environment.NewLine;
                this.memoEdit.Text += "Product Version: 1.01" + Environment.NewLine + "Release Date: 2013-02-18";
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString(), t);
            }
        }

        /// <summary>
        /// hyperLink 클릭시
        /// </summary>
        private void hyperLinkEdit_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://samurae83.blog.me/90165627248");
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString(), t);
            }
        }
    }
}
