namespace Lab_2_OOP
{
    public class GameAccount
    {
        public string UserName { get; set; }
        public int CurrentRating { get; set; }
        private int GamesCount = 0;

        public int GetGamesCount() => GamesCount;
        public void SetGamesCount(int gamesCount) => GamesCount = gamesCount;
        protected List<GameHistory> histories = new List<GameHistory>();


        public GameAccount(string userName, int curretRating)
        {
            UserName = userName;
            CurrentRating = curretRating;
        }


        public virtual void WinGame(string opponentname, BaseGame game, int index)
        {
            if (game.GetRating() < 0)
            {
                Console.WriteLine("Error! Game rating must be positive!");
            }

            if (game.GetRating() >= CurrentRating)
            {
                Console.WriteLine("Error! Game rating is too high");
            }

            CurrentRating += game.GetRating();
            GameHistory story = new GameHistory(index, true, opponentname, game.GetRating());
            histories.Add(story);
        }


        public virtual void LoseGame(string opponentName, BaseGame game, int index)
        {
            if (game.GetRating() < 0)
            {
                Console.WriteLine("Error! Game rating must be positive!");
            }

            if (game.GetRating() >= CurrentRating)
            {
                Console.WriteLine("Error! Game rating is too high");
            }

            CurrentRating -= game.GetRating();
            GameHistory story = new GameHistory(index, false, opponentName, game.GetRating());
            histories.Add(story);
        }


        public void GetStats()
        {
            for (int i = 0; i < histories.Count; i++)
            {
                if (histories[i].WinLose == false)
                {
                    Console.WriteLine($"Game: {histories[i].Index}.\nLoser: {histories[i].Opponent} -{histories[i].Rating} points");
                }
                else
                {
                    Console.WriteLine($"Game: {histories[i].Index}.\nWinner: {histories[i].Opponent} +{histories[i].Rating} points");
                }
            }
        }
    }
}

