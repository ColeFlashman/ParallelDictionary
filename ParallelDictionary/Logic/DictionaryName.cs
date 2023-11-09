using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelDictionary.Logic
{
    public class DictionaryName
    {
        public Dictionary<int, string> AddItem(Dictionary<int, string> itemDictionary, string name)
        {
            int id = itemDictionary.Count;

            itemDictionary.Add(id, name);
            return itemDictionary;

        }
    }
}
