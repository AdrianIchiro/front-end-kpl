﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AppointmentApp
{
    //class for Represents an appointment
    public class Appointment
    {
        public int AppoimentId { get; set; }
        public string TimeStart { get; set; }
        public string TimeEnd { get; set; }
        public int Status { get; set; }
        public bool IsCompleted { get; set; }
        public int sapacity { get; set; }
        public string room { get; set; }
        public string Doctor { get; set; }
        public DateTime date { get; set; }
        public string speciaLization { get; set; }
        public int DoctorId { get; set; }
        public string specialization { get; set; }
    }
    // Service to interact with appointment API
    public class AppointmentService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl;
        private static Lazy<AppointmentService> _instance;

        // Private constructor to enforce singleton pattern
        private AppointmentService()
        {
            _httpClient = new HttpClient();
            _apiUrl = "https://localhost:7264/api/Appoiment";
        }
        // Initializes the singleton instance of the service
        public static void Initialize()
        {
            if (_instance == null)
            {
                _instance = new Lazy<AppointmentService>(() => new AppointmentService());
            }
        }
        // Gets the singleton instance of the service
        public static AppointmentService Instance
        {
            get
            {
                if (_instance == null)
                {
                    throw new InvalidOperationException("AppointmentService is not initialized. Call Initialize(apiUrl) first.");
                }
                return _instance.Value;
            }
        }
        // Fetches all appointments asynchronously
        public async Task<List<Appointment>> FetchAppointmentsAsync()
        {
            List<Appointment> appointments = null;

            try
            {
                var response = await _httpClient.GetAsync(_apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    appointments = JsonConvert.DeserializeObject<List<Appointment>>(content);
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
        // Fetches a specific appointment by ID asynchronously
        public async Task<Appointment> GetAppointmentAsyncInternal(int appointmentId)
        {
            var requestUrl = $"{_apiUrl}/{appointmentId}";
            var response = await _httpClient.GetAsync(requestUrl);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var appointment = JsonConvert.DeserializeObject<Appointment>(content);
            return appointment;
        }
        // Deletes an appointment by ID asynchronously
        public async Task DeleteAppoiment(int id)
        {
            var requestUrl = $"{_apiUrl}/{id}";
            HttpResponseMessage response = await _httpClient.DeleteAsync(requestUrl);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Appoiment deleted successfully!");
            }
            else
            {
                Console.WriteLine("Failed to delete Appoiment");
            }
        }
    }
}
