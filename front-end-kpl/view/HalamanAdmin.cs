using frontEnd.view;
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
        Admin admin;
        public HalamanAdmin(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAdmin addAdmin = new AddAdmin(admin);
            addAdmin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditAdmin EditAdmin = new EditAdmin(admin);
            EditAdmin.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteAdmin DeleteAdmin = new DeleteAdmin(admin);
            DeleteAdmin.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddDoctor AddDoctor = new AddDoctor(admin);
            AddDoctor.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EditDoctor EditDoctor = new EditDoctor(admin);
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
            AddPatient AddPatient = new AddPatient(admin);
            AddPatient.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EditPatient EditPatient = new EditPatient(admin);
            EditPatient.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DeletePatient DeletePatient = new DeletePatient(admin);
            DeletePatient.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AppoimentManagement appoimentManagement = new AppoimentManagement(admin);
            appoimentManagement.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            RoomGUI room = new RoomGUI();
            room.Show();
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Specialization specialization = new Specialization();
            specialization.Show();
            this.Close();
        }
    }
}
