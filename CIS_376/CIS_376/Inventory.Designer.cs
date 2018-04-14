namespace CIS_376
{
    partial class Inventory
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
            this.FridgeInventroyLabel = new System.Windows.Forms.Label();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.SearchFridgeButton = new System.Windows.Forms.Button();
            this.AddItem = new System.Windows.Forms.Button();
            this.RemoveFoodButton = new System.Windows.Forms.Button();
            this.InvGridView = new System.Windows.Forms.DataGridView();
            this.Refresh_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InvGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FridgeInventroyLabel
            // 
            this.FridgeInventroyLabel.AutoSize = true;
            this.FridgeInventroyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FridgeInventroyLabel.Location = new System.Drawing.Point(34, 51);
            this.FridgeInventroyLabel.Name = "FridgeInventroyLabel";
            this.FridgeInventroyLabel.Size = new System.Drawing.Size(152, 25);
            this.FridgeInventroyLabel.TabIndex = 0;
            this.FridgeInventroyLabel.Text = "Fridge Inventory";
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(683, 55);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 23);
            this.ReturnButton.TabIndex = 1;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // SearchFridgeButton
            // 
            this.SearchFridgeButton.Location = new System.Drawing.Point(39, 390);
            this.SearchFridgeButton.Name = "SearchFridgeButton";
            this.SearchFridgeButton.Size = new System.Drawing.Size(75, 23);
            this.SearchFridgeButton.TabIndex = 2;
            this.SearchFridgeButton.Text = "Search";
            this.SearchFridgeButton.UseVisualStyleBackColor = true;
            this.SearchFridgeButton.Click += new System.EventHandler(this.SearchFridgeButton_Click);
            // 
            // AddItem
            // 
            this.AddItem.Location = new System.Drawing.Point(143, 390);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(75, 23);
            this.AddItem.TabIndex = 3;
            this.AddItem.Text = "Add Item";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveFoodButton
            // 
            this.RemoveFoodButton.Location = new System.Drawing.Point(242, 390);
            this.RemoveFoodButton.Name = "RemoveFoodButton";
            this.RemoveFoodButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveFoodButton.TabIndex = 5;
            this.RemoveFoodButton.Text = "Remove Item";
            this.RemoveFoodButton.UseVisualStyleBackColor = true;
            this.RemoveFoodButton.Click += new System.EventHandler(this.RemoveFoodButton_Click);
            // 
            // InvGridView
            // 
            this.InvGridView.AllowUserToResizeColumns = false;
            this.InvGridView.AllowUserToResizeRows = false;
            this.InvGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InvGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.InvGridView.Location = new System.Drawing.Point(39, 80);
            this.InvGridView.MultiSelect = false;
            this.InvGridView.Name = "InvGridView";
            this.InvGridView.ReadOnly = true;
            this.InvGridView.RowTemplate.ReadOnly = true;
            this.InvGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InvGridView.Size = new System.Drawing.Size(517, 304);
            this.InvGridView.TabIndex = 6;
            // 
            // Refresh_button
            // 
            this.Refresh_button.Location = new System.Drawing.Point(563, 80);
            this.Refresh_button.Name = "Refresh_button";
            this.Refresh_button.Size = new System.Drawing.Size(75, 23);
            this.Refresh_button.TabIndex = 7;
            this.Refresh_button.Text = "Refresh";
            this.Refresh_button.UseVisualStyleBackColor = true;
            this.Refresh_button.Click += new System.EventHandler(this.Refresh_button_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Refresh_button);
            this.Controls.Add(this.InvGridView);
            this.Controls.Add(this.RemoveFoodButton);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.SearchFridgeButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.FridgeInventroyLabel);
            this.Name = "Inventory";
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.InvGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FridgeInventroyLabel;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button SearchFridgeButton;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.Button RemoveFoodButton;
        private System.Windows.Forms.DataGridView InvGridView;
        private System.Windows.Forms.Button Refresh_button;
    }
}