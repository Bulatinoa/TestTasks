using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientsDataBase
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            Patients patients = new Patients();
            patients.Show();
        }

        private void btnVisits_Click(object sender, EventArgs e)
        {
            Visits visits = new Visits();
            visits.Show();
        }

        private void btnPandV_Click(object sender, EventArgs e)
        {
            PatientsAndVisits patientsAndVisits = new PatientsAndVisits();
            patientsAndVisits.Show();
        }
    }
}
