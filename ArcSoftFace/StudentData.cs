using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcSoftFace
{
    public partial class StudentData : Form
    {

        Dictionary<string, KeyValuePair<string, string>> students=new Dictionary<string, KeyValuePair<string, string>>();
        Dictionary<string, string> Classes = new Dictionary<string, string>();

        int absence=0, on_time=0, late=0;
        public StudentData()
        {
            InitializeComponent();
            updateStudents();
            updateClass();
            cmBoxSno.SelectedIndex = 0;

        }

        private void updateChart()
        {
            //chart1.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧
            chart1.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。
            chart1.Titles.Add("Rate");
            List<string> xData = new List<string>() { "未到", "准时", "迟到" };
            List<int> yData = new List<int>() { absence, on_time, late };
            chart1.Series[0].Points.DataBindXY(xData, yData); //序列数据点集合1绑定数据


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            updateListView();
            updateChart();
        }

        private void updateStudents()
        {
            using (StreamReader sr = File.OpenText("..\\..\\..\\Database\\Student\\Student.csv"))
            {
                string strLine = sr.ReadLine();
                string[] strArray;
                if(students.Count!=0)
                    students.Clear();
                while ((strLine = sr.ReadLine()) != null)
                {
                    strArray = strLine.Split(',');
                    students.Add(strArray[0], new KeyValuePair<string, string>(strArray[1], strArray[2]));
                    cmBoxSno.Items.Add(strArray[0]);
                }
            }
        }


        private void updateClass()
        {
            using (StreamReader sr = File.OpenText("..\\..\\..\\Database\\Class\\Class.csv"))
            {
                string strLine = sr.ReadLine();
                string[] strArray;
                Classes.Clear();
                while ((strLine = sr.ReadLine()) != null)
                {
                    strArray = strLine.Split(',');
                    Classes.Add(strArray[0], strArray[1]);
                }
            }
        }


        private void updateListView()
        {
            string sno = cmBoxSno.Text.ToString();
            this.listViewInfo.Items.Clear();
            //this.listViewInfo.Clear();
            absence = 0; on_time = 0; late = 0;
            foreach (var i in Classes.Keys)
            {
                updateRecord(sno, i);
            }
        }



        private void updateRecord(string sno, string cno)
        {
            using (StreamReader sr = File.OpenText("..\\..\\..\\Database\\Class\\List\\" + cno + ".csv"))
            {
                string strLine = sr.ReadLine();
                string[] strArray = strLine.Split(',');
                int recordNum = strArray.Length/2;
                string[] recordName = strArray;

                while ((strLine = sr.ReadLine()) != null)
                {
                    strArray = strLine.Split(',');
                    if (strArray[0] == sno)
                    {
                        for(int i = 0, j = 1; i < recordNum; i++,j+=2)
                        {
                            ListViewItem it = new ListViewItem();
                            it.Text = Classes[cno];
                            it.SubItems.Add(recordName[j]);
                            if (strArray[j] == "0")
                            {
                                it.SubItems.Add("未到");
                                absence++;
                            }
                            else
                            {
                                if (strArray[j + 1] == "0")
                                {
                                    it.SubItems.Add("准时到");
                                    on_time++;
                                }
                                else
                                {
                                    it.SubItems.Add("迟到");
                                    late++;
                                }
                            }
                            this.listViewInfo.Items.Add(it);
                        }
                        break;
                    }
                }
            }

        }



        private void cmBoxSno_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.labelName.Text = students[cmBoxSno.Text.ToString()].Key;
            this.labelGender.Text = students[cmBoxSno.Text.ToString()].Value;
        }
    }
}
