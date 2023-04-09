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
    public partial class DeleteInfo : Form
    {
        SqlConnection connection;
        AdminForm adminForm;
        AdminForm.DeleteObject obj;
        public DeleteInfo(SqlConnection connection, AdminForm adminForm, AdminForm.DeleteObject obj)
        {
            this.connection = connection;
            this.adminForm = adminForm;
            this.obj = obj;
            InitializeComponent();
        }

        private void DeleteInfo_Load(object sender, EventArgs e)
        {
            switch (obj)
            {
                case AdminForm.DeleteObject.PATIENT:
                    DeleteDGV.DataSource = adminForm.GetFilledDataSet("EXEC DisplayPatients").Tables[0];
                    break;
                case AdminForm.DeleteObject.DOCTOR:
                    DeleteDGV.DataSource = adminForm.GetFilledDataSet("EXEC DisplayDoctors").Tables[0];
                    break;
                case AdminForm.DeleteObject.REGISTRY:
                    DeleteDGV.DataSource = adminForm.GetFilledDataSet("EXEC DisplayRegistry").Tables[0];
                    break;
                case AdminForm.DeleteObject.VISIT:
                    DeleteDGV.DataSource = adminForm.GetFilledDataSet("EXEC DisplayVisits").Tables[0];
                    break;
            }
        }

        private void DeleteDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlDataAdapter adapter;
            DataSet ds;
            switch (obj)
            {
                case AdminForm.DeleteObject.PATIENT:
                    var res = MessageBox.Show("Вы действительно хотите удалить пациента, его мед. карту и его посещения вместе с ним?", "Удаление записи", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.Yes)
                    {
                        string patientPS = DeleteDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                        string patientPN = DeleteDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
                        adapter = new SqlDataAdapter($"SELECT id_patient FROM Patient " +
                            $"WHERE passport_series = '{patientPS}' AND passport_number = '{patientPN}'", connection);
                        ds = new DataSet();
                        adapter.Fill(ds);
                        string idPatient = ds.Tables[0].Rows[0][0].ToString();

                        string deleteRPQuery = $"DELETE FROM Registry_Patient WHERE id_patient = {idPatient}";

                        new SqlCommand(deleteRPQuery, connection).ExecuteNonQuery();

                        adapter = new SqlDataAdapter($"SELECT id_medical_card FROM Medical_Card " +
                            $"WHERE id_patient = {idPatient}", connection);
                        ds = new DataSet();
                        adapter.Fill(ds);
                        string idMC = ds.Tables[0].Rows[0][0].ToString();

                        string deleteVisits = $"DELETE FROM Medical_Card_Doctor WHERE id_medical_card = {idMC}";
                        new SqlCommand(deleteVisits, connection).ExecuteNonQuery();

                        string deleteMC = $"DELETE FROM Medical_Card WHERE id_medical_card = {idMC}";
                        new SqlCommand(deleteMC, connection).ExecuteNonQuery();

                        string deletePatient = $"DELETE FROM Patient WHERE id_patient = {idPatient}";
                        new SqlCommand(deletePatient, connection).ExecuteNonQuery();
                        this.Close();
                        adminForm.RefreshPatientsDGV();
                        adminForm.RefreshVisitsDGV();
                        adminForm.RefreshMedicalCardsDGV();
                    }
                    break;
                case AdminForm.DeleteObject.DOCTOR:
                    var resDoctor = MessageBox.Show("Вы действительно хотите удалить доктора и его посещения вместе с ним?", "Удаление записи",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resDoctor == DialogResult.Yes)
                    {
                        string doctorPS = DeleteDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                        string doctorPN = DeleteDGV.Rows[e.RowIndex].Cells[4].Value.ToString();

                        adapter = new SqlDataAdapter($"SELECT id_doctor FROM Doctor " +
                                $"WHERE passport_series = '{doctorPS}' AND passport_number = '{doctorPN}'", connection);
                        ds = new DataSet();
                        adapter.Fill(ds);
                        string idDoctor = ds.Tables[0].Rows[0][0].ToString();

                        string deleteVisits = $"DELETE FROM Medical_Card_Doctor WHERE id_doctor = {idDoctor}";
                        new SqlCommand(deleteVisits, connection).ExecuteNonQuery();

                        string deleteDoctor = $"DELETE FROM Doctor WHERE id_doctor = {idDoctor}";
                        new SqlCommand(deleteDoctor, connection).ExecuteNonQuery();
                        this.Close();
                        adminForm.RefreshDoctorsDGV();
                        adminForm.RefreshVisitsDGV();
                    }
                    break;
                case AdminForm.DeleteObject.VISIT:
                    var resVisit = MessageBox.Show("Вы действительно хотите удалить посещение?", "Удаление записи",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resVisit == DialogResult.Yes)
                    {
                        string idVisit = DeleteDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                        string deleteVisit = $"DELETE FROM Medical_Card_Doctor WHERE id_medical_card_doctor = {idVisit}";
                        new SqlCommand(deleteVisit, connection).ExecuteNonQuery();
                        this.Close();
                        adminForm.RefreshVisitsDGV();
                    }
                    break;
                case AdminForm.DeleteObject.REGISTRY:
                    var resReg = MessageBox.Show("Вы действительно хотите удалить регистратуру?", "Удаление записи",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resReg == DialogResult.Yes)
                    {
                        string idReg = DeleteDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                        try
                        {
                            new SqlCommand($"DELETE FROM Registry WHERE id_registry = {idReg}", connection).ExecuteNonQuery();
                        }
                        catch 
                        {
                            MessageBox.Show("Чтобы удалить эту регистратуру, сначала перенесите все записи о пациентах в другую регистратуру", "Ошибка", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        this.Close();
                        adminForm.RefreshRegistryDGV();
                    }
                    break;
            }

        }
    }
}
