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
using ZedGraph;

namespace ArcSoftFace
{
    public partial class Teacher : Form
    {
        List<string> recordName = new List<string>();
        List<int> onTime = new List<int>();
        List<int> late = new List<int>();
        List<int> absent = new List<int>();
        Dictionary<string, string> Classes = new Dictionary<string, string>();
        public Teacher()
        {
            InitializeComponent();
            updateClass();
            foreach(var i in Classes.Keys)
            {
                this.cmBoxClass.Items.Add(i);
            }
            this.cmBoxClass.SelectedIndex = 0;
        }


        private void btnList_Click(object sender, EventArgs e)
        {
            ListWindow listview = new ListWindow(recordName, onTime, late, absent);
            listview.Show();
            this.groBox.Controls.Clear();
            this.groBox.Controls.Add(listview);
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


        private void update_data(string cno)
        {
            using (StreamReader sr = File.OpenText("..\\..\\..\\Database\\Class\\List\\" + cno + ".csv"))
            {
                string strLine = sr.ReadLine();
                string[] strArray = strLine.Split(',');
                int recordNum = strArray.Length / 2;
                this.recordName = new List<string>();
                this.onTime = new List<int>();
                this.late=new List<int>();
                this.absent = new List<int>();
                for(int i = 1; i < strArray.Length; i+=2)
                {
                    this.recordName.Add(strArray[i]);
                    this.onTime.Add(0);
                    this.late.Add(0);
                    this.absent.Add(0);
                }
                while ((strLine = sr.ReadLine()) != null)
                {
                    strArray = strLine.Split(',');

                    for (int i = 0, j = 1; i < recordNum; i++, j += 2)
                    {
                        if (strArray[j] == "0")
                        {
                            this.absent[i]++;
                        }
                        else
                        {
                            if (strArray[j + 1] == "0")
                            {
                                this.onTime[i]++;
                            }
                            else
                            {
                                this.late[i]++;
                            }
                        }

                    }

                }
            }
        }
        private void cmBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.labelClassName.Text = Classes[this.cmBoxClass.Text.ToString()];
            string cno = this.cmBoxClass.Text;
            update_data(cno);
        }

        private void btnPie_Click(object sender, EventArgs e)
        {
            PieGraph pie = new PieGraph(absent.Sum(),late.Sum(),onTime.Sum());
            pie.Show();
            this.groBox.Controls.Clear();
            this.groBox.Controls.Add(pie);
        }

        private void btnBar_Click(object sender, EventArgs e)
        {
            BarGraph bar = new BarGraph(recordName, late, absent, onTime);
            bar.Show();
            this.groBox.Controls.Clear();
            this.groBox.Controls.Add(bar);
        }
    }
}
