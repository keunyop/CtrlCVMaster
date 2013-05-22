using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CtrlCVMaster.Gui.Contents.Data
{
    public class HotKeyInfoList : BindingList<HotKeyInfo>
    {
        public HotKeyInfoList()
        {
        }

        public HotKeyInfo FindHotKey(string shortCutKey)
        {
            foreach (HotKeyInfo hkInfo in this)
            {
                if (hkInfo.HOTKEYNAME.Equals(shortCutKey))
                    return hkInfo;
            }

            return null;
        }
    }

    public class HotKeyInfo
    {
        private Hotkey hotkey = null;
        private string hotkeyName = "";
        //private int index = 0;

        public Hotkey HOTKEY
        {
            get { return this.hotkey; }
            set
            {
                this.hotkey = value;
            }
        }

        public string HOTKEYNAME
        {
            get { return this.hotkeyName; }
            set
            {
                this.hotkeyName = value;
            }
        }

        //public int INDEX
        //{
        //    get { return this.index; }
        //    set
        //    {
        //        this.index = value;
        //    }
        //}
    }
}
