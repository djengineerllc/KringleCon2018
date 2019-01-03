using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CensusAPI
    {
        public string BaseUrl => "https://api.census.gov/";
        public Task<string> RunAsync(string parameters) => Task.Run(async () =>
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl); client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/text"));
                try {
                    var response = await client.GetAsync(parameters);
                    if (response.IsSuccessStatusCode) { return await response.Content.ReadAsStringAsync(); }
                }
                catch (Exception ex) { var _ = ex; }
                return string.Empty;
            }
        });
    }
}