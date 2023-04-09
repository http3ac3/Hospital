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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public static string GetRemoteConnectionString(string login, string password)
        {
            SqlConnectionStringBuilder sqlString = new SqlConnectionStringBuilder()
            {
                DataSource = $"DESKTOP-QI4TJ5P",
                InitialCatalog = "Hospital_DB_R", //Database
                IntegratedSecurity = false,
                MultipleActiveResultSets = true,
                ApplicationName = "EntityFramework",
                UserID = login,
                Password = password
            };
            return sqlString.ToString();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string login = LoginNameTB.Text;
            string password = PasswordTB.Text;
            string connectionString = GetRemoteConnectionString(login, password);
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                if (Convert.ToInt32(new SqlCommand("SELECT IS_MEMBER('Admin')", connection).ExecuteScalar()) == 1)
                {
                    new AdminForm(connection, this).Show();
                    this.Hide();
                }
                else if (Convert.ToInt32(new SqlCommand("SELECT IS_MEMBER('Patient')", connection).ExecuteScalar()) == 1)
                {
                    string[] passport = LoginNameTB.Text.Split('_');
                    new PatientForm(connection, this, passport[0], passport[1]).Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Введенные данные неверны! Проверьте правильность введенных логина и/или пароля!", "Ошибка входа", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            new RegistrationForm().Show();
        }
    }
}
