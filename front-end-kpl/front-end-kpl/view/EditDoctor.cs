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
using System.Net;
using front_end_kpl.Model;

namespace front_end_kpl.view
{
    public partial class EditDoctor : Form
    {
        Admin admin;
        List<SpecializationModel> specializations;
        int selectedIndexSpecializations = -1;
        public EditDoctor(Admin admin)
        {
            this.admin = admin;
            InitializeComponent();
            FillSpecializationComboBox();
        }

        //class untuk store data dokter untuk diedit
        public class UploadData
        {
            public string? firstName { get; set; }
            public string? lastName { get; set; }
            public string? address { get; set; }
            public string? birthDate { get; set; }
            public string? phoneNumber { get; set; }
            public string? email { get; set; }
        }

        public async Task EditDoctorData(int id, int? specID)
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
                if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("email or phone number already used by another doctor");
                    return;
                }
                MessageBox.Show("Failed to edit doctor. Please check the ID and try again.");
                return;
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

            //mengeset specialisation ID, spec id bisa null
            int? specID = null;
            if (selectedIndexSpecializations >= 0 && selectedIndexSpecializations < specializations.Count)
            {
                specID = specializations[selectedIndexSpecializations].specializationId;
            }

            try
            {
                EditDoctorData(id, specID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void FillSpecializationComboBox()
        {
            //membuat httpclient yang mengirim GET request ke specialisation
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new HttpClient(handler);
            HttpResponseMessage response = await client.GetAsync($"https://localhost:7264/api/Specialization");

            //handling response, berikan error message jika faiil, deserealize dan masukkan ke combobox jika berhasil
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

        private void button2_Click(object sender, EventArgs e)
        {
            HalamanAdmin adminpage = new HalamanAdmin(admin);
            adminpage.Show();

            this.Close();
        }

        //mengambil index specialisasi dari combobox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                selectedIndexSpecializations = comboBox1.SelectedIndex;
            }
        }
    }
}
