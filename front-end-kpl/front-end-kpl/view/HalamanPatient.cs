﻿using System;
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
    public partial class HalamanPatient : Form
    {
        Patient Patient;
        public HalamanPatient(Patient patient)
        {
            InitializeComponent();
            this.Patient = patient;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookAppoimentPage bookAppoimentPage = new BookAppoimentPage(Patient);
            bookAppoimentPage.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyAppoimentPatient myAppoimentPatient = new MyAppoimentPatient(Patient);
            myAppoimentPatient.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyMedicalCheckupForm medicalCheckupForm = new MyMedicalCheckupForm(this.Patient);
            medicalCheckupForm.Show();
            this.Close();
        }
    }
}
