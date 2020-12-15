using System;
using System.Globalization;
using System.Threading;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var culture = new CultureInfo("sv-SE");
            // var test = Convert.ToDecimal("-94,00", culture);

            Thread.CurrentThread.CurrentCulture = culture;
            Console.WriteLine($"CurrentCulture: {Thread.CurrentThread.CurrentCulture.EnglishName}");
            var test1 = Convert.ToDecimal("-94,00");
            Console.WriteLine($"test {test1}");
            var test2 = Convert.ToDecimal("-1 094,00");
            Console.WriteLine($"test1 {test2}");
            Console.WriteLine("End");
        }
    }
}
