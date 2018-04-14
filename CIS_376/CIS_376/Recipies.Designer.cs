namespace CIS_376
{
    partial class Recipies
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
            this.Recipes = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ingedients = new System.Windows.Forms.ListBox();
            this.Directions = new System.Windows.Forms.ListBox();
            this.Return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Recipes
            // 
            this.Recipes.AutoSize = true;
            this.Recipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recipes.Location = new System.Drawing.Point(41, 44);
            this.Recipes.Name = "Recipes";
            this.Recipes.Size = new System.Drawing.Size(82, 25);
            this.Recipes.TabIndex = 0;
            this.Recipes.Text = "Recipes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(46, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 204);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Ingedients
            // 
            this.Ingedients.FormattingEnabled = true;
            this.Ingedients.Location = new System.Drawing.Point(404, 67);
            this.Ingedients.Name = "Ingedients";
            this.Ingedients.Size = new System.Drawing.Size(291, 121);
            this.Ingedients.TabIndex = 2;
            // 
            // Directions
            // 
            this.Directions.FormattingEnabled = true;
            this.Directions.Location = new System.Drawing.Point(404, 236);
            this.Directions.Name = "Directions";
            this.Directions.Size = new System.Drawing.Size(291, 121);
            this.Directions.TabIndex = 3;
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(619, 35);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 23);
            this.Return.TabIndex = 4;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            // 
            // Recipies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Directions);
            this.Controls.Add(this.Ingedients);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Recipes);
            this.Name = "Recipies";
            this.Text = "Recipies";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Recipes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox Ingedients;
        private System.Windows.Forms.ListBox Directions;
        private System.Windows.Forms.Button Return;
    }
}