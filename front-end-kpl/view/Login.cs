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
        //Automata.automata.State state = Automata.automata.State.LOGIN, nextPosisi;
        string email, pass, role;

        public Login()
        {
            InitializeComponent();
        }

        public class Authenticate
        {
            public string email { get; set; }
            public string password { get; set; }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            role = (string)comboBox1.SelectedItem;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var checkdata = new Authenticate
            {
                email = textBox1.Text,
                password = textBox2.Text,
            };

            HttpResponseMessage response = null;

            var jsonContent = JsonSerializer.Serialize(checkdata);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");


            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Invalid role");
                return;
            }


            if (role.Equals("Admin"))
            {
                response = await new HttpClient().PostAsync("https://localhost:7264/api/Admin/login", content);
            }
            else if (role.Equals("Doctor"))
            {
                response = await new HttpClient().PostAsync("https://localhost:7264/api/Doctor/login", content);
            }
            else if (role.Equals("Patient"))
            {
                response = await new HttpClient().PostAsync("https://localhost:7264/api/Patients/login", content);
            }
            else
            {
                response = new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Content = new StringContent("Invalid role specified")
                };
            }

            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();

                if (role.Equals("Admin"))
                {
                    Admin admin = JsonSerializer.Deserialize<Admin>(responseContent);
                    MessageBox.Show("Welcome " + admin.firstName);
                    HalamanAdmin halamanAdmin = new HalamanAdmin(admin);
                    halamanAdmin.Show();
                    this.Hide();
                }
                else if (role.Equals("Doctor"))
                {
                    
                    Doctor  doctor = JsonSerializer.Deserialize<Doctor>(responseContent);
                    MessageBox.Show("Welcome Doctor " + doctor.firstName);
                    HalamanDoctor halamanDoctor = new HalamanDoctor(doctor);
                    halamanDoctor.Show();
                    this.Hide();
                }
                else if (role.Equals("Patient"))
                {
                    Patient patient = JsonSerializer.Deserialize<Patient>(responseContent); 
                    MessageBox.Show("Welcome " + patient.firstName);
                    HalamanPatient halamanPatient = new HalamanPatient(patient);
                    halamanPatient.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("nama dan password salah");
                }


            }
            else
            {
                MessageBox.Show("nama dan password salah");
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
