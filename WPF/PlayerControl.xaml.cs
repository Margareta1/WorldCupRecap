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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF
{

    public partial class PlayerControl : UserControl
    {
        private static RepositoryFactory rf = new RepositoryFactory();
        private static IRepository repo = rf.GiveThisManARepository();
        public Player player = new Player();
        private Resolution resolution = new Resolution();

        public PlayerControl(Player p)
        {
            player = p;
            resolution = repo.GetResolution();
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            InitLabel();
            InitResolution();
        }

        private void InitResolution()
        {
            if (resolution == Resolution.Large)
            {
                this.Height = 50;
                this.Width = 50;
            }
            else if (resolution == Resolution.Medium)
            {
                this.Height = 40;
                this.Width = 40;

            }
            else
            {
                this.Height = 30;
                this.Width = 30;
            }
        }

        private void InitLabel()
        {
            lblPlayerNumber.Content = player.ShirtNumber;
        }

    }
}
