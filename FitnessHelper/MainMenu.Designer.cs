namespace FitnessHelper
{
    partial class MainMenu
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
            this.CurrentYear = new System.Windows.Forms.Label();
            this.WeekTabName = new System.Windows.Forms.Label();
            this.MonthTabName = new System.Windows.Forms.Label();
            this.TopBar = new System.Windows.Forms.Panel();
            this.Options = new System.Windows.Forms.Button();
            this.MiddleBar = new System.Windows.Forms.Panel();
            this.WeekTab = new System.Windows.Forms.Panel();
            this.MonthTab = new System.Windows.Forms.Panel();
            this.DayHolder = new System.Windows.Forms.Panel();
            this.CurrentMonth = new System.Windows.Forms.Label();
            this.NextMonth = new System.Windows.Forms.Button();
            this.PreviousMonth = new System.Windows.Forms.Button();
            this.CurrentDay = new System.Windows.Forms.Label();
            this.NutritionYesterdayTitle = new System.Windows.Forms.Label();
            this.ChangeDaily = new System.Windows.Forms.Button();
            this.NutritionSelectedTitle = new System.Windows.Forms.Label();
            this.CarbohydratesYesterdayTitel = new System.Windows.Forms.Label();
            this.CaloriesYesterdayTitel = new System.Windows.Forms.Label();
            this.FatsYesterdayTitel = new System.Windows.Forms.Label();
            this.ProteinYesterdayTitel = new System.Windows.Forms.Label();
            this.CarbohydratesSelectedTitel = new System.Windows.Forms.Label();
            this.CaloriesSelectedTitel = new System.Windows.Forms.Label();
            this.FatsSelectedTitel = new System.Windows.Forms.Label();
            this.ProteinSelectedTitel = new System.Windows.Forms.Label();
            this.CaloriesSumYesterday = new System.Windows.Forms.Label();
            this.CarbohydratesSumYesterday = new System.Windows.Forms.Label();
            this.FatsSumYesterday = new System.Windows.Forms.Label();
            this.ProteinSumYesterday = new System.Windows.Forms.Label();
            this.CaloriesSumSelected = new System.Windows.Forms.Label();
            this.CarbohydratesSumSelected = new System.Windows.Forms.Label();
            this.FatsSumSelected = new System.Windows.Forms.Label();
            this.ProteinSumSelected = new System.Windows.Forms.Label();
            this.TopBar.SuspendLayout();
            this.WeekTab.SuspendLayout();
            this.MonthTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrentYear
            // 
            this.CurrentYear.AutoSize = true;
            this.CurrentYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentYear.Location = new System.Drawing.Point(3, 8);
            this.CurrentYear.Name = "CurrentYear";
            this.CurrentYear.Size = new System.Drawing.Size(152, 26);
            this.CurrentYear.TabIndex = 0;
            this.CurrentYear.Text = "_current year";
            this.CurrentYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeekTabName
            // 
            this.WeekTabName.AutoSize = true;
            this.WeekTabName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekTabName.Location = new System.Drawing.Point(3, 0);
            this.WeekTabName.Name = "WeekTabName";
            this.WeekTabName.Size = new System.Drawing.Size(55, 20);
            this.WeekTabName.TabIndex = 1;
            this.WeekTabName.Text = "_week";
            this.WeekTabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MonthTabName
            // 
            this.MonthTabName.AutoSize = true;
            this.MonthTabName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthTabName.Location = new System.Drawing.Point(17, 12);
            this.MonthTabName.Name = "MonthTabName";
            this.MonthTabName.Size = new System.Drawing.Size(63, 20);
            this.MonthTabName.TabIndex = 2;
            this.MonthTabName.Text = "_month";
            this.MonthTabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(108)))), ((int)(((byte)(158)))));
            this.TopBar.Controls.Add(this.Options);
            this.TopBar.Controls.Add(this.CurrentYear);
            this.TopBar.Location = new System.Drawing.Point(12, 1);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(950, 54);
            this.TopBar.TabIndex = 3;
            // 
            // Options
            // 
            this.Options.Image = global::FitnessHelper.Properties.Resources.Settings_32x;
            this.Options.Location = new System.Drawing.Point(896, 8);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(40, 40);
            this.Options.TabIndex = 29;
            this.Options.UseVisualStyleBackColor = true;
            this.Options.Click += new System.EventHandler(this.Options_Click);
            // 
            // MiddleBar
            // 
            this.MiddleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.MiddleBar.Location = new System.Drawing.Point(12, 61);
            this.MiddleBar.Name = "MiddleBar";
            this.MiddleBar.Size = new System.Drawing.Size(950, 48);
            this.MiddleBar.TabIndex = 4;
            // 
            // WeekTab
            // 
            this.WeekTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(92)))), ((int)(((byte)(113)))));
            this.WeekTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WeekTab.Controls.Add(this.WeekTabName);
            this.WeekTab.Location = new System.Drawing.Point(12, 142);
            this.WeekTab.Name = "WeekTab";
            this.WeekTab.Size = new System.Drawing.Size(87, 34);
            this.WeekTab.TabIndex = 0;
            // 
            // MonthTab
            // 
            this.MonthTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(92)))), ((int)(((byte)(113)))));
            this.MonthTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MonthTab.Controls.Add(this.MonthTabName);
            this.MonthTab.Location = new System.Drawing.Point(105, 142);
            this.MonthTab.Name = "MonthTab";
            this.MonthTab.Size = new System.Drawing.Size(87, 34);
            this.MonthTab.TabIndex = 5;
            // 
            // DayHolder
            // 
            this.DayHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.DayHolder.Location = new System.Drawing.Point(12, 227);
            this.DayHolder.Name = "DayHolder";
            this.DayHolder.Size = new System.Drawing.Size(414, 375);
            this.DayHolder.TabIndex = 6;
            // 
            // CurrentMonth
            // 
            this.CurrentMonth.AutoSize = true;
            this.CurrentMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentMonth.Location = new System.Drawing.Point(105, 198);
            this.CurrentMonth.Name = "CurrentMonth";
            this.CurrentMonth.Size = new System.Drawing.Size(108, 16);
            this.CurrentMonth.TabIndex = 3;
            this.CurrentMonth.Text = "_current month";
            this.CurrentMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NextMonth
            // 
            this.NextMonth.Location = new System.Drawing.Point(339, 198);
            this.NextMonth.Name = "NextMonth";
            this.NextMonth.Size = new System.Drawing.Size(87, 23);
            this.NextMonth.TabIndex = 7;
            this.NextMonth.Text = ">";
            this.NextMonth.UseVisualStyleBackColor = true;
            this.NextMonth.Click += new System.EventHandler(this.button1_Click);
            // 
            // PreviousMonth
            // 
            this.PreviousMonth.Location = new System.Drawing.Point(12, 198);
            this.PreviousMonth.Name = "PreviousMonth";
            this.PreviousMonth.Size = new System.Drawing.Size(87, 23);
            this.PreviousMonth.TabIndex = 8;
            this.PreviousMonth.Text = "<";
            this.PreviousMonth.UseVisualStyleBackColor = true;
            this.PreviousMonth.Click += new System.EventHandler(this.button2_Click);
            // 
            // CurrentDay
            // 
            this.CurrentDay.AutoSize = true;
            this.CurrentDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.CurrentDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDay.ForeColor = System.Drawing.Color.White;
            this.CurrentDay.Location = new System.Drawing.Point(242, 201);
            this.CurrentDay.Name = "CurrentDay";
            this.CurrentDay.Size = new System.Drawing.Size(91, 17);
            this.CurrentDay.TabIndex = 9;
            this.CurrentDay.Text = "current day";
            this.CurrentDay.Click += new System.EventHandler(this.CurrentDay_Click);
            // 
            // NutritionYesterdayTitle
            // 
            this.NutritionYesterdayTitle.AutoSize = true;
            this.NutritionYesterdayTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NutritionYesterdayTitle.Location = new System.Drawing.Point(476, 227);
            this.NutritionYesterdayTitle.Name = "NutritionYesterdayTitle";
            this.NutritionYesterdayTitle.Size = new System.Drawing.Size(85, 16);
            this.NutritionYesterdayTitle.TabIndex = 10;
            this.NutritionYesterdayTitle.Text = "_yesterday";
            // 
            // ChangeDaily
            // 
            this.ChangeDaily.Location = new System.Drawing.Point(559, 532);
            this.ChangeDaily.Name = "ChangeDaily";
            this.ChangeDaily.Size = new System.Drawing.Size(75, 23);
            this.ChangeDaily.TabIndex = 11;
            this.ChangeDaily.Text = "button3";
            this.ChangeDaily.UseVisualStyleBackColor = true;
            this.ChangeDaily.Click += new System.EventHandler(this.ChangeDaily_Click);
            // 
            // NutritionSelectedTitle
            // 
            this.NutritionSelectedTitle.AutoSize = true;
            this.NutritionSelectedTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NutritionSelectedTitle.Location = new System.Drawing.Point(476, 402);
            this.NutritionSelectedTitle.Name = "NutritionSelectedTitle";
            this.NutritionSelectedTitle.Size = new System.Drawing.Size(106, 16);
            this.NutritionSelectedTitle.TabIndex = 12;
            this.NutritionSelectedTitle.Text = "_selected day";
            // 
            // CarbohydratesYesterdayTitel
            // 
            this.CarbohydratesYesterdayTitel.AutoSize = true;
            this.CarbohydratesYesterdayTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarbohydratesYesterdayTitel.Location = new System.Drawing.Point(663, 243);
            this.CarbohydratesYesterdayTitel.Name = "CarbohydratesYesterdayTitel";
            this.CarbohydratesYesterdayTitel.Size = new System.Drawing.Size(100, 17);
            this.CarbohydratesYesterdayTitel.TabIndex = 16;
            this.CarbohydratesYesterdayTitel.Text = "_carbohydrate";
            // 
            // CaloriesYesterdayTitel
            // 
            this.CaloriesYesterdayTitel.AutoSize = true;
            this.CaloriesYesterdayTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaloriesYesterdayTitel.Location = new System.Drawing.Point(800, 243);
            this.CaloriesYesterdayTitel.Name = "CaloriesYesterdayTitel";
            this.CaloriesYesterdayTitel.Size = new System.Drawing.Size(65, 17);
            this.CaloriesYesterdayTitel.TabIndex = 15;
            this.CaloriesYesterdayTitel.Text = "_calories";
            // 
            // FatsYesterdayTitel
            // 
            this.FatsYesterdayTitel.AutoSize = true;
            this.FatsYesterdayTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FatsYesterdayTitel.Location = new System.Drawing.Point(598, 243);
            this.FatsYesterdayTitel.Name = "FatsYesterdayTitel";
            this.FatsYesterdayTitel.Size = new System.Drawing.Size(32, 17);
            this.FatsYesterdayTitel.TabIndex = 14;
            this.FatsYesterdayTitel.Text = "_fat";
            // 
            // ProteinYesterdayTitel
            // 
            this.ProteinYesterdayTitel.AutoSize = true;
            this.ProteinYesterdayTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProteinYesterdayTitel.Location = new System.Drawing.Point(476, 243);
            this.ProteinYesterdayTitel.Name = "ProteinYesterdayTitel";
            this.ProteinYesterdayTitel.Size = new System.Drawing.Size(60, 17);
            this.ProteinYesterdayTitel.TabIndex = 13;
            this.ProteinYesterdayTitel.Text = "_protein";
            // 
            // CarbohydratesSelectedTitel
            // 
            this.CarbohydratesSelectedTitel.AutoSize = true;
            this.CarbohydratesSelectedTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarbohydratesSelectedTitel.Location = new System.Drawing.Point(663, 432);
            this.CarbohydratesSelectedTitel.Name = "CarbohydratesSelectedTitel";
            this.CarbohydratesSelectedTitel.Size = new System.Drawing.Size(100, 17);
            this.CarbohydratesSelectedTitel.TabIndex = 20;
            this.CarbohydratesSelectedTitel.Text = "_carbohydrate";
            // 
            // CaloriesSelectedTitel
            // 
            this.CaloriesSelectedTitel.AutoSize = true;
            this.CaloriesSelectedTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaloriesSelectedTitel.Location = new System.Drawing.Point(800, 432);
            this.CaloriesSelectedTitel.Name = "CaloriesSelectedTitel";
            this.CaloriesSelectedTitel.Size = new System.Drawing.Size(65, 17);
            this.CaloriesSelectedTitel.TabIndex = 19;
            this.CaloriesSelectedTitel.Text = "_calories";
            // 
            // FatsSelectedTitel
            // 
            this.FatsSelectedTitel.AutoSize = true;
            this.FatsSelectedTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FatsSelectedTitel.Location = new System.Drawing.Point(602, 432);
            this.FatsSelectedTitel.Name = "FatsSelectedTitel";
            this.FatsSelectedTitel.Size = new System.Drawing.Size(32, 17);
            this.FatsSelectedTitel.TabIndex = 18;
            this.FatsSelectedTitel.Text = "_fat";
            // 
            // ProteinSelectedTitel
            // 
            this.ProteinSelectedTitel.AutoSize = true;
            this.ProteinSelectedTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProteinSelectedTitel.Location = new System.Drawing.Point(476, 432);
            this.ProteinSelectedTitel.Name = "ProteinSelectedTitel";
            this.ProteinSelectedTitel.Size = new System.Drawing.Size(60, 17);
            this.ProteinSelectedTitel.TabIndex = 17;
            this.ProteinSelectedTitel.Text = "_protein";
            // 
            // CaloriesSumYesterday
            // 
            this.CaloriesSumYesterday.AutoSize = true;
            this.CaloriesSumYesterday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaloriesSumYesterday.Location = new System.Drawing.Point(800, 278);
            this.CaloriesSumYesterday.Name = "CaloriesSumYesterday";
            this.CaloriesSumYesterday.Size = new System.Drawing.Size(13, 17);
            this.CaloriesSumYesterday.TabIndex = 24;
            this.CaloriesSumYesterday.Text = "-";
            // 
            // CarbohydratesSumYesterday
            // 
            this.CarbohydratesSumYesterday.AutoSize = true;
            this.CarbohydratesSumYesterday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarbohydratesSumYesterday.Location = new System.Drawing.Point(663, 278);
            this.CarbohydratesSumYesterday.Name = "CarbohydratesSumYesterday";
            this.CarbohydratesSumYesterday.Size = new System.Drawing.Size(13, 17);
            this.CarbohydratesSumYesterday.TabIndex = 23;
            this.CarbohydratesSumYesterday.Text = "-";
            // 
            // FatsSumYesterday
            // 
            this.FatsSumYesterday.AutoSize = true;
            this.FatsSumYesterday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FatsSumYesterday.Location = new System.Drawing.Point(602, 278);
            this.FatsSumYesterday.Name = "FatsSumYesterday";
            this.FatsSumYesterday.Size = new System.Drawing.Size(13, 17);
            this.FatsSumYesterday.TabIndex = 22;
            this.FatsSumYesterday.Text = "-";
            // 
            // ProteinSumYesterday
            // 
            this.ProteinSumYesterday.AutoSize = true;
            this.ProteinSumYesterday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProteinSumYesterday.Location = new System.Drawing.Point(476, 278);
            this.ProteinSumYesterday.Name = "ProteinSumYesterday";
            this.ProteinSumYesterday.Size = new System.Drawing.Size(13, 17);
            this.ProteinSumYesterday.TabIndex = 21;
            this.ProteinSumYesterday.Text = "-";
            // 
            // CaloriesSumSelected
            // 
            this.CaloriesSumSelected.AutoSize = true;
            this.CaloriesSumSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaloriesSumSelected.Location = new System.Drawing.Point(800, 464);
            this.CaloriesSumSelected.Name = "CaloriesSumSelected";
            this.CaloriesSumSelected.Size = new System.Drawing.Size(13, 17);
            this.CaloriesSumSelected.TabIndex = 28;
            this.CaloriesSumSelected.Text = "-";
            // 
            // CarbohydratesSumSelected
            // 
            this.CarbohydratesSumSelected.AutoSize = true;
            this.CarbohydratesSumSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarbohydratesSumSelected.Location = new System.Drawing.Point(663, 464);
            this.CarbohydratesSumSelected.Name = "CarbohydratesSumSelected";
            this.CarbohydratesSumSelected.Size = new System.Drawing.Size(13, 17);
            this.CarbohydratesSumSelected.TabIndex = 27;
            this.CarbohydratesSumSelected.Text = "-";
            // 
            // FatsSumSelected
            // 
            this.FatsSumSelected.AutoSize = true;
            this.FatsSumSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FatsSumSelected.Location = new System.Drawing.Point(602, 464);
            this.FatsSumSelected.Name = "FatsSumSelected";
            this.FatsSumSelected.Size = new System.Drawing.Size(13, 17);
            this.FatsSumSelected.TabIndex = 26;
            this.FatsSumSelected.Text = "-";
            // 
            // ProteinSumSelected
            // 
            this.ProteinSumSelected.AutoSize = true;
            this.ProteinSumSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProteinSumSelected.Location = new System.Drawing.Point(476, 464);
            this.ProteinSumSelected.Name = "ProteinSumSelected";
            this.ProteinSumSelected.Size = new System.Drawing.Size(13, 17);
            this.ProteinSumSelected.TabIndex = 25;
            this.ProteinSumSelected.Text = "-";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 614);
            this.Controls.Add(this.CaloriesSumSelected);
            this.Controls.Add(this.CarbohydratesSumSelected);
            this.Controls.Add(this.FatsSumSelected);
            this.Controls.Add(this.ProteinSumSelected);
            this.Controls.Add(this.CaloriesSumYesterday);
            this.Controls.Add(this.CarbohydratesSumYesterday);
            this.Controls.Add(this.FatsSumYesterday);
            this.Controls.Add(this.ProteinSumYesterday);
            this.Controls.Add(this.CarbohydratesSelectedTitel);
            this.Controls.Add(this.CaloriesSelectedTitel);
            this.Controls.Add(this.FatsSelectedTitel);
            this.Controls.Add(this.ProteinSelectedTitel);
            this.Controls.Add(this.CarbohydratesYesterdayTitel);
            this.Controls.Add(this.CaloriesYesterdayTitel);
            this.Controls.Add(this.FatsYesterdayTitel);
            this.Controls.Add(this.ProteinYesterdayTitel);
            this.Controls.Add(this.NutritionSelectedTitle);
            this.Controls.Add(this.ChangeDaily);
            this.Controls.Add(this.NutritionYesterdayTitle);
            this.Controls.Add(this.CurrentDay);
            this.Controls.Add(this.PreviousMonth);
            this.Controls.Add(this.NextMonth);
            this.Controls.Add(this.CurrentMonth);
            this.Controls.Add(this.DayHolder);
            this.Controls.Add(this.MonthTab);
            this.Controls.Add(this.MiddleBar);
            this.Controls.Add(this.WeekTab);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_overview";
            this.Resize += new System.EventHandler(this.MainMenu_Resize);
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            this.WeekTab.ResumeLayout(false);
            this.WeekTab.PerformLayout();
            this.MonthTab.ResumeLayout(false);
            this.MonthTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentYear;
        private System.Windows.Forms.Label WeekTabName;
        private System.Windows.Forms.Label MonthTabName;
        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Panel MiddleBar;
        private System.Windows.Forms.Panel WeekTab;
        private System.Windows.Forms.Panel MonthTab;
        private System.Windows.Forms.Panel DayHolder;
        private System.Windows.Forms.Label CurrentMonth;
        private System.Windows.Forms.Button NextMonth;
        private System.Windows.Forms.Button PreviousMonth;
        private System.Windows.Forms.Label CurrentDay;
        private System.Windows.Forms.Label NutritionYesterdayTitle;
        private System.Windows.Forms.Button ChangeDaily;
        private System.Windows.Forms.Label NutritionSelectedTitle;
        private System.Windows.Forms.Label CarbohydratesYesterdayTitel;
        private System.Windows.Forms.Label CaloriesYesterdayTitel;
        private System.Windows.Forms.Label FatsYesterdayTitel;
        private System.Windows.Forms.Label ProteinYesterdayTitel;
        private System.Windows.Forms.Label CarbohydratesSelectedTitel;
        private System.Windows.Forms.Label CaloriesSelectedTitel;
        private System.Windows.Forms.Label FatsSelectedTitel;
        private System.Windows.Forms.Label ProteinSelectedTitel;
        private System.Windows.Forms.Label CaloriesSumYesterday;
        private System.Windows.Forms.Label CarbohydratesSumYesterday;
        private System.Windows.Forms.Label FatsSumYesterday;
        private System.Windows.Forms.Label ProteinSumYesterday;
        private System.Windows.Forms.Label CaloriesSumSelected;
        private System.Windows.Forms.Label CarbohydratesSumSelected;
        private System.Windows.Forms.Label FatsSumSelected;
        private System.Windows.Forms.Label ProteinSumSelected;
        private System.Windows.Forms.Button Options;
    }
}