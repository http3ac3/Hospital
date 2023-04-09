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
    public partial class VisitInfo : Form
    {
        SqlConnection connection;
        AdminForm adminForm;
        
        string idVisit;

        public enum SetMode {PATIENT, DOCTOR};

        AdminForm.ViewMode mode;
        public VisitInfo(SqlConnection connection, AdminForm adminForm, AdminForm.ViewMode mode)
        {
            this.connection = connection;
            this.adminForm = adminForm;
            this.mode = mode;
            InitializeComponent();
        }
        public VisitInfo(SqlConnection connection, AdminForm adminForm, AdminForm.ViewMode mode, string idVisit)
        {
            this.connection = connection;
            this.adminForm = adminForm;
            this.mode = mode;
            this.idVisit = idVisit;
            InitializeComponent();
        }

        private void VisitInfo_Load(object sender, EventArgs e)
        {
            switch (mode)
            {
                case AdminForm.ViewMode.WATCH:
                    SetDoctorButton.Enabled = false;
                    SetPatientButton.Enabled = false;
                    AddVisitButton.Text = "Изменить информацию";

                    DataSet ds = adminForm.GetFilledDataSet($"EXEC FindVisitById {idVisit}");
                    DataRow row = ds.Tables[0].Rows[0];
                    FIOPatientTB.Text = row[1].ToString();
                    PatientPassportSeriesTB.Text = row[2].ToString();
                    PatientPassportNumberTB.Text = row[3].ToString();
                    DiseaseTB.Text = row[4].ToString();
                    StatusCB.SelectedItem = row[5].ToString();
                    VisitDateTB.Value = DateTime.Parse(row[6].ToString());
                    FIODoctorTB.Text = row[7].ToString();
                    SpecializationTB.Text = row[8].ToString();
                    DoctorPassportSeriesTB.Text = row[9].ToString();
                    DoctorPassportNumberTB.Text = row[10].ToString();
                    break;
                case AdminForm.ViewMode.ADD:
                    DiseaseTB.ReadOnly = false;
                    StatusCB.Enabled = true;
                    VisitDateTB.Enabled = true;
                    break;
            }

        }

        private void AddVisitButton_Click(object sender, EventArgs e)
        {
            if (AddVisitButton.Text == "Добавить посещение")
            {
                DataSet ds = adminForm.GetFilledDataSet($"SELECT id_patient FROM Patient WHERE " +
                       $"passport_number = '{PatientPassportNumberTB.Text}' AND passport_series = '{PatientPassportSeriesTB.Text}'");
                string idPatient = ds.Tables[0].Rows[0][0].ToString();

                ds = adminForm.GetFilledDataSet($"SELECT id_medical_card FROM Medical_Card WHERE id_patient = {idPatient}");
                string idMedicalCard = ds.Tables[0].Rows[0][0].ToString();

                ds = adminForm.GetFilledDataSet($"SELECT id_doctor FROM Doctor WHERE passport_number = '{DoctorPassportNumberTB.Text}' AND " +
                    $"passport_series = '{DoctorPassportSeriesTB.Text}'");

                string idDoctor = ds.Tables[0].Rows[0][0].ToString();

                string insertQuery = $"INSERT INTO Medical_Card_Doctor VALUES ({idMedicalCard}, {idDoctor}, '{VisitDateTB.Value.ToString("d")}', " +
                    $"'{DiseaseTB.Text}', '{StatusCB.SelectedItem}')";

                try
                {
                    new SqlCommand(insertQuery, connection).ExecuteNonQuery();
                    MessageBox.Show("Данные были успешно добавлены!", "Добаление посещения", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    adminForm.RefreshVisitsDGV();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (AddVisitButton.Text == "Изменить информацию")
            {
                AddVisitButton.Text = "Сохранить";
                SetPatientButton.Enabled = true;
                SetDoctorButton.Enabled = true;
                VisitDateTB.Enabled = true;
                StatusCB.Enabled = true;
                DiseaseTB.ReadOnly = false;
            }
            else if (AddVisitButton.Text == "Сохранить")
            {
                var res = MessageBox.Show("Вы уверены, что хотите применить изменения?", "Изменение информации", MessageBoxButtons.YesNoCancel,
                   MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    DataSet ds = adminForm.GetFilledDataSet($"SELECT id_patient FROM Patient WHERE " +
                        $"passport_number = '{PatientPassportNumberTB.Text}' AND passport_series = '{PatientPassportSeriesTB.Text}'");
                    string idPatient = ds.Tables[0].Rows[0][0].ToString();

                    ds = adminForm.GetFilledDataSet($"SELECT id_medical_card FROM Medical_Card WHERE id_patient = {idPatient}");
                    string idMedicalCard = ds.Tables[0].Rows[0][0].ToString();

                    ds = adminForm.GetFilledDataSet($"SELECT id_doctor FROM Doctor WHERE passport_number = '{DoctorPassportNumberTB.Text}' AND " +
                        $"passport_series = '{DoctorPassportSeriesTB.Text}'");

                    string idDoctor = ds.Tables[0].Rows[0][0].ToString();

                    string updateQuery = $"UPDATE Medical_Card_Doctor SET id_medical_card = {idMedicalCard}, id_doctor = {idDoctor}, " +
                        $"visit_date = '{VisitDateTB.Value.ToString("d")}', disease_name = '{DiseaseTB.Text}', patient_status = '{StatusCB.SelectedItem}' " +
                        $"WHERE id_medical_card_doctor = {idVisit}";
                    try
                    {
                        new SqlCommand(updateQuery, connection).ExecuteNonQuery();
                        MessageBox.Show("Данные были успешно обновлены!", "Обновление данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        adminForm.RefreshVisitsDGV();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (res == DialogResult.No)
                {
                    MessageBox.Show("Изменения не были сохранены!", "Изменение информации", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void SetPatientButton_Click(object sender, EventArgs e)
        {
            new SetInfoForm(connection, this, SetMode.PATIENT).Show();
        }

        private void SetDoctorButton_Click(object sender, EventArgs e)
        {
            new SetInfoForm(connection, this, SetMode.DOCTOR).Show();
        }
    }
}
