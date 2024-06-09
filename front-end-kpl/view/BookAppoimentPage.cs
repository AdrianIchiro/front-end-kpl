using AppointmentApp;
using front_end_kpl.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace front_end_kpl.view
{
    public partial class BookAppoimentPage : Form
    {
        int rows;
        Patient patient;
        List<Appointment> appointments;
        public BookAppoimentPage(Patient patient)
        {
            InitializeComponent();
            LoadAppointmentsAsync();
            this.patient = patient;
        }

        private readonly string _apiUrl = "https://localhost:7264/api/Appoiment";
        private readonly HttpClient _httpClient = new HttpClient();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BookAppoiment_Load(object sender, EventArgs e)
        {

        }

        private async Task LoadAppointmentsAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync(_apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var appointments = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Appointment>>(content);
                    this.appointments = appointments;

                    dataGridView1.Rows.Clear();

                    foreach (var appointment in appointments)
                    {
                        dataGridView1.Rows.Add(appointment.AppoimentId, appointment.TimeStart, appointment.TimeEnd, appointment.Status, appointment.IsCompleted, appointment.sapacity, appointment.room, appointment.Doctor, appointment.date, appointment.specialization);
                    }
                }
                else
                {
                    MessageBox.Show($"Failed to fetch data. Status code: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.rows = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                label5.Text = "Date: " + Convert.ToString(selectedRow.Cells["Date"].Value).Substring(0, 10);


                label6.Text = "Doctor: " + Convert.ToString(selectedRow.Cells["Doctor"].Value);
                label3.Text = "Time Start: " + Convert.ToString(selectedRow.Cells["TimeStart"].Value).Substring(0, 5);
                label7.Text = "Specialization: " + Convert.ToString(selectedRow.Cells["Specialization"].Value);


                label4.Text = "Time End: " + Convert.ToString(selectedRow.Cells["TimeEnd"].Value).Substring(0, 5);








            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (this.rows >= 0)
            {
                AppoimetPatientsApp appointmentPatientApp = new AppoimetPatientsApp();

                List<AppointmentPatient> appointmentPatients = await appointmentPatientApp.FetchAppointmentsAsync();
                int patientId = patient.patientId;
                int appointmentId = Convert.ToInt32(dataGridView1.Rows[this.rows].Cells["AppoimentId"].Value);

                foreach (var appointment in appointmentPatients)
                {
                    if (appointment.appoimentId == appointmentId && appointment.patientId == patientId)
                    {
                        MessageBox.Show("You have already booked this appointment");
                        return;
                    }
                }

                BookAppoiment bookAppoiment = new BookAppoiment();
                bookAppoiment.BookAppoimentPatient(patientId, appointmentId);

                MessageBox.Show("You have sucess booked this appointment");



            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HalamanPatient halamanPatient = new HalamanPatient(patient);
            halamanPatient.Show();
            this.Close();
        }
    }
}
