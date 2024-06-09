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
        public AddPatient()
        {
            InitializeComponent();
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
                Console.WriteLine(response.IsSuccessStatusCode);
            }
            else
            {
                MessageBox.Show("data salah");
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
            Register("Male", "B");
        }
    }
}
