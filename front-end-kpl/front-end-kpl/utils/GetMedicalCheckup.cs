using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace front_end_kpl.utils
{
    public class MedicalCheckUp
    {
        public int medicalChekUpId { get; set; }
        public string date { get; set; }
        public string noteMedicalChekup { get; set; }
        public string result { get; set; }
        public string doctor { get; set; }
        public string patient { get; set; }
        public int apoimentId { get; set; }
        public int patientId { get; set; }
    }

    public class GetMedicalCheckup
    {
        private static readonly Lazy<GetMedicalCheckup> _instance = new Lazy<GetMedicalCheckup>(() => new GetMedicalCheckup());
        private readonly HttpClient _httpClient;

        // Private constructor
        private GetMedicalCheckup()
        {
            _httpClient = new HttpClient();
        }

        // Singleton instance property
        public static GetMedicalCheckup Instance => _instance.Value;

        // Method to fetch medical checkups asynchronously
        public async Task<List<MedicalCheckUp>> FetchMedicalCheckupsAsync()
        {
            List<MedicalCheckUp> medicalCheckups = null;
            try
            {
                var response = await _httpClient.GetAsync("https://localhost:7264/api/MedicalCheckup");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    medicalCheckups = JsonConvert.DeserializeObject<List<MedicalCheckUp>>(content);
                }
                else
                {
                    Console.WriteLine($"Failed to fetch data. Status code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return medicalCheckups;
        }
    }
}
