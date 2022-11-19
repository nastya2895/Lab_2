using System.Collections.Generic;

namespace Lab_2_OOP
{
    public abstract class BaseGame
    {
        public virtual int GetRating() => hist[hist.Count - 1].Rating;

        public abstract string TypeOfGame();
        protected int GameCount = 0;
        protected List<RecordOfOurGame> hist = new List<RecordOfOurGame>();

        public abstract void Game(GameAccount winner, GameAccount loser, int rating);

        public void GetStats()
        {
            for (int i = 0; i < hist.Count; i++)
            {
                Console.WriteLine($"\nGame: {hist[i].Index}.\nLoser: {hist[i].Loser}, winner: {hist[i].Winner}, rating: {hist[i].Rating} points");
            }
        }
    }
}