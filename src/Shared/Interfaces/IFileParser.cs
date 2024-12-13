namespace GameDataReader.Shared.Interfaces;

internal interface IFileParser<T>
{
    List<T> Parse(string fileContent);
}
