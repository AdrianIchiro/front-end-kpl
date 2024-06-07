using AppointmentApp;
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

namespace frontEnd.view
{
    public partial class AppoimentManagement : Form
    {
       
        private readonly string _apiUrl = "https://localhost:7264/api/Appoiment";
        private readonly HttpClient _httpClient = new HttpClient();

        public AppoimentManagement()
        {
            InitializeComponent();
            _ = LoadAppointmentsAsync();
        }

        private void AppoimentManagement_Load(object sender, EventArgs e)
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

                    dataGridView1.Rows.Clear();

                    foreach (var appointment in appointments)
                    {
                        dataGridView1.Rows.Add(appointment.AppoimentId, appointment.TimeStart, appointment.TimeEnd, appointment.Status, appointment.IsCompleted, appointment.Capacity, appointment.Room, appointment.Doctor, appointment.date);
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

      

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Pastikan event ini terjadi di dalam baris yang sebenarnya (bukan di header)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Dapatkan data dari baris yang dipilih
                int appointmentId = Convert.ToInt32(selectedRow.Cells["AppoimentId"].Value);
                string timeStart = Convert.ToString(selectedRow.Cells["TimeStart"].Value);
                string timeEnd = Convert.ToString(selectedRow.Cells["TimeEnd"].Value);

                // Tampilkan pesan dengan data yang diperoleh
                MessageBox.Show($"Appointment ID: {appointmentId}, Time Start: {timeStart}, Time End: {timeEnd}");
            }

        }
    }
}
