namespace Lab_2_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            DeductedLessPointsAccount Vanya = new DeductedLessPointsAccount("Ivan", 100);
            ExtraPointsAccount Nastya = new ExtraPointsAccount("Nastyusha", 100);
            TrainingAccount Liza = new TrainingAccount("Liza", 100);
            VipAccount Andriy = new VipAccount("Andriy", 1000);

            GetTypeOfGames games = new GetTypeOfGames();
            var game = games.GetSimple();

            Console.WriteLine($"Type of game: {game.TypeOfGame()}");

            Console.WriteLine($"\nVanya: {Vanya.CurrentRating}");
            Console.WriteLine($"Nastya: {Nastya.CurrentRating}");
            Console.WriteLine($"Liza: {Liza.CurrentRating}");
            Console.WriteLine($"Andriy: {Andriy.CurrentRating}");

            game.Game(Nastya, Vanya, 44);
            game.GetStats();
            Console.WriteLine($"\nVanya: {Vanya.CurrentRating}");
            Console.WriteLine($"Nastya: {Nastya.CurrentRating}");
            Console.WriteLine($"Liza: {Liza.CurrentRating}");
            Console.WriteLine($"Andriy: {Andriy.CurrentRating}");

            game.Game(Andriy, Vanya, 22);
            game.GetStats();
            Console.WriteLine($"\nVanya: {Vanya.CurrentRating}");
            Console.WriteLine($"Nastya: {Nastya.CurrentRating}");
            Console.WriteLine($"Liza: {Liza.CurrentRating}");
            Console.WriteLine($"Andriy: {Andriy.CurrentRating}");

            game.Game(Liza, Andriy, 14);
            game.GetStats();
            Console.WriteLine($"\nVanya: {Vanya.CurrentRating}");
            Console.WriteLine($"Nastya: {Nastya.CurrentRating}");
            Console.WriteLine($"Liza: {Liza.CurrentRating}");
            Console.WriteLine($"Andriy: {Andriy.CurrentRating}");

            game.Game(Andriy, Nastya, 5);
            game.GetStats();
            Console.WriteLine($"\nVanya: {Vanya.CurrentRating}");
            Console.WriteLine($"Nastya: {Nastya.CurrentRating}");
            Console.WriteLine($"Liza: {Liza.CurrentRating}");
            Console.WriteLine($"Andriy: {Andriy.CurrentRating}");

            game.Game(Vanya, Liza, 10);
            game.GetStats();
            Console.WriteLine($"\nVanya: {Vanya.CurrentRating}");
            Console.WriteLine($"Nastya: {Nastya.CurrentRating}");
            Console.WriteLine($"Liza: {Liza.CurrentRating}");
            Console.WriteLine($"Andriy: {Andriy.CurrentRating}");

            game.Game(Liza, Nastya, 30);
            game.GetStats();
            Console.WriteLine($"\nVanya: {Vanya.CurrentRating}");
            Console.WriteLine($"Nastya: {Nastya.CurrentRating}");
            Console.WriteLine($"Liza: {Liza.CurrentRating}");
            Console.WriteLine($"Andriy: {Andriy.CurrentRating}");

            Console.WriteLine("\nVanya");
            Vanya.GetStats();

            Console.WriteLine("\nNastya");
            Nastya.GetStats();

            Console.WriteLine("\nLiza");
            Liza.GetStats();

            Console.WriteLine("\nAndriy");
            Andriy.GetStats();
        }
    }
}