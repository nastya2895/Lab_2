namespace Lab_2_OOP
{
    public class ExtraPointsAccount : GameAccount
    {
        public ExtraPointsAccount(string userName, int curretRating) : base(userName, curretRating) { }


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

            CurrentRating += 2 * game.GetRating();
            GameHistory story = new GameHistory(index, true, opponentname, 2 * game.GetRating());
            histories.Add(story);
        }
    }
}
