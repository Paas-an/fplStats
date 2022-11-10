using System.Text;
namespace test
{
    public class FileWriter
    {

        //Creates CSV for weekScore
        public  void  makeCSVWeekScore(List<Current> listWeekScores,string path){
            
            var builder = new StringBuilder();
            builder.AppendLine("Gameweek;Points;Total points;GW Rank;Overall Rank; Percentage placment");
            int i =0;
            foreach(var a in listWeekScores){
             i++;
               builder.AppendLine($"{i};{a.points};{a.total_points};{a.rank};{a.overall_rank};{percentagePlacement(a)}");
            }
            File.WriteAllText(path,builder.ToString());
        }

        public static int percentagePlacement(Current current){
            double numPlayers= 10873369;
            double topPercent = (current.overall_rank / numPlayers)*100;
            return (int)Math.Round(topPercent);
        }
    }
}