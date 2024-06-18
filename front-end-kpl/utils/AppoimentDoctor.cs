using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace front_end_kpl.utils
{
    public class Appoiment
    {
        public int appoimentId { get; set; }
        public string timeStart { get; set; }
        public string timeEnd { get; set; }
        public int status { get; set; }
        public bool isCompleted { get; set; }
        public int sapacity { get; set; }
        public string room { get; set; }
        public string doctor { get; set; }
        public string date { get; set; }
        public int doctorId { get; set; }
        public string specialization { get; set; }
    }

    public class AppoimentDoctor
    {
        private static readonly Lazy<AppoimentDoctor> _instance = new Lazy<AppoimentDoctor>(() => new AppoimentDoctor());
        private readonly HttpClient _httpClient;

        // Private constructor
        private AppoimentDoctor()
        {
            _httpClient = new HttpClient();
        }

        // Singleton instance property
        public static AppoimentDoctor Instance => _instance.Value;

        // Method to fetch appointments asynchronously
        public async Task<List<Appoiment>> FetchAppointmentsAsync()
        {
            List<Appoiment> appointments = null;
            try
            {
                var response = await _httpClient.GetAsync("https://localhost:7264/api/Appoiment");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    appointments = JsonConvert.DeserializeObject<List<Appoiment>>(content);
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

            return appointments;
        }
    }
}
