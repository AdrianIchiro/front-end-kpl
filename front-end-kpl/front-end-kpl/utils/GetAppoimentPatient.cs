using front_end_kpl.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace front_end_kpl.utils
{
    public class GetAppoimentPatients
    {
        public int appoimentId { get; set; }
        public string appoiment { get; set; }
        public int patientId { get; set; }
        public string patient { get; set; }

    }

    internal class GetAppoimentPatient
    {

        public async Task<List<GetAppoimentPatients>> GetAppoimentPatients(int id)
        {
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                handler.ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) => { return true; };

                HttpClient client = new HttpClient(handler);
                HttpResponseMessage response = await client.GetAsync($"https://localhost:7264/api/AppoimentPatien/{id}");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var appoimentPatient = Newtonsoft.Json.JsonConvert.DeserializeObject<List<GetAppoimentPatients>>(content);
                    return appoimentPatient;
                }
                else
                {
                    MessageBox.Show("Error: " + response.StatusCode);
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
                return null;
            }
        }
    }
}


