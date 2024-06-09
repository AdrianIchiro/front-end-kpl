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
namespace front_end_kpl.view
{
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
            if (role.Equals("Admin"))
            {
                 response = await new HttpClient().PostAsync("https://localhost:7264/api/Admin/login", content);
            } else if (role.Equals("Doctor"))
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

                if (role.Equals("Admin"))
                {
                    MessageBox.Show("Welcome " + textBox1.Text);
                    HalamanAdmin halamanAdmin = new HalamanAdmin();
                    halamanAdmin.Show();
                    this.Hide();
                } else if (role.Equals("Doctor"))
                {
                    MessageBox.Show("Welcome Doctor " + textBox1.Text);
                    HalamanDoctor halamanDoctor = new HalamanDoctor();
                    halamanDoctor.Show();
                    this.Hide();
                }
                else if(role.Equals("Patient"))
                {
                    MessageBox.Show("Welcome " + textBox1.Text);
                    HalamanPatient halamanPatient = new HalamanPatient();
                    halamanPatient.Show();
                    this.Hide();
                } else
                {
                    MessageBox.Show("nama dan password salah");
                }


            } else
            {
                MessageBox.Show("nama dan password salah");
            }

            

        }
    }
}
