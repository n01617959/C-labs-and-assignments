using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Winforms.Inventory.Business;

namespace Winforms.Inventory.UI
{
    public partial class InventoryForm : Form
    {
        private List<InventoryItems> inventoryItems = new List<InventoryItems>();
        private InventoryOperations inventoryOperations = new InventoryOperations();
        private AddItemsForm addItemsForm;

        public InventoryForm()
        {
            InitializeComponent();
            addItemsForm = new AddItemsForm(this);
            InitializeListView();
        }       

        //Exit button
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Add button
        private void button1_Click(object sender, EventArgs e)
        {
            if(addItemsForm is null || addItemsForm.IsDisposed)
                addItemsForm = new AddItemsForm(this);
            addItemsForm.Show();
        }

        //Delete Button
        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete the items", "Delete Confirmation Box", MessageBoxButtons.YesNo))
                {
                    foreach (ListViewItem item in listView1.SelectedItems)
                    {
                        try
                        {
                            int id = int.Parse(item.SubItems[0].Text);
                            inventoryOperations.DeleteItems(id);

                        }
                        catch
                        {
                            MessageBox.Show("Error deleting item. Please try again");

                        }
                    }
                    UpdatedListView();
                }
                else
                {
                    MessageBox.Show("Item not deleted");
                }
            }
            else
                MessageBox.Show("Select an item to delete");
        }

        public void UpdatedListView()
        {
            inventoryItems = inventoryOperations.GetItems();
            listView1.Items.Clear();
            foreach (var inventoryItem in inventoryItems)
            {
                ListViewItem item = new ListViewItem(inventoryItem.ItemNo.ToString());
                item.SubItems.Add(inventoryItem.Description);
                item.SubItems.Add(inventoryItem.Price.ToString());
                listView1.Items.Add(item);
            }
        }

        private void InitializeListView()
        {
            // Add columns to the ListView
            listView1.Columns.Add("ItemNumber", 80);
            listView1.Columns.Add("Description", 220);
            listView1.Columns.Add("Price", 65);
            listView1.FullRowSelect = true;

            UpdatedListView();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
