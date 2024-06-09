using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using front_end_kpl.Model;

namespace front_end_kpl.Service
{
    public class SpecializationService
    {
        private readonly HttpClient _httpClient;

        public SpecializationService()
        {
            _httpClient = new HttpClient();

        }

        //Get Specialization
        public async Task<List<SpecializationModel>> SpecializationsAsyncGet(string spcUrl)
        {
            List<SpecializationModel> specializations = null;

            try
            {
                var response = await _httpClient.GetAsync(spcUrl);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    specializations = Newtonsoft.Json.JsonConvert.DeserializeObject<List<SpecializationModel>>(content);
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

            return specializations;
        }

        // Post Specialization
        public async Task PostSpecialization(string name, string description)
        {
            var spesialization = new SpecializationModel
            {
                name = name,
                description = description
            };
            var jsonContent = JsonSerializer.Serialize(spesialization);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var apiUrl = "https://localhost:7264/api/Specialization";
            var response = await _httpClient.PostAsync(apiUrl, content);

            Console.WriteLine(response.IsSuccessStatusCode);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Specialization data posted successfully.");

            }
            else
            {
                Console.WriteLine($"Failed to post Specialization data. Status code: {response.StatusCode}");
            }

        }


        // delete berdasarkan id Specialization
        public async Task DeleteSpecialization(int id)
        {
            try
            {
                var apiUrl = $"https://localhost:7264/api/Specialization/{id}";
                var response = await _httpClient.DeleteAsync(apiUrl);

                Console.WriteLine(response.IsSuccessStatusCode);
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Specialization data deleted successfully.");
                }
                else
                {
                    Console.WriteLine($"Failed to delete Specialization data. Status code: {response.StatusCode}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        // Update berdasarkan id Specialization
        public async Task UpdateSpecialization(int id, SpecializationModel updatedSpecialization)
        {
            try
            {
                var apiUrl = $"https://localhost:7264/api/Specialization/{id}";
                var jsonContent = JsonSerializer.Serialize(updatedSpecialization);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                var response = await _httpClient.PutAsync(apiUrl, content);

                Console.WriteLine(response.IsSuccessStatusCode);
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Specialization data deleted successfully.");
                }
                else
                {
                    Console.WriteLine($"Failed to delete Specialization data. Status code: {response.StatusCode}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

    }
}
