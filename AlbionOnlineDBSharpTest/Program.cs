using AlbionOnlineDB.Models;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AlbionOnlineDBSharpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test1");
            Parallel.ForEach(AlbionOnlineDB.Items.GetItems().Result.GetRange(0,20), (item) => {
                Console.WriteLine(item.uniquename + ":" + item.ItemInfo.tier);
            });
            Console.WriteLine("Test2");
            Parallel.ForEach(AlbionOnlineDB.Items.GetItems().Result.GetRange(20, 20), (item) => {
                Console.WriteLine(item.uniquename + ":" + item.ItemInfo.tier);
            });
            Console.WriteLine("Test3");

            Console.ReadKey();
        }
    }
}