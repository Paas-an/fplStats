using System.Text;
namespace test
{
    public class FileWriter
    {

        //Creates CSV for weekScore
        public  void  makeCSVWeekScore(List<Current> listWeekScores){
            var builder = new StringBuilder();
            builder.AppendLine("Gameweek;Points;Total points;GW Rank;Overall Rank; ");
            foreach(var a in listWeekScores){
               builder.AppendLine($"{a._event.ToString()};{a.points};{a.total_points};{a.rank};{a.overall_rank};");
            }
            File.WriteAllText("C:\\Users\\Jolse\\no\\c#\\random\\test\\infoScores.CSV",builder.ToString());

        }
    }
}