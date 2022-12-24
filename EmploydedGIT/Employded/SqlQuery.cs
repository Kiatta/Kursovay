using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Employded
{
    public partial class SqlQuery : Form
    {
        DataBase dataBase = new DataBase();
        public SqlQuery()
        {
            InitializeComponent();
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            string str = userSqlCommandCheck();
            if (str == "ok")
            {
                try
                {
                    SqlCommand com2 = new SqlCommand(textBox_query.Text, dataBase.getConnection());
                    dataBase.openConnection();
                    textBox_query.Text = "Команда успешно выполнена";
                    using (var reader = com2.ExecuteReader())
                    {
                        DataTable table = new DataTable();
                        table.Load(reader);
                        dataGridView_query.DataSource = table;
                    }

                    }
                catch (System.Data.SqlClient.SqlException)
                {
                    textBox_query.ForeColor = System.Drawing.Color.Red;
                    textBox_query.Text = "Неправильно введена SQL инструкция";
                }
            }
            else
            {
                MessageBox.Show("Вы  не можете использовать команду " + str, "Ошибка");
            }
            dataBase.closeConnection();
        }

        private string userSqlCommandCheck()
        {
            string check = "ok";
          
                string[] fobidenComands = { "insert", "delete", "update", "drop" };
                string str = textBox_query.Text.ToLower();
                for (int i = 0; i < fobidenComands.Length; i++)
                {
                    if (str.Contains(fobidenComands[i]))
                    {
                        check = fobidenComands[i];
                    }
                }
            
            return check;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_query.Text = "SELECT employes.employes_id,employes_fio,employes_pasp_data, employes_gender, Emp_has_dep.endWork   FROM employes INNER JOIN Emp_has_Dep ON Emp_has_Dep.employes_id = employes.employes_id INNER JOIN department ON Emp_has_Dep.department_id = department.department_id WHERE department_name = 'Crazy' and Emp_has_Dep.startWork > '2010-10-10' ORDER BY employes_birthday";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            textBox_query.Text = "SELECT employes.employes_id,employes_fio,employes_pasp_data, employes_amount_of_children, department_id FROM employes  INNER join Emp_has_Dep ON employes.employes_id = Emp_has_Dep.employes_id WHERE employes_amount_of_children> 1 ORDER BY department_id";
            DataTable tad = new DataTable();
            string querystring = " SELECT department.department_id FROM session INNER JOIN department ON session.department_name=department.department_name";
            SqlCommand commands = new SqlCommand(querystring, dataBase.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(commands);
            adapter.SelectCommand = commands;
            adapter.Fill(tad);

            var s = tad.Rows[0]["department_id"].ToString();



            commands.ExecuteNonQuery();

            var stQuery = "SELECT AVG(DATEDIFF("+"YYYY"+$", (DATEADD(S, CONVERT(int,LEFT(employes_birthday, 10)), '1970-01-01')) , GETDATE())) as department_age_avg FROM employes INNER join Emp_has_Dep ON employes.employes_id = Emp_has_Dep.employes_id WHERE Emp_has_Dep.department_id = '{s}'";
            SqlCommand com2 = new SqlCommand(stQuery, dataBase.getConnection());
            
            using (var reader = com2.ExecuteReader())
            {
                DataTable table = new DataTable();
                table.Load(reader);
                dataGridView_query.DataSource = table;
            }
            dataBase.closeConnection(); 
        }

        private void SqlQuery_Load(object sender, EventArgs e)
        {

        }
    }
}
