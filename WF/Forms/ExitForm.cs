using Library.Models;
using Library.Repository;
using System.Globalization;

namespace WF
{
    public partial class ExitForm : Form
    {
        private static IRepository repository = RepositoryFactory.GiveThisManARepository();
        Settings s = repository.GetSettings();
        public ExitForm()
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
    }
}
