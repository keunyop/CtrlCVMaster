using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CtrlCVMaster.Gui.Contents;
using System.Drawing;
using System.Diagnostics;

namespace CtrlCVMaster
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #if DEBUG
            DebugMethod();
            #endif

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            CtrlCVMasterForm form = new CtrlCVMasterForm();
            int x = Screen.PrimaryScreen.Bounds.Width - form.Width;
            int y = Screen.PrimaryScreen.Bounds.Height - form.Height;
            form.Location = new Point(x, y-40);

            Application.Run(form);
        }

        [Conditional("DEBUG")]
        static void DebugMethod()
        {
            ConsoleLib.ConsoleLib.CreateConsole();
            ConsoleLib.ConsoleLib.WriteLine("CtrlCVMaster Debugging Start" + Environment.NewLine);
        }
    }
}
