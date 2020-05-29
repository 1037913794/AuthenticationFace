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
    public partial class FormClass : Form
    {
        public FormClass()
        {
            InitializeComponent();
            show_classes();
        }

        private void new_edit_Click(object sender, EventArgs e)
        {
            update(this.textClassNo.Text.ToString(), this.textClassName.Text.ToString());
        }

        private void show_classes()
        {//更新课程列表
            listClasses.Items.Clear();
            using (StreamReader sr = File.OpenText("..\\..\\..\\Database\\Class\\Class.csv"))
            {
                string strLine = sr.ReadLine();
                string[] strArray;
                while ((strLine = sr.ReadLine()) != null)
                {
                    strArray = strLine.Split(',');
                    listClasses.Items.Add(strArray[0] + " " + strArray[1]);
                }
            }
        }

        private void update(string newCno, string newCname)
        {
            string[] classes;
            string path_class = "..\\..\\..\\Database\\Class\\Class.csv";
            if (!File.Exists(path_class))
            {//文件不存在则创建
                using (StreamWriter sw = File.CreateText(path_class))
                {
                    sw.WriteLine(newCno + ',' + newCname + ',' + "0");
                }
            }
            try
            {
                int flag = 0;//指示课程是否存在与课程表中
                classes = File.ReadAllLines(path_class);
                for (int i = 0; i < classes.Length; i++)
                {
                    string Cno = classes[i].Split(',')[0];
                    if (Cno == newCno)
                    {//找到课程号，对应Edit操作
                        classes[i] = newCno + ',' + newCname + ',' + classes[i].Split(',')[2];
                        flag = 1;
                        break;
                    }
                }
                if (flag == 1)
                {
                    File.WriteAllLines(path_class, classes);
                    show_classes();
                    MessageBox.Show($"Edit success!");
                }
                else
                {//不存在则对应new操作
                    using (StreamWriter sw = File.AppendText(path_class))
                    {
                        sw.WriteLine(newCno + ',' + newCname + ',' + "0");
                        MessageBox.Show($"Add success!");
                    }
                    show_classes();
                    using (StreamWriter sw = new StreamWriter("..\\..\\..\\Database\\Class\\List\\" + newCno + ".csv"))
                    {//创建List.csv
                        string text = "sno";
                        text += "\r\n";
                        sw.Write(text);
                    }
                }
                
                
            }
            catch (Exception)
            {

            }
        }

    }
}
