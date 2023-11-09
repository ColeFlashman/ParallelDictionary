using ParallelDictionary.Logic;
using ParallelDictionary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ParallelDictionary
{
    /// <summary>
    /// Interaction logic for SearchPage.xaml
    /// </summary>
    public partial class SearchPage : Page
    {
        public SearchPage()
        {
            InitializeComponent();

            List<StockItem> stockItems = new List<StockItem>();
            Dictionary<int, string> itemDictionary = new Dictionary<int, string>();
            Dictionary<int, int> stockDictionary = new Dictionary<int, int>();


            AddStockItem addStockItem = new AddStockItem();
            stockItems.Add(addStockItem.AddNewItem(0, "Iphone 15", 100));
            stockItems.Add(addStockItem.AddNewItem(100, "Iphone 14", 150));
            stockItems.Add(addStockItem.AddNewItem(55, "Iphone 13", 200));
            stockItems.Add(addStockItem.AddNewItem(75, "Iphone 12", 250));
            stockItems.Add(addStockItem.AddNewItem(25, "Iphone 11", 300));

            DictionaryName dName = new DictionaryName();

            foreach (var item in stockItems)
            { 
                dName.AddItem(itemDictionary, item.Name);

                DictionaryStock dStock = new DictionaryStock();
                dStock.AddItem(stockDictionary, itemDictionary, item);
                int index = 0;
                MessageBox.Show($"Stock Item Id:{index}\n\tStock Item Name:{itemDictionary[index]}Stock Item Quantity:{stockDictionary[index]}\n\t");
                index++;
            }
        }
    }
}
