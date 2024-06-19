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
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace front_end_kpl.view
{
    public partial class EditAdmin : Form
    {
        Admin admin;
        public EditAdmin(Admin admin)
        {
            InitializeComponent();
            this.admin = admin; 
        }

        public class UploadData
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string phoneNumber { get; set; }
            public string email { get; set; }
        }

        public async Task EditAdminData(int id)
        {
            id = int.Parse(textBox1.Text);

            //membuat instansi UploadData dengan user input
            var checkdata = new UploadData
            {
                firstName = textBox2.Text,
                lastName = textBox3.Text,
                phoneNumber = textBox5.Text,
                email = textBox4.Text,
            };

            //serialise data admin ke JSON
            var jsonContent = JsonSerializer.Serialize(checkdata);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await new HttpClient().PutAsync($"https://localhost:7264/api/Admin/{id}", content);

            //menghandal response
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Admin updated successfully!");
            }
            else
            {
                MessageBox.Show("Failed to edit admin. Please check the ID and try again");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
 //validasi agar inputtan id berupa integer
            if (!int.TryParse(textBox1.Text, out int id))
            {
                MessageBox.Show("Please enter a valid Admin ID");
                return;
            }

            try
            {
                //validasi semua textfield agar tidak ada yang null
                if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                    string.IsNullOrWhiteSpace(textBox2.Text) ||
                    string.IsNullOrWhiteSpace(textBox3.Text) ||
                    string.IsNullOrWhiteSpace(textBox4.Text) ||
                    string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    MessageBox.Show("None of the fields may be empty");
                    return;
                }
                EditAdminData(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HalamanAdmin halamanAdmin = new HalamanAdmin(admin);
            halamanAdmin.Show();

            this.Close();
        }
    }
}
