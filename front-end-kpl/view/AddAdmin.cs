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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace front_end_kpl.view
{
    public partial class AddAdmin : Form
    {
        public AddAdmin()
        {
            InitializeComponent();
        }

        //class untuk store data pasien inputtan user
        public class UploadData
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string phoneNumber { get; set; }
            public string email { get; set; }
            public string password { get; set; }
        }

        public async Task RegisterNewAdmin()
        {
            //Buat instance UploadData dengan user input
            var checkdata = new UploadData
            {
                firstName = textBox1.Text,
                lastName = textBox2.Text,
                email = textBox3.Text,
                phoneNumber = textBox4.Text,
                password = textBox5.Text,
            };

            //Serialise data admin  ke JSON
            var JsonContent = JsonSerializer.Serialize(checkdata);
            var content = new StringContent(JsonContent, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await new HttpClient().PostAsync("https://localhost:7264/api/Admin", content);

            //cek jika response sukses atau tidak, display pesan yang sesuai
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Admin added successfully!");
            }
            else
            {
                MessageBox.Show("Failed to add admin. Please check the data and try again");
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //cek agar tidak ada texbox yang null
                if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                    string.IsNullOrWhiteSpace(textBox2.Text) ||
                    string.IsNullOrWhiteSpace(textBox3.Text) ||
                    string.IsNullOrWhiteSpace(textBox4.Text) ||
                    string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    MessageBox.Show("None of the fields may be empty");
                    return;
                }
                RegisterNewAdmin();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { 
        HalamanAdmin admin = new HalamanAdmin();
        admin.Show();

        this.Close();
        }
    }
}
