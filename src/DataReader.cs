using GameDataReader.Shared.Interfaces;

internal class DataReader<T>(IUserInteractor userInteractor, IFileReader fileReader, IFileParser<T> fileParser, IDataPrinter<T> dataPrinter)
{
    private readonly IUserInteractor _userInteractor = userInteractor;
    private readonly IFileReader _fileReader = fileReader;
    private readonly IFileParser<T> _fileParser = fileParser;
    private readonly IDataPrinter<T> _dataPrinter = dataPrinter;

    public void Run()
    {
        string path;
        do
        {
            path = _userInteractor.Read("Enter path to your game data");
            System.Console.WriteLine("WE HERE");

        } while (!File.Exists(path));


        string file = _fileReader.Read(path);

        List<T> data = _fileParser.Parse(file);

        _dataPrinter.Print(data);

        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }

}
