using Newtonsoft.Json;
using RecipeApp.DataFetch.TastyApp.DTO;
using RestSharp;

namespace RecipeApp.DataFetch.TastyApp.Client
{
    public class TastyAppClient
    {
        const string TASTY_APP_BASE_URL = "https://tasty.p.rapidapi.com/recipes/list";
        const string RAPID_API_KEY = "f8079ba7a1msh2b4c6522ad8f776p1b38bajsn3b8a50359767";
        const string RAPID_API_HOST = "tasty.p.rapidapi.com";
        
        public int From { get; set; }
        public int Size { get; set; }

        public TastyAppClient()
        {
            From = 0;
            Size = 41;
        }

        public async Task FetchData()
        {
            List<ResultDTO> results = new List<ResultDTO>();
            
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine($"Started {i+1} fetch");
                var client = new RestClient($"{TASTY_APP_BASE_URL}?from={From}&size={Size}");
                var request = new RestRequest();
                request.AddHeader("X-RapidAPI-Key", RAPID_API_KEY);
                request.AddHeader("X-RapidAPI-Host", RAPID_API_HOST);
                RestResponse response = client.Execute(request);
                
                Console.WriteLine($"Finished {i+1} fetch");
                
                RootDTO root = JsonConvert.DeserializeObject<RootDTO>(response.Content);
                
                results.AddRange(root.results);
            }
            Console.WriteLine(results.Count);

            var json = JsonConvert.SerializeObject(results);
            
            System.IO.File.WriteAllText("data.json",json);
        }
    }
}