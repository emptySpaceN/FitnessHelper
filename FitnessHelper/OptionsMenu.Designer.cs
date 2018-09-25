namespace FitnessHelper
{
    partial class OptionsMenu
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
            this.AdministrateFood = new System.Windows.Forms.Button();
            this.AdministrateDays = new System.Windows.Forms.Button();
            this.GroupDatabaseAdministration = new System.Windows.Forms.GroupBox();
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.LanguageSettings = new System.Windows.Forms.GroupBox();
            this.LanguageHolder = new System.Windows.Forms.ComboBox();
            this.GroupDatabaseAdministration.SuspendLayout();
            this.BackgroundPanel.SuspendLayout();
            this.LanguageSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdministrateFood
            // 
            this.AdministrateFood.Location = new System.Drawing.Point(16, 57);
            this.AdministrateFood.Name = "AdministrateFood";
            this.AdministrateFood.Size = new System.Drawing.Size(196, 23);
            this.AdministrateFood.TabIndex = 0;
            this.AdministrateFood.Text = "_nutrition/meals";
            this.AdministrateFood.UseVisualStyleBackColor = true;
            this.AdministrateFood.Click += new System.EventHandler(this.AdministrateFood_Click);
            // 
            // AdministrateDays
            // 
            this.AdministrateDays.Location = new System.Drawing.Point(16, 28);
            this.AdministrateDays.Name = "AdministrateDays";
            this.AdministrateDays.Size = new System.Drawing.Size(196, 23);
            this.AdministrateDays.TabIndex = 2;
            this.AdministrateDays.Text = "_days";
            this.AdministrateDays.UseVisualStyleBackColor = true;
            this.AdministrateDays.Click += new System.EventHandler(this.AdministratDays_Click);
            // 
            // GroupDatabaseAdministration
            // 
            this.GroupDatabaseAdministration.Controls.Add(this.AdministrateDays);
            this.GroupDatabaseAdministration.Controls.Add(this.AdministrateFood);
            this.GroupDatabaseAdministration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GroupDatabaseAdministration.Location = new System.Drawing.Point(13, 14);
            this.GroupDatabaseAdministration.Name = "GroupDatabaseAdministration";
            this.GroupDatabaseAdministration.Size = new System.Drawing.Size(232, 105);
            this.GroupDatabaseAdministration.TabIndex = 3;
            this.GroupDatabaseAdministration.TabStop = false;
            this.GroupDatabaseAdministration.Text = "_administrate database";
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackColor = System.Drawing.Color.White;
            this.BackgroundPanel.Controls.Add(this.LanguageSettings);
            this.BackgroundPanel.Controls.Add(this.GroupDatabaseAdministration);
            this.BackgroundPanel.Location = new System.Drawing.Point(12, 12);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(794, 318);
            this.BackgroundPanel.TabIndex = 4;
            // 
            // LanguageSettings
            // 
            this.LanguageSettings.Controls.Add(this.LanguageHolder);
            this.LanguageSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LanguageSettings.Location = new System.Drawing.Point(13, 137);
            this.LanguageSettings.Name = "LanguageSettings";
            this.LanguageSettings.Size = new System.Drawing.Size(232, 105);
            this.LanguageSettings.TabIndex = 4;
            this.LanguageSettings.TabStop = false;
            this.LanguageSettings.Text = "_language";
            // 
            // LanguageHolder
            // 
            this.LanguageHolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageHolder.FormattingEnabled = true;
            this.LanguageHolder.Location = new System.Drawing.Point(16, 41);
            this.LanguageHolder.Name = "LanguageHolder";
            this.LanguageHolder.Size = new System.Drawing.Size(121, 21);
            this.LanguageHolder.TabIndex = 5;
            this.LanguageHolder.SelectionChangeCommitted += new System.EventHandler(this.LanguageHolder_SelectionChangeCommitted);
            // 
            // OptionsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 342);
            this.Controls.Add(this.BackgroundPanel);
            this.Name = "OptionsMenu";
            this.Text = "_settings";
            this.GroupDatabaseAdministration.ResumeLayout(false);
            this.BackgroundPanel.ResumeLayout(false);
            this.LanguageSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdministrateFood;
        private System.Windows.Forms.Button AdministrateDays;
        private System.Windows.Forms.GroupBox GroupDatabaseAdministration;
        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.GroupBox LanguageSettings;
        private System.Windows.Forms.ComboBox LanguageHolder;
    }
}