namespace FitnessHelper
{
    partial class BMR_DailyCalorieCalculate
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
            this.AgeTitle = new System.Windows.Forms.Label();
            this.HeightTitle = new System.Windows.Forms.Label();
            this.WeightTitle = new System.Windows.Forms.Label();
            this.HeightContainer = new System.Windows.Forms.TextBox();
            this.WeightContainer = new System.Windows.Forms.TextBox();
            this.BMRTitle = new System.Windows.Forms.Label();
            this.DailyCalorieNeedTitle = new System.Windows.Forms.Label();
            this.CalculateAndDisplay = new System.Windows.Forms.Button();
            this.GenderContainer = new System.Windows.Forms.ComboBox();
            this.GenderTitle = new System.Windows.Forms.Label();
            this.BMR_Result = new System.Windows.Forms.Label();
            this.DailyCalorieNeed_Result = new System.Windows.Forms.Label();
            this.AgeContainer = new System.Windows.Forms.ComboBox();
            this.ActivityTitle = new System.Windows.Forms.Label();
            this.ActivityOneTitle = new System.Windows.Forms.Label();
            this.ActivityOneText = new System.Windows.Forms.Label();
            this.ActivityTwoText = new System.Windows.Forms.Label();
            this.ActivityTwoTitle = new System.Windows.Forms.Label();
            this.ActivityThreeText = new System.Windows.Forms.Label();
            this.ActivityThreeTitle = new System.Windows.Forms.Label();
            this.ActivityFourText = new System.Windows.Forms.Label();
            this.ActivityFourTitle = new System.Windows.Forms.Label();
            this.ActivityFiveText = new System.Windows.Forms.Label();
            this.ActivityFiveTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ActivityOneHours = new System.Windows.Forms.TextBox();
            this.ActivityTwoHours = new System.Windows.Forms.TextBox();
            this.ActivityThreeHours = new System.Windows.Forms.TextBox();
            this.ActivityFourHours = new System.Windows.Forms.TextBox();
            this.ActivityFiveHours = new System.Windows.Forms.TextBox();
            this.HoursSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AgeTitle
            // 
            this.AgeTitle.AutoSize = true;
            this.AgeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeTitle.Location = new System.Drawing.Point(176, 56);
            this.AgeTitle.Name = "AgeTitle";
            this.AgeTitle.Size = new System.Drawing.Size(44, 16);
            this.AgeTitle.TabIndex = 0;
            this.AgeTitle.Text = "Alter:";
            // 
            // HeightTitle
            // 
            this.HeightTitle.AutoSize = true;
            this.HeightTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightTitle.Location = new System.Drawing.Point(301, 56);
            this.HeightTitle.Name = "HeightTitle";
            this.HeightTitle.Size = new System.Drawing.Size(55, 16);
            this.HeightTitle.TabIndex = 1;
            this.HeightTitle.Text = "Größe:";
            // 
            // WeightTitle
            // 
            this.WeightTitle.AutoSize = true;
            this.WeightTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightTitle.Location = new System.Drawing.Point(418, 56);
            this.WeightTitle.Name = "WeightTitle";
            this.WeightTitle.Size = new System.Drawing.Size(66, 16);
            this.WeightTitle.TabIndex = 2;
            this.WeightTitle.Text = "Gewicht:";
            // 
            // HeightContainer
            // 
            this.HeightContainer.Location = new System.Drawing.Point(304, 75);
            this.HeightContainer.Name = "HeightContainer";
            this.HeightContainer.Size = new System.Drawing.Size(61, 20);
            this.HeightContainer.TabIndex = 4;
            // 
            // WeightContainer
            // 
            this.WeightContainer.Location = new System.Drawing.Point(421, 75);
            this.WeightContainer.Name = "WeightContainer";
            this.WeightContainer.Size = new System.Drawing.Size(61, 20);
            this.WeightContainer.TabIndex = 5;
            // 
            // BMRTitle
            // 
            this.BMRTitle.AutoSize = true;
            this.BMRTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMRTitle.Location = new System.Drawing.Point(30, 358);
            this.BMRTitle.Name = "BMRTitle";
            this.BMRTitle.Size = new System.Drawing.Size(101, 16);
            this.BMRTitle.TabIndex = 6;
            this.BMRTitle.Text = "Grundumsatz:";
            // 
            // DailyCalorieNeedTitle
            // 
            this.DailyCalorieNeedTitle.AutoSize = true;
            this.DailyCalorieNeedTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailyCalorieNeedTitle.Location = new System.Drawing.Point(155, 358);
            this.DailyCalorieNeedTitle.Name = "DailyCalorieNeedTitle";
            this.DailyCalorieNeedTitle.Size = new System.Drawing.Size(105, 16);
            this.DailyCalorieNeedTitle.TabIndex = 7;
            this.DailyCalorieNeedTitle.Text = "Tagesumsatz:";
            // 
            // CalculateAndDisplay
            // 
            this.CalculateAndDisplay.Location = new System.Drawing.Point(351, 393);
            this.CalculateAndDisplay.Name = "CalculateAndDisplay";
            this.CalculateAndDisplay.Size = new System.Drawing.Size(75, 23);
            this.CalculateAndDisplay.TabIndex = 8;
            this.CalculateAndDisplay.Text = "Berechnen";
            this.CalculateAndDisplay.UseVisualStyleBackColor = true;
            this.CalculateAndDisplay.Click += new System.EventHandler(this.CalculateAndDisplay_Click);
            // 
            // GenderContainer
            // 
            this.GenderContainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderContainer.FormattingEnabled = true;
            this.GenderContainer.Location = new System.Drawing.Point(23, 74);
            this.GenderContainer.Name = "GenderContainer";
            this.GenderContainer.Size = new System.Drawing.Size(121, 21);
            this.GenderContainer.TabIndex = 9;
            // 
            // GenderTitle
            // 
            this.GenderTitle.AutoSize = true;
            this.GenderTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderTitle.Location = new System.Drawing.Point(20, 55);
            this.GenderTitle.Name = "GenderTitle";
            this.GenderTitle.Size = new System.Drawing.Size(89, 16);
            this.GenderTitle.TabIndex = 10;
            this.GenderTitle.Text = "Geschlecht:";
            // 
            // BMR_Result
            // 
            this.BMR_Result.AutoSize = true;
            this.BMR_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMR_Result.Location = new System.Drawing.Point(30, 384);
            this.BMR_Result.Name = "BMR_Result";
            this.BMR_Result.Size = new System.Drawing.Size(13, 16);
            this.BMR_Result.TabIndex = 11;
            this.BMR_Result.Text = "-";
            // 
            // DailyCalorieNeed_Result
            // 
            this.DailyCalorieNeed_Result.AutoSize = true;
            this.DailyCalorieNeed_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailyCalorieNeed_Result.Location = new System.Drawing.Point(155, 384);
            this.DailyCalorieNeed_Result.Name = "DailyCalorieNeed_Result";
            this.DailyCalorieNeed_Result.Size = new System.Drawing.Size(13, 16);
            this.DailyCalorieNeed_Result.TabIndex = 12;
            this.DailyCalorieNeed_Result.Text = "-";
            // 
            // AgeContainer
            // 
            this.AgeContainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AgeContainer.FormattingEnabled = true;
            this.AgeContainer.Location = new System.Drawing.Point(179, 75);
            this.AgeContainer.Name = "AgeContainer";
            this.AgeContainer.Size = new System.Drawing.Size(61, 21);
            this.AgeContainer.TabIndex = 13;
            // 
            // ActivityTitle
            // 
            this.ActivityTitle.AutoSize = true;
            this.ActivityTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityTitle.Location = new System.Drawing.Point(20, 124);
            this.ActivityTitle.Name = "ActivityTitle";
            this.ActivityTitle.Size = new System.Drawing.Size(132, 16);
            this.ActivityTitle.TabIndex = 14;
            this.ActivityTitle.Text = "Aktivitäten wählen";
            // 
            // ActivityOneTitle
            // 
            this.ActivityOneTitle.AutoSize = true;
            this.ActivityOneTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityOneTitle.Location = new System.Drawing.Point(20, 156);
            this.ActivityOneTitle.Name = "ActivityOneTitle";
            this.ActivityOneTitle.Size = new System.Drawing.Size(59, 16);
            this.ActivityOneTitle.TabIndex = 15;
            this.ActivityOneTitle.Text = "Sitzend";
            // 
            // ActivityOneText
            // 
            this.ActivityOneText.AutoSize = true;
            this.ActivityOneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityOneText.Location = new System.Drawing.Point(20, 172);
            this.ActivityOneText.Name = "ActivityOneText";
            this.ActivityOneText.Size = new System.Drawing.Size(103, 52);
            this.ActivityOneText.TabIndex = 16;
            this.ActivityOneText.Text = "Keine oder wenig\r\nBewegung (Bürojob)\r\n\r\nFaktor: 1,2";
            // 
            // ActivityTwoText
            // 
            this.ActivityTwoText.AutoSize = true;
            this.ActivityTwoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityTwoText.Location = new System.Drawing.Point(140, 172);
            this.ActivityTwoText.Name = "ActivityTwoText";
            this.ActivityTwoText.Size = new System.Drawing.Size(89, 52);
            this.ActivityTwoText.TabIndex = 18;
            this.ActivityTwoText.Text = "Leichte Übungen\r\n\r\n\r\nFaktor: 1,375";
            // 
            // ActivityTwoTitle
            // 
            this.ActivityTwoTitle.AutoSize = true;
            this.ActivityTwoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityTwoTitle.Location = new System.Drawing.Point(140, 156);
            this.ActivityTwoTitle.Name = "ActivityTwoTitle";
            this.ActivityTwoTitle.Size = new System.Drawing.Size(86, 16);
            this.ActivityTwoTitle.TabIndex = 17;
            this.ActivityTwoTitle.Text = "Leicht aktiv";
            // 
            // ActivityThreeText
            // 
            this.ActivityThreeText.AutoSize = true;
            this.ActivityThreeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityThreeText.Location = new System.Drawing.Point(260, 172);
            this.ActivityThreeText.Name = "ActivityThreeText";
            this.ActivityThreeText.Size = new System.Drawing.Size(99, 52);
            this.ActivityThreeText.TabIndex = 20;
            this.ActivityThreeText.Text = "Moderate Übungen\r\n\r\n\r\nFaktor: 1,55";
            // 
            // ActivityThreeTitle
            // 
            this.ActivityThreeTitle.AutoSize = true;
            this.ActivityThreeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityThreeTitle.Location = new System.Drawing.Point(260, 156);
            this.ActivityThreeTitle.Name = "ActivityThreeTitle";
            this.ActivityThreeTitle.Size = new System.Drawing.Size(102, 16);
            this.ActivityThreeTitle.TabIndex = 19;
            this.ActivityThreeTitle.Text = "Moderat aktiv";
            // 
            // ActivityFourText
            // 
            this.ActivityFourText.AutoSize = true;
            this.ActivityFourText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityFourText.Location = new System.Drawing.Point(380, 172);
            this.ActivityFourText.Name = "ActivityFourText";
            this.ActivityFourText.Size = new System.Drawing.Size(96, 52);
            this.ActivityFourText.TabIndex = 22;
            this.ActivityFourText.Text = "Schwere Übungen\r\n\r\n\r\nFaktor: 1,725";
            // 
            // ActivityFourTitle
            // 
            this.ActivityFourTitle.AutoSize = true;
            this.ActivityFourTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityFourTitle.Location = new System.Drawing.Point(380, 156);
            this.ActivityFourTitle.Name = "ActivityFourTitle";
            this.ActivityFourTitle.Size = new System.Drawing.Size(77, 16);
            this.ActivityFourTitle.TabIndex = 21;
            this.ActivityFourTitle.Text = "Sehr aktiv";
            // 
            // ActivityFiveText
            // 
            this.ActivityFiveText.AutoSize = true;
            this.ActivityFiveText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityFiveText.Location = new System.Drawing.Point(500, 172);
            this.ActivityFiveText.Name = "ActivityFiveText";
            this.ActivityFiveText.Size = new System.Drawing.Size(239, 52);
            this.ActivityFiveText.TabIndex = 24;
            this.ActivityFiveText.Text = "Täglich schwere Übungen, 2x Training\r\npro Tag oder schwere Arbeit und zusätzlich " +
    "Sport\r\n\r\nFaktor: 1,9";
            // 
            // ActivityFiveTitle
            // 
            this.ActivityFiveTitle.AutoSize = true;
            this.ActivityFiveTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityFiveTitle.Location = new System.Drawing.Point(500, 156);
            this.ActivityFiveTitle.Name = "ActivityFiveTitle";
            this.ActivityFiveTitle.Size = new System.Drawing.Size(92, 16);
            this.ActivityFiveTitle.TabIndex = 23;
            this.ActivityFiveTitle.Text = "Extrem aktiv";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(23, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 1);
            this.panel1.TabIndex = 25;
            // 
            // ActivityOneHours
            // 
            this.ActivityOneHours.Location = new System.Drawing.Point(20, 246);
            this.ActivityOneHours.Name = "ActivityOneHours";
            this.ActivityOneHours.Size = new System.Drawing.Size(100, 20);
            this.ActivityOneHours.TabIndex = 26;
            this.ActivityOneHours.TextChanged += new System.EventHandler(this.ActivityOneHours_TextChanged);
            // 
            // ActivityTwoHours
            // 
            this.ActivityTwoHours.Location = new System.Drawing.Point(140, 246);
            this.ActivityTwoHours.Name = "ActivityTwoHours";
            this.ActivityTwoHours.Size = new System.Drawing.Size(100, 20);
            this.ActivityTwoHours.TabIndex = 27;
            this.ActivityTwoHours.TextChanged += new System.EventHandler(this.ActivityTwoHours_TextChanged);
            // 
            // ActivityThreeHours
            // 
            this.ActivityThreeHours.Location = new System.Drawing.Point(260, 246);
            this.ActivityThreeHours.Name = "ActivityThreeHours";
            this.ActivityThreeHours.Size = new System.Drawing.Size(100, 20);
            this.ActivityThreeHours.TabIndex = 28;
            this.ActivityThreeHours.TextChanged += new System.EventHandler(this.ActivityThreeHours_TextChanged);
            // 
            // ActivityFourHours
            // 
            this.ActivityFourHours.Location = new System.Drawing.Point(380, 246);
            this.ActivityFourHours.Name = "ActivityFourHours";
            this.ActivityFourHours.Size = new System.Drawing.Size(100, 20);
            this.ActivityFourHours.TabIndex = 29;
            this.ActivityFourHours.TextChanged += new System.EventHandler(this.ActivityFourHours_TextChanged);
            // 
            // ActivityFiveHours
            // 
            this.ActivityFiveHours.Location = new System.Drawing.Point(500, 246);
            this.ActivityFiveHours.Name = "ActivityFiveHours";
            this.ActivityFiveHours.Size = new System.Drawing.Size(100, 20);
            this.ActivityFiveHours.TabIndex = 30;
            this.ActivityFiveHours.TextChanged += new System.EventHandler(this.ActivityFiveHours_TextChanged);
            // 
            // HoursSum
            // 
            this.HoursSum.AutoSize = true;
            this.HoursSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursSum.Location = new System.Drawing.Point(735, 247);
            this.HoursSum.Name = "HoursSum";
            this.HoursSum.Size = new System.Drawing.Size(63, 16);
            this.HoursSum.TabIndex = 31;
            this.HoursSum.Text = "Summe:";
            // 
            // BMR_DailyCalorieCalculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 461);
            this.Controls.Add(this.HoursSum);
            this.Controls.Add(this.ActivityFiveHours);
            this.Controls.Add(this.ActivityFourHours);
            this.Controls.Add(this.ActivityThreeHours);
            this.Controls.Add(this.ActivityTwoHours);
            this.Controls.Add(this.ActivityOneHours);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ActivityFiveText);
            this.Controls.Add(this.ActivityFiveTitle);
            this.Controls.Add(this.ActivityFourText);
            this.Controls.Add(this.ActivityFourTitle);
            this.Controls.Add(this.ActivityThreeText);
            this.Controls.Add(this.ActivityThreeTitle);
            this.Controls.Add(this.ActivityTwoText);
            this.Controls.Add(this.ActivityTwoTitle);
            this.Controls.Add(this.ActivityOneText);
            this.Controls.Add(this.ActivityOneTitle);
            this.Controls.Add(this.ActivityTitle);
            this.Controls.Add(this.AgeContainer);
            this.Controls.Add(this.DailyCalorieNeed_Result);
            this.Controls.Add(this.BMR_Result);
            this.Controls.Add(this.GenderTitle);
            this.Controls.Add(this.GenderContainer);
            this.Controls.Add(this.CalculateAndDisplay);
            this.Controls.Add(this.DailyCalorieNeedTitle);
            this.Controls.Add(this.BMRTitle);
            this.Controls.Add(this.WeightContainer);
            this.Controls.Add(this.HeightContainer);
            this.Controls.Add(this.WeightTitle);
            this.Controls.Add(this.HeightTitle);
            this.Controls.Add(this.AgeTitle);
            this.Name = "BMR_DailyCalorieCalculate";
            this.Text = "BMR_DailyCalorieCalculate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AgeTitle;
        private System.Windows.Forms.Label HeightTitle;
        private System.Windows.Forms.Label WeightTitle;
        private System.Windows.Forms.TextBox HeightContainer;
        private System.Windows.Forms.TextBox WeightContainer;
        private System.Windows.Forms.Label BMRTitle;
        private System.Windows.Forms.Label DailyCalorieNeedTitle;
        private System.Windows.Forms.Button CalculateAndDisplay;
        private System.Windows.Forms.ComboBox GenderContainer;
        private System.Windows.Forms.Label GenderTitle;
        private System.Windows.Forms.Label BMR_Result;
        private System.Windows.Forms.Label DailyCalorieNeed_Result;
        private System.Windows.Forms.ComboBox AgeContainer;
        private System.Windows.Forms.Label ActivityTitle;
        private System.Windows.Forms.Label ActivityOneTitle;
        private System.Windows.Forms.Label ActivityOneText;
        private System.Windows.Forms.Label ActivityTwoText;
        private System.Windows.Forms.Label ActivityTwoTitle;
        private System.Windows.Forms.Label ActivityThreeText;
        private System.Windows.Forms.Label ActivityThreeTitle;
        private System.Windows.Forms.Label ActivityFourText;
        private System.Windows.Forms.Label ActivityFourTitle;
        private System.Windows.Forms.Label ActivityFiveText;
        private System.Windows.Forms.Label ActivityFiveTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ActivityOneHours;
        private System.Windows.Forms.TextBox ActivityTwoHours;
        private System.Windows.Forms.TextBox ActivityThreeHours;
        private System.Windows.Forms.TextBox ActivityFourHours;
        private System.Windows.Forms.TextBox ActivityFiveHours;
        private System.Windows.Forms.Label HoursSum;
    }
}