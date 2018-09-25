namespace FitnessHelper
{
    partial class DayOverview
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CurrentDay = new System.Windows.Forms.Label();
            this.MealNameTitel = new System.Windows.Forms.Label();
            this.ProteinTitel = new System.Windows.Forms.Label();
            this.FatsTitel = new System.Windows.Forms.Label();
            this.CaloriesTitel = new System.Windows.Forms.Label();
            this.CarbohydratesTitel = new System.Windows.Forms.Label();
            this.SummaryTitel = new System.Windows.Forms.Label();
            this.SumProtein = new System.Windows.Forms.Label();
            this.SumFats = new System.Windows.Forms.Label();
            this.SumCarbohydrates = new System.Windows.Forms.Label();
            this.SumCalories = new System.Windows.Forms.Label();
            this.SummaryLineSeparator = new System.Windows.Forms.Panel();
            this.SaveDay = new System.Windows.Forms.Button();
            this.GramsTitel = new System.Windows.Forms.Label();
            this.MealPerDayDatabaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mealPerDayDatabaseDataSet = new FitnessHelper.MealPerDayDatabaseDataSet();
            this.mealPerDayDatabaseTableAdapter = new FitnessHelper.MealPerDayDatabaseDataSetTableAdapters.MealPerDayDatabaseTableAdapter();
            this.foodDatabaseDataSet1 = new FitnessHelper.FoodDatabaseDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.MealPerDayDatabaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealPerDayDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentDay
            // 
            this.CurrentDay.AutoSize = true;
            this.CurrentDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDay.Location = new System.Drawing.Point(12, 9);
            this.CurrentDay.Name = "CurrentDay";
            this.CurrentDay.Size = new System.Drawing.Size(120, 26);
            this.CurrentDay.TabIndex = 1;
            this.CurrentDay.Text = "current day";
            // 
            // MealNameTitel
            // 
            this.MealNameTitel.AutoSize = true;
            this.MealNameTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MealNameTitel.Location = new System.Drawing.Point(106, 61);
            this.MealNameTitel.Name = "MealNameTitel";
            this.MealNameTitel.Size = new System.Drawing.Size(51, 17);
            this.MealNameTitel.TabIndex = 2;
            this.MealNameTitel.Text = "Essen:";
            // 
            // ProteinTitel
            // 
            this.ProteinTitel.AutoSize = true;
            this.ProteinTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProteinTitel.Location = new System.Drawing.Point(269, 61);
            this.ProteinTitel.Name = "ProteinTitel";
            this.ProteinTitel.Size = new System.Drawing.Size(102, 17);
            this.ProteinTitel.TabIndex = 3;
            this.ProteinTitel.Text = "Protein/Eiweiß:";
            // 
            // FatsTitel
            // 
            this.FatsTitel.AutoSize = true;
            this.FatsTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FatsTitel.Location = new System.Drawing.Point(456, 61);
            this.FatsTitel.Name = "FatsTitel";
            this.FatsTitel.Size = new System.Drawing.Size(36, 17);
            this.FatsTitel.TabIndex = 4;
            this.FatsTitel.Text = "Fett:";
            // 
            // CaloriesTitel
            // 
            this.CaloriesTitel.AutoSize = true;
            this.CaloriesTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaloriesTitel.Location = new System.Drawing.Point(744, 61);
            this.CaloriesTitel.Name = "CaloriesTitel";
            this.CaloriesTitel.Size = new System.Drawing.Size(103, 17);
            this.CaloriesTitel.TabIndex = 5;
            this.CaloriesTitel.Text = "Kalorien (kcal):";
            // 
            // CarbohydratesTitel
            // 
            this.CarbohydratesTitel.AutoSize = true;
            this.CarbohydratesTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarbohydratesTitel.Location = new System.Drawing.Point(582, 61);
            this.CarbohydratesTitel.Name = "CarbohydratesTitel";
            this.CarbohydratesTitel.Size = new System.Drawing.Size(104, 17);
            this.CarbohydratesTitel.TabIndex = 6;
            this.CarbohydratesTitel.Text = "Kohlenhydrate:";
            // 
            // SummaryTitel
            // 
            this.SummaryTitel.AutoSize = true;
            this.SummaryTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryTitel.Location = new System.Drawing.Point(25, 182);
            this.SummaryTitel.Name = "SummaryTitel";
            this.SummaryTitel.Size = new System.Drawing.Size(132, 17);
            this.SummaryTitel.TabIndex = 7;
            this.SummaryTitel.Text = "Zusammenfassung:";
            // 
            // SumProtein
            // 
            this.SumProtein.AutoSize = true;
            this.SumProtein.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumProtein.Location = new System.Drawing.Point(269, 182);
            this.SumProtein.Name = "SumProtein";
            this.SumProtein.Size = new System.Drawing.Size(16, 17);
            this.SumProtein.TabIndex = 8;
            this.SumProtein.Text = "0";
            // 
            // SumFats
            // 
            this.SumFats.AutoSize = true;
            this.SumFats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumFats.Location = new System.Drawing.Point(456, 182);
            this.SumFats.Name = "SumFats";
            this.SumFats.Size = new System.Drawing.Size(16, 17);
            this.SumFats.TabIndex = 9;
            this.SumFats.Text = "0";
            // 
            // SumCarbohydrates
            // 
            this.SumCarbohydrates.AutoSize = true;
            this.SumCarbohydrates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumCarbohydrates.Location = new System.Drawing.Point(582, 182);
            this.SumCarbohydrates.Name = "SumCarbohydrates";
            this.SumCarbohydrates.Size = new System.Drawing.Size(16, 17);
            this.SumCarbohydrates.TabIndex = 10;
            this.SumCarbohydrates.Text = "0";
            // 
            // SumCalories
            // 
            this.SumCalories.AutoSize = true;
            this.SumCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumCalories.Location = new System.Drawing.Point(744, 182);
            this.SumCalories.Name = "SumCalories";
            this.SumCalories.Size = new System.Drawing.Size(16, 17);
            this.SumCalories.TabIndex = 11;
            this.SumCalories.Text = "0";
            // 
            // SummaryLineSeparator
            // 
            this.SummaryLineSeparator.BackColor = System.Drawing.Color.Black;
            this.SummaryLineSeparator.Location = new System.Drawing.Point(109, 166);
            this.SummaryLineSeparator.Name = "SummaryLineSeparator";
            this.SummaryLineSeparator.Size = new System.Drawing.Size(738, 1);
            this.SummaryLineSeparator.TabIndex = 12;
            // 
            // SaveDay
            // 
            this.SaveDay.Location = new System.Drawing.Point(17, 58);
            this.SaveDay.Name = "SaveDay";
            this.SaveDay.Size = new System.Drawing.Size(75, 23);
            this.SaveDay.TabIndex = 13;
            this.SaveDay.Text = "Speichern";
            this.SaveDay.UseVisualStyleBackColor = true;
            this.SaveDay.Click += new System.EventHandler(this.SaveDay_Click);
            // 
            // GramsTitel
            // 
            this.GramsTitel.AutoSize = true;
            this.GramsTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GramsTitel.Location = new System.Drawing.Point(180, 61);
            this.GramsTitel.Name = "GramsTitel";
            this.GramsTitel.Size = new System.Drawing.Size(58, 17);
            this.GramsTitel.TabIndex = 14;
            this.GramsTitel.Text = "Gramm:";
            // 
            // MealPerDayDatabaseBindingSource
            // 
            this.MealPerDayDatabaseBindingSource.DataMember = "MealPerDayDatabase";
            this.MealPerDayDatabaseBindingSource.DataSource = this.mealPerDayDatabaseDataSet;
            // 
            // mealPerDayDatabaseDataSet
            // 
            this.mealPerDayDatabaseDataSet.DataSetName = "MealPerDayDatabaseDataSet";
            this.mealPerDayDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mealPerDayDatabaseTableAdapter
            // 
            this.mealPerDayDatabaseTableAdapter.ClearBeforeFill = true;
            // 
            // foodDatabaseDataSet1
            // 
            this.foodDatabaseDataSet1.DataSetName = "FoodDatabaseDataSet";
            this.foodDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DayOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 520);
            this.Controls.Add(this.GramsTitel);
            this.Controls.Add(this.SaveDay);
            this.Controls.Add(this.SummaryLineSeparator);
            this.Controls.Add(this.SumCalories);
            this.Controls.Add(this.SumCarbohydrates);
            this.Controls.Add(this.SumFats);
            this.Controls.Add(this.SumProtein);
            this.Controls.Add(this.SummaryTitel);
            this.Controls.Add(this.CarbohydratesTitel);
            this.Controls.Add(this.CaloriesTitel);
            this.Controls.Add(this.FatsTitel);
            this.Controls.Add(this.ProteinTitel);
            this.Controls.Add(this.MealNameTitel);
            this.Controls.Add(this.CurrentDay);
            this.Name = "DayOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "tagtest";
            this.Text = "Tagesübersicht";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DayOverview_FormClosing);
            this.Load += new System.EventHandler(this.DayOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MealPerDayDatabaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealPerDayDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CurrentDay;
        private System.Windows.Forms.Label MealNameTitel;
        private System.Windows.Forms.Label ProteinTitel;
        private System.Windows.Forms.Label FatsTitel;
        private System.Windows.Forms.Label CaloriesTitel;
        private System.Windows.Forms.Label CarbohydratesTitel;
        private System.Windows.Forms.Label SummaryTitel;
        private System.Windows.Forms.Label SumProtein;
        private System.Windows.Forms.Label SumFats;
        private System.Windows.Forms.Label SumCarbohydrates;
        private System.Windows.Forms.Label SumCalories;
        private System.Windows.Forms.Panel SummaryLineSeparator;
        private System.Windows.Forms.Button SaveDay;
        private System.Windows.Forms.Label GramsTitel;
        public MealPerDayDatabaseDataSet mealPerDayDatabaseDataSet;
        private System.Windows.Forms.BindingSource MealPerDayDatabaseBindingSource;
        public MealPerDayDatabaseDataSetTableAdapters.MealPerDayDatabaseTableAdapter mealPerDayDatabaseTableAdapter;
        private FoodDatabaseDataSet foodDatabaseDataSet1;
    }
}

