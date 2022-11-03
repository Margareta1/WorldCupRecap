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

    public partial class ChangeFavoriteTeamWindow : Window
    {

        private static IRepository repo = RepositoryFactory.GiveThisManARepository();
        private static Cup cup = new Cup();
        private static Settings settings;
        public ChangeFavoriteTeamWindow(Cup c)
        {
            cup = c;
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem item = (ComboBoxItem)cbFavoriteTeam.SelectedItem;
            string tag = item.Tag.ToString();
            Team t = repo.GetTeamByFifaCode(tag, settings.CupChoice);
            settings.FavoriteTeam = t;
            IList<Player> players = repo.GetPlayersForTeam(settings.CupChoice, (int)t.Id);
            Player pl = players[0];
            settings.FavoritePlayers[0] = pl;
            pl = players[0];
            settings.FavoritePlayers[1] = pl;
            pl = players[1];
            settings.FavoritePlayers[2] = pl;
            repo.SetSettings(settings);
            this.Hide();
            (new ChooseTeam()).Show();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            settings = repo.GetSettings();
            InitSettings();
            InitComboBox();
        }

        private void InitComboBox()
        {
            IList<Team> teams = cup == Cup.Female ? repo.GetWomensTeams() : repo.GetMensTeams();
            
            foreach (var item in teams)
            {
                ComboBoxItem it = new ComboBoxItem();
                it.Content = item.Country;
                it.Tag = item.FifaCode;
                if (item == teams[0])
                {
                    it.IsSelected = true;
                }
                cbFavoriteTeam.Items.Add(it);
            }
        }

        private void InitSettings()
        {
            CultureInfo culture = new CultureInfo(settings.LanguageChoice == Library.Models.Language.Croatian ? "hr" : "en");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
        }
    }
}
