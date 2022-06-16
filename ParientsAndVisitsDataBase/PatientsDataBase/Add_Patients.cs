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
    public partial class Add_Patients : Form
    {
        DataBase database = new DataBase();
        public Add_Patients()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var id_p = textBox_id_p2.Text;
            var m_surname = textBox_surname2.Text;
            var m_name = textBox_name2.Text;
            var m_patronymic = textBox_patronymic2.Text;
            var date_of_birth = textBox_date_of_birth2.Text.ToString();
            var mobile_number = textBox_mobile_number2.Text;

            var addQuery = $"insert into patients (id, m_surname, m_name, m_patronymic, date_of_birth, mobile_number)" +
                $"values ('{id_p}','{m_surname}','{m_name}','{m_patronymic}','{date_of_birth}','{mobile_number}')";

            var command = new SqlCommand(addQuery, database.getConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Запись успешно создана!","Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            database.closeConnection();
        }
    }
}
