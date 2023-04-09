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
    public partial class DoctorInfo : Form
    {
        
        SqlConnection connection;
        AdminForm adminForm;

        AdminForm.ViewMode mode;

        string passportNumber;
        string passportSeries;
        public DoctorInfo(SqlConnection connection, AdminForm adminForm, AdminForm.ViewMode mode)
        {
            this.connection = connection;
            this.adminForm = adminForm;
            this.mode = mode;
            InitializeComponent();
        }

        public DoctorInfo(SqlConnection connection, AdminForm adminForm, AdminForm.ViewMode mode, string passportSeries, string passportNumber)
        {
            this.connection = connection;
            this.adminForm = adminForm;
            this.mode = mode;
            this.passportNumber = passportNumber;
            this.passportSeries = passportSeries;
            InitializeComponent();
        }

        private void DoctorInfo_Load(object sender, EventArgs e)
        {
            switch (mode)
            {
                case AdminForm.ViewMode.WATCH:

                    foreach (var tb in this.Controls.OfType<TextBox>()) tb.ReadOnly = true;
                    foreach (var mtb in this.Controls.OfType<MaskedTextBox>()) mtb.ReadOnly = true;
                    VisitCostTB.ReadOnly = true;
                    BirthdayTB.Enabled = false;
                    SexCB.Enabled = false;
                    AddButton.Visible = true;
                    AddButton.Text = "Изменить";

                    SqlDataAdapter adapter = new SqlDataAdapter($"EXEC FindDoctorByPassport '{passportSeries}', '{passportNumber}'", connection);
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
                    SpecializationTB.Text = row[9].ToString();
                    VisitCostTB.Value = Convert.ToDecimal(row[10].ToString());
                    CabinetNumberTB.Text = row[11].ToString();
                    WorkStartTB.Text = row[12].ToString().Substring(0, 5);
                    WorkEndTB.Text = row[13].ToString().Substring(0, 5);

                    int i = 20;
                    foreach (var checkBox in groupBox1.Controls.OfType<CheckBox>())
                    {
                        checkBox.Enabled = false;
                        if (row[i].ToString() == "да") checkBox.Checked = true;
                        i--;
                    }
                    break;
                case AdminForm.ViewMode.ADD:
                    AddButton.Visible = true;
                    this.Text = "Добавление врача";
                    SexCB.SelectedIndex = 0;
                    WorkStartTB.Text = "08:00";
                    WorkEndTB.Text = "17:00";
                    BirthdayTB.Value = DateTime.Parse("01-01-1990");
                    foreach (var checkBox in groupBox1.Controls.OfType<CheckBox>())
                    {
                        checkBox.Checked = true;
                    }
                    break;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string patronymic = PatronymicTextBox.Text;
            patronymic = (patronymic == "" ? "NULL" : $"\'{patronymic}\'");

            if (AddButton.Text == "Добавить")
            {
                string insertQuery = $"INSERT INTO Doctor VALUES ('{LastNameTextBox.Text}', '{FirstNameTextBox.Text}', {patronymic}," +
                    $"'{SexCB.SelectedItem}', '{BirthdayTB.Value.ToString("d")}', '{PassportSeriesTB.Text}', '{PasssportNumberTB.Text}'," +
                    $"'{PhoneNumberTextBox.Text}', '{SpecializationTB.Text}', {VisitCostTB.Value.ToString().Replace(",", ".")}," +
                    $"{CabinetNumberTB.Text}, '{WorkStartTB.Text}', '{WorkEndTB.Text}', '{(WorkMondayCB.Checked ? "да" : "нет")}', " +
                    $"'{(WorkTuesdayCB.Checked ? "да" : "нет")}', '{(WorkWednesdayCB.Checked ? "да" : "нет")}', '{(WorkThursdayCB.Checked ? "да" : "нет")}'," +
                    $"'{(WorkFridayCB.Checked ? "да" : "нет")}', '{(WorkSaturdayCB.Checked ? "да" : "нет")}', '{(WorkSundayCB.Checked ? "да" : "нет")}')";
                try
                {
                    new SqlCommand(insertQuery, connection).ExecuteNonQuery();
                    MessageBox.Show("Данные были успешно добавлены!", "Добаление доктора", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    adminForm.RefreshDoctorsDGV();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (AddButton.Text == "Изменить")
            {
                AddButton.Text = "Сохранить";
                foreach (var tb in this.Controls.OfType<TextBox>()) tb.ReadOnly = false;
                foreach (var mtb in this.Controls.OfType<MaskedTextBox>()) mtb.ReadOnly = false;
                foreach (var checkBox in groupBox1.Controls.OfType<CheckBox>()) checkBox.Enabled = true;
                
                VisitCostTB.ReadOnly = false;
                BirthdayTB.Enabled = true;
                SexCB.Enabled = true;
            }
            else if (AddButton.Text == "Сохранить")
            {
                var res = MessageBox.Show("Вы уверены, что хотите применить изменения?", "Изменение информации", MessageBoxButtons.YesNoCancel, 
                    MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    
                    string updateQuery = $"UPDATE Doctor SET last_name = '{LastNameTextBox.Text}', first_name = '{FirstNameTextBox.Text}'," +
                        $"patronymic = {patronymic}, gender = '{SexCB.SelectedItem}', birthday_date = '{BirthdayTB.Value.ToString("d")}', " +
                        $"passport_series = '{PassportSeriesTB.Text}', passport_number = '{PasssportNumberTB.Text}', " +
                        $"phone_number = '{PhoneNumberTextBox.Text}', specialization = '{SpecializationTB.Text}', " +
                        $"service_price = {VisitCostTB.Value.ToString().Replace(",", ".")}, " +
                        $"cabinet_number = {CabinetNumberTB.Text}, start_work_time = '{WorkStartTB.Text}', end_work_time = '{WorkEndTB.Text}'," +
                        $"monday_work = '{(WorkMondayCB.Checked ? "да" : "нет")}', tuesday_work = '{(WorkTuesdayCB.Checked ? "да" : "нет")}'," +
                        $"wednesday_work = '{(WorkWednesdayCB.Checked ? "да" : "нет")}', thursday_work = '{(WorkThursdayCB.Checked ? "да" : "нет")}'," +
                        $"friday_work = '{(WorkFridayCB.Checked ? "да" : "нет")}', saturday_work = '{(WorkSaturdayCB.Checked ? "да" : "нет")}'," +
                        $"sunday_work = '{(WorkSundayCB.Checked ? "да" : "нет")}' " +
                        $"WHERE passport_number = '{passportNumber}' AND passport_series = '{passportSeries}'";
                    try
                    {
                        new SqlCommand(updateQuery, connection).ExecuteNonQuery();
                        MessageBox.Show("Данные были успешно обновлены!", "Обновление данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        adminForm.RefreshDoctorsDGV();
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
    }
}
