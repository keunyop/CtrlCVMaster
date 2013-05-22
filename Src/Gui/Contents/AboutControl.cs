using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CtrlCVMaster.Gui.Contents
{
    public partial class AboutControl : UserControl
    {
        public AboutControl()
        {
            InitializeComponent();
            this.SetResource();
        }

        /// <summary>
        /// Debug Console 창에 밝은 빨간색 font
        /// </summary>
        private ConsoleLib.ConsoleLib.ConsoleAttributes t
        {
            get { return ConsoleLib.ConsoleLib.ConsoleAttributes.ForegroundRed | ConsoleLib.ConsoleLib.ConsoleAttributes.ForegroundIntensity; }
        }

        private void SetResource()
        {
            try
            {
                this.memoEdit.Text = "Product Version: 1.01" + Environment.NewLine + "Release Date: 2013-02-18";
                this.memoEdit.Text += Environment.NewLine + "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
                this.memoEdit.Text += Environment.NewLine + Environment.NewLine;
                this.memoEdit.Text += "Product Version: 1.02" + Environment.NewLine + "Release Date: 2013-03-11";
                this.memoEdit.Text += Environment.NewLine + Environment.NewLine;
                this.memoEdit.Text += "Added Feature: Setting hotkey upto 10.";
                this.memoEdit.Text += Environment.NewLine + "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
                this.memoEdit.Text += Environment.NewLine + Environment.NewLine;
                this.memoEdit.Text += "Product Version: 1.03" + Environment.NewLine + "Release Date: 2013-03-12";
                this.memoEdit.Text += Environment.NewLine + Environment.NewLine;
                this.memoEdit.Text += "Added Feature: Can set Start CtrlCVMaster on System Startup. ";
                this.memoEdit.Text += Environment.NewLine + "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
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
                System.Diagnostics.Process.Start("http://samurae83.blog.me/");
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString(), t);
            }
        }
    }
}
