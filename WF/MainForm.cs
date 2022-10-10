using Library.Models;
using Library.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF
{
    public partial class MainForm : Form
    {
        private static RepositoryFactory rf = new RepositoryFactory();
        private static IRepository repo = rf.GiveThisManARepository();
        private static Settings s = repo.GetSettings();
        private static IList<Player> players = repo.GetPlayersForTeam(s.CupChoice, (int)s.FavoriteTeam.Id);
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            InitPlayerControls();
            InitRankings();

        }

        private void InitRankings()
        {

            IList<Player> playersRankedByGoals = RankPlayersByGoals(s.CupChoice, players);
            IList<Player> playersRankedByYellowCards = RankPlayersByYellowCards(s.CupChoice, players);
            IList<Match> matches = repo.GetMatches(s.CupChoice);
            IList<Match> matchesOfTeam = new List<Match>();
            foreach (var item in matches)
            {
                if (item.HomeTeam.Code == s.FavoriteTeam.FifaCode || item.AwayTeam.Code == s.FavoriteTeam.FifaCode)
                {
                    matchesOfTeam.Add(item);
                }
            }
            IList<Match> matchesRankedByAttendance = RankMatchesByAttendance(matchesOfTeam);
            foreach (var item in playersRankedByGoals)
            {
                flpPlayersByScores.Controls.Add(new PlayerRankingControl(item));
            }
            foreach (var item in playersRankedByYellowCards)
            {
                flpPlayersByYC.Controls.Add(new PlayerRankingControl(item));
            }

        }

        private IList<Match> RankMatchesByAttendance(IList<Match> matchesOfTeam)
        {
            List<Match> sortedMatches = (List<Match>)matchesOfTeam;
            sortedMatches.Sort((a, b) => -a.Attendance.CompareTo(b.Attendance));
            return sortedMatches;
        }

        private IList<Player> RankPlayersByYellowCards(Cup cupChoice, IList<Player> players)
        {
            List<Player> p = (List<Player>)players;
            p.Sort((a, b) => -a.YellowCardNumber.CompareTo(b.GoalNumber));
            return p;
        }

        private IList<Player> RankPlayersByGoals(Cup cupChoice, IList<Player> players)
        {
            List<Player> p = (List<Player>)players;
            p.Sort((a, b) => a.GoalNumber.CompareTo(b.GoalNumber));
            return p;
        }

        private void InitPlayerControls()
        {
            IList<Player> tempPlayer = players;
            foreach (var item in s.FavoritePlayers)
            {
                flpFavorites.Controls.Add(new PlayerControl(item));
            }
            

            foreach (var item in tempPlayer)
            {
                flpPlayers.Controls.Add(new PlayerControl(item));
            }
        }
    }
}
