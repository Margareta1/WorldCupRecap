using Library.Models;
using Library.Repository;

namespace WF
{
    public partial class ChooseFavoriteTeamForm : Form
    {
        private Settings settings = new Settings();
        private static RepositoryFactory rf = new RepositoryFactory();
        private static IRepository repo = rf.GiveThisManARepository();
        public ChooseFavoriteTeamForm(Settings s)
        {
            
            InitializeComponent();
            settings = s;
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
