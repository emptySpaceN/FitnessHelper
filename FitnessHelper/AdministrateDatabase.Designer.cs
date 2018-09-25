namespace FitnessHelper
{
    partial class AdministrateDatabase
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
            this.DatabaseGrid = new System.Windows.Forms.DataGridView();
            this.ExportDatabase = new System.Windows.Forms.Button();
            this.ImportData = new System.Windows.Forms.Button();
            this.DeleteDatabase = new System.Windows.Forms.CheckBox();
            this.ContainsColumnTitles = new System.Windows.Forms.CheckBox();
            this.DeleteMeal = new System.Windows.Forms.Button();
            this.FilterMeals = new System.Windows.Forms.Label();
            this.FilterBox = new System.Windows.Forms.TextBox();
            this.EditMeal = new System.Windows.Forms.Button();
            this.NewMeal = new System.Windows.Forms.Button();
            this.ApplyMeal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DatabaseGrid
            // 
            this.DatabaseGrid.AllowUserToAddRows = false;
            this.DatabaseGrid.AllowUserToDeleteRows = false;
            this.DatabaseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatabaseGrid.Location = new System.Drawing.Point(12, 12);
            this.DatabaseGrid.Name = "DatabaseGrid";
            this.DatabaseGrid.Size = new System.Drawing.Size(854, 376);
            this.DatabaseGrid.TabIndex = 0;
            // 
            // ExportDatabase
            // 
            this.ExportDatabase.Location = new System.Drawing.Point(12, 394);
            this.ExportDatabase.Name = "ExportDatabase";
            this.ExportDatabase.Size = new System.Drawing.Size(75, 23);
            this.ExportDatabase.TabIndex = 1;
            this.ExportDatabase.Text = "Exportieren";
            this.ExportDatabase.UseVisualStyleBackColor = true;
            this.ExportDatabase.Click += new System.EventHandler(this.ExportDatabase_Click);
            // 
            // ImportData
            // 
            this.ImportData.Location = new System.Drawing.Point(381, 394);
            this.ImportData.Name = "ImportData";
            this.ImportData.Size = new System.Drawing.Size(75, 23);
            this.ImportData.TabIndex = 2;
            this.ImportData.Text = "Importieren";
            this.ImportData.UseVisualStyleBackColor = true;
            this.ImportData.Click += new System.EventHandler(this.ImportData_Click);
            // 
            // DeleteDatabase
            // 
            this.DeleteDatabase.AutoSize = true;
            this.DeleteDatabase.Location = new System.Drawing.Point(462, 398);
            this.DeleteDatabase.Name = "DeleteDatabase";
            this.DeleteDatabase.Size = new System.Drawing.Size(119, 17);
            this.DeleteDatabase.TabIndex = 3;
            this.DeleteDatabase.Text = "Datenbank löschen";
            this.DeleteDatabase.UseVisualStyleBackColor = true;
            this.DeleteDatabase.CheckedChanged += new System.EventHandler(this.DeleteDatabase_CheckedChanged);
            // 
            // ContainsColumnTitles
            // 
            this.ContainsColumnTitles.AutoSize = true;
            this.ContainsColumnTitles.Location = new System.Drawing.Point(587, 398);
            this.ContainsColumnTitles.Name = "ContainsColumnTitles";
            this.ContainsColumnTitles.Size = new System.Drawing.Size(130, 17);
            this.ContainsColumnTitles.TabIndex = 4;
            this.ContainsColumnTitles.Text = "Enthält Spaltennamen";
            this.ContainsColumnTitles.UseVisualStyleBackColor = true;
            // 
            // DeleteMeal
            // 
            this.DeleteMeal.Location = new System.Drawing.Point(174, 449);
            this.DeleteMeal.Name = "DeleteMeal";
            this.DeleteMeal.Size = new System.Drawing.Size(75, 23);
            this.DeleteMeal.TabIndex = 28;
            this.DeleteMeal.Text = "Löschen";
            this.DeleteMeal.UseVisualStyleBackColor = true;
            // 
            // FilterMeals
            // 
            this.FilterMeals.AutoSize = true;
            this.FilterMeals.Location = new System.Drawing.Point(318, 454);
            this.FilterMeals.Name = "FilterMeals";
            this.FilterMeals.Size = new System.Drawing.Size(32, 13);
            this.FilterMeals.TabIndex = 27;
            this.FilterMeals.Text = "Filter:";
            // 
            // FilterBox
            // 
            this.FilterBox.Location = new System.Drawing.Point(356, 451);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.Size = new System.Drawing.Size(275, 20);
            this.FilterBox.TabIndex = 26;
            this.FilterBox.TextChanged += new System.EventHandler(this.FilterBox_TextChanged);
            this.FilterBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilterBox_KeyDown);
            // 
            // EditMeal
            // 
            this.EditMeal.Location = new System.Drawing.Point(93, 449);
            this.EditMeal.Name = "EditMeal";
            this.EditMeal.Size = new System.Drawing.Size(75, 23);
            this.EditMeal.TabIndex = 25;
            this.EditMeal.Text = "Bearbeiten";
            this.EditMeal.UseVisualStyleBackColor = true;
            // 
            // NewMeal
            // 
            this.NewMeal.Location = new System.Drawing.Point(12, 449);
            this.NewMeal.Name = "NewMeal";
            this.NewMeal.Size = new System.Drawing.Size(75, 23);
            this.NewMeal.TabIndex = 24;
            this.NewMeal.Text = "Hinzufügen";
            this.NewMeal.UseVisualStyleBackColor = true;
            // 
            // ApplyMeal
            // 
            this.ApplyMeal.Location = new System.Drawing.Point(686, 449);
            this.ApplyMeal.Name = "ApplyMeal";
            this.ApplyMeal.Size = new System.Drawing.Size(109, 23);
            this.ApplyMeal.TabIndex = 23;
            this.ApplyMeal.Text = "Übernehmen";
            this.ApplyMeal.UseVisualStyleBackColor = true;
            // 
            // AdministrateDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 539);
            this.Controls.Add(this.DeleteMeal);
            this.Controls.Add(this.FilterMeals);
            this.Controls.Add(this.FilterBox);
            this.Controls.Add(this.EditMeal);
            this.Controls.Add(this.NewMeal);
            this.Controls.Add(this.ApplyMeal);
            this.Controls.Add(this.ContainsColumnTitles);
            this.Controls.Add(this.DeleteDatabase);
            this.Controls.Add(this.ImportData);
            this.Controls.Add(this.ExportDatabase);
            this.Controls.Add(this.DatabaseGrid);
            this.Name = "AdministrateDatabase";
            this.Text = "AdministrateDatabase";
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DatabaseGrid;
        private System.Windows.Forms.Button ExportDatabase;
        private System.Windows.Forms.Button ImportData;
        private System.Windows.Forms.CheckBox DeleteDatabase;
        private System.Windows.Forms.CheckBox ContainsColumnTitles;
        private System.Windows.Forms.Button DeleteMeal;
        private System.Windows.Forms.Label FilterMeals;
        private System.Windows.Forms.TextBox FilterBox;
        private System.Windows.Forms.Button EditMeal;
        private System.Windows.Forms.Button NewMeal;
        private System.Windows.Forms.Button ApplyMeal;
    }
}