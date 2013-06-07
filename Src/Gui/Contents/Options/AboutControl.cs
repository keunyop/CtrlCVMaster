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
                string text = System.IO.File.ReadAllText(@"VersionInfo.txt");
                this.memoEdit.Text = text;
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                                                 ", t);
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
