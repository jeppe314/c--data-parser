namespace GameDataReader.Games;

using GameDataReader.Shared.Interfaces;

internal class GamePrinter : IDataPrinter<Game>
{
    public void Print(List<Game> gameObjects)
    {

        foreach (Game game in gameObjects)
        {
            Console.WriteLine($"{game.Title}, released in {game.ReleaseYear}, rating {game.Rating}");
        }
    }
}
