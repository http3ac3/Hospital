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
    public partial class SetInfoForm : Form
    {
        SqlConnection connection;
        VisitInfo visitInfoForm;
        VisitInfo.SetMode mode;
        public SetInfoForm(SqlConnection connection, VisitInfo visitInfoForm, VisitInfo.SetMode mode)
        {
            this.connection = connection;
            this.visitInfoForm = visitInfoForm;
            this.mode = mode;
            InitializeComponent();
        }

        private void SetInfoForm_Load(object sender, EventArgs e)
        {
            switch (mode)
            {
                case VisitInfo.SetMode.PATIENT:
                    SqlDataAdapter adapter = new SqlDataAdapter("EXEC DisplayPatients", connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    InfoDGV.DataSource = ds.Tables[0];
                    break;
                case VisitInfo.SetMode.DOCTOR:
                    adapter = new SqlDataAdapter("EXEC DisplayDoctors", connection);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    InfoDGV.DataSource = ds.Tables[0];
                    break;
            }

        }

        private void InfoDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (mode)
            {
                case VisitInfo.SetMode.PATIENT:
                    string lastName = InfoDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string firstName = InfoDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string patronymic = InfoDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string passportSeries = InfoDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string passportNumber = InfoDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
                    visitInfoForm.FIOPatientTB.Text = $"{lastName} {firstName} {patronymic}";
                    visitInfoForm.PatientPassportSeriesTB.Text = passportSeries;
                    visitInfoForm.PatientPassportNumberTB.Text = passportNumber;
                    this.Close();
                    break;

                case VisitInfo.SetMode.DOCTOR:
                    lastName = InfoDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                    firstName = InfoDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                    patronymic = InfoDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                    passportSeries = InfoDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                    passportNumber = InfoDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
                    string specialization = InfoDGV.Rows[e.RowIndex].Cells[5].Value.ToString();

                    visitInfoForm.FIODoctorTB.Text = $"{lastName} {firstName} {patronymic}";
                    visitInfoForm.DoctorPassportSeriesTB.Text = passportSeries;
                    visitInfoForm.DoctorPassportNumberTB.Text = passportNumber;
                    visitInfoForm.SpecializationTB.Text = specialization;
                    this.Close();
                    break;
            }
            

        }
    }
}
