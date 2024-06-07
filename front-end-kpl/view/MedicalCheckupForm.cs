using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace front_end_kpl.view
{
    public partial class MedicalCheckupForm : Form
    {
        public MedicalCheckupForm()
        {
            InitializeComponent();
        }


        public class MedicalCheckUpData
        {
            public string date { get; set; }
            public string NoteMedicalChekup { get; set; }
            public string result { get; set; }
        }

        public async Task PostMedicalCheckUp(string date, string note, string result, int doctorid, int patientid, int appoimentid)
        {
            var checkUpData = new MedicalCheckUpData
            {
                date = date,
                NoteMedicalChekup = note,
                result = result,
            };

            var jsonContent = JsonSerializer.Serialize(checkUpData);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await new HttpClient().PostAsync($"https://localhost:7264/api/MedicalCheckUp?appoimentId={appoimentid}&patientId={patientid}&doctorId={doctorid}", content);
            Console.WriteLine(response.IsSuccessStatusCode);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Medical check-up data posted successfully.");
            }
            else
            {
                Console.WriteLine($"Failed to post medical check-up data. Status code: {response.StatusCode}");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PostMedicalCheckUp(textBox1.Text, textBox3.Text, textBox2.Text, 1, 1, 3);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
