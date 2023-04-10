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

namespace Hospital
{
    public partial class AdminForm : Form
    {
        SqlConnection connection;
        LoginForm loginForm;
        public enum ViewMode { WATCH, ADD, EDIT };
        public enum DeleteObject { PATIENT, DOCTOR, REGISTRY, VISIT}

        public AdminForm(SqlConnection connection, LoginForm loginForm)
        {
            this.connection = connection;
            this.loginForm = loginForm;
            InitializeComponent();
        }
        public DataSet GetFilledDataSet(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet;
        }

        public void RefreshDoctorsDGV() => DoctorsDGV.DataSource = GetFilledDataSet("EXEC DisplayDoctors").Tables[0];
        public void RefreshPatientsDGV() => PatientsDGV.DataSource = GetFilledDataSet("EXEC DisplayPatients").Tables[0];
        public void RefreshVisitsDGV() => VisitsDGV.DataSource = GetFilledDataSet("EXEC DisplayVisits").Tables[0];
        public void RefreshRegistryDGV() => RegistryDGV.DataSource = GetFilledDataSet("EXEC DisplayRegistry").Tables[0];
        public void RefreshMedicalCardsDGV() => MedicalCardsDGV.DataSource = GetFilledDataSet("EXEC DisplayMedicalCards").Tables[0];
        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                loginForm.Close();
                connection.Close();
            }
            else
                e.Cancel = true;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            
            RefreshDoctorsDGV();
            RefreshPatientsDGV();
            RefreshVisitsDGV();
            RefreshRegistryDGV();
            RefreshMedicalCardsDGV();
            VisitsDGV.Columns[0].Visible = false;
            RegistryDGV.Columns[0].Visible = false;
        }

        private void AddDoctorButton_Click(object sender, EventArgs e)
        {
            new DoctorInfo(connection, this, ViewMode.ADD).Show();
        }

        private void DoctorsDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string passportSeries = DoctorsDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            string passportNumber = DoctorsDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            new DoctorInfo(connection, this, ViewMode.WATCH, passportSeries, passportNumber).Show();
        }

        private void PatientsDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string passportSeries = PatientsDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            string passportNumber = PatientsDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            new PatientInfo(connection, this, ViewMode.WATCH, passportSeries, passportNumber).Show();
        }

        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            new PatientInfo(connection, this, ViewMode.ADD).Show();
        }

        private void VisitsDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = VisitsDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            new VisitInfo(connection, this, ViewMode.WATCH, id).Show();
        }

        private void NewVisitButton_Click(object sender, EventArgs e)
        {
            new VisitInfo(connection, this, ViewMode.ADD).Show();
        }

        private void RegistryDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = RegistryDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            new RegistryInfo(connection, this, ViewMode.WATCH, id).Show();
        }

        private void AddRegistryButton_Click(object sender, EventArgs e)
        {
            new RegistryInfo(connection, this, ViewMode.ADD).Show();
        }

        private void DeleteDoctorButton_Click(object sender, EventArgs e)
        {
            new DeleteInfo(connection, this, DeleteObject.DOCTOR).Show();
        }

        private void DeletePatientButton_Click(object sender, EventArgs e)
        {
            new DeleteInfo(connection, this, DeleteObject.PATIENT).Show();
        }

        private void DeleteRegistryButton_Click(object sender, EventArgs e)
        {
            new DeleteInfo(connection, this, DeleteObject.REGISTRY).Show();
        }

        private void посещениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DeleteInfo(connection, this, DeleteObject.VISIT).Show();
        }

        private void GetPriceButton_Click(object sender, EventArgs e)
        {
            new VisitPrice(connection, false).Show();
        }
    }
}
