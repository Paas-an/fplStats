using System.Text.Json;
namespace test
{
    public class WebService
    {
        // Returns list of Current objects
        public static List<Current> getWeeklyScores(string url){

                using(var client =new HttpClient()){

                var endpoint = new Uri(url);
                
                var result = client.GetAsync(endpoint).Result;
                var jsonResult = result.Content.ReadAsStringAsync().Result;
                var parsed = JsonDocument.Parse(jsonResult);
                var weekScores = parsed.RootElement.GetProperty("current");

                var List = JsonSerializer.Deserialize<List<Current>>(weekScores);
                
                return List;
            }
        }

         

        public static void Main(String[] args ){
           var liste = getWeeklyScores("https://fantasy.premierleague.com/api/entry/7502607/history/");
           FileWriter f = new FileWriter();
           f.makeCSVWeekScore(liste);
        }
        
    }
}