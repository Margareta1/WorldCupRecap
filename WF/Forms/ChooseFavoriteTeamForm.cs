using Library.Models;
using Library.Repository;
using System.Globalization;

namespace WF
{
    public partial class ChooseFavoriteTeamForm : Form
    {
        private Settings settings = new Settings();
        private static IRepository repo = RepositoryFactory.GiveThisManARepository();
        public ChooseFavoriteTeamForm(Settings s)
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

        private void GetTeamsSource()
        {
            IList<Team> teams = new List<Team>();
            if (settings.CupChoice==Cup.Male)
            {
                teams = repo.GetMensTeams();
            }
            else
            {
                teams = repo.GetWomensTeams();
            }
            foreach (var item in teams)
            {
                cbTeams.Items.Add(item);
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbTeams.SelectedItem!=null)
            {
                Team t = cbTeams.SelectedItem as Team;
                settings.FavoriteTeam = t;
                (new ChooseFavoritePlayersForm(settings)).Show();
                this.Hide();
            }

        }

        private void ChooseFavoriteTeamForm_Load(object sender, EventArgs e)
        {
            GetTeamsSource();
        }
    }
}
