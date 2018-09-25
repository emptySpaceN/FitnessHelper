using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessHelper
{
    public partial class DayOverview : Form
    {
        // The layout that has the database with meals
        private ChooseMeal chooseMealLayout;

        // Save button public available
        public Button SaveDayPublic
        {
            get { return SaveDay; }
            set { SaveDay = value; }
        }

        // These variables will be filled during the opening of the form
        private int passedYear;
        private int passedMonth;
        private int passedDay;

        public int passedYearPublic
        {
            get { return passedYear; }
            set { passedYear = value; }
        }
        public int passedMonthPublic
        {
            get { return passedMonth; }
            set { passedMonth = value; }
        }
        public int passedDayPublic
        {
            get { return passedDay; }
            set { passedDay = value; }
        }

        // Holds the database current row count
        private int databaseRowCount;

        // Counts how many liney = meals are choosen
        private int lineCounter;

        public int lineCounterPublic
        {
            get { return lineCounter; }
            set { lineCounter = value; }
        }

        // Holds the current line - is updated as soon as you click on the choose meal button
        private int currentLine;

        public int currentLinePublic
        {
            get { return currentLine; }
            set { currentLine = value; }
        }

        // This lists hold every control that is dynamically created and holds a value of the meal
        private List<Button> chooseHolder = new List<Button>();
        private List<Button> deleteMealHolder = new List<Button>();
        private List<Label> mealNameHolder = new List<Label>();
        private List<Label> proteinHolder = new List<Label>();
        private List<Label> fatsHolder = new List<Label>();
        private List<Label> carbohydratesHolder = new List<Label>();
        private List<Label> caloriesHolder = new List<Label>();

        public List<Button> chooseHolderPublic
        {
            get { return chooseHolder; }
        }
        public List<Button> deleteMealHolderPublic
        {
            get { return deleteMealHolder; }
        }
        public List<Label> mealNameHolderPublic
        {
            get { return mealNameHolder; }
        }
        public List<Label> proteinHolderPublic
        {
            get { return proteinHolder; }
        }
        public List<Label> fatsHolderPublic
        {
            get { return fatsHolder; }
        }
        public List<Label> carbohydratesHolderPublic
        {
            get { return carbohydratesHolder; }
        }
        public List<Label> caloriesHolderPublic
        {
            get { return caloriesHolder; }
        }

        private bool tableChanged = false;
        public bool databaseInitialized = false;

        private MainMenu mainMenuLayout;

        public MainMenu mainMenu_Layout
        {
            get { return mainMenuLayout; }
            set { mainMenuLayout = value; }
        }

        public DayOverview()
        {
            InitializeComponent();

            // Events

        }

        private void DayOverview_Load(object sender, EventArgs e)
        {
            // Set all text regarding the current culture info
            SetLocalisation();

            FillDatabaseAdapter();

            CurrentDay.Text = new DateTime(passedYear, passedMonth, passedDay).ToString("dddd, dd.MM.yyyy");

            Button Choose = new Button();
            Choose.Name = "Choose_" + lineCounter;
            Choose.Tag = lineCounter;
            Choose.Width = 24;
            Choose.Height = 24;
            Choose.Image = Properties.Resources.AddMeal_24x24;
            Choose.FlatStyle = FlatStyle.Flat;
            Choose.FlatAppearance.BorderSize = 0;
            Choose.FlatAppearance.BorderColor = this.BackColor;
            Choose.Tag = lineCounter;
            Choose.Left = MealNameTitel.Left - 50;
            Choose.Top = MealNameTitel.Top + Choose.Height + 15;
            Choose.Click += Choose_Click;


            // Place the separator line
            SummaryLineSeparator.Top = Choose.Top + Choose.Height + 7;
            SummaryLineSeparator.Left = Choose.Left;
            SummaryLineSeparator.Width = (CaloriesTitel.Left + CaloriesTitel.Width + 34) - Choose.Left;
            SummaryLineSeparator.Height = 1;

            // Positioning the summary line
            SummaryTitel.Top = Choose.Top + Choose.Height + 15;
            SumProtein.Top = SummaryTitel.Top;
            SumFats.Top = SummaryTitel.Top;
            SumCarbohydrates.Top = SummaryTitel.Top;
            SumCalories.Top = SummaryTitel.Top;

            this.Controls.Add(Choose);

            chooseHolder.Add(Choose);

            DateTime bufferDate = new DateTime();

            //MessageBox.Show("entries: " + mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows.Count);
            // Check and additionally load data from the database into the form
            for (int i = 0; i < mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows.Count; i++)
            {
                
                bufferDate = DateTime.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][1].ToString());

                //MessageBox.Show(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][0].ToString() + " - " + mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][1].ToString() + " - " + mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][2].ToString() + " - " + mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][3].ToString());
                

                if (bufferDate.ToString("dd.MM.yyyy") == (passedDay.ToString("00") + "." + passedMonth.ToString("00") + "." + passedYear.ToString("0000")))
                {
                    currentLine = deleteMealHolder.Count;

                    FillLineWithMeal(false,
                        mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][3].ToString(),
                        mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][4].ToString(),
                        mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][5].ToString(),
                        mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][6].ToString(),
                        mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][7].ToString(),
                        mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][0].ToString());
                }
            }

            SaveDay.Enabled = false;

            //return;
            //foreach (DataRow row in mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows)
            //{
            //    DateTime bufferDate = new DateTime();
            //    bufferDate = DateTime.Parse(row[1].ToString());

            //    if (bufferDate.ToString("dd.MM.yyyy") == (passedDay.ToString("00") + "." + passedMonth.ToString("00") + "." + passedYear.ToString("0000")))
            //    {
            //        FillLineWithMeal(false, "1", "1", "1", "1", "1", "1");
            //    }
            //}
        }

        private void SetLocalisation()
        {
            MealNameTitel.Text = Localization.strings.MainMenu_Label_Title_Meal;
        }

        public void FillDatabaseAdapter()
        {
            //if (!databaseInitialized)
            //{
                // TODO: Diese Codezeile lädt Daten in die Tabelle "mealPerDayDatabaseDataSet.MealPerDayDatabase". Sie können sie bei Bedarf verschieben oder entfernen.
                this.mealPerDayDatabaseTableAdapter.Fill(this.mealPerDayDatabaseDataSet.MealPerDayDatabase);

                //databaseInitialized = true;
            //}
        }



        public void FillLineWithMeal(bool _PassedEditType, string _PassedMealName, string _PassedProtein, string _PassedFats, string _PassedCarbohydrates, string _PassedCalories, string _PassedDatabaseID)
        {
            // Variables that will hold the sums of all meals/food
            float sumOfProtein = 0;
            float sumOfFat = 0;
            float sumOfCarbohydrates = 0;
            float sumOfCalories = 0;

            if (!_PassedEditType)
            {
                Label MealName = new Label();
                MealName.Name = "MealName_" + lineCounter;
                MealName.Text = _PassedMealName;
                MealName.Left = MealNameTitel.Left;
                MealName.TextAlign = ContentAlignment.MiddleLeft;
                MealName.Top = this.Controls["Choose_" + lineCounter].Top;

                Label Protein = new Label();
                Protein.Name = "Protein_" + lineCounter;
                Protein.Text = _PassedProtein;
                Protein.TextAlign = ContentAlignment.MiddleLeft;
                Protein.Left = ProteinTitel.Left;
                Protein.Top = this.Controls["Choose_" + lineCounter].Top;

                Label Fats = new Label();
                Fats.Name = "Fats_" + lineCounter;
                Fats.Text = _PassedFats;
                Fats.TextAlign = ContentAlignment.MiddleLeft;
                Fats.Left = FatsTitel.Left;
                Fats.Top = this.Controls["Choose_" + lineCounter].Top;

                Label Carbohydrates = new Label();
                Carbohydrates.Name = "Carbohydrates_" + lineCounter;
                Carbohydrates.Text = _PassedCarbohydrates;
                Carbohydrates.TextAlign = ContentAlignment.MiddleLeft;
                Carbohydrates.Left = CarbohydratesTitel.Left;
                Carbohydrates.Top = this.Controls["Choose_" + lineCounter].Top;

                Label Calories = new Label();
                Calories.Name = "Calories_" + lineCounter;
                Calories.Text = _PassedCalories;
                Calories.TextAlign = ContentAlignment.MiddleLeft;
                Calories.Left = CaloriesTitel.Left;
                Calories.Top = this.Controls["Choose_" + lineCounter].Top;

                Button DeleteMeal = new Button();
                DeleteMeal.Name = "DeleteMeal_" + lineCounter;
                DeleteMeal.Tag = lineCounter;
                DeleteMeal.Width = 24;
                DeleteMeal.Height = 24;
                DeleteMeal.Image = Properties.Resources.DeleteMeal_24x24;
                DeleteMeal.FlatStyle = FlatStyle.Flat;
                DeleteMeal.FlatAppearance.BorderSize = 0;
                DeleteMeal.FlatAppearance.BorderColor = this.BackColor;
                DeleteMeal.Left = CaloriesTitel.Left + CaloriesTitel.Width + 10;
                DeleteMeal.Top = this.Controls["Choose_" + lineCounter].Top;
                DeleteMeal.Click += DeleteMeal_Click;

                Button Choose = new Button();
                Choose.Name = "Choose_" + (lineCounter + 1);
                Choose.Tag = (lineCounter + 1);
                Choose.Width = 24;
                Choose.Height = 24;
                Choose.Image = Properties.Resources.AddMeal_24x24;
                Choose.FlatStyle = FlatStyle.Flat;
                Choose.FlatAppearance.BorderSize = 0;
                Choose.FlatAppearance.BorderColor = this.BackColor;
                Choose.Left = MealNameTitel.Left - 50;
                Choose.Top = this.Controls["Choose_" + lineCounter].Top + this.Controls["Choose_" + lineCounter].Height + 15;
                Choose.Click += Choose_Click;


                // Adding the controls to the form
                this.Controls.Add(MealName);
                this.Controls.Add(Protein);
                this.Controls.Add(Fats);
                this.Controls.Add(Carbohydrates);
                this.Controls.Add(Calories);
                this.Controls.Add(DeleteMeal);
                this.Controls.Add(Choose);

                // Place the separator line
                SummaryLineSeparator.Top = this.Controls["Choose_" + (lineCounter + 1)].Top + this.Controls["Choose_" + (lineCounter + 1)].Height + 7;
                SummaryLineSeparator.Left = this.Controls["Choose_" + (lineCounter + 1)].Left;
                SummaryLineSeparator.Width = (CaloriesTitel.Left + CaloriesTitel.Width + 34) - this.Controls["Choose_" + (lineCounter + 1)].Left;
                SummaryLineSeparator.Height = 1;

                // Positioning the summary line
                SummaryTitel.Top = this.Controls["Choose_" + (lineCounter + 1)].Top + this.Controls["Choose_" + (lineCounter + 1)].Height + 15;
                SummaryTitel.Left = MealNameTitel.Left; ;
                SumProtein.Top = SummaryTitel.Top;
                SumProtein.Left = ProteinTitel.Left;
                SumFats.Top = SummaryTitel.Top;
                SumFats.Left = FatsTitel.Left;
                SumCarbohydrates.Top = SummaryTitel.Top;
                SumCarbohydrates.Left = CarbohydratesTitel.Left;
                SumCalories.Top = SummaryTitel.Top;
                SumCalories.Left = CaloriesTitel.Left;

                // Adding the controls to the specific control holder
                mealNameHolder.Add(MealName);
                proteinHolder.Add(Protein);
                fatsHolder.Add(Fats);
                carbohydratesHolder.Add(Carbohydrates);
                caloriesHolder.Add(Calories);
                deleteMealHolder.Add(DeleteMeal);
                chooseHolder.Add(Choose);

                // Change the icon of the add/edit button after first adding a meal
                if (chooseHolderPublic[currentLine].Image != Properties.Resources.EditMeal_24x24)
                {
                    chooseHolderPublic[currentLine].Image = Properties.Resources.EditMeal_24x24;
                }

                // Increment the line counter
                lineCounter++;
            }
            else
            {
                mealNameHolder[currentLine].Text = _PassedMealName;
                proteinHolder[currentLine].Text = _PassedProtein;
                fatsHolder[currentLine].Text = _PassedFats;
                carbohydratesHolder[currentLine].Text = _PassedCarbohydrates;
                caloriesHolder[currentLine].Text = _PassedCalories;
            }


            // Get the protein sum
            for (int i = 0; i < proteinHolder.Count; i++)
            {
                sumOfProtein += float.Parse(proteinHolder[i].Text);
            }

            // Get the fat sum
            for (int i = 0; i < fatsHolder.Count; i++)
            {
                sumOfFat += float.Parse(fatsHolder[i].Text);
            }

            // Get the carbohydrates sum
            for (int i = 0; i < carbohydratesHolder.Count; i++)
            {
                sumOfCarbohydrates += float.Parse(carbohydratesHolder[i].Text);
            }

            // Get the calories sum
            for (int i = 0; i < caloriesHolder.Count; i++)
            {
                sumOfCalories += float.Parse(caloriesHolder[i].Text);
            }

            // Fill the displayed sums
            SumProtein.Text = sumOfProtein.ToString("0.0");
            SumFats.Text = sumOfFat.ToString("0.0");
            SumCarbohydrates.Text = sumOfCarbohydrates.ToString("0.0");
            SumCalories.Text = sumOfCalories.ToString("0.0");

            // Adding the meal database id to the specific meal name label tag
            mealNameHolderPublic[currentLine].Tag = _PassedDatabaseID;
        }

        private void DeleteMeal_Click(object sender, EventArgs e)
        {
            // Retrieve the current to be deleted line number 
            int linePosition = (((dynamic)sender).Tag);

            // Get each control name
            string addButtonName = chooseHolder[linePosition].Name;
            string mealNameLabelName = mealNameHolder[linePosition].Name;
            string proteinLabelName = proteinHolder[linePosition].Name;
            string fatsLabelName = fatsHolder[linePosition].Name;
            string carbohydratesLabelName = carbohydratesHolder[linePosition].Name;
            string caloriesLabelName = caloriesHolder[linePosition].Name;
            string deleteButtonName = deleteMealHolder[linePosition].Name;

            // Variables that will hold the sums of all meals/food
            float sumOfProtein = 0;
            float sumOfFat = 0;
            float sumOfCarbohydrates = 0;
            float sumOfCalories = 0;

            // Remove controls from the form
            this.Controls.RemoveByKey(addButtonName);
            this.Controls.RemoveByKey(mealNameLabelName);
            this.Controls.RemoveByKey(proteinLabelName);
            this.Controls.RemoveByKey(fatsLabelName);
            this.Controls.RemoveByKey(carbohydratesLabelName);
            this.Controls.RemoveByKey(caloriesLabelName);
            this.Controls.RemoveByKey(deleteButtonName);

            // Remove the controls from the lists
            chooseHolder.RemoveAt(linePosition);
            mealNameHolder.RemoveAt(linePosition);
            proteinHolder.RemoveAt(linePosition);
            fatsHolder.RemoveAt(linePosition);
            carbohydratesHolder.RemoveAt(linePosition);
            caloriesHolder.RemoveAt(linePosition);
            deleteMealHolder.RemoveAt(linePosition);

            // Update chooseHolder
            for (int i = 0; i < chooseHolder.Count; i++)
            {
                chooseHolder[i].Name = "Choose_" + i;
                chooseHolder[i].Tag = i;
                chooseHolder[i].Top = MealNameTitel.Top + ((chooseHolder[0].Height + 15) * (i + 1));
            }

            // Update mealNameHolder
            for (int i = 0; i < mealNameHolder.Count; i++)
            {
                mealNameHolder[i].Name = "MealName_" + i;
                //mealNameHolder[i].Tag = i;
                mealNameHolder[i].Top = MealNameTitel.Top + ((chooseHolder[0].Height + 15) * (i + 1));
            }

            // Update proteinHolder
            for (int i = 0; i < proteinHolder.Count; i++)
            {
                proteinHolder[i].Name = "Protein_" + i;
                //proteinHolder[i].Tag = i;
                proteinHolder[i].Top = MealNameTitel.Top + ((chooseHolder[0].Height + 15) * (i + 1));
                sumOfProtein += float.Parse(proteinHolder[i].Text);
            }

            // Update fatsHolder
            for (int i = 0; i < fatsHolder.Count; i++)
            {
                fatsHolder[i].Name = "Fats_" + i;
                //fatsHolder[i].Tag = i;
                fatsHolder[i].Top = MealNameTitel.Top + ((chooseHolder[0].Height + 15) * (i + 1));
                sumOfFat += float.Parse(fatsHolder[i].Text);
            }

            // Update carbohydratesHolder
            for (int i = 0; i < carbohydratesHolder.Count; i++)
            {
                carbohydratesHolder[i].Name = "Carbohydrates_" + i;
                //carbohydratesHolder[i].Tag = i;
                carbohydratesHolder[i].Top = MealNameTitel.Top + ((chooseHolder[0].Height + 15) * (i + 1));
                sumOfCarbohydrates += float.Parse(carbohydratesHolder[i].Text);
            }

            // Update caloriesHolder
            for (int i = 0; i < caloriesHolder.Count; i++)
            {
                caloriesHolder[i].Name = "Calories_" + i;
                //caloriesHolder[i].Tag = i;
                caloriesHolder[i].Top = MealNameTitel.Top + ((chooseHolder[0].Height + 15) * (i + 1));
                sumOfCalories += float.Parse(caloriesHolder[i].Text);
            }

            // Update deleteHolder
            for (int i = 0; i < deleteMealHolder.Count; i++)
            {
                deleteMealHolder[i].Name = "DeleteMeal_" + i;
                deleteMealHolder[i].Tag = i;
                deleteMealHolder[i].Top = MealNameTitel.Top + ((chooseHolder[0].Height + 15) * (i + 1));
            }

            lineCounter = chooseHolder.Count - 1;

            // Place the separator line
            SummaryLineSeparator.Top = this.Controls["Choose_" + lineCounter].Top + this.Controls["Choose_" + lineCounter].Height + 7;
            SummaryLineSeparator.Left = this.Controls["Choose_" + lineCounter].Left;
            SummaryLineSeparator.Width = (CaloriesTitel.Left + CaloriesTitel.Width) - MealNameTitel.Left;
            SummaryLineSeparator.Height = 1;

            // Positioning the summary line
            SummaryTitel.Top = this.Controls["Choose_" + lineCounter].Top + this.Controls["Choose_" + lineCounter].Height + 15;
            SummaryTitel.Left = MealNameTitel.Left; ;
            SumProtein.Top = SummaryTitel.Top;
            SumProtein.Left = ProteinTitel.Left;
            SumFats.Top = SummaryTitel.Top;
            SumFats.Left = FatsTitel.Left;
            SumCarbohydrates.Top = SummaryTitel.Top;
            SumCarbohydrates.Left = CarbohydratesTitel.Left;
            SumCalories.Top = SummaryTitel.Top;
            SumCalories.Left = CaloriesTitel.Left;

            // Fill in the sums
            SumProtein.Text = sumOfProtein.ToString("0.0");
            SumFats.Text = sumOfFat.ToString("0.0");
            SumCarbohydrates.Text = sumOfCarbohydrates.ToString("0.0");
            SumCalories.Text = sumOfCalories.ToString("0.0");

            // Enable database saving
            SaveDay.Enabled = true;
        }

        private void Choose_Click(object sender, EventArgs e)
        {
            // Asign the current line
            currentLine = ((dynamic)sender).Tag;

            // Create the form to choose the meal from
            chooseMealLayout = new ChooseMeal();
            chooseMealLayout.dayOverview_Layout = this;
            chooseMealLayout.Owner = this;
            chooseMealLayout.FormClosed += new FormClosedEventHandler(ChooseMeal_FormClosed);
            chooseMealLayout.Text = "Nahrungsmittel/Mahlzeit auswählen";
            chooseMealLayout.ShowDialog();
        }


        private void ChooseMeal_FormClosed(object sender, FormClosedEventArgs e)
        {
            chooseMealLayout = null;
        }

        private void SaveDay_Click(object sender, EventArgs e)
        {
            // Function to delete all entries of the current day and write the new data into the database
            UpdateDatabase();

            this.Close();
        }

        private void UpdateDatabase()
        {
            // Check and additionally load data from the database into the form
            MessageBox.Show(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows.Count.ToString());
            for (int i = 0; i < mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows.Count; i++)
            {
                DateTime bufferDate = new DateTime();
                bufferDate = DateTime.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][1].ToString());

                //MessageBox.Show(bufferDate.ToString("dd.MM.yyyy") + Environment.NewLine + (passedDay.ToString("00") + "." + passedMonth.ToString("00") + "." + passedYear.ToString("0000")));

                if (bufferDate.ToString("dd.MM.yyyy") == (passedDay.ToString("00") + "." + passedMonth.ToString("00") + "." + passedYear.ToString("0000")))
                {
                    //MessageBox.Show(int.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][0].ToString()) + " | " +
                    //                DateTime.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][1].ToString()) + " | " +
                    //                double.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][2].ToString()) + " | " +
                    //                mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][3].ToString() + " | " +
                    //                double.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][4].ToString()) + " | " +
                    //                double.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][5].ToString()) + " | " +
                    //                double.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][6].ToString()) + " | " +
                    //                double.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][7].ToString()) + Environment.NewLine + mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows.Count);

                    // Delete selected database entry
                    this.mealPerDayDatabaseTableAdapter.Delete(int.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][0].ToString()),
                                                                DateTime.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][1].ToString()),
                                                                double.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][2].ToString()),
                                                                mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][3].ToString(),
                                                                double.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][4].ToString()),
                                                                double.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][5].ToString()),
                                                                double.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][6].ToString()),
                                                                double.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][7].ToString()));
                }
            }

            for (int i = 0; i < mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows.Count; i++)
            {
                this.mealPerDayDatabaseTableAdapter.Update(i + 1,
                                                            DateTime.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][1].ToString()),
                                                            double.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][2].ToString()),
                                                            mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][3].ToString(),
                                                            double.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][4].ToString()),
                                                            double.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][5].ToString()),
                                                            double.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][6].ToString()),
                                                            double.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][7].ToString()),
                                    int.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][0].ToString()),
                                    DateTime.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][1].ToString()),
                                    double.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][2].ToString()),
                                    mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][3].ToString(),
                                    double.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][4].ToString()),
                                    double.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][5].ToString()),
                                    double.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][6].ToString()),
                                    double.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][7].ToString()));

                //MessageBox.Show(int.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][0].ToString()) + " | " +
                //                DateTime.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][1].ToString()) + " | " +
                //                double.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][2].ToString()) + " | " +
                //                mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][3].ToString() + " | " +
                //                double.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][4].ToString()) + " | " +
                //                double.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][5].ToString()) + " | " +
                //                double.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][6].ToString()) + " | " +
                //                double.Parse(mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][7].ToString()) + Environment.NewLine + mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows.Count);
            }

            databaseRowCount = mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows.Count;

            for (int i = 0; i < lineCounter; i++)
            {
                databaseRowCount++;

                this.mealPerDayDatabaseTableAdapter.Insert(databaseRowCount,
                    DateTime.Parse(CurrentDay.Text),
                    1,
                    mealNameHolder[i].Text,
                    double.Parse(proteinHolder[i].Text.ToString()),
                    double.Parse(fatsHolder[i].Text.ToString()),
                    double.Parse(carbohydratesHolder[i].Text.ToString()),
                    double.Parse(caloriesHolder[i].Text.ToString()));
            }

            // Reload database
            this.mealPerDayDatabaseTableAdapter.Fill(this.mealPerDayDatabaseDataSet.MealPerDayDatabase);

            mainMenuLayout.dayOverviewLayoutPublic.FillDatabaseAdapter();
            //MessageBox.Show("Gespeichert!");
        }

        private void DayOverview_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tableChanged)
            {
                DialogResult result = MessageBox.Show("Sie haben Änderungen vorgenommen, diese aber noch nicht gespeichert. Möchten Sie jetzt speichern?", "Änderungen speichern?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    // Function to update the database
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }
    }
}
