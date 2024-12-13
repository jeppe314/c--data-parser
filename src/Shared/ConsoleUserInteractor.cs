using GameDataParser.Shared.Interfaces;

namespace GameDataParser.Shared;

internal class ConsoleUserInteractor : IUserInteractor
{
    public string Read(string message)
    {
        try
        {
            if (!string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }

            return Console.ReadLine() ?? string.Empty;
        }
        catch (FormatException ex)
        {

            Console.WriteLine("Something wrong with your input dude" + ex);
            throw;
        }
        catch (Exception ex)
        {
            Console.WriteLine("STH WROOONG" + ex);
            throw;
        }
    }
}