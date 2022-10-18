using Library.Models;
using Library.Repository;
using System.Globalization;

namespace WF
{
    public partial class MainForm : Form
    {
        private static RepositoryFactory rf = new RepositoryFactory();
        private static IRepository repo = rf.GiveThisManARepository();
        private static Settings s = repo.GetSettings();
        private static IList<Player> players = repo.GetPlayersForTeam(s.CupChoice, (int)s.FavoriteTeam.Id);
        private static IList<Match> matches = repo.GetMatches(s.CupChoice);
        private Font headingFont = new Font("Lucida Console", 14);
        private Font txtFont = new Font("Lucida Console", 10);
        public MainForm()
        {
            InitCulture(s);
            InitializeComponent();
        }
        private void InitCulture(Settings s)
        {
            CultureInfo culture = new CultureInfo(s.LanguageChoice == Language.Croatian ? "hr" : "en");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

        }
        private void MainForm_Load(object sender, EventArgs e)
        {

            InitPlayerControls();
            InitRankings();

        }

        private void InitRankings()
        {
            InitPlayersRankedByGoals();
            InitPlayersRankedByYC();
            InitMatchRankings();

        }

        private void InitMatchRankings()
        {
            IList<Match> matchesOfTeam = new List<Match>();
            foreach (var item in matches)
            {
                if (item.HomeTeam.Code == s.FavoriteTeam.FifaCode || item.AwayTeam.Code == s.FavoriteTeam.FifaCode)
                {
                    matchesOfTeam.Add(item);
                }
            }
            IList<Match> matchesRankedByAttendance = RankMatchesByAttendance(matchesOfTeam);


            foreach (var item in matchesRankedByAttendance)
            {
                flpMatchesByAttendance.Controls.Add(new MatchControl(item));
            }
        }

        private void InitPlayersRankedByYC()
        {
            IList<Player> playersRankedByYellowCards = RankPlayersByYellowCards(s.CupChoice, players);
            foreach (var item in playersRankedByYellowCards)
            {
                flpPlayersByYC.Controls.Add(new PlayerRankingControl(item));
            }
        }

        private void InitPlayersRankedByGoals()
        {
            IList<Player> playersRankedByGoals = RankPlayersByGoals(s.CupChoice, players);
            foreach (var item in playersRankedByGoals)
            {
                flpPlayersByScores.Controls.Add(new PlayerRankingControl(item));
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
            p.Sort((a, b) => -a.YellowCardNumber.CompareTo(b.YellowCardNumber));
            return p;
        }

        private IList<Player> RankPlayersByGoals(Cup cupChoice, IList<Player> players)
        {
            List<Player> p = (List<Player>)players;
            p.Sort((a, b) => -a.GoalNumber.CompareTo(b.GoalNumber));
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

        private void btnChangeLan_Click(object sender, EventArgs e)
        {

            ChangeLanguageForm clf = new ChangeLanguageForm();
            if (clf.ShowDialog() == DialogResult.OK)
            {
                ChangeLanguage();

            }

        }

        private void ChangeLanguage()
        {

            Settings s = repo.GetSettings();
            Settings newSettings = s;
            if (s.LanguageChoice == Language.English)
            {
                newSettings.LanguageChoice = Language.Croatian;


            }
            else
            {
                newSettings.LanguageChoice = Language.English;
            }
            repo.SetSettings(newSettings);
            this.Controls.Clear();
            InitCulture(newSettings);
            InitializeComponent();
            InitPlayerControls();
            InitRankings();

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            var exit = new ExitForm();
            if (exit.ShowDialog() == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void printDocGoalRankings_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float y = e.MarginBounds.Y - 20;
            float x = e.MarginBounds.X;
            int temp = 0;

            e.Graphics.DrawString("Players ranked by goals:", headingFont, Brushes.Black, x, y);
            IList<Player>? tempPlayersGoalsRanked = RankPlayersByGoals(s.CupChoice, players);
            foreach (var player in tempPlayersGoalsRanked)
            {
                e.Graphics.DrawString($"{temp++}.\t" + player.Name + ", " + player.Position + ", shirt:  " + player.ShirtNumber + ", goals: " + player.GoalNumber, txtFont, Brushes.Black, x, y += 25);

            }
        }

        private void printDocYCRankings_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float y = e.MarginBounds.Y - 20;
            float x = e.MarginBounds.X;
            int temp = 0;

            IList<Player> tempPlayersYCRanked = RankPlayersByYellowCards(s.CupChoice, players);
            temp = 0;
            e.Graphics.DrawString("Players ranked by yellow cards:", headingFont, Brushes.Black, x, y += 30);
            foreach (Player player in tempPlayersYCRanked)
            {
                e.Graphics.DrawString($"{temp++}.\t" + player.Name + ", " + player.Position + ", shirt:  " + player.ShirtNumber + ", yellow cards: " + player.YellowCardNumber, txtFont, Brushes.Black, x, y += 20);

            }
        }

        private void printDocAttendance_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float y = e.MarginBounds.Y - 20;
            float x = e.MarginBounds.X;
            int temp = 0;

            IList<Match> matchesOfTeam = new List<Match>();
            foreach (var item in matches)
            {
                if (item.HomeTeam.Code == s.FavoriteTeam.FifaCode || item.AwayTeam.Code == s.FavoriteTeam.FifaCode)
                {
                    matchesOfTeam.Add(item);
                }
            }
            IList<Match> matchesRanked = RankMatchesByAttendance(matchesOfTeam);

            e.Graphics.DrawString("Matches ranked by attendance:", headingFont, Brushes.Black, x, y += 30);
            foreach (Match match in matchesRanked)
            {
                e.Graphics.DrawString($"{temp++}.\t" + match.Location + ", home team: " + match.HomeTeam.Code + ", away team: " + match.AwayTeam.Code + ", attendance: " + match.Attendance, txtFont, Brushes.Black, x, y += 20);

            }
        }

        private void btnPrintAttendance_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocAttendance.Print();
            }
        }

        private void btnPrintYCRankings_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocYCRankings.Print();
            }
        }

        private void btnPrintGoalRankings_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocGoalRankings.Print();
            }
        }
    }
}
