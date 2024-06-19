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

namespace front_end_kpl.view
{

    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        public async Task Registration(string gender, string bloodtype)
        {
            DateTime birthDate = dateTimePicker1.Value;
            // Merubah value datetime ke string dengan format yang ditentukan
            string formattedBirthDate = birthDate.ToString("yyyy-MM-dd");

            //buat instance UploadData dengan user input
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

            //Serialize data user ke json
            var jsonContent = JsonSerializer.Serialize(checkdata);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await new HttpClient().PostAsync($"https://localhost:7264/api/Patients?gender={gender}&bloodtype={bloodtype}", content);

            //handling response
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Registration successfull!");
            }
            else
            {
                MessageBox.Show("Failed to add patient. Please check the data and try again");
                return;
            }
        }

        //class untuk mengstore data user untuk registrasi
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

            //validasi gender dan bloodtype agar tidak null
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
                //validasi semua field agar tidak null
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

                Registration(gender, bloodtype);

                Login login = new Login();
                login.Show();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();

            this.Close();
        }
    }
}
