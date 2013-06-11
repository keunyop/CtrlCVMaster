using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Xml;

namespace CtrlCVMaster.Gui.Contents.Data
{
    public class ClipboardInfoList : BindingList<ClipboardInfo>
    {
        public ClipboardInfoList()
        {
        }

        #region DEBUG
        /// <summary>
        /// Debug Console 창에 밝은 빨간색 font
        /// </summary>
        private ConsoleLib.ConsoleLib.ConsoleAttributes t
        {
            get { return ConsoleLib.ConsoleLib.ConsoleAttributes.ForegroundRed | ConsoleLib.ConsoleLib.ConsoleAttributes.ForegroundIntensity; }
        }
        #endregion

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

        /// <summary>
        /// Convert and return the clipboardinfolist to DataTable
        /// </summary>
        public DataTable GetDataTable()
        {
            DataTable dt = new DataTable("SavedClipboardData");
            int i = 0;

            foreach (ClipboardInfo info in this)
            {
                PropertyDescriptorCollection Classproperties = TypeDescriptor.GetProperties(info);

                if (i == 0) // Create Table Header
                {
                    // Create Columns
                    for (int x = 0; x < Classproperties.Count; x++)
                    {
                        DataColumn dtc = new DataColumn();
                        dtc.ColumnName = Classproperties[x].Name;

                        dt.Columns.Add(dtc);
                    }
                }

                DataRow dr = dt.NewRow(); // new datatable row

                //Fill in Datatable
                for (int x = 0; x < Classproperties.Count; x++)
                {
                    Type fieldtype = info.GetType();
                    string fldname = Classproperties[x].Name.ToString();
                    PropertyInfo prtinf = fieldtype.GetProperty(fldname) as PropertyInfo;
                    dr[x] = prtinf.GetValue(info, null);
                }

                dt.Rows.Add(dr);

                i++;
            }

            return dt;
        }

        /// <summary>
        /// Convert and return the clipboardinfolist from DataTable
        /// </summary>
        public ClipboardInfoList SetDataTable(DataTable dt)
        {
            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    ClipboardInfo clipboardInfo = new ClipboardInfo();
                    for (int i = 0; i < row.ItemArray.Length; i++)
                    {
                        if (i == 0) clipboardInfo.SHORTKEY = row.ItemArray[0].ToString();
                        else if (i == 1) clipboardInfo.CONTENTS = row.ItemArray[1].ToString();
                        else if (i == 2) clipboardInfo.COPIEDTIME = row.ItemArray[2].ToString();
                        else if (i == 3)
                        {
                            string contentsType = row.ItemArray[3].ToString();
                            if ("Text".Equals(contentsType)) clipboardInfo.CONTENTSTYPE = CtrlCVMaster.Gui.Contents.CtrlCVMasterForm.ContentsType.Text;
                            else if ("Image".Equals(contentsType)) clipboardInfo.CONTENTSTYPE = CtrlCVMaster.Gui.Contents.CtrlCVMasterForm.ContentsType.Image;
                        }
                        else if (i == 4) clipboardInfo.INDEX = Int32.Parse(row.ItemArray[4].ToString());
                    }

                    this.Add(clipboardInfo);
                }

                return this;
            }
            catch (Exception ex)
            {
                ConsoleLib.ConsoleLib.WriteFormatted(ex.ToString() + "                    ", t);
                ConsoleLib.ConsoleLib.WriteLine(Environment.NewLine);
                return null;
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
