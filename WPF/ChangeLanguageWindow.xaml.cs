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
    /// Interaction logic for ChangeLanguageWindow.xaml
    /// </summary>
    public partial class ChangeLanguageWindow : Window
    {
        private static RepositoryFactory rf = new RepositoryFactory();
        private static IRepository repo = rf.GiveThisManARepository();
        private Settings settings = new Settings();
        public ChangeLanguageWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            settings = repo.GetSettings();
            InitLabel();
        }

        private void InitLabel()
        {
            if (settings.LanguageChoice == Library.Models.Language.English)
            {
                lblChange.Content = "Are you sure you want to switch to Croatian?";
            }
            else
            {

                lblChange.Content = "Sigurno se želite prebaciti na engleski?";
            }
        }

        private void btnAccept_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
