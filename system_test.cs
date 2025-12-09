using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class Program
{
    // Define classes to match JSON structure
    public class ApiResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public static async Task Main(string[] args)
    {
        string apiUrl = "https://api.example.com/data"; // Replace with your API endpoint

        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Send GET request
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                // Read response content as string
                string jsonResponse = await response.Content.ReadAsStringAsync();

                // Deserialize JSON to object
                ApiResponse data = JsonConvert.DeserializeObject<ApiResponse>(jsonResponse);

                // Process data (e.g., display)
                Console.WriteLine($"ID: {data.Id}");
                Console.WriteLine($"Name: {data.Name}");
                Console.WriteLine($"Description: {data.Description}");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
            }
            catch (JsonException e)
            {
                Console.WriteLine($"JSON parsing error: {e.Message}");
            }
        }
    }
}