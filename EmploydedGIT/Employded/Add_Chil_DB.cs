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
    public partial class Add_Chil_DB : Form
    {
        DataBase dataBase = new DataBase();
        public Add_Chil_DB()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Add_Chil_DB_Load(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            int Birthsert;
            var name = Name_text.Text;
            var birthday = BirthDay_text.Text;
            if (int.TryParse(BirthSert_text.Text, out Birthsert))
            {
                var addQuery = $"insert into childrens(childrens_BirthSertNumber,childrens_name,childrens_birthday) VALUES('{Birthsert}','{name}','{birthday}')";
                var comannd = new SqlCommand(addQuery, dataBase.getConnection());
                comannd.ExecuteNonQuery();
                var addQuery2 = $"INSERT INTO Emp_has_Chil (employes_id,childrens_id) VALUES ((SELECT TOP 1 employes_id from employes),(SELECT TOP 1  childrens_id FROM childrens ORDER BY childrens_id DESC))";
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
    }
}
