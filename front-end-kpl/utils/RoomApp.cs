using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using front_end_kpl.view;
using System.Resources;
using System.Globalization;

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
        private ResourceManager rm;

        // Design pattern Singleton
        // Instansi singleton
        private static RoomApp _instance;

        // objek untuk keamanan
        private static readonly object _lock = new object();

        // Menggunakan private biar mencegah instantiasi
        // httpclient buat melakukan permintaan http (get, put, post, delte)
        // baseaddress untuk mengatur httpclient tadi ke url API
        private RoomApp()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7264/api/");
            rm = new ResourceManager("front_end_kpl.Language.Strings", typeof(Room).Assembly);
        }

        // Method untuk mendapatkan instance singleton
        public static RoomApp Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new RoomApp();
                        }
                    }
                }
                return _instance;
            }
        }

        // Print semua ruangan
        public async Task<List<Room>> GetAllRoomsAsync()
        {
            List<Room> rooms = new List<Room>();

            try
            {
                // Melakukan permintaan http get dan melakukan pengecekan
                // Jika gagal lempar exception
                HttpResponseMessage response = await _httpClient.GetAsync("Room");
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                // Melakukan deserialisasi dari JSON menjadi list ruangan
                rooms = JsonSerializer.Deserialize<List<Room>>(responseBody);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error fetching rooms: {ex.Message}");
            }

            return rooms;
        }

        // Menambahkan sebuah ruangan
        public async Task<Room> PostRoom(String name, int floor, int number)
        {
            try
            {
                // Membuat list yang akan digunakan untuk pengecekan
                var rooms = await GetAllRoomsAsync();

                // Mengecek jika ruangan dengan lantai dan nomor ruangan yang sama sudah terdaftar
                if (rooms.Any(r => r.roomFloor == floor && r.roomNumber == number))
                {
                    MessageBox.Show(rm.GetString("MRoomExist", CultureInfo.CurrentCulture));
                    return null;
                }

                // Membuat instance room untuk proses post nanti
                var newRoom = new Room
                {
                    roomName = name,
                    roomFloor = floor,
                    roomNumber = number
                };

                // Mengonversi newRoom menjadi string JSON
                // Agar data objek bisa dikirim ke database dengan format yang dapat diterima
                var jsonContent = JsonSerializer.Serialize(newRoom);

                // Baris ini membuat objek StringContent yang akan digunakan sebagai konten dari permintaan http post
                // System.Text.Encoding.UTF8 itu encoding yang digunakan
                // application/json merupakan tipe konten
                var content = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");

                // Mengirimkan permintaan http post
                HttpResponseMessage response = await _httpClient.PostAsync("Room", content);
                // Menerima status sukses dari database, jika gagal lempar exception
                response.EnsureSuccessStatusCode();

                // Membaca isi respons dari server sebagai string 
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

        // Hapus ruangan dengan id yang diinput
        public async Task<bool> DeleteRoom(int id)
        {

            try
            {
                // Membuat list yang akan digunakan untuk pengecekan
                var rooms = await GetAllRoomsAsync();


                // Melakukan pengecekan jika ruangan tidak ada
                if (!rooms.Any(r => r.roomId == id))
                {
                    MessageBox.Show(rm.GetString("MRoomNotExist", CultureInfo.CurrentCulture));
                    return false;
                }

                // Mengirim permintaan http delete untuk menghapus room dengan id yang sudah diinput
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


        // Update ruangan dengan id yang diinput
        public async Task<Room> UpdateRoom(int id, string name, int floor, int number)
        {

            // Membuat list yang akan digunakan untuk pengecekan
            var rooms = await GetAllRoomsAsync();

            // Mengecek jika ruangan tidak ada
            if (!rooms.Any(r => r.roomId == id))
            {
                MessageBox.Show(rm.GetString("MRoomNotExist", CultureInfo.CurrentCulture));
                return null; // Or throw an exception or return an error message
            }

            // Membuat instance room untuk proses put nanti
            var updatedRoom = new Room
            {
                roomId = id,
                roomName = name,
                roomFloor = floor,
                roomNumber = number
            };

            try
            {
                // Baris ini membuat objek StringContent yang akan digunakan sebagai konten dari permintaan http post
                // System.Text.Encoding.UTF8 itu encoding yang digunakan
                // application/json merupakan tipe konten
                var jsonContent = JsonSerializer.Serialize(updatedRoom);
                var content = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");

                // Melakukan permintaan http put
                HttpResponseMessage response = await _httpClient.PutAsync($"Room/{id}", content);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                // Menulis respon server
                Console.WriteLine($"Response body: {responseBody}");

                // Menegecek jika respon null
                if (string.IsNullOrWhiteSpace(responseBody))
                {
                    Console.WriteLine("Response body is empty.");
                    return null;
                }

                // Melakukan deserialisasi responsebody
                var room = JsonSerializer.Deserialize<Room>(responseBody);
                return room;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error updating room: {ex.Message}");
                return null;
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Error deserializing JSON: {ex.Message}");
                return null;
            }
        }
    }

    
}
