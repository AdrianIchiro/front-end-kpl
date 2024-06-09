using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;

namespace front_end_kpl.view
{
    public partial class AddPatient : Form
    {
        Admin admin;
        public AddPatient(Admin admin)
        {
            InitializeComponent();
            this.admin = admin; 
        }

        public async Task Register(string gender, string bloodtype)
        {
            // Get the DateTime value from the DateTimePicker
            DateTime birthDate = dateTimePicker1.Value;

            // Convert the DateTime to a string with a specific format
            string formattedBirthDate = birthDate.ToString("yyyy-MM-dd"); // Change the format as needed

            var checkdata = new UploadData
            {
                firstName = textBox1.Text,
                lastName = textBox2.Text,
                address = textBox3.Text,
                birthDate = formattedBirthDate,
                phoneNumber = textBox4.Text,
                email = textBox5.Text,
                password = textBox6.Text,
            };

            var jsonContent = JsonSerializer.Serialize(checkdata);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await new HttpClient().PostAsync($"https://localhost:7264/api/Patients?gender={gender}&bloodtype={bloodtype}", content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Patient added successfully!");
            }
            else
            {
                MessageBox.Show("Failed to add patient. Please check the data and try again");
            }



        }

        public class UploadData
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string address { get; set; }
            public string birthDate { get; set; }
            public string phoneNumber { get; set; }
            public string email { get; set; }
            public string password { get; set; }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = comboBox1.Text;
            string bloodtype = comboBox2.Text;

            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Invalid Gender");
                return;
            }

            if (string.IsNullOrEmpty(bloodtype))
            {
                MessageBox.Show("Invalid Bloodtype");
                return;
            }

            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                    string.IsNullOrWhiteSpace(textBox2.Text) ||
                    string.IsNullOrWhiteSpace(textBox3.Text) ||
                    string.IsNullOrWhiteSpace(textBox4.Text) ||
                    string.IsNullOrWhiteSpace(textBox5.Text) ||
                    string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    MessageBox.Show("None of the fields may be empty");
                    return;
                }


             

                Register(gender, bloodtype);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HalamanAdmin halamanAdmin = new HalamanAdmin(admin);

            halamanAdmin.Show();

            this.Close();
        }
    }
}
