using AppointmentApp;
using front_end_kpl.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace front_end_kpl.view
{
    
    public partial class MyAppoimentPatient : Form
    {
        List<AppointmentPatient> MyAppoiment =  new List<AppointmentPatient>();
        Patient patient;

        public MyAppoimentPatient(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
            AllMyAppoimentPatient();
        }

        private void MyAppoimentPatient_Load(object sender, EventArgs e)
        {
            
        }


        private async void AllMyAppoimentPatient()
        {
            List<Appointment> appointments = new List<Appointment>();
            AppoimetPatientsApp appoimetPatientsApp = new AppoimetPatientsApp();
            List<AppointmentPatient> appoimentPatients =await appoimetPatientsApp.FetchAppointmentsAsync();
            AppointmentService appointmentService = new AppointmentService();   
            foreach (var appoimentPatient in appoimentPatients)
            {
                if (appoimentPatient.patientId == patient.patientId)
                {
                    this.MyAppoiment.Add(appoimentPatient);
                }
            }

            for(int i = 0; i < MyAppoiment.Count; i++)
            {
                Appointment appointment = await appointmentService.GetAppointmentAsyncInternal(MyAppoiment[i].appoimentId);
               appointments.Add(appointment);
            }

            foreach (var appointment in appointments)
            {
                dataGridView1.Rows.Add(appointment.AppoimentId, appointment.TimeStart, appointment.TimeEnd, appointment.Status, appointment.IsCompleted, appointment.sapacity, appointment.room, appointment.Doctor, appointment.date);
            }

        }
    }
}
