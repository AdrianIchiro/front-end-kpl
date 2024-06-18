using System.Net.Http;
using System.Threading.Tasks;
using System;
using Newtonsoft.Json;

namespace frontEnd
{
    internal class FetchAdmin
    {
        public async Task<AdminData> ParseAdminDataAsync(int adminId)
        {
            AdminData adminData = null;

            try
            {
                string url = $"https://localhost:7264/api/Admin/{adminId}";
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        adminData = JsonConvert.DeserializeObject<AdminData>(json);
                    }
                    else
                    {
                        Console.WriteLine($"Failed to fetch admin data. Status code: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return adminData;
        }
    }

    internal class AdminData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class Admin
    {
        public int AdminId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}