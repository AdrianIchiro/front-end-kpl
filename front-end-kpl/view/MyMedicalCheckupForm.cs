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
    public partial class MyMedicalCheckupForm : Form
    {
        private int idPatient;
        private Patient patientData;
        private readonly GetMedicalCheckup _myMedicalCheckupInstance;
        public MyMedicalCheckupForm(Patient patient)
        {
            InitializeComponent();
            this.idPatient = patient.patientId;
            this.patientData = patient;

            _myMedicalCheckupInstance = GetMedicalCheckup.Instance;
        }

        public async void loadData(int id)
        {
            List<MedicalCheckUp> medicalCheckup = await _myMedicalCheckupInstance.FetchMedicalCheckupsAsync();
            dataGridView1.Rows.Clear();
            foreach (var mcu in medicalCheckup)
            {
                if (this.idPatient == mcu.patienId)
                {
                    dataGridView1.Rows.Add(mcu.medicalCheckUpId, mcu.date, mcu.noteMedicalCheckup, mcu.result, mcu.doctor, mcu.patient, mcu.appointmentId, mcu.patienId);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HalamanPatient halamanPatient = new HalamanPatient(this.patientData);
            halamanPatient.Show();
            this.Close();
        }
    }
}
