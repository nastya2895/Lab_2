namespace Lab_2_OOP
{
    public class RecordOfOurGame
    {
        public int Index;
        public string Winner;
        public string Loser;
        public int Rating;

        public RecordOfOurGame(int index, string winner, string loser, int rating)
        {
            Index = index;
            Winner = winner;
            Loser = loser;
            Rating = rating;
        }
    }
}