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
        Admin admin;
        public EditDoctor()
        {
            InitializeComponent();
        }

        //class untuk store data dokter untuk diedit
        public class UploadData
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string address { get; set; }
            public string birthDate { get; set; }
            public string phoneNumber { get; set; }
            public string email { get; set; }
        }

        public async Task EditDoctorData(int id, int specID)
        {
            DateTime birthDate = dateTimePicker1.Value;
            // Merubah value datetime ke string dengan format yang ditentukan
            string formattedBirthDate = birthDate.ToString("yyyy-MM-dd");

            //membuat instansi UploadData dengan user input
            var checkdata = new UploadData
            {

                firstName = textBox2.Text,
                lastName = textBox3.Text,
                address = textBox5.Text,
                birthDate = formattedBirthDate,
                phoneNumber = textBox6.Text,
                email = textBox4.Text,
            };

            //serialise data dokter ke JSON
            var jsonContent = JsonSerializer.Serialize(checkdata);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await new HttpClient().PutAsync($"https://localhost:7264/api/Doctor/{id}?specializationId={specID}", content);

            //menghandal response
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Doctor updated successfully!");
            }
            else
            {
                MessageBox.Show("Failed to edit doctor. Please check the ID and try again.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //valdasi doctor id agar berupa integer
            if (!int.TryParse(textBox1.Text, out int id))
            {
                MessageBox.Show("Please enter a valid Doctor ID.");
                return;
            }

            //validasi specialist id agar berupa integer
            if (!int.TryParse(textBox8.Text, out int specID))
            {
                MessageBox.Show("Please enter a valid Specialization ID.");
                return;
            }

            try
            {
                //validasi semua textfield
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

                EditDoctorData(id, specID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HalamanAdmin admin = new HalamanAdmin(admin);
            admin.Show();

            this.Close();
        }
    }
}
