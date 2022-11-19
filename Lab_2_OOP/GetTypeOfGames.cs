namespace Lab_2_OOP
{
    public class GetTypeOfGames
    {
        public BaseGame GetSimple() => new SimpleGame();

        public BaseGame GetTrain() => new TrainingGame();

        public BaseGame GetOnlyWin() => new OnlyWinGame();
    }
}
