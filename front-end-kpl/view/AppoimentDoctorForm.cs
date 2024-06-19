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
    public partial class AppoimentDoctorForm : Form
    {
        private readonly AppoimentDoctor _appoimentDoctorInstance;
        private Doctor doctorData;
        private int appoiment;

        public AppoimentDoctorForm(Doctor doctor)
        {
            InitializeComponent();
            _appoimentDoctorInstance = AppoimentDoctor.Instance;
            this.doctorData = doctor;

            loadData(doctor.id);
        }

        private async void loadData(int id)
        {
            List<Appoiment> appoimentDoctor = await _appoimentDoctorInstance.FetchAppointmentsAsync();
            dataGridView1.Rows.Clear();
            foreach (var appoiment in appoimentDoctor)
            {
                if (this.doctorData.id == appoiment.doctorId)
                {
                    dataGridView1.Rows.Add(appoiment.appoimentId, appoiment.timeStart, appoiment.timeEnd, appoiment.status, appoiment.isCompleted, appoiment.sapacity, appoiment.room, appoiment.doctor);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                this.appoiment = Convert.ToInt32(row.Cells["appoimentId"].Value);
                MedicalCheckupForm Form = new MedicalCheckupForm(this.doctorData, this.appoiment);
                Form.Show();

                this.Hide();
            }
        }

    }
}
