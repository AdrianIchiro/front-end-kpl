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
    }
}
