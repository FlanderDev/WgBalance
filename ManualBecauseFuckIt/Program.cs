using ManualBecauseFuckIt.Data;

namespace ManualBecauseFuckIt;

internal class Program
{
    static void Main(string[] args)
    {
        using var dbContext = new DatabaseContext();
        dbContext.Database.EnsureCreated();
    }
}