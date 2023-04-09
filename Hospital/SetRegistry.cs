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
    public partial class SetRegistry : Form
    {
        SqlConnection connection;
        PatientInfo patientInfo;
        public SetRegistry(SqlConnection connection, PatientInfo patientInfo)
        {
            this.connection = connection;
            this.patientInfo = patientInfo;
            InitializeComponent();
        }

        private void SetRegistry_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("EXEC DisplayRegistry", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            RegistryDGV.DataSource = ds.Tables[0];
            RegistryDGV.Columns[0].Visible = false;
        }

        private void RegistryDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string country = RegistryDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            string region = RegistryDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            string locality = RegistryDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            string street = RegistryDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            string homeNumber = RegistryDGV.Rows[e.RowIndex].Cells[5].Value.ToString();
            patientInfo.RegistryTB.Text = $"{country}, {region}, {locality}, {street}, {homeNumber}";
            patientInfo.id_registry = RegistryDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.Close();
        }
    }
}
