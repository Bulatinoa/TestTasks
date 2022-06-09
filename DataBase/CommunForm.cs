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
    public partial class CommunForm : Form
    {
        DataBase dataBase = new DataBase();
        public CommunForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            createTreeView();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            createTreeView();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Add_Form_Commun addfrm = new Add_Form_Commun();
            addfrm.Show();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            treeView1.SelectedNode.ForeColor = Color.White; // не могу найти метод, чтобы скрыть элемент
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var index1 = treeView1.Nodes.IndexOf(treeView1.SelectedNode);
            string a = treeView1.Nodes[index1].Text;
            int index2 = Convert.ToInt32(a);
            var deleteQuery = $"delete from commun where idparent = {index2}";

            var command = new SqlCommand(deleteQuery, dataBase.getConnection());
            command.ExecuteNonQuery();

            dataBase.closeConnection();
        }

        private void createTreeView()
        {
            treeView1.Nodes.Clear();

            string queryString = $"select * from commun";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                TreeNode node = new TreeNode(reader["idparent"].ToString());
                node.Nodes.Add("idchild: " + reader["idchild"].ToString());
                node.Nodes.Add("linkname: " + reader["linkname"].ToString());

                treeView1.Nodes.Add(node);
            }
            reader.Close();
        }
    }
}
