using KassenHelper.Business;

namespace KassenHelper;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            var result = ConsoleInstnace.ExecuteCommand(args);
            Console.WriteLine(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Uncaught Exception:");
            Console.WriteLine(ex.Message);
        }
    }
}