using AppointmentApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace front_end_kpl.utils
{
    internal class AppoimetPatientsApp
    {
        private readonly HttpClient _httpClient;

        public AppoimetPatientsApp()
        {
            _httpClient = new HttpClient();
        }   
        public async Task<List<AppointmentPatient>> FetchAppointmentsAsync() { 
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

public class AppointmentPatient {
    public int appoimentId { get; set; }
    public int patientId { get; set; }

}
