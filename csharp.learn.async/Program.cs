using System;
using static System.Console;

namespace csharp.learn.async
{
    class Program
    {
        static void Main(string[] args)
        {
            // var shareListing = new ShareService();
            var shareListing = new ImprovedShareService();
            for (int i = 0; i < 100_000_000; i++)
            {
                var result = shareListing.GetStockDetails().Result;
            }
            WriteLine($"Garbage collection occurred {GC.CollectionCount(0)} times");
            ReadLine();
        }
    }
}
