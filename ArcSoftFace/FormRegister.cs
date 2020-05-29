using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ArcSoftFace
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //SQLiteConnection.CreateFile("..\\..\\..\\Database\\Account.db");
            SQLiteConnection dbConnection;
            dbConnection = new SQLiteConnection("Data Source = ..\\..\\..\\Database\\Account.db");
            dbConnection.Open();
            //string sql1 = "create table Account (Identity TEXT, ID TEXT, Password TEXT)";
            //SQLiteCommand command1 = new SQLiteCommand(sql1, dbConnection);
            //command1.ExecuteNonQuery();
            string id = textBoxID.Text;
            string pw = textBoxPW.Text;
            string rw = textBoxRW.Text;
            string identity = comboBoxID.Text;
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = dbConnection;
            cmd.CommandText = "SELECT ID FROM Account WHERE ID == '" + id + "'";
            if(cmd.ExecuteScalar()!=null)
            {
                MessageBox.Show("您注册的账号已存在，请重新注册");
            }
            else
            {
                if(pw != rw)
                {
                    MessageBox.Show("两次输入的密码不同，请重新输入");
                }
                else
                {
                    SQLiteCommand command = new SQLiteCommand();
                    command.Connection = dbConnection;
                    command.CommandText = "INSERT INTO Account(Identity,ID,Password) VALUES(@Identity,@ID,@Password)";
                    command.Parameters.Add("Identity", DbType.String).Value = identity;
                    command.Parameters.Add("ID", DbType.String).Value = id;
                    command.Parameters.Add("Password", DbType.String).Value = pw;
                    command.ExecuteNonQuery();
                    MessageBox.Show("注册成功");
                }
            }
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            this.Dispose();
        }
    }
}
