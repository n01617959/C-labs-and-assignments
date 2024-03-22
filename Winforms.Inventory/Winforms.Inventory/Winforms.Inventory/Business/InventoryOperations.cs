using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winforms.Inventory.DataBase;

namespace Winforms.Inventory.Business
{
    public class InventoryOperations
    {
        public InventoryOperations() { }

        public List<InventoryItems> GetItems()
        {
            return InventoryDB.GetItems();
        }

        public void SaveItems(InventoryItems item )
        {
            InventoryDB.SaveItems(item); 
        }

        public void DeleteItems(int id)
        {
            InventoryDB.DeleteItems(id);
        }
    }
}
