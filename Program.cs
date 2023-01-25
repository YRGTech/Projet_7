namespace Projet_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleManager.WindowSetup();
            Game game = new Game();
            game.Run();
        }
    }
}