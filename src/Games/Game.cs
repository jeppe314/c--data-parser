using GameDataParser.Shared.Interfaces;

namespace GameDataParser.Games;


internal class Game : IDataObject
{
    public required string Title { get; set; }
    public int ReleaseYear { get; set; }
    public double Rating { get; set; }

    public override string ToString()
    {
        return $"Title: {Title}, ReleaseYear: {ReleaseYear}, Rating: {Rating}";
    }
}