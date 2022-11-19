namespace Lab_2_OOP
{
    public class SimpleGame : BaseGame
    {
        public override string TypeOfGame()
        {
            return "Simple game";
        }

        public override void Game(GameAccount winner, GameAccount loser, int rating)
        {
            if (rating < 0)
            {
                Console.WriteLine("Error! Game rating must be positive!");
            }

            if (rating > 0 && loser.CurrentRating - rating > 0)
            {
                RecordOfOurGame story = new RecordOfOurGame(GameCount, winner.UserName, loser.UserName, rating);
                hist.Add(story);

                winner.WinGame(loser.UserName, this, GameCount);
                loser.LoseGame(winner.UserName, this, GameCount);

                winner.SetGamesCount(winner.GetGamesCount() + 1);
                loser.SetGamesCount(loser.GetGamesCount() + 1);
                GameCount++;
            }
        }
    }
}

