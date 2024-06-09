using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace front_end_kpl.utils
{
    public class Room
    {
        public int roomId { get; set; }
        public string roomName { get; set; }
        public int roomFloor { get; set; }
        public int roomNumber { get; set; }
    }
    internal class RoomApp
    {
        private readonly HttpClient _httpClient;

        public RoomApp()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7264/api/");
        }

        public async Task<List<Room>> GetAllRoomsAsync()
        {
            List<Room> rooms = new List<Room>();

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("Room");
                response.EnsureSuccessStatusCode(); // Throws if not successful

                string responseBody = await response.Content.ReadAsStringAsync();

                // Deserialize the JSON response into a list of Room objects
                rooms = JsonSerializer.Deserialize<List<Room>>(responseBody);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error fetching rooms: {ex.Message}");
            }

            return rooms;
        }
    }

    
}
