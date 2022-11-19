namespace Lab_2_OOP
{
    public class GameHistory
    {
        public int Index;
        public bool WinLose;
        public string Opponent;
        public int Rating;

        public GameHistory(int index, bool winLose, string opponent, int rating)
        {
            Index = index;
            WinLose = winLose;
            Opponent = opponent;
            Rating = rating;
        }
    }
}