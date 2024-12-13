using System.Text.Json;
using GameDataParser.Shared.Interfaces;

namespace GameDataParser.Shared;


internal class JsonFileParser<T> : IFileParser<T>
{
    public List<T> Parse(string content)
    {
        try
        {
            // Deserialize JSON content into a list of Game objects
            return JsonSerializer.Deserialize<List<T>>(content)
                   ?? new List<T>();
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"The content of this file is not valid json: {ex.Message}");
            throw;
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Argument was null lol" + ex);
            throw;
        }
        catch (NotSupportedException ex)
        {
            Console.WriteLine("Not supported hehe" + ex);
            throw;
        }
    }
}
