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
    public partial class EntryWindow : Window
    {
        private static RepositoryFactory rf = new RepositoryFactory();
        private static IRepository repo = rf.GiveThisManARepository();
        private static Settings settings = repo.GetSettings();
        public EntryWindow()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem item = (ComboBoxItem)cbResolution.SelectedItem;
            Resolution r = new Resolution();
            switch (item.Content.ToString())
            {
                case "Large":
                    r = Resolution.Large;
                    break;
                case "Medium":
                    r = Resolution.Medium;
                    break;
                case "Small":
                    r = Resolution.Small;
                    break;
                default:
                    r = Resolution.Large;
                    break;
            }
            repo.SetResolution(r);
            (new ChooseTeam()).Show();
            this.Hide();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            InitSettings();
        }

        private void InitSettings()
        {

            CultureInfo culture = new CultureInfo(settings.LanguageChoice == Library.Models.Language.Croatian ? "hr" : "en");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

        }
    }
}
