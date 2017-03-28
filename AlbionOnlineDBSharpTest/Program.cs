using AlbionOnlineDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AlbionOnlineDBSharpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Retrieving...");
            Dictionary<String,String> test = new Dictionary<String, String>();
            var items = AlbionOnlineDB.Items.GetItems().Result;
            Parallel.ForEach(items, (item) => {
                if(test.ContainsKey(item.ItemInfo.shopcategory))
                {

                }
                else
                {
                    test.Add(item.ItemInfo.shopcategory, item.ItemInfo.JsonSource);
                    Console.WriteLine(item.ItemInfo.shopcategory);
                }
            });

            Console.WriteLine("Done. Re-Dumping");

            foreach(var cat in test)
            {
                Console.WriteLine(cat.Key);
                Console.WriteLine(cat.Value);
            }

            Console.WriteLine("Done. Press any key to exit.");

            Console.ReadKey();
        }
    }
}