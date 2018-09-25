using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;


namespace FitnessHelper
{
    public partial class MainMenu : Form
    {
        // Class declaration
        private DayOverview dayOverviewLayout;
        private BMR_DailyCalorieCalculate bmr_DailyCalorieCalculate;
        private OptionsMenu optionsMenu;
        private FileHandling_Ini fileHandling_Ini;

        public DayOverview dayOverviewLayoutPublic
        {
            get { return dayOverviewLayout; }
            set { dayOverviewLayout = value; }
        }


        private List<DaySurface> daySurface;
        private Label[] weekDays = new Label[7];

        // ======== Access to local controls - start ========
        public Label ProteinSumYesterdayPublic
        {
            get { return ProteinSumYesterday; }
            set { ProteinSumYesterday = value; }
        }

        public Label FatsSumYesterdayPublic
        {
            get { return FatsSumYesterday; }
            set { FatsSumYesterday = value; }
        }

        public Label CarbohydratesSumYesterdayPublic
        {
            get { return CarbohydratesSumYesterday; }
            set { CarbohydratesSumYesterday = value; }
        }

        public Label CaloriesSumYesterdayPublic
        {
            get { return CaloriesSumYesterday; }
            set { CaloriesSumYesterday = value; }
        }

        public Label ProteinSumSelectedPublic
        {
            get { return ProteinSumSelected; }
            set { ProteinSumSelected = value; }
        }

        public Label FatsSumSelectedPublic
        {
            get { return FatsSumSelected; }
            set { FatsSumSelected = value; }
        }

        public Label CarbohydratesSumSelectedPublic
        {
            get { return CarbohydratesSumSelected; }
            set { CarbohydratesSumSelected = value; }
        }

        public Label CaloriesSumSelectedPublic
        {
            get { return CaloriesSumSelected; }
            set { CaloriesSumSelected = value; }
        }
        // ======== Access to local controls - end ========


        private int yearHolder = DateTime.Today.Year;
        private int monthHolder = DateTime.Today.Month;
        private int currentDayIndex;                        // Contains the index number of the current day, that is included in the daySurface list - for easy access (e.g. to mark or select the current day

        private int lastSelectedDayIndex;
        public int lastSelectedDayIndexPublic
        {
            get { return lastSelectedDayIndex; }
            set { lastSelectedDayIndex = value; }
        }

        public enum language
        {
            english,
            spanish,
            german
        }

        public language currentLanguage = language.english;

        public MainMenu()
        {
            InitializeComponent();

            // Events
            this.Load += new EventHandler(MainMenu_Load);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Set all text regarding the current culture info
            SetLocalisation();

            dayOverviewLayout = new DayOverview();
            dayOverviewLayout.FillDatabaseAdapter();

            CreateCalendarDays();

            // Visual appearance
            TopBar.Left = 0;
            TopBar.Top = 0;
            TopBar.Width = this.ClientSize.Width;
            TopBar.Height = 40;

            MiddleBar.Left = 0;
            MiddleBar.Top = TopBar.Top + TopBar.Height;
            MiddleBar.Width = this.ClientSize.Width;
            MiddleBar.Height = 40;

            DayHolder.Width = (50 * 7) + 34;
            DayHolder.Height = (50 * 6) + 52;

            // ======== Controls for yesterday nutrition - start ========
            NutritionYesterdayTitle.Left = DayHolder.Right + 50;
            NutritionYesterdayTitle.Top = DayHolder.Top;

            ProteinYesterdayTitel.Left = NutritionYesterdayTitle.Left;
            ProteinYesterdayTitel.Top = NutritionYesterdayTitle.Bottom + 10;

            FatsYesterdayTitel.Left = ProteinYesterdayTitel.Right + 50;
            FatsYesterdayTitel.Top = NutritionYesterdayTitle.Bottom + 10;

            CarbohydratesYesterdayTitel.Left = FatsYesterdayTitel.Right + 50;
            CarbohydratesYesterdayTitel.Top = NutritionYesterdayTitle.Bottom + 10;

            CaloriesYesterdayTitel.Left = CarbohydratesYesterdayTitel.Right + 50;
            CaloriesYesterdayTitel.Top = NutritionYesterdayTitle.Bottom + 10;

            ProteinSumYesterday.Left = ProteinYesterdayTitel.Left;
            ProteinSumYesterday.Top = ProteinYesterdayTitel.Bottom + 5;

            FatsSumYesterday.Left = FatsYesterdayTitel.Left;
            FatsSumYesterday.Top = ProteinYesterdayTitel.Bottom + 5;

            CarbohydratesSumYesterday.Left = CarbohydratesYesterdayTitel.Left;
            CarbohydratesSumYesterday.Top = ProteinYesterdayTitel.Bottom + 5;

            CaloriesSumYesterday.Left = CaloriesYesterdayTitel.Left;
            CaloriesSumYesterday.Top = ProteinYesterdayTitel.Bottom + 5;
            // ======== Controls for yesterday nutrition - end ========

            // ======== Controls for selected nuitrition - start ========
            NutritionSelectedTitle.Left = NutritionYesterdayTitle.Left;
            NutritionSelectedTitle.Top = DayHolder.Top + (DayHolder.Height / 2);

            ProteinSelectedTitel.Left = NutritionSelectedTitle.Left;
            ProteinSelectedTitel.Top = NutritionSelectedTitle.Bottom + 10;

            FatsSelectedTitel.Left = ProteinSelectedTitel.Right + 50;
            FatsSelectedTitel.Top = NutritionSelectedTitle.Bottom + 10;

            CarbohydratesSelectedTitel.Left = FatsSelectedTitel.Right + 50;
            CarbohydratesSelectedTitel.Top = NutritionSelectedTitle.Bottom + 10;

            CaloriesSelectedTitel.Left = CarbohydratesSelectedTitel.Right + 50;
            CaloriesSelectedTitel.Top = NutritionSelectedTitle.Bottom + 10;



            ProteinSumSelected.Left = ProteinSelectedTitel.Left;
            ProteinSumSelected.Top = ProteinSelectedTitel.Bottom + 5;

            FatsSumSelected.Left = FatsSelectedTitel.Left;
            FatsSumSelected.Top = ProteinSelectedTitel.Bottom + 5;

            CarbohydratesSumSelected.Left = CarbohydratesSelectedTitel.Left;
            CarbohydratesSumSelected.Top = ProteinSelectedTitel.Bottom + 5;

            CaloriesSumSelected.Left = CaloriesSelectedTitel.Left;
            CaloriesSumSelected.Top = ProteinSelectedTitel.Bottom + 5;
            // ======== Controls for selected nuitrition - end ========
        }


