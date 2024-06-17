using AppointmentApp;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

public class AppomentData
{
    public string timeStart { get; set; }
    public string timeEnd { get; set; }
    public int status { get; set; }
    public int sapacity { get; set; }
    public bool isComplete { get; set; }
    public string date { get; set; }
}

public class PostAppointment
{
    private static readonly HttpClient _client = new HttpClient();
    private static PostAppointment _instance;
    private static readonly string _baseUrl = "https://localhost:7264/api/Appoiment";

    private PostAppointment()
    {
        // Private constructor to prevent external instantiation
    }

    public static PostAppointment Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new PostAppointment();
            }
            return _instance;
        }
    }

    public static void Initialize()
    {
        // Initialize the singleton instance if not already initialized
        if (_instance == null)
        {
            _instance = new PostAppointment();
        }
    }

    public string BaseUrl => _baseUrl;

    public async Task CreateAppointmentAsync(AppomentData appointment, int doctorid, int roomid)
    {
        try
        {
            var jsonContent = JsonSerializer.Serialize(appointment);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.PostAsync($"{_baseUrl}?doctorId={doctorid}&roomId={roomid}", content);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Appointment data posted successfully.");
            }
            else
            {
                Console.WriteLine($"Failed to post appointment data. Status code: {response.StatusCode}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while creating appointment: {ex.Message}");
        }
    }

    public async Task EditAppointmentAsync(AppomentData appointment, int doctorId, int roomId, int appointmentId)
    {
        try
        {
            var jsonContent = JsonSerializer.Serialize(appointment);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.PutAsync($"{_baseUrl}/{appointmentId}?doctorID={doctorId}&roomID={roomId}", content);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Appointment data updated successfully.");
                MessageBox.Show("Appointment data updated successfully.");
            }
            else
            {
                Console.WriteLine($"Failed to update appointment data. Status code: {response.StatusCode}");
                MessageBox.Show("Appointment data failed to update.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while editing appointment data: {ex.Message}");
        }
    }
}
