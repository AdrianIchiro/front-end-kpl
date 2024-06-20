using AppointmentApp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace front_end_kpl.utils
{
    // Singleton class to fetch appointment patients data
    internal class AppoimetPatientsApp
    {
        private readonly HttpClient _httpClient;
        private static readonly Lazy<AppoimetPatientsApp> _instance = new Lazy<AppoimetPatientsApp>(() => new AppoimetPatientsApp());

        // Private constructor to enforce singleton pattern
        private AppoimetPatientsApp()
        {
            _httpClient = new HttpClient();
        }

        // Public property to access the singleton instance
        public static AppoimetPatientsApp Instance => _instance.Value;

        // Method to fetch appointment patients asynchronously
        public async Task<List<AppointmentPatient>> FetchAppointmentsAsync()
        {
            List<AppointmentPatient> appointments = null;
            try
            {
                var response = await _httpClient.GetAsync("https://localhost:7264/api/AppoimentPatien");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    appointments = Newtonsoft.Json.JsonConvert.DeserializeObject<List<AppointmentPatient>>(content);
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

public class AppointmentPatient
{
    public int appoimentId { get; set; }
    public int patientId { get; set; }
}
