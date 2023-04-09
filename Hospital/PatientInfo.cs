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
    public partial class PatientInfo : Form
    {
        SqlConnection connection;
        AdminForm adminForm;

        AdminForm.ViewMode mode;

        string idMedicalCard;
        string passportNumber;
        string passportSeries;

        public string id_registry;
        public PatientInfo(SqlConnection connection, AdminForm adminForm, AdminForm.ViewMode mode)
        {
            this.connection = connection;
            this.adminForm = adminForm;
            this.mode = mode;
            InitializeComponent();
        }
        public PatientInfo(SqlConnection connection, AdminForm adminForm, AdminForm.ViewMode mode, string passportSeries, string passportNumber)
        {
            this.connection = connection;
            this.adminForm = adminForm;
            this.mode = mode;
            this.passportNumber = passportNumber;
            this.passportSeries = passportSeries;
            InitializeComponent();
        }

        private void PatientInfo_Load(object sender, EventArgs e)
        {
            switch (mode)
            {
                case AdminForm.ViewMode.WATCH:
                    foreach (var tb in this.Controls.OfType<TextBox>()) tb.ReadOnly = true;
                    foreach (var mtb in this.Controls.OfType<MaskedTextBox>()) mtb.ReadOnly = true;
                    BirthdayTB.Enabled = false;
                    RegDateTB.Enabled = false;
                    SexCB.Enabled = false;
                    MCTypeCB.Enabled = false;
                    VisitListButton.Visible = true;
                    // AddButton.Visible = true;
                    AddButton.Text = "Изменить";

                    SqlDataAdapter adapter = new SqlDataAdapter($"EXEC FindPatientByPassportNumber '{passportSeries}', {passportNumber}", connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    DataRow row = ds.Tables[0].Rows[0];
                    LastNameTextBox.Text = row[1].ToString();
                    FirstNameTextBox.Text = row[2].ToString();
                    PatronymicTextBox.Text = row[3].ToString();
                    SexCB.SelectedItem = row[4].ToString();
                    BirthdayTB.Value = DateTime.Parse(row[5].ToString());
                    PassportSeriesTB.Text = passportSeries;
                    PasssportNumberTB.Text = passportNumber;
                    PhoneNumberTextBox.Text = row[8].ToString();
                    SnilsTB.Text = row[9].ToString();
                    PolicyTB.Text = row[10].ToString();

                    idMedicalCard = row[11].ToString();
                    RegDateTB.Value = DateTime.Parse(row[12].ToString());
                    MCTypeCB.SelectedItem = row[13].ToString();

                    ds = adminForm.GetFilledDataSet($"SELECT id_registry, registration_type FROM Registry_Patient WHERE id_patient = {row[0]}");
                    id_registry = row[0].ToString();
                    ds = adminForm.GetFilledDataSet($"SELECT * FROM Registry WHERE id_registry = {ds.Tables[0].Rows[0][0]}");
                    row = ds.Tables[0].Rows[0];
                    RegistryTB.Text = $"{row[1]}, {row[2]}, {row[3]}, {row[4]}, {row[5]}";
                    break;
                case AdminForm.ViewMode.ADD:
                    ChangeRegistryButton.Enabled = true;
                    SexCB.SelectedIndex = 0;
                    BirthdayTB.Value = DateTime.Parse("01-01-1990");
                    MCTypeCB.SelectedIndex = 0;
                    this.Text = "Добавление пацента";

                    break;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string patronymic = PatronymicTextBox.Text;
            patronymic = (patronymic == "" ? "NULL" : $"\'{patronymic}\'");

            if (AddButton.Text == "Добавить")
            {
                string insertPatinetQuery = $"INSERT INTO Patient VALUES ('{LastNameTextBox.Text}', '{FirstNameTextBox.Text}', {patronymic}," +
                    $"'{SexCB.SelectedItem}', '{BirthdayTB.Value.ToString("d")}', '{PassportSeriesTB.Text}', '{PasssportNumberTB.Text}'," +
                    $"'{PhoneNumberTextBox.Text}', '{SnilsTB.Text}', '{PolicyTB.Text}')";
                
                try
                {
                    
                    new SqlCommand(insertPatinetQuery, connection).ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT TOP 1 id_patient FROM Patient ORDER BY id_patient DESC", connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    
                    string idNewPatient = ds.Tables[0].Rows[0][0].ToString();

                    string insertMCQuery = $"INSERT INTO Medical_Card VALUES ('{RegDateTB.Value}', '{MCTypeCB.SelectedItem}', {idNewPatient})";
                    new SqlCommand(insertMCQuery, connection).ExecuteNonQuery();

                    string insertRPQuery = $"INSERT INTO Registry_Patient VALUES ( {id_registry}, {idNewPatient}, " +
                        $" '{(MCTypeCB.SelectedItem.ToString() == "Физическая" ? "В больнице" : "онлайн")}')";
                    new SqlCommand(insertRPQuery, connection).ExecuteNonQuery();

                    MessageBox.Show("Данные были успешно добавлены!", "Добаление пациента", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    adminForm.RefreshPatientsDGV();
                    adminForm.RefreshMedicalCardsDGV();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            
            else if (AddButton.Text == "Изменить")
            {
                foreach (var tb in this.Controls.OfType<TextBox>()) tb.ReadOnly = false;
                foreach (var mtb in this.Controls.OfType<MaskedTextBox>()) mtb.ReadOnly = false;
                RegistryTB.ReadOnly = true;
                ChangeRegistryButton.Enabled = true;
                BirthdayTB.Enabled = true;
                RegDateTB.Enabled = true;
                SexCB.Enabled = true;
                MCTypeCB.Enabled = true;
                AddButton.Text = "Сохранить";
            }
            
            else if (AddButton.Text == "Сохранить")
            {
                var res = MessageBox.Show("Вы уверены, что хотите применить изменения?", "Изменение информации", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);
                
                if (res == DialogResult.Yes)
                {
                    string updateQuery = $"UPDATE Patient SET last_name = '{LastNameTextBox.Text}', first_name = '{FirstNameTextBox.Text}'," +
                        $"patronymic = {patronymic}, gender = '{SexCB.SelectedItem}', birthday_date = '{BirthdayTB.Value.ToString("d")}', " +
                        $"passport_series = '{PassportSeriesTB.Text}', passport_number = '{PasssportNumberTB.Text}', " +
                        $"phone_number = '{PhoneNumberTextBox.Text}', snils = '{SnilsTB.Text}', policy_number = '{PolicyTB.Text}' " +
                        $"WHERE passport_series = '{passportSeries}' AND passport_number = '{passportNumber}'";
                     
                    string updateMCQuery = $"UPDATE Medical_Card SET registration_date = '{RegDateTB.Value.ToString("d")}', " +
                        $"medical_card_type = '{MCTypeCB.SelectedItem}' WHERE id_medical_card = {idMedicalCard}";


                    DataSet ds = adminForm.GetFilledDataSet($"SELECT id_patient FROM Patient WHERE passport_number = '{passportNumber}' AND " +
                        $"passport_series = '{passportSeries}'");
                    string id_patient = ds.Tables[0].Rows[0][0].ToString();
                    string updateRPQuery = $"UPDATE Registry_Patient SET id_registry = {id_registry}, id_patient = {id_patient}, " +
                        $"registration_type = '{(MCTypeCB.SelectedItem.ToString() == "Физическая" ? "В больнице" : "онлайн")}' WHERE id_patient = {id_patient}";

                    try
                    {
                        new SqlCommand(updateQuery, connection).ExecuteNonQuery();
                        new SqlCommand(updateMCQuery, connection).ExecuteNonQuery();
                        new SqlCommand(updateRPQuery, connection).ExecuteNonQuery();
                        MessageBox.Show("Данные были успешно обновлены!", "Изменение информации", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        adminForm.RefreshPatientsDGV();
                        adminForm.RefreshMedicalCardsDGV();
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

        private void ChangeRegistryButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new SetRegistry(connection, this).Show();
        }

        private void VisitListButton_Click(object sender, EventArgs e)
        {
            new VisitList(connection, passportSeries, passportNumber).Show();
        }
    }
}
