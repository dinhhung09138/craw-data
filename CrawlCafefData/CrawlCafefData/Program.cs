using System;
using AdapterRegex;

namespace CrawlCafefData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            StockCafef cafef = new StockCafef();
            //cafef.Process();

            StockVietStock vietStockIndustry = new StockVietStock();

            vietStockIndustry.Process();

        }
    }
}
