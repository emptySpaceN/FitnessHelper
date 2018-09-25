namespace FitnessHelper
{
    partial class AddMeal
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
            this.CarbohydratesTitel = new System.Windows.Forms.Label();
            this.CaloriesTitel = new System.Windows.Forms.Label();
            this.FatsTitel = new System.Windows.Forms.Label();
            this.ProteinTitel = new System.Windows.Forms.Label();
            this.MealNameTitel = new System.Windows.Forms.Label();
            this.MealName = new System.Windows.Forms.TextBox();
            this.ProteinCount = new System.Windows.Forms.TextBox();
            this.FatCount = new System.Windows.Forms.TextBox();
            this.CarbohydratesCount = new System.Windows.Forms.TextBox();
            this.CaloriesCount = new System.Windows.Forms.TextBox();
            this.AddMealToDatabase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CarbohydratesTitel
            // 
            this.CarbohydratesTitel.AutoSize = true;
            this.CarbohydratesTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarbohydratesTitel.Location = new System.Drawing.Point(488, 9);
            this.CarbohydratesTitel.Name = "CarbohydratesTitel";
            this.CarbohydratesTitel.Size = new System.Drawing.Size(104, 17);
            this.CarbohydratesTitel.TabIndex = 11;
            this.CarbohydratesTitel.Text = "Kohlenhydrate:";
            // 
            // CaloriesTitel
            // 
            this.CaloriesTitel.AutoSize = true;
            this.CaloriesTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaloriesTitel.Location = new System.Drawing.Point(650, 9);
            this.CaloriesTitel.Name = "CaloriesTitel";
            this.CaloriesTitel.Size = new System.Drawing.Size(103, 17);
            this.CaloriesTitel.TabIndex = 10;
            this.CaloriesTitel.Text = "Kalorien (kcal):";
            // 
            // FatsTitel
            // 
            this.FatsTitel.AutoSize = true;
            this.FatsTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FatsTitel.Location = new System.Drawing.Point(362, 9);
            this.FatsTitel.Name = "FatsTitel";
            this.FatsTitel.Size = new System.Drawing.Size(36, 17);
            this.FatsTitel.TabIndex = 9;
            this.FatsTitel.Text = "Fett:";
            // 
            // ProteinTitel
            // 
            this.ProteinTitel.AutoSize = true;
            this.ProteinTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProteinTitel.Location = new System.Drawing.Point(175, 9);
            this.ProteinTitel.Name = "ProteinTitel";
            this.ProteinTitel.Size = new System.Drawing.Size(102, 17);
            this.ProteinTitel.TabIndex = 8;
            this.ProteinTitel.Text = "Protein/Eiweiß:";
            // 
            // MealNameTitel
            // 
            this.MealNameTitel.AutoSize = true;
            this.MealNameTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MealNameTitel.Location = new System.Drawing.Point(12, 9);
            this.MealNameTitel.Name = "MealNameTitel";
            this.MealNameTitel.Size = new System.Drawing.Size(51, 17);
            this.MealNameTitel.TabIndex = 7;
            this.MealNameTitel.Text = "Essen:";
            // 
            // MealName
            // 
            this.MealName.Location = new System.Drawing.Point(12, 29);
            this.MealName.Name = "MealName";
            this.MealName.Size = new System.Drawing.Size(100, 20);
            this.MealName.TabIndex = 12;
            // 
            // ProteinCount
            // 
            this.ProteinCount.Location = new System.Drawing.Point(178, 29);
            this.ProteinCount.Name = "ProteinCount";
            this.ProteinCount.Size = new System.Drawing.Size(100, 20);
            this.ProteinCount.TabIndex = 13;
            // 
            // FatCount
            // 
            this.FatCount.Location = new System.Drawing.Point(365, 29);
            this.FatCount.Name = "FatCount";
            this.FatCount.Size = new System.Drawing.Size(100, 20);
            this.FatCount.TabIndex = 14;
            // 
            // CarbohydratesCount
            // 
            this.CarbohydratesCount.Location = new System.Drawing.Point(491, 29);
            this.CarbohydratesCount.Name = "CarbohydratesCount";
            this.CarbohydratesCount.Size = new System.Drawing.Size(100, 20);
            this.CarbohydratesCount.TabIndex = 15;
            // 
            // CaloriesCount
            // 
            this.CaloriesCount.Location = new System.Drawing.Point(653, 29);
            this.CaloriesCount.Name = "CaloriesCount";
            this.CaloriesCount.Size = new System.Drawing.Size(100, 20);
            this.CaloriesCount.TabIndex = 16;
            // 
            // AddMealToDatabase
            // 
            this.AddMealToDatabase.Location = new System.Drawing.Point(12, 55);
            this.AddMealToDatabase.Name = "AddMealToDatabase";
            this.AddMealToDatabase.Size = new System.Drawing.Size(75, 23);
            this.AddMealToDatabase.TabIndex = 17;
            this.AddMealToDatabase.Text = "Erstellen";
            this.AddMealToDatabase.UseVisualStyleBackColor = true;
            this.AddMealToDatabase.Click += new System.EventHandler(this.AddMealToDatabase_Click);
            // 
            // AddMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 111);
            this.Controls.Add(this.AddMealToDatabase);
            this.Controls.Add(this.CaloriesCount);
            this.Controls.Add(this.CarbohydratesCount);
            this.Controls.Add(this.FatCount);
            this.Controls.Add(this.ProteinCount);
            this.Controls.Add(this.MealName);
            this.Controls.Add(this.CarbohydratesTitel);
            this.Controls.Add(this.CaloriesTitel);
            this.Controls.Add(this.FatsTitel);
            this.Controls.Add(this.ProteinTitel);
            this.Controls.Add(this.MealNameTitel);
            this.Name = "AddMeal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A";
            this.Load += new System.EventHandler(this.AddMeal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CarbohydratesTitel;
        private System.Windows.Forms.Label CaloriesTitel;
        private System.Windows.Forms.Label FatsTitel;
        private System.Windows.Forms.Label ProteinTitel;
        private System.Windows.Forms.Label MealNameTitel;
        private System.Windows.Forms.TextBox MealName;
        private System.Windows.Forms.TextBox ProteinCount;
        private System.Windows.Forms.TextBox FatCount;
        private System.Windows.Forms.TextBox CarbohydratesCount;
        private System.Windows.Forms.TextBox CaloriesCount;
        private System.Windows.Forms.Button AddMealToDatabase;
    }
}