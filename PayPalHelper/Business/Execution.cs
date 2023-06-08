using PayPalHelper.Data;
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
    internal static readonly string[] _bewohnerMails = new string[] { "", " ", "lena@bucht.eu", "Jessica.Brunss.jb@gmail.com", "dafina.vogt@aol.de", "Amiraligng@yahoo.com", "esther.helms@web.de", "ellalouisa02@gmail.com", "Tonyyx@yahoo.com", "arnerodi@web.de", "sb-pay@gmx.de" };

    internal static void DoShit()
    {
        var fileLines = PayPalData.GetFileLines();
        var transactions = Helper.ConvertCsvLinesToTransactions(fileLines);

        var allNameGroups = transactions.GroupBy(d => d?.Name ?? "").ToList();

        var filtredNameGroups = allNameGroups;

        foreach (var nameGroup in filtredNameGroups)
        {
            var key = string.IsNullOrWhiteSpace(nameGroup.Key) ? "------------" : nameGroup.Key;
            var name = nameGroup.FirstOrDefault(f => f != null && f.Name != null)?.Name ?? "No name";
            Console.WriteLine($"Mail: {key} | {name}");

            decimal balance = 0;
            foreach (var transaction in nameGroup)
            {
                if (transaction == null || transaction.Netto == null)
                {
                    Console.WriteLine($"No transaction value");
                    continue;
                }

                balance += (decimal)transaction.Netto;
            }
            Console.WriteLine($"balance: {balance}");
            Console.WriteLine(Environment.NewLine);
        }
    }
}
