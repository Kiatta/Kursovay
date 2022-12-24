using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Employded
{
    public partial class register : Form
    {
        DataBase dataBases = new DataBase();
        public register()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void register_Load(object sender, EventArgs e)
        {
            login_text.MaxLength = 50;
            password_text.MaxLength = 50;

           

            DataTable tad = new DataTable();
        
            
                
                string querystring = "SELECT department.department_name from department";
                SqlCommand commands = new SqlCommand(querystring, dataBases.getConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(commands);
                adapter.SelectCommand = commands;
                adapter.Fill(tad);
            

            for (int i = 0; i < tad.Rows.Count; i++)
            {
                combo_dep.Items.Add(tad.Rows[i]["department_name"]);
            }
          
            dataBases.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var LoginUser = login_text.Text;
            var PasswordUser = password_text.Text;
            var Dep = combo_dep.Text;
            bool s = checkUser();
            try
            {

                string querystring1 = $"INSERT INTO [register](login,password,department_name) VALUES  ('{LoginUser}','{PasswordUser}','{Dep}')";
                SqlCommand command = new SqlCommand(querystring1, dataBases.getConnection());

                dataBases.openConnection();

                if (s==false)
                {
                    

                    MessageBox.Show("Вы успешно зарегестрировались!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    log_in frm1 = new log_in();
                    this.Close();
                    frm1.ShowDialog();
                    this.Show();
                }
                else {
                    MessageBox.Show("Неудачная регистрация!", "Попробуйте еще раз!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } }

            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Неудачная регистрация!", "Попробуйте еще раз!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 

                dataBases.closeConnection();
        }
        
       private Boolean checkUser()
        {
            var LoginUser = login_text.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select idusers, login, password from register where login = '{LoginUser}'";
            SqlCommand command = new SqlCommand(querystring, dataBases.getConnection());
            
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            log_in frm1 = new log_in();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
        }

        
    }
    }

