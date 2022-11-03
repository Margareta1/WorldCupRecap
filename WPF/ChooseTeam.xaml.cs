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

    public partial class ChooseTeam : Window
    {

        private static IRepository repo = RepositoryFactory.GiveThisManARepository();
        private static Settings settings;
        public ChooseTeam()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem item = (ComboBoxItem)cbOppositeTeam.SelectedItem;
            string tag = item.Tag.ToString();
            Team t = repo.GetTeamByFifaCode(tag, settings.CupChoice);
            (new MainWindow(t)).Show();
            this.Hide();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            settings = repo.GetSettings();
            InitSettings();
            InitComboBox();
        }

        private void InitComboBox()
        {
            IList<Team> teams = new List<Team>();
            Team t = settings.FavoriteTeam;
            IList<Match> allMatches = repo.GetMatches(settings.CupChoice==Cup.Female ? Cup.Female : Cup.Male);
            foreach (var item in allMatches)
            {
                if (item.AwayTeam.Code==t.FifaCode)
                {
                    teams.Add(repo.GetTeamByFifaCode(item.HomeTeam.Code, settings.CupChoice));
                }
                if (item.HomeTeam.Code == t.FifaCode)
                {
                    teams.Add(repo.GetTeamByFifaCode(item.AwayTeam.Code, settings.CupChoice));
                }
            }

            foreach (var item in teams)
            {
                ComboBoxItem it = new ComboBoxItem();
                it.Content = item.Country;
                it.Tag = item.FifaCode;
                if (item==teams[0])
                {
                    it.IsSelected = true;
                }
                cbOppositeTeam.Items.Add(it);
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
