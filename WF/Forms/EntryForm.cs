using Library.Models;


namespace WF
{
    public partial class EntryForm : Form
    {
        private Settings settings = new Settings();
        public EntryForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnEN.Checked)
            {
                settings.LanguageChoice = Language.English;
            }
            else
            {
                settings.LanguageChoice = Language.Croatian;
            }

            if (btnWomen.Checked)
            {
                settings.CupChoice = Cup.Female;
            }
            else
            {
                settings.CupChoice = Cup.Male;
            }
            this.Hide();
            (new ChooseFavoriteTeamForm(settings)).Show();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
