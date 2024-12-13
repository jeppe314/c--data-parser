using System.Text;
using GameDataParser.Shared.Interfaces;

namespace GameDataParser.Shared;

internal class FileStreamReader : IFileReader
{
    public string Read(string path)
    {
        StringBuilder fileContent = new();

        try
        {
            // Pass the file path to the StreamReader constructor
            using StreamReader sr = new(path);

            string line;
            // Read each line and append it to the StringBuilder
            while ((line = sr.ReadLine()) is not null)
            {
                fileContent.AppendLine(line);
            }
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
            throw;
        }

        // Return the accumulated file content as a string
        return fileContent.ToString();
    }
}

