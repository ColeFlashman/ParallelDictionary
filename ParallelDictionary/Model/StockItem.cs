using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelDictionary.Model
{
    public class StockItem
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public StockItem(int iD, string name, int quantity)
        {
            ID = iD;
            Name = name;
            Quantity = quantity;
        }

        public StockItem() { }
    }
}
