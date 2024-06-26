﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace front_end_kpl.view
{
    public partial class DeleteAdmin : Form
    {
        Admin admin;
        public DeleteAdmin(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        public async Task DeleteAdminByID(string id)
        {
            //buat client baru yang connect ke api localhost
            var client = new HttpClient();
            string api = $"https://localhost:7264/api/Admin/{id}";

            HttpResponseMessage response = await client.DeleteAsync(api);

            //cek jika response sukses atau tidak, display pesan yang sesuai
            string responseContent = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Admin deleted successfully!");
            }
            else
            {
                MessageBox.Show("Failed to delete admin. "+ responseContent);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;

            //cek jika admin ID valid
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter a valid Admin ID");
                return;
            }

            if (!int.TryParse(id, out _))
            {
                MessageBox.Show("Please enter a valid Admin ID (numeric value)");
                return;
            }

            DeleteAdminByID(id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HalamanAdmin halamanAdmin = new HalamanAdmin(admin);
            halamanAdmin.Show();

            this.Close();
        }
    }
}
