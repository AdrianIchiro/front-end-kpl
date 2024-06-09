﻿using front_end_kpl.utils;
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

    public partial class HalamanDoctor : Form
    {
        public Doctor doctor;
        public HalamanDoctor(Doctor doctor)
        {
            InitializeComponent();
            this.doctor = doctor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyAppoiment myAppoiment = new MyAppoiment(doctor);  
            myAppoiment.Show();
            this.Hide();
            
        }
    }
}
