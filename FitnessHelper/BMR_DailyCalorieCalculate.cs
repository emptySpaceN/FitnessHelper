using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessHelper
{
    public partial class BMR_DailyCalorieCalculate : Form
    {
        // Activity variables
        float hoursActivityOne = 0;
        float hoursActivityTwo = 0;
        float hoursActivityThree = 0;
        float hoursActivityFour = 0;
        float hoursActivityFive = 0;
        float hoursActivitySum = 0;

        public BMR_DailyCalorieCalculate()
        {
            InitializeComponent();

            // Events
            this.Load += new EventHandler(BMR_DailyCalorieCalculate_Load);
        }

        private void BMR_DailyCalorieCalculate_Load(object sender, EventArgs e)
        {
            GenderContainer.Items.Add("Männlich");
            GenderContainer.Items.Add("Weiblich");

            for (int i = 1; i <= 150; i++)
            {
                AgeContainer.Items.Add(i);
            }
        }

        private void CalculateAndDisplay_Click(object sender, EventArgs e)
        {
            if (GenderContainer.Text == "Männlich")
            {
                if (hoursActivitySum == 24)
                {
                    CultureInfo de = new CultureInfo("de-DE", true);

                    float faktor = ((hoursActivityOne * (float)1.2) + (hoursActivityTwo * (float)1.375) + (hoursActivityThree * (float)1.55) + (hoursActivityFour * (float)1.725) + (hoursActivityFive * (float)1.9)) / 24;

                    BMR_Result.Text = ((10 * float.Parse(WeightContainer.Text)) + (6.25 * float.Parse(HeightContainer.Text)) - ((5 * float.Parse(AgeContainer.Text)) + 5)).ToString("0.00", de);

                    DailyCalorieNeed_Result.Text = (((10 * float.Parse(WeightContainer.Text)) + (6.25 * float.Parse(HeightContainer.Text)) - ((5 * float.Parse(AgeContainer.Text)) + 5)) * faktor).ToString("0.00", de);
                }
                else
                {
                    MessageBox.Show("Die Summe der Stunden ergibt keinen ganzen Tag. Vergeben Sie die Stunden so, dass es in der Summe 24 sind.", "StundenSumme", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                if (hoursActivitySum == 24)
                {
                    float faktor = ((hoursActivityOne * (float)1.2) + (hoursActivityTwo * (float)1.375) + (hoursActivityThree * (float)1.55) + (hoursActivityFour * (float)1.725) + (hoursActivityFive * (float)1.9)) / 24;

                    BMR_Result.Text = ((10 * float.Parse(WeightContainer.Text)) + (6.25 * float.Parse(HeightContainer.Text)) - ((5 * float.Parse(AgeContainer.Text)) + 161)).ToString("0,00");

                    DailyCalorieNeed_Result.Text = (((10 * float.Parse(WeightContainer.Text)) + (6.25 * float.Parse(HeightContainer.Text)) - ((5 * float.Parse(AgeContainer.Text)) + 161)) * faktor).ToString("0,00");
                }
                else
                {
                    MessageBox.Show("Die Summe der Stunden ergibt keinen ganzen Tag. Vergeben Sie die Stunden so, dass es in der Summe 24 sind.", "StundenSumme", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void ActivityOneHours_TextChanged(object sender, EventArgs e)
        {
            CalculateHoursSum(((dynamic)sender), hoursActivityOne);
        }

        private void ActivityTwoHours_TextChanged(object sender, EventArgs e)
        {
            CalculateHoursSum(((dynamic)sender), hoursActivityTwo);
        }

        private void ActivityThreeHours_TextChanged(object sender, EventArgs e)
        {
            CalculateHoursSum(((dynamic)sender), hoursActivityThree);
        }

        private void ActivityFourHours_TextChanged(object sender, EventArgs e)
        {
            CalculateHoursSum(((dynamic)sender), hoursActivityFour);
        }

        private void ActivityFiveHours_TextChanged(object sender, EventArgs e)
        {
            CalculateHoursSum(((dynamic)sender), hoursActivityFive);
        }

        private void CalculateHoursSum(Control _PassedActivityHoursContainer, float _PassedBufferHour)
        {
            hoursActivityOne = 0;
            hoursActivityTwo = 0;
            hoursActivityThree = 0;
            hoursActivityFour = 0;
            hoursActivityFive = 0;
            hoursActivitySum = 0;

            float.TryParse(ActivityOneHours.Text, out hoursActivityOne);
            float.TryParse(ActivityTwoHours.Text, out hoursActivityTwo);
            float.TryParse(ActivityThreeHours.Text, out hoursActivityThree);
            float.TryParse(ActivityFourHours.Text, out hoursActivityFour);
            float.TryParse(ActivityFiveHours.Text, out hoursActivityFive);

            hoursActivitySum = hoursActivityOne + hoursActivityTwo + hoursActivityThree + hoursActivityFour + hoursActivityFive;

            if (hoursActivitySum > 24)
            {
                MessageBox.Show("Die Summe der Stunden überschreitet 24 Stunden. Geben Sie eine Zahl ein, die in der Summe mit den anderen Werten 24 ergibt.", "Stundeneingabe", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                _PassedActivityHoursContainer.Text = _PassedBufferHour.ToString();
            }
            else
            {
                HoursSum.Text = "Summe: " + hoursActivitySum.ToString();
            }
        }
    }
}
