
using System;
using System.Net.Http;

class Program
{
  static async void Main(string[] args)
  {
    const string consumerKey = "YOUR_CONSUMER_KEY";
    const string consumerSecret = "YOUR_CONSUMER_SECRET";
    const string accessToken = "YOUR_ACCESS_TOKEN";
    const string accessTokenSecret = "YOUR_ACCESS_TOKEN_SECRET";
    
    const string baseUrl = "https://api.twitter.com/2/tweets/search/recent?query=";
    
    HttpClient client = new HttpClient();
    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");
    
    string query = "Python";
    
    HttpResponseMessage response = await client.GetAsync($"{baseUrl}{query}");
    
    if (response.IsSuccessStatusCode)
    {
        string responseData = await response.Content.ReadAsStringAsync();
        Console.WriteLine(responseData);
    }
    else
    {
        Console.WriteLine("Failed to retrieve data. Status code: " + response.StatusCode);
    }
  }
}
