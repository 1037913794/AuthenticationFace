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
    public partial class FormRecord : Form
    {
        private string className, classID;
        public FormRecord(string className,string classID)
        {
            InitializeComponent();
            this.className = className;
            this.classID = classID;
            setLabel(className, classID);
            show_records();
        }

        public void setLabel(string className,string classID) {
            this.labelClassName.Text = className;
            this.labelClassID.Text = classID;
        }

        private void show_records()
        {
            listPreRecord.Items.Clear();
            using (StreamReader sr = File.OpenText("..\\..\\..\\Database\\Class\\List\\" + classID + ".csv")) {
                string[] strArray = sr.ReadLine().Split(',');
                if (strArray.Length > 1)
                {
                    for (int i = 1; i < strArray.Length; i++)
                    {
                        listPreRecord.Items.Add(strArray[i]);
                    }
                }
            }
               
        }

        private void btnCreat_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.txtRecordName.Text.ToString()!= "")
            {
                update_records(this.txtRecordName.Text.ToString());
            }
           
        }

        private void btnCancel_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void update_records(string newRecords) {
            string[] records;
            try
            {
                records=File.ReadAllLines("..\\..\\..\\Database\\Class\\List\\" + this.labelClassID.Text.ToString() + ".csv");
                string[] recordName = records[0].Split(',');
                bool canCreat = false;
                if (recordName.Length > 1)
                {
                    if (recordName.Contains(newRecords))
                    {
                        //记录不可以重名
                        canCreat = false;
                    }
                    else
                    {
                        canCreat = true;
                    }

                }
                else
                {
                    canCreat = true;
                }

                if (!canCreat)
                {
                    MessageBox.Show($"{newRecords} already exits,please choose another name.");
                }
                else
                {
                    //更新课程对应的csv，初始新纪录所有人没有考勤
                    records[0] += "," + newRecords;
                    for(int i = 1; i < records.Length; i++)
                    {
                        records[i] += "," + "0";
                    }
                    File.WriteAllLines("..\\..\\..\\Database\\Class\\List\\" + classID + ".csv", records);

                    //更新class表中课程对应的recordNum
                    string[] classes = File.ReadAllLines("..\\..\\..\\Database\\Class\\Class.csv");
                    for(int i = 0; i < classes.Length; i++)
                    {
                        if (classes[i].Split(',')[0] == classID)
                        {
                            var info = classes[i].Split(',');
                            info[info.Length - 1] = (int.Parse(info[info.Length - 1]) + 1).ToString();
                            classes[i] = string.Join(",", info);
                            break;

                        }
                    }
                    File.WriteAllLines("..\\..\\..\\Database\\Class\\Class.csv", classes);
                    show_records();
                }


            }
            catch (Exception) { 
            
            
            }

               
        }
    }
}
