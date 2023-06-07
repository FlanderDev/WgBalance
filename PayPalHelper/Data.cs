using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayPalHelper;
internal class Data
{
    internal static readonly string _filePath = @"E:\Downloads\PayPal.CSV";
    internal static List<string> GetFileLines() => File.ReadAllLines(_filePath).Skip(1).ToList();
}
