using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CtrlCVMaster.Gui.Contents.Data
{
    public class SettingInfoList : BindingList<SettingInfo>
    {
        public SettingInfoList()
        {
        }
    }

    public class SettingInfo
    {
        private string settingName = "";

        public string SETTINGNAME
        {
            get
            {
                return this.settingName;
            }
            set
            {
                this.settingName = value;
            }
        }

        public SettingInfo()
        {
        }
    }
}
