using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCommuns_Click(object sender, EventArgs e)
        {
            CommunForm cmn = new CommunForm();
            cmn.Show();
        }

        private void btnObjects_Click(object sender, EventArgs e)
        {
            ObjectForm obf = new ObjectForm();
            obf.Show();
        }

        private void btnAttributes_Click(object sender, EventArgs e)
        {
            AttributesForm abf = new AttributesForm();
            abf.Show();
        }
    }
}
