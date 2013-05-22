using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CtrlCVMaster.Gui.Contents.Data
{
    public class ClipboardInfoList : BindingList<ClipboardInfo>
    {
        public ClipboardInfoList()
        {
        }

        public ClipboardInfo FindClipboardInfoByHotKey(string key)
        {
            foreach (ClipboardInfo info in this)
            {
                if (info.SHORTKEY.Equals(key))
                    return info;
            }
            return null;
        }

        public ClipboardInfo FindClipboardInfoByIndex(int index)
        {
            foreach (ClipboardInfo info in this)
            {
                if (info.INDEX == index)
                    return info;
            }
            return null;
        }

        public int GetNextIndex()
        {
            try
            {
                List<int> hkList = new List<int>();
                foreach (ClipboardInfo info in this)
                {
                    if (info.INDEX > 0)
                        hkList.Add(info.INDEX);
                }

                for (int i = 1; i < 11; i++)
                {
                    if (!hkList.Contains(i))
                        return i;
                }

                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }            
        }
    }

    public class ClipboardInfo
    {
        private string shortkey = "";
        private string contents = "";
        private string copiedTime = "";
        private CtrlCVMaster.Gui.Contents.CtrlCVMasterForm.ContentsType contentsType = CtrlCVMaster.Gui.Contents.CtrlCVMasterForm.ContentsType.None;
        private int index = 0;

        public string SHORTKEY
        {
            get
            {
                return this.shortkey;
            }
            set
            {
                if (this.shortkey == value)
                    return;
                this.shortkey = value;
            }
        }

        public string CONTENTS
        {
            get
            {
                return this.contents;
            }
            set
            {
                if (this.contents == value)
                    return;
                this.contents = value;
            }
        }

        public string COPIEDTIME
        {
            get { return this.copiedTime; }
            set
            {
                if (this.copiedTime == value)
                    return;
                this.copiedTime = value;
            }
        }

        public CtrlCVMaster.Gui.Contents.CtrlCVMasterForm.ContentsType CONTENTSTYPE
        {
            get { return this.contentsType; }
            set
            {
                if (this.contentsType == value)
                    return;
                this.contentsType = value;
            }
        }

        public int INDEX
        {
            get { return this.index; }
            set
            {
                this.index = value;
            }
        }
    }
}
