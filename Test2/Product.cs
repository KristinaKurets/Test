using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    public class Product : IComparable
    {
        public string Id { get; set; }
        public string Tree_name { get; set; }

        public Product(string id, string tree_Name)
        {
            Id = id;
            Tree_name = tree_Name;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
