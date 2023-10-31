using Microsoft.EntityFrameworkCore;
using PayPalHelper.Business;
using PayPalHelper.Database;
using System.Diagnostics;
using System.Security.Cryptography;

namespace PayPalHelper;

internal class Program
{
    static void Main()
    {
        if (false)
        {
            var clearChanges = DatabaseManager.ClearTransactions();
            Console.WriteLine($"Clear changes {clearChanges}");
            Execution.AddPaypalDataToDatabase();
        }

        using var dbc = new DatabaseContext();
        var transactions = dbc.Transactions.AsNoTracking().ToList();

        var wgMails = dbc.Tenants.Select(t => t.Email).ToList();
        var sendWg = transactions.Where(w => wgMails.Any(a => a.Equals(w.EmpfängerEMailAdresse, StringComparison.OrdinalIgnoreCase))).ToList().OrderBy(o => o.Transaktionscode).ToList();


        wgMails.ForEach(Console.WriteLine);

        decimal ex = 0;
        foreach (var t in sendWg)
        {
            Console.WriteLine($"{t.Hinweis} || {t.Betreff} || {t.Brutto} || {t.EmpfängerEMailAdresse} || {t.Transaktionscode}");

            bool needInput = true;
            while (needInput)
            {
                var input = Console.ReadKey(true).Key;
                if (input == ConsoleKey.C)
                    Process.Start("explorer");

                if (input == ConsoleKey.A) //Add to total
                    ex += t.Brutto;

                if (input == ConsoleKey.A || input == ConsoleKey.I) // ignore
                    needInput = false;
            }

            Console.WriteLine();
        }

        Console.WriteLine($"Money is: {ex}");
    }
}