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
    public partial class DeletePatient : Form
    {
        Admin admin;
        public DeletePatient(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        public async Task DeletePatientById(string id)
        {
            //buat client baru yang connect ke api localhost
            var client = new HttpClient();
            string api = $"https://localhost:7264/api/Patients/{id}";

            HttpResponseMessage response = await client.DeleteAsync(api);

            //cek jika response sukses atau tidak, display pesan yang sesuai
            string responseContent = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Patient deleted successfully!");
            }
            else
            {
                MessageBox.Show("Failed to delete patient. " + responseContent);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;

            //cek jika patient ID valid
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter a valid Patient ID");
                return;
            }

            if (!int.TryParse(id, out _))
            {
                MessageBox.Show("Please enter a valid Patient ID (numeric value)");
                return;
            }

            DeletePatientById(id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HalamanAdmin adminpage = new HalamanAdmin(admin);
            adminpage.Show();

            this.Close();
        }
    }
}

