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
        var fileLines = Data.GetFileLines();
        var transactions = Helper.ConvertCsvLinesToTransactions(fileLines);





        return;

        var allEmailGroups = transactions.GroupBy(d => d?.AbsenderEMailAdresse ?? "").ToList();
        var filtredEmailGroups = allEmailGroups.Where(amg =>
        {
            if (!_bewohnerMails.Contains(amg.Key))
            {
                Console.WriteLine($"Skipping mail: {amg.Key}");
                return false;
            }

            return true;
        }).ToList();


        foreach (var mailGroup in filtredEmailGroups)
        {
            var key = string.IsNullOrWhiteSpace(mailGroup.Key) ? "------------" : mailGroup.Key;
            var name = mailGroup.FirstOrDefault(f => f != null && f.Name != null)?.Name ?? "No name";
            Console.WriteLine($"Mail: {key} | {name}");

            decimal balance = 0;
            foreach (var transaction in mailGroup)
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
