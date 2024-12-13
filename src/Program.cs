using GameDataParser.Shared;
using GameDataReader.Games;
using GameDataReader.Shared;
using GameDataReader.Shared.Interfaces;

try
{

    Run();
}
catch (Exception ex)
{
    Console.WriteLine("Something bad happened. Did you do something bad?" + ex);
}


void Run()
{
    ConsoleUserInteractor consoleUserInteractor = new();
    FileStreamReader fileReader = new();
    JsonFileParser<Game> jsonFileParser = new();
    IDataPrinter<Game> gamePrinter = new GamePrinter();

    DataReader<Game> gameDataReader = new(consoleUserInteractor, fileReader, jsonFileParser, gamePrinter);

    gameDataReader.Run();
}
