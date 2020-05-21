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
    public partial class FormDisplay : Form
    {
        public FormDisplay()
        {
            InitializeComponent();
        }


        //更新显示Presence和Absence
        void update_show()
        {
            List<string> preList = new List<string>();
            List<string> abeList = new List<string>();
            using (StreamReader sr = File.OpenText("..\\..\\..\\Database\\Class\\List\\" + ClassID.Text.ToString() + ".csv"))
            {
                string strLine = sr.ReadLine();
                string[] strArray = strLine.Split(',');
                string record = this.recordName.Text.ToString();
                //清空内容
                listPresence.Items.Clear();
                listAbsence.Items.Clear();
                //找到要查询的记录处于哪一列
                int col = 0;

                for (col = 0; col < strArray.Length; col++)
                {
                    if (strArray[col].Equals(record))
                    {
                        break;
                    }
                }
                if (col < strArray.Length)
                {
                    //如果col有效
                    while ((strLine = sr.ReadLine()) != null)
                    {
                        strArray = strLine.Split(',');
                        if (strArray[col] == "1")
                        {
                            preList.Add(strArray[0]);//讲学号加入出席学生名单
                        }
                        else
                        {
                            abeList.Add(strArray[0]);//讲学号加入未出席学生名单
                        }
                    }

                }

            }
            if (preList.Count > 0 || abeList.Count > 0)
            {
                //根据学号去找姓名
                using (StreamReader sr = File.OpenText("..\\..\\..\\Database\\Student\\Student.csv"))
                {
                    string strLine = sr.ReadLine();
                    string[] strArray;
                    while ((strLine = sr.ReadLine()) != null)
                    {
                        strArray = strLine.Split(',');
                        for (int i = 0; i < preList.Count; i++)
                        {
                            if (preList[i] == strArray[0])
                            {
                                preList[i] += strArray[1];
                                break;
                            }

                        }
                        for (int i = 0; i < abeList.Count; i++)
                        {
                            if (abeList[i] == strArray[0])
                            {
                                abeList[i] += strArray[1];
                                break;
                            }
                        }
                    }
                }

                foreach (string p in preList)
                {
                    this.listPresence.Items.Add(p);
                    this.listPresence.Items.Add("");//添加一个空行
                }

                foreach (string p in abeList)
                {
                    this.listAbsence.Items.Add(p);
                    this.listAbsence.Items.Add("");
                }
            }


        }




        public void setLabel(string ClassName, string ClassID, string RecordName)
        {

            this.ClassID.Text = ClassID;
            this.ClassName.Text = ClassName;
            this.recordName.Text = RecordName;
            update_show();
        }
    }
}

