using Library.Models;
using Library.Repository;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF
{
    public partial class EntryWindow : Window
    {

        private static IRepository repo = RepositoryFactory.GiveThisManARepository();
        private static Settings settings;
        public EntryWindow()
        {
            InitializeComponent();
            
        }
        private void CallSettings()
        {
            try
            {
                settings = repo.GetSettings();

            }
            catch (Exception)
            {
                settings = new Settings();
                settings.LanguageChoice = Library.Models.Language.Croatian;
                settings.CupChoice = Cup.Female;
                settings.FavoriteTeam = repo.GetWomensTeams()[0];
                IList<Player> players = repo.GetPlayersForTeam(Cup.Female, (int)settings.FavoriteTeam.Id);
                Player first = new Player();
                IList<Player> temp = new List<Player>();
                first = players[0];
                temp.Add(first);
                first = players[1];
                temp.Add(first);
                first = players[2]; 
                temp.Add(first);
                settings.FavoritePlayers = temp;
                repo.SetSettings(settings);
            }
        }
        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem item = (ComboBoxItem)cbResolution.SelectedItem;
            Resolution r = new Resolution();
            switch (item.Content.ToString())
            {
                case "Large":
                    r = Resolution.Large;
                    break;
                case "Medium":
                    r = Resolution.Medium;
                    break;
                case "Small":
                    r = Resolution.Small;
                    break;
                default:
                    r = Resolution.Large;
                    break;
            }
            repo.SetResolution(r);
            (new ChooseTeam()).Show();
            this.Hide();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CallSettings();
            InitSettings();
        }

        private void InitSettings()
        {

            CultureInfo culture = new CultureInfo(settings.LanguageChoice == Library.Models.Language.Croatian ? "hr" : "en");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

        }
    }
}
