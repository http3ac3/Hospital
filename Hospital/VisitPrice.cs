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
    public partial class VisitPrice : Form
    {
        SqlConnection connection;
        public bool isVisiter;
        public VisitPrice(SqlConnection connection, bool isVisiter)
        {
            this.isVisiter = isVisiter;
            this.connection = connection;
            InitializeComponent();
        }

        private void ChooseDoctorButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new SetInfoForm(connection, this, true).Show();
            VisitsAmountTB.Value = 0;
        }

        private void VisitsAmountTB_ValueChanged(object sender, EventArgs e)
        {
            if (FIODoctorTB.Text != "")
            {
                int amount = Convert.ToInt32(VisitsAmountTB.Value);
               
                PriceTB.Text = new SqlCommand($"SELECT dbo.PriceFun({amount}, '{SpecializationTB.Text}')", connection).ExecuteScalar().ToString();
            }
        }
    }
}
