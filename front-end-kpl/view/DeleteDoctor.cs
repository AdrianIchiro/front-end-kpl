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
            InitializeComponent();
            this.admin = admin;
        }

        public async Task DeleteDoctorByID(string id)
        {
            //buat client baru yang connect ke api localhost
            var client = new HttpClient();
            string api = $"https://localhost:7264/api/Doctor/{id}";

            HttpResponseMessage response = await client.DeleteAsync(api);

            //cek jika response sukses atau tidak, display pesan yang sesuai
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Doctor deleted successfully!");
            }
            else
            {
                MessageBox.Show("Failed to delete doctor. Please check the ID and try again");
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
            DeleteDoctorByID(id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HalamanAdmin admin = new HalamanAdmin(admin);
            admin.Show();

            this.Close();
        }
    }
}
