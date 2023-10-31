using PayPalHelper.Model;
using System.Data;

namespace PayPalHelper.Business;

internal static class Helper
{
    internal static List<PpTransaction> ConvertCsvLinesToTransactions(List<string> fileLines)
    {
        var list = fileLines.Select(fl =>
        {
            var split = fl.Split("\",\"");
            var trimedSplit = split.Select(s => s.Trim('"')).ToList();
            return trimedSplit != null ? PpTransaction.Create(trimedSplit) : null;
        }).ToList();

        list.RemoveAll(s => s == null);
        return list;
    }

    internal static string? GetValueIfSame(List<string?> values, out List<string?> extraValues)
    {
        var duplicatesCount = values.GroupBy(str => str)
                                     .ToDictionary(group => group.Key ?? " ", group => group.Count());

        var duplicates = duplicatesCount.OrderByDescending(x => x.Value).ToList();
        var mostDups = duplicates.FirstOrDefault();

        extraValues = new List<string?>();
        foreach (var duplicate in duplicates)
        {
            if (duplicate.Key.Equals(mostDups.Key))
                continue;

            extraValues.Add(string.IsNullOrWhiteSpace(duplicate.Key) ? null : duplicate.Key);
        }

        return string.IsNullOrWhiteSpace(mostDups.Key) ? null : mostDups.Key;
    }


    internal static void Warning(string text) => PrintColor(text, ConsoleColor.Yellow);

    internal static void PrintColor(string text, ConsoleColor consoleColor)
    {
        Console.ForegroundColor = consoleColor;
        Console.WriteLine(text);
        Console.ForegroundColor = default;
    }
}
