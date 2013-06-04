using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtrlCVMaster.Gui.Contents.Options
{
    public enum DialogMessage
    {
        OK,
        Cancel
    }

    public interface IOptionPanel
    {
        bool ReceiveDialogMessage(DialogMessage message);
    }
}
