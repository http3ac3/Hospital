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
    public partial class RegistryInfo : Form
    {
        SqlConnection connection;
        AdminForm adminForm;
        string idRegistry;
        AdminForm.ViewMode mode;

        public RegistryInfo(SqlConnection connection, AdminForm adminForm, AdminForm.ViewMode mode)
        {
            this.connection = connection;
            this.adminForm = adminForm;
            this.mode = mode;
            InitializeComponent();
        }

        public RegistryInfo(SqlConnection connection, AdminForm adminForm, AdminForm.ViewMode mode, string idRegistry)
        {
            this.connection = connection;
            this.adminForm = adminForm;
            this.mode = mode;
            this.idRegistry = idRegistry;
            InitializeComponent();
        }


        private void RegistryInfo_Load(object sender, EventArgs e)
        {
            switch (mode)
            {
                case AdminForm.ViewMode.WATCH:
                    AddButton.Visible = false;
                    DataSet ds = adminForm.GetFilledDataSet($"SELECT * FROM Registry WHERE id_registry = {idRegistry}");
                    DataRow row = ds.Tables[0].Rows[0];
                    CountryTB.Text = row[1].ToString();
                    RegionTB.Text = row[2].ToString();
                    LocalityTB.Text = row[3].ToString();
                    StreetTB.Text = row[4].ToString();
                    HomeNumberTB.Text = row[5].ToString();
                    break;
                case AdminForm.ViewMode.ADD:
                    foreach (var tb in this.Controls.OfType<TextBox>()) tb.ReadOnly = false;
                    break;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (AddButton.Text == "Добавить регистратуру")
            {
                string insertQuery = $"INSERT INTO Registry VALUES ('{CountryTB.Text}', '{RegionTB.Text}', '{LocalityTB.Text}', " +
                    $"'{StreetTB.Text}', '{HomeNumberTB.Text}')";
                try
                {
                    new SqlCommand(insertQuery, connection).ExecuteNonQuery();
                    MessageBox.Show("Данные были успешно добавлены!", "Добаление регистратуры", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    adminForm.RefreshRegistryDGV();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            /*
            else if (AddButton.Text == "Изменить информацию")
            {
                AddButton.Text = "Сохранить";
                foreach (var tb in this.Controls.OfType<TextBox>()) tb.ReadOnly = false;
            }
            else if (AddButton.Text == "Сохранить")
            {
                var res = MessageBox.Show("Вы уверены, что хотите применить изменения?", "Изменение информации", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);
                
                if (res == DialogResult.Yes)
                {
                    string updateQuery = $"UPDATE Registry SET country = '{CountryTB.Text}', region = '{RegionTB.Text}', " +
                                        $"locality = '{LocalityTB.Text}', street = '{StreetTB.Text}', home_number = '{HomeNumberTB.Text}' " +
                                        $"WHERE id_registry = {idRegistry}";
                    try
                    {
                        new SqlCommand(updateQuery, connection).ExecuteNonQuery();
                        MessageBox.Show("Данные были успешно обновлены!", "Изменение информации", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        adminForm.RefreshRegistryDGV();
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
                
            } */
        }
    }
}
