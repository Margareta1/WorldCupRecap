using Library.Models;
using Library.Repository;
using System.Globalization;

namespace WF
{
    public partial class ChooseFavoritePlayersForm : Form
    {
        private Settings settings = new Settings();
        private static RepositoryFactory rf = new RepositoryFactory();
        private static IRepository repo = rf.GiveThisManARepository();
        public ChooseFavoritePlayersForm(Settings s)
        {
            InitCulture(s);
            InitializeComponent();
            settings = s;
        }
        private void InitCulture(Settings s)
        {
            CultureInfo culture = new CultureInfo(s.LanguageChoice == Language.Croatian ? "hr" : "en");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbFP1.SelectedItem!=null &&cbFP2.SelectedItem!=null && cbFP3.SelectedItem!=null)
            {
                settings.FavoritePlayers = new List<Player>();
                settings.FavoritePlayers.Add((Player)cbFP1.SelectedItem);
                settings.FavoritePlayers.Add((Player)cbFP2.SelectedItem);
                settings.FavoritePlayers.Add((Player)cbFP3.SelectedItem);
                repo.SetSettings(settings);
                (new MainForm()).Show();
                this.Hide();
            }
        }

        private void ChooseFavoritePlayersForm_Load(object sender, EventArgs e)
        {
            GetPlayers();
        }

        private void GetPlayers()
        {
            Team t = settings.FavoriteTeam;
            IList<Player> players = new List<Player>();
            IList<Match> m = repo.GetMatches(settings.CupChoice);
            Match match = m.FirstOrDefault(m => m.HomeTeam.Country == t.Country);
            players = (IList<Player>)match.HomeTeamStatistics.StartingEleven;
            foreach (var item in match.HomeTeamStatistics.Substitutes)
            {
                players.Add(item);
            }
            foreach (var item in players)
            {
                cbFP1.Items.Add(item);
                cbFP2.Items.Add(item);
                cbFP3.Items.Add(item);
            }
        }
    }
}
