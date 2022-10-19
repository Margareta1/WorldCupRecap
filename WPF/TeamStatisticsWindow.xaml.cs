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
    /// <summary>
    /// Interaction logic for TeamStatisticsWindow.xaml
    /// </summary>
    public partial class TeamStatisticsWindow : Window
    {
        private static RepositoryFactory rf = new RepositoryFactory();
        private static IRepository repo = rf.GiveThisManARepository();
        public Team team = new Team();
        public Cup cup = new Cup();
        public TeamResult teamResults;
        public Settings settings;
        public TeamStatisticsWindow(Team t, Cup c)
        {
            teamResults   = new TeamResult();
            team = t;
            cup = c;
            InitializeComponent();
           
            
        }

        private void SetCulture()
        {
            CultureInfo culture = new CultureInfo(settings.LanguageChoice == Library.Models.Language.Croatian ? "hr" : "en");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
        }

        private void InitLabels()
        {
            teamResults = repo.GetResultsForTeam((int)team.Id, cup).FirstOrDefault(t => t.Country == team.Country);
            
            lbTeamName.Content = teamResults.Country;
            lbTeamFifaCode.Content = teamResults.FifaCode;
            lbTeamPlayedMatches.Content = teamResults.GamesPlayed;
            lbTeamMatchesWon.Content = teamResults.Wins;
            lbTeamMatchesLost.Content = teamResults.Losses;
            lbTeamDraws.Content = teamResults.Draws;
            lbTeamGoalsFor.Content = teamResults.GoalsFor;
            lbTeamGoalsAgainst.Content = teamResults.GoalsAgainst;
            lbTeamGoalDifferential.Content = teamResults.GoalDifferential;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            InitLabels();
            settings = repo.GetSettings();
            SetCulture();

        }
    }
}
