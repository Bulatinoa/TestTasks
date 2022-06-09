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
    public partial class Add_Form_Commun : Form
    {
        DataBase dataBase = new DataBase();
        public Add_Form_Commun()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_aSave_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var a_idparent = textBox_a_idparent.Text;
            var a_idchild = textBox_a_idchild.Text;
            var a_linkname = textBox_a_linkname.Text;

            var addQuery = $"insert into commun (idparent, idchild, linkname) values ('{a_idparent}', '{a_idchild}', '{a_linkname}')";

            var command = new SqlCommand(addQuery, dataBase.getConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Запись создана!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataBase.closeConnection();
        }
    }
}
