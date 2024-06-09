using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.Json;
using System.Reflection;

namespace front_end_kpl.view
{
    public partial class EditPatient : Form
    {
        Admin admin;
        public EditPatient(Admin admin)
        {
            InitializeComponent();
            this.admin = admin; 
        }


        public class UploadData
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string address { get; set; }
            public string birthDate { get; set; }
            public string phoneNumber { get; set; }
            public string email { get; set; }

        }

        public async Task Edit(int id, string gender, string bloodtype)
        {
            // Get the DateTime value from the DateTimePicker
            DateTime birthDate = dateTimePicker1.Value;

            // Convert the DateTime to a string with a specific format
            string formattedBirthDate = birthDate.ToString("yyyy-MM-dd"); // Change the format as needed

            var checkdata = new UploadData
            {
                firstName = textBox2.Text,
                lastName = textBox3.Text,
                address = textBox4.Text,
                birthDate = formattedBirthDate,
                phoneNumber = textBox6.Text,
                email = textBox7.Text,
            };

            var jsonContent = JsonSerializer.Serialize(checkdata);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await new HttpClient().PutAsync($"https://localhost:7264/api/Patients/{id}?gender={gender}&bloodtype={bloodtype}", content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Patient updated successfully!");
            }
            else
            {
                MessageBox.Show("Failed to edit patient. Please check the ID and try again");
            }



        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = comboBox1.Text;
            string bloodtype = comboBox2.Text;

            if (!int.TryParse(textBox1.Text, out int id))
            {
                MessageBox.Show("Please enter a valid Patient ID");
                return;
            }

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
                if (
                    string.IsNullOrWhiteSpace(textBox2.Text) ||
                    string.IsNullOrWhiteSpace(textBox3.Text) ||
                    string.IsNullOrWhiteSpace(textBox4.Text) ||
                    string.IsNullOrWhiteSpace(textBox6.Text) ||
                    string.IsNullOrWhiteSpace(textBox7.Text))
                {
                    MessageBox.Show("None of the fields may be empty");
                    return;
                }

                Edit(id, gender, bloodtype);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HalamanAdmin HalamanAdmin = new HalamanAdmin(admin);

            HalamanAdmin.Show();

            this.Close();
        }
    }
}
