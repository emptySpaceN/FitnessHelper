using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FitnessHelper
{
    public partial class AddMeal : Form
    {
        private ChooseMeal chooseMealLayout;

        public ChooseMeal chooseMeal_Layout
        {
            get { return chooseMealLayout; }
            set { chooseMealLayout = value; }
        }

        private bool editMode;

        public bool editModePublic
        {
            get { return editMode; }
            set { editMode = value; }
        }

        public AddMeal()
        {
            InitializeComponent();
        }

        private void AddMealToDatabase_Click(object sender, EventArgs e)
        {
            MessageBox.Show(IsDigitsOnly(ProteinCount.Text).ToString());
            // Check if every textbox has a value
            if (MealName.Text == "" || ProteinCount.Text == "" || FatCount.Text == "" || CarbohydratesCount.Text == "" || CaloriesCount.Text == "")
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus.", "Mahlzeit hinzufügen", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else if (!IsDigitsOnly(ProteinCount.Text) || !IsDigitsOnly(FatCount.Text) || !IsDigitsOnly(CarbohydratesCount.Text) || !IsDigitsOnly(CaloriesCount.Text))
            {
                MessageBox.Show("Das Format der eingegebenen Zahlen stimmt nicht, bitte prüfen Sie die Zahlen nochmals.", "Mahlzeit hinzufügen", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                if (!editMode)
                {
                    // Add a new database entry
                    chooseMeal_Layout.UpdateDatabase(false, MealName.Text, double.Parse(ProteinCount.Text.ToString()), double.Parse(FatCount.Text.ToString()), double.Parse(CarbohydratesCount.Text.ToString()), double.Parse(CaloriesCount.Text.ToString()));
                }
                else if (editMode)
                {
                    // Edit the database entry
                    chooseMeal_Layout.UpdateDatabase(true, MealName.Text, double.Parse(ProteinCount.Text.ToString()), double.Parse(FatCount.Text.ToString()), double.Parse(CarbohydratesCount.Text.ToString()), double.Parse(CaloriesCount.Text.ToString()));
                }

                // Empty all textboxes for adding a new meal/food
                MealName.Text = "";
                ProteinCount.Text = "";
                FatCount.Text = "";
                CarbohydratesCount.Text = "";
                CaloriesCount.Text = "";
            }            
        }

        private bool IsDigitsOnly(string _PassedString)
        {
            // Check if the amount of comma is greater than one
            if ((_PassedString.Split(',').Length - 1) > 1)
            {
                return false;
            }

            // Evaluates if the the string only contains digits
            foreach (char c in _PassedString)
            {
                if (c != ',')
                {
                    if (c < '0' || c > '9')
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void AddMeal_Load(object sender, EventArgs e)
        {
            if (editMode)
            {
                MealName.Text = chooseMealLayout.FoodListingPublic.Rows[chooseMealLayout.FoodListingPublic.CurrentCell.RowIndex].Cells[1].Value.ToString();
                ProteinCount.Text = chooseMealLayout.FoodListingPublic.Rows[chooseMealLayout.FoodListingPublic.CurrentCell.RowIndex].Cells[2].Value.ToString();
                FatCount.Text = chooseMealLayout.FoodListingPublic.Rows[chooseMealLayout.FoodListingPublic.CurrentCell.RowIndex].Cells[3].Value.ToString();
                CarbohydratesCount.Text = chooseMealLayout.FoodListingPublic.Rows[chooseMealLayout.FoodListingPublic.CurrentCell.RowIndex].Cells[4].Value.ToString();
                CaloriesCount.Text = chooseMealLayout.FoodListingPublic.Rows[chooseMealLayout.FoodListingPublic.CurrentCell.RowIndex].Cells[5].Value.ToString();
            }
        }
    }
}

















//// Sql query
//string cmdString = "INSERT INTO FoodDatabase (ID, Bezeichnung, Eiweiß, Fett, Kohlenhydrate, Kalorien) VALUES (@val1, @val2, @val3, @val4, @val5, @val6)";
//string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\FoodDatabase.mdf;Integrated Security=True";
//using (SqlConnection conn = new SqlConnection(connString))
//{
//    using (SqlCommand comm = new SqlCommand())
//    {
//        // Fill the database
//        comm.Connection = conn;
//        comm.CommandText = cmdString;
//        comm.Parameters.AddWithValue("@val1", databaseID);
//        comm.Parameters.AddWithValue("@val2", MealName.Text);
//        comm.Parameters.AddWithValue("@val3", ProteinCount.Text);
//        comm.Parameters.AddWithValue("@val4", FatCount.Text);
//        comm.Parameters.AddWithValue("@val5", CarbohydratesCount.Text);
//        comm.Parameters.AddWithValue("@val6", CaloriesCount.Text);
//        try
//        {
//            conn.Open();
//            comm.ExecuteNonQuery();
//        }
//        catch (SqlException err)
//        {
//            MessageBox.Show(err.Message);
//        }
//    }
//}