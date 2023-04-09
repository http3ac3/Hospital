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
    public partial class VisitList : Form
    {
        SqlConnection connection;

        string passportSeries;
        string passportNumber;
        public VisitList(SqlConnection connection, string passportSeries, string passportNumber)
        {
            this.connection = connection;
            this.passportNumber = passportNumber;
            this.passportSeries = passportSeries;
            InitializeComponent();
        }

        private void VisitList_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter($"EXEC FindVisitListByPassport '{passportSeries}', '{passportNumber}'", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            VisitListDGV.DataSource = ds.Tables[0];
        }
    }
}
