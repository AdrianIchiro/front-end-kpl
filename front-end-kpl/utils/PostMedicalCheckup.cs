using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace front_end_kpl.utils
{
    public class MedicalCheckUpData
    {
        public string date { get; set; }
        public string NoteMedicalChekup { get; set; }
        public string result { get; set; }
    }

    public class PostMedicalCheckup
    {
        private static readonly Lazy<PostMedicalCheckup> _instance = new Lazy<PostMedicalCheckup>(() => new PostMedicalCheckup());
        private readonly HttpClient _httpClient;

        private PostMedicalCheckup()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) => { return true; };

            _httpClient = new HttpClient(handler);
        }

        public static PostMedicalCheckup Instance => _instance.Value;

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

            try
            {
                HttpResponseMessage response = await _httpClient.PostAsync($"https://localhost:7264/api/MedicalCheckUp?appoimentId={appoimentid}&patientID={patientid}&doctorId={doctorid}", content);
                Console.WriteLine(response.IsSuccessStatusCode);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Data berhasil dimasukkan.");
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
