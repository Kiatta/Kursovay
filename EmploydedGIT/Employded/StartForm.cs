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

    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class StartForm : Form
    {

        DataBase dataBase = new DataBase();
        private int selectedRow;

        public StartForm()
        {
            InitializeComponent();
            Gender_Combo.Items.Add(1);
            Gender_Combo.Items.Add(0);
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("employes_fio", "FIO");
            dataGridView1.Columns.Add("employes_amount_of_children", "Amount of Chil");
            dataGridView1.Columns.Add("department_name", "Department_name");
            dataGridView1.Columns.Add("employes_id", "ID");
            dataGridView1.Columns.Add("IsNew", "ModifiedNew");



        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {

        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string query = $"SELECT employes.employes_fio , ([employes].employes_amount_of_children)  , session.department_name, employes.employes_id \r\nFROM [employes]\r\nINNER JOIN [Emp_has_Dep]\r\nON employes.employes_id = [Emp_has_Dep].employes_id\r\nINNER JOIN department\r\nON Emp_has_Dep.department_id = department.department_id\r\nINNER JOIN session \r\nON department.department_name = session.department_name\r\nWHERE department.department_name = session.department_name\r\nORDER BY employes.employes_id";
            SqlCommand command = new SqlCommand(query, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[4]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();

            }
            reader.Close();
            foreach (string[] s in data)

            {
                dataGridView1.Rows.Add(s);


            }
            for (int intI = 0; intI < dataGridView1.Rows.Count; intI++)
            {
                for (int intJ = intI + 1; intJ < dataGridView1.RowCount; intJ++)
                {
                    if (dataGridView1.Rows[intJ].Cells[0].Value.ToString() == dataGridView1.Rows[intI].Cells[0].Value.ToString())
                    {
                        dataGridView1.Rows.RemoveAt(intJ);
                        intJ--;
                    }
                }
            }

        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);

        }


        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataBase.openConnection();

            string querystring = $"delete from session";
            SqlCommand commands = new SqlCommand(querystring, dataBase.getConnection());
            commands.ExecuteNonQuery();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                
                
                DataGridViewRow row2 = dataGridView1.Rows[selectedRow];
                
                var id = row2.Cells[3].Value.ToString();
                DataTable tad = new DataTable();
                string searchString2 = $"SELECT TOP (1) [employes_id],[employes_fio],[employes_pasp_data],[employes_birthday],[employes_gender],[employes_position],[employes_amount_of_children] FROM[Employes_View].[dbo].[employes] where employes_id = '{id}'";
                SqlCommand com2 = new SqlCommand(searchString2, dataBase.getConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(com2);
                adapter.SelectCommand = com2;
                adapter.Fill(tad);
               
                FIO_text.Text = row2.Cells[0].Value.ToString();
                Amount_text.Text = row2.Cells[1].Value.ToString();
                ID_text.Text = id;
                Pasp_text.Text = tad.Rows[0]["employes_pasp_data"].ToString();
                Birthday_text.Text = tad.Rows[0]["employes_birthday"].ToString();
                Position_text.Text = tad.Rows[0]["employes_position"].ToString();
                Gender_Combo.SelectedItem = tad.Rows[0]["employes_gender"].ToString();



            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Add_Form addFrm = new Add_Form();
            addFrm.Show();
        }


        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;
            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[4].Value = "Deleted";
                return;
            }
            dataGridView1.Rows[index].Cells[4].Value = "Deleted";

        }

        private void Update()
        {
            dataBase.openConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = dataGridView1.Rows[index].Cells[4].Value;
                if (rowState == "Existed")
                    continue;
                if (rowState == "Deleted")
                {
                    var id = Convert.ToString(dataGridView1.Rows[index].Cells[3].Value);
                    var delQuery = $"delete from Emp_Has_Dep where employes_id = {id}";
                    var command = new SqlCommand(delQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                    var delQuery1 = $"delete from Emp_Has_Chil where employes_id = {id}";
                    var command1 = new SqlCommand(delQuery1, dataBase.getConnection());
                    command1.ExecuteNonQuery();
                    var delQuery2 = $"delete from employes where employes_id = {id}";
                    var command2 = new SqlCommand(delQuery2, dataBase.getConnection());
                    command2.ExecuteNonQuery();
                }
                if (rowState == "Modified")
                    
                {
                    var id = dataGridView1.Rows[index].Cells[3].Value;
                    var fio = dataGridView1.Rows[index].Cells[0].Value;
                    var amount = dataGridView1.Rows[index].Cells[1].Value;
                    var department= dataGridView1.Rows[index].Cells[2].Value;
                    int Pasp;
                    var pos = Position_text.Text;
                    Gender_Combo.Items.Add(1);
                    Gender_Combo.Items.Add(0);
                    int combo;
                    string dr = "";
                    int birth;
                    int.TryParse(Birthday_text.Text, out birth);
                    int.TryParse(Pasp_text.Text, out Pasp);
                    int.TryParse(Gender_Combo.Text, out combo);
                    var changeQuery = $"UPDATE employes set employes_fio = '{fio}',employes_pasp_data = '{Pasp}',employes_birthday = '{birth}',employes_gender = '{combo}',employes_position = '{pos}',employes_amount_of_children = '{amount}' where employes_id ='{id}'" ;
                    var com = new SqlCommand(changeQuery, dataBase.getConnection());
                    com.ExecuteNonQuery();

                }
            }
            dataBase.openConnection();
        }


        private void Search(DataGridView dgw)
        {
            DataTable tad = new DataTable();
            dgw.Rows.Clear();
            dataBase.openConnection();
            string searchString = $"select employes_fio,employes_amount_of_children,employes_id from employes where concat ( employes_fio,  employes_amount_of_children,employes_id) like '%" + text_search.Text + "%'";
            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());
            com.ExecuteNonQuery();
            string searchString2 = $"SELECT department_name FROM session ";
            SqlCommand com2 = new SqlCommand(searchString2, dataBase.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(com2);
            adapter.SelectCommand = com2;
            adapter.Fill(tad);
            com2.ExecuteNonQuery();
            SqlDataReader read = com.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (read.Read())
            {
                data.Add(new string[4]);
                data[data.Count - 1][0] = read[0].ToString();
                data[data.Count - 1][1] = read[1].ToString();
                data[data.Count - 1][2] = tad.Rows[0]["department_name"].ToString();
                data[data.Count - 1][3] = read[2].ToString();
               

            }
            read.Close();
            foreach (string[] s in data)

            {
                dataGridView1.Rows.Add(s);

            }
            for (int intI = 0; intI < dataGridView1.Rows.Count; intI++)
            {
                for (int intJ = intI + 1; intJ < dataGridView1.RowCount; intJ++)
                {
                    if (dataGridView1.Rows[intJ].Cells[0].Value.ToString() == dataGridView1.Rows[intI].Cells[0].Value.ToString())
                    {
                        dataGridView1.Rows.RemoveAt(intJ);
                        intJ--;
                    }
                }
            }
        }


        private void Change() {
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
           
            var id =    ID_text.Text;
            var amount = Amount_text.Text;
            var fio = FIO_text.Text;
            Gender_Combo.Items.Add(1);
            Gender_Combo.Items.Add(0);
            string dr = "";
            int birth;
            string querystring = $"SELECT department_name from session";
            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows) // если есть данные
            {
                while (reader.Read())   // построчно считываем данные
                {
                    dr  = reader.GetValue(0).ToString();
                }
            }

            reader.Close();
            dataBase.closeConnection();
            if (row.Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(Birthday_text.Text, out birth))
                {
                    row.SetValues(fio, amount, dr, id, birth);
                    row.Cells[4].Value = "Modified";
                }
                else
                {
                    MessageBox.Show("День рождение =целое число!");

                } 
                }
            



            }
        
        private void text_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void search_btn_Click(object sender, EventArgs e)
        {

        }

        private void del_button_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void upd_button_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void Add_Chil_Click(object sender, EventArgs e)
        {
            Add_Chil addFrm = new Add_Chil();
            addFrm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlQuery addFrm2 = new SqlQuery();
            addFrm2.Show();

        }
    }
}
