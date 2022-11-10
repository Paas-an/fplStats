using System.Text;
namespace test
{
    public class FileWriter
    {

        //Creates CSV for weekScore
        public  void  makeCSVWeekScore(List<Current> listWeekScores,string path){
            var builder = new StringBuilder();
            builder.AppendLine("Gameweek;Points;Total points;GW Rank;Overall Rank; ");
            int i =0;
            foreach(var a in listWeekScores){
             i++;
               builder.AppendLine($"{i};{a.points};{a.total_points};{a.rank};{a.overall_rank};");
            }
            File.WriteAllText(path,builder.ToString());
            

        }
    }
}