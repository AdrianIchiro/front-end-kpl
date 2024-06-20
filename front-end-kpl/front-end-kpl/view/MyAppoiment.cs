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
        // Array for appointment status
        string[] appoimentStatus = { "Scheduled", "Completed" };
        // Doctor object to display appointments for
        private Doctor doctor;
        // List to store fetched appointments
        List<Appointment> appointments;
       
       
        //service
        private readonly AppointmentService appointmentService;
        private readonly PostAppointment postAppointment;
        public MyAppoiment(Doctor doctor)
        {
            InitializeComponent();
            this.doctor = doctor;// Set the doctor for whom appointments are to be displayed
            //initialize services
            AppointmentService.Initialize();
            PostAppointment.Initialize();
            appointmentService = AppointmentService.Instance;
            postAppointment = PostAppointment.Instance;
            _ =  LoadAppointmentsAsync();// Load appointments asynchronously when the form is initialized
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MyAppoiment_Load(object sender, EventArgs e)
        {

        }
        // Async method to load appointments from API
        private async Task LoadAppointmentsAsync()
        {
            try
            {
                var appointments = await appointmentService.FetchAppointmentsAsync();

                if (appointments != null)
                {


                    this.appointments = appointments;
                    // Clear table and populate with fetched appointments
                    dataGridView1.Rows.Clear();
                    foreach (var appointment in appointments)
                    {
                        // Only show Scheduled appointments
                        if (appointment.DoctorId == doctor.id)
                        {
                            dataGridView1.Rows.Add(appointment.AppoimentId, appointment.TimeStart, appointment.TimeEnd, appoimentStatus[appointment.Status], appointment.IsCompleted, appointment.sapacity, appointment.room, appointment.Doctor, appointment.date, appointment.specialization);
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"Failed to fetch data");
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
        // Event handler for button back click (Back to Doctor Page)
        private void button1_Click(object sender, EventArgs e)
        {
            HalamanDoctor halamanDoctor = new HalamanDoctor(doctor);
            halamanDoctor.Show();
            this.Close();
        }
    }
}
