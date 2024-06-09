using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

public class AddAppointmentData
{
    public int appoimentId { get; set; }
    public string timeStart { get; set; }
    public string timeEnd { get; set; }
    public int status { get; set; }
    public int sapacity { get; set; } 
    public bool isComplete { get; set; }
    public string date { get; set; }
 
}

public class EditAppoment {
    public string timeStart { get; set; }
    public string timeEnd { get; set; }
    public int status { get; set; }
    public int sapacity { get; set; }
    public bool isComplete { get; set; }
    public string date { get; set; }
}

public class PostAppointment
{
    private readonly HttpClient _client;

    public PostAppointment()
    {
        _client = new HttpClient();
    }

    public async Task CreateAppointmentAsync(AddAppointmentData appointment, int doctorid, int roomid)
    {
        
       
        var AddAppoiment = appointment;
        
        var jsonContent = JsonSerializer.Serialize(AddAppoiment);
        var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
        HttpResponseMessage response = await _client.PostAsync($"https://localhost:7264/api/Appoiment?doctorId={doctorid}&roomId={roomid}", content);
       Console.WriteLine(response.IsSuccessStatusCode);

        if (response.IsSuccessStatusCode)
        {
            Console.WriteLine("Appoiment data posted successfully.");
        }
        else
        {
            Console.WriteLine($"Failed to post Appoiment data. Status code: {response.StatusCode}");
        }
    }
    public async Task EditAppointmentAsync(EditAppoment appointment, int doctorId, int roomId, int appoimentId)
    {
        try
        {
            var jsonContent = JsonSerializer.Serialize(appointment);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.PutAsync($"https://localhost:7264/api/Appoiment/{appoimentId}?doctorID={doctorId}&roomID={roomId}", content);

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
