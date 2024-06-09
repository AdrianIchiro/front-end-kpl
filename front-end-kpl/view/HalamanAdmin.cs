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
    public partial class HalamanAdmin : Form
    {
        public HalamanAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAdmin addAdmin = new AddAdmin();
            addAdmin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditAdmin EditAdmin = new EditAdmin();
            EditAdmin.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteAdmin DeleteAdmin = new DeleteAdmin();
            DeleteAdmin.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddDoctor AddDoctor = new AddDoctor();
            AddDoctor.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EditDoctor EditDoctor = new EditDoctor();
            EditDoctor.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DeleteDoctor DeleteDoctor = new DeleteDoctor();
            DeleteDoctor.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddPatient AddPatient = new AddPatient();
            AddPatient.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EditPatient EditPatient = new EditPatient();
            EditPatient.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DeletePatient DeletePatient = new DeletePatient();
            DeletePatient.Show();
            this.Hide();
        }
    }
}
