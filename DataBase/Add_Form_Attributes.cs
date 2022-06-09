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

namespace DataBase
{
    public partial class Add_Form_Attributes : Form
    {
        DataBase dataBase = new DataBase();
        public Add_Form_Attributes()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_aSave_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var a_name = textBox_a_name.Text;
            var a_value = textBox_a_value.Text;

            var addQuery = $"insert into attributes (m_name, m_value) values ('{a_name}', '{a_value}')";

            var command = new SqlCommand(addQuery, dataBase.getConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Запись создана!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataBase.closeConnection();
        }
    }
}
