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
        public DeletePatient()
        {
            InitializeComponent();
        }

        public async Task Delete(string id)
        {

            var client = new HttpClient();
            string api = $"https://localhost:7264/api/Patients/{id}";

            HttpResponseMessage response = await client.DeleteAsync(api);




            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Patient deleted successfully!");
            }
            else
            {
                MessageBox.Show("Failed to delete patient. Please check the ID and try again");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter a valid Patient ID");
                return;
            }

            Delete(id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HalamanAdmin admin = new HalamanAdmin();

            admin.Show();

            this.Close();
        }
    }
}

