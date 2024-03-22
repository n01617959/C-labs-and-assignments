using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Winforms.Inventory.Business
{
    public class InventoryItems
    {
        public int ItemNo { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public InventoryItems() { }       

    }
}
