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

namespace front_end_kpl.view
{
    public partial class MyAppoiment : Form
    {
        private Doctor doctor;
        List<Appointment> appointments;
        private readonly string _apiUrl = "https://localhost:7264/api/Appoiment";
        private readonly HttpClient _httpClient = new HttpClient();
        public MyAppoiment(Doctor doctor)
        {
            InitializeComponent();
            this.doctor = doctor;
            LoadAppointmentsAsync();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MyAppoiment_Load(object sender, EventArgs e)
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
                        if (appointment.DoctorId == doctor.id)
                        {
                            dataGridView1.Rows.Add(appointment.AppoimentId, appointment.TimeStart, appointment.TimeEnd, appointment.Status, appointment.IsCompleted, appointment.sapacity, appointment.room, appointment.Doctor, appointment.date);
                        }

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HalamanDoctor halamanDoctor = new HalamanDoctor(doctor);
            halamanDoctor.Show();
            this.Close();
        }
    }
}
