using AlbionOnlineDB.Models;
using System;
using System.Linq;

namespace AlbionOnlineDBSharpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(Item i in AlbionOnlineDB.Items.GetItems().Result)
            {

            }
            Console.WriteLine(String.Join(",", AlbionOnlineDB.Items.GetItems().Result.Select(x=> x.uniquename)));
            Console.ReadKey();
        }
    }
}