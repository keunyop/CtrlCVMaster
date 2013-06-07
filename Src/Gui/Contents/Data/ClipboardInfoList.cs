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
        /// Set DataTable to the clipboardinfolist
        /// </summary>
        /// <param name="dt"></param>
        public ClipboardInfoList SetDataTable(DataTable dt)
        {
            // DataTable을 받아서 grid.DataSource에 넣을 수 있는 ClipboardInfoList형태로 변환
            //List<DataRow> list = dt.AsEnumerable().ToList();

            foreach (DataRow dr in dt.Rows)
            {
                foreach (object ob in dr.ItemArray)
                {
                    
                }
            }

            

            return null;
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
