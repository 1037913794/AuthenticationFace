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
    public partial class PieGraph : UserControl
    {
        public PieGraph(int absent,int late,int ontime)
        {
            InitializeComponent();
            List<string> xData = new List<string>() { "缺席", "准时", "迟到"};
            List<int> yData = new List<int>() { absent,ontime,late};
            chart1.Titles.Add("课程考勤记录统计分析");
            chart1.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧 
            chart1.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。 
            chart1.Series[0].Points.DataBindXY(xData, yData);
        }
    }
}
