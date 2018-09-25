using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FitnessHelper
{
    public partial class AdministrateDatabase : Form
    {
        // Class declaration
        private MainMenu mainMenu;
        private DayOverview dayOverview;
        private ChooseMeal chooseMeal;

        public MainMenu MainMenuPublic
        {
            get { return mainMenu; }
            set { mainMenu = value; }
        }

        public enum AdministrationType
        {
            food,
            day
        }

        public AdministrationType DatabaseType = AdministrationType.day;

        private BindingSource FoodListingBindingSource;

        private List<string> filterContainer = new List<string>();

        public AdministrateDatabase()
        {
            InitializeComponent();

            // Events
            this.Load += new EventHandler(AdministrateDatabase_Load);
            this.FormClosing += new FormClosingEventHandler(AdministrateDatabase_FormClosing);
        }

        private void AdministrateDatabase_Load(object sender, EventArgs e)
        {
            FillDataGrid();

            // Add all available values to the filter holder (of column 2)
            for (int i = 0; i < DatabaseGrid.Rows.Count; i++)
            {
                filterContainer.Add(DatabaseGrid.Rows[i].Cells[1].Value.ToString());
            }
        }

        private void FillDataGrid()
        {
            // Buffer datatable that is filled with the data and given to the binding source at the end
            DataTable FoodListingDataTable = new DataTable();

            switch (DatabaseType)
            {
                case AdministrationType.food:
                    {
                        chooseMeal = new ChooseMeal();
                        chooseMeal.FillDatabaseAdapter();

                        for (int i = 0; i < chooseMeal.FoodDatabaseDataSet.FoodDatabase.Columns.Count; i++)
                        {
                            // TODO: Get the column titles
                            FoodListingDataTable.Columns.Add("Spalte" + (i + 1));
                        }

                        for (int i = 0; i < chooseMeal.FoodDatabaseDataSet.FoodDatabase.Rows.Count; i++)
                        {
                            DataRow dr = null;
                            dr = FoodListingDataTable.NewRow();

                            for (int j = 0; j < chooseMeal.FoodDatabaseDataSet.FoodDatabase.Columns.Count; j++)
                            {
                                //DatabaseGrid.Rows[i].Cells[j].Value = chooseMeal.FoodDatabaseDataSet.FoodDatabase.Rows[i][j].ToString();
                                dr[j] = chooseMeal.FoodDatabaseDataSet.FoodDatabase.Rows[i][j].ToString();
                            }

                            FoodListingDataTable.Rows.Add(dr);
                        }
                    }
                    break;
                case AdministrationType.day:
                    {
                        dayOverview = new DayOverview();
                        dayOverview.FillDatabaseAdapter();

                        for (int i = 0; i < dayOverview.mealPerDayDatabaseDataSet.MealPerDayDatabase.Columns.Count; i++)
                        {
                            // TODO: Get the column titles
                            FoodListingDataTable.Columns.Add("Spalte" + (i + 1));
                        }

                        for (int i = 0; i < dayOverview.mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows.Count; i++)
                        {
                            DataRow dr = null;
                            dr = FoodListingDataTable.NewRow();

                            for (int j = 0; j < dayOverview.mealPerDayDatabaseDataSet.MealPerDayDatabase.Columns.Count; j++)
                            {
                                //DatabaseGrid.Rows[i].Cells[j].Value = chooseMeal.FoodDatabaseDataSet.FoodDatabase.Rows[i][j].ToString();
                                dr[j] = dayOverview.mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][j].ToString();
                            }

                            FoodListingDataTable.Rows.Add(dr);
                        }
                    }
                    break;
                default:
                    break;
            }

            // Create a BindingSource the datatable to it
            FoodListingBindingSource = new BindingSource();
            FoodListingBindingSource.DataSource = FoodListingDataTable;

            // Asign the BindingSource to the DataGridView
            DatabaseGrid.DataSource = FoodListingBindingSource;

        }

        private void AdministrateDatabase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dayOverview != null) { dayOverview = null; }
            if (chooseMeal != null) { chooseMeal = null; }
        }

        private void DeleteDatabase_CheckedChanged(object sender, EventArgs e)
        {
            if (DeleteDatabase.CheckState == CheckState.Checked)
            {
                if (MessageBox.Show("Sie sind im Begriff alle Daten aus der Datenbank zu löschen, möchten Sie fortfahren?", "Datenbank löschen", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.OK)
                {
                    DeleteDatabase.CheckState = CheckState.Unchecked;
                }
            }
        }

        private void ExportDatabase_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog exportToCSV = new SaveFileDialog())
            {
                exportToCSV.Filter = "CSV (Trennzeichen getrennt) (*.csv)|*.csv";
                exportToCSV.FileName = "Database";

                try
                {
                    if (exportToCSV.ShowDialog() == DialogResult.OK)
                    {
                        switch (exportToCSV.FilterIndex)
                        {
                            case 1: // Export to .csv
                                StringBuilder csv = new StringBuilder();

                                string newLine;

                                for (int i = 0; i < DatabaseGrid.Rows.Count; i++)
                                {
                                    newLine = "";

                                    if (i == 0)
                                    {
                                        for (int j = 0; j < DatabaseGrid.Columns.Count; j++)
                                        {
                                            if (j < (DatabaseGrid.Columns.Count - 1))
                                            {
                                                newLine += DatabaseGrid.Columns[j].HeaderText + ";";
                                            }
                                            else if (j == (DatabaseGrid.Columns.Count - 1))
                                            {
                                                newLine += DatabaseGrid.Columns[j].HeaderText;
                                            }
                                        }
                                        csv.AppendLine(newLine);
                                        newLine = "";
                                    }

                                    for (int k = 0; k < DatabaseGrid.Columns.Count; k++)
                                    {
                                        if (k < (DatabaseGrid.Columns.Count - 1))
                                        {
                                            newLine += (DatabaseGrid.Rows[i].Cells[k].Value == null ? "" : DatabaseGrid.Rows[i].Cells[k].Value.ToString()) + ";";
                                        }
                                        else if (k == (DatabaseGrid.Columns.Count - 1))
                                        {
                                            newLine += (DatabaseGrid.Rows[i].Cells[k].Value == null ? "" : DatabaseGrid.Rows[i].Cells[k].Value.ToString());
                                        }
                                    }
                                    csv.AppendLine(newLine);
                                }

                                File.WriteAllText(exportToCSV.FileName, csv.ToString());
                                break;
                            default:
                                return;
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Beim exportieren der Liste ist ein Fehler aufgetreten. Die Fehlermeldung lautet wie folgt:\n\n" + err.Message, "Liste exportieren", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ImportData_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog importDatabaseData = new OpenFileDialog())
            {
                importDatabaseData.Multiselect = false;
                importDatabaseData.Filter = "CSV (Trennzeichen getrennt) (*.csv)|*.csv";
                importDatabaseData.FileName = "Database";

                try
                {
                    if (importDatabaseData.ShowDialog() == DialogResult.OK)
                    {
                        switch (importDatabaseData.FilterIndex)
                        {
                            case 1: // Export to .csv
                                {
                                    TextFieldParser csvParser = new TextFieldParser(importDatabaseData.FileName, System.Text.Encoding.Default);

                                    if (DeleteDatabase.Checked)
                                    {
                                        int currentColumnCount = (DatabaseType == AdministrationType.food ? 6 : 8);
                                        int currentLine;
                                        int columnLengthSum = 0;

                                        List<int> columnLengthContainer = new List<int>();

                                        //csvParser.CommentTokens = new string[] { "#" };
                                        csvParser.TextFieldType = FieldType.Delimited;
                                        csvParser.SetDelimiters(new string[] { ";" });
                                        csvParser.HasFieldsEnclosedInQuotes = true;

                                        while (!csvParser.EndOfData)
                                        {
                                            // Read current line fields, pointer moves to the next line.
                                            string[] completeRow = csvParser.ReadFields();
                                            columnLengthContainer.Add(completeRow.Length);
                                            columnLengthSum += completeRow.Length;
                                        }

                                        //
                                        csvParser.Dispose();
                                        csvParser = null;

                                        csvParser = new TextFieldParser(importDatabaseData.FileName, System.Text.Encoding.Default);
                                        csvParser.TextFieldType = FieldType.Delimited;
                                        csvParser.SetDelimiters(new string[] { ";" });
                                        csvParser.HasFieldsEnclosedInQuotes = true;

                                        // Evaluate if the selected file has the needed amount of columns
                                        if (((columnLengthSum / columnLengthContainer.Count) == columnLengthContainer[0]) && (columnLengthContainer[0] == currentColumnCount))
                                        {
                                            switch (DatabaseType)
                                            {
                                                case AdministrationType.food:
                                                    {
                                                        for (int i = 0; i < chooseMeal.FoodDatabaseDataSet.FoodDatabase.Rows.Count; i++)
                                                        {
                                                            chooseMeal.FoodDatabaseTableAdapter.Delete(
                                                                int.Parse(chooseMeal.FoodDatabaseDataSet.FoodDatabase.Rows[i][0].ToString()),
                                                                chooseMeal.FoodDatabaseDataSet.FoodDatabase.Rows[i][1].ToString(),
                                                                double.Parse(chooseMeal.FoodDatabaseDataSet.FoodDatabase.Rows[i][2].ToString()),
                                                                double.Parse(chooseMeal.FoodDatabaseDataSet.FoodDatabase.Rows[i][3].ToString()),
                                                                double.Parse(chooseMeal.FoodDatabaseDataSet.FoodDatabase.Rows[i][4].ToString()),
                                                                double.Parse(chooseMeal.FoodDatabaseDataSet.FoodDatabase.Rows[i][5].ToString()));
                                                        }
                                                    }
                                                    break;
                                                case AdministrationType.day:
                                                    {
                                                        for (int i = 0; i < dayOverview.mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows.Count; i++)
                                                        {
                                                            dayOverview.mealPerDayDatabaseTableAdapter.Delete(
                                                                int.Parse(dayOverview.mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][0].ToString()),
                                                                DateTime.Parse(dayOverview.mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][1].ToString()),
                                                                double.Parse(dayOverview.mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][2].ToString()),
                                                                dayOverview.mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][3].ToString(),
                                                                double.Parse(dayOverview.mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][4].ToString()),
                                                                double.Parse(dayOverview.mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][5].ToString()),
                                                                double.Parse(dayOverview.mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][6].ToString()),
                                                                double.Parse(dayOverview.mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][7].ToString()));

                                                            MainMenuPublic.dayOverviewLayoutPublic.FillDatabaseAdapter();
                                                        }
                                                    }
                                                    break;
                                                default:
                                                    break;
                                            }

                                            // Completely clear the DataGridView for the new filling
                                            DatabaseGrid.Rows.Clear();
                                            DatabaseGrid.Columns.Clear();

                                            // Skip the row with the column names
                                            if (ContainsColumnTitles.Checked)
                                            {
                                                string[] fields = csvParser.ReadFields();

                                                columnLengthContainer.Add(fields.Length);

                                                columnLengthSum += fields.Length;

                                                DatabaseGrid.ColumnCount = fields.Length;

                                                for (int i = 0; i < fields.Length; i++)
                                                {
                                                    DatabaseGrid.Columns[i].Name = fields[i].ToString();
                                                    DatabaseGrid.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;
                                                }

                                                currentLine = 0;
                                            }
                                            else
                                            {
                                                string[] fields = csvParser.ReadFields();

                                                DatabaseGrid.ColumnCount = fields.Length;

                                                for (int i = 0; i < fields.Length; i++)
                                                {
                                                    DatabaseGrid.Columns[i].Name = "Spalte " + (i + 1);
                                                    DatabaseGrid.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;

                                                    int n;

                                                    if (int.TryParse(fields[0], out n))
                                                    {
                                                        DatabaseGrid.Rows.Add();
                                                        DatabaseGrid.Rows[0].Cells[i].Value = fields[i].ToString();
                                                    }
                                                }

                                                currentLine = 0;
                                            }

                                            while (!csvParser.EndOfData)
                                            {
                                                if (ContainsColumnTitles.Checked && currentLine == 0)
                                                {
                                                    currentLine++;
                                                    continue;
                                                }

                                                // Read current line fields, pointer moves to the next line.
                                                string[] fields = csvParser.ReadFields();
                                                int n;

                                                if (!int.TryParse(fields[0], out n))
                                                {
                                                    continue;
                                                }
                                                
                                                switch (DatabaseType)
                                                {
                                                    case AdministrationType.food:
                                                        {
                                                            chooseMeal.FoodDatabaseTableAdapter.Insert(
                                                                int.Parse(fields[0]),
                                                                fields[1],
                                                                double.Parse(fields[2]),
                                                                double.Parse(fields[3]),
                                                                double.Parse(fields[4]),
                                                                double.Parse(fields[5]));
                                                        }
                                                        break;
                                                    case AdministrationType.day:
                                                        {
                                                            dayOverview.mealPerDayDatabaseTableAdapter.Insert(
                                                                int.Parse(fields[0]),
                                                                DateTime.Parse(fields[1]),
                                                                double.Parse(fields[2]),
                                                                fields[3],
                                                                double.Parse(fields[4]),
                                                                double.Parse(fields[5]),
                                                                double.Parse(fields[6]),
                                                                double.Parse(fields[7]));
                                                        }
                                                        break;
                                                    default:
                                                        break;
                                                }

                                                DatabaseGrid.Rows.Add();

                                                for (int j = 0; j < fields.Length; j++)
                                                {
                                                    if (ContainsColumnTitles.Checked)
                                                    {
                                                        DatabaseGrid.Rows[DatabaseGrid.Rows.Count - 1].Cells[j].Value = fields[j].ToString();
                                                    }
                                                    else
                                                    {
                                                        DatabaseGrid.Rows[DatabaseGrid.Rows.Count - 1].Cells[j].Value = fields[j].ToString();
                                                    }
                                                }

                                                currentLine++;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Die Datei enthält eine unterschiedliche Anzahl von Spalten, der Vorgang wird nun abgebrochen.", "Fehler beim importieren", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                        }


                                    }
                                    else
                                    {
                                        MessageBox.Show("No deletion!");
                                    }

                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Beim exportieren der Liste ist ein Fehler aufgetreten. Die Fehlermeldung lautet wie folgt:\n\n" + err.Message, "Liste exportieren", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FilterBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = true;
                FilterBox.Text = "";
            }
        }

        private void FilterBox_TextChanged(object sender, EventArgs e)
        {
            List<string> bufferFilterContainer = new List<string>(filterContainer);

            string columnFilterSyntax = "[" + DatabaseGrid.Columns[1].Name + "] IN (";

            repeatCheck:
            for (int j = 0; j < bufferFilterContainer.Count; j++)
            {
                string bufferString = bufferFilterContainer[j].ToString();

                if (!bufferString.Contains(FilterBox.Text, StringComparison.OrdinalIgnoreCase))
                {
                    bufferFilterContainer.RemoveAt(j);
                    goto repeatCheck;
                }
            }

            for (int k = 0; k < bufferFilterContainer.Count; k++)
            {
                if (k < (bufferFilterContainer.Count - 1))
                {
                    columnFilterSyntax += "'" + bufferFilterContainer[k].ToString() + "', ";
                }
                else
                {
                    columnFilterSyntax += "'" + bufferFilterContainer[k].ToString() + "')";
                }
            }

            if (bufferFilterContainer.Count == 0)
            {
                if (FilterBox.Text == "")
                {
                    columnFilterSyntax = "";
                }
                else
                {
                    columnFilterSyntax = "[" + DatabaseGrid.Columns[1].Name + "] IN ('')";
                }
            }

            FoodListingBindingSource.Filter = columnFilterSyntax;
        }
    }
}