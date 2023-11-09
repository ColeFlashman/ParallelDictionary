using ParallelDictionary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ParallelDictionary.Logic
{
    public class DictionaryStock
    {
        public Dictionary<int, int> AddItem(Dictionary<int, int> stockDictionary, Dictionary<int, string> itemDictionary, StockItem item)
        {
            var selectedItem = itemDictionary.Where(x => x.Value == item.Name);
            foreach(var value in selectedItem)
            {
                stockDictionary.Add(value.Key, item.Quantity);
            }

            return stockDictionary;
        }
    }
}
