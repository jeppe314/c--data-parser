using GameDataParser.Shared.Interfaces;

namespace GameDataParser.Games;

internal class GamePrinter : IDataPrinter<Game>
{
    public void Print(List<Game> gameObjects)
    {
        Console.WriteLine("The loaded video games are:");
        foreach (Game game in gameObjects)
        {
            Console.WriteLine(game.ToString());
        }
    }
}
