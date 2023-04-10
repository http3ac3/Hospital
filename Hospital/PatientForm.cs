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
    public partial class PatientForm : Form
    {
        SqlConnection connection;
        LoginForm loginForm;
        string passportSeries;
        string passportNumber;
        public PatientForm(SqlConnection connection,LoginForm loginForm, string passportSeries, string passportNumber)
        {
            this.loginForm = loginForm;
            this.connection = connection;
            this.passportSeries = passportSeries;
            this.passportNumber = passportNumber;
            InitializeComponent();
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("EXEC DisplayDoctorsToPatient", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DoctorsDGV.DataSource = ds.Tables[0];

            adapter = new SqlDataAdapter("EXEC DisplayRegistry", connection);
            ds = new DataSet();
            adapter.Fill(ds);
            RegistryDGV.DataSource = ds.Tables[0];
        }

        private void PatientForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void VisitListButton_Click(object sender, EventArgs e)
        {
            new VisitList(connection, passportSeries, passportNumber).Show();
        }

        private void VisitPriceButton_Click(object sender, EventArgs e)
        {
            new VisitPrice(connection, true).Show();
        }
    }
}
