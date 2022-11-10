using System.Text.Json;
namespace test
{
    public class WebService
    {
        // Returns list of Current objects
        public static List<Current> getListFromJSONProperty(string url,string property){

                using(var client =new HttpClient()){

                var endpoint = new Uri(url);
                
                var result = client.GetAsync(endpoint).Result;
                var jsonResult = result.Content.ReadAsStringAsync().Result;
                var parsed = JsonDocument.Parse(jsonResult);
                var jsonstring = parsed.RootElement.GetProperty(property);

                var List  = JsonSerializer.Deserialize<List<Current>>(jsonstring)!;
                
                return List;
            }
        }
        
    }
}