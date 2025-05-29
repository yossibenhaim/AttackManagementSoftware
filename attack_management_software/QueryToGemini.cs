using DotNetEnv;
using Sprache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Google.Apis.Requests.BatchRequest;

namespace attack_management_software
{
    internal class QueryToGemini
    {
        public HttpClient client;

        public QueryToGemini(HttpClient client)
        {
            this.client = client;
        }

        public class Root
        {
            public List<Candidate> candidates { get; set; }
        }

        public class Candidate
        {
            public Content content { get; set; }
        }
        public class Content
        {
            public List<Part> parts { get; set; }
        }

        public class Part
        {
            public string text { get; set; }
        }



        public async Task<string> queryToGemini(string str)
        {
            Env.Load();

            string API_KEY = Environment.GetEnvironmentVariable("GEMINI_API_KEY").ToString();
            if (API_KEY.Length == 0)
            {
                return "Error: the api is empty";
                 
            }

            string fullModelName = "models/gemini-1.5-flash"; 
            string url = $"https://generativelanguage.googleapis.com/v1beta/{fullModelName}:generateContent?key={API_KEY}";

            var requestBody = new
            {
                contents = new[] {
                new
                {
                    parts = new[]
                    {
                        new { text = $" {str} תענה לי באנגלית" } 
                    }
                }
            },
            };

            string jsonRequestBody = JsonSerializer.Serialize(requestBody);

            var content = new StringContent(jsonRequestBody, Encoding.UTF8, "application/json");


            HttpResponseMessage response = await client.PostAsync(url, content);


            string responseString = await response.Content.ReadAsStringAsync();


            Root root = JsonSerializer.Deserialize<Root>(responseString);

            string result = root.candidates[0].content.parts[0].text;
            string cleaned = Regex.Replace(result, @"\r\n?|\n", "");
            Console.WriteLine(cleaned);
            return cleaned;
        }
    }
}
