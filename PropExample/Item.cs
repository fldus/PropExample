using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    internal class Item
    {
        private static int count;
        public readonly int id = -1;
        public string name;
        public int price;

        public Item(string name, int price)
        {
            id = count++;
            this.name = name;
            this.price = price;
        }
    }
}
