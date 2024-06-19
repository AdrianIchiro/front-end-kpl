using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace front_end_kpl.utils
{
    public class Doctor
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string specialization { get; set; }
        public string address { get; set; }
        public DateOnly birthDate { get; set; }
       public string phoneNumber { get; set; }
        public string email { get; set; }

        public static implicit operator int(Doctor? v)
        {
            throw new NotImplementedException();
        }
    }
    internal class DoctorApp
    {
        private readonly HttpClient _httpClient;
        public DoctorApp() {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7264/api/");
        }
        public async Task<List<Doctor>> GetAllDoctorsAsync()
        {
            List<Doctor> doctors = new List<Doctor>();

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("Doctor");
                response.EnsureSuccessStatusCode(); // Throws if not successful

                string responseBody = await response.Content.ReadAsStringAsync();

                // Deserialize the JSON response into a list of Room objects
                doctors = JsonSerializer.Deserialize<List<Doctor>>(responseBody);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error fetching rooms: {ex.Message}");
            }

            return doctors;
        }
    }
}
