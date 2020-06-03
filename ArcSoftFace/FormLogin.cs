using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcSoftFace
{
    public partial class FormLogin : Form
    {
        public static string identity;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            string pw = textBoxPW.Text;
            bool idfind = false;
            SQLiteConnection dbConnection;
            dbConnection = new SQLiteConnection("Data Source = ..\\..\\..\\Database\\Account.db");
            dbConnection.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = dbConnection;
            cmd.CommandText = "SELECT * FROM Account";
            if(cmd.ExecuteScalar() != null)
            {
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if(reader[1].ToString() == id)
                    {
                        idfind = true;
                        if (reader[2].ToString() == pw)
                        {
                            identity = reader[0].ToString();
                            this.Hide();
                            AuthenticationForm authenticationForm = new AuthenticationForm();
                            authenticationForm.ShowDialog();
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("密码错误，请重新输入");
                        }
                    }
                }
                if(!idfind)
                {
                    MessageBox.Show("该账号不存在");
                }
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister formRegister = new FormRegister();
            formRegister.ShowDialog();
            this.Dispose();
        }
    }
}
