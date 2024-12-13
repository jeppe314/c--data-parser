namespace GameDataReader.Shared;

using System.Text;
using GameDataReader.Shared.Interfaces;




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
        catch (Exception ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
            throw;
        }

        // Return the accumulated file content as a string
        return fileContent.ToString();
    }
}