        public void SetLocalisation()
        {
            // Initialize the configuration file
            InitializeSettingsFile();

            switch (currentLanguage)
            {
                case language.english:
                {
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
                }
                break;
                case language.spanish:
                {
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("es-ES");
                }
                break;
                case language.german:
                {
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("de-DE");
                }
                break;
                default:
                    break;
            }

            this.Text = Localization.strings.MainMenuTitle;

            CurrentYear.Text = yearHolder.ToString();
            CurrentMonth.Text = DateTime.Now.ToString("MMMM yyyy");
            CurrentDay.Text = DateTime.Now.ToString("dd");

            WeekTabName.Text = Localization.strings.MainMenu_Label_Week;
            MonthTabName.Text = Localization.strings.MainMenu_Label_Month;

            NutritionYesterdayTitle.Text = Localization.strings.MainMenu_Label_Yesterday;
            ProteinYesterdayTitel.Text = Localization.strings.MainMenu_Label_Protein_Title;
            FatsYesterdayTitel.Text = Localization.strings.MainMenu_Label_Fats_Title;
            CarbohydratesYesterdayTitel.Text = Localization.strings.MainMenu_Label_Carbohydrates_Title;
            CaloriesYesterdayTitel.Text = Localization.strings.MainMenu_Label_Calories_Title;

            NutritionSelectedTitle.Text = Localization.strings.MainMenu_Label_SelectedDay;
            ProteinSelectedTitel.Text = Localization.strings.MainMenu_Label_Protein_Title;
            FatsSelectedTitel.Text = Localization.strings.MainMenu_Label_Fats_Title;
            CarbohydratesSelectedTitel.Text = Localization.strings.MainMenu_Label_Carbohydrates_Title;
            CaloriesSelectedTitel.Text = Localization.strings.MainMenu_Label_Calories_Title;
        }


        private void InitializeSettingsFile()
        {
            if (File.Exists("config/Settings.ini"))
            {
                fileHandling_Ini = new FileHandling_Ini("config/Settings.ini");

                switch (fileHandling_Ini.IniReadValue("Application Settings", "Language"))
                {
                    case "English":
                    {
                        currentLanguage = language.english;
                    }
                    break;
                    case "Spanish":
                    {
                        currentLanguage = language.spanish;
                    }
                    break;
                    case "German":
                    {
                        currentLanguage = language.german;
                    }
                    break;
                    default:
                    {
                        currentLanguage = language.english;
                        // Create an entry in the protocoll file that the language could not be retrieved
                    }
                    break;
                }
            }
            else
            {
                fileHandling_Ini = new FileHandling_Ini("config/Settings.ini");

                if (!Directory.Exists("config"))
                {
                    Directory.CreateDirectory("config");
                }

                fileHandling_Ini.IniWriteValue("Application Settings", "Language", "English", true);
            }
        }


        private void CreateCalendarDays()
        {
            daySurface = new List<DaySurface>();

            // Clear the whole calendar view
            DayHolder.Controls.Clear();

            int daysInMonth = DateTime.DaysInMonth(yearHolder, monthHolder);
            int linecounter = 0;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    DaySurface day = new DaySurface(this, linecounter + 1);

                    day.BackColor = Color.Transparent;
                    day.SetDayForecolor = Color.White;
                    day.SelectionIndex = linecounter;

                    if (linecounter < 7)
                    {
                        day.Top = 30;

                        if (linecounter == 0)
                        {
                            day.Left = 10;
                        }
                        else
                        {
                            day.Left = DayHolder.Controls[linecounter - 1].Left + 52;
                        }
                    }
                    else if ((linecounter >= 7) && (linecounter < 14))
                    {
                        day.Top = 82;

                        if (linecounter == 7)
                        {
                            day.Left = 10;
                        }
                        else
                        {
                            day.Left = DayHolder.Controls[linecounter - 8].Left + 52;
                        }
                    }
                    else if ((linecounter >= 14) && (linecounter < 21))
                    {
                        day.Top = 134;

                        if (linecounter == 14)
                        {
                            day.Left = 10;
                        }
                        else
                        {
                            day.Left = DayHolder.Controls[linecounter - 8].Left + 52;
                        }
                    }
                    else if ((linecounter >= 21) && (linecounter < 28))
                    {
                        day.Top = 186;

                        if (linecounter == 21)
                        {
                            day.Left = 10;
                        }
                        else
                        {
                            day.Left = DayHolder.Controls[linecounter - 8].Left + 52;
                        }
                    }
                    else if ((linecounter >= 28) && (linecounter < 35))
                    {
                        day.Top = 238;

                        if (linecounter == 28)
                        {
                            day.Left = 10;
                        }
                        else
                        {
                            day.Left = DayHolder.Controls[linecounter - 8].Left + 52;
                        }
                    }
                    else if ((linecounter >= 35) && (linecounter < 42))
                    {
                        day.Top = 290;

                        if (linecounter == 35)
                        {
                            day.Left = 10;
                        }
                        else
                        {
                            day.Left = DayHolder.Controls[linecounter - 8].Left + 52;
                        }
                    }

                    linecounter++;

                    daySurface.Add(day);
                    DayHolder.Controls.Add(day);
                }
            }

