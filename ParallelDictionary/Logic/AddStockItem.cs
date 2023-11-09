using ParallelDictionary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelDictionary.Logic
{
    public class AddStockItem
    {
        public StockItem AddNewItem(int Id, string name, int quantity)
        {
            return new StockItem  { ID = Id, Name = name, Quantity = quantity };
        }
    }
}
