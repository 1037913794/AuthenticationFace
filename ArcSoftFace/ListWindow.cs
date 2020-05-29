using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcSoftFace
{
    public partial class ListWindow : UserControl
    {
        public ListWindow(List<string> recordName,List<int> onTime,List<int> late,List<int> absent)
        {
            InitializeComponent();
            for(int i = 0; i < recordName.Count; i++)
            {
                ListViewItem it = new ListViewItem();
                it.Text = recordName[i];
                it.SubItems.Add(onTime[i].ToString());
                it.SubItems.Add(late[i].ToString());
                it.SubItems.Add(absent[i].ToString());
                double rate = (onTime[i] + late[i]) * 1.0 / (onTime[i] + late[i] + absent[i]);
                it.SubItems.Add(rate.ToString("P"));
                this.listViewInfo.Items.Add(it);
            }
        }
    }
}
