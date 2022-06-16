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

namespace PatientsDataBase
{
    public partial class Visits : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;
        public Visits()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void createColumns()
        {
            dataGridView1.Columns.Add("id_visit", "Ид посещения");
            dataGridView1.Columns.Add("date_of_visit", "Дата посещения");
            dataGridView1.Columns.Add("diagnosis", "Диагноз");
            dataGridView1.Columns.Add("id", "Ид Пациента");
        }

        private void readSingleRow(DataGridView dwg, IDataRecord record)
        {
            dwg.Rows.Add(record.GetString(0), record.GetDateTime(1),
                record.GetString(2), record.GetString(3));
        }

        private void refreshDataGrid(DataGridView dwg)
        {
            dwg.Rows.Clear();

            string queryString = $"select * from visits";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                readSingleRow(dwg, reader);
            }
            reader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createColumns();
            refreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox_id_visit.Text = row.Cells[0].Value.ToString();
                textBox_date_of_visit.Text = row.Cells[1].Value.ToString();
                textBox_diagnosis.Text = row.Cells[2].Value.ToString();
                textBox_id_p.Text = row.Cells[3].Value.ToString();
            }
                
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshDataGrid(dataGridView1);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Add_Visits addvisits = new Add_Visits();
            addvisits.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            int index = dataGridView1.CurrentCell.RowIndex;
            var id_p = dataGridView1.Rows[index].Cells[3].Value.ToString();

            var deleteQuery = $"delete from visits where id = '{id_p}'";

            dataGridView1.Rows[index].Visible = false;

            var command = new SqlCommand(deleteQuery, dataBase.getConnection());
            command.ExecuteNonQuery();

            dataBase.closeConnection();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id_visit = textBox_id_visit.Text; 
            var date_of_visit = textBox_date_of_visit.Text; 
            var diagnosis = textBox_diagnosis.Text; 
            var id_p = textBox_id_p.Text; 

            dataGridView1.Rows[selectedRowIndex].SetValues(id_visit, date_of_visit, diagnosis, id_p);

            var changeQuery = $"update visits set id_visit = '{id_visit}', date_of_visit = '{date_of_visit}'," +
                $"diagnosis = '{diagnosis}' where id = '{id_p}'";

            var command = new SqlCommand(changeQuery, dataBase.getConnection());
            command.ExecuteNonQuery();
        }
    }
}
