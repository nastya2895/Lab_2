namespace Lab_2_OOP
{
    public class DeductedLessPointsAccount : GameAccount
    {
        public DeductedLessPointsAccount(string UserName, int CurretRating) : base(UserName, CurretRating) { }


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

            CurrentRating -= game.GetRating() / 2;
            GameHistory story = new GameHistory(index, false, opponentname, game.GetRating() / 2);
            histories.Add(story);
        }
    }
}
