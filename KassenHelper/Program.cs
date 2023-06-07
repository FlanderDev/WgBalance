using KassenHelper.Business;

namespace KassenHelper;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("------------------");
            var command = Console.ReadLine() ?? "-h";

            try
            {
                //ConsoleInstnace.ExecuteCommand(args);
                var result = ConsoleInstnace.ExecuteCommand(command);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Uncaught Exception:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}