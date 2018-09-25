namespace FitnessHelper
{
    partial class ChooseMeal
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
            this.components = new System.ComponentModel.Container();
            this.ApplyMeal = new System.Windows.Forms.Button();
            this.mealIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proteinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carbohydratesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caloriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodListing = new System.Windows.Forms.DataGridView();
            this.FoodDatabaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FoodDatabaseDataSet = new FitnessHelper.FoodDatabaseDataSet();
            this.NewMeal = new System.Windows.Forms.Button();
            this.EditMeal = new System.Windows.Forms.Button();
            this.FilterBox = new System.Windows.Forms.TextBox();
            this.FilterMeals = new System.Windows.Forms.Label();
            this.FoodDatabaseTableAdapter = new FitnessHelper.FoodDatabaseDataSetTableAdapters.FoodDatabaseTableAdapter();
            this.DeleteMeal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FoodListing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodDatabaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ApplyMeal
            // 
            this.ApplyMeal.Location = new System.Drawing.Point(686, 353);
            this.ApplyMeal.Name = "ApplyMeal";
            this.ApplyMeal.Size = new System.Drawing.Size(109, 23);
            this.ApplyMeal.TabIndex = 0;
            this.ApplyMeal.Text = "Übernehmen";
            this.ApplyMeal.UseVisualStyleBackColor = true;
            this.ApplyMeal.Click += new System.EventHandler(this.ApplyMeal_Click);
            // 
            // mealIDDataGridViewTextBoxColumn
            // 
            this.mealIDDataGridViewTextBoxColumn.Name = "mealIDDataGridViewTextBoxColumn";
            // 
            // mealNameDataGridViewTextBoxColumn
            // 
            this.mealNameDataGridViewTextBoxColumn.Name = "mealNameDataGridViewTextBoxColumn";
            // 
            // proteinDataGridViewTextBoxColumn
            // 
            this.proteinDataGridViewTextBoxColumn.Name = "proteinDataGridViewTextBoxColumn";
            // 
            // fatsDataGridViewTextBoxColumn
            // 
            this.fatsDataGridViewTextBoxColumn.Name = "fatsDataGridViewTextBoxColumn";
            // 
            // carbohydratesDataGridViewTextBoxColumn
            // 
            this.carbohydratesDataGridViewTextBoxColumn.Name = "carbohydratesDataGridViewTextBoxColumn";
            // 
            // caloriesDataGridViewTextBoxColumn
            // 
            this.caloriesDataGridViewTextBoxColumn.Name = "caloriesDataGridViewTextBoxColumn";
            // 
            // FoodListing
            // 
            this.FoodListing.AllowUserToAddRows = false;
            this.FoodListing.AllowUserToDeleteRows = false;
            this.FoodListing.AllowUserToResizeColumns = false;
            this.FoodListing.AllowUserToResizeRows = false;
            this.FoodListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FoodListing.Location = new System.Drawing.Point(12, 12);
            this.FoodListing.MultiSelect = false;
            this.FoodListing.Name = "FoodListing";
            this.FoodListing.ReadOnly = true;
            this.FoodListing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FoodListing.Size = new System.Drawing.Size(783, 324);
            this.FoodListing.TabIndex = 17;
            this.FoodListing.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FoodListing_CellDoubleClick);
            // 
            // FoodDatabaseBindingSource
            // 
            this.FoodDatabaseBindingSource.DataMember = "FoodDatabase";
            this.FoodDatabaseBindingSource.DataSource = this.FoodDatabaseDataSet;
            // 
            // FoodDatabaseDataSet
            // 
            this.FoodDatabaseDataSet.DataSetName = "FoodDatabaseDataSet";
            this.FoodDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NewMeal
            // 
            this.NewMeal.Location = new System.Drawing.Point(12, 353);
            this.NewMeal.Name = "NewMeal";
            this.NewMeal.Size = new System.Drawing.Size(75, 23);
            this.NewMeal.TabIndex = 18;
            this.NewMeal.Text = "Hinzufügen";
            this.NewMeal.UseVisualStyleBackColor = true;
            this.NewMeal.Click += new System.EventHandler(this.NewMeal_Click);
            // 
            // EditMeal
            // 
            this.EditMeal.Location = new System.Drawing.Point(93, 353);
            this.EditMeal.Name = "EditMeal";
            this.EditMeal.Size = new System.Drawing.Size(75, 23);
            this.EditMeal.TabIndex = 19;
            this.EditMeal.Text = "Bearbeiten";
            this.EditMeal.UseVisualStyleBackColor = true;
            this.EditMeal.Click += new System.EventHandler(this.EditMeal_Click);
            // 
            // FilterBox
            // 
            this.FilterBox.Location = new System.Drawing.Point(356, 355);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.Size = new System.Drawing.Size(275, 20);
            this.FilterBox.TabIndex = 20;
            this.FilterBox.TextChanged += new System.EventHandler(this.FilterBox_TextChanged);
            this.FilterBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilterBox_KeyDown);
            // 
            // FilterMeals
            // 
            this.FilterMeals.AutoSize = true;
            this.FilterMeals.Location = new System.Drawing.Point(318, 358);
            this.FilterMeals.Name = "FilterMeals";
            this.FilterMeals.Size = new System.Drawing.Size(32, 13);
            this.FilterMeals.TabIndex = 21;
            this.FilterMeals.Text = "Filter:";
            // 
            // FoodDatabaseTableAdapter
            // 
            this.FoodDatabaseTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteMeal
            // 
            this.DeleteMeal.Location = new System.Drawing.Point(174, 353);
            this.DeleteMeal.Name = "DeleteMeal";
            this.DeleteMeal.Size = new System.Drawing.Size(75, 23);
            this.DeleteMeal.TabIndex = 22;
            this.DeleteMeal.Text = "Löschen";
            this.DeleteMeal.UseVisualStyleBackColor = true;
            this.DeleteMeal.Click += new System.EventHandler(this.DeleteMeal_Click);
            // 
            // ChooseMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 396);
            this.Controls.Add(this.DeleteMeal);
            this.Controls.Add(this.FilterMeals);
            this.Controls.Add(this.FilterBox);
            this.Controls.Add(this.EditMeal);
            this.Controls.Add(this.NewMeal);
            this.Controls.Add(this.FoodListing);
            this.Controls.Add(this.ApplyMeal);
            this.Name = "ChooseMeal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseMeal";
            ((System.ComponentModel.ISupportInitialize)(this.FoodListing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodDatabaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ApplyMeal;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proteinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carbohydratesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caloriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView FoodListing;
        private System.Windows.Forms.Button NewMeal;
        private System.Windows.Forms.Button EditMeal;
        private System.Windows.Forms.TextBox FilterBox;
        private System.Windows.Forms.Label FilterMeals;
        private System.Windows.Forms.Button DeleteMeal;
        public FoodDatabaseDataSet FoodDatabaseDataSet;
        private System.Windows.Forms.BindingSource FoodDatabaseBindingSource;
        public FoodDatabaseDataSetTableAdapters.FoodDatabaseTableAdapter FoodDatabaseTableAdapter;
    }
}