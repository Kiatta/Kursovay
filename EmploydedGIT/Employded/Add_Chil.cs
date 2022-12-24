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
using static System.Collections.Specialized.BitVector32;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Employded
{
    
    public partial class Add_Chil : Form
    {
       
        DataBase dataBase = new DataBase();
        int selectedRow2;
        public Add_Chil()
        {
            InitializeComponent();
        }
        private void CreateColumns()
        {
            dataGridView2.Columns.Add("childrens_id", "id");
            dataGridView2.Columns.Add("childrens_BirthSertNumber", "Birth Sert");
            dataGridView2.Columns.Add("childrens_name", "Name");
            dataGridView2.Columns.Add("childrens_birthday", "Birthday");
            dataGridView2.Columns.Add("IsNew", "ModifiedNew");

            DataGridViewColumn column = dataGridView2.Columns[3];
            column.Width = 200;

        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record) {
            dgw.Rows.Add(record.GetInt64(0), record.GetInt64(1), record.GetString(2), record.GetDateTime(3), "ModifiedNew");
        }
        private void ReadSingleRow2(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt64(0), record.GetInt64(1), record.GetString(2), record.GetInt64(3), "ModifiedNew");
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select childrens.childrens_id, childrens.childrens_BirthSertNumber, childrens.childrens_name , (  (DATEADD(S, CONVERT(int,LEFT(childrens.childrens_birthday, 10)), '1970-01-01'))) as childrens_birthday from childrens  INNER JOIN[Emp_has_Chil] ON childrens.childrens_id = Emp_has_Chil.childrens_id INNER JOIN employes ON Emp_has_Chil.employes_id = employes.employes_id INNER JOIN Emp_has_Dep ON Emp_has_Dep.employes_id = employes.employes_id INNER JOIN department ON Emp_has_Dep.department_id = department.department_id INNER JOIN session ON department.department_name = session.department_name ORDER BY childrens_id";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView2);
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Add_Chil_DB addFrm = new Add_Chil_DB();
            addFrm.Show();
        }

        private void del_button_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void upd_button_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void Add_Chil_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView2);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow2 = e.RowIndex;
            if (e.RowIndex >= 0)
            {


                DataGridViewRow row = dataGridView2.Rows[selectedRow2];


                ID_text.Text = row.Cells[0].Value.ToString();
                BirthSert_text.Text = row.Cells[1].Value.ToString();
                Name_Text.Text = row.Cells[2].Value.ToString();
                Birthday_text.Text = row.Cells[3].Value.ToString();


            }
        }
        private void deleteRow() {
            int index = dataGridView2.CurrentCell.RowIndex;
            dataGridView2.Rows[index].Visible = false;
            if (dataGridView2.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView2.Rows[index].Cells[4].Value = "Deleted";
                return;
            }
            dataGridView2.Rows[index].Cells[4].Value = "Deleted";
        }
        private void Update() {
            dataBase.openConnection();
            for (int index = 0; index < dataGridView2.Rows.Count; index++)
            {
                var rowState = dataGridView2.Rows[index].Cells[4].Value;
                if (rowState == "Existed")
                    continue;
                if (rowState == "Deleted")
                {
                    var id = Convert.ToInt64(dataGridView2.Rows[index].Cells[0].Value);
                    var deleteQuery1 = $"delete from Emp_has_Chil where childrens_id ='{id}'";
                    var com1 = new SqlCommand(deleteQuery1, dataBase.getConnection());
                    com1.ExecuteNonQuery();
                    var deleteQuery = $"delete from childrens where childrens_id ='{id}'";
                    var com = new SqlCommand(deleteQuery, dataBase.getConnection());
                    com.ExecuteNonQuery();
                }
                if (rowState == "Modified") {
                    var id = dataGridView2.Rows[index].Cells[0].Value.ToString();
                    var Birth = dataGridView2.Rows[index].Cells[1].Value.ToString();
                    var name = dataGridView2.Rows[index].Cells[2].Value.ToString();
                    var BirthDay = dataGridView2.Rows[index].Cells[3].Value.ToString();
           
                    var changeQuery = $"update childrens set childrens_BirthSertNumber = '{Birth}', childrens_name = '{name}', childrens_birthday =  (DATEDIFF(SECOND,"+"{d '1970-01-01'},"+$"'{BirthDay}'))   where childrens_id = '{id}'";
                    var command = new SqlCommand(changeQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                        }

}
            dataBase.closeConnection();
        }
        private void Change()
        {
            DataGridViewRow row = dataGridView2.Rows[selectedRow2];
            var id = ID_text.Text;
            var name = Name_Text.Text;
            var Birthday = Birthday_text.Text;
            int Birth;
            if (row.Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(BirthSert_text.Text, out Birth))
                {
                    row.SetValues(id, Birth, name, Birthday);
                    row.Cells[4].Value = "Modified";
                }
                else
                {
                    MessageBox.Show("Номер сертификата должен быть целым числом!");
                }
                }
            
        }


        private void Search(DataGridView dgw) {
            dgw.Rows.Clear();
           
            string searchString = $"select * from childrens where concat (childrens_id, childrens_BirthSertNumber, childrens_name, childrens_birthday) like '%" + text_search.Text + "%'";
            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read()) {
                ReadSingleRow2(dgw, read);
            }
            read.Close();
        }


    
        private void text_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView2);
        }
    }
}
