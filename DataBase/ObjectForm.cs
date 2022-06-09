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
    public partial class ObjectForm : Form
    {
        DataBase dataBase = new DataBase();
       
        public ObjectForm()
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
            Add_Form_Object afo = new Add_Form_Object();
            afo.Show();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            treeView2.SelectedNode.ForeColor = Color.White; // не могу найти метод, чтобы скрыть элемент
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var index1 = treeView2.Nodes.IndexOf(treeView2.SelectedNode);
            string a = treeView2.Nodes[index1].Text;
            int index2 = Convert.ToInt32(a);
            var deleteQuery = $"delete from m_objects where id = {index2}";

            var command = new SqlCommand(deleteQuery, dataBase.getConnection());
            command.ExecuteNonQuery();

            dataBase.closeConnection();
        }

        private void createTreeView()
        {
            treeView2.Nodes.Clear();

            string queryString = $"select * from m_objects";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                TreeNode node = new TreeNode(reader["id"].ToString());
                node.Nodes.Add("type: " + reader["m_type"].ToString());
                node.Nodes.Add("product: " + reader["product"].ToString());

                treeView2.Nodes.Add(node);
            }
            reader.Close();
        }
    }
}
