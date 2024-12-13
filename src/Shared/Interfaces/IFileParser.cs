namespace GameDataParser.Shared.Interfaces;

internal interface IFileParser<T>
{
    List<T> Parse(string fileContent);
}
