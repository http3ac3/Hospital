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
    public partial class RegistrationForm : Form
    {
        SqlConnection connection;
        public static string GetRemoteConnectionString(string login, string password)
        {
            SqlConnectionStringBuilder sqlString = new SqlConnectionStringBuilder()
            {
                DataSource = $"DESKTOP-QI4TJ5P",
                InitialCatalog = "Hospital_DB_R", //Database
                IntegratedSecurity = true,
                MultipleActiveResultSets = true,
                ApplicationName = "EntityFramework",
                UserID = login,
                Password = password
            };
            return sqlString.ToString();
        }
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void CheckPassportButton_Click(object sender, EventArgs e)
        {
            string connectionString = GetRemoteConnectionString("", "");
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT passport_series, passport_number FROM Patient " +
                $"WHERE passport_number = '{PasssportNumberTB.Text}' AND passport_series = '{PassportSeriesTB.Text}'", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                groupBox1.Enabled = true;
                LoginNameTB.Text = $"{PassportSeriesTB.Text}_{PasssportNumberTB.Text}";
            }
            else
            {
                MessageBox.Show("Записи о вас в базе данных регистратуры не найдено! Проверьте правильность введенных данных или посетите регистратуру!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                return;
            }
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            new SqlCommand($"EXEC sp_addlogin '{LoginNameTB.Text}', '{PasswordTB.Text}', 'Hospital_DB_R'", connection).ExecuteNonQuery();
            new SqlCommand($"USE Hospital_DB_R", connection).ExecuteNonQuery();
            new SqlCommand($"EXEC sp_adduser '{LoginNameTB.Text}', '{LoginNameTB.Text}'", connection).ExecuteNonQuery();
            new SqlCommand($"EXEC sp_addrolemember 'Patient', '{LoginNameTB.Text}'", connection).ExecuteNonQuery();
            MessageBox.Show("Регистрация прошла успешно!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
        }
    }
}
