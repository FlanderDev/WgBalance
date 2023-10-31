using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using PayPalHelper.Data;
using PayPalHelper.Database;
using PayPalHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PayPalHelper.Business;

internal class Execution
{
    internal static int AddPaypalDataToDatabase()
    {
        var fileLines = PayPalData.GetFileLines();
        var fileTransactions = Helper.ConvertCsvLinesToTransactions(fileLines);

        var dbTransactions = DatabaseManager.GetPayPalTransaction();
        var dbTransactionCodes = dbTransactions.Select(dbT => dbT.Transaktionscode).ToList();

        var newTransactions = fileTransactions.Where(w => !dbTransactionCodes.Contains(w.Transaktionscode)).ToList();

        var tenants = DatabaseManager.GetTenants();
        int kassenRelevant = 0;
        foreach (var newTransaction in newTransactions)
        {
            Console.WriteLine($"{newTransaction.Name} --- {newTransaction.AbsenderEMailAdresse} -> {newTransaction.EmpfängerEMailAdresse}: {newTransaction.Brutto}");
            if (tenants.Any(tenant => (newTransaction.AbsenderEMailAdresse?.Equals(tenant.Email, StringComparison.OrdinalIgnoreCase) ?? false) || (newTransaction.EmpfängerEMailAdresse?.Equals(tenant.Email, StringComparison.OrdinalIgnoreCase) ?? false)))
            {
                //newTransaction.Relevance = Enum.Kasse.Relevant;
                kassenRelevant++;
            }
        }
        
        var changes = DatabaseManager.AddTransactions(newTransactions);
        Console.WriteLine($"Saved Changes: {changes}");


        Console.WriteLine();
        Console.WriteLine($"Added {newTransactions.Count} new entires, of which {kassenRelevant} are relevant for wg-balance.");

        return changes;

        /*
        return; //old
        var transBySenders = fileTransactions.GroupBy(t => t?.AbsenderEMailAdresse ?? "NoSenderMail");

        var ignoreEmail = dbContext.IgnoreSenderMail.AsNoTracking().Select(s => s.Email).ToList();

        Console.WriteLine("Add mails to filter list? y/n");
        if (Console.ReadKey(true).Key == ConsoleKey.Y)
        {
            foreach (var transBySender in transBySenders)
            {
                if (ignoreEmail.Contains(transBySender.Key))
                {
                    Console.WriteLine($"Skipping ignored: {transBySender.Key}");
                    continue;
                }

                Console.WriteLine(Environment.NewLine);
                Console.WriteLine($"--------{transBySender.Key} {transBySender.First(f => f != null)?.Name ?? "EmailNoName"}--------");
                Console.WriteLine("Skip? y/n  ");
                if (Console.ReadKey(true).Key == ConsoleKey.Y)
                {
                    Console.WriteLine("Skipping...");
                    using var dbContextAddIgnoreMail = new DatabaseContext();
                    dbContextAddIgnoreMail.IgnoreSenderMail.Add(new IgnoreMail { Email = transBySender.Key });
                    dbContextAddIgnoreMail.SaveChanges();
                    continue;
                }
            }
        }
        Console.WriteLine(Environment.NewLine);

        foreach (var transBySender in transBySenders)
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"---{transBySender.Key}---");
            foreach (var transaction in transBySender)
            {
                Console.WriteLine($"{transaction?.Betreff ?? "__"} - {transaction?.Brutto ?? 0}");
            }
            Console.WriteLine($"Sum is: {transBySender.Sum(t => t?.Brutto ?? 0)}");
        }
        */
    }
}
