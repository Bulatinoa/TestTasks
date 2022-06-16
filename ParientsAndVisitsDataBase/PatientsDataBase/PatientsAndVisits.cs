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
using System.Xml.Linq;

namespace PatientsDataBase
{
    public partial class PatientsAndVisits : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;
        public PatientsAndVisits()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void createColumns()
        {
            dataGridView1.Columns.Add("id", "�� ��������");
            dataGridView1.Columns.Add("m_surname", "�������");
            dataGridView1.Columns.Add("m_name", "���");
            dataGridView1.Columns.Add("m_patronymic", "��������");
            dataGridView1.Columns.Add("date_of_birth", "���� ��������");
            dataGridView1.Columns.Add("mobile_number", "�������");
            dataGridView1.Columns.Add("id_visit", "�� ���������");
            dataGridView1.Columns.Add("date_of_visit", "���� ���������");
            dataGridView1.Columns.Add("diagnosis", "�������");
        }
        private void readSingleRow(DataGridView dwg, IDataRecord record)
        {
            dwg.Rows.Add(record.GetString(0), record.GetString(1),
                record.GetString(2), record.GetString(3),
                record.GetDateTime(4), record.GetString(5),
                record.GetString(6), record.GetDateTime(7),
                record.GetString(8));
        }
        private void refreshDataGrid(DataGridView dwg)
        {
            dwg.Rows.Clear();

            string queryString = $"select patients.id, patients.m_surname, patients.m_name," +
                $"patients.m_patronymic, patients.date_of_birth, patients.mobile_number," +
                $"visits.id_visit, visits.date_of_visit, visits.diagnosis " +
                $"from patients, visits " +
                $"where patients.id = visits.id";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
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

        private void btnXML_Click(object sender, EventArgs e)
        {

            int index = dataGridView1.CurrentCell.RowIndex;
            var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            var m_surname = dataGridView1.Rows[index].Cells[1].Value.ToString();
            var m_name = dataGridView1.Rows[index].Cells[2].Value.ToString();
            var m_patronymic = dataGridView1.Rows[index].Cells[3].Value.ToString();
            var date_of_birth = dataGridView1.Rows[index].Cells[4].Value.ToString();
            var mobile_number = dataGridView1.Rows[index].Cells[5].Value.ToString();
            var id_visit = dataGridView1.Rows[index].Cells[6].Value.ToString();
            var date_of_visit = dataGridView1.Rows[index].Cells[7].Value.ToString();
            var diagnosis = dataGridView1.Rows[index].Cells[8].Value.ToString();

            XDocument xdoc = new XDocument();

            XElement person = new XElement("person");
            XAttribute personIdAttr = new XAttribute("��_��������", id);
            XElement personSurnameElem = new XElement("�������", m_surname);
            XElement personNameElem = new XElement("���", m_name);
            XElement personPatronymicElem = new XElement("��������", m_patronymic);
            XElement personDateOfBirthElem = new XElement("����_��������", date_of_birth);
            XElement personMobileNumberElem = new XElement("�������", mobile_number);
            XElement personIdVisitElem = new XElement("��_���������", id_visit);
            XElement personDateOfVisitElem = new XElement("����_���������", date_of_visit);
            XElement personDiagnosisElem = new XElement("�������", diagnosis);

            person.Add(personIdAttr);
            person.Add(personSurnameElem);
            person.Add(personNameElem);
            person.Add(personPatronymicElem);
            person.Add(personDateOfBirthElem);
            person.Add(personMobileNumberElem);
            person.Add(personIdVisitElem);
            person.Add(personDateOfVisitElem);
            person.Add(personDiagnosisElem);

            xdoc.Add(person);
            xdoc.Save("person.xml");
        }
    }
}
