using KassenHelper.Database;
using KassenHelper.Model;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Xml.Linq;

namespace KassenHelper.Business;

internal class ConsoleInstnace
{
    private string _workingDir;

    internal ConsoleInstnace(string? dir = null)
    {
        if (dir == null)
            _workingDir = Environment.CurrentDirectory;
        else
            _workingDir = Directory.Exists(dir) ? dir : throw new DirectoryNotFoundException(dir);
    }

    internal static string ExecuteCommand(string[] args) => ExecuteCommand(args.Aggregate((a, b) => $"{a} {b}"));
    internal static string ExecuteCommand(string command)
    {
        try
        {
            using var dbContext = new DatabaseContext();
            dbContext.Database.EnsureCreated();
        }
        catch (Exception ex)
        {
            return $"Could not find & create database:{Environment.NewLine}{ex.Message}";
        }

        return command.Trim() switch
        {
            "-cp" => CreatePerson(),
            "-ap" => AddPurchase(),
            "-np" => NewPayment(),
            "-h" => string.Join(Environment.NewLine, new string[] { "-cp = createPerson", "-ap = addPurchase", "-np = newPayment", "-h = help" }),
            _ => "Unknown Command. Try -h for help."
        };
    }

    internal static string CreatePerson()
    {
        Console.WriteLine("Enter a name for the new person:");
        var inputName = Console.ReadLine();
        if (inputName == null)
            return "Invalid name";

        var person = new Person(inputName.Trim());

        using var dbContext = new DatabaseContext();

        var foundPerson = dbContext.People.FirstOrDefault(p => p.Name.Equals(person.Name));
        if (foundPerson != null)
            return $"You can't add '{person.Name}' since '{foundPerson.Name}' with id '{foundPerson.Id}' already exsists.";

        dbContext.People.Add(person);
        dbContext.SaveChanges();

        return $"Created Person '{person.Name}' with id '{person.Id}'.";
    }

    internal static string AddPurchase()
    {
        using var dbContext = new DatabaseContext();

        Console.WriteLine("Select the id of the person to add the purchase to.");

        foreach (var person in dbContext.People)
            Console.WriteLine($"Id: {person.Id}. Name: {person.Name}");

        var inputId = Console.ReadLine();
        if (!int.TryParse(inputId, out int parsedId))
            return $"Could not parse '{inputId}' to whole number.";

        var foundPerson = dbContext.People.FirstOrDefault(p => p.Id == parsedId);
        if (foundPerson == null)
            return $"The selected id '{parsedId}' does not match a person's id.";

        Console.WriteLine($"Selected id: {foundPerson.Id}, name: {foundPerson.Name}");

        string? filePath = null;
        while (filePath == null)
        {
            Console.WriteLine($"Enter absolute image file path or just press enter to skip.");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                break;

            var trimedPath = input.Trim().Trim('"').Trim();
            if (File.Exists(trimedPath))
            {
                Console.WriteLine($"File found.{Environment.NewLine}");
                break;
            }
            Console.WriteLine($"Could not find find file at:{Environment.NewLine}{trimedPath}");
        }

        Console.WriteLine("Enter Item name or press enter to continue.");
        var items = new List<Item>();
        while (true)
        {
            var inputItemName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputItemName))
                break;

            while (true)
            {
                Console.WriteLine("Enter the sum of the item, with '.' as seperator. Or press enter to go back.");
                var inputPrice = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(inputPrice))
                    break;

                if (decimal.TryParse(inputPrice, out decimal price))
                {
                    var item = new Item(inputItemName.Trim(), price);
                    items.Add(item);
                    Console.WriteLine($"Added item '{item.Name}' with price of '{item.Price}'");
                    break;
                }
            }

            var basketTotal = items.Sum(i => i.Price);
            Console.WriteLine($"The current basket total is {basketTotal}€ with {items.Count} items.");
        }

        var sum = items.Sum(i => i.Price);
        var purchase = new Purchase(filePath, sum, DateTime.Now, items);
        foundPerson.Purchases.Add(purchase);
        dbContext.SaveChanges();

        return $"Added new purchase with total of {sum} to {foundPerson.Name} ({foundPerson.Id})";
    }

    internal static string NewPayment()
    {
        using var dbContext = new DatabaseContext();

        Console.WriteLine("Select the id of the person to add the purchase to.");

        foreach (var person in dbContext.People)
            Console.WriteLine($"Id: {person.Id}. Name: {person.Name}");

        var inputId = Console.ReadLine();
        if (!int.TryParse(inputId, out int parsedId))
            return $"Could not parse '{inputId}' to whole number.";

        var foundPerson = dbContext.People.FirstOrDefault(p => p.Id == parsedId);
        if (foundPerson == null)
            return $"The selected id '{parsedId}' does not match a person's id.";

        Console.WriteLine($"Selected id: {foundPerson.Id}, name: {foundPerson.Name}");

        decimal amount;
        while (true)
        {
            var input = Console.ReadLine();
            if (decimal.TryParse(input, out amount))
                break;

            Console.WriteLine($"Cant convert '{input}' to decimal.");
        }

        var payment = new Payment(foundPerson, amount, DateTime.Now);
        foundPerson.Payments.Add(payment);
        dbContext.SaveChanges();

        return $"Added payment of {amount} to {foundPerson.Name} ({foundPerson.Id})";
    }
}
