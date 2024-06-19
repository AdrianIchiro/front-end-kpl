using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace front_end_kpl.utils
{
    // Singleton class for booking Appoiment
    public class BookAppoiment
    {
        private readonly HttpClient _client;
        private static readonly Lazy<BookAppoiment> _instance = new Lazy<BookAppoiment>(() => new BookAppoiment());
        // Private constructor to enforce singleton pattern
        private BookAppoiment()
        {
            _client = new HttpClient();
        }
        // Public property to access the singleton instance
        public static BookAppoiment Instance => _instance.Value;
        // Method to book an appointment for a patient asynchronously
        public async void BookAppointmentPatientAsync(int patientId, int appoimentId)
        {
            HttpContent emptyContent = new StringContent(string.Empty);
            HttpResponseMessage response = await _client.PostAsync($"https://localhost:7264/api/AppoimentPatien?appoiment={appoimentId}&patient={patientId}", emptyContent);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Book Appoiment posted successfully.");
            }
            else
            {
                Console.WriteLine($"Failed to Book Appoiment data. Status code: {response.StatusCode}");
            }
        }
    }
}
