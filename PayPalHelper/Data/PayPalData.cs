using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayPalHelper.Data;
internal class PayPalData
{
    internal static readonly string _filePath = @"C:\Users\Felix Kreuzberger\Downloads\PayPalDownload.CSV";
    internal static List<string> GetFileLines() => File.ReadAllLines(_filePath).Skip(1).ToList();
}
