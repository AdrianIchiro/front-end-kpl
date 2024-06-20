using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace front_end_kpl.view
{
    public partial class DeleteDoctor : Form
    {
        Admin admin;
        public DeleteDoctor(Admin admin)
        {
            this.admin = admin;
            InitializeComponent();
           
        }

        public async Task DeleteDoctorByID(string id)
        {
            //buat client baru yang connect ke api localhost
            var client = new HttpClient();
            string api = $"https://localhost:7264/api/Doctor/{id}";

            HttpResponseMessage response = await client.DeleteAsync(api);

            //cek jika response sukses atau tidak, display pesan yang sesuai
            string responseContent = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Doctor deleted successfully!");
            }
            else
            {
                MessageBox.Show("Failed to delete doctor. " + responseContent);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;

            //cek jika doctor ID valid
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter a valid Doctor ID");
                return;
            }

            if (!int.TryParse(id, out _))
            {
                MessageBox.Show("Please enter a valid Doctor ID (numeric value)");
                return;
            }

            DeleteDoctorByID(id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HalamanAdmin adminpage = new HalamanAdmin(admin);
            adminpage.Show();

            this.Close();
        }

        private void DeleteDoctor_Load(object sender, EventArgs e)
        {

        }
    }
}
