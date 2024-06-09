using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using front_end_kpl.view;

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
            _httpClient.BaseAddress = new Uri("https://localhost:7264/api/Room");
        }


        //Print semua ruangan
        public async Task<List<Room>> GetAllRoomsAsync()
        {
            List<Room> rooms = new List<Room>();

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("Room");
                response.EnsureSuccessStatusCode(); 

                string responseBody = await response.Content.ReadAsStringAsync();

                
                rooms = JsonSerializer.Deserialize<List<Room>>(responseBody);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error fetching rooms: {ex.Message}");
            }

            return rooms;
        }

        //Tambahkan sebuah ruangan
        public async Task<Room> PostRoom(String name, int floor, int number)
        {
            try
            {
                
                var rooms = await GetAllRoomsAsync();

                
                if (rooms.Any(r => r.roomFloor == floor && r.roomNumber == number))
                {
                    MessageBox.Show($"Room with floor {floor} and number {number} already exists.");
                    return null; 
                }

                var newRoom = new Room
                {
                    roomName = name,
                    roomFloor = floor,
                    roomNumber = number
                };

                var jsonContent = JsonSerializer.Serialize(newRoom);
                var content = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _httpClient.PostAsync("Room", content);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                var createdRoom = JsonSerializer.Deserialize<Room>(responseBody);

                return createdRoom;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error posting room: {ex.Message}");
                return null;
            }

        }

        //Hapus ruangan yang dipilih
        public async Task<bool> DeleteRoom(int id)
        {

            try
            {
                var rooms = await GetAllRoomsAsync();

                if (!rooms.Any(r => r.roomId == id))
                {
                    MessageBox.Show($"Room with ID {id} does not exist.");
                    return false;
                }

                HttpResponseMessage response = await _httpClient.DeleteAsync($"Room/{id}");
                response.EnsureSuccessStatusCode();

                return true;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error deleting room: {ex.Message}");
                return false;
            }
        }


        //Update ruangan yang dipilih
        public async Task<Room> UpdateRoom(int id, string name, int floor, int number)
        {

            // Fetch all rooms
            var rooms = await GetAllRoomsAsync();

            // Check if a room with the same floor and number already exists
            if (!rooms.Any(r => r.roomId == id))
            {
                MessageBox.Show($"Room with ID {id} does not exist.");
                return null; // Or throw an exception or return an error message
            }

            var updatedRoom = new Room
            {
                roomId = id,
                roomName = name,
                roomFloor = floor,
                roomNumber = number
            };

            try
            {
                var jsonContent = JsonSerializer.Serialize(updatedRoom);
                var content = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _httpClient.PutAsync($"Room/{id}", content);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                var room = JsonSerializer.Deserialize<Room>(responseBody);

                return room;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error updating room: {ex.Message}");
                return null;
            }
        }

    }
}
