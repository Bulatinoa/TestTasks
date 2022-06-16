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
    public partial class Add_Visits : Form
    {
        DataBase database = new DataBase();
        public Add_Visits()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var id_visit= textBox_id_visit2.Text;
            var date_of_visit = textBox_date_of_visit2.Text.ToString();
            var diagnosis = textBox_diagnosis2.Text;
            var id_p = textBox_id_p2.Text;

            var addQuery = $"insert into visits (id_visit, date_of_visit, diagnosis, id)" +
                $"values ('{id_visit}','{date_of_visit}','{diagnosis}','{id_p}')";

            var command = new SqlCommand(addQuery, database.getConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Запись успешно создана!","Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            database.closeConnection();
        }
    }
}
