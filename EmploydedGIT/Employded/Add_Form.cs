using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Employded
{
    public partial class Add_Form : Form
    {
        DataBase dataBase = new DataBase(); 
        public Add_Form()
        {
            InitializeComponent();
            StartPosition= FormStartPosition.CenterScreen;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            var fio = Fio_text.Text;
            var pasp = Pasport_data.Text;
            var birthday = BirthDay.Text;
            var position = Position.Text;
            int amount ;
            int gender =1;

           
            if (int.TryParse(Amount.Text, out amount)) 
            {
                var addQuery = $"insert into employes(employes_fio,employes_pasp_data,employes_birthday,employes_gender,employes_position,employes_amount_of_children) VALUES('{fio}','{pasp}','{birthday}','{gender}','{position}','{amount}')";
                var  comannd = new SqlCommand(addQuery, dataBase.getConnection()) ;
                comannd.ExecuteNonQuery() ;
                var addQuery2 = $"INSERT INTO Emp_has_Dep (employes_id,department_id, startWork,endWork) VALUES ((SELECT TOP 1  employes_id FROM employes ORDER BY employes_id DESC),(SELECT TOP 1 department_id from department\r\nINNER JOIN session\r\nON session.department_name = department.department_name) ,'2000-01-01','2010-01-01')";
                var comannd2 = new SqlCommand(addQuery2, dataBase.getConnection());
                comannd2.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана!!", "Усппех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Неудачно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataBase.closeConnection(); 
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            int gender;

            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                if (radioButton.Text == "Man")
                {
                    gender = 1;


                }
                else
                {
                    gender = 0;
                }
            }

        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            
            string querystring = $"SELECT department_name from session";
            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows) // если есть данные
            {
                while (reader.Read())   // построчно считываем данные
                {
                    label7.Text = reader.GetValue(0).ToString();
                }
            }
         
                    reader.Close();
            dataBase.closeConnection();

        }

        private void Add_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
