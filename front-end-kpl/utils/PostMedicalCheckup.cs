using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace front_end_kpl.utils
{
    public class MedicalCheckUpData
    {
        public string date { get; set; }
        public string NoteMedicalChekup { get; set; }
        public string result { get; set; }
    }

    
    internal class PostMedicalCheckup
    {
        public async Task PostMedicalCheckUp(string date, string note, string result, int doctorid, int patientid, int appoimentid)
        {
            var checkUpData = new MedicalCheckUpData
            {
                date = date,
                NoteMedicalChekup = note,
                result = result,
            };

            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) => { return true; };

            var jsonContent = JsonSerializer.Serialize(checkUpData);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await new HttpClient(handler).PostAsync($"https://localhost:7264/api/MedicalCheckUp?appoimentId={appoimentid}&patientID={patientid}&doctorId={doctorid}", content);
                Console.WriteLine(response.IsSuccessStatusCode);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("data berhasil di masukan");
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(errorContent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }
    }
}
