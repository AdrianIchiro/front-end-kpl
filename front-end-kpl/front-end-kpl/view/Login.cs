using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Net;
using front_end_kpl.utils;
using Newtonsoft.Json;
namespace front_end_kpl.view
{

    public class Admin
    {
        public int adminId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
    }

    public class Patient
    {
        public int patientId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public DateOnly birthDate { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
    }


    public partial class Login : Form
    {
        //field untuk menstore credential user 
        string _email, _password, _role;
        //membuat enumuntuk mendefinisi role role user
        enum UserRole { Admin, Doctor, Patient, None };
        UserRole _currentRole = UserRole.None;

        public Login()
        {
            InitializeComponent();
            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            textBox2.PasswordChar = '*';
            comboBox1.SelectedIndex = 2;
        }

        //class untuk mengstore data authentikasi user
        public class Authenticate
        {
            public string email { get; set; }
            public string password { get; set; }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
                // Implement your logic here for when the checkbox is checked
            }
            else
            {
                textBox2.PasswordChar = '*';
                // Implement your logic here for when the checkbox is unchecked
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = (string)comboBox1.SelectedItem;

            //set state _currentRole menggunakan if statement berdasarkan role yang dipilih
            if (selected.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                _currentRole = UserRole.Admin;
            }
            else if (selected.Equals("Doctor", StringComparison.OrdinalIgnoreCase))
            {
                _currentRole = UserRole.Doctor;
            }
            else if (selected.Equals("Patient", StringComparison.OrdinalIgnoreCase))
            {
                _currentRole = UserRole.Patient;
            }
            else
            {
                _currentRole = UserRole.None;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Email and password must be filled");
            }

            //membuat instansi authentikasi menggunakan user input
            var checkdata = new Authenticate
            {
                email = textBox1.Text,
                password = textBox2.Text,
            };

            HttpResponseMessage response = null;

            //serialize data authentikasi ke JSON
            var jsonContent = System.Text.Json.JsonSerializer.Serialize(checkdata);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            //cek jika role yang dipilih valid
            if (_currentRole == UserRole.None)
            {
                MessageBox.Show("Invalid role");
                return;
            }

            //kirim login request berdasarkan role yang dipilih, menggunakan automata
            switch (_currentRole)
            {
                case UserRole.Admin:
                    response = await new HttpClient().PostAsync("https://localhost:7264/api/Admin/login", content);
                    break;
                case UserRole.Doctor:
                    response = await new HttpClient().PostAsync("https://localhost:7264/api/Doctor/login", content);
                    break;
                case UserRole.Patient:
                    response = await new HttpClient().PostAsync("https://localhost:7264/api/Patients/login", content);
                    break;
                default:
                    response = new HttpResponseMessage
                    {
                        StatusCode = HttpStatusCode.BadRequest,
                        Content = new StringContent("Invalid role specified")
                    };
                    break;
            }

            //handle response
            if (response != null)
            {
                string responseContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    switch (_currentRole)
                    {
                        case UserRole.Admin:
                            Admin admin = System.Text.Json.JsonSerializer.Deserialize<Admin>(responseContent);
                            MessageBox.Show("Welcome " + admin.firstName);
                            HalamanAdmin halamanAdmin = new HalamanAdmin(admin);
                            halamanAdmin.Show();
                            this.Hide();
                            break;
                        case UserRole.Doctor:
                            Doctor doctor = System.Text.Json.JsonSerializer.Deserialize<Doctor>(responseContent);
                            MessageBox.Show("Welcome Doctor " + doctor.firstName);
                            HalamanDoctor halamanDoctor = new HalamanDoctor(doctor);
                            halamanDoctor.Show();
                            this.Hide();
                            break;
                        case UserRole.Patient:
                            Patient patient = System.Text.Json.JsonSerializer.Deserialize<Patient>(responseContent);
                            MessageBox.Show("Welcome " + patient.firstName);
                            HalamanPatient halamanPatient = new HalamanPatient(patient);
                            halamanPatient.Show();
                            this.Hide();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid email or password. " + responseContent);
                }
            }
            else
            {
                MessageBox.Show("Failed to get a response from the server.");
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();

            this.Hide();
        }
    }
}