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
    public partial class Patients : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;
        public Patients()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void createColumns()
        {
            dataGridView1.Columns.Add("id", "Ид пациента");
            dataGridView1.Columns.Add("m_surname", "Фамилия");
            dataGridView1.Columns.Add("m_name", "Имя");
            dataGridView1.Columns.Add("m_patronymic", "Отчество");
            dataGridView1.Columns.Add("date_of_birth", "Дата рождения");
            dataGridView1.Columns.Add("mobile_number", "Телефон");
        }

        private void readSingleRow(DataGridView dwg, IDataRecord record)
        {
                dwg.Rows.Add(record.GetString(0), record.GetString(1),
                    record.GetString(2), record.GetString(3),
                    record.GetDateTime(4), record.GetString(5));
        }

        private void refreshDataGrid(DataGridView dwg)
        {
            dwg.Rows.Clear();

            string queryString = $"select * from patients";

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

                textBox_id_p.Text = row.Cells[0].Value.ToString();
                textBox_surname.Text = row.Cells[1].Value.ToString();
                textBox_name.Text = row.Cells[2].Value.ToString();
                textBox_patronymic.Text = row.Cells[3].Value.ToString();
                textBox_date_of_birth.Text = row.Cells[4].Value.ToString();
                textBox_mobile_number.Text = row.Cells[5].Value.ToString();
            }
                
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshDataGrid(dataGridView1);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Add_Patients addpatients = new Add_Patients();
            addpatients.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            int index = dataGridView1.CurrentCell.RowIndex;
            var id_p = dataGridView1.Rows[index].Cells[0].Value.ToString();

            var deleteQuery = $"delete from patients where id = '{id_p}'";

            dataGridView1.Rows[index].Visible = false;

            var command = new SqlCommand(deleteQuery, dataBase.getConnection());
            command.ExecuteNonQuery();

            dataBase.closeConnection();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id_p = textBox_id_p.Text; 
            var m_surname = textBox_surname.Text; 
            var m_name = textBox_name.Text; 
            var m_patronymic = textBox_patronymic.Text; 
            var date_of_birth = textBox_date_of_birth.Text; 
            var mobile_number = textBox_mobile_number.Text; 

            dataGridView1.Rows[selectedRowIndex].SetValues(id_p, m_surname, m_name, m_patronymic, date_of_birth, mobile_number);

            var changeQuery = $"update patients set m_surname = '{m_surname}', m_name = '{m_name}'," +
                $"m_patronymic = '{m_patronymic}', date_of_birth = '{date_of_birth}', mobile_number = '{mobile_number}' where id = '{id_p}'";

            var command = new SqlCommand(changeQuery, dataBase.getConnection());
            command.ExecuteNonQuery();
        }
    }
}
