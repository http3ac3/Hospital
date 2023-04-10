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

        VisitPrice visitPrice;
        bool isSetPrice;
        public SetInfoForm(SqlConnection connection, VisitInfo visitInfoForm, VisitInfo.SetMode mode)
        {
            this.connection = connection;
            this.visitInfoForm = visitInfoForm;
            this.mode = mode;
            InitializeComponent();
        }

        public SetInfoForm(SqlConnection connection, VisitPrice visitPrice, bool isSetPrice)
        {
            this.connection = connection;
            this.visitPrice = visitPrice;
            this.isSetPrice = isSetPrice;
            this.mode = VisitInfo.SetMode.DOCTOR;
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
                    InfoDGV.Dock = DockStyle.Fill;
                    InfoDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    if (visitPrice.isVisiter)
                    {
                        InfoDGV.Columns[3].Visible = false;
                        InfoDGV.Columns[4].Visible = false;
                    }
                    break;
            }

        }

        private void InfoDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isSetPrice)
            {
                string lastName = InfoDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                string firstName = InfoDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                string patronymic = InfoDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                string specialization = InfoDGV.Rows[e.RowIndex].Cells[5].Value.ToString();
                visitPrice.FIODoctorTB.Text = $"{lastName} {firstName} {patronymic}";
                visitPrice.SpecializationTB.Text = specialization;
                this.Close();
                return;
            }    
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
