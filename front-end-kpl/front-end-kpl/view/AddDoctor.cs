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
using System.Net;
using front_end_kpl.utils;
using front_end_kpl.Model;
namespace front_end_kpl.view



{
    public partial class AddDoctor : Form
    {
        Admin admin;
        int selectedIndexSpecializations = -1;
        List<SpecializationModel> specializations;
        public AddDoctor(Admin admin)
        {
            InitializeComponent();
            fillSpecializationComboBox();
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

            //menghandal response
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Doctor addedd successfully!");
            }
            else
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("email or phone number already used by another doctor");
                    return;
                }
                MessageBox.Show("Failed to add doctor. Please check the ID and try again. email or phone number already used by another doctor");
                return;
            }
        }

        //class untuk store data doktor inputtan user
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

        private void label9_Click(object sender, EventArgs e)
        {

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
                if(selectedIndexSpecializations == -1)
                {
                    MessageBox.Show("Please select a specialization");
                    return;
                }
                string idstring = specializations[selectedIndexSpecializations].specializationId.ToString();
                MessageBox.Show(idstring);
                RegisterNewDoctor(specializations[selectedIndexSpecializations].specializationId);
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

        private void AddDoctor_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1) {
                selectedIndexSpecializations = comboBox1.SelectedIndex;
                
            }
            
        }

        private async void fillSpecializationComboBox() {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new HttpClient(handler);
            HttpResponseMessage response = await client.GetAsync($"https://localhost:7264/api/Specialization");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                specializations = Newtonsoft.Json.JsonConvert.DeserializeObject<List<SpecializationModel>>(content);
                comboBox1.Items.Clear();
                foreach (var specialization in specializations)
                {
                    comboBox1.Items.Add(specialization.name);
                }
                
            }
            else
            {
                MessageBox.Show("Error: " + response.StatusCode);
                return;
            }
        }
    }
}
