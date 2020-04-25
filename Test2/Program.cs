using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Test2
{
    class Program 
    {
        static void Main(string[] args)
        {
            string json = File.ReadAllText("myList.json");
            List<Product> MyList = JsonConvert.DeserializeObject<List<Product>>(json);
            var sortedList = MyList.OrderBy(x => x.Id, new MyListComparer()).ToList();

            foreach (var item in sortedList)
            {
                Console.WriteLine($"{item.Id} {item.Tree_name}");
            }

        }

    }
}
