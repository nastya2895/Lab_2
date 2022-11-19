namespace Lab_2_OOP
{
    public class OnlyWinGame : BaseGame
    {
        public override string TypeOfGame()
        {
            return "Only win game";
        }

        public override void Game(GameAccount winner, GameAccount loser, int rating)
        {
            if (rating < 0)
            {
                Console.WriteLine("Error! Game rating must be positive!");
            }

            if (rating > 0 && loser.CurrentRating - rating > 0)
            {
                RecordOfOurGame history = new RecordOfOurGame(GameCount, winner.UserName, loser.UserName, rating);
                hist.Add(history);

                winner.WinGame(loser.UserName, this, GameCount);
                hist[hist.Count - 1].Rating = 0;

                loser.LoseGame(winner.UserName, this, GameCount);
                hist[hist.Count - 1].Rating = rating;
                winner.SetGamesCount(winner.GetGamesCount() + 1);
                loser.SetGamesCount(loser.GetGamesCount() + 1);
                GameCount++;
            }
        }
    }
}

