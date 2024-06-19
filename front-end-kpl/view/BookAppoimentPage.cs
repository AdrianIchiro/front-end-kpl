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
        // Array for appointment status
        string[] appoimentStatus = { "Scheduled", "Completed" };
        // Variable to store selected row index
        int rows;
        // Patient object
        Patient patient;
        // List to store appointments
        List<Appointment> appointments;
        // Instance of AppoimetPatientsApp for handling appointments with patients
        //services
        private readonly AppoimetPatientsApp appoimetPatientsApp ;
        private readonly AppointmentService appointmentService;
        // Constructor
        public BookAppoimentPage(Patient patient)
        {
            InitializeComponent();
            AppointmentService.Initialize();
            PostAppointment.Initialize();
            appointmentService = AppointmentService.Instance;
            appoimetPatientsApp = AppoimetPatientsApp.Instance;
           _= LoadAppointmentsAsync(); // Load appointments asynchronously
            this.patient = patient;
        }
      
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BookAppoiment_Load(object sender, EventArgs e)
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
                        if (appointment.Status == 0)
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

        // Event handler for table cell click
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //encure that user click the cell of the table
            if (e.RowIndex >= 0)
            {
                // Populate labels with selected appointment details
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
        // Event handler for button book click (Book Appointment)
        private async void button1_Click(object sender, EventArgs e)
        {
            if (this.rows >= 0)
            {
                // Fetch appointments already booked by the patient
                List<AppointmentPatient> appointmentPatients = await appoimetPatientsApp.FetchAppointmentsAsync();
                int patientId = patient.patientId;
                int appointmentId = Convert.ToInt32(dataGridView1.Rows[this.rows].Cells["AppoimentId"].Value);

                // Check if the patient has already booked this appointment
                foreach (var appointment in appointmentPatients)
                {
                    if (appointment.appoimentId == appointmentId && appointment.patientId == patientId)
                    {
                        MessageBox.Show("You have already booked this appointment");
                        return;
                    }
                }

                // Book the appointment
                BookAppoiment.Instance.BookAppointmentPatientAsync(patientId, appointmentId);

                MessageBox.Show("You have sucess booked this appointment");



            }

        }
        // Event handler for button2 click (Back to Patient Page)
        private void button2_Click(object sender, EventArgs e)
        {
            // Navigate back to patient page
            HalamanPatient halamanPatient = new HalamanPatient(patient);
            halamanPatient.Show();
            this.Close();
        }
    }
}