            // Add titles
            for (int l = 0; l < 7; l++)
            {
                weekDays[l] = new Label();
                weekDays[l].AutoSize = true;
                weekDays[l].ForeColor = Color.White;
                weekDays[l].Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                weekDays[l].Top = 10;
                DayHolder.Controls.Add(weekDays[l]);
            }

            // Set the week titles
            SetWeekTitles();

            // Completley refill the calendar
            FillCalendar();
        }


        public void SetWeekTitles()
        {
            weekDays[0].Text = Localization.strings.Weekday_Monday;
            weekDays[0].Left = 10 + ((52 - weekDays[0].Width) / 2);
            weekDays[1].Text = Localization.strings.Weekday_Tuesday;
            weekDays[1].Left = 62 + ((52 - weekDays[0].Width) / 2);
            weekDays[2].Text = Localization.strings.Weekday_Wednesday;
            weekDays[2].Left = 114 + ((52 - weekDays[0].Width) / 2);
            weekDays[3].Text = Localization.strings.Weekday_Thursday;
            weekDays[3].Left = 166 + ((52 - weekDays[0].Width) / 2);
            weekDays[4].Text = Localization.strings.Weekday_Friday;
            weekDays[4].Left = 218 + ((52 - weekDays[0].Width) / 2);
            weekDays[5].Text = Localization.strings.Weekday_Saturday;
            weekDays[5].Left = 270 + ((52 - weekDays[0].Width) / 2);
            weekDays[6].Text = Localization.strings.Weekday_Sunday;
            weekDays[6].Left = 322 + ((52 - weekDays[0].Width) / 2);
        }


        private void FillCalendar()
        {
            string dayOfWeek = new DateTime(yearHolder, monthHolder, 1).DayOfWeek.ToString().Substring(0, 2);

            int daysLastMonth = DateTime.DaysInMonth(yearHolder - 1, (monthHolder == 1 ? 12 : monthHolder - 1));
            int daysCurrentMonth = DateTime.DaysInMonth(yearHolder, monthHolder);

            int daysNextMonth = 1;

            switch (dayOfWeek)
            {
                case "Mo":      // German & English
                {
                    // Days of the current month
                    for (int j = 0; j < daysCurrentMonth; j++)
                    {
                        daySurface[j].DisplayedDay = j + 1;
                        daySurface[j].Month = monthHolder;
                        daySurface[j].Year = yearHolder;

                        daySurface[j].SetDayForecolor = Color.White;

                        // Clear everything
                        daySurface[j].ClearDatabaseMark();
                        daySurface[j].ClearCurrentDay();
                        daySurface[j].ClearSelection();

                        // Check what is the current day
                        if ((j + 1) == DateTime.Today.Day)
                        {
                            if (new DateTime(yearHolder, monthHolder, j + 1).ToString("dd.MM.yyyy") == DateTime.Today.ToString("dd.MM.yyyy"))
                            {
                                currentDayIndex = j;
                                daySurface[j].SetCurrentDay();
                            }
                        }
                    }

                    // Days of the following month
                    int leftDays = 42 - daysCurrentMonth;

                    for (int k = (42 - leftDays); k < 42; k++)
                    {
                        daySurface[k].DisplayedDay = daysNextMonth;
                        daySurface[k].Month = monthHolder + 1;
                        daySurface[k].Year = yearHolder;

                        daySurface[k].SetDayForecolor = Color.FromArgb(100, 100, 101);

                        daySurface[k].ClearDatabaseMark();
                        daySurface[k].ClearCurrentDay();
                        daySurface[k].ClearSelection();

                        daysNextMonth++;
                    }
                }
                break;
                case "Di":      // German
                case "Tu":      // English
                {
                    // Days of last month
                    daySurface[0].DisplayedDay = daysLastMonth;
                    daySurface[0].Month = monthHolder - 1;
                    daySurface[0].Year = yearHolder;

                    daySurface[0].SetDayForecolor = Color.FromArgb(100, 100, 101);

                    daySurface[0].ClearDatabaseMark();
                    daySurface[0].ClearCurrentDay();
                    daySurface[0].ClearSelection();


                    // Days of the current month
                    for (int j = 1; j <= (daysCurrentMonth + 1); j++)
                    {
                        daySurface[j].DisplayedDay = j;
                        daySurface[j].Month = monthHolder;
                        daySurface[j].Year = yearHolder;

                        daySurface[j].SetDayForecolor = Color.White;

                        // Clear everything
                        daySurface[j].ClearDatabaseMark();
                        daySurface[j].ClearCurrentDay();
                        daySurface[j].ClearSelection();

                        // Check what is the current day
                        if (j == DateTime.Today.Day)
                        {
                            if (new DateTime(yearHolder, monthHolder, j).ToString("dd.MM.yyyy") == DateTime.Today.ToString("dd.MM.yyyy"))
                            {
                                currentDayIndex = j;
                                daySurface[j].SetCurrentDay();
                            }
                        }
                    }

                    // Days of the following month
                    int leftDays = 42 - (daysCurrentMonth + 1);

                    for (int k = (42 - leftDays); k < 42; k++)
                    {
                        daySurface[k].DisplayedDay = daysNextMonth;
                        daySurface[k].Month = monthHolder + 1;
                        daySurface[k].Year = yearHolder;

                        daySurface[k].SetDayForecolor = Color.FromArgb(100, 100, 101);

                        daySurface[k].ClearDatabaseMark();
                        daySurface[k].ClearCurrentDay();
                        daySurface[k].ClearSelection();

                        daysNextMonth++;
                    }
                }
                break;
                case "Mi":      // German
                case "We":      // English
                {
                    daysLastMonth--;

                    // Days of last month
                    for (int i = 0; i <= 1; i++)
                    {
                        daySurface[i].DisplayedDay = daysLastMonth;
                        daySurface[i].Month = monthHolder - 1;
                        daySurface[i].Year = yearHolder;

                        daySurface[i].SetDayForecolor = Color.FromArgb(100, 100, 101);

                        daySurface[i].ClearDatabaseMark();
                        daySurface[i].ClearCurrentDay();
                        daySurface[i].ClearSelection();

                        daysLastMonth++;
                    }

                    // Days of the current month
                    for (int j = 2; j <= (daysCurrentMonth + 2); j++)
                    {
                        daySurface[j].DisplayedDay = j - 1;
                        daySurface[j].Month = monthHolder;
                        daySurface[j].Year = yearHolder;

                        daySurface[j].SetDayForecolor = Color.White;

                        // Clear everything
                        daySurface[j].ClearDatabaseMark();
                        daySurface[j].ClearCurrentDay();
                        daySurface[j].ClearSelection();

                        // Check what is the current day
                        if ((j - 1) == DateTime.Today.Day)
                        {
                            if (new DateTime(yearHolder, monthHolder, j - 1).ToString("dd.MM.yyyy") == DateTime.Today.ToString("dd.MM.yyyy"))
                            {
                                currentDayIndex = j;
                                daySurface[j].SetCurrentDay();
                            }
                        }
                    }

                    // Days of the following month
                    int leftDays = 42 - (daysCurrentMonth + 2);

                    for (int k = (42 - leftDays); k < 42; k++)
                    {
                        daySurface[k].DisplayedDay = daysNextMonth;
                        daySurface[k].Month = monthHolder + 1;
                        daySurface[k].Year = yearHolder;

                        daySurface[k].SetDayForecolor = Color.FromArgb(100, 100, 101);

                        daySurface[k].ClearDatabaseMark();
                        daySurface[k].ClearCurrentDay();
                        daySurface[k].ClearSelection();

                        daysNextMonth++;
                    }
                }
                break;
                case "Do":      // German
                case "Th":      // English
                {
                    daysLastMonth -= 2;

                    // Days of last month
                    for (int i = 0; i <= 2; i++)
                    {
                        daySurface[i].DisplayedDay = daysLastMonth;
                        daySurface[i].Month = monthHolder - 1;
                        daySurface[i].Year = yearHolder;

                        daySurface[i].SetDayForecolor = Color.FromArgb(100, 100, 101);

                        daySurface[i].ClearDatabaseMark();
                        daySurface[i].ClearCurrentDay();
                        daySurface[i].ClearSelection();

                        daysLastMonth++;
                    }

                    // Days of the current month
                    for (int j = 3; j <= (daysCurrentMonth + 3); j++)
                    {
                        daySurface[j].DisplayedDay = j - 2;
                        daySurface[j].Month = monthHolder;
                        daySurface[j].Year = yearHolder;

                        daySurface[j].SetDayForecolor = Color.White;

                        // Clear everything
                        daySurface[j].ClearDatabaseMark();
                        daySurface[j].ClearCurrentDay();
                        daySurface[j].ClearSelection();

                        // Check what is the current day
                        if ((j - 2) == DateTime.Today.Day)
                        {
                            if (new DateTime(yearHolder, monthHolder, j - 2).ToString("dd.MM.yyyy") == DateTime.Today.ToString("dd.MM.yyyy"))
                            {
                                currentDayIndex = j;
                                daySurface[j].SetCurrentDay();
                            }
                        }
                    }

                    // Days of the following month
                    int leftDays = 42 - (daysCurrentMonth + 3);

                    for (int k = (42 - leftDays); k < 42; k++)
                    {
                        daySurface[k].DisplayedDay = daysNextMonth;
                        daySurface[k].Month = monthHolder + 1;
                        daySurface[k].Year = yearHolder;

                        daySurface[k].SetDayForecolor = Color.FromArgb(100, 100, 101);

                        daySurface[k].ClearDatabaseMark();
                        daySurface[k].ClearCurrentDay();
                        daySurface[k].ClearSelection();

                        daysNextMonth++;
                    }
                }
                break;
                case "Fr":      // German & English
                {
                    daysLastMonth -= 3;

                    // Days of last month
                    for (int i = 0; i <= 3; i++)
                    {
                        daySurface[i].DisplayedDay = daysLastMonth;
                        daySurface[i].Month = monthHolder - 1;
                        daySurface[i].Year = yearHolder;

                        daySurface[i].SetDayForecolor = Color.FromArgb(100, 100, 101);

                        daySurface[i].ClearDatabaseMark();
                        daySurface[i].ClearCurrentDay();
                        daySurface[i].ClearSelection();

                        daysLastMonth++;
                    }

                    // Days of the current month
                    for (int j = 4; j <= (daysCurrentMonth + 4); j++)
                    {
                        daySurface[j].DisplayedDay = j - 3;
                        daySurface[j].Month = monthHolder;
                        daySurface[j].Year = yearHolder;

                        daySurface[j].SetDayForecolor = Color.White;

                        // Clear everything
                        daySurface[j].ClearDatabaseMark();
                        daySurface[j].ClearCurrentDay();
                        daySurface[j].ClearSelection();

                        // Check what is the current day
                        if ((j - 3) == DateTime.Today.Day)
                        {
                            if (new DateTime(yearHolder, monthHolder, j - 3).ToString("dd.MM.yyyy") == DateTime.Today.ToString("dd.MM.yyyy"))
                            {
                                currentDayIndex = j;
                                daySurface[j].SetCurrentDay();
                            }
                        }
                    }

                    // Days of the following month
                    int leftDays = 42 - (daysCurrentMonth + 4);

                    for (int k = (42 - leftDays); k < 42; k++)
                    {
                        daySurface[k].DisplayedDay = daysNextMonth;
                        daySurface[k].Month = monthHolder + 1;
                        daySurface[k].Year = yearHolder;

                        daySurface[k].SetDayForecolor = Color.FromArgb(100, 100, 101);

                        daySurface[k].ClearDatabaseMark();
                        daySurface[k].ClearCurrentDay();
                        daySurface[k].ClearSelection();

                        daysNextMonth++;
                    }
                }
                break;
                case "Sa":      // German & English
                {
                    daysLastMonth -= 4;

                    // Days of last month
                    for (int i = 0; i <= 4; i++)
                    {
                        daySurface[i].DisplayedDay = daysLastMonth;
                        daySurface[i].Month = monthHolder - 1;
                        daySurface[i].Year = yearHolder;

                        daySurface[i].SetDayForecolor = Color.FromArgb(100, 100, 101);

                        daySurface[i].ClearDatabaseMark();
                        daySurface[i].ClearCurrentDay();
                        daySurface[i].ClearSelection();

                        daysLastMonth++;
                    }

                    // Days of the current month
                    for (int j = 5; j <= (daysCurrentMonth + 5); j++)
                    {
                        daySurface[j].DisplayedDay = j - 4;
                        daySurface[j].Month = monthHolder;
                        daySurface[j].Year = yearHolder;

                        daySurface[j].SetDayForecolor = Color.White;

                        // Clear everything
                        daySurface[j].ClearDatabaseMark();
                        daySurface[j].ClearCurrentDay();
                        daySurface[j].ClearSelection();

                        // Check what is the current day
                        if ((j - 4) == DateTime.Today.Day)
                        {
                            if (new DateTime(yearHolder, monthHolder, j - 4).ToString("dd.MM.yyyy") == DateTime.Today.ToString("dd.MM.yyyy"))
                            {
                                currentDayIndex = j;
                                daySurface[j].SetCurrentDay();
                            }
                        }
                    }

                    // Days of the following month
                    int leftDays = 42 - (daysCurrentMonth + 5);

                    for (int k = (42 - leftDays); k < 42; k++)
                    {
                        daySurface[k].DisplayedDay = daysNextMonth;
                        daySurface[k].Month = monthHolder + 1;
                        daySurface[k].Year = yearHolder;

                        daySurface[k].SetDayForecolor = Color.FromArgb(100, 100, 101);

                        daySurface[k].ClearDatabaseMark();
                        daySurface[k].ClearCurrentDay();
                        daySurface[k].ClearSelection();

                        daysNextMonth++;
                    }
                }
                break;
                case "So":      // German
                case "Su":      // English
                {
                    daysLastMonth -= 5;

                    // Days of last month
                    for (int i = 0; i <= 5; i++)
                    {
                        daySurface[i].DisplayedDay = daysLastMonth;
                        daySurface[i].Month = monthHolder - 1;
                        daySurface[i].Year = yearHolder;

                        daySurface[i].SetDayForecolor = Color.FromArgb(100, 100, 101);

                        daySurface[i].ClearDatabaseMark();
                        daySurface[i].ClearCurrentDay();
                        daySurface[i].ClearSelection();

                        daysLastMonth++;
                    }

                    // Days of the current month
                    for (int j = 6; j <= (daysCurrentMonth + 6); j++)
                    {
                        daySurface[j].DisplayedDay = j - 5;
                        daySurface[j].Month = monthHolder;
                        daySurface[j].Year = yearHolder;

                        daySurface[j].SetDayForecolor = Color.White;

                        // Clear everything
                        daySurface[j].ClearDatabaseMark();
                        daySurface[j].ClearCurrentDay();
                        daySurface[j].ClearSelection();

                        // Check what is the current day
                        if ((j - 5) == DateTime.Today.Day)
                        {
                            if (new DateTime(yearHolder, monthHolder, j - 5).ToString("dd.MM.yyyy") == DateTime.Today.ToString("dd.MM.yyyy"))
                            {
                                currentDayIndex = j;
                                daySurface[j].SetCurrentDay();
                            }
                        }
                    }

                    // Days of the following month
                    int leftDays = 42 - (daysCurrentMonth + 6);

                    if (yearHolder == 2199 && monthHolder == 12)
                    {
                        for (int k = (42 - leftDays); k < 42; k++)
                        {
                            daySurface[k].DisplayedDay = -1;
                            daySurface[k].Month = monthHolder + 1;
                            daySurface[k].Year = yearHolder;

                            daySurface[k].SetDayForecolor = Color.Transparent;

                            daySurface[k].ClearDatabaseMark();
                            daySurface[k].ClearCurrentDay();
                            daySurface[k].ClearSelection();

                            daysNextMonth++;
                        }
                    }
                    else
                    {
                        for (int k = (42 - leftDays); k < 42; k++)
                        {
                            daySurface[k].DisplayedDay = daysNextMonth;
                            daySurface[k].Month = monthHolder + 1;
                            daySurface[k].Year = yearHolder;

                            daySurface[k].SetDayForecolor = Color.FromArgb(100, 100, 101);

                            daySurface[k].ClearDatabaseMark();
                            daySurface[k].ClearCurrentDay();
                            daySurface[k].ClearSelection();

                            daysNextMonth++;
                        }
                    }
                }
                break;
                default:
                    break;
            }

            MarkDayIfMealInDatabase();
        }

        public void MarkDayIfMealInDatabase()
        {
            for (int a = 0; a < daySurface.Count; a++)
            {
                if (daySurface[a].hasFoodInDatabasePublic)
                {
                    daySurface[a].ClearDatabaseMark();
                }
            }

            // Color a day if it has food in the database
            for (int i = 0; i < dayOverviewLayout.mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows.Count; i++)
            {
                DateTime bufferDate = new DateTime();
                bufferDate = DateTime.Parse(dayOverviewLayout.mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][1].ToString());

                for (int j = 0; j < daySurface.Count; j++)
                {
                    if (bufferDate.ToString("dd.MM.yyyy") == (daySurface[j].DisplayedDay.ToString("00") + "." + daySurface[j].Month.ToString("00") + "." + daySurface[j].Year.ToString("0000")))
                    {
                        daySurface[j].SetFoodInDatabase();
                    }
                }
            }
        }


        public void ResetSelection()
        {
            for (int i = 0; i < (daySurface.Count - 1); i++)
            {
                if (lastSelectedDayIndex != daySurface[i].SelectionIndex)
                {
                    daySurface[i].ClearSelection();
                }

                if (!daySurface[i].isCurrentDayPublic)
                {
                    daySurface[i].ClearCurrentDay();
                }
            }
            //foreach (DaySurface day in daySurface)
            //{

            //    day.ClearSelection();
            //    return;
            //    if (lastSelectedDayIndex != day.SelectionIndex)
            //    {
            //        day.ClearSelection();
            //    }
            //}
        }


        private void MainMenu_Resize(object sender, EventArgs e)
        {
            TopBar.Left = 0;
            TopBar.Top = 0;
            TopBar.Width = this.ClientSize.Width;
            TopBar.Height = 40;

            MiddleBar.Left = 0;
            MiddleBar.Top = TopBar.Top + TopBar.Height;
            MiddleBar.Width = this.ClientSize.Width;
            MiddleBar.Height = 40;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (yearHolder == 1917 && monthHolder == 1)
            {
                return;
            }

            if (monthHolder == 1)
            {
                yearHolder--;
                monthHolder = 12;

                CurrentYear.Text = yearHolder.ToString();
                CurrentMonth.Text = new DateTime(yearHolder, monthHolder, 1).ToString("MMMMM yyyy");
            }
            else if (monthHolder > 1)
            {
                monthHolder--;
                CurrentMonth.Text = new DateTime(yearHolder, monthHolder, 1).ToString("MMMMM yyyy");
            }

            // Completley refill the calendar
            FillCalendar();

            // Reset the selected day nutrition
            ProteinSumSelected.Text = "-";
            FatsSumSelected.Text = "-";
            CarbohydratesSumSelected.Text = "-";
            CaloriesSumSelected.Text = "-";

            lastSelectedDayIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (yearHolder == 2199 && monthHolder == 12)
            {
                return;
            }

            if (monthHolder == 12)
            {
                yearHolder++;
                monthHolder = 1;

                CurrentYear.Text = yearHolder.ToString();
                CurrentMonth.Text = new DateTime(yearHolder, monthHolder, 1).ToString("MMMMM yyyy");
            }
            else if (monthHolder < 12)
            {
                monthHolder++;
                CurrentMonth.Text = new DateTime(yearHolder, monthHolder, 1).ToString("MMMMM yyyy");
            }

            // Completley refill the calendar
            FillCalendar();

            // Reset the selected day nutrition
            ProteinSumSelected.Text = "-";
            FatsSumSelected.Text = "-";
            CarbohydratesSumSelected.Text = "-";
            CaloriesSumSelected.Text = "-";

            lastSelectedDayIndex = 0;
        }

        private void CurrentDay_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lastSelectedDayIndex.ToString());
            if ((yearHolder != DateTime.Now.Year) || (monthHolder != DateTime.Now.Month))
            {
                yearHolder = DateTime.Today.Year;
                monthHolder = DateTime.Today.Month;

                CurrentYear.Text = yearHolder.ToString();
                CurrentMonth.Text = DateTime.Now.ToString("MMMM yyyy");

                // Completley refill the calendar
                FillCalendar();

                daySurface[currentDayIndex].SetCurrentDay();

                lastSelectedDayIndex = currentDayIndex;
            }
            else
            {
                daySurface[currentDayIndex].SetCurrentDay();

                lastSelectedDayIndex = currentDayIndex;
            }

        }

        private void ChangeDaily_Click(object sender, EventArgs e)
        {
            bmr_DailyCalorieCalculate = new BMR_DailyCalorieCalculate();


            bmr_DailyCalorieCalculate.FormClosing += new FormClosingEventHandler(bmr_DailyCalorieCalculate_FormClosed);

            bmr_DailyCalorieCalculate.ShowDialog();
        }

        private void bmr_DailyCalorieCalculate_FormClosed(object sender, FormClosingEventArgs e)
        {
            bmr_DailyCalorieCalculate = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dayOverviewLayout.Tag = "this is a test";
            MessageBox.Show(dayOverviewLayout.Tag.ToString());
        }

        private void Options_Click(object sender, EventArgs e)
        {
            optionsMenu = new OptionsMenu();

            optionsMenu.MainMenuPublic = this;
            optionsMenu.FormClosing += new FormClosingEventHandler(optionsMenu_FormClosed);
            optionsMenu.Owner = this;
            optionsMenu.Text = "Einstellungen";

            optionsMenu.ShowDialog();
        }

        private void optionsMenu_FormClosed(object sender, FormClosingEventArgs e)
        {
            optionsMenu = null;
        }
    }



    public class DaySurface : Panel
    {
        // Classes
        private MainMenu mainMenu;
        private DayOverview dayOverviewLayout;

        private Label DayText = new Label();

        private bool hasFoodInDatabase = false;
        private bool isCurrentDay = false;

        public bool hasFoodInDatabasePublic
        {
            get { return hasFoodInDatabase; }
        }

        public bool isCurrentDayPublic
        {
            get { return isCurrentDay; }
        }

        private int year;
        private int month;
        private int selectionIndex;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        public int SelectionIndex
        {
            get { return selectionIndex; }
            set { selectionIndex = value; }
        }

        public int DisplayedDay
        {
            get { return int.Parse(DayText.Text); }
            set
            {
                DayText.AutoSize = true;

                if (value != -1)
                {
                    DayText.Text = value.ToString();
                }
                else
                {
                    DayText.Text = "";
                }
                DayText.Left = (this.Width - DayText.Width) / 2;
                DayText.Top = (this.Height - DayText.Height) / 2;
            }
        }

        public Color SetDayForecolor
        {
            get { return DayText.ForeColor; }
            set { DayText.ForeColor = value; }
        }

        private enum paintingState
        {
            mouseOver,
            mouseLeft,
            mouseDown,
            mouseUp,
            clearSelection
        }

        private paintingState finalState = paintingState.mouseLeft;

        public DaySurface(MainMenu _PassedMainMenu, int _PassedDay)
        {
            mainMenu = _PassedMainMenu;

            this.Controls.Add(DayText);

            this.Width = 50;
            this.Height = 50;

            DayText.AutoSize = true;
            DayText.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            DayText.Text = _PassedDay.ToString();

            DayText.Left = (this.Width - DayText.Width) / 2;
            DayText.Top = (this.Height - DayText.Height) / 2;

            // Label events
            DayText.MouseEnter += new EventHandler(Day_MouseEnter);
            DayText.MouseLeave += new EventHandler(Day_MouseLeave);
            DayText.MouseDown += new MouseEventHandler(Day_MouseDown);
            DayText.MouseUp += new MouseEventHandler(Day_MouseUp);
            DayText.DoubleClick += new EventHandler(Day_DoubleClick);

            // Panel events
            this.MouseEnter += new EventHandler(Day_MouseEnter);
            this.MouseLeave += new EventHandler(Day_MouseLeave);
            this.MouseDown += new MouseEventHandler(Day_MouseDown);
            this.MouseUp += new MouseEventHandler(Day_MouseUp);
            this.DoubleClick += new EventHandler(Day_DoubleClick);
        }

        private void DisplayNutrition()
        {
            if (hasFoodInDatabase)
            {
                DateTime bufferDate = new DateTime();
                float protein = 0;
                float fat = 0;
                float carbohydrate = 0;
                float calories = 0;

                for (int i = 0; i < mainMenu.dayOverviewLayoutPublic.mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows.Count; i++)
                {
                    bufferDate = DateTime.Parse(mainMenu.dayOverviewLayoutPublic.mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][1].ToString());

                    if (new DateTime(year, month, int.Parse(DayText.Text)).ToString("dd.MM.yyyy") == bufferDate.ToString("dd.MM.yyyy"))
                    {
                        protein += float.Parse(mainMenu.dayOverviewLayoutPublic.mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][4].ToString());
                        fat += float.Parse(mainMenu.dayOverviewLayoutPublic.mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][5].ToString());
                        carbohydrate += float.Parse(mainMenu.dayOverviewLayoutPublic.mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][6].ToString());
                        calories += float.Parse(mainMenu.dayOverviewLayoutPublic.mealPerDayDatabaseDataSet.MealPerDayDatabase.Rows[i][7].ToString());
                    }
                }

                if ((protein + fat + carbohydrate + calories) > 0)
                {
                    mainMenu.ProteinSumSelectedPublic.Text = protein.ToString();
                    mainMenu.FatsSumSelectedPublic.Text = fat.ToString();
                    mainMenu.CarbohydratesSumSelectedPublic.Text = carbohydrate.ToString();
                    mainMenu.CaloriesSumSelectedPublic.Text = calories.ToString();
                }
            }
            else
            {
                mainMenu.ProteinSumSelectedPublic.Text = "-";
                mainMenu.FatsSumSelectedPublic.Text = "-";
                mainMenu.CarbohydratesSumSelectedPublic.Text = "-";
                mainMenu.CaloriesSumSelectedPublic.Text = "-";
            }
        }

        public void ClearSelection()
        {
            finalState = paintingState.clearSelection;
            this.Refresh();
        }

        public void SetFoodInDatabase()
        {
            hasFoodInDatabase = true;
            this.Refresh();
        }

        public void ClearDatabaseMark()
        {
            hasFoodInDatabase = false;
            this.Refresh();
        }

        public void SetCurrentDay()
        {
            isCurrentDay = true;
            this.Refresh();
        }

        public void ClearCurrentDay()
        {
            isCurrentDay = false;
            this.Refresh();
        }

        // Label events
        private void Day_MouseEnter(object sender, EventArgs e)
        {
            finalState = paintingState.mouseOver;
            this.Refresh();
        }

        private void Day_MouseLeave(object sender, EventArgs e)
        {
            finalState = paintingState.mouseLeft;
            this.Refresh();
        }

        private void Day_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                finalState = paintingState.mouseDown;

                this.Refresh();
                mainMenu.lastSelectedDayIndexPublic = selectionIndex;
            }

            DisplayNutrition();
        }

        private void Day_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                finalState = paintingState.mouseUp;
                mainMenu.ResetSelection();
                this.Refresh();
            }
        }

        private void Day_DoubleClick(object sender, EventArgs e)
        {
            // Create the form to choose the meal from
            dayOverviewLayout = new DayOverview();

            dayOverviewLayout.FillDatabaseAdapter();

            dayOverviewLayout.mainMenu_Layout = mainMenu;
            dayOverviewLayout.passedYearPublic = year;
            dayOverviewLayout.passedMonthPublic = month;
            dayOverviewLayout.passedDayPublic = int.Parse(DayText.Text);
            dayOverviewLayout.Owner = mainMenu;
            dayOverviewLayout.FormClosed += new FormClosedEventHandler(DayOverview_FormClosed);
            dayOverviewLayout.Text = "Tagesübersicht";

            dayOverviewLayout.ShowDialog();
        }

        private void DayOverview_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Reset the local DayOverview
            dayOverviewLayout = null;

            // Loop through each day to check if the day is still in the database
            mainMenu.MarkDayIfMealInDatabase();

            DisplayNutrition();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Pen pen;

            if (hasFoodInDatabase)
            {
                this.BackColor = Color.CornflowerBlue;
            }
            else
            {
                this.BackColor = Color.Transparent;
            }

            if (isCurrentDay)
            {
                pen = new Pen(Color.Green, 4);

                Rectangle rect = this.ClientRectangle;

                e.Graphics.DrawRectangle(pen, rect);
            }

            switch (finalState)
            {
                case paintingState.mouseOver:
                {
                    if (selectionIndex == mainMenu.lastSelectedDayIndexPublic)
                    {
                        pen = new Pen(Color.FromArgb(8, 104, 180), 4);

                        Rectangle rect = this.ClientRectangle;

                        e.Graphics.DrawRectangle(pen, rect);
                    }
                    else
                    {
                        pen = new Pen(Color.FromArgb(127, 127, 127), 4);

                        Rectangle rect = this.ClientRectangle;

                        e.Graphics.DrawRectangle(pen, rect);
                    }
                }
                break;
                case paintingState.mouseLeft:
                {
                    if (!isCurrentDay)
                    {
                        if (selectionIndex == mainMenu.lastSelectedDayIndexPublic)
                        {
                            pen = new Pen(Color.FromArgb(66, 156, 227), 4);

                            Rectangle rect = this.ClientRectangle;

                            e.Graphics.DrawRectangle(pen, rect);
                        }
                        else
                        {
                            pen = new Pen(Color.Transparent, 4);

                            Rectangle rect = this.ClientRectangle;

                            e.Graphics.DrawRectangle(pen, rect);
                        }
                    }
                }
                break;
                case paintingState.mouseDown:
                {
                    if (!isCurrentDay)
                    {
                        if (selectionIndex == mainMenu.lastSelectedDayIndexPublic)
                        {
                            pen = new Pen(Color.FromArgb(5, 112, 199), 4);

                            Rectangle rect = this.ClientRectangle;

                            e.Graphics.DrawRectangle(pen, rect);
                        }
                        else
                        {
                            pen = new Pen(Color.FromArgb(170, 170, 170), 4);

                            Rectangle rect = this.ClientRectangle;

                            e.Graphics.DrawRectangle(pen, rect);
                        }
                    }
                }
                break;
                case paintingState.mouseUp:
                {
                    if (!isCurrentDay)
                    {
                        pen = new Pen(Color.FromArgb(8, 104, 180), 4);

                        Rectangle rect = this.ClientRectangle;

                        e.Graphics.DrawRectangle(pen, rect);
                    }
                }
                break;
                case paintingState.clearSelection:
                {
                    //pen = new Pen(Color.Transparent, 0);

                    //Rectangle rect = this.ClientRectangle;

                    //e.Graphics.DrawRectangle(pen, rect);
                }
                break;
                default:
                    break;
            }

            base.OnPaint(e);
        }
    }
}
