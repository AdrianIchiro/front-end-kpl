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

namespace front_end_kpl.view
{
    public partial class AddAdmin : Form
    {
        public AddAdmin()
        {
            InitializeComponent();
        }

        public class UploadData
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string phoneNumber { get; set; }
            public string email { get; set; }
            public string password { get; set; }

        }

        public async Task Register()
        {
            var checkdata = new UploadData
            {
                firstName = textBox1.Text,
                lastName = textBox2.Text,
                email = textBox3.Text,
                phoneNumber = textBox4.Text,
                password = textBox5.Text,
            };

            var JsonContent = JsonSerializer.Serialize(checkdata);
            var content = new StringContent(JsonContent, Encoding.UTF8, "application/json");


            HttpResponseMessage response = await new HttpClient().PostAsync("https://localhost:7264/api/Admin", content);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.IsSuccessStatusCode);
            } else
            {
                MessageBox.Show("Data salah");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register();
        }
    }



   
    
}
