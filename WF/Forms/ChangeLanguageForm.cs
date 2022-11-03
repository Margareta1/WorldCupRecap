using Library.Models;
using Library.Repository;
using System.Globalization;

namespace WF
{


    public partial class ChangeLanguageForm : Form
    {
        private static IRepository repo = RepositoryFactory.GiveThisManARepository();

        public ChangeLanguageForm()
        {
            InitCulture(repo.GetSettings());
            InitializeComponent();
            
        }

        private void InitCulture(Settings s)
        {
            CultureInfo culture = new CultureInfo(s.LanguageChoice == Language.Croatian ? "hr" : "en");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

        }

        private void ChangeLanguageForm_Load(object sender, EventArgs e)
        {
            InitLabel();
        }

        private void InitLabel()
        {
            var settings = repo.GetSettings();
            if (settings.LanguageChoice==Language.English)
            {
                lblSwitch.Text = "Switch to HR?";
            }
            else
            {
                lblSwitch.Text = "Prebaci se na EN?";
            }

        }
    }
}
