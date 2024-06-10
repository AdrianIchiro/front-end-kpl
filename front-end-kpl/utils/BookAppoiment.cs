using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace front_end_kpl.utils
{

    public class BookAppoiment
    {
        private readonly HttpClient _client;

        public BookAppoiment()
        {
            _client = new HttpClient();
        }
        public async void BookAppoimentPatient(int patientId, int appoimentId) 
        {
            HttpContent emptyContent = new StringContent(string.Empty);
            HttpResponseMessage response = await _client.PostAsync($"https://localhost:7264/api/AppoimentPatien?appoiment={appoimentId}&patient={patientId}",emptyContent);
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

