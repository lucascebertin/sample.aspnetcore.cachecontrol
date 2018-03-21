using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Sample.DotNetCore.Client
{
    class Program
    {
        private const string API = "http://localhost:56759/api/values";
        
        static async Task Main(string[] args)
        {
            var client = new HttpClient();

            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(TimeSpan.FromSeconds(1));
                var response = await client.GetAsync(API);
                var body = await response.Content.ReadAsStringAsync();

                Console.WriteLine(body);
            }

        }
    }
}
