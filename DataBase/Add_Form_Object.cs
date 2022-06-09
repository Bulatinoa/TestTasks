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
    public partial class Add_Form_Object : Form
    {
        DataBase dataBase = new DataBase();
        public Add_Form_Object()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_aSave_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var a_type = textBox_a_type.Text;
            var a_product = textBox_a_product.Text;

            var addQuery = $"insert into m_objects (m_type, product) values ('{a_type}', '{a_product}')";

            var command = new SqlCommand(addQuery, dataBase.getConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Запись создана!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataBase.closeConnection();
        }
    }
}
