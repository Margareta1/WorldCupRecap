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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF
{

    public partial class MainWindow : Window
    {
        private static RepositoryFactory rf = new RepositoryFactory();
        private static IRepository repo = rf.GiveThisManARepository();
        private static Settings settings = repo.GetSettings();
        public Team oppositeTeam = new Team();
        public MainWindow(Team t)
        {
            oppositeTeam = t;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            InitSettings();
            InitResolution();
        }

        private void InitResolution()
        {

            switch (repo.GetResolution())
            {
                case Resolution.Large:
                    WindowState = WindowState.Maximized;
                    WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    //FieldGrid.Width = 600;
                    //FieldGrid.Height = 900;
                    //miniPlayerSize = new Size(50, 50);
                    //miniPlayerMargin = 30;
                    break;

                case Resolution.Medium:
                    WindowState = WindowState.Normal;
                    WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    Width = 1200;
                    Height = 900;
                    //FieldGrid.Width = 400;
                    //FieldGrid.Height = 600;
                    //miniPlayerSize = new Size(40, 40);
                    //miniPlayerMargin = 20;
                    break;

                case Resolution.Small:
                    WindowState = WindowState.Normal;
                    WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    Width = 800;
                    Height = 600;
                    //FieldGrid.Width = 250;
                    //FieldGrid.Height = 375;
                    //miniPlayerSize = new Size(25, 25);
                    //miniPlayerMargin = 10;
                    break;
                default:
                    WindowState = WindowState.Maximized;
                    WindowStyle = WindowStyle.None;
                    WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    //FieldGrid.Width = 600;
                    //FieldGrid.Height = 900;
                    //miniPlayerSize = new Size(50, 50);
                    //miniPlayerMargin = 30;
                    break;
            }
        }

        private void InitSettings()
        {
            CultureInfo culture = new CultureInfo(settings.LanguageChoice == Library.Models.Language.Croatian ? "hr" : "en");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();

        }
    }
}
