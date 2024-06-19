using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static front_end_kpl.view.Login;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;
namespace front_end_kpl.view



{
    public partial class AddDoctor : Form
    {
        Admin admin;
        public AddDoctor(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }


        public async Task RegisterNewDoctor(int specialisation)
        {
            DateTime birthDate = dateTimePicker1.Value;
            // Merubah value datetime ke string dengan format yang ditentukan
            string formattedBirthDate = birthDate.ToString("yyyy-MM-dd");

            //Buat instance UploadData dengan user input
            var checkdata = new UploadData
            {
                firstName = textBox1.Text,
                lastName = textBox2.Text,
                address = textBox5.Text,
                birthDate = formattedBirthDate,
                phoneNumber = textBox4.Text,
                email = textBox3.Text,
                password = textBox6.Text,
            };

            //Serialise data dokter ke JSON
            var jsonContent = JsonSerializer.Serialize(checkdata);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await new HttpClient().PostAsync($"https://localhost:7264/api/Doctor?specializationId={specialisation}", content);

            //cek jika response sukses atau tidak, display pesan yang sesuai
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Doctor added successfully!");
            }
            else
            {
                MessageBox.Show("Failed to add doctor. Please check the data and try again");
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
            try
            {
                //cek agar tidak ada textbox yang null
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

                //cek jika specialisastion id yang dipilih valid
                if (!int.TryParse(comboBox1.Text, out int specID))
                {
                    MessageBox.Show("Invalid Specialisation ID");
                }
                RegisterNewDoctor(specID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HalamanAdmin HalamanAdmin = new HalamanAdmin(admin);
            HalamanAdmin.Show();

            this.Close();
        }
    }
}
