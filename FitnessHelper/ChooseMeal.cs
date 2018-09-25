using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessHelper
{
    public partial class ChooseMeal : Form
    {
        // Form declarations
        private DayOverview dayOverviewLayout;
        private AddMeal addMealLayout;

        public DayOverview dayOverview_Layout
        {
            get { return dayOverviewLayout; }
            set { dayOverviewLayout = value; }
        }

        public DataGridView FoodListingPublic
        {
            get { return FoodListing; }
            set { FoodListing = value; }
        }

        private int lineCounter;
        private int currentLine;

        private bool editMode;

        private BindingSource FoodListingBindingSource;

        private List<string> filterContainer = new List<string>();

        public ChooseMeal()
        {
            InitializeComponent();

            // Events
            this.Load += new EventHandler(ChooseMeal_Load);
        }


        private void ChooseMeal_Load(object sender, EventArgs e)
        {
            FillDatabaseAdapter();

            FillDataGrid();

            for (int i = 0; i < FoodListing.Rows.Count; i++)
            {
                filterContainer.Add(FoodListing.Rows[i].Cells[1].Value.ToString());
            }

            lineCounter = dayOverview_Layout.lineCounterPublic;
            currentLine = dayOverview_Layout.currentLinePublic;
            editMode = CheckOpeningType();

            // Select the meal in the datagridview if you edit it
            if (editMode)
            {
                foreach (DataGridViewRow row in FoodListing.Rows)
                {
                    if ((row.Cells[0].Value.ToString() == dayOverviewLayout.mealNameHolderPublic[currentLine].Tag.ToString()) && (row.Cells[1].Value.ToString() == dayOverviewLayout.mealNameHolderPublic[currentLine].Text))
                    {
                        row.Selected = true;

                        break;
                    }
                }
            }
            else if (!editMode)
            {
                FoodListing.ClearSelection();
            }
        }

        public void FillDatabaseAdapter()
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "foodDatabaseDataSet.FoodDatabase". Sie können sie bei Bedarf verschieben oder entfernen.
            this.FoodDatabaseTableAdapter.Fill(this.FoodDatabaseDataSet.FoodDatabase);
        }

        private void FillDataGrid()
        {
            DataTable FoodListingDataTable = new DataTable();

            for (int i = 0; i < FoodDatabaseDataSet.FoodDatabase.Columns.Count; i++)
            {
                // TODO: Get the column titles
                FoodListingDataTable.Columns.Add("Spalte" + (i + 1));
            }

            for (int i = 0; i < FoodDatabaseDataSet.FoodDatabase.Rows.Count; i++)
            {
                DataRow dr = null;
                dr = FoodListingDataTable.NewRow();

                for (int j = 0; j < FoodDatabaseDataSet.FoodDatabase.Columns.Count; j++)
                {
                    dr[j] = FoodDatabaseDataSet.FoodDatabase.Rows[i][j].ToString();
                }

                FoodListingDataTable.Rows.Add(dr);
            }

            // Create a BindingSource the datatable to it
            FoodListingBindingSource = new BindingSource();
            FoodListingBindingSource.DataSource = FoodListingDataTable;

            // Asign the BindingSource to the DataGridView
            FoodListing.DataSource = FoodListingBindingSource;
        }

        public void UpdateDatabase(bool _PassedEditMode, string _PassedDescription, double _PassedProtein, double _PassedFat, double _PassedCarbohydrates, double _PassedCalories)
        {
            if (!_PassedEditMode)
            {
                this.FoodDatabaseTableAdapter.Insert(FoodListing.Rows.Count + 1, _PassedDescription, _PassedProtein, _PassedFat, _PassedCarbohydrates, _PassedCalories);
            }
            else if (_PassedEditMode)
            {
                this.FoodDatabaseTableAdapter.Update(_PassedDescription, _PassedProtein,
                    _PassedFat,
                    _PassedCarbohydrates,
                    _PassedCalories,
                    int.Parse(FoodListing.Rows[FoodListing.CurrentCell.RowIndex].Cells[0].Value.ToString()),
                    FoodListing.Rows[FoodListing.CurrentCell.RowIndex].Cells[1].Value.ToString(),
                    double.Parse(FoodListing.Rows[FoodListing.CurrentCell.RowIndex].Cells[2].Value.ToString()),
                    double.Parse(FoodListing.Rows[FoodListing.CurrentCell.RowIndex].Cells[3].Value.ToString()),
                    double.Parse(FoodListing.Rows[FoodListing.CurrentCell.RowIndex].Cells[4].Value.ToString()),
                    double.Parse(FoodListing.Rows[FoodListing.CurrentCell.RowIndex].Cells[5].Value.ToString()));
            }

            FillDatabaseAdapter();
            FillDataGrid();
        }

        private void ApplyMeal_Click(object sender, EventArgs e)
        {
            ApplyData();
        }

        private void ApplyData()
        {
            string gramsEaten = "100";

            if (InputBox("Portionsangabe", "Wie viel Gramm haben sie zu sich genommen?", ref gramsEaten) == DialogResult.OK)
            {
                if (!editMode)
                {
                    dayOverviewLayout.FillLineWithMeal(false,
                        FoodListing.Rows[FoodListing.CurrentCell.RowIndex].Cells[1].Value.ToString(),
                        ((float.Parse(FoodListing.Rows[FoodListing.CurrentCell.RowIndex].Cells[2].Value.ToString()) / 100) * int.Parse(gramsEaten)).ToString("0.0"),
                        ((float.Parse(FoodListing.Rows[FoodListing.CurrentCell.RowIndex].Cells[3].Value.ToString()) / 100) * int.Parse(gramsEaten)).ToString("0.0"),
                        ((float.Parse(FoodListing.Rows[FoodListing.CurrentCell.RowIndex].Cells[4].Value.ToString()) / 100) * int.Parse(gramsEaten)).ToString("0.0"),
                        ((float.Parse(FoodListing.Rows[FoodListing.CurrentCell.RowIndex].Cells[5].Value.ToString()) / 100) * int.Parse(gramsEaten)).ToString("0.0"),
                        FoodListing.Rows[FoodListing.CurrentCell.RowIndex].Cells[0].Value.ToString());
                }
                else
                {
                    dayOverviewLayout.FillLineWithMeal(true,
                        FoodListing.Rows[FoodListing.CurrentCell.RowIndex].Cells[1].Value.ToString(),
                        ((float.Parse(FoodListing.Rows[FoodListing.CurrentCell.RowIndex].Cells[2].Value.ToString()) / 100) * int.Parse(gramsEaten)).ToString("0.0"),
                        ((float.Parse(FoodListing.Rows[FoodListing.CurrentCell.RowIndex].Cells[3].Value.ToString()) / 100) * int.Parse(gramsEaten)).ToString("0.0"),
                        ((float.Parse(FoodListing.Rows[FoodListing.CurrentCell.RowIndex].Cells[4].Value.ToString()) / 100) * int.Parse(gramsEaten)).ToString("0.0"),
                        ((float.Parse(FoodListing.Rows[FoodListing.CurrentCell.RowIndex].Cells[5].Value.ToString()) / 100) * int.Parse(gramsEaten)).ToString("0.0"),
                        FoodListing.Rows[FoodListing.CurrentCell.RowIndex].Cells[0].Value.ToString());
                }
            }
            else
            {
                return;
            }

            dayOverviewLayout.SaveDayPublic.Enabled = true;

            this.Close();
        }

        private DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value.ToString();

            buttonOk.Text = "Übernehmen";
            buttonCancel.Text = "Abbrechen";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        private bool CheckOpeningType()
        {
            try
            {
                string checkBuffer = dayOverview_Layout.mealNameHolderPublic[currentLine].Name.ToString();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        private void FoodListing_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ApplyData();
        }

        private void FilterBox_TextChanged(object sender, EventArgs e)
        {
            List<string> bufferFilterContainer = new List<string>(filterContainer);

            string columnFilterSyntax = "[" + FoodListing.Columns[1].Name + "] IN (";

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
                    columnFilterSyntax = "[" + FoodListing.Columns[1].Name + "] IN ('')";
                }
            }

            FoodListingBindingSource.Filter = columnFilterSyntax;
        }

        private void NewMeal_Click(object sender, EventArgs e)
        {
            // Create the form to add a new meal
            addMealLayout = new AddMeal();
            addMealLayout.chooseMeal_Layout = this;
            addMealLayout.editModePublic = false;
            addMealLayout.Owner = this;
            addMealLayout.FormClosed += new FormClosedEventHandler(AddMeal_FormClosed);
            addMealLayout.Text = "Nahrungsmittel/Mahlzeit hinzufügen";
            addMealLayout.ShowDialog();
        }


        private void AddMeal_FormClosed(object sender, FormClosedEventArgs e)
        {
            addMealLayout = null;
        }

        private void DeleteMeal_Click(object sender, EventArgs e)
        {
            // Delete selected database entry
            this.FoodDatabaseTableAdapter.Delete(int.Parse(FoodListing.Rows[FoodListing.CurrentCell.RowIndex].Cells[0].Value.ToString()), FoodListing.Rows[FoodListing.CurrentCell.RowIndex].Cells[1].Value.ToString(), double.Parse(FoodListing.Rows[FoodListing.CurrentCell.RowIndex].Cells[2].Value.ToString()), double.Parse(FoodListing.Rows[FoodListing.CurrentCell.RowIndex].Cells[3].Value.ToString()), double.Parse(FoodListing.Rows[FoodListing.CurrentCell.RowIndex].Cells[4].Value.ToString()), double.Parse(FoodListing.Rows[FoodListing.CurrentCell.RowIndex].Cells[5].Value.ToString()));

            // Reload database
            this.FoodDatabaseTableAdapter.Fill(this.FoodDatabaseDataSet.FoodDatabase);
        }

        private void EditMeal_Click(object sender, EventArgs e)
        {
            // Create the form to edit an existing meal 
            addMealLayout = new AddMeal();
            addMealLayout.chooseMeal_Layout = this;
            addMealLayout.editModePublic = true;
            addMealLayout.Owner = this;
            addMealLayout.FormClosed += new FormClosedEventHandler(AddMeal_FormClosed);
            addMealLayout.Text = "Nahrungsmittel/Mahlzeit bearbeiten";
            addMealLayout.ShowDialog();
        }

        private void FilterBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = true;
                FilterBox.Text = "";
            }
        }
    }


    // New extension method for string
    public static class StringExtensions
    {
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source.IndexOf(toCheck, comp) >= 0;
        }
    }
}
