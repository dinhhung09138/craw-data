using System;
using AdapterRegex;
using SIM.Crawl.VietStock;

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

            //vietStockIndustry.Process();

            CrawlBySector sector1 = new CrawlBySector();
            sector1.Process().ConfigureAwait(true);
        }
    }
}
