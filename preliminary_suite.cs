
using HtmlAgilityPack;
using System;
using System.Net;

class Program
{
    static void Main()
    {
        string url = "https://www.example.com/jobs";
        
        HtmlWeb web = new HtmlWeb();
        HtmlDocument doc = web.Load(url);

        HtmlNodeCollection jobPostings = doc.DocumentNode.SelectNodes("//div[@class='job-posting']");
        
        if(jobPostings != null)
        {
            foreach(HtmlNode jobPosting in jobPostings)
            {
                string jobTitle = jobPosting.SelectSingleNode(".//h2").InnerText;
                string company = jobPosting.SelectSingleNode(".//p[@class='company']").InnerText;
                string location = jobPosting.SelectSingleNode(".//p[@class='location']").InnerText;
                string description = jobPosting.SelectSingleNode(".//div[@class='description']").InnerText;

                Console.WriteLine("Job Title: " + jobTitle.Trim());
                Console.WriteLine("Company: " + company.Trim());
                Console.WriteLine("Location: " + location.Trim());
                Console.WriteLine("Description: " + description.Trim());
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("No job postings found.");
        }
    }
}
