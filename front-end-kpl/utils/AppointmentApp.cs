using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AppointmentApp
{
    public class Appointment
    {
        public int AppoimentId { get; set; }
        public string TimeStart { get; set; }
        public string TimeEnd { get; set; }
        public int Status { get; set; }
        public bool IsCompleted { get; set; }
        public int Capacity { get; set; }
        public int Room { get; set; }
        public string Doctor { get; set; }
        public DateTime date { get; set; }  
    }

    public class AppointmentService
    {
        private readonly HttpClient _httpClient;

        public AppointmentService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<Appointment>> FetchAppointmentsAsync(string apiUrl)
        {
            List<Appointment> appointments = null;

            try
            {
                var response = await _httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    appointments = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Appointment>>(content);
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