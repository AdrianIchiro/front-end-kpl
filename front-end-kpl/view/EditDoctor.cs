using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;

namespace front_end_kpl.view
{
    public partial class EditDoctor : Form
    {
        public EditDoctor()
        {
            InitializeComponent();
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

        public async Task Edit(int id, int specID)
        {
            // Get the DateTime value from the DateTimePicker
            DateTime birthDate = dateTimePicker1.Value;

            // Convert the DateTime to a string with a specific format
            string formattedBirthDate = birthDate.ToString("yyyy-MM-dd"); // Change the format as needed


            var checkdata = new UploadData
            {

                firstName = textBox2.Text,
                lastName = textBox3.Text,
                address = textBox5.Text,
                birthDate = formattedBirthDate,
                phoneNumber = textBox6.Text,
                email = textBox4.Text,
            };

            var jsonContent = JsonSerializer.Serialize(checkdata);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await new HttpClient().PutAsync($"https://localhost:7264/api/Doctor/{id}?specializationId={specID}", content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Doctor updated successfully!");
            }
            else
            {
                MessageBox.Show("Failed to edit doctor. Please check the ID and try again.");
            }



        }



        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int id))
            {
                MessageBox.Show("Please enter a valid Doctor ID.");
                return;
            }

            if (!int.TryParse(textBox8.Text, out int specID))
            {
                MessageBox.Show("Please enter a valid Specialization ID.");
                return;
            }

            try
            {
                if (
                    string.IsNullOrWhiteSpace(textBox2.Text) ||
                    string.IsNullOrWhiteSpace(textBox3.Text) ||
                    string.IsNullOrWhiteSpace(textBox4.Text) ||
                    string.IsNullOrWhiteSpace(textBox5.Text) ||
                    string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    MessageBox.Show("None of the fields may be empty");
                    return;
                }

                Edit(id, specID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HalamanAdmin admin = new HalamanAdmin();

            admin.Show();

            this.Close();
        }
    }
}
