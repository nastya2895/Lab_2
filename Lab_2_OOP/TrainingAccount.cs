namespace Lab_2_OOP
{
    public class TrainingAccount : GameAccount
    {
        public TrainingAccount(string UserName, int CurretRating) : base(UserName, CurretRating) { }


        public override void LoseGame(string opponentname, BaseGame game, int index)
        {
            if (game.GetRating() < 0)
            {
                Console.WriteLine("Error! Game rating must be positive!");
            }

            if (game.GetRating() >= CurrentRating)
            {
                Console.WriteLine("Error! Game rating is too high");
            }

            CurrentRating -= 0;
            GameHistory story = new GameHistory(index, false, opponentname, 0);
            histories.Add(story);
        }


        public override void WinGame(string opponentname, BaseGame game, int index)
        {
            if (game.GetRating() < 0)
            {
                Console.WriteLine("Error! Game rating must be positive!");
            }

            if (game.GetRating() >= CurrentRating)
            {
                Console.WriteLine("Error! Game rating is too high");
            }

            CurrentRating += 0;
            GameHistory story = new GameHistory(index, true, opponentname, 0);
            histories.Add(story);
        }
    }
}

