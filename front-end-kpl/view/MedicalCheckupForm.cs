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
        private int appoimentId;
        private int patientId;
        private int doctorId;
        private Doctor doctor;

        private readonly PostMedicalCheckup _postMedicalCheckup;

        // catch doctor model and appoimentId in constructor
        public MedicalCheckupForm(Doctor doctor, int appoimentId)
        {
            this.doctor = doctor;
            this.doctorId = doctor.id;
            this.appoimentId = appoimentId;
            InitializeComponent();
            _postMedicalCheckup = PostMedicalCheckup.Instance;

            loadData(appoimentId);
        }
        // looping data patient by id
        private async void loadData(int id)
        {
            List<GetAppoimentPatients> appoimentPatient = await new GetAppoimentPatient().GetAppoimentPatients(id);
            dataGridView1.Rows.Clear();
            foreach (var appoiment in appoimentPatient)
            {
                dataGridView1.Rows.Add(appoiment.appoimentId, appoiment.appoiment, appoiment.patient, appoiment.patientId);
            }
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
            // check if the text field is empty
            if (textBox3.Text == "" || textBox2.Text == "" || this.patientId == null)
            {
                MessageBox.Show("fill in the fields first");
            }
            else
            {
                // try to get error if request post failed
                try
                {
                    DateTime date = dateTimePicker1.Value;
                    await _postMedicalCheckup.PostMedicalCheckUp(date.ToString("yyyy-MM-dd"), textBox3.Text, textBox2.Text, this.doctorId, this.patientId, this.appoimentId);
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

        private void button2_Click(object sender, EventArgs e)
        {
            AppoimentDoctorForm appoimentDoctor = new AppoimentDoctorForm(this.doctor);
            appoimentDoctor.Show();
            this.Close();
        }
    }
}
