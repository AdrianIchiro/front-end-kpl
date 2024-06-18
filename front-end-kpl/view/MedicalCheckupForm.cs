using AppointmentApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using front_end_kpl.utils;

namespace front_end_kpl.view
{
    public partial class MedicalCheckupForm : Form
    {
        private int patientId;

        private async void loadData(int id)
        {
            List<GetAppoimentPatients> appoimentPatient = await new GetAppoimentPatient().GetAppoimentPatients(1);
            dataGridView1.Rows.Clear();
            foreach (var appoiment in appoimentPatient)
            {
                dataGridView1.Rows.Add(appoiment.appoimentId, appoiment.appoiment, appoiment.patient, appoiment.patientId);
            }
        }
        public MedicalCheckupForm()
        {
            InitializeComponent();
            loadData(1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                this.patientId = Convert.ToInt32(row.Cells["PatientId"].Value);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == null || textBox2 == null)
            {
                MessageBox.Show("isi field terlebih dahulu");
            }
            else
            {
                try
                {
                    DateTime date = dateTimePicker1.Value;
                    MessageBox.Show(date.ToString("yyyy-mm-dd"));
                    MessageBox.Show(this.patientId.ToString());
                    await new PostMedicalCheckup().PostMedicalCheckUp(date.ToString("yyyy-MM-dd"), textBox3.Text, textBox2.Text, 1, this.patientId, 1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void MedicalCheckupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
