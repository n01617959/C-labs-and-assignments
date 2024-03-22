namespace Winforms.Inventory
{
    partial class AddItemsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Header = new System.Windows.Forms.Label();
            this.ItemNo = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.ItemNoBox = new System.Windows.Forms.TextBox();
            this.DescBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Location = new System.Drawing.Point(285, 36);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(178, 20);
            this.Header.TabIndex = 0;
            this.Header.Text = "Add New Inventory Item";
            // 
            // ItemNo
            // 
            this.ItemNo.AutoSize = true;
            this.ItemNo.Location = new System.Drawing.Point(79, 117);
            this.ItemNo.Name = "ItemNo";
            this.ItemNo.Size = new System.Drawing.Size(69, 20);
            this.ItemNo.TabIndex = 1;
            this.ItemNo.Text = "Item No:";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(79, 181);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(93, 20);
            this.Description.TabIndex = 2;
            this.Description.Text = "Description:";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(79, 245);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(48, 20);
            this.Price.TabIndex = 3;
            this.Price.Text = "Price:";
            this.Price.Click += new System.EventHandler(this.label4_Click);
            // 
            // ItemNoBox
            // 
            this.ItemNoBox.Location = new System.Drawing.Point(258, 110);
            this.ItemNoBox.Name = "ItemNoBox";
            this.ItemNoBox.Size = new System.Drawing.Size(172, 26);
            this.ItemNoBox.TabIndex = 4;
            // 
            // DescBox
            // 
            this.DescBox.Location = new System.Drawing.Point(258, 181);
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(347, 26);
            this.DescBox.TabIndex = 5;
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(258, 238);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(172, 26);
            this.PriceBox.TabIndex = 6;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(258, 364);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(107, 30);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(465, 364);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(113, 30);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.DescBox);
            this.Controls.Add(this.ItemNoBox);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.ItemNo);
            this.Controls.Add(this.Header);
            this.Name = "AddItemsForm";
            this.Text = "AddItemsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Label ItemNo;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox ItemNoBox;
        private System.Windows.Forms.TextBox DescBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button Cancel;
    }
}