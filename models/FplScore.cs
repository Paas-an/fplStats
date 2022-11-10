namespace test
{
    //Object with the values to save and use from api
    public class FplScore
    {
        private int Event{get;set;}
        private int points{get;set;}

        public FplScore(int weekNum_, int points_){
            Event = weekNum_;
            points = points_;
        }
    }
}