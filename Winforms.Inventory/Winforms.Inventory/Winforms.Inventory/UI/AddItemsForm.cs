using System;
using System.Windows.Forms;
using Winforms.Inventory.Business;
using Winforms.Inventory.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Winforms.Inventory
{
    public partial class AddItemsForm : Form
    {
        private InventoryOperations inventoryOperations = new InventoryOperations();
        private InventoryForm inventoryForm;

        public AddItemsForm(InventoryForm inventoryForm )
        {
            InitializeComponent();
            this.inventoryForm = inventoryForm;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var inventoryItems = new InventoryItems();
                inventoryItems.ItemNo = int.Parse(ItemNoBox.Text);
                inventoryItems.Description = DescBox.Text;
                inventoryItems.Price = decimal.Parse(PriceBox.Text);

                inventoryOperations.SaveItems(inventoryItems);

                this.Close();
                inventoryForm.UpdatedListView();
                inventoryForm.Show();
            }
            catch
            {
                MessageBox.Show("Add valid entries", "Incorrect entry");
                this.Show();
            }
           

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}
