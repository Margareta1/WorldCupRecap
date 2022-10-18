using Library.Models;
using Library.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        private static Team team = new Team();
        private static Cup cup = new Cup();
        private static TeamResult teamResults = new TeamResult();
        public TeamStatisticsWindow(Team t, Cup c)
        {
            team = t;
            cup = c;
            InitializeComponent();
            InitLabels();
        }

        private void InitLabels()
        {
            teamResults = repo.GetResultsForTeam((int)team.Id, cup)[0];
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
    }
}
