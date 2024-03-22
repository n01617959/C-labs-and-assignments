using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winforms.Inventory.Business;

namespace Winforms.Inventory.DataBase
{
    public static class InventoryDB
    {
        private static readonly string filePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "Winforms.Inventory\\Winforms.Inventory\\grocery_inventory_items.txt"); private const string Delimiter = "|";

        public static List<InventoryItems> GetItems() 
        {
            List<InventoryItems> items = new List<InventoryItems>();
            using (StreamReader textIn = new StreamReader(new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read)))
            {
                string row;
                while ((row = textIn.ReadLine()) != null)
                {
                    string[] columns = row.Split('|');


                    if (columns.Length == 3)
                    {
                        InventoryItems item = new InventoryItems
                        {
                            ItemNo = Convert.ToInt32(columns[0]),
                            Description = columns[1],
                            Price = Convert.ToDecimal(columns[2])
                        };
                        items.Add(item);
                    }
                }
            }
            return items;

        }

        public static void SaveItems(InventoryItems item )
        {
            using (StreamWriter textOut = File.AppendText(filePath))
            {                
                    textOut.Write(item.ItemNo + Delimiter);
                    textOut.Write(item.Description + Delimiter);
                    textOut.WriteLine(item.Price);                
            }
        }   

        public static void DeleteItems(int id)
        {
            try { 
            var AllItems = GetItems();
            var itemToDelete = AllItems.Where(x => x.ItemNo == id).FirstOrDefault();
                AllItems.Remove(itemToDelete);

                using (StreamWriter textOut = new StreamWriter(new FileStream(filePath, FileMode.Create, FileAccess.Write)))
                {
                    foreach (InventoryItems item in AllItems)
                    {
                        textOut.Write(item.ItemNo + Delimiter);
                        textOut.Write(item.Description + Delimiter);
                        textOut.WriteLine(item.Price);
                    }
                }

            }
            catch
            {
                throw;
            }
        }

    }
}
