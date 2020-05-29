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
    public partial class BarGraph : UserControl
    {
        public BarGraph(List<string> recordName,List<int> late,List<int> absent,List<int> ontime)
        {
            InitializeComponent();
            chart1.Titles.Add("课程考勤记录柱状图");
            chart1.Series[0].Points.DataBindXY(recordName, ontime);
            chart1.Series[1].Points.DataBindY(late);
            chart1.Series[2].Points.DataBindY(absent);

        }
    }
}
