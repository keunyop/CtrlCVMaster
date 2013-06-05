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
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("Product Version: 1.05");
                sb.AppendLine("Release Date: 20??-??-??");
                sb.AppendLine("");
                sb.AppendLine("Added Feature:");
                sb.AppendLine("\t- Shortcut keys for the tray context menu");
                sb.AppendLine("\t- Enforce debugging error log");
                sb.AppendLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _");
                sb.AppendLine("");
                sb.AppendLine("Product Version: 1.04");
                sb.AppendLine("Release Date: 2013-06-04");
                sb.AppendLine("");
                sb.AppendLine("Added Feature:");
                sb.AppendLine("\t- Activate CtrlCVMaster Shortcut key");
                sb.AppendLine("\t- Enable/Disable clipboard connection");
                sb.AppendLine("\t\t- Change CtrlCVMaster Icon while disabled");
                sb.AppendLine("\t- In the Setting window, only the changed properties are saved");
                sb.AppendLine("\t\t- Input validation check");
                sb.AppendLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _");
                sb.AppendLine("");
                sb.AppendLine("Product Version: 1.03");
                sb.AppendLine("Release Date: 2013-03-12");
                sb.AppendLine("");
                sb.AppendLine("Added Feature:");
                sb.AppendLine("\t- Can set Start CtrlCVMaster on System Startup.");
                sb.AppendLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _  _ _ _ _ _ _ _ _ _ _ __ _ _ _");
                sb.AppendLine("");
                sb.AppendLine("Product Version: 1.02");
                sb.AppendLine("Release Date: 2013-03-11");
                sb.AppendLine("");
                sb.AppendLine("Added Feature:");
                sb.AppendLine("\t- Setting hotkey upto 10.");
                sb.AppendLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _");
                sb.AppendLine("");
                sb.AppendLine("Product Version: 1.01");
                sb.AppendLine("Release Date: 2013-02-18");
               
                this.memoEdit.Text = sb.ToString();               
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
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
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
            }
        }
    }
}
