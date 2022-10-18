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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF
{

    public partial class MainWindow : Window
    {
        private static RepositoryFactory rf = new RepositoryFactory();
        private static IRepository repo = rf.GiveThisManARepository();
        private static Settings settings = new Settings();
        public Team oppositeTeam = new Team();
        public Match match = new Match();



        public MainWindow(Team t)
        {
            oppositeTeam = t;
            InitializeComponent();
            CallSettings();
        }

        private void CallSettings()
        {
            try
            {
                settings = repo.GetSettings();
            }
            catch (Exception)
            {
                settings.LanguageChoice = Library.Models.Language.Croatian;
                settings.CupChoice = Cup.Female;
                settings.FavoriteTeam = repo.GetWomensTeams()[0];
                IList<Player> players = repo.GetPlayersForTeam(Cup.Female, (int)settings.FavoriteTeam.Id);
                settings.FavoritePlayers[0] = players[0];
                settings.FavoritePlayers[1] = players[1];
                settings.FavoritePlayers[2] = players[2];
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            InitSettings();
            InitResolution();
            InitLabels();
            InitPlayerControls();

        }

        private void InitPlayerControls()
        {
            foreach (var item in match.AwayTeamStatistics.StartingEleven)
            {
                SetAwayTeamControl(item);
            }
            foreach (var item in match.HomeTeamStatistics.StartingEleven)
            {
                SetHomeTeamControl(item);
            }
        }

        private void SetHomeTeamControl(Player player)
        {
            PlayerControl pc = new PlayerControl(player);

            pc.MouseLeftButtonDown += PlayerControl_MouseLeftButtonDown;
            switch (player.Position)
            {
                case "Goalie":
                    wpHomeGoalie.Children.Add(pc);
                    break;
                case "Defender":
                    wpHomeDefenders.Children.Add(pc);
                    break;
                case "Midfield":
                    wpHomeMidfielders.Children.Add(pc);
                    break;
                case "Forward":
                    wpHomeAttackers.Children.Add(pc);
                    break;
            }
        }
        private void PlayerControl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PlayerControl pc = (PlayerControl)sender;
            PlayerWindow window = new PlayerWindow(pc.player,match);
            window.ShowDialog();
        }

        private void SetAwayTeamControl(Player player)
        {
            PlayerControl pc = new PlayerControl(player);

            pc.MouseLeftButtonDown += PlayerControl_MouseLeftButtonDown;
            switch (player.Position)
            {
                case "Goalie":
                    wpAwayGoalie.Children.Add(pc);
                    break;
                case "Defender":
                    wpAwayDefenders.Children.Add(pc);
                    break;
                case "Midfield":
                    wpAwayMidfielders.Children.Add(pc);
                    break;
                case "Forward":
                    wpAwayAttackers.Children.Add(pc);
                    break;
            }
        }

        private void InitLabels()
        {
            IList<Match> matches = repo.GetMatches(settings.CupChoice);
            bool favoriteTeamIsHome = true;
            match = matches.FirstOrDefault(m=> (m.HomeTeam.Code==oppositeTeam.FifaCode && m.AwayTeam.Code==settings.FavoriteTeam.FifaCode)|| (m.AwayTeam.Code == oppositeTeam.FifaCode && m.HomeTeam.Code == settings.FavoriteTeam.FifaCode));
            lblOppositeTeamName.Content = oppositeTeam.Country;
            lblHomeTeam.Content = settings.FavoriteTeam.Country;
            lblScore.Content = favoriteTeamIsHome==true ? $"{match.HomeTeam.Goals} : {match.AwayTeam.Goals}" : $"{match.AwayTeam.Goals} : {match.HomeTeam.Goals}";
        }

        private void InitResolution()
        {

            switch (repo.GetResolution())
            {
                case Resolution.Large:
                    WindowState = WindowState.Maximized;
                    WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    imgField.Width = 600;
                    imgField.Height = 900;
                    //miniPlayerSize = new Size(50, 50);
                    //miniPlayerMargin = 30;
                    break;

                case Resolution.Medium:
                    WindowState = WindowState.Normal;
                    Width = 1000;
                    Height = 700;                    
                    WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    imgField.Width = 400;
                    imgField.Height = 600;
                    //miniPlayerSize = new Size(40, 40);
                    //miniPlayerMargin = 20;
                    break;

                case Resolution.Small:
                    WindowState = WindowState.Normal;
                    WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    Width = 800;
                    Height = 600;
                    imgField.Width = 250;
                    imgField.Height = 375;
                    //miniPlayerSize = new Size(25, 25);
                    //miniPlayerMargin = 10;
                    break;
                default:
                    WindowState = WindowState.Maximized;
                    WindowStyle = WindowStyle.None;
                    WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    imgField.Width = 600;
                    imgField.Height = 900;
                    //miniPlayerSize = new Size(50, 50);
                    //miniPlayerMargin = 30;
                    break;
            }
        }

        private void InitSettings()
        {
            CultureInfo culture = new CultureInfo(settings.LanguageChoice == Library.Models.Language.Croatian ? "hr" : "en");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();

        }

        private void btnOppositeTeam_Click(object sender, RoutedEventArgs e)
        {
            (new TeamStatisticsWindow(oppositeTeam, settings.CupChoice)).ShowDialog();
        }

        private void btnHomeTeam_Click(object sender, RoutedEventArgs e)
        {
            (new TeamStatisticsWindow(settings.FavoriteTeam, settings.CupChoice)).ShowDialog();
        }

        private void btnChangeHomeTeam_Click(object sender, RoutedEventArgs e)
        {
            (new ChangeFavoriteTeamWindow(settings.CupChoice)).Show();
            this.Hide();
        }

        private void btnChangeLanguage_Click(object sender, RoutedEventArgs e)
        {
            if ((new ChangeLanguageWindow()).ShowDialog() == true)
            {
                ChangeLanguage();
            }
        }

        private void ChangeLanguage()
        {
            CultureInfo culture = new CultureInfo(settings.LanguageChoice == Library.Models.Language.Croatian ? "en" : "hr");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
        }

        private void btnChangeOppositeTeam_Click(object sender, RoutedEventArgs e)
        {
            (new ChooseTeam()).ShowDialog();
            this.Hide();
        }
    }
}
