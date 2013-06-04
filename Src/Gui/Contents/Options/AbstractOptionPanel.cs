using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CtrlCVMaster.Gui.Contents.Options
{
    public class AbstractOptionPanel: UserControl, IOptionPanel
    {
        public virtual bool ReceiveDialogMessage(DialogMessage message)
        {
            switch (message)
            {
                case DialogMessage.OK:
                    this.StorePanelContents();
                    break;
            }

            return true;
        }

        public virtual bool StorePanelContents()
        {
            return true;
        }
    }
}
