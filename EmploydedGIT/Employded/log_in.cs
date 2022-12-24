using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employded
{
    public partial class log_in : Form
    {
        
        DataBase dataBase = new DataBase();
        public log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void log_in_Load(object sender, EventArgs e)
        {
            login_text.MaxLength = 50;
            password_text.MaxLength = 50;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var LoginUser = login_text.Text;
            var PasswordUser = password_text.Text;
            dataBase.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(); 
            DataTable table = new DataTable();
            string querystring = $"SELECT idusers, login, password from register where login = '{LoginUser}' and password = '{PasswordUser}'";
            SqlCommand command1 = new SqlCommand(querystring, dataBase.getConnection() );
            command1.ExecuteNonQuery();
            adapter.SelectCommand = command1;
            adapter.Fill(table);
           
            if (table.Rows.Count == 1)
            {

               



                try
                {
                    string querystring2 = $"INSERT INTO session VALUES ('{LoginUser}',(SELECT department_name FROM register WHERE login = '{LoginUser}'))";

                    SqlCommand command2 = new SqlCommand(querystring2, dataBase.getConnection());
                    command2.ExecuteNonQuery();
                   

                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Ошибка, проверьте данные", "Неудачно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


              
             
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            StartForm frm1 = new StartForm();
            this.Hide();
            frm1.ShowDialog();
            this.Show();

                dataBase.closeConnection();
            }
        else
            MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register frm1 = new register();
            this.Hide();
            frm1.ShowDialog();
            this.Show();



        }
    }

}
