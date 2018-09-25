using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace FitnessHelper
{
    public partial class OptionsMenu : Form
    {
        // Classes declaration
        private MainMenu mainMenu;
        private AdministrateDatabase administrateDatabase;
        private FileHandling_Ini fileHandling_Ini;

        public MainMenu MainMenuPublic
        {
            get { return mainMenu; }
            set { mainMenu = value; }
        }

        public OptionsMenu()
        {
            InitializeComponent();

            // Events
            this.Load += new EventHandler(OptionsMenu_Load);
        }

        private void OptionsMenu_Load(object sender, EventArgs e)
        {
            // Initialize the settings file
            fileHandling_Ini = new FileHandling_Ini("config/Settings.ini");

            // Set all text regarding the current culture info
            SetLocalisation(false);
        }

        private void SetLocalisation(bool _SkipSettingsInitialization)
        {
            // Initialize the configuration file
            if (!_SkipSettingsInitialization) { InitializeSettingsFile(); }

            this.Text = Localization.strings.OptionsMenuTitle;

            GroupDatabaseAdministration.Text = Localization.strings.OptionsMenu_GroupBox_GroupDatabaseAdministration;
            AdministrateDays.Text = Localization.strings.OptionsMenu_Button_AdministrateDays;
            AdministrateFood.Text = Localization.strings.OptionsMenu_Button_AdministrateFood;

            LanguageSettings.Text = Localization.strings.OptionsMenu_GroupBox_LanguageSettings;
        }

        private void InitializeSettingsFile()
        {
            switch (fileHandling_Ini.IniReadValue("Application Settings", "Language"))
            {
                case "English":
                    {
                        LanguageHolder.Items.Add("English");
                        LanguageHolder.Items.Add("Spanish");
                        LanguageHolder.Items.Add("German");

                        LanguageHolder.Text = LanguageHolder.Items[0].ToString();
                    }
                    break;
                case "German":
                    {
                        LanguageHolder.Items.Add("Englisch");
                        LanguageHolder.Items.Add("Spanisch");
                        LanguageHolder.Items.Add("Deutsch");

                        LanguageHolder.Text = LanguageHolder.Items[2].ToString();
                    }
                    break;
                case "Spanish":
                    {
                        LanguageHolder.Items.Add("Inglés");
                        LanguageHolder.Items.Add("Español");
                        LanguageHolder.Items.Add("Alemán");

                        LanguageHolder.Text = LanguageHolder.Items[1].ToString();
                    }
                    break;
                default:
                    {
                        // Set english as the current language and write it to the settings file
                        Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
                        fileHandling_Ini.IniWriteValue("Application Settings", "Language", "English", false);

                        LanguageHolder.Items.Add("English");
                        LanguageHolder.Items.Add("Spanish");
                        LanguageHolder.Items.Add("German");

                        LanguageHolder.Text = LanguageHolder.Items[0].ToString();
                        // Create an entry in the protocoll file that the language could not be retrieved
                    }
                    break;
            }

        }

        private void AdministratDays_Click(object sender, EventArgs e)
        {
            administrateDatabase = new AdministrateDatabase();

            administrateDatabase.MainMenuPublic = mainMenu;
            administrateDatabase.DatabaseType = AdministrateDatabase.AdministrationType.day;

            administrateDatabase.FormClosed += new FormClosedEventHandler(administrateDatabase_FormClosed);
            administrateDatabase.Text = "Datenbank verwalten";

            administrateDatabase.ShowDialog();
        }

        private void AdministrateFood_Click(object sender, EventArgs e)
        {
            administrateDatabase = new AdministrateDatabase();

            administrateDatabase.MainMenuPublic = mainMenu;
            administrateDatabase.DatabaseType = AdministrateDatabase.AdministrationType.food;

            administrateDatabase.FormClosed += new FormClosedEventHandler(administrateDatabase_FormClosed);
            administrateDatabase.Text = "Datenbank verwalten";

            administrateDatabase.ShowDialog();
        }

        private void administrateDatabase_FormClosed(object sender, FormClosedEventArgs e)
        {
            administrateDatabase = null;
        }


        private void LanguageHolder_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (LanguageHolder.Text)
            {
                case "English":
                case "Inglés":
                case "Englisch":
                    {
                        Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
                        fileHandling_Ini.IniWriteValue("Application Settings", "Language", "English", false);

                        LanguageHolder.Items[0] = "English";
                        LanguageHolder.Items[1] = "Spanish";
                        LanguageHolder.Items[2] = "German";

                        LanguageHolder.Text = LanguageHolder.Items[0].ToString();
                    }
                    break;
                case "Spanish":
                case "Español":
                case "Spanisch":
                    {
                        Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("es-ES");
                        fileHandling_Ini.IniWriteValue("Application Settings", "Language", "Spanish", false);

                        LanguageHolder.Items[0] = "Inglés";
                        LanguageHolder.Items[1] = "Español";
                        LanguageHolder.Items[2] = "Alemán";

                        LanguageHolder.Text = LanguageHolder.Items[1].ToString();
                    }
                    break;
                case "German":
                case "Alemán":
                case "Deutsch":
                    {
                        Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("de-DE");
                        fileHandling_Ini.IniWriteValue("Application Settings", "Language", "German", false);

                        LanguageHolder.Items[0] = "Englisch";
                        LanguageHolder.Items[1] = "Spanisch";
                        LanguageHolder.Items[2] = "Deutsch";

                        LanguageHolder.Text = LanguageHolder.Items[2].ToString();
                    }
                    break;
                default:
                    {
                        // Placeholder - will never be reached
                    }
                    break;
            }

            SetLocalisation(true);
            mainMenu.SetLocalisation();
            mainMenu.SetWeekTitles();
        }
    }
}
