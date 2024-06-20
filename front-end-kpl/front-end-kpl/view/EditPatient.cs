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
using System.Net;

namespace front_end_kpl.view
{
    public partial class EditPatient : Form
    {
        Admin admin;
        public EditPatient(Admin admin)

        {
            this.admin = admin;
            InitializeComponent();
        }

        //class untuk mengstore data pasien untuk di edit
        public class UploadData
        {
            public string ?firstName { get; set; }
            public string ?lastName { get; set; }
            public string ?address { get; set; }
            public string ?birthDate { get; set; }
            public string ?phoneNumber { get; set; }
            public string ?email { get; set; }

        }

        //method untuk edit data pasien
        public async Task EditPatientData(int id, string? gender, string? bloodtype)
        {
            DateTime birthDate = dateTimePicker1.Value;
            // Merubah value datetime ke string dengan format yang ditentukan
            string formattedBirthDate = birthDate.ToString("yyyy-MM-dd");

            //membuat instance UploadData dengan user input
            var checkdata = new UploadData
            {
                firstName = textBox2.Text,
                lastName = textBox3.Text,
                address = textBox4.Text,
                birthDate = formattedBirthDate,
                phoneNumber = textBox6.Text,
                email = textBox7.Text,
            };

            //serialise data pasien ke JSON
            var jsonContent = JsonSerializer.Serialize(checkdata);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await new HttpClient().PutAsync($"https://localhost:7264/api/Patients/{id}?gender={gender}&bloodtype={bloodtype}", content);

            //menghandal response
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Patient updated successfully!");
            }
            else
            {
                if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("email or phone number already used by another patient");
                    return;
                }
                MessageBox.Show("Failed to edit patient. Please check the ID and try again.");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validasi id pasien aar berupa integer
            if (!int.TryParse(textBox1.Text, out int id))
            {
                MessageBox.Show("Please enter a valid Patient ID");
                return;
            }

            //menghandal agar input gender dan bloodtype nullable
            string? gender = null;
            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                gender = comboBox1.Text;
            }

            string? bloodtype = null;
            if (!string.IsNullOrEmpty(comboBox2.Text))
            {
                bloodtype = comboBox2.Text;
            }

            try
            {
                EditPatientData(id, gender, bloodtype);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HalamanAdmin adminpage = new HalamanAdmin(admin);
            adminpage.Show();

            this.Close();
        }

        private void EditPatient_Load(object sender, EventArgs e)
        {

        }
    }
}
