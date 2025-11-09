
using System;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string apiUrl = "http://api.example.com/data";
        
        using(var httpClient = new HttpClient())
        {
            var response = await httpClient.GetAsync(apiUrl);
            var apiResponse = await response.Content.ReadAsStringAsync();
            
            JObject json = JObject.Parse(apiResponse);
            JArray dataArray = json["data"] as JArray;
            
            foreach(var item in dataArray)
            {
                string name = item["name"].ToString();
                int value = (int)item["value"];
                
                Console.WriteLine($"Name: {name}, Value: {value}");
            }
        }
    }
}
