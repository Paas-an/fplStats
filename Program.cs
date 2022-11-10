using System.Text;
namespace test
{
    public class Program
    {

         public static void getUserWeeklyscore(string userID,string name){
            
            var liste = WebService.getListFromJSONProperty($"https://fantasy.premierleague.com/api/entry/{userID}/history/","current");

            FileWriter file = new FileWriter();
            file.makeCSVWeekScore(liste,$"C:\\Users\\Jolse\\no\\c#\\random\\test\\generatedFiles\\infoScores{name}.CSV");

        }
           public static void Main(String[] args ){
            
            getUserWeeklyscore("7502607","J");
            getUserWeeklyscore("2746239","Henrik");
            getUserWeeklyscore("7764051","ole");
            getUserWeeklyscore("7616935","Andreas");
        }
    }
}